<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderSize
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnGrande = New System.Windows.Forms.Button()
        Me.btnMedio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.lblItemName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 47)
        Me.Panel1.TabIndex = 1
        '
        'lblItemName
        '
        Me.lblItemName.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblItemName.Location = New System.Drawing.Point(26, 6)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(117, 35)
        Me.lblItemName.TabIndex = 2
        Me.lblItemName.Text = "Order SIze"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(407, 10)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 28)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnGrande
        '
        Me.btnGrande.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGrande.Font = New System.Drawing.Font("Poppins Medium", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btnGrande.Location = New System.Drawing.Point(220, 53)
        Me.btnGrande.Name = "btnGrande"
        Me.btnGrande.Size = New System.Drawing.Size(300, 106)
        Me.btnGrande.TabIndex = 2
        Me.btnGrande.Text = "GRANDE"
        Me.btnGrande.UseVisualStyleBackColor = False
        '
        'btnMedio
        '
        Me.btnMedio.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnMedio.Font = New System.Drawing.Font("Poppins Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedio.Location = New System.Drawing.Point(220, 168)
        Me.btnMedio.Name = "btnMedio"
        Me.btnMedio.Size = New System.Drawing.Size(300, 106)
        Me.btnMedio.TabIndex = 3
        Me.btnMedio.Text = "MEDIO"
        Me.btnMedio.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 232)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'OrderSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 286)
        Me.Controls.Add(Me.btnMedio)
        Me.Controls.Add(Me.btnGrande)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(548, 325)
        Me.MinimumSize = New System.Drawing.Size(548, 325)
        Me.Name = "OrderSize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Size"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblItemName As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnGrande As Button
    Friend WithEvents btnMedio As Button
End Class
