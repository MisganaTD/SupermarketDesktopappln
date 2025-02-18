<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportStock
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
        Me.SaveFileDialogslesrprt = New System.Windows.Forms.SaveFileDialog()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBoxall = New System.Windows.Forms.GroupBox()
        Me.btnviewSales = New System.Windows.Forms.Button()
        Me.DateTimePickersalesfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePickersalesto = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnexporttoexcelsales = New System.Windows.Forms.Button()
        Me.DataGridViewsals = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewcosexpired = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5.SuspendLayout()
        Me.GroupBoxall.SuspendLayout()
        CType(Me.DataGridViewsals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewcosexpired, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Lavender
        Me.TabPage5.Controls.Add(Me.DataGridViewsals)
        Me.TabPage5.Controls.Add(Me.GroupBoxall)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(867, 447)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "SALES RESULT"
        '
        'GroupBoxall
        '
        Me.GroupBoxall.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxall.Controls.Add(Me.btnexporttoexcelsales)
        Me.GroupBoxall.Controls.Add(Me.Label1)
        Me.GroupBoxall.Controls.Add(Me.DateTimePickersalesto)
        Me.GroupBoxall.Controls.Add(Me.Label11)
        Me.GroupBoxall.Controls.Add(Me.DateTimePickersalesfrom)
        Me.GroupBoxall.Controls.Add(Me.btnviewSales)
        Me.GroupBoxall.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxall.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxall.Location = New System.Drawing.Point(14, 14)
        Me.GroupBoxall.Name = "GroupBoxall"
        Me.GroupBoxall.Size = New System.Drawing.Size(840, 63)
        Me.GroupBoxall.TabIndex = 6
        Me.GroupBoxall.TabStop = False
        '
        'btnviewSales
        '
        Me.btnviewSales.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewSales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnviewSales.Location = New System.Drawing.Point(336, 22)
        Me.btnviewSales.Name = "btnviewSales"
        Me.btnviewSales.Size = New System.Drawing.Size(75, 23)
        Me.btnviewSales.TabIndex = 1
        Me.btnviewSales.Text = "View"
        Me.btnviewSales.UseVisualStyleBackColor = True
        '
        'DateTimePickersalesfrom
        '
        Me.DateTimePickersalesfrom.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickersalesfrom.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickersalesfrom.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickersalesfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickersalesfrom.Location = New System.Drawing.Point(49, 22)
        Me.DateTimePickersalesfrom.Name = "DateTimePickersalesfrom"
        Me.DateTimePickersalesfrom.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickersalesfrom.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(10, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "From"
        '
        'DateTimePickersalesto
        '
        Me.DateTimePickersalesto.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickersalesto.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickersalesto.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickersalesto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickersalesto.Location = New System.Drawing.Point(210, 22)
        Me.DateTimePickersalesto.Name = "DateTimePickersalesto"
        Me.DateTimePickersalesto.Size = New System.Drawing.Size(120, 22)
        Me.DateTimePickersalesto.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(184, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "To"
        '
        'btnexporttoexcelsales
        '
        Me.btnexporttoexcelsales.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexporttoexcelsales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnexporttoexcelsales.Location = New System.Drawing.Point(417, 21)
        Me.btnexporttoexcelsales.Name = "btnexporttoexcelsales"
        Me.btnexporttoexcelsales.Size = New System.Drawing.Size(107, 24)
        Me.btnexporttoexcelsales.TabIndex = 38
        Me.btnexporttoexcelsales.Text = "Export to Excel"
        Me.btnexporttoexcelsales.UseVisualStyleBackColor = True
        '
        'DataGridViewsals
        '
        Me.DataGridViewsals.AllowUserToAddRows = False
        Me.DataGridViewsals.AllowUserToDeleteRows = False
        Me.DataGridViewsals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewsals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewsals.Location = New System.Drawing.Point(10, 83)
        Me.DataGridViewsals.Name = "DataGridViewsals"
        Me.DataGridViewsals.ReadOnly = True
        Me.DataGridViewsals.Size = New System.Drawing.Size(844, 349)
        Me.DataGridViewsals.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Lavender
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.DataGridViewcosexpired)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(867, 447)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "STOCK EXPIRED"
        '
        'DataGridViewcosexpired
        '
        Me.DataGridViewcosexpired.AllowUserToAddRows = False
        Me.DataGridViewcosexpired.AllowUserToDeleteRows = False
        Me.DataGridViewcosexpired.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewcosexpired.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewcosexpired.Location = New System.Drawing.Point(12, 14)
        Me.DataGridViewcosexpired.Name = "DataGridViewcosexpired"
        Me.DataGridViewcosexpired.ReadOnly = True
        Me.DataGridViewcosexpired.Size = New System.Drawing.Size(841, 384)
        Me.DataGridViewcosexpired.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(12, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(875, 475)
        Me.TabControl1.TabIndex = 114
        '
        'frmReportStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(899, 499)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report - Supermarket Desktop Appln"
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBoxall.ResumeLayout(False)
        Me.GroupBoxall.PerformLayout()
        CType(Me.DataGridViewsals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridViewcosexpired, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialogslesrprt As SaveFileDialog
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents DataGridViewsals As DataGridView
    Friend WithEvents GroupBoxall As GroupBox
    Friend WithEvents btnexporttoexcelsales As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickersalesto As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePickersalesfrom As DateTimePicker
    Friend WithEvents btnviewSales As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewcosexpired As DataGridView
    Friend WithEvents TabControl1 As TabControl
End Class
