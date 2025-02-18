<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbill
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewerbill = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Bill_DataSet = New Pharmacy_mgmtsys.Bill_DataSet()
        Me.salestblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.salestblTableAdapter = New Pharmacy_mgmtsys.Bill_DataSetTableAdapters.salestblTableAdapter()
        CType(Me.Bill_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salestblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewerbill
        '
        Me.ReportViewerbill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "Bill_DataSet"
        ReportDataSource1.Value = Me.salestblBindingSource
        Me.ReportViewerbill.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerbill.LocalReport.ReportEmbeddedResource = "Pharmacy_mgmtsys.frmbillreport.rdlc"
        Me.ReportViewerbill.Location = New System.Drawing.Point(12, 87)
        Me.ReportViewerbill.Name = "ReportViewerbill"
        Me.ReportViewerbill.Size = New System.Drawing.Size(875, 400)
        Me.ReportViewerbill.TabIndex = 0
        '
        'Bill_DataSet
        '
        Me.Bill_DataSet.DataSetName = "Bill_DataSet"
        Me.Bill_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'salestblBindingSource
        '
        Me.salestblBindingSource.DataMember = "salestbl"
        Me.salestblBindingSource.DataSource = Me.Bill_DataSet
        '
        'salestblTableAdapter
        '
        Me.salestblTableAdapter.ClearBeforeFill = True
        '
        'frmbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 499)
        Me.Controls.Add(Me.ReportViewerbill)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Bill  - Supermarket Desktop Appln"
        CType(Me.Bill_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salestblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewerbill As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents salestblBindingSource As BindingSource
    Friend WithEvents Bill_DataSet As Bill_DataSet
    Friend WithEvents salestblTableAdapter As Bill_DataSetTableAdapters.salestblTableAdapter
End Class
