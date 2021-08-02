<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCar
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
        Dim Car_IDLabel As System.Windows.Forms.Label
        Dim Plate_NoLabel As System.Windows.Forms.Label
        Dim Car_NameLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Rent_DayLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCar))
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.ListOfCarsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ListOfCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfCarsDataSet = New FinalCarRentalSystem.ListOfCarsDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListOfCarsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtCar_ID = New System.Windows.Forms.TextBox()
        Me.txtPlate_No = New System.Windows.Forms.TextBox()
        Me.txtCar_Name = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtRent_Day = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListOfCarsTableAdapter = New FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter()
        Me.TableAdapterManager = New FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Car_IDLabel = New System.Windows.Forms.Label()
        Plate_NoLabel = New System.Windows.Forms.Label()
        Car_NameLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Rent_DayLabel = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout()
        CType(Me.ListOfCarsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListOfCarsBindingNavigator.SuspendLayout()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Car_IDLabel
        '
        Car_IDLabel.AutoSize = True
        Car_IDLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_IDLabel.Location = New System.Drawing.Point(123, 126)
        Car_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Car_IDLabel.Name = "Car_IDLabel"
        Car_IDLabel.Size = New System.Drawing.Size(69, 28)
        Car_IDLabel.TabIndex = 85
        Car_IDLabel.Text = "Car ID:"
        '
        'Plate_NoLabel
        '
        Plate_NoLabel.AutoSize = True
        Plate_NoLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Plate_NoLabel.Location = New System.Drawing.Point(123, 166)
        Plate_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Plate_NoLabel.Name = "Plate_NoLabel"
        Plate_NoLabel.Size = New System.Drawing.Size(91, 28)
        Plate_NoLabel.TabIndex = 87
        Plate_NoLabel.Text = "Plate No:"
        '
        'Car_NameLabel
        '
        Car_NameLabel.AutoSize = True
        Car_NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Car_NameLabel.Location = New System.Drawing.Point(123, 206)
        Car_NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Car_NameLabel.Name = "Car_NameLabel"
        Car_NameLabel.Size = New System.Drawing.Size(102, 28)
        Car_NameLabel.TabIndex = 89
        Car_NameLabel.Text = "Car Name:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColorLabel.Location = New System.Drawing.Point(123, 246)
        ColorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(64, 28)
        ColorLabel.TabIndex = 91
        ColorLabel.Text = "Color:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(123, 286)
        QuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(92, 28)
        QuantityLabel.TabIndex = 93
        QuantityLabel.Text = "Quantity:"
        '
        'Rent_DayLabel
        '
        Rent_DayLabel.AutoSize = True
        Rent_DayLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rent_DayLabel.Location = New System.Drawing.Point(123, 326)
        Rent_DayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rent_DayLabel.Name = "Rent_DayLabel"
        Rent_DayLabel.Size = New System.Drawing.Size(97, 28)
        Rent_DayLabel.TabIndex = 95
        Rent_DayLabel.Text = "Rent/Day:"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.button4)
        Me.groupBox2.Controls.Add(Me.button2)
        Me.groupBox2.Location = New System.Drawing.Point(181, 525)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBox2.Size = New System.Drawing.Size(302, 88)
        Me.groupBox2.TabIndex = 84
        Me.groupBox2.TabStop = False
        '
        'button4
        '
        Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Location = New System.Drawing.Point(25, 25)
        Me.button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(123, 49)
        Me.button4.TabIndex = 34
        Me.button4.Text = "CLEAR ALL"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(161, 25)
        Me.button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(123, 49)
        Me.button2.TabIndex = 33
        Me.button2.Text = "CLOSE"
        Me.button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(245, 292)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 49)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "ADD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(245, 351)
        Me.button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(123, 49)
        Me.button1.TabIndex = 32
        Me.button1.Text = "SAVE"
        Me.button1.UseVisualStyleBackColor = True
        '
        'ListOfCarsBindingNavigator
        '
        Me.ListOfCarsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ListOfCarsBindingNavigator.BindingSource = Me.ListOfCarsBindingSource
        Me.ListOfCarsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListOfCarsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ListOfCarsBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ListOfCarsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListOfCarsBindingNavigatorSaveItem})
        Me.ListOfCarsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ListOfCarsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListOfCarsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListOfCarsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListOfCarsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListOfCarsBindingNavigator.Name = "ListOfCarsBindingNavigator"
        Me.ListOfCarsBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ListOfCarsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListOfCarsBindingNavigator.Size = New System.Drawing.Size(688, 33)
        Me.ListOfCarsBindingNavigator.TabIndex = 85
        Me.ListOfCarsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ListOfCarsBindingSource
        '
        Me.ListOfCarsBindingSource.DataMember = "ListOfCars"
        Me.ListOfCarsBindingSource.DataSource = Me.ListOfCarsDataSet
        '
        'ListOfCarsDataSet
        '
        Me.ListOfCarsDataSet.DataSetName = "ListOfCarsDataSet"
        Me.ListOfCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'ListOfCarsBindingNavigatorSaveItem
        '
        Me.ListOfCarsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListOfCarsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListOfCarsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ListOfCarsBindingNavigatorSaveItem.Name = "ListOfCarsBindingNavigatorSaveItem"
        Me.ListOfCarsBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.ListOfCarsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtCar_ID
        '
        Me.txtCar_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Car_ID", True))
        Me.txtCar_ID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCar_ID.Location = New System.Drawing.Point(231, 122)
        Me.txtCar_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCar_ID.Name = "txtCar_ID"
        Me.txtCar_ID.Size = New System.Drawing.Size(307, 33)
        Me.txtCar_ID.TabIndex = 86
        '
        'txtPlate_No
        '
        Me.txtPlate_No.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Plate_No", True))
        Me.txtPlate_No.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate_No.Location = New System.Drawing.Point(231, 162)
        Me.txtPlate_No.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPlate_No.Name = "txtPlate_No"
        Me.txtPlate_No.Size = New System.Drawing.Size(307, 33)
        Me.txtPlate_No.TabIndex = 88
        '
        'txtCar_Name
        '
        Me.txtCar_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Car_Name", True))
        Me.txtCar_Name.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCar_Name.Location = New System.Drawing.Point(231, 202)
        Me.txtCar_Name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCar_Name.Name = "txtCar_Name"
        Me.txtCar_Name.Size = New System.Drawing.Size(307, 33)
        Me.txtCar_Name.TabIndex = 90
        '
        'txtColor
        '
        Me.txtColor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Color", True))
        Me.txtColor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.Location = New System.Drawing.Point(231, 242)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(307, 33)
        Me.txtColor.TabIndex = 92
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Quantity", True))
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(231, 282)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(307, 33)
        Me.txtQuantity.TabIndex = 94
        '
        'txtRent_Day
        '
        Me.txtRent_Day.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListOfCarsBindingSource, "Rent/Day", True))
        Me.txtRent_Day.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRent_Day.Location = New System.Drawing.Point(231, 322)
        Me.txtRent_Day.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRent_Day.Name = "txtRent_Day"
        Me.txtRent_Day.Size = New System.Drawing.Size(307, 33)
        Me.txtRent_Day.TabIndex = 96
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.button1)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 88)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(602, 427)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        '
        'ListOfCarsTableAdapter
        '
        Me.ListOfCarsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ListOfCarsTableAdapter = Me.ListOfCarsTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Label2.Font = New System.Drawing.Font("Georgia", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 60)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Add Car"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.PictureBox2.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(694, 82)
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'AddCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(688, 622)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Car_IDLabel)
        Me.Controls.Add(Me.txtCar_ID)
        Me.Controls.Add(Plate_NoLabel)
        Me.Controls.Add(Me.txtPlate_No)
        Me.Controls.Add(Car_NameLabel)
        Me.Controls.Add(Me.txtCar_Name)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Rent_DayLabel)
        Me.Controls.Add(Me.txtRent_Day)
        Me.Controls.Add(Me.ListOfCarsBindingNavigator)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddCar"
        Me.Text = "Add Car"
        Me.groupBox2.ResumeLayout(False)
        CType(Me.ListOfCarsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListOfCarsBindingNavigator.ResumeLayout(False)
        Me.ListOfCarsBindingNavigator.PerformLayout()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents ListOfCarsDataSet As FinalCarRentalSystem.ListOfCarsDataSet
    Friend WithEvents ListOfCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsTableAdapter As FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
    Friend WithEvents TableAdapterManager As FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListOfCarsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListOfCarsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCar_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtPlate_No As System.Windows.Forms.TextBox
    Friend WithEvents txtCar_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtRent_Day As System.Windows.Forms.TextBox
    Private WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
