<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddCosmeticsandothersstock
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
        Me.GroupBoxStock = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerexpidatestock = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickermanfdatestock = New System.Windows.Forms.DateTimePicker()
        Me.txtboxremarkstock = New System.Windows.Forms.TextBox()
        Me.txtboxpricestock = New System.Windows.Forms.TextBox()
        Me.txtboxbatchstock = New System.Windows.Forms.TextBox()
        Me.txtboxquanstock = New System.Windows.Forms.TextBox()
        Me.txtboximportedidstock = New System.Windows.Forms.TextBox()
        Me.txtboxbnamestock = New System.Windows.Forms.TextBox()
        Me.txtboxgnamestock = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxsernostock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewStockdata = New System.Windows.Forms.DataGridView()
        Me.btnaddnewstock = New System.Windows.Forms.Button()
        Me.btneditstock = New System.Windows.Forms.Button()
        Me.btndeletestock = New System.Windows.Forms.Button()
        Me.btnclearstock = New System.Windows.Forms.Button()
        Me.btnexporttoexcel = New System.Windows.Forms.Button()
        Me.ErrorProvideraddcos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBoxsercmed = New System.Windows.Forms.GroupBox()
        Me.btnstocksearch = New System.Windows.Forms.Button()
        Me.txtboxsearchstock = New System.Windows.Forms.TextBox()
        Me.ToolTipvalidaco = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnrefreshstock = New System.Windows.Forms.Button()
        Me.SaveFileDialogcostoc = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBoxStock.SuspendLayout()
        CType(Me.DataGridViewStockdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvideraddcos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxsercmed.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxStock
        '
        Me.GroupBoxStock.Controls.Add(Me.DateTimePickerexpidatestock)
        Me.GroupBoxStock.Controls.Add(Me.DateTimePickermanfdatestock)
        Me.GroupBoxStock.Controls.Add(Me.txtboxremarkstock)
        Me.GroupBoxStock.Controls.Add(Me.txtboxpricestock)
        Me.GroupBoxStock.Controls.Add(Me.txtboxbatchstock)
        Me.GroupBoxStock.Controls.Add(Me.txtboxquanstock)
        Me.GroupBoxStock.Controls.Add(Me.txtboximportedidstock)
        Me.GroupBoxStock.Controls.Add(Me.txtboxbnamestock)
        Me.GroupBoxStock.Controls.Add(Me.txtboxgnamestock)
        Me.GroupBoxStock.Controls.Add(Me.Label10)
        Me.GroupBoxStock.Controls.Add(Me.Label9)
        Me.GroupBoxStock.Controls.Add(Me.Label8)
        Me.GroupBoxStock.Controls.Add(Me.Label7)
        Me.GroupBoxStock.Controls.Add(Me.Label6)
        Me.GroupBoxStock.Controls.Add(Me.Label5)
        Me.GroupBoxStock.Controls.Add(Me.Label4)
        Me.GroupBoxStock.Controls.Add(Me.Label3)
        Me.GroupBoxStock.Controls.Add(Me.Label2)
        Me.GroupBoxStock.Controls.Add(Me.txtboxsernostock)
        Me.GroupBoxStock.Controls.Add(Me.Label1)
        Me.GroupBoxStock.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxStock.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxStock.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxStock.Name = "GroupBoxStock"
        Me.GroupBoxStock.Size = New System.Drawing.Size(875, 217)
        Me.GroupBoxStock.TabIndex = 0
        Me.GroupBoxStock.TabStop = False
        Me.GroupBoxStock.Text = "Stock Details"
        '
        'DateTimePickerexpidatestock
        '
        Me.DateTimePickerexpidatestock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerexpidatestock.Location = New System.Drawing.Point(568, 54)
        Me.DateTimePickerexpidatestock.Name = "DateTimePickerexpidatestock"
        Me.DateTimePickerexpidatestock.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerexpidatestock.TabIndex = 19
        '
        'DateTimePickermanfdatestock
        '
        Me.DateTimePickermanfdatestock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickermanfdatestock.Location = New System.Drawing.Point(568, 26)
        Me.DateTimePickermanfdatestock.Name = "DateTimePickermanfdatestock"
        Me.DateTimePickermanfdatestock.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickermanfdatestock.TabIndex = 18
        '
        'txtboxremarkstock
        '
        Me.txtboxremarkstock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxremarkstock.Location = New System.Drawing.Point(568, 82)
        Me.txtboxremarkstock.Multiline = True
        Me.txtboxremarkstock.Name = "txtboxremarkstock"
        Me.txtboxremarkstock.Size = New System.Drawing.Size(200, 115)
        Me.txtboxremarkstock.TabIndex = 17
        '
        'txtboxpricestock
        '
        Me.txtboxpricestock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxpricestock.Location = New System.Drawing.Point(130, 172)
        Me.txtboxpricestock.Name = "txtboxpricestock"
        Me.txtboxpricestock.Size = New System.Drawing.Size(259, 22)
        Me.txtboxpricestock.TabIndex = 16
        '
        'txtboxbatchstock
        '
        Me.txtboxbatchstock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxbatchstock.Location = New System.Drawing.Point(130, 148)
        Me.txtboxbatchstock.Name = "txtboxbatchstock"
        Me.txtboxbatchstock.Size = New System.Drawing.Size(259, 22)
        Me.txtboxbatchstock.TabIndex = 15
        '
        'txtboxquanstock
        '
        Me.txtboxquanstock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxquanstock.Location = New System.Drawing.Point(130, 123)
        Me.txtboxquanstock.Name = "txtboxquanstock"
        Me.txtboxquanstock.Size = New System.Drawing.Size(259, 22)
        Me.txtboxquanstock.TabIndex = 14
        '
        'txtboximportedidstock
        '
        Me.txtboximportedidstock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboximportedidstock.Location = New System.Drawing.Point(130, 99)
        Me.txtboximportedidstock.Name = "txtboximportedidstock"
        Me.txtboximportedidstock.Size = New System.Drawing.Size(259, 22)
        Me.txtboximportedidstock.TabIndex = 13
        '
        'txtboxbnamestock
        '
        Me.txtboxbnamestock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxbnamestock.Location = New System.Drawing.Point(130, 75)
        Me.txtboxbnamestock.Name = "txtboxbnamestock"
        Me.txtboxbnamestock.Size = New System.Drawing.Size(259, 22)
        Me.txtboxbnamestock.TabIndex = 12
        '
        'txtboxgnamestock
        '
        Me.txtboxgnamestock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxgnamestock.Location = New System.Drawing.Point(130, 50)
        Me.txtboxgnamestock.Name = "txtboxgnamestock"
        Me.txtboxgnamestock.Size = New System.Drawing.Size(259, 22)
        Me.txtboxgnamestock.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(422, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 15)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Remark"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(19, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(422, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Expired Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(422, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Manufactured Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(19, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Batch No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(19, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(19, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Imported Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(19, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Brand Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(19, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Generic Name"
        '
        'txtboxsernostock
        '
        Me.txtboxsernostock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxsernostock.Location = New System.Drawing.Point(130, 25)
        Me.txtboxsernostock.Name = "txtboxsernostock"
        Me.txtboxsernostock.Size = New System.Drawing.Size(259, 22)
        Me.txtboxsernostock.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Serial No"
        '
        'DataGridViewStockdata
        '
        Me.DataGridViewStockdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStockdata.Location = New System.Drawing.Point(12, 273)
        Me.DataGridViewStockdata.Name = "DataGridViewStockdata"
        Me.DataGridViewStockdata.Size = New System.Drawing.Size(875, 214)
        Me.DataGridViewStockdata.TabIndex = 1
        '
        'btnaddnewstock
        '
        Me.btnaddnewstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddnewstock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnaddnewstock.Location = New System.Drawing.Point(405, 235)
        Me.btnaddnewstock.Name = "btnaddnewstock"
        Me.btnaddnewstock.Size = New System.Drawing.Size(54, 32)
        Me.btnaddnewstock.TabIndex = 2
        Me.btnaddnewstock.Text = "Add"
        Me.btnaddnewstock.UseVisualStyleBackColor = True
        '
        'btneditstock
        '
        Me.btneditstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditstock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btneditstock.Location = New System.Drawing.Point(465, 235)
        Me.btneditstock.Name = "btneditstock"
        Me.btneditstock.Size = New System.Drawing.Size(57, 32)
        Me.btneditstock.TabIndex = 3
        Me.btneditstock.Text = "Edit"
        Me.btneditstock.UseVisualStyleBackColor = True
        '
        'btndeletestock
        '
        Me.btndeletestock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletestock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ErrorProvideraddcos.SetIconAlignment(Me.btndeletestock, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.btndeletestock.Location = New System.Drawing.Point(528, 235)
        Me.btndeletestock.Name = "btndeletestock"
        Me.btndeletestock.Size = New System.Drawing.Size(59, 32)
        Me.btndeletestock.TabIndex = 4
        Me.btndeletestock.Text = "Delete"
        Me.btndeletestock.UseVisualStyleBackColor = True
        '
        'btnclearstock
        '
        Me.btnclearstock.Location = New System.Drawing.Point(660, 235)
        Me.btnclearstock.Name = "btnclearstock"
        Me.btnclearstock.Size = New System.Drawing.Size(60, 32)
        Me.btnclearstock.TabIndex = 5
        Me.btnclearstock.Text = "Clear"
        Me.btnclearstock.UseVisualStyleBackColor = True
        '
        'btnexporttoexcel
        '
        Me.btnexporttoexcel.Location = New System.Drawing.Point(792, 235)
        Me.btnexporttoexcel.Name = "btnexporttoexcel"
        Me.btnexporttoexcel.Size = New System.Drawing.Size(95, 32)
        Me.btnexporttoexcel.TabIndex = 6
        Me.btnexporttoexcel.Text = "Export to Excel"
        Me.btnexporttoexcel.UseVisualStyleBackColor = True
        '
        'ErrorProvideraddcos
        '
        Me.ErrorProvideraddcos.ContainerControl = Me
        '
        'GroupBoxsercmed
        '
        Me.GroupBoxsercmed.Controls.Add(Me.btnstocksearch)
        Me.GroupBoxsercmed.Controls.Add(Me.txtboxsearchstock)
        Me.GroupBoxsercmed.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxsercmed.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxsercmed.Location = New System.Drawing.Point(12, 235)
        Me.GroupBoxsercmed.Name = "GroupBoxsercmed"
        Me.GroupBoxsercmed.Size = New System.Drawing.Size(389, 32)
        Me.GroupBoxsercmed.TabIndex = 15
        Me.GroupBoxsercmed.TabStop = False
        Me.GroupBoxsercmed.Text = "Search Item"
        '
        'btnstocksearch
        '
        Me.btnstocksearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstocksearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnstocksearch.Location = New System.Drawing.Point(312, 1)
        Me.btnstocksearch.Name = "btnstocksearch"
        Me.btnstocksearch.Size = New System.Drawing.Size(71, 32)
        Me.btnstocksearch.TabIndex = 15
        Me.btnstocksearch.Text = "Search"
        Me.btnstocksearch.UseVisualStyleBackColor = True
        '
        'txtboxsearchstock
        '
        Me.txtboxsearchstock.Location = New System.Drawing.Point(101, 5)
        Me.txtboxsearchstock.Name = "txtboxsearchstock"
        Me.txtboxsearchstock.Size = New System.Drawing.Size(205, 22)
        Me.txtboxsearchstock.TabIndex = 0
        '
        'btnrefreshstock
        '
        Me.btnrefreshstock.Location = New System.Drawing.Point(726, 235)
        Me.btnrefreshstock.Name = "btnrefreshstock"
        Me.btnrefreshstock.Size = New System.Drawing.Size(60, 32)
        Me.btnrefreshstock.TabIndex = 16
        Me.btnrefreshstock.Text = "Refresh"
        Me.btnrefreshstock.UseVisualStyleBackColor = True
        '
        'frmAddCosmeticsandothersstock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 499)
        Me.Controls.Add(Me.btnrefreshstock)
        Me.Controls.Add(Me.GroupBoxsercmed)
        Me.Controls.Add(Me.btnexporttoexcel)
        Me.Controls.Add(Me.btnclearstock)
        Me.Controls.Add(Me.btndeletestock)
        Me.Controls.Add(Me.btneditstock)
        Me.Controls.Add(Me.btnaddnewstock)
        Me.Controls.Add(Me.DataGridViewStockdata)
        Me.Controls.Add(Me.GroupBoxStock)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddCosmeticsandothersstock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Details - Supermarket Desktop Appln"
        Me.GroupBoxStock.ResumeLayout(False)
        Me.GroupBoxStock.PerformLayout()
        CType(Me.DataGridViewStockdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvideraddcos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxsercmed.ResumeLayout(False)
        Me.GroupBoxsercmed.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxStock As GroupBox
    Friend WithEvents DataGridViewStockdata As DataGridView
    Friend WithEvents btnaddnewstock As Button
    Friend WithEvents btneditstock As Button
    Friend WithEvents btndeletestock As Button
    Friend WithEvents btnclearstock As Button
    Friend WithEvents btnexporttoexcel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxsernostock As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerexpidatestock As DateTimePicker
    Friend WithEvents DateTimePickermanfdatestock As DateTimePicker
    Friend WithEvents txtboxremarkstock As TextBox
    Friend WithEvents txtboxpricestock As TextBox
    Friend WithEvents txtboxbatchstock As TextBox
    Friend WithEvents txtboxquanstock As TextBox
    Friend WithEvents txtboximportedidstock As TextBox
    Friend WithEvents txtboxbnamestock As TextBox
    Friend WithEvents txtboxgnamestock As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ErrorProvideraddcos As ErrorProvider
    Friend WithEvents GroupBoxsercmed As GroupBox
    Friend WithEvents btnstocksearch As Button
    Friend WithEvents txtboxsearchstock As TextBox
    Friend WithEvents ToolTipvalidaco As ToolTip
    Friend WithEvents btnrefreshstock As Button
    Friend WithEvents SaveFileDialogcostoc As SaveFileDialog
End Class
