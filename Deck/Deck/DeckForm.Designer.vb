<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeckForm
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
        Me.SortedListBox = New System.Windows.Forms.ListBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.ShuffleButton = New System.Windows.Forms.Button()
        Me.ShuffledListBox = New System.Windows.Forms.ListBox()
        Me.CardPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.CardPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SortedListBox
        '
        Me.SortedListBox.FormattingEnabled = True
        Me.SortedListBox.Location = New System.Drawing.Point(12, 12)
        Me.SortedListBox.Name = "SortedListBox"
        Me.SortedListBox.Size = New System.Drawing.Size(116, 186)
        Me.SortedListBox.TabIndex = 0
        '
        'GenerateButton
        '
        Me.GenerateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateButton.Location = New System.Drawing.Point(12, 204)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(116, 27)
        Me.GenerateButton.TabIndex = 1
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'ShuffleButton
        '
        Me.ShuffleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShuffleButton.Location = New System.Drawing.Point(134, 204)
        Me.ShuffleButton.Name = "ShuffleButton"
        Me.ShuffleButton.Size = New System.Drawing.Size(116, 27)
        Me.ShuffleButton.TabIndex = 2
        Me.ShuffleButton.Text = "Shuffle"
        Me.ShuffleButton.UseVisualStyleBackColor = True
        '
        'ShuffledListBox
        '
        Me.ShuffledListBox.FormattingEnabled = True
        Me.ShuffledListBox.Location = New System.Drawing.Point(134, 12)
        Me.ShuffledListBox.Name = "ShuffledListBox"
        Me.ShuffledListBox.Size = New System.Drawing.Size(116, 186)
        Me.ShuffledListBox.TabIndex = 3
        '
        'CardPictureBox
        '
        Me.CardPictureBox.Location = New System.Drawing.Point(258, 13)
        Me.CardPictureBox.Name = "CardPictureBox"
        Me.CardPictureBox.Size = New System.Drawing.Size(122, 185)
        Me.CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CardPictureBox.TabIndex = 4
        Me.CardPictureBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(258, 205)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(122, 26)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DeckForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 243)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CardPictureBox)
        Me.Controls.Add(Me.ShuffledListBox)
        Me.Controls.Add(Me.ShuffleButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.SortedListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DeckForm"
        Me.Text = "Deck"
        CType(Me.CardPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SortedListBox As ListBox
    Friend WithEvents GenerateButton As Button
    Friend WithEvents ShuffleButton As Button
    Friend WithEvents ShuffledListBox As ListBox
    Friend WithEvents CardPictureBox As PictureBox
    Friend WithEvents ExitButton As Button
End Class
