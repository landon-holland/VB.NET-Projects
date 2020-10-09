<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Message))
        Me.gbxStudentInformation = New System.Windows.Forms.GroupBox()
        Me.mtbPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.gbxBackground = New System.Windows.Forms.GroupBox()
        Me.rbnGreen = New System.Windows.Forms.RadioButton()
        Me.rbnBlue = New System.Windows.Forms.RadioButton()
        Me.rbnRed = New System.Windows.Forms.RadioButton()
        Me.rbnGray = New System.Windows.Forms.RadioButton()
        Me.gbxText = New System.Windows.Forms.GroupBox()
        Me.rbnWhite = New System.Windows.Forms.RadioButton()
        Me.rbnBlack = New System.Windows.Forms.RadioButton()
        Me.cbxVisible = New System.Windows.Forms.CheckBox()
        Me.pbxSun = New System.Windows.Forms.PictureBox()
        Me.pbxSnow = New System.Windows.Forms.PictureBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tlt = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbxStudentInformation.SuspendLayout()
        Me.gbxBackground.SuspendLayout()
        Me.gbxText.SuspendLayout()
        CType(Me.pbxSun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSnow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxStudentInformation
        '
        Me.gbxStudentInformation.Controls.Add(Me.mtbPhoneNumber)
        Me.gbxStudentInformation.Controls.Add(Me.lblPhoneNumber)
        Me.gbxStudentInformation.Controls.Add(Me.txtMajor)
        Me.gbxStudentInformation.Controls.Add(Me.lblMajor)
        Me.gbxStudentInformation.Controls.Add(Me.txtName)
        Me.gbxStudentInformation.Controls.Add(Me.lblName)
        Me.gbxStudentInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxStudentInformation.Location = New System.Drawing.Point(13, 13)
        Me.gbxStudentInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxStudentInformation.Name = "gbxStudentInformation"
        Me.gbxStudentInformation.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxStudentInformation.Size = New System.Drawing.Size(403, 107)
        Me.gbxStudentInformation.TabIndex = 0
        Me.gbxStudentInformation.TabStop = False
        Me.gbxStudentInformation.Text = "Student Information"
        '
        'mtbPhoneNumber
        '
        Me.mtbPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbPhoneNumber.Location = New System.Drawing.Point(133, 76)
        Me.mtbPhoneNumber.Mask = "(999) 000-0000"
        Me.mtbPhoneNumber.Name = "mtbPhoneNumber"
        Me.mtbPhoneNumber.Size = New System.Drawing.Size(263, 23)
        Me.mtbPhoneNumber.TabIndex = 2
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(7, 79)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(120, 17)
        Me.lblPhoneNumber.TabIndex = 4
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'txtMajor
        '
        Me.txtMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMajor.Location = New System.Drawing.Point(67, 47)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.Size = New System.Drawing.Size(329, 23)
        Me.txtMajor.TabIndex = 1
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(8, 50)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(53, 17)
        Me.lblMajor.TabIndex = 2
        Me.lblMajor.Text = "Major:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(67, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(329, 23)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(7, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(9, 124)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(64, 20)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Output"
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.SystemColors.Control
        Me.txtOutput.Location = New System.Drawing.Point(79, 124)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(337, 108)
        Me.txtOutput.TabIndex = 2
        '
        'gbxBackground
        '
        Me.gbxBackground.Controls.Add(Me.rbnGreen)
        Me.gbxBackground.Controls.Add(Me.rbnBlue)
        Me.gbxBackground.Controls.Add(Me.rbnRed)
        Me.gbxBackground.Controls.Add(Me.rbnGray)
        Me.gbxBackground.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBackground.Location = New System.Drawing.Point(423, 13)
        Me.gbxBackground.Name = "gbxBackground"
        Me.gbxBackground.Size = New System.Drawing.Size(154, 131)
        Me.gbxBackground.TabIndex = 3
        Me.gbxBackground.TabStop = False
        Me.gbxBackground.Text = "Background"
        '
        'rbnGreen
        '
        Me.rbnGreen.AutoSize = True
        Me.rbnGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnGreen.Location = New System.Drawing.Point(6, 104)
        Me.rbnGreen.Name = "rbnGreen"
        Me.rbnGreen.Size = New System.Drawing.Size(71, 21)
        Me.rbnGreen.TabIndex = 6
        Me.rbnGreen.TabStop = True
        Me.rbnGreen.Text = "Green"
        Me.rbnGreen.UseVisualStyleBackColor = True
        '
        'rbnBlue
        '
        Me.rbnBlue.AutoSize = True
        Me.rbnBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnBlue.Location = New System.Drawing.Point(6, 77)
        Me.rbnBlue.Name = "rbnBlue"
        Me.rbnBlue.Size = New System.Drawing.Size(58, 21)
        Me.rbnBlue.TabIndex = 5
        Me.rbnBlue.TabStop = True
        Me.rbnBlue.Text = "Blue"
        Me.rbnBlue.UseVisualStyleBackColor = True
        '
        'rbnRed
        '
        Me.rbnRed.AutoSize = True
        Me.rbnRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnRed.Location = New System.Drawing.Point(6, 50)
        Me.rbnRed.Name = "rbnRed"
        Me.rbnRed.Size = New System.Drawing.Size(55, 21)
        Me.rbnRed.TabIndex = 4
        Me.rbnRed.TabStop = True
        Me.rbnRed.Text = "Red"
        Me.rbnRed.UseVisualStyleBackColor = True
        '
        'rbnGray
        '
        Me.rbnGray.AutoSize = True
        Me.rbnGray.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnGray.Location = New System.Drawing.Point(6, 23)
        Me.rbnGray.Name = "rbnGray"
        Me.rbnGray.Size = New System.Drawing.Size(61, 21)
        Me.rbnGray.TabIndex = 3
        Me.rbnGray.TabStop = True
        Me.rbnGray.Text = "Gray"
        Me.rbnGray.UseVisualStyleBackColor = True
        '
        'gbxText
        '
        Me.gbxText.Controls.Add(Me.rbnWhite)
        Me.gbxText.Controls.Add(Me.rbnBlack)
        Me.gbxText.Location = New System.Drawing.Point(423, 150)
        Me.gbxText.Name = "gbxText"
        Me.gbxText.Size = New System.Drawing.Size(154, 82)
        Me.gbxText.TabIndex = 4
        Me.gbxText.TabStop = False
        Me.gbxText.Text = "Text Color"
        '
        'rbnWhite
        '
        Me.rbnWhite.AutoSize = True
        Me.rbnWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnWhite.Location = New System.Drawing.Point(6, 49)
        Me.rbnWhite.Name = "rbnWhite"
        Me.rbnWhite.Size = New System.Drawing.Size(67, 21)
        Me.rbnWhite.TabIndex = 8
        Me.rbnWhite.TabStop = True
        Me.rbnWhite.Text = "White"
        Me.rbnWhite.UseVisualStyleBackColor = True
        '
        'rbnBlack
        '
        Me.rbnBlack.AutoSize = True
        Me.rbnBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnBlack.Location = New System.Drawing.Point(6, 22)
        Me.rbnBlack.Name = "rbnBlack"
        Me.rbnBlack.Size = New System.Drawing.Size(65, 21)
        Me.rbnBlack.TabIndex = 7
        Me.rbnBlack.TabStop = True
        Me.rbnBlack.Text = "Black"
        Me.rbnBlack.UseVisualStyleBackColor = True
        '
        'cbxVisible
        '
        Me.cbxVisible.AutoSize = True
        Me.cbxVisible.Checked = True
        Me.cbxVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxVisible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxVisible.Location = New System.Drawing.Point(13, 238)
        Me.cbxVisible.Name = "cbxVisible"
        Me.cbxVisible.Size = New System.Drawing.Size(143, 20)
        Me.cbxVisible.TabIndex = 9
        Me.cbxVisible.Text = "Message Visible"
        Me.cbxVisible.UseVisualStyleBackColor = True
        '
        'pbxSun
        '
        Me.pbxSun.Image = CType(resources.GetObject("pbxSun.Image"), System.Drawing.Image)
        Me.pbxSun.Location = New System.Drawing.Point(13, 264)
        Me.pbxSun.Name = "pbxSun"
        Me.pbxSun.Size = New System.Drawing.Size(100, 100)
        Me.pbxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSun.TabIndex = 6
        Me.pbxSun.TabStop = False
        '
        'pbxSnow
        '
        Me.pbxSnow.Image = CType(resources.GetObject("pbxSnow.Image"), System.Drawing.Image)
        Me.pbxSnow.Location = New System.Drawing.Point(13, 264)
        Me.pbxSnow.Name = "pbxSnow"
        Me.pbxSnow.Size = New System.Drawing.Size(100, 100)
        Me.pbxSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSnow.TabIndex = 7
        Me.pbxSnow.TabStop = False
        Me.pbxSnow.Visible = False
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Orange
        Me.btnDisplay.Location = New System.Drawing.Point(423, 238)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(154, 36)
        Me.btnDisplay.TabIndex = 10
        Me.btnDisplay.Text = "&Display Message"
        Me.tlt.SetToolTip(Me.btnDisplay, "Click to display message.")
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Orange
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(423, 280)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(154, 36)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset"
        Me.tlt.SetToolTip(Me.btnReset, "Click to reset form.")
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Orange
        Me.btnExit.Location = New System.Drawing.Point(423, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(154, 36)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.tlt.SetToolTip(Me.btnExit, "Click to exit program.")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Message
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(595, 371)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.pbxSnow)
        Me.Controls.Add(Me.pbxSun)
        Me.Controls.Add(Me.cbxVisible)
        Me.Controls.Add(Me.gbxText)
        Me.Controls.Add(Me.gbxBackground)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.gbxStudentInformation)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Message"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Message"
        Me.gbxStudentInformation.ResumeLayout(False)
        Me.gbxStudentInformation.PerformLayout()
        Me.gbxBackground.ResumeLayout(False)
        Me.gbxBackground.PerformLayout()
        Me.gbxText.ResumeLayout(False)
        Me.gbxText.PerformLayout()
        CType(Me.pbxSun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSnow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxStudentInformation As GroupBox
    Friend WithEvents mtbPhoneNumber As MaskedTextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents lblMajor As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents gbxBackground As GroupBox
    Friend WithEvents rbnGray As RadioButton
    Friend WithEvents rbnGreen As RadioButton
    Friend WithEvents rbnBlue As RadioButton
    Friend WithEvents rbnRed As RadioButton
    Friend WithEvents gbxText As GroupBox
    Friend WithEvents rbnWhite As RadioButton
    Friend WithEvents rbnBlack As RadioButton
    Friend WithEvents cbxVisible As CheckBox
    Friend WithEvents pbxSun As PictureBox
    Friend WithEvents pbxSnow As PictureBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tlt As ToolTip
End Class
