<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCinsumos

    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Panel1 = New Panel()
        categorialbl = New Label()
        registrarmovi = New Button()
        insumostotaleslbl = New Label()
        label4 = New Label()
        combocategoria = New ComboBox()
        Label2 = New Label()
        dashboardbtn = New Button()
        buscartxt = New TextBox()
        buscarlbl = New Label()
        Label1 = New Label()
        descripciontxt = New TextBox()
        stocklbl = New Label()
        PictureBox1 = New PictureBox()
        labeltexto = New Label()
        dgwinsumos = New DataGridView()
        Panel2 = New Panel()
        stockcambiartxt = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        Label6 = New Label()
        nombreinsumolbl = New Label()
        stockvalorizadolbl = New Label()
        stockminlbl = New Label()
        stockactuallbl = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        dgvrecientes = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgwinsumos, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvrecientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(categorialbl)
        Panel1.Controls.Add(registrarmovi)
        Panel1.Controls.Add(insumostotaleslbl)
        Panel1.Controls.Add(label4)
        Panel1.Controls.Add(combocategoria)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dashboardbtn)
        Panel1.Controls.Add(buscartxt)
        Panel1.Controls.Add(buscarlbl)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1224, 109)
        Panel1.TabIndex = 4
        ' 
        ' categorialbl
        ' 
        categorialbl.AutoSize = True
        categorialbl.Font = New Font("Mongolian Baiti", 11F)
        categorialbl.Location = New Point(211, 53)
        categorialbl.Name = "categorialbl"
        categorialbl.Size = New Size(71, 16)
        categorialbl.TabIndex = 17
        categorialbl.Text = "Categoría:"
        ' 
        ' registrarmovi
        ' 
        registrarmovi.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        registrarmovi.FlatAppearance.BorderSize = 0
        registrarmovi.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        registrarmovi.FlatStyle = FlatStyle.Flat
        registrarmovi.Font = New Font("Segoe UI", 10F)
        registrarmovi.ForeColor = Color.GhostWhite
        registrarmovi.Image = My.Resources.Resources.modificar
        registrarmovi.ImageAlign = ContentAlignment.TopLeft
        registrarmovi.Location = New Point(1035, 39)
        registrarmovi.Name = "registrarmovi"
        registrarmovi.Size = New Size(114, 31)
        registrarmovi.TabIndex = 9
        registrarmovi.Text = "Modificar"
        registrarmovi.TextImageRelation = TextImageRelation.ImageBeforeText
        registrarmovi.UseVisualStyleBackColor = False
        ' 
        ' insumostotaleslbl
        ' 
        insumostotaleslbl.AutoSize = True
        insumostotaleslbl.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        insumostotaleslbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        insumostotaleslbl.ForeColor = Color.GhostWhite
        insumostotaleslbl.Location = New Point(741, 51)
        insumostotaleslbl.Name = "insumostotaleslbl"
        insumostotaleslbl.Size = New Size(17, 20)
        insumostotaleslbl.TabIndex = 16
        insumostotaleslbl.Text = "0"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Segoe UI", 12F, FontStyle.Underline)
        label4.Location = New Point(603, 49)
        label4.Name = "label4"
        label4.Size = New Size(120, 21)
        label4.TabIndex = 15
        label4.Text = "Insumos Totales"
        ' 
        ' combocategoria
        ' 
        combocategoria.FormattingEnabled = True
        combocategoria.Location = New Point(288, 51)
        combocategoria.Name = "combocategoria"
        combocategoria.Size = New Size(121, 23)
        combocategoria.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Label2.Location = New Point(803, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(5, 77)
        Label2.TabIndex = 0
        ' 
        ' dashboardbtn
        ' 
        dashboardbtn.BackColor = SystemColors.ScrollBar
        dashboardbtn.FlatAppearance.BorderSize = 0
        dashboardbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        dashboardbtn.FlatStyle = FlatStyle.Flat
        dashboardbtn.Font = New Font("Segoe UI", 10F)
        dashboardbtn.ForeColor = Color.Black
        dashboardbtn.Location = New Point(426, 45)
        dashboardbtn.Name = "dashboardbtn"
        dashboardbtn.Size = New Size(114, 31)
        dashboardbtn.TabIndex = 1
        dashboardbtn.Text = "Buscar"
        dashboardbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        dashboardbtn.UseVisualStyleBackColor = False
        ' 
        ' buscartxt
        ' 
        buscartxt.Location = New Point(73, 48)
        buscartxt.Name = "buscartxt"
        buscartxt.Size = New Size(121, 23)
        buscartxt.TabIndex = 11
        ' 
        ' buscarlbl
        ' 
        buscarlbl.AutoSize = True
        buscarlbl.Font = New Font("Mongolian Baiti", 11F)
        buscarlbl.Location = New Point(3, 55)
        buscarlbl.Name = "buscarlbl"
        buscarlbl.Size = New Size(54, 16)
        buscarlbl.TabIndex = 1
        buscarlbl.Text = "Buscar:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 11F)
        Label1.Location = New Point(128, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 16)
        Label1.TabIndex = 5
        Label1.Text = "Descripcion"
        ' 
        ' descripciontxt
        ' 
        descripciontxt.Location = New Point(15, 242)
        descripciontxt.Multiline = True
        descripciontxt.Name = "descripciontxt"
        descripciontxt.PlaceholderText = "Descripción de insumo"
        descripciontxt.ReadOnly = True
        descripciontxt.Size = New Size(305, 44)
        descripciontxt.TabIndex = 14
        ' 
        ' stocklbl
        ' 
        stocklbl.AutoSize = True
        stocklbl.Font = New Font("Mongolian Baiti", 11F)
        stocklbl.Location = New Point(38, 325)
        stocklbl.Name = "stocklbl"
        stocklbl.Size = New Size(46, 16)
        stocklbl.TabIndex = 3
        stocklbl.Text = "Stock:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(15, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(305, 184)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' labeltexto
        ' 
        labeltexto.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        labeltexto.Dock = DockStyle.Top
        labeltexto.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        labeltexto.ForeColor = Color.GhostWhite
        labeltexto.ImageAlign = ContentAlignment.MiddleRight
        labeltexto.Location = New Point(0, 0)
        labeltexto.Name = "labeltexto"
        labeltexto.RightToLeft = RightToLeft.No
        labeltexto.Size = New Size(1224, 38)
        labeltexto.TabIndex = 2
        labeltexto.Text = "         GESTIÓN DE INSUMOS"
        labeltexto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dgwinsumos
        ' 
        dgwinsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwinsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwinsumos.Location = New Point(19, 181)
        dgwinsumos.MultiSelect = False
        dgwinsumos.Name = "dgwinsumos"
        dgwinsumos.ReadOnly = True
        dgwinsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgwinsumos.Size = New Size(764, 360)
        dgwinsumos.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(stockcambiartxt)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(nombreinsumolbl)
        Panel2.Controls.Add(stockvalorizadolbl)
        Panel2.Controls.Add(stockminlbl)
        Panel2.Controls.Add(stockactuallbl)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(descripciontxt)
        Panel2.Controls.Add(stocklbl)
        Panel2.Location = New Point(829, 181)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(337, 377)
        Panel2.TabIndex = 18
        ' 
        ' stockcambiartxt
        ' 
        stockcambiartxt.Location = New Point(197, 299)
        stockcambiartxt.Name = "stockcambiartxt"
        stockcambiartxt.Size = New Size(46, 23)
        stockcambiartxt.TabIndex = 20
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.GhostWhite
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F)
        Button2.ForeColor = Color.GhostWhite
        Button2.Image = My.Resources.Resources.eliminar2
        Button2.Location = New Point(156, 298)
        Button2.Name = "Button2"
        Button2.Size = New Size(22, 23)
        Button2.TabIndex = 26
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.GhostWhite
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.ForeColor = Color.GhostWhite
        Button1.Image = My.Resources.Resources.añadir2
        Button1.Location = New Point(249, 298)
        Button1.Name = "Button1"
        Button1.Size = New Size(22, 23)
        Button1.TabIndex = 25
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Mongolian Baiti", 11F)
        Label6.Location = New Point(38, 300)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 16)
        Label6.TabIndex = 24
        Label6.Text = "Actualizar stock:"
        ' 
        ' nombreinsumolbl
        ' 
        nombreinsumolbl.AutoSize = True
        nombreinsumolbl.Font = New Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nombreinsumolbl.Location = New Point(105, 15)
        nombreinsumolbl.Name = "nombreinsumolbl"
        nombreinsumolbl.Size = New Size(149, 16)
        nombreinsumolbl.TabIndex = 23
        nombreinsumolbl.Text = "Nombre del insumo"
        ' 
        ' stockvalorizadolbl
        ' 
        stockvalorizadolbl.AutoSize = True
        stockvalorizadolbl.BackColor = Color.White
        stockvalorizadolbl.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        stockvalorizadolbl.ForeColor = Color.Black
        stockvalorizadolbl.Location = New Point(249, 351)
        stockvalorizadolbl.Name = "stockvalorizadolbl"
        stockvalorizadolbl.Size = New Size(15, 17)
        stockvalorizadolbl.TabIndex = 22
        stockvalorizadolbl.Text = "0"
        ' 
        ' stockminlbl
        ' 
        stockminlbl.AutoSize = True
        stockminlbl.BackColor = Color.White
        stockminlbl.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        stockminlbl.ForeColor = Color.Black
        stockminlbl.Location = New Point(145, 351)
        stockminlbl.Name = "stockminlbl"
        stockminlbl.Size = New Size(15, 17)
        stockminlbl.TabIndex = 21
        stockminlbl.Text = "0"
        ' 
        ' stockactuallbl
        ' 
        stockactuallbl.AutoSize = True
        stockactuallbl.BackColor = Color.White
        stockactuallbl.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        stockactuallbl.ForeColor = Color.Black
        stockactuallbl.Location = New Point(40, 351)
        stockactuallbl.Name = "stockactuallbl"
        stockactuallbl.Size = New Size(15, 17)
        stockactuallbl.TabIndex = 20
        stockactuallbl.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Mongolian Baiti", 11F)
        Label5.Location = New Point(228, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 16)
        Label5.TabIndex = 19
        Label5.Text = "Stock Val. :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 11F)
        Label3.Location = New Point(128, 325)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 16)
        Label3.TabIndex = 18
        Label3.Text = "StockMin:"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(dgvrecientes)
        Panel4.Location = New Point(19, 564)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1147, 124)
        Panel4.TabIndex = 19
        ' 
        ' dgvrecientes
        ' 
        dgvrecientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvrecientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvrecientes.Dock = DockStyle.Fill
        dgvrecientes.Location = New Point(0, 0)
        dgvrecientes.MultiSelect = False
        dgvrecientes.Name = "dgvrecientes"
        dgvrecientes.ReadOnly = True
        dgvrecientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvrecientes.Size = New Size(1147, 124)
        dgvrecientes.TabIndex = 5
        ' 
        ' UCinsumos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(labeltexto)
        Controls.Add(dgwinsumos)
        Name = "UCinsumos"
        Size = New Size(1224, 713)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgwinsumos, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(dgvrecientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents combocategoria As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dashboardbtn As Button
    Friend WithEvents dtphasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents stocklbl As Label
    Friend WithEvents buscartxt As TextBox
    Friend WithEvents buscarlbl As Label
    Friend WithEvents labeltexto As Label
    Friend WithEvents dgwinsumos As DataGridView
    Friend WithEvents insumostotaleslbl As Label
    Friend WithEvents label4 As Label
    Friend WithEvents registrarmovi As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents categorialbl As Label
    Friend WithEvents stockvalorizadolbl As Label
    Friend WithEvents stockminlbl As Label
    Friend WithEvents stockactuallbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nombreinsumolbl As Label
    Private WithEvents descripciontxt As TextBox
    Friend WithEvents dgvrecientes As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents stockcambiartxt As TextBox

End Class
