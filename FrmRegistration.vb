Imports System.Data.Sqlclient
Imports System.IO
Public Class FrmRegistration
    Dim ReturnID As String
    Dim selectedTVQry As String
    Dim OnlyFirstItem As Boolean = False
    Private bindingSource As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim imageIndex As Integer = 0
    Public ReturnSchoolID As Integer
    Dim StoredX As Long
    Dim StoredY As Long
    Dim j As Integer = 0
    Private Sub FrmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        j = 0

        'FillBank()
        DGridList.Columns("cmdSchoolID").DisplayIndex = DGridList.Columns("SchoolID").DisplayIndex - 1
        AppHeader1.lblForm.Text = "Student Beneficiary Information"

        DGridList.AutoGenerateColumns = False
        Me.DGridList.DataSource = bindingSource
        ' DGridList.AutoGenerateColumns = False

        'oLoadDbgrid()

        cboCriteria.SelectedIndex = 1

        LoadScholarType()
        LoadCurrencyType()

        ' DGridList.Columns("cmdSchoolID").DisplayIndex = 20 ' DGridList.Columns("SchoolID").DisplayIndex - 1

        cboCountry.Focus()

        applyGridTheme(DGridList)

        DGridList.ReadOnly = Not GetUserAccessDetails("Edit Scholar", False) '=false
        DGridList.AllowUserToAddRows = GetUserAccessDetails("Add New Scholar", False)
        cmdNew.Enabled = GetUserAccessDetails("Add New Scholar", False)

        DGridList.AllowUserToDeleteRows = GetUserAccessDetails("Delete Scholar", False)
        DGridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGridList.Columns("Sn").ReadOnly = True

        DGridList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub
    Private Sub FillSchCountry()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboCountry.Items.Clear()

        'cmSQL.CommandText = "SELECT DISTINCT SchCountry  FROM RegisterSch ORDER BY SchCountry"

        cboCountry.Items.Add("ALL")

        If cScholarType.Text = "ALL" Then
            cmSQL.CommandText = "SELECT DISTINCT Country FROM Register ORDER BY Country"
        Else
            cmSQL.CommandText = "SELECT DISTINCT Country FROM Register WHERE StudyProgramme='" & cScholarType.Text & "' ORDER BY [Country]"
        End If

        ' cmSQL.CommandText = "SELECT DISTINCT Country FROM Register ORDER BY Country"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboCountry.Items.Add(drSQL.Item("Country").ToString)
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
    Private Sub oLoadDbgrid()
        On Error GoTo errhdl
        Dim i As Integer

        'DGridList.DataSource = bindingSource
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim strQry1 As String = ""
        Dim strCamp As String = ""
        Dim strQry As String = "SELECT * FROM Register "
        If cboCountry.Text <> "ALL" Then strQry1 = " WHERE Country ='" & cboCountry.Text & "'"
        If cSchool.Text <> "ALL" Then strQry1 = strQry1 + IIf(strQry1 = "", " WHERE ", " AND ") + " SchName ='" & cSchool.Text & "'"
        If cScholarType.Text <> "ALL" Then strQry1 = strQry1 + IIf(strQry1 = "", " WHERE ", " AND ") + " StudyProgramme ='" & cScholarType.Text & "'"


        'If strQry1 <> "" Then
        strQry = strQry + strQry1 + " ORDER BY Sn,SchCountry,SchName"
        'If strQry1 = "" Then
        '    cmSQL.CommandText = "FetchAllRegister"
        '    cmSQL.CommandType = CommandType.StoredProcedure
        'Else
        cmSQL.CommandText = strQry
        cmSQL.CommandType = CommandType.Text
        'End If
        dataAdapter = New SqlDataAdapter(cmSQL)
        Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        Me.dataAdapter.Fill(table)
        Me.bindingSource.DataSource = table

        Dim myStyle As New DataGridViewCellStyle
        Dim myStyle1 As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Red
        myStyle1.ForeColor = Color.Black
     
        lblCount.Text = GetCount()


        ' DGridList.Columns(6).HeaderText = "Bank Code"

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
        On Error Resume Next
        DGridList.Tag = DGridList.Item(0, e.RowIndex).Value
        SelColumn.Value = e.ColumnIndex + 1
        DGridList.Tag = e.RowIndex ' e.ColumnIndex

        If chkMultiFilter.Checked = False Then
            tFilter.Text = DGridList.Item(e.ColumnIndex, e.RowIndex).Value
        Else
            tFilter.Text = tFilter.Text + IIf(tFilter.Text = "", "", ",") + DGridList.Item(e.ColumnIndex, e.RowIndex).Value
        End If

    End Sub
    Private Sub oLoadSchName()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cSchool.Items.Clear()
        cSchool.Items.Add("ALL")

        If cScholarType.Text = "ALL" Then
            If cboCountry.Text = "ALL" Then
                cmSQL.CommandText = "SELECT DISTINCT SchName FROM Register ORDER BY SchName"
            Else
                cmSQL.CommandText = "SELECT DISTINCT SchName FROM Register WHERE Country='" & cboCountry.Text & "' ORDER BY [SchName]"
            End If
        Else
            If cboCountry.Text = "ALL" Then
                cmSQL.CommandText = "SELECT DISTINCT SchName FROM Register  WHERE StudyProgramme='" & cScholarType.Text & "' ORDER BY SchName"
            Else
                cmSQL.CommandText = "SELECT DISTINCT SchName FROM Register WHERE StudyProgramme='" & cScholarType.Text & "' AND Country='" & cboCountry.Text & "' ORDER BY [SchName]"
            End If
        End If

        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            cSchool.SelectedIndex = 0
            Exit Sub
        End If

        Do While drSQL.Read
            cSchool.Items.Add(ChkNull(drSQL.Item("SchName")))
        Loop


        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()


        cSchool.SelectedIndex = 0
        'oLoadDbgrid()



        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCountry.SelectedIndexChanged
        oLoadSchName()
    End Sub
    Private Sub cSchool_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cSchool.SelectedIndexChanged
        oLoadDbgrid()
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
        j = 0

        Me.dataAdapter.Update(CType(bindingSource.DataSource, DataTable))
        MsgBox("Update successfull", MsgBoxStyle.Information, strApptitle)


        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()
        'cmSQL.CommandText = "UPDATE Register SET Camp='' WHERE Camp is null"
        'cmSQL.CommandType = CommandType.Text

        'cmSQL.ExecuteNonQuery()

        'cmSQL.CommandText = "UPDATE Register SET SortCode='' WHERE SortCode is null"
        'cmSQL.CommandType = CommandType.Text
        'cmSQL.ExecuteNonQuery()

        cmSQL.CommandText = "UPDATE Register SET Country='NIGERIA' WHERE Country is null OR Country=''"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.CommandText = "UPDATE Register SET StudyProgramme='' WHERE StudyProgramme is null"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.CommandText = "UPDATE Register SET Active=1 WHERE Active is null"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()


        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        oLoadDbgrid()

        Exit Sub
        Resume
