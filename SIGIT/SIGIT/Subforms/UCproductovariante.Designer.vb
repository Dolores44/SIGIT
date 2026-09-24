<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCproductovariante
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
        Label3 = New Label()
        talletxt = New TextBox()
        validacionstockactuallbl = New Label()
        validaiconstockminimolbl = New Label()
        validacionprecioventalbl = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        Label8 = New Label()
        Label6 = New Label()
        stactutxt = New TextBox()
        Label7 = New Label()
        stmintxt = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        prventatxt = New TextBox()
        Label2 = New Label()
        comboproducto = New ComboBox()
        Label1 = New Label()
        Volver = New Button()
        carectxt = New TextBox()
        colortxt = New TextBox()
        eliminarbtn = New Button()
        buscarlbl = New Label()
        Panel2 = New Panel()
        productovarianteficha = New Label()
        Label22 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        añdinsumopr = New Button()
        dgwinsumos = New DataGridView()
        Label21 = New Label()
        ComboBox1 = New ComboBox()
        cantidadinsumos = New TextBox()
        Label20 = New Label()
        Label19 = New Label()
        cantinsumoslbl = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgwinsumos, ComponentModel.ISupportInitialize).BeginInit()
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
        labeltexto.Size = New Size(1201, 38)
        labeltexto.TabIndex = 1
        labeltexto.Text = "     SECCIÒN AÑADIR UNA VARIANTE Y SU FICHA"
        labeltexto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(talletxt)
        Panel1.Controls.Add(validacionstockactuallbl)
        Panel1.Controls.Add(validaiconstockminimolbl)
        Panel1.Controls.Add(validacionprecioventalbl)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(stactutxt)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(stmintxt)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(prventatxt)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(comboproducto)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Volver)
        Panel1.Controls.Add(carectxt)
        Panel1.Controls.Add(colortxt)
        Panel1.Controls.Add(eliminarbtn)
        Panel1.Controls.Add(buscarlbl)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(487, 715)
        Panel1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 11F)
        Label3.Location = New Point(320, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 16)
        Label3.TabIndex = 74
        Label3.Text = "Talle"
        ' 
        ' talletxt
        ' 
        talletxt.BackColor = Color.Lavender
        talletxt.Location = New Point(320, 219)
        talletxt.Name = "talletxt"
        talletxt.PlaceholderText = "N. stock actual"
        talletxt.Size = New Size(142, 23)
        talletxt.TabIndex = 73
        ' 
        ' validacionstockactuallbl
        ' 
        validacionstockactuallbl.Font = New Font("Yu Gothic UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        validacionstockactuallbl.Location = New Point(320, 171)
        validacionstockactuallbl.Name = "validacionstockactuallbl"
        validacionstockactuallbl.Size = New Size(141, 16)
        validacionstockactuallbl.TabIndex = 72
        ' 
        ' validaiconstockminimolbl
        ' 
        validaiconstockminimolbl.Font = New Font("Yu Gothic UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        validaiconstockminimolbl.Location = New Point(21, 245)
        validaiconstockminimolbl.Name = "validaiconstockminimolbl"
        validaiconstockminimolbl.Size = New Size(141, 16)
        validaiconstockminimolbl.TabIndex = 71
        ' 
        ' validacionprecioventalbl
        ' 
        validacionprecioventalbl.Font = New Font("Yu Gothic UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        validacionprecioventalbl.Location = New Point(320, 95)
        validacionprecioventalbl.Name = "validacionprecioventalbl"
        validacionprecioventalbl.Size = New Size(141, 16)
        validacionprecioventalbl.TabIndex = 70
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Mongolian Baiti", 11F)
        Label14.Location = New Point(367, 502)
        Label14.Name = "Label14"
        Label14.Size = New Size(12, 16)
        Label14.TabIndex = 39
        Label14.Text = "-"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Mongolian Baiti", 11F)
        Label15.Location = New Point(367, 620)
        Label15.Name = "Label15"
        Label15.Size = New Size(12, 16)
        Label15.TabIndex = 38
        Label15.Text = "-"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Mongolian Baiti", 11F)
        Label16.Location = New Point(367, 561)
        Label16.Name = "Label16"
        Label16.Size = New Size(12, 16)
        Label16.TabIndex = 37
        Label16.Text = "-"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Mongolian Baiti", 11F)
        Label17.Location = New Point(367, 443)
        Label17.Name = "Label17"
        Label17.Size = New Size(12, 16)
        Label17.TabIndex = 36
        Label17.Text = "-"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Mongolian Baiti", 11F)
        Label18.Location = New Point(367, 384)
        Label18.Name = "Label18"
        Label18.Size = New Size(12, 16)
        Label18.TabIndex = 35
        Label18.Text = "-"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Mongolian Baiti", 12F)
        Label10.Location = New Point(241, 502)
        Label10.Name = "Label10"
        Label10.Size = New Size(84, 16)
        Label10.TabIndex = 34
        Label10.Text = "Stock actual"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Mongolian Baiti", 12F)
        Label11.Location = New Point(241, 620)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 16)
        Label11.TabIndex = 33
        Label11.Text = "Color"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Mongolian Baiti", 12F)
        Label12.Location = New Point(241, 561)
        Label12.Name = "Label12"
        Label12.Size = New Size(104, 16)
        Label12.TabIndex = 32
        Label12.Text = "Precio de venta"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Mongolian Baiti", 12F)
        Label13.Location = New Point(241, 443)
        Label13.Name = "Label13"
        Label13.Size = New Size(43, 16)
        Label13.TabIndex = 31
        Label13.Text = "Color"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Mongolian Baiti", 12F)
        Label9.Location = New Point(241, 384)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 16)
        Label9.TabIndex = 30
        Label9.Text = "Producto"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(20, 372)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 266)
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Mongolian Baiti", 13F)
        Label8.Location = New Point(166, 345)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 19)
        Label8.TabIndex = 28
        Label8.Text = "Vista previa de lista"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Mongolian Baiti", 11F)
        Label6.Location = New Point(320, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 16)
        Label6.TabIndex = 26
        Label6.Text = "Stock actual"
        ' 
        ' stactutxt
        ' 
        stactutxt.BackColor = Color.Lavender
        stactutxt.Location = New Point(320, 145)
        stactutxt.Name = "stactutxt"
        stactutxt.PlaceholderText = "N. stock actual"
        stactutxt.Size = New Size(142, 23)
        stactutxt.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Mongolian Baiti", 11F)
        Label7.Location = New Point(20, 200)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 16)
        Label7.TabIndex = 24
        Label7.Text = "Stock Minimo"
        ' 
        ' stmintxt
        ' 
        stmintxt.BackColor = Color.Lavender
        stmintxt.Location = New Point(20, 219)
        stmintxt.Name = "stmintxt"
        stmintxt.PlaceholderText = "N. stockminimo"
        stmintxt.Size = New Size(192, 23)
        stmintxt.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Mongolian Baiti", 11F)
        Label5.Location = New Point(20, 268)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 16)
        Label5.TabIndex = 22
        Label5.Text = "Caracteristicas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Mongolian Baiti", 11F)
        Label4.Location = New Point(320, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 16)
        Label4.TabIndex = 21
        Label4.Text = "Precio de venta"
        ' 
        ' prventatxt
        ' 
        prventatxt.BackColor = Color.Lavender
        prventatxt.Location = New Point(320, 69)
        prventatxt.Name = "prventatxt"
        prventatxt.PlaceholderText = "Numeros"
        prventatxt.Size = New Size(142, 23)
        prventatxt.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 11F)
        Label2.Location = New Point(20, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 16)
        Label2.TabIndex = 19
        Label2.Text = "Color"
        ' 
        ' comboproducto
        ' 
        comboproducto.BackColor = Color.Lavender
        comboproducto.FormattingEnabled = True
        comboproducto.Location = New Point(20, 69)
        comboproducto.Name = "comboproducto"
        comboproducto.Size = New Size(142, 23)
        comboproducto.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 11F)
        Label1.Location = New Point(20, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 16)
        Label1.TabIndex = 16
        Label1.Text = "Producto"
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
        Volver.Location = New Point(12, 660)
        Volver.Name = "Volver"
        Volver.Size = New Size(148, 28)
        Volver.TabIndex = 15
        Volver.Text = "Cancelar"
        Volver.TextImageRelation = TextImageRelation.ImageBeforeText
        Volver.UseVisualStyleBackColor = False
        ' 
        ' carectxt
        ' 
        carectxt.BackColor = Color.Lavender
        carectxt.Location = New Point(20, 287)
        carectxt.Multiline = True
        carectxt.Name = "carectxt"
        carectxt.PlaceholderText = "Caracteristica"
        carectxt.Size = New Size(448, 54)
        carectxt.TabIndex = 13
        ' 
        ' colortxt
        ' 
        colortxt.BackColor = Color.Lavender
        colortxt.Location = New Point(20, 145)
        colortxt.Name = "colortxt"
        colortxt.PlaceholderText = "Color, cualquiera"
        colortxt.Size = New Size(192, 23)
        colortxt.TabIndex = 12
        ' 
        ' eliminarbtn
        ' 
        eliminarbtn.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        eliminarbtn.FlatAppearance.BorderSize = 0
        eliminarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        eliminarbtn.FlatStyle = FlatStyle.Flat
        eliminarbtn.Font = New Font("Segoe UI", 10F)
        eliminarbtn.ForeColor = Color.GhostWhite
        eliminarbtn.Image = My.Resources.Resources.añadir
        eliminarbtn.ImageAlign = ContentAlignment.TopLeft
        eliminarbtn.Location = New Point(320, 660)
        eliminarbtn.Name = "eliminarbtn"
        eliminarbtn.Size = New Size(148, 28)
        eliminarbtn.TabIndex = 11
        eliminarbtn.Text = "Añadir producto variante"
        eliminarbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        eliminarbtn.UseVisualStyleBackColor = False
        ' 
        ' buscarlbl
        ' 
        buscarlbl.AutoSize = True
        buscarlbl.Font = New Font("Mongolian Baiti", 15F)
        buscarlbl.Location = New Point(20, 12)
        buscarlbl.Name = "buscarlbl"
        buscarlbl.Size = New Size(208, 21)
        buscarlbl.TabIndex = 1
        buscarlbl.Text = "Producto y sus variantes"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cantinsumoslbl)
        Panel2.Controls.Add(productovarianteficha)
        Panel2.Controls.Add(Label22)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(añdinsumopr)
        Panel2.Controls.Add(dgwinsumos)
        Panel2.Controls.Add(Label21)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(cantidadinsumos)
        Panel2.Controls.Add(Label20)
        Panel2.Controls.Add(Label19)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(487, 38)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(718, 715)
        Panel2.TabIndex = 4
        ' 
        ' productovarianteficha
        ' 
        productovarianteficha.AutoSize = True
        productovarianteficha.CausesValidation = False
        productovarianteficha.Font = New Font("Mongolian Baiti", 12F)
        productovarianteficha.Location = New Point(371, 16)
        productovarianteficha.Name = "productovarianteficha"
        productovarianteficha.Size = New Size(12, 16)
        productovarianteficha.TabIndex = 31
        productovarianteficha.Text = "-"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Mongolian Baiti", 11F)
        Label22.Location = New Point(48, 55)
        Label22.Name = "Label22"
        Label22.Size = New Size(95, 16)
        Label22.TabIndex = 45
        Label22.Text = "Insumo receta"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Lavender
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F)
        Button2.ForeColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Button2.Image = My.Resources.Resources.eliminar2
        Button2.ImageAlign = ContentAlignment.TopLeft
        Button2.Location = New Point(62, 660)
        Button2.Name = "Button2"
        Button2.Size = New Size(148, 28)
        Button2.TabIndex = 44
        Button2.Text = "Eliminar insumo"
        Button2.TextImageRelation = TextImageRelation.ImageBeforeText
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lavender
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.ForeColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Button1.Image = My.Resources.Resources.cambiar
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(527, 660)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 28)
        Button1.TabIndex = 43
        Button1.Text = "Cambiar insumo"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' añdinsumopr
        ' 
        añdinsumopr.BackColor = Color.Lavender
        añdinsumopr.FlatAppearance.BorderSize = 0
        añdinsumopr.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        añdinsumopr.FlatStyle = FlatStyle.Flat
        añdinsumopr.Font = New Font("Segoe UI", 10F)
        añdinsumopr.ForeColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        añdinsumopr.Image = My.Resources.Resources.añadir2
        añdinsumopr.ImageAlign = ContentAlignment.TopLeft
        añdinsumopr.Location = New Point(527, 69)
        añdinsumopr.Name = "añdinsumopr"
        añdinsumopr.Size = New Size(148, 28)
        añdinsumopr.TabIndex = 40
        añdinsumopr.Text = "Añadir insumo"
        añdinsumopr.TextImageRelation = TextImageRelation.ImageBeforeText
        añdinsumopr.UseVisualStyleBackColor = False
        ' 
        ' dgwinsumos
        ' 
        dgwinsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwinsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwinsumos.Location = New Point(48, 126)
        dgwinsumos.MultiSelect = False
        dgwinsumos.Name = "dgwinsumos"
        dgwinsumos.ReadOnly = True
        dgwinsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgwinsumos.Size = New Size(627, 438)
        dgwinsumos.TabIndex = 42
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Mongolian Baiti", 11F)
        Label21.Location = New Point(375, 55)
        Label21.Name = "Label21"
        Label21.Size = New Size(63, 16)
        Label21.TabIndex = 41
        Label21.Text = "Cantidad"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.Lavender
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(48, 74)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(192, 23)
        ComboBox1.TabIndex = 41
        ' 
        ' cantidadinsumos
        ' 
        cantidadinsumos.BackColor = Color.Lavender
        cantidadinsumos.Location = New Point(307, 74)
        cantidadinsumos.Name = "cantidadinsumos"
        cantidadinsumos.PlaceholderText = "Cantidad de insumo"
        cantidadinsumos.Size = New Size(192, 23)
        cantidadinsumos.TabIndex = 40
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Mongolian Baiti", 11F)
        Label20.Location = New Point(-407, 846)
        Label20.Name = "Label20"
        Label20.Size = New Size(63, 16)
        Label20.TabIndex = 40
        Label20.Text = "Producto"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Mongolian Baiti", 15F)
        Label19.Location = New Point(235, 12)
        Label19.Name = "Label19"
        Label19.Size = New Size(130, 21)
        Label19.TabIndex = 40
        Label19.Text = "Ficha Tecnica:"
        ' 
        ' cantinsumoslbl
        ' 
        cantinsumoslbl.Font = New Font("Yu Gothic UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        cantinsumoslbl.Location = New Point(307, 100)
        cantinsumoslbl.Name = "cantinsumoslbl"
        cantinsumoslbl.Size = New Size(141, 16)
        cantinsumoslbl.TabIndex = 73
        ' 
        ' UCproductovariante
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(1201, 753)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(labeltexto)
        Name = "UCproductovariante"
        Text = "Añadir cositas ah"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgwinsumos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents labeltexto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Volver As Button
    Friend WithEvents carectxt As TextBox
    Friend WithEvents colortxt As TextBox
    Friend WithEvents eliminarbtn As Button
    Friend WithEvents buscarlbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents comboproducto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents prventatxt As TextBox
    Friend WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Friend WithEvents stactutxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents stmintxt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Private WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Private WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cantidadinsumos As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents añdinsumopr As Button
    Friend WithEvents dgwinsumos As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents productovarianteficha As Label
    Friend WithEvents validacionprecioventalbl As Label
    Private WithEvents Label3 As Label
    Friend WithEvents talletxt As TextBox
    Friend WithEvents validacionstockactuallbl As Label
    Friend WithEvents validaiconstockminimolbl As Label
    Friend WithEvents cantinsumoslbl As Label

End Class
