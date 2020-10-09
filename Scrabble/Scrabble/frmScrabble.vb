Imports System.ComponentModel
Public Class frmScrabble
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
        Dim shtTilesUsed As Short
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
            shtTilesUsed = 0
            strPath = "D:\CP2\VB.NET Project Files\Scrabble\resources\values.txt"
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
    Structure Hand
        Dim arrHand() As Tile
        Dim arrActive() As Boolean
        Dim arrPicture() As PictureBox
        Dim arrUsed() As Short
        Dim shtUsedCount As Short
        Dim shtHandCount As Short
        Sub Initialize()
            ReDim arrHand(6)
            ReDim arrActive(6)
            Dim i As Short

            For i = 0 To 6
                arrActive(i) = False
            Next
            shtHandCount = 0
        End Sub
        Sub BInitialize()
            ReDim arrPicture(6)
            arrPicture(0) = frmScrabble.picBoard1
            arrPicture(1) = frmScrabble.picBoard2
            arrPicture(2) = frmScrabble.picBoard3
            arrPicture(3) = frmScrabble.picBoard4
            arrPicture(4) = frmScrabble.picBoard5
            arrPicture(5) = frmScrabble.picBoard6
            arrPicture(6) = frmScrabble.picBoard7
        End Sub
        Sub HInitialize()
            ReDim arrPicture(6)
            ReDim arrUsed(6)
            Dim i As Short
            arrPicture(0) = frmScrabble.picHand1
            arrPicture(1) = frmScrabble.picHand2
            arrPicture(2) = frmScrabble.picHand3
            arrPicture(3) = frmScrabble.picHand4
            arrPicture(4) = frmScrabble.picHand5
            arrPicture(5) = frmScrabble.picHand6
            arrPicture(6) = frmScrabble.picHand7
            For i = 0 To 6
                arrUsed(i) = -1
            Next
        End Sub
        Sub Enable()
            Dim i As Short
            For i = 0 To 6
                arrPicture(i).Enabled = True
            Next
        End Sub
        Sub Disable()
            Dim i As Short
            For i = 0 To 6
                arrPicture(i).Enabled = False
            Next
        End Sub
        Sub Use(Index As Short)
            arrUsed(shtUsedCount) = Index
            shtUsedCount += 1
        End Sub
        Sub UnUse()
            arrUsed(shtUsedCount) = -1
            shtUsedCount -= 1
        End Sub
        Sub DisplayHand()
            Dim i As Short

            For i = 0 To 6
                If arrActive(i) = True Then
                    arrPicture(i).Visible = True
                    arrPicture(i).ImageLocation = "D:\CP2\VB.NET Project Files\Scrabble\resources\pics\" + arrHand(i).strLetter + ".png"
                Else
                    arrPicture(i).Visible = False
                End If
            Next
        End Sub
        Function GetScore() As Short
            Dim i As Short
            For i = 0 To shtHandCount
                If arrActive(i) = True Then
                    If i = 1 Then
                        GetScore += arrHand(i).shtValue * 2
                    ElseIf i = 4 Then
                        GetScore += arrHand(i).shtValue * 3
                    Else
                        GetScore += arrHand(i).shtValue
                    End If
                End If
            Next
        End Function
        Sub Check()
            Dim i As Short
            Dim lngLow As Long
            Dim lngHigh As Long
            Dim lngMD As Long
            Dim strWord As String
            Dim blnIsWord As Boolean
            For i = 0 To shtHandCount - 1
                strWord += arrHand(i).strLetter
            Next

            blnIsWord = False
            lngLow = 1
            lngHigh = 178690
            Do While lngLow <= lngHigh
                lngMD = (lngLow + lngHigh) / 2
                If strWord = frmScrabble.arrDictionary(lngMD) Then
                    blnIsWord = True
                    Exit Do
                ElseIf strWord < frmScrabble.arrDictionary(lngMD) Then
                    lngHigh = lngMD - 1
                ElseIf strWord > frmScrabble.arrDictionary(lngMD) Then
                    lngLow = lngMD + 1
                End If
            Loop

            If blnIsWord = True Then
                If Len(strWord) = 6 Then
                    frmScrabble.pyrCurrent.lngScore += GetScore() * 2
                ElseIf Len(strword) = 7 Then
                    frmScrabble.pyrCurrent.lngScore += GetScore() * 3
                Else
                    frmScrabble.pyrCurrent.lngScore += GetScore()
                End If
                frmScrabble.txtTotalScore.Text = Str(frmScrabble.pyrCurrent.lngScore)
                MsgBox(strWord + " is a word! You earned " + Trim(Str(GetScore)) + " points!")
            ElseIf blnIsWord = False Then
                MsgBox("Sorry, " + strWord + " is not a word.")
            End If
        End Sub
    End Structure
    Structure Player
        Dim shtID As Short
        Dim strInitials As String
        Dim lngScore As Long
    End Structure
    Dim bagTiles As Bag
    Dim arrDictionary(178690) As String
    Dim hndBoard As Hand
    Dim hndHand As Hand
    Dim arrPlayer(19) As Player
    Dim pyrCurrent As Player
    Dim shtPlayers As Short
    Dim blnFirstTime As Boolean
    Dim shtLastTile As Short
    Dim blnUnUseTwice As Boolean
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim i As Short

        btnCheck.Visible = True
        If blnFirstTime = True Then
            bagTiles.Create()
            bagTiles.Shuffle()
            hndBoard.Initialize()
            hndHand.Initialize()
            hndBoard.BInitialize()
            hndHand.HInitialize()
            hndHand.Enable()

            hndBoard.DisplayHand()
            hndHand.DisplayHand()

            For i = 0 To 6
                hndHand.arrHand(i) = bagTiles.arrTiles(bagTiles.shtTilesUsed)
                hndHand.arrActive(i) = True
                bagTiles.shtTilesUsed += 1
            Next
            hndHand.DisplayHand()
            blnFirstTime = False
        Else
            hndBoard.Initialize()
            hndBoard.BInitialize()
            hndHand.Enable()

            hndBoard.DisplayHand()
            hndHand.DisplayHand()

            For i = 0 To 6
                If hndHand.arrUsed(i) <> -1 Then
                    hndHand.arrHand(hndHand.arrUsed(i)) = bagTiles.arrTiles(bagTiles.shtTilesUsed)
                    bagTiles.shtTilesUsed += 1
                End If
            Next

            For i = 0 To 6
                hndHand.arrUsed(i) = -1
            Next
            hndHand.shtUsedCount = 0
            hndHand.DisplayHand()
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub picHand_Click(sender As Object, e As EventArgs) Handles picHand1.Click, picHand2.Click, picHand3.Click, picHand4.Click, picHand5.Click, picHand6.Click, picHand7.Click
        Dim shtSelectedTileCount As Short
        If hndBoard.shtHandCount < 7 Then
            shtSelectedTileCount = Val(Mid(sender.Name, 8, 1)) - 1
            shtLastTile = shtSelectedTileCount
            sender.Enabled = False
            sender.Visible = False
            If hndHand.arrHand(shtSelectedTileCount).strLetter = "_" Then
                hndHand.arrHand(shtSelectedTileCount).strLetter = UCase(InputBox("What letter do you want this blank to be?", "Blank"))
            End If
            hndBoard.arrHand(hndBoard.shtHandCount) = hndHand.arrHand(shtSelectedTileCount)
            hndBoard.arrActive(hndBoard.shtHandCount) = True
            hndBoard.DisplayHand()
            hndHand.Use(shtSelectedTileCount)
            txtWordScore.Text = Str(hndBoard.GetScore)
            hndBoard.shtHandCount += 1
            blnUnUseTwice = False
        Else
            MsgBox("Your word can only have seven letters.")
        End If
    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        hndBoard.Check()
        hndHand.Disable()
    End Sub
    Private Sub frmScrabble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Long
        Dim strLine As String
        Dim shtLineCount As Short
        Dim shtPlayerCount As Short

        FileOpen(1, "D:\CP2\VB.NET Project Files\Scrabble\resources\dictionary.txt", OpenMode.Input)
        For i = 0 To 178690
            arrDictionary(i) = LineInput(1)
        Next
        FileClose(1)

        shtLineCount = 0
        shtPlayerCount = 1
        FileOpen(1, "D:\CP2\VB.NET Project Files\Scrabble\resources\players.txt", OpenMode.Input)
        Do While Not EOF(1)
            strLine = LineInput(1)
            If strLine <> String.Empty Then
                shtLineCount += 1
                If shtLineCount = 1 Then
                    shtPlayers = Val(strLine)
                ElseIf IsNumeric(strLine) = False Then
                    arrPlayer(shtPlayerCount).strInitials = strLine
                Else
                    arrPlayer(shtPlayerCount).lngScore = Val(strLine)
                    arrPlayer(shtPlayerCount).shtID = shtPlayerCount
                    shtPlayerCount += 1
                End If
            End If
        Loop
        FileClose(1)

        blnFirstTime = True
        lblLoading.Visible = False
        btnPlay.Enabled = True
        btnCheck.Enabled = True
        btnExit.Enabled = True
    End Sub
    Private Sub picBoard_Click(sender As Object, e As EventArgs) Handles picBoard1.Click, picBoard2.Click, picBoard3.Click, picBoard4.Click, picBoard5.Click, picBoard6.Click, picBoard7.Click
        Dim shtSelectedTileCount As Short
        If hndBoard.shtHandCount > 0 And blnUnUseTwice = False Then
            shtSelectedTileCount = Val(Mid(sender.Name, 9, 1)) - 1
            sender.Visible = False
            hndHand.arrPicture(shtLastTile).Visible = True
            hndHand.arrPicture(shtLastTile).Enabled = True
            hndBoard.arrActive(shtSelectedTileCount) = False
            hndBoard.DisplayHand()
            hndHand.UnUse()
            hndBoard.shtHandCount -= 1
            txtWordScore.Text = Str(hndBoard.GetScore)
            blnUnUseTwice = True
        End If
    End Sub
    Private Sub NewPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPlayerToolStripMenuItem.Click
        pyrCurrent.strInitials = UCase(InputBox("Enter player initials:", "New Player"))
        pyrCurrent.lngScore = 0
        shtPlayers += 1
        pyrCurrent.shtID = shtPlayers
        MsgBox("Remember your ID: " + Trim(Str(pyrCurrent.shtID)))
        MsgBox("Welcome, " + pyrCurrent.strInitials + "!")
        btnPlay.Visible = True
        btnPlay.Focus()
    End Sub
    Private Sub frmScrabble_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim i As Short

        arrPlayer(pyrCurrent.shtID) = pyrCurrent
        System.IO.File.WriteAllText("D:\CP2\VB.NET Project Files\Scrabble\resources\players.txt", String.Empty)

        FileOpen(1, "D:\CP2\VB.NET Project Files\Scrabble\resources\players.txt", OpenMode.Output)
        PrintLine(1, Trim(Str(shtPlayers)))
        For i = 1 To shtPlayers
            PrintLine(1, arrPlayer(i).strInitials)
            PrintLine(1, Trim(Str(arrPlayer(i).lngScore)))
        Next
        FileClose(1)
    End Sub
    Private Sub OpenPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenPlayerToolStripMenuItem.Click
        pyrCurrent.shtID = Val(InputBox("Input ID of user:", "Open Player", "1"))
        pyrCurrent = arrPlayer(pyrCurrent.shtID)
        MsgBox("Welcome, " + pyrCurrent.strInitials + "!")
        txtTotalScore.Text = Trim(Str(pyrCurrent.lngScore))
        btnPlay.Visible = True
        btnPlay.Focus()
    End Sub
    Private Sub LeaderboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaderboardToolStripMenuItem.Click
        Dim i As Short
        For i = 1 To shtPlayers
            With frmLeaderboard
                .arrPlayers(i).shtID = arrPlayer(i).shtID
                .arrPlayers(i).strInitials = arrPlayer(i).strInitials
                .arrPlayers(i).lngScore = arrPlayer(i).lngScore
            End With
        Next
        frmLeaderboard.shtPlayers = shtPlayers
        frmLeaderboard.Show()
        Me.Hide()
    End Sub
End Class