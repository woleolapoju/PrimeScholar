Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmPayment
    Dim ReturnID As String
    Dim selectedTVQry As String
    Dim OnlyFirstItem As Boolean = False
    Private bindingSource As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim imageIndex As Integer = 0
    Public ReturnSchoolID As Integer
    Public ReturnPayTypes As String
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
    Public MandateNo As String
    Public clayout As Integer
    Dim StoredX As Long
    Dim StoredY As Long
    Public ReturnSn As Integer
    Public ReturnIDNo As String
    Public ReturnProxySource As String
    Dim LastMandateNo As String = ""
    Dim TheSource As String = ""
    Dim TheCondition As String = ""
    Public dIndex As Integer = -1

    Private fromIndex As Integer
    Private dragIndex As Integer
    Private dragRect As Rectangle

    Dim DGVhasChanged As Boolean
    Dim canSave As Boolean = True


    Private Sub FrmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AppHeader1.lblForm.Text = "Payment"
        lblCurrency.Text = ""
        tTotal.Text = "0.0"
        'Me.DGridList.DataSource = bindingSource
        ' DGridList.AutoGenerateColumns = False

        DGridList.Rows.Clear()

        DGridList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText

        LoadTVList()
        'LoadMandateNo()
        cboCriteria.SelectedIndex = 1

        LoadCurrencyType()

        cboMandateNo.Tag = ""
        lnkSuggest.Visible = False

        'If MandatePrefix = "" Then tMandateSn.Visible = False
        If CustomerRefPrefix = "" Then
            Panel5.Visible = False
            tCustomerRefSn.Visible = False
        End If


        If Trim(MandateNo) <> "" Then
            oLoadPayments(MandateNo)
            If MandatePrefix = "" And CustomerRefPrefix = "" Then
                lnkSuggest.Visible = True
                lnkSuggest.Enabled = False
            End If
            If dIndex <> -1 Then
                DGridList.Rows(dIndex - 1).Selected = True

                '   DGridList.CurrentCell = DGridList.Rows(dIndex - 1).Cells(0)
                '  DGridList.CurrentRow = dIndex - 1
                DGridList.FirstDisplayedScrollingRowIndex = DGridList.CurrentRow.Index
            End If
        Else
            DGVhasChanged = False
            If MandatePrefix = "" And CustomerRefPrefix = "" Then lnkSuggest.Visible = True
            If MandatePrefix <> "" Then
                cboMandateNo.Text = MandatePrefix
                tMandateSn.Text = oGetNewMandateSn()
            End If
            If CustomerRefPrefix <> "" Then
                tCustomerRefNo.Text = CustomerRefPrefix
                tCustomerRefSn.Text = oGetNewCustomerRefNoSn()
            End If

            DGridList.Columns("IDRefNo").Visible = False
            DGridList.Columns("IDNo").Visible = False
            DGridList.Columns("cmdIDNo").Visible = False

        End If

        applyGridTheme(DGridList)

        DGridList.AutoGenerateColumns = False
        DGridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DGridList.ColumnHeadersHeight = 40

        DGridList.ReadOnly = False
        DGridList.AllowUserToDeleteRows = True
        DGridList.Columns("Source").ReadOnly = True
        DGridList.Columns("IDRefNo").ReadOnly = True
        DGridList.Columns("IDNo").ReadOnly = True

        SplitContainer1.SplitterDistance = 301

        DGridList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub
    Private Sub oLoadDbgrid(ByVal Source As String, ByVal strCond As String)
        On Error GoTo errhdl
        Dim i As Integer

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        Dim strQry1 As String = ""
        Dim strCamp As String = ""
        Dim strQry As String = ""
        Dim resp
        Dim BeneRefNo As String
        Dim j As Integer = DGridList.Rows.Count - 1
        Dim g As Integer = 0
        If Source = "STUDENT" Then
            strQry = "SELECT * FROM Register WHERE Active = 1 AND Sn IN (" & strCond & ")"
            strQry = strQry + strQry1 + " ORDER BY SchCountry,SchName"

            cmSQL.CommandText = strQry
            cmSQL.CommandType = CommandType.Text
            drSQL = cmSQL.ExecuteReader()

            Do While drSQL.Read
                If CheckIfExist(Source, drSQL.Item("Sn")) = True Then
                    resp = MsgBox("The Student Beneficiary [" + UCase(drSQL.Item("Name")) + "] Exist....Add (y/n)?", vbYesNoCancel + vbInformation, strApptitle)
                    If resp = vbCancel Then GoTo SkipItFinal
                    If resp = vbNo Then
                        GoTo SkipIt
                    End If
                End If

                DGridList.Rows.Add()
                j = j + 1
                g = DGridList.RowCount
                If Len(g.ToString) = 1 Then
                    BeneRefNo = "00" & j + 1
                ElseIf Len(g.ToString) = 2 Then
                    BeneRefNo = "0" & j + 1
                Else
                    BeneRefNo = g
                End If

                DGridList.Item("Sn", j).Value = drSQL.Item("Sn")
                DGridList.Item("CustomerRefNo", j).Value = "" 'customerRefNo
                DGridList.Item("BeneficiaryRefID", j).Value = BeneRefNo 'drSQL.Item("Sn")      beneficiaryID
                DGridList.Item("tName", j).Value = drSQL.Item("Name")
                'DGridList.Rows(j).Cells(4).Value = IIf(drSQL.Item("Currency") = "USD", "01269958350", IIf(drSQL.Item("Currency") = "EUR", "01269949496", "01269950801"))  'DebitAcctNo
                DGridList.Item("IDRefNo", j).Value = ""
                DGridList.Item("IDNo", j).Value = ChkNull(drSQL.Item("IDNumber"))
                DGridList.Item("ProxySource", j).Value = ""

                DGridList.Item("DebitAcctNo", j).Value = GetDebitAcct4Currency(ChkNull(drSQL.Item("Currency")))  'IIf(ChkNull(drSQL.Item("Currency")) = "USD", USD, IIf(ChkNull(drSQL.Item("Currency")) = "EUR", EUR, GBP))  'DebitAcctNo
                DGridList.Item("Amount", j).Value = 0  'Amount
                DGridList.Item("Currency", j).Value = drSQL.Item("Currency")
                DGridList.Item("Period", j).Value = "" 'Period
                DGridList.Item("Bank1", j).Value = drSQL.Item("BankName")
                DGridList.Item("Account", j).Value = drSQL.Item("BankAcctNo")
                DGridList.Item("SwiftCode", j).Value = drSQL.Item("SwiftCode")
                DGridList.Item("BeneficiaryCountry", j).Value = drSQL.Item("Country")

                DGridList.Item("PayType1", j).Value = "" 'Paytype
                DGridList.Item("PayType", j).Value = "" 'command buttion
                DGridList.Item("PaymentDetails1", j).Value = ChkNull(drSQL.Item("SortCode")) '"" 'paymentDetails1
                DGridList.Item("PaymentDetails2", j).Value = "" 'paymentDetails2
                DGridList.Item("Address1", j).Value = drSQL.Item("Address")
                DGridList.Item("City1", j).Value = ChkNull(drSQL.Item("City")) '+ IIf(ChkNull(drSQL.Item("City")) = "", "", ",") + ChkNull(drSQL.Item("Country"))
                DGridList.Item("CountryCode", j).Value = drSQL.Item("CountryCode")
                DGridList.Item("BankAddress", j).Value = drSQL.Item("BankAddress")
                DGridList.Item("BankCity", j).Value = drSQL.Item("BankCity") '
                On Error Resume Next
                If drSQL.Item("BankCountry") = drSQL.Item("Country") Then 'if the bankCountry is the same as beneficiary country
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("CountryCode")
                Else
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("BankCountry")
                End If
                On Error GoTo errhdl
                DGridList.Item("IntermediateBankName", j).Value = drSQL.Item("IntermediateBankName")
                DGridList.Item("IntermediateSwiftCode", j).Value = drSQL.Item("IntermediateSwiftCode")
                DGridList.Item("IntermediateBankAddress", j).Value = drSQL.Item("IntermediateBankAddress")
                DGridList.Item("IntermediateBankCity", j).Value = drSQL.Item("IntermediateBankCity")
                DGridList.Item("IntermediateBankCountry", j).Value = drSQL.Item("IntermediateBankCountry")
                DGridList.Item("SchoolID", j).Value = drSQL.Item("SchoolID")
                DGridList.Item("SchName", j).Value = drSQL.Item("SchName")
                DGridList.Item("SchAddress", j).Value = drSQL.Item("SchAddress")
                DGridList.Item("SchCity", j).Value = drSQL.Item("SchCity")
                DGridList.Item("SchoolCountry", j).Value = drSQL.Item("SchCountry")
                DGridList.Item("Source", j).Value = Source '0
                DGridList.Item("Remark", j).Value = "" 'Remark
                DGridList.Item("Void", j).Value = 1

SkipIt:
            Loop
            drSQL.Close()
        End If

        If Source = "STUDENT - By Study Programme" Then
            strQry = "SELECT * FROM Register WHERE Active = 1 AND Sn IN (" & strCond & ")"
            strQry = strQry + strQry1 + " ORDER BY SchCountry,SchName,StudyProgramme"

            cmSQL.CommandText = strQry
            cmSQL.CommandType = CommandType.Text
            drSQL = cmSQL.ExecuteReader()

            Do While drSQL.Read
                If CheckIfExist("STUDENT", drSQL.Item("Sn")) = True Then
                    resp = MsgBox("The Student Beneficiary [" + UCase(drSQL.Item("Name")) + "] Exist....Add (y/n)?", vbYesNoCancel + vbInformation, strApptitle)
                    If resp = vbCancel Then GoTo SkipItFinal
                    If resp = vbNo Then
                        GoTo SkipIt1
                    End If
                End If

                DGridList.Rows.Add()
                j = j + 1
                g = DGridList.RowCount
                If Len(g.ToString) = 1 Then
                    BeneRefNo = "00" & j + 1
                ElseIf Len(g.ToString) = 2 Then
                    BeneRefNo = "0" & j + 1
                Else
                    BeneRefNo = g
                End If
                DGridList.Item("Sn", j).Value = drSQL.Item("Sn")
                DGridList.Item("CustomerRefNo", j).Value = "" 'customerRefNo
                DGridList.Item("BeneficiaryRefID", j).Value =BeneRefNo 'j + 1  'drSQL.Item("Sn")      beneficiaryID
                DGridList.Item("tName", j).Value = drSQL.Item("Name")
                'DGridList.Rows(j).Cells(4).Value = IIf(drSQL.Item("Currency") = "USD", "01269958350", IIf(drSQL.Item("Currency") = "EUR", "01269949496", "01269950801"))  'DebitAcctNo
                DGridList.Item("IDRefNo", j).Value = ""
                DGridList.Item("IDNo", j).Value = ChkNull(drSQL.Item("IDNumber"))
                DGridList.Item("ProxySource", j).Value = ""
                DGridList.Item("DebitAcctNo", j).Value = GetDebitAcct4Currency(ChkNull(drSQL.Item("Currency"))) 'IIf(ChkNull(drSQL.Item("Currency")) = "USD", USD, IIf(ChkNull(drSQL.Item("Currency")) = "EUR", EUR, GBP))  'DebitAcctNo
                DGridList.Item("Amount", j).Value = 0  'Amount
                DGridList.Item("Currency", j).Value = drSQL.Item("Currency")
                DGridList.Item("Period", j).Value = "" 'Period
                DGridList.Item("Bank1", j).Value = drSQL.Item("BankName")
                DGridList.Item("Account", j).Value = drSQL.Item("BankAcctNo")
                DGridList.Item("SwiftCode", j).Value = drSQL.Item("SwiftCode")
                DGridList.Item("BeneficiaryCountry", j).Value = drSQL.Item("Country")

                DGridList.Item("PayType1", j).Value = "" 'Paytype
                DGridList.Item("PayType", j).Value = "" 'command buttion
                DGridList.Item("PaymentDetails1", j).Value = ChkNull(drSQL.Item("SortCode")) ' "" 'paymentDetails1
                DGridList.Item("PaymentDetails2", j).Value = "" 'paymentDetails2
                DGridList.Item("Address1", j).Value = drSQL.Item("Address")
                DGridList.Item("City1", j).Value = ChkNull(drSQL.Item("City")) '+ IIf(ChkNull(drSQL.Item("City")) = "", "", ",") + ChkNull(drSQL.Item("Country"))
                DGridList.Item("CountryCode", j).Value = drSQL.Item("CountryCode")
                DGridList.Item("BankAddress", j).Value = drSQL.Item("BankAddress")
                DGridList.Item("BankCity", j).Value = drSQL.Item("BankCity") '
                On Error Resume Next
                If drSQL.Item("BankCountry") = drSQL.Item("Country") Then 'if the bankCountry is the same as beneficiary country
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("CountryCode")
                Else
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("BankCountry")
                End If
                On Error GoTo errhdl
                DGridList.Item("IntermediateBankName", j).Value = drSQL.Item("IntermediateBankName")
                DGridList.Item("IntermediateSwiftCode", j).Value = drSQL.Item("IntermediateSwiftCode")
                DGridList.Item("IntermediateBankAddress", j).Value = drSQL.Item("IntermediateBankAddress")
                DGridList.Item("IntermediateBankCity", j).Value = drSQL.Item("IntermediateBankCity")
                DGridList.Item("IntermediateBankCountry", j).Value = drSQL.Item("IntermediateBankCountry")
                DGridList.Item("SchoolID", j).Value = drSQL.Item("SchoolID")
                DGridList.Item("SchName", j).Value = drSQL.Item("SchName")
                DGridList.Item("SchAddress", j).Value = drSQL.Item("SchAddress")
                DGridList.Item("SchCity", j).Value = drSQL.Item("SchCity")
                DGridList.Item("SchoolCountry", j).Value = drSQL.Item("SchCountry")
                DGridList.Item("Source", j).Value = "STUDENT" '0
                DGridList.Item("Remark", j).Value = "" 'Remark
                DGridList.Item("Void", j).Value = 1

