Imports System.Data.SqlClient
Imports System.Drawing
Public Class FrmCoyInfo
    Private Sub cmdGetLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetLogo.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Application.Info.DirectoryPath
        OpenFileDialog.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
        OpenFileDialog.FilterIndex = 2

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            OwnerLogo.Image = Image.FromFile(FileName)
        End If
    End Sub

    Private Sub FrmCoyInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler
        AppHeader1.lblForm.Text = "Owner's Information"
        tName.Text = sysOwner
        Dim arrayLogo() As Byte = {0}
        Dim arrayBG() As Byte = {0}
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        cmSQL.CommandText = "FetchAllSystemParameters"
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Invalid System parameter", MsgBoxStyle.Information, strApptitle)
            End
        Else
            If drSQL.Read Then
                tAddress.Text = drSQL.Item("Address")
                tPhone.Text = drSQL.Item("Phone")
                tMandatePrefix.Text = ChkNull(drSQL.Item("MandatePrefix"))
                tCustomerRefPrefix.Text = ChkNull(drSQL.Item("CustomerRefPrefix"))
                'tUSD.Text = ChkNull(drSQL.Item("USD"))
                'tGBP.Text = ChkNull(drSQL.Item("GBP"))
                'tEUR.Text = ChkNull(drSQL.Item("EUR"))
                If IsDBNull(drSQL.Item("Logo")) = False Then
                    arrayLogo = CType(drSQL.Item("Logo"), Byte())
                    If arrayLogo.Length > 1 Then
                        Dim ms As New IO.MemoryStream(arrayLogo)
                        OwnerLogo.Image = Image.FromStream(ms)
                        Dim logoPictFileName = My.Computer.FileSystem.GetTempFileName
                        logoPictFileName = Mid(logoPictFileName, 1, Len(logoPictFileName) - 3) + "nap"
                        OwnerLogo.Image.Save(logoPictFileName)
                        ms.Close()
                        OwnerLogo.Image = Image.FromFile(logoPictFileName)
                    End If
                End If

                If IsDBNull(drSQL.Item("BackImage")) = False Then
                    arrayBG = CType(drSQL.Item("BackImage"), Byte())
                    If arrayBG.Length > 1 Then
                        Dim ms As New IO.MemoryStream(arrayBG)
                        PicBG.Image = Image.FromStream(ms)
                        Dim logoPictFileName = My.Computer.FileSystem.GetTempFileName
                        logoPictFileName = Mid(logoPictFileName, 1, Len(logoPictFileName) - 3) + "nap"
                        PicBG.Image.Save(logoPictFileName)
                        ms.Close()
                        PicBG.Image = Image.FromFile(logoPictFileName)
                    End If
                End If

            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()

        Dim arrayLogo() As Byte = {0}
        Dim arrayBG() As Byte = {0}

        If IsNothing(OwnerLogo.Image) = False Then
            Dim ms As New IO.MemoryStream()
            OwnerLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'OwnerLogo.Image.RawFormat
            arrayLogo = ms.GetBuffer
            ms.Close()
        End If

        If IsNothing(PicBG.Image) = False Then
            Dim ms1 As New IO.MemoryStream()
            PicBG.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg) 'OwnerLogo.Image.RawFormat
            arrayBG = ms1.GetBuffer
            ms1.Close()
        End If

        cmSQL.CommandText = "UpdateSysParam4CoySetup"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@NName", tName.Text)
        cmSQL.Parameters.AddWithValue("@logo", arrayLogo)
        cmSQL.Parameters.AddWithValue("@Address", tAddress.Text)
        cmSQL.Parameters.AddWithValue("@Phone", tPhone.Text)
        cmSQL.Parameters.AddWithValue("@MandatePrefix", tMandatePrefix.Text)
        cmSQL.Parameters.AddWithValue("@CustomerRefPrefix", tCustomerRefPrefix.Text)
        'cmSQL.Parameters.AddWithValue("@USD", tUSD.Text)
        'cmSQL.Parameters.AddWithValue("@GBP", tGBP.Text)
        'cmSQL.Parameters.AddWithValue("@EUR", tEUR.Text)
        cmSQL.Parameters.AddWithValue("@BackImage", arrayBG)
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        MsgBox("Update successfull, Pls. restart the application", MsgBoxStyle.Critical, "Company Information")

        End

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub InsertLogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertLogoToolStripMenuItem.Click
        cmdGetLogo_Click(sender, e)
    End Sub

    Private Sub ClearLogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearLogoToolStripMenuItem.Click
        On Error GoTo handler
        OwnerLogo.Image = Nothing
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub OwnerLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OwnerLogo.Click

    End Sub

    Private Sub cmdBG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBG.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Application.Info.DirectoryPath
        OpenFileDialog.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
        OpenFileDialog.FilterIndex = 2

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            PicBG.Image = Image.FromFile(FileName)
        End If
    End Sub
End Class