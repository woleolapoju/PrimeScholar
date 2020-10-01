Imports System.Data.SqlClient
Public Class FrmNewUser
    Public Action As String
    Private Sub FrmNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AppHeader1.lblForm.Text = "New User"
        If Action = "New" Then
            cboUser.Visible = False
            Me.Text = "New User"
            tUserName.Focus()
        End If

        If Action = "Delete" Then
            Me.Text = "Delete User"
            AppHeader1.lblForm.Text = "Delete User"
            cboUser.Enabled = True
            LoadUser()
            cboUser.BringToFront()
        End If
        If Action = "Edit" Then
            Me.Text = "Edit User"
            AppHeader1.lblForm.Text = "Edit User"
            tUserName.Visible = False
            cboUser.Enabled = True
            LoadUser()
            cboUser.BringToFront()
        End If

        applyGridTheme(ModuleDGV)

        ModuleDGV.ReadOnly = False
        ModuleDGV.Columns("Modules").ReadOnly = True

        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 0).Value = "Add New Scholar"
        ModuleDGV.Item(1, 0).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 1).Value = "Edit Scholar"
        ModuleDGV.Item(1, 1).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 2).Value = "Delete Scholar"
        ModuleDGV.Item(1, 2).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 3).Value = "Add New Institution"
        ModuleDGV.Item(1, 3).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 4).Value = "Edit Institution"
        ModuleDGV.Item(1, 4).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 5).Value = "Delete Institution"
        ModuleDGV.Item(1, 5).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 6).Value = "Add New Staff/Stakeholder"
        ModuleDGV.Item(1, 6).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 7).Value = "Edit Staff/Stakeholder"
        ModuleDGV.Item(1, 7).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 8).Value = "Delete Staff/Stakeholder"
        ModuleDGV.Item(1, 8).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 9).Value = "Authorise Mandate"
        ModuleDGV.Item(1, 9).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 10).Value = "Void Payment"
        ModuleDGV.Item(1, 10).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 11).Value = "Admin. Role"
        ModuleDGV.Item(1, 11).Value = 0
        ModuleDGV.Rows.Add()
        ModuleDGV.Item(0, 12).Value = "Payments"
        ModuleDGV.Item(1, 12).Value = 0
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim TheLevel As String = ""
        Dim i As Integer
        For i = 0 To ModuleDGV.RowCount - 1
            If ModuleDGV.Item("Open", i).Value = True Then
                TheLevel = TheLevel & IIf(TheLevel = "", "", ",") & ModuleDGV.Item("Modules", i).Value
            End If

        Next
        If Action = "New" Then
            If Trim(tPwd.Text) = "" Or Trim(tConfirmPwd.Text) = "" Or Trim(tUserName.Text) = "" Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If

            If tPwd.Text <> tConfirmPwd.Text Then
                MsgBox("Inconsistent Password", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            cnSQL.Open()
            cmSQL.CommandText = "InsertUserAccess"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@UserID", tUserName.Text)
            cmSQL.Parameters.AddWithValue("@UserPassword", tPwd.Text)
            cmSQL.Parameters.AddWithValue("@Level", TheLevel)
            cmSQL.ExecuteNonQuery()
            cmSQL.Parameters.Clear()
            MsgBox("Successfull!", MsgBoxStyle.Information, strApptitle)
            tUserName.Text = ""
            tPwd.Text = ""
            tConfirmPwd.Text = ""
            tUserName.Focus()
            chkSelectAll.Checked = False
        End If
        If Action = "Delete" Then
            If UCase(Trim(cboUser.Text)) = "ADMIN" Then
                MsgBox("This User cannot be deleted", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Trim(cboUser.Text) = "" Then
                MsgBox("Pls. specify user", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
            cnSQL.Open()
            cmSQL.CommandText = "DELETE FROM UserAccess WHERE UserID='" & cboUser.Text & "'"
            cmSQL.CommandType = CommandType.Text
            cmSQL.ExecuteNonQuery()
            MsgBox("Delete Successfull!", MsgBoxStyle.Information, strApptitle)
            Me.Close()
        End If
        If Action = "Edit" Then

            cnSQL.Open()
            cmSQL.CommandText = "UPDATE UserAccess SET [Level]='" & TheLevel & "' WHERE UserID='" & cboUser.Text & "'"
            cmSQL.CommandType = CommandType.Text
            cmSQL.ExecuteNonQuery()

            MsgBox("Update Successfull!", MsgBoxStyle.Information, strApptitle)
            Me.Close()
        End If
        Exit Sub
handler:
        If Err.Number = 5 Then
            MsgBox("User already exist", MsgBoxStyle.Information, strApptitle)
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub LoadUser()
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cboUser.Items.Clear()
        cmSQL.CommandText = "SELECT * FROM UserAccess"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            If UCase(drSQL.Item("UserID")) <> "ADMIN" Then cboUser.Items.Add(drSQL.Item("UserID").ToString)
        Loop
        Exit Sub
        drSQL.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub

    Private Sub FrmNewUser_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        Dim i As Integer
        For i = 0 To ModuleDGV.RowCount - 1
            ModuleDGV.Rows(i).Cells(1).Value = chkSelectAll.Checked
        Next
    End Sub

    Private Sub cboUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUser.SelectedIndexChanged
        Dim theTask As String = FillTask()
        For i = 0 To ModuleDGV.RowCount - 1
            If theTask Like "*" & ModuleDGV.Item("Modules", i).Value & "*" Then
                ModuleDGV.Item("Open", i).Value = True
            Else
                ModuleDGV.Item("Open", i).Value = False
            End If

        Next
    End Sub
    Function FillTask() As String

        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        FillTask = ""
        cmSQL.CommandText = "SELECT * FROM UserAccess WHERE UserID='" & cboUser.Text & "'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then GoTo SkipIt
        If drSQL.Read Then FillTask = drSQL.Item("level")
SkipIt:
        drSQL.Close()
        cmSQL.Dispose()
        cnSQL.Close()

        Exit Function

        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)

    End Function
End Class