<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Label3 As Label
        Panel1 = New Panel()
        Label2 = New Label()
        Panel8 = New Panel()
        Panel6 = New Panel()
        Button6 = New Button()
        Panel9 = New Panel()
        Panel4 = New Panel()
        clientesbtn = New Button()
        produccionbtn = New Button()
        Panel7 = New Panel()
        stockbtn = New Button()
        Insumosbtn = New Button()
        Panel5 = New Panel()
        Productosbtn = New Button()
        Panel3 = New Panel()
        Pedidosbtn = New Button()
        Panel2 = New Panel()
        dashboardbtn = New Button()
        Label6 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel10 = New Panel()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(50))
        Label3.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(2, 93)
        Label3.Margin = New Padding(0)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 5)
        Label3.TabIndex = 25
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(clientesbtn)
        Panel1.Controls.Add(produccionbtn)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(stockbtn)
        Panel1.Controls.Add(Insumosbtn)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Productosbtn)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Pedidosbtn)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(dashboardbtn)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(182, 691)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Dubai", 8.1F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(15, 75)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(160, 18)
        Label2.TabIndex = 16
        Label2.Text = "Sistema Integral de Indumentaria"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Panel8.Location = New Point(0, 490)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(10, 26)
        Panel8.TabIndex = 22
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Panel6.Location = New Point(0, 386)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(10, 26)
        Panel6.TabIndex = 22
        ' 
        ' Button6
        ' 
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI", 9.75F)
        Button6.ForeColor = Color.GhostWhite
        Button6.Image = My.Resources.Resources.carrito_de_compras1
        Button6.ImageAlign = ContentAlignment.TopLeft
        Button6.Location = New Point(8, 490)
        Button6.Name = "Button6"
        Button6.Size = New Size(174, 26)
        Button6.TabIndex = 21
        Button6.Text = "  - Pedidos"
        Button6.TextAlign = ContentAlignment.MiddleLeft
        Button6.TextImageRelation = TextImageRelation.ImageBeforeText
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Panel9.Location = New Point(0, 438)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(10, 26)
        Panel9.TabIndex = 20
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Panel4.Location = New Point(0, 282)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(10, 26)
        Panel4.TabIndex = 22
        ' 
        ' clientesbtn
        ' 
        clientesbtn.FlatAppearance.BorderSize = 0
        clientesbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        clientesbtn.FlatStyle = FlatStyle.Flat
        clientesbtn.Font = New Font("Segoe UI", 9.75F)
        clientesbtn.ForeColor = Color.GhostWhite
        clientesbtn.Image = My.Resources.Resources.clientes
        clientesbtn.ImageAlign = ContentAlignment.TopLeft
        clientesbtn.Location = New Point(8, 438)
        clientesbtn.Name = "clientesbtn"
        clientesbtn.Size = New Size(174, 26)
        clientesbtn.TabIndex = 19
        clientesbtn.Text = "  - Clientes"
        clientesbtn.TextAlign = ContentAlignment.MiddleLeft
        clientesbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        clientesbtn.UseVisualStyleBackColor = True
        ' 
        ' produccionbtn
        ' 
        produccionbtn.FlatAppearance.BorderSize = 0
        produccionbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        produccionbtn.FlatStyle = FlatStyle.Flat
        produccionbtn.Font = New Font("Segoe UI", 9.75F)
        produccionbtn.ForeColor = Color.GhostWhite
        produccionbtn.Image = My.Resources.Resources.maquinadecoser
        produccionbtn.ImageAlign = ContentAlignment.TopLeft
        produccionbtn.Location = New Point(8, 386)
        produccionbtn.Name = "produccionbtn"
        produccionbtn.Size = New Size(174, 26)
        produccionbtn.TabIndex = 21
        produccionbtn.Text = "  - Producción"
        produccionbtn.TextAlign = ContentAlignment.MiddleLeft
        produccionbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        produccionbtn.UseVisualStyleBackColor = True
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Panel7.Location = New Point(0, 334)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(10, 26)
        Panel7.TabIndex = 20
        ' 
        ' stockbtn
        ' 
        stockbtn.FlatAppearance.BorderSize = 0
        stockbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        stockbtn.FlatStyle = FlatStyle.Flat
        stockbtn.Font = New Font("Segoe UI", 9.75F)
        stockbtn.ForeColor = Color.GhostWhite
        stockbtn.Image = My.Resources.Resources.base_de_datos
        stockbtn.ImageAlign = ContentAlignment.TopLeft
        stockbtn.Location = New Point(8, 282)
        stockbtn.Name = "stockbtn"
        stockbtn.Size = New Size(174, 26)
        stockbtn.TabIndex = 21
        stockbtn.Text = "  - Stock"
        stockbtn.TextAlign = ContentAlignment.MiddleLeft
        stockbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        stockbtn.UseVisualStyleBackColor = True
        ' 
        ' Insumosbtn
        ' 
        Insumosbtn.FlatAppearance.BorderSize = 0
        Insumosbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Insumosbtn.FlatStyle = FlatStyle.Flat
        Insumosbtn.Font = New Font("Segoe UI", 9.75F)
        Insumosbtn.ForeColor = Color.GhostWhite
        Insumosbtn.Image = My.Resources.Resources.tijeras
        Insumosbtn.ImageAlign = ContentAlignment.TopLeft
        Insumosbtn.Location = New Point(8, 334)
        Insumosbtn.Name = "Insumosbtn"
        Insumosbtn.Size = New Size(174, 26)
        Insumosbtn.TabIndex = 19
        Insumosbtn.Text = "  - Insumos"
        Insumosbtn.TextAlign = ContentAlignment.MiddleLeft
        Insumosbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        Insumosbtn.UseVisualStyleBackColor = True
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Panel5.Location = New Point(0, 230)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(10, 26)
        Panel5.TabIndex = 20
        ' 
        ' Productosbtn
        ' 
        Productosbtn.FlatAppearance.BorderSize = 0
        Productosbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Productosbtn.FlatStyle = FlatStyle.Flat
        Productosbtn.Font = New Font("Segoe UI", 9.75F)
        Productosbtn.ForeColor = Color.GhostWhite
        Productosbtn.Image = My.Resources.Resources.camisa
        Productosbtn.ImageAlign = ContentAlignment.TopLeft
        Productosbtn.Location = New Point(8, 230)
        Productosbtn.Name = "Productosbtn"
        Productosbtn.Size = New Size(174, 26)
        Productosbtn.TabIndex = 19
        Productosbtn.Text = "  - Productos"
        Productosbtn.TextAlign = ContentAlignment.MiddleLeft
        Productosbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        Productosbtn.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Panel3.Location = New Point(0, 178)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(10, 26)
        Panel3.TabIndex = 18
        ' 
        ' Pedidosbtn
        ' 
        Pedidosbtn.FlatAppearance.BorderSize = 0
        Pedidosbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Pedidosbtn.FlatStyle = FlatStyle.Flat
        Pedidosbtn.Font = New Font("Segoe UI", 9.75F)
        Pedidosbtn.ForeColor = Color.GhostWhite
        Pedidosbtn.Image = My.Resources.Resources.carrito_de_compras1
        Pedidosbtn.ImageAlign = ContentAlignment.TopLeft
        Pedidosbtn.Location = New Point(8, 178)
        Pedidosbtn.Name = "Pedidosbtn"
        Pedidosbtn.Size = New Size(174, 26)
        Pedidosbtn.TabIndex = 17
        Pedidosbtn.Text = "  - Pedidos"
        Pedidosbtn.TextAlign = ContentAlignment.MiddleLeft
        Pedidosbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        Pedidosbtn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Panel2.Location = New Point(0, 126)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(10, 26)
        Panel2.TabIndex = 16
        ' 
        ' dashboardbtn
        ' 
        dashboardbtn.FlatAppearance.BorderSize = 0
        dashboardbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        dashboardbtn.FlatStyle = FlatStyle.Flat
        dashboardbtn.Font = New Font("Segoe UI", 9.75F)
        dashboardbtn.ForeColor = Color.GhostWhite
        dashboardbtn.Image = My.Resources.Resources.histograma
        dashboardbtn.ImageAlign = ContentAlignment.TopLeft
        dashboardbtn.Location = New Point(8, 126)
        dashboardbtn.Name = "dashboardbtn"
        dashboardbtn.Size = New Size(174, 26)
        dashboardbtn.TabIndex = 0
        dashboardbtn.Text = "  - Dashboard"
        dashboardbtn.TextAlign = ContentAlignment.MiddleLeft
        dashboardbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        dashboardbtn.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Consolas", 8.0F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(12, 659)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.No
        Label6.Size = New Size(67, 13)
        Label6.TabIndex = 15
        Label6.Text = "Ver. 0.0.1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 18.0F, FontStyle.Bold Or FontStyle.Underline)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(71, 32)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(104, 32)
        Label1.TabIndex = 2
        Label1.Text = "S I G I T"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(8, 14)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel10
        ' 
        Panel10.Location = New Point(183, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(1224, 713)
        Panel10.TabIndex = 1
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(1384, 691)
        Controls.Add(Panel10)
        Controls.Add(Panel1)
        Name = "Inicio"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashboardbtn As Button
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents stockbtn As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Productosbtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Pedidosbtn As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents clientesbtn As Button
    Friend WithEvents produccionbtn As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Insumosbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel10 As Panel
End Class
