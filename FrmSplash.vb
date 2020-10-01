Public NotInheritable Class FrmSplash

    Private Sub FrmSplash2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Me.Close()
    End Sub


    Private Sub FrmSplash2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tTimer.Enabled = True
    End Sub

    Private Sub FrmSplash2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTimer.Tick
        Me.Close()
    End Sub

    Private Sub ApplicationTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub MainLayoutPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainLayoutPanel.Click
        Me.Close()
    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint

    End Sub

    Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Copyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ApplicationTitle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Copyright_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Version_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ApplicationTitle_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationTitle.Click

    End Sub
End Class
