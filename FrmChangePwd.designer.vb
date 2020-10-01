<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePwd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePwd))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tConfirm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tUserID = New System.Windows.Forms.TextBox()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tCurrentPwd = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Confirm Pwd:"
        '
        'tConfirm
        '
        Me.tConfirm.AcceptsReturn = True
        Me.tConfirm.Location = New System.Drawing.Point(94, 117)
        Me.tConfirm.Name = "tConfirm"
        Me.tConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tConfirm.Size = New System.Drawing.Size(94, 20)
        Me.tConfirm.TabIndex = 2
        Me.tConfirm.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Password:"
        '
        'tPassword
        '
        Me.tPassword.AcceptsReturn = True
        Me.tPassword.Location = New System.Drawing.Point(94, 94)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tPassword.Size = New System.Drawing.Size(94, 20)
        Me.tPassword.TabIndex = 1
        Me.tPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "User ID:"
        '
        'tUserID
        '
        Me.tUserID.AcceptsReturn = True
        Me.tUserID.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tUserID.Enabled = False
        Me.tUserID.Location = New System.Drawing.Point(94, 47)
        Me.tUserID.Name = "tUserID"
        Me.tUserID.ReadOnly = True
        Me.tUserID.Size = New System.Drawing.Size(94, 20)
        Me.tUserID.TabIndex = 38
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(0, 0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(249, 41)
        Me.AppHeader1.TabIndex = 124
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Current Password:"
        '
        'tCurrentPwd
        '
        Me.tCurrentPwd.AcceptsReturn = True
        Me.tCurrentPwd.Location = New System.Drawing.Point(94, 71)
        Me.tCurrentPwd.Name = "tCurrentPwd"
        Me.tCurrentPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tCurrentPwd.Size = New System.Drawing.Size(94, 20)
        Me.tCurrentPwd.TabIndex = 0
        Me.tCurrentPwd.UseSystemPasswordChar = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 3)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(190, 148)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(52, 34)
        Me.Cancel.TabIndex = 128
        Me.Cancel.Text = "&Close"
        '
        'cmdOK
        '
        Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.Location = New System.Drawing.Point(91, 147)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(94, 35)
        Me.cmdOK.TabIndex = 127
        Me.cmdOK.Text = "&OK"
        '
        'OK
        '
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(93, 151)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 35)
        Me.OK.TabIndex = 127
        Me.OK.Text = "&OK"
        '
        'FrmChangePwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(249, 185)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.tCurrentPwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AppHeader1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tConfirm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tUserID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmChangePwd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tConfirm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tUserID As System.Windows.Forms.TextBox
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tCurrentPwd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
End Class
