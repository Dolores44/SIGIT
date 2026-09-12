Public Class UCproductoslista

    Public Sub cargardatos(nombre As String, nombrecategoria As String, precio As Decimal, stock As Integer) 'creo subrutina para psar los datos a UCproductos
        nombreproducto.Text = nombre
        categoria.Text = nombrecategoria.ToUpper 'lo hago mayuscula
        preciotxt.Text = "$ " & precio.ToString ' Concateno el signo peso, para poner el precio en integer nomas, porque soy r crack | arreglito, le puse .tostring porque me cago todo a la mierda
        stockcount.Text = stock.ToString & " u" 'unidades
    End Sub


    Private Sub UCproductoslista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
