Imports System.IO
Imports System.Data.SqlClient
Public Class FrmMainbox
    Dim TheMenuName As String
    Private MouseIsDown As Boolean = False
    Dim noOfLogons As Integer = 0
    Private Sub FrmMainbox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error GoTo handler

        Me.SetStyle(ControlStyles.DoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)

        lblOwner.Text = " " + sysOwner
        lblUserName1.Text = ""
        lblUserName2.Text = ""



       ' lblSystemPeriod.Text = "System Period : " + sysPeriod
        FrmStart.mnuSystemUser.Visible = False

        On Error Resume Next
        If Not arrayLogo Is Nothing Then
            Dim ms As New MemoryStream(arrayLogo)
            OwnerLogo.Image = Image.FromStream(ms)
        End If


        GetBodyPict()


      


        PicFA.Cursor = Cursors.Hand
        PicSC.Cursor = Cursors.Hand
        PicPayroll.Cursor = Cursors.Hand
        PicAccounts.Cursor = Cursors.Hand
        PicHR.Cursor = Cursors.Hand


        ' txtUserId.Focus()
        mnuLogOff_Click(sender, e)


        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub TimCalender_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimCalender.Tick
        lblDayName.Text = UCase(Format(Now, "dddd"))
        lblDayNumber.Text = Format(Now, "dd")
        lblMonthYear.Text = UCase(Format(Now, "MMMM, yyyy"))
        lblTime.Text = Format(Now, "hh:mm:ss tt")
    End Sub
    Private Sub mnuPict1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPict1.Click
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        '        Dim drSQL As SqlDataReader

        cnSQL.Open()
        cmSQL.CommandText = " Update UserAccess SET PicBody = 1 WHERE UserID = '" & sysUser & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        PictBody = True
   
        If Not arrayBody Is Nothing And arrayBody.Length > 1 Then
            Dim ms As New MemoryStream(arrayBody)
            Me.BackgroundImage = Image.FromStream(ms)

            SvrInfo.ForeColor = Color.Black

            lblOwner.ForeColor = Color.Black
            lblMainTitle.ForeColor = Color.Black
            lnkWebsite.LinkColor = Color.Black
            lblUserName1.ForeColor = Color.Black
            lblUserName2.ForeColor = Color.Black
            mnuLogOff.ForeColor = Color.Black

        Else
            Me.BackgroundImage = Nothing
            SvrInfo.ForeColor = Color.White

            lblOwner.ForeColor = Color.White
            lblMainTitle.ForeColor = Color.White
            lnkWebsite.LinkColor = Color.White
            lblUserName1.ForeColor = Color.White
            lblUserName2.ForeColor = Color.White
            mnuLogOff.ForeColor = Color.White
        End If

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub mnuPict2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()
        cmSQL.CommandText = " Update UserAccess SET PicBody = 2 WHERE UserID = '" & sysUser & "'"
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
    Public Sub GetBodyPict()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        On Error GoTo handler


        'ReDim arrayBody(0)
        cnSQL.Open()

        cmSQL.CommandText = "FetchAllSystemParameters"
        cmSQL.CommandType = CommandType.StoredProcedure

        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
        Else
            If drSQL.Read Then
                '  If PictBody = 1 Then arrayBody = CType(drSQL.Item("Pict1"), Byte())
              
            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        On Error Resume Next
        Dim ctrl As ToolStripItem
        If PictBody < 1 Then

            'lblOwner.ForeColor = Color.White
            'lblMainTitle.ForeColor = Color.White
            'lnkWebsite.LinkColor = Color.White
            'lblUserName1.ForeColor = Color.White
            'lblUserName2.ForeColor = Color.White
            'mnuLogOff.ForeColor = Color.White
            lblOwner.ForeColor = Color.Black
            lblMainTitle.ForeColor = Color.Black
            lnkWebsite.LinkColor = Color.Black
            lblUserName1.ForeColor = Color.Black
            lblUserName2.ForeColor = Color.Black
            mnuLogOff.ForeColor = Color.Black
        Else

            lblOwner.ForeColor = Color.Black
            lblMainTitle.ForeColor = Color.Black
            lnkWebsite.LinkColor = Color.Black
            lblUserName1.ForeColor = Color.Black
            lblUserName2.ForeColor = Color.Black
            mnuLogOff.ForeColor = Color.Black
        End If
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Critical, strApptitle)
    End Sub


    Public Sub mnuLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogOff.Click
        On Error GoTo errhdl
        'closeMailNotification = False
        'TimerMail.Enabled = False
        'frmMailNotification.Close()

        'FrmStart.Close()
        'sysUser = ""

        'On Error Resume Next

        tblLogin.Visible = True

        txtUserId.Text = ""
        txtPwd.Text = ""
        sysUser = ""
        txtUserId.Focus()
        pnlMain.Enabled = False

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub mnuClearPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClearPicture.Click
        On Error Resume Next

        Me.BackgroundImage = Nothing ' Image.FromFile(AppPath + "\ConfigDir\BodyPic.jpg")

        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        '       Dim drSQL As SqlDataReader

        cnSQL.Open()
        cmSQL.CommandText = " Update UserAccess SET PicBody = 0 WHERE UserID = '" & sysUser & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        'lblOwner.ForeColor = Color.White
        'lblMainTitle.ForeColor = Color.White
        'lnkWebsite.LinkColor = Color.White
        'lblUserName1.ForeColor = Color.White
        'lblUserName2.ForeColor = Color.White
        'mnuLogOff.ForeColor = Color.White

        lblOwner.ForeColor = Color.Black
        lblMainTitle.ForeColor = Color.Black
        lnkWebsite.LinkColor = Color.Black
        lblUserName1.ForeColor = Color.Black
        lblUserName2.ForeColor = Color.Black
        mnuLogOff.ForeColor = Color.Black


        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Sub mnuCoyInfor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCoyInfor.Click
        Dim ChildForm As New FrmCoyInfo
        ' ChildForm.MdiParent = FrmStart
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuserverInfor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuServerInfor.Click
        Dim ChildForm As New FrmSvrInfor
        ' ChildForm.MdiParent = FrmStart
        ChildForm.ShowDialog()
    End Sub
  Private Sub FirstColumn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstColumn.Tick
        If pnlHR.BackColor = Color.Crimson Then

            pnlHR.BackColor = Color.Teal
            pnlPayroll.BackColor = Color.DarkSeaGreen
            pnlFA.BackColor = Color.DarkOrange
            pnlSC.BackColor = Color.Purple
            pnlAccounts.BackColor = Color.Crimson

        ElseIf pnlHR.BackColor = Color.Teal Then

            pnlHR.BackColor = Color.DarkSeaGreen
            pnlPayroll.BackColor = Color.DarkOrange
            pnlFA.BackColor = Color.Purple
            pnlSC.BackColor = Color.Crimson
            pnlAccounts.BackColor = Color.Teal

        ElseIf pnlHR.BackColor = Color.DarkSeaGreen Then

            pnlHR.BackColor = Color.DarkOrange
            pnlPayroll.BackColor = Color.Purple
            pnlFA.BackColor = Color.Crimson
            pnlSC.BackColor = Color.Teal
            pnlAccounts.BackColor = Color.DarkSeaGreen

        ElseIf pnlHR.BackColor = Color.DarkOrange Then

            pnlHR.BackColor = Color.Purple
            pnlPayroll.BackColor = Color.Crimson
            pnlFA.BackColor = Color.Teal
            pnlSC.BackColor = Color.DarkSeaGreen
            pnlAccounts.BackColor = Color.DarkOrange

        Else

            pnlHR.BackColor = Color.Crimson
            pnlPayroll.BackColor = Color.Teal
            pnlFA.BackColor = Color.DarkSeaGreen
            pnlSC.BackColor = Color.DarkOrange
            pnlAccounts.BackColor = Color.Purple

        End If
        'Panel6.BackColor = pnlAccounts.BackColor
    End Sub

    Private Sub PicAdmin_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicAdmin.MouseEnter
        If sysUser = "" Then Exit Sub
        tblTools.Visible = True
    End Sub

    Private Sub pnlMain_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlMain.MouseEnter
        tblTools.Visible = False
    End Sub

    Private Sub PicQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicQuit.Click
        End
    End Sub

   
    Private Sub cmdBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mnuBackupDB_Click(sender, e)
    End Sub

    Private Sub PicRptBuilder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicRptBuilder.Click
        On Error GoTo errhdl

        If MsgBox("This operation cannot be reversed.....continue (y/n)", vbYesNo + MsgBoxStyle.Information, strApptitle) = vbNo Then
            Exit Sub
        End If

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        Dim ThePayment As String = "Payment" + Format(Now, "MMM") + Mid(Trim(Str(Year(Now))), 3)

        cmSQL.CommandText = "EXEC sp_rename 'Payment', '" & ThePayment & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.CommandText = "SELECT * INTO Payment FROM PaymentBlank"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        MsgBox("Successful", MsgBoxStyle.Information, strApptitle)

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    Private Sub mnuBackupDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBackupDB.Click
        'If GetUserAccessDetails("Backup DB") = False Then Exit Sub
        Dim ChildForm As New FrmBakRes
        ChildForm.MdiParent = FrmStart
        ChildForm.Action = "Backup"
        ChildForm.Show()
    End Sub
    Private Sub mnuSystemUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewUsers.Click

        If GetUserAccessDetails("Admin. Role", True) = False Then Exit Sub
        Dim ChildForm As New FrmNewUser
        ChildForm.Action = "New"
        ChildForm.ShowDialog()
    End Sub

    Private Sub lnkWebsite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkWebsite.LinkClicked
        System.Diagnostics.Process.Start("http://www.megahitsystems.com")
    End Sub
    Public Function MarqueeLeft(ByVal Text As String)
        Dim Str1 As String = Text.Remove(0, 1)
        Dim Str2 As String = Text(0)
        Return Str1 & Str2
    End Function

    Private Sub mnuChangePwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChangePwd.Click
        Dim ChildForm As New FrmChangePwd
        ' ChildForm.MdiParent = FrmStart
        ChildForm.ShowDialog()
    End Sub


    Private Sub tblBody_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles tblBody.Paint

    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        ' On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        cmSQL.CommandText = "FetchUserAccess"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@UserID", txtUserId.Text)
        cmSQL.Parameters.AddWithValue("@UserPwd", txtPwd.Text)

        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Invalid User Login Information" & Chr(13) & "Access Denied", MsgBoxStyle.Information)
            If noOfLogons = 3 Then
                End
            Else
                noOfLogons += 1
                Me.Text = Me.Text + " *"
                Exit Sub
            End If
        End If

        If drSQL.Read Then
            sysUserName = drSQL.Item("UserID")
            sysUser = drSQL.Item("UserID")

            strLevel = drSQL.Item("Level")
            PictBody = drSQL.Item("PicBody")

            SysPwd = txtPwd.Text
        End If

        drSQL.Close()

        sysUserName = txtUserId.Text


        'If UCase(sysOwner) <> UCase(strOwnerFromServer) Then
        '    cmSQL.CommandText = "UPDATE SystemParameters SET NName='" & sysOwner & "'"
        '    cmSQL.CommandType = CommandType.Text
        '    cmSQL.ExecuteNonQuery()
        'End If

        cmSQL.Connection.Close()
        cmSQL.Dispose()

        cnSQL.Close()
        cnSQL.Dispose()


        tblLogin.Visible = False
        pnlMain.Enabled = True

        If PictBody = True Then
            lblOwner.ForeColor = Color.Black
            lblMainTitle.ForeColor = Color.Black
            lnkWebsite.LinkColor = Color.Black
            lblUserName1.ForeColor = Color.Black
            lblUserName2.ForeColor = Color.Black
            mnuLogOff.ForeColor = Color.Black

            If Not arrayBody Is Nothing And arrayBody.Length > 1 Then
                Dim ms1 As New MemoryStream(arrayBody)
                Me.BackgroundImage = Image.FromStream(ms1)
                'tblBody.BackgroundImage= Image.FromStream(ms1)
            Else
                Me.BackgroundImage = Nothing
                'lblOwner.ForeColor = Color.White
                'lblMainTitle.ForeColor = Color.White
                'lnkWebsite.LinkColor = Color.White
                'lblUserName1.ForeColor = Color.White
                'lblUserName2.ForeColor = Color.White
                'mnuLogOff.ForeColor = Color.White

                lblOwner.ForeColor = Color.Black
                lblMainTitle.ForeColor = Color.Black
                lnkWebsite.LinkColor = Color.Black
                lblUserName1.ForeColor = Color.Black
                lblUserName2.ForeColor = Color.Black
                mnuLogOff.ForeColor = Color.Black

            End If

        Else
            'lblOwner.ForeColor = Color.White
            'lblMainTitle.ForeColor = Color.White
            'lnkWebsite.LinkColor = Color.White
            'lblUserName1.ForeColor = Color.White
            'lblUserName2.ForeColor = Color.White
            'mnuLogOff.ForeColor = Color.White

            lblOwner.ForeColor = Color.Black
            lblMainTitle.ForeColor = Color.Black
            lnkWebsite.LinkColor = Color.Black
            lblUserName1.ForeColor = Color.Black
            lblUserName2.ForeColor = Color.Black
            mnuLogOff.ForeColor = Color.Black

            Me.BackgroundImage = Nothing
        End If

        Dim i As Integer
        i = InStr(sysUserName, " ")
        If i > 0 Then
            lblUserName1.Text = Mid(sysUserName, 1, i - 1)
            lblUserName2.Text = Mid(sysUserName, i + 1)
        Else
            lblUserName1.Text = sysUserName
            lblUserName2.Text = ""
        End If

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub PicAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicAdmin.Click

    End Sub

    Private Sub PicAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicAccounts.Click
        Dim ChildForm As New FrmRegistration
        ChildForm.MdiParent = FrmStart
        ChildForm.Show()
    End Sub

    Private Sub PicPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicPayroll.Click
        Dim ChildForm As New FrmRegistrationSch
        ChildForm.MdiParent = FrmStart
        ChildForm.Show()
    End Sub

    Private Sub PicHR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicHR.Click
        If GetUserAccessDetails("Payments", True) = False Then Exit Sub
        Dim ChildForm As New FrmMandateSummary
        ChildForm.ShowDialog()
    End Sub

    Private Sub PicSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicSC.Click
        Dim ChildForm As New FrmMLedger
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeleteUser.Click
        If GetUserAccessDetails("Admin. Role", True) = False Then Exit Sub
        Dim ChildForm As New FrmNewUser
        ChildForm.Action = "Delete"
        ChildForm.ShowDialog()
    End Sub

    Private Sub PicPayAudit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicPayAudit.Click
        If GetUserAccessDetails("Admin. Role", True) = False Then Exit Sub
        Dim ChildForm As New FrmPaymentType
        ChildForm.ShowDialog()
    End Sub

    Private Sub PicFA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicFA.Click
        Dim ChildForm As New FrmRegistrationStaff
        ChildForm.MdiParent = FrmStart
        ChildForm.Show()
    End Sub

    Private Sub PicReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicReports.Click
        FrmReport.ShowDialog()
    End Sub

    Private Sub SvrInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SvrInfo.Click
        Dim ChildForm As New FrmSvrInfor
        'ChildForm.TopMost = True
        ChildForm.ShowDialog()
    End Sub

    Private Sub PicCurrency_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicCurrency.Click
        If GetUserAccessDetails("Admin. Role", True) = False Then Exit Sub
        Dim ChildForm As New FrmCurrency
        ChildForm.ShowDialog()
    End Sub

    Private Sub mnuUpdateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpdateUser.Click
        If GetUserAccessDetails("Admin. Role", True) = False Then Exit Sub
        Dim ChildForm As New FrmNewUser
        ChildForm.Action = "Edit"
        ChildForm.ShowDialog()
    End Sub
End Class