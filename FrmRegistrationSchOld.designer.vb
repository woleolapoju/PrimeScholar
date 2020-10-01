<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrationSchOld
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrationSchOld))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lnkEntryLenght = New System.Windows.Forms.LinkLabel()
        Me.lnkCleanCommas = New System.Windows.Forms.LinkLabel()
        Me.lnkCleanData = New System.Windows.Forms.LinkLabel()
        Me.lnkShowFilterOption = New System.Windows.Forms.LinkLabel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.DGridList = New System.Windows.Forms.DataGridView()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        Me.PanFilter = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdCleanUp = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.tFilter = New System.Windows.Forms.TextBox()
        Me.SelColumn = New System.Windows.Forms.NumericUpDown()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmdFilter = New System.Windows.Forms.Button()
        Me.cmdRefresh2 = New System.Windows.Forms.Button()
        Me.cboCriteria = New System.Windows.Forms.ComboBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.chkMultiFilter = New System.Windows.Forms.CheckBox()
        Me.cmdCloseFilter = New System.Windows.Forms.Button()
        Me.Sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SwiftCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bank1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CountryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SortCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Country = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateSwiftCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateBankName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateBankAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateBankCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntermediateBankCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudyProgramme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IBAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGridList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanFilter.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SelColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AppHeader1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DGridList, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1112, 678)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(281, 625)
        Me.TableLayoutPanel3.TabIndex = 53
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cboCountry)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(273, 37)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 563
        Me.Label3.Text = "Country:"
        '
        'cboCountry
        '
        Me.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Items.AddRange(New Object() {"LGA", "MDA"})
        Me.cboCountry.Location = New System.Drawing.Point(48, 7)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(220, 23)
        Me.cboCountry.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.cmdNew)
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 573)
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lnkEntryLenght)
        Me.Panel3.Controls.Add(Me.lnkCleanCommas)
        Me.Panel3.Controls.Add(Me.lnkCleanData)
        Me.Panel3.Controls.Add(Me.lnkShowFilterOption)
        Me.Panel3.Controls.Add(Me.cmdClose)
        Me.Panel3.Controls.Add(Me.lblCount)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 461)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(273, 112)
        Me.Panel3.TabIndex = 572
        '
        'lnkEntryLenght
        '
        Me.lnkEntryLenght.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkEntryLenght.AutoSize = True
        Me.lnkEntryLenght.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEntryLenght.Location = New System.Drawing.Point(4, 34)
        Me.lnkEntryLenght.Name = "lnkEntryLenght"
        Me.lnkEntryLenght.Size = New System.Drawing.Size(132, 17)
        Me.lnkEntryLenght.TabIndex = 580
        Me.lnkEntryLenght.TabStop = True
        Me.lnkEntryLenght.Text = "Check Entry Lenght"
        '
        'lnkCleanCommas
        '
        Me.lnkCleanCommas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkCleanCommas.AutoSize = True
        Me.lnkCleanCommas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCleanCommas.Location = New System.Drawing.Point(175, 34)
        Me.lnkCleanCommas.Name = "lnkCleanCommas"
        Me.lnkCleanCommas.Size = New System.Drawing.Size(89, 17)
        Me.lnkCleanCommas.TabIndex = 579
        Me.lnkCleanCommas.TabStop = True
        Me.lnkCleanCommas.Text = "Comma Data"
        Me.lnkCleanCommas.Visible = False
        '
        'lnkCleanData
        '
        Me.lnkCleanData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkCleanData.AutoSize = True
        Me.lnkCleanData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCleanData.Location = New System.Drawing.Point(4, 7)
        Me.lnkCleanData.Name = "lnkCleanData"
        Me.lnkCleanData.Size = New System.Drawing.Size(78, 17)
        Me.lnkCleanData.TabIndex = 577
        Me.lnkCleanData.TabStop = True
        Me.lnkCleanData.Text = "Clean Data"
        '
        'lnkShowFilterOption
        '
        Me.lnkShowFilterOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkShowFilterOption.AutoSize = True
        Me.lnkShowFilterOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkShowFilterOption.Location = New System.Drawing.Point(147, 7)
        Me.lnkShowFilterOption.Name = "lnkShowFilterOption"
        Me.lnkShowFilterOption.Size = New System.Drawing.Size(123, 17)
        Me.lnkShowFilterOption.TabIndex = 574
        Me.lnkShowFilterOption.TabStop = True
        Me.lnkShowFilterOption.Text = "Show Filter Option"
        '
        'cmdClose
        '
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(0, 74)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(273, 38)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(55, 56)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(122, 23)
        Me.lblCount.TabIndex = 571
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 570
        Me.Label4.Text = "List Count"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSave
        '
        Me.cmdSave.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(0, 76)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(273, 38)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "Update"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(0, 38)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(273, 38)
        Me.cmdNew.TabIndex = 10
        Me.cmdNew.Text = "New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Location = New System.Drawing.Point(0, 0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(273, 38)
        Me.cmdRefresh.TabIndex = 8
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.AppHeader1, 2)
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(1, 0)
        Me.AppHeader1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(1110, 53)
        Me.AppHeader1.TabIndex = 55
        '
        'DGridList
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DGridList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sn, Me.tName, Me.Account, Me.State, Me.City1, Me.SwiftCode, Me.Bank1, Me.BankAddress, Me.Currency, Me.CountryCode, Me.SortCode, Me.Country, Me.BankCountry, Me.BankCity, Me.IntermediateSwiftCode, Me.IntermediateBankName, Me.IntermediateBankAddress, Me.IntermediateBankCity, Me.IntermediateBankCountry, Me.IDNumber, Me.StudyProgramme, Me.IBAN, Me.Remark, Me.TheActive})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridList.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGridList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGridList.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGridList.Location = New System.Drawing.Point(287, 56)
        Me.DGridList.Name = "DGridList"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGridList.RowHeadersWidth = 15
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGridList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.Size = New System.Drawing.Size(822, 619)
        Me.DGridList.TabIndex = 56
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.ForeColor = System.Drawing.Color.Red
        Me.chkSelectAll.Location = New System.Drawing.Point(1039, 30)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(61, 16)
        Me.chkSelectAll.TabIndex = 571
        Me.chkSelectAll.Text = "Select all"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        Me.chkSelectAll.Visible = False
        '
        'PanFilter
        '
        Me.PanFilter.AllowDrop = True
        Me.PanFilter.BackColor = System.Drawing.Color.Goldenrod
        Me.PanFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanFilter.Controls.Add(Me.Panel4)
        Me.PanFilter.Controls.Add(Me.cmdCloseFilter)
        Me.PanFilter.Location = New System.Drawing.Point(449, 305)
        Me.PanFilter.Name = "PanFilter"
        Me.PanFilter.Size = New System.Drawing.Size(415, 114)
        Me.PanFilter.TabIndex = 573
        Me.PanFilter.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cmdExport)
        Me.Panel4.Controls.Add(Me.cmdCleanUp)
        Me.Panel4.Controls.Add(Me.UsernameLabel)
        Me.Panel4.Controls.Add(Me.tFilter)
        Me.Panel4.Controls.Add(Me.SelColumn)
        Me.Panel4.Controls.Add(Me.lblFilter)
        Me.Panel4.Controls.Add(Me.cmdFilter)
        Me.Panel4.Controls.Add(Me.cmdRefresh2)
        Me.Panel4.Controls.Add(Me.cboCriteria)
        Me.Panel4.Controls.Add(Me.cmdFind)
        Me.Panel4.Controls.Add(Me.chkMultiFilter)
        Me.Panel4.Location = New System.Drawing.Point(4, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(405, 83)
        Me.Panel4.TabIndex = 280
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(309, 55)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(93, 23)
        Me.cmdExport.TabIndex = 278
        Me.cmdExport.Text = "EXPORT DATA"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdCleanUp
        '
        Me.cmdCleanUp.Location = New System.Drawing.Point(95, 57)
        Me.cmdCleanUp.Name = "cmdCleanUp"
        Me.cmdCleanUp.Size = New System.Drawing.Size(93, 23)
        Me.cmdCleanUp.TabIndex = 279
        Me.cmdCleanUp.Text = "CLEAN DATA"
        Me.cmdCleanUp.UseVisualStyleBackColor = True
        Me.cmdCleanUp.Visible = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(3, 6)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(91, 23)
        Me.UsernameLabel.TabIndex = 18
        Me.UsernameLabel.Text = "&Selected Column:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tFilter
        '
        Me.tFilter.Location = New System.Drawing.Point(173, 33)
        Me.tFilter.Name = "tFilter"
        Me.tFilter.Size = New System.Drawing.Size(229, 20)
        Me.tFilter.TabIndex = 20
        '
        'SelColumn
        '
        Me.SelColumn.Location = New System.Drawing.Point(94, 10)
        Me.SelColumn.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.SelColumn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelColumn.Name = "SelColumn"
        Me.SelColumn.Size = New System.Drawing.Size(39, 20)
        Me.SelColumn.TabIndex = 21
        Me.SelColumn.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblFilter
        '
        Me.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFilter.ForeColor = System.Drawing.Color.Black
        Me.lblFilter.Location = New System.Drawing.Point(5, 33)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(61, 23)
        Me.lblFilter.TabIndex = 276
        Me.lblFilter.Text = "&Filter Text:"
        Me.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdFilter
        '
        Me.cmdFilter.Location = New System.Drawing.Point(219, 3)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(66, 27)
        Me.cmdFilter.TabIndex = 22
        Me.cmdFilter.Text = "F&ilter"
        Me.cmdFilter.UseVisualStyleBackColor = True
        '
        'cmdRefresh2
        '
        Me.cmdRefresh2.Location = New System.Drawing.Point(343, 3)
        Me.cmdRefresh2.Name = "cmdRefresh2"
        Me.cmdRefresh2.Size = New System.Drawing.Size(59, 27)
        Me.cmdRefresh2.TabIndex = 23
        Me.cmdRefresh2.Text = "&Refresh"
        Me.cmdRefresh2.UseVisualStyleBackColor = True
        '
        'cboCriteria
        '
        Me.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCriteria.FormattingEnabled = True
        Me.cboCriteria.Items.AddRange(New Object() {"=", "Containing", "Start With", "End With"})
        Me.cboCriteria.Location = New System.Drawing.Point(94, 33)
        Me.cboCriteria.Name = "cboCriteria"
        Me.cboCriteria.Size = New System.Drawing.Size(76, 20)
        Me.cboCriteria.TabIndex = 26
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(285, 3)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(59, 27)
        Me.cmdFind.TabIndex = 24
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'chkMultiFilter
        '
        Me.chkMultiFilter.AutoSize = True
        Me.chkMultiFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMultiFilter.ForeColor = System.Drawing.Color.Black
        Me.chkMultiFilter.Location = New System.Drawing.Point(136, 11)
        Me.chkMultiFilter.Name = "chkMultiFilter"
        Me.chkMultiFilter.Size = New System.Drawing.Size(73, 17)
        Me.chkMultiFilter.TabIndex = 25
        Me.chkMultiFilter.Text = "Multi-Filter"
        Me.chkMultiFilter.UseVisualStyleBackColor = True
        '
        'cmdCloseFilter
        '
        Me.cmdCloseFilter.BackColor = System.Drawing.Color.Firebrick
        Me.cmdCloseFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCloseFilter.ForeColor = System.Drawing.Color.White
        Me.cmdCloseFilter.Location = New System.Drawing.Point(390, 0)
        Me.cmdCloseFilter.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.cmdCloseFilter.Name = "cmdCloseFilter"
        Me.cmdCloseFilter.Size = New System.Drawing.Size(21, 21)
        Me.cmdCloseFilter.TabIndex = 275
        Me.cmdCloseFilter.Text = "X"
        Me.cmdCloseFilter.UseVisualStyleBackColor = False
        '
        'Sn
        '
        Me.Sn.DataPropertyName = "Sn"
        Me.Sn.Frozen = True
        Me.Sn.HeaderText = "RefNo"
        Me.Sn.Name = "Sn"
        Me.Sn.ReadOnly = True
        Me.Sn.Width = 40
        '
        'tName
        '
        Me.tName.DataPropertyName = "SchName"
        Me.tName.FillWeight = 115.0!
        Me.tName.Frozen = True
        Me.tName.HeaderText = "Beneficiary Name"
        Me.tName.MaxInputLength = 115
        Me.tName.Name = "tName"
        Me.tName.Width = 200
        '
        'Account
        '
        Me.Account.DataPropertyName = "BankAcctNo"
        Me.Account.FillWeight = 34.0!
        Me.Account.HeaderText = "Beneficiary Account Number"
        Me.Account.MaxInputLength = 34
        Me.Account.Name = "Account"
        Me.Account.Width = 150
        '
        'State
        '
        Me.State.DataPropertyName = "SchAddress"
        Me.State.FillWeight = 35.0!
        Me.State.HeaderText = "Beneficiary Address 1"
        Me.State.MaxInputLength = 35
        Me.State.Name = "State"
        Me.State.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.State.Width = 200
        '
        'City1
        '
        Me.City1.DataPropertyName = "SchCity"
        Me.City1.FillWeight = 35.0!
        Me.City1.HeaderText = "Beneficiary Address 2"
        Me.City1.MaxInputLength = 35
        Me.City1.Name = "City1"
        Me.City1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'SwiftCode
        '
        Me.SwiftCode.DataPropertyName = "SwiftCode"
        Me.SwiftCode.FillWeight = 11.0!
        Me.SwiftCode.HeaderText = "Beneficiary Bank Swift Code"
        Me.SwiftCode.MaxInputLength = 11
        Me.SwiftCode.Name = "SwiftCode"
        Me.SwiftCode.Width = 150
        '
        'Bank1
        '
        Me.Bank1.DataPropertyName = "BankName"
        Me.Bank1.FillWeight = 35.0!
        Me.Bank1.HeaderText = "Beneficiary Bank Name"
        Me.Bank1.MaxInputLength = 35
        Me.Bank1.Name = "Bank1"
        Me.Bank1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bank1.Width = 150
        '
        'BankAddress
        '
        Me.BankAddress.DataPropertyName = "BankAddress"
        Me.BankAddress.FillWeight = 105.0!
        Me.BankAddress.HeaderText = "Beneficiary Bank Address"
        Me.BankAddress.MaxInputLength = 105
        Me.BankAddress.Name = "BankAddress"
        Me.BankAddress.Width = 150
        '
        'Currency
        '
        Me.Currency.DataPropertyName = "Currency"
        Me.Currency.FillWeight = 3.0!
        Me.Currency.HeaderText = "Payment Currency"
        Me.Currency.Name = "Currency"
        Me.Currency.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Currency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Currency.Width = 65
        '
        'CountryCode
        '
        Me.CountryCode.DataPropertyName = "CountryCode"
        Me.CountryCode.FillWeight = 5.0!
        Me.CountryCode.HeaderText = "Beneficiary Country Code"
        Me.CountryCode.MaxInputLength = 5
        Me.CountryCode.Name = "CountryCode"
        Me.CountryCode.Width = 130
        '
        'SortCode
        '
        Me.SortCode.DataPropertyName = "SortCode"
        Me.SortCode.HeaderText = "Beneficiary SortCode"
        Me.SortCode.Name = "SortCode"
        '
        'Country
        '
        Me.Country.DataPropertyName = "SchCountry"
        Me.Country.FillWeight = 35.0!
        Me.Country.HeaderText = "Beneficiary Country"
        Me.Country.MaxInputLength = 35
        Me.Country.Name = "Country"
        '
        'BankCountry
        '
        Me.BankCountry.DataPropertyName = "BankCountry"
        Me.BankCountry.FillWeight = 35.0!
        Me.BankCountry.HeaderText = "BankCountry"
        Me.BankCountry.MaxInputLength = 35
        Me.BankCountry.Name = "BankCountry"
        '
        'BankCity
        '
        Me.BankCity.DataPropertyName = "BankCity"
        Me.BankCity.FillWeight = 35.0!
        Me.BankCity.HeaderText = "BankCity"
        Me.BankCity.MaxInputLength = 35
        Me.BankCity.Name = "BankCity"
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
        Me.IntermediateBankName.Width = 200
        '
        'IntermediateBankAddress
        '
        Me.IntermediateBankAddress.DataPropertyName = "IntermediateBankAddress"
        Me.IntermediateBankAddress.FillWeight = 105.0!
        Me.IntermediateBankAddress.HeaderText = "Intermediate BankAddress"
        Me.IntermediateBankAddress.MaxInputLength = 105
        Me.IntermediateBankAddress.Name = "IntermediateBankAddress"
        Me.IntermediateBankAddress.Width = 200
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
        'IDNumber
        '
        Me.IDNumber.DataPropertyName = "IDNumber"
        Me.IDNumber.HeaderText = "IDNumber"
        Me.IDNumber.Name = "IDNumber"
        '
        'StudyProgramme
        '
        Me.StudyProgramme.DataPropertyName = "StudyProgramme"
        Me.StudyProgramme.HeaderText = "StudyProgramme"
        Me.StudyProgramme.Name = "StudyProgramme"
        '
        'IBAN
        '
        Me.IBAN.DataPropertyName = "IBAN"
        Me.IBAN.FillWeight = 34.0!
        Me.IBAN.HeaderText = "IBAN"
        Me.IBAN.MaxInputLength = 34
        Me.IBAN.Name = "IBAN"
        '
        'Remark
        '
        Me.Remark.DataPropertyName = "Remark"
        Me.Remark.FillWeight = 900.0!
        Me.Remark.HeaderText = "Remark"
        Me.Remark.MaxInputLength = 900
        Me.Remark.Name = "Remark"
        Me.Remark.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Remark.Width = 150
        '
        'TheActive
        '
        Me.TheActive.DataPropertyName = "Active"
        Me.TheActive.HeaderText = "Active"
        Me.TheActive.Name = "TheActive"
        Me.TheActive.Width = 50
        '
        'FrmRegistrationSch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1112, 678)
        Me.Controls.Add(Me.PanFilter)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistrationSch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGridList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanFilter.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.SelColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lnkShowFilterOption As System.Windows.Forms.LinkLabel
    Friend WithEvents PanFilter As System.Windows.Forms.Panel
    Friend WithEvents cmdCleanUp As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents cmdCloseFilter As System.Windows.Forms.Button
    Friend WithEvents cboCriteria As System.Windows.Forms.ComboBox
    Friend WithEvents chkMultiFilter As System.Windows.Forms.CheckBox
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh2 As System.Windows.Forms.Button
    Friend WithEvents cmdFilter As System.Windows.Forms.Button
    Friend WithEvents SelColumn As System.Windows.Forms.NumericUpDown
    Friend WithEvents tFilter As System.Windows.Forms.TextBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents lnkCleanData As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
    Friend WithEvents lnkCleanCommas As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkEntryLenght As System.Windows.Forms.LinkLabel
    Friend WithEvents DGridList As System.Windows.Forms.DataGridView
    Friend WithEvents Sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SwiftCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bank1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Currency As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CountryCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SortCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Country As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankCountry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateSwiftCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateBankName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateBankAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateBankCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntermediateBankCountry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudyProgramme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IBAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TheActive As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
