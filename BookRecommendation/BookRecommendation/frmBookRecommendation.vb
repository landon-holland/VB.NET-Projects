Public Class frmBookRecommendation
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnRecommend.Click
        Me.Hide()
        frmRecommend.Show()
    End Sub
    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        Me.Hide()
        frmBooks.Show()
    End Sub
    Private Sub btnRatings_Click(sender As Object, e As EventArgs) Handles btnRatings.Click
        Me.Hide()
        frmRatings.Show()
    End Sub
End Class