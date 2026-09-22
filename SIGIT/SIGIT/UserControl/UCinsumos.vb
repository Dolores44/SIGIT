Imports MySqlConnector

Public Class UCinsumos




    Private Sub vaciartxt()
        descripciontxt.Text = ""
        buscartxt.Text = ""

    End Sub


    Private Sub cargarcombocategorias()
        Try
            combocategoria.Items.Clear() 'Limpio el combo para que no se dupliquen los datos
            combocategoria.Items.Add("Todos") 'Pongo la opcion de todos para que el index sea 0
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT ID_Categoria, nombre FROM categoria ORDER BY nombre;"
                Using consulta As New MySqlCommand(sql, cn)

                    Using lector As MySqlDataReader = consulta.ExecuteReader
                        While lector.Read() 'Mientras el lector lea las categorias, las voy agregando al combo
                            combocategoria.Items.Add(lector("nombre").ToString())
                        End While

                        'dios que bonrca la ia me tira fruta y no me acuerdo como desactivar

                    End Using

                End Using
            End Using
            combocategoria.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorias: " & ex.Message)
        End Try


    End Sub
    Private Sub cargarinsumos()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT ID_insumo As ID, ID_categoria As Categoria, descripcion, unidad_medida As `Unidad Medida`, stock_actual As `Stock Actual`, stock_minimo As `Stock minimo`, costo_unitario As `Costo Unitario`, nombre, " &
                                    "CASE " &
                                    " WHEN stock_actual <= stock_minimo Then 'CRITICO' " &
                                    " WHEN stock_actual <= stock_minimo * 1.5 Then 'BAJO' " &
                                    " Else 'DISPONIBLE' END AS ESTADO " &
                                    " FROM insumo WHERE 1=1 " 'El 1=1 es para que siempre se cumpla la condicion, y asi poder agregar mas condiciones con AND sin tener que preocuparme de si es la primera condicion o no"

                'ANOTAR, los TEXTOS POR CASE se usa comilla ', en INVERTIDO se ocupa para poner los AS
                'Osea, que si tiene un 50% mas de lo que indica stock minimo, entonces es bajo
                'un case, pero en consulta!! es muy util esto, lo que hace investigar loco

                'aplico el filtro para buscar segun el usuario
                If buscartxt.Text <> "" Then
                    sql = sql & "AND nombre LIKE @busqueda "
                End If

                ' Filtro de categoria solo se agrega si el combo NO esta en todos, osea el indice 0
                If combocategoria.SelectedIndex > 0 Then
                    sql = sql & "AND ID_categoria = @categoria "
                End If

                sql = sql & "ORDER BY ID_insumo;"


                Dim sqllabel As String = "SELECT COUNT(*) from insumo; " 'para insumos totales

                Using cmd As New MySqlCommand(sql, cn)
                    If buscartxt.Text <> "" Then
                        cmd.Parameters.AddWithValue("@busqueda", "%" & buscartxt.Text & "%")
                    End If
                    'Agrego el parametro de busqueda para el texto

                    If combocategoria.SelectedIndex > 0 Then ' Si es mayor a 0, entonces

                        Dim sqlCategoria As String = "SELECT ID_Categoria FROM categoria WHERE nombre = @nombre" 'Hago una consulta a categoria, sacando el nombre de la cat

                        Using cmdCategoria As New MySqlCommand(sqlCategoria, cn)

                            cmdCategoria.Parameters.AddWithValue("@nombre", combocategoria.SelectedItem.ToString()) 'le adjudico un valor a  nombres, scado del combobox

                            Dim idCategoria As Integer = Convert.ToInt32(cmdCategoria.ExecuteScalar()) 'executescalar devuelve el primer valor, y convierto a integer el ID de categoria, o si no el loquito tira error

                            cmd.Parameters.AddWithValue("@categoria", idCategoria)

                        End Using

                    End If
                    Dim tabla As New DataTable()

                    Using lector As MySqlDataReader = cmd.ExecuteReader()
                        tabla.Load(lector)
                    End Using

                    dgwinsumos.DataSource = tabla
                End Using

                Using cmdlabel As New MySqlCommand(sqllabel, cn)

                    insumostotaleslbl.Text = cmdlabel.ExecuteScalar().ToString() 'pongo el resultado de la consulta en el label
                    'Oculto ID_categoria, porque no es necesario mostrarlo al usuario
                    If (dgwinsumos.Columns.Contains("categoria")) Then 'Si la columna contiene ID_CLIENTE
                        dgwinsumos.Columns("categoria").Visible = False 'entonces, cambiamos la propiedad y lo hacemos invisible
                    End If

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar insumos: " & ex.Message)
        End Try



    End Sub





    Private Sub UCinsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaPers.Personalizargrilla(dgwinsumos)
        cargarcombocategorias() 'primero COMBO,a a tener en cuenta para los siguientes apartados
        cargarinsumos()
        GrillaPers.ColorearEstado(dgwinsumos)

    End Sub


    Private Sub registrarmovi_Click(sender As Object, e As EventArgs) Handles registrarmovi.Click

        Using nuevoform As New UCinsumosañadir()
            nuevoform.ShowDialog()
            cargarcombocategorias()
            'Mientras el nuevoform este abierto 
            cargarinsumos() 'Cuando se cierre el form, recargo la grilla para que se vea el nuevo insumo

        End Using
    End Sub



    Private Sub dgwinsumos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwinsumos.CellFormatting 'El cellformating es para el formato de la celda, intente ponerlo en un modulo y no funciona

        For Each fila As DataGridViewRow In dgwinsumos.Rows 'Un for each para recorrer todas las filas de la grilla, y cambiar el color de la fila según el estado del insumo

            If Not fila.IsNewRow Then 'Esto evita que el 
                Dim cellValue As Object = fila.Cells("estado").Value
                ' Validamos que no esté vacío ni sea nulo
                If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                    Dim estado As String = cellValue.ToString().ToUpper().Trim()
                    Dim backColor As Color = Color.White
                    Dim foreColor As Color = Color.Black
                    ' Determinamos los colores según el estado
                    Select Case estado
                        Case "CRITICO"
                            backColor = Color.FromArgb(248, 215, 218) ' Rojo claro
                            foreColor = Color.FromArgb(132, 32, 41)   ' Rojo fuerte
                        Case "BAJO"
                            backColor = Color.FromArgb(255, 243, 205) ' Amarillo claro
                            foreColor = Color.FromArgb(133, 100, 4)    ' Amarillo oscuro
                        Case "DISPONIBLE"
                            backColor = Color.FromArgb(212, 237, 218) ' Verde claro
                            foreColor = Color.FromArgb(21, 87, 36)    ' Verde oscuro
                    End Select
                    ' APLICAR A TODA LA FILA: Cambiamos el estilo por defecto de la fila
                    fila.DefaultCellStyle.BackColor = backColor
                    fila.DefaultCellStyle.ForeColor = foreColor
                End If


            End If

        Next

    End Sub

    Private Sub dgwinsumos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwinsumos.CellClick
        If e.RowIndex >= 0 Then
            nombreinsumolbl.Text = dgwinsumos.Rows(e.RowIndex).Cells("nombre").Value.ToString()
            descripciontxt.Text = dgwinsumos.Rows(e.RowIndex).Cells("descripcion").Value.ToString()
            stockactuallbl.Text = dgwinsumos.Rows(e.RowIndex).Cells("Stock Actual").Value.ToString()
            stockminlbl.Text = dgwinsumos.Rows(e.RowIndex).Cells("Stock minimo").Value.ToString()

            'Hago una variable de valorizado
            Dim stockactual As Decimal = CDec(stockactuallbl.Text) 'Me paso el valor de stock actual a un decimal, para poder hacer la comparacion
            Dim valorizado As Decimal = CDec(dgwinsumos.Rows(e.RowIndex).Cells("Costo Unitario").Value.ToString()) * stockactual 'Multiplico el costo unitario por el stock actual, para obtener el valorizado)
            stockvalorizadolbl.Text = valorizado.ToString("C") 'Le pongo formato de moneda al valorizado
        End If
    End Sub

    Private Sub dashboardbtn_Click(sender As Object, e As EventArgs) Handles dashboardbtn.Click
        cargarinsumos()

    End Sub

    Private Sub combocategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocategoria.SelectedIndexChanged
        cargarinsumos()
    End Sub
End Class
