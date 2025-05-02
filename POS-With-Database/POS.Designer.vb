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
        Me.dtOrders = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.flpItemName = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnMilkTea = New System.Windows.Forms.Button()
        Me.btnCoffee = New System.Windows.Forms.Button()
        Me.btnPRAF = New System.Windows.Forms.Button()
        Me.btnFruitTea = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.pnlAddOrder = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grbSize = New System.Windows.Forms.GroupBox()
        Me.rdbGrande = New System.Windows.Forms.RadioButton()
        Me.rdbMedio = New System.Windows.Forms.RadioButton()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.grbAddon = New System.Windows.Forms.GroupBox()
        Me.chkPearl = New System.Windows.Forms.CheckBox()
        Me.chkCrystal = New System.Windows.Forms.CheckBox()
        Me.chkCoffeeJelly = New System.Windows.Forms.CheckBox()
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
        Me.chkCheeseCake = New System.Windows.Forms.CheckBox()
        Me.chkCreamPuff = New System.Windows.Forms.CheckBox()
        Me.chkOreo = New System.Windows.Forms.CheckBox()
        Me.dtRetailer = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dtOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlAddOrder.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.grbSize.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAddon.SuspendLayout()
        CType(Me.dtRetailer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dtOrders
        '
        Me.dtOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtOrders.BackgroundColor = System.Drawing.Color.White
        Me.dtOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtOrders.Location = New System.Drawing.Point(12, 138)
        Me.dtOrders.Name = "dtOrders"
        Me.dtOrders.Size = New System.Drawing.Size(315, 240)
        Me.dtOrders.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtPay)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(12, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(315, 113)
        Me.Panel2.TabIndex = 2
        '
        'txtPay
        '
        Me.txtPay.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPay.Location = New System.Drawing.Point(151, 21)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(158, 27)
        Me.txtPay.TabIndex = 3
        '
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(151, 62)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(158, 28)
        Me.lblChange.TabIndex = 2
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Change"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Recieved Ammount"
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
        Me.Panel3.Controls.Add(Me.btnCheckout)
        Me.Panel3.Controls.Add(Me.btnEdit)
        Me.Panel3.Controls.Add(Me.btnVoid)
        Me.Panel3.Location = New System.Drawing.Point(336, 500)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(700, 58)
        Me.Panel3.TabIndex = 4
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCheckout.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(6, 5)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(225, 50)
        Me.btnCheckout.TabIndex = 2
        Me.btnCheckout.Text = "CHECK OUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(237, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(225, 50)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnVoid.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnVoid.ForeColor = System.Drawing.Color.White
        Me.btnVoid.Location = New System.Drawing.Point(468, 5)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(225, 50)
        Me.btnVoid.TabIndex = 0
        Me.btnVoid.Text = "VOID"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnMilkTea
        '
        Me.btnMilkTea.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMilkTea.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMilkTea.Location = New System.Drawing.Point(336, 82)
        Me.btnMilkTea.Name = "btnMilkTea"
        Me.btnMilkTea.Size = New System.Drawing.Size(164, 55)
        Me.btnMilkTea.TabIndex = 4
        Me.btnMilkTea.Text = "MILK TEA"
        Me.btnMilkTea.UseVisualStyleBackColor = False
        '
        'btnCoffee
        '
        Me.btnCoffee.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btnCoffee.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnCoffee.Location = New System.Drawing.Point(506, 82)
        Me.btnCoffee.Name = "btnCoffee"
        Me.btnCoffee.Size = New System.Drawing.Size(164, 55)
        Me.btnCoffee.TabIndex = 5
        Me.btnCoffee.Text = "COFFEE"
        Me.btnCoffee.UseVisualStyleBackColor = False
        '
        'btnPRAF
        '
        Me.btnPRAF.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnPRAF.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnPRAF.Location = New System.Drawing.Point(846, 82)
        Me.btnPRAF.Name = "btnPRAF"
        Me.btnPRAF.Size = New System.Drawing.Size(164, 55)
        Me.btnPRAF.TabIndex = 7
        Me.btnPRAF.Text = "PRAF"
        Me.btnPRAF.UseVisualStyleBackColor = False
        '
        'btnFruitTea
        '
        Me.btnFruitTea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnFruitTea.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.btnFruitTea.Location = New System.Drawing.Point(676, 82)
        Me.btnFruitTea.Name = "btnFruitTea"
        Me.btnFruitTea.Size = New System.Drawing.Size(164, 55)
        Me.btnFruitTea.TabIndex = 6
        Me.btnFruitTea.Text = "FRUIT TEA"
        Me.btnFruitTea.UseVisualStyleBackColor = False
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
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Poppins Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(3, 2)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(99, 49)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Total:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lblTotal)
        Me.Panel4.Controls.Add(Me.label2)
        Me.Panel4.Location = New System.Drawing.Point(13, 376)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(314, 54)
        Me.Panel4.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Poppins Medium", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(98, 3)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(213, 49)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "00.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlAddOrder
        '
        Me.pnlAddOrder.Controls.Add(Me.grbAddon)
        Me.pnlAddOrder.Controls.Add(Me.numQuantity)
        Me.pnlAddOrder.Controls.Add(Me.grbSize)
        Me.pnlAddOrder.Controls.Add(Me.btnAdd)
        Me.pnlAddOrder.Controls.Add(Me.Label5)
        Me.pnlAddOrder.Controls.Add(Me.PictureBox1)
        Me.pnlAddOrder.Controls.Add(Me.Panel6)
        Me.pnlAddOrder.Location = New System.Drawing.Point(336, 79)
        Me.pnlAddOrder.Name = "pnlAddOrder"
        Me.pnlAddOrder.Size = New System.Drawing.Size(700, 415)
        Me.pnlAddOrder.TabIndex = 10
        Me.pnlAddOrder.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Controls.Add(Me.lblItemName)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(700, 67)
        Me.Panel6.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(306, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Quantity"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(310, 366)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(364, 36)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grbSize
        '
        Me.grbSize.Controls.Add(Me.rdbMedio)
        Me.grbSize.Controls.Add(Me.rdbGrande)
        Me.grbSize.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbSize.ForeColor = System.Drawing.Color.White
        Me.grbSize.Location = New System.Drawing.Point(310, 162)
        Me.grbSize.Name = "grbSize"
        Me.grbSize.Size = New System.Drawing.Size(364, 57)
        Me.grbSize.TabIndex = 7
        Me.grbSize.TabStop = False
        Me.grbSize.Text = "Size"
        '
        'rdbGrande
        '
        Me.rdbGrande.AutoSize = True
        Me.rdbGrande.Location = New System.Drawing.Point(31, 20)
        Me.rdbGrande.Name = "rdbGrande"
        Me.rdbGrande.Size = New System.Drawing.Size(149, 27)
        Me.rdbGrande.TabIndex = 0
        Me.rdbGrande.TabStop = True
        Me.rdbGrande.Text = "39 - Grande (22oz)"
        Me.rdbGrande.UseVisualStyleBackColor = True
        '
        'rdbMedio
        '
        Me.rdbMedio.AutoSize = True
        Me.rdbMedio.Location = New System.Drawing.Point(200, 20)
        Me.rdbMedio.Name = "rdbMedio"
        Me.rdbMedio.Size = New System.Drawing.Size(136, 27)
        Me.rdbMedio.TabIndex = 1
        Me.rdbMedio.TabStop = True
        Me.rdbMedio.Text = "29 - Medio (16oz)"
        Me.rdbMedio.UseVisualStyleBackColor = True
        '
        'lblItemName
        '
        Me.lblItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblItemName.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.lblItemName.ForeColor = System.Drawing.Color.White
        Me.lblItemName.Location = New System.Drawing.Point(24, 20)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(175, 28)
        Me.lblItemName.TabIndex = 0
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(561, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS_With_Database.My.Resources.Resources.big_brew
        Me.PictureBox1.Location = New System.Drawing.Point(24, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.POS_With_Database.My.Resources.Resources.Bigbrew_logo
        Me.picLogo.Location = New System.Drawing.Point(336, 143)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(700, 351)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        Me.picLogo.Visible = False
        '
        'numQuantity
        '
        Me.numQuantity.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.numQuantity.Location = New System.Drawing.Point(310, 125)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(364, 31)
        Me.numQuantity.TabIndex = 8
        '
        'grbAddon
        '
        Me.grbAddon.Controls.Add(Me.chkOreo)
        Me.grbAddon.Controls.Add(Me.chkCreamPuff)
        Me.grbAddon.Controls.Add(Me.chkCheeseCake)
        Me.grbAddon.Controls.Add(Me.chkCreamCheese)
        Me.grbAddon.Controls.Add(Me.chkCoffeeJelly)
        Me.grbAddon.Controls.Add(Me.chkCrystal)
        Me.grbAddon.Controls.Add(Me.chkPearl)
        Me.grbAddon.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAddon.ForeColor = System.Drawing.Color.White
        Me.grbAddon.Location = New System.Drawing.Point(310, 225)
        Me.grbAddon.Name = "grbAddon"
        Me.grbAddon.Size = New System.Drawing.Size(364, 135)
        Me.grbAddon.TabIndex = 8
        Me.grbAddon.TabStop = False
        Me.grbAddon.Text = "Add-ons"
        '
        'chkPearl
        '
        Me.chkPearl.AutoSize = True
        Me.chkPearl.Location = New System.Drawing.Point(24, 28)
        Me.chkPearl.Name = "chkPearl"
        Me.chkPearl.Size = New System.Drawing.Size(62, 27)
        Me.chkPearl.TabIndex = 0
        Me.chkPearl.Text = "Pearl"
        Me.chkPearl.UseVisualStyleBackColor = True
        '
        'chkCrystal
        '
        Me.chkCrystal.AutoSize = True
        Me.chkCrystal.Location = New System.Drawing.Point(123, 28)
        Me.chkCrystal.Name = "chkCrystal"
        Me.chkCrystal.Size = New System.Drawing.Size(75, 27)
        Me.chkCrystal.TabIndex = 1
        Me.chkCrystal.Text = "Crystal"
        Me.chkCrystal.UseVisualStyleBackColor = True
        '
        'chkCoffeeJelly
        '
        Me.chkCoffeeJelly.AutoSize = True
        Me.chkCoffeeJelly.Location = New System.Drawing.Point(228, 28)
        Me.chkCoffeeJelly.Name = "chkCoffeeJelly"
        Me.chkCoffeeJelly.Size = New System.Drawing.Size(102, 27)
        Me.chkCoffeeJelly.TabIndex = 2
        Me.chkCoffeeJelly.Text = "Coffee Jelly"
        Me.chkCoffeeJelly.UseVisualStyleBackColor = True
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(45, 61)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(126, 27)
        Me.chkCreamCheese.TabIndex = 3
        Me.chkCreamCheese.Text = "Cream Cheese"
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'chkCheeseCake
        '
        Me.chkCheeseCake.AutoSize = True
        Me.chkCheeseCake.Location = New System.Drawing.Point(204, 61)
        Me.chkCheeseCake.Name = "chkCheeseCake"
        Me.chkCheeseCake.Size = New System.Drawing.Size(115, 27)
        Me.chkCheeseCake.TabIndex = 4
        Me.chkCheeseCake.Text = "Cheese Cake"
        Me.chkCheeseCake.UseVisualStyleBackColor = True
        '
        'chkCreamPuff
        '
        Me.chkCreamPuff.AutoSize = True
        Me.chkCreamPuff.Location = New System.Drawing.Point(81, 94)
        Me.chkCreamPuff.Name = "chkCreamPuff"
        Me.chkCreamPuff.Size = New System.Drawing.Size(101, 27)
        Me.chkCreamPuff.TabIndex = 5
        Me.chkCreamPuff.Text = "Cream Puff"
        Me.chkCreamPuff.UseVisualStyleBackColor = True
        '
        'chkOreo
        '
        Me.chkOreo.AutoSize = True
        Me.chkOreo.Location = New System.Drawing.Point(188, 94)
        Me.chkOreo.Name = "chkOreo"
        Me.chkOreo.Size = New System.Drawing.Size(118, 27)
        Me.chkOreo.TabIndex = 6
        Me.chkOreo.Text = "Crushed Oreo"
        Me.chkOreo.UseVisualStyleBackColor = True
        '
        'dtRetailer
        '
        Me.dtRetailer.AllowUserToAddRows = False
        Me.dtRetailer.AllowUserToDeleteRows = False
        Me.dtRetailer.AllowUserToResizeColumns = False
        Me.dtRetailer.AllowUserToResizeRows = False
        Me.dtRetailer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtRetailer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtRetailer.BackgroundColor = System.Drawing.Color.White
        Me.dtRetailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtRetailer.Location = New System.Drawing.Point(12, 79)
        Me.dtRetailer.Name = "dtRetailer"
        Me.dtRetailer.ReadOnly = True
        Me.dtRetailer.RowHeadersVisible = False
        Me.dtRetailer.ShowEditingIcon = False
        Me.dtRetailer.Size = New System.Drawing.Size(315, 58)
        Me.dtRetailer.TabIndex = 11
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1048, 569)
        Me.Controls.Add(Me.dtRetailer)
        Me.Controls.Add(Me.pnlAddOrder)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFruitTea)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnMilkTea)
        Me.Controls.Add(Me.btnCoffee)
        Me.Controls.Add(Me.flpItemName)
        Me.Controls.Add(Me.btnPRAF)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dtOrders)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(1064, 608)
        Me.Name = "POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS-ong Bato"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnlAddOrder.ResumeLayout(False)
        Me.pnlAddOrder.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.grbSize.ResumeLayout(False)
        Me.grbSize.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAddon.ResumeLayout(False)
        Me.grbAddon.PerformLayout()
        CType(Me.dtRetailer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtOrders As DataGridView
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
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtPay As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents pnlAddOrder As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents grbSize As GroupBox
    Friend WithEvents rdbMedio As RadioButton
    Friend WithEvents rdbGrande As RadioButton
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblItemName As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents grbAddon As GroupBox
    Friend WithEvents chkOreo As CheckBox
    Friend WithEvents chkCreamPuff As CheckBox
    Friend WithEvents chkCheeseCake As CheckBox
    Friend WithEvents chkCreamCheese As CheckBox
    Friend WithEvents chkCoffeeJelly As CheckBox
    Friend WithEvents chkCrystal As CheckBox
    Friend WithEvents chkPearl As CheckBox
    Friend WithEvents dtRetailer As DataGridView
End Class
