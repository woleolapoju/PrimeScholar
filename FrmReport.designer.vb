<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReport))
        Me.myCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuMandate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMandateExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSummary1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAnnual = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cboMandateNo = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.OwnerLogo = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmdGetFile = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tDocFile = New System.Windows.Forms.TextBox()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'myCrystalReportViewer
        '
        Me.myCrystalReportViewer.ActiveViewIndex = -1
        Me.myCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.myCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.myCrystalReportViewer.Location = New System.Drawing.Point(330, 60)
        Me.myCrystalReportViewer.Name = "myCrystalReportViewer"
        Me.TableLayoutPanel1.SetRowSpan(Me.myCrystalReportViewer, 4)
        Me.myCrystalReportViewer.ShowGroupTreeButton = False
        Me.myCrystalReportViewer.Size = New System.Drawing.Size(413, 530)
        Me.myCrystalReportViewer.TabIndex = 0
        Me.myCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.myCrystalReportViewer, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.AppHeader1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(746, 593)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel1.Controls.Add(Me.MainMenu)
        Me.Panel1.Location = New System.Drawing.Point(0, 77)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0, 20, 0, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 51)
        Me.Panel1.TabIndex = 551
        '
        'MainMenu
        '
        Me.MainMenu.AllowMerge = False
        Me.MainMenu.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMandate, Me.mnuMandateExcel, Me.mnuSummary, Me.mnuSummary1, Me.mnuAnnual})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainMenu.Size = New System.Drawing.Size(139, 51)
        Me.MainMenu.TabIndex = 247
        Me.MainMenu.Text = "MenuStrip2"
        '
        'mnuMandate
        '
        Me.mnuMandate.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.mnuMandate.Image = CType(resources.GetObject("mnuMandate.Image"), System.Drawing.Image)
        Me.mnuMandate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuMandate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuMandate.Name = "mnuMandate"
        Me.mnuMandate.Size = New System.Drawing.Size(126, 21)
        Me.mnuMandate.Text = "MANDATE"
        '
        'mnuMandateExcel
        '
        Me.mnuMandateExcel.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.mnuMandateExcel.Image = CType(resources.GetObject("mnuMandateExcel.Image"), System.Drawing.Image)
        Me.mnuMandateExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuMandateExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuMandateExcel.Name = "mnuMandateExcel"
        Me.mnuMandateExcel.Size = New System.Drawing.Size(126, 21)
        Me.mnuMandateExcel.Text = "MANDATE (Excel)"
        '
        'mnuSummary
        '
        Me.mnuSummary.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSummary.Image = CType(resources.GetObject("mnuSummary.Image"), System.Drawing.Image)
        Me.mnuSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuSummary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSummary.Name = "mnuSummary"
        Me.mnuSummary.Size = New System.Drawing.Size(196, 21)
        Me.mnuSummary.Text = "STUDENT INFORMATION"
        Me.mnuSummary.Visible = False
        '
        'mnuSummary1
        '
        Me.mnuSummary1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSummary1.Image = CType(resources.GetObject("mnuSummary1.Image"), System.Drawing.Image)
        Me.mnuSummary1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuSummary1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSummary1.Name = "mnuSummary1"
        Me.mnuSummary1.Size = New System.Drawing.Size(196, 21)
        Me.mnuSummary1.Text = "SCHOOL INFORMATION"
        Me.mnuSummary1.Visible = False
        '
        'mnuAnnual
        '
        Me.mnuAnnual.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAnnual.Image = CType(resources.GetObject("mnuAnnual.Image"), System.Drawing.Image)
        Me.mnuAnnual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuAnnual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuAnnual.Name = "mnuAnnual"
        Me.mnuAnnual.Size = New System.Drawing.Size(196, 21)
        Me.mnuAnnual.Text = "ANNUAL PAYMENT ANALYSIS"
        Me.mnuAnnual.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblState)
        Me.Panel2.Controls.Add(Me.cboMandateNo)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(3, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 88)
        Me.Panel2.TabIndex = 552
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Black
        Me.lblState.Location = New System.Drawing.Point(2, 8)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(69, 13)
        Me.lblState.TabIndex = 567
        Me.lblState.Text = "Mandate No:"
        '
        'cboMandateNo
        '
        Me.cboMandateNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMandateNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMandateNo.FormattingEnabled = True
        Me.cboMandateNo.Items.AddRange(New Object() {"LGA", "MDA"})
        Me.cboMandateNo.Location = New System.Drawing.Point(76, 4)
        Me.cboMandateNo.Name = "cboMandateNo"
        Me.cboMandateNo.Size = New System.Drawing.Size(227, 21)
        Me.cboMandateNo.TabIndex = 566
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightYellow
        Me.Panel3.Controls.Add(Me.cmdClose)
        Me.Panel3.Controls.Add(Me.cmdOk)
        Me.Panel3.Location = New System.Drawing.Point(76, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(226, 47)
        Me.Panel3.TabIndex = 563
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(122, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 38)
        Me.cmdClose.TabIndex = 246
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdOk.Location = New System.Drawing.Point(5, 5)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(115, 38)
        Me.cmdOk.TabIndex = 245
        Me.cmdOk.Text = "&Preview"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblOwner)
        Me.Panel4.Controls.Add(Me.OwnerLogo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 267)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(321, 323)
        Me.Panel4.TabIndex = 553
        '
        'lblOwner
        '
        Me.lblOwner.AutoEllipsis = True
        Me.lblOwner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblOwner.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwner.ForeColor = System.Drawing.Color.Black
        Me.lblOwner.Location = New System.Drawing.Point(0, 294)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(321, 29)
        Me.lblOwner.TabIndex = 10
        Me.lblOwner.Text = "Megahit Systems"
        Me.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOwner.UseMnemonic = False
        Me.lblOwner.Visible = False
        '
        'OwnerLogo
        '
        Me.OwnerLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OwnerLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OwnerLogo.Location = New System.Drawing.Point(71, 72)
        Me.OwnerLogo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.OwnerLogo.Name = "OwnerLogo"
        Me.OwnerLogo.Size = New System.Drawing.Size(179, 198)
        Me.OwnerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OwnerLogo.TabIndex = 9
        Me.OwnerLogo.TabStop = False
        Me.OwnerLogo.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel6.Controls.Add(Me.cmdGetFile)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.tDocFile)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 235)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(321, 26)
        Me.Panel6.TabIndex = 554
        Me.Panel6.Visible = False
        '
        'cmdGetFile
        '
        Me.cmdGetFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGetFile.Location = New System.Drawing.Point(289, 2)
        Me.cmdGetFile.Name = "cmdGetFile"
        Me.cmdGetFile.Size = New System.Drawing.Size(27, 21)
        Me.cmdGetFile.TabIndex = 204
        Me.cmdGetFile.Text = "..."
        Me.cmdGetFile.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(2, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 202
        Me.Label15.Text = "Saving Path:"
        '
        'tDocFile
        '
        Me.tDocFile.Location = New System.Drawing.Point(77, 3)
        Me.tDocFile.Name = "tDocFile"
        Me.tDocFile.Size = New System.Drawing.Size(212, 20)
        Me.tDocFile.TabIndex = 203
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.AppHeader1, 2)
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(0, 0)
        Me.AppHeader1.Margin = New System.Windows.Forms.Padding(0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(746, 57)
        Me.AppHeader1.TabIndex = 555
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(746, 593)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents myCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMandate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents mnuSummary1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents OwnerLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents cboMandateNo As System.Windows.Forms.ComboBox
    Friend WithEvents mnuAnnual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSummary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMandateExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdGetFile As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tDocFile As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
End Class
