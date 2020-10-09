Public Class frmEdit
    Dim shtID As Short
    Public Sub DisplayID(shtPlayerID As Short)
        shtID = shtPlayerID
        With pyrList.arrPlayers(shtID)
            txtID.Text = Trim(Str(.shtID))
            txtInitials.Text = .strInitials
            txtScore.Text = Trim(Str(.lngScore))
            txtPlays.Text = Trim(Str(.shtPlays))
        End With
    End Sub
    Sub GoBack()
        pyrList.Save()
        Me.Hide()
        frmPlayers.Reload()
        frmPlayers.Show()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Call GoBack()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        pyrList.Delete(shtID)

        MsgBox("Deleted.")
        Call GoBack()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With pyrList.arrPlayers(shtID)
            .strInitials = txtInitials.Text
            .lngScore = Val(txtScore.Text)
            .shtPlays = Val(txtPlays.Text)
        End With

        MsgBox("Edited.")
        Call GoBack()
    End Sub
End Class