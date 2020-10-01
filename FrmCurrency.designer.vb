<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCurrency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCurrency))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.DbGrid = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.Currency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Symbol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitAcctNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nominator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Denominator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmdRefresh, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdNew, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdOk, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdClose, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 436)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(545, 30)
        Me.TableLayoutPanel2.TabIndex = 52
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(64, 0)
        Me.cmdRefresh.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(58, 30)
        Me.cmdRefresh.TabIndex = 58
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdNew.Location = New System.Drawing.Point(0, 0)
        Me.cmdNew.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(9, 30)
        Me.cmdNew.TabIndex = 56
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.Visible = False
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(9, 0)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(55, 30)
        Me.cmdOk.TabIndex = 53
        Me.cmdOk.Text = "&Update"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.Location = New System.Drawing.Point(482, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(63, 30)
        Me.cmdClose.TabIndex = 54
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'DbGrid
        '
        Me.DbGrid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        Me.DbGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DbGrid.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.DbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Currency, Me.Symbol, Me.DebitAcctNo, Me.Nominator, Me.Denominator})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DbGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DbGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGrid.Location = New System.Drawing.Point(4, 49)
        Me.DbGrid.Name = "DbGrid"
        Me.DbGrid.Size = New System.Drawing.Size(539, 383)
        Me.DbGrid.TabIndex = 51
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DbGrid, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AppHeader1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(547, 467)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(1, 1)
        Me.AppHeader1.Margin = New System.Windows.Forms.Padding(0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(545, 44)
        Me.AppHeader1.TabIndex = 53
        '
        'Currency
        '
        Me.Currency.DataPropertyName = "Currency"
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Name = "Currency"
        '
        'Symbol
        '
        Me.Symbol.DataPropertyName = "Symbol"
        Me.Symbol.HeaderText = "Symbol"
        Me.Symbol.Name = "Symbol"
        Me.Symbol.Width = 70
        '
        'DebitAcctNo
        '
        Me.DebitAcctNo.DataPropertyName = "DebitAcctNo"
        Me.DebitAcctNo.HeaderText = "DebitAcctNo"
        Me.DebitAcctNo.Name = "DebitAcctNo"
        Me.DebitAcctNo.Width = 110
        '
        'Nominator
        '
        Me.Nominator.DataPropertyName = "Nominator"
        Me.Nominator.HeaderText = "Nominator"
        Me.Nominator.Name = "Nominator"
        '
        'Denominator
        '
        Me.Denominator.DataPropertyName = "Denominator"
        Me.Denominator.HeaderText = "Denominator"
        Me.Denominator.Name = "Denominator"
        '
        'FrmCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(547, 467)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCurrency"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Setup"
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents DbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
    Friend WithEvents Currency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Symbol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitAcctNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nominator As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Denominator As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
