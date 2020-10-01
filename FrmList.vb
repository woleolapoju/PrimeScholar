Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmList

    Public frmParent As Object
    Public tSelection As String
    Public qryPrm As String = ""
    Public colIndex As Integer = 0
    Dim pstrCaption() As String
    Dim pintWidth() As Integer
    Dim plistQuery As String
    Private bindingSource As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Public listQuery As String
    Private Sub FrmList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        DGrid.DataSource = bindingSource

        DGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        DGrid.AutoGenerateColumns = True

        cboCriteria.SelectedIndex = 1

        LoadLvList()
        applyGridTheme(DGrid)
        On Error Resume Next
        DGrid.Columns(1).Width = 220
        DGrid.Columns(4).Width = 220
      

    End Sub
    Public Sub LoadLvList()
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cmdOk.Visible = True
        cmSQL.CommandType = CommandType.StoredProcedure
        Select Case listQuery
            Case "GetGeneratedPayPeriod"
                cmSQL.CommandText = "SELECT DISTINCT PayPeriod FROM Payment ORDER BY PayPeriod DESC"
                cmSQL.CommandType = CommandType.Text
            Case Is = "FillActiveSchool"
                cmSQL.CommandText = "SELECT Sn, SchName, SchAddress, SchCountry, SchCity FROM RegisterSch ORDER BY SchCountry,SchName"
                cmSQL.CommandType = CommandType.Text
            Case Is = "FillActiveStudent"
                cmSQL.CommandText = "SELECT Sn, [Name],IDNumber, SchName, SchCountry, SchCity FROM Register ORDER BY SchCountry,SchName"
                cmSQL.CommandType = CommandType.Text
            Case Is = "FillActiveStaff"
                cmSQL.CommandText = "SELECT Sn, [Name],IDNumber, SchName, SchCountry, SchCity FROM RegisterStaff ORDER BY SchCountry,SchName"
                cmSQL.CommandType = CommandType.Text
            Case Is = "FillActiveStakeholders"
                cmSQL.CommandText = "SELECT Sn, [Name],IDNumber, SchName, SchCountry, SchCity FROM RegisterStakeholders ORDER BY SchCountry,SchName"
                cmSQL.CommandType = CommandType.Text
        End Select

        cnSQL.Open()
     
        dataAdapter = New SqlDataAdapter(cmSQL) '"AC_FetchAllPaymentVouchers", strConnect)
        Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        Me.dataAdapter.Fill(table)
        Me.bindingSource.DataSource = table

        cmSQL.Dispose()
        lblCount.Text = DGrid.Rows.Count
        SelColumn.Minimum = 1
        SelColumn.Maximum = DGrid.Columns.Count

        formatGrid()

   

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Sub formatGrid()

        Dim myStyle1 As New DataGridViewCellStyle
        myStyle1.Format = "N2"
        myStyle1.Alignment = DataGridViewContentAlignment.BottomRight

        For i = 0 To DGrid.ColumnCount - 1
            If DGrid.Columns(i).ValueType.FullName = "System.Decimal" Then
                ' MsgBox(DGrid.Columns(i).ValueType.FullName)
                DGrid.Columns(i).DefaultCellStyle = myStyle1
            End If
        Next
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Select Case tSelection
            Case "GetGeneratedPayPeriod"
                frmParent.ReturnPayperiod = DGrid.Tag
            Case Is = "FillActiveSchool"
                frmParent.ReturnSchoolID = DGrid.Tag
            Case Is = "FillActiveStudent"
                frmParent.ReturnSn = DGrid.Tag
                frmParent.ReturnIDNo = GrpQuery.Tag 'lvList.SelectedItems(0).SubItems(2).Text
                frmParent.ReturnProxySource = IIf(RadStaff.Checked, "STAFF", IIf(radStakeHolders.Checked, "STAKEHOLDERS", "STUDENT"))
            Case Is = "FillActiveStaff"
                frmParent.ReturnSn = DGrid.Tag
                frmParent.ReturnIDNo = GrpQuery.Tag ' lvList.SelectedItems(0).SubItems(2).Text
                frmParent.ReturnProxySource = IIf(RadStaff.Checked, "STAFF", IIf(radStakeHolders.Checked, "STAKEHOLDERS", "STUDENT"))
            Case Is = "FillActiveStakeholders"
                frmParent.ReturnSn = DGrid.Tag
                frmParent.ReturnIDNo = GrpQuery.Tag 'lvList.SelectedItems(0).SubItems(2).Text
                frmParent.ReturnProxySource = IIf(RadStaff.Checked, "STAFF", IIf(radStakeHolders.Checked, "STAKEHOLDERS", "STUDENT"))
        End Select
        DGrid.Tag = ""
        Me.Close()

        Exit Sub
