Imports MySqlConnector

Public Class UCinsumosañadir


    Private Sub cargarinsumo()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "SELECT ID_insumo AS ID, ID_categoria AS Categoria, descripcion, unidad_medida AS `Unidad Medida`, stock_actual AS `Stock Actual`, stock_minimo AS `Stock minimo`, costo_unitario AS `Costo Unitario`, nombre " &
                                    "FROM insumo ORDER BY ID_insumo;"

                Using cmd As New MySqlCommand(sql, cn)
                    Dim tabla As New DataTable()
                    Using lector = cmd.ExecuteReader()
                        tabla.Load(lector)
                    End Using
                    dgwcat.DataSource = tabla
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorias: ", ex.Message)

        End Try
    End Sub

    Private Sub cargarcombocategorias()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT ID_categoria, nombre FROM categoria ORDER BY nombre;"
                Using cmd As New MySqlCommand(sql, cn)
                    Dim tabla As New DataTable()
                    Using lector = cmd.ExecuteReader()
                        tabla.Load(lector)
                    End Using
                    categoriabox.DataSource = tabla
                    categoriabox.DisplayMember = "nombre"
                    categoriabox.ValueMember = "ID_categoria"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar categorias: " & ex.Message)
        End Try
    End Sub
    Private Sub borrartexts()
        'borro todos los textbox para que no queden datos viejos
        Stockmintxt.Clear()
        costoUnitxt.Clear()
        stockacttxt.Clear()
        nombreinsumo.Clear()
        descripciontxt.Clear()
        categoriabox.SelectedIndex = -1

        Dim medidas As List(Of String) = New List(Of String) From {"Centimetro", "Metro", "Unidad", "Pulgadas", "Milimetro", "Docena"} 'Creo un array de medidas para que el usuario no tenga que escribirlo, sino que lo seleccione
        unidadcombobox.DataSource = medidas
        unidadcombobox.SelectedIndex = 0 'Selecciono el primer elemento del array, que es centimetro



    End Sub


    Private Sub UCproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaPers.Personalizargrilla(dgwcat) 'que lindo hacer modulos que se ocupen despues
        borrartexts()
        cargarinsumo()
        cargarcombocategorias()

    End Sub



    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
    End Sub

    Private Sub Añadirbtn_Click(sender As Object, e As EventArgs) Handles Añadirbtn.Click
        'hago validaciones
        If Not Validaciones.Validaciones(nombreinsumo, lblerrorinsumo, "Sin espacios o espacio vacio") Then Exit Sub
        If Not Validaciones.Validaciones(stockacttxt, lblerrorsta, "Solo numeros") Then Exit Sub
        If Not Validaciones.Validaciones(Stockmintxt, lblerrorsma, "Solo numeros") Then Exit Sub
        If Not Validaciones.Validaciones(costoUnitxt, lblerrorcu, "Solo numeros") Then Exit Sub
        If categoriabox.SelectedIndex = -1 Then Exit Sub

        Try
            Using cn As New MySqlConnection(CADENA)
                Dim sql As String =
                    "INSERT INTO insumo (ID_categoria, descripcion, unidad_medida, stock_actual, stock_minimo, costo_unitario, nombre) " &
                    "VALUES (@ID_categoria, @descripcion, @unidad_medida, @stock_actual, @stock_minimo, @costo_unitario, @nombre);"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@ID_categoria", categoriabox.SelectedValue)
                    cmd.Parameters.AddWithValue("@descripcion", descripciontxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@unidad_medida", unidadcombobox.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@stock_actual", stockacttxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@stock_minimo", Stockmintxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@costo_unitario", costoUnitxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@nombre", nombreinsumo.Text.Trim())
                    cn.Open()
                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro insertado!" & resultado)

                End Using


            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar insumo: " & ex.Message)
        End Try


        borrartexts()
        cargarinsumo()
        cargarcombocategorias()

    End Sub

    Private Sub eliminarbtn_Click(sender As Object, e As EventArgs) Handles eliminarbtn.Click
        If dgwcat.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un fila para poder eliminar")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim consulta As String = "DELETE FROM insumo WHERE ID_insumo=@id"

                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@id", dgwcat.SelectedRows(0).Cells("ID").Value)
                    'El 0 es lo que selecciona el usuario
                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro eliminado!" & resultado)
                End Using

            End Using
        Catch ex As Exception

            MessageBox.Show("Error! " & ex.Message)

        End Try
        cargarinsumo()

    End Sub

    Private Sub Editarcat_Click(sender As Object, e As EventArgs) Handles Editarcat.Click

        If dgwcat.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo para editar")
            Exit Sub
        End If
        'abro consulta para modificar, no confundir con el INSERT, esto es UPDATE

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim consulta As String = "UPDATE insumo SET ID_insumo=@ID, ID_categoria=@ID_categoria, descripcion=@descripcion, unidad_medida=@unidad_medida, stock_actual=@stock_actual, stock_minimo=@stock_minimo, costo_unitario=@costo_unitario, nombre=@nombre WHERE ID_insumo=@ID "
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@ID", dgwcat.SelectedRows(0).Cells("ID").Value)
                    cmd.Parameters.AddWithValue("@ID_categoria", categoriabox.SelectedValue)
                    cmd.Parameters.AddWithValue("@descripcion", descripciontxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@unidad_medida", unidadcombobox.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@stock_actual", CDec(stockacttxt.Text.Trim())) 'el cdec para pasarlo a decimal
                    cmd.Parameters.AddWithValue("@stock_minimo", CDec(Stockmintxt.Text.Trim()))
                    cmd.Parameters.AddWithValue("@costo_unitario", CDec(costoUnitxt.Text.Trim()))
                    cmd.Parameters.AddWithValue("@nombre", nombreinsumo.Text.Trim())
                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro cambiado!" & resultado)

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error! " & ex.Message)
        End Try

        cargarinsumo()
        cargarcombocategorias()
        borrartexts()
    End Sub

    Private Sub dgwcat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwcat.CellClick
        'traigo datos de las celdas al dwgcat, osea, a la grilla
        If e.RowIndex >= 0 Then
            nombreinsumo.Text = dgwcat.Rows(e.RowIndex).Cells("nombre").Value.ToString()
            descripciontxt.Text = dgwcat.Rows(e.RowIndex).Cells("descripcion").Value.ToString()
            stockacttxt.Text = dgwcat.Rows(e.RowIndex).Cells("Stock Actual").Value.ToString()
            Stockmintxt.Text = dgwcat.Rows(e.RowIndex).Cells("Stock minimo").Value.ToString()
            costoUnitxt.Text = dgwcat.Rows(e.RowIndex).Cells("Costo Unitario").Value.ToString()
            categoriabox.SelectedValue = dgwcat.Rows(e.RowIndex).Cells("Categoria").Value
        End If
    End Sub

    Private Sub labeltexto_Click(sender As Object, e As EventArgs) Handles labeltexto.Click

    End Sub
End Class
