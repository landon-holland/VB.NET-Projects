<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScrabble
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
        Me.picBoard1 = New System.Windows.Forms.PictureBox()
        Me.lblBoard = New System.Windows.Forms.Label()
        Me.picBoard2 = New System.Windows.Forms.PictureBox()
        Me.picBoard3 = New System.Windows.Forms.PictureBox()
        Me.picBoard4 = New System.Windows.Forms.PictureBox()
        Me.picBoard5 = New System.Windows.Forms.PictureBox()
        Me.picBoard6 = New System.Windows.Forms.PictureBox()
        Me.picBoard7 = New System.Windows.Forms.PictureBox()
        Me.picHand7 = New System.Windows.Forms.PictureBox()
        Me.picHand6 = New System.Windows.Forms.PictureBox()
        Me.picHand5 = New System.Windows.Forms.PictureBox()
        Me.picHand4 = New System.Windows.Forms.PictureBox()
        Me.picHand3 = New System.Windows.Forms.PictureBox()
        Me.picHand2 = New System.Windows.Forms.PictureBox()
        Me.picHand1 = New System.Windows.Forms.PictureBox()
        Me.lblHand = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblWordScore = New System.Windows.Forms.Label()
        Me.txtWordScore = New System.Windows.Forms.TextBox()
        Me.txtTotalScore = New System.Windows.Forms.TextBox()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaderboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDoubleLetter = New System.Windows.Forms.Label()
        Me.lblTripleLetter = New System.Windows.Forms.Label()
        Me.lblDoubleWord = New System.Windows.Forms.Label()
        Me.lblTripleWord = New System.Windows.Forms.Label()
        CType(Me.picBoard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoard7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHand7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHand6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHand5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHand4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHand3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHand2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHand1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBoard1
        '
        Me.picBoard1.Location = New System.Drawing.Point(12, 44)
        Me.picBoard1.Name = "picBoard1"
        Me.picBoard1.Size = New System.Drawing.Size(85, 85)
        Me.picBoard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoard1.TabIndex = 0
        Me.picBoard1.TabStop = False
        '
        'lblBoard
        '
        Me.lblBoard.AutoSize = True
        Me.lblBoard.Location = New System.Drawing.Point(12, 24)
        Me.lblBoard.Name = "lblBoard"
        Me.lblBoard.Size = New System.Drawing.Size(51, 17)
        Me.lblBoard.TabIndex = 1
        Me.lblBoard.Text = "Board"
        '
        'picBoard2
        '
        Me.picBoard2.Location = New System.Drawing.Point(103, 44)
        Me.picBoard2.Name = "picBoard2"
        Me.picBoard2.Size = New System.Drawing.Size(85, 85)
        Me.picBoard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoard2.TabIndex = 2
        Me.picBoard2.TabStop = False
        '
        'picBoard3
        '
        Me.picBoard3.Location = New System.Drawing.Point(194, 44)
        Me.picBoard3.Name = "picBoard3"
        Me.picBoard3.Size = New System.Drawing.Size(85, 85)
        Me.picBoard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoard3.TabIndex = 3
        Me.picBoard3.TabStop = False
        '
        'picBoard4
        '
        Me.picBoard4.Location = New System.Drawing.Point(285, 44)
        Me.picBoard4.Name = "picBoard4"
        Me.picBoard4.Size = New System.Drawing.Size(85, 85)
        Me.picBoard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoard4.TabIndex = 4
        Me.picBoard4.TabStop = False
        '
        'picBoard5
        '
        Me.picBoard5.Location = New System.Drawing.Point(376, 44)
        Me.picBoard5.Name = "picBoard5"
        Me.picBoard5.Size = New System.Drawing.Size(85, 85)
        Me.picBoard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoard5.TabIndex = 5
        Me.picBoard5.TabStop = False
        '
        'picBoard6
        '
        Me.picBoard6.Location = New System.Drawing.Point(467, 44)
        Me.picBoard6.Name = "picBoard6"
        Me.picBoard6.Size = New System.Drawing.Size(85, 85)
        Me.picBoard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoard6.TabIndex = 6
        Me.picBoard6.TabStop = False
        '
        'picBoard7
        '
        Me.picBoard7.Location = New System.Drawing.Point(558, 44)
        Me.picBoard7.Name = "picBoard7"
        Me.picBoard7.Size = New System.Drawing.Size(85, 85)
        Me.picBoard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoard7.TabIndex = 7
        Me.picBoard7.TabStop = False
        '
        'picHand7
        '
        Me.picHand7.Enabled = False
        Me.picHand7.Location = New System.Drawing.Point(558, 183)
        Me.picHand7.Name = "picHand7"
        Me.picHand7.Size = New System.Drawing.Size(85, 85)
        Me.picHand7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHand7.TabIndex = 14
        Me.picHand7.TabStop = False
        '
        'picHand6
        '
        Me.picHand6.Enabled = False
        Me.picHand6.Location = New System.Drawing.Point(467, 183)
        Me.picHand6.Name = "picHand6"
        Me.picHand6.Size = New System.Drawing.Size(85, 85)
        Me.picHand6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHand6.TabIndex = 13
        Me.picHand6.TabStop = False
        '
        'picHand5
        '
        Me.picHand5.Enabled = False
        Me.picHand5.Location = New System.Drawing.Point(376, 183)
        Me.picHand5.Name = "picHand5"
        Me.picHand5.Size = New System.Drawing.Size(85, 85)
        Me.picHand5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHand5.TabIndex = 12
        Me.picHand5.TabStop = False
        '
        'picHand4
        '
        Me.picHand4.Enabled = False
        Me.picHand4.Location = New System.Drawing.Point(285, 183)
        Me.picHand4.Name = "picHand4"
        Me.picHand4.Size = New System.Drawing.Size(85, 85)
        Me.picHand4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHand4.TabIndex = 11
        Me.picHand4.TabStop = False
        '
        'picHand3
        '
        Me.picHand3.Enabled = False
        Me.picHand3.Location = New System.Drawing.Point(194, 183)
        Me.picHand3.Name = "picHand3"
        Me.picHand3.Size = New System.Drawing.Size(85, 85)
        Me.picHand3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHand3.TabIndex = 10
        Me.picHand3.TabStop = False
        '
        'picHand2
        '
        Me.picHand2.Enabled = False
        Me.picHand2.Location = New System.Drawing.Point(103, 183)
        Me.picHand2.Name = "picHand2"
        Me.picHand2.Size = New System.Drawing.Size(85, 85)
        Me.picHand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHand2.TabIndex = 9
        Me.picHand2.TabStop = False
        '
        'picHand1
        '
        Me.picHand1.Enabled = False
        Me.picHand1.Location = New System.Drawing.Point(12, 183)
        Me.picHand1.Name = "picHand1"
        Me.picHand1.Size = New System.Drawing.Size(85, 85)
        Me.picHand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHand1.TabIndex = 8
        Me.picHand1.TabStop = False
        '
        'lblHand
        '
        Me.lblHand.AutoSize = True
        Me.lblHand.Location = New System.Drawing.Point(12, 163)
        Me.lblHand.Name = "lblHand"
        Me.lblHand.Size = New System.Drawing.Size(46, 17)
        Me.lblHand.TabIndex = 15
        Me.lblHand.Text = "Hand"
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.Location = New System.Drawing.Point(12, 274)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(85, 29)
        Me.btnPlay.TabIndex = 16
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        Me.btnPlay.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(558, 274)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 29)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(285, 274)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(85, 29)
        Me.btnCheck.TabIndex = 18
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        Me.btnCheck.Visible = False
        '
        'lblWordScore
        '
        Me.lblWordScore.AutoSize = True
        Me.lblWordScore.Location = New System.Drawing.Point(100, 280)
        Me.lblWordScore.Name = "lblWordScore"
        Me.lblWordScore.Size = New System.Drawing.Size(93, 17)
        Me.lblWordScore.TabIndex = 19
        Me.lblWordScore.Text = "Word Score"
        '
        'txtWordScore
        '
        Me.txtWordScore.Location = New System.Drawing.Point(199, 277)
        Me.txtWordScore.Name = "txtWordScore"
        Me.txtWordScore.ReadOnly = True
        Me.txtWordScore.Size = New System.Drawing.Size(80, 23)
        Me.txtWordScore.TabIndex = 20
        Me.txtWordScore.TabStop = False
        '
        'txtTotalScore
        '
        Me.txtTotalScore.Location = New System.Drawing.Point(471, 277)
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.ReadOnly = True
        Me.txtTotalScore.Size = New System.Drawing.Size(81, 23)
        Me.txtTotalScore.TabIndex = 22
        Me.txtTotalScore.TabStop = False
        '
        'lblTotalScore
        '
        Me.lblTotalScore.AutoSize = True
        Me.lblTotalScore.Location = New System.Drawing.Point(373, 280)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(92, 17)
        Me.lblTotalScore.TabIndex = 21
        Me.lblTotalScore.Text = "Total Score"
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Location = New System.Drawing.Point(563, 24)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(81, 17)
        Me.lblLoading.TabIndex = 23
        Me.lblLoading.Text = "Loading..."
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerToolStripMenuItem})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(656, 24)
        Me.mnuStrip.TabIndex = 24
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'PlayerToolStripMenuItem
        '
        Me.PlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPlayerToolStripMenuItem, Me.OpenPlayerToolStripMenuItem, Me.LeaderboardToolStripMenuItem})
        Me.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem"
        Me.PlayerToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PlayerToolStripMenuItem.Text = "Player"
        '
        'NewPlayerToolStripMenuItem
        '
        Me.NewPlayerToolStripMenuItem.Name = "NewPlayerToolStripMenuItem"
        Me.NewPlayerToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.NewPlayerToolStripMenuItem.Text = "New"
        '
        'OpenPlayerToolStripMenuItem
        '
        Me.OpenPlayerToolStripMenuItem.Name = "OpenPlayerToolStripMenuItem"
        Me.OpenPlayerToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.OpenPlayerToolStripMenuItem.Text = "Open"
        '
        'LeaderboardToolStripMenuItem
        '
        Me.LeaderboardToolStripMenuItem.Name = "LeaderboardToolStripMenuItem"
        Me.LeaderboardToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.LeaderboardToolStripMenuItem.Text = "Leaderboard"
        '
        'lblDoubleLetter
        '
        Me.lblDoubleLetter.AutoSize = True
        Me.lblDoubleLetter.Location = New System.Drawing.Point(109, 132)
        Me.lblDoubleLetter.Name = "lblDoubleLetter"
        Me.lblDoubleLetter.Size = New System.Drawing.Size(72, 17)
        Me.lblDoubleLetter.TabIndex = 25
        Me.lblDoubleLetter.Text = "2x Letter"
        '
        'lblTripleLetter
        '
        Me.lblTripleLetter.AutoSize = True
        Me.lblTripleLetter.Location = New System.Drawing.Point(382, 132)
        Me.lblTripleLetter.Name = "lblTripleLetter"
        Me.lblTripleLetter.Size = New System.Drawing.Size(72, 17)
        Me.lblTripleLetter.TabIndex = 26
        Me.lblTripleLetter.Text = "3x Letter"
        '
        'lblDoubleWord
        '
        Me.lblDoubleWord.AutoSize = True
        Me.lblDoubleWord.Location = New System.Drawing.Point(476, 132)
        Me.lblDoubleWord.Name = "lblDoubleWord"
        Me.lblDoubleWord.Size = New System.Drawing.Size(67, 17)
        Me.lblDoubleWord.TabIndex = 27
        Me.lblDoubleWord.Text = "2x Word"
        '
        'lblTripleWord
        '
        Me.lblTripleWord.AutoSize = True
        Me.lblTripleWord.Location = New System.Drawing.Point(567, 132)
        Me.lblTripleWord.Name = "lblTripleWord"
        Me.lblTripleWord.Size = New System.Drawing.Size(67, 17)
        Me.lblTripleWord.TabIndex = 28
        Me.lblTripleWord.Text = "3x Word"
        '
        'frmScrabble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 311)
        Me.Controls.Add(Me.lblTripleWord)
        Me.Controls.Add(Me.lblDoubleWord)
        Me.Controls.Add(Me.lblTripleLetter)
        Me.Controls.Add(Me.lblDoubleLetter)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.txtTotalScore)
        Me.Controls.Add(Me.lblTotalScore)
        Me.Controls.Add(Me.txtWordScore)
        Me.Controls.Add(Me.lblWordScore)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblHand)
        Me.Controls.Add(Me.picHand7)
        Me.Controls.Add(Me.picHand6)
        Me.Controls.Add(Me.picHand5)
        Me.Controls.Add(Me.picHand4)
        Me.Controls.Add(Me.picHand3)
        Me.Controls.Add(Me.picHand2)
        Me.Controls.Add(Me.picHand1)
        Me.Controls.Add(Me.picBoard7)
        Me.Controls.Add(Me.picBoard6)
        Me.Controls.Add(Me.picBoard5)
        Me.Controls.Add(Me.picBoard4)
        Me.Controls.Add(Me.picBoard3)
        Me.Controls.Add(Me.picBoard2)
        Me.Controls.Add(Me.lblBoard)
        Me.Controls.Add(Me.picBoard1)
        Me.Controls.Add(Me.mnuStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmScrabble"
        Me.Text = "Scrabble"
        CType(Me.picBoard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoard7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHand7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHand6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHand5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHand4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHand3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHand2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHand1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBoard1 As PictureBox
    Friend WithEvents lblBoard As Label
    Friend WithEvents picBoard2 As PictureBox
    Friend WithEvents picBoard3 As PictureBox
    Friend WithEvents picBoard4 As PictureBox
    Friend WithEvents picBoard5 As PictureBox
    Friend WithEvents picBoard6 As PictureBox
    Friend WithEvents picBoard7 As PictureBox
    Friend WithEvents picHand7 As PictureBox
    Friend WithEvents picHand6 As PictureBox
    Friend WithEvents picHand5 As PictureBox
    Friend WithEvents picHand4 As PictureBox
    Friend WithEvents picHand3 As PictureBox
    Friend WithEvents picHand2 As PictureBox
    Friend WithEvents picHand1 As PictureBox
    Friend WithEvents lblHand As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblWordScore As Label
    Friend WithEvents txtWordScore As TextBox
    Friend WithEvents txtTotalScore As TextBox
    Friend WithEvents lblTotalScore As Label
    Friend WithEvents lblLoading As Label
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents PlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaderboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDoubleLetter As Label
    Friend WithEvents lblTripleLetter As Label
    Friend WithEvents lblDoubleWord As Label
    Friend WithEvents lblTripleWord As Label
End Class
