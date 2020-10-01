Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmReport
    Dim RptFilename, SelFormula, RptDestination, RptTitle As String
    Dim myReportDocument As ReportDocument
    Dim PaperSize, POrientation As String
    Dim ReportName As String
    Public dTitle As String
    Public dAmtInWords As String
    Public Signatory1 As String
    Public Signatory2 As String
    Public Signatory3 As String
    Public Signatory1Design As String
    Public Signatory2Design As String
    Public Signatory3Design As String
    Public PreparedBy As String
    Public FullMandateNo As String
    Public clayout As Integer

    Private Sub ConfigureCrystalReports()
        On Error GoTo handler
        Dim intCounter As Integer
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
        ConInfo.ConnectionInfo.DatabaseName = AttachName
        ConInfo.ConnectionInfo.ServerName = ServerName
        If IntegratedSecurity Then
            ConInfo.ConnectionInfo.IntegratedSecurity = True
        Else
            ConInfo.ConnectionInfo.UserID = UserID
            ConInfo.ConnectionInfo.Password = Password
        End If

        For intCounter = 0 To myReportDocument.Database.Tables.Count - 1
            myReportDocument.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
        Next

        'Dim connection As IConnectionInfo

        '' Set Database Logon to main report
        'For Each connection In myReportDocument.DataSourceConnections
        '    Select Case connection.ServerName
        '        Case ServerName
        '            connection.SetLogon(UserID, Password)
        '    End Select
        'Next

        '' Set Database Logon to subreport
        'Dim subreport As ReportDocument
        'For Each subreport In myReportDocument.Subreports
        '    For Each connection In subreport.DataSourceConnections
        '        Select Case connection.ServerName
        '            Case ServerName
        '                connection.SetLogon(UserID, Password)
        '        End Select
        '    Next
        'Next


        If RptDestination = "Printer" Then
            ' You can change more print options via PrintOptions property of ReportDocument
            ' myCrystalReportViewer.PrintReport()
            myReportDocument.PrintToPrinter(1, True, 0, 0)
            myReportDocument.Close()
        End If
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub FillStates()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboMandateNo.Items.Clear()
        cboMandateNo.Items.Add("ALL")
        cmSQL.CommandText = "SELECT DISTINCT State FROM StateCamp ORDER BY State"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboMandateNo.Items.Add(drSQL.Item("State").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cboMandateNo.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub MandateNo()
        On Error GoTo handler

        Dim cnSQL1 As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL1 As SqlCommand = cnSQL1.CreateCommand
        Dim drSQL1 As SqlDataReader
        cnSQL1.Open()

        cboMandateNo.Items.Clear()

        cmSQL1.CommandText = "SELECT DISTINCT MandateNo FROM Payment ORDER BY MandateNo"
        cmSQL1.CommandType = CommandType.Text
        drSQL1 = cmSQL1.ExecuteReader()

        Do While drSQL1.Read
            cboMandateNo.Items.Add(drSQL1.Item("MandateNo"))
        Loop

        cmSQL1.Connection.Close()
        cmSQL1.Dispose()
        drSQL1.Close()
        cnSQL1.Close()
        cnSQL1.Dispose()

        Exit Sub
        Resume
handler:
        'If Err.Number = 91 Then
        '    Resume Next
        'Else
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        'End If
    End Sub

    Private Sub FrmRptDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MandateNo()

        On Error Resume Next
        If Not arrayLogo Is Nothing Then
            Dim ms As New MemoryStream(arrayLogo)
            OwnerLogo.Image = Image.FromStream(ms)
        End If
        lblOwner.Text = UCase(sysOwner)


        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo errhdl

        Dim SelFormular As String = ""
        Dim RptFilename As ReportDocument = New ReportDocument
        Dim RptFilename1 As ReportDocument = New ReportDocument

        'Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        'Dim cmSQL As SqlCommand = cnSQL.CreateCommand

       
        If UCase(Trim(ReportName)) = "MANDATE" Then
            If Trim(cboMandateNo.Text) = "" Then
                MsgBox("Pls. select mandate no", vbInformation, strApptitle)
                Exit Sub
            End If
            RptFilename.Load(AppPath + "ConfigDir\Mandate.rpt")
            'RptFilename = New Mandate
            SelFormular = " {RptPayment.MandateNo}='" & cboMandateNo.Text & "'"
            FrmMandateRpt.TheMandateNo = cboMandateNo.Text
            FrmMandateRpt.frmParent = Me
            FrmMandateRpt.ShowDialog()

            If FullMandateNo = "SDDDDDDDDDDD_FFFFF@@##" Then Exit Sub

            RptFilename.DataDefinition.FormulaFields("Title").Text = "'" & dTitle & "'"
            RptFilename.DataDefinition.FormulaFields("AmtInWords").Text = "'" & dAmtInWords & "'"
            RptFilename.DataDefinition.FormulaFields("Signatory1").Text = "'" & Signatory1 & "'"
            RptFilename.DataDefinition.FormulaFields("Signatory2").Text = "'" & Signatory2 & "'"
            RptFilename.DataDefinition.FormulaFields("Signatory3").Text = "'" & Signatory3 & "'"
            RptFilename.DataDefinition.FormulaFields("PreparedBy").Text = "'" & PreparedBy & "'"
            RptFilename.DataDefinition.FormulaFields("FullMandateNo").Text = "'" & FullMandateNo & "'"

            ' Exit Sub
        ElseIf UCase(Trim(ReportName)) = UCase("STIPENDS  SCHEDULE (Exclude Unpaid Delegates)") Then
            'RptFilename = New StipendSchedule
            'SelFormular = " {RptPayment.Amount}>0 AND {RptPayment.NoOfDelegate}<=1 AND {RptPayment.PayPeriod}=cdate('" & PayPeriod & "')"
            'If cboMandateNo.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboMandateNo.Text & "'"
        ElseIf UCase(Trim(ReportName)) = UCase("MANDATE (Excel)") Then
            Export2Excel()
            Exit Sub
        End If
        RptDestination = "Screen"
        myReportDocument = RptFilename
        If SelFormular <> "" Then myCrystalReportViewer.SelectionFormula = SelFormular
        ConfigureCrystalReports()
        Me.Text = "Report: " + UCase(RptTitle)
        myCrystalReportViewer.ReportSource = myReportDocument
        myCrystalReportViewer.Zoom(100)


        If UCase(Trim(ReportName)) = "MANDATE" Then
            'RptFilename = New CoveringLetter

            Select Case clayout
                Case Is = 1
                    RptFilename1.Load(AppPath + "ConfigDir\CoveringLetter1.rpt")
                Case Is = 2
                    RptFilename1.Load(AppPath + "ConfigDir\CoveringLetter2.rpt")
                Case Is = 3
                    RptFilename1.Load(AppPath + "ConfigDir\CoveringLetter3.rpt")
                Case Is = 4
                    RptFilename1.Load(AppPath + "ConfigDir\CoveringLetter4.rpt")
                Case Is = 5
                    RptFilename1.Load(AppPath + "ConfigDir\CoveringLetter5.rpt")
                Case Is = 6
                    RptFilename1.Load(AppPath + "ConfigDir\CoveringLetter6.rpt")
                Case Else
                    MsgBox("Layout not available", vbInformation, strApptitle)

                    Exit Sub

            End Select

            SelFormular = " {RptPayment.MandateNo}='" & cboMandateNo.Text & "'"
            RptFilename1.DataDefinition.FormulaFields("Title").Text = "'" & dTitle & "'"
            RptFilename1.DataDefinition.FormulaFields("AmtInWords").Text = "'" & dAmtInWords & "'"
            RptFilename1.DataDefinition.FormulaFields("Signatory1").Text = "'" & Signatory1 & "'"
            RptFilename1.DataDefinition.FormulaFields("Signatory2").Text = "'" & Signatory2 & "'"
            RptFilename1.DataDefinition.FormulaFields("Signatory3").Text = "'" & Signatory3 & "'"
            RptFilename1.DataDefinition.FormulaFields("Signatory1Design").Text = "'" & Signatory1Design & "'"
            RptFilename1.DataDefinition.FormulaFields("Signatory2Design").Text = "'" & Signatory2Design & "'"
            RptFilename1.DataDefinition.FormulaFields("Signatory3Design").Text = "'" & Signatory3Design & "'"

            RptFilename1.DataDefinition.FormulaFields("PreparedBy").Text = "'" & PreparedBy & "'"
            RptFilename1.DataDefinition.FormulaFields("FullMandateNo").Text = "'" & FullMandateNo & "'"
            'RptDestination = "Screen"
            'myReportDocument = RptFilename
            'If SelFormular <> "" Then myCrystalReportViewer.SelectionFormula = SelFormular
            'ConfigureCrystalReports()
            'Me.Text = "Report: " + UCase(RptTitle)
            'myCrystalReportViewer.ReportSource = myReportDocument
            'myCrystalReportViewer.Zoom(100)

            Dim ChildForm As New FrmRptDisplay
            ChildForm.RptTitle = UCase(Trim(ReportName))
            ChildForm.RptDestination = "Screen"
            ChildForm.myReportDocument = RptFilename1
            If SelFormular <> "" Then ChildForm.SelFormula = SelFormular
            ChildForm.ShowDialog()


        End If

   

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Sub mnuSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMandate.Click
        ReportName = mnuMandate.Text

        AppHeader1.lblForm.Text = UCase(ReportName)

        'lblPeriod.ForeColor = Color.Red
        'lblState.ForeColor = Color.Red
        'lblCamp.ForeColor = Color.Red
        Panel6.Visible = False
    End Sub
    Private Sub mnuConSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSummary1.Click
        ReportName = mnuSummary1.Text
        AppHeader1.lblForm.Text = UCase(ReportName)
        'lblPeriod.ForeColor = Color.Red
        'lblState.ForeColor = Color.Red
        'lblCamp.ForeColor = Color.Red
    End Sub

    Private Sub mnuAnnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnnual.Click
        ReportName = mnuAnnual.Text
        AppHeader1.lblForm.Text = UCase(ReportName)
        'lblPeriod.ForeColor = Color.Red
        'lblState.ForeColor = Color.Red
        'lblCamp.ForeColor = Color.Red
        Panel6.Visible = False
    End Sub
    Private Sub mnuSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSummary.Click
        ReportName = mnuSummary.Text
        AppHeader1.lblForm.Text = UCase(ReportName)
        Panel6.Visible = False
    End Sub
    Private Sub Export2Excel()
        'Create a new workbook in Excel
        'On Error Resume Next
        'My.Application.DoEvents()
        On Error GoTo errhdl
 
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        'Dim hk As Integer
        cnSQL.Open()
        'For hk = 1 To cboMandateNo.Items.Count - 1
        'cboMandateNo.SelectedIndex = hk
        Dim oExcel As Object
        Dim xlbook As Object
        Dim xlsheet As Object
        oExcel = CreateObject("Excel.Application")

        If tDocFile.Text = "" Then
            MsgBox("Please select a location to save the file into", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim filename As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\Mandate.xls" ' Trim(tPeriod.Text) + ".xls" 'Path.GetTempFileName()

        ' Dim filename As String = tDocFile.Text + "\Mandate.xls" ' Trim(tPeriod.Text) + ".xls" 'Path.GetTempFileName()
        On Error Resume Next

        Kill(filename)

        FileCopy(AppPath & "ConfigDir\" + "ExcelTemplate.xls", filename)

        On Error GoTo errhdl
        oExcel.Workbooks.open(filename)



        oExcel.Sheets(1).Select()

        oExcel.Visible = True

        oExcel.Cells(1, 1) = "Customer Reference No"
        oExcel.Cells(1, 2) = "Beneficiary Reference ID"
        oExcel.Cells(1, 3) = "Beneficiary Name"
        oExcel.Cells(1, 4) = "Debit Account Number"
        oExcel.Cells(1, 5) = "Payment Amount"
        oExcel.Cells(1, 6) = "Payment Value Date"
        oExcel.Cells(1, 7) = "Beneficiary Account Number"
        oExcel.Cells(1, 8) = "Beneficiary Address 1"
        oExcel.Cells(1, 9) = "Beneficiary Address 2"
        oExcel.Cells(1, 10) = "Beneficiary Swift Code"
        oExcel.Cells(1, 11) = "Beneficiary Bank Name"
        oExcel.Cells(1, 12) = "Beneficiary Bank Address"
        oExcel.Cells(1, 13) = "Payment Currency"
        oExcel.Cells(1, 14) = "Payment Details 1"
        oExcel.Cells(1, 15) = "Payment Details 2"
        oExcel.Cells(1, 16) = "Beneficiary Country Code"
        oExcel.Cells(1, 17) = "Intermediary Bank Code"
        oExcel.Cells(1, 18) = "Intermediary Bank"
        oExcel.Cells(1, 19) = "Intermediary Bank Address"

        Dim i As Integer

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPayment"
        cmSQL.Parameters.AddWithValue("@MandateNo", cboMandateNo.Text)
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()

        ' If drSQL.HasRows = False Then GoTo skipit
        Dim BenRefID As String
        Dim j As Integer = 2
        'Dim k As Integer = 0
        Do While drSQL.Read
            If MandatePrefix = "" Then
                BenRefID = drSQL.Item("BeneficiaryRefID")
            Else
                If drSQL.Item("Source") = "SCHOOL" Then
                    BenRefID = "SC" + Trim(drSQL.Item("BeneficiaryRefID"))
                ElseIf drSQL.Item("Source") = "STUDENT" Then
                    BenRefID = "ST" + Trim(drSQL.Item("BeneficiaryRefID"))
                ElseIf drSQL.Item("Source") = "STAFF" Then
                    BenRefID = "SF" + Trim(drSQL.Item("BeneficiaryRefID"))
                ElseIf drSQL.Item("Source") = "STAKEHOLDERS" Then
                    BenRefID = "SK" + Trim(drSQL.Item("BeneficiaryRefID"))
                Else
                    BenRefID = drSQL.Item("BeneficiaryRefID")
                End If
            End If

            'oExcel.Cells(j, 1).NumberFormat = "@"
            oExcel.Cells(j, 1) = drSQL.Item("CustomerRefNo")
            ' oExcel.Cells(j, 2).NumberFormat = "@"
            oExcel.Cells(j, 2) = BenRefID 'drSQL.Item("BeneficiaryRefID")
            oExcel.Cells(j, 3) = drSQL.Item("Name")
            If IsNumeric(drSQL.Item("DebitAcctNo")) = True Then
                oExcel.Cells(j, 4).NumberFormat = "@"
                oExcel.Cells(j, 4) = drSQL.Item("DebitAcctNo")
            Else
                oExcel.Cells(j, 4) = drSQL.Item("DebitAcctNo")
            End If
            oExcel.Cells(j, 5).NumberFormat = "0.00"
            oExcel.Cells(j, 5) = drSQL.Item("Amount")

            oExcel.Cells(j, 6).NumberFormat = "dd/mm/yyyy"
            oExcel.Cells(j, 6) = Trim(Str(Format(drSQL.Item("PayValueDate"), "dd"))) + "/" + Trim(Str(Format(drSQL.Item("PayValueDate"), "MM"))) + "/" + Trim(Str(Format(drSQL.Item("PayValueDate"), "yyyy")))

            If IsNumeric(drSQL.Item("BankAcctNo")) = True Then
                oExcel.Cells(j, 7).NumberFormat = "@"
                oExcel.Cells(j, 7) = drSQL.Item("BankAcctNo")
            Else
                oExcel.Cells(j, 7) = drSQL.Item("BankAcctNo")
            End If

            oExcel.Cells(j, 8) = drSQL.Item("Address1")
            oExcel.Cells(j, 9) = drSQL.Item("Address2")

            If IsNumeric(drSQL.Item("SwiftCode")) = True Then
                oExcel.Cells(j, 10).NumberFormat = "@"
                oExcel.Cells(j, 10) = drSQL.Item("SwiftCode")
            Else
                oExcel.Cells(j, 10) = drSQL.Item("SwiftCode")
            End If


            oExcel.Cells(j, 11) = drSQL.Item("BankName")
            oExcel.Cells(j, 12) = drSQL.Item("BankAddress")
            oExcel.Cells(j, 13) = drSQL.Item("Currency")
            oExcel.Cells(j, 14) = drSQL.Item("PayDetails1")
            oExcel.Cells(j, 15) = drSQL.Item("PayDetails2")
            oExcel.Cells(j, 16) = drSQL.Item("CountryCode")

            If IsNumeric(drSQL.Item("IntermediateSwiftCode")) = True Then
                oExcel.Cells(j, 17).NumberFormat = "@"
                oExcel.Cells(j, 17) = drSQL.Item("IntermediateSwiftCode")
            Else
                oExcel.Cells(j, 17) = drSQL.Item("IntermediateSwiftCode")
            End If

            oExcel.Cells(j, 18) = drSQL.Item("IntermediateBankName")
            oExcel.Cells(j, 19) = drSQL.Item("IntermediateBankAddress")

            j = j + 1

            '  k = 1
        Loop
        'skipit:
        drSQL.Close()
        oExcel.Workbooks(1).Save()   'As(filename)

        'oExcel.Workbooks(1).PrintPreview()
        'End If
        oExcel.Workbooks(1).Close()
        oExcel.Quit()

        'Next

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        MsgBox("Export Complete.....")

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub mnuScheduleExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMandateExcel.Click
        ReportName = mnuMandateExcel.Text
        AppHeader1.lblForm.Text = UCase(ReportName)
        'Panel6.Visible = True
    End Sub

    Private Sub cmdGetFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetFile.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tDocFile.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class