<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.flpItemName = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMilkTea = New System.Windows.Forms.Button()
        Me.btnCoffee = New System.Windows.Forms.Button()
        Me.btnPRAF = New System.Windows.Forms.Button()
        Me.btnFruitTea = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnHistory)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 73)
        Me.Panel1.TabIndex = 0
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.Black
        Me.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHistory.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnHistory.Location = New System.Drawing.Point(755, 18)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(136, 28)
        Me.btnHistory.TabIndex = 8
        Me.btnHistory.Text = "DAILY HISTORY"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Black
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(897, 18)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(113, 28)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pos-ong Bato"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(315, 358)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(12, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(315, 113)
        Me.Panel2.TabIndex = 2
        '
        'flpItemName
        '
        Me.flpItemName.AutoScroll = True
        Me.flpItemName.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.flpItemName.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpItemName.Location = New System.Drawing.Point(336, 143)
        Me.flpItemName.Name = "flpItemName"
        Me.flpItemName.Size = New System.Drawing.Size(700, 351)
        Me.flpItemName.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(336, 500)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(700, 58)
        Me.Panel3.TabIndex = 4
        '
        'btnMilkTea
        '
        Me.btnMilkTea.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMilkTea.Location = New System.Drawing.Point(336, 82)
        Me.btnMilkTea.Name = "btnMilkTea"
        Me.btnMilkTea.Size = New System.Drawing.Size(164, 55)
        Me.btnMilkTea.TabIndex = 4
        Me.btnMilkTea.Text = "MILK TEA"
        Me.btnMilkTea.UseVisualStyleBackColor = True
        '
        'btnCoffee
        '
        Me.btnCoffee.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnCoffee.Location = New System.Drawing.Point(506, 82)
        Me.btnCoffee.Name = "btnCoffee"
        Me.btnCoffee.Size = New System.Drawing.Size(164, 55)
        Me.btnCoffee.TabIndex = 5
        Me.btnCoffee.Text = "COFFEE"
        Me.btnCoffee.UseVisualStyleBackColor = True
        '
        'btnPRAF
        '
        Me.btnPRAF.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnPRAF.Location = New System.Drawing.Point(846, 82)
        Me.btnPRAF.Name = "btnPRAF"
        Me.btnPRAF.Size = New System.Drawing.Size(164, 55)
        Me.btnPRAF.TabIndex = 7
        Me.btnPRAF.Text = "PRAF"
        Me.btnPRAF.UseVisualStyleBackColor = True
        '
        'btnFruitTea
        '
        Me.btnFruitTea.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnFruitTea.Location = New System.Drawing.Point(676, 82)
        Me.btnFruitTea.Name = "btnFruitTea"
        Me.btnFruitTea.Size = New System.Drawing.Size(164, 55)
        Me.btnFruitTea.TabIndex = 6
        Me.btnFruitTea.Text = "FRUIT TEA"
        Me.btnFruitTea.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1013, 82)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(23, 55)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "↻"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1048, 569)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFruitTea)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnMilkTea)
        Me.Controls.Add(Me.btnCoffee)
        Me.Controls.Add(Me.flpItemName)
        Me.Controls.Add(Me.btnPRAF)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1064, 608)
        Me.Name = "POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS-ong Bato"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents flpItemName As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMilkTea As Button
    Friend WithEvents btnCoffee As Button
    Friend WithEvents btnPRAF As Button
    Friend WithEvents btnFruitTea As Button
    Friend WithEvents btnClear As Button
End Class
