Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data.SqlClient.SqlDataReader
Public Class Main_Form
    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim cmd As SqlCommand
        'Dim GlobalUserRole As String
        'Dim GlobalUserID As String
        Dim currentDate As DateTime = DateTime.Today
        Dim dtime As DateTime = currentDate.ToString("ddd, dd MMMM yyy")
        If lbltime.Visible = True Then
            'lbldatedmy.Text = dtime
            myTimer.Start()
        Else
            myTimer.Stop()
        End If
    End Sub
    Private Function mytime(ByVal value As Integer) As String
        Return value.ToString().PadLeft(2, "0")
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles myTimer.Tick
        Dim tm As String = ""
        tm &= mytime(DateTime.Now.Hour)
        tm &= ":" & mytime(DateTime.Now.Minute)
        tm &= ":" & mytime(DateTime.Now.Second)
        lbltime.Text = tm
        ' lbltime.Text = tm
    End Sub
    Private Sub AddCosmoticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCosmoticsToolStripMenuItem.Click
        frmAddCosmeticsandothersstock.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        frmSales.Show()
    End Sub
    Private Sub CashierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierToolStripMenuItem.Click
        frmCashier.Show()
    End Sub

    Private Sub ReToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReToolStripMenuItem.Click
        frmResetEmppassword.Show()

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub
#Region "TOOLS"
    Private Sub NotePadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotePadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("TaskMgr.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MsExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsExcelToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("excel.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MicrosoftWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftWordToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("winword.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Product Name: Supermarket Management System" & vbNewLine & vbNewLine & "Version: 1.0" & vbNewLine & vbNewLine & "Copyright" & vbNewLine & vbNewLine & "Developer team" & vbNewLine & vbNewLine & "Description: This Supermarket Management System is a desktop application software which is capable of managing Stocks’ and sales. The user inteface is simple and clean in order to achieve maximum efficiency")
    End Sub
    Private Sub CosmeticToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CosmeticToolStripMenuItem.Click
        frmAddCosmeticsandothersstock.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        frmReportStock.Show()
    End Sub
End Class
