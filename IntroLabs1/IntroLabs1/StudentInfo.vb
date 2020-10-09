Public Class StudentInfo
    Private Sub btnDisplay1_Click(sender As Object, e As EventArgs) Handles btnDisplay1.Click
        'Displays student 1's information.
        txtName.Text = "Christopher Lee"
        txtMajor.Text = "Computer Science"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clear text boxes.
        txtName.Clear()
        txtMajor.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close program.
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        MsgBox("Print")
    End Sub

    Private Sub btnDisplay2_Click(sender As Object, e As EventArgs) Handles btnDisplay2.Click
        'Display student 2's information.
        txtName.Text = "Bob Builder"
        txtMajor.Text = "Construction"
    End Sub

    Private Sub btnDisplay3_Click(sender As Object, e As EventArgs) Handles btnDisplay3.Click
        'Display student 3's information.
        txtName.Text = "Cool Kid"
        txtMajor.Text = "Being Cool"
    End Sub
End Class
