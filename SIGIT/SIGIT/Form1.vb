Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySqlConnector
Imports MaterialSkin
Imports MaterialSkin.Controls


Public Class LOGIN
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles usuariotxt.TextChanged
        ' Tu evento de texto cambiado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'boton conectar de prueba
        Try
            Using CN As New MySqlConnection(CADENA)
                CN.Open()
                MessageBox.Show("Conexion exitosa")
            End Using
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        End Try
    End Sub


    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Pongo conexion al cargar, es para ver si esta conectado desde un principio
        Try
            Using CN As New MySqlConnection(CADENA)
                CN.Open()
                Label9.Text = "¡Conectado!"
            End Using
        Catch ex As Exception

            Label9.Text = "Desconectado :("

        End Try
    End Sub

    Private Sub Iniciosesion_Click(sender As Object, e As EventArgs) Handles Iniciosesion.Click
        'llamo validaciones del modulo validaciones ahre, le paso valores y hago la verifiacion
        If Not Validaciones.Validaciones(usuariotxt, usererrorlbl, "Usuario") Then Exit Sub
        If Not Validaciones.Validaciones(contraseñatxt, contraerrorlbl, "Contraseña") Then Exit Sub


    End Sub

    Private Sub contraseñatxt_TextChanged(sender As Object, e As EventArgs) Handles contraseñatxt.TextChanged
        'Hace que el texto sea *
        contraseñatxt.PasswordChar = "*"c
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Inicio.Show()

    End Sub
End Class
