Public Class frmInventory
    Dim arrCbx(12) As CheckBox
    Dim arrDatabase(50) As String
    Dim shtDatabaseCount As Short
    Sub SetControlArray()
        arrCbx(1) = cbxMonitor
        arrCbx(2) = cbxKeyboard
        arrCbx(3) = cbxMouse
        arrCbx(4) = cbxWaterCooling
        arrCbx(5) = cbxRGB
        arrCbx(6) = cbxCase
        arrCbx(7) = cbxWireless
        arrCbx(8) = cbx10Gb
        arrCbx(9) = cbxSound
        arrCbx(10) = cbxIEMs
        arrCbx(11) = cbxHeadphones
        arrCbx(12) = cbxSpeakers
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetControlArray()
        shtDatabaseCount = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        shtDatabaseCount += 1
        arrDatabase(shtDatabaseCount) = String.Empty

        If comCPUManufacturer.Text = "Intel" Then
            arrDatabase(shtDatabaseCount) += "I"
        ElseIf comCPUManufacturer.Text = "AMD" Then
            arrDatabase(shtDatabaseCount) += "A"
        End If

        If comCPUGeneration.Text = "Sandy Bridge" Then
            arrDatabase(shtDatabaseCount) += "S"
        ElseIf comCPUGeneration.Text = "Ivy Bridge" Then
            arrDatabase(shtDatabaseCount) += "I"
        ElseIf comCPUGeneration.Text = "Haswell" Then
            arrDatabase(shtDatabaseCount) += "H"
        ElseIf comCPUGeneration.Text = "Skylake" Then
            arrDatabase(shtDatabaseCount) += "S"
        ElseIf comCPUGeneration.Text = "Kaby Lake" Then
            arrDatabase(shtDatabaseCount) += "K"
        ElseIf comCPUGeneration.Text = "Jaguar" Then
            arrDatabase(shtDatabaseCount) += "J"
        ElseIf comCPUGeneration.Text = "Ryzen" Then
            arrDatabase(shtDatabaseCount) += "R"
        ElseIf comCPUGeneration.Text = "Threadripper" Then
            arrDatabase(shtDatabaseCount) += "T"
        End If

        If comCPUModel.Text = "i3-2125" Then
            arrDatabase(shtDatabaseCount) += "01"
        ElseIf comCPUModel.Text = "i5-2500K" Then
            arrDatabase(shtDatabaseCount) += "02"
        ElseIf comCPUModel.Text = "i7-2700K" Then
            arrDatabase(shtDatabaseCount) += "03"
        ElseIf comCPUModel.Text = "i3-3245" Then
            arrDatabase(shtDatabaseCount) += "04"
        ElseIf comCPUModel.Text = "i5-3570K" Then
            arrDatabase(shtDatabaseCount) += "05"
        ElseIf comCPUModel.Text = "i7-3770K" Then
            arrDatabase(shtDatabaseCount) += "06"
        ElseIf comCPUModel.Text = "i3-4360" Then
            arrDatabase(shtDatabaseCount) += "07"
        ElseIf comCPUModel.Text = "i5-4670K" Then
            arrDatabase(shtDatabaseCount) += "08"
        ElseIf comCPUModel.Text = "i5-4690K" Then
            arrDatabase(shtDatabaseCount) += "09"
        ElseIf comCPUModel.Text = "i7-4770K" Then
            arrDatabase(shtDatabaseCount) += "10"
        ElseIf comCPUModel.Text = "i7-4790K" Then
            arrDatabase(shtDatabaseCount) += "11"
        ElseIf comCPUModel.Text = "i3-6300" Then
            arrDatabase(shtDatabaseCount) += "12"
        ElseIf comCPUModel.Text = "i5-6600K" Then
            arrDatabase(shtDatabaseCount) += "13"
        ElseIf comCPUModel.Text = "i7-6700K" Then
            arrDatabase(shtDatabaseCount) += "14"
        ElseIf comCPUModel.Text = "i3-7350K" Then
            arrDatabase(shtDatabaseCount) += "15"
        ElseIf comCPUModel.Text = "i5-7600K" Then
            arrDatabase(shtDatabaseCount) += "16"
        ElseIf comCPUModel.Text = "i7-7700K" Then
            arrDatabase(shtDatabaseCount) += "17"
        ElseIf comCPUModel.Text = "Athlon 5150" Then
            arrDatabase(shtDatabaseCount) += "18"
        ElseIf comCPUModel.Text = "Athlon 5350" Then
            arrDatabase(shtDatabaseCount) += "19"
        ElseIf comCPUModel.Text = "Athlon 5370" Then
            arrDatabase(shtDatabaseCount) += "20"
        ElseIf comCPUModel.Text = "Ryzen 3" Then
            arrDatabase(shtDatabaseCount) += "21"
        ElseIf comCPUModel.Text = "Ryzen 5" Then
            arrDatabase(shtDatabaseCount) += "22"
        ElseIf comCPUModel.Text = "Ryzen 7" Then
            arrDatabase(shtDatabaseCount) += "23"
        ElseIf comCPUModel.Text = "1900X" Then
            arrDatabase(shtDatabaseCount) += "24"
        ElseIf comCPUModel.Text = "1920X" Then
            arrDatabase(shtDatabaseCount) += "25"
        ElseIf comCPUModel.Text = "1950X" Then
            arrDatabase(shtDatabaseCount) += "26"
        End If

        If comRAM.Text = "4 GB" Then
            arrDatabase(shtDatabaseCount) += "1"
        ElseIf comRAM.Text = "8 GB" Then
            arrDatabase(shtDatabaseCount) += "2"
        ElseIf comRAM.Text = "16 GB" Then
            arrDatabase(shtDatabaseCount) += "3"
        ElseIf comRAM.Text = "32 GB" Then
            arrDatabase(shtDatabaseCount) += "4"
        ElseIf comRAM.Text = "64 GB" Then
            arrDatabase(shtDatabaseCount) += "5"
        End If

        If rbnGigabyteMobo.Checked = True Then
            arrDatabase(shtDatabaseCount) += "G"
        ElseIf rbnASUSMobo.Checked = True Then
            arrDatabase(shtDatabaseCount) += "A"
        ElseIf rbnMSIMobo.Checked = True Then
            arrDatabase(shtDatabaseCount) += "M"
        End If

        If rbnGTXVC.Checked = True Then
            arrDatabase(shtDatabaseCount) += "G"
        ElseIf rbnRadeonVC.Checked = True Then
            arrDatabase(shtDatabaseCount) += "R"
        ElseIf rbnIntegratedVC.Checked = True Then
            arrDatabase(shtDatabaseCount) += "I"
        End If

        If rbnSSDST.Checked = True Then
            arrDatabase(shtDatabaseCount) += "S"
        ElseIf rbnNVMeST.Checked = True Then
            arrDatabase(shtDatabaseCount) += "N"
        ElseIf rbnHardDriveST.Checked = True Then
            arrDatabase(shtDatabaseCount) += "H"
        End If

        If rbn400PSU.Checked = True Then
            arrDatabase(shtDatabaseCount) += "4"
        ElseIf rbn600PSU.Checked = True Then
            arrDatabase(shtDatabaseCount) += "6"
        ElseIf rbn800PSU.Checked = True Then
            arrDatabase(shtDatabaseCount) += "8"
        End If

        Dim i As Short
        For i = 1 To 12
            If arrCbx(i).Checked = True Then
                arrDatabase(shtDatabaseCount) += "1"
            Else
                arrDatabase(shtDatabaseCount) += "0"
            End If
        Next i

        lbxDatabase.Items.Add(arrDatabase(shtDatabaseCount))
    End Sub

    Private Sub comCPUManufacturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comCPUManufacturer.SelectedIndexChanged
        comCPUGeneration.Items.Clear()
        If comCPUManufacturer.Text = "Intel" Then
            comCPUGeneration.Items.Add("Sandy Bridge")
            comCPUGeneration.Items.Add("Ivy Bridge")
            comCPUGeneration.Items.Add("Haswell")
            comCPUGeneration.Items.Add("Skylake")
            comCPUGeneration.Items.Add("Kaby Lake")
        ElseIf comCPUManufacturer.Text = "AMD" Then
            comCPUGeneration.Items.Add("Jaguar")
            comCPUGeneration.Items.Add("Ryzen")
            comCPUGeneration.Items.Add("Threadripper")
        End If
    End Sub

    Private Sub comCPUGeneration_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles comCPUGeneration.SelectedIndexChanged
        comCPUModel.Items.Clear()
        If comCPUGeneration.Text = "Sandy Bridge" Then
            comCPUModel.Items.Add("i3-2125") '01
            comCPUModel.Items.Add("i5-2500K") '02
            comCPUModel.Items.Add("i7-2700K") '03
        ElseIf comCPUGeneration.Text = "Ivy Bridge" Then
            comCPUModel.Items.Add("i3-3245") '04
            comCPUModel.Items.Add("i5-3570K") '05
            comCPUModel.Items.Add("i7-3770K") '06
        ElseIf comCPUGeneration.Text = "Haswell" Then
            comCPUModel.Items.Add("i3-4360") '07
            comCPUModel.Items.Add("i5-4670K") '08
            comCPUModel.Items.Add("i5-4690K") '09
            comCPUModel.Items.Add("i7-4770K") '10
            comCPUModel.Items.Add("i7-4790K") '11
        ElseIf comCPUGeneration.Text = "Skylake" Then
            comCPUModel.Items.Add("i3-6300") '12
            comCPUModel.Items.Add("i5-6600K") '13
            comCPUModel.Items.Add("i7-6700K") '14
        ElseIf comCPUGeneration.Text = "Kaby Lake" Then
            comCPUModel.Items.Add("i3-7350K") '15
            comCPUModel.Items.Add("i5-7600K") '16
            comCPUModel.Items.Add("i7-7700K") '17
        ElseIf comCPUGeneration.Text = "Jaguar" Then
            comCPUModel.Items.Add("Athlon 5150") '18
            comCPUModel.Items.Add("Athlon 5350") '19
            comCPUModel.Items.Add("Athlon 5370") '20
        ElseIf comCPUGeneration.Text = "Ryzen" Then
            comCPUModel.Items.Add("Ryzen 3") '21
            comCPUModel.Items.Add("Ryzen 5") '22
            comCPUModel.Items.Add("Ryzen 7") '23
        ElseIf comCPUGeneration.Text = "Threadripper" Then
            comCPUModel.Items.Add("1900X") '24
            comCPUModel.Items.Add("1920X") '25
            comCPUModel.Items.Add("1950X") '26
        End If
    End Sub

    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        Dim strPath As String
        Dim i As Integer

        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        SaveFileDialog1.ShowDialog()

        strPath = SaveFileDialog1.FileName

        FileOpen(1, strPath, OpenMode.Output)
        For i = 1 To shtDatabaseCount
            PrintLine(1, arrDatabase(i))
        Next i
        FileClose(1)
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim strPath As String
        Dim strGarbage As String
        Dim i As Integer

        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()

        strPath = OpenFileDialog1.FileName

        i = 1
        FileOpen(1, strPath, OpenMode.Input)
        Do While Not EOF(1)
            strGarbage = LineInput(1)
            If strGarbage <> "" Then
                arrDatabase(i) = strGarbage
                lbxDatabase.Items.Add(arrDatabase(i))
                i += 1
            End If
        Loop
        shtDatabaseCount = i
        FileClose(1)
    End Sub

    Private Sub lbxDatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxDatabase.SelectedIndexChanged
        Dim strDecode As String
        Dim i As Short
        strDecode = lbxDatabase.SelectedItem

        comCPUManufacturer.Text = String.Empty
        comCPUGeneration.Items.Clear()
        comCPUGeneration.Text = String.Empty
        comCPUModel.Items.Clear()
        comCPUModel.Text = String.Empty
        comRAM.Text = String.Empty
        rbnGigabyteMobo.Checked = False
        rbnASUSMobo.Checked = False
        rbnMSIMobo.Checked = False
        rbnGTXVC.Checked = False
        rbnRadeonVC.Checked = False
        rbnIntegratedVC.Checked = False
        rbnSSDST.Checked = False
        rbnNVMeST.Checked = False
        rbn400PSU.Checked = False
        rbn600PSU.Checked = False
        rbn800PSU.Checked = False
        For i = 1 To 12
            arrCbx(i).Checked = False
        Next i

        If Mid(strDecode, 1, 1) = "I" Then
            comCPUManufacturer.Text = "Intel"
            comCPUGeneration.Items.Add("Sandy Bridge")
            comCPUGeneration.Items.Add("Ivy Bridge")
            comCPUGeneration.Items.Add("Haswell")
            comCPUGeneration.Items.Add("Skylake")
            comCPUGeneration.Items.Add("Kaby Lake")
        ElseIf Mid(strDecode, 1, 1) = "A" Then
            comCPUManufacturer.Text = "AMD"
            comCPUGeneration.Items.Add("Jaguar")
            comCPUGeneration.Items.Add("Ryzen")
            comCPUGeneration.Items.Add("Threadripper")
        End If

        If Mid(strDecode, 2, 1) = "S" Then
            comCPUGeneration.Text = "Sandy Bridge"
            comCPUModel.Items.Add("i3-2125") '01
            comCPUModel.Items.Add("i5-2500K") '02
            comCPUModel.Items.Add("i7-2700K") '03
        ElseIf Mid(strDecode, 2, 1) = "I" Then
            comCPUGeneration.Text = "Ivy Bridge"
            comCPUModel.Items.Add("i3-3245") '04
            comCPUModel.Items.Add("i5-3570K") '05
            comCPUModel.Items.Add("i7-3770K") '06
        ElseIf Mid(strDecode, 2, 1) = "H" Then
            comCPUGeneration.Text = "Haswell"
            comCPUModel.Items.Add("i3-4360") '07
            comCPUModel.Items.Add("i5-4670K") '08
            comCPUModel.Items.Add("i5-4690K") '09
            comCPUModel.Items.Add("i7-4770K") '10
            comCPUModel.Items.Add("i7-4790K") '11
        ElseIf Mid(strDecode, 2, 1) = "S" Then
            comCPUGeneration.Text = "Skylake"
            comCPUModel.Items.Add("i3-6300") '12
            comCPUModel.Items.Add("i5-6600K") '13
            comCPUModel.Items.Add("i7-6700K") '14
        ElseIf Mid(strDecode, 2, 1) = "K" Then
            comCPUGeneration.Text = "Kaby Lake"
            comCPUModel.Items.Add("i3-7350K") '15
            comCPUModel.Items.Add("i5-7600K") '16
            comCPUModel.Items.Add("i7-7700K") '17
        ElseIf Mid(strDecode, 2, 1) = "J" Then
            comCPUGeneration.Text = "Jaguar"
            comCPUModel.Items.Add("Athlon 5150") '18
            comCPUModel.Items.Add("Athlon 5350") '19
            comCPUModel.Items.Add("Athlon 5370") '20
        ElseIf Mid(strDecode, 2, 1) = "R" Then
            comCPUGeneration.Text = "Ryzen"
            comCPUModel.Items.Add("Ryzen 3") '21
            comCPUModel.Items.Add("Ryzen 5") '22
            comCPUModel.Items.Add("Ryzen 7") '23
        ElseIf Mid(strDecode, 2, 1) = "T" Then
            comCPUGeneration.Text = "Threadripper"
            comCPUModel.Items.Add("1900X") '24
            comCPUModel.Items.Add("1920X") '25
            comCPUModel.Items.Add("1950X") '26
        End If

        If Mid(strDecode, 3, 2) = "01" Then
            comCPUModel.Text = "i3-2125"
        ElseIf Mid(strDecode, 3, 2) = "02" Then
            comCPUModel.Text = "i5-2500K"
        ElseIf Mid(strDecode, 3, 2) = "03" Then
            comCPUModel.Text = "i7-2700K"
        ElseIf Mid(strDecode, 3, 2) = "04" Then
            comCPUModel.Text = "i3-3245"
        ElseIf Mid(strDecode, 3, 2) = "05" Then
            comCPUModel.Text = "i5-3570K"
        ElseIf Mid(strDecode, 3, 2) = "06" Then
            comCPUModel.Text = "i7-3770K"
        ElseIf Mid(strDecode, 3, 2) = "07" Then
            comCPUModel.Text = "i3-4360"
        ElseIf Mid(strDecode, 3, 2) = "08" Then
            comCPUModel.Text = "i5-4670K"
        ElseIf Mid(strDecode, 3, 2) = "09" Then
            comCPUModel.Text = "i5-4690K"
        ElseIf Mid(strDecode, 3, 2) = "10" Then
            comCPUModel.Text = "i7-4770K"
        ElseIf Mid(strDecode, 3, 2) = "11" Then
            comCPUModel.Text = "i7-4790K"
        ElseIf Mid(strDecode, 3, 2) = "12" Then
            comCPUModel.Text = "i3-6300"
        ElseIf Mid(strDecode, 3, 2) = "13" Then
            comCPUModel.Text = "i5-6600K"
        ElseIf Mid(strDecode, 3, 2) = "14" Then
            comCPUModel.Text = "i7-6700K"
        ElseIf Mid(strDecode, 3, 2) = "15" Then
            comCPUModel.Text = "i3-7350K"
        ElseIf Mid(strDecode, 3, 2) = "16" Then
            comCPUModel.Text = "i5-7600K"
        ElseIf Mid(strDecode, 3, 2) = "17" Then
            comCPUModel.Text = "i7-7700K"
        ElseIf Mid(strDecode, 3, 2) = "18" Then
            comCPUModel.Text = "Athlon 5150"
        ElseIf Mid(strDecode, 3, 2) = "19" Then
            comCPUModel.Text = "Athlon 5350"
        ElseIf Mid(strDecode, 3, 2) = "20" Then
            comCPUModel.Text = "Athlon 5370"
        ElseIf Mid(strDecode, 3, 2) = "21" Then
            comCPUModel.Text = "Ryzen 3"
        ElseIf Mid(strDecode, 3, 2) = "22" Then
            comCPUModel.Text = "Ryzen 5"
        ElseIf Mid(strDecode, 3, 2) = "23" Then
            comCPUModel.Text = "Ryzen 7"
        ElseIf Mid(strDecode, 3, 2) = "24" Then
            comCPUModel.Text = "1900X"
        ElseIf Mid(strDecode, 3, 2) = "25" Then
            comCPUModel.Text = "1920X"
        ElseIf Mid(strDecode, 3, 2) = "26" Then
            comCPUModel.Text = "1950X"
        End If

        If Mid(strDecode, 5, 1) = "1" Then
            comRAM.Text = "4 GB"
        ElseIf Mid(strDecode, 5, 1) = "2" Then
            comRAM.Text = "8 GB"
        ElseIf Mid(strDecode, 5, 1) = "3" Then
            comRAM.Text = "16 GB"
        ElseIf Mid(strDecode, 5, 1) = "4" Then
            comRAM.Text = "32 GB"
        ElseIf Mid(strDecode, 5, 1) = "5" Then
            comRAM.Text = "64 GB"
        End If

        If Mid(strDecode, 6, 1) = "G" Then
            rbnGigabyteMobo.Checked = True
        ElseIf Mid(strDecode, 6, 1) = "A" Then
            rbnASUSMobo.Checked = True
        ElseIf Mid(strDecode, 6, 1) = "M" Then
            rbnMSIMobo.Checked = True
        End If

        If Mid(strDecode, 7, 1) = "G" Then
            rbnGTXVC.Checked = True
        ElseIf Mid(strDecode, 7, 1) = "R" Then
            rbnRadeonVC.Checked = True
        ElseIf Mid(strDecode, 7, 1) = "R" Then
            rbnIntegratedVC.Checked = True
        End If

        If Mid(strDecode, 8, 1) = "S" Then
            rbnSSDST.Checked = True
        ElseIf Mid(strDecode, 8, 1) = "N" Then
            rbnNVMeST.Checked = True
        ElseIf Mid(strDecode, 7, 1) = "H" Then
            rbnHardDriveST.Checked = True
        End If

        If Mid(strDecode, 9, 1) = "4" Then
            rbn400PSU.Checked = True
        ElseIf Mid(strDecode, 9, 1) = "6" Then
            rbn600PSU.Checked = True
        ElseIf Mid(strDecode, 9, 1) = "8" Then
            rbn800PSU.Checked = True
        End If

        For i = 1 To 12
            If Mid(strDecode, 9 + i, 1) = "1" Then
                arrCbx(i).Checked = True
            End If
        Next i
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Short
        For i = lbxDatabase.SelectedIndex To shtDatabaseCount
            arrDatabase(i) = arrDatabase(i + 1)
        Next i
        shtDatabaseCount -= 1
        comCPUManufacturer.Text = String.Empty
        comCPUGeneration.Items.Clear()
        comCPUGeneration.Text = String.Empty
        comCPUModel.Items.Clear()
        comCPUModel.Text = String.Empty
        comRAM.Text = String.Empty
        rbnGigabyteMobo.Checked = False
        rbnASUSMobo.Checked = False
        rbnMSIMobo.Checked = False
        rbnGTXVC.Checked = False
        rbnRadeonVC.Checked = False
        rbnIntegratedVC.Checked = False
        rbnSSDST.Checked = False
        rbnNVMeST.Checked = False
        rbn400PSU.Checked = False
        rbn600PSU.Checked = False
        rbn800PSU.Checked = False
        For i = 1 To 12
            arrCbx(i).Checked = False
        Next i
        lbxDatabase.Items.Clear()
        For i = 1 To shtDatabaseCount
            If arrDatabase(i) <> "" Then
                lbxDatabase.Items.Add(arrDatabase(i))
            End If
        Next i
    End Sub
End Class