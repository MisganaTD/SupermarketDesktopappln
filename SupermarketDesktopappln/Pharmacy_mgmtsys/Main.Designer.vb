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
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CosmeticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCosmoticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotePadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MicrosoftWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBoxMain = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.myTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStripMain.SuspendLayout()
        Me.GroupBoxMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripMain
        '
        Me.MenuStripMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.AddStockToolStripMenuItem, Me.SalesToolStripMenuItem, Me.CashierToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.UserAccountToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1055, 24)
        Me.MenuStripMain.TabIndex = 0
        Me.MenuStripMain.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserEmployeeToolStripMenuItem, Me.ManageStockToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'AddUserEmployeeToolStripMenuItem
        '
        Me.AddUserEmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.ReToolStripMenuItem})
        Me.AddUserEmployeeToolStripMenuItem.Name = "AddUserEmployeeToolStripMenuItem"
        Me.AddUserEmployeeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddUserEmployeeToolStripMenuItem.Text = "Manage Employee"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User Employee"
        '
        'ReToolStripMenuItem
        '
        Me.ReToolStripMenuItem.Name = "ReToolStripMenuItem"
        Me.ReToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ReToolStripMenuItem.Text = "Reset User Account"
        '
        'ManageStockToolStripMenuItem
        '
        Me.ManageStockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CosmeticToolStripMenuItem})
        Me.ManageStockToolStripMenuItem.Name = "ManageStockToolStripMenuItem"
        Me.ManageStockToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ManageStockToolStripMenuItem.Text = "Manage Stock"
        '
        'CosmeticToolStripMenuItem
        '
        Me.CosmeticToolStripMenuItem.Name = "CosmeticToolStripMenuItem"
        Me.CosmeticToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CosmeticToolStripMenuItem.Text = "Stock"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AddStockToolStripMenuItem
        '
        Me.AddStockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCosmoticsToolStripMenuItem})
        Me.AddStockToolStripMenuItem.Name = "AddStockToolStripMenuItem"
        Me.AddStockToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.AddStockToolStripMenuItem.Text = "Add Stock"
        '
        'AddCosmoticsToolStripMenuItem
        '
        Me.AddCosmoticsToolStripMenuItem.Name = "AddCosmoticsToolStripMenuItem"
        Me.AddCosmoticsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddCosmoticsToolStripMenuItem.Text = "Add Stock"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'CashierToolStripMenuItem
        '
        Me.CashierToolStripMenuItem.Name = "CashierToolStripMenuItem"
        Me.CashierToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.CashierToolStripMenuItem.Text = "Cashier"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.NotePadToolStripMenuItem, Me.MsExcelToolStripMenuItem, Me.MicrosoftWordToolStripMenuItem, Me.TaskManagerToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NotePadToolStripMenuItem
        '
        Me.NotePadToolStripMenuItem.Name = "NotePadToolStripMenuItem"
        Me.NotePadToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NotePadToolStripMenuItem.Text = "Notepad"
        '
        'MsExcelToolStripMenuItem
        '
        Me.MsExcelToolStripMenuItem.Name = "MsExcelToolStripMenuItem"
        Me.MsExcelToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MsExcelToolStripMenuItem.Text = "Microsoft Excel"
        '
        'MicrosoftWordToolStripMenuItem
        '
        Me.MicrosoftWordToolStripMenuItem.Name = "MicrosoftWordToolStripMenuItem"
        Me.MicrosoftWordToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MicrosoftWordToolStripMenuItem.Text = "Microsoft Word"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'UserAccountToolStripMenuItem
        '
        Me.UserAccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem})
        Me.UserAccountToolStripMenuItem.Name = "UserAccountToolStripMenuItem"
        Me.UserAccountToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.UserAccountToolStripMenuItem.Text = "User Account"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'GroupBoxMain
        '
        Me.GroupBoxMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBoxMain.Controls.Add(Me.Label5)
        Me.GroupBoxMain.Controls.Add(Me.lbltime)
        Me.GroupBoxMain.Controls.Add(Me.Label2)
        Me.GroupBoxMain.Controls.Add(Me.lblUID)
        Me.GroupBoxMain.Controls.Add(Me.Label1)
        Me.GroupBoxMain.Controls.Add(Me.lblusername)
        Me.GroupBoxMain.Location = New System.Drawing.Point(719, 29)
        Me.GroupBoxMain.Name = "GroupBoxMain"
        Me.GroupBoxMain.Size = New System.Drawing.Size(331, 119)
        Me.GroupBoxMain.TabIndex = 23
        Me.GroupBoxMain.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(7, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Time:"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbltime.Location = New System.Drawing.Point(105, 73)
        Me.lbltime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(11, 16)
        Me.lbltime.TabIndex = 26
        Me.lbltime.Text = "-"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Active User ID:"
        '
        'lblUID
        '
        Me.lblUID.AutoSize = True
        Me.lblUID.BackColor = System.Drawing.Color.Transparent
        Me.lblUID.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUID.Location = New System.Drawing.Point(105, 44)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(11, 16)
        Me.lblUID.TabIndex = 22
        Me.lblUID.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Welcome:"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Book Antiqua", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblusername.Location = New System.Drawing.Point(105, 15)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(11, 16)
        Me.lblusername.TabIndex = 20
        Me.lblusername.Text = "-"
        '
        'myTimer
        '
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1055, 576)
        Me.Controls.Add(Me.GroupBoxMain)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStripMain
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu - Supermarket Desktop Appln"
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.GroupBoxMain.ResumeLayout(False)
        Me.GroupBoxMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCosmoticsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CashierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotePadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBoxMain As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents myTimer As Timer
    Friend WithEvents MicrosoftWordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CosmeticToolStripMenuItem As ToolStripMenuItem
End Class
