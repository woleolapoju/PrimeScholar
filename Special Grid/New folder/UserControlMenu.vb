
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DGVColumnSelector
	Public Partial Class UserControlMenu
		Inherits UserControl
        Public DoneEvent As EventHandler
		Public Delegate Sub CheckedChanged(iIndex As Integer, bChecked As Boolean)
		Public Event CheckedChangedEnent As CheckedChanged
		Public Overridable Sub OnCheckedChanged(iIndex As Integer, bChecked As Boolean)
			RaiseEvent CheckedChangedEnent(iIndex, bChecked)
		End Sub
		Public Overridable Sub OnDone()
            '  RaiseEvent DoneEvent(Me, EventArgs.Empty)
		End Sub

		Private m_pMenuControl As New MenuControl()

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub buttonDone_Click(sender As Object, e As EventArgs)
			Parent.Focus()
		End Sub

		Public Sub Initialize(pDataGridView As DataGridView)
			m_pMenuControl = New MenuControl()

			For Each c As DataGridViewColumn In pDataGridView.Columns
				m_pMenuControl.Add(c.HeaderText, c.Visible)
			Next

			m_pMenuControl.Prepare(CreateGraphics())

			Width = m_pMenuControl.Width
			Height = m_pMenuControl.Height

			timer1.Enabled = True

		End Sub

		Private Sub UserControlMenu_Paint(sender As Object, e As PaintEventArgs)
			m_pMenuControl.Draw(e.Graphics)
		End Sub

		Private Sub UserControlMenu_MouseMove(sender As Object, e As MouseEventArgs)
			If m_pMenuControl.HitTestMouseMove(e.X, e.Y) Then
                m_pMenuControl.Draw(CreateGraphics())
			End If
		End Sub

		Private Sub UserControlMenu_MouseDown(sender As Object, e As MouseEventArgs)
			If m_pMenuControl.HitTestMouseDown(e.X, e.Y) Then
				If m_pMenuControl.Done Then
					OnDone()
				Else
					Dim iHitIndex As Integer = m_pMenuControl.HitIndex
					If iHitIndex <> -1 Then
						Dim bChecked As Boolean = m_pMenuControl.ChangeChecked(iHitIndex, CreateGraphics())
						OnCheckedChanged(iHitIndex, bChecked)
					End If
				End If
			End If
		End Sub

		Private Sub timer1_Tick(sender As Object, e As EventArgs)
			Dim pPoint As Point = PointToClient(Cursor.Position)
			If m_pMenuControl.HitTestMouseMove(pPoint.X, pPoint.Y) Then
				m_pMenuControl.Draw(CreateGraphics())
			End If
		End Sub
	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
