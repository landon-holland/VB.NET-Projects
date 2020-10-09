Public Class frmAlgorithms
    Dim arr(99) As Integer
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim i As Integer

        lst.Items.Clear()
        Randomize()
        For i = 0 To 99
            arr(i) = Int(Rnd() * 100 + 1)
            lst.Items.Add(arr(i))
        Next i
    End Sub
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim arrs(99) As Integer
        Dim i As Integer
        Dim f As Integer
        Dim b As Integer
        Dim temp As Integer

        For i = 0 To 99
            arrs(i) = arr(i)
        Next

        For f = 0 To 98
            For b = f + 1 To 99
                If arrs(f) > arrs(b) Then
                    temp = arrs(f)
                    arrs(f) = arrs(b)
                    arrs(b) = temp
                End If
            Next b
        Next f

        lst2.Items.Clear()
        For i = 0 To 99
            lst2.Items.Add(arrs(i))
        Next
    End Sub
    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click
        Dim arrsh(99) As Integer
        Dim i As Integer
        Dim rnum As Integer
        Dim temp As Integer

        For i = 0 To 99
            arrsh(i) = arr(i)
        Next

        For i = 0 To 99
            rnum = Int(Rnd() * 99)
            temp = arrsh(i)
            arrsh(i) = arrsh(rnum)
            arrsh(rnum) = temp
        Next i

        lst2.Items.Clear()
        For i = 0 To 99
            lst2.Items.Add(arrsh(i))
        Next
    End Sub
    Private Sub btnUniqueness_Click(sender As Object, e As EventArgs) Handles btnUniqueness.Click
        Dim arru(99) As Integer
        Dim i As Integer
        Dim j As Integer
        Dim unc As Integer
        Dim flag As Boolean
        Dim arrs(99) As Integer
        Dim f As Integer
        Dim b As Integer
        Dim temp As Integer

        For i = 0 To 99
            arrs(i) = arr(i)
        Next

        For f = 0 To 98
            For b = f + 1 To 99
                If arrs(f) > arrs(b) Then
                    temp = arrs(f)
                    arrs(f) = arrs(b)
                    arrs(b) = temp
                End If
            Next b
        Next f

        unc = 1
        arru(1) = arrs(1)

        For i = 1 To 99
            flag = False
            For j = 0 To unc
                If arrs(i) = arru(j) Then
                    flag = True
                    Exit For
                End If
            Next j
            If flag = False Then
                unc += 1
                arru(unc) = arrs(i)
            End If
        Next i

        lst2.Items.Clear()
        For i = 0 To unc
            lst2.Items.Add(arru(i))
        Next i
    End Sub
End Class