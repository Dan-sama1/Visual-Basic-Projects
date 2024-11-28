<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.wmpVidPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.wmpVidPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(0, -1)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse File"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'wmpVidPlayer
        '
        Me.wmpVidPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wmpVidPlayer.Enabled = True
        Me.wmpVidPlayer.Location = New System.Drawing.Point(0, 21)
        Me.wmpVidPlayer.Name = "wmpVidPlayer"
        Me.wmpVidPlayer.OcxState = CType(resources.GetObject("wmpVidPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpVidPlayer.Size = New System.Drawing.Size(800, 424)
        Me.wmpVidPlayer.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 443)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.wmpVidPlayer)
        Me.Name = "Form1"
        Me.Text = "Video Player"
        CType(Me.wmpVidPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wmpVidPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
