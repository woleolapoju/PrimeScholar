<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCoyInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCoyInfo))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tPhone = New System.Windows.Forms.TextBox()
        Me.CMLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdGetLogo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OwnerLogo = New System.Windows.Forms.PictureBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tMandatePrefix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tCustomerRefPrefix = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tUSD = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tGBP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tEUR = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdBG = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PicBG = New System.Windows.Forms.PictureBox()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.CMLogo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name:"
        '
        'tName
        '
        Me.tName.AcceptsReturn = True
        Me.tName.Enabled = False
        Me.tName.Location = New System.Drawing.Point(104, 53)
        Me.tName.Multiline = True
        Me.tName.Name = "tName"
        Me.tName.Size = New System.Drawing.Size(226, 40)
        Me.tName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Address:"
        '
        'tAddress
        '
        Me.tAddress.Location = New System.Drawing.Point(104, 95)
        Me.tAddress.Multiline = True
        Me.tAddress.Name = "tAddress"
        Me.tAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tAddress.Size = New System.Drawing.Size(226, 47)
        Me.tAddress.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Phone:"
        '
        'tPhone
        '
        Me.tPhone.Location = New System.Drawing.Point(104, 144)
        Me.tPhone.Name = "tPhone"
        Me.tPhone.Size = New System.Drawing.Size(226, 20)
        Me.tPhone.TabIndex = 11
        '
        'CMLogo
        '
        Me.CMLogo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertLogoToolStripMenuItem, Me.ToolStripMenuItem1, Me.ClearLogoToolStripMenuItem})
        Me.CMLogo.Name = "CMLogo"
        Me.CMLogo.Size = New System.Drawing.Size(134, 54)
        '
        'InsertLogoToolStripMenuItem
        '
        Me.InsertLogoToolStripMenuItem.Name = "InsertLogoToolStripMenuItem"
        Me.InsertLogoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.InsertLogoToolStripMenuItem.Text = "Insert Logo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 6)
        '
        'ClearLogoToolStripMenuItem
        '
        Me.ClearLogoToolStripMenuItem.Name = "ClearLogoToolStripMenuItem"
        Me.ClearLogoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ClearLogoToolStripMenuItem.Text = "Clear Logo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Logo"
        '
        'cmdGetLogo
        '
        Me.cmdGetLogo.Location = New System.Drawing.Point(49, 220)
        Me.cmdGetLogo.Name = "cmdGetLogo"
        Me.cmdGetLogo.Size = New System.Drawing.Size(30, 24)
        Me.cmdGetLogo.TabIndex = 18
        Me.cmdGetLogo.Text = "..."
        Me.cmdGetLogo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OwnerLogo)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(104, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 156)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'OwnerLogo
        '
        Me.OwnerLogo.AccessibleDescription = ""
        Me.OwnerLogo.ContextMenuStrip = Me.CMLogo
        Me.OwnerLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OwnerLogo.Location = New System.Drawing.Point(3, 16)
        Me.OwnerLogo.Margin = New System.Windows.Forms.Padding(1)
        Me.OwnerLogo.Name = "OwnerLogo"
        Me.OwnerLogo.Size = New System.Drawing.Size(141, 137)
        Me.OwnerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OwnerLogo.TabIndex = 17
        Me.OwnerLogo.TabStop = False
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(107, 379)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(74, 34)
        Me.cmdOk.TabIndex = 50
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(181, 379)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(74, 34)
        Me.cmdClose.TabIndex = 51
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Mandate Prefix:"
        '
        'tMandatePrefix
        '
        Me.tMandatePrefix.Location = New System.Drawing.Point(104, 167)
        Me.tMandatePrefix.Name = "tMandatePrefix"
        Me.tMandatePrefix.Size = New System.Drawing.Size(226, 20)
        Me.tMandatePrefix.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(13, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 28)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Customer Ref Prefix:"
        '
        'tCustomerRefPrefix
        '
        Me.tCustomerRefPrefix.Location = New System.Drawing.Point(104, 191)
        Me.tCustomerRefPrefix.Name = "tCustomerRefPrefix"
        Me.tCustomerRefPrefix.Size = New System.Drawing.Size(226, 20)
        Me.tCustomerRefPrefix.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "USD:"
        '
        'tUSD
        '
        Me.tUSD.Location = New System.Drawing.Point(40, 14)
        Me.tUSD.Name = "tUSD"
        Me.tUSD.Size = New System.Drawing.Size(122, 20)
        Me.tUSD.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "DEBIT ACCOUNTS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "GBP:"
        '
        'tGBP
        '
        Me.tGBP.Location = New System.Drawing.Point(40, 37)
        Me.tGBP.Name = "tGBP"
        Me.tGBP.Size = New System.Drawing.Size(122, 20)
        Me.tGBP.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "EUR:"
        '
        'tEUR
        '
        Me.tEUR.Location = New System.Drawing.Point(40, 59)
        Me.tEUR.Name = "tEUR"
        Me.tEUR.Size = New System.Drawing.Size(122, 20)
        Me.tEUR.TabIndex = 62
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tGBP)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.tUSD)
        Me.Panel1.Controls.Add(Me.tEUR)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(343, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(34, 29)
        Me.Panel1.TabIndex = 63
        Me.Panel1.Visible = False
        '
        'cmdBG
        '
        Me.cmdBG.Location = New System.Drawing.Point(346, 303)
        Me.cmdBG.Name = "cmdBG"
        Me.cmdBG.Size = New System.Drawing.Size(30, 24)
        Me.cmdBG.TabIndex = 65
        Me.cmdBG.Text = "..."
        Me.cmdBG.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicBG)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(263, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(115, 82)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Background Image"
        '
        'PicBG
        '
        Me.PicBG.AccessibleDescription = ""
        Me.PicBG.ContextMenuStrip = Me.CMLogo
        Me.PicBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicBG.Location = New System.Drawing.Point(3, 16)
        Me.PicBG.Margin = New System.Windows.Forms.Padding(1)
        Me.PicBG.Name = "PicBG"
        Me.PicBG.Size = New System.Drawing.Size(109, 63)
        Me.PicBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBG.TabIndex = 17
        Me.PicBG.TabStop = False
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(0, 0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(384, 47)
        Me.AppHeader1.TabIndex = 67
        '
        'FrmCoyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(384, 416)
        Me.Controls.Add(Me.AppHeader1)
        Me.Controls.Add(Me.cmdBG)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tCustomerRefPrefix)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tMandatePrefix)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdGetLogo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tPhone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCoyInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Information"
        Me.CMLogo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdGetLogo As System.Windows.Forms.Button
    Friend WithEvents CMLogo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents InsertLogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearLogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OwnerLogo As System.Windows.Forms.PictureBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tMandatePrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tCustomerRefPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tGBP As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tEUR As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdBG As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PicBG As System.Windows.Forms.PictureBox
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
End Class
