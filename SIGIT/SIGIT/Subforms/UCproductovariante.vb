Imports MySqlConnector

Public Class UCproductovariante
    Private Sub cargarcomboproductos() 'Cargo el combo de productos, para saber a que producto adjudicar una nueva variante
        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()
                Dim sql As String = "SELECT ID_Producto, nombre FROM Producto ORDER BY nombre"
                Using cmd As New MySqlCommand(sql, cn)
                    Using lector As MySqlDataReader = cmd.ExecuteReader()
                        comboproducto.Items.Clear() 'Limpio el combo antes de cargarlo
                        Dim tabla As New DataTable()
                        tabla.Load(lector)

                        comboproducto.DataSource = tabla
                        comboproducto.DisplayMember = "nombre" 'muestro nombre
                        comboproducto.ValueMember = "ID_Producto" 'me quedo con el ID


                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar productos: " & ex.Message)
        End Try


    End Sub

    Private Sub vaciartxt()

        colortxt.Text = ""
        prventatxt.Text = ""
        stactutxt.Text = ""
        stmintxt.Text = ""
        talletxt.Text = ""

    End Sub
    Private Sub añadirvariante()

        'Realizo validaciones primeramnete
        If Not Validaciones.Validaciones(stactutxt, validacionstockactuallbl, "Stock actual") Then Exit Sub
        If Not Validaciones.Validaciones(stmintxt, validaiconstockminimolbl, "Stock mínimo") Then Exit Sub
        If Not Validaciones.Validaciones(prventatxt, validacionprecioventalbl, "Precio de venta") Then Exit Sub

        'Como esas 3 son not null, entonces solo hago eso ahr

        Try
            Using cn As New MySqlConnection(CADENA)
                cn.Open()

                Dim sql As String = "INSERT INTO Producto_Variante(ID_Producto, color, talle, stock_actual, stock_minimo, precio_venta, otra_caracteristica) " &
                                    "VALUES (@ID_Producto, @color, @talle, @stock_actual, @stock_minimo, @precio_venta, @otra_caracteristica);"

                Using cmd As New MySqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@ID_producto", comboproducto.SelectedValue)
                    cmd.Parameters.AddWithValue("@color", colortxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@talle", talletxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@stock_actual", stactutxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@stock_minimo", stmintxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@precio_venta", prventatxt.Text.Trim())
                    cmd.Parameters.AddWithValue("@otra_caracteristica", carectxt.Text.Trim())

                    Dim resultado As Integer = cmd.ExecuteNonQuery()
                    MessageBox.Show("Producto variante añadido!!" & resultado)

                End Using
            End Using
            vaciartxt()
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub

    Private Sub UCproductovariante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcomboproductos()

    End Sub

    Private Sub eliminarbtn_Click(sender As Object, e As EventArgs) Handles eliminarbtn.Click
        añadirvariante()
    End Sub
End Class
