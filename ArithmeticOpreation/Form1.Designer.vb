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
        Me.components = New System.ComponentModel.Container()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnIntDiv = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.txtAns = New System.Windows.Forms.TextBox()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(96, 50)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(197, 20)
        Me.txtNum1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(96, 91)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(197, 20)
        Me.txtNum2.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(157, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(72, 13)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Enter Number"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(326, 47)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(452, 46)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(75, 23)
        Me.btnSub.TabIndex = 5
        Me.btnSub.Text = "Subtract"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(326, 76)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(75, 23)
        Me.btnMulti.TabIndex = 6
        Me.btnMulti.Text = "Multiply"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(452, 76)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnDiv.TabIndex = 7
        Me.btnDiv.Text = "Divide"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnIntDiv
        '
        Me.btnIntDiv.Location = New System.Drawing.Point(326, 105)
        Me.btnIntDiv.Name = "btnIntDiv"
        Me.btnIntDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnIntDiv.TabIndex = 8
        Me.btnIntDiv.Text = "Int Division"
        Me.btnIntDiv.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(452, 106)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 23)
        Me.btnMod.TabIndex = 9
        Me.btnMod.Text = "Modulo"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(24, 53)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(66, 13)
        Me.lblNum1.TabIndex = 10
        Me.lblNum1.Text = "First Number"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(6, 91)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(84, 13)
        Me.lblNum2.TabIndex = 11
        Me.lblNum2.Text = "Second Number"
        '
        'txtAns
        '
        Me.txtAns.Location = New System.Drawing.Point(96, 130)
        Me.txtAns.Name = "txtAns"
        Me.txtAns.ReadOnly = True
        Me.txtAns.Size = New System.Drawing.Size(197, 20)
        Me.txtAns.TabIndex = 12
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Location = New System.Drawing.Point(48, 130)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(42, 13)
        Me.lblAns.TabIndex = 13
        Me.lblAns.Text = "Answer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 184)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.txtAns)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnIntDiv)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnIntDiv As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents txtAns As TextBox
    Friend WithEvents lblAns As Label
End Class
