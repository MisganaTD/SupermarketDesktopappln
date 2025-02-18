<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxcusname = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtboxcusid = New System.Windows.Forms.TextBox()
        Me.txtboxstockprice = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtboxstockquan = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtboxstockgeneric = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtboxselectstock = New System.Windows.Forms.TextBox()
        Me.TabControlSales = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewmedsale = New System.Windows.Forms.DataGridView()
        Me.btnselectstock = New System.Windows.Forms.Button()
        Me.btnsale = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxstockbrand = New System.Windows.Forms.TextBox()
        Me.btnrefreshsale = New System.Windows.Forms.Button()
        Me.ErrorProviderSales = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtboxstockid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltotalavailablestock = New System.Windows.Forms.Label()
        Me.TabControlSales.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewmedsale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(479, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Customer name"
        '
        'txtboxcusname
        '
        Me.txtboxcusname.BackColor = System.Drawing.Color.White
        Me.txtboxcusname.Location = New System.Drawing.Point(454, 84)
        Me.txtboxcusname.Name = "txtboxcusname"
        Me.txtboxcusname.Size = New System.Drawing.Size(248, 22)
        Me.txtboxcusname.TabIndex = 68
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(316, 17)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 15)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "Customer ID"
        '
        'txtboxcusid
        '
        Me.txtboxcusid.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxcusid.Enabled = False
        Me.txtboxcusid.Location = New System.Drawing.Point(312, 38)
        Me.txtboxcusid.Name = "txtboxcusid"
        Me.txtboxcusid.ReadOnly = True
        Me.txtboxcusid.Size = New System.Drawing.Size(79, 22)
        Me.txtboxcusid.TabIndex = 66
        '
        'txtboxstockprice
        '
        Me.txtboxstockprice.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxstockprice.Location = New System.Drawing.Point(396, 38)
        Me.txtboxstockprice.Name = "txtboxstockprice"
        Me.txtboxstockprice.ReadOnly = True
        Me.txtboxstockprice.Size = New System.Drawing.Size(91, 22)
        Me.txtboxstockprice.TabIndex = 60
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(376, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 15)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Quantity"
        '
        'txtboxstockquan
        '
        Me.txtboxstockquan.BackColor = System.Drawing.Color.White
        Me.txtboxstockquan.Location = New System.Drawing.Point(369, 83)
        Me.txtboxstockquan.Name = "txtboxstockquan"
        Me.txtboxstockquan.Size = New System.Drawing.Size(79, 22)
        Me.txtboxstockquan.TabIndex = 58
        Me.txtboxstockquan.Tag = "Please enter PD"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(81, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 15)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Generic"
        '
        'txtboxstockgeneric
        '
        Me.txtboxstockgeneric.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxstockgeneric.Location = New System.Drawing.Point(26, 84)
        Me.txtboxstockgeneric.Name = "txtboxstockgeneric"
        Me.txtboxstockgeneric.ReadOnly = True
        Me.txtboxstockgeneric.Size = New System.Drawing.Size(184, 22)
        Me.txtboxstockgeneric.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(408, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 15)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Price"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(13, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 15)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Stock"
        '
        'txtboxselectstock
        '
        Me.txtboxselectstock.Location = New System.Drawing.Point(69, 36)
        Me.txtboxselectstock.Name = "txtboxselectstock"
        Me.txtboxselectstock.Size = New System.Drawing.Size(155, 22)
        Me.txtboxselectstock.TabIndex = 51
        '
        'TabControlSales
        '
        Me.TabControlSales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlSales.Controls.Add(Me.TabPage1)
        Me.TabControlSales.Location = New System.Drawing.Point(12, 126)
        Me.TabControlSales.Name = "TabControlSales"
        Me.TabControlSales.SelectedIndex = 0
        Me.TabControlSales.Size = New System.Drawing.Size(875, 361)
        Me.TabControlSales.TabIndex = 74
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridViewmedsale)
        Me.TabPage1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(867, 333)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Current Sale Stocks"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridViewmedsale
        '
        Me.DataGridViewmedsale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewmedsale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewmedsale.Location = New System.Drawing.Point(10, 6)
        Me.DataGridViewmedsale.Name = "DataGridViewmedsale"
        Me.DataGridViewmedsale.Size = New System.Drawing.Size(851, 321)
        Me.DataGridViewmedsale.TabIndex = 0
        '
        'btnselectstock
        '
        Me.btnselectstock.BackColor = System.Drawing.Color.Transparent
        Me.btnselectstock.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnselectstock.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselectstock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnselectstock.Location = New System.Drawing.Point(230, 35)
        Me.btnselectstock.Name = "btnselectstock"
        Me.btnselectstock.Size = New System.Drawing.Size(72, 23)
        Me.btnselectstock.TabIndex = 75
        Me.btnselectstock.Text = "Select"
        Me.btnselectstock.UseVisualStyleBackColor = False
        '
        'btnsale
        '
        Me.btnsale.BackColor = System.Drawing.Color.Transparent
        Me.btnsale.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnsale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsale.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnsale.Location = New System.Drawing.Point(708, 82)
        Me.btnsale.Name = "btnsale"
        Me.btnsale.Size = New System.Drawing.Size(72, 24)
        Me.btnsale.TabIndex = 76
        Me.btnsale.Text = "Sale"
        Me.btnsale.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(269, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Brand"
        '
        'txtboxstockbrand
        '
        Me.txtboxstockbrand.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxstockbrand.Location = New System.Drawing.Point(214, 84)
        Me.txtboxstockbrand.Name = "txtboxstockbrand"
        Me.txtboxstockbrand.ReadOnly = True
        Me.txtboxstockbrand.Size = New System.Drawing.Size(149, 22)
        Me.txtboxstockbrand.TabIndex = 77
        '
        'btnrefreshsale
        '
        Me.btnrefreshsale.BackColor = System.Drawing.Color.Transparent
        Me.btnrefreshsale.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnrefreshsale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefreshsale.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnrefreshsale.Location = New System.Drawing.Point(786, 82)
        Me.btnrefreshsale.Name = "btnrefreshsale"
        Me.btnrefreshsale.Size = New System.Drawing.Size(72, 24)
        Me.btnrefreshsale.TabIndex = 79
        Me.btnrefreshsale.Text = "Refresh"
        Me.btnrefreshsale.UseVisualStyleBackColor = False
        '
        'ErrorProviderSales
        '
        Me.ErrorProviderSales.ContainerControl = Me
        '
        'txtboxstockid
        '
        Me.txtboxstockid.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtboxstockid.Location = New System.Drawing.Point(496, 38)
        Me.txtboxstockid.Name = "txtboxstockid"
        Me.txtboxstockid.ReadOnly = True
        Me.txtboxstockid.Size = New System.Drawing.Size(91, 22)
        Me.txtboxstockid.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(508, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Stock ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(593, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Available stock"
        '
        'lbltotalavailablestock
        '
        Me.lbltotalavailablestock.AutoSize = True
        Me.lbltotalavailablestock.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalavailablestock.ForeColor = System.Drawing.Color.Green
        Me.lbltotalavailablestock.Location = New System.Drawing.Point(689, 41)
        Me.lbltotalavailablestock.Name = "lbltotalavailablestock"
        Me.lbltotalavailablestock.Size = New System.Drawing.Size(11, 15)
        Me.lbltotalavailablestock.TabIndex = 85
        Me.lbltotalavailablestock.Text = "-"
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(899, 499)
        Me.Controls.Add(Me.lbltotalavailablestock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtboxstockid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnrefreshsale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxstockbrand)
        Me.Controls.Add(Me.btnsale)
        Me.Controls.Add(Me.btnselectstock)
        Me.Controls.Add(Me.TabControlSales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxcusname)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtboxcusid)
        Me.Controls.Add(Me.txtboxstockprice)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtboxstockquan)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtboxstockgeneric)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtboxselectstock)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales - Supermarket Desktop Appln"
        Me.TabControlSales.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewmedsale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxcusname As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtboxcusid As TextBox
    Friend WithEvents txtboxstockprice As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtboxstockquan As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtboxstockgeneric As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtboxselectstock As TextBox
    Friend WithEvents TabControlSales As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridViewmedsale As DataGridView
    Friend WithEvents btnselectstock As Button
    Friend WithEvents btnsale As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxstockbrand As TextBox
    Friend WithEvents btnrefreshsale As Button
    Friend WithEvents ErrorProviderSales As ErrorProvider
    Friend WithEvents txtboxstockid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbltotalavailablestock As Label
    Friend WithEvents Label5 As Label
End Class
