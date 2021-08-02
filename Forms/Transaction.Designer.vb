<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaction
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
        Dim Rent_IDLabel As System.Windows.Forms.Label
        Dim Rent_HoursLbl As System.Windows.Forms.Label
        Dim Deposit_label As System.Windows.Forms.Label
        Dim Total_DueLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction))
        Dim Label1 As System.Windows.Forms.Label
        Me.Rent_DetailsDataSet = New FinalCarRentalSystem.Rent_DetailsDataSet()
        Me.RentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter()
        Me.TableAdapterManager = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager()
        Me.Rent_DetailsTableAdapter = New FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter()
        Me.RentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.RentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Rent_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Rent_Hours = New System.Windows.Forms.TextBox()
        Me.Deposit = New System.Windows.Forms.TextBox()
        Me.Total_Fees = New System.Windows.Forms.TextBox()
        Me.Rent_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfCarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfCarsDataSet = New FinalCarRentalSystem.ListOfCarsDataSet()
        Me.ListOfCarsTableAdapter = New FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataSet = New FinalCarRentalSystem.CustomerDataSet()
        Me.CustomerTableAdapter = New FinalCarRentalSystem.CustomerDataSetTableAdapters.CustomerTableAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Rent_IDLabel = New System.Windows.Forms.Label()
        Rent_HoursLbl = New System.Windows.Forms.Label()
        Deposit_label = New System.Windows.Forms.Label()
        Total_DueLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RentBindingNavigator.SuspendLayout()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rent_IDLabel
        '
        Rent_IDLabel.AutoSize = True
        Rent_IDLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rent_IDLabel.Location = New System.Drawing.Point(44, 163)
        Rent_IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rent_IDLabel.Name = "Rent_IDLabel"
        Rent_IDLabel.Size = New System.Drawing.Size(79, 28)
        Rent_IDLabel.TabIndex = 1
        Rent_IDLabel.Text = "Rent ID:"
        '
        'Rent_HoursLbl
        '
        Rent_HoursLbl.AutoSize = True
        Rent_HoursLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rent_HoursLbl.Location = New System.Drawing.Point(27, 100)
        Rent_HoursLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rent_HoursLbl.Name = "Rent_HoursLbl"
        Rent_HoursLbl.Size = New System.Drawing.Size(120, 28)
        Rent_HoursLbl.TabIndex = 27
        Rent_HoursLbl.Text = "Rent/Hours :"
        '
        'Deposit_label
        '
        Deposit_label.AutoSize = True
        Deposit_label.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Deposit_label.Location = New System.Drawing.Point(26, 151)
        Deposit_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Deposit_label.Name = "Deposit_label"
        Deposit_label.Size = New System.Drawing.Size(131, 28)
        Deposit_label.TabIndex = 29
        Deposit_label.Text = "Deposit (RM):"
        '
        'Total_DueLabel
        '
        Total_DueLabel.Location = New System.Drawing.Point(0, 0)
        Total_DueLabel.Name = "Total_DueLabel"
        Total_DueLabel.Size = New System.Drawing.Size(100, 23)
        Total_DueLabel.TabIndex = 36
        '
        'Rent_DetailsDataSet
        '
        Me.Rent_DetailsDataSet.DataSetName = "Rent_DetailsDataSet"
        Me.Rent_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentBindingSource
        '
        Me.RentBindingSource.DataMember = "Rent"
        Me.RentBindingSource.DataSource = Me.Rent_DetailsDataSet
        '
        'RentTableAdapter
        '
        Me.RentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Rent_DetailsTableAdapter = Me.Rent_DetailsTableAdapter
        Me.TableAdapterManager.RentTableAdapter = Me.RentTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Rent_DetailsTableAdapter
        '
        Me.Rent_DetailsTableAdapter.ClearBeforeFill = True
        '
        'RentBindingNavigator
        '
        Me.RentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RentBindingNavigator.BindingSource = Me.RentBindingSource
        Me.RentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RentBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.RentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RentBindingNavigatorSaveItem})
        Me.RentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RentBindingNavigator.Name = "RentBindingNavigator"
        Me.RentBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.RentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RentBindingNavigator.Size = New System.Drawing.Size(669, 33)
        Me.RentBindingNavigator.TabIndex = 0
        Me.RentBindingNavigator.Text = "BindingNavigator1"
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
        'RentBindingNavigatorSaveItem
        '
        Me.RentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RentBindingNavigatorSaveItem.Image = CType(resources.GetObject("RentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RentBindingNavigatorSaveItem.Name = "RentBindingNavigatorSaveItem"
        Me.RentBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.RentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Rent_IDTextBox
        '
        Me.Rent_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Rent_ID", True))
        Me.Rent_IDTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rent_IDTextBox.Location = New System.Drawing.Point(186, 158)
        Me.Rent_IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Rent_IDTextBox.Name = "Rent_IDTextBox"
        Me.Rent_IDTextBox.Size = New System.Drawing.Size(298, 33)
        Me.Rent_IDTextBox.TabIndex = 2
        '
        'Rent_Hours
        '
        Me.Rent_Hours.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Rent/Day", True))
        Me.Rent_Hours.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rent_Hours.Location = New System.Drawing.Point(168, 97)
        Me.Rent_Hours.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Rent_Hours.Name = "Rent_Hours"
        Me.Rent_Hours.Size = New System.Drawing.Size(298, 33)
        Me.Rent_Hours.TabIndex = 28
        '
        'Deposit
        '
        Me.Deposit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "No_of_Days", True))
        Me.Deposit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deposit.Location = New System.Drawing.Point(168, 151)
        Me.Deposit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Deposit.Name = "Deposit"
        Me.Deposit.Size = New System.Drawing.Size(298, 33)
        Me.Deposit.TabIndex = 30
        '
        'Total_Fees
        '
        Me.Total_Fees.BackColor = System.Drawing.Color.HotPink
        Me.Total_Fees.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentBindingSource, "Total_Due", True))
        Me.Total_Fees.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Fees.Location = New System.Drawing.Point(168, 219)
        Me.Total_Fees.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Total_Fees.Name = "Total_Fees"
        Me.Total_Fees.ReadOnly = True
        Me.Total_Fees.Size = New System.Drawing.Size(298, 33)
        Me.Total_Fees.TabIndex = 32
        '
        'ListOfCarsDataSet
        '
        Me.ListOfCarsDataSet.DataSetName = "ListOfCarsDataSet"
        Me.ListOfCarsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListOfCarsTableAdapter
        '
        Me.ListOfCarsTableAdapter.ClearBeforeFill = True
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.CustomerDataSet
        '
        'CustomerDataSet
        '
        Me.CustomerDataSet.DataSetName = "CustomerDataSet"
        Me.CustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(674, 82)
        Me.PictureBox2.TabIndex = 102
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Rent_HoursLbl)
        Me.GroupBox2.Controls.Add(Me.Rent_Hours)
        Me.GroupBox2.Controls.Add(Deposit_label)
        Me.GroupBox2.Controls.Add(Me.Deposit)
        Me.GroupBox2.Controls.Add(Total_DueLabel)
        Me.GroupBox2.Controls.Add(Me.Total_Fees)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 117)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(636, 341)
        Me.GroupBox2.TabIndex = 109
        Me.GroupBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(488, 271)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 43)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Print"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(488, 210)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 42)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Calculate"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Label2.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 56)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Transaction"
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(330, 23)
        Me.button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(110, 49)
        Me.button2.TabIndex = 19
        Me.button2.Text = "CLOSE"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(8, 23)
        Me.button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(127, 49)
        Me.button3.TabIndex = 22
        Me.button3.Text = "ADD"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(168, 23)
        Me.button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(123, 49)
        Me.button1.TabIndex = 18
        Me.button1.Text = "SAVE"
        Me.button1.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.button1)
        Me.groupBox3.Controls.Add(Me.button3)
        Me.groupBox3.Controls.Add(Me.button2)
        Me.groupBox3.Location = New System.Drawing.Point(95, 468)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBox3.Size = New System.Drawing.Size(461, 88)
        Me.groupBox3.TabIndex = 104
        Me.groupBox3.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(34, 195)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(92, 84)
        Label1.TabIndex = 35
        Label1.Text = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Payment " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM) :"
        '
        'Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(669, 574)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Rent_IDLabel)
        Me.Controls.Add(Me.Rent_IDTextBox)
        Me.Controls.Add(Me.RentBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Transaction"
        Me.Text = "Form2"
        CType(Me.Rent_DetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RentBindingNavigator.ResumeLayout(False)
        Me.RentBindingNavigator.PerformLayout()
        CType(Me.Rent_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfCarsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rent_DetailsDataSet As FinalCarRentalSystem.Rent_DetailsDataSet
    Friend WithEvents RentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RentTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.RentTableAdapter
    Friend WithEvents TableAdapterManager As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Rent_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rent_Hours As System.Windows.Forms.TextBox
    Friend WithEvents Deposit As System.Windows.Forms.TextBox
    Friend WithEvents Total_Fees As System.Windows.Forms.TextBox
    Friend WithEvents Rent_DetailsTableAdapter As FinalCarRentalSystem.Rent_DetailsDataSetTableAdapters.Rent_DetailsTableAdapter
    Friend WithEvents Rent_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsDataSet As FinalCarRentalSystem.ListOfCarsDataSet
    Friend WithEvents ListOfCarsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfCarsTableAdapter As FinalCarRentalSystem.ListOfCarsDataSetTableAdapters.ListOfCarsTableAdapter
    Friend WithEvents CustomerDataSet As FinalCarRentalSystem.CustomerDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As FinalCarRentalSystem.CustomerDataSetTableAdapters.CustomerTableAdapter
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Private WithEvents button2 As Button
    Private WithEvents button3 As Button
    Private WithEvents button1 As Button
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents Button5 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