SkipIt1:
            Loop
            drSQL.Close()
        End If

        If Source = "SCHOOL" Then
            strQry = "SELECT * FROM RegisterSch WHERE Active = 1  AND Sn IN (" & strCond & ")" 'AND Sn=" & Val(strCond)
            strQry = strQry + strQry1 + " ORDER BY SchCountry,SchName"

            cmSQL.CommandText = strQry
            cmSQL.CommandType = CommandType.Text
            drSQL = cmSQL.ExecuteReader()

            Do While drSQL.Read
                If CheckIfExist(Source, drSQL.Item("Sn")) = True Then

                    resp = MsgBox("The School Beneficiary [" + UCase(drSQL.Item("SchName")) + "] Exist....Add (y/n)?", vbYesNoCancel + vbInformation, strApptitle)
                    If resp = vbCancel Then GoTo SkipItFinal
                    If resp = vbNo Then
                        GoTo SkipIt2
                    End If

                End If
                j = j + 1
                DGridList.Rows.Add()

                g = DGridList.RowCount
                If Len(g.ToString) = 1 Then
                    BeneRefNo = "00" & j + 1
                ElseIf Len(g.ToString) = 2 Then
                    BeneRefNo = "0" & j + 1
                Else
                    BeneRefNo = g
                End If
                DGridList.Item("Sn", j).Value = drSQL.Item("Sn")
                DGridList.Item("CustomerRefNo", j).Value = "" 'customerRefNo
                DGridList.Item("BeneficiaryRefID", j).Value = BeneRefNo 'j + 1  'drSQL.Item("Sn")      beneficiaryID
                DGridList.Item("tName", j).Value = drSQL.Item("SchName")
                'DGridList.Rows(j).Cells(4).Value = IIf(drSQL.Item("Currency") = "USD", "01269958350", IIf(drSQL.Item("Currency") = "EUR", "01269949496", "01269950801"))  'DebitAcctNo
                DGridList.Item("IDRefNo", j).Value = ""
                DGridList.Item("IDNo", j).Value = ""
                DGridList.Item("ProxySource", j).Value = ""
                DGridList.Item("DebitAcctNo", j).Value = GetDebitAcct4Currency(ChkNull(drSQL.Item("Currency")))  'IIf(ChkNull(drSQL.Item("Currency")) = "USD", USD, IIf(ChkNull(drSQL.Item("Currency")) = "EUR", EUR, GBP))  'DebitAcctNo
                DGridList.Item("Amount", j).Value = 0  'Amount
                DGridList.Item("Currency", j).Value = drSQL.Item("Currency")
                DGridList.Item("Period", j).Value = "" 'Period
                DGridList.Item("Bank1", j).Value = drSQL.Item("BankName")
                DGridList.Item("Account", j).Value = drSQL.Item("BankAcctNo")
                DGridList.Item("SwiftCode", j).Value = drSQL.Item("SwiftCode")
                DGridList.Item("BeneficiaryCountry", j).Value = drSQL.Item("SchCountry")

                DGridList.Item("PayType1", j).Value = "" 'Paytype
                DGridList.Item("PayType", j).Value = "" 'command buttion
                DGridList.Item("PaymentDetails1", j).Value = ChkNull(drSQL.Item("SortCode")) '"" 'paymentDetails1
                DGridList.Item("PaymentDetails2", j).Value = "" 'paymentDetails2
                DGridList.Item("Address1", j).Value = drSQL.Item("SchAddress")
                DGridList.Item("City1", j).Value = ChkNull(drSQL.Item("SchCity"))  '+ IIf(ChkNull(drSQL.Item("SchCity")) = "", "", ",") + ChkNull(drSQL.Item("SchCountry"))
                DGridList.Item("CountryCode", j).Value = drSQL.Item("CountryCode")
                DGridList.Item("BankAddress", j).Value = drSQL.Item("BankAddress")
                DGridList.Item("BankCity", j).Value = drSQL.Item("BankCity") '
                On Error Resume Next
                If drSQL.Item("BankCountry") = drSQL.Item("SchCountry") Then 'if the bankCountry is the same as beneficiary country
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("CountryCode")
                Else
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("BankCountry")
                End If
                On Error GoTo errhdl
                DGridList.Item("IntermediateBankName", j).Value = drSQL.Item("IntermediateBankName")
                DGridList.Item("IntermediateSwiftCode", j).Value = drSQL.Item("IntermediateSwiftCode")
                DGridList.Item("IntermediateBankAddress", j).Value = drSQL.Item("IntermediateBankAddress")
                DGridList.Item("IntermediateBankCity", j).Value = drSQL.Item("IntermediateBankCity")
                DGridList.Item("IntermediateBankCountry", j).Value = drSQL.Item("IntermediateBankCountry")
                DGridList.Item("SchoolID", j).Value = "" 'drSQL.Item("Sn")
                DGridList.Item("SchName", j).Value = "" 'drSQL.Item("SchName")
                DGridList.Item("SchAddress", j).Value = "" ' drSQL.Item("SchAddress")
                DGridList.Item("SchCity", j).Value = "" ' drSQL.Item("SchCity")
                DGridList.Item("SchoolCountry", j).Value = "" 'drSQL.Item("SchCountry")
                DGridList.Item("Source", j).Value = Source
                DGridList.Item("Remark", j).Value = "" 'Remark
                DGridList.Item("Void", j).Value = 1

skipit2:
            Loop
            drSQL.Close()


            DGridList.Columns("IDRefNo").Visible = True
            DGridList.Columns("IDNo").Visible = True
            DGridList.Columns("cmdIDNo").Visible = True

        End If
        If Source = "STAFF" Then
            strQry = "SELECT * FROM RegisterStaff WHERE Active = 1 AND Sn IN (" & strCond & ")"
            strQry = strQry + strQry1 + " ORDER BY Agency, SchCountry,SchName"

            cmSQL.CommandText = strQry
            cmSQL.CommandType = CommandType.Text
            drSQL = cmSQL.ExecuteReader()

            Do While drSQL.Read
                If CheckIfExist(Source, drSQL.Item("Sn")) = True Then
                    resp = MsgBox("The Staff Beneficiary [" + UCase(drSQL.Item("Name")) + "] Exist....Add (y/n)?", vbYesNoCancel + vbInformation, strApptitle)
                    If resp = vbCancel Then GoTo SkipItFinal
                    If resp = vbNo Then
                        GoTo SkipIt3
                    End If
                End If
                j = j + 1
                DGridList.Rows.Add()
                g = DGridList.RowCount
                If Len(g.ToString) = 1 Then
                    BeneRefNo = "00" & j + 1
                ElseIf Len(g.ToString) = 2 Then
                    BeneRefNo = "0" & j + 1
                Else
                    BeneRefNo = g
                End If
                DGridList.Item("Sn", j).Value = drSQL.Item("Sn")
                DGridList.Item("CustomerRefNo", j).Value = "" 'customerRefNo
                DGridList.Item("BeneficiaryRefID", j).Value = BeneRefNo 'j + 1  'drSQL.Item("Sn")      beneficiaryID
                DGridList.Item("tName", j).Value = drSQL.Item("Name")
                'DGridList.Rows(j).Cells(4).Value = IIf(drSQL.Item("Currency") = "USD", "01269958350", IIf(drSQL.Item("Currency") = "EUR", "01269949496", "01269950801"))  'DebitAcctNo
                DGridList.Item("IDRefNo", j).Value = ""
                DGridList.Item("IDNo", j).Value = ChkNull(drSQL.Item("IDNumber"))
                DGridList.Item("ProxySource", j).Value = ""
                DGridList.Item("DebitAcctNo", j).Value = GetDebitAcct4Currency(ChkNull(drSQL.Item("Currency")))  'IIf(ChkNull(drSQL.Item("Currency")) = "USD", USD, IIf(ChkNull(drSQL.Item("Currency")) = "EUR", EUR, GBP))  'DebitAcctNo
                DGridList.Item("Amount", j).Value = 0  'Amount
                DGridList.Item("Currency", j).Value = drSQL.Item("Currency")
                DGridList.Item("Period", j).Value = "" 'Period
                DGridList.Item("Bank1", j).Value = drSQL.Item("BankName")
                DGridList.Item("Account", j).Value = drSQL.Item("BankAcctNo")
                DGridList.Item("SwiftCode", j).Value = drSQL.Item("SwiftCode")
                DGridList.Item("BeneficiaryCountry", j).Value = drSQL.Item("Country")

                DGridList.Item("PayType1", j).Value = "" 'Paytype
                DGridList.Item("PayType", j).Value = "" 'command buttion
                DGridList.Item("PaymentDetails1", j).Value = ChkNull(drSQL.Item("SortCode")) '"" 'paymentDetails1
                DGridList.Item("PaymentDetails2", j).Value = "" 'paymentDetails2
                DGridList.Item("Address1", j).Value = drSQL.Item("Address")
                DGridList.Item("City1", j).Value = ChkNull(drSQL.Item("City")) ' + IIf(ChkNull(drSQL.Item("City")) = "", "", ",") + ChkNull(drSQL.Item("Country"))
                DGridList.Item("CountryCode", j).Value = drSQL.Item("CountryCode")
                DGridList.Item("BankAddress", j).Value = drSQL.Item("BankAddress")
                DGridList.Item("BankCity", j).Value = drSQL.Item("BankCity") '
                On Error Resume Next
                If drSQL.Item("BankCountry") = drSQL.Item("Country") Then 'if the bankCountry is the same as beneficiary country
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("CountryCode")
                Else
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("BankCountry")
                End If
                On Error GoTo errhdl
                DGridList.Item("IntermediateBankName", j).Value = drSQL.Item("IntermediateBankName")
                DGridList.Item("IntermediateSwiftCode", j).Value = drSQL.Item("IntermediateSwiftCode")
                DGridList.Item("IntermediateBankAddress", j).Value = drSQL.Item("IntermediateBankAddress")
                DGridList.Item("IntermediateBankCity", j).Value = drSQL.Item("IntermediateBankCity")
                DGridList.Item("IntermediateBankCountry", j).Value = drSQL.Item("IntermediateBankCountry")
                DGridList.Item("SchoolID", j).Value = drSQL.Item("SchoolID")
                DGridList.Item("SchName", j).Value = drSQL.Item("SchName")
                DGridList.Item("SchAddress", j).Value = drSQL.Item("SchAddress")
                DGridList.Item("SchCity", j).Value = drSQL.Item("SchCity")
                DGridList.Item("SchoolCountry", j).Value = drSQL.Item("SchCountry")
                DGridList.Item("Source", j).Value = Source
                DGridList.Item("Remark", j).Value = "" 'Remark
                DGridList.Item("Void", j).Value = 1

skipIt3:
            Loop
            drSQL.Close()

        End If
        If Source = "STAKEHOLDERS" Then
            strQry = "SELECT * FROM RegisterStakeHolders WHERE Active = 1 AND Sn IN (" & strCond & ")"
            strQry = strQry + strQry1 + " ORDER BY SchCountry,SchName"

            cmSQL.CommandText = strQry
            cmSQL.CommandType = CommandType.Text
            drSQL = cmSQL.ExecuteReader()

            Do While drSQL.Read
                If CheckIfExist(Source, drSQL.Item("Sn")) = True Then
                    resp = MsgBox("The StakeHolder Beneficiary [" + UCase(drSQL.Item("Name")) + "] Exist....Add (y/n)?", vbYesNoCancel + vbInformation, strApptitle)
                    If resp = vbCancel Then GoTo SkipItFinal
                    If resp = vbNo Then
                        GoTo SkipIt4
                    End If
                End If
                j = j + 1
                DGridList.Rows.Add()
                g = DGridList.RowCount
                If Len(g.ToString) = 1 Then
                    BeneRefNo = "00" & j + 1
                ElseIf Len(g.ToString) = 2 Then
                    BeneRefNo = "0" & j + 1
                Else
                    BeneRefNo = g
                End If
                DGridList.Item("Sn", j).Value = drSQL.Item("Sn")
                DGridList.Item("CustomerRefNo", j).Value = "" 'customerRefNo
                DGridList.Item("BeneficiaryRefID", j).Value = BeneRefNo 'j + 1  'drSQL.Item("Sn")      beneficiaryID
                DGridList.Item("tName", j).Value = drSQL.Item("Name")
                'DGridList.Rows(j).Cells(4).Value = IIf(drSQL.Item("Currency") = "USD", "01269958350", IIf(drSQL.Item("Currency") = "EUR", "01269949496", "01269950801"))  'DebitAcctNo
                DGridList.Item("IDRefNo", j).Value = ""
                DGridList.Item("IDNo", j).Value = ChkNull(drSQL.Item("IDNumber"))
                DGridList.Item("ProxySource", j).Value = ""
                DGridList.Item("DebitAcctNo", j).Value = GetDebitAcct4Currency(ChkNull(drSQL.Item("Currency")))  'IIf(ChkNull(drSQL.Item("Currency")) = "USD", USD, IIf(ChkNull(drSQL.Item("Currency")) = "EUR", EUR, GBP))  'DebitAcctNo
                DGridList.Item("Amount", j).Value = 0  'Amount
                DGridList.Item("Currency", j).Value = drSQL.Item("Currency")
                DGridList.Item("Period", j).Value = "" 'Period
                DGridList.Item("Bank1", j).Value = drSQL.Item("BankName")
                DGridList.Item("Account", j).Value = drSQL.Item("BankAcctNo")
                DGridList.Item("SwiftCode", j).Value = drSQL.Item("SwiftCode")
                DGridList.Item("BeneficiaryCountry", j).Value = drSQL.Item("Country")

                DGridList.Item("PayType1", j).Value = "" 'Paytype
                DGridList.Item("PayType", j).Value = "" 'command buttion
                DGridList.Item("PaymentDetails1", j).Value = ChkNull(drSQL.Item("SortCode")) '"" 'paymentDetails1
                DGridList.Item("PaymentDetails2", j).Value = "" 'paymentDetails2
                DGridList.Item("Address1", j).Value = drSQL.Item("Address")
                DGridList.Item("City1", j).Value = ChkNull(drSQL.Item("City")) '+ IIf(ChkNull(drSQL.Item("City")) = "", "", ",") + ChkNull(drSQL.Item("Country"))
                DGridList.Item("CountryCode", j).Value = drSQL.Item("CountryCode")
                DGridList.Item("BankAddress", j).Value = drSQL.Item("BankAddress")
                DGridList.Item("BankCity", j).Value = drSQL.Item("BankCity") '
                On Error Resume Next
                If drSQL.Item("BankCountry") = drSQL.Item("Country") Then 'if the bankCountry is the same as beneficiary country
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("CountryCode")
                Else
                    DGridList.Item("BankCountry", j).Value = drSQL.Item("BankCountry")
                End If
                On Error GoTo errhdl
                DGridList.Item("IntermediateBankName", j).Value = drSQL.Item("IntermediateBankName")
                DGridList.Item("IntermediateSwiftCode", j).Value = drSQL.Item("IntermediateSwiftCode")
                DGridList.Item("IntermediateBankAddress", j).Value = drSQL.Item("IntermediateBankAddress")
                DGridList.Item("IntermediateBankCity", j).Value = drSQL.Item("IntermediateBankCity")
                DGridList.Item("IntermediateBankCountry", j).Value = drSQL.Item("IntermediateBankCountry")
                DGridList.Item("SchoolID", j).Value = drSQL.Item("SchoolID")
                DGridList.Item("SchName", j).Value = drSQL.Item("SchName")
                DGridList.Item("SchAddress", j).Value = drSQL.Item("SchAddress")
                DGridList.Item("SchCity", j).Value = drSQL.Item("SchCity")
                DGridList.Item("SchoolCountry", j).Value = drSQL.Item("SchCountry")
                DGridList.Item("Source", j).Value = Source
                DGridList.Item("Remark", j).Value = "" 'Remark
                DGridList.Item("Void", j).Value = 1
skipit4:
            Loop
            drSQL.Close()

        End If


