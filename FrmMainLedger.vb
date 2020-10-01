Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmMainLedger
    Private bindingSource As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Private bindingSourceA As New BindingSource()
    Private dataAdapterA As New SqlDataAdapter()
    Dim ReturnCode As String = ""
    Private Sub FrmClientLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo errhdl
        DGrid.DataSource = bindingSource
        DGridSummary.DataSource = bindingSourceA
        Dim e1 As System.Windows.Forms.LinkLabelLinkClickedEventArgs
        'lnkViewType_LinkClicked(sender, e1)
        DeleteHTMTempFiles()

        FillSchCountry()

        applyGridTheme(DGridSummary)
        applyGridTheme(DGrid)

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Private Sub LoadClientBalances()
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        'cnSQL.Open()
        Dim strQry1 As String = ""
        cmSQL.Parameters.Clear()
        If RadSchool.Checked = True Then
            If cboCountry.Text <> "ALL" Then strQry1 = " SchCountry ='" & cboCountry.Text & "'"
            cmSQL.CommandText = "SELECT Sn, Name, 0 AS CR, SUM(Amount) AS DR,0-SUM(Amount) AS Balance, MAX(Currency) AS TheCurrency FROM Ledger WHERE Source='SCHOOL' " & IIf(strQry1 = "", "", " AND " + strQry1) & " GROUP BY Sn, Name"
        ElseIf RadStudent.Checked = True Then
            If cboCountry.Text <> "ALL" Then strQry1 = " SchCountry ='" & cboCountry.Text & "'"
            If cSchool.Text <> "ALL" Then strQry1 = strQry1 + IIf(strQry1 = "", " ", " AND ") + " SchName ='" & cSchool.Text & "'"
            cmSQL.CommandText = "SELECT Sn, Name, 0 AS CR, SUM(Amount) AS DR,0-SUM(Amount) AS Balance, MAX(Currency) AS TheCurrency FROM Ledger WHERE Source='STUDENT' " & IIf(strQry1 = "", "", " AND " + strQry1) & " GROUP BY Sn, Name"
        ElseIf RadStaff.Checked = True Then
            If cboCountry.Text <> "ALL" Then strQry1 = " SchCountry ='" & cboCountry.Text & "'"
            cmSQL.CommandText = "SELECT Sn, Name, 0 AS CR, SUM(Amount) AS DR,0-SUM(Amount) AS Balance, MAX(Currency) AS TheCurrency FROM Ledger WHERE Source='STAFF' " & IIf(strQry1 = "", "", " AND " + strQry1) & " GROUP BY Sn, Name"
        Else 'RadStake.Checked = True
            If cboCountry.Text <> "ALL" Then strQry1 = " SchCountry ='" & cboCountry.Text & "'"
            cmSQL.CommandText = "SELECT Sn, Name, 0 AS CR, SUM(Amount) AS DR,0-SUM(Amount) AS Balance, MAX(Currency) AS TheCurrency FROM Ledger WHERE Source='STAKEHOLDERS' " & IIf(strQry1 = "", "", " AND " + strQry1) & " GROUP BY Sn, Name"

        End If

        cmSQL.CommandType = CommandType.Text
        dataAdapterA = New SqlDataAdapter(cmSQL)
        Dim commandBuilder As New SqlCommandBuilder(dataAdapterA)
        Dim tableA As New DataTable()
        tableA.Locale = System.Globalization.CultureInfo.InvariantCulture
        dataAdapterA.Fill(tableA)
        bindingSourceA.DataSource = tableA

        Dim myStyle As New DataGridViewCellStyle
        Dim myStyle1 As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Red
        myStyle.Format = "N2"
        myStyle1.Format = "N2"
        myStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        myStyle1.ForeColor = Color.Black
        myStyle1.Alignment = DataGridViewContentAlignment.MiddleRight
        cnSQL.Close()

        LoadDetails("-899", "sfsfsfs@@")

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub LoadDetails(ByVal ClientCode As String, ByVal theName As String)
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        'cnSQL.Open()
        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPaymentDetails"
        If RadSchool.Checked Then cmSQL.Parameters.AddWithValue("@Source", "SCHOOL")
        If RadStudent.Checked Then cmSQL.Parameters.AddWithValue("@Source", "STUDENT")
        If RadStaff.Checked Then cmSQL.Parameters.AddWithValue("@Source", "STAFF")
        If RadStake.Checked Then cmSQL.Parameters.AddWithValue("@Source", "STAKEHOLDERS")

        cmSQL.Parameters.AddWithValue("@RefNo", ClientCode)
        cmSQL.Parameters.AddWithValue("@TheName", theName)

        'cmSQL.CommandText = "SELECT MandateNo,PayValueDate, Amount,PayPeriod, BankName, BankAcctNo, SwiftCode, Currency, SchName, SchCountry, PayDetails1, PayDetails2 FROM Payment WHERE IsSchool=0 AND Sn=" & ClientCode & "' [Name]='" & theName & "'"

        cmSQL.CommandType = CommandType.StoredProcedure
        dataAdapter = New SqlDataAdapter(cmSQL)
        Dim commandBuilder As New SqlCommandBuilder(dataAdapter)
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        dataAdapter.Fill(table)
        bindingSource.DataSource = table

        'DGrid.Columns(5).Width = 250

        Dim myStyle As New DataGridViewCellStyle
        Dim myStyle1 As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Red
        myStyle.Format = "N2"
        myStyle1.Format = "N2"
        myStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        myStyle1.ForeColor = Color.Black
        myStyle1.Alignment = DataGridViewContentAlignment.MiddleRight

        Dim i As Integer
        Dim j As Integer

        'For i = 0 To DGrid.Rows.Count - 1
        '    If DGrid.Item(2, i).Value < 0 Then
        '        DGrid.Item(2, i).Style = myStyle
        '    Else
        '        DGrid.Item(2, i).Style = myStyle1
        '    End If
        'Next
        On Error Resume Next
        DGrid.Columns(2).DefaultCellStyle = myStyle1
        'DGrid.Columns(3).DefaultCellStyle = myStyle1

        cmSQL.Dispose()
        cnSQL.Close()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub DGridSummary_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridSummary.CellClick
        On Error Resume Next
        Me.Tag = ""
        Me.Tag = DGridSummary.Item(0, e.RowIndex).Value
        DGridSummary.Tag = DGridSummary.Item(1, e.RowIndex).Value

    End Sub
    Private Sub DGridSummary_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGridSummary.DoubleClick
        On Error GoTo skipIt
        If Val(Me.Tag) <> 0 Then
            CreateHTML(Me.Tag, DGridSummary.Tag)
            LoadDetails(Me.Tag, DGridSummary.Tag)
        End If


        Exit Sub
