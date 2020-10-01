Imports System.Data.SqlClient
Public Class FrmMandateRpt
    Public TheMandateNo As String
    Public frmParent As Object
    Dim Nominator As String
    Dim Denominator As String
    Private Sub FrmMandateRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppHeader1.lblForm.Text = UCase(TheMandateNo) + ": Mandate Print Details"

        If CustomerRefPrefix = "" Then
            tMandateNo.Text = "PTDF/FIN/CBN/" + TheMandateNo ' just for PTDF
        Else
            tMandateNo.Text = TheMandateNo
        End If

        GetRefNoAndTitle()

        FillData()

        tSignatory1.Text = Signatory1
        tSignatory2.Text = Signatory2
        tSignatory3.Text = Signatory3
        tSignatory1Design.Text = SignatoryDesig1
        tSignatory2Design.Text = SignatoryDesig2
        tSignatory3Design.Text = SignatoryDesig3

        tPreparedBy.Text = PreparedBy

        cboLayout.SelectedIndex = 0

    End Sub

    Private Sub FillData()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "SELECT ISNULL(SUM(Amount),0) AS TheAmount, MAX(Currency) AS TheCurrency FROM Payment WHERE MandateNo='" & TheMandateNo & "'"

        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            tAmount.Text = Format(drSQL.Item("TheAmount"), "standard")
            tCurrency.Text = ChkNull(drSQL.Item("TheCurrency"))
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        GetCurrency(tCurrency.Text)
        'Select Case tCurrency.Text
        '   Case Is = "GBP"
        tAmtInWords.Text = Towords(tAmount.Text, Nominator, Denominator) + " Only"
        '  Case Is = "EUR"
        'tAmtInWords.Text = Towords(tAmount.Text, "Euro", "Cents")
        ' Case Is = "USD"
        'tAmtInWords.Text = Towords(tAmount.Text, "US Dollar", "Cents")
        ' Case Else
        'tAmtInWords.Text = Towords(tAmount.Text, "Naira", "Kobo")
        'End Select

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub GetCurrency(ByVal Currency As String)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Nominator = ""
        Denominator = ""
        cmSQL.CommandText = "SELECT Currency, Symbol, DebitAcctNo, Nominator, Denominator FROM CurrencyType WHERE Currency='" & Currency & "'"

        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            Nominator = drSQL.Item("Nominator")
            Denominator = drSQL.Item("Denominator")
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        frmParent.dTitle = tMandateTitle.Text
        frmParent.dAmtInWords = tAmtInWords.Text
        frmParent.Signatory1 = tSignatory1.Text
        frmParent.Signatory2 = tSignatory2.Text
        frmParent.Signatory3 = tSignatory3.Text
        frmParent.Signatory1Design = tSignatory1Design.Text
        frmParent.Signatory2Design = tSignatory2Design.Text
        frmParent.Signatory3Design = tSignatory3Design.Text
        frmParent.PreparedBy = tPreparedBy.Text
        frmParent.FullMandateNo = tMandateNo.Text
        frmParent.clayout = cboLayout.SelectedIndex + 1 '.Text

        If Signatory1 <> tSignatory1.Text Or Signatory2 <> tSignatory2.Text Or Signatory3 <> tSignatory3.Text Or SignatoryDesig1 <> tSignatory1Design.Text Or SignatoryDesig2 <> tSignatory2Design.Text Or SignatoryDesig3 <> tSignatory3Design.Text Or PreparedBy <> tPreparedBy.Text Then
            SaveDefault()
        End If

        SaveRefNoAndTitle()

        Me.Close()
    End Sub
    Sub SaveRefNoAndTitle()
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()
        Dim TheStr As String = "RefNo: " + tMandateNo.Text + ": ," + tMandateTitle.Text

        cmSQL.CommandText = "UPDATE Payment SET Remark = '" & TheStr & "' WHERE MandateNo ='" & TheMandateNo & "' AND (Remark='' OR Remark is Null OR Remark like 'RefNo: %')"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub GetRefNoAndTitle()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim TheRemark As String = ""

        cmSQL.CommandText = "SELECT top 1 Remark FROM Payment WHERE MandateNo ='" & TheMandateNo & "' AND Remark like 'RefNo: %'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then GoTo SkipIt
        If drSQL.Read Then TheRemark = drSQL.Item("Remark")
        If Len(TheRemark) > 0 Then
            tMandateNo.Text = Mid(TheRemark, 8, InStr(TheRemark, ": ,") - 8)
            tMandateTitle.Text = Mid(TheRemark, InStr(TheRemark, ": ,") + 3)
        End If

SkipIt:
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Sub SaveDefault()
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()

        cmSQL.CommandText = "UpdateSysParam4Mandate"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@1stSignatory", tSignatory1.Text)
        cmSQL.Parameters.AddWithValue("@2ndSignatory", tSignatory2.Text)
        cmSQL.Parameters.AddWithValue("@3rdSignatory", tSignatory3.Text)
        cmSQL.Parameters.AddWithValue("@1stSignatoryDesig", tSignatory1Design.Text)
        cmSQL.Parameters.AddWithValue("@2ndSignatoryDesig", tSignatory2Design.Text)
        cmSQL.Parameters.AddWithValue("@3rdSignatoryDesig", tSignatory3Design.Text)
        cmSQL.Parameters.AddWithValue("@PreparedBy", tPreparedBy.Text)

        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        frmParent.FullMandateNo = "SDDDDDDDDDDD_FFFFF@@##"
        Me.Close()
    End Sub

    Private Sub FrmMandateRpt_MenuStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MenuStart
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class