SkipItFinal:
        'DGridList.Rows(j).Cells(20).Style.BackColor = Color.PaleGoldenrod

        'drSQL.Close()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        lblCount.Text = DGridList.Rows.Count ' GetCount() + 1



        Dim myStyle As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Red
        On Error Resume Next

        Dim ik As Integer = 0
        For ik = 0 To DGridList.RowCount - 1
            For i = 0 To DGridList.ColumnCount - 1
                If Len(DGridList.Item(i, ik).Value) > DGridList.Columns(i).FillWeight Then
                    DGridList.Item(i, ik).Style = myStyle
                    DGridList.Item(i, ik).Value = Mid(DGridList.Item(i, ik).Value, 1, DGridList.Columns(i).FillWeight)
                End If
            Next
            DGridList.Item("Void", ik).Value = 0
        Next


        ' DGridList.Columns(6).HeaderText = "Bank Code"

        'DGridList.Focus()
        DGridList.CurrentCell = DGridList.Rows(0).Cells("Amount")
        DGridList.Focus()

        Exit Sub
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub DGridList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridList.CellClick
        DGridList.Tag = e.RowIndex
    End Sub
    Private Sub DGridList_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridList.CellEndEdit
        On Error GoTo errhdl

        If DGridList.Columns(e.ColumnIndex).Name = "Amount" Then
            If IsNumeric(DGridList.Item("Amount", e.RowIndex).Value) = False Then
                MsgBox("Invalid entry...number expected", vbInformation, strApptitle)
                DGridList.Item("Amount", e.RowIndex).Value = 0
            Else
                DGridList.Item("Amount", e.RowIndex).Value = Format(DGridList.Item("Amount", e.RowIndex).Value, "standard")
                calculateTotal()
            End If

        End If

        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub DGridList_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGridList.DataError
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DGridList.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If
        ' MsgBox(e.Exception.Message)
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim NewMandateNo As String = ""
        canSave = True
        If Trim(cboMandateNo.Text) = "" Then
            MsgBox("Pls. enter Mandate No", vbInformation, strApptitle)
            Exit Sub
        End If

        Dim i As Integer

        If DGridList.Rows.Count > 0 Then
            Dim TheCurrency As String = DGridList.Item("Currency", 0).Value
            For i = 0 To DGridList.Rows.Count - 1
                If DGridList.Item("Currency", i).Value <> TheCurrency Then
                    MsgBox("Currency should be Uniform", vbInformation, strApptitle)
                    Exit Sub
                End If
            Next
            Dim TheDebitAcctNo As String = ""

            On Error Resume Next
            TheDebitAcctNo = DGridList.Item("DebitAcctNo", 0).Value
            On Error GoTo handler

            For i = 0 To DGridList.Rows.Count - 1
                If DGridList.Item("DebitAcctNo", i).Value <> TheDebitAcctNo Then
                    If MsgBox("Debit AcctNo not Uniform...continue (y/n)?", vbInformation + vbYesNo, strApptitle) = vbNo Then Exit Sub
                End If
            Next

            If CustomerRefPrefix = "" Then
                For i = 0 To DGridList.Rows.Count - 1
                    If IIf(DGridList.Item("CustomerRefNo", i).Value Is Nothing, "", DGridList.Item("CustomerRefNo", i).Value) = "" Then
                        MsgBox("CustomerRefNo cannot be blank", vbInformation, strApptitle)
                        Exit Sub
                    End If
                Next
            End If

        End If

        If DGridList.Rows.Count > 0 Then
            For i = 0 To DGridList.Rows.Count - 1
                If DGridList.Item("Source", i).Value = "SCHOOL" Then
                    If DGridList.Item("IDRefNo", i).Value Is Nothing Then
                        If MsgBox("Proxy (Student,Staff or Stakeholders) RefNo not omitted for a SCHOOL transaction" + Chr(13) + Chr(10) + "Continue (y/n)?", vbYesNo + vbInformation, strApptitle) = vbNo Then
                            Exit Sub
                        Else
                            GoTo SkipIt
                        End If
                    ElseIf Val(DGridList.Item("IDRefNo", i).Value) = 0 Then
                        If MsgBox("Proxy (Student,Staff or Stakeholders) RefNo not omitted for a SCHOOL transaction" + Chr(13) + Chr(10) + "Continue (y/n)?", vbYesNo + vbInformation, strApptitle) = vbNo Then
                            Exit Sub
                        Else
                            GoTo SkipIt
                        End If
                    End If
                End If
            Next

        End If

SkipIt:

        NewMandateNo = cboMandateNo.Text + IIf(Trim(tMandateSn.Text) = "" Or Val(tMandateSn.Text) = 0, "", Trim(tMandateSn.Text))

        If MandateNo = "" Then
            'If MandatePrefix = "" Then
            '    If CheckPayments(cboMandateNo.Text) = True Then
            '        If MsgBox("Records already exist for this Mandate No...Continue (y/n)?" + Chr(13) + Chr(10) + "If you choose to Continue, the previous would be deleted", vbYesNo + vbCritical, strApptitle) = vbNo Then Exit Sub
            '    End If
            '    If Trim(tCustomerRefNo.Text) = "" And CustomerRefPrefix <> "" Then
            '        MsgBox("Pls. enter Customer RefNo", vbInformation, strApptitle)
            '        Exit Sub
            '    End If
            'Else

            If Trim(tCustomerRefNo.Text) = "" And CustomerRefPrefix <> "" Then
                MsgBox("Pls. enter Customer RefNo", vbInformation, strApptitle)
                Exit Sub
            End If
            If MandatePrefix <> "" Then
                If MsgBox("Regenerate SerialNo (y/n)?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, strApptitle) = MsgBoxResult.Yes Then
                    tMandateSn.Text = oGetNewMandateSn()
                    If CustomerRefPrefix <> "" Then tCustomerRefSn.Text = oGetNewCustomerRefNoSn()
                End If
            End If

            If CheckPayments(NewMandateNo) = True Then
                If MsgBox("Records already exist for this Mandate No...Continue (y/n)?" + Chr(13) + Chr(10) + "If you choose to Continue, the previous would be deleted", vbYesNo + vbCritical, strApptitle) = vbNo Then Exit Sub
            End If
            'End If

        Else
            '            NewMandateNo = cboMandateNo.Text + IIf(Trim(tMandateSn.Text) = "" Or Val(tMandateSn.Text) = 0, "", Trim(tMandateSn.Text))

            If CheckPayments(NewMandateNo) = True And NewMandateNo <> MandateNo Then
                If MsgBox("Records already exist for this Mandate No...Continue (y/n)?" + Chr(13) + Chr(10) + "If you choose to Continue, the previous would be deleted", vbYesNo + vbCritical, strApptitle) = vbNo Then Exit Sub
            End If
        End If

        If Val(tMandateSn.Text) = 0 And MandatePrefix <> "" Then
            If MsgBox("Mandate SerialNo should be a number....continue (y/n)?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, strApptitle) = MsgBoxResult.No Then Exit Sub
        End If
        If Val(tCustomerRefSn.Text) = 0 And CustomerRefPrefix <> "" Then
            If MsgBox("CustomerRefNo, SerialNo should be a number....continue (y/n)?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, strApptitle) = MsgBoxResult.No Then Exit Sub
        End If

        ' CleanList()
        cleanData()

        If canSave = False Then
            MsgBox("Saving Aborted please correct error(s) found....", MsgBoxStyle.Critical, strApptitle)
            Exit Sub
        End If

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        myTrans = cnSQL.BeginTransaction(IsolationLevel.Serializable)
        cmSQL.Transaction = myTrans

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "DeletePayment"
        cmSQL.CommandType = CommandType.StoredProcedure
        If Trim(MandateNo) = "" Then
            cmSQL.Parameters.AddWithValue("@MandateNo", NewMandateNo)
        Else
            cmSQL.Parameters.AddWithValue("@MandateNo", MandateNo)
        End If
        cmSQL.ExecuteNonQuery()

        If MandateNo <> "" And NewMandateNo <> MandateNo Then
            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "DeletePayment"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@MandateNo", NewMandateNo)
            cmSQL.ExecuteNonQuery()
        End If
        Dim g As Integer = 0
        For i = 0 To DGridList.Rows.Count - 1

            If IIf(DGridList.Item("Amount", i).Value Is Nothing, 0, DGridList.Item("Amount", i).Value) > 0 Then
                g = g + 1
                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertPayment"
                cmSQL.CommandType = CommandType.StoredProcedure
                cmSQL.Parameters.AddWithValue("@PayPeriod", IIf(DGridList.Item("Period", i).Value Is Nothing, "", DGridList.Item("Period", i).Value))
                cmSQL.Parameters.AddWithValue("@PayValueDate", formatDate(dtpDate))
                cmSQL.Parameters.AddWithValue("@Sn", IIf(DGridList.Item("Sn", i).Value Is Nothing, "", DGridList.Item("Sn", i).Value))
                If CustomerRefPrefix = "" Then
                    cmSQL.Parameters.AddWithValue("@CustomerRefNo", UCase(IIf(DGridList.Item("CustomerRefNo", i).Value Is Nothing, "", DGridList.Item("CustomerRefNo", i).Value)))
                Else
                    If MandateNo = "" Then
                        'cmSQL.Parameters.AddWithValue("@CustomerRefNo", tCustomerRefNo.Text + "/" + Trim(Str(g))) 'cboMandateNo.Text) 'IIf(DGridList.Item(1, i).Value Is Nothing, "", DGridList.Item(1, i).Value))
                        cmSQL.Parameters.AddWithValue("@CustomerRefNo", UCase(tCustomerRefNo.Text + IIf(Trim(tCustomerRefSn.Text) = "" Or Val(tCustomerRefSn.Text) = 0, "", Trim(Str(Val(tCustomerRefSn.Text)))) + Trim(Str(g)))) 'cboMandateNo.Text) 'IIf(DGridList.Item(1, i).Value Is Nothing, "", DGridList.Item(1, i).Value))
                    Else
                        cmSQL.Parameters.AddWithValue("@CustomerRefNo", UCase(IIf(DGridList.Item("CustomerRefNo", i).Value Is Nothing, "", DGridList.Item("CustomerRefNo", i).Value)))
                    End If
                End If
                cmSQL.Parameters.AddWithValue("@ProxySn", IIf(DGridList.Item("IDRefNo", i).Value Is Nothing, "", DGridList.Item("IDRefNo", i).Value))
                cmSQL.Parameters.AddWithValue("@ProxySource", IIf(DGridList.Item("ProxySource", i).Value Is Nothing, "", DGridList.Item("ProxySource", i).Value))
                cmSQL.Parameters.AddWithValue("@IDNo", IIf(DGridList.Item("IDNo", i).Value Is Nothing, "", DGridList.Item("IDNo", i).Value))

                cmSQL.Parameters.AddWithValue("@BeneficiaryRefID", UCase(IIf(DGridList.Item("BeneficiaryRefID", i).Value Is Nothing, "", DGridList.Item("BeneficiaryRefID", i).Value)))
                cmSQL.Parameters.AddWithValue("@Name", UCase(IIf(DGridList.Item("tName", i).Value Is Nothing, "", DGridList.Item("tName", i).Value)))
                cmSQL.Parameters.AddWithValue("@Address1", UCase(IIf(DGridList.Item("Address1", i).Value Is Nothing, "", DGridList.Item("Address1", i).Value)))
                cmSQL.Parameters.AddWithValue("@Address2", UCase(IIf(DGridList.Item("BeneficiaryCountry", i).Value Is Nothing, "", DGridList.Item("BeneficiaryCountry", i).Value)))
                cmSQL.Parameters.AddWithValue("@CountryCode", UCase(IIf(DGridList.Item("CountryCode", i).Value Is Nothing, "", DGridList.Item("CountryCode", i).Value)))
                cmSQL.Parameters.AddWithValue("@BankName", UCase(IIf(DGridList.Item("Bank1", i).Value Is Nothing, "", DGridList.Item("Bank1", i).Value)))
                cmSQL.Parameters.AddWithValue("@BankAcctNo", UCase(IIf(DGridList.Item("Account", i).Value Is Nothing, "", DGridList.Item("Account", i).Value)))
                cmSQL.Parameters.AddWithValue("@SwiftCode", UCase(IIf(DGridList.Item("SwiftCode", i).Value Is Nothing, "", DGridList.Item("SwiftCode", i).Value)))
                cmSQL.Parameters.AddWithValue("@BankAddress", UCase(IIf(DGridList.Item("BankAddress", i).Value Is Nothing, "", DGridList.Item("BankAddress", i).Value)))
                cmSQL.Parameters.AddWithValue("@BankCity", IIf(DGridList.Item("BankCity", i).Value Is Nothing, "", DGridList.Item("BankCity", i).Value))
                cmSQL.Parameters.AddWithValue("@BankCountry", IIf(DGridList.Item("BankCountry", i).Value Is Nothing, "", DGridList.Item("BankCountry", i).Value))
                cmSQL.Parameters.AddWithValue("@Currency", UCase(IIf(DGridList.Item("Currency", i).Value Is Nothing, "", DGridList.Item("Currency", i).Value)))
                cmSQL.Parameters.AddWithValue("@IntermediateBankName", IIf(DGridList.Item("IntermediateBankName", i).Value Is Nothing, "", DGridList.Item("IntermediateBankName", i).Value))
                cmSQL.Parameters.AddWithValue("@IntermediateSwiftCode", IIf(DGridList.Item("IntermediateSwiftCode", i).Value Is Nothing, "", DGridList.Item("IntermediateSwiftCode", i).Value))
                cmSQL.Parameters.AddWithValue("@IntermediateBankAddress", IIf(DGridList.Item("IntermediateBankAddress", i).Value Is Nothing, "", DGridList.Item("IntermediateBankAddress", i).Value))
                cmSQL.Parameters.AddWithValue("@IntermediateBankCity", IIf(DGridList.Item("IntermediateBankCity", i).Value Is Nothing, "", DGridList.Item("IntermediateBankCity", i).Value))
                cmSQL.Parameters.AddWithValue("@IntermediateBankCountry", IIf(DGridList.Item("IntermediateBankCountry", i).Value Is Nothing, "", DGridList.Item("IntermediateBankCountry", i).Value))
                cmSQL.Parameters.AddWithValue("@SchoolID", IIf(DGridList.Item("SchoolID", i).Value Is Nothing, "", DGridList.Item("SchoolID", i).Value))
                cmSQL.Parameters.AddWithValue("@SchName", IIf(DGridList.Item("SchName", i).Value Is Nothing, "", DGridList.Item("SchName", i).Value))
                cmSQL.Parameters.AddWithValue("@SchAddress", IIf(DGridList.Item("SchAddress", i).Value Is Nothing, "", DGridList.Item("SchAddress", i).Value))
                cmSQL.Parameters.AddWithValue("@SchCity", IIf(DGridList.Item("SchCity", i).Value Is Nothing, "", DGridList.Item("SchCity", i).Value))
                cmSQL.Parameters.AddWithValue("@SchCountry", IIf(DGridList.Item("SchoolCountry", i).Value Is Nothing, "", DGridList.Item("SchoolCountry", i).Value))
                cmSQL.Parameters.AddWithValue("@Amount", IIf(DGridList.Item("Amount", i).Value Is Nothing, 0, CDbl(DGridList.Item("Amount", i).Value)))
                cmSQL.Parameters.AddWithValue("@PayDetails1", IIf(DGridList.Item("PaymentDetails1", i).Value Is Nothing, "", DGridList.Item("PaymentDetails1", i).Value))
                cmSQL.Parameters.AddWithValue("@PayDetails2", IIf(DGridList.Item("PaymentDetails2", i).Value Is Nothing, "", DGridList.Item("PaymentDetails2", i).Value))
                cmSQL.Parameters.AddWithValue("@DebitAcctNo", UCase(IIf(DGridList.Item("DebitAcctNo", i).Value Is Nothing, "", DGridList.Item("DebitAcctNo", i).Value)))
                'If MandatePrefix = "" Then
                '    cmSQL.Parameters.AddWithValue("@MandateNo", cboMandateNo.Text)
                'Else
                cmSQL.Parameters.AddWithValue("@MandateNo", UCase(NewMandateNo)) 'cboMandateNo.Text + IIf(Trim(tMandateSn.Text) = "" Or Val(tMandateSn.Text) = 0, "", Trim(Str(Val(tMandateSn.Text)))))  'cboMandateNo.Text)
                'End If

                cmSQL.Parameters.AddWithValue("@Source", IIf(DGridList.Item("Source", i).Value Is Nothing, "", DGridList.Item("Source", i).Value))
                cmSQL.Parameters.AddWithValue("@PayType", IIf(DGridList.Item("PayType1", i).Value Is Nothing, "", DGridList.Item("PayType1", i).Value))
                cmSQL.Parameters.AddWithValue("@dIndex", g)
                cmSQL.Parameters.AddWithValue("@MandateSn", Val(tMandateSn.Text))
                cmSQL.Parameters.AddWithValue("@CustomerSn", Val(tCustomerRefSn.Text))
                cmSQL.Parameters.AddWithValue("@MandatePrefix", UCase(cboMandateNo.Text))
                cmSQL.Parameters.AddWithValue("@CustomerPrefix", UCase(tCustomerRefNo.Text))
                cmSQL.Parameters.AddWithValue("@Remark", IIf(DGridList.Item("Remark", i).Value Is Nothing, "", DGridList.Item("Remark", i).Value))
                cmSQL.Parameters.AddWithValue("@Authorised", 0)
                cmSQL.Parameters.AddWithValue("@AuthorisedBy", "")
                cmSQL.Parameters.AddWithValue("@Username", sysUser)
                cmSQL.Parameters.AddWithValue("@Void", IIf(DGridList.Item("Void", i).Value Is Nothing, 0, IIf(DGridList.Item("Void", i).Value = False, 0, 1)))

                cmSQL.ExecuteNonQuery()
            End If
        Next

        myTrans.Commit()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If g = 0 Then
            MsgBox("No Record Saved", vbInformation, strApptitle)
            Exit Sub
        End If

        MsgBox("Successful", vbInformation, strApptitle)

        DGVhasChanged = False

        LastMandateNo = NewMandateNo

        If CustomerRefPrefix <> "" Then oLoadPayments(NewMandateNo)
        'LoadMandateNo()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim jk As Integer = 0
        Dim kj As Integer
        Dim wr As Integer = 0
        Dim containStr As Boolean = False
        ' Row indexes we'll remove later on.
        Dim deleteIndexList As List(Of Integer) = New List(Of Integer)


        Dim myStyle As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Red

        Dim strNewFilter As String = ""
        Select Case cboCriteria.Text
            Case Is = "="
                strNewFilter = tFilterText2.Text
            Case Is = "Containing"
                strNewFilter = "*" + tFilterText2.Text + "*"
            Case Is = "Start With"
                strNewFilter = tFilterText2.Text + "*"
            Case Is = "End with"
                strNewFilter = "*" + tFilterText2.Text
        End Select
        Dim x As Integer = 0
        While i < DGridList.Rows.Count

            kj = 1
            jk = 1

            'End If
            For j = kj To jk
                If Not DGridList.Item(j, i).Value Is DBNull.Value Or Nothing Then
                    If LCase(DGridList.Item(j, i).Value) Like LCase(strNewFilter) Then
                        DGridList.Item(j, i).Selected = True
                        DGridList.Rows(i).DefaultCellStyle = myStyle
                        x = i
                        '                DGridList.Item(j, i).Style.ForeColor = Color.Red
                        'Exit For
                    End If
                End If
            Next j
            i = i + 1
        End While
        If x > 0 Then
            DGridList.CurrentCell = DGridList.Rows(x).Cells("tName")
            DGridList.Focus()
        End If
        'SendKeys.Send("{BS}")

        'SendKeys.Send("11")

        Exit Sub

    End Sub

    'Function GetCount() As Integer
    '    GetCount = 0
    '    Dim j As Integer = -1
    '    Dim i As Integer
    '    For i = 0 To DGridList.Rows.Count - 1
    '        j = j + 1
    '    Next
    '    GetCount = j
    'End Function
    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        Dim i As Integer
        For i = 0 To DGridList.RowCount - 1
            DGridList.Item("Void", i).Value = IIf(chkSelectAll.Checked, 1, 0)
        Next
    End Sub

    Private Sub DGridList_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DGridList.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        DGridList.Tag = e.RowIndex

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

            On Error GoTo errhdl
            If senderGrid.Columns(e.ColumnIndex).Name = "PayType" Then
                FrmChoosePayType.frmParent = Me
                FrmChoosePayType.ShowDialog()
                If ReturnPayTypes = "" Then Exit Sub

                FillPayType(ReturnPayTypes, e.RowIndex, e.ColumnIndex)
            End If
            If senderGrid.Columns(e.ColumnIndex).Name = "cmdIDNo" Then
                If DGridList.Item("Source", e.RowIndex).Value <> "SCHOOL" Then Exit Sub
                On Error GoTo errhdl
                Dim strValue As String
                Dim strPrompt As String
                Dim strCaption(6) As String
                Dim intWidth(6) As Integer
                strCaption(0) = "RefID"
                intWidth(0) = 50
                strCaption(1) = "Beneficiary Name"
                intWidth(1) = 200
                strCaption(2) = "IDNumber"
                intWidth(2) = 70
                strCaption(3) = "School Name"
                intWidth(3) = 150
                strCaption(4) = "School Country"
                intWidth(4) = 100
                strCaption(5) = "School City"
                intWidth(5) = 100

                With FrmList
                    .frmParent = Me
                    .tSelection = "FillActiveStudent"
                    .listQuery = "FillActiveStudent"
                    .Text = "List of Active Student"
                    .TopMost = True
                    .PanO.Visible = True
                    .ShowDialog()
                End With
                If ReturnSn = 0 Then Exit Sub

                DGridList.Item("IDRefNo", e.RowIndex).Value = ReturnSn
                DGridList.Item("IDNo", e.RowIndex).Value = ReturnIDNo
                DGridList.Item("ProxySource", e.RowIndex).Value = ReturnProxySource

            End If
        End If
        Exit Sub
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub FillPayType(ByVal PayType As String, ByVal dRow As Integer, ByVal dColumn As Integer)
        On Error GoTo handler

        ' DGridList.Item(dColumn - 1, dRow).Value = PayType 'SchoolID
        DGridList.Item("PayType1", dRow).Value = PayType

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
    Private Sub LoadTVList()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim cmSQL1 As SqlCommand = cnSQL.CreateCommand
        Dim drSQL1 As SqlDataReader

        TVList.Nodes.Clear()
        cmSQL.CommandText = "SELECT DISTINCT SchCountry FROM Register WHERE Active=1 ORDER BY SchCountry"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        TVList.BeginUpdate()
        TVList.Nodes.Add("NONE4@", "STUDENT - By Study Programme").BackColor = Color.CadetBlue
        TVList.Nodes.Add("NONE@", "STUDENT").BackColor = Color.CadetBlue

        TVList.Nodes.Add("NONE2@", "STAFF").BackColor = Color.CadetBlue
        TVList.Nodes.Add("NONE3@", "STAKEHOLDERS").BackColor = Color.CadetBlue

        TVList.Nodes.Add("NONE1@", "SCHOOL").BackColor = Color.CadetBlue
        TVList.EndUpdate()
        TVList.Nodes("NONE@").ForeColor = Color.White
        TVList.Nodes("NONE4@").ForeColor = Color.White
        TVList.Nodes("NONE1@").ForeColor = Color.White
        TVList.Nodes("NONE2@").ForeColor = Color.White
        TVList.Nodes("NONE3@").ForeColor = Color.White
        Do While drSQL.Read
            TVList.BeginUpdate()
            TVList.Nodes("NONE@").Nodes.Add(drSQL.Item("SchCountry").ToString, drSQL.Item("SchCountry").ToString) ', drSQL.Item("Account").ToString, 0)
            TVList.EndUpdate()

            LoadTVSubNode(drSQL.Item("SchCountry").ToString, "STUDENT")
        Loop

        drSQL.Close()

        cmSQL.CommandText = "SELECT DISTINCT StudyProgramme FROM Register WHERE Active=1 ORDER BY StudyProgramme"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TVList.BeginUpdate()
            'TVList.Nodes(UCase(drSQL.Item("Outline").ToString)).Nodes.Add(drSQL.Item("Key").ToString, drSQL.Item("Account").ToString, 0)
            TVList.Nodes("NONE4@").Nodes.Add(drSQL.Item("StudyProgramme").ToString, drSQL.Item("StudyProgramme").ToString) ', drSQL.Item("Account").ToString, 0)
            TVList.EndUpdate()
            ' LoadTVSubNode(drSQL.Item("SchCountry").ToString, "SCHOOL")
        Loop
        drSQL.Close()

        cmSQL.CommandText = "SELECT DISTINCT StudyProgramme,Country FROM Register WHERE Active=1 ORDER BY StudyProgramme"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TVList.BeginUpdate()
            'TVList.Nodes(UCase(drSQL.Item("Outline").ToString)).Nodes.Add(drSQL.Item("Key").ToString, drSQL.Item("Account").ToString, 0)
            TVList.Nodes("NONE4@").Nodes(drSQL.Item("StudyProgramme").ToString).Nodes.Add(drSQL.Item("Country").ToString, drSQL.Item("Country").ToString) ', drSQL.Item("Account").ToString, 0)
            TVList.EndUpdate()
            ' LoadTVSubNode(drSQL.Item("SchCountry").ToString, "SCHOOL")
        Loop
        drSQL.Close()


      
        cmSQL.CommandText = "SELECT DISTINCT SchCountry FROM RegisterSch WHERE Active=1 ORDER BY SchCountry"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TVList.BeginUpdate()
            'TVList.Nodes(UCase(drSQL.Item("Outline").ToString)).Nodes.Add(drSQL.Item("Key").ToString, drSQL.Item("Account").ToString, 0)
            TVList.Nodes("NONE1@").Nodes.Add(drSQL.Item("SchCountry").ToString, drSQL.Item("SchCountry").ToString) ', drSQL.Item("Account").ToString, 0)
            TVList.EndUpdate()
            LoadTVSubNode(drSQL.Item("SchCountry").ToString, "SCHOOL")
        Loop
        drSQL.Close()

        cmSQL.CommandText = "SELECT DISTINCT Agency  FROM RegisterStaff WHERE Active=1 ORDER BY Agency"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TVList.BeginUpdate()
            'TVList.Nodes(UCase(drSQL.Item("Outline").ToString)).Nodes.Add(drSQL.Item("Key").ToString, drSQL.Item("Account").ToString, 0)
            TVList.Nodes("NONE2@").Nodes.Add(drSQL.Item("Agency").ToString, drSQL.Item("Agency").ToString) ', drSQL.Item("Account").ToString, 0)
            TVList.EndUpdate()
            'LoadTVSubNode(drSQL.Item("SchCountry").ToString, "SCHOOL")
        Loop
        drSQL.Close()

        cmSQL.CommandText = "SELECT DISTINCT Agency FROM RegisterStakeHolders WHERE Active=1 ORDER BY Agency"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            TVList.BeginUpdate()
            'TVList.Nodes(UCase(drSQL.Item("Outline").ToString)).Nodes.Add(drSQL.Item("Key").ToString, drSQL.Item("Account").ToString, 0)
            TVList.Nodes("NONE3@").Nodes.Add(drSQL.Item("Agency").ToString, drSQL.Item("Agency").ToString) ', drSQL.Item("Account").ToString, 0)
            TVList.EndUpdate()
            'LoadTVSubNode(drSQL.Item("SchCountry").ToString, "SCHOOL")
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        'TVList.Nodes("NONE@").Expand()
        'TVList.Nodes("NONE1@").Expand()
        Exit Sub
        Resume
