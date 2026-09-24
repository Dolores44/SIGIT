Imports MySqlConnector

Public Class UCproductos
    Private formcategoria As UCproductoscategoria = Nothing '
    Sub cargarproductos()

        Try
            FLPproductos.Controls.Clear() 'Saco lo que hay antes, sirve para el LIMIT posterior

            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                'Realizo consulta para traer los productos, es un join de 3 tablas, CATEGORIA, PRODUCTO y VARIANTE PRODUCTO
                Dim sql As String = "SELECT pr.nombre, pv.precio_venta, pv.stock_actual, cat.nombre AS categoria " & 'Llamo a Producto NOMBRE, precio de venta y stock de producto variante, por ultimo la categoria 
                                    "FROM Producto_Variante pv " & 'pv es el nombre que se le pone arriba para sacar los campos de esa tabla
                                    "JOIN producto pr ON pv.ID_Producto = pr.ID_Producto " & 'La funcion de join se interpeta asi: solo juntá una fila de cada lado si el número de ID_producto coincide"
                                    "JOIN Categoria cat ON pr.ID_categoria = cat.ID_categoria " &
                                    "ORDER BY pr.nombre"

                Using cmd As New MySqlCommand(sql, cn)
                    Using lector As MySqlDataReader = cmd.ExecuteReader()

                        While lector.Read() ' "Mientras lector se pueda leer"
                            Dim tarjeta As New UCproductoslista
                            tarjeta.cargardatos(
                            lector("nombre").ToString(),
                            lector("categoria").ToString(),
                            CDec(lector("precio_venta")),
                            CInt(lector("stock_actual"))
                            )
                            'Cdec convierte expresion a decimal, porque esta en decimal el precio en la BD y en el programa
                            'Lo mismo pero con numero entero
                            FLPproductos.Controls.Add(tarjeta) 'Añado todo lo que sacamos a la tarjetita

                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception

            MessageBox.Show("Error" & ex.Message)

        End Try
    End Sub
    Private Sub UCproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarproductos()
    End Sub
    Private Sub labeltexto_Click(sender As Object, e As EventArgs) Handles labeltexto.Click

    End Sub

    Private Sub Añadirbtn_Click(sender As Object, e As EventArgs) Handles Añadirbtn.Click

        ' abro el form de categorias
        Using nuevoform As New UCproductoscategoria
            nuevoform.ShowDialog
            cargarproductos
        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using newform As New UCproductosañadir()
            newform.ShowDialog()
            cargarproductos()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using varianteform As New UCproductovariante
            varianteform.ShowDialog()
            cargarproductos()
        End Using
    End Sub
End Class
