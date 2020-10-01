Imports System.Data.SqlClient
Public Class FrmMandateSummary

    Private Sub ACFrmMandateSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppHeader1.lblForm.Text = "Mandate Summary"


        dtpStartDate.Text = CDate("01-Jan-" + Str(Year(Now)))
        dtpEndDate.Text = CDate("31-Dec-" + Str(Year(Now)))

        ' listOfMandates()

    End Sub

    Private Sub ACFrmMandateSummary_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub lvList_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvList.ColumnClick
        On Error GoTo handler
        On Error Resume Next
        Dim lvwColumnSorter As ListViewSorter
        lvwColumnSorter = New ListViewSorter()
        lvList.ListViewItemSorter = lvwColumnSorter
        lvwColumnSorter.Order = 1
        lvwColumnSorter.SortColumn = e.Column
        lvList.Sort()
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Sub listOfMandates()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        lvList.Items.Clear()
        ' cmSQL.CommandText = "SELECT DISTINCT Chequeno FROM AC_PaymentVoucher WHERE Authorised = 0 AND NOT(AC_PaymentVoucher.Chequeno IS NULL) OR AC_PaymentVoucher.Chequeno <> ''"
        'cmSQL.CommandText = "SELECT DISTINCT MandateNo AS Chequeno FROM AC_Mandate WHERE [Date]>='" & dtpStartDate.Text & "' AND [Date]<='" & dtpEndDate.Text & "'"
        cmSQL.CommandText = "SELECT MandateNo, COUNT(Sn) AS NoOfPayments, SUM(Amount) AS TheAmount, MAX(Currency) AS TheCurrency,MAX([PayValueDate]) AS TheDate,Authorised FROM Payment WHERE [PayValueDate]>='" & dtpStartDate.Text & "' AND [PayValueDate]<='" & dtpEndDate.Text & "' GROUP BY [PayValueDate],MandateNo,Authorised ORDER BY [PayValueDate]"
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()

        Dim initialText As String = ""
        Dim LvItems As New ListViewItem(initialText)
        drSQL = cmSQL.ExecuteReader()
        Dim j As Integer = 0
        Do While drSQL.Read
            initialText = drSQL.Item("MandateNo")
            LvItems = New ListViewItem(initialText)
            LvItems.SubItems.Add(Format(drSQL.Item("TheDate"), "dd-MMM-yyyy"))
            LvItems.SubItems.Add(drSQL.Item("NoOfPayments"))
            LvItems.SubItems.Add(Format(drSQL.Item("TheAmount"), "standard"))
            LvItems.SubItems.Add(ChkNull(drSQL.Item("TheCurrency")))
            LvItems.SubItems.Add(drSQL.Item("Authorised"))
            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
    Private Sub cmdNewMandate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewMandate.Click
        ' If GetUserAccessDetails("Mandate") = False Then Exit Sub
          Dim ChildForm As New FrmPayment
        ChildForm.cboMandateNo.Text = ""
        ChildForm.MandateNo = ""
        'ChildForm.MdiParent = FrmStart
        ChildForm.ShowDialog()
        listOfMandates()
    End Sub

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        Dim SLV As ListView.SelectedListViewItemCollection = lvList.SelectedItems
        Dim item As ListViewItem
        For Each item In SLV
            Dim ChildForm As New FrmPayment
            ChildForm.cboMandateNo.Text = item.Text
            ChildForm.MandateNo = item.Text
            'ChildForm.MdiParent = FrmStart
            If item.SubItems(5).Text = True Then
                ChildForm.cmdSave.Enabled = False
            Else
                ChildForm.cmdSave.Enabled = True
            End If

            ChildForm.ShowDialog()
            listOfMandates()
        Next
    End Sub
    Private Sub dtpStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartDate.ValueChanged
        listOfMandates()
    End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged
        listOfMandates()
    End Sub
    Private Sub mnuAuthoriseMandate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAuthoriseMandate.Click
        On Error GoTo handler
        If GetUserAccessDetails("Authorise Mandate", True) = False Then Exit Sub
            If lvList.SelectedItems(0).SubItems(5).Text = False Then
                Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
                Dim cmSQL As SqlCommand = cnSQL.CreateCommand

                cmSQL.CommandText = "UPDATE Payment SET Authorised=1,AuthorisedBy='" & sysUserName & "' WHERE MandateNo='" & lvList.SelectedItems(0).Text & "'"
                cmSQL.CommandType = CommandType.Text
                cnSQL.Open()

                cmSQL.ExecuteNonQuery()
                cmSQL.Dispose()

                cnSQL.Close()
                cnSQL.Dispose()

                listOfMandates()

            End If
       
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub mnuUnauthoriseMandate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUnauthoriseMandate.Click
        On Error GoTo handler
        If GetUserAccessDetails("Authorise Mandate", True) = False Then Exit Sub

        If lvList.SelectedItems(0).SubItems(5).Text = True Then
            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand

            cmSQL.CommandText = "UPDATE Payment SET Authorised=0,AuthorisedBy='' WHERE MandateNo='" & lvList.SelectedItems(0).Text & "'"
            cmSQL.CommandType = CommandType.Text
            cnSQL.Open()

            cmSQL.ExecuteNonQuery()
            cmSQL.Dispose()

            cnSQL.Close()
            cnSQL.Dispose()

            listOfMandates()

        End If
        
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub mnuVOIDMandateTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVOIDMandateTransaction.Click
        If GetUserAccessDetails("Void Payment", True) = False Then Exit Sub
        If lvList.SelectedItems(0).SubItems(5).Text = False Then
            Dim ChildForm As New FrmVoidPayment
            ChildForm.cboMandateNo.Text = lvList.SelectedItems(0).Text
            ChildForm.MandateNo = lvList.SelectedItems(0).Text
            ChildForm.cmdSave.Enabled = True
            ChildForm.ShowDialog()
        Else
            MsgBox("Access Denied!! Mandate Authorised", vbInformation)
        End If
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim ChildForm As New FrmAdvSearch
        ChildForm.ShowDialog()
    End Sub

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub

    Private Sub mnuDeleteMandate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteMandate.Click
        On Error GoTo handler
        If GetUserAccessDetails("Authorise Mandate", True) = False Then Exit Sub
        If lvList.SelectedItems(0).SubItems(5).Text = False Then
            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand

            If MsgBox("The Mandate would be Deleted...Continue (y/n)?" + Chr(13) + Chr(10) + "If you choose to Continue, the mandate cannot be recovered", vbYesNo + vbCritical, strApptitle) = vbNo Then Exit Sub

            cmSQL.CommandText = "DELETE FROM Payment WHERE Authorised<>1 AND MandateNo='" & lvList.SelectedItems(0).Text & "'"
            cmSQL.CommandType = CommandType.Text

            cnSQL.Open()

            cmSQL.ExecuteNonQuery()
            cmSQL.Dispose()

            cnSQL.Close()
            cnSQL.Dispose()

            listOfMandates()
        Else
            MsgBox("Mandate already authorised....it cannot be authorised", vbInformation, strApptitle)
        End If

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub mnuEXPORTMandate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEXPORTMandate.Click
        FrmPayment.Export2Excel(lvList.SelectedItems(0).Text)
    End Sub
End Class