handler:
        If Err.Number = 91 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub LoadTVSubNode(ByVal TheSchCountry As String, ByVal TheSource As String)
        On Error GoTo handler

        Dim cnSQL1 As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL1 As SqlCommand = cnSQL1.CreateCommand
        Dim drSQL1 As SqlDataReader
        cnSQL1.Open()
        If TheSource = "STUDENT" Then
            cmSQL1.CommandText = "FetchDistinctSchNameInReister"
            cmSQL1.CommandType = CommandType.StoredProcedure
            cmSQL1.Parameters.AddWithValue("@TheSchCountry", TheSchCountry)
            drSQL1 = cmSQL1.ExecuteReader()

            Do While drSQL1.Read
                TVList.BeginUpdate()
                TVList.Nodes("NONE@").Nodes(TheSchCountry).Nodes.Add(drSQL1.Item("SchoolID").ToString + " - " + drSQL1.Item("SchName").ToString)
                TVList.EndUpdate()
            Loop

            drSQL1.Close()
        Else
            cmSQL1.CommandText = "FetchDistinctSchNameInReisterSch"
            cmSQL1.CommandType = CommandType.StoredProcedure
            cmSQL1.Parameters.AddWithValue("@TheSchCountry", TheSchCountry)
            drSQL1 = cmSQL1.ExecuteReader()

            Do While drSQL1.Read
                TVList.BeginUpdate()
                TVList.Nodes("NONE1@").Nodes(TheSchCountry).Nodes.Add(drSQL1.Item("Sn").ToString + " - " + drSQL1.Item("SchName").ToString)
                TVList.EndUpdate()
            Loop

            drSQL1.Close()

        End If

        cmSQL1.Connection.Close()
        cmSQL1.Dispose()
        drSQL1.Close()
        cnSQL1.Close()
        cnSQL1.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 91 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub LoadMandateNo()
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
handler:
        'If Err.Number = 91 Then
        '    Resume Next
        'Else
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        'End If
    End Sub
    Private Sub LoadCurrencyType()
        On Error GoTo handler

        Dim cnSQL1 As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL1 As SqlCommand = cnSQL1.CreateCommand
        Dim drSQL1 As SqlDataReader
        cnSQL1.Open()

        Currency.Items.Clear()

        cmSQL1.CommandText = "SELECT DISTINCT Currency FROM CurrencyType ORDER BY Currency"
        cmSQL1.CommandType = CommandType.Text
        drSQL1 = cmSQL1.ExecuteReader()

        Do While drSQL1.Read
            Currency.Items.Add(drSQL1.Item("Currency"))
        Loop

        cmSQL1.Connection.Close()
        cmSQL1.Dispose()
        drSQL1.Close()
        cnSQL1.Close()
        cnSQL1.Dispose()

        Exit Sub
