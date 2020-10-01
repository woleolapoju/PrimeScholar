
Namespace DGVColumnSelector
	Partial Class UserControlMenu
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.SuspendLayout()
            '
            'UserControlMenu
            '
            Me.Name = "UserControlMenu"
            Me.Size = New System.Drawing.Size(150, 222)
            Me.ResumeLayout(False)

        End Sub

#End Region


        Friend WithEvents Timer1 As System.Windows.Forms.Timer

	End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
