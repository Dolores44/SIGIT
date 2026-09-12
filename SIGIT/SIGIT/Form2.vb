Imports MySqlConnector
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class Inicio

    Private Sub CambiarPanel(Vista As UserControl)
        'SUBRUTINA PARA LLAMAR PANELES
        'VACIO EL PANEL QUE ESTA
        PanelControl.Controls.Clear()
        'DOCK FILL PARA QUE SE PONGA ENCUARDARDO, PANTALLA COMPLETA, O COMO SE QUIERA DECIR
        Vista.Dock = DockStyle.Fill
        'LO CAMBIO
        PanelControl.Controls.Add(Vista)

    End Sub

    Private Sub dashboardbtn_Click(sender As Object, e As EventArgs) Handles dashboardbtn.Click
        'LLAMO  SUBRUTINA, SOLO PONGO ESTE COMENTARIO PORQUE ES MISMO PROCEDIMIENTO PARA TODO
        CambiarPanel(New UCdashboard)
    End Sub

    Private Sub Pedidosbtn_Click(sender As Object, e As EventArgs) Handles Pedidosbtn.Click
        CambiarPanel(New UCpedidos)
    End Sub

    Private Sub Productosbtn_Click(sender As Object, e As EventArgs) Handles Productosbtn.Click
        CambiarPanel(New UCproductos)
    End Sub

    Private Sub stockbtn_Click(sender As Object, e As EventArgs) Handles stockbtn.Click
        CambiarPanel(New UCstock)
    End Sub

    Private Sub Insumosbtn_Click(sender As Object, e As EventArgs) Handles Insumosbtn.Click
        CambiarPanel(New UCinsumos)
    End Sub

    Private Sub produccionbtn_Click(sender As Object, e As EventArgs) Handles produccionbtn.Click
        CambiarPanel(New UCproduccion)
    End Sub

    Private Sub clientesbtn_Click(sender As Object, e As EventArgs) Handles clientesbtn.Click
        CambiarPanel(New UCclientes)
    End Sub

    Private Sub PanelControl_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl.Paint

    End Sub
End Class