handler:
        'If Err.Number = 91 Then
        '    Resume Next
        'Else
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        'End If
    End Sub

    Private Sub TVList_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) 'Handles TVList.AfterSelect
        If TVList.SelectedNode.Level = 2 Then
            If TVList.SelectedNode.Parent.Parent.Text = "SCHOOL" Then
                oLoadDbgrid(TVList.SelectedNode.Parent.Parent.Text, GetIt4Me(TVList.SelectedNode.Text, " - "))
                PanSelection.Visible = False
                DGridList.Columns("IDRefNo").Visible = True
                DGridList.Columns("IDNo").Visible = True
                DGridList.Columns("cmdIDNo").Visible = True
            End If
            If TVList.SelectedNode.Parent.Parent.Text = "STUDENT" Then
                PanSelection.Visible = True
                LoadLvList(TVList.SelectedNode.Parent.Parent.Text, "AND SchoolID=" & Val(GetIt4Me(TVList.SelectedNode.Text, " - ")))
                lblChoice.Text = UCase(TVList.SelectedNode.Parent.Parent.Text) + ": " & TVList.SelectedNode.Text
            End If
            If TVList.SelectedNode.Parent.Parent.Text = "STUDENT - By Study Programme" Then
                LoadLvList(TVList.SelectedNode.Parent.Parent.Text, " AND StudyProgramme='" & TVList.SelectedNode.Parent.Text & "' AND Country='" & TVList.SelectedNode.Text & "'")
                PanSelection.Visible = True
                lblChoice.Text = UCase(TVList.SelectedNode.Parent.Parent.Text) + ": " & TVList.SelectedNode.Text
            End If
        End If

        If TVList.SelectedNode.Level = 1 Then
            If TVList.SelectedNode.Parent.Text = "STAFF" Then
                ' oLoadDbgrid(TVList.SelectedNode.Parent.Text, TVList.SelectedNode.Text)
                LoadLvList(TVList.SelectedNode.Parent.Text, "AND Agency='" & TVList.SelectedNode.Text & "'")
                PanSelection.Visible = True
                lblChoice.Text = UCase(TVList.SelectedNode.Parent.Text) + ": " & TVList.SelectedNode.Text
            End If

            If TVList.SelectedNode.Parent.Text = "STAKEHOLDERS" Then
                LoadLvList(TVList.SelectedNode.Parent.Text, "AND Agency='" & TVList.SelectedNode.Text & "'")
                'oLoadDbgrid(TVList.SelectedNode.Parent.Text, TVList.SelectedNode.Text)
                PanSelection.Visible = True
                lblChoice.Text = UCase(TVList.SelectedNode.Parent.Text) + ": " & TVList.SelectedNode.Text
            End If
            If TVList.SelectedNode.Parent.Text = "SCHOOL" Then
                'oLoadDbgrid(TVList.SelectedNode.Parent.Text, "AND SchoolID=" & Val(TVList.SelectedNode.Text))

                LoadLvList(TVList.SelectedNode.Parent.Text, "AND SchCountry='" & TVList.SelectedNode.Text & "'")
                PanSelection.Visible = True
                lblChoice.Text = UCase(TVList.SelectedNode.Parent.Text) + ": " & TVList.SelectedNode.Text
            End If
            If TVList.SelectedNode.Parent.Text = "STUDENT" Then
                'oLoadDbgrid(TVList.SelectedNode.Parent.Parent.Text, "AND SchoolID=" & Val(TVList.SelectedNode.Text))
                LoadLvList(TVList.SelectedNode.Parent.Text, "AND SchCountry='" & TVList.SelectedNode.Text & "'")
                PanSelection.Visible = True
                lblChoice.Text = UCase(TVList.SelectedNode.Parent.Text) + ": " & TVList.SelectedNode.Text
            End If
            If TVList.SelectedNode.Parent.Text = "STUDENT - By Study Programme" Then
                LoadLvList(TVList.SelectedNode.Parent.Text, "AND StudyProgramme='" & TVList.SelectedNode.Text & "'")
                PanSelection.Visible = True
                lblChoice.Text = UCase(TVList.SelectedNode.Parent.Text) + ": " & TVList.SelectedNode.Text
            End If


        End If

        If TVList.SelectedNode.Level = 0 Then
            If TVList.SelectedNode.Text = "STAFF" Then
                ' oLoadDbgrid(TVList.SelectedNode.Parent.Text, TVList.SelectedNode.Text)
                LoadLvList("STAFF", "")
                PanSelection.Visible = True
                lblChoice.Text = "STAFF"
            End If

            If TVList.SelectedNode.Text = "STAKEHOLDERS" Then
                LoadLvList(TVList.SelectedNode.Text, "")
                'oLoadDbgrid(TVList.SelectedNode.Parent.Text, TVList.SelectedNode.Text)
                PanSelection.Visible = True
                lblChoice.Text = "STAKEHOLDERS"
            End If
            If TVList.SelectedNode.Text = "SCHOOL" Then
                'oLoadDbgrid(TVList.SelectedNode.Parent.Text, "AND SchoolID=" & Val(TVList.SelectedNode.Text))

                LoadLvList("SCHOOL", "")
                PanSelection.Visible = True
                lblChoice.Text = "SCHOOL"
            End If
            If TVList.SelectedNode.Text = "STUDENT" Then
                'oLoadDbgrid(TVList.SelectedNode.Parent.Parent.Text, "AND SchoolID=" & Val(TVList.SelectedNode.Text))
                LoadLvList("STUDENT", "")
                PanSelection.Visible = True
                lblChoice.Text = "STUDENT"
            End If
            If TVList.SelectedNode.Text = "STUDENT - By Study Programme" Then
                LoadLvList("STUDENT", "")
                PanSelection.Visible = True
                lblChoice.Text = "STUDENT"
            End If


        End If

    End Sub
    Public Function GetIt4Me(ByVal TheStr As String, ByVal LocStr As String) As String
        On Error GoTo handler
        GetIt4Me = ""
        If TheStr = "" Or LocStr = "" Then Exit Function
        GetIt4Me = TheStr
        Dim TheLen As Integer = InStr(Trim(TheStr), LocStr)
        If TheLen <> 0 Then GetIt4Me = Trim(Mid$(Trim(TheStr), 1, TheLen - 1))
        Exit Function
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Function

    Function CheckIfExist(ByVal TheSource As String, ByVal TheRefNo As Integer) As Boolean
        On Error GoTo handler
        CheckIfExist = False
        Dim d As Integer
        ' If TheSource = "STUDENT" Then
        For d = 0 To DGridList.RowCount - 1
            If DGridList.Item("Sn", d).Value = TheRefNo And DGridList.Item("Source", d).Value = TheSource Then
                CheckIfExist = True
                Exit Function
            End If
        Next
        'Else
        'For d = 0 To DGridList.RowCount - 1
        '    If DGridList.Item(0, d).Value = TheRefNo And DGridList.Item(31, d).Value = 1 Then
        '        CheckIfExist = True
        '        Exit Function
        '    End If
        'Next
        'End If


        Exit Function
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Function

  
    Private Sub oLoadPayments(ByVal MandateNo As String)
        On Error GoTo errhdl
        Dim i As Integer

        DGridList.Rows.Clear()

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        Dim strQry1 As String = ""
        Dim strCamp As String = ""
        Dim strQry As String = ""
        Dim j As Integer = 0

        LastMandateNo = MandateNo

        Dim chkIfSchIncluded As Boolean = False
        cmSQL.CommandText = "FetchPayment"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MandateNo", MandateNo)
        drSQL = cmSQL.ExecuteReader()

        'If DGridList.Rows.Count > 0 Then
        '    If drSQL.HasRows = True Then
        '        If MsgBox("Records exist for this Mandate No...", vbInformation, strApptitle) Then
        '            cboMandateNo.Focus()
        '            Exit Sub
        '        End If
        '    End If
        'End If

        Do While drSQL.Read
            DGridList.Rows.Add()
            DGridList.Item("Sn", j).Value = drSQL.Item("Sn")
            DGridList.Item("CustomerRefNo", j).Value = drSQL.Item("customerRefNo")
            DGridList.Item("BeneficiaryRefID", j).Value = drSQL.Item("BeneficiaryRefID")

            DGridList.Item("IDRefNo", j).Value = ChkNull(drSQL.Item("ProxySn"))
            DGridList.Item("IDNo", j).Value = ChkNull(drSQL.Item("IDNo"))
            DGridList.Item("ProxySource", j).Value = ChkNull(drSQL.Item("ProxySource"))

            DGridList.Item("tName", j).Value = drSQL.Item("Name")
            DGridList.Item("DebitAcctNo", j).Value = drSQL.Item("DebitAcctNo")
            DGridList.Item("Amount", j).Value = Format(drSQL.Item("Amount"), "standard")
            DGridList.Item("Currency", j).Value = drSQL.Item("Currency")
            DGridList.Item("Period", j).Value = drSQL.Item("PayPeriod")
            DGridList.Item("Bank1", j).Value = drSQL.Item("BankName")
            DGridList.Item("Account", j).Value = drSQL.Item("BankAcctNo")
            DGridList.Item("SwiftCode", j).Value = drSQL.Item("SwiftCode")

            DGridList.Item("PayType1", j).Value = drSQL.Item("Paytype") 'Paytype
            ' DGridList.Rows(j).Cells(12).Value = "" 'command buttion
            DGridList.Item("PaymentDetails1", j).Value = drSQL.Item("PayDetails1") '
            DGridList.Item("PaymentDetails2", j).Value = drSQL.Item("PayDetails2") 'paymentDetails2
            DGridList.Item("Address1", j).Value = drSQL.Item("Address1")
            DGridList.Item("BeneficiaryCountry", j).Value = drSQL.Item("Address2") 'Beneficiary Country

            DGridList.Item("City1", j).Value = drSQL.Item("Address2")
            DGridList.Item("CountryCode", j).Value = drSQL.Item("CountryCode")
            DGridList.Item("BankAddress", j).Value = drSQL.Item("BankAddress")
            DGridList.Item("BankCity", j).Value = drSQL.Item("BankCity") '
            DGridList.Item("BankCountry", j).Value = drSQL.Item("BankCountry")
            DGridList.Item("IntermediateBankName", j).Value = drSQL.Item("IntermediateBankName")
            DGridList.Item("IntermediateSwiftCode", j).Value = drSQL.Item("IntermediateSwiftCode")
            DGridList.Item("IntermediateBankAddress", j).Value = drSQL.Item("IntermediateBankAddress")
            DGridList.Item("IntermediateBankCity", j).Value = drSQL.Item("IntermediateBankCity")
            DGridList.Item("IntermediateBankCountry", j).Value = drSQL.Item("IntermediateBankCountry")
            DGridList.Item("SchoolID", j).Value = drSQL.Item("SchoolID")
            DGridList.Item("SchName", j).Value = drSQL.Item("SchName")
            DGridList.Item("SchAddress", j).Value = drSQL.Item("SchAddress")
            DGridList.Item("SchCity", j).Value = drSQL.Item("SchCity")
            DGridList.Item("SchoolCountry", j).Value = drSQL.Item("SchCountry")
            DGridList.Item("Source", j).Value = drSQL.Item("Source")
            DGridList.Item("Remark", j).Value = ChkNull(drSQL.Item("Remark"))

            On Error Resume Next
            DGridList.Item("Void", j).Value = drSQL.Item("Void")
            On Error GoTo errhdl

            If drSQL.Item("Source") = "SCHOOL" Then chkIfSchIncluded = True

            j = j + 1
            dtpDate.Text = drSQL.Item("PayValueDate")
            tCustomerRefSn.Text = ChkNull(drSQL.Item("CustomerSn"))
            tMandateSn.Text = Mid(ChkNull(drSQL.Item("MandateNo")), Len(ChkNull(drSQL.Item("MandatePrefix"))) + 1) 'ChkNull(drSQL.Item("MandateSn"))
            tCustomerRefNo.Text = ChkNull(drSQL.Item("CustomerPrefix"))
            cboMandateNo.Text = ChkNull(drSQL.Item("MandatePrefix"))
        Loop

        drSQL.Close()

        If Trim(cboMandateNo.Text) = "" Then cboMandateNo.Text = MandateNo


        'tCustomerRefNo.Text = CustomerRefPrefix
        'cboMandateNo.Text = MandatePrefix

        'DGridList.Rows(j).Cells(20).Style.BackColor = Color.PaleGoldenrod

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        If chkIfSchIncluded = False Then
            DGridList.Columns("IDRefNo").Visible = False
            DGridList.Columns("IDNo").Visible = False
            DGridList.Columns("cmdIDNo").Visible = False
            DGridList.Refresh()
        End If

        lblCount.Text = DGridList.Rows.Count 'GetCount() + 1
        dtpDate.Focus()

        'Dim myStyle As New DataGridViewCellStyle
        'myStyle.ForeColor = Color.Red

        For i = 0 To DGridList.RowCount - 1
            If DGridList.Item("Void", i).Value = True Then
                ' DGridList.Rows(i).DefaultCellStyle = myStyle
                DGridList.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next i

        calculateTotal()

        DGVhasChanged = False

        Exit Sub
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Function CheckPayments(ByVal MandateNo As String)
        On Error GoTo errhdl
        CheckPayments = False

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()

        cmSQL.CommandText = "FetchPayment"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MandateNo", MandateNo)
        drSQL = cmSQL.ExecuteReader()

        CheckPayments = drSQL.HasRows

        drSQL.Close()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Function
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If

    End Function
    Private Sub cboMandateNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMandateNo.LostFocus
        'If Trim(MandateNo) <> "" Then Exit Sub
        'If Trim(cboMandateNo.Text) = "" Then Exit Sub
        'If CheckPayments(cboMandateNo.Text) = True Then
        '    MsgBox("Records exist for this Mandate No...", vbInformation, strApptitle)
        '    'cboMandateNo.Focus()
        'End If
        'cboMandateNo.Tag = ""
    End Sub
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        If MandateNo <> "" Then cboMandateNo.Text = ""

        MandateNo = ""
        LastMandateNo = ""

        If MandatePrefix = "" And CustomerRefPrefix = "" Then
            lnkSuggest.Visible = True
            lnkSuggest.Enabled = True
        End If

        If MandatePrefix <> "" Then
            cboMandateNo.Text = MandatePrefix
            tMandateSn.Text = oGetNewMandateSn()
        End If
        If CustomerRefPrefix <> "" Then
            tCustomerRefNo.Text = CustomerRefPrefix
            tCustomerRefSn.Text = oGetNewCustomerRefNoSn()
        End If

        DGridList.Rows.Clear()
        DGridList.Columns("IDRefNo").Visible = False
        DGridList.Columns("IDNo").Visible = False
        DGridList.Columns("cmdIDNo").Visible = False
    End Sub
    Private Sub mnuPrintMandate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrintMandate.Click

        On Error GoTo handler
        If Trim(cboMandateNo.Text) = "" Then
            MsgBox("Pls. select mandate no", vbInformation, strApptitle)
            Exit Sub
        End If
        If LastMandateNo = "" Then
            MsgBox("Cannot determine last Mandate...pls select", vbInformation, strApptitle)
            Exit Sub
        End If
    ' Dim NewMandateNo As String = cboMandateNo.Text + IIf(Trim(tMandateSn.Text) = "" Or Val(tMandateSn.Text) = 0, "", Trim(tMandateSn.Text))

    'RptFilename = New Mandate
        FrmMandateRpt.TheMandateNo = LastMandateNo 'cboMandateNo.Text
        FrmMandateRpt.frmParent = Me
        FrmMandateRpt.ShowDialog()

        If FullMandateNo = "SDDDDDDDDDDD_FFFFF@@##" Then Exit Sub

    Dim RptFilename As ReportDocument = New ReportDocument
        RptFilename.Load(AppPath + "ConfigDir\Mandate.rpt")


        RptFilename.DataDefinition.FormulaFields("Title").Text = "'" & dTitle & "'"
        RptFilename.DataDefinition.FormulaFields("AmtInWords").Text = "'" & dAmtInWords & "'"
        RptFilename.DataDefinition.FormulaFields("Signatory1").Text = "'" & Signatory1 & "'"
        RptFilename.DataDefinition.FormulaFields("Signatory2").Text = "'" & Signatory2 & "'"
        RptFilename.DataDefinition.FormulaFields("Signatory3").Text = "'" & Signatory3 & "'"
        RptFilename.DataDefinition.FormulaFields("PreparedBy").Text = "'" & PreparedBy & "'"
        RptFilename.DataDefinition.FormulaFields("FullMandateNo").Text = "'" & FullMandateNo & "'"

    Dim ChildForm1 As New FrmRptDisplay
        ChildForm1.RptTitle = "Mandate"
        ChildForm1.RptDestination = "Screen"
        ChildForm1.myReportDocument = RptFilename
        ChildForm1.SelFormula = ""
        ChildForm1.SelFormula = " {RptPayment.MandateNo}='" & LastMandateNo & "'"
        ChildForm1.ShowDialog()

    'RptFilename = New CoveringLetter

        Select Case clayout
            Case Is = 1
                RptFilename.Load(AppPath + "ConfigDir\CoveringLetter1.rpt")
            Case Is = 2
                RptFilename.Load(AppPath + "ConfigDir\CoveringLetter2.rpt")
            Case Is = 3
                RptFilename.Load(AppPath + "ConfigDir\CoveringLetter3.rpt")
            Case Is = 4
                RptFilename.Load(AppPath + "ConfigDir\CoveringLetter4.rpt")
            Case Is = 5
                RptFilename.Load(AppPath + "ConfigDir\CoveringLetter5.rpt")
            Case Is = 6
                RptFilename.Load(AppPath + "ConfigDir\CoveringLetter6.rpt")
            Case Is = 7
                RptFilename.Load(AppPath + "ConfigDir\CoveringLetter7.rpt")
            Case Is = 8
                RptFilename.Load(AppPath + "ConfigDir\CoveringLetter8.rpt")
            Case Else
                MsgBox("Layout not available", vbInformation, strApptitle)

                Exit Sub

        End Select


        RptFilename.DataDefinition.FormulaFields("Title").Text = "'" & dTitle & "'"
        RptFilename.DataDefinition.FormulaFields("AmtInWords").Text = "'" & dAmtInWords & "'"
        RptFilename.DataDefinition.FormulaFields("Signatory1").Text = "'" & Signatory1 & "'"
        RptFilename.DataDefinition.FormulaFields("Signatory2").Text = "'" & Signatory2 & "'"
        RptFilename.DataDefinition.FormulaFields("Signatory3").Text = "'" & Signatory3 & "'"
        RptFilename.DataDefinition.FormulaFields("Signatory1Design").Text = "'" & Signatory1Design & "'"
        RptFilename.DataDefinition.FormulaFields("Signatory2Design").Text = "'" & Signatory2Design & "'"
        RptFilename.DataDefinition.FormulaFields("Signatory3Design").Text = "'" & Signatory3Design & "'"

        RptFilename.DataDefinition.FormulaFields("PreparedBy").Text = "'" & PreparedBy & "'"
        RptFilename.DataDefinition.FormulaFields("FullMandateNo").Text = "'" & FullMandateNo & "'"

    Dim ChildForm As New FrmRptDisplay
        ChildForm.RptTitle = "Mandate"
        ChildForm.RptDestination = "Screen"
        ChildForm.myReportDocument = RptFilename
        ChildForm.SelFormula = " {RptPayment.MandateNo}='" & LastMandateNo & "'"
        ChildForm.ShowDialog()
        Exit Sub
        Resume
