Imports System.Net.Mime.MediaTypeNames
Imports MySqlConnector


Public Class UCproductosañadir

    Private Sub vaciartxt()
        nombreproducto.Clear()
        descripciontxt.Clear()
        categoriabox.SelectedIndex = -1
        confeccionadoradio.Checked = False
        reventaradio.Checked = False
    End Sub
    Private Sub cargarproductos()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT ID_categoria as `Nro categoria`, ID_producto as `Nro Producto`, nombre as Nombre, descripcion, tipo_producto AS `Tipo Producto` " &
                                    "FROM producto ORDER BY ID_categoria"
                Using cmd As New MySqlCommand(sql, cn)
                    Dim tabla As New DataTable()
                    Using lector = cmd.ExecuteReader
                        tabla.Load(lector)
                    End Using
                    dgwproducto.DataSource = tabla

                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
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
    Private Sub añadirproducto()

        If Not Validaciones.Validaciones(nombreproducto, validacionproductolbl, "Producto") Then Exit Sub
        If categoriabox.SelectedIndex = -1 Then
            Validacioncategoria.Text = "Debe seleccionar una categoria"
            Exit Sub
        Else
            Validacioncategoria.Text = ""
        End If

        If Not confeccionadoradio.Checked And Not reventaradio.Checked Then
            validacioncheckbox.Text = "Debe seleccionar al menos una opción"
            Exit Sub
        Else
            validacioncheckbox.Text = ""

        End If


        'Hago validaciones, ya que no tengo un modulo para esto, lo realizo asi, en caso de requerir mas similares, hago un validaciones
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "INSERT INTO producto (ID_categoria, nombre, descripcion, tipo_producto)" &
                                    "VALUES (@ID_categoria, @nombre, @descripcion, @tipo_producto);"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@ID_categoria", categoriabox.SelectedValue)
                    cmd.Parameters.AddWithValue("@nombre", nombreproducto.Text.Trim())
                    cmd.Parameters.AddWithValue("@descripcion", descripciontxt.Text.Trim())
                    Dim tipo_producto As String = If(confeccionadoradio.Checked, "Confeccionado", "Reventa") 'si confeccionado esta chequeado, entonces es confeccionado, si no, es reventa
                    cmd.Parameters.AddWithValue("@tipo_producto", tipo_producto)

                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro insertado!" & resultado)

                End Using


            End Using
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Editarcat_Click(sender As Object, e As EventArgs) Handles Editarcat.Click
        añadirproducto()
        cargarproductos()
    End Sub

    Private Sub UCproductosañadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaPers.Personalizargrilla(dgwproducto)
        cargarcombocategorias()
        cargarproductos()
        vaciartxt()
    End Sub

    Private Sub eliminarbtn_Click(sender As Object, e As EventArgs) Handles eliminarbtn.Click
        If dgwproducto.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un insumo para borrar")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim consulta As String = "DELETE FROM producto WHERE ID_producto=@ID"
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@ID", dgwproducto.SelectedRows(0).Cells("Nro Producto").Value)
                    'El 0 es lo que selecciona el usuario
                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro eliminado!" & resultado)
                End Using
                cargarproductos()
                vaciartxt()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar: " & ex.Message)
        End Try
    End Sub

    Private Sub dgwproducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwproducto.CellContentClick
        If e.RowIndex >= 0 Then
            descripciontxt.Text = dgwproducto.Rows(e.RowIndex).Cells("descripcion").Value.ToString()
            nombreproducto.Text = dgwproducto.Rows(e.RowIndex).Cells("Nombre").Value.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgwproducto.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar algo para editar")
            Exit Sub
        End If
        'abro consulta para modificar, no confundir con el INSERT, esto es UPDATE

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim consulta As String = "UPDATE producto SET nombre=@nombre, descripcion=@descripcion, tipo_producto=@tipo_producto WHERE ID_producto=@ID "
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@ID", dgwproducto.SelectedRows(0).Cells("Nro Producto").Value) 'Mismo procedimiento de antes
                    cmd.Parameters.AddWithValue("@nombre", nombreproducto.Text.Trim)
                    cmd.Parameters.AddWithValue("@descripcion", descripciontxt.Text.Trim)
                    Dim tipo_producto As String = If(confeccionadoradio.Checked, "Confeccionado", "Reventa")
                    cmd.Parameters.AddWithValue("@tipo_producto", tipo_producto)

                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro cambiado!" & resultado)

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error! " & ex.Message)
        End Try

        cargarproductos()
        vaciartxt()
    End Sub
End Class

