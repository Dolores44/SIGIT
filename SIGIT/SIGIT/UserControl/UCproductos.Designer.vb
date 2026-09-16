<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCproductos
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
        labeltexto = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        combocategoria = New ComboBox()
        Añadirbtn = New Button()
        Label2 = New Label()
        dashboardbtn = New Button()
        categorialbl = New Label()
        buscartxt = New TextBox()
        buscarlbl = New Label()
        Panel2 = New Panel()
        FLPproductos = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
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
        labeltexto.Size = New Size(1224, 38)
        labeltexto.TabIndex = 1
        labeltexto.Text = "        CATÁLOGO DE PRODUCTOS"
        labeltexto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(combocategoria)
        Panel1.Controls.Add(Añadirbtn)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dashboardbtn)
        Panel1.Controls.Add(categorialbl)
        Panel1.Controls.Add(buscartxt)
        Panel1.Controls.Add(buscarlbl)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1224, 109)
        Panel1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.ForeColor = Color.GhostWhite
        Button1.Image = My.Resources.Resources.añadir
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(1032, 33)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 30)
        Button1.TabIndex = 11
        Button1.Text = "Registrar Producto"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' combocategoria
        ' 
        combocategoria.FormattingEnabled = True
        combocategoria.Location = New Point(397, 33)
        combocategoria.Name = "combocategoria"
        combocategoria.Size = New Size(142, 23)
        combocategoria.TabIndex = 10
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
        Añadirbtn.Location = New Point(847, 33)
        Añadirbtn.Name = "Añadirbtn"
        Añadirbtn.Size = New Size(136, 30)
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
        Label2.Size = New Size(5, 30)
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
        dashboardbtn.Location = New Point(629, 33)
        dashboardbtn.Name = "dashboardbtn"
        dashboardbtn.Size = New Size(81, 25)
        dashboardbtn.TabIndex = 1
        dashboardbtn.Text = "Filtrar"
        dashboardbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        dashboardbtn.UseVisualStyleBackColor = False
        ' 
        ' categorialbl
        ' 
        categorialbl.AutoSize = True
        categorialbl.Font = New Font("Segoe UI", 10F)
        categorialbl.Location = New Point(327, 35)
        categorialbl.Name = "categorialbl"
        categorialbl.Size = New Size(71, 19)
        categorialbl.TabIndex = 3
        categorialbl.Text = "Categoria:"
        ' 
        ' buscartxt
        ' 
        buscartxt.Location = New Point(125, 33)
        buscartxt.Name = "buscartxt"
        buscartxt.Size = New Size(192, 23)
        buscartxt.TabIndex = 2
        ' 
        ' buscarlbl
        ' 
        buscarlbl.AutoSize = True
        buscarlbl.Font = New Font("Segoe UI", 10F)
        buscarlbl.Location = New Point(75, 35)
        buscarlbl.Name = "buscarlbl"
        buscarlbl.Size = New Size(52, 19)
        buscarlbl.TabIndex = 1
        buscarlbl.Text = "Buscar:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.GhostWhite
        Panel2.Controls.Add(FLPproductos)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 147)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1224, 566)
        Panel2.TabIndex = 3
        ' 
        ' FLPproductos
        ' 
        FLPproductos.Dock = DockStyle.Fill
        FLPproductos.Location = New Point(0, 0)
        FLPproductos.Name = "FLPproductos"
        FLPproductos.Size = New Size(1224, 566)
        FLPproductos.TabIndex = 12
        ' 
        ' UCproductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(labeltexto)
        Name = "UCproductos"
        Size = New Size(1224, 713)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents labeltexto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents combocategoria As ComboBox
    Friend WithEvents Añadirbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dashboardbtn As Button
    Friend WithEvents categorialbl As Label
    Friend WithEvents buscartxt As TextBox
    Friend WithEvents buscarlbl As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents FLPproductos As FlowLayoutPanel

End Class
