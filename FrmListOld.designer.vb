<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListOld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListOld))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lvList = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdFilter = New System.Windows.Forms.Button()
        Me.cmdSort = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RasDescend = New System.Windows.Forms.RadioButton()
        Me.RadAscend = New System.Windows.Forms.RadioButton()
        Me.SelColumn = New System.Windows.Forms.NumericUpDown()
        Me.tFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.PanO = New System.Windows.Forms.Panel()
        Me.radStakeHolders = New System.Windows.Forms.RadioButton()
        Me.RadStaff = New System.Windows.Forms.RadioButton()
        Me.RadStudent = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SelColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanO.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lvList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PanO, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(456, 400)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lvList
        '
        Me.lvList.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TableLayoutPanel1.SetColumnSpan(Me.lvList, 2)
        Me.lvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvList.FullRowSelect = True
        Me.lvList.GridLines = True
        Me.lvList.Location = New System.Drawing.Point(3, 29)
        Me.lvList.MultiSelect = False
        Me.lvList.Name = "lvList"
        Me.lvList.Size = New System.Drawing.Size(450, 274)
        Me.lvList.TabIndex = 0
        Me.lvList.UseCompatibleStateImageBehavior = False
        Me.lvList.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdRefresh)
        Me.GroupBox1.Controls.Add(Me.lblCount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdFilter)
        Me.GroupBox1.Controls.Add(Me.cmdSort)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RasDescend)
        Me.GroupBox1.Controls.Add(Me.RadAscend)
        Me.GroupBox1.Controls.Add(Me.SelColumn)
        Me.GroupBox1.Controls.Add(Me.tFilter)
        Me.GroupBox1.Controls.Add(Me.lblFilter)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 88)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(262, 13)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(55, 27)
        Me.cmdRefresh.TabIndex = 14
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(294, 67)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(28, 20)
        Me.lblCount.TabIndex = 13
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(245, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "List Count"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdFilter
        '
        Me.cmdFilter.Location = New System.Drawing.Point(206, 13)
        Me.cmdFilter.Name = "cmdFilter"
        Me.cmdFilter.Size = New System.Drawing.Size(55, 27)
        Me.cmdFilter.TabIndex = 11
        Me.cmdFilter.Text = "F&ilter"
        Me.cmdFilter.UseVisualStyleBackColor = True
        '
        'cmdSort
        '
        Me.cmdSort.Location = New System.Drawing.Point(149, 13)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.Size = New System.Drawing.Size(55, 27)
        Me.cmdSort.TabIndex = 10
        Me.cmdSort.Text = "Sor&t"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "S&ort Order:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RasDescend
        '
        Me.RasDescend.AutoSize = True
        Me.RasDescend.Location = New System.Drawing.Point(165, 69)
        Me.RasDescend.Name = "RasDescend"
        Me.RasDescend.Size = New System.Drawing.Size(82, 17)
        Me.RasDescend.TabIndex = 8
        Me.RasDescend.Text = "&Descending"
        Me.RasDescend.UseVisualStyleBackColor = True
        '
        'RadAscend
        '
        Me.RadAscend.AutoSize = True
        Me.RadAscend.Checked = True
        Me.RadAscend.Location = New System.Drawing.Point(88, 69)
        Me.RadAscend.Name = "RadAscend"
        Me.RadAscend.Size = New System.Drawing.Size(75, 17)
        Me.RadAscend.TabIndex = 7
        Me.RadAscend.TabStop = True
        Me.RadAscend.Text = "&Ascending"
        Me.RadAscend.UseVisualStyleBackColor = True
        '
        'SelColumn
        '
        Me.SelColumn.Location = New System.Drawing.Point(89, 17)
        Me.SelColumn.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelColumn.Name = "SelColumn"
        Me.SelColumn.Size = New System.Drawing.Size(39, 20)
        Me.SelColumn.TabIndex = 6
        Me.SelColumn.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tFilter
        '
        Me.tFilter.Location = New System.Drawing.Point(89, 43)
        Me.tFilter.Name = "tFilter"
        Me.tFilter.Size = New System.Drawing.Size(227, 20)
        Me.tFilter.TabIndex = 5
        '
        'lblFilter
        '
        Me.lblFilter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFilter.Location = New System.Drawing.Point(3, 40)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(61, 23)
        Me.lblFilter.TabIndex = 4
        Me.lblFilter.Text = "&Filter Text:"
        Me.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(2, 15)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(91, 23)
        Me.UsernameLabel.TabIndex = 2
        Me.UsernameLabel.Text = "&Selected Column:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cmdClose, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cmdOk, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(331, 309)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(122, 88)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(64, 3)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(55, 82)
        Me.cmdClose.TabIndex = 54
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(3, 3)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(55, 82)
        Me.cmdOk.TabIndex = 53
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'PanO
        '
        Me.PanO.BackColor = System.Drawing.Color.Goldenrod
        Me.PanO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanO.Controls.Add(Me.radStakeHolders)
        Me.PanO.Controls.Add(Me.RadStaff)
        Me.PanO.Controls.Add(Me.RadStudent)
        Me.PanO.Location = New System.Drawing.Point(4, 3)
        Me.PanO.Margin = New System.Windows.Forms.Padding(4, 3, 1, 1)
        Me.PanO.Name = "PanO"
        Me.PanO.Size = New System.Drawing.Size(205, 22)
        Me.PanO.TabIndex = 3
        Me.PanO.Visible = False
        '
        'radStakeHolders
        '
        Me.radStakeHolders.AutoSize = True
        Me.radStakeHolders.ForeColor = System.Drawing.Color.White
        Me.radStakeHolders.Location = New System.Drawing.Point(115, 1)
        Me.radStakeHolders.Name = "radStakeHolders"
        Me.radStakeHolders.Size = New System.Drawing.Size(87, 17)
        Me.radStakeHolders.TabIndex = 11
        Me.radStakeHolders.Text = "Stakeholders"
        Me.radStakeHolders.UseVisualStyleBackColor = True
        '
        'RadStaff
        '
        Me.RadStaff.AutoSize = True
        Me.RadStaff.ForeColor = System.Drawing.Color.White
        Me.RadStaff.Location = New System.Drawing.Point(68, 1)
        Me.RadStaff.Name = "RadStaff"
        Me.RadStaff.Size = New System.Drawing.Size(47, 17)
        Me.RadStaff.TabIndex = 10
        Me.RadStaff.Text = "Staff"
        Me.RadStaff.UseVisualStyleBackColor = True
        '
        'RadStudent
        '
        Me.RadStudent.AutoSize = True
        Me.RadStudent.Checked = True
        Me.RadStudent.ForeColor = System.Drawing.Color.White
        Me.RadStudent.Location = New System.Drawing.Point(5, 1)
        Me.RadStudent.Name = "RadStudent"
        Me.RadStudent.Size = New System.Drawing.Size(62, 17)
        Me.RadStudent.TabIndex = 9
        Me.RadStudent.TabStop = True
        Me.RadStudent.Text = "Student"
        Me.RadStudent.UseVisualStyleBackColor = True
        '
        'FrmList1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(456, 400)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmList1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SelColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.PanO.ResumeLayout(False)
        Me.PanO.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lvList As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SelColumn As System.Windows.Forms.NumericUpDown
    Friend WithEvents tFilter As System.Windows.Forms.TextBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents cmdFilter As System.Windows.Forms.Button
    Friend WithEvents cmdSort As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RasDescend As System.Windows.Forms.RadioButton
    Friend WithEvents RadAscend As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents PanO As System.Windows.Forms.Panel
    Friend WithEvents radStakeHolders As System.Windows.Forms.RadioButton
    Friend WithEvents RadStaff As System.Windows.Forms.RadioButton
    Friend WithEvents RadStudent As System.Windows.Forms.RadioButton
End Class
