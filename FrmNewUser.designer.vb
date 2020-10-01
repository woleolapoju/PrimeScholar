<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewUser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.tPwd = New System.Windows.Forms.TextBox()
        Me.tUserName = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.tConfirmPwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ModuleDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        Me.Modules = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ModuleDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(9, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 3)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(225, 89)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(52, 35)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "&Close"
        '
        'OK
        '
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(113, 89)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(106, 35)
        Me.OK.TabIndex = 3
        Me.OK.Text = "&OK"
        '
        'tPwd
        '
        Me.tPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPwd.Location = New System.Drawing.Point(114, 31)
        Me.tPwd.Name = "tPwd"
        Me.tPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tPwd.Size = New System.Drawing.Size(107, 21)
        Me.tPwd.TabIndex = 1
        Me.tPwd.UseSystemPasswordChar = True
        '
        'tUserName
        '
        Me.tUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUserName.Location = New System.Drawing.Point(114, 5)
        Me.tUserName.Name = "tUserName"
        Me.tUserName.Size = New System.Drawing.Size(148, 21)
        Me.tUserName.TabIndex = 0
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(4, 32)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(61, 15)
        Me.PasswordLabel.TabIndex = 10
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(4, 3)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(68, 15)
        Me.UsernameLabel.TabIndex = 8
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tConfirmPwd
        '
        Me.tConfirmPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tConfirmPwd.Location = New System.Drawing.Point(114, 57)
        Me.tConfirmPwd.Name = "tConfirmPwd"
        Me.tConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tConfirmPwd.Size = New System.Drawing.Size(105, 21)
        Me.tConfirmPwd.TabIndex = 2
        Me.tConfirmPwd.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "&Confirm Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboUser
        '
        Me.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(114, 4)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(164, 23)
        Me.cboUser.TabIndex = 16
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(0, 0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(290, 41)
        Me.AppHeader1.TabIndex = 125
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ModuleDGV, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 41)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(290, 471)
        Me.TableLayoutPanel1.TabIndex = 126
        '
        'ModuleDGV
        '
        Me.ModuleDGV.AllowUserToAddRows = False
        Me.ModuleDGV.AllowUserToDeleteRows = False
        Me.ModuleDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.ModuleDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ModuleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModuleDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Modules, Me.Open})
        Me.ModuleDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModuleDGV.Location = New System.Drawing.Point(1, 136)
        Me.ModuleDGV.Margin = New System.Windows.Forms.Padding(1)
        Me.ModuleDGV.MultiSelect = False
        Me.ModuleDGV.Name = "ModuleDGV"
        Me.ModuleDGV.RowHeadersWidth = 21
        Me.ModuleDGV.Size = New System.Drawing.Size(288, 334)
        Me.ModuleDGV.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkSelectAll)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.PasswordLabel)
        Me.Panel1.Controls.Add(Me.tUserName)
        Me.Panel1.Controls.Add(Me.tConfirmPwd)
        Me.Panel1.Controls.Add(Me.tPwd)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.OK)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Cancel)
        Me.Panel1.Controls.Add(Me.cboUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 129)
        Me.Panel1.TabIndex = 45
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Location = New System.Drawing.Point(5, 106)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(70, 17)
        Me.chkSelectAll.TabIndex = 19
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'Modules
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell
        Me.Modules.DefaultCellStyle = DataGridViewCellStyle1
        Me.Modules.Frozen = True
        Me.Modules.HeaderText = "Modules"
        Me.Modules.Name = "Modules"
        Me.Modules.ReadOnly = True
        Me.Modules.ToolTipText = "Application Modules"
        Me.Modules.Width = 200
        '
        'Open
        '
        Me.Open.HeaderText = "Allow"
        Me.Open.Name = "Open"
        Me.Open.ToolTipText = "Click to Toggle Open options"
        Me.Open.Width = 45
        '
        'FrmNewUser
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(290, 512)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AppHeader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ModuleDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents tPwd As System.Windows.Forms.TextBox
    Friend WithEvents tUserName As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents tConfirmPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ModuleDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents Modules As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Open As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
