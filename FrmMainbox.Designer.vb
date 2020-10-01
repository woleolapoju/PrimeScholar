<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainbox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainbox))
        Me.tblBody = New System.Windows.Forms.TableLayoutPanel()
        Me.CMMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuPict1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearPicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.tblTools = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuAdmin = New System.Windows.Forms.MenuStrip()
        Me.mnuCoyInfor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuServerInfor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChangePwd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackupDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestoreDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicCurrency = New System.Windows.Forms.PictureBox()
        Me.pnlPayAudit = New System.Windows.Forms.Panel()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.PicPayAudit = New System.Windows.Forms.PictureBox()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.PicReports = New System.Windows.Forms.PictureBox()
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.PicAdmin = New System.Windows.Forms.PictureBox()
        Me.pnlRptBuilder = New System.Windows.Forms.Panel()
        Me.lblDashBoard = New System.Windows.Forms.Label()
        Me.PicRptBuilder = New System.Windows.Forms.PictureBox()
        Me.lnkWebsite = New System.Windows.Forms.LinkLabel()
        Me.OwnerLogo = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDayName = New System.Windows.Forms.Label()
        Me.lblDayNumber = New System.Windows.Forms.Label()
        Me.lblMonthYear = New System.Windows.Forms.Label()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSystemPeriod = New System.Windows.Forms.Label()
        Me.pnlAccounts = New System.Windows.Forms.Panel()
        Me.lblAccounts = New System.Windows.Forms.Label()
        Me.PicAccounts = New System.Windows.Forms.PictureBox()
        Me.pnlPayroll = New System.Windows.Forms.Panel()
        Me.lblEmployees = New System.Windows.Forms.Label()
        Me.PicPayroll = New System.Windows.Forms.PictureBox()
        Me.pnlSC = New System.Windows.Forms.Panel()
        Me.lblBoarding = New System.Windows.Forms.Label()
        Me.PicSC = New System.Windows.Forms.PictureBox()
        Me.pnlHR = New System.Windows.Forms.Panel()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.PicHR = New System.Windows.Forms.PictureBox()
        Me.pnlFA = New System.Windows.Forms.Panel()
        Me.lblAdmission = New System.Windows.Forms.Label()
        Me.PicFA = New System.Windows.Forms.PictureBox()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUserName2 = New System.Windows.Forms.Label()
        Me.lblUserName1 = New System.Windows.Forms.Label()
        Me.PictUserImage = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PicQuit = New System.Windows.Forms.PictureBox()
        Me.mnuLogOff = New System.Windows.Forms.Label()
        Me.tblLogin = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SvrInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblAttemps = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimCalender = New System.Windows.Forms.Timer(Me.components)
        Me.FirstColumn = New System.Windows.Forms.Timer(Me.components)
        Me.tblBody.SuspendLayout()
        Me.CMMain.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblTools.SuspendLayout()
        Me.MenuAdmin.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PicCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPayAudit.SuspendLayout()
        CType(Me.PicPayAudit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReports.SuspendLayout()
        CType(Me.PicReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdmin.SuspendLayout()
        CType(Me.PicAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRptBuilder.SuspendLayout()
        CType(Me.PicRptBuilder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.pnlAccounts.SuspendLayout()
        CType(Me.PicAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPayroll.SuspendLayout()
        CType(Me.PicPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSC.SuspendLayout()
        CType(Me.PicSC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHR.SuspendLayout()
        CType(Me.PicHR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFA.SuspendLayout()
        CType(Me.PicFA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PicQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblLogin.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblBody
        '
        Me.tblBody.AutoScroll = True
        Me.tblBody.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.tblBody.BackColor = System.Drawing.Color.Transparent
        Me.tblBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tblBody.ColumnCount = 3
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblBody.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblBody.ContextMenuStrip = Me.CMMain
        Me.tblBody.Controls.Add(Me.pnlMain, 1, 3)
        Me.tblBody.Controls.Add(Me.Panel2, 1, 1)
        Me.tblBody.Controls.Add(Me.tblLogin, 1, 4)
        Me.tblBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBody.Location = New System.Drawing.Point(0, 0)
        Me.tblBody.Name = "tblBody"
        Me.tblBody.RowCount = 6
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.48417!))
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.13416!))
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblBody.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.38167!))
        Me.tblBody.Size = New System.Drawing.Size(1284, 772)
        Me.tblBody.TabIndex = 2
        '
        'CMMain
        '
        Me.CMMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPict1, Me.mnuClearPicture})
        Me.CMMain.Name = "CMPicture"
        Me.CMMain.Size = New System.Drawing.Size(142, 48)
        '
        'mnuPict1
        '
        Me.mnuPict1.Name = "mnuPict1"
        Me.mnuPict1.Size = New System.Drawing.Size(141, 22)
        Me.mnuPict1.Text = "Load Picture"
        '
        'mnuClearPicture
        '
        Me.mnuClearPicture.Name = "mnuClearPicture"
        Me.mnuClearPicture.Size = New System.Drawing.Size(141, 22)
        Me.mnuClearPicture.Text = "Clear Picture"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Transparent
        Me.pnlMain.Controls.Add(Me.PictureBox3)
        Me.pnlMain.Controls.Add(Me.lblOwner)
        Me.pnlMain.Controls.Add(Me.tblTools)
        Me.pnlMain.Controls.Add(Me.Panel5)
        Me.pnlMain.Controls.Add(Me.lnkWebsite)
        Me.pnlMain.Controls.Add(Me.OwnerLogo)
        Me.pnlMain.Controls.Add(Me.Panel4)
        Me.pnlMain.Controls.Add(Me.pnlLogo)
        Me.pnlMain.Controls.Add(Me.pnlAccounts)
        Me.pnlMain.Controls.Add(Me.pnlPayroll)
        Me.pnlMain.Controls.Add(Me.pnlSC)
        Me.pnlMain.Controls.Add(Me.pnlHR)
        Me.pnlMain.Controls.Add(Me.pnlFA)
        Me.pnlMain.Controls.Add(Me.lblMainTitle)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Enabled = False
        Me.pnlMain.ForeColor = System.Drawing.Color.White
        Me.pnlMain.Location = New System.Drawing.Point(196, 89)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(892, 508)
        Me.pnlMain.TabIndex = 31
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 37)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(892, 1)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 43
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'lblOwner
        '
        Me.lblOwner.AutoEllipsis = True
        Me.lblOwner.AutoSize = True
        Me.lblOwner.BackColor = System.Drawing.Color.Transparent
        Me.lblOwner.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOwner.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwner.ForeColor = System.Drawing.Color.Black
        Me.lblOwner.Location = New System.Drawing.Point(0, 0)
        Me.lblOwner.Margin = New System.Windows.Forms.Padding(7, 0, 10, 0)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(225, 37)
        Me.lblOwner.TabIndex = 42
        Me.lblOwner.Text = " Megahit Systems"
        Me.lblOwner.UseMnemonic = False
        '
        'tblTools
        '
        Me.tblTools.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblTools.BackColor = System.Drawing.SystemColors.Control
        Me.tblTools.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tblTools.ColumnCount = 1
        Me.tblTools.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTools.Controls.Add(Me.MenuAdmin, 0, 0)
        Me.tblTools.Location = New System.Drawing.Point(440, 324)
        Me.tblTools.Margin = New System.Windows.Forms.Padding(0)
        Me.tblTools.Name = "tblTools"
        Me.tblTools.RowCount = 1
        Me.tblTools.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblTools.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161.0!))
        Me.tblTools.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161.0!))
        Me.tblTools.Size = New System.Drawing.Size(125, 162)
        Me.tblTools.TabIndex = 41
        Me.tblTools.Visible = False
        '
        'MenuAdmin
        '
        Me.MenuAdmin.AllowMerge = False
        Me.MenuAdmin.BackColor = System.Drawing.Color.Transparent
        Me.MenuAdmin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCoyInfor, Me.mnuServerInfor, Me.mnuNewUsers, Me.mnuUpdateUser, Me.mnuDeleteUser, Me.mnuChangePwd, Me.ToolStripMenuItem15, Me.mnuBackupDB, Me.mnuRestoreDB})
        Me.MenuAdmin.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuAdmin.Location = New System.Drawing.Point(1, 1)
        Me.MenuAdmin.Name = "MenuAdmin"
        Me.MenuAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuAdmin.Size = New System.Drawing.Size(123, 160)
        Me.MenuAdmin.TabIndex = 15
        Me.MenuAdmin.Text = "MenuStrip2"
        '
        'mnuCoyInfor
        '
        Me.mnuCoyInfor.BackColor = System.Drawing.Color.Transparent
        Me.mnuCoyInfor.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuCoyInfor.Name = "mnuCoyInfor"
        Me.mnuCoyInfor.Size = New System.Drawing.Size(116, 21)
        Me.mnuCoyInfor.Text = "Company Infor."
        Me.mnuCoyInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuServerInfor
        '
        Me.mnuServerInfor.BackColor = System.Drawing.Color.Transparent
        Me.mnuServerInfor.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuServerInfor.Name = "mnuServerInfor"
        Me.mnuServerInfor.Size = New System.Drawing.Size(116, 21)
        Me.mnuServerInfor.Text = "Server Infor."
        Me.mnuServerInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuNewUsers
        '
        Me.mnuNewUsers.BackColor = System.Drawing.Color.Transparent
        Me.mnuNewUsers.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuNewUsers.Name = "mnuNewUsers"
        Me.mnuNewUsers.Size = New System.Drawing.Size(116, 21)
        Me.mnuNewUsers.Text = "New Users"
        Me.mnuNewUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuUpdateUser
        '
        Me.mnuUpdateUser.BackColor = System.Drawing.Color.Transparent
        Me.mnuUpdateUser.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUpdateUser.Name = "mnuUpdateUser"
        Me.mnuUpdateUser.Size = New System.Drawing.Size(116, 21)
        Me.mnuUpdateUser.Text = "Edit Users"
        Me.mnuUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuDeleteUser
        '
        Me.mnuDeleteUser.BackColor = System.Drawing.Color.Transparent
        Me.mnuDeleteUser.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDeleteUser.Name = "mnuDeleteUser"
        Me.mnuDeleteUser.Size = New System.Drawing.Size(116, 21)
        Me.mnuDeleteUser.Text = "Delete Users"
        Me.mnuDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuChangePwd
        '
        Me.mnuChangePwd.BackColor = System.Drawing.Color.Transparent
        Me.mnuChangePwd.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuChangePwd.Name = "mnuChangePwd"
        Me.mnuChangePwd.Size = New System.Drawing.Size(116, 21)
        Me.mnuChangePwd.Text = "Change Password"
        Me.mnuChangePwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem15.Enabled = False
        Me.ToolStripMenuItem15.Font = New System.Drawing.Font("Segoe UI", 2.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(116, 8)
        Me.ToolStripMenuItem15.Text = "_________________________________________________________________________________" & _
            "_________________________________________________________"
        Me.ToolStripMenuItem15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuBackupDB
        '
        Me.mnuBackupDB.BackColor = System.Drawing.Color.Transparent
        Me.mnuBackupDB.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBackupDB.Name = "mnuBackupDB"
        Me.mnuBackupDB.Size = New System.Drawing.Size(116, 21)
        Me.mnuBackupDB.Text = "Backup DB"
        Me.mnuBackupDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuRestoreDB
        '
        Me.mnuRestoreDB.BackColor = System.Drawing.Color.Transparent
        Me.mnuRestoreDB.Enabled = False
        Me.mnuRestoreDB.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuRestoreDB.Name = "mnuRestoreDB"
        Me.mnuRestoreDB.Size = New System.Drawing.Size(116, 21)
        Me.mnuRestoreDB.Text = "Restore DB"
        Me.mnuRestoreDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.pnlPayAudit)
        Me.Panel5.Controls.Add(Me.pnlReports)
        Me.Panel5.Controls.Add(Me.pnlAdmin)
        Me.Panel5.Controls.Add(Me.pnlRptBuilder)
        Me.Panel5.Location = New System.Drawing.Point(309, 61)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(259, 390)
        Me.Panel5.TabIndex = 39
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Peru
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.PicCurrency)
        Me.Panel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel7.Location = New System.Drawing.Point(1, 64)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(125, 62)
        Me.Panel7.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Currency Setup"
        '
        'PicCurrency
        '
        Me.PicCurrency.BackColor = System.Drawing.Color.Transparent
        Me.PicCurrency.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicCurrency.Image = CType(resources.GetObject("PicCurrency.Image"), System.Drawing.Image)
        Me.PicCurrency.Location = New System.Drawing.Point(0, 0)
        Me.PicCurrency.Name = "PicCurrency"
        Me.PicCurrency.Size = New System.Drawing.Size(125, 62)
        Me.PicCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicCurrency.TabIndex = 2
        Me.PicCurrency.TabStop = False
        '
        'pnlPayAudit
        '
        Me.pnlPayAudit.BackColor = System.Drawing.Color.BurlyWood
        Me.pnlPayAudit.Controls.Add(Me.lblInventory)
        Me.pnlPayAudit.Controls.Add(Me.PicPayAudit)
        Me.pnlPayAudit.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlPayAudit.Location = New System.Drawing.Point(1, 1)
        Me.pnlPayAudit.Name = "pnlPayAudit"
        Me.pnlPayAudit.Size = New System.Drawing.Size(125, 59)
        Me.pnlPayAudit.TabIndex = 8
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.BackColor = System.Drawing.Color.Transparent
        Me.lblInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInventory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblInventory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventory.Location = New System.Drawing.Point(0, 40)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(102, 19)
        Me.lblInventory.TabIndex = 0
        Me.lblInventory.Text = "Payment Types"
        '
        'PicPayAudit
        '
        Me.PicPayAudit.BackColor = System.Drawing.Color.Transparent
        Me.PicPayAudit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPayAudit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicPayAudit.Image = CType(resources.GetObject("PicPayAudit.Image"), System.Drawing.Image)
        Me.PicPayAudit.Location = New System.Drawing.Point(0, 0)
        Me.PicPayAudit.Name = "PicPayAudit"
        Me.PicPayAudit.Size = New System.Drawing.Size(125, 59)
        Me.PicPayAudit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicPayAudit.TabIndex = 2
        Me.PicPayAudit.TabStop = False
        '
        'pnlReports
        '
        Me.pnlReports.BackColor = System.Drawing.Color.DimGray
        Me.pnlReports.Controls.Add(Me.lblReports)
        Me.pnlReports.Controls.Add(Me.PicReports)
        Me.pnlReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlReports.Location = New System.Drawing.Point(1, 132)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(256, 125)
        Me.pnlReports.TabIndex = 9
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.BackColor = System.Drawing.Color.Transparent
        Me.lblReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReports.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReports.Location = New System.Drawing.Point(3, 103)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(56, 19)
        Me.lblReports.TabIndex = 0
        Me.lblReports.Text = "Reports"
        '
        'PicReports
        '
        Me.PicReports.BackColor = System.Drawing.Color.Transparent
        Me.PicReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicReports.Image = CType(resources.GetObject("PicReports.Image"), System.Drawing.Image)
        Me.PicReports.Location = New System.Drawing.Point(0, 0)
        Me.PicReports.Name = "PicReports"
        Me.PicReports.Size = New System.Drawing.Size(256, 125)
        Me.PicReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicReports.TabIndex = 2
        Me.PicReports.TabStop = False
        '
        'pnlAdmin
        '
        Me.pnlAdmin.BackColor = System.Drawing.Color.DeepPink
        Me.pnlAdmin.Controls.Add(Me.lblPayment)
        Me.pnlAdmin.Controls.Add(Me.PicAdmin)
        Me.pnlAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAdmin.Location = New System.Drawing.Point(1, 263)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(125, 125)
        Me.pnlAdmin.TabIndex = 11
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPayment.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(3, 103)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(88, 19)
        Me.lblPayment.TabIndex = 0
        Me.lblPayment.Text = "Admin. Tools"
        '
        'PicAdmin
        '
        Me.PicAdmin.BackColor = System.Drawing.Color.Transparent
        Me.PicAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicAdmin.Image = CType(resources.GetObject("PicAdmin.Image"), System.Drawing.Image)
        Me.PicAdmin.Location = New System.Drawing.Point(0, 0)
        Me.PicAdmin.Name = "PicAdmin"
        Me.PicAdmin.Size = New System.Drawing.Size(125, 125)
        Me.PicAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicAdmin.TabIndex = 2
        Me.PicAdmin.TabStop = False
        '
        'pnlRptBuilder
        '
        Me.pnlRptBuilder.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlRptBuilder.Controls.Add(Me.lblDashBoard)
        Me.pnlRptBuilder.Controls.Add(Me.PicRptBuilder)
        Me.pnlRptBuilder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlRptBuilder.Location = New System.Drawing.Point(132, 1)
        Me.pnlRptBuilder.Name = "pnlRptBuilder"
        Me.pnlRptBuilder.Size = New System.Drawing.Size(125, 125)
        Me.pnlRptBuilder.TabIndex = 10
        '
        'lblDashBoard
        '
        Me.lblDashBoard.AutoSize = True
        Me.lblDashBoard.BackColor = System.Drawing.Color.Transparent
        Me.lblDashBoard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDashBoard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashBoard.Location = New System.Drawing.Point(3, 103)
        Me.lblDashBoard.Name = "lblDashBoard"
        Me.lblDashBoard.Size = New System.Drawing.Size(111, 19)
        Me.lblDashBoard.TabIndex = 0
        Me.lblDashBoard.Text = "Initialise New DB"
        '
        'PicRptBuilder
        '
        Me.PicRptBuilder.BackColor = System.Drawing.Color.Transparent
        Me.PicRptBuilder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicRptBuilder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicRptBuilder.Image = CType(resources.GetObject("PicRptBuilder.Image"), System.Drawing.Image)
        Me.PicRptBuilder.Location = New System.Drawing.Point(0, 0)
        Me.PicRptBuilder.Name = "PicRptBuilder"
        Me.PicRptBuilder.Size = New System.Drawing.Size(125, 125)
        Me.PicRptBuilder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicRptBuilder.TabIndex = 2
        Me.PicRptBuilder.TabStop = False
        '
        'lnkWebsite
        '
        Me.lnkWebsite.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lnkWebsite.ForeColor = System.Drawing.Color.Black
        Me.lnkWebsite.LinkColor = System.Drawing.Color.White
        Me.lnkWebsite.Location = New System.Drawing.Point(16, 467)
        Me.lnkWebsite.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.lnkWebsite.Name = "lnkWebsite"
        Me.lnkWebsite.Size = New System.Drawing.Size(209, 20)
        Me.lnkWebsite.TabIndex = 35
        Me.lnkWebsite.TabStop = True
        Me.lnkWebsite.Text = "www,megahitsystems.com"
        '
        'OwnerLogo
        '
        Me.OwnerLogo.AccessibleDescription = ""
        Me.OwnerLogo.BackColor = System.Drawing.Color.Transparent
        Me.OwnerLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OwnerLogo.Location = New System.Drawing.Point(737, 323)
        Me.OwnerLogo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.OwnerLogo.Name = "OwnerLogo"
        Me.OwnerLogo.Size = New System.Drawing.Size(125, 125)
        Me.OwnerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OwnerLogo.TabIndex = 15
        Me.OwnerLogo.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel4.Location = New System.Drawing.Point(606, 61)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(256, 256)
        Me.Panel4.TabIndex = 10
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblTime, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDayName, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDayNumber, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMonthYear, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(254, 254)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(3, 212)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(248, 42)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "7:30:23 AM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDayName
        '
        Me.lblDayName.BackColor = System.Drawing.Color.Transparent
        Me.lblDayName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDayName.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayName.ForeColor = System.Drawing.Color.Black
        Me.lblDayName.Location = New System.Drawing.Point(3, 0)
        Me.lblDayName.Name = "lblDayName"
        Me.lblDayName.Size = New System.Drawing.Size(248, 47)
        Me.lblDayName.TabIndex = 3
        Me.lblDayName.Text = "MONDAY"
        Me.lblDayName.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblDayNumber
        '
        Me.lblDayNumber.AutoSize = True
        Me.lblDayNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblDayNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDayNumber.Font = New System.Drawing.Font("Segoe UI", 70.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayNumber.ForeColor = System.Drawing.Color.Red
        Me.lblDayNumber.Location = New System.Drawing.Point(3, 47)
        Me.lblDayNumber.Name = "lblDayNumber"
        Me.lblDayNumber.Size = New System.Drawing.Size(248, 135)
        Me.lblDayNumber.TabIndex = 4
        Me.lblDayNumber.Text = "10"
        Me.lblDayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthYear
        '
        Me.lblMonthYear.BackColor = System.Drawing.Color.Transparent
        Me.lblMonthYear.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMonthYear.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthYear.ForeColor = System.Drawing.Color.Black
        Me.lblMonthYear.Location = New System.Drawing.Point(3, 182)
        Me.lblMonthYear.Name = "lblMonthYear"
        Me.lblMonthYear.Size = New System.Drawing.Size(248, 30)
        Me.lblMonthYear.TabIndex = 5
        Me.lblMonthYear.Text = "OCTOBER, 2015"
        Me.lblMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.Crimson
        Me.pnlLogo.Controls.Add(Me.TableLayoutPanel6)
        Me.pnlLogo.Location = New System.Drawing.Point(607, 323)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(125, 125)
        Me.pnlLogo.TabIndex = 14
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lblSystemPeriod, 0, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(125, 125)
        Me.TableLayoutPanel6.TabIndex = 36
        '
        'lblSystemPeriod
        '
        Me.lblSystemPeriod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSystemPeriod.Font = New System.Drawing.Font("Segoe UI Symbol", 8.3!, System.Drawing.FontStyle.Italic)
        Me.lblSystemPeriod.ForeColor = System.Drawing.Color.White
        Me.lblSystemPeriod.Location = New System.Drawing.Point(3, 0)
        Me.lblSystemPeriod.Name = "lblSystemPeriod"
        Me.lblSystemPeriod.Size = New System.Drawing.Size(119, 125)
        Me.lblSystemPeriod.TabIndex = 5
        Me.lblSystemPeriod.Text = "System Period"
        Me.lblSystemPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAccounts
        '
        Me.pnlAccounts.BackColor = System.Drawing.Color.DarkOrange
        Me.pnlAccounts.Controls.Add(Me.lblAccounts)
        Me.pnlAccounts.Controls.Add(Me.PicAccounts)
        Me.pnlAccounts.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlAccounts.Location = New System.Drawing.Point(18, 61)
        Me.pnlAccounts.Name = "pnlAccounts"
        Me.pnlAccounts.Size = New System.Drawing.Size(125, 125)
        Me.pnlAccounts.TabIndex = 7
        '
        'lblAccounts
        '
        Me.lblAccounts.AutoSize = True
        Me.lblAccounts.BackColor = System.Drawing.Color.Transparent
        Me.lblAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAccounts.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccounts.Location = New System.Drawing.Point(3, 103)
        Me.lblAccounts.Name = "lblAccounts"
        Me.lblAccounts.Size = New System.Drawing.Size(53, 19)
        Me.lblAccounts.TabIndex = 0
        Me.lblAccounts.Text = "Scholar"
        '
        'PicAccounts
        '
        Me.PicAccounts.BackColor = System.Drawing.Color.Transparent
        Me.PicAccounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicAccounts.Image = CType(resources.GetObject("PicAccounts.Image"), System.Drawing.Image)
        Me.PicAccounts.Location = New System.Drawing.Point(0, 0)
        Me.PicAccounts.Name = "PicAccounts"
        Me.PicAccounts.Size = New System.Drawing.Size(125, 125)
        Me.PicAccounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicAccounts.TabIndex = 2
        Me.PicAccounts.TabStop = False
        '
        'pnlPayroll
        '
        Me.pnlPayroll.BackColor = System.Drawing.Color.Teal
        Me.pnlPayroll.Controls.Add(Me.lblEmployees)
        Me.pnlPayroll.Controls.Add(Me.PicPayroll)
        Me.pnlPayroll.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlPayroll.Location = New System.Drawing.Point(149, 61)
        Me.pnlPayroll.Name = "pnlPayroll"
        Me.pnlPayroll.Size = New System.Drawing.Size(125, 125)
        Me.pnlPayroll.TabIndex = 6
        '
        'lblEmployees
        '
        Me.lblEmployees.AutoSize = True
        Me.lblEmployees.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEmployees.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployees.Location = New System.Drawing.Point(3, 103)
        Me.lblEmployees.Name = "lblEmployees"
        Me.lblEmployees.Size = New System.Drawing.Size(72, 19)
        Me.lblEmployees.TabIndex = 0
        Me.lblEmployees.Text = "Institution"
        '
        'PicPayroll
        '
        Me.PicPayroll.BackColor = System.Drawing.Color.Transparent
        Me.PicPayroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPayroll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicPayroll.Image = CType(resources.GetObject("PicPayroll.Image"), System.Drawing.Image)
        Me.PicPayroll.Location = New System.Drawing.Point(0, 0)
        Me.PicPayroll.Name = "PicPayroll"
        Me.PicPayroll.Size = New System.Drawing.Size(125, 125)
        Me.PicPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicPayroll.TabIndex = 2
        Me.PicPayroll.TabStop = False
        '
        'pnlSC
        '
        Me.pnlSC.BackColor = System.Drawing.Color.Purple
        Me.pnlSC.Controls.Add(Me.lblBoarding)
        Me.pnlSC.Controls.Add(Me.PicSC)
        Me.pnlSC.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlSC.Location = New System.Drawing.Point(149, 324)
        Me.pnlSC.Name = "pnlSC"
        Me.pnlSC.Size = New System.Drawing.Size(125, 125)
        Me.pnlSC.TabIndex = 5
        '
        'lblBoarding
        '
        Me.lblBoarding.AutoSize = True
        Me.lblBoarding.BackColor = System.Drawing.Color.Transparent
        Me.lblBoarding.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBoarding.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoarding.Location = New System.Drawing.Point(3, 103)
        Me.lblBoarding.Name = "lblBoarding"
        Me.lblBoarding.Size = New System.Drawing.Size(51, 19)
        Me.lblBoarding.TabIndex = 0
        Me.lblBoarding.Text = "Ledger"
        '
        'PicSC
        '
        Me.PicSC.BackColor = System.Drawing.Color.Transparent
        Me.PicSC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicSC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicSC.Image = CType(resources.GetObject("PicSC.Image"), System.Drawing.Image)
        Me.PicSC.Location = New System.Drawing.Point(0, 0)
        Me.PicSC.Name = "PicSC"
        Me.PicSC.Size = New System.Drawing.Size(125, 125)
        Me.PicSC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicSC.TabIndex = 2
        Me.PicSC.TabStop = False
        '
        'pnlHR
        '
        Me.pnlHR.BackColor = System.Drawing.Color.Crimson
        Me.pnlHR.Controls.Add(Me.lblStudent)
        Me.pnlHR.Controls.Add(Me.PicHR)
        Me.pnlHR.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlHR.Location = New System.Drawing.Point(17, 192)
        Me.pnlHR.Name = "pnlHR"
        Me.pnlHR.Size = New System.Drawing.Size(256, 125)
        Me.pnlHR.TabIndex = 4
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.Location = New System.Drawing.Point(3, 103)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(69, 19)
        Me.lblStudent.TabIndex = 0
        Me.lblStudent.Text = "Payments"
        '
        'PicHR
        '
        Me.PicHR.BackColor = System.Drawing.Color.Transparent
        Me.PicHR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicHR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicHR.Image = CType(resources.GetObject("PicHR.Image"), System.Drawing.Image)
        Me.PicHR.Location = New System.Drawing.Point(0, 0)
        Me.PicHR.Name = "PicHR"
        Me.PicHR.Size = New System.Drawing.Size(256, 125)
        Me.PicHR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicHR.TabIndex = 4
        Me.PicHR.TabStop = False
        '
        'pnlFA
        '
        Me.pnlFA.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.pnlFA.Controls.Add(Me.lblAdmission)
        Me.pnlFA.Controls.Add(Me.PicFA)
        Me.pnlFA.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlFA.Location = New System.Drawing.Point(18, 324)
        Me.pnlFA.Name = "pnlFA"
        Me.pnlFA.Size = New System.Drawing.Size(125, 125)
        Me.pnlFA.TabIndex = 3
        '
        'lblAdmission
        '
        Me.lblAdmission.AutoSize = True
        Me.lblAdmission.BackColor = System.Drawing.Color.Transparent
        Me.lblAdmission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdmission.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAdmission.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmission.Location = New System.Drawing.Point(0, 106)
        Me.lblAdmission.Name = "lblAdmission"
        Me.lblAdmission.Size = New System.Drawing.Size(119, 19)
        Me.lblAdmission.TabIndex = 0
        Me.lblAdmission.Text = "Staff/Stakeholders"
        '
        'PicFA
        '
        Me.PicFA.BackColor = System.Drawing.Color.Transparent
        Me.PicFA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicFA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicFA.Image = CType(resources.GetObject("PicFA.Image"), System.Drawing.Image)
        Me.PicFA.InitialImage = Nothing
        Me.PicFA.Location = New System.Drawing.Point(0, 0)
        Me.PicFA.Name = "PicFA"
        Me.PicFA.Size = New System.Drawing.Size(125, 125)
        Me.PicFA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicFA.TabIndex = 3
        Me.PicFA.TabStop = False
        '
        'lblMainTitle
        '
        Me.lblMainTitle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.ForeColor = System.Drawing.Color.Black
        Me.lblMainTitle.Location = New System.Drawing.Point(15, 445)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(260, 63)
        Me.lblMainTitle.TabIndex = 0
        Me.lblMainTitle.Text = "Offshore School/Student Mgt. www.megahitsystems.com +234-803-311-6212"
        Me.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.tblBody.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(201, 12)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(8, 3, 6, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1077, 69)
        Me.Panel2.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6, 3, 6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblUserName2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblUserName1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictUserImage, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(747, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(330, 72)
        Me.TableLayoutPanel1.TabIndex = 35
        '
        'lblUserName2
        '
        Me.lblUserName2.AutoSize = True
        Me.lblUserName2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUserName2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUserName2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName2.ForeColor = System.Drawing.Color.Black
        Me.lblUserName2.Location = New System.Drawing.Point(0, 21)
        Me.lblUserName2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUserName2.Name = "lblUserName2"
        Me.lblUserName2.Size = New System.Drawing.Size(260, 15)
        Me.lblUserName2.TabIndex = 7
        Me.lblUserName2.Text = "??"
        Me.lblUserName2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserName1
        '
        Me.lblUserName1.AutoSize = True
        Me.lblUserName1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUserName1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUserName1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName1.ForeColor = System.Drawing.Color.Black
        Me.lblUserName1.Location = New System.Drawing.Point(0, 0)
        Me.lblUserName1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUserName1.Name = "lblUserName1"
        Me.lblUserName1.Size = New System.Drawing.Size(260, 21)
        Me.lblUserName1.TabIndex = 1
        Me.lblUserName1.Text = "??"
        Me.lblUserName1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictUserImage
        '
        Me.PictUserImage.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictUserImage.Image = CType(resources.GetObject("PictUserImage.Image"), System.Drawing.Image)
        Me.PictUserImage.Location = New System.Drawing.Point(263, 3)
        Me.PictUserImage.Name = "PictUserImage"
        Me.TableLayoutPanel1.SetRowSpan(Me.PictUserImage, 3)
        Me.PictUserImage.Size = New System.Drawing.Size(64, 66)
        Me.PictUserImage.TabIndex = 0
        Me.PictUserImage.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PicQuit)
        Me.Panel1.Controls.Add(Me.mnuLogOff)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(254, 30)
        Me.Panel1.TabIndex = 8
        '
        'PicQuit
        '
        Me.PicQuit.BackColor = System.Drawing.Color.Black
        Me.PicQuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicQuit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicQuit.Image = CType(resources.GetObject("PicQuit.Image"), System.Drawing.Image)
        Me.PicQuit.Location = New System.Drawing.Point(151, 0)
        Me.PicQuit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 30)
        Me.PicQuit.Name = "PicQuit"
        Me.PicQuit.Size = New System.Drawing.Size(39, 28)
        Me.PicQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicQuit.TabIndex = 40
        Me.PicQuit.TabStop = False
        '
        'mnuLogOff
        '
        Me.mnuLogOff.AutoSize = True
        Me.mnuLogOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuLogOff.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuLogOff.ForeColor = System.Drawing.Color.Black
        Me.mnuLogOff.Location = New System.Drawing.Point(192, 6)
        Me.mnuLogOff.Margin = New System.Windows.Forms.Padding(0, 3, 0, 5)
        Me.mnuLogOff.Name = "mnuLogOff"
        Me.mnuLogOff.Size = New System.Drawing.Size(55, 19)
        Me.mnuLogOff.TabIndex = 6
        Me.mnuLogOff.Text = "Log Off"
        Me.mnuLogOff.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tblLogin
        '
        Me.tblLogin.ColumnCount = 3
        Me.tblLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblLogin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLogin.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.tblLogin.Controls.Add(Me.Panel3, 1, 0)
        Me.tblLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLogin.Location = New System.Drawing.Point(196, 603)
        Me.tblLogin.Name = "tblLogin"
        Me.tblLogin.RowCount = 1
        Me.tblLogin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLogin.Size = New System.Drawing.Size(892, 106)
        Me.tblLogin.TabIndex = 37
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SvrInfo})
        Me.MenuStrip1.Location = New System.Drawing.Point(150, 82)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 5, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(125, 21)
        Me.MenuStrip1.TabIndex = 69
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SvrInfo
        '
        Me.SvrInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SvrInfo.ForeColor = System.Drawing.Color.White
        Me.SvrInfo.Name = "SvrInfo"
        Me.SvrInfo.Size = New System.Drawing.Size(115, 17)
        Me.SvrInfo.Text = "Server Information"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.txtPwd)
        Me.Panel3.Controls.Add(Me.txtUserId)
        Me.Panel3.Controls.Add(Me.PasswordLabel)
        Me.Panel3.Controls.Add(Me.UsernameLabel)
        Me.Panel3.Controls.Add(Me.cmdOk)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(283, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(325, 100)
        Me.Panel3.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.Controls.Add(Me.lblAttemps)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Location = New System.Drawing.Point(4, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(314, 36)
        Me.Panel6.TabIndex = 74
        '
        'lblAttemps
        '
        Me.lblAttemps.BackColor = System.Drawing.Color.Transparent
        Me.lblAttemps.ForeColor = System.Drawing.Color.Yellow
        Me.lblAttemps.Location = New System.Drawing.Point(130, 17)
        Me.lblAttemps.Name = "lblAttemps"
        Me.lblAttemps.Size = New System.Drawing.Size(183, 13)
        Me.lblAttemps.TabIndex = 68
        Me.lblAttemps.Text = "Attempts:"
        Me.lblAttemps.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAttemps.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 22)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Pls. enter your login details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(1, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 3)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'txtPwd
        '
        Me.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(113, 71)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(108, 21)
        Me.txtPwd.TabIndex = 1
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'txtUserId
        '
        Me.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Location = New System.Drawing.Point(113, 46)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(108, 21)
        Me.txtUserId.TabIndex = 0
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(19, 70)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(80, 23)
        Me.PasswordLabel.TabIndex = 73
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(19, 45)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(80, 23)
        Me.UsernameLabel.TabIndex = 72
        Me.UsernameLabel.Text = "&UserID"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdOk
        '
        Me.cmdOk.BackgroundImage = CType(resources.GetObject("cmdOk.BackgroundImage"), System.Drawing.Image)
        Me.cmdOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(240, 40)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(79, 57)
        Me.cmdOk.TabIndex = 70
        Me.cmdOk.Text = "Login"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'TimCalender
        '
        Me.TimCalender.Enabled = True
        Me.TimCalender.Interval = 10
        '
        'FirstColumn
        '
        Me.FirstColumn.Enabled = True
        Me.FirstColumn.Interval = 2000
        '
        'FrmMainbox
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 772)
        Me.ControlBox = False
        Me.Controls.Add(Me.tblBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMainbox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tblBody.ResumeLayout(False)
        Me.CMMain.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblTools.ResumeLayout(False)
        Me.tblTools.PerformLayout()
        Me.MenuAdmin.ResumeLayout(False)
        Me.MenuAdmin.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PicCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPayAudit.ResumeLayout(False)
        Me.pnlPayAudit.PerformLayout()
        CType(Me.PicPayAudit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReports.ResumeLayout(False)
        Me.pnlReports.PerformLayout()
        CType(Me.PicReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdmin.ResumeLayout(False)
        Me.pnlAdmin.PerformLayout()
        CType(Me.PicAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRptBuilder.ResumeLayout(False)
        Me.pnlRptBuilder.PerformLayout()
        CType(Me.PicRptBuilder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.pnlLogo.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.pnlAccounts.ResumeLayout(False)
        Me.pnlAccounts.PerformLayout()
        CType(Me.PicAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPayroll.ResumeLayout(False)
        Me.pnlPayroll.PerformLayout()
        CType(Me.PicPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSC.ResumeLayout(False)
        Me.pnlSC.PerformLayout()
        CType(Me.PicSC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHR.ResumeLayout(False)
        Me.pnlHR.PerformLayout()
        CType(Me.PicHR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFA.ResumeLayout(False)
        Me.pnlFA.PerformLayout()
        CType(Me.PicFA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblLogin.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblBody As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PicQuit As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents tblTools As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuAdmin As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuCoyInfor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuServerInfor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChangePwd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBackupDB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestoreDB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents pnlPayAudit As System.Windows.Forms.Panel
    Private WithEvents lblInventory As System.Windows.Forms.Label
    Public WithEvents PicPayAudit As System.Windows.Forms.PictureBox
    Private WithEvents pnlReports As System.Windows.Forms.Panel
    Private WithEvents lblReports As System.Windows.Forms.Label
    Private WithEvents PicReports As System.Windows.Forms.PictureBox
    Private WithEvents pnlAdmin As System.Windows.Forms.Panel
    Private WithEvents lblPayment As System.Windows.Forms.Label
    Private WithEvents PicAdmin As System.Windows.Forms.PictureBox
    Private WithEvents pnlRptBuilder As System.Windows.Forms.Panel
    Private WithEvents lblDashBoard As System.Windows.Forms.Label
    Private WithEvents PicRptBuilder As System.Windows.Forms.PictureBox
    Friend WithEvents lnkWebsite As System.Windows.Forms.LinkLabel
    Friend WithEvents OwnerLogo As System.Windows.Forms.PictureBox
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lblTime As System.Windows.Forms.Label
    Private WithEvents lblDayName As System.Windows.Forms.Label
    Private WithEvents lblDayNumber As System.Windows.Forms.Label
    Private WithEvents lblMonthYear As System.Windows.Forms.Label
    Private WithEvents pnlLogo As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSystemPeriod As System.Windows.Forms.Label
    Private WithEvents pnlAccounts As System.Windows.Forms.Panel
    Private WithEvents lblAccounts As System.Windows.Forms.Label
    Public WithEvents PicAccounts As System.Windows.Forms.PictureBox
    Private WithEvents pnlPayroll As System.Windows.Forms.Panel
    Private WithEvents lblEmployees As System.Windows.Forms.Label
    Public WithEvents PicPayroll As System.Windows.Forms.PictureBox
    Private WithEvents pnlSC As System.Windows.Forms.Panel
    Private WithEvents lblBoarding As System.Windows.Forms.Label
    Public WithEvents PicSC As System.Windows.Forms.PictureBox
    Private WithEvents pnlHR As System.Windows.Forms.Panel
    Private WithEvents lblStudent As System.Windows.Forms.Label
    Public WithEvents PicHR As System.Windows.Forms.PictureBox
    Private WithEvents pnlFA As System.Windows.Forms.Panel
    Private WithEvents lblAdmission As System.Windows.Forms.Label
    Public WithEvents PicFA As System.Windows.Forms.PictureBox
    Private WithEvents lblMainTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblUserName2 As System.Windows.Forms.Label
    Friend WithEvents lblUserName1 As System.Windows.Forms.Label
    Friend WithEvents mnuLogOff As System.Windows.Forms.Label
    Friend WithEvents PictUserImage As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents TimCalender As System.Windows.Forms.Timer
    Private WithEvents FirstColumn As System.Windows.Forms.Timer
    Friend WithEvents CMMain As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuPict1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClearPicture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tblLogin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SvrInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lblAttemps As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents mnuDeleteUser As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Panel7 As System.Windows.Forms.Panel
    Private WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents PicCurrency As System.Windows.Forms.PictureBox
    Friend WithEvents mnuUpdateUser As System.Windows.Forms.ToolStripMenuItem

End Class
