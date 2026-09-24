<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCproductosañadir
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
        Validacioncategoria = New Label()
        validacioncheckbox = New Label()
        GroupBox1 = New GroupBox()
        reventaradio = New RadioButton()
        confeccionadoradio = New RadioButton()
        Label2 = New Label()
        categoriabox = New ComboBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        eliminarbtn = New Button()
        Editarcat = New Button()
        nombreproducto = New TextBox()
        Label3 = New Label()
        descripciontxt = New TextBox()
        buscarlbl = New Label()
        validacionproductolbl = New Label()
        Button1 = New Button()
        dgwproducto = New DataGridView()
        Button2 = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgwproducto, ComponentModel.ISupportInitialize).BeginInit()
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
        labeltexto.Size = New Size(754, 38)
        labeltexto.TabIndex = 1
        labeltexto.Text = "     AÑADIR PRODUCTO"
        labeltexto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.GhostWhite
        Panel1.Controls.Add(Validacioncategoria)
        Panel1.Controls.Add(validacioncheckbox)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(categoriabox)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(eliminarbtn)
        Panel1.Controls.Add(Editarcat)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(368, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(386, 440)
        Panel1.TabIndex = 2
        ' 
        ' Validacioncategoria
        ' 
        Validacioncategoria.Font = New Font("Yu Gothic UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Validacioncategoria.Location = New Point(197, 42)
        Validacioncategoria.Name = "Validacioncategoria"
        Validacioncategoria.Size = New Size(141, 16)
        Validacioncategoria.TabIndex = 77
        ' 
        ' validacioncheckbox
        ' 
        validacioncheckbox.Font = New Font("Yu Gothic UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        validacioncheckbox.Location = New Point(170, 96)
        validacioncheckbox.Name = "validacioncheckbox"
        validacioncheckbox.Size = New Size(141, 16)
        validacioncheckbox.TabIndex = 70
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(reventaradio)
        GroupBox1.Controls.Add(confeccionadoradio)
        GroupBox1.Location = New Point(49, 114)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(207, 50)
        GroupBox1.TabIndex = 76
        GroupBox1.TabStop = False
        ' 
        ' reventaradio
        ' 
        reventaradio.AutoSize = True
        reventaradio.BackColor = Color.Lavender
        reventaradio.Font = New Font("Segoe UI", 9F, FontStyle.Italic Or FontStyle.Underline)
        reventaradio.Location = New Point(112, 22)
        reventaradio.Name = "reventaradio"
        reventaradio.Size = New Size(68, 19)
        reventaradio.TabIndex = 3
        reventaradio.TabStop = True
        reventaradio.Text = "Reventa"
        reventaradio.UseVisualStyleBackColor = False
        ' 
        ' confeccionadoradio
        ' 
        confeccionadoradio.AutoSize = True
        confeccionadoradio.BackColor = Color.Lavender
        confeccionadoradio.Font = New Font("Segoe UI", 9F, FontStyle.Italic Or FontStyle.Underline)
        confeccionadoradio.Location = New Point(4, 22)
        confeccionadoradio.Name = "confeccionadoradio"
        confeccionadoradio.Size = New Size(102, 19)
        confeccionadoradio.TabIndex = 2
        confeccionadoradio.TabStop = True
        confeccionadoradio.Text = "Confeccionado"
        confeccionadoradio.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 11F)
        Label2.Location = New Point(25, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 16)
        Label2.TabIndex = 75
        Label2.Text = "Tipo de producto"
        ' 
        ' categoriabox
        ' 
        categoriabox.FormattingEnabled = True
        categoriabox.Location = New Point(25, 39)
        categoriabox.Name = "categoriabox"
        categoriabox.Size = New Size(130, 23)
        categoriabox.TabIndex = 73
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 11F)
        Label1.Location = New Point(25, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 16)
        Label1.TabIndex = 74
        Label1.Text = "Categoria asociada"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(25, 170)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(328, 169)
        PictureBox1.TabIndex = 72
        PictureBox1.TabStop = False
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
        eliminarbtn.Location = New Point(31, 366)
        eliminarbtn.Name = "eliminarbtn"
        eliminarbtn.Size = New Size(148, 28)
        eliminarbtn.TabIndex = 59
        eliminarbtn.Text = "Eliminar Insumo"
        eliminarbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        eliminarbtn.UseVisualStyleBackColor = False
        ' 
        ' Editarcat
        ' 
        Editarcat.BackColor = Color.Lavender
        Editarcat.FlatAppearance.BorderSize = 0
        Editarcat.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Editarcat.FlatStyle = FlatStyle.Flat
        Editarcat.Font = New Font("Segoe UI", 10F)
        Editarcat.ForeColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Editarcat.Image = My.Resources.Resources.añadir2
        Editarcat.ImageAlign = ContentAlignment.TopLeft
        Editarcat.Location = New Point(202, 366)
        Editarcat.Name = "Editarcat"
        Editarcat.Size = New Size(148, 28)
        Editarcat.TabIndex = 61
        Editarcat.Text = "Añadir producto"
        Editarcat.TextImageRelation = TextImageRelation.ImageBeforeText
        Editarcat.UseVisualStyleBackColor = False
        ' 
        ' nombreproducto
        ' 
        nombreproducto.BackColor = Color.Lavender
        nombreproducto.Location = New Point(12, 77)
        nombreproducto.Name = "nombreproducto"
        nombreproducto.PlaceholderText = "Nombre del producto"
        nombreproducto.Size = New Size(334, 23)
        nombreproducto.TabIndex = 68
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 11F)
        Label3.Location = New Point(12, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 16)
        Label3.TabIndex = 63
        Label3.Text = "Descripción"
        ' 
        ' descripciontxt
        ' 
        descripciontxt.BackColor = Color.Lavender
        descripciontxt.Location = New Point(12, 152)
        descripciontxt.Multiline = True
        descripciontxt.Name = "descripciontxt"
        descripciontxt.PlaceholderText = "Descripción del producto. Por ejemplo: Mochila, remera, top, etc..."
        descripciontxt.Size = New Size(334, 98)
        descripciontxt.TabIndex = 60
        ' 
        ' buscarlbl
        ' 
        buscarlbl.AutoSize = True
        buscarlbl.Font = New Font("Mongolian Baiti", 11F)
        buscarlbl.Location = New Point(12, 58)
        buscarlbl.Name = "buscarlbl"
        buscarlbl.Size = New Size(141, 16)
        buscarlbl.TabIndex = 57
        buscarlbl.Text = "Nombre del producto"
        ' 
        ' validacionproductolbl
        ' 
        validacionproductolbl.Font = New Font("Yu Gothic UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        validacionproductolbl.Location = New Point(12, 103)
        validacionproductolbl.Name = "validacionproductolbl"
        validacionproductolbl.Size = New Size(141, 16)
        validacionproductolbl.TabIndex = 69
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Button1.Font = New Font("Segoe UI", 11F)
        Button1.ForeColor = Color.GhostWhite
        Button1.Image = My.Resources.Resources.volver
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(12, 399)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 38)
        Button1.TabIndex = 70
        Button1.Text = "Volver"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dgwproducto
        ' 
        dgwproducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwproducto.Location = New Point(12, 269)
        dgwproducto.MultiSelect = False
        dgwproducto.Name = "dgwproducto"
        dgwproducto.ReadOnly = True
        dgwproducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgwproducto.Size = New Size(334, 108)
        dgwproducto.TabIndex = 71
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Button2.Font = New Font("Segoe UI", 11F)
        Button2.ForeColor = Color.GhostWhite
        Button2.Image = My.Resources.Resources.modificar
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(239, 399)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 38)
        Button2.TabIndex = 72
        Button2.Text = "Modificar"
        Button2.TextImageRelation = TextImageRelation.TextBeforeImage
        Button2.UseVisualStyleBackColor = False
        ' 
        ' UCproductosañadir
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(754, 478)
        Controls.Add(Button2)
        Controls.Add(dgwproducto)
        Controls.Add(Button1)
        Controls.Add(validacionproductolbl)
        Controls.Add(nombreproducto)
        Controls.Add(Label3)
        Controls.Add(descripciontxt)
        Controls.Add(buscarlbl)
        Controls.Add(Panel1)
        Controls.Add(labeltexto)
        Name = "UCproductosañadir"
        Text = "Añadir productox"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgwproducto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents errorcodigo As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents labeltexto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents eliminarbtn As Button
    Friend WithEvents Editarcat As Button
    Friend WithEvents categoriabox As ComboBox
    Friend WithEvents nombreproducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents descripciontxt As TextBox
    Friend WithEvents buscarlbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Validacioncategoria As Label
    Friend WithEvents validacioncheckbox As Label
    Friend WithEvents validacionproductolbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents confeccionadoradio As RadioButton
    Friend WithEvents reventaradio As RadioButton
    Friend WithEvents dgwproducto As DataGridView
    Friend WithEvents Button2 As Button

End Class
