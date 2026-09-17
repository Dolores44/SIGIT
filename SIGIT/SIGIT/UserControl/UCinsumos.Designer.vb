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
        registrarmovi = New Button()
        Label1 = New Label()
        insumostotaleslbl = New Label()
        label4 = New Label()
        descripciontxt = New TextBox()
        comboestado = New ComboBox()
        Añadirbtn = New Button()
        eliminarbtn = New Button()
        Label2 = New Label()
        dashboardbtn = New Button()
        stocklbl = New Label()
        buscartxt = New TextBox()
        buscarlbl = New Label()
        labeltexto = New Label()
        dgwinsumos = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgwinsumos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(registrarmovi)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(insumostotaleslbl)
        Panel1.Controls.Add(label4)
        Panel1.Controls.Add(descripciontxt)
        Panel1.Controls.Add(comboestado)
        Panel1.Controls.Add(Añadirbtn)
        Panel1.Controls.Add(eliminarbtn)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dashboardbtn)
        Panel1.Controls.Add(stocklbl)
        Panel1.Controls.Add(buscartxt)
        Panel1.Controls.Add(buscarlbl)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 38)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1224, 109)
        Panel1.TabIndex = 4
        ' 
        ' registrarmovi
        ' 
        registrarmovi.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        registrarmovi.FlatAppearance.BorderSize = 0
        registrarmovi.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        registrarmovi.FlatStyle = FlatStyle.Flat
        registrarmovi.Font = New Font("Segoe UI", 10F)
        registrarmovi.ForeColor = Color.GhostWhite
        registrarmovi.Image = My.Resources.Resources.eliminar
        registrarmovi.ImageAlign = ContentAlignment.TopLeft
        registrarmovi.Location = New Point(979, 45)
        registrarmovi.Name = "registrarmovi"
        registrarmovi.Size = New Size(88, 30)
        registrarmovi.TabIndex = 9
        registrarmovi.Text = "Registrar "
        registrarmovi.TextImageRelation = TextImageRelation.ImageBeforeText
        registrarmovi.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Mongolian Baiti", 11F)
        Label1.Location = New Point(320, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 16)
        Label1.TabIndex = 5
        Label1.Text = "Descripcion"
        ' 
        ' insumostotaleslbl
        ' 
        insumostotaleslbl.AutoSize = True
        insumostotaleslbl.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        insumostotaleslbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        insumostotaleslbl.ForeColor = Color.GhostWhite
        insumostotaleslbl.Location = New Point(600, 57)
        insumostotaleslbl.Name = "insumostotaleslbl"
        insumostotaleslbl.Size = New Size(17, 20)
        insumostotaleslbl.TabIndex = 16
        insumostotaleslbl.Text = "0"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Segoe UI", 12F, FontStyle.Underline)
        label4.Location = New Point(555, 33)
        label4.Name = "label4"
        label4.Size = New Size(120, 21)
        label4.TabIndex = 15
        label4.Text = "Insumos Totales"
        ' 
        ' descripciontxt
        ' 
        descripciontxt.Location = New Point(225, 35)
        descripciontxt.Multiline = True
        descripciontxt.Name = "descripciontxt"
        descripciontxt.PlaceholderText = "Descripción breve de la categoría"
        descripciontxt.Size = New Size(290, 41)
        descripciontxt.TabIndex = 14
        ' 
        ' comboestado
        ' 
        comboestado.FormattingEnabled = True
        comboestado.Location = New Point(86, 57)
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
        Añadirbtn.Location = New Point(862, 21)
        Añadirbtn.Name = "Añadirbtn"
        Añadirbtn.Size = New Size(83, 30)
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
        eliminarbtn.Location = New Point(862, 69)
        eliminarbtn.Name = "eliminarbtn"
        eliminarbtn.Size = New Size(83, 30)
        eliminarbtn.TabIndex = 8
        eliminarbtn.Text = "Eliminar"
        eliminarbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        eliminarbtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Label2.Location = New Point(829, 18)
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
        dashboardbtn.Location = New Point(695, 35)
        dashboardbtn.Name = "dashboardbtn"
        dashboardbtn.Size = New Size(100, 33)
        dashboardbtn.TabIndex = 1
        dashboardbtn.Text = "Buscar"
        dashboardbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        dashboardbtn.UseVisualStyleBackColor = False
        ' 
        ' stocklbl
        ' 
        stocklbl.AutoSize = True
        stocklbl.Font = New Font("Mongolian Baiti", 11F)
        stocklbl.Location = New Point(16, 59)
        stocklbl.Name = "stocklbl"
        stocklbl.Size = New Size(46, 16)
        stocklbl.TabIndex = 3
        stocklbl.Text = "Stock:"
        ' 
        ' buscartxt
        ' 
        buscartxt.Location = New Point(86, 21)
        buscartxt.Name = "buscartxt"
        buscartxt.Size = New Size(121, 23)
        buscartxt.TabIndex = 11
        ' 
        ' buscarlbl
        ' 
        buscarlbl.AutoSize = True
        buscarlbl.Font = New Font("Mongolian Baiti", 11F)
        buscarlbl.Location = New Point(16, 27)
        buscarlbl.Name = "buscarlbl"
        buscarlbl.Size = New Size(54, 16)
        buscarlbl.TabIndex = 1
        buscarlbl.Text = "Buscar:"
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
        labeltexto.Text = "         GESTIÓN DE PEDIDOS Y FACTURACIÓN"
        labeltexto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dgwinsumos
        ' 
        dgwinsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgwinsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwinsumos.Location = New Point(17, 150)
        dgwinsumos.MultiSelect = False
        dgwinsumos.Name = "dgwinsumos"
        dgwinsumos.ReadOnly = True
        dgwinsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgwinsumos.Size = New Size(1163, 432)
        dgwinsumos.TabIndex = 3
        ' 
        ' UCinsumos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Controls.Add(labeltexto)
        Controls.Add(dgwinsumos)
        Name = "UCinsumos"
        Size = New Size(1224, 713)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgwinsumos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents comboestado As ComboBox
    Friend WithEvents Añadirbtn As Button
    Friend WithEvents eliminarbtn As Button
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
    Friend WithEvents descripciontxt As TextBox
    Friend WithEvents registrarmovi As Button

End Class
