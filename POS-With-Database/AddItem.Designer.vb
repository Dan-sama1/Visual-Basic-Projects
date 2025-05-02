<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItem
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.rdbMilkTea = New System.Windows.Forms.RadioButton()
        Me.rdbFruitTea = New System.Windows.Forms.RadioButton()
        Me.rdbCoffee = New System.Windows.Forms.RadioButton()
        Me.rdbFrap = New System.Windows.Forms.RadioButton()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dtProductName = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.grpCategory.SuspendLayout()
        CType(Me.dtProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 54)
        Me.Panel1.TabIndex = 15
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(639, 14)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 28)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Exit"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Add Items"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(301, 288)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(451, 31)
        Me.txtName.TabIndex = 3
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(301, 393)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(103, 30)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "Create Product"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(649, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 30)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'rdbMilkTea
        '
        Me.rdbMilkTea.AutoSize = True
        Me.rdbMilkTea.Enabled = False
        Me.rdbMilkTea.Location = New System.Drawing.Point(18, 19)
        Me.rdbMilkTea.Name = "rdbMilkTea"
        Me.rdbMilkTea.Size = New System.Drawing.Size(94, 32)
        Me.rdbMilkTea.TabIndex = 4
        Me.rdbMilkTea.TabStop = True
        Me.rdbMilkTea.Text = "Milk Tea"
        Me.rdbMilkTea.UseVisualStyleBackColor = True
        '
        'rdbFruitTea
        '
        Me.rdbFruitTea.AutoSize = True
        Me.rdbFruitTea.Enabled = False
        Me.rdbFruitTea.Location = New System.Drawing.Point(249, 19)
        Me.rdbFruitTea.Name = "rdbFruitTea"
        Me.rdbFruitTea.Size = New System.Drawing.Size(98, 32)
        Me.rdbFruitTea.TabIndex = 6
        Me.rdbFruitTea.TabStop = True
        Me.rdbFruitTea.Text = "Fruit Tea"
        Me.rdbFruitTea.UseVisualStyleBackColor = True
        '
        'rdbCoffee
        '
        Me.rdbCoffee.AutoSize = True
        Me.rdbCoffee.Enabled = False
        Me.rdbCoffee.Location = New System.Drawing.Point(143, 19)
        Me.rdbCoffee.Name = "rdbCoffee"
        Me.rdbCoffee.Size = New System.Drawing.Size(82, 32)
        Me.rdbCoffee.TabIndex = 5
        Me.rdbCoffee.TabStop = True
        Me.rdbCoffee.Text = "Coffee"
        Me.rdbCoffee.UseVisualStyleBackColor = True
        '
        'rdbFrap
        '
        Me.rdbFrap.AutoSize = True
        Me.rdbFrap.Enabled = False
        Me.rdbFrap.Location = New System.Drawing.Point(371, 19)
        Me.rdbFrap.Name = "rdbFrap"
        Me.rdbFrap.Size = New System.Drawing.Size(61, 32)
        Me.rdbFrap.TabIndex = 7
        Me.rdbFrap.TabStop = True
        Me.rdbFrap.Text = "Praf"
        Me.rdbFrap.UseVisualStyleBackColor = True
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.rdbFruitTea)
        Me.grpCategory.Controls.Add(Me.rdbFrap)
        Me.grpCategory.Controls.Add(Me.rdbMilkTea)
        Me.grpCategory.Controls.Add(Me.rdbCoffee)
        Me.grpCategory.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCategory.Location = New System.Drawing.Point(301, 325)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(451, 60)
        Me.grpCategory.TabIndex = 24
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Poppins", 8.25!)
        Me.btnDelete.Location = New System.Drawing.Point(534, 393)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 30)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dtProductName
        '
        Me.dtProductName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtProductName.BackgroundColor = System.Drawing.Color.White
        Me.dtProductName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtProductName.Location = New System.Drawing.Point(298, 121)
        Me.dtProductName.Name = "dtProductName"
        Me.dtProductName.Size = New System.Drawing.Size(450, 138)
        Me.dtProductName.TabIndex = 26
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(301, 84)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(329, 31)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Poppins", 8.25!)
        Me.btnSearch.Location = New System.Drawing.Point(636, 84)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 31)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS_With_Database.My.Resources.Resources.Chocolate
        Me.PictureBox1.Location = New System.Drawing.Point(12, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 266)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(421, 393)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(103, 30)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit Product"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Poppins", 8.25!)
        Me.btnRefresh.Location = New System.Drawing.Point(717, 84)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(31, 31)
        Me.btnRefresh.TabIndex = 30
        Me.btnRefresh.Text = "↻"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 471)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dtProductName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(795, 510)
        Me.MinimumSize = New System.Drawing.Size(795, 507)
        Me.Name = "AddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Items"
        Me.Panel1.ResumeLayout(False)
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        CType(Me.dtProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents rdbMilkTea As RadioButton
    Friend WithEvents rdbFruitTea As RadioButton
    Friend WithEvents rdbCoffee As RadioButton
    Friend WithEvents rdbFrap As RadioButton
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents dtProductName As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnRefresh As Button
End Class
