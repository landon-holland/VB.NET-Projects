<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdit))
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtInitials = New System.Windows.Forms.TextBox()
        Me.lblInitials = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.lblPlays = New System.Windows.Forms.Label()
        Me.txtPlays = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.Font = New System.Drawing.Font("RiskofRainFont", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.White
        Me.lblEdit.Location = New System.Drawing.Point(12, 9)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(66, 26)
        Me.lblEdit.TabIndex = 1
        Me.lblEdit.Text = "Edit"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(12, 35)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 15)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Black
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(12, 53)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(230, 22)
        Me.txtID.TabIndex = 3
        Me.txtID.TabStop = False
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInitials
        '
        Me.txtInitials.BackColor = System.Drawing.Color.Black
        Me.txtInitials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInitials.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitials.ForeColor = System.Drawing.Color.White
        Me.txtInitials.Location = New System.Drawing.Point(12, 94)
        Me.txtInitials.Name = "txtInitials"
        Me.txtInitials.Size = New System.Drawing.Size(230, 22)
        Me.txtInitials.TabIndex = 4
        Me.txtInitials.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInitials
        '
        Me.lblInitials.AutoSize = True
        Me.lblInitials.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitials.ForeColor = System.Drawing.Color.White
        Me.lblInitials.Location = New System.Drawing.Point(12, 76)
        Me.lblInitials.Name = "lblInitials"
        Me.lblInitials.Size = New System.Drawing.Size(63, 15)
        Me.lblInitials.TabIndex = 5
        Me.lblInitials.Text = "Initials"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(12, 119)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(42, 15)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Score"
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.Color.Black
        Me.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScore.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.ForeColor = System.Drawing.Color.White
        Me.txtScore.Location = New System.Drawing.Point(12, 137)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(230, 22)
        Me.txtScore.TabIndex = 7
        Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPlays
        '
        Me.lblPlays.AutoSize = True
        Me.lblPlays.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlays.ForeColor = System.Drawing.Color.White
        Me.lblPlays.Location = New System.Drawing.Point(12, 162)
        Me.lblPlays.Name = "lblPlays"
        Me.lblPlays.Size = New System.Drawing.Size(42, 15)
        Me.lblPlays.TabIndex = 8
        Me.lblPlays.Text = "Plays"
        '
        'txtPlays
        '
        Me.txtPlays.BackColor = System.Drawing.Color.Black
        Me.txtPlays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlays.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlays.ForeColor = System.Drawing.Color.White
        Me.txtPlays.Location = New System.Drawing.Point(12, 180)
        Me.txtPlays.Name = "txtPlays"
        Me.txtPlays.Size = New System.Drawing.Size(230, 22)
        Me.txtPlays.TabIndex = 9
        Me.txtPlays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Font = New System.Drawing.Font("RiskofRainFont", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(12, 208)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(68, 32)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Font = New System.Drawing.Font("RiskofRainFont", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(178, 208)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(64, 32)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Black
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("RiskofRainFont", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(86, 208)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 32)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'frmEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(254, 245)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtPlays)
        Me.Controls.Add(Me.lblPlays)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblInitials)
        Me.Controls.Add(Me.txtInitials)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblEdit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEdit"
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEdit As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtInitials As TextBox
    Friend WithEvents lblInitials As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents txtScore As TextBox
    Friend WithEvents lblPlays As Label
    Friend WithEvents txtPlays As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
End Class
