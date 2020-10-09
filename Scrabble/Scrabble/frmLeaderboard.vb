Public Class frmLeaderboard
    Structure Player
        Public shtID As Short
        Public strInitials As String
        Public lngScore As Long
    End Structure
    Public arrPlayers(19) As Player
    Public shtPlayers As Short
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmScrabble.Show()
        Me.Hide()
    End Sub
    Private Sub frmLeaderboard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim i As Short
        Dim pyrTemp As Player
        Dim f As Short
        Dim b As Short

        For f = 1 To shtPlayers - 1
            For b = f + 1 To shtPlayers
                If arrPlayers(f).lngScore < arrPlayers(b).lngScore Then
                    pyrTemp = arrPlayers(f)
                    arrPlayers(f) = arrPlayers(b)
                    arrPlayers(b) = pyrTemp
                End If
            Next b
        Next f

        For i = 1 To shtPlayers
            lstLeaderboard.Items.Add(Trim(Str(i)) + ": " + Trim(Str(arrPlayers(i).lngScore)) + " - " + Trim(Str(arrPlayers(i).shtID)) + "." + arrPlayers(i).strInitials)
        Next
    End Sub
End Class