skipIt:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Private Function CreateHTML(ByVal ClientCode As String, ByVal theName As String) As Boolean
        On Error GoTo errHandler
        'If Trim(strAccountNo) = "" Then Exit Sub
        ' Create an instance of StreamWriter to write text to a file.
        Dim GetHTMFileName As String = My.Computer.FileSystem.GetTempFileName
        GetHTMFileName = Mid(GetHTMFileName, 1, Len(GetHTMFileName) - 3) + "apx"
        CreateHTML = False
        Using sw As StreamWriter = New StreamWriter(GetHTMFileName)

            sw.WriteLine("<html>")
            sw.WriteLine("<head>")
            sw.WriteLine("<meta http-equiv='Content-Type' content='text/html; charset=windows-1252'>")
            sw.WriteLine("<title>PrimeScholar</title>")
            sw.WriteLine("<style>")
            sw.WriteLine("<!--")
            sw.WriteLine("BODY         { background: url('top-vb.gif') repeat-x; font-family: Verdana; font-size: 67% ; background-color:white } ")
            sw.WriteLine(".maindiv     { background: url('side-vb.gif') repeat-y; padding-left: 30px; padding-top: 5px; position: relative; ")

            sw.WriteLine("height: 50px }")
            sw.WriteLine("P            { margin-top: 0; margin-bottom: 6px; line-height:130% }")
            sw.WriteLine("H1           { margin-top: 20px; margin-bottom: 12px; font-size:190% }")
            sw.WriteLine("H2           { color: #585F56; left: -55px; position: relative; margin-top: 21px; margin-bottom: 9px; font-size:170% ")



            sw.WriteLine("}")
            sw.WriteLine("H3           { margin-top: 21px; margin-bottom: 9px; font-size: 140%;  font-weight: bold}")
            sw.WriteLine("H4           { margin-top: 18px; margin-bottom: 9px; font-size: 140%; font-weight: bold}")
            sw.WriteLine("OL           { margin-top: 0; margin-bottom: 9px; line-height:130%}")
            sw.WriteLine("UL           { margin-top: 0; margin-bottom: 9px; line-height:130%}")
            sw.WriteLine("LI           { margin-top: 0; margin-bottom: 6px }")
            sw.WriteLine("BLOCKQUOTE   { margin-left: 10px }")
            sw.WriteLine("TABLE        { padding: 4px; BACKGROUND: white; BORDER: #DDDCD6 1px solid; BORDER-COLLAPSE: collapse; margin-")

            sw.WriteLine("bottom: 9px; }")
            sw.WriteLine("TR           { vertical-align: top} ")
            sw.WriteLine("TD           { padding: 4px; font-family: Verdana; font-size: 67%; line-height: 130%} ")
            sw.WriteLine(".contents    { line-height: 150% }")
            sw.WriteLine("DIV.CodeBlock   { font-family: 'Courier New'; font-size: 100%; margin-bottom: 6px; BACKGROUND: #f8f7ef; BORDER: ")

            sw.WriteLine("#eeede6 1px solid; padding: 5px; }")
            sw.WriteLine(".CodeInline  { font-family: 'Courier New' }")
            sw.WriteLine(".ProcedureLabel {margin-top: 5px; font-style: italic; font-weight: bold; color: #0D4CC3 } ")
            sw.WriteLine(".FileNameCol { padding: 5px; BACKGROUND: seashell; width=200px; font-size: 60%; font-weight: bold}")
            sw.WriteLine(".Col {padding: 5px; width=600px}")
            sw.WriteLine("-->")
            sw.WriteLine("</style>")
            sw.WriteLine("</head>")

            sw.WriteLine("<body topmargin='0' leftmargin='0' rightmargin='0'>")
            sw.WriteLine("<div class='maindiv'>")

            sw.WriteLine("<a name='top'>")

            sw.WriteLine("<!-- MAIN CONTENT BEGINS -->")

            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand
            Dim drSQL As SqlDataReader

            If RadSchool.Checked Then cmSQL.CommandText = "SELECT * FROM RegisterSch WHERE Sn=" & ClientCode
            If RadStudent.Checked Then cmSQL.CommandText = "SELECT * FROM Register WHERE Sn=" & ClientCode
            If RadStaff.Checked Then cmSQL.CommandText = "SELECT * FROM RegisterStaff WHERE Sn=" & ClientCode
            If RadStake.Checked Then cmSQL.CommandText = "SELECT * FROM RegisterStakeHolders WHERE Sn=" & ClientCode

            cmSQL.CommandType = CommandType.Text

            cnSQL.Open()
            drSQL = cmSQL.ExecuteReader()
            Dim i As Integer
            If drSQL.HasRows = False Then GoTo SkipIt
            CreateHTML = True
            If drSQL.Read Then
                sw.WriteLine("<h1>")
                sw.WriteLine("<span style='font-size: 11pt'>BENEFICIARY INFORMATION</span><a name='top'>")

                sw.WriteLine("</h1>")

                sw.WriteLine("</a>")

                sw.WriteLine("<table border='1' bordercolor= #DDDCD6 width='100%' style='border-collapse: collapse'>")
                sw.WriteLine("<tr>")

                For i = 0 To drSQL.FieldCount - 1

                    sw.WriteLine("<tr>")

                    sw.WriteLine("<td class='FileNameCol'>" & drSQL.GetName(i) & "</td>")
                    If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                        sw.WriteLine("<td class='Col'>" & IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")) & "</td>")
                    ElseIf drSQL.Item(i).GetType.ToString = "System.Decimal" Then
                        sw.WriteLine("<td class='Col'>" & IIf(IsDBNull(drSQL.Item(i)), 0, Format(drSQL.Item(i), "standard")) & "</td>")
                    Else
                        sw.WriteLine("<td class='Col'>" & ChkNull(drSQL.Item(i)) & "</td>")
                    End If
                    sw.WriteLine("</tr>")
                Next i
            Else
                sw.WriteLine("<h1>")
                sw.WriteLine("<span style='font-size: 11pt;color: #990000'>" & sysOwner & "</span><a name='top'>")
                sw.WriteLine("</h1>")
                sw.WriteLine("<h1>")
                sw.WriteLine("<span style='font-size: 11pt;color: #990000'>Details:</span><a name='top'>")
                sw.WriteLine("</h1>")
                sw.WriteLine("</a>")
                sw.WriteLine("<table border='1' bordercolor= #DDDCD6 width='70%' style='border-collapse: collapse'>")
                sw.WriteLine("<tr>")
            End If

SkipIt:
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()

            sw.WriteLine("</table>")
            sw.WriteLine("</p>")
            sw.WriteLine("<h3>")
            sw.WriteLine("<span style='font-size: 60%'>")


            sw.WriteLine("<p>&nbsp;</p>")

            sw.WriteLine("</div>")
            sw.WriteLine("</body>")
            sw.WriteLine("</html>")

            sw.Close()

            WebBrowser.Navigate(New Uri(GetHTMFileName))

        End Using
        Exit Function
        Resume
errHandler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Function
    Private Sub Navigate(ByVal address As String)

        If String.IsNullOrEmpty(address) Then Return
        If address.Equals("about:blank") Then Return
        If Not address.StartsWith("http://") Then
            address = address ''"http://" &
        End If

        Try
            WebBrowser.Navigate(New Uri(address))
        Catch ex As System.UriFormatException
            WebBrowser.Visible = False
            MsgBox("Cannot open Readme file", MsgBoxStyle.Information, strApptitle)
            Return
        End Try
    End Sub
    Private Sub DeleteHTMTempFiles()
        On Error Resume Next
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(My.Computer.FileSystem.SpecialDirectories.Temp, FileIO.SearchOption.SearchTopLevelOnly, "*.apx")
            Kill(foundFile)
        Next
    End Sub
    Private Sub FillSchCountry()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboCountry.Items.Clear()
        cboCountry.Items.Add("ALL")
        'cmSQL.CommandText = "SELECT DISTINCT SchCountry  FROM RegisterSch ORDER BY SchCountry"
        If RadSchool.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchCountry FROM Payment WHERE Source='SCHOOL' ORDER BY SchCountry"
        If RadStudent.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchCountry FROM Payment WHERE  Source='STUDENT' ORDER BY SchCountry"

        If RadStaff.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchCountry FROM Payment WHERE  Source='STAFF' ORDER BY SchCountry"

        If RadStake.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchCountry FROM Payment WHERE  Source='STAKEHOLDERS' ORDER BY SchCountry"

        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboCountry.Items.Add(drSQL.Item("SchCountry").ToString)
            ' State.Items.Add(drSQL.Item("State").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cboCountry.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub oLoadSchName()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cSchool.Items.Clear()
        If cboCountry.Text = "ALL" Then
            If RadSchool.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchName FROM Payment WHERE Source='SCHOOL' ORDER BY [SchName]"
            If RadStudent.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchName FROM Payment WHERE Source='STUDENT' ORDER BY [SchName]"
            If RadStaff.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchName FROM Payment WHERE Source='STAFF' ORDER BY [SchName]"
            If RadStake.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchName FROM Payment WHERE Source='STAKEHOLDERS' ORDER BY [SchName]"
        Else
            If RadSchool.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchName FROM Payment WHERE Source='SCHOOL' AND SchCountry='" & cboCountry.Text & "' ORDER BY [SchName]"
            If RadStudent.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchName FROM Payment WHERE Source='STUDENT' AND SchCountry='" & cboCountry.Text & "' ORDER BY [SchName]"
            If RadStaff.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchName FROM Payment WHERE Source='STAFF' AND SchCountry='" & cboCountry.Text & "' ORDER BY [SchName]"
            If RadStake.Checked = True Then cmSQL.CommandText = "SELECT DISTINCT SchName FROM Payment WHERE Source='STAKEHOLDERS' AND SchCountry='" & cboCountry.Text & "' ORDER BY [SchName]"
        End If
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        cSchool.Items.Add("ALL")
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read
            cSchool.Items.Add(ChkNull(drSQL.Item("SchName")))
        Loop


        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cSchool.SelectedIndex = 0



        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cboCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCountry.SelectedIndexChanged
        If Panel2.Visible = True Then
            oLoadSchName()
        Else
            LoadClientBalances()
        End If

    End Sub
    Private Sub RadStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadStudent.CheckedChanged
        Panel3.Visible = True
        Panel2.Visible = True
        FillSchCountry()
    End Sub
    Private Sub RadSchool_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSchool.CheckedChanged
        Panel3.Visible = True
        Panel2.Visible = False
        FillSchCountry()
    End Sub

    Private Sub cSchool_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cSchool.SelectedIndexChanged
        If Panel2.Visible = True Then LoadClientBalances()
    End Sub

    Private Sub DGridSummary_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridSummary.CellContentClick

    End Sub

    Private Sub DGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGrid.CellContentClick

    End Sub

    Private Sub lnkPrintLedger_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPrintLedger.LinkClicked
        Dim RptFilename As ReportDocument = New ReportDocument

        RptFilename = New Ledger

        Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Ledger"
        ChildForm.RptDestination = "Screen"
        ChildForm.myReportDocument = RptFilename
        'If RadStudent.Checked = True Then
        '    ChildForm.SelFormula = " {RptPayment.IsSchool}=false AND {RptPayment.Sn}=" & Me.Tag
        'Else
        '    ChildForm.SelFormula = " {RptPayment.IsSchool}=true AND {RptPayment.Sn}=" & Me.Tag
        'End If
        If RadSchool.Checked Then ChildForm.SelFormula = " {RptLedger.Source}='SCHOOL'AND {RptLedger.Sn}=" & Me.Tag
        If RadStudent.Checked Then ChildForm.SelFormula = " {RptLedger.Source}='STUDENT'AND {RptLedger.Sn}=" & Me.Tag
        If RadStaff.Checked Then ChildForm.SelFormula = " {RptLedger.Source}='STAFF'AND {RptLedger.Sn}=" & Me.Tag
        If RadStake.Checked Then ChildForm.SelFormula = " {RptLedger.Source}='STAKEHOLDERS'AND {RptLedger.Sn}=" & Me.Tag

        ChildForm.ShowDialog()

    End Sub

    Private Sub RadStaff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadStaff.CheckedChanged
        Panel2.Visible = False
        Panel3.Visible = True
        LoadClientBalances()
    End Sub

    Private Sub RadStake_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadStake.CheckedChanged
        Panel2.Visible = False
        Panel3.Visible = True
        LoadClientBalances()
    End Sub
End Class