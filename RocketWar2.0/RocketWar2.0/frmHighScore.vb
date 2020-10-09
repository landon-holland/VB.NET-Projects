Public Class frmHighScore
    Private Sub frmHighScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Short
        Dim shtTop10 As Short

        t10.Initialize()

        If pyrList.shtPlayers < 9 Then
            shtTop10 = pyrList.shtPlayers
        Else
            shtTop10 = 9
        End If
        For i = 0 To shtTop10
            lstHighScores.Items.Add(t10.arrPlayers(i).GetPlayerString)
        Next
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub
End Class