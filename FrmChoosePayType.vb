Imports System.Data.SqlClient
Public Class FrmChoosePayType
    Dim SelectedPayTypes As String
    Public frmParent As Object
    Private Sub FrmChoosePayType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadLvList()
        AppHeader1.lblForm.Text = "Choose Payment Type"

    End Sub

    Public Sub LoadLvList()
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
       
        lvList.Items.Clear()
        cmSQL.CommandText = "select Sn, PaymentType from PaymentType ORDER BY SN"
                cmSQL.CommandType = CommandType.Text
       
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Long = 0
        Dim initialText As String
        Do While drSQL.Read
            j += 1
         
                initialText = drSQL.Item("PaymentType").ToString
            Dim LvItems As New ListViewItem(initialText)

            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        drSQL.Close()
        cmSQL.Connection.Close()
        cmSQL.Dispose()

        cnSQL.Close()
        cnSQL.Dispose()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        SelectedPayTypes = ""
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        SelectedPayTypes = ""
        Dim i As Integer
        For i = 0 To lvList.Items.Count - 1
            If lvList.Items(i).Checked Then
                SelectedPayTypes = SelectedPayTypes + IIf(SelectedPayTypes <> "", " ", "") + lvList.Items(i).Text
            End If
        Next
        frmParent.ReturnPayTypes = SelectedPayTypes
        Me.Close()
    End Sub

    Private Sub mnuPayType_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles mnuPayType.LinkClicked
        Dim ChildForm As New FrmPaymentType
        ChildForm.ShowDialog()
        LoadLvList()
    End Sub
End Class