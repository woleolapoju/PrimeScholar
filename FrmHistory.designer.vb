<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistory))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DbGrid = New System.Windows.Forms.DataGridView()
        Me.TheDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MandateNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheCurrency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDetails1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDetails2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lnkPrintLedger = New System.Windows.Forms.LinkLabel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tSchool = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tRefNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DbGrid, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AppHeader1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(790, 400)
        Me.TableLayoutPanel1.TabIndex = 552
        '
        'DbGrid
        '
        Me.DbGrid.AllowUserToAddRows = False
        Me.DbGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        Me.DbGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DbGrid.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.DbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TheDate, Me.MandateNo, Me.Amount, Me.TheCurrency, Me.PaymentDetails1, Me.PaymentDetails2, Me.Bank, Me.AccountNo})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DbGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.DbGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbGrid.Location = New System.Drawing.Point(3, 139)
        Me.DbGrid.Name = "DbGrid"
        Me.DbGrid.ReadOnly = True
        Me.DbGrid.Size = New System.Drawing.Size(784, 258)
        Me.DbGrid.TabIndex = 52
        '
        'TheDate
        '
        Me.TheDate.DataPropertyName = "PayValueDate"
        Me.TheDate.HeaderText = "Date"
        Me.TheDate.Name = "TheDate"
        Me.TheDate.ReadOnly = True
        Me.TheDate.Width = 70
        '
        'MandateNo
        '
        Me.MandateNo.DataPropertyName = "MandateNo"
        Me.MandateNo.HeaderText = "Mandate No"
        Me.MandateNo.Name = "MandateNo"
        Me.MandateNo.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'TheCurrency
        '
        Me.TheCurrency.DataPropertyName = "Currency"
        Me.TheCurrency.HeaderText = ""
        Me.TheCurrency.Name = "TheCurrency"
        Me.TheCurrency.ReadOnly = True
        Me.TheCurrency.Width = 50
        '
        'PaymentDetails1
        '
        Me.PaymentDetails1.DataPropertyName = "PayDetails1"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentDetails1.DefaultCellStyle = DataGridViewCellStyle2
        Me.PaymentDetails1.HeaderText = "PaymentDetails1"
        Me.PaymentDetails1.Name = "PaymentDetails1"
        Me.PaymentDetails1.ReadOnly = True
        '
        'PaymentDetails2
        '
        Me.PaymentDetails2.DataPropertyName = "PayDetails2"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentDetails2.DefaultCellStyle = DataGridViewCellStyle3
        Me.PaymentDetails2.HeaderText = "PaymentDetails2"
        Me.PaymentDetails2.Name = "PaymentDetails2"
        Me.PaymentDetails2.ReadOnly = True
        '
        'Bank
        '
        Me.Bank.DataPropertyName = "BankName"
        Me.Bank.HeaderText = "Bank"
        Me.Bank.Name = "Bank"
        Me.Bank.ReadOnly = True
        '
        'AccountNo
        '
        Me.AccountNo.DataPropertyName = "BankAcctNo"
        Me.AccountNo.HeaderText = "Account No"
        Me.AccountNo.Name = "AccountNo"
        Me.AccountNo.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lnkPrintLedger)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Controls.Add(Me.tSchool)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tRefNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 81)
        Me.Panel1.TabIndex = 0
        '
        'lnkPrintLedger
        '
        Me.lnkPrintLedger.AutoSize = True
        Me.lnkPrintLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkPrintLedger.Location = New System.Drawing.Point(455, 57)
        Me.lnkPrintLedger.Name = "lnkPrintLedger"
        Me.lnkPrintLedger.Size = New System.Drawing.Size(96, 15)
        Me.lnkPrintLedger.TabIndex = 581
        Me.lnkPrintLedger.TabStop = True
        Me.lnkPrintLedger.Text = "PRINT LEDGER"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(356, 31)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(72, 43)
        Me.cmdClose.TabIndex = 6
        Me.cmdClose.Text = "CLOSE"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tSchool
        '
        Me.tSchool.BackColor = System.Drawing.Color.White
        Me.tSchool.Location = New System.Drawing.Point(52, 55)
        Me.tSchool.Name = "tSchool"
        Me.tSchool.ReadOnly = True
        Me.tSchool.Size = New System.Drawing.Size(297, 20)
        Me.tSchool.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "School:"
        '
        'tName
        '
        Me.tName.BackColor = System.Drawing.Color.White
        Me.tName.Location = New System.Drawing.Point(52, 32)
        Me.tName.Name = "tName"
        Me.tName.ReadOnly = True
        Me.tName.Size = New System.Drawing.Size(297, 20)
        Me.tName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'tRefNo
        '
        Me.tRefNo.BackColor = System.Drawing.Color.White
        Me.tRefNo.Location = New System.Drawing.Point(52, 8)
        Me.tRefNo.Name = "tRefNo"
        Me.tRefNo.ReadOnly = True
        Me.tRefNo.Size = New System.Drawing.Size(121, 20)
        Me.tRefNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ref No:"
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(0, 0)
        Me.AppHeader1.Margin = New System.Windows.Forms.Padding(0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(790, 49)
        Me.AppHeader1.TabIndex = 53
        '
        'FrmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(790, 400)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmHistory"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DbGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DbGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents tSchool As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TheDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MandateNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TheCurrency As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentDetails1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentDetails2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lnkPrintLedger As System.Windows.Forms.LinkLabel
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
End Class