handler:
        If Err.Description Like "*Concurrency violation*" And J <= 2 Then
            Resume
            J = J + 1
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If

    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        If PanFilter.Visible = False Then cmdSave.Enabled = True
        oLoadDbgrid()
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        If Not DGridList.IsCurrentCellInEditMode Then
            DGridList.Focus()
            DGridList.CurrentCell = DGridList.Rows(DGridList.Rows.Count - 1).Cells("tName")
            '    DGridList.Rows(DGridList.Rows.Count - 1).Cells("Sn").Value = GetNewSn()
            DGridList.Focus()
            'SendKeys.Send("{BS}")

            'SendKeys.Send("11")

            DGridList.Item("TheActive", DGridList.Rows.Count - 1).Value = True
            If cScholarType.Text <> "ALL" Then DGridList.Item("StudyProgramme", DGridList.Rows.Count - 1).Value = cScholarType.Text
            If cboCountry.Text <> "ALL" Then DGridList.Item("Country", DGridList.Rows.Count - 1).Value = cboCountry.Text
            DGridList.Item("Currency", DGridList.Rows.Count - 1).Value = "USD"


        End If
    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Function GetCount() As Integer
        GetCount = 0
        Dim j As Integer = -1
        Dim i As Integer
        For i = 0 To DGridList.Rows.Count - 1
            j = j + 1
        Next
        GetCount = j
    End Function
    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        Dim i As Integer
        For i = 0 To DGridList.RowCount - 1
            DGridList.Item("Active", i).Value = IIf(chkSelectAll.Checked, 1, 0)
        Next
    End Sub

    Private Sub cmdCleanUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCleanUp.Click
        On Error GoTo handler
        DGridList.Enabled = False
        Dim i As Integer
        For i = 0 To DGridList.RowCount - 1
            If Asc(DGridList.Item(1, i).Value) <= 31 Then DGridList.Item(1, i).Value = Mid(DGridList.Item(1, i).Value, 2) 'Name
            If Asc(DGridList.Item(2, i).Value) <= 31 Then DGridList.Item(2, i).Value = Mid(DGridList.Item(2, i).Value, 2) 'State
            If Asc(DGridList.Item(3, i).Value) <= 31 Then DGridList.Item(3, i).Value = Mid(DGridList.Item(3, i).Value, 2) 'Camp
            If Asc(DGridList.Item(4, i).Value) <= 31 Then DGridList.Item(4, i).Value = Mid(DGridList.Item(4, i).Value, 2) 'Bank
            If Asc(DGridList.Item(5, i).Value) <= 31 Then DGridList.Item(5, i).Value = Mid(DGridList.Item(5, i).Value, 2) 'BankAcctNo
            If Asc(DGridList.Item(6, i).Value) <= 31 Then DGridList.Item(6, i).Value = Mid(DGridList.Item(6, i).Value, 2) 'SortCode
            If Asc(DGridList.Item(7, i).Value) <= 31 Then DGridList.Item(7, i).Value = Mid(DGridList.Item(7, i).Value, 2) 'StopPay
            If Asc(DGridList.Item(8, i).Value) <= 31 Then DGridList.Item(8, i).Value = Mid(DGridList.Item(8, i).Value, 2) 'Remark
            DGridList.Item(1, i).Value = Trim(DGridList.Item(1, i).Value)
        Next

        newCleanSpace()

        DGridList.Enabled = True
        MsgBox("Successfull")

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

    Sub newCleanSpace()
        On Error GoTo handler
        Dim FountIt As Boolean
        Dim i As Integer
        Dim jk As Integer = 0
