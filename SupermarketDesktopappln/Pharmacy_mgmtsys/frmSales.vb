Imports System.Data.SqlClient
Public Class frmSales
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = Supermarketdb; Integrated Security = true")
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                'ErrorProviderSales.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
#Region "when FORM Load"
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FiltrDa("")
        '----------------------------- view current saled stock ---------------------------------
        Dim saller As String = Main_Form.lblusername.Text
        Dim tdysles As DateTime = DateTime.Today
        Dim SearchQrysles As String = $"select * from salestbl where salesdate = '" & tdysles & "' and status = 'paid' and salesby = '" & saller & "' "
        Dim c1sles As New SqlCommand(SearchQrysles, cn)
        Dim d1sles = New SqlDataAdapter(c1sles)
        Dim t1sles As New DataTable()
        d1sles.Fill(t1sles)
        DataGridViewmedsale.DataSource = t1sles
        '-----------------------------------------------------------------------------------------
        '-------------------------------------for auto cusid-----------------------------------------
        'Dim GetCode As String = "0"
        Dim GetCode As Integer = 0
        Dim command As New SqlCommand()
        command = New SqlCommand()
        command.Connection = conn
        command.CommandText = "SELECT TOP(1) * FROM salestbl ORDER BY customerid DESC"
        Try
            conn.Open()
            Dim reader As SqlDataReader
            reader = command.ExecuteReader(CommandBehavior.SingleRow)
            If (reader.HasRows = True) Then
                While reader.Read()
                    GetCode = (reader.GetInt32(reader.GetOrdinal("customerid")))
                End While
            End If
            reader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        If (GetCode = 0) Then
            txtboxcusid.Text = "1"
        ElseIf (GetCode <> 0) Then
            Dim OldNum As Integer = GetCode
            txtboxcusid.Text = OldNum + 1
        End If
        conn.Close()
        '------------------------------------------- ------------------------------------------------------------
        '-----------------Fill Auto Complete for medicine stockname ------------------------------
        'Try
        '    'Dim cmdtel As 
        '    Dim command1 As New SqlCommand("select genericname from medicinestocktbl", conn)
        '    'Dim datel As 
        '    Dim daa As New SqlClient.SqlDataAdapter(command1)
        '    Dim dstel As DataSet = New DataSet
        '    daa.Fill(dstel, "medicinestocktbl")
        '    Dim coltel As New AutoCompleteStringCollection
        '    For i = 0 To dstel.Tables(0).Rows.Count - 1
        '        coltel.Add(dstel.Tables(0).Rows(i)(0).ToString)
        '    Next
        '    txtboxselectstock.AutoCompleteSource = AutoCompleteSource.CustomSource
        '    txtboxselectstock.AutoCompleteCustomSource = coltel
        '    txtboxselectstock.AutoCompleteMode = AutoCompleteMode.Suggest
        'Catch ex As Exception
        '    MsgBox("SQL Conifiguration error", MsgBoxStyle.Information)
        'End Try
        '------------------------------------------------------------------------------------------
        '-----------------Fill Auto Complete for cosmetic stockname ------------------------------
        Try
            'Dim cmdtel As 
            Dim commandcos As New SqlCommand("select genericname from stocktbl", conn)
            'Dim datel As 
            Dim dacos As New SqlClient.SqlDataAdapter(commandcos)
            Dim dscos As DataSet = New DataSet
            dacos.Fill(dscos, "stocktbl")
            Dim colcos As New AutoCompleteStringCollection
            For i = 0 To dscos.Tables(0).Rows.Count - 1
                colcos.Add(dscos.Tables(0).Rows(i)(0).ToString)
            Next
            txtboxselectstock.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtboxselectstock.AutoCompleteCustomSource = colcos
            txtboxselectstock.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration error", MsgBoxStyle.Information)
        End Try
        '------------------------------------------------------------------------------------------
    End Sub
    'Public Sub FiltrDa(valToSearch As String)
    '    Try
    '        Dim tsalday As DateTime = DateTime.Today
    '        Dim SearchQery As String = "select * from salestbl where salesdate = '" & tsalday & "' and status = 'notpaid'"
    '        Dim cnd As New SqlCommand(SearchQery, cn)
    '        Dim dt As New SqlDataAdapter(cnd)
    '        Dim tblmed As New DataTable()
    '        dt.Fill(tblmed)
    '        DataGridViewmedsale.DataSource = tblmed
    '    Catch ex As Exception
    '        MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
    '    End Try
    'End Sub
