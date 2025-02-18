Imports System.Data.SqlClient
Imports System.Linq
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelautoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Public Class frmReportStock
    Private Sub frmReportStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '----------------------------- view expired medicine stock ---------------------------------
        'Dim todymed As DateTime = DateTime.Today
        'Dim SearchQrymed As String = $"select * from medicinestocktbl where expireddate <= '" & todymed & "'"
        'Dim c1med As New SqlCommand(SearchQrymed, cn)
        'Dim d1med = New SqlDataAdapter(c1med)
        'Dim t1med As New DataTable()
        'd1med.Fill(t1med)
        'DataGridViewmedexpired.DataSource = t1med
        '-----------------------------------------------------------------------------------------
        '----------------------------- view expired cosmetics stock ------------------------------
        Dim todycos As DateTime = DateTime.Today
        Dim SearchQrycos As String = $"select * from stocktbl where expireddate <= '" & todycos & "'"
        Dim c1cos As New SqlCommand(SearchQrycos, cn)
        Dim d1cos = New SqlDataAdapter(c1cos)
        Dim t1cos As New DataTable()
        d1cos.Fill(t1cos)
        DataGridViewcosexpired.DataSource = t1cos
        '-----------------------------------------------------------------------------------------
    End Sub
    Private Sub btnviewSales_Click(sender As Object, e As EventArgs) Handles btnviewSales.Click
        Dim salesfrom As DateTime = DateTimePickersalesfrom.Value.ToShortDateString()
        Dim salesto As DateTime = DateTimePickersalesto.Value.ToShortDateString()
        Dim SearchQryall As String = $"select * from salestbl where salesdate between '" & salesfrom & "' AND '" & salesto & "'"
        Dim c1 As New SqlCommand(SearchQryall, cn)
        Dim d1 = New SqlDataAdapter(c1)
        Dim t1 As New DataTable()
        d1.Fill(t1)
        DataGridViewsals.DataSource = t1
    End Sub

    Private Sub btnexporttoexcelsales_Click(sender As Object, e As EventArgs) Handles btnexporttoexcelsales.Click
        Try
            btnexporttoexcelsales.Text = "Please wait..."
            btnexporttoexcelsales.Enabled = False
            SaveFileDialogslesrprt.Filter = "Excel Docoment (*.xlsx)|*.xlsx"
            If SaveFileDialogslesrprt.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlapp As Microsoft.Office.Interop.Excel.Application
                Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misval As Object = System.Reflection.Missing.Value
                Dim x As Integer
                Dim y As Integer
                xlapp = New Microsoft.Office.Interop.Excel.Application
                xlworkbook = xlapp.Workbooks.Add(misval)
                xlworksheet = xlworkbook.Sheets("Sheet1")
                For x = 0 To DataGridViewsals.RowCount - 2
                    For y = 0 To DataGridViewsals.ColumnCount - 1
                        For z As Integer = 1 To DataGridViewsals.Columns.Count
                            xlworksheet.Cells(1, z) = DataGridViewsals.Columns(z - 1).HeaderText
                            xlworksheet.Cells(x + 2, y + 1) = DataGridViewsals(y, x).Value.ToString()
                        Next
                    Next
                Next
                xlworksheet.SaveAs(SaveFileDialogslesrprt.FileName)
                xlworkbook.Close()
                xlapp.Quit()
                releaseObjectmed(xlapp)
                releaseObjectmed(xlworkbook)
                releaseObjectmed(xlworksheet)
                MsgBox("Successfully saved" & vbCrLf & "File saved at:" & SaveFileDialogslesrprt.FileName, MsgBoxStyle.Information, "Informatiuon")
                btnexporttoexcelsales.Text = "Export to Excel"
                btnexporttoexcelsales.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save", "Error Message - Supermarket Desktop Appln", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Private Sub releaseObjectmed(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
        Finally
            GC.Collect()
        End Try
    End Sub
End Class