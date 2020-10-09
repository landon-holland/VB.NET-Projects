Module modStructures
    Structure Book
        Dim shtID As Short
        Dim strTitle As String
        Dim strAuthor As String
        Dim blnIsSeries As Boolean
        Function GetBookString() As String
            Return Trim(Str(shtID)) + " - " + strTitle + ", by " + strAuthor
        End Function
        Function GetCoverPath() As String
            If blnIsSeries = True Then
                If strTitle = "Maus: A Survivor's Tale" Then
                    Return "D:\CP2\VB.NET Project Files\BookRecommendation\resources\covers\series\Maus Series.jpg"
                Else
                    Return "D:\CP2\VB.NET Project Files\BookRecommendation\resources\covers\series\" + strTitle + ".jpg"
                End If
            ElseIf blnIsSeries = False Then
                If strTitle = "Dinotopia: A Land Apart from Time" Then
                    Return "D:\CP2\VB.NET Project Files\BookRecommendation\resources\covers\Dinotopia.jpg"
                Else
                    Return "D:\CP2\VB.NET Project Files\BookRecommendation\resources\covers\" + strTitle + ".jpg"
                End If
            End If
        End Function
    End Structure
    Structure BookList
        Dim arrBooks() As Book
        Sub Create()
            ReDim arrBooks(54)

            Const strBooksPath As String = "D:\CP2\VB.NET Project Files\BookRecommendation\resources\books.txt"

            Dim i As Short
            Dim j As Short
            Dim strLine As String
            Dim shtTitleStart As Short
            Dim shtAuthorEnd As Short

            FileOpen(1, strBooksPath, OpenMode.Input)
            For i = 0 To 54
                With arrBooks(i)
                    strLine = LineInput(1)
                    .shtID = i
                    For j = 1 To Len(strLine)
                        If Mid(strLine, j, 1) = "," Then
                            shtTitleStart = j + 1
                            shtAuthorEnd = j - 1
                            Exit For
                        End If
                    Next j
                    .strTitle = Mid(strLine, shtTitleStart, Len(strLine) - j)
                    .strAuthor = Mid(strLine, 1, shtAuthorEnd)
                    If .strTitle = "Bourne Series" Or .strTitle = "Foundatin Series" Or .strTitle = "Harry Potter Series" Or .strTitle = "Maus: A Survivor's Tale" Or .strTitle = "Twilight Series" Then
                        .blnIsSeries = True
                    Else
                        .blnIsSeries = False
                    End If
                End With
            Next i
            FileClose(1)
        End Sub
    End Structure
    Structure Reader
        Dim shtID As Short
        Dim strName As String
        Dim arrRatings() As Short
        Sub Initialize()
            ReDim arrRatings(54)

            Dim i As Short

            For i = 0 To 54
                arrRatings(i) = 0
            Next
        End Sub
        Function GetReaderString() As String
            Return Trim(Str(shtID)) + " - " + strName
        End Function
    End Structure
    Structure ReaderList
        Dim arrReaders() As Reader
        Sub Create()
            ReDim arrReaders(85)

            Const strBooksPath As String = "D:\CP2\VB.NET Project Files\BookRecommendation\resources\ratings.txt"

            Dim i As Short
            Dim j As Short
            Dim shtReaderCount As Short
            Dim shtRatingCount As Short
            Dim strLine As String
            Dim strRating As String

            shtReaderCount = 0

            FileOpen(1, strBooksPath, OpenMode.Input)
            For i = 0 To 171
                strLine = Trim(LineInput(1))
                With arrReaders(shtReaderCount)
                    If Len(strLine) < 109 Then
                        .Initialize()
                        .shtID = shtReaderCount
                        .strName = Trim(strLine)
                    ElseIf Len(strLine) = 109 Then
                        shtRatingCount = 0
                        For j = 1 To Len(strLine)
                            strRating = Mid(strLine, j, 1)
                            If Not strRating = " " Then
                                If strRating = "R" Then
                                    .arrRatings(shtRatingCount) = 5
                                ElseIf strRating = "L" Then
                                    .arrRatings(shtRatingCount) = 3
                                ElseIf strRating = "O" Then
                                    .arrRatings(shtRatingCount) = 1
                                ElseIf strRating = "N" Then
                                    .arrRatings(shtRatingCount) = 0
                                ElseIf strRating = "D" Then
                                    .arrRatings(shtRatingCount) = -3
                                ElseIf strRating = "H" Then
                                    .arrRatings(shtRatingCount) = -5
                                End If
                                shtRatingCount += 1
                            End If
                        Next j
                        shtReaderCount += 1
                    End If
                End With
            Next i
            FileClose(1)
        End Sub
        Function MethodA(shtReaderID As Short)
            Dim bls As BookList
            Dim arrAverages(54) As Single
            Dim arrSimilarBooks(54) As Book
            Dim intAverage As Integer
            Dim shtRatingCount As Short
            Dim shtMaxID As Short
            Dim blnFirstTime As Boolean
            Dim i As Short
            Dim j As Short

            bls.Create()

            For i = 0 To 54
                intAverage = 0
                shtRatingCount = 0
                For j = 0 To 85
                    intAverage += arrReaders(j).arrRatings(i)
                    shtRatingCount += 1
                Next j
                arrAverages(i) = intAverage / shtRatingCount
            Next i

            blnFirstTime = True
            Do
                If blnFirstTime = False Then
                    arrAverages(shtMaxID) = -1000
                End If
                For i = 0 To 54
                    If arrAverages(i) >= arrAverages(shtMaxID) Then
                        shtMaxID = i
                    End If
                Next i
                blnFirstTime = False
            Loop Until arrReaders(shtReaderID).arrRatings(shtMaxID) = 0

            arrSimilarBooks(0) = bls.arrBooks(shtMaxID)
            Return arrSimilarBooks
        End Function
        Function MethodB(shtReaderID As Short)
            Dim i As Short
            Dim j As Short
            Dim intScore As Integer
            Dim intMaxScore As Integer
            Dim shtMostSimilarID As Short

            For i = 0 To 85
                If Not i = shtReaderID Then
                    intScore = 0
                    For j = 0 To 54
                        With arrReaders(i)
                            intScore += .arrRatings(j) * arrReaders(shtReaderID).arrRatings(j)
                        End With
                    Next j
                    If intScore > intMaxScore Then
                        intMaxScore = intScore
                        shtMostSimilarID = i
                    End If
                End If
            Next i

            Return shtMostSimilarID
        End Function
        Function MethodC(shtReaderID As Short)
            Dim arrSimilarity(85) As Integer
            Dim arrPrediction(54) As Integer
            Dim intScore As Integer
            Dim shtMostSimilarID As Short
            Dim intMaxPrediction As Integer
            Dim blnFirstTime As Boolean
            Dim i As Short
            Dim j As Short

            For i = 0 To 85
                If i = shtReaderID Then
                    intScore = -1
                Else
                    intScore = 0
                    For j = 0 To 54
                        With arrReaders(i)
                            intScore += .arrRatings(j) * arrReaders(shtReaderID).arrRatings(j)
                        End With
                    Next j
                End If
                arrSimilarity(i) = intScore
            Next i

            For i = 0 To 54
                arrPrediction(i) = 0
            Next

            For i = 0 To 54
                For j = 0 To 85
                    arrPrediction(i) += arrReaders(j).arrRatings(i) * arrSimilarity(j)
                Next j
            Next i

            blnFirstTime = True
            Do
                intMaxPrediction = -1
                If blnFirstTime = False Then
                    arrPrediction(shtMostSimilarID) = -1
                End If
                For i = 0 To 54
                    If arrPrediction(i) > intMaxPrediction Then
                        intMaxPrediction = arrPrediction(i)
                        shtMostSimilarID = i
                    End If
                Next
                blnFirstTime = False
            Loop Until arrReaders(shtReaderID).arrRatings(shtMostSimilarID) = 0
            Return shtMostSimilarID
        End Function
        Function FindSimilarBooks(shtReaderID As Short, shtTargetID As Short)
            Dim i As Short
            Dim bls As BookList
            Dim arrSimilarBooks(54) As Book
            Dim shtBookCount As Short

            bls.Create()
            shtBookCount = 0

            For i = 0 To 54
                If arrReaders(shtTargetID).arrRatings(i) = 5 And arrReaders(shtReaderID).arrRatings(i) = 0 Then
                    arrSimilarBooks(shtBookCount) = bls.arrBooks(i)
                    shtBookCount += 1
                End If
            Next i

            Return arrSimilarBooks
        End Function
    End Structure
End Module