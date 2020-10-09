<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlgorithms
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lst = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnShuffle = New System.Windows.Forms.Button()
        Me.btnUniqueness = New System.Windows.Forms.Button()
        Me.lst2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(22, 569)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(183, 61)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lst
        '
        Me.lst.FormattingEnabled = True
        Me.lst.ItemHeight = 24
        Me.lst.Location = New System.Drawing.Point(22, 22)
        Me.lst.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lst.Name = "lst"
        Me.lst.Size = New System.Drawing.Size(191, 532)
        Me.lst.TabIndex = 1
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(227, 22)
        Me.btnSort.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(310, 70)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnShuffle
        '
        Me.btnShuffle.Location = New System.Drawing.Point(227, 103)
        Me.btnShuffle.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.Size = New System.Drawing.Size(310, 70)
        Me.btnShuffle.TabIndex = 3
        Me.btnShuffle.Text = "Shuffle"
        Me.btnShuffle.UseVisualStyleBackColor = True
        '
        'btnUniqueness
        '
        Me.btnUniqueness.Location = New System.Drawing.Point(227, 185)
        Me.btnUniqueness.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnUniqueness.Name = "btnUniqueness"
        Me.btnUniqueness.Size = New System.Drawing.Size(310, 70)
        Me.btnUniqueness.TabIndex = 4
        Me.btnUniqueness.Text = "Uniqueness"
        Me.btnUniqueness.UseVisualStyleBackColor = True
        '
        'lst2
        '
        Me.lst2.FormattingEnabled = True
        Me.lst2.ItemHeight = 24
        Me.lst2.Location = New System.Drawing.Point(548, 22)
        Me.lst2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lst2.Name = "lst2"
        Me.lst2.Size = New System.Drawing.Size(191, 532)
        Me.lst2.TabIndex = 5
        '
        'frmAlgorithms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 646)
        Me.Controls.Add(Me.lst2)
        Me.Controls.Add(Me.btnUniqueness)
        Me.Controls.Add(Me.btnShuffle)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.lst)
        Me.Controls.Add(Me.btnGenerate)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmAlgorithms"
        Me.Text = "Algorithms"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents lst As ListBox
    Friend WithEvents btnSort As Button
    Friend WithEvents btnShuffle As Button
    Friend WithEvents btnUniqueness As Button
    Friend WithEvents lst2 As ListBox
End Class
