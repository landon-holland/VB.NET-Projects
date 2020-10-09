Public Class frmPlayers
    Public Sub Reload()
        Dim i As Short

        lstPlayers.Items.Clear()
        For i = 0 To pyrList.shtPlayers
            lstPlayers.Items.Add(pyrList.arrPlayers(i).GetPlayerString)
        Next i
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub
    Private Sub lstPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPlayers.SelectedIndexChanged
        Me.Hide()
        frmEdit.DisplayID(lstPlayers.SelectedIndex)
        frmEdit.Show()
    End Sub
    Private Sub frmPlayers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim i As Short

        lstPlayers.Items.Clear()
        For i = 0 To pyrList.shtPlayers
            lstPlayers.Items.Add(pyrList.arrPlayers(i).GetPlayerString)
        Next i
    End Sub
End Class