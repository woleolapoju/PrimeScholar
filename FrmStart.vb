Imports System.Windows.Forms

Public Class FrmStart

    Public Sub FrmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'TO DISABLE Timer for faster process
        'TimerMail.Enabled = AC_AllowMailing

        On Error GoTo handler
        If LogOnFail Then
            FrmSvrInfor.ShowDialog()
            InitialiseEntireSystem()
        End If

        FrmSplash.ShowDialog()

        FrmMainbox.MdiParent = Me
        FrmMainbox.Dock = DockStyle.Fill
        FrmMainbox.WindowState = FormWindowState.Maximized
        FrmMainbox.Show()


        'If sysUser <> "" Then

        '    FrmMainbox.MdiParent = Me
        '    FrmMainbox.Dock = DockStyle.Fill
        '    FrmMainbox.WindowState = FormWindowState.Maximized
        '    FrmMainbox.Show()

        'End If
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        On Error Resume Next
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            If Not (ChildForm.Name = "FrmMain") Then ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    
End Class
