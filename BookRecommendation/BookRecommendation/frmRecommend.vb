Public Class frmRecommend
    Dim blsMaster As BookList
    Dim rlsMaster As ReaderList
    Dim arrBookIndexes(54) As Short
    Sub Clear()
        For i = 0 To 54
            arrBookIndexes(i) = -1
        Next i
        lstBooks.Items.Clear()
        txtBestMatch.Text = String.Empty
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmBookRecommendation.Show()
    End Sub
    Private Sub frmRecommend_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim i As Short

        blsMaster.Create()
        rlsMaster.Create()

        Call Clear()

        For i = 0 To 85
            With rlsMaster.arrReaders(i)
                comReader1.Items.Add(.GetReaderString)
            End With
        Next
    End Sub
    Private Sub btnRecommend_Click(sender As Object, e As EventArgs) Handles btnRecommend.Click
        Dim i As Short
        Dim arrBooks(54) As Book
        Dim shtReaderID As Short
        Dim shtSimilarID As Short
        Dim shtBookIndexCount As Short

        Call Clear()
        shtBookIndexCount = 0

        shtReaderID = comReader1.SelectedIndex
        If rbnA.Checked = True Then
            arrBooks = rlsMaster.MethodA(shtReaderID)
            txtBestMatch.Text = "N/A"
            For i = 0 To 54
                If Not arrBooks(i).strTitle = String.Empty Then
                    lstBooks.Items.Add(arrBooks(i).GetBookString)
                    arrBookIndexes(shtBookIndexCount) = arrBooks(i).shtID
                    shtBookIndexCount += 1
                End If
            Next i
        ElseIf rbnB.Checked = True Then
            shtSimilarID = rlsMaster.MethodB(shtReaderID)
            arrBooks = rlsMaster.FindSimilarBooks(shtReaderID, shtSimilarID)
            txtBestMatch.Text = rlsMaster.arrReaders(shtSimilarID).GetReaderString
            For i = 0 To 54
                If Not arrBooks(i).strTitle = String.Empty Then
                    lstBooks.Items.Add(arrBooks(i).GetBookString)
                    arrBookIndexes(shtBookIndexCount) = arrBooks(i).shtID
                    shtBookIndexCount += 1
                End If
            Next i
        ElseIf rbnC.Checked = True Then
            shtSimilarID = rlsMaster.MethodC(shtReaderID)
            txtBestMatch.Text = "N/A"
            lstBooks.Items.Add(blsMaster.arrBooks(shtSimilarID).GetBookString)
            arrBookIndexes(0) = shtSimilarID
        End If
    End Sub
    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        Dim strIndex As String
        strIndex = lstBooks.SelectedIndex
        If Not blsMaster.arrBooks(strIndex).strTitle = String.Empty Then
            picCover.ImageLocation = blsMaster.arrBooks(arrBookIndexes(strIndex)).GetCoverPath
        End If
    End Sub
End Class