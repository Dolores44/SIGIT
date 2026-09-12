<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCproductoslista
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        categoria = New Label()
        nombreproducto = New Label()
        preciotxt = New Label()
        stockcount = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        editarbtn = New Button()
        verfichabtn = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' categoria
        ' 
        categoria.AutoSize = True
        categoria.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        categoria.ForeColor = SystemColors.AppWorkspace
        categoria.Location = New Point(15, 164)
        categoria.Name = "categoria"
        categoria.Size = New Size(108, 17)
        categoria.TabIndex = 0
        categoria.Text = "C A T E G O R Ì A"
        ' 
        ' nombreproducto
        ' 
        nombreproducto.AutoSize = True
        nombreproducto.Font = New Font("Segoe UI", 11.0F)
        nombreproducto.ForeColor = SystemColors.ActiveCaptionText
        nombreproducto.Location = New Point(24, 179)
        nombreproducto.Name = "nombreproducto"
        nombreproducto.Size = New Size(122, 20)
        nombreproducto.TabIndex = 1
        nombreproducto.Text = "nombreproducto"
        ' 
        ' preciotxt
        ' 
        preciotxt.AutoSize = True
        preciotxt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        preciotxt.ForeColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        preciotxt.Location = New Point(15, 208)
        preciotxt.Name = "preciotxt"
        preciotxt.Size = New Size(53, 17)
        preciotxt.TabIndex = 2
        preciotxt.Text = "PRECIO"
        ' 
        ' stockcount
        ' 
        stockcount.AutoSize = True
        stockcount.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        stockcount.ForeColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        stockcount.Location = New Point(211, 208)
        stockcount.Name = "stockcount"
        stockcount.Size = New Size(75, 17)
        stockcount.TabIndex = 3
        stockcount.Text = "stockcount"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        Label1.Location = New Point(159, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 17)
        Label1.TabIndex = 4
        Label1.Text = "Stock:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGray
        Panel1.Controls.Add(editarbtn)
        Panel1.Controls.Add(verfichabtn)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 232)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(290, 48)
        Panel1.TabIndex = 5
        ' 
        ' editarbtn
        ' 
        editarbtn.BackColor = Color.FromArgb(CByte(28), CByte(45), CByte(58))
        editarbtn.FlatAppearance.BorderSize = 0
        editarbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        editarbtn.FlatStyle = FlatStyle.Flat
        editarbtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        editarbtn.ForeColor = Color.White
        editarbtn.ImageAlign = ContentAlignment.TopLeft
        editarbtn.Location = New Point(159, 10)
        editarbtn.Name = "editarbtn"
        editarbtn.Size = New Size(123, 27)
        editarbtn.TabIndex = 2
        editarbtn.Text = "Editar"
        editarbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        editarbtn.UseVisualStyleBackColor = False
        ' 
        ' verfichabtn
        ' 
        verfichabtn.BackColor = Color.GhostWhite
        verfichabtn.FlatAppearance.BorderSize = 0
        verfichabtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(40), CByte(70), CByte(100))
        verfichabtn.FlatStyle = FlatStyle.Flat
        verfichabtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        verfichabtn.ForeColor = Color.Black
        verfichabtn.ImageAlign = ContentAlignment.TopLeft
        verfichabtn.Location = New Point(10, 10)
        verfichabtn.Name = "verfichabtn"
        verfichabtn.Size = New Size(120, 27)
        verfichabtn.TabIndex = 1
        verfichabtn.Text = "Ver ficha"
        verfichabtn.TextImageRelation = TextImageRelation.ImageBeforeText
        verfichabtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.MaximumSize = New Size(0, 150)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(290, 150)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' UCproductoslista
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(stockcount)
        Controls.Add(preciotxt)
        Controls.Add(categoria)
        Controls.Add(nombreproducto)
        Name = "UCproductoslista"
        Size = New Size(290, 280)
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents categoria As Label
    Friend WithEvents nombreproducto As Label
    Friend WithEvents preciotxt As Label
    Friend WithEvents stockcount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents verfichabtn As Button
    Friend WithEvents editarbtn As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
