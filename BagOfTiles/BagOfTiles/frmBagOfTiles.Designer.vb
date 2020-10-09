<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBagOfTiles
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
        Me.lstTiles = New System.Windows.Forms.ListBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.picTile = New System.Windows.Forms.PictureBox()
        CType(Me.picTile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTiles
        '
        Me.lstTiles.FormattingEnabled = True
        Me.lstTiles.ItemHeight = 16
        Me.lstTiles.Location = New System.Drawing.Point(12, 12)
        Me.lstTiles.Name = "lstTiles"
        Me.lstTiles.Size = New System.Drawing.Size(122, 244)
        Me.lstTiles.TabIndex = 0
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(140, 12)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(95, 64)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Generate and Shuffle"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'picTile
        '
        Me.picTile.Location = New System.Drawing.Point(143, 82)
        Me.picTile.Name = "picTile"
        Me.picTile.Size = New System.Drawing.Size(92, 92)
        Me.picTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTile.TabIndex = 2
        Me.picTile.TabStop = False
        '
        'frmBagOfTiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 275)
        Me.Controls.Add(Me.picTile)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lstTiles)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBagOfTiles"
        Me.Text = "Bag of Tiles"
        CType(Me.picTile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstTiles As ListBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents picTile As PictureBox
End Class
