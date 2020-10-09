<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardGameForm
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
        Me.DealerLabel = New System.Windows.Forms.Label()
        Me.PlayerLabel = New System.Windows.Forms.Label()
        Me.DealerCard1 = New System.Windows.Forms.PictureBox()
        Me.DealerCard2 = New System.Windows.Forms.PictureBox()
        Me.DealerCard3 = New System.Windows.Forms.PictureBox()
        Me.DealerCard4 = New System.Windows.Forms.PictureBox()
        Me.DealerCard5 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard1 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard2 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard3 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard4 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard5 = New System.Windows.Forms.PictureBox()
        Me.HitButton = New System.Windows.Forms.Button()
        Me.StandButton = New System.Windows.Forms.Button()
        Me.DoubleButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DealerHandTextBox = New System.Windows.Forms.TextBox()
        Me.PlayerHandTextBox = New System.Windows.Forms.TextBox()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        CType(Me.DealerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DealerLabel
        '
        Me.DealerLabel.AutoSize = True
        Me.DealerLabel.Location = New System.Drawing.Point(12, 24)
        Me.DealerLabel.Name = "DealerLabel"
        Me.DealerLabel.Size = New System.Drawing.Size(56, 17)
        Me.DealerLabel.TabIndex = 0
        Me.DealerLabel.Text = "Dealer"
        '
        'PlayerLabel
        '
        Me.PlayerLabel.AutoSize = True
        Me.PlayerLabel.Location = New System.Drawing.Point(12, 174)
        Me.PlayerLabel.Name = "PlayerLabel"
        Me.PlayerLabel.Size = New System.Drawing.Size(54, 17)
        Me.PlayerLabel.TabIndex = 1
        Me.PlayerLabel.Text = "Player"
        '
        'DealerCard1
        '
        Me.DealerCard1.Location = New System.Drawing.Point(15, 44)
        Me.DealerCard1.Name = "DealerCard1"
        Me.DealerCard1.Size = New System.Drawing.Size(103, 127)
        Me.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard1.TabIndex = 2
        Me.DealerCard1.TabStop = False
        '
        'DealerCard2
        '
        Me.DealerCard2.Location = New System.Drawing.Point(124, 44)
        Me.DealerCard2.Name = "DealerCard2"
        Me.DealerCard2.Size = New System.Drawing.Size(103, 127)
        Me.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard2.TabIndex = 3
        Me.DealerCard2.TabStop = False
        '
        'DealerCard3
        '
        Me.DealerCard3.Location = New System.Drawing.Point(233, 44)
        Me.DealerCard3.Name = "DealerCard3"
        Me.DealerCard3.Size = New System.Drawing.Size(103, 127)
        Me.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard3.TabIndex = 4
        Me.DealerCard3.TabStop = False
        '
        'DealerCard4
        '
        Me.DealerCard4.Location = New System.Drawing.Point(342, 44)
        Me.DealerCard4.Name = "DealerCard4"
        Me.DealerCard4.Size = New System.Drawing.Size(103, 127)
        Me.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard4.TabIndex = 5
        Me.DealerCard4.TabStop = False
        '
        'DealerCard5
        '
        Me.DealerCard5.Location = New System.Drawing.Point(451, 44)
        Me.DealerCard5.Name = "DealerCard5"
        Me.DealerCard5.Size = New System.Drawing.Size(103, 127)
        Me.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard5.TabIndex = 6
        Me.DealerCard5.TabStop = False
        '
        'PlayerCard1
        '
        Me.PlayerCard1.Location = New System.Drawing.Point(15, 194)
        Me.PlayerCard1.Name = "PlayerCard1"
        Me.PlayerCard1.Size = New System.Drawing.Size(103, 127)
        Me.PlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard1.TabIndex = 7
        Me.PlayerCard1.TabStop = False
        '
        'PlayerCard2
        '
        Me.PlayerCard2.Location = New System.Drawing.Point(124, 194)
        Me.PlayerCard2.Name = "PlayerCard2"
        Me.PlayerCard2.Size = New System.Drawing.Size(103, 127)
        Me.PlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard2.TabIndex = 8
        Me.PlayerCard2.TabStop = False
        '
        'PlayerCard3
        '
        Me.PlayerCard3.Location = New System.Drawing.Point(233, 194)
        Me.PlayerCard3.Name = "PlayerCard3"
        Me.PlayerCard3.Size = New System.Drawing.Size(103, 127)
        Me.PlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard3.TabIndex = 9
        Me.PlayerCard3.TabStop = False
        '
        'PlayerCard4
        '
        Me.PlayerCard4.Location = New System.Drawing.Point(342, 194)
        Me.PlayerCard4.Name = "PlayerCard4"
        Me.PlayerCard4.Size = New System.Drawing.Size(103, 127)
        Me.PlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard4.TabIndex = 10
        Me.PlayerCard4.TabStop = False
        '
        'PlayerCard5
        '
        Me.PlayerCard5.Location = New System.Drawing.Point(451, 194)
        Me.PlayerCard5.Name = "PlayerCard5"
        Me.PlayerCard5.Size = New System.Drawing.Size(103, 127)
        Me.PlayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard5.TabIndex = 11
        Me.PlayerCard5.TabStop = False
        '
        'HitButton
        '
        Me.HitButton.Location = New System.Drawing.Point(451, 327)
        Me.HitButton.Name = "HitButton"
        Me.HitButton.Size = New System.Drawing.Size(103, 29)
        Me.HitButton.TabIndex = 12
        Me.HitButton.Text = "Hit"
        Me.HitButton.UseVisualStyleBackColor = True
        Me.HitButton.Visible = False
        '
        'StandButton
        '
        Me.StandButton.Location = New System.Drawing.Point(342, 327)
        Me.StandButton.Name = "StandButton"
        Me.StandButton.Size = New System.Drawing.Size(103, 29)
        Me.StandButton.TabIndex = 13
        Me.StandButton.Text = "Stand"
        Me.StandButton.UseVisualStyleBackColor = True
        Me.StandButton.Visible = False
        '
        'DoubleButton
        '
        Me.DoubleButton.Location = New System.Drawing.Point(233, 327)
        Me.DoubleButton.Name = "DoubleButton"
        Me.DoubleButton.Size = New System.Drawing.Size(103, 29)
        Me.DoubleButton.TabIndex = 14
        Me.DoubleButton.Text = "Double"
        Me.DoubleButton.UseVisualStyleBackColor = True
        Me.DoubleButton.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(568, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlayerToolStripMenuItem
        '
        Me.PlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewPlayerToolStripMenuItem, Me.OpenPlayerToolStripMenuItem})
        Me.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem"
        Me.PlayerToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PlayerToolStripMenuItem.Text = "Player"
        '
        'NewPlayerToolStripMenuItem
        '
        Me.NewPlayerToolStripMenuItem.Name = "NewPlayerToolStripMenuItem"
        Me.NewPlayerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewPlayerToolStripMenuItem.Text = "New Player"
        '
        'OpenPlayerToolStripMenuItem
        '
        Me.OpenPlayerToolStripMenuItem.Name = "OpenPlayerToolStripMenuItem"
        Me.OpenPlayerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenPlayerToolStripMenuItem.Text = "Open Player"
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(124, 327)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(103, 29)
        Me.PlayButton.TabIndex = 16
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        Me.PlayButton.Visible = False
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(15, 327)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(103, 29)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DealerHandTextBox
        '
        Me.DealerHandTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DealerHandTextBox.Location = New System.Drawing.Point(74, 23)
        Me.DealerHandTextBox.Name = "DealerHandTextBox"
        Me.DealerHandTextBox.ReadOnly = True
        Me.DealerHandTextBox.Size = New System.Drawing.Size(73, 20)
        Me.DealerHandTextBox.TabIndex = 18
        Me.DealerHandTextBox.TabStop = False
        '
        'PlayerHandTextBox
        '
        Me.PlayerHandTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerHandTextBox.Location = New System.Drawing.Point(72, 173)
        Me.PlayerHandTextBox.Name = "PlayerHandTextBox"
        Me.PlayerHandTextBox.ReadOnly = True
        Me.PlayerHandTextBox.Size = New System.Drawing.Size(75, 20)
        Me.PlayerHandTextBox.TabIndex = 19
        Me.PlayerHandTextBox.TabStop = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Location = New System.Drawing.Point(339, 174)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(50, 17)
        Me.ScoreLabel.TabIndex = 20
        Me.ScoreLabel.Text = "Score"
        '
        'ScoreTextBox
        '
        Me.ScoreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreTextBox.Location = New System.Drawing.Point(395, 173)
        Me.ScoreTextBox.Name = "ScoreTextBox"
        Me.ScoreTextBox.ReadOnly = True
        Me.ScoreTextBox.Size = New System.Drawing.Size(75, 20)
        Me.ScoreTextBox.TabIndex = 21
        Me.ScoreTextBox.TabStop = False
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(124, 357)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(103, 29)
        Me.ResetButton.TabIndex = 22
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        Me.ResetButton.Visible = False
        '
        'CardGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 398)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ScoreTextBox)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.PlayerHandTextBox)
        Me.Controls.Add(Me.DealerHandTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.DoubleButton)
        Me.Controls.Add(Me.StandButton)
        Me.Controls.Add(Me.HitButton)
        Me.Controls.Add(Me.PlayerCard5)
        Me.Controls.Add(Me.PlayerCard4)
        Me.Controls.Add(Me.PlayerCard3)
        Me.Controls.Add(Me.PlayerCard2)
        Me.Controls.Add(Me.PlayerCard1)
        Me.Controls.Add(Me.DealerCard5)
        Me.Controls.Add(Me.DealerCard4)
        Me.Controls.Add(Me.DealerCard3)
        Me.Controls.Add(Me.DealerCard2)
        Me.Controls.Add(Me.DealerCard1)
        Me.Controls.Add(Me.PlayerLabel)
        Me.Controls.Add(Me.DealerLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CardGameForm"
        Me.Text = "Card Game"
        CType(Me.DealerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DealerLabel As Label
    Friend WithEvents PlayerLabel As Label
    Friend WithEvents DealerCard1 As PictureBox
    Friend WithEvents DealerCard2 As PictureBox
    Friend WithEvents DealerCard3 As PictureBox
    Friend WithEvents DealerCard4 As PictureBox
    Friend WithEvents DealerCard5 As PictureBox
    Friend WithEvents PlayerCard1 As PictureBox
    Friend WithEvents PlayerCard2 As PictureBox
    Friend WithEvents PlayerCard3 As PictureBox
    Friend WithEvents PlayerCard4 As PictureBox
    Friend WithEvents PlayerCard5 As PictureBox
    Friend WithEvents HitButton As Button
    Friend WithEvents StandButton As Button
    Friend WithEvents DoubleButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DealerHandTextBox As TextBox
    Friend WithEvents PlayerHandTextBox As TextBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents ScoreTextBox As TextBox
    Friend WithEvents ResetButton As Button
End Class
