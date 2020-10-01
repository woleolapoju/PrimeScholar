Imports System.Data.SqlClient
Public Class FrmAdvSearch
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Private Sub FrmCurrency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppHeader1.lblForm.Text = "Search"
        Me.DbGrid.DataSource = bindingSource1
        DbGrid.AutoGenerateColumns = False

        cboCriteria.SelectedIndex = 0

        applyGridTheme(DbGrid)
        DbGrid.ReadOnly = True

        'DbGrid.RowHeadersVisible = False

    End Sub
    Private Sub GetData(ByVal selectCommand As String)

        Try

            dataAdapter = New SqlDataAdapter(selectCommand, strConnect)
            Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataAdapter.Fill(table)
            Me.bindingSource1.DataSource = table

            lblCount.Text = DbGrid.Rows.Count

        Catch ex As SqlException
            ' MsgBox(ex.Message, MsgBoxStyle.Information, strApptitle)
            MsgBox("Invalid Search String", MsgBoxStyle.Information, strApptitle)

        End Try

    End Sub

   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        On Error GoTo handler
        Select Case cboCriteria.Text

            Case Is = "BENEFICIARY NAME"
                GetData("select * from Payment WHERE [Name] like '%" & tFilter.Text & "%' ORDER BY MandateNo")
            Case Is = "BANK"
                GetData("select * from Payment WHERE [BankName] like '%" & tFilter.Text & "%' ORDER BY MandateNo")
            Case Is = "AMOUNT"
                GetData("select * from Payment WHERE [Amount] =" & tFilter.Text & " ORDER BY MandateNo")
            Case Is = "PAYMENT DETAILS"
                GetData("select * from Payment WHERE [PayDetails1]+[PayDetails2] like '%" & tFilter.Text & "%' ORDER BY MandateNo")
            Case Is = "CUSTOMER REFNo"
                GetData("select * from Payment WHERE [CustomerRefNo] like '%" & tFilter.Text & "%' ORDER BY MandateNo")
            Case Is = "CURRENCY"
                GetData("select * from Payment WHERE [Currency] like '%" & tFilter.Text & "%' ORDER BY MandateNo")

        End Select

        Exit Sub
        Resume
handler:
        MsgBox("Invalid Search String", strApptitle)
    End Sub
    Private Sub tFilter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSearch_Click(sender, e)
        End If
    End Sub

    Private Sub tFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFilter.TextChanged

    End Sub

    Private Sub DGridList_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DbGrid.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        DbGrid.Tag = e.RowIndex

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewLinkColumn AndAlso e.RowIndex >= 0 Then

            On Error GoTo errhdl
            If senderGrid.Columns(e.ColumnIndex).Name = "MandateNo" Then
                Dim ChildForm As New FrmPayment
                ChildForm.cboMandateNo.Text = DbGrid.Item(0, e.RowIndex).Value
                ChildForm.MandateNo = DbGrid.Item(0, e.RowIndex).Value
                ChildForm.dIndex = DbGrid.Item("dIndex", e.RowIndex).Value
                ChildForm.cmdSave.Enabled = False

                ChildForm.ShowDialog()
            End If

        End If
        Exit Sub
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

End Class