handler:
        If Err.Description Like "*Load report*" Then
            MsgBox("Error Loading Report", vbInformation, strApptitle)
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub


    Private Function oGetNewMandateSn() As Integer
        On Error GoTo errhdl
        Dim i As Integer

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        oGetNewMandateSn = 1
        cmSQL.CommandText = "SELECT ISNULL(MAX(MandateSn),0) AS CurrentMandateSn FROM Payment"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        If drSQL.Read Then
            oGetNewMandateSn = drSQL.Item("CurrentMandateSn") + 1
        End If

        drSQL.Close()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        Exit Function
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Function

    Private Function oGetNewCustomerRefNoSn() As Integer
        On Error GoTo errhdl
        Dim i As Integer

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()
        oGetNewCustomerRefNoSn = 1
        cmSQL.CommandText = "SELECT ISNULL(MAX(CustomerSn),0) AS CurrentCustomerSn FROM Payment"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        If drSQL.Read Then
            oGetNewCustomerRefNoSn = drSQL.Item("CurrentCustomerSn") + 1
        End If

        drSQL.Close()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        Exit Function
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Function

    Private Sub cboMandateNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMandateNo.SelectedIndexChanged

    End Sub

    Private Sub cmdClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClean.Click
        On Error GoTo handler

        CleanList()

        MsgBox("Successfull")

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Sub CleanList()
        On Error GoTo handler

        ' DGridList.Enabled = False
        Dim myStyle As New DataGridViewCellStyle
        myStyle.BackColor = Color.Yellow
        myStyle.ForeColor = Color.Red

        Dim i As Integer
        Dim j As Integer
        Dim h As Integer
        For i = 0 To DGridList.RowCount - 1
            For j = 0 To DGridList.Columns.Count - 1
                DGridList.Item(j, i).Value = Trim(DGridList.Item(j, i).Value)
                If Len(DGridList.Item(j, i).Value) > 0 Then
                    If Asc(Mid(DGridList.Item(j, i).Value, 1)) < 32 Or Asc(Mid(DGridList.Item(j, i).Value, 1)) > 126 Then
                        DGridList.Item(j, i).Value = Mid(DGridList.Item(j, i).Value, 2)
                        DGridList.Item(j, i).Style = myStyle
                        ' DGridList.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    End If

                    If Asc(Microsoft.VisualBasic.Right(DGridList.Item(j, i).Value, 1)) < 32 Or Asc(Microsoft.VisualBasic.Right(DGridList.Item(j, i).Value, 1)) > 126 Then
                        DGridList.Item(j, i).Value = Mid(DGridList.Item(j, i).Value, 1, Len(DGridList.Item(j, i).Value) - 1)
                        DGridList.Item(j, i).Style = myStyle
                    End If
                End If
            Next j
        Next i

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Or Err.Number = 13 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            ' DGridList.Enabled = True
        End If
    End Sub
    Private Sub cmdLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLedger.Click
        Dim ChildForm As New FrmMLedger
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegister.Click
        Dim ChildForm As New FrmRegistration
        ' ChildForm.MdiParent = FrmStart
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdSchRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSchRegister.Click
        Dim ChildForm As New FrmRegistrationSch
        ' ChildForm.MdiParent = FrmStart
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdPayType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayType.Click
        Dim ChildForm As New FrmPaymentType
        ChildForm.ShowDialog()
    End Sub

    Private Sub FrmPayment_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Panel2.Left = Me.Width - Panel2.Width - 10
    End Sub
    Public Sub LoadLvList(ByVal Source As String, ByVal strCondition As String)
        On Error GoTo errhdl

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        TheSource = Source
        TheCondition = strCondition

        lvList.Items.Clear()
        chkAll.Checked = False
        Dim strQry As String = ""

        If Source = "STUDENT" Then
            strQry = "SELECT * FROM Register WHERE Active = 1 " + strCondition 'AND SchoolID=" & Val(SchoolID)
            strQry = strQry + " ORDER BY [Name],SchCountry,SchName"

        End If
        If Source = "SCHOOL" Then
            strQry = "SELECT Sn, SchName AS [Name],'' AS IDNumber, BankName, BankAcctNo, '' AS SchName FROM RegisterSch WHERE Active = 1 " + strCondition 'AND Sn=" & Val(SchoolID)
            strQry = strQry + " ORDER BY [SchName],SchCountry"
        End If
        If Source = "STUDENT - By Study Programme" Then
            strQry = "SELECT * FROM Register WHERE Active = 1 " + strCondition 'AND StudyProgramme='" & SchoolID & "'"
            strQry = strQry + " ORDER BY [Name],SchCountry,SchName,StudyProgramme"
            Source = "STUDENT"
        End If
        If Source = "STAFF" Then
            strQry = "SELECT * FROM RegisterStaff WHERE Active = 1 " + strCondition 'AND Agency='" & SchoolID & "'"
            strQry = strQry + " ORDER BY [Name],Agency, SchCountry,SchName"

        End If
        If Source = "STAKEHOLDERS" Then
            strQry = "SELECT * FROM RegisterStakeHolders WHERE Active = 1 " + strCondition 'AND Agency='" & SchoolID & "'"
            strQry = strQry + " ORDER BY [Name],SchCountry,SchName"
        End If

        cmSQL.CommandText = strQry
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Long = 0
        Dim initialText As String
        Do While drSQL.Read
            j += 1

            initialText = drSQL.Item("Name").ToString
            Dim LvItems As New ListViewItem(initialText)
            LvItems.SubItems.Add(ChkNull(drSQL.Item("Sn")))
            LvItems.SubItems.Add(ChkNull(drSQL.Item("IDNumber")))
            LvItems.SubItems.Add(ChkNull(drSQL.Item("BankName")))
            LvItems.SubItems.Add(ChkNull(drSQL.Item("BankAcctNo")))
            LvItems.SubItems.Add(ChkNull(drSQL.Item("SchName")))
            LvItems.SubItems.Add(Source)

            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop

        drSQL.Close()
        cmSQL.Connection.Close()
        cmSQL.Dispose()

        cnSQL.Close()
        cnSQL.Dispose()

        lblListCount.Text = lvList.Items.Count

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim i As Integer = 0
        For i = 0 To lvList.Items.Count - 1
            lvList.Items(i).Checked = chkAll.Checked
        Next
    End Sub

    Private Sub cmdCloseFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCloseFilter.Click
        PanSelection.Visible = False
    End Sub
    Private Sub PanSelection_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanSelection.MouseDown
        StoredX = e.X
        StoredY = e.Y
        PanSelection.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub PanFilter_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanSelection.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            PanSelection.Top = PanSelection.Top - (StoredY - e.Y)
            PanSelection.Left = PanSelection.Left - (StoredX - e.X)
        End If
        PanSelection.Cursor = Cursors.Default
    End Sub
    Private Sub lblChoice_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblChoice.MouseDown
        StoredX = e.X
        StoredY = e.Y
        lblChoice.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub lblChoice_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblChoice.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            PanSelection.Top = PanSelection.Top + lblChoice.Top - (StoredY - e.Y)
            PanSelection.Left = PanSelection.Left + lblChoice.Left - (StoredX - e.X)
        End If
        lblChoice.Cursor = Cursors.Default
    End Sub
    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        Dim i As Integer = 0
        Dim strIN As String = ""
        For i = 0 To lvList.Items.Count - 1
            If lvList.Items(i).Checked Then
                strIN = strIN + IIf(strIN = "", "", ",") + lvList.Items(i).SubItems(1).Text
            End If
        Next
        If strIN <> "" Then oLoadDbgrid(lvList.Items(0).SubItems(6).Text, strIN)

        ' Dim i As Integer = 0
        For i = 0 To lvList.Items.Count - 1
            lvList.Items(i).Checked = False
        Next
    End Sub


    Private Function GetDebitAcct4Currency(ByVal TheCurrency As String) As String
        On Error GoTo handler
        GetDebitAcct4Currency = ""
        Dim cnSQL1 As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL1 As SqlCommand = cnSQL1.CreateCommand
        Dim drSQL1 As SqlDataReader
        cnSQL1.Open()


        cmSQL1.CommandText = "SELECT DebitAcctNo FROM CurrencyType WHERE Currency='" & TheCurrency & "'"
        cmSQL1.CommandType = CommandType.Text
        drSQL1 = cmSQL1.ExecuteReader()

        If drSQL1.HasRows = True Then
            If drSQL1.Read Then GetDebitAcct4Currency = drSQL1.Item("DebitAcctNo")
        End If

        cmSQL1.Connection.Close()
        cmSQL1.Dispose()
        drSQL1.Close()
        cnSQL1.Close()
        cnSQL1.Dispose()

        Exit Function
