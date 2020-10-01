Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmVoidPayment
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
    Public MandateNo As String
    Public clayout As Integer
    Public ReturnSn As Integer
 
    Private Sub FrmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AppHeader1.lblForm.Text = "Void Payment"

        'Me.DGridList.DataSource = bindingSource
        ' DGridList.AutoGenerateColumns = False

        DGridList.Rows.Clear()

        'LoadMandateNo()


 
        cboMandateNo.Text = MandateNo

        
        oLoadPayments(MandateNo)

        getTotals()

        applyGridTheme(DGridList)

        DGridList.AutoGenerateColumns = False

        DGridList.ReadOnly = False
        DGridList.AllowUserToDeleteRows = False
    
        For i = 0 To DGridList.RowCount - 1
            DGridList.Columns(i).ReadOnly = True
        Next
        DGridList.Columns("Void").ReadOnly = False

        DGridList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub
    Private Sub DGridList_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridList.CellEndEdit
        On Error GoTo errhdl
        Dim sumV As Double = 0
        If DGridList.Columns(e.ColumnIndex).Name = "Void" Then
          getTotals

        End If

        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Sub getTotals()
        On Error GoTo errhdl
        Dim sumV As Double = 0
        Dim sumM As Double = 0
        Dim Vcount As Integer = 0
        For i = 0 To DGridList.RowCount - 1
            If DGridList.Item("Void", i).Value = True Then
                sumV = sumV + DGridList.Item("Amount", i).Value
                Vcount = Vcount + 1
            End If
            sumM = sumM + DGridList.Item("Amount", i).Value
        Next
        lblVoid.Text = Vcount
        lblCount.Text = DGridList.RowCount
        lblVoidTotal.Text = Format(sumV, "standard")
        lblMandateTotal.Text = Format(sumM, "standard")
        lblMadateBalance.Text = Format(sumM - sumV, "standard")

        Exit Sub
        Resume
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
 
        Dim i As Integer

        cnSQL.Open()

        Dim myTrans As SqlClient.SqlTransaction
        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        For i = 0 To DGridList.Rows.Count - 1
            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "UpdatePayment4Void"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@dIndex", DGridList.Item("dIndex", i).Value)
            cmSQL.Parameters.AddWithValue("@MandateNo", cboMandateNo.Text)
            cmSQL.Parameters.AddWithValue("@Void", IIf(DGridList.Item("Void", i).Value Is Nothing, 0, IIf(DGridList.Item("Void", i).Value = False, 0, 1)))
            cmSQL.ExecuteNonQuery()
        Next

        myTrans.Commit()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        MsgBox("Successful", vbInformation, strApptitle)

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        myTrans.Rollback()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub DGridList_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DGridList.CellContentClick

        DGridList.Tag = e.RowIndex

        Exit Sub
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
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
        Dim chkIfSchIncluded As Boolean = False
        cmSQL.CommandText = "FetchPayment"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@MandateNo", MandateNo)
        drSQL = cmSQL.ExecuteReader()

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
            DGridList.Item("Amount", j).Value = drSQL.Item("Amount")
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
            DGridList.Item("dIndex", j).Value = drSQL.Item("dIndex")

            On Error Resume Next
            DGridList.Item("Void", j).Value = drSQL.Item("Void")
            On Error GoTo errhdl

            If drSQL.Item("Source") = "SCHOOL" Then chkIfSchIncluded = True

            j = j + 1
            dtpDate.Text = drSQL.Item("PayValueDate")
       
        Loop

        drSQL.Close()

        If Trim(cboMandateNo.Text) = "" Then cboMandateNo.Text = MandateNo


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

        dtpDate.Focus()

        Exit Sub
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
 
End Class