Imports System.Data.SqlClient
Imports System.Linq
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelautoFormat = Microsoft.Office.Interop.Excel.xlRangeAutoformat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Public Class frmAddCosmeticsandothersstock
    Dim index As Integer
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = Supermarketdb; Integrated Security = true")
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                'ErrorProvideraddcos.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
#Region "FORM load"
    Private Sub frmAddCosmeticsandothersstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterDta("")
    End Sub
#End Region
#Region "VIEW AND EDIT Cosmetic DETAIL"
    Public Sub FilterDta(valToSearch As String)
        Try
            Dim SearchQery As String = "select * from stocktbl where CONCAT(id,genericname,brandname) like '%" & valToSearch & "%' and status = 1"
            Dim coand As New SqlCommand(SearchQery, cn)
            Dim dat As New SqlDataAdapter(coand)
            Dim tble As New DataTable()
            dat.Fill(tble)
            DataGridViewStockdata.DataSource = tble
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub txtboxsearchstock_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxsearchstock.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnstocksearch_Click(sender, e)
        End If
    End Sub
    Private Sub btnstocksearch_Click(sender As Object, e As EventArgs) Handles btnstocksearch.Click
        FilterDta(txtboxsearchstock.Text)
    End Sub
    Private Sub txtboxsearchstock_TextChanged(sender As Object, e As EventArgs) Handles txtboxsearchstock.TextChanged
        FilterDta(txtboxsearchstock.Text)
    End Sub
#End Region
#Region "ADD stock details"
    Private Sub btnaddnewstock_Click(sender As Object, e As EventArgs) Handles btnaddnewstock.Click
        'check validity
        If vld(txtboxsernostock) = False Then
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            'check duplication
            conn.Open()
            Dim cmdep As SqlCommand = New SqlCommand("select id from stocktbl where id=@cosid", conn)
            cmdep.Parameters.AddWithValue("@cosid", txtboxsernostock.Text)
            Dim rdrp As SqlDataReader = cmdep.ExecuteReader()
            If rdrp.HasRows Then
                MsgBox("Stock serial number already exist please try again!", MsgBoxStyle.Critical)
            Else
                'insert detail to db
                Dim regcoby As String = Main_Form.lblusername.Text 'userName.ToString()
                Dim statmsto As Integer = 1
                Dim insertQer As String = "insert into stocktbl(id, genericname,brandname,importedid,quantity, batchno, price,
