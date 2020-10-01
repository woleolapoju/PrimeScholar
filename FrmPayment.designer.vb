<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPayment))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TVList = New System.Windows.Forms.TreeView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboMandateNo = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuPrintMandate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportMandate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCSV = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEXCEL = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuCleanData = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.lnkSuggest = New System.Windows.Forms.LinkLabel()
        Me.tMandateSn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboCriteria = New System.Windows.Forms.ComboBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.tFilterText2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tCustomerRefSn = New System.Windows.Forms.TextBox()
        Me.tCustomerRefNo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.tTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cmdClean = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGridList = New System.Windows.Forms.DataGridView()
        Me.Sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerRefNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeneficiaryRefID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SwiftCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bank1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeneficiaryCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Period = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayType1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayType = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PaymentDetails1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDetails2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitAcctNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateSwiftCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateBankName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateBankAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateBankCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateBankCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDRefNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProxySource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdIDNo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SchoolID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Source = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Void = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cntxActions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCopyAmount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyDRAccountNo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyPeriod = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyPaymentTypes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuGeneratePaymentDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyPayDetail1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearPaymentDetails1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuGenerateCustomerRef = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyCustomerRef = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearCustomerRefNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRegenerateBeneficiaryRefID = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearPaymentDetails2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopyPayDetail2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.myCloneSelectedRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGetTotalOfSelectedRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        Me.cmdRegister = New System.Windows.Forms.Button()
        Me.cmdSchRegister = New System.Windows.Forms.Button()
        Me.cmdLedger = New System.Windows.Forms.Button()
        Me.cmdPayType = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdCurrency = New System.Windows.Forms.Button()
        Me.cmdStaff = New System.Windows.Forms.Button()
        Me.PanSelection = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmdFindtxt = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdFilter = New System.Windows.Forms.Button()
        Me.tFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblListCount = New System.Windows.Forms.Label()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lvList = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdCloseFilter = New System.Windows.Forms.Button()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DGridList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cntxActions.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanSelection.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.AppHeader1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1112, 732)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(0, 0)
        Me.AppHeader1.Margin = New System.Windows.Forms.Padding(0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(1112, 55)
        Me.AppHeader1.TabIndex = 55
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 58)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGridList)
        Me.SplitContainer1.Size = New System.Drawing.Size(1106, 671)
        Me.SplitContainer1.SplitterDistance = 301
        Me.SplitContainer1.TabIndex = 56
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 667.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(297, 667)
        Me.TableLayoutPanel3.TabIndex = 53
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TVList, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(291, 661)
        Me.TableLayoutPanel2.TabIndex = 575
        '
        'TVList
        '
        Me.TVList.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TVList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TVList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TVList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TVList.HideSelection = False
        Me.TVList.LineColor = System.Drawing.Color.Crimson
        Me.TVList.Location = New System.Drawing.Point(1, 1)
        Me.TVList.Margin = New System.Windows.Forms.Padding(0)
        Me.TVList.Name = "TVList"
        Me.TVList.SelectedImageKey = "NodeClose.bmp"
        Me.TVList.Size = New System.Drawing.Size(289, 401)
        Me.TVList.TabIndex = 573
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cboMandateNo)
        Me.Panel3.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel3.Controls.Add(Me.lnkSuggest)
        Me.Panel3.Controls.Add(Me.tMandateSn)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.dtpDate)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Location = New System.Drawing.Point(4, 466)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(283, 191)
        Me.Panel3.TabIndex = 572
        '
        'cboMandateNo
        '
        Me.cboMandateNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboMandateNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMandateNo.FormattingEnabled = True
        Me.cboMandateNo.Location = New System.Drawing.Point(91, 5)
        Me.cboMandateNo.Name = "cboMandateNo"
        Me.cboMandateNo.Size = New System.Drawing.Size(126, 30)
        Me.cboMandateNo.TabIndex = 576
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.MenuStrip2, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Panel7, 0, 4)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 80)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(283, 111)
        Me.TableLayoutPanel5.TabIndex = 281
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrintMandate, Me.mnuExportMandate})
        Me.MenuStrip1.Location = New System.Drawing.Point(6, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(274, 27)
        Me.MenuStrip1.TabIndex = 573
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuPrintMandate
        '
        Me.mnuPrintMandate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnuPrintMandate.Name = "mnuPrintMandate"
        Me.mnuPrintMandate.Size = New System.Drawing.Size(127, 23)
        Me.mnuPrintMandate.Text = "PRINT MANDATE"
        '
        'mnuExportMandate
        '
        Me.mnuExportMandate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCSV, Me.mnuEXCEL})
        Me.mnuExportMandate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.mnuExportMandate.Name = "mnuExportMandate"
        Me.mnuExportMandate.Size = New System.Drawing.Size(139, 23)
        Me.mnuExportMandate.Text = "EXPORT MANDATE"
        '
        'mnuCSV
        '
        Me.mnuCSV.Name = "mnuCSV"
        Me.mnuCSV.Size = New System.Drawing.Size(116, 24)
        Me.mnuCSV.Text = "CSV"
        '
        'mnuEXCEL
        '
        Me.mnuEXCEL.Name = "mnuEXCEL"
        Me.mnuEXCEL.Size = New System.Drawing.Size(116, 24)
        Me.mnuEXCEL.Text = "EXCEL"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCleanData})
        Me.MenuStrip2.Location = New System.Drawing.Point(6, 33)
        Me.MenuStrip2.Margin = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(117, 24)
        Me.MenuStrip2.TabIndex = 574
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnuCleanData
        '
        Me.mnuCleanData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnuCleanData.ForeColor = System.Drawing.Color.OrangeRed
        Me.mnuCleanData.Name = "mnuCleanData"
        Me.mnuCleanData.Size = New System.Drawing.Size(109, 20)
        Me.mnuCleanData.Text = "CLEAN DATA       "
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel7.Controls.Add(Me.cmdSave)
        Me.Panel7.Controls.Add(Me.cmdClose)
        Me.Panel7.Controls.Add(Me.cmdClear)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 66)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(277, 42)
        Me.Panel7.TabIndex = 575
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(2, 2)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(124, 39)
        Me.cmdSave.TabIndex = 578
        Me.cmdSave.Text = "SAVE PAYMENT"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(215, 2)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(60, 39)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(138, 2)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(77, 39)
        Me.cmdClear.TabIndex = 579
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'lnkSuggest
        '
        Me.lnkSuggest.AutoSize = True
        Me.lnkSuggest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lnkSuggest.LinkColor = System.Drawing.Color.Red
        Me.lnkSuggest.Location = New System.Drawing.Point(88, 31)
        Me.lnkSuggest.Name = "lnkSuggest"
        Me.lnkSuggest.Size = New System.Drawing.Size(135, 19)
        Me.lnkSuggest.TabIndex = 587
        Me.lnkSuggest.TabStop = True
        Me.lnkSuggest.Text = "Suggest MandateNo"
        '
        'tMandateSn
        '
        Me.tMandateSn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMandateSn.Location = New System.Drawing.Point(219, 5)
        Me.tMandateSn.Name = "tMandateSn"
        Me.tMandateSn.Size = New System.Drawing.Size(40, 23)
        Me.tMandateSn.TabIndex = 583
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 577
        Me.Label3.Text = "Mandate No:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 573
        Me.Label1.Text = "Value Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(91, 55)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(126, 23)
        Me.dtpDate.TabIndex = 572
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Purple
        Me.GroupBox4.Controls.Add(Me.cboCriteria)
        Me.GroupBox4.Controls.Add(Me.cmdFind)
        Me.GroupBox4.Controls.Add(Me.tFilterText2)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(73, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(14, 13)
        Me.GroupBox4.TabIndex = 569
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'cboCriteria
        '
        Me.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCriteria.FormattingEnabled = True
        Me.cboCriteria.Items.AddRange(New Object() {"=", "Containing", "Start With", "End With"})
        Me.cboCriteria.Location = New System.Drawing.Point(66, 13)
        Me.cboCriteria.Name = "cboCriteria"
        Me.cboCriteria.Size = New System.Drawing.Size(82, 20)
        Me.cboCriteria.TabIndex = 18
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(55, 44)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(87, 39)
        Me.cmdFind.TabIndex = 16
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'tFilterText2
        '
        Me.tFilterText2.Location = New System.Drawing.Point(7, 38)
        Me.tFilterText2.Name = "tFilterText2"
        Me.tFilterText2.Size = New System.Drawing.Size(165, 20)
        Me.tFilterText2.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.Location = New System.Drawing.Point(5, -23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 23)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Find Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.tCustomerRefSn)
        Me.Panel5.Controls.Add(Me.tCustomerRefNo)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(-4, 27)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(270, 22)
        Me.Panel5.TabIndex = 55
        '
        'tCustomerRefSn
        '
        Me.tCustomerRefSn.Location = New System.Drawing.Point(223, 2)
        Me.tCustomerRefSn.Name = "tCustomerRefSn"
        Me.tCustomerRefSn.Size = New System.Drawing.Size(40, 20)
        Me.tCustomerRefSn.TabIndex = 584
        '
        'tCustomerRefNo
        '
        Me.tCustomerRefNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.tCustomerRefNo.FormattingEnabled = True
        Me.tCustomerRefNo.Location = New System.Drawing.Point(95, 2)
        Me.tCustomerRefNo.Name = "tCustomerRefNo"
        Me.tCustomerRefNo.Size = New System.Drawing.Size(126, 21)
        Me.tCustomerRefNo.TabIndex = 581
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 582
        Me.Label2.Text = "Customer RefNo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblCount)
        Me.Panel1.Controls.Add(Me.cmdClean)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 406)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 53)
        Me.Panel1.TabIndex = 574
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblCurrency, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.tTotal, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(84, 5)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(183, 28)
        Me.TableLayoutPanel4.TabIndex = 587
        '
        'lblCurrency
        '
        Me.lblCurrency.AutoSize = True
        Me.lblCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrency.ForeColor = System.Drawing.Color.Red
        Me.lblCurrency.Location = New System.Drawing.Point(3, 0)
        Me.lblCurrency.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(24, 28)
        Me.lblCurrency.TabIndex = 586
        Me.lblCurrency.Text = "??"
        Me.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tTotal
        '
        Me.tTotal.BackColor = System.Drawing.Color.Black
        Me.tTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTotal.ForeColor = System.Drawing.Color.White
        Me.tTotal.Location = New System.Drawing.Point(27, 3)
        Me.tTotal.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.tTotal.Name = "tTotal"
        Me.tTotal.Size = New System.Drawing.Size(153, 27)
        Me.tTotal.TabIndex = 585
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 578
        Me.Label5.Text = "TOTAL:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCount.Location = New System.Drawing.Point(64, 30)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(18, 20)
        Me.lblCount.TabIndex = 571
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdClean
        '
        Me.cmdClean.Location = New System.Drawing.Point(194, 25)
        Me.cmdClean.Name = "cmdClean"
        Me.cmdClean.Size = New System.Drawing.Size(67, 22)
        Me.cmdClean.TabIndex = 585
        Me.cmdClean.Text = "CLEAN DATA"
        Me.cmdClean.UseVisualStyleBackColor = True
        Me.cmdClean.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 570
        Me.Label4.Text = "List Count"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGridList
        '
        Me.DGridList.AllowDrop = True
        Me.DGridList.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGridList.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sn, Me.CustomerRefNo, Me.BeneficiaryRefID, Me.tName, Me.Account, Me.Currency, Me.Amount, Me.SwiftCode, Me.Bank1, Me.BankAddress, Me.Address1, Me.BeneficiaryCountry, Me.CountryCode, Me.Period, Me.PayType1, Me.PayType, Me.PaymentDetails1, Me.PaymentDetails2, Me.DebitAcctNo, Me.City1, Me.BankCity, Me.BankCountry, Me.IntermediateSwiftCode, Me.IntermediateBankName, Me.IntermediateBankAddress, Me.IntermediateBankCity, Me.IntermediateBankCountry, Me.IDNo, Me.IDRefNo, Me.ProxySource, Me.cmdIDNo, Me.SchoolID, Me.SchName, Me.SchAddress, Me.SchCity, Me.SchoolCountry, Me.Source, Me.Remark, Me.Void})
        Me.DGridList.ContextMenuStrip = Me.cntxActions
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.DefaultCellStyle = DataGridViewCellStyle12
        Me.DGridList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGridList.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGridList.Location = New System.Drawing.Point(0, 0)
        Me.DGridList.Name = "DGridList"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DGridList.RowHeadersWidth = 25
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DGridList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.Size = New System.Drawing.Size(797, 667)
        Me.DGridList.TabIndex = 54
        '
        'Sn
        '
        Me.Sn.DataPropertyName = "Sn"
        Me.Sn.Frozen = True
        Me.Sn.HeaderText = "RefNo"
        Me.Sn.Name = "Sn"
        Me.Sn.ReadOnly = True
        Me.Sn.Width = 5
        '
        'CustomerRefNo
        '
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomerRefNo.DefaultCellStyle = DataGridViewCellStyle3
        Me.CustomerRefNo.FillWeight = 16.0!
        Me.CustomerRefNo.Frozen = True
        Me.CustomerRefNo.HeaderText = "CustomerRefNo"
        Me.CustomerRefNo.MaxInputLength = 16
        Me.CustomerRefNo.Name = "CustomerRefNo"
        Me.CustomerRefNo.Width = 120
        '
        'BeneficiaryRefID
        '
        Me.BeneficiaryRefID.FillWeight = 20.0!
        Me.BeneficiaryRefID.Frozen = True
        Me.BeneficiaryRefID.HeaderText = "BeneficiaryRefID"
        Me.BeneficiaryRefID.MaxInputLength = 20
        Me.BeneficiaryRefID.Name = "BeneficiaryRefID"
        Me.BeneficiaryRefID.Width = 50
        '
        'tName
        '
        Me.tName.DataPropertyName = "Name"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tName.DefaultCellStyle = DataGridViewCellStyle4
        Me.tName.FillWeight = 35.0!
        Me.tName.Frozen = True
        Me.tName.HeaderText = "Beneficiary Name"
        Me.tName.MaxInputLength = 35
        Me.tName.Name = "tName"
        Me.tName.Width = 200
        '
        'Account
        '
        Me.Account.DataPropertyName = "BankAcctNo"
        Me.Account.FillWeight = 34.0!
        Me.Account.HeaderText = "Bank Acct No"
        Me.Account.MaxInputLength = 34
        Me.Account.Name = "Account"
        Me.Account.Width = 150
        '
        'Currency
        '
        Me.Currency.DataPropertyName = "Currency"
        Me.Currency.FillWeight = 3.0!
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Items.AddRange(New Object() {"USD", "EUR", "GBP"})
        Me.Currency.Name = "Currency"
        Me.Currency.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Currency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Currency.Width = 60
        '
        'Amount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle5
        Me.Amount.FillWeight = 15.0!
        Me.Amount.HeaderText = "Amount"
        Me.Amount.MaxInputLength = 15
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 80
        '
        'SwiftCode
        '
        Me.SwiftCode.DataPropertyName = "SwiftCode"
        Me.SwiftCode.FillWeight = 11.0!
        Me.SwiftCode.HeaderText = "Swift Code"
        Me.SwiftCode.MaxInputLength = 11
        Me.SwiftCode.Name = "SwiftCode"
        '
        'Bank1
        '
        Me.Bank1.DataPropertyName = "BankName"
        Me.Bank1.FillWeight = 35.0!
        Me.Bank1.HeaderText = "Bank Name"
        Me.Bank1.MaxInputLength = 35
        Me.Bank1.Name = "Bank1"
        Me.Bank1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bank1.Width = 150
        '
        'BankAddress
        '
        Me.BankAddress.DataPropertyName = "BankAddress"
        Me.BankAddress.FillWeight = 35.0!
        Me.BankAddress.HeaderText = "Bank Address"
        Me.BankAddress.MaxInputLength = 35
        Me.BankAddress.Name = "BankAddress"
        Me.BankAddress.Width = 200
        '
        'Address1
        '
        Me.Address1.DataPropertyName = "Address"
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Address1.DefaultCellStyle = DataGridViewCellStyle6
        Me.Address1.FillWeight = 70.0!
        Me.Address1.HeaderText = "Beneficiary Address"
        Me.Address1.MaxInputLength = 70
        Me.Address1.Name = "Address1"
        Me.Address1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Address1.Width = 200
        '
        'BeneficiaryCountry
        '
        Me.BeneficiaryCountry.DataPropertyName = "Country"
        Me.BeneficiaryCountry.FillWeight = 10.0!
        Me.BeneficiaryCountry.HeaderText = "Beneficiary Country"
        Me.BeneficiaryCountry.MaxInputLength = 10
        Me.BeneficiaryCountry.Name = "BeneficiaryCountry"
        '
        'CountryCode
        '
        Me.CountryCode.DataPropertyName = "CountryCode"
        Me.CountryCode.FillWeight = 3.0!
        Me.CountryCode.HeaderText = "Country Code"
        Me.CountryCode.MaxInputLength = 3
        Me.CountryCode.Name = "CountryCode"
        '
        'Period
        '
        Me.Period.HeaderText = "Period"
        Me.Period.Name = "Period"
        '
        'PayType1
        '
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PayType1.DefaultCellStyle = DataGridViewCellStyle7
        Me.PayType1.FillWeight = 140.0!
        Me.PayType1.HeaderText = "PayType"
        Me.PayType1.Name = "PayType1"
        Me.PayType1.ReadOnly = True
        '
        'PayType
        '
        Me.PayType.HeaderText = ""
        Me.PayType.Name = "PayType"
        Me.PayType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PayType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PayType.Width = 30
        '
        'PaymentDetails1
        '
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentDetails1.DefaultCellStyle = DataGridViewCellStyle8
        Me.PaymentDetails1.FillWeight = 140.0!
        Me.PaymentDetails1.HeaderText = "PaymentDetails"
        Me.PaymentDetails1.MaxInputLength = 140
        Me.PaymentDetails1.Name = "PaymentDetails1"
        Me.PaymentDetails1.Width = 300
        '
        'PaymentDetails2
        '
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentDetails2.DefaultCellStyle = DataGridViewCellStyle9
        Me.PaymentDetails2.FillWeight = 140.0!
        Me.PaymentDetails2.HeaderText = "PaymentDetails2"
        Me.PaymentDetails2.MaxInputLength = 140
        Me.PaymentDetails2.Name = "PaymentDetails2"
        Me.PaymentDetails2.Visible = False
        Me.PaymentDetails2.Width = 150
        '
        'DebitAcctNo
        '
        Me.DebitAcctNo.FillWeight = 40.0!
        Me.DebitAcctNo.HeaderText = "DebitAcctNo"
        Me.DebitAcctNo.MaxInputLength = 40
        Me.DebitAcctNo.Name = "DebitAcctNo"
        '
        'City1
        '
        Me.City1.DataPropertyName = "City"
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.City1.DefaultCellStyle = DataGridViewCellStyle10
        Me.City1.FillWeight = 35.0!
        Me.City1.HeaderText = "Beneficiary Address 2"
        Me.City1.MaxInputLength = 35
        Me.City1.Name = "City1"
        Me.City1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.City1.Width = 200
        '
        'BankCity
        '
        Me.BankCity.DataPropertyName = "BankCity"
        Me.BankCity.FillWeight = 35.0!
        Me.BankCity.HeaderText = "BankCity"
        Me.BankCity.MaxInputLength = 35
        Me.BankCity.Name = "BankCity"
        '
        'BankCountry
        '
        Me.BankCountry.DataPropertyName = "BankCountry"
        Me.BankCountry.FillWeight = 3.0!
        Me.BankCountry.HeaderText = "BankCountry Code"
        Me.BankCountry.MaxInputLength = 3
        Me.BankCountry.Name = "BankCountry"
        '
        'IntermediateSwiftCode
        '
        Me.IntermediateSwiftCode.DataPropertyName = "IntermediateSwiftCode"
        Me.IntermediateSwiftCode.FillWeight = 11.0!
        Me.IntermediateSwiftCode.HeaderText = "Intermediate SwiftCode"
        Me.IntermediateSwiftCode.MaxInputLength = 11
        Me.IntermediateSwiftCode.Name = "IntermediateSwiftCode"
        '
        'IntermediateBankName
        '
        Me.IntermediateBankName.DataPropertyName = "IntermediateBankName"
        Me.IntermediateBankName.FillWeight = 35.0!
        Me.IntermediateBankName.HeaderText = "Intermediate BankName"
        Me.IntermediateBankName.MaxInputLength = 35
        Me.IntermediateBankName.Name = "IntermediateBankName"
        '
        'IntermediateBankAddress
        '
        Me.IntermediateBankAddress.DataPropertyName = "IntermediateBankAddress"
        Me.IntermediateBankAddress.FillWeight = 105.0!
        Me.IntermediateBankAddress.HeaderText = "Intermediate BankAddress"
        Me.IntermediateBankAddress.MaxInputLength = 105
        Me.IntermediateBankAddress.Name = "IntermediateBankAddress"
        '
        'IntermediateBankCity
        '
        Me.IntermediateBankCity.DataPropertyName = "IntermediateBankCity"
        Me.IntermediateBankCity.FillWeight = 35.0!
        Me.IntermediateBankCity.HeaderText = "Intermediate BankCity"
        Me.IntermediateBankCity.MaxInputLength = 35
        Me.IntermediateBankCity.Name = "IntermediateBankCity"
        '
        'IntermediateBankCountry
        '
        Me.IntermediateBankCountry.DataPropertyName = "IntermediateBankCountry"
        Me.IntermediateBankCountry.FillWeight = 35.0!
        Me.IntermediateBankCountry.HeaderText = "Intermediate BankCountry"
        Me.IntermediateBankCountry.MaxInputLength = 35
        Me.IntermediateBankCountry.Name = "IntermediateBankCountry"
        '
        'IDNo
        '
        Me.IDNo.DataPropertyName = "IDNumber"
        Me.IDNo.HeaderText = "IDNo"
        Me.IDNo.Name = "IDNo"
        Me.IDNo.Width = 80
        '
        'IDRefNo
        '
        Me.IDRefNo.HeaderText = "Proxy RefNo"
        Me.IDRefNo.Name = "IDRefNo"
        '
        'ProxySource
        '
        Me.ProxySource.HeaderText = "ProxySource"
        Me.ProxySource.Name = "ProxySource"
        Me.ProxySource.Visible = False
        '
        'cmdIDNo
        '
        Me.cmdIDNo.HeaderText = ""
        Me.cmdIDNo.Name = "cmdIDNo"
        Me.cmdIDNo.Width = 30
        '
        'SchoolID
        '
        Me.SchoolID.DataPropertyName = "SchoolID"
        Me.SchoolID.HeaderText = "SchoolID"
        Me.SchoolID.Name = "SchoolID"
        Me.SchoolID.ReadOnly = True
        Me.SchoolID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SchoolID.Width = 50
        '
        'SchName
        '
        Me.SchName.DataPropertyName = "SchName"
        Me.SchName.FillWeight = 35.0!
        Me.SchName.HeaderText = "School Name"
        Me.SchName.MaxInputLength = 35
        Me.SchName.Name = "SchName"
        Me.SchName.ReadOnly = True
        Me.SchName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SchName.Width = 200
        '
        'SchAddress
        '
        Me.SchAddress.DataPropertyName = "SchAddress"
        Me.SchAddress.FillWeight = 105.0!
        Me.SchAddress.HeaderText = "School Address"
        Me.SchAddress.MaxInputLength = 105
        Me.SchAddress.Name = "SchAddress"
        Me.SchAddress.ReadOnly = True
        Me.SchAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SchAddress.Width = 200
        '
        'SchCity
        '
        Me.SchCity.DataPropertyName = "SchCity"
        Me.SchCity.FillWeight = 35.0!
        Me.SchCity.HeaderText = "School City"
        Me.SchCity.MaxInputLength = 35
        Me.SchCity.Name = "SchCity"
        Me.SchCity.ReadOnly = True
        Me.SchCity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'SchoolCountry
        '
        Me.SchoolCountry.DataPropertyName = "SchCountry"
        Me.SchoolCountry.FillWeight = 35.0!
        Me.SchoolCountry.HeaderText = "School Country"
        Me.SchoolCountry.MaxInputLength = 35
        Me.SchoolCountry.Name = "SchoolCountry"
        Me.SchoolCountry.ReadOnly = True
        Me.SchoolCountry.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Source
        '
        Me.Source.HeaderText = "Source"
        Me.Source.Name = "Source"
        Me.Source.ReadOnly = True
        Me.Source.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Source.Width = 5
        '
        'Remark
        '
        Me.Remark.FillWeight = 32767.0!
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Width = 200
        '
        'Void
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Void.DefaultCellStyle = DataGridViewCellStyle11
        Me.Void.HeaderText = "Void"
        Me.Void.Name = "Void"
        Me.Void.Width = 50
        '
        'cntxActions
        '
        Me.cntxActions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopyAmount, Me.mnuCopyDRAccountNo, Me.mnuCopyPeriod, Me.mnuCopyPaymentTypes, Me.ToolStripMenuItem1, Me.mnuGeneratePaymentDetails, Me.mnuCopyPayDetail1, Me.mnuClearPaymentDetails1, Me.ToolStripMenuItem2, Me.mnuGenerateCustomerRef, Me.mnuCopyCustomerRef, Me.ClearCustomerRefNoToolStripMenuItem, Me.ToolStripMenuItem3, Me.mnuRegenerateBeneficiaryRefID, Me.mnuClearPaymentDetails2, Me.mnuCopyPayDetail2, Me.ToolStripMenuItem4, Me.myCloneSelectedRows, Me.mnuGetTotalOfSelectedRows})
        Me.cntxActions.Name = "ContextMenuStrip1"
        Me.cntxActions.Size = New System.Drawing.Size(223, 358)
        '
        'mnuCopyAmount
        '
        Me.mnuCopyAmount.Name = "mnuCopyAmount"
        Me.mnuCopyAmount.Size = New System.Drawing.Size(222, 22)
        Me.mnuCopyAmount.Text = "Copy Amount"
        '
        'mnuCopyDRAccountNo
        '
        Me.mnuCopyDRAccountNo.Name = "mnuCopyDRAccountNo"
        Me.mnuCopyDRAccountNo.Size = New System.Drawing.Size(222, 22)
        Me.mnuCopyDRAccountNo.Text = "Copy DR Account No"
        '
        'mnuCopyPeriod
        '
        Me.mnuCopyPeriod.Name = "mnuCopyPeriod"
        Me.mnuCopyPeriod.Size = New System.Drawing.Size(222, 22)
        Me.mnuCopyPeriod.Text = "Copy Period"
        '
        'mnuCopyPaymentTypes
        '
        Me.mnuCopyPaymentTypes.Name = "mnuCopyPaymentTypes"
        Me.mnuCopyPaymentTypes.Size = New System.Drawing.Size(222, 22)
        Me.mnuCopyPaymentTypes.Text = "Copy Payment Types"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(219, 6)
        '
        'mnuGeneratePaymentDetails
        '
        Me.mnuGeneratePaymentDetails.Name = "mnuGeneratePaymentDetails"
        Me.mnuGeneratePaymentDetails.Size = New System.Drawing.Size(222, 22)
        Me.mnuGeneratePaymentDetails.Text = "Generate Payment Details"
        '
        'mnuCopyPayDetail1
        '
        Me.mnuCopyPayDetail1.Name = "mnuCopyPayDetail1"
        Me.mnuCopyPayDetail1.Size = New System.Drawing.Size(222, 22)
        Me.mnuCopyPayDetail1.Text = "Copy Payment Detail"
        '
        'mnuClearPaymentDetails1
        '
        Me.mnuClearPaymentDetails1.Name = "mnuClearPaymentDetails1"
        Me.mnuClearPaymentDetails1.Size = New System.Drawing.Size(222, 22)
        Me.mnuClearPaymentDetails1.Text = "Clear Payment Details"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(219, 6)
        '
        'mnuGenerateCustomerRef
        '
        Me.mnuGenerateCustomerRef.Name = "mnuGenerateCustomerRef"
        Me.mnuGenerateCustomerRef.Size = New System.Drawing.Size(222, 22)
        Me.mnuGenerateCustomerRef.Text = "Generate Customer RefNo"
        '
        'mnuCopyCustomerRef
        '
        Me.mnuCopyCustomerRef.Name = "mnuCopyCustomerRef"
        Me.mnuCopyCustomerRef.Size = New System.Drawing.Size(222, 22)
        Me.mnuCopyCustomerRef.Text = "Copy Customer RefNo"
        '
        'ClearCustomerRefNoToolStripMenuItem
        '
        Me.ClearCustomerRefNoToolStripMenuItem.Name = "ClearCustomerRefNoToolStripMenuItem"
        Me.ClearCustomerRefNoToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ClearCustomerRefNoToolStripMenuItem.Text = "Clear Customer RefNo"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(219, 6)
        '
        'mnuRegenerateBeneficiaryRefID
        '
        Me.mnuRegenerateBeneficiaryRefID.Name = "mnuRegenerateBeneficiaryRefID"
        Me.mnuRegenerateBeneficiaryRefID.Size = New System.Drawing.Size(222, 22)
        Me.mnuRegenerateBeneficiaryRefID.Text = "Regenerate BeneficiaryRefID"
        '
        'mnuClearPaymentDetails2
        '
        Me.mnuClearPaymentDetails2.Name = "mnuClearPaymentDetails2"
        Me.mnuClearPaymentDetails2.Size = New System.Drawing.Size(222, 22)
        Me.mnuClearPaymentDetails2.Text = "Clear Payment Detail 2"
        Me.mnuClearPaymentDetails2.Visible = False
        '
        'mnuCopyPayDetail2
        '
        Me.mnuCopyPayDetail2.Name = "mnuCopyPayDetail2"
        Me.mnuCopyPayDetail2.Size = New System.Drawing.Size(222, 22)
        Me.mnuCopyPayDetail2.Text = "Copy Payment Detail 2"
        Me.mnuCopyPayDetail2.Visible = False
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(219, 6)
        '
        'myCloneSelectedRows
        '
        Me.myCloneSelectedRows.Name = "myCloneSelectedRows"
        Me.myCloneSelectedRows.Size = New System.Drawing.Size(222, 22)
        Me.myCloneSelectedRows.Text = "Clone Selected Row(s)"
        '
        'mnuGetTotalOfSelectedRows
        '
        Me.mnuGetTotalOfSelectedRows.Name = "mnuGetTotalOfSelectedRows"
        Me.mnuGetTotalOfSelectedRows.Size = New System.Drawing.Size(222, 22)
        Me.mnuGetTotalOfSelectedRows.Text = "Get Total of Selected Row(s)"
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.BackColor = System.Drawing.Color.Goldenrod
        Me.chkSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.ForeColor = System.Drawing.Color.White
        Me.chkSelectAll.Location = New System.Drawing.Point(380, 12)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(93, 16)
        Me.chkSelectAll.TabIndex = 571
        Me.chkSelectAll.Text = "Void All Records"
        Me.chkSelectAll.UseVisualStyleBackColor = False
        '
        'cmdRegister
        '
        Me.cmdRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRegister.Location = New System.Drawing.Point(26, 4)
        Me.cmdRegister.Name = "cmdRegister"
        Me.cmdRegister.Size = New System.Drawing.Size(105, 29)
        Me.cmdRegister.TabIndex = 588
        Me.cmdRegister.Text = "Scholar"
        Me.cmdRegister.UseVisualStyleBackColor = True
        '
        'cmdSchRegister
        '
        Me.cmdSchRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSchRegister.Location = New System.Drawing.Point(133, 4)
        Me.cmdSchRegister.Name = "cmdSchRegister"
        Me.cmdSchRegister.Size = New System.Drawing.Size(105, 29)
        Me.cmdSchRegister.TabIndex = 589
        Me.cmdSchRegister.Text = "Institution"
        Me.cmdSchRegister.UseVisualStyleBackColor = True
        '
        'cmdLedger
        '
        Me.cmdLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdLedger.Location = New System.Drawing.Point(491, 3)
        Me.cmdLedger.Name = "cmdLedger"
        Me.cmdLedger.Size = New System.Drawing.Size(61, 29)
        Me.cmdLedger.TabIndex = 590
        Me.cmdLedger.Text = "Ledger"
        Me.cmdLedger.UseVisualStyleBackColor = True
        '
        'cmdPayType
        '
        Me.cmdPayType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdPayType.Location = New System.Drawing.Point(554, 3)
        Me.cmdPayType.Name = "cmdPayType"
        Me.cmdPayType.Size = New System.Drawing.Size(93, 29)
        Me.cmdPayType.TabIndex = 591
        Me.cmdPayType.Text = "Payment Type"
        Me.cmdPayType.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel2.Controls.Add(Me.cmdCurrency)
        Me.Panel2.Controls.Add(Me.cmdStaff)
        Me.Panel2.Controls.Add(Me.cmdPayType)
        Me.Panel2.Controls.Add(Me.chkSelectAll)
        Me.Panel2.Controls.Add(Me.cmdRegister)
        Me.Panel2.Controls.Add(Me.cmdLedger)
        Me.Panel2.Controls.Add(Me.cmdSchRegister)
        Me.Panel2.Location = New System.Drawing.Point(281, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(783, 35)
        Me.Panel2.TabIndex = 592
        '
        'cmdCurrency
        '
        Me.cmdCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdCurrency.Location = New System.Drawing.Point(649, 3)
        Me.cmdCurrency.Name = "cmdCurrency"
        Me.cmdCurrency.Size = New System.Drawing.Size(126, 29)
        Me.cmdCurrency.TabIndex = 593
        Me.cmdCurrency.Text = "Currency/DR Accounts"
        Me.cmdCurrency.UseVisualStyleBackColor = True
        '
        'cmdStaff
        '
        Me.cmdStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStaff.Location = New System.Drawing.Point(241, 4)
        Me.cmdStaff.Name = "cmdStaff"
        Me.cmdStaff.Size = New System.Drawing.Size(105, 29)
        Me.cmdStaff.TabIndex = 592
        Me.cmdStaff.Text = "Staff/Stakeholders"
        Me.cmdStaff.UseVisualStyleBackColor = True
        '
        'PanSelection
        '
        Me.PanSelection.AllowDrop = True
        Me.PanSelection.BackColor = System.Drawing.Color.Goldenrod
        Me.PanSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanSelection.Controls.Add(Me.Panel6)
        Me.PanSelection.Controls.Add(Me.cmdLoad)
        Me.PanSelection.Controls.Add(Me.chkAll)
        Me.PanSelection.Controls.Add(Me.Panel4)
        Me.PanSelection.Controls.Add(Me.cmdCloseFilter)
        Me.PanSelection.Controls.Add(Me.lblChoice)
        Me.PanSelection.Location = New System.Drawing.Point(379, 200)
        Me.PanSelection.Name = "PanSelection"
        Me.PanSelection.Size = New System.Drawing.Size(625, 456)
        Me.PanSelection.TabIndex = 593
        Me.PanSelection.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmdFindtxt)
        Me.Panel6.Controls.Add(Me.cmdRefresh)
        Me.Panel6.Controls.Add(Me.cmdFilter)
        Me.Panel6.Controls.Add(Me.tFilter)
        Me.Panel6.Controls.Add(Me.lblFilter)
        Me.Panel6.Controls.Add(Me.lblListCount)
        Me.Panel6.Location = New System.Drawing.Point(6, 419)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(463, 27)
        Me.Panel6.TabIndex = 574
        '
        'cmdFindtxt
        '
        Me.cmdFindtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdFindtxt.Location = New System.Drawing.Point(286, 2)
        Me.cmdFindtxt.Name = "cmdFindtxt"
        Me.cmdFindtxt.Size = New System.Drawing.Size(55, 21)
        Me.cmdFindtxt.TabIndex = 577
        Me.cmdFindtxt.Text = "Find"
        Me.cmdFindtxt.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdRefresh.Location = New System.Drawing.Point(342, 2)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(55, 22)
        Me.cmdRefresh.TabIndex = 576
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdFilter
        '
        Me.cmdFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cmdFilter.Location = New System.Drawing.Point(230, 2)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(55, 21)
        Me.cmdFilter.TabIndex = 575
        Me.cmdFilter.Text = "F&ilter"
        Me.cmdFilter.UseVisualStyleBackColor = True
        '
        'tFilter
        '
        Me.tFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.tFilter.Location = New System.Drawing.Point(78, 2)
        Me.tFilter.Name = "tFilter"
        Me.tFilter.Size = New System.Drawing.Size(150, 21)
        Me.tFilter.TabIndex = 0
        '
        'lblFilter
        '
        Me.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblFilter.ForeColor = System.Drawing.Color.White
        Me.lblFilter.Location = New System.Drawing.Point(-3, 5)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(84, 15)
        Me.lblFilter.TabIndex = 573
        Me.lblFilter.Text = "Name contain"
        Me.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblListCount
        '
        Me.lblListCount.AutoSize = True
        Me.lblListCount.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblListCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListCount.ForeColor = System.Drawing.Color.Red
        Me.lblListCount.Location = New System.Drawing.Point(421, 7)
        Me.lblListCount.Name = "lblListCount"
        Me.lblListCount.Size = New System.Drawing.Size(14, 13)
        Me.lblListCount.TabIndex = 572
        Me.lblListCount.Text = "0"
        Me.lblListCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(485, 416)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(133, 31)
        Me.cmdLoad.TabIndex = 282
        Me.cmdLoad.Text = "Load Selected"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.ForeColor = System.Drawing.Color.White
        Me.chkAll.Location = New System.Drawing.Point(12, 5)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(70, 17)
        Me.chkAll.TabIndex = 281
        Me.chkAll.Text = "Select All"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lvList)
        Me.Panel4.Location = New System.Drawing.Point(5, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(613, 388)
        Me.Panel4.TabIndex = 280
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lvList.CheckBoxes = True
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvList.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.Location = New System.Drawing.Point(0, 0)
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(609, 384)
        Me.lvList.TabIndex = 54
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 260
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RefNo"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID No"
        Me.ColumnHeader6.Width = 71
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Bank"
        Me.ColumnHeader3.Width = 119
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Account No"
        Me.ColumnHeader4.Width = 95
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "School"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Source"
        Me.ColumnHeader7.Width = 5
        '
        'cmdCloseFilter
        '
        Me.cmdCloseFilter.BackColor = System.Drawing.Color.Firebrick
        Me.cmdCloseFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseFilter.ForeColor = System.Drawing.Color.White
        Me.cmdCloseFilter.Location = New System.Drawing.Point(595, 2)
        Me.cmdCloseFilter.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.cmdCloseFilter.Name = "cmdCloseFilter"
        Me.cmdCloseFilter.Size = New System.Drawing.Size(21, 21)
        Me.cmdCloseFilter.TabIndex = 275
        Me.cmdCloseFilter.Text = "X"
        Me.cmdCloseFilter.UseVisualStyleBackColor = False
        '
        'lblChoice
        '
        Me.lblChoice.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice.ForeColor = System.Drawing.Color.White
        Me.lblChoice.Location = New System.Drawing.Point(6, 4)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(610, 18)
        Me.lblChoice.TabIndex = 573
        Me.lblChoice.Text = "??"
        Me.lblChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1112, 732)
        Me.Controls.Add(Me.PanSelection)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPayment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DGridList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cntxActions.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanSelection.ResumeLayout(False)
        Me.PanSelection.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DGridList As System.Windows.Forms.DataGridView
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TVList As System.Windows.Forms.TreeView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCriteria As System.Windows.Forms.ComboBox
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents tFilterText2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboMandateNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tCustomerRefNo As System.Windows.Forms.ComboBox
    Friend WithEvents tCustomerRefSn As System.Windows.Forms.TextBox
    Friend WithEvents tMandateSn As System.Windows.Forms.TextBox
    Friend WithEvents cmdRegister As System.Windows.Forms.Button
    Friend WithEvents cmdSchRegister As System.Windows.Forms.Button
    Friend WithEvents cmdLedger As System.Windows.Forms.Button
    Friend WithEvents cmdPayType As System.Windows.Forms.Button
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanSelection As System.Windows.Forms.Panel
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cmdCloseFilter As System.Windows.Forms.Button
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblListCount As System.Windows.Forms.Label
    Friend WithEvents lblChoice As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lnkSuggest As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdStaff As System.Windows.Forms.Button
    Friend WithEvents cmdCurrency As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tFilter As System.Windows.Forms.TextBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents cmdFilter As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdFindtxt As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cntxActions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuCopyAmount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopyDRAccountNo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopyPeriod As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopyPaymentTypes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuGeneratePaymentDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClearPaymentDetails1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRegenerateBeneficiaryRefID As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopyCustomerRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopyPayDetail1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopyPayDetail2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClearPaymentDetails2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGenerateCustomerRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearCustomerRefNoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuPrintMandate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportMandate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuCleanData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCurrency As System.Windows.Forms.Label
    Friend WithEvents tTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents cmdClean As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mnuCSV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEXCEL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents myCloneSelectedRows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGetTotalOfSelectedRows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerRefNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeneficiaryRefID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Currency As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SwiftCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bank1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeneficiaryCountry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Period As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayType1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayType As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents PaymentDetails1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentDetails2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitAcctNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankCountry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateSwiftCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateBankName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateBankAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateBankCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateBankCountry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDRefNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProxySource As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdIDNo As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents SchoolID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolCountry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Source As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Void As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