handler:
        If Err.Number = 5 Then
            MsgBox("Please select an entry", vbInformation, strApptitle)
        ElseIf Err.Number = 438 Then
            Resume Next
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        On Error GoTo errhdl
        'Dim myStyle As New DataGridViewCellStyle
        'myStyle.ForeColor = Color.Black

        Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        Me.dataAdapter.Fill(table)
        Me.bindingSource.DataSource = table

        'DGrid.DataSource = bindingSource

        'DGrid.Refresh()
        tFilter.Text = ""
        'Dim x As Integer = 0
        'Dim y As Integer = 0
        'While x < DGrid.Rows.Count

        '    While y < DGrid.Rows(x).Cells.Count
        '        DGrid.Item(y, x).Style = myStyle
        '        y = y + 1
        '    End While

        '    'DGrid.Rows(x).DefaultCellStyle = myStyle
        '    x = x + 1
        'End While
        SelColumn.Maximum = DGrid.Columns.Count

        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        PassFilter(DGrid, tFilter.Text)
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Private Sub tFilter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdFilter_Click(sender, e)
        End If
    End Sub
    Private Sub PassFilter(ByRef datagridview As DataGridView, ByVal strFilter As String)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim jk As Integer = 0
        Dim kj As Integer
        Dim wr As Integer = 0
        Dim containStr As Boolean = False
        ' Row indexes we'll remove later on.
        Dim deleteIndexList As List(Of Integer) = New List(Of Integer)

        Dim strNewFilter As String = ""
        Select Case cboCriteria.Text
            Case Is = "="
                strNewFilter = strFilter
            Case Is = "<>"
                strNewFilter = strFilter
            Case Is = "Containing"
                strNewFilter = "*" + strFilter + "*"
            Case Is = "Start With"
                strNewFilter = strFilter + "*"
            Case Is = "End With"
                strNewFilter = "*" + strFilter
        End Select
        While i < datagridview.Rows.Count
            j = 0
            containStr = False

            If chkIgnore.Checked = True Then
                jk = datagridview.Rows(i).Cells.Count - 1
                kj = 0
            Else
                kj = SelColumn.Value - 1
                jk = SelColumn.Value - 1
            End If
            For j = kj To jk
                If Not datagridview.Item(j, i).Value Is DBNull.Value Or Nothing Then
                    If cboCriteria.Text = "<>" Then
                        If LCase(datagridview.Item(j, i).Value) <> LCase(strNewFilter) Then
                            containStr = True
                            wr = wr + 1
                            Exit For
                        End If
                    Else
                        If LCase(datagridview.Item(j, i).Value) Like LCase(strNewFilter) Then
                            containStr = True
                            wr = wr + 1
                            Exit For
                        End If
                    End If
                End If
            Next j
            If Not containStr Then
                ' Don't remove rows here or your row indexes will get out of whack!
                ' datagridview.Rows.RemoveAt(i)
                deleteIndexList.Add(i)
            End If
            i = i + 1
        End While
        ' Remove rows by reversed row index order (highest removed first) to keep the indexes in whack.
        deleteIndexList.Reverse()
        For Each idx As Integer In deleteIndexList
            datagridview.Rows.RemoveAt(idx)
        Next
        lblCount.Text = wr
    End Sub
    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        On Error GoTo handler
        Dim x As Integer = 0

        Dim myStyle As New DataGridViewCellStyle
        Dim myStyle1 As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Red
        myStyle1.ForeColor = Color.Black
        Dim ij As Integer = 0
        Dim jk As Integer = 0
        Dim kj As Integer
        Dim strNewFilter As String = ""
        Select Case cboCriteria.Text
            Case Is = "="
                strNewFilter = tFilter.Text
            Case Is = "Containing"
                strNewFilter = "*" + tFilter.Text + "*"
            Case Is = "Start With"
                strNewFilter = tFilter.Text + "*"
            Case Is = "End with"
                strNewFilter = "*" + tFilter.Text
        End Select

        While x < DGrid.Rows.Count
            Dim y As Integer = 0
            If chkIgnore.Checked = True Then
                jk = DGrid.Rows(x).Cells.Count - 1
                kj = 0
            Else
                kj = SelColumn.Value - 1
                jk = SelColumn.Value - 1
            End If
            For y = kj To jk
                If Not DGrid.Item(y, x).Value Is DBNull.Value Or Nothing Then
                    If LCase(DGrid.Item(y, x).Value) Like LCase(strNewFilter) Then
                        DGrid.Item(y, x).Style = myStyle
                        ij = ij + 1
                    End If
                End If
            Next y
            x = x + 1
        End While
        If ij = 0 Then
            MessageBox.Show("Match Not Found!")
        Else
            MessageBox.Show("(" + ij.ToString + ") Match Found")
        End If

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub mnuExportToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExportToExcel.Click
        On Error GoTo handler
        Dim oXL As Object
        oXL = CreateObject("Excel.Application")
        oXL.Visible = True
        oXL.Workbooks.Add()

        oXL.Sheets(1).Select()

        oXL.Visible = True

        ' Format A1:D1 as bold, vertical alignment = center.
        With oXL.Sheets(1).Range("A1", "AZ1")
            .Font.Bold = True
            ' .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        Dim jk As Integer = 0
        For j = 0 To DGrid.ColumnCount - 1
            oXL.Cells(1, j + 1) = DGrid.Columns(j).Name.ToString()
        Next

        For i = 0 To DGrid.RowCount - 1
            If DGrid.Rows(i).Selected = True Then
                For j = 0 To DGrid.ColumnCount - 1
                    If IsNumeric(DGrid(j, i).Value) Then
                        oXL.Cells(jk + 2, j + 1).NumberFormat = "@"
                        oXL.Cells(jk + 2, j + 1) = DGrid(j, i).Value
                    Else
                        oXL.Cells(jk + 2, j + 1) = DGrid(j, i).Value
                    End If

                Next
                jk = jk + 1
            End If
        Next
        ' Make sure Excel is visible and give the user control
        ' of Excel's lifetime.

        oXL.UserControl = True

        ' Make sure that you release object references.
        oXL.Quit()
        oXL = Nothing

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub mnuCopyToClipboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyToClipboard.Click

        DGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText

        If DGrid.GetCellCount(DataGridViewElementStates.Selected) > 0 Then

            Try

                ' Add the selection to the clipboard.
                Clipboard.SetDataObject(DGrid.GetClipboardContent())

                ' Replace the text box contents with the clipboard text.
                'Me.TextBox1.Text = Clipboard.GetText()
                MsgBox("Successfull!!")
            Catch ex As System.Runtime.InteropServices.ExternalException
                MsgBox("The Clipboard could not be accessed. Please try again.")
            End Try

        End If
    End Sub
    
    Private Sub DGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGrid.CellClick
        On Error Resume Next
        DGrid.Tag = DGrid.Item(0, e.RowIndex).Value
        Me.Tag = DGrid.Item(1, e.RowIndex).Value
        GrpQuery.Tag = DGrid.Item(2, e.RowIndex).Value
        cboCriteria.Tag = DGrid.Item(3, e.RowIndex).Value
        SelColumn.Value = e.ColumnIndex + 1
        tFilter.Text = DGrid.Item(e.ColumnIndex, e.RowIndex).Value

    End Sub
    Private Sub DGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGrid.DoubleClick
        On Error Resume Next
        If DGrid.Tag = "" Then Exit Sub
        cmdOk_Click(sender, e)
        DGrid.Tag = ""
    End Sub

    Private Sub DGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGrid.CellContentClick

    End Sub

    Private Sub RadStudent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadStudent.CheckedChanged

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

        With Me
            .tSelection = "FillActiveStudent"
            .listQuery = "FillActiveStudent"
        End With
        LoadLvList()
    End Sub

    Private Sub RadStaff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadStaff.CheckedChanged
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

        With Me
            .tSelection = "FillActiveStaff"
            .listQuery = "FillActiveStaff"
        End With
        LoadLvList()
    End Sub

    Private Sub radStakeHolders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radStakeHolders.CheckedChanged
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

        With Me
            .tSelection = "FillActiveStakeholders"
            .listQuery = "FillActiveStakeholders"
        End With
        LoadLvList()
    End Sub
End Class

