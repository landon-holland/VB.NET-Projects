Module modRocketWar2
    Structure Player
        Dim shtID As Short
        Dim strInitials As String
        Dim lngScore As Long
        Dim shtPlays As Short
        Function GetPlayerString() As String
            GetPlayerString = Trim(Str(shtID)) + " - " + strInitials + ": " + Trim(Str(lngScore)) + " points after " + Trim(Str(shtPlays)) + " attempts."
        End Function
    End Structure
    Structure PlayerList
        Dim arrPlayers() As Player
        Dim pyrCurrent As Player
        Dim shtPlayers As Short
        Dim blnGoodLogin As Boolean
        Const strPath As String = "F:\CP2\VB.NET Project Files\RocketWar2.0\resources\scores.txt"
        Sub Initialize()
            ReDim arrPlayers(99)
            Dim strLine As String
            Dim shtPlayerCount As Short
            Dim arrInput(3) As String
            Dim i As Short

            blnGoodLogin = False

            i = 0
            shtPlayerCount = 0
            FileOpen(1, strPath, OpenMode.Input)
            Do While Not EOF(1)
                strLine = LineInput(1)
                If i = 0 Then
                    shtPlayers = Val(strLine)
                Else
                    arrInput = strLine.Split(" ")
                    arrPlayers(shtPlayerCount).shtID = Val(arrInput(0))
                    arrPlayers(shtPlayerCount).strInitials = arrInput(1)
                    arrPlayers(shtPlayerCount).lngScore = Val(arrInput(2))
                    arrPlayers(shtPlayerCount).shtPlays = Val(arrInput(3))
                    shtPlayerCount += 1
                End If
                i += 1
            Loop
            FileClose(1)
        End Sub
        Sub Add(strInitials As String)
            shtPlayers += 1
            arrPlayers(shtPlayers).shtID = shtPlayers
            arrPlayers(shtPlayers).strInitials = strInitials
            arrPlayers(shtPlayers).lngScore = 0
            arrPlayers(shtPlayers).shtPlays = 0
            Login(shtPlayers)
        End Sub
        Sub Delete(shtPlayerID As Short)

        End Sub
        Sub Login(shtPlayerID As Short)
            If Not arrPlayers(shtPlayerID).strInitials = String.Empty Then
                pyrCurrent = arrPlayers(shtPlayerID)
                blnGoodLogin = True
            Else
                MsgBox("This ID does not correlate with a user.")
                blnGoodLogin = False
            End If
        End Sub
        Sub Save()
            Dim i As Short

            If blnGoodLogin = True Then
                arrPlayers(pyrCurrent.shtID) = pyrCurrent
            End If
            System.IO.File.WriteAllText(strPath, String.Empty)

            FileOpen(1, strPath, OpenMode.Output)
            PrintLine(1, Trim(Str(shtPlayers)))
            For i = 0 To shtPlayers
                With arrPlayers(i)
                    PrintLine(1, Trim(Str(.shtID)) + " " + .strInitials + " " + Trim(Str(.lngScore)) + " " + Trim(Str(.shtPlays)))
                End With
            Next i
            FileClose(1)
        End Sub
    End Structure
    Structure Top10
        Dim arrPlayers() As Player
        Sub Initialize()
            ReDim arrPlayers(9)
            Dim arrTempPlayers(99) As Player
            Dim i As Short
            Dim shtPlayers As Short
            Dim sngGap As Single
            Dim pyrTemp As Player
            Dim blnSwapped As Boolean
            Const sngShrink As Single = 1.3

            shtPlayers = pyrList.shtPlayers
            For i = 0 To shtPlayers
                arrTempPlayers(i) = pyrList.arrPlayers(i)
            Next i

            Do
                sngGap = Int(sngGap / sngShrink)
                If sngGap < 1 Then
                    sngGap = 1
                End If
                blnSwapped = False
                For i = 0 To shtPlayers - sngGap
                    If arrTempPlayers(i).lngScore < arrTempPlayers(i + sngGap).lngScore Then
                        pyrTemp = arrTempPlayers(i)
                        arrTempPlayers(i) = arrTempPlayers(i + sngGap)
                        arrTempPlayers(i + sngGap) = pyrTemp
                        blnSwapped = True
                    End If
                Next i
            Loop Until Not blnSwapped And sngGap = 1
            For i = 0 To 9
                arrPlayers(i) = arrTempPlayers(i)
            Next i
        End Sub
        Sub Test(pyrNew As Player)
            If pyrNew.lngScore >= arrPlayers(9).lngScore Then
                arrPlayers(9) = pyrNew
            End If
        End Sub
        Sub Sort()
            Dim i As Short
            Dim shtPlayers As Short
            Dim sngGap As Single
            Dim pyrTemp As Player
            Dim blnSwapped As Boolean
            Const sngShrink As Single = 1.3

            shtplayers = 9

            Do
                sngGap = Int(sngGap / sngShrink)
                If sngGap < 1 Then
                    sngGap = 1
                End If
                blnSwapped = False
                For i = 0 To shtPlayers - sngGap
                    If arrPlayers(i).lngScore < arrPlayers(i + sngGap).lngScore Then
                        pyrTemp = arrPlayers(i)
                        arrPlayers(i) = arrPlayers(i + sngGap)
                        arrPlayers(i + sngGap) = pyrTemp
                        blnSwapped = True
                    End If
                Next i
            Loop Until Not blnSwapped And sngGap = 1
        End Sub
    End Structure
    Public pyrList As PlayerList
    Public t10 As Top10
End Module