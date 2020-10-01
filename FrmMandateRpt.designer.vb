<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMandateRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMandateRpt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tMandateTitle = New System.Windows.Forms.TextBox()
        Me.tAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tAmtInWords = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.tCurrency = New System.Windows.Forms.TextBox()
        Me.tSignatory1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tSignatory2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tPreparedBy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tMandateNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tSignatory2Design = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tSignatory1Design = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.tSignatory3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tSignatory3Design = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboLayout = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AppHeader1 = New PrimeScholar.AppHeader()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Mandate Title:"
        '
        'tMandateTitle
        '
        Me.tMandateTitle.Location = New System.Drawing.Point(102, 78)
        Me.tMandateTitle.Multiline = True
        Me.tMandateTitle.Name = "tMandateTitle"
        Me.tMandateTitle.Size = New System.Drawing.Size(249, 64)
        Me.tMandateTitle.TabIndex = 53
        '
        'tAmount
        '
        Me.tAmount.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tAmount.Location = New System.Drawing.Point(102, 145)
        Me.tAmount.Name = "tAmount"
        Me.tAmount.ReadOnly = True
        Me.tAmount.Size = New System.Drawing.Size(147, 20)
        Me.tAmount.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Mandate Total:"
        '
        'tAmtInWords
        '
        Me.tAmtInWords.Location = New System.Drawing.Point(102, 171)
        Me.tAmtInWords.Multiline = True
        Me.tAmtInWords.Name = "tAmtInWords"
        Me.tAmtInWords.Size = New System.Drawing.Size(249, 62)
        Me.tAmtInWords.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 30)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Amount in words:"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(103, 398)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(109, 28)
        Me.cmdOk.TabIndex = 58
        Me.cmdOk.Text = "OK"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'tCurrency
        '
        Me.tCurrency.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.tCurrency.Location = New System.Drawing.Point(255, 145)
        Me.tCurrency.Name = "tCurrency"
        Me.tCurrency.ReadOnly = True
        Me.tCurrency.Size = New System.Drawing.Size(96, 20)
        Me.tCurrency.TabIndex = 59
        '
        'tSignatory1
        '
        Me.tSignatory1.BackColor = System.Drawing.Color.White
        Me.tSignatory1.Location = New System.Drawing.Point(102, 237)
        Me.tSignatory1.Name = "tSignatory1"
        Me.tSignatory1.Size = New System.Drawing.Size(249, 20)
        Me.tSignatory1.TabIndex = 61
        Me.tSignatory1.Text = "PAUL TARELA BOROH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "1st Signatory:"
        '
        'tSignatory2
        '
        Me.tSignatory2.BackColor = System.Drawing.Color.White
        Me.tSignatory2.Location = New System.Drawing.Point(102, 260)
        Me.tSignatory2.Name = "tSignatory2"
        Me.tSignatory2.Size = New System.Drawing.Size(249, 20)
        Me.tSignatory2.TabIndex = 63
        Me.tSignatory2.Text = "OPOKUMA LOYIBO JOHN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "2nd Signatory:"
        '
        'tPreparedBy
        '
        Me.tPreparedBy.BackColor = System.Drawing.Color.White
        Me.tPreparedBy.Location = New System.Drawing.Point(103, 373)
        Me.tPreparedBy.Name = "tPreparedBy"
        Me.tPreparedBy.Size = New System.Drawing.Size(249, 20)
        Me.tPreparedBy.TabIndex = 65
        Me.tPreparedBy.Text = "Ibrahim Hakeem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Prepared By:"
        '
        'tMandateNo
        '
        Me.tMandateNo.BackColor = System.Drawing.Color.White
        Me.tMandateNo.Location = New System.Drawing.Point(102, 54)
        Me.tMandateNo.Name = "tMandateNo"
        Me.tMandateNo.Size = New System.Drawing.Size(249, 20)
        Me.tMandateNo.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Ref. No:"
        '
        'tSignatory2Design
        '
        Me.tSignatory2Design.BackColor = System.Drawing.Color.White
        Me.tSignatory2Design.Location = New System.Drawing.Point(102, 327)
        Me.tSignatory2Design.Name = "tSignatory2Design"
        Me.tSignatory2Design.Size = New System.Drawing.Size(249, 20)
        Me.tSignatory2Design.TabIndex = 71
        Me.tSignatory2Design.Text = "SA (Fin. & Accts)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "2nd Sign. Design:"
        '
        'tSignatory1Design
        '
        Me.tSignatory1Design.BackColor = System.Drawing.Color.White
        Me.tSignatory1Design.Location = New System.Drawing.Point(102, 305)
        Me.tSignatory1Design.Name = "tSignatory1Design"
        Me.tSignatory1Design.Size = New System.Drawing.Size(249, 20)
        Me.tSignatory1Design.TabIndex = 69
        Me.tSignatory1Design.Text = "Special Adviser to the President on Niger Delta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 308)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "1st Sign. Design:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(243, 397)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(109, 28)
        Me.cmdCancel.TabIndex = 72
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'tSignatory3
        '
        Me.tSignatory3.BackColor = System.Drawing.Color.White
        Me.tSignatory3.Location = New System.Drawing.Point(102, 282)
        Me.tSignatory3.Name = "tSignatory3"
        Me.tSignatory3.Size = New System.Drawing.Size(249, 20)
        Me.tSignatory3.TabIndex = 127
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "3rd Signatory:"
        '
        'tSignatory3Design
        '
        Me.tSignatory3Design.BackColor = System.Drawing.Color.White
        Me.tSignatory3Design.Location = New System.Drawing.Point(103, 350)
        Me.tSignatory3Design.Name = "tSignatory3Design"
        Me.tSignatory3Design.Size = New System.Drawing.Size(249, 20)
        Me.tSignatory3Design.TabIndex = 129
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "3rd Sign. Design:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Cover Letter Layout:"
        '
        'cboLayout
        '
        Me.cboLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLayout.FormattingEnabled = True
        Me.cboLayout.Items.AddRange(New Object() {"USD FBN", "USB BULK", "GBP FBN", "GBP BULK", "EUR FBN", "AED FBN", "PRESSID NGN"})
        Me.cboLayout.Location = New System.Drawing.Point(3, 24)
        Me.cboLayout.Name = "cboLayout"
        Me.cboLayout.Size = New System.Drawing.Size(103, 21)
        Me.cboLayout.TabIndex = 131
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.cboLayout)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(356, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 51)
        Me.Panel1.TabIndex = 132
        '
        'AppHeader1
        '
        Me.AppHeader1.BackColor = System.Drawing.Color.White
        Me.AppHeader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AppHeader1.Location = New System.Drawing.Point(0, 0)
        Me.AppHeader1.Name = "AppHeader1"
        Me.AppHeader1.Size = New System.Drawing.Size(474, 47)
        Me.AppHeader1.TabIndex = 125
        '
        'FrmMandateRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(474, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tSignatory3Design)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tSignatory3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AppHeader1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.tSignatory2Design)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tSignatory1Design)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tMandateNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tPreparedBy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tSignatory2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tSignatory1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tCurrency)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.tAmtInWords)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tMandateTitle)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMandateRpt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mandate Report"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tMandateTitle As System.Windows.Forms.TextBox
    Friend WithEvents tAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tAmtInWords As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents tCurrency As System.Windows.Forms.TextBox
    Friend WithEvents tSignatory1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tSignatory2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tPreparedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tMandateNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tSignatory2Design As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tSignatory1Design As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents AppHeader1 As PrimeScholar.AppHeader
    Friend WithEvents tSignatory3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tSignatory3Design As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboLayout As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
