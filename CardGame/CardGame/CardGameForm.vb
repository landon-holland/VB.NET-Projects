Imports System.ComponentModel
Public Class CardGameForm
    Structure Card
        Dim ValueInteger As Integer
        Dim SuitInteger As Integer
        Dim FaceDownBoolean As Boolean
        Dim ActiveBoolean As Boolean
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
    Structure Player
        Dim IDShort As Short
        Dim InitialsString As String
        Dim ScoreInteger As Integer
    End Structure
    Dim DealerCardArray(4) As PictureBox
    Dim PlayerCardArray(4) As PictureBox
    Dim DeckArray(51) As Card
    Dim ShuffledDeckArray(51) As Card
    Dim DealerHand(4) As Card
    Dim PlayerHand(4) As Card
    Dim DealerHandCountShort As Short
    Dim PlayerHandCountShort As Short
    Dim DealerValueShort As Short
    Dim PlayerValueShort As Short
    Dim PlayerArray(19) As Player
    Dim CurrentPlayer As Player
    Dim PlayersShort As Short
    Dim CurrentPlayerIDShort As Short
    Dim CardCountShort As Short
    Dim BetInteger As Integer
    Sub SetObjectArray()
        DealerCardArray(0) = DealerCard1
        DealerCardArray(1) = DealerCard2
        DealerCardArray(2) = DealerCard3
        DealerCardArray(3) = DealerCard4
        DealerCardArray(4) = DealerCard5
        PlayerCardArray(0) = PlayerCard1
        PlayerCardArray(1) = PlayerCard2
        PlayerCardArray(2) = PlayerCard3
        PlayerCardArray(3) = PlayerCard4
        PlayerCardArray(4) = PlayerCard5
    End Sub
    Sub GenerateCards()
        Dim i As Short
        Dim j As Short
        Dim CardCountShort As Short

        CardCountShort = 0
        For i = 1 To 4
            For j = 1 To 13
                With DeckArray(CardCountShort)
                    .ValueInteger = j
                    .SuitInteger = i
                    .FaceDownBoolean = False
                    .ActiveBoolean = False
                End With
                CardCountShort += 1
            Next j
        Next i
    End Sub
    Sub ShuffleCards()
        Dim RandomNumberShort As Short
        Dim TempCard As Card
        Dim i As Short
        Randomize()

        For i = 0 To 51
            ShuffledDeckArray(i) = DeckArray(i)
        Next

        For i = 0 To 51
            RandomNumberShort = Int(Rnd() * 51)
            TempCard = ShuffledDeckArray(i)
            ShuffledDeckArray(i) = ShuffledDeckArray(RandomNumberShort)
            ShuffledDeckArray(RandomNumberShort) = TempCard
        Next
    End Sub
    Sub DisplayHands()
        Dim i As Short
        For i = 0 To 4
            If DealerHand(i).FaceDownBoolean = False And DealerHand(i).ActiveBoolean = True Then
                DealerCardArray(i).Visible = True
                DealerCardArray(i).ImageLocation = "D:\CP2\VB.NET Project Files\CardGame\cardimages\" + DealerHand(i).GetCardString + ".gif"
            ElseIf DealerHand(i).FaceDownBoolean = True And DealerHand(i).ActiveBoolean = True Then
                DealerCardArray(i).Visible = True
                DealerCardArray(i).ImageLocation = "D:\CP2\VB.NET Project Files\CardGame\cardimages\back.png"
            ElseIf DealerHand(i).ActiveBoolean = False Then
                DealerCardArray(i).Visible = False
            End If
        Next
        For i = 0 To 4
            If PlayerHand(i).ActiveBoolean = True Then
                PlayerCardArray(i).ImageLocation = "D:\CP2\VB.NET Project Files\CardGame\cardimages\" + PlayerHand(i).GetCardString + ".gif"
                PlayerCardArray(i).Visible = True
            ElseIf PlayerHand(i).ActiveBoolean = False Then
                PlayerCardArray(i).Visible = False
            End If
        Next
    End Sub
    Sub CalculateHandValue()
        Dim i As Short

        DealerValueShort = 0
        PlayerValueShort = 0

        For i = 0 To 4
            Select Case DealerHand(i).ValueInteger
                Case 10
                    DealerValueShort += 10
                Case 11
                    DealerValueShort += 10
                Case 12
                    DealerValueShort += 10
                Case 13
                    DealerValueShort += 10
                Case 1
                    If DealerValueShort + 11 <= 21 Then
                        DealerValueShort += 11
                    Else
                        DealerValueShort += 1
                    End If
                Case Else
                    DealerValueShort += DealerHand(i).ValueInteger
            End Select
        Next
        For i = 0 To 4
            Select Case PlayerHand(i).ValueInteger
                Case 10
                    PlayerValueShort += 10
                Case 11
                    PlayerValueShort += 10
                Case 12
                    PlayerValueShort += 10
                Case 13
                    PlayerValueShort += 10
                Case 1
                    If PlayerValueShort + 11 <= 21 Then
                        PlayerValueShort += 11
                    Else
                        PlayerValueShort += 1
                    End If
                Case Else
                    PlayerValueShort += PlayerHand(i).ValueInteger
            End Select
        Next

        PlayerHandTextBox.Text = Str(PlayerValueShort)

    End Sub
    Sub CheckGimmics()
        If PlayerValueShort = 21 Then
            Call Stand()
        End If
        If PlayerHand(4).ActiveBoolean = True And PlayerValueShort < 21 Then
            MsgBox("5 Card Charlie!")
            Call Win()
        End If
    End Sub
    Sub CheckBust()
        If PlayerValueShort > 21 Then
            Call Bust()
        End If
    End Sub
    Sub CheckWins()
        If DealerValueShort = 21 And PlayerValueShort <> 21 Then
            DealerHand(0).FaceDownBoolean = False
            Call DisplayHands()
            DealerHandTextBox.Text = Str(DealerValueShort)
            Call Lose()
        End If
    End Sub
    Sub Bust()
        DealerHand(0).FaceDownBoolean = False
        DealerHandTextBox.Text = Str(DealerValueShort)
        Call DisplayHands()
        MsgBox("Bust!")
        HitButton.Visible = False
        StandButton.Visible = False
        DoubleButton.Visible = False
        ResetButton.Visible = True
        ResetButton.Focus()
    End Sub
    Sub Push()
        DealerHand(0).FaceDownBoolean = False
        DealerHandTextBox.Text = Str(DealerValueShort)
        Call DisplayHands()
        MsgBox("Push.")
        HitButton.Visible = False
        StandButton.Visible = False
        DoubleButton.Visible = False
        ResetButton.Visible = True
        ResetButton.Focus()
    End Sub
    Sub Win()
        MsgBox("You Win!")
        HitButton.Visible = False
        StandButton.Visible = False
        DoubleButton.Visible = False
        ResetButton.Visible = True
        ResetButton.Focus()
        If PlayerValueShort = 21 Then
            CurrentPlayer.ScoreInteger += BetInteger / 2
        End If
        CurrentPlayer.ScoreInteger += BetInteger * 2
        ScoreTextBox.Text = Str(CurrentPlayer.ScoreInteger)
    End Sub
    Sub Lose()
        DealerHand(0).FaceDownBoolean = False
        DealerHandTextBox.Text = Str(DealerValueShort)
        Call DisplayHands()
        MsgBox("You lose.")
        HitButton.Visible = False
        StandButton.Visible = False
        DoubleButton.Visible = False
        ResetButton.Visible = True
        ResetButton.Focus()
    End Sub
    Sub Hit()
        PlayerHand(PlayerHandCountShort) = ShuffledDeckArray(CardCountShort)
        PlayerHand(PlayerHandCountShort).ActiveBoolean = True
        PlayerHandCountShort += 1
        CardCountShort += 1
        Call DisplayHands()
        Call CalculateHandValue()
        Call CheckGimmics()
        Call CheckBust()
        Call CheckWins()
    End Sub
    Sub Stand()
        DealerHand(0).ActiveBoolean = True
        DealerHand(0).FaceDownBoolean = False
        Do While DealerValueShort < 17 Or DealerValueShort < PlayerValueShort
            DealerHand(DealerHandCountShort) = ShuffledDeckArray(CardCountShort)
            DealerHand(DealerHandCountShort).ActiveBoolean = True
            DealerHandCountShort += 1
            CardCountShort += 1
            Call CalculateHandValue()
            Call DisplayHands()
            DealerHandTextBox.Text = Str(DealerValueShort)
            If DealerValueShort >= 17 Then
                Exit Do
            ElseIf DealerValueShort > PlayerValueShort Then
                Exit Do
            End If
            System.Threading.Thread.Sleep(1000)
        Loop
        If DealerValueShort > 21 Then
            Call Win()
        ElseIf DealerValueShort < PlayerValueShort Then
            Call Win()
        ElseIf DealerValueShort > PlayerValueShort Then
            Call Lose()
        ElseIf DealerValueShort = PlayerValueShort Then
            Call Push()
        End If
    End Sub
    Private Sub CardGameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PathString As String
        Dim LineString As String
        Dim LineCountShort As Short
        Dim PlayerCountShort As Short
        Call GenerateCards()
        Call SetObjectArray()

        PathString = "D:\CP2\VB.NET Project Files\CardGame\players.txt"
        LineCountShort = 0
        PlayerCountShort = 1

        FileOpen(1, PathString, OpenMode.Input)
        Do While Not EOF(1)
            LineString = LineInput(1)
            If LineString <> String.Empty Then
                LineCountShort += 1
                If LineCountShort = 1 Then
                    PlayersShort = Val(LineString)
                ElseIf IsNumeric(LineString) = False Then
                    PlayerArray(PlayerCountShort).InitialsString = LineString
                Else
                    PlayerArray(PlayerCountShort).ScoreInteger = Val(LineString)
                    PlayerCountShort += 1
                End If
            End If
        Loop
        FileClose(1)
    End Sub
    Private Sub HitButton_Click(sender As Object, e As EventArgs) Handles HitButton.Click
        Call Hit()
    End Sub
    Private Sub NewPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPlayerToolStripMenuItem.Click
        CurrentPlayer.InitialsString = InputBox("Enter player initials:", "New Player")
        CurrentPlayer.ScoreInteger = 100
        PlayersShort += 1
        CurrentPlayerIDShort = PlayersShort
        MsgBox("Remember your ID: " + Trim(Str(PlayersShort)))
        ScoreTextBox.Text = Str(CurrentPlayer.ScoreInteger)
        PlayButton.Visible = True
        PlayButton.Focus()
    End Sub
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Dim i As Short
        Dim DoneBoolean As Boolean
        BetInteger = 0
        DoneBoolean = False
        Do While DoneBoolean = False
            BetInteger = InputBox("How much of your score would you like to bet?", "Bet")
            If 1 > CurrentPlayer.ScoreInteger - BetInteger Then
                MsgBox("You can not have a negative bet.")
            Else
                CurrentPlayer.ScoreInteger -= BetInteger
                ScoreTextBox.Text = CurrentPlayer.ScoreInteger
                DoneBoolean = True
                Exit Do
            End If
        Loop

        Call ShuffleCards()
        CardCountShort = 0

        ResetButton.Visible = False

        For i = 0 To 1
            DealerHand(i) = ShuffledDeckArray(CardCountShort)
            DealerHand(i).ActiveBoolean = True
            CardCountShort += 1
        Next
        DealerHand(0).FaceDownBoolean = True
        For i = 0 To 1
            PlayerHand(i) = ShuffledDeckArray(CardCountShort)
            PlayerHand(i).ActiveBoolean = True
            CardCountShort += 1
        Next
        PlayerHandCountShort = 2
        DealerHandCountShort = 2

        Call DisplayHands()
        Call CalculateHandValue()
        Call CheckGimmics()
        Call CheckBust()
        Call CheckWins()

        HitButton.Visible = True
        StandButton.Visible = True
        DoubleButton.Visible = True
        PlayButton.Visible = False
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub StandButton_Click(sender As Object, e As EventArgs) Handles StandButton.Click
        Call Stand()
    End Sub
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Dim i As Short
        For i = 0 To 4
            DealerHand(i).ValueInteger = 0
            PlayerHand(i).ValueInteger = 0
            DealerHand(i).ActiveBoolean = False
            DealerHand(i).ActiveBoolean = False
        Next
        Call DisplayHands()
        PlayButton.Visible = True
        PlayerValueShort = 0
        DealerValueShort = 0
        PlayerHandTextBox.Text = String.Empty
        DealerHandTextBox.Text = String.Empty
    End Sub
    Private Sub DoubleButton_Click(sender As Object, e As EventArgs) Handles DoubleButton.Click
        BetInteger *= 2
        MsgBox(BetInteger)
        Call Hit()
        HitButton.Visible = False
        DoubleButton.Visible = False
    End Sub
    Private Sub OpenPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPlayerToolStripMenuItem.Click
        CurrentPlayerIDShort = Val(InputBox("Input ID of user:", "Open Player", "1"))
        CurrentPlayer = PlayerArray(CurrentPlayerIDShort)
        ScoreTextBox.Text = Str(CurrentPlayer.ScoreInteger)
        PlayButton.Visible = True
        PlayButton.Focus()
    End Sub
    Private Sub CardGameForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim PathString As String
        PlayerArray(CurrentPlayerIDShort) = CurrentPlayer
        PathString = "D:\CP2\VB.NET Project Files\CardGame\players.txt"
        System.IO.File.WriteAllText(PathString, String.Empty)

        FileOpen(1, PathString, OpenMode.Output)
        PrintLine(1, Trim(Str(PlayersShort)))
        For i = 1 To PlayersShort
            PrintLine(1, PlayerArray(i).InitialsString)
            PrintLine(1, Trim(Str(PlayerArray(i).ScoreInteger)))
        Next
        FileClose(1)
    End Sub
End Class