handler:
        'If Err.Number = 91 Then
        '    Resume Next
        'Else
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        'End If
    End Function

    Public Sub Export2Excel(ByVal dLastMandateNo As String) '_CSV format

        On Error GoTo errhdl

        If dLastMandateNo = "" Then
            MsgBox("Cannot determine last Mandate...pls select", vbInformation, strApptitle)
            Exit Sub
        End If


        Dim TheFileName As String = dLastMandateNo
        If InStr(dLastMandateNo, "/") Then TheFileName = ""
        If InStr(dLastMandateNo, "\") Then TheFileName = ""
        Dim filename As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\Mandate_" + TheFileName + ".csv" ' Trim(tPeriod.Text) + ".xls" 'Path.GetTempFileName()


        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()

        If File.Exists(filename) Then
            File.Delete(filename)
        End If


        Dim objWriter As New System.IO.StreamWriter(filename, True, System.Text.Encoding.UTF8)

        ''-------Dummy record not to be posted-----------
        'If File.Exists(filename) Then
        '    objWriter.Write("CUSTOMER REF NO,")
        '    objWriter.Write("BENEFICIARY NAME,")
        '    objWriter.Write("BENEFICIARY ACCOUNT NUMBER,")
        '    objWriter.Write("BENEFICIARY ADDRESS,")
        '    objWriter.Write("BENEFICIARY COUNTRY,")
        '    objWriter.Write("SWIFT CODE,")
        '    objWriter.Write("BENEFICIARY BANK NAME,")
        '    objWriter.Write("BENEFICIARY BANK ADDRESS,")
        '    objWriter.Write("BENEFICIARY COUNTRY CODE,")
        '    objWriter.Write("PAYMENT CURRENCY,")
        '    objWriter.Write("PAYMENT DETAILS,")
        '    objWriter.Write("DEBIT ACCOUNT NUMBER,")
        '    objWriter.Write("PAYMENT AMOUNT,")
        '    objWriter.Write("PAYMENT VALUE DATE,")
        '    objWriter.Write("INTERMEDIARY BANK CODE,")
        '    objWriter.Write("INTERMEDIARY BANK NAME,")
        '    objWriter.Write("INTERMEDIARY BANK ADDRESS")
        '    objWriter.Write(Environment.NewLine)
        'End If
        ''--------- End dummy record ---------


        Dim i As Integer

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPayment"
        cmSQL.Parameters.AddWithValue("@MandateNo", dLastMandateNo) ' cboMandateNo.Text)
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()

        Do While drSQL.Read
            If File.Exists(filename) Then

                objWriter.Write(drSQL.Item("CustomerRefNo") & ",")
                If drSQL("Name").ToString().Contains(",") Then
                    objWriter.Write(drSQL("Name").ToString().Replace(",", " ") & ",")
                Else
                    objWriter.Write(drSQL("Name") & ",")
                End If
                objWriter.Write(drSQL.Item("BankAcctNo") & ",")
                objWriter.Write(drSQL.Item("Address1") & ",")
                objWriter.Write(drSQL.Item("Address2") & ",") 'Country
                objWriter.Write(drSQL.Item("SwiftCode") & ",")
                objWriter.Write(drSQL.Item("BankName") & ",")
                objWriter.Write(drSQL.Item("BankAddress") & ",")
                objWriter.Write(drSQL.Item("CountryCode") & ",")
                objWriter.Write(drSQL.Item("Currency") & ",")
                objWriter.Write(drSQL.Item("PayDetails1") & ",")
                objWriter.Write(drSQL.Item("DebitAcctNo") & ",")
                objWriter.Write(Math.Round(drSQL.Item("Amount"), 2) & ",")
                objWriter.Write(Trim(Str(Format(drSQL.Item("PayValueDate"), "dd"))) + "/" + Trim(Str(Format(drSQL.Item("PayValueDate"), "MM"))) + "/" + Trim(Str(Format(drSQL.Item("PayValueDate"), "yy"))) & ",")
                objWriter.Write(drSQL.Item("IntermediateSwiftCode") & ",")
                objWriter.Write(drSQL.Item("IntermediateBankName") & ",")
                objWriter.Write(drSQL.Item("IntermediateBankAddress")) ' & ",")
                objWriter.Write(Environment.NewLine)
            End If
        Loop

        objWriter.Close()

        drSQL.Close()

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

    Public Sub Export2Excel_MSExcel(ByVal dLastMandateNo As String) ' MSExcel format
        'Create a new workbook in Excel
        'On Error Resume Next
        'My.Application.DoEvents()
        On Error GoTo errhdl
        'Dim NewMandateNo As String = cboMandateNo.Text + IIf(Trim(tMandateSn.Text) = "" Or Val(tMandateSn.Text) = 0, "", Trim(Str(Val(tMandateSn.Text))))

        If dLastMandateNo = "" Then
            MsgBox("Cannot determine last Mandate...pls select", vbInformation, strApptitle)
            Exit Sub
        End If

        Dim TheFileName As String = LastMandateNo
        If InStr(LastMandateNo, "/") Then TheFileName = ""
        If InStr(LastMandateNo, "\") Then TheFileName = ""
        Dim filename As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\Mandate_" + TheFileName + ".xls" ' Trim(tPeriod.Text) + ".xls" 'Path.GetTempFileName()


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

        On Error Resume Next

        Kill(filename)

        FileCopy(AppPath & "ConfigDir\" + "ExcelTemplate.xls", filename)

        On Error GoTo errhdl
        oExcel.Workbooks.open(filename)


        oExcel.Sheets(1).Select()

        oExcel.Visible = True



        oExcel.Cells(1, 1) = "CUSTOMER REF NO"
        oExcel.Cells(1, 2) = "BENEFICIARY NAME"
        oExcel.Cells(1, 3) = "BENEFICIARY ACCOUNT NUMBER"
        oExcel.Cells(1, 4) = "BENEFICIARY ADDRESS"
        oExcel.Cells(1, 5) = "BENEFICIARY COUNTRY"
        oExcel.Cells(1, 6) = "SWIFT CODE"
        oExcel.Cells(1, 7) = "BENEFICIARY BANK NAME"
        oExcel.Cells(1, 8) = "BENEFICIARY BANK ADDRESS"
        oExcel.Cells(1, 9) = "BENEFICIARY COUNTRY CODE"
        oExcel.Cells(1, 10) = "PAYMENT CURRENCY"
        oExcel.Cells(1, 11) = "PAYMENT DETAILS"
        oExcel.Cells(1, 12) = "DEBIT ACCOUNT NUMBER"
        oExcel.Cells(1, 13) = "PAYMENT AMOUNT"
        oExcel.Cells(1, 14) = "PAYMENT VALUE DATE"
        oExcel.Cells(1, 15) = "INTERMEDIARY BANK CODE"
        oExcel.Cells(1, 16) = "INTERMEDIARY BANK NAME"
        oExcel.Cells(1, 17) = "INTERMEDIARY BANK ADDRESS"


        Dim i As Integer

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPayment"
        cmSQL.Parameters.AddWithValue("@MandateNo", dLastMandateNo) ' cboMandateNo.Text)
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()

        Dim BenRefID As String
        Dim j As Integer = 2
        Do While drSQL.Read

            oExcel.Cells(j, 1) = drSQL.Item("CustomerRefNo")
            If drSQL("Name").ToString().Contains(",") Then
                oExcel.Cells(j, 2) = drSQL("Name").ToString().Replace(",", " ")
            Else
                oExcel.Cells(j, 2) = drSQL("Name")
            End If

            If IsNumeric(drSQL.Item("BankAcctNo")) = True Then
                oExcel.Cells(j, 3).NumberFormat = "@"
                oExcel.Cells(j, 3) = drSQL.Item("BankAcctNo")
            Else
                oExcel.Cells(j, 3) = drSQL.Item("BankAcctNo")
            End If

            oExcel.Cells(j, 4) = drSQL.Item("Address1")
            oExcel.Cells(j, 5) = drSQL.Item("Address2")   'Country

            If IsNumeric(drSQL.Item("SwiftCode")) = True Then
                oExcel.Cells(j, 6).NumberFormat = "@"
                oExcel.Cells(j, 6) = drSQL.Item("SwiftCode")
            Else
                oExcel.Cells(j, 6) = drSQL.Item("SwiftCode")
            End If

            oExcel.Cells(j, 7) = drSQL.Item("BankName")
            oExcel.Cells(j, 8) = drSQL.Item("BankAddress")
            oExcel.Cells(j, 9) = drSQL.Item("CountryCode")
            oExcel.Cells(j, 10) = drSQL.Item("Currency")
            oExcel.Cells(j, 11) = drSQL.Item("PayDetails1")
            If IsNumeric(drSQL.Item("DebitAcctNo")) = True Then
                oExcel.Cells(j, 12).NumberFormat = "@"
                oExcel.Cells(j, 12) = drSQL.Item("DebitAcctNo")
            Else
                oExcel.Cells(j, 12) = drSQL.Item("DebitAcctNo")
            End If
            oExcel.Cells(j, 13).NumberFormat = "0.00"
            oExcel.Cells(j, 13) = Math.Round(drSQL.Item("Amount"), 2)
            oExcel.Cells(j, 14).NumberFormat = "dd/mm/yyyy"
            oExcel.Cells(j, 14) = Trim(Str(Format(drSQL.Item("PayValueDate"), "dd"))) + "/" + Trim(Str(Format(drSQL.Item("PayValueDate"), "MM"))) + "/" + Trim(Str(Format(drSQL.Item("PayValueDate"), "yyyy")))
            oExcel.Cells(j, 15) = drSQL.Item("IntermediateSwiftCode")
            oExcel.Cells(j, 16) = drSQL.Item("IntermediateBankName")
            oExcel.Cells(j, 17) = drSQL.Item("IntermediateBankAddress")

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

    Private Sub mnuExportMandate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExportMandate.Click

    End Sub


    Private Sub lnkSuggest_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSuggest.LinkClicked
        On Error GoTo errhdl

        If Not DGridList.Rows.Count > 0 Then Exit Sub

        If Trim(tMandateSn.Text) <> "" Then Exit Sub


        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()

        cmSQL.CommandText = "SELECT ISNULL(MAX(MandateSn),0) AS CurrentMandateSn FROM Payment WHERE Currency='" & DGridList.Item("Currency", 0).Value & "'"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        If drSQL.Read Then
            tMandateSn.Text = drSQL.Item("CurrentMandateSn") + 1
        End If

        drSQL.Close()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        cboMandateNo.Text = DGridList.Item("Currency", 0).Value + "/"

        If Len(tMandateSn.Text) = 1 Then
            tMandateSn.Text = "00" & tMandateSn.Text
        ElseIf Len(tMandateSn.Text) = 2 Then
            tMandateSn.Text = "0" & tMandateSn.Text
        Else
            tMandateSn.Text = tMandateSn.Text
        End If

        Exit Sub
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If

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

    Private Sub lvList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvList.SelectedIndexChanged

    End Sub

    Private Sub cmdStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStaff.Click
        Dim ChildForm As New FrmRegistrationStaff
        ' ChildForm.MdiParent = FrmStart
        ChildForm.ShowDialog()
    End Sub

    Private Sub cmdCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCurrency.Click
        Dim ChildForm As New FrmCurrency
        ChildForm.ShowDialog()
        LoadCurrencyType()
    End Sub

    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        filterList()
    End Sub
    Private Sub filterList()
        On Error GoTo errhdl
        Dim i As Integer
        Dim j As Integer = 1
        Dim price As Double = 0.0
        i = lvList.Items.Count - 1
        Do While i >= 0
            If j = 1 Then
                If Not LCase(lvList.Items(i).Text) Like LCase("*" + tFilter.Text + "*") Then
                    lvList.Items(i).Remove()
                End If
            Else
                If Not LCase(lvList.Items(i).SubItems(j - 1).Text) Like LCase("*" + tFilter.Text + "*") Then
                    lvList.Items(i).Remove()
                End If
            End If
            i = i - 1
        Loop
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        On Error GoTo errhdl
        If TheSource = "" Then Exit Sub
        LoadLvList(TheSource, TheCondition)
        tFilter.Text = ""
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub cmdFindtxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindtxt.Click
        On Error GoTo errhdl
        Dim i As Integer
        Dim j As Integer = 1
        Dim price As Double = 0.0
        i = lvList.Items.Count - 1
        Do While i >= 0
            If j = 1 Then
                If LCase(lvList.Items(i).Text) Like LCase("*" + tFilter.Text + "*") Then
                    'lvList.Items(i).ForeColor = Color.Red '.Selected = True
                    lvList.Items(i).BackColor = Color.MediumPurple
                    lvList.Items(i).ForeColor = Color.White
                    lvList.Items(i).EnsureVisible()
                End If
            Else
                If LCase(lvList.Items(i).SubItems(j - 1).Text) Like LCase("*" + tFilter.Text + "*") Then
                    lvList.Items(i).BackColor = Color.MediumPurple '.ForeColor = Color.Red
                    lvList.Items(i).ForeColor = Color.White
                    lvList.Items(i).EnsureVisible()
                End If
            End If
            i = i - 1
        Loop
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub tFilter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tFilter.KeyPress
        If e.KeyChar = Chr(13) Then cmdFindtxt_Click(sender, e)
    End Sub

    Private Sub tFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFilter.TextChanged

    End Sub

    Private Sub DGridList_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGridList.DragDrop
        On Error GoTo errhdl
        Dim p As Point = DGridList.PointToClient(New Point(e.X, e.Y))
        dragIndex = DGridList.HitTest(p.X, p.Y).RowIndex
        If (e.Effect = DragDropEffects.Move) Then
            Dim dragRow As DataGridViewRow = e.Data.GetData(GetType(DataGridViewRow))
            DGridList.Rows.RemoveAt(fromIndex)
            On Error GoTo errhdd
            DGridList.Rows.Insert(dragIndex, dragRow)
            Exit Sub
errhdd:
            DGridList.Rows.Insert(fromIndex, dragRow)
            Err.Clear()

        End If
        Exit Sub
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub DGridList_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGridList.DragOver
        e.Effect = DragDropEffects.Move
    End Sub



    Private Sub DGridList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGridList.MouseDown
        fromIndex = DGridList.HitTest(e.X, e.Y).RowIndex
        If fromIndex > -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragRect = New Rectangle(New Point(e.X - (dragSize.Width / 2), _
                                               e.Y - (dragSize.Height / 2)), _
                                     dragSize)
        Else
            dragRect = Rectangle.Empty
        End If
    End Sub

    Private Sub DGridList_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGridList.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If (dragRect <> Rectangle.Empty _
            AndAlso Not dragRect.Contains(e.X, e.Y)) Then
                DGridList.DoDragDrop(DGridList.Rows(fromIndex), _
                                         DragDropEffects.Move)
            End If
        End If
    End Sub

    Private Sub DGridList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGridList.KeyDown
        If e.Control Then

            If e.KeyCode = Keys.C Then
                ' DGridList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText

                CopyRows()
                DGridList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText

                e.Handled = True
            End If
            If e.KeyCode = Keys.V Then
                ' pasterows()

                PasteUnboundRecords(DGridList)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CopyRows()
        If DGridList.SelectedRows.Count > 0 Then
            'Dim row As DataGridViewRow
            'row = DGridList.SelectedRows(0)
            'Clipboard.SetDataObject(Me.DGridList.GetClipboardContent())

            Dim d As DataObject = DGridList.GetClipboardContent()
            Clipboard.SetDataObject(d)



        End If
    End Sub

    Private Sub pasterows()
        If Clipboard.ContainsText Then
            'Dim CopyText As String
            'CopyText = Clipboard.GetText
            'Dim Items() As String
            'Items = CopyText.Split(ChrW(Keys.Tab))
            'dt1.Rows.Add(Items)


            Dim tArr() As String
            Dim arT() As String
            Dim i, ii As Integer
            Dim c, cc, r As Integer

            tArr = Clipboard.GetText().Split(Environment.NewLine)

            r = DGridList.SelectedCells(0).RowIndex
            c = DGridList.SelectedCells(0).ColumnIndex
            For i = 0 To tArr.Length - 1
                arT = tArr(i).Split(vbTab)
                cc = c
                For ii = 0 To arT.Length - 1
                    With DGridList.Item(cc, r)
                        .Value = arT(ii).TrimStart
                    End With
                    cc = cc + 1
                Next
                r = r + 1
            Next


        End If
    End Sub

    Private Sub PasteUnboundRecords(ByVal dgv As DataGridView)
        Try
            Dim rowLines As String() = Clipboard.GetText(TextDataFormat.Text).Split(New String(0) {vbCr & vbLf}, StringSplitOptions.None)
            Dim currentRowIndex As Integer = (If(dgv.CurrentRow IsNot Nothing, dgv.CurrentRow.Index, 0))
            Dim currentColumnIndex As Integer = (If(dgv.CurrentCell IsNot Nothing, dgv.CurrentCell.ColumnIndex, 0))
            Dim currentColumnCount As Integer = dgv.ColumnCount

            For rowLine As Integer = 0 To rowLines.Length - 1
                If rowLine = rowLines.Length - 1 AndAlso String.IsNullOrEmpty(rowLines(rowLine)) Then
                    Exit For
                End If

                Dim columnsData As String() = rowLines(rowLine).Split(New String(0) {vbTab}, StringSplitOptions.None)
                If (currentColumnIndex + columnsData.Length) > dgv.ColumnCount Then
                    For columnCreationCounter As Integer = 0 To ((currentColumnIndex + columnsData.Length) - currentColumnCount) - 1
                        If columnCreationCounter = rowLines.Length - 1 Then
                            Exit For
                        End If
                    Next
                End If
                If dgv.Rows.Count > (currentRowIndex + rowLine) Then
                    For columnsDataIndex As Integer = 0 To columnsData.Length - 1
                        If currentColumnIndex + columnsDataIndex <= dgv.ColumnCount - 1 Then
                            dgv.Rows(currentRowIndex + rowLine).Cells(currentColumnIndex + columnsDataIndex).Value = columnsData(columnsDataIndex)
                        End If
                    Next
                Else
                    Dim pasteCells As String() = New String(dgv.ColumnCount - 1) {}
                    For cellStartCounter As Integer = currentColumnIndex To dgv.ColumnCount - 1
                        If columnsData.Length > (cellStartCounter - currentColumnIndex) Then
                            pasteCells(cellStartCounter) = columnsData(cellStartCounter - currentColumnIndex)
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            'Log Exception
        End Try


    End Sub

    Private Sub mnuCopyAmount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyAmount.Click
        On Error Resume Next
        Dim h As Integer = 0
        Dim dRow As Integer = Val(DGridList.Tag)
        For h = 0 To DGridList.Rows.Count - 1
            If Val(DGridList.Rows(dRow).Cells("Amount").Value) <> 0 And Val(DGridList.Rows(h).Cells("Amount").Value) = 0 Then 'Amount
                If Val(DGridList.Rows(h).Cells("Amount").Value) = 0 Then DGridList.Rows(h).Cells("Amount").Value = DGridList.Rows(dRow).Cells("Amount").Value
            End If
        Next h
    End Sub

    Private Sub mnuCopyDRAccountNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyDRAccountNo.Click
        Dim h As Integer = 0
        Dim dRow As Integer = Val(DGridList.Tag)
        For h = 0 To DGridList.Rows.Count - 1
            If DGridList.Rows(dRow).Cells("DebitAcctNo").Value <> "" And Val(DGridList.Rows(h).Cells("Sn").Value) > 0 Then 'DrAcctNo
                If DGridList.Rows(h).Cells("DebitAcctNo").Value = "" Then DGridList.Rows(h).Cells("DebitAcctNo").Value = DGridList.Rows(dRow).Cells("DebitAcctNo").Value
            End If
        Next h
    End Sub

    Private Sub mnuCopyPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyPeriod.Click
        Dim h As Integer = 0
        Dim dRow As Integer = Val(DGridList.Tag)
        For h = 0 To DGridList.Rows.Count - 1
            If DGridList.Rows(dRow).Cells("Period").Value <> "" And Val(DGridList.Rows(h).Cells("Sn").Value) > 0 Then 'Period
                If DGridList.Rows(h).Cells("Period").Value = "" Then DGridList.Rows(h).Cells("Period").Value = DGridList.Rows(dRow).Cells("Period").Value
            End If
        Next h
    End Sub

    Private Sub mnuCopyPaymentTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyPaymentTypes.Click
        Dim h As Integer = 0
        Dim dRow As Integer = Val(DGridList.Tag)
        For h = 0 To DGridList.Rows.Count - 1
            If DGridList.Rows(dRow).Cells("PayType1").Value <> "" And Val(DGridList.Rows(h).Cells("Sn").Value) > 0 Then 'PayType
                If DGridList.Rows(h).Cells("PayType1").Value = "" Then DGridList.Rows(h).Cells("PayType1").Value = DGridList.Rows(dRow).Cells("PayType1").Value
            End If
        Next h
    End Sub

    Private Sub mnuGeneratePaymentDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGeneratePaymentDetails.Click
        Dim h As Integer = 0
        On Error Resume Next
        Dim ThePayDetails As String = ""
        Dim ThePayDetails1 As String = ""
        Dim ThePayDetails2 As String = ""

        For h = 0 To DGridList.Rows.Count - 1
            ThePayDetails1 = ""
            ThePayDetails2 = ""
            ThePayDetails = DGridList.Rows(h).Cells("Period").Value + " " + DGridList.Rows(h).Cells("PayType1").Value
            If ThePayDetails = "" Then GoTo SkipIt
            '-------------------OLD STRUCTURE--------------------------
            'If Len(ThePayDetails) > 70 Then
            '    ThePayDetails1 = Mid(ThePayDetails, 1, 70)
            '    ThePayDetails2 = Mid(ThePayDetails, 71, 70)
            'Else
            ThePayDetails1 = ThePayDetails
            ThePayDetails2 = ""
            'End If
            '------------------------------------------------------------
            If Len(DGridList.Rows(h).Cells("PaymentDetails1").Value) = 0 Then
                DGridList.Rows(h).Cells("PaymentDetails1").Value = ThePayDetails1
                'DGridList.Rows(h).Cells("PaymentDetails2").Value = ThePayDetails2
            End If


SkipIt:
        Next h

    End Sub

    Private Sub mnuClearPaymentDetails1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClearPaymentDetails1.Click
        Dim h As Integer = 0
        'For h = 0 To DGridList.Rows.Count - 1
        '    If DGridList.Rows(0).Cells(13).Value <> "" And Val(DGridList.Rows(h).Cells(0).Value) > 0 Then 'paymentDetails1
        '        DGridList.Rows(h).Cells(13).Value = DGridList.Rows(0).Cells(13).Value
        '    End If

        '    If DGridList.Rows(0).Cells(14).Value <> "" And Val(DGridList.Rows(h).Cells(0).Value) > 0 Then 'paymentDetails2
        '        DGridList.Rows(h).Cells(14).Value = DGridList.Rows(0).Cells(14).Value
        '    End If
        'Next h

        For h = 0 To DGridList.Rows.Count - 1
            DGridList.Rows(h).Cells("PaymentDetails1").Value = ""
        Next h
    End Sub

    Private Sub mnuClearPaymentDetails2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClearPaymentDetails2.Click
        Dim h As Integer = 0

        For h = 0 To DGridList.Rows.Count - 1
            DGridList.Rows(h).Cells("PaymentDetails2").Value = ""
        Next h
    End Sub

    Private Sub calculateTotal()
        On Error Resume Next
        Dim h As Integer = 0
        Dim sum As Double = 0
        For h = 0 To DGridList.Rows.Count - 1
            sum = sum + DGridList.Rows(h).Cells("Amount").Value

        Next h
        tTotal.Text = Format(sum, "standard")
        lblCurrency.Text = DGridList.Rows(0).Cells("currency").Value
    End Sub

    Private Sub mnuRegenerateBeneficiaryRefID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegenerateBeneficiaryRefID.Click
        On Error Resume Next
        Dim h As Integer = 0
        Dim g As Integer = 0
        Dim BeneRefNo As String = ""
        For h = 0 To DGridList.Rows.Count - 1
            g = h + 1
            If Len(g.ToString) = 1 Then
                BeneRefNo = "00" & h + 1
            ElseIf Len(g.ToString) = 2 Then
                BeneRefNo = "0" & h + 1
            Else
                BeneRefNo = g
            End If

            DGridList.Item("BeneficiaryRefID", h).Value = BeneRefNo

        Next h
    End Sub

    Private Sub mnuCopyCustomerRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyCustomerRef.Click
        Dim h As Integer = 0
        Dim dRow As Integer = Val(DGridList.Tag)
        For h = 0 To DGridList.Rows.Count - 1
            If DGridList.Rows(dRow).Cells("CustomerRefNo").Value <> "" And Val(DGridList.Rows(h).Cells("Sn").Value) > 0 Then 'CustomerRefNo
                If DGridList.Rows(h).Cells("CustomerRefNo").Value = "" Then DGridList.Rows(h).Cells("CustomerRefNo").Value = DGridList.Rows(dRow).Cells("CustomerRefNo").Value
            End If
        Next h
    End Sub

    Private Sub DGridList_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridList.CellValueChanged
        DGVhasChanged = True
    End Sub

    Private Sub DGridList_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGridList.CurrentCellDirtyStateChanged
        DGVhasChanged = True
    End Sub
    Private Sub FrmPayment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If DGVhasChanged = True Then
            Dim response As MsgBoxResult
            response = MsgBox("Do you want to save the changes?", MsgBoxStyle.YesNo)
            If response = MsgBoxResult.Yes Then
                cmdSave_Click(sender, e)
                DGVhasChanged = False
            End If
        End If

    End Sub
    Private Sub DGridList_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGridList.RowsRemoved
        calculateTotal()
    End Sub

    Private Sub mnuCopyPayDetail1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyPayDetail1.Click
        Dim h As Integer = 0
        Dim dRow As Integer = Val(DGridList.Tag)
        For h = 0 To DGridList.Rows.Count - 1
            If DGridList.Rows(dRow).Cells("PaymentDetails1").Value <> "" And Val(DGridList.Rows(h).Cells("Sn").Value) > 0 Then 'CustomerRefNo
                If DGridList.Rows(h).Cells("PaymentDetails1").Value = "" Then DGridList.Rows(h).Cells("PaymentDetails1").Value = DGridList.Rows(dRow).Cells("PaymentDetails1").Value
            End If
        Next h
    End Sub

    Private Sub mnuCopyPayDetail2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyPayDetail2.Click
        Dim h As Integer = 0
        Dim dRow As Integer = Val(DGridList.Tag)
        For h = 0 To DGridList.Rows.Count - 1
            If DGridList.Rows(dRow).Cells("PaymentDetails2").Value <> "" And Val(DGridList.Rows(h).Cells("Sn").Value) > 0 Then 'CustomerRefNo
                If DGridList.Rows(h).Cells("PaymentDetails2").Value = "" Then DGridList.Rows(h).Cells("PaymentDetails2").Value = DGridList.Rows(dRow).Cells("PaymentDetails2").Value
            End If
        Next h
    End Sub

    Private Sub TVList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TVList.MouseDown
        If e.Button = MouseButtons.Left Then

            Dim Test = TVList.HitTest(e.Location)
            If (Test.Location = TreeViewHitTestLocations.PlusMinus) Then
            Else
                Dim temp As TreeNode = TVList.GetNodeAt(New Point(e.X, e.Y))
                TVList.SelectedNode = temp
                Dim e1 As System.Windows.Forms.TreeViewEventArgs = Nothing
                TVList_AfterSelect(sender, e1)
            End If
        End If
    End Sub
    Private Function DoAdvanceSearch(ByVal theStr As String) As String
        On Error GoTo errh
        Dim j As Integer = 0
        DoAdvanceSearch = ""
        Dim NewStr As String = ""
        For j = 1 To Len(theStr)
            If Asc(Mid(theStr, j, 1)) < 32 Or Asc(Mid(theStr, j, 1)) > 126 Then
            Else
                NewStr = NewStr + Mid(theStr, j, 1)
            End If
        Next
        If theStr = NewStr Then
            DoAdvanceSearch = "@@%%%%%%DDTDTT!!!!!!!!!!!&&***********1223334344"
        Else
            DoAdvanceSearch = NewStr
        End If
        Exit Function
errh:
        MsgBox(Err.Description)
    End Function

    Private Sub mnuCleanData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCleanData.Click
        cleanData()
    End Sub
    Private Sub cleanData()

        On Error GoTo handler
        DGridList.Enabled = False
        Dim myStyle As New DataGridViewCellStyle
        myStyle.BackColor = Color.Yellow
        myStyle.ForeColor = Color.Red

        Dim i As Integer
        Dim j As Integer
        Dim h As Integer
        Dim errh As Integer = 0
        Dim AdvString As String = ""
        For i = 0 To DGridList.RowCount - 1
            For j = 0 To DGridList.Columns.Count - 1
                If UCase(DGridList.Columns(j).Name) <> "DEBITACCTNO" Then 'DebitAcctNo
                    DGridList.Item(j, i).Value = Trim(DGridList.Item(j, i).Value)
                    If Len(DGridList.Item(j, i).Value) > 0 Then
                        AdvString = DoAdvanceSearch(DGridList.Item(j, i).Value)
                        If AdvString = "@@%%%%%%DDTDTT!!!!!!!!!!!&&***********1223334344" Then
                        Else
                            DGridList.Item(j, i).Value = AdvString
                            DGridList.Item(j, i).Style = myStyle
                            errh = errh + 1
                        End If

                    End If
                End If
            Next j
        Next i

        If errh > 0 Then
            MsgBox(errh.ToString + " entries Cleaned")

            'Else
            '    MsgBox("Noting to Clean")

        End If

        CheckLength()

        RemoveCommas()

        CheckSpecialCondition()

        DGridList.Enabled = True
        Exit Sub
        Resume
handler:
        If Err.Number = 5 Or Err.Number = 13 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            DGridList.Enabled = True
        End If
    End Sub

    Private Sub CheckLength()
        Dim myStyle As New DataGridViewCellStyle
        myStyle.ForeColor = Color.LightSeaGreen

        On Error Resume Next
        Dim dCount As Integer = 0
        Dim ik As Integer = 0

        For ik = 0 To DGridList.RowCount - 1
            'leave out RefNo
            For i = 1 To DGridList.ColumnCount - 1
                If Len(DGridList.Item(i, ik).Value) > DGridList.Columns(i).FillWeight Then
                    DGridList.Item(i, ik).Style = myStyle
                    DGridList.Item(i, ik).Value = Mid(DGridList.Item(i, ik).Value, 1, DGridList.Columns(i).FillWeight)
                    dCount = dCount + 1
                End If
                'End If
            Next
        Next

        If dCount > 0 Then
            MsgBox(dCount.ToString + "Long Entry Found and Truncated", MsgBoxStyle.Information, strApptitle)
            'Else
            '    MsgBox("Successfull!! No Entry Found", MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub CheckSpecialCondition()
        Dim myStyle As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Crimson
        myStyle.BackColor = Color.MediumOrchid '.Cornsilk

        On Error Resume Next
        Dim dCount As Integer = 0
        Dim ik As Integer = 0

        For ik = 0 To DGridList.RowCount - 1
            'leave out RefNo

            If Len(DGridList.Item("SwiftCode", ik).Value) <> 8 And Len(DGridList.Item("SwiftCode", ik).Value) <> 11 Then
                DGridList.Item("SwiftCode", ik).Style = myStyle
                dCount = dCount + 1
            End If
            If DGridList.Item("CustomerRefNo", ik).Value = "" Then
                DGridList.Item("CustomerRefNo", ik).Style = myStyle
                dCount = dCount + 1
            End If
            If DGridList.Item("tName", ik).Value = "" Then
                DGridList.Item("tName", ik).Style = myStyle
                dCount = dCount + 1
            End If
            If DGridList.Item("Account", ik).Value = "" Then
                DGridList.Item("Account", ik).Style = myStyle
                dCount = dCount + 1
            End If
            If DGridList.Item("Address1", ik).Value = "" Then
                DGridList.Item("Address1", ik).Style = myStyle
                dCount = dCount + 1
            End If
            If DGridList.Item("BeneficiaryCountry", ik).Value = "" Then
                DGridList.Item("BeneficiaryCountry", ik).Style = myStyle
                dCount = dCount + 1
            End If
            If DGridList.Item("Bank1", ik).Value = "" Then
                DGridList.Item("Bank1", ik).Style = myStyle
                dCount = dCount + 1
            End If
            If DGridList.Item("DebitAcctNo", ik).Value = "" Then
                DGridList.Item("DebitAcctNo", ik).Style = myStyle
                dCount = dCount + 1
            End If
            If DGridList.Item("PaymentDetails1", ik).Value = "" Then
                DGridList.Item("PaymentDetails1", ik).Style = myStyle
                dCount = dCount + 1
            End If

        Next

        If dCount > 0 Then
            canSave = False
            MsgBox(dCount.ToString + " Special criteria failed", MsgBoxStyle.Information, strApptitle)
            'Else
            '    MsgBox("Successfull!! No Entry Found", MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub RemoveCommas()
        Dim myStyle As New DataGridViewCellStyle
        myStyle.BackColor = Color.Yellow
        myStyle.ForeColor = Color.Red

        Dim i As Integer
        Dim j As Integer
        Dim errh As Integer = 0
        Dim AdvString As String = ""
        For i = 0 To DGridList.RowCount - 1
            For j = 0 To DGridList.Columns.Count - 1

                If UCase(DGridList.Columns(j).Name) <> "DEBITACCTNO" Then 'DebitAcctNo
                    If DGridList.Item(j, i).Value Is Nothing Or IsDBNull(DGridList.Item(j, i).Value) Then

                    Else


                        DGridList.Item(j, i).Value = Trim(DGridList.Item(j, i).Value)
                        If Len(DGridList.Item(j, i).Value) > 0 Then
                            AdvString = DGridList.Item(j, i).Value

                            Dim jk As Integer = 0
                            Dim NewStr As String = ""
                            For jk = 1 To Len(AdvString)
                                If Asc(Mid(AdvString, jk, 1)) = 44 Or Asc(Mid(AdvString, jk, 1)) = 45 Then ' , and -

                                ElseIf Asc(Mid(AdvString, jk, 1)) = 46 And UCase(DGridList.Columns(j).Name) <> "AMOUNT" Then 'for fullstop .

                                Else
                                    NewStr = NewStr + Mid(AdvString, jk, 1)
                                End If
                            Next
                            'If NewStr = "" Then
                            'Else
                            If AdvString = NewStr Then
                            Else
                                DGridList.Item(j, i).Value = NewStr
                                DGridList.Item(j, i).Style = myStyle
                                errh = errh + 1
                            End If
                            'End If
                        End If
                    End If

                End If
            Next j
        Next i

        If errh > 0 Then
            MsgBox(errh.ToString + "comma entries removed")
            'Else
            '    MsgBox("Noting to Clean")

        End If

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Or Err.Number = 13 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub mnuGenerateCustomerRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGenerateCustomerRef.Click
        On Error Resume Next
        Dim h As Integer = 0
        Dim g As Integer = 0
        Dim BeneRefNo As String = ""
        Dim dRow As Integer = Val(DGridList.Tag)
        Dim selectedCellContent As String = ""
        selectedCellContent = DGridList.Rows(dRow).Cells("CustomerRefNo").Value
        For h = 0 To DGridList.Rows.Count - 1
            g = h + 1
            ' If DGridList.Rows(dRow).Cells("CustomerRefNo").Value <> "" And Val(DGridList.Rows(h).Cells("Sn").Value) > 0 Then 'CustomerRefNo
            If DGridList.Rows(h).Cells("CustomerRefNo").Value = "" And selectedCellContent <> "" Then
                DGridList.Rows(h).Cells("CustomerRefNo").Value = selectedCellContent + Trim(Str(g))
            Else
                DGridList.Item("CustomerRefNo", h).Value = DGridList.Item("CustomerRefNo", h).Value + Trim(Str(g))
            End If

            'End If

        Next h
    End Sub

    Private Sub ClearCustomerRefNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearCustomerRefNoToolStripMenuItem.Click
        Dim h As Integer = 0

        For h = 0 To DGridList.Rows.Count - 1
            DGridList.Rows(h).Cells("CustomerRefNo").Value = ""
        Next h
    End Sub

    Private Sub mnuCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCSV.Click
        Export2Excel(LastMandateNo)
    End Sub

    Private Sub mnuEXCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEXCEL.Click
        Export2Excel_MSExcel(LastMandateNo)
    End Sub

    Private Sub myCloneSelectedRows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myCloneSelectedRows.Click
        Dim row As New DataGridViewRow()
        Dim g As Integer = DGridList.Rows.Count

        Dim i As Integer = 0
        Do While i < DGridList.Rows.Count
            If DGridList.Rows(i).Selected = True Then
                row = DirectCast(DGridList.Rows(i).Clone(), DataGridViewRow)
                Dim intColIndex As Integer = 0
                For Each cell As DataGridViewCell In DGridList.Rows(i).Cells
                    row.Cells(intColIndex).Value = cell.Value
                    intColIndex += 1
                Next cell
                g += 1

                row.Cells(1).Value = g
                DGridList.Rows.Add(row)
            End If
            i += 1
        Loop
        DGridList.AllowUserToAddRows = False
        DGridList.Refresh()

    End Sub

    Private Sub mnuGetTotalOfSelectedRows_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGetTotalOfSelectedRows.Click
        Dim dsum As Double = 0
        For i As Integer = 0 To DGridList.Rows.Count - 1
            If DGridList.Rows(i).Selected = True Then
                dsum = dsum + Convert.ToDouble(DGridList("amount", i).Value)
            End If
        Next i
        MessageBox.Show("Sum is = " & dsum.ToString("N"), "Selected row total")

    End Sub
End Class