DoItAgain:
        FountIt = False
        For i = 0 To DGridList.RowCount - 1
            If Asc(DGridList.Item(1, i).Value) <= 31 Then DGridList.Item(1, i).Value = Mid(DGridList.Item(1, i).Value, 2) 'Name
            jk = 0
            jk = InStr(DGridList.Item(1, i).Value, "  ")
            If jk > 0 Then
                DGridList.Item(1, i).Value = Trim(Mid(DGridList.Item(1, i).Value, 1, jk - 1)) + " " + Trim(Mid(DGridList.Item(1, i).Value, jk))
                DGridList.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                FountIt = True
            End If
        Next

        If FountIt = True Then GoTo DoItAgain

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

    Private Sub DGridList_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles DGridList.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        'DGridList.Tag = ""

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then

            On Error GoTo errhdl
            Dim strValue As String
            Dim strPrompt As String
            Dim strCaption(5) As String
            Dim intWidth(5) As Integer
            strCaption(0) = "School ID"
            intWidth(0) = 50
            strCaption(1) = "School Name"
            intWidth(1) = 200
            strCaption(2) = "School Country"
            intWidth(2) = 100
            strCaption(3) = "School Address"
            intWidth(3) = 200
            strCaption(4) = "School City"
            intWidth(4) = 100

            With FrmList
                .frmParent = Me
                .tSelection = "FillActiveSchool"
                .listQuery = "FillActiveSchool"
                .Text = "List of Active Schools"
                .TopMost = True
                .ShowDialog()
            End With
            If ReturnSchoolID = 0 Then Exit Sub
            FillSchool(ReturnSchoolID, e.RowIndex, e.ColumnIndex)
            'txt.Text = Format(CDate(ReturnPayperiod), "MMM-yyyy")

            'txt.Focus()


        End If
        Exit Sub
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub FillSchool(ByVal SchoolID As Integer, ByVal dRow As Integer, ByVal dColumn As Integer)
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        'cmSQL.CommandText = "SELECT DISTINCT Camp FROM StatesAndCamps WHERE state='" & theState & "' ORDER BY [Camp]"
        cmSQL.CommandText = "SELECT * FROM RegisterSch WHERE Sn=" & SchoolID
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read Then
            DGridList.Item("SchoolID", dRow).Value = ChkNull(drSQL.Item("Sn")) 'SchoolID
            DGridList.Item("SchName", dRow).Value = ChkNull(drSQL.Item("SchName")) 'DGridList.Item(dColumn + 2, dRow).Value = ChkNull(drSQL.Item("SchName"))
            DGridList.Item("SchAddress", dRow).Value = ChkNull(drSQL.Item("SchAddress"))
            DGridList.Item("SchCity", dRow).Value = ChkNull(drSQL.Item("SchCity"))
            DGridList.Item("SchCountry", dRow).Value = ChkNull(drSQL.Item("SchCountry"))
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        PassFilter(DGridList, tFilter.Text)
        cmdSave.Enabled = False
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
        If chkMultiFilter.Checked Then
            PassFilterMulti(datagridview, strFilter)
            Exit Sub
        End If
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
            Case Is = "Containing"
                strNewFilter = "*" + strFilter + "*"
            Case Is = "Start With"
                strNewFilter = strFilter + "*"
            Case Is = "End with"
                strNewFilter = "*" + strFilter
        End Select
        While i < datagridview.Rows.Count
            j = 0
            containStr = False
            kj = SelColumn.Value - 1
            jk = SelColumn.Value - 1
            For j = kj To jk
                If Not datagridview.Item(j, i).Value Is DBNull.Value Or Nothing Then
                    If LCase(datagridview.Item(j, i).Value) Like LCase(strNewFilter) Then
                        containStr = True
                        wr = wr + 1
                        Exit For
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
        On Error Resume Next
        For Each idx As Integer In deleteIndexList
            datagridview.Rows.RemoveAt(idx)
        Next
    End Sub
    Private Sub PassFilterMulti(ByRef datagridview As DataGridView, ByVal strFilter As String)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim jk As Integer = 0
        Dim kj As Integer
        Dim wr As Integer = 0
        Dim containStr As Boolean = False
        ' Row indexes we'll remove later on.
        Dim deleteIndexList As List(Of Integer) = New List(Of Integer)

        'Dim strNewFilter As String = ""
        'Select Case cboCriteria.Text
        '    Case Is = "="
        '        strNewFilter = strFilter
        '    Case Is = "Containing"
        '        strNewFilter = "*" + strFilter + "*"
        '    Case Is = "Start With"
        '        strNewFilter = strFilter + "*"
        '    Case Is = "End with"
        '        strNewFilter = "*" + strFilter
        'End Select
        While i < datagridview.Rows.Count
            j = 0
            containStr = False
            kj = SelColumn.Value - 1
            jk = SelColumn.Value - 1
            For j = kj To jk
                If Not datagridview.Item(j, i).Value Is DBNull.Value Or Nothing Then
                    If LCase(strFilter) Like "*" + LCase(datagridview.Item(j, i).Value) + "*" Then
                        containStr = True
                        wr = wr + 1
                        Exit For
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
        tFilter.Text = ""
        ' Remove rows by reversed row index order (highest removed first) to keep the indexes in whack.
        deleteIndexList.Reverse()
        For Each idx As Integer In deleteIndexList
            datagridview.Rows.RemoveAt(idx)
        Next
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        On Error GoTo handler
        Dim x As Integer = 0

        oLoadDbgrid()

        Dim myStyle As New DataGridViewCellStyle
        'Dim myStyle1 As New DataGridViewCellStyle

        myStyle.ForeColor = Color.White
        myStyle.BackColor = Color.MediumPurple
        Dim drow2select As Integer = 0

        'myStyle1.ForeColor = Color.Black
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

        While x < DGridList.Rows.Count
            Dim y As Integer = 0
            kj = SelColumn.Value - 1
            jk = SelColumn.Value - 1
            For y = kj To jk
                If Not DGridList.Item(y, x).Value Is DBNull.Value Or Nothing Then
                    If LCase(DGridList.Item(y, x).Value) Like LCase(strNewFilter) Then
                        'DGridList.Item(y, x).Style = myStyle
                        DGridList.Rows(x).DefaultCellStyle = myStyle
                        ij = ij + 1
                        If drow2select = 0 Then drow2select = x
                    End If
                End If
            Next y
            x = x + 1
        End While
        On Error Resume Next
        If ij = 0 Then
            MessageBox.Show("Match Not Found!")
        Else
            MessageBox.Show("(" + ij.ToString + ") Match Found")
            DGridList.CurrentCell = DGridList.Rows(drow2select).Cells("tName")
            DGridList.Focus()
        End If

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub cmdRefresh2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh2.Click
        '  cmdSave.Enabled = True
        oLoadDbgrid()
        cmdSave.Enabled = True
    End Sub
   

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        On Error GoTo handler
        Dim oXL As Object
        oXL = CreateObject("Excel.Application")
        oXL.Visible = True
        oXL.Workbooks.Add()

        oXL.Sheets(1).Select()

        oXL.Visible = True
        Dim j, i As Integer
        ' Format A1:D1 as bold, vertical alignment = center.
        With oXL.Sheets(1).Range("A1", "AZ1")
            .Font.Bold = True
            ' .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        Dim jk As Integer = 0
        For j = 0 To DGridList.ColumnCount - 1
            oXL.Cells(1, j + 1) = DGridList.Columns(j).Name.ToString()
        Next
        On Error Resume Next
        For i = 0 To DGridList.RowCount - 1
            ' If DGridList.Rows(i).Selected = True Then
            For j = 0 To DGridList.ColumnCount - 1
                If IsNumeric(DGridList(j, i).Value) Then
                    oXL.Cells(jk + 2, j + 1) = "'" + DGridList(j, i).Value.ToString()
                Else
                    oXL.Cells(jk + 2, j + 1) = DGridList(j, i).Value.ToString()
                End If

            Next
            jk = jk + 1
            'End If
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
    Private Sub PanFilter_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanFilter.MouseDown
        StoredX = e.X
        StoredY = e.Y
        PanFilter.Cursor = Cursors.NoMove2D
    End Sub
    Private Sub PanFilter_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanFilter.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            PanFilter.Top = PanFilter.Top - (StoredY - e.Y)
            PanFilter.Left = PanFilter.Left - (StoredX - e.X)
        End If
        PanFilter.Cursor = Cursors.Default
    End Sub

    Private Sub DGridList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGridList.DoubleClick
        On Error Resume Next

        Dim h As Integer = Val(DGridList.Tag)
        If h < 0 Then Exit Sub
        If IsDBNull(DGridList.Item("Sn", h).Value) Then Exit Sub
        Dim ChildForm As New FrmHistory
        ChildForm.RefNo = DGridList.Item("Sn", h).Value
        ChildForm.tRefNo.Text = DGridList.Item("Sn", h).Value
        ChildForm.tName.Text = DGridList.Item("tName", h).Value
        ChildForm.tSchool.Text = DGridList.Item("SchName", h).Value
        ChildForm.Source = "Student"
        ChildForm.ShowDialog()

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

    Private Sub LoadScholarType()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cScholarType.Items.Clear()

        cnSQL.Open()
        cmSQL.CommandText = "SELECT DISTINCT StudyProgramme FROM Register ORDER BY StudyProgramme"
        cmSQL.CommandType = CommandType.Text
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cScholarType.Items.Add(drSQL.Item("StudyProgramme"))
        Loop
        drSQL.Close()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        cScholarType.Items.Add("ALL")

        cScholarType.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 91 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub cScholarType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cScholarType.SelectedIndexChanged
        FillSchCountry()
    End Sub

    Private Sub DGridList_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridList.CellEndEdit
        Dim r As Integer = 0
        If DGridList.Columns(e.ColumnIndex).Name = "SwiftCode" Then
            r = e.RowIndex()
            If Len(DGridList.Item(e.ColumnIndex, e.RowIndex).Value) <> 11 Then
                MsgBox("Swift Code must be 11 characters", vbInformation, strApptitle)
                ' DGridList.CurrentCell = DGridList.Rows(r).Cells("SwiftCode")
            End If
        End If

    End Sub

    Private Sub mnuUpdateSchInfor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpdateSchInfor.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cnSQL1 As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim cmSQL1 As SqlCommand = cnSQL1.CreateCommand

        cnSQL1.Open()
        Dim myTrans As SqlClient.SqlTransaction

        myTrans = cnSQL1.BeginTransaction()
        cmSQL1.Transaction = myTrans

        cmSQL.CommandText = "SELECT * FROM RegisterSch order By Sn"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cmSQL1.Parameters.Clear()
            cmSQL1.CommandText = "UpdateSchool4Students"
            cmSQL1.CommandType = CommandType.StoredProcedure
            cmSQL1.Parameters.AddWithValue("@SchoolID", drSQL.Item("Sn"))
            cmSQL1.Parameters.AddWithValue("@SchName", drSQL.Item("SchName")) 'DGridList.Item(dColumn + 2, dRow).Value = ChkNull(drSQL.Item("SchName"))
            cmSQL1.Parameters.AddWithValue("@SchAddress", drSQL.Item("SchAddress"))
            cmSQL1.Parameters.AddWithValue("@SchCity", drSQL.Item("SchCity"))
            cmSQL1.Parameters.AddWithValue("@SchCountry", drSQL.Item("SchCountry"))
            cmSQL1.ExecuteNonQuery()
        Loop


        myTrans.Commit()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cmSQL1.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL1.Close()
        cnSQL.Dispose()

        MsgBox("Successful!", vbInformation, strApptitle)
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub mnuCleanData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCleanData.Click
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
            Next j
        Next i

        If errh > 0 Then
            MsgBox(errh.ToString + " entries Cleaned")
        Else
            MsgBox("Noting to Clean")

        End If

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

    Private Sub mnuChkEntryLenght_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChkEntryLenght.Click
        Dim myStyle As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Red

        On Error Resume Next
        Dim dCount As Integer = 0
        Dim ik As Integer = 0

        For ik = 0 To DGridList.RowCount - 1
            'leave out RefNo and IDNumber
            For i = 2 To DGridList.ColumnCount - 1
                'If DGridList.Columns(i).Name = "City1" Then
                '    If Len(DGridList.Item("City1", ik).Value) + Len(DGridList.Item("Country", ik).Value) > 35 Then
                '        DGridList.Item(i, ik).Style = myStyle
                '        DGridList.Item(i, ik).Value = Mid(DGridList.Item(i, ik).Value, 1, 35 - Len(DGridList.Item("Country", ik).Value))
                '        dCount = dCount + 1
                '    End If
                'ElseIf DGridList.Columns(i).Name = "BankCity" Then
                '    If Len(DGridList.Item("BankCity", ik).Value) + Len(DGridList.Item("BankCountry", ik).Value) > 35 Then
                '        DGridList.Item(i, ik).Style = myStyle
                '        DGridList.Item(i, ik).Value = Mid(DGridList.Item(i, ik).Value, 1, 35 - Len(DGridList.Item("BankCountry", ik).Value))
                '        dCount = dCount + 1
                '    End If
                'ElseIf DGridList.Columns(i).Name = "IntermediateBankCity" Then
                '    If Len(DGridList.Item("IntermediateBankCity", ik).Value) + Len(DGridList.Item("IntermediateBankCountry", ik).Value) > 35 Then
                '        DGridList.Item(i, ik).Style = myStyle
                '        DGridList.Item(i, ik).Value = Mid(DGridList.Item(i, ik).Value, 1, 35 - Len(DGridList.Item("IntermediateBankCountry", ik).Value))
                '        dCount = dCount + 1
                '    End If
                'Else
                If Len(DGridList.Item(i, ik).Value) > DGridList.Columns(i).FillWeight Then
                    DGridList.Item(i, ik).Style = myStyle
                    DGridList.Item(i, ik).Value = Mid(DGridList.Item(i, ik).Value, 1, DGridList.Columns(i).FillWeight)
                    dCount = dCount + 1
                End If
                'End If
            Next
        Next

        If dCount > 0 Then
            MsgBox(dCount.ToString + " Entry Found and Truncated", MsgBoxStyle.Information, strApptitle)
        Else
            MsgBox("Successfull!! No Entry Found", MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub mnuCheckComma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCheckComma.Click
        Dim myStyle As New DataGridViewCellStyle
        myStyle.BackColor = Color.Yellow
        myStyle.ForeColor = Color.Red

        Dim i As Integer
        Dim j As Integer
        Dim errh As Integer = 0
        Dim AdvString As String = ""
        For i = 0 To DGridList.RowCount - 1
            For j = 0 To DGridList.Columns.Count - 1
                If DGridList.Item(j, i).Value Is Nothing Or IsDBNull(DGridList.Item(j, i).Value) Then

                Else


                    DGridList.Item(j, i).Value = Trim(DGridList.Item(j, i).Value)
                    If Len(DGridList.Item(j, i).Value) > 0 Then
                        AdvString = DGridList.Item(j, i).Value

                        Dim jk As Integer = 0
                        Dim NewStr As String = ""
                        For jk = 1 To Len(AdvString)
                            If Asc(Mid(AdvString, jk, 1)) = 44 Or Asc(Mid(AdvString, jk, 1)) = 45 Then ' , and -

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
            Next j
        Next i

        If errh > 0 Then
            MsgBox(errh.ToString + " entries Cleaned")
        Else
            MsgBox("Noting to Clean")

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
End Class