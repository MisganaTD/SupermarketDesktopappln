<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashier))
        Me.DataGridViewCashier = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxtotalprice = New System.Windows.Forms.TextBox()
        Me.txtboxstocname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtboxcustomerid = New System.Windows.Forms.TextBox()
        Me.txtboxstockquantity = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtboxcustname = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxcashchange = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtboxcashrecieve = New System.Windows.Forms.TextBox()
        Me.btnchange = New System.Windows.Forms.Button()
        Me.btnsale = New System.Windows.Forms.Button()
        Me.ErrorProviderCsh = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxsalesid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblpricebyyou = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btntpricetoday = New System.Windows.Forms.Button()
        Me.PrintDocumentBill = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialogbill = New System.Windows.Forms.PrintPreviewDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rtxtboxprintbill = New System.Windows.Forms.RichTextBox()
        Me.btnpbill = New System.Windows.Forms.Button()
        CType(Me.DataGridViewCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderCsh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewCashier
        '
        Me.DataGridViewCashier.AllowUserToAddRows = False
        Me.DataGridViewCashier.AllowUserToDeleteRows = False
        Me.DataGridViewCashier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCashier.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewCashier.Name = "DataGridViewCashier"
        Me.DataGridViewCashier.ReadOnly = True
        Me.DataGridViewCashier.Size = New System.Drawing.Size(855, 296)
        Me.DataGridViewCashier.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(299, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Price"
        '
        'txtboxtotalprice
        '
        Me.txtboxtotalprice.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxtotalprice.Enabled = False
        Me.txtboxtotalprice.Location = New System.Drawing.Point(282, 28)
        Me.txtboxtotalprice.Name = "txtboxtotalprice"
        Me.txtboxtotalprice.ReadOnly = True
        Me.txtboxtotalprice.Size = New System.Drawing.Size(79, 22)
        Me.txtboxtotalprice.TabIndex = 94
        '
        'txtboxstocname
        '
        Me.txtboxstocname.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxstocname.Location = New System.Drawing.Point(366, 28)
        Me.txtboxstocname.Name = "txtboxstocname"
        Me.txtboxstocname.ReadOnly = True
        Me.txtboxstocname.Size = New System.Drawing.Size(167, 22)
        Me.txtboxstocname.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(416, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Stock Name"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(104, 7)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 15)
        Me.Label24.TabIndex = 89
        Me.Label24.Text = "Customer ID"
        '
        'txtboxcustomerid
        '
        Me.txtboxcustomerid.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxcustomerid.Enabled = False
        Me.txtboxcustomerid.Location = New System.Drawing.Point(100, 28)
        Me.txtboxcustomerid.Name = "txtboxcustomerid"
        Me.txtboxcustomerid.ReadOnly = True
        Me.txtboxcustomerid.Size = New System.Drawing.Size(79, 22)
        Me.txtboxcustomerid.TabIndex = 88
        '
        'txtboxstockquantity
        '
        Me.txtboxstockquantity.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxstockquantity.Location = New System.Drawing.Point(184, 28)
        Me.txtboxstockquantity.Name = "txtboxstockquantity"
        Me.txtboxstockquantity.ReadOnly = True
        Me.txtboxstockquantity.Size = New System.Drawing.Size(91, 22)
        Me.txtboxstockquantity.TabIndex = 87
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(594, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 15)
        Me.Label19.TabIndex = 86
        Me.Label19.Text = "Customer Name"
        '
        'txtboxcustname
        '
        Me.txtboxcustname.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxcustname.Location = New System.Drawing.Point(539, 29)
        Me.txtboxcustname.Name = "txtboxcustname"
        Me.txtboxcustname.ReadOnly = True
        Me.txtboxcustname.Size = New System.Drawing.Size(184, 22)
        Me.txtboxcustname.TabIndex = 85
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(200, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 15)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(122, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Cash Change"
        '
        'txtboxcashchange
        '
        Me.txtboxcashchange.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxcashchange.Location = New System.Drawing.Point(97, 86)
        Me.txtboxcashchange.Name = "txtboxcashchange"
        Me.txtboxcashchange.ReadOnly = True
        Me.txtboxcashchange.Size = New System.Drawing.Size(120, 22)
        Me.txtboxcashchange.TabIndex = 98
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(12, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 15)
        Me.Label20.TabIndex = 97
        Me.Label20.Text = "Cash Recieved"
        '
        'txtboxcashrecieve
        '
        Me.txtboxcashrecieve.BackColor = System.Drawing.Color.White
        Me.txtboxcashrecieve.Location = New System.Drawing.Point(12, 86)
        Me.txtboxcashrecieve.Name = "txtboxcashrecieve"
        Me.txtboxcashrecieve.Size = New System.Drawing.Size(79, 22)
        Me.txtboxcashrecieve.TabIndex = 96
        Me.txtboxcashrecieve.Tag = "Please enter PD"
        '
        'btnchange
        '
        Me.btnchange.BackColor = System.Drawing.Color.Transparent
        Me.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnchange.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnchange.Location = New System.Drawing.Point(223, 85)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.Size = New System.Drawing.Size(67, 23)
        Me.btnchange.TabIndex = 101
        Me.btnchange.Text = "Change"
        Me.btnchange.UseVisualStyleBackColor = False
        '
        'btnsale
        '
        Me.btnsale.BackColor = System.Drawing.Color.Transparent
        Me.btnsale.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnsale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsale.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsale.Location = New System.Drawing.Point(729, 27)
        Me.btnsale.Name = "btnsale"
        Me.btnsale.Size = New System.Drawing.Size(72, 23)
        Me.btnsale.TabIndex = 100
        Me.btnsale.Text = "Sale"
        Me.btnsale.UseVisualStyleBackColor = False
        '
        'ErrorProviderCsh
        '
        Me.ErrorProviderCsh.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Sales ID"
        '
        'txtboxsalesid
        '
        Me.txtboxsalesid.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxsalesid.Enabled = False
        Me.txtboxsalesid.Location = New System.Drawing.Point(12, 28)
        Me.txtboxsalesid.Name = "txtboxsalesid"
        Me.txtboxsalesid.ReadOnly = True
        Me.txtboxsalesid.Size = New System.Drawing.Size(79, 22)
        Me.txtboxsalesid.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(378, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 15)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Total stock saled by you today = "
        '
        'lblpricebyyou
        '
        Me.lblpricebyyou.AutoSize = True
        Me.lblpricebyyou.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpricebyyou.ForeColor = System.Drawing.Color.Green
        Me.lblpricebyyou.Location = New System.Drawing.Point(563, 89)
        Me.lblpricebyyou.Name = "lblpricebyyou"
        Me.lblpricebyyou.Size = New System.Drawing.Size(11, 15)
        Me.lblpricebyyou.TabIndex = 105
        Me.lblpricebyyou.Text = "-"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(807, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(12, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 37)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "Genereate Bill"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btntpricetoday
        '
        Me.btntpricetoday.BackColor = System.Drawing.Color.Transparent
        Me.btntpricetoday.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btntpricetoday.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntpricetoday.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btntpricetoday.Location = New System.Drawing.Point(294, 85)
        Me.btntpricetoday.Name = "btntpricetoday"
        Me.btntpricetoday.Size = New System.Drawing.Size(78, 23)
        Me.btntpricetoday.TabIndex = 108
        Me.btntpricetoday.Text = "Saled Today"
        Me.btntpricetoday.UseVisualStyleBackColor = False
        '
        'PrintDocumentBill
        '
        '
        'PrintPreviewDialogbill
        '
        Me.PrintPreviewDialogbill.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogbill.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialogbill.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialogbill.Document = Me.PrintDocumentBill
        Me.PrintPreviewDialogbill.Enabled = True
        Me.PrintPreviewDialogbill.Icon = CType(resources.GetObject("PrintPreviewDialogbill.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialogbill.Name = "PrintPreviewDialogbill"
        Me.PrintPreviewDialogbill.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 157)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(875, 336)
        Me.TabControl1.TabIndex = 109
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewCashier)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(867, 308)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SALES"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnpbill)
        Me.TabPage2.Controls.Add(Me.rtxtboxprintbill)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(867, 308)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PRINT BILL"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'rtxtboxprintbill
        '
        Me.rtxtboxprintbill.AcceptsTab = True
        Me.rtxtboxprintbill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtboxprintbill.Location = New System.Drawing.Point(38, 15)
        Me.rtxtboxprintbill.Name = "rtxtboxprintbill"
        Me.rtxtboxprintbill.Size = New System.Drawing.Size(388, 236)
        Me.rtxtboxprintbill.TabIndex = 0
        Me.rtxtboxprintbill.Text = ""
        '
        'btnpbill
        '
        Me.btnpbill.BackColor = System.Drawing.Color.Transparent
        Me.btnpbill.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnpbill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpbill.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnpbill.Location = New System.Drawing.Point(38, 257)
        Me.btnpbill.Name = "btnpbill"
        Me.btnpbill.Size = New System.Drawing.Size(72, 38)
        Me.btnpbill.TabIndex = 110
        Me.btnpbill.Text = "Print"
        Me.btnpbill.UseVisualStyleBackColor = False
        '
        'frmCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(899, 499)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btntpricetoday)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblpricebyyou)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxsalesid)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.btnsale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxcashchange)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtboxcashrecieve)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxtotalprice)
        Me.Controls.Add(Me.txtboxstocname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtboxcustomerid)
        Me.Controls.Add(Me.txtboxstockquantity)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtboxcustname)
        Me.Controls.Add(Me.Label17)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier - Supermarket Desktop Appln"
        CType(Me.DataGridViewCashier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderCsh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewCashier As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxtotalprice As TextBox
    Friend WithEvents txtboxstocname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtboxcustomerid As TextBox
    Friend WithEvents txtboxstockquantity As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtboxcustname As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxcashchange As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtboxcashrecieve As TextBox
    Friend WithEvents btnchange As Button
    Friend WithEvents btnsale As Button
    Friend WithEvents ErrorProviderCsh As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxsalesid As TextBox
    Friend WithEvents lblpricebyyou As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btntpricetoday As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PrintDocumentBill As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialogbill As PrintPreviewDialog
    Friend WithEvents rtxtboxprintbill As RichTextBox
    Friend WithEvents btnpbill As Button
End Class
