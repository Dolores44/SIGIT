Imports MySqlConnector

Public Class UCinsumos

    ' funcion para cargar los insumos en el flowlayoutpanel

    Private Sub vaciartxt()
        descripciontxt.Text = ""
        buscartxt.Text = ""

    End Sub
    Private Sub cargarinsumos()
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT * FROM insumo ORDER BY nombre;"
                Dim sqllabel As String = "SELECT COUNT(*) from insumo; "

                Using cmd As New MySqlCommand(sql, cn)
                    Dim tabla As New DataTable()
                    dgwinsumos.Controls.Clear()

                    Using lector As MySqlDataReader = cmd.ExecuteReader()
                        tabla.Load(lector)
                    End Using

                    dgwinsumos.DataSource = tabla
                End Using

                Using cmdlabel As New MySqlCommand(sqllabel, cn)

                    insumostotaleslbl.Text = cmdlabel.ExecuteScalar().ToString() 'pongo el resultado de la consulta en el label

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar insumos: " & ex.Message)
        End Try
    End Sub





    Private Sub UCinsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrillaPers.Personalizargrilla(dgwinsumos)
        cargarinsumos()

    End Sub


    Private Sub Añadirbtn_Click(sender As Object, e As EventArgs) Handles Añadirbtn.Click
        'Añado un nuevo insumo
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "INSERT INTO insumo (nombre, descripcion) VALUES (@nombre, @descripcion);"
                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@nombre", descripciontxt.Text)
                    cmd.Parameters.AddWithValue("@descripcion", buscartxt.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception

        End Try


    End Sub


    Private Sub registrarmovi_Click(sender As Object, e As EventArgs) Handles registrarmovi.Click
        Using nuevoform As New UCinsumosañadir()
            nuevoform.ShowDialog()
        End Using
    End Sub
End Class
