Public Class frmBagOfTiles
    Structure Tile
        Dim strLetter As String
        Dim shtValue As Short
        Function GetTileString() As String
            GetTileString = String.Empty
            GetTileString = strLetter + " - " + Trim(Str(shtValue))
        End Function
    End Structure
    Structure Bag
        Dim arrTiles() As Tile
        Sub Create()
            Dim strPath As String
            Dim strFillLetter As String
            Dim shtFillValue As Short
            Dim shtAmount As Short
            Dim i As Short
            Dim j As Short
            Dim shtTileCount As Short
            Dim strCurrentLine As String
            ReDim arrTiles(99)

            shtTileCount = 0
            strPath = "D:\CP2\VB.NET Project Files\BagOfTiles\resources\values.txt"
            FileOpen(1, strPath, OpenMode.Input)
            For i = 0 To 26
                strCurrentLine = LineInput(1)
                strFillLetter = Mid(strCurrentLine, 1, 1)
                If Len(strCurrentLine) = 6 Then
                    If strFillLetter = "E" Then
                        shtFillValue = Mid(strCurrentLine, 3, 1)
                        shtAmount = Mid(strCurrentLine, 5, 2)
                    ElseIf strFillLetter = "Q" Or strFillLetter = "Z" Then
                        shtFillValue = Mid(strCurrentLine, 3, 2)
                        shtAmount = Mid(strCurrentLine, 6, 1)
                    End If
                    For j = 1 To shtAmount
                        arrTiles(shtTileCount).strLetter = strFillLetter
                        arrTiles(shtTileCount).shtValue = shtFillValue
                        shtTileCount += 1
                    Next
                Else
                    shtFillValue = Mid(strCurrentLine, 3, 1)
                    shtAmount = Mid(strCurrentLine, 5, 1)
                    For j = 1 To shtAmount
                        arrTiles(shtTileCount).strLetter = strFillLetter
                        arrTiles(shtTileCount).shtValue = shtFillValue
                        shtTileCount += 1
                    Next
                End If
            Next
            FileClose(1)
        End Sub
        Sub Shuffle()
            Dim shtRandomNumber As Short
            Dim tleTemp As Tile
            Dim i As Short

            Randomize()
            For i = 0 To 99
                shtRandomNumber = Int(Rnd() * 99)
                tleTemp = arrTiles(i)
                arrTiles(i) = arrTiles(shtRandomNumber)
            Next
        End Sub
    End Structure
    Dim BagOfTiles As Bag
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim i As Short

        BagOfTiles.Create()
        BagOfTiles.Shuffle()
        For i = 0 To 99
            lstTiles.Items.Add(BagOfTiles.arrTiles(i).GetTileString())
        Next
    End Sub
    Private Sub lstTiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTiles.SelectedIndexChanged
        picTile.ImageLocation = "D:\CP2\VB.NET Project Files\BagOfTiles\resources\pics\" + BagOfTiles.arrTiles(lstTiles.SelectedIndex).strLetter + ".png"
    End Sub
End Class