manufactureddate,expireddate,remark,stockregisteredby,status) 
values('" & txtboxsernostock.Text & "','" & txtboxgnamestock.Text & "','" & txtboxbnamestock.Text & "','" & txtboximportedidstock.Text & "','" & txtboxquanstock.Text & "','" & txtboxbatchstock.Text & "','" & txtboxpricestock.Text & "','" & DateTimePickermanfdatestock.Value.ToShortDateString() & "','" & DateTimePickerexpidatestock.Value.ToShortDateString() & "','" & txtboxremarkstock.Text & "','" & regcoby & "','" & statmsto & "')"
                InsertUpdateDelete(insertQer)
                MessageBox.Show("Data successfully added", "Data Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'clear controls/textbox
                txtboxsernostock.Clear()
                txtboxgnamestock.Clear()
                txtboxbnamestock.Clear()
                txtboximportedidstock.Clear()
                txtboxbatchstock.Clear()
                txtboxquanstock.Clear()
                txtboxpricestock.Clear()
                'DateTimePickermanfdatestock.
                'DateTimePickerexpidatestock
                txtboxremarkstock.Clear()
                txtboxsernostock.Focus()
            End If
        End If
        conn.Close()
    End Sub
#End Region
#Region "EDIT stock details"
    Private Sub btneditstock_Click(sender As Object, e As EventArgs) Handles btneditstock.Click
        If vld(txtboxsernostock, txtboxgnamestock, txtboxbnamestock, txtboximportedidstock, txtboxbatchstock, txtboxquanstock, txtboxpricestock, txtboxremarkstock) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            conn.Open()
            Dim cmdep As SqlCommand = New SqlCommand("select id from stocktbl where id=@cid", conn)
            cmdep.Parameters.AddWithValue("@cid", txtboxsernostock.Text)
            Dim rdrp As SqlDataReader = cmdep.ExecuteReader()
            If rdrp.HasRows Then
                'id, genericname,brandname,importedid,quantity, batchno, price, manufactureddate,expireddate,remark,stockregisteredby,status
                Dim updtequery As String = "update stocktbl set genericname='" & txtboxgnamestock.Text & "', brandname='" & txtboxbnamestock.Text & "',importedid='" & txtboximportedidstock.Text & "', quantity='" & txtboxquanstock.Text & "', batchno='" & txtboxbatchstock.Text & "', price='" & txtboxpricestock.Text & "', manufactureddate='" & DateTimePickermanfdatestock.Value.ToShortDateString() & "', expireddate='" & DateTimePickerexpidatestock.Value.ToShortDateString() & "', remark='" & txtboxremarkstock.Text & "' where id='" & txtboxsernostock.Text & "'"
                InsertUpdateDelete(updtequery)
                MessageBox.Show("Successfully edited !", "Data updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtboxsernostock.Clear()
                txtboxgnamestock.Clear()
                txtboxbnamestock.Clear()
                txtboximportedidstock.Clear()
                txtboxbatchstock.Clear()
                txtboxquanstock.Clear()
                txtboxpricestock.Clear()
                'DateTimePickermanfdatestock.
                'DateTimePickerexpidatestock
                txtboxremarkstock.Clear()
                txtboxsernostock.Focus()
            Else
                MsgBox("No such stock serial number exist please try again!", MsgBoxStyle.Critical)
            End If
        End If
        conn.Close()
    End Sub
    Private Sub DataGridViewStockdata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewStockdata.CellContentClick
        Try
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewStockdata.Rows(index)
            txtboxsernostock.Text = selectedRow.Cells(0).Value.ToString
            txtboxgnamestock.Text = selectedRow.Cells(1).Value.ToString
            txtboxbnamestock.Text = selectedRow.Cells(2).Value.ToString
            txtboximportedidstock.Text = selectedRow.Cells(3).Value.ToString
            txtboxquanstock.Text = selectedRow.Cells(4).Value.ToString
            txtboxbatchstock.Text = selectedRow.Cells(5).Value.ToString
            txtboxpricestock.Text = selectedRow.Cells(6).Value.ToString
            DateTimePickermanfdatestock.Text = selectedRow.Cells(7).Value.ToString
            DateTimePickerexpidatestock.Text = selectedRow.Cells(8).Value.ToString
            txtboxremarkstock.Text = selectedRow.Cells(9).Value.ToString
        Catch ex As Exception
            MsgBox("Ctrl + C to copy stock details from database", MsgBoxStyle.Information)
        End Try
    End Sub
#End Region
#Region "DELETE stock details"
    Private Sub btndeletestock_Click(sender As Object, e As EventArgs) Handles btndeletestock.Click
        If vld(txtboxsernostock) = False Then
            'Exit Sub
            MsgBox("Please select stock form the datagriview below to delete", MsgBoxStyle.Critical)
        ElseIf IsConfirm("Do you want to delete this stock from database?") Then
            Dim dltequery As String = "delete from stocktbl where id='" & txtboxsernostock.Text & "'"
            If InsertUpdateDelete(dltequery) Then
                MessageBox.Show("Successfully deleted !", "Data deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Successfully updated!")
                txtboxsernostock.Clear()
                txtboxgnamestock.Clear()
                txtboxbnamestock.Clear()
                txtboximportedidstock.Clear()
                txtboxbatchstock.Clear()
                txtboxquanstock.Clear()
                txtboxpricestock.Clear()
                'DateTimePickermanfdatestock
                'DateTimePickerexpidatestock
                txtboxremarkstock.Clear()
                txtboxsernostock.Focus()
            End If
        End If
    End Sub
#End Region
#Region "CLEAR frm stock"
    Private Sub btnclearstock_Click(sender As Object, e As EventArgs) Handles btnclearstock.Click
        txtboxsernostock.Clear()
        txtboxgnamestock.Clear()
        txtboxbnamestock.Clear()
        txtboximportedidstock.Clear()
        txtboxbatchstock.Clear()
        txtboxquanstock.Clear()
        txtboxpricestock.Clear()
        'DateTimePickermanfdatestock.
        'DateTimePickerexpidatestock
        txtboxremarkstock.Clear()
        txtboxsernostock.Focus()
    End Sub
#End Region
#Region "Import to ms-excel stock details"
    Private Sub btnimporttoexcelstock_Click(sender As Object, e As EventArgs) Handles btnexporttoexcel.Click
        Try
            btnexporttoexcel.Text = "Please wait,..."
            btnexporttoexcel.Enabled = False
            SaveFileDialogcostoc.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If SaveFileDialogcostoc.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlapp As Microsoft.Office.Interop.Excel.Application
                Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misval As Object = System.Reflection.Missing.Value
                Dim x As Integer
                Dim y As Integer
                xlapp = New Microsoft.Office.Interop.Excel.Application
                xlworkbook = xlapp.Workbooks.Add(misval)
                xlworksheet = xlworkbook.Sheets("Sheet1")
                For x = 0 To DataGridViewStockdata.RowCount - 2
                    For y = 0 To DataGridViewStockdata.ColumnCount - 1
                        For z As Integer = 1 To DataGridViewStockdata.Columns.Count
                            xlworksheet.Cells(1, z) = DataGridViewStockdata.Columns(z - 1).HeaderText
                            xlworksheet.Cells(x + 2, y + 1) = DataGridViewStockdata(y, x).Value.ToString()
                        Next
                    Next
                Next
                xlworksheet.SaveAs(SaveFileDialogcostoc.FileName)
                xlworkbook.Close()
                xlapp.Quit()
                releaseObjctstock(xlapp)
                releaseObjctstock(xlworkbook)
                releaseObjctstock(xlworksheet)
                MsgBox("Successfully Saved" & vbCrLf & "File saved at:" & SaveFileDialogcostoc.FileName, MsgBoxStyle.Information, "Information")
                btnexporttoexcel.Text = "Import to Excel"
                btnexporttoexcel.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub
    Private Sub releaseObjctstock(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub txtboxquanstock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxquanstock.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9")) Then
            MessageBox.Show("Invalid input. Numbers only allowed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub
    Private Sub btnrefreshstock_Click(sender As Object, e As EventArgs) Handles btnrefreshstock.Click
        Me.Controls.Clear()
        InitializeComponent()
        frmAddCosmeticsandothersstock_Load(e, e)
        Refresh()
    End Sub

    Private Sub txtboxpricestock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxpricestock.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        'ToolTipvalida.Show("Only numeric input required", sender, 5000)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9")) Then ' Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid input numbers only allowed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txtboxquanstock.Clear()
            e.Handled = True
        End If
    End Sub
#End Region
End Class