<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMandateSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMandateSummary))
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.lvList = New System.Windows.Forms.ListView()
        Me.ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAuthoriseMandate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuUnauthoriseMandate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuVOIDMandateTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDeleteMandate = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.PanMandate = New System.Windows.Forms.Panel()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmdNewMandate = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEXPORTMandate = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanMandate.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.AppHeader1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lvList, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(717, 553)
        Me.TableLayoutPanel3.TabIndex = 97
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(0, 0)
        Me.AppHeader1.Margin = New System.Windows.Forms.Padding(0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(717, 47)
        Me.AppHeader1.TabIndex = 126
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lvList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader, Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvList.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.Location = New System.Drawing.Point(3, 108)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(711, 442)
        Me.lvList.TabIndex = 23
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader
        '
        Me.ColumnHeader.Text = "Mandate Number"
        Me.ColumnHeader.Width = 191
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 117
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NoOfPayments"
        Me.ColumnHeader1.Width = 105
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Amount"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Currency"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Authorised"
        Me.ColumnHeader5.Width = 82
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAuthoriseMandate, Me.ToolStripMenuItem1, Me.mnuUnauthoriseMandate, Me.ToolStripMenuItem2, Me.mnuVOIDMandateTransaction, Me.ToolStripMenuItem3, Me.mnuDeleteMandate, Me.ToolStripMenuItem4, Me.mnuEXPORTMandate})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(217, 138)
        '
        'mnuAuthoriseMandate
        '
        Me.mnuAuthoriseMandate.Name = "mnuAuthoriseMandate"
        Me.mnuAuthoriseMandate.Size = New System.Drawing.Size(216, 22)
        Me.mnuAuthoriseMandate.Text = "Authorise Mandate"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(213, 6)
        '
        'mnuUnauthoriseMandate
        '
        Me.mnuUnauthoriseMandate.Name = "mnuUnauthoriseMandate"
        Me.mnuUnauthoriseMandate.Size = New System.Drawing.Size(216, 22)
        Me.mnuUnauthoriseMandate.Text = "Unauthorise Mandate"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(213, 6)
        '
        'mnuVOIDMandateTransaction
        '
        Me.mnuVOIDMandateTransaction.Name = "mnuVOIDMandateTransaction"
        Me.mnuVOIDMandateTransaction.Size = New System.Drawing.Size(216, 22)
        Me.mnuVOIDMandateTransaction.Text = "VOID Mandate Transaction"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(213, 6)
        '
        'mnuDeleteMandate
        '
        Me.mnuDeleteMandate.Name = "mnuDeleteMandate"
        Me.mnuDeleteMandate.Size = New System.Drawing.Size(216, 22)
        Me.mnuDeleteMandate.Text = "Delete Mandate"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdSearch)
        Me.Panel1.Controls.Add(Me.PanMandate)
        Me.Panel1.Controls.Add(Me.cmdNewMandate)
        Me.Panel1.Controls.Add(Me.CmdCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 52)
        Me.Panel1.TabIndex = 24
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.Lavender
        Me.cmdSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(609, 0)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(102, 52)
        Me.cmdSearch.TabIndex = 245
        Me.cmdSearch.Text = "&SEARCH"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'PanMandate
        '
        Me.PanMandate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanMandate.Controls.Add(Me.dtpEndDate)
        Me.PanMandate.Controls.Add(Me.Label3)
        Me.PanMandate.Controls.Add(Me.dtpStartDate)
        Me.PanMandate.Controls.Add(Me.Label15)
        Me.PanMandate.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanMandate.Location = New System.Drawing.Point(0, 0)
        Me.PanMandate.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.PanMandate.Name = "PanMandate"
        Me.PanMandate.Size = New System.Drawing.Size(183, 52)
        Me.PanMandate.TabIndex = 244
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(63, 26)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(114, 22)
        Me.dtpEndDate.TabIndex = 246
        Me.dtpEndDate.Tag = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-1, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 245
        Me.Label3.Text = "End Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(63, 2)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(114, 22)
        Me.dtpStartDate.TabIndex = 244
        Me.dtpStartDate.Tag = "Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(-1, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 13)
        Me.Label15.TabIndex = 235
        Me.Label15.Text = "Start Date:"
        '
        'cmdNewMandate
        '
        Me.cmdNewMandate.BackColor = System.Drawing.Color.Lavender
        Me.cmdNewMandate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewMandate.Location = New System.Drawing.Point(187, 1)
        Me.cmdNewMandate.Name = "cmdNewMandate"
        Me.cmdNewMandate.Size = New System.Drawing.Size(154, 48)
        Me.cmdNewMandate.TabIndex = 22
        Me.cmdNewMandate.Text = "&NEW MANDATE"
        Me.cmdNewMandate.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.Location = New System.Drawing.Point(509, 0)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(72, 52)
        Me.CmdCancel.TabIndex = 21
        Me.CmdCancel.Text = "&Close"
        Me.CmdCancel.UseVisualStyleBackColor = True
        Me.CmdCancel.Visible = False
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(213, 6)
        '
        'mnuEXPORTMandate
        '
        Me.mnuEXPORTMandate.Name = "mnuEXPORTMandate"
        Me.mnuEXPORTMandate.Size = New System.Drawing.Size(216, 22)
        Me.mnuEXPORTMandate.Text = "EXPORT Mandate"
        '
        'FrmMandateSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(717, 553)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMandateSummary"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mandates"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanMandate.ResumeLayout(False)
        Me.PanMandate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdNewMandate As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents PanMandate As System.Windows.Forms.Panel
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAuthoriseMandate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuUnauthoriseMandate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuVOIDMandateTransaction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuDeleteMandate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuEXPORTMandate As System.Windows.Forms.ToolStripMenuItem
End Class
