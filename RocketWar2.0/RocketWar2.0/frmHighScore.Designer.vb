<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHighScore))
        Me.lblHighScores = New System.Windows.Forms.Label()
        Me.lstHighScores = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHighScores
        '
        Me.lblHighScores.AutoSize = True
        Me.lblHighScores.Font = New System.Drawing.Font("RiskofRainFont", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScores.ForeColor = System.Drawing.Color.White
        Me.lblHighScores.Location = New System.Drawing.Point(12, 9)
        Me.lblHighScores.Name = "lblHighScores"
        Me.lblHighScores.Size = New System.Drawing.Size(168, 26)
        Me.lblHighScores.TabIndex = 1
        Me.lblHighScores.Text = "High Scores"
        '
        'lstHighScores
        '
        Me.lstHighScores.BackColor = System.Drawing.Color.Black
        Me.lstHighScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstHighScores.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHighScores.ForeColor = System.Drawing.Color.White
        Me.lstHighScores.FormattingEnabled = True
        Me.lstHighScores.ItemHeight = 15
        Me.lstHighScores.Location = New System.Drawing.Point(12, 38)
        Me.lstHighScores.Name = "lstHighScores"
        Me.lstHighScores.Size = New System.Drawing.Size(348, 152)
        Me.lstHighScores.TabIndex = 2
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Font = New System.Drawing.Font("RiskofRainFont", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(12, 196)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(348, 41)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(373, 247)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstHighScores)
        Me.Controls.Add(Me.lblHighScores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHighScore"
        Me.Text = "High Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHighScores As Label
    Friend WithEvents lstHighScores As ListBox
    Friend WithEvents btnBack As Button
End Class
