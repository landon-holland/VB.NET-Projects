Public Class DeckForm
    Structure Card
        Dim ValueInteger As Integer
        Dim SuitInteger As Integer
        Function GetCardString() As String
            GetCardString = String.Empty
            Select Case ValueInteger
                Case 1
                    GetCardString += "a"
                Case 10
                    GetCardString += "t"
                Case 11
                    GetCardString += "j"
                Case 12
                    GetCardString += "q"
                Case 13
                    GetCardString += "k"
                Case Else
                    GetCardString += Trim(Str(ValueInteger))
            End Select
            Select Case SuitInteger
                Case 1
                    GetCardString += "s"
                Case 2
                    GetCardString += "h"
                Case 3
                    GetCardString += "d"
                Case 4
                    GetCardString += "c"
            End Select
        End Function
    End Structure
    Dim DeckArray(0 To 51) As Card
    Dim ShuffledDeckArray(0 To 51) As Card

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        Dim i As Short
        Dim j As Short
        Dim CardCountShort As Short

        CardCountShort = 0
        For i = 1 To 4
            For j = 1 To 13
                With DeckArray(CardCountShort)
                    .ValueInteger = j
                    .SuitInteger = i
                End With

                CardCountShort += 1
            Next j
        Next i

        For i = 0 To 51
            SortedListBox.Items.Add(DeckArray(i).GetCardString)
        Next i
    End Sub

    Private Sub ShuffleButton_Click(sender As Object, e As EventArgs) Handles ShuffleButton.Click
        Dim RandomNumberShort As Short
        Dim TempSuitShort As Short
        Dim TempValueShort As Short
        Dim i As Short
        Randomize()

        For i = 0 To 51
            ShuffledDeckArray(i).SuitInteger = DeckArray(i).SuitInteger
            ShuffledDeckArray(i).ValueInteger = DeckArray(i).ValueInteger
        Next

        For i = 0 To 51
            RandomNumberShort = Int(Rnd() * 51)
            TempSuitShort = ShuffledDeckArray(i).SuitInteger
            TempValueShort = ShuffledDeckArray(i).ValueInteger
            ShuffledDeckArray(i).SuitInteger = ShuffledDeckArray(RandomNumberShort).SuitInteger
            ShuffledDeckArray(i).ValueInteger = ShuffledDeckArray(RandomNumberShort).ValueInteger
            ShuffledDeckArray(RandomNumberShort).SuitInteger = TempSuitShort
            ShuffledDeckArray(RandomNumberShort).ValueInteger = TempValueShort
        Next i

        For i = 0 To 51
            ShuffledListBox.Items.Add(ShuffledDeckArray(i).GetCardString)
        Next i
    End Sub

    Private Sub ShuffledListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShuffledListBox.SelectedIndexChanged
        CardPictureBox.ImageLocation = "D:\CP2\VB.NET Project Files\Deck\cardimages\" + ShuffledDeckArray(ShuffledListBox.SelectedIndex).GetCardString + ".gif"
    End Sub

    Private Sub SortedListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortedListBox.SelectedIndexChanged
        CardPictureBox.ImageLocation = "D:\CP2\VB.NET Project Files\Deck\cardimages\" + DeckArray(SortedListBox.SelectedIndex).GetCardString + ".gif"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
