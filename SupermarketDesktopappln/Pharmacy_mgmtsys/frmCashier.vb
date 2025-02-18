Imports System.Data.SqlClient
Public Class frmCashier
    Dim index As Integer
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = Supermarketdb; Integrated Security = true")
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                'ErrorProviderCsh.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub frmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FiltrData("")
    End Sub
    Public Sub FiltrData(valToSearch As String)
        Try
            Dim tsalday As DateTime = DateTime.Today
            Dim SearchQery As String = "select * from salestbl where salesdate = '" & tsalday & "' and status = 'notpaid'"
        Dim coand As New SqlCommand(SearchQery, cn)
            Dim dat As New SqlDataAdapter(coand)
            Dim tbl As New DataTable()
            dat.Fill(tbl)
            DataGridViewCashier.DataSource = tbl
        Catch ex As Exception
            MsgBox("Please enter the keyword to search", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub DataGridViewCashier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCashier.CellContentClick
        Try
            Index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewCashier.Rows(index)
            txtboxsalesid.Text = selectedRow.Cells(0).Value.ToString
            txtboxcustomerid.Text = selectedRow.Cells(4).Value.ToString
            txtboxstockquantity.Text = selectedRow.Cells(2).Value.ToString
            txtboxtotalprice.Text = selectedRow.Cells(3).Value.ToString
            txtboxstocname.Text = selectedRow.Cells(1).Value.ToString
            txtboxcustname.Text = selectedRow.Cells(5).Value.ToString
        Catch ex As Exception
            MsgBox("Ctrl + C to copy sales details from database", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub btnchange_Click(sender As Object, e As EventArgs) Handles btnchange.Click
        Try
            Dim chnge As Double
            chnge = txtboxcashrecieve.Text - txtboxtotalprice.Text
            txtboxcashchange.Text = chnge
        Catch ex As Exception
            MsgBox("Error try again", MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtboxcashrecieve_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxcashrecieve.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnchange_Click(sender, e)
        End If
    End Sub

    'Private Sub txtboxcashrecieve_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxcashrecieve.KeyPress
    '    'If Not IsNumeric(e.KeyChar) Then
    '    'ToolTipvalida.Show("Only numeric input required", sender, 5000)
    '    If Not ((e.KeyChar >= "0" And e.KeyChar <= "9")) Then ' Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
    '        MessageBox.Show("Invalid input numbers only allowed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        'e.KeyChar = Nothing
    '        e.Handled = True
    '    End If
    'End Sub

#Region "Sale Stock"
    Private Sub btnsale_Click(sender As Object, e As EventArgs) Handles btnsale.Click
        If vld(txtboxcustomerid, txtboxstockquantity, txtboxtotalprice, txtboxstocname, txtboxcustname) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        ElseIf IsConfirm("Do you want to sale this stock?") Then
            Dim slby As String = Main_Form.lblusername.Text
            Dim slday As DateTime = DateTime.Today
            Dim stus As String = "paid"
            Dim updatequeryslt As String = "update salestbl set cashier = '" & slby & "',paiddate = '" & slday & "', status = '" & stus & "'where id='" & txtboxsalesid.Text & "'"
            If (InsertUpdateDelete(updatequeryslt)) Then
                MessageBox.Show("Successfully done", "Stock Sales - Supermarket Desktop Appln", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '---------------------------------Set print bill to the rtxtboxprintbill-----------------------------------------------------
                rtxtboxprintbill.AppendText("Supermarket Management System" + vbNewLine)
                rtxtboxprintbill.AppendText("---------------------------------------------------" + vbNewLine + vbNewLine)
                rtxtboxprintbill.AppendText("Customer ID-" + vbTab + txtboxcustomerid.Text + vbNewLine + vbNewLine)
                rtxtboxprintbill.AppendText("Stock-" + vbTab + txtboxstocname.Text + vbNewLine + vbNewLine)
                rtxtboxprintbill.AppendText("Quantity-" + vbTab + txtboxstockquantity.Text + vbNewLine + vbNewLine)
                rtxtboxprintbill.AppendText("Price-" + vbTab + txtboxtotalprice.Text + vbNewLine + vbNewLine)
                rtxtboxprintbill.AppendText("Customer Name-" + vbTab + txtboxcustname.Text + vbNewLine + vbNewLine)
                rtxtboxprintbill.AppendText("---------------------------------------------------" + vbNewLine)
                rtxtboxprintbill.AppendText(" Thank You" + vbNewLine)
                '--------------------------------------------------------------------------------------
                txtboxsalesid.Clear()
                txtboxcustomerid.Clear()
                txtboxstockquantity.Clear()
                txtboxtotalprice.Clear()
                txtboxstocname.Clear()
                txtboxcustname.Clear()
                txtboxcashrecieve.Clear()
                txtboxcashchange.Clear()
                txtboxcashrecieve.Focus()
                'Me.Controls.Clear()
                'InitializeComponent()
                'frmCashier_Load(e, e)
                'Refresh()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtboxsalesid.Clear()
        txtboxcustomerid.Clear()
        txtboxstockquantity.Clear()
        txtboxtotalprice.Clear()
        txtboxstocname.Clear()
        txtboxcustname.Clear()
        txtboxcashrecieve.Clear()
        txtboxcashchange.Clear()
        rtxtboxprintbill.Clear()
        txtboxcashrecieve.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmbill.Show()
    End Sub
    Private Sub btntpricetoday_Click(sender As Object, e As EventArgs) Handles btntpricetoday.Click
        '-------------------------------------------------------------------------
        Try
            conn.Open()
            Dim userNme As String = Main_Form.lblusername.Text.Trim()
            Dim dtch As DateTime = DateTime.Today
            Dim cmdtpr = New SqlCommand("Select SUM(totalprice) as totalprtoday from salestbl WHERE cashier= '" & userNme & "' and paiddate = '" & dtch & "' and status = 'paid'", cn)
            Dim rdtpr = cmdtpr.ExecuteReader()
            If (rdtpr.HasRows) Then
                While (rdtpr.Read())
                    lblpricebyyou.Text = rdtpr("totalprtoday").ToString + " ETB"
                End While
            End If
            'rdtpr.Close()
            'cn.Close()
        Catch ex As Exception
            MsgBox("SQL Conifiguration error please inform system admin", MsgBoxStyle.Information)
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub btnpbill_Click(sender As Object, e As EventArgs) Handles btnpbill.Click
        'Set on PrintPreviewDialogbill properties of ---Document--- to PrintDocumentBill
        PrintPreviewDialogbill.WindowState = FormWindowState.Maximized
        PrintPreviewDialogbill.ShowDialog()
        'rtxtboxprintbill.Clear()
    End Sub

    Private Sub PrintDocumentBill_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentBill.PrintPage
        'PrintDocument for rtxtboxprintbill
        Static fntheadingfont As New Font("Times New Roman", 12, FontStyle.Regular)
        Dim centerpage As New Single
        centerpage = Convert.ToSingle(e.PageBounds.Width - 400 - e.Graphics.MeasureString(rtxtboxprintbill.Text, fntheadingfont).Width / 2)
        e.Graphics.DrawString(rtxtboxprintbill.Text, fntheadingfont, Brushes.Black, centerpage, 200)
    End Sub
#End Region
End Class