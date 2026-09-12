<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCpedidos
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
        comboestado = New ComboBox()
        Añadirbtn = New Button()
        eliminarbtn = New Button()
        Label2 = New Label()
        Button1 = New Button()
        dashboardbtn = New Button()
        dtphasta = New DateTimePicker()
        dtpDesde = New DateTimePicker()
        Label1 = New Label()
        estadolbl = New Label()
        buscartxt = New TextBox()
        buscarlbl = New Label()
        dgwpedidos = New DataGridView()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(dgwpedidos, ComponentModel.ISupportInitialize).BeginInit()
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
        labeltexto.TabIndex = 0
        labeltexto.Text = "         GESTIÓN DE PEDIDOS Y FACTURACIÓN"
        labeltexto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(comboestado)
        Panel1.Controls.Add(Añadirbtn)
        Panel1.Controls.Add(eliminarbtn)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(dashboardbtn)
        Panel1.Controls.Add(dtphasta)
        Panel1.Controls.Add(dtpDesde)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(estadolbl)
        Panel1.Controls.Add(buscartxt)
        Panel1.Controls.Add(buscarlbl)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1224, 109)
        Panel1.TabIndex = 1
        ' 
        ' comboestado
        ' 
        comboestado.FormattingEnabled = True
        comboestado.Location = New Point(338, 42)
        comboestado.Name = "comboestado"
        comboestado.Size = New Size(121, 23)
        comboestado.TabIndex = 10
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
        Añadirbtn.Location = New Point(881, 39)
        Añadirbtn.Name = "Añadirbtn"
        Añadirbtn.Size = New Size(81, 25)
        Añadirbtn.TabIndex = 9
        Añadirbtn.Text = "Añadir "
        Añadirbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        Añadirbtn.UseVisualStyleBackColor = False
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
        eliminarbtn.Location = New Point(990, 39)
        eliminarbtn.Name = "eliminarbtn"
        eliminarbtn.Size = New Size(81, 25)
        eliminarbtn.TabIndex = 8
        eliminarbtn.Text = "Eliminar"
        eliminarbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        eliminarbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Label2.Location = New Point(750, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(5, 30)
        Label2.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.ForeColor = Color.GhostWhite
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(1099, 39)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 25)
        Button1.TabIndex = 7
        Button1.Text = "Añadir"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dashboardbtn
        ' 
        dashboardbtn.BackColor = SystemColors.ScrollBar
        dashboardbtn.FlatAppearance.BorderSize = 0
        dashboardbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        dashboardbtn.FlatStyle = FlatStyle.Flat
        dashboardbtn.Font = New Font("Segoe UI", 10F)
        dashboardbtn.ForeColor = Color.Black
        dashboardbtn.Location = New Point(767, 40)
        dashboardbtn.Name = "dashboardbtn"
        dashboardbtn.Size = New Size(81, 25)
        dashboardbtn.TabIndex = 1
        dashboardbtn.Text = "Buscar"
        dashboardbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        dashboardbtn.UseVisualStyleBackColor = False
        ' 
        ' dtphasta
        ' 
        dtphasta.Format = DateTimePickerFormat.Short
        dtphasta.Location = New Point(653, 40)
        dtphasta.Name = "dtphasta"
        dtphasta.Size = New Size(87, 23)
        dtphasta.TabIndex = 6
        ' 
        ' dtpDesde
        ' 
        dtpDesde.Format = DateTimePickerFormat.Short
        dtpDesde.Location = New Point(558, 40)
        dtpDesde.Name = "dtpDesde"
        dtpDesde.Size = New Size(85, 23)
        dtpDesde.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(505, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 19)
        Label1.TabIndex = 4
        Label1.Text = "Fecha:"
        ' 
        ' estadolbl
        ' 
        estadolbl.AutoSize = True
        estadolbl.Font = New Font("Segoe UI", 10F)
        estadolbl.Location = New Point(268, 44)
        estadolbl.Name = "estadolbl"
        estadolbl.Size = New Size(53, 19)
        estadolbl.TabIndex = 3
        estadolbl.Text = "Estado:"
        ' 
        ' buscartxt
        ' 
        buscartxt.Location = New Point(66, 42)
        buscartxt.Name = "buscartxt"
        buscartxt.Size = New Size(192, 23)
        buscartxt.TabIndex = 2
        ' 
        ' buscarlbl
        ' 
        buscarlbl.AutoSize = True
        buscarlbl.Font = New Font("Segoe UI", 10F)
        buscarlbl.Location = New Point(16, 44)
        buscarlbl.Name = "buscarlbl"
        buscarlbl.Size = New Size(52, 19)
        buscarlbl.TabIndex = 1
        buscarlbl.Text = "Buscar:"
        ' 
        ' dgwpedidos
        ' 
        dgwpedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwpedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwpedidos.Location = New Point(17, 20)
        dgwpedidos.MultiSelect = False
        dgwpedidos.Name = "dgwpedidos"
        dgwpedidos.ReadOnly = True
        dgwpedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgwpedidos.Size = New Size(1163, 432)
        dgwpedidos.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dgwpedidos)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 147)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1224, 566)
        Panel2.TabIndex = 2
        ' 
        ' UCpedidos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(labeltexto)
        Name = "UCpedidos"
        Size = New Size(1224, 713)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgwpedidos, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents labeltexto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgwpedidos As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents buscartxt As TextBox
    Friend WithEvents buscarlbl As Label
    Friend WithEvents estadolbl As Label
    Friend WithEvents dtphasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dashboardbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Añadirbtn As Button
    Friend WithEvents eliminarbtn As Button
    Friend WithEvents comboestado As ComboBox

End Class
