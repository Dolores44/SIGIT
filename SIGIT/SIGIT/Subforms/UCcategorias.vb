Imports MySqlConnector

Public Class UCcategorias


    Private Sub cargarcategorias()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "SELECT * FROM categoria ORDER BY ID_categoria;"

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
    Private Sub borrartexts()
        categoriatxt.Clear()
        codigotxt.Clear()
        descripciontxt.Clear()
    End Sub


    Private Sub UCproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaPers.Personalizargrilla(dgwcat) 'que lindo hacer modulos que se ocupen despues
        borrartexts()
        cargarcategorias()
    End Sub



    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
    End Sub

    Private Sub Añadirbtn_Click(sender As Object, e As EventArgs) Handles Añadirbtn.Click

        If Not Validaciones.Validaciones(categoriatxt, lblerrorcat, " La categoría no debe estar vacia") Then Exit Sub
        If Not Validaciones.Validaciones(codigotxt, errorcodigo, " El codigo no debe estar vacio") Then Exit Sub
        'Conectamos a la base de datos para la carga
        Using cn As New MySqlConnection(CADENA)
            cn.Open()

            Dim consulta As String = "INSERT INTO categoria (nombre, descripcion, codigo)" &
                                     " VALUES (@nombre, @descripcion, @codigo);"

            Using cmd As New MySqlCommand(consulta, cn)
                cmd.Parameters.AddWithValue("@nombre", categoriatxt.Text.Trim) 'Cargo los valores que estan en los textbox
                cmd.Parameters.AddWithValue("@descripcion", descripciontxt.Text.Trim)
                cmd.Parameters.AddWithValue("@codigo", codigotxt.Text.Trim)

                'ejecuto consulta
                Dim resultado As Integer = cmd.ExecuteNonQuery()
                MessageBox.Show("Registro cargado! " & resultado)

            End Using

        End Using
        borrartexts()
        cargarcategorias()
    End Sub

    Private Sub eliminarbtn_Click(sender As Object, e As EventArgs) Handles eliminarbtn.Click
        If dgwcat.SelectedRows.Count = 0 Then
            MessageBox.Show("Debe seleccionar un fila para poder eliminar")
            Exit Sub
        End If

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim consulta As String = "DELETE FROM categoria WHERE ID_categoria=@id"

                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@id", dgwcat.SelectedRows(0).Cells("ID_categoria").Value)
                    'El 0 es lo que selecciona el usuario
                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro eliminado!" & resultado)
                End Using

            End Using
        Catch ex As Exception

            MessageBox.Show("Error! " & ex.Message)

        End Try
        cargarcategorias()
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

                Dim consulta As String = "UPDATE categoria SET nombre=@nombre, descripcion=@descripcion, codigo=@codigo WHERE ID_categoria=@ID "
                Using cmd As New MySqlCommand(consulta, cn)
                    cmd.Parameters.AddWithValue("@ID", dgwcat.SelectedRows(0).Cells("ID_categoria").Value) 'Mismo procedimiento de antes
                    cmd.Parameters.AddWithValue("@nombre", categoriatxt.Text.Trim)
                    cmd.Parameters.AddWithValue("@codigo", codigotxt.Text.Trim)
                    cmd.Parameters.AddWithValue("@descripcion", descripciontxt.Text.Trim)

                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Registro cambiado!" & resultado)

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error! " & ex.Message)
        End Try

        cargarcategorias()
        borrartexts()

    End Sub

    Private Sub dgwcat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwcat.CellClick
        'traigo datos de las celdas al dwgcat, osea, a la grilla

        If e.RowIndex >= 0 Then
            descripciontxt.Text = dgwcat.Rows(e.RowIndex).Cells("descripcion").Value.ToString()
            codigotxt.Text = dgwcat.Rows(e.RowIndex).Cells("codigo").Value.ToString()
            categoriatxt.Text = dgwcat.Rows(e.RowIndex).Cells("nombre").Value.ToString()
        End If

    End Sub

    Private Sub labeltexto_Click(sender As Object, e As EventArgs) Handles labeltexto.Click

    End Sub
End Class
