Imports MySqlConnector

Public Class UCproductosañadir

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

        If Not Validaciones.Validaciones(nombreinsumo, validacionproductolbl, "Producto") Then Exit Sub
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
                    cmd.Parameters.AddWithValue("@nombre", nombreinsumo.Text.Trim())
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
    End Sub

    Private Sub UCproductosañadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcombocategorias()
    End Sub
End Class

