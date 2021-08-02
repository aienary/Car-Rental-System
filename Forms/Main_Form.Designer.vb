<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AddCarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerBookingCarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnCarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnDetailsStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Pink
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.Font = New System.Drawing.Font("Myriad Hebrew", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCarsToolStripMenuItem, Me.CarsToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.FileMenu, Me.RegisterToolStripMenuItem1, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(205, 614)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AddCarsToolStripMenuItem
        '
        Me.AddCarsToolStripMenuItem.Name = "AddCarsToolStripMenuItem"
        Me.AddCarsToolStripMenuItem.Size = New System.Drawing.Size(198, 44)
        Me.AddCarsToolStripMenuItem.Text = "Add Cars"
        '
        'CarsToolStripMenuItem
        '
        Me.CarsToolStripMenuItem.Name = "CarsToolStripMenuItem"
        Me.CarsToolStripMenuItem.Size = New System.Drawing.Size(198, 44)
        Me.CarsToolStripMenuItem.Text = "Cars"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerBookingCarToolStripMenuItem, Me.ReturnCarToolStripMenuItem, Me.ReturnDetailsStatusToolStripMenuItem})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(198, 44)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'CustomerBookingCarToolStripMenuItem
        '
        Me.CustomerBookingCarToolStripMenuItem.Name = "CustomerBookingCarToolStripMenuItem"
        Me.CustomerBookingCarToolStripMenuItem.Size = New System.Drawing.Size(430, 48)
        Me.CustomerBookingCarToolStripMenuItem.Text = "Booking Details"
        '
        'ReturnCarToolStripMenuItem
        '
        Me.ReturnCarToolStripMenuItem.Name = "ReturnCarToolStripMenuItem"
        Me.ReturnCarToolStripMenuItem.Size = New System.Drawing.Size(430, 48)
        Me.ReturnCarToolStripMenuItem.Text = "Return Car"
        '
        'ReturnDetailsStatusToolStripMenuItem
        '
        Me.ReturnDetailsStatusToolStripMenuItem.Name = "ReturnDetailsStatusToolStripMenuItem"
        Me.ReturnDetailsStatusToolStripMenuItem.Size = New System.Drawing.Size(430, 48)
        Me.ReturnDetailsStatusToolStripMenuItem.Text = "Return Details/Status"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator5, Me.PrintSetupToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(198, 44)
        Me.FileMenu.Text = "&Transaction"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(329, 6)
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(332, 48)
        Me.PrintSetupToolStripMenuItem.Text = "Customer Fees"
        '
        'RegisterToolStripMenuItem1
        '
        Me.RegisterToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem2})
        Me.RegisterToolStripMenuItem1.Name = "RegisterToolStripMenuItem1"
        Me.RegisterToolStripMenuItem1.Size = New System.Drawing.Size(198, 44)
        Me.RegisterToolStripMenuItem1.Text = "Admin"
        '
        'RegisterToolStripMenuItem2
        '
        Me.RegisterToolStripMenuItem2.Name = "RegisterToolStripMenuItem2"
        Me.RegisterToolStripMenuItem2.Size = New System.Drawing.Size(243, 48)
        Me.RegisterToolStripMenuItem2.Text = "Register"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(198, 44)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(198, 44)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Label2.Font = New System.Drawing.Font("Adobe Gothic Std B", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(203, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(697, 65)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "DMF CAR RENTAL SYSTEM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MediumVioletRed
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(696, 112)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "SMART CAR ? JUST RENTAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepPink
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "MENU LIST"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightPink
        Me.Label4.Font = New System.Drawing.Font("Adobe Garamond Pro Bold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(769, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 437)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "STAY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SAFE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ALWAYS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WEAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MASK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(898, 614)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main_Form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMIN PAGE"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CarsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCarsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerBookingCarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnCarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnDetailsStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
