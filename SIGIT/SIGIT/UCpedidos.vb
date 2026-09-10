
Imports System.Web
Imports System.Windows.Forms.Design
Imports MySqlConnector
Public Class UCpedidos

    Sub Cargarpedidos()
        'Creo subrutina para cargar pedidos
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                'cargo consulta
                Dim consulta As String = "SELECT * FROM pedido ORDER BY ID_pedido;"

                Using cmd As New MySqlCommand(consulta, cn) 'Aca agarro laconsulta y la conexion de la base de datos
                    Dim tabla As New DataTable 'Creo variable tabla, para dejar los datos de la base aca
                    Using lector As MySqlDataReader = cmd.ExecuteReader 'Leo los datos y ejecuta el comando
                        tabla.Load(lector)
                    End Using
                    dgwpedidos.DataSource = tabla 'asigno datos a la tabla
                End Using

            End Using
        Catch ex As Exception

            MessageBox.Show("Error en la carga de pedidos" & ex.Message)

        End Try

    End Sub
    Private Sub UCpedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        buscartxt.PlaceholderText = "Cliente o Nro"

        'Cargo grilla al cargar formulario
        Cargarpedidos()


    End Sub

    Private Sub labeltexto_Click(sender As Object, e As EventArgs) Handles labeltexto.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
