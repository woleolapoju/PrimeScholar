<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdvSearch
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdvSearch))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.DbGrid = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboCriteria = New System.Windows.Forms.ComboBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.tFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MandateNo = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.dIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tBName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tCurrency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerRefNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Source = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AppHeader1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DbGrid, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(995, 604)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.AppHeader1, 3)
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(0, 0)
        Me.AppHeader1.Margin = New System.Windows.Forms.Padding(0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(995, 44)
        Me.AppHeader1.TabIndex = 53
        '
        'DbGrid
        '
        Me.DbGrid.AllowUserToAddRows = False
        Me.DbGrid.AllowUserToDeleteRows = False
        Me.DbGrid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        Me.DbGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DbGrid.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.DbGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DbGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DbGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MandateNo, Me.dIndex, Me.tDate, Me.tBName, Me.Amount, Me.tCurrency, Me.Bank, Me.CustomerRefNo, Me.IDNumber, Me.Source})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DbGrid, 3)
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DbGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.DbGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGrid.Location = New System.Drawing.Point(3, 105)
        Me.DbGrid.Name = "DbGrid"
        Me.DbGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DbGrid.RowHeadersWidth = 10
        Me.DbGrid.Size = New System.Drawing.Size(989, 496)
        Me.DbGrid.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.cboCriteria)
        Me.Panel1.Controls.Add(Me.cmdSearch)
        Me.Panel1.Controls.Add(Me.tFilter)
        Me.Panel1.Controls.Add(Me.lblFilter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(267, 69)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 25, 3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 30)
        Me.Panel1.TabIndex = 54
        '
        'cboCriteria
        '
        Me.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCriteria.FormattingEnabled = True
        Me.cboCriteria.Items.AddRange(New Object() {"BENEFICIARY NAME", "AMOUNT", "PAYMENT DETAILS", "CUSTOMER REFNo", "BANK", "CURRENCY"})
        Me.cboCriteria.Location = New System.Drawing.Point(5, 5)
        Me.cboCriteria.Name = "cboCriteria"
        Me.cboCriteria.Size = New System.Drawing.Size(139, 21)
        Me.cboCriteria.TabIndex = 21
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(381, 2)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(74, 26)
        Me.cmdSearch.TabIndex = 20
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'tFilter
        '
        Me.tFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tFilter.Location = New System.Drawing.Point(147, 5)
        Me.tFilter.Name = "tFilter"
        Me.tFilter.Size = New System.Drawing.Size(232, 21)
        Me.tFilter.TabIndex = 0
        '
        'lblFilter
        '
        Me.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(114, -47)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(57, 13)
        Me.lblFilter.TabIndex = 18
        Me.lblFilter.Text = "Containing"
        Me.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblCount)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 27)
        Me.Panel2.TabIndex = 55
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(56, 2)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(122, 23)
        Me.lblCount.TabIndex = 573
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 572
        Me.Label4.Text = "List Found:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MandateNo
        '
        Me.MandateNo.DataPropertyName = "MandateNo"
        Me.MandateNo.HeaderText = "MandateNo"
        Me.MandateNo.Name = "MandateNo"
        Me.MandateNo.Width = 130
        '
        'dIndex
        '
        Me.dIndex.DataPropertyName = "dIndex"
        Me.dIndex.HeaderText = "dIndex"
        Me.dIndex.Name = "dIndex"
        Me.dIndex.Width = 5
        '
        'tDate
        '
        Me.tDate.DataPropertyName = "PayValueDate"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.tDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.tDate.HeaderText = "Date"
        Me.tDate.Name = "tDate"
        Me.tDate.Width = 80
        '
        'tBName
        '
        Me.tBName.DataPropertyName = "Name"
        Me.tBName.HeaderText = "Beneficiary Name"
        Me.tBName.Name = "tBName"
        Me.tBName.Width = 220
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 80
        '
        'tCurrency
        '
        Me.tCurrency.DataPropertyName = "Currency"
        Me.tCurrency.HeaderText = "Currency"
        Me.tCurrency.Name = "tCurrency"
        Me.tCurrency.Width = 80
        '
        'Bank
        '
        Me.Bank.DataPropertyName = "BankName"
        Me.Bank.HeaderText = "Bank"
        Me.Bank.Name = "Bank"
        Me.Bank.Width = 160
        '
        'CustomerRefNo
        '
        Me.CustomerRefNo.DataPropertyName = "CustomerRefNo"
        Me.CustomerRefNo.HeaderText = "Customer RefNo"
        Me.CustomerRefNo.Name = "CustomerRefNo"
        Me.CustomerRefNo.Width = 110
        '
        'IDNumber
        '
        Me.IDNumber.DataPropertyName = "IDNumber"
        Me.IDNumber.HeaderText = "ID Number"
        Me.IDNumber.Name = "IDNumber"
        Me.IDNumber.Width = 90
        '
        'Source
        '
        Me.Source.DataPropertyName = "Source"
        Me.Source.HeaderText = "Source"
        Me.Source.Name = "Source"
        '
        'FrmAdvSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(995, 604)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdvSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboCriteria As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents tFilter As System.Windows.Forms.TextBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents DbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MandateNo As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents dIndex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tBName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tCurrency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerRefNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Source As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
