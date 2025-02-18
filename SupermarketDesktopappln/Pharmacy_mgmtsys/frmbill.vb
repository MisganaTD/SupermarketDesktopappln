Public Class frmbill
    Private Sub frmbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bill_DataSet.salestbl' table. You can move, or remove it, as needed.
        Me.salestblTableAdapter.Fill(Me.Bill_DataSet.salestbl)

        Me.ReportViewerbill.RefreshReport()
    End Sub
End Class