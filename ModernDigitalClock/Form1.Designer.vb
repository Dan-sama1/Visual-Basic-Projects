<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAM = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 600)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblTime.Font = New System.Drawing.Font("Digital-7 Mono", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.NavajoWhite
        Me.lblTime.Location = New System.Drawing.Point(235, 258)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(148, 54)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "00:00"
        '
        'lblDay
        '
        Me.lblDay.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblDay.Font = New System.Drawing.Font("Digital-7 Mono", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.NavajoWhite
        Me.lblDay.Location = New System.Drawing.Point(245, 324)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(129, 28)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "888888"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 1000
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblMonth.Font = New System.Drawing.Font("Digital-7 Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMonth.Location = New System.Drawing.Point(269, 352)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(80, 17)
        Me.lblMonth.TabIndex = 3
        Me.lblMonth.Text = "888"
        Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.SystemColors.WindowText
        Me.lblDate.Font = New System.Drawing.Font("Digital-7 Mono", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDate.Location = New System.Drawing.Point(273, 369)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(72, 17)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "88, 8888"
        '
        'lblAM
        '
        Me.lblAM.AutoSize = True
        Me.lblAM.Font = New System.Drawing.Font("Digital-7 Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAM.ForeColor = System.Drawing.Color.NavajoWhite
        Me.lblAM.Location = New System.Drawing.Point(380, 258)
        Me.lblAM.Name = "lblAM"
        Me.lblAM.Size = New System.Drawing.Size(29, 20)
        Me.lblAM.TabIndex = 5
        Me.lblAM.Text = "PM"
        '
        'frmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(609, 612)
        Me.Controls.Add(Me.lblAM)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmForm"
        Me.Text = "Modern Digital Clock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAM As Label
End Class
