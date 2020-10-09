<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecommend
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.comReader1 = New System.Windows.Forms.ComboBox()
        Me.lblReader1 = New System.Windows.Forms.Label()
        Me.btnRecommend = New System.Windows.Forms.Button()
        Me.lblBestMatch = New System.Windows.Forms.Label()
        Me.txtBestMatch = New System.Windows.Forms.TextBox()
        Me.lblBooks = New System.Windows.Forms.Label()
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.rbnA = New System.Windows.Forms.RadioButton()
        Me.rbnB = New System.Windows.Forms.RadioButton()
        Me.rbnC = New System.Windows.Forms.RadioButton()
        Me.picCover = New System.Windows.Forms.PictureBox()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(235, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 21)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'comReader1
        '
        Me.comReader1.FormattingEnabled = True
        Me.comReader1.Location = New System.Drawing.Point(15, 25)
        Me.comReader1.Name = "comReader1"
        Me.comReader1.Size = New System.Drawing.Size(113, 21)
        Me.comReader1.TabIndex = 1
        '
        'lblReader1
        '
        Me.lblReader1.AutoSize = True
        Me.lblReader1.Location = New System.Drawing.Point(42, 9)
        Me.lblReader1.Name = "lblReader1"
        Me.lblReader1.Size = New System.Drawing.Size(59, 13)
        Me.lblReader1.TabIndex = 2
        Me.lblReader1.Text = "Reader 1"
        '
        'btnRecommend
        '
        Me.btnRecommend.Location = New System.Drawing.Point(134, 25)
        Me.btnRecommend.Name = "btnRecommend"
        Me.btnRecommend.Size = New System.Drawing.Size(95, 21)
        Me.btnRecommend.TabIndex = 5
        Me.btnRecommend.Text = "Recommend"
        Me.btnRecommend.UseVisualStyleBackColor = True
        '
        'lblBestMatch
        '
        Me.lblBestMatch.AutoSize = True
        Me.lblBestMatch.Location = New System.Drawing.Point(36, 49)
        Me.lblBestMatch.Name = "lblBestMatch"
        Me.lblBestMatch.Size = New System.Drawing.Size(71, 13)
        Me.lblBestMatch.TabIndex = 6
        Me.lblBestMatch.Text = "Best Match"
        '
        'txtBestMatch
        '
        Me.txtBestMatch.Location = New System.Drawing.Point(15, 65)
        Me.txtBestMatch.Name = "txtBestMatch"
        Me.txtBestMatch.ReadOnly = True
        Me.txtBestMatch.Size = New System.Drawing.Size(113, 20)
        Me.txtBestMatch.TabIndex = 7
        Me.txtBestMatch.TabStop = False
        '
        'lblBooks
        '
        Me.lblBooks.AutoSize = True
        Me.lblBooks.Location = New System.Drawing.Point(12, 88)
        Me.lblBooks.Name = "lblBooks"
        Me.lblBooks.Size = New System.Drawing.Size(42, 13)
        Me.lblBooks.TabIndex = 8
        Me.lblBooks.Text = "Books"
        '
        'lstBooks
        '
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.Location = New System.Drawing.Point(15, 104)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(315, 160)
        Me.lstBooks.TabIndex = 9
        '
        'rbnA
        '
        Me.rbnA.AutoSize = True
        Me.rbnA.Location = New System.Drawing.Point(134, 52)
        Me.rbnA.Name = "rbnA"
        Me.rbnA.Size = New System.Drawing.Size(33, 17)
        Me.rbnA.TabIndex = 10
        Me.rbnA.Text = "A"
        Me.rbnA.UseVisualStyleBackColor = True
        '
        'rbnB
        '
        Me.rbnB.AutoSize = True
        Me.rbnB.Checked = True
        Me.rbnB.Location = New System.Drawing.Point(173, 52)
        Me.rbnB.Name = "rbnB"
        Me.rbnB.Size = New System.Drawing.Size(33, 17)
        Me.rbnB.TabIndex = 11
        Me.rbnB.TabStop = True
        Me.rbnB.Text = "B"
        Me.rbnB.UseVisualStyleBackColor = True
        '
        'rbnC
        '
        Me.rbnC.AutoSize = True
        Me.rbnC.Location = New System.Drawing.Point(212, 52)
        Me.rbnC.Name = "rbnC"
        Me.rbnC.Size = New System.Drawing.Size(33, 17)
        Me.rbnC.TabIndex = 12
        Me.rbnC.Text = "C"
        Me.rbnC.UseVisualStyleBackColor = True
        '
        'picCover
        '
        Me.picCover.Location = New System.Drawing.Point(15, 270)
        Me.picCover.Name = "picCover"
        Me.picCover.Size = New System.Drawing.Size(315, 149)
        Me.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCover.TabIndex = 13
        Me.picCover.TabStop = False
        '
        'frmRecommend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 431)
        Me.Controls.Add(Me.picCover)
        Me.Controls.Add(Me.rbnC)
        Me.Controls.Add(Me.rbnB)
        Me.Controls.Add(Me.rbnA)
        Me.Controls.Add(Me.lstBooks)
        Me.Controls.Add(Me.lblBooks)
        Me.Controls.Add(Me.txtBestMatch)
        Me.Controls.Add(Me.lblBestMatch)
        Me.Controls.Add(Me.btnRecommend)
        Me.Controls.Add(Me.lblReader1)
        Me.Controls.Add(Me.comReader1)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRecommend"
        Me.Text = "Recommend"
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents comReader1 As ComboBox
    Friend WithEvents lblReader1 As Label
    Friend WithEvents btnRecommend As Button
    Friend WithEvents lblBestMatch As Label
    Friend WithEvents txtBestMatch As TextBox
    Friend WithEvents lblBooks As Label
    Friend WithEvents lstBooks As ListBox
    Friend WithEvents rbnA As RadioButton
    Friend WithEvents rbnB As RadioButton
    Friend WithEvents rbnC As RadioButton
    Friend WithEvents picCover As PictureBox
End Class
