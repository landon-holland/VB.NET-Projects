Public Class frmBooks
    Dim blsMaster As BookList
    Dim arrBooksIndexes(54) As Short
    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Short

        blsMaster.Create()

        For i = 0 To 54
            lstBooks.Items.Add(blsMaster.arrBooks(i).GetBookString)
            arrBooksIndexes(i) = blsMaster.arrBooks(i).shtID
        Next i
    End Sub
    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        Dim strIndex As String
        strIndex = lstBooks.SelectedIndex
        If Not blsMaster.arrBooks(strIndex).strTitle = String.Empty Then
            picCover.ImageLocation = blsMaster.arrBooks(arrBooksIndexes(strIndex)).GetCoverPath
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmBookRecommendation.Show()
    End Sub
End Class