#End Region
#Region "Select stock"
    Private Sub btnselectstock_Click(sender As Object, e As EventArgs) Handles btnselectstock.Click
        'Dim searchCommand As New SqlCommand("select * from medicinestocktbl where genericname=@StockID", conn)
        'searchCommand.Parameters.Add("@StockID", SqlDbType.VarChar).Value = txtboxselectstock.Text
        'Dim adapter As New SqlDataAdapter(searchCommand)
        'Dim table As New DataTable()
        'adapter.Fill(table)
        'If table.Rows.Count > 0 Then
        '    txtboxstockgeneric.Text = table(0)(1)
        '    txtboxstockbrand.Text = table(0)(2)
        '    txtboxstockprice.Text = table(0)(6)
        '    txtboxmedid.Text = table(0)(0)
        '    lbltotalavailablestock.Text = table(0)(4)
        '    txtboxstockid.Clear()
        'Else
        '    txtboxstockgeneric.Text = ""
        '    txtboxstockbrand.Text = ""
        '    txtboxstockprice.Text = ""
        '    txtboxmedid.Text = ""
        '    lbltotalavailablestock.Text = ""
        '    MsgBox("No data found", MsgBoxStyle.Information)
        'End If
        Dim searchCommandcos As New SqlCommand("select * from stocktbl where genericname=@CosStockID", conn)
        searchCommandcos.Parameters.Add("@CosStockID", SqlDbType.VarChar).Value = txtboxselectstock.Text
        Dim adaptr As New SqlDataAdapter(searchCommandcos)
        Dim tabl As New DataTable()
        adaptr.Fill(tabl)
        If tabl.Rows.Count > 0 Then
            txtboxstockgeneric.Text = tabl(0)(1)
            txtboxstockbrand.Text = tabl(0)(2)
            txtboxstockprice.Text = tabl(0)(6)
            txtboxstockid.Text = tabl(0)(0)
            lbltotalavailablestock.Text = tabl(0)(4)
            'txtboxmedid.Clear()
        Else
            txtboxstockgeneric.Text = ""
            txtboxstockbrand.Text = ""
            txtboxstockprice.Text = ""
            txtboxstockid.Text = ""
            lbltotalavailablestock.Text = ""
            MsgBox("No data found", MsgBoxStyle.Information)
        End If
    End Sub
#End Region
    Private Sub txtboxstockquan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxstockquan.KeyPress
        'If Not IsNumeric(e.KeyChar) Then
        'ToolTipvalida.Show("Only numeric input required", sender, 5000)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9")) Then ' Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid input numbers only allowed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'e.KeyChar = Nothing
            e.Handled = True
        End If
    End Sub

    Private Sub btnrefreshsale_Click(sender As Object, e As EventArgs) Handles btnrefreshsale.Click
        Me.Controls.Clear()
        InitializeComponent()
        frmSales_Load(e, e)
        Refresh()
    End Sub
    Private Sub btnsale_Click(sender As Object, e As EventArgs) Handles btnsale.Click
        If vld(txtboxselectstock, txtboxcusid, txtboxstockgeneric, txtboxstockbrand, txtboxstockprice, txtboxstockquan, txtboxcusname) = False Then
            'Exit Sub
            'DateTimePickermanufmed
            'DateTimePickerexpimed
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            'conn.Open()
            'Dim tdy As DateTime = DateTime.Today
            'Dim cmdep As SqlCommand = New SqlCommand("select stockname,status,customername from salestbl where stockname=@uid and salesdate = '" & tdy & "'and status='notpaid'", conn)
            'cmdep.Parameters.AddWithValue("@uid", txtboxselectstock.Text)
            'cmdep.Parameters.AddWithValue("@custname", txtboxcusname.Text)
            'Dim rdrp As SqlDataReader = cmdep.ExecuteReader()
            'If rdrp.HasRows Then
            '    MsgBox("Stock already added please try again!", MsgBoxStyle.Critical)
            'Else
            'rdrp.Close()
            Dim salesby As String = Main_Form.lblusername.Text 'userName.ToString()
                Dim statmed As Integer = 1
                Dim tday As DateTime = DateTime.Today
                Dim stat As String = "notpaid"
                '15% sales tax
                Dim totalprice As Double = txtboxstockquan.Text * txtboxstockprice.Text
                Dim insertQery As String = "insert into salestbl(stockname,totalquantity,totalprice,customerid,customername,salesby,salesdate,status) values('" & txtboxselectstock.Text & "','" & txtboxstockquan.Text & "','" & totalprice & "', '" & txtboxcusid.Text & "','" & txtboxcusname.Text & "','" & salesby & "','" & tday & "','" & stat & "')"
                If InsertUpdateDelete(insertQery) Then
                    Dim tquan As Integer = txtboxstockquan.Text
                'Dim updatequerymed As String = "update medicinestocktbl set quantity = (quantity) - ('" & tquan & "') where medicineid='" & txtboxmedid.Text & "' and quantity != 0"
                Dim updatequerycos As String = "update stocktbl set quantity = (quantity) - ('" & tquan & "') where id='" & txtboxstockid.Text & "' and quantity != 0"
                'Dim tyagn As DateTime = DateTime.Today '-----------------
                'Dim totalpriceagn As Double = txtboxstockquan.Text * txtboxstockprice.Text '----------------
                ' Dim insertQeryagn As String = "update salestbl set stockname = 'stockname'+','+'" & txtboxselectstock.Text & "',totalquantity = totalquantity + '" & txtboxstockquan.Text & "',totalprice = totalprice + '" & totalpriceagn & "'  where customerid='" & txtboxcusid.Text & "' and salesdate = '" & tyagn & "' and status='notpaid' "
                'InsertUpdateDelete(insertQeryagn)
                'InsertUpdateDelete(updatequerymed)
                InsertUpdateDelete(updatequerycos)
                    MessageBox.Show("Stock sales successfully done", "Stock Saled - Supermarket Desktop Appln", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtboxselectstock.Clear()
                    'txtboxcusid.Clear() 
                    txtboxstockid.Clear()
                'txtboxmedid.Clear()
                txtboxstockgeneric.Clear()
                    txtboxstockbrand.Clear()
                    txtboxstockprice.Clear()
                    txtboxstockquan.Clear()
                    txtboxcusname.Clear()
                    txtboxselectstock.Focus()
                End If
            End If
        'End If
        conn.Close()
    End Sub
End Class