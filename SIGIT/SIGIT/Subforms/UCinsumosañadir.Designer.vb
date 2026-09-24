<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCinsumosañadir
    Inherits System.Windows.Forms.Form

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
        labeltexto = New Label()
        Panel1 = New Panel()
        categoriabox = New ComboBox()
        lblerrorcu = New Label()
        lblerrorunidadm = New Label()
        lblerrorcategoria = New Label()
        lblerrorsma = New Label()
        lblerrorsta = New Label()
        lblerrorinsumo = New Label()
        PictureBox1 = New PictureBox()
        unidadcombobox = New ComboBox()
        costoUnitxt = New TextBox()
        Stockmintxt = New TextBox()
        nombreinsumo = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        lblerrorcat = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Volver = New Button()
        Editarcat = New Button()
        descripciontxt = New TextBox()
        eliminarbtn = New Button()
        Añadirbtn = New Button()
        Label2 = New Label()
        stockacttxt = New TextBox()
        buscarlbl = New Label()
        Panel2 = New Panel()
        FLPproductos = New FlowLayoutPanel()
        dgwcat = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        FLPproductos.SuspendLayout()
        CType(dgwcat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        labeltexto.Size = New Size(1208, 38)
        labeltexto.TabIndex = 1
        labeltexto.Text = "     AÑADIR INSUMOS"
        labeltexto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(categoriabox)
        Panel1.Controls.Add(lblerrorcu)
        Panel1.Controls.Add(lblerrorunidadm)
        Panel1.Controls.Add(lblerrorcategoria)
        Panel1.Controls.Add(lblerrorsma)
        Panel1.Controls.Add(lblerrorsta)
        Panel1.Controls.Add(lblerrorinsumo)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(unidadcombobox)
        Panel1.Controls.Add(costoUnitxt)
        Panel1.Controls.Add(Stockmintxt)
        Panel1.Controls.Add(nombreinsumo)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblerrorcat)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Volver)
        Panel1.Controls.Add(Editarcat)
        Panel1.Controls.Add(descripciontxt)
        Panel1.Controls.Add(eliminarbtn)
        Panel1.Controls.Add(Añadirbtn)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(stockacttxt)
        Panel1.Controls.Add(buscarlbl)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1208, 289)
        Panel1.TabIndex = 2
        ' 
        ' categoriabox
        ' 
        categoriabox.FormattingEnabled = True
        categoriabox.Location = New Point(301, 39)
        categoriabox.Name = "categoriabox"
        categoriabox.Size = New Size(111, 23)
        categoriabox.TabIndex = 37
        ' 
        ' lblerrorcu
        ' 
        lblerrorcu.Font = New Font("Mongolian Baiti", 8F)
        lblerrorcu.ForeColor = Color.Gray
        lblerrorcu.Location = New Point(678, 111)
        lblerrorcu.Name = "lblerrorcu"
        lblerrorcu.Size = New Size(83, 16)
        lblerrorcu.TabIndex = 36
        ' 
        ' lblerrorunidadm
        ' 
        lblerrorunidadm.Font = New Font("Mongolian Baiti", 8F)
        lblerrorunidadm.ForeColor = Color.Gray
        lblerrorunidadm.Location = New Point(678, 46)
        lblerrorunidadm.Name = "lblerrorunidadm"
        lblerrorunidadm.Size = New Size(83, 16)
        lblerrorunidadm.TabIndex = 35
        ' 
        ' lblerrorcategoria
        ' 
        lblerrorcategoria.Font = New Font("Mongolian Baiti", 8F)
        lblerrorcategoria.ForeColor = Color.Gray
        lblerrorcategoria.Location = New Point(440, 46)
        lblerrorcategoria.Name = "lblerrorcategoria"
        lblerrorcategoria.Size = New Size(83, 16)
        lblerrorcategoria.TabIndex = 34
        ' 
        ' lblerrorsma
        ' 
        lblerrorsma.Font = New Font("Mongolian Baiti", 8F)
        lblerrorsma.ForeColor = Color.Gray
        lblerrorsma.Location = New Point(440, 109)
        lblerrorsma.Name = "lblerrorsma"
        lblerrorsma.Size = New Size(83, 16)
        lblerrorsma.TabIndex = 33
        ' 
        ' lblerrorsta
        ' 
        lblerrorsta.Font = New Font("Mongolian Baiti", 8F)
        lblerrorsta.ForeColor = Color.Gray
        lblerrorsta.Location = New Point(153, 109)
        lblerrorsta.Name = "lblerrorsta"
        lblerrorsta.Size = New Size(83, 16)
        lblerrorsta.TabIndex = 32
        ' 
        ' lblerrorinsumo
        ' 
        lblerrorinsumo.Font = New Font("Mongolian Baiti", 8F)
        lblerrorinsumo.ForeColor = Color.Gray
        lblerrorinsumo.Location = New Point(153, 46)
        lblerrorinsumo.Name = "lblerrorinsumo"
        lblerrorinsumo.Size = New Size(83, 16)
        lblerrorinsumo.TabIndex = 31
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(872, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(258, 175)
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' unidadcombobox
        ' 
        unidadcombobox.FormattingEnabled = True
        unidadcombobox.Location = New Point(567, 42)
        unidadcombobox.Name = "unidadcombobox"
        unidadcombobox.Size = New Size(111, 23)
        unidadcombobox.TabIndex = 29
        ' 
        ' costoUnitxt
        ' 
        costoUnitxt.Location = New Point(561, 105)
        costoUnitxt.Name = "costoUnitxt"
        costoUnitxt.PlaceholderText = "Costo Uni"
        costoUnitxt.Size = New Size(111, 23)
        costoUnitxt.TabIndex = 28
        ' 
        ' Stockmintxt
        ' 
        Stockmintxt.Location = New Point(301, 105)
        Stockmintxt.Name = "Stockmintxt"
        Stockmintxt.PlaceholderText = "Stock Min"
        Stockmintxt.Size = New Size(133, 23)
        Stockmintxt.TabIndex = 27
        ' 
        ' nombreinsumo
        ' 
        nombreinsumo.Location = New Point(20, 42)
        nombreinsumo.Name = "nombreinsumo"
        nombreinsumo.PlaceholderText = "Nombre del insumo"
        nombreinsumo.Size = New Size(127, 23)
        nombreinsumo.TabIndex = 24
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Mongolian Baiti", 11F)
        Label7.Location = New Point(561, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 16)
        Label7.TabIndex = 23
        Label7.Text = "Costo Uni."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Mongolian Baiti", 11F)
        Label6.Location = New Point(301, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 16)
        Label6.TabIndex = 22
        Label6.Text = "Stock Min. Alerta"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Mongolian Baiti", 11F)
        Label5.Location = New Point(20, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 16)
        Label5.TabIndex = 21
        Label5.Text = "Stock actual"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Mongolian Baiti", 11F)
        Label4.Location = New Point(301, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 16)
        Label4.TabIndex = 20
        Label4.Text = "Categoria"
        ' 
        ' lblerrorcat
        ' 
        lblerrorcat.Font = New Font("Mongolian Baiti", 8F)
        lblerrorcat.ForeColor = SystemColors.AppWorkspace
        lblerrorcat.Location = New Point(20, 78)
        lblerrorcat.Name = "lblerrorcat"
        lblerrorcat.Size = New Size(192, 24)
        lblerrorcat.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 11F)
        Label3.Location = New Point(20, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 16)
        Label3.TabIndex = 17
        Label3.Text = "Descripción"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 11F)
        Label1.Location = New Point(561, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 16)
        Label1.TabIndex = 16
        Label1.Text = "Unidad de medida"
        ' 
        ' Volver
        ' 
        Volver.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Volver.FlatAppearance.BorderSize = 0
        Volver.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Volver.FlatStyle = FlatStyle.Flat
        Volver.Font = New Font("Segoe UI", 10F)
        Volver.ForeColor = Color.GhostWhite
        Volver.Image = My.Resources.Resources.volver
        Volver.ImageAlign = ContentAlignment.TopLeft
        Volver.Location = New Point(1016, 255)
        Volver.Name = "Volver"
        Volver.Size = New Size(148, 28)
        Volver.TabIndex = 15
        Volver.Text = "Volver"
        Volver.TextImageRelation = TextImageRelation.ImageBeforeText
        Volver.UseVisualStyleBackColor = False
        ' 
        ' Editarcat
        ' 
        Editarcat.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Editarcat.FlatAppearance.BorderSize = 0
        Editarcat.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Editarcat.FlatStyle = FlatStyle.Flat
        Editarcat.Font = New Font("Segoe UI", 10F)
        Editarcat.ForeColor = Color.GhostWhite
        Editarcat.Image = My.Resources.Resources.base_de_datos
        Editarcat.ImageAlign = ContentAlignment.TopLeft
        Editarcat.Location = New Point(1016, 204)
        Editarcat.Name = "Editarcat"
        Editarcat.Size = New Size(148, 28)
        Editarcat.TabIndex = 14
        Editarcat.Text = "Editar Insumo"
        Editarcat.TextImageRelation = TextImageRelation.ImageBeforeText
        Editarcat.UseVisualStyleBackColor = False
        ' 
        ' descripciontxt
        ' 
        descripciontxt.Location = New Point(20, 164)
        descripciontxt.Multiline = True
        descripciontxt.Name = "descripciontxt"
        descripciontxt.PlaceholderText = "Descripción breve del insumo"
        descripciontxt.Size = New Size(690, 54)
        descripciontxt.TabIndex = 13
        ' 
        ' eliminarbtn
        ' 
        eliminarbtn.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        eliminarbtn.FlatAppearance.BorderSize = 0
        eliminarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        eliminarbtn.FlatStyle = FlatStyle.Flat
        eliminarbtn.Font = New Font("Segoe UI", 10F)
        eliminarbtn.ForeColor = Color.GhostWhite
        eliminarbtn.Image = My.Resources.Resources.eliminar
        eliminarbtn.ImageAlign = ContentAlignment.TopLeft
        eliminarbtn.Location = New Point(831, 204)
        eliminarbtn.Name = "eliminarbtn"
        eliminarbtn.Size = New Size(148, 28)
        eliminarbtn.TabIndex = 11
        eliminarbtn.Text = "Eliminar Insumo"
        eliminarbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        eliminarbtn.UseVisualStyleBackColor = False
        ' 
        ' Añadirbtn
        ' 
        Añadirbtn.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Añadirbtn.FlatAppearance.BorderSize = 0
        Añadirbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Añadirbtn.FlatStyle = FlatStyle.Flat
        Añadirbtn.Font = New Font("Segoe UI", 10F)
        Añadirbtn.ForeColor = Color.GhostWhite
        Añadirbtn.Image = My.Resources.Resources.añadir
        Añadirbtn.ImageAlign = ContentAlignment.TopLeft
        Añadirbtn.Location = New Point(831, 255)
        Añadirbtn.Name = "Añadirbtn"
        Añadirbtn.Size = New Size(148, 28)
        Añadirbtn.TabIndex = 9
        Añadirbtn.Text = "Añadir Insumo"
        Añadirbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        Añadirbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Label2.Location = New Point(787, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(5, 214)
        Label2.TabIndex = 0
        ' 
        ' stockacttxt
        ' 
        stockacttxt.Location = New Point(20, 105)
        stockacttxt.Name = "stockacttxt"
        stockacttxt.PlaceholderText = "Stock Actu"
        stockacttxt.Size = New Size(127, 23)
        stockacttxt.TabIndex = 2
        ' 
        ' buscarlbl
        ' 
        buscarlbl.AutoSize = True
        buscarlbl.Font = New Font("Mongolian Baiti", 11F)
        buscarlbl.Location = New Point(20, 23)
        buscarlbl.Name = "buscarlbl"
        buscarlbl.Size = New Size(127, 16)
        buscarlbl.TabIndex = 1
        buscarlbl.Text = "Nombre de insumo"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.GhostWhite
        Panel2.Controls.Add(FLPproductos)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 327)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1208, 347)
        Panel2.TabIndex = 3
        ' 
        ' FLPproductos
        ' 
        FLPproductos.Controls.Add(dgwcat)
        FLPproductos.Dock = DockStyle.Fill
        FLPproductos.Location = New Point(0, 0)
        FLPproductos.Name = "FLPproductos"
        FLPproductos.Size = New Size(1208, 347)
        FLPproductos.TabIndex = 12
        ' 
        ' dgwcat
        ' 
        dgwcat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwcat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwcat.Dock = DockStyle.Bottom
        dgwcat.Location = New Point(3, 3)
        dgwcat.MultiSelect = False
        dgwcat.Name = "dgwcat"
        dgwcat.ReadOnly = True
        dgwcat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgwcat.Size = New Size(1086, 330)
        dgwcat.TabIndex = 1
        ' 
        ' UCinsumosañadir
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(1208, 674)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(labeltexto)
        Name = "UCinsumosañadir"
        Text = "Añadir categorias"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        FLPproductos.ResumeLayout(False)
        CType(dgwcat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents labeltexto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Añadirbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents stockacttxt As TextBox
    Friend WithEvents buscarlbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents eliminarbtn As Button
    Friend WithEvents FLPproductos As FlowLayoutPanel
    Friend WithEvents Editarcat As Button
    Friend WithEvents descripciontxt As TextBox
    Friend WithEvents Volver As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblerrorcat As Label
    Friend WithEvents errorcodigo As Label
    Friend WithEvents dgwcat As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents nombreinsumo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents costoUnitxt As TextBox
    Friend WithEvents Stockmintxt As TextBox
    Friend WithEvents unidadcombobox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblerrorcu As Label
    Friend WithEvents lblerrorunidadm As Label
    Friend WithEvents lblerrorcategoria As Label
    Friend WithEvents lblerrorsma As Label
    Friend WithEvents lblerrorsta As Label
    Friend WithEvents lblerrorinsumo As Label
    Friend WithEvents categoriabox As ComboBox

End Class
