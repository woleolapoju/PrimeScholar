Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class FrmHistory
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Public RefNo As Integer = 0
    Public Source As String
    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppHeader1.lblForm.Text = "History"
        If RefNo = 0 Then Exit Sub

        Me.DbGrid.DataSource = bindingSource1
        DbGrid.AutoGenerateColumns = False
        If Source = "School" Then GetData("SELECT PayValueDate, Name, BankName, BankAcctNo, Currency, Amount, PayDetails1, PayDetails2, MandateNo, Source FROM Ledger WHERE Sn=" & RefNo & " AND Source='School'")
        If Source = "Student" Then GetData("SELECT PayValueDate, Name, BankName, BankAcctNo, Currency, Amount, PayDetails1, PayDetails2, MandateNo, Source FROM Ledger WHERE Sn=" & RefNo & " AND Source='Student'")
        If Source = "Staff" Then GetData("SELECT PayValueDate, Name, BankName, BankAcctNo, Currency, Amount, PayDetails1, PayDetails2, MandateNo, Source FROM Ledger WHERE Sn=" & RefNo & " AND Source='Staff'")
        If Source = "StakeHolders" Then GetData("SELECT PayValueDate, Name, BankName, BankAcctNo, Currency, Amount, PayDetails1, PayDetails2, MandateNo, Source FROM Ledger WHERE Sn=" & RefNo & " AND Source='StakeHolders'")
        applyGridTheme(DbGrid)

    End Sub
    Private Sub GetData(ByVal selectCommand As String)

        Try

            dataAdapter = New SqlDataAdapter(selectCommand, strConnect)
            Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataAdapter.Fill(table)
            Me.bindingSource1.DataSource = table
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Information, strApptitle)
        End Try

    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub lnkPrintLedger_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPrintLedger.LinkClicked

        Dim RptFilename As ReportDocument = New ReportDocument

        RptFilename = New Ledger
       
        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Ledger"
        ChildForm.RptDestination = "Screen"
        ChildForm.myReportDocument = RptFilename

        ChildForm.SelFormula = " {RptLedger.Source}='" & Source & "' AND {Rptledger.Sn}=" & tRefNo.Text
       

        ChildForm.ShowDialog()


    End Sub
End Class