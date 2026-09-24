<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCcategorias
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
        errorcodigo = New Label()
        lblerrorcat = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Volver = New Button()
        Editarcat = New Button()
        descripciontxt = New TextBox()
        codigotxt = New TextBox()
        eliminarbtn = New Button()
        Añadirbtn = New Button()
        Label2 = New Label()
        categoriatxt = New TextBox()
        buscarlbl = New Label()
        Panel2 = New Panel()
        FLPproductos = New FlowLayoutPanel()
        dgwcat = New DataGridView()
        Panel1.SuspendLayout()
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
        labeltexto.Text = "     SECCIÒN AÑADIR UNA CATEGORIA"
        labeltexto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(errorcodigo)
        Panel1.Controls.Add(lblerrorcat)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Volver)
        Panel1.Controls.Add(Editarcat)
        Panel1.Controls.Add(descripciontxt)
        Panel1.Controls.Add(codigotxt)
        Panel1.Controls.Add(eliminarbtn)
        Panel1.Controls.Add(Añadirbtn)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(categoriatxt)
        Panel1.Controls.Add(buscarlbl)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1208, 204)
        Panel1.TabIndex = 2
        ' 
        ' errorcodigo
        ' 
        errorcodigo.Font = New Font("Mongolian Baiti", 8F)
        errorcodigo.ForeColor = SystemColors.AppWorkspace
        errorcodigo.Location = New Point(469, 74)
        errorcodigo.Name = "errorcodigo"
        errorcodigo.Size = New Size(192, 26)
        errorcodigo.TabIndex = 19
        ' 
        ' lblerrorcat
        ' 
        lblerrorcat.Font = New Font("Mongolian Baiti", 8F)
        lblerrorcat.ForeColor = SystemColors.AppWorkspace
        lblerrorcat.Location = New Point(20, 74)
        lblerrorcat.Name = "lblerrorcat"
        lblerrorcat.Size = New Size(192, 24)
        lblerrorcat.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Mongolian Baiti", 11F)
        Label3.Location = New Point(20, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 16)
        Label3.TabIndex = 17
        Label3.Text = "Descripción"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 11F)
        Label1.Location = New Point(479, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 16)
        Label1.TabIndex = 16
        Label1.Text = "Codigo de la Categoría"
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
        Volver.Location = New Point(1016, 121)
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
        Editarcat.Location = New Point(1016, 56)
        Editarcat.Name = "Editarcat"
        Editarcat.Size = New Size(148, 28)
        Editarcat.TabIndex = 14
        Editarcat.Text = "Editar Categoría"
        Editarcat.TextImageRelation = TextImageRelation.ImageBeforeText
        Editarcat.UseVisualStyleBackColor = False
        ' 
        ' descripciontxt
        ' 
        descripciontxt.Location = New Point(20, 125)
        descripciontxt.Multiline = True
        descripciontxt.Name = "descripciontxt"
        descripciontxt.PlaceholderText = "Descripción breve de la categoría"
        descripciontxt.Size = New Size(690, 54)
        descripciontxt.TabIndex = 13
        ' 
        ' codigotxt
        ' 
        codigotxt.Location = New Point(469, 44)
        codigotxt.Name = "codigotxt"
        codigotxt.PlaceholderText = "Codigo: Por ejemplo BOLS, MOCH, ETC"
        codigotxt.Size = New Size(192, 23)
        codigotxt.TabIndex = 12
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
        eliminarbtn.Location = New Point(819, 56)
        eliminarbtn.Name = "eliminarbtn"
        eliminarbtn.Size = New Size(148, 28)
        eliminarbtn.TabIndex = 11
        eliminarbtn.Text = "Eliminar Categoria"
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
        Añadirbtn.Location = New Point(819, 121)
        Añadirbtn.Name = "Añadirbtn"
        Añadirbtn.Size = New Size(148, 28)
        Añadirbtn.TabIndex = 9
        Añadirbtn.Text = "Añadir Categoria"
        Añadirbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        Añadirbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Label2.Location = New Point(799, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(5, 146)
        Label2.TabIndex = 0
        ' 
        ' categoriatxt
        ' 
        categoriatxt.Location = New Point(20, 44)
        categoriatxt.Name = "categoriatxt"
        categoriatxt.PlaceholderText = "Nombre de la categoría"
        categoriatxt.Size = New Size(192, 23)
        categoriatxt.TabIndex = 2
        ' 
        ' buscarlbl
        ' 
        buscarlbl.AutoSize = True
        buscarlbl.Font = New Font("Mongolian Baiti", 11F)
        buscarlbl.Location = New Point(20, 23)
        buscarlbl.Name = "buscarlbl"
        buscarlbl.Size = New Size(156, 16)
        buscarlbl.TabIndex = 1
        buscarlbl.Text = "Nombre de la Categoría"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.GhostWhite
        Panel2.Controls.Add(FLPproductos)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 242)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1208, 432)
        Panel2.TabIndex = 3
        ' 
        ' FLPproductos
        ' 
        FLPproductos.Controls.Add(dgwcat)
        FLPproductos.Dock = DockStyle.Fill
        FLPproductos.Location = New Point(0, 0)
        FLPproductos.Name = "FLPproductos"
        FLPproductos.Size = New Size(1208, 432)
        FLPproductos.TabIndex = 12
        ' 
        ' dgwcat
        ' 
        dgwcat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwcat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwcat.Location = New Point(3, 3)
        dgwcat.MultiSelect = False
        dgwcat.Name = "dgwcat"
        dgwcat.ReadOnly = True
        dgwcat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgwcat.Size = New Size(1086, 396)
        dgwcat.TabIndex = 1
        ' 
        ' UCproductoscategoria
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(1208, 674)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(labeltexto)
        Name = "UCproductoscategoria"
        Text = "Añadir categorias"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        FLPproductos.ResumeLayout(False)
        CType(dgwcat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents labeltexto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Añadirbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents categoriatxt As TextBox
    Friend WithEvents buscarlbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents eliminarbtn As Button
    Friend WithEvents FLPproductos As FlowLayoutPanel
    Friend WithEvents Editarcat As Button
    Friend WithEvents descripciontxt As TextBox
    Friend WithEvents codigotxt As TextBox
    Friend WithEvents Volver As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblerrorcat As Label
    Friend WithEvents errorcodigo As Label
    Friend WithEvents dgwcat As DataGridView

End Class
