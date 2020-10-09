Public Class frmRatings
    Private Sub frmRatings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim rls As ReaderList
        Dim strRatings As String
        Dim strOutput As String
        Dim i As Short
        Dim j As Short

        rls.Create()

        For i = 0 To 85
            strRatings = String.Empty
            If i = 0 Then
                strOutput = rls.arrReaders(i).GetReaderString
                For j = 0 To 54
                    strRatings += str(rls.arrReaders(i).arrRatings(j)) + " "
                Next j
                strOutput += vbCrLf + strRatings
            Else
                strOutput += vbCrLf + rls.arrReaders(i).GetReaderString
                For j = 0 To 54
                    strRatings += str(rls.arrReaders(i).arrRatings(j)) + " "
                Next j
                strOutput += vbCrLf + strRatings
            End If
        Next i

        txtRatings.Text = strOutput
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmBookRecommendation.Show()
    End Sub
End Class