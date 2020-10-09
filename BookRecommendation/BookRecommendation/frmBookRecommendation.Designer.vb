<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookRecommendation
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnRecommend = New System.Windows.Forms.Button()
        Me.btnRatings = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(233, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Book Recommendation"
        '
        'btnRecommend
        '
        Me.btnRecommend.Location = New System.Drawing.Point(46, 53)
        Me.btnRecommend.Name = "btnRecommend"
        Me.btnRecommend.Size = New System.Drawing.Size(164, 30)
        Me.btnRecommend.TabIndex = 1
        Me.btnRecommend.Text = "Recommend"
        Me.btnRecommend.UseVisualStyleBackColor = True
        '
        'btnRatings
        '
        Me.btnRatings.Location = New System.Drawing.Point(46, 125)
        Me.btnRatings.Name = "btnRatings"
        Me.btnRatings.Size = New System.Drawing.Size(164, 30)
        Me.btnRatings.TabIndex = 2
        Me.btnRatings.Text = "Ratings"
        Me.btnRatings.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(46, 161)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(164, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBooks
        '
        Me.btnBooks.Location = New System.Drawing.Point(46, 89)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(164, 30)
        Me.btnBooks.TabIndex = 4
        Me.btnBooks.Text = "Books"
        Me.btnBooks.UseVisualStyleBackColor = True
        '
        'frmBookRecommendation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 201)
        Me.Controls.Add(Me.btnBooks)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRatings)
        Me.Controls.Add(Me.btnRecommend)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBookRecommendation"
        Me.Text = "Book Recommendation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnRecommend As Button
    Friend WithEvents btnRatings As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBooks As Button
End Class
