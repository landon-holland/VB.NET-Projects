<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInfo
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
        Me.lblStudentInformationCaption = New System.Windows.Forms.Label()
        Me.lblAcademicMajorCaption = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMajor = New System.Windows.Forms.TextBox()
        Me.btnDisplay1 = New System.Windows.Forms.Button()
        Me.btnDisplay2 = New System.Windows.Forms.Button()
        Me.btnDisplay3 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStudentInformationCaption
        '
        Me.lblStudentInformationCaption.AutoSize = True
        Me.lblStudentInformationCaption.Location = New System.Drawing.Point(24, 12)
        Me.lblStudentInformationCaption.Name = "lblStudentInformationCaption"
        Me.lblStudentInformationCaption.Size = New System.Drawing.Size(115, 17)
        Me.lblStudentInformationCaption.TabIndex = 0
        Me.lblStudentInformationCaption.Text = "Student Name:"
        '
        'lblAcademicMajorCaption
        '
        Me.lblAcademicMajorCaption.AutoSize = True
        Me.lblAcademicMajorCaption.Location = New System.Drawing.Point(12, 40)
        Me.lblAcademicMajorCaption.Name = "lblAcademicMajorCaption"
        Me.lblAcademicMajorCaption.Size = New System.Drawing.Size(127, 17)
        Me.lblAcademicMajorCaption.TabIndex = 1
        Me.lblAcademicMajorCaption.Text = "Academic Major:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(145, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(222, 23)
        Me.txtName.TabIndex = 2
        Me.txtName.TabStop = False
        '
        'txtMajor
        '
        Me.txtMajor.Location = New System.Drawing.Point(145, 37)
        Me.txtMajor.Name = "txtMajor"
        Me.txtMajor.ReadOnly = True
        Me.txtMajor.Size = New System.Drawing.Size(222, 23)
        Me.txtMajor.TabIndex = 3
        Me.txtMajor.TabStop = False
        '
        'btnDisplay1
        '
        Me.btnDisplay1.Location = New System.Drawing.Point(15, 66)
        Me.btnDisplay1.Name = "btnDisplay1"
        Me.btnDisplay1.Size = New System.Drawing.Size(95, 49)
        Me.btnDisplay1.TabIndex = 4
        Me.btnDisplay1.Text = "Display Student #&1"
        Me.btnDisplay1.UseVisualStyleBackColor = True
        '
        'btnDisplay2
        '
        Me.btnDisplay2.Location = New System.Drawing.Point(145, 66)
        Me.btnDisplay2.Name = "btnDisplay2"
        Me.btnDisplay2.Size = New System.Drawing.Size(95, 49)
        Me.btnDisplay2.TabIndex = 5
        Me.btnDisplay2.Text = "Display Student #&2"
        Me.btnDisplay2.UseVisualStyleBackColor = True
        '
        'btnDisplay3
        '
        Me.btnDisplay3.Location = New System.Drawing.Point(272, 66)
        Me.btnDisplay3.Name = "btnDisplay3"
        Me.btnDisplay3.Size = New System.Drawing.Size(95, 49)
        Me.btnDisplay3.TabIndex = 6
        Me.btnDisplay3.Text = "Display Student #&3"
        Me.btnDisplay3.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(15, 121)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 27)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(145, 121)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(95, 27)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(272, 121)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 27)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StudentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 155)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnDisplay3)
        Me.Controls.Add(Me.btnDisplay2)
        Me.Controls.Add(Me.btnDisplay1)
        Me.Controls.Add(Me.txtMajor)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblAcademicMajorCaption)
        Me.Controls.Add(Me.lblStudentInformationCaption)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StudentInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStudentInformationCaption As Label
    Friend WithEvents lblAcademicMajorCaption As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents btnDisplay1 As Button
    Friend WithEvents btnDisplay2 As Button
    Friend WithEvents btnDisplay3 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button
End Class
