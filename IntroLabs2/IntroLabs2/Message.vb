Public Class Message

    Private GrayColor As Color
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtOutput.Text =
            "My name: " _
            & txtName.Text & ControlChars.NewLine _
            & "Major : " _
            & txtMajor.Text & ControlChars.NewLine _
            & "Phone Number: " _
            & mtbPhoneNumber.Text
    End Sub

    Private Sub rbnGray_CheckedChanged(sender As Object, e As EventArgs) Handles rbnGray.CheckedChanged
        Me.BackColor = GrayColor
    End Sub

    Private Sub rbnRed_CheckedChanged(sender As Object, e As EventArgs) Handles rbnRed.CheckedChanged
        Me.BackColor = Color.Red
    End Sub

    Private Sub rbnBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbnBlue.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub rbnGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbnGreen.CheckedChanged
        Me.BackColor = Color.Green
    End Sub

    Private Sub rbnBlack_CheckedChanged(sender As Object, e As EventArgs) Handles rbnBlack.CheckedChanged
        Me.ForeColor = Color.Black
    End Sub

    Private Sub rbnWhite_CheckedChanged(sender As Object, e As EventArgs) Handles rbnWhite.CheckedChanged
        Me.ForeColor = Color.White
    End Sub

    Private Sub Message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrayColor = Me.BackColor
    End Sub

    Private Sub cbxVisible_CheckedChanged(sender As Object, e As EventArgs) Handles cbxVisible.CheckedChanged
        txtOutput.Visible = cbxVisible.Checked
        lblOutput.Visible = cbxVisible.Checked
    End Sub

    Private Sub pbxSnow_Click(sender As Object, e As EventArgs) Handles pbxSnow.Click
        pbxSnow.Visible = False
        pbxSun.Visible = True
    End Sub

    Private Sub pbxSun_Click(sender As Object, e As EventArgs) Handles pbxSun.Click
        pbxSnow.Visible = True
        pbxSun.Visible = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        txtMajor.Clear()
        mtbPhoneNumber.Clear()
        txtOutput.Clear()

        rbnGray.Checked = True
        rbnBlack.Checked = True

        cbxVisible.Checked = True

        pbxSnow.Visible = False
        pbxSun.Visible = True

        txtName.Focus()
    End Sub
End Class