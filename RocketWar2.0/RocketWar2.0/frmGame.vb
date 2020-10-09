Public Class frmGame
    Structure Enemy
        Dim dblX As Double
        Dim dblY As Double
        Dim shtsX As Short
        Dim shtsY As Short
        Dim blnActive As Boolean
        Dim picSprite As PictureBox
    End Structure
    Structure EnemyTeam
        Dim arrEnemies() As Enemy
        Dim shtActiveEnemies As Short
        Const strPicturePath As String = "F:\CP2\VB.NET Project Files\RocketWar2.0\resources\Enemy.png"
        Sub Initialize()
            ReDim arrEnemies(399)
            Dim i As Short
            Randomize()

            shtActiveEnemies = 0
            For i = 0 To 399
                With arrEnemies(i)
                    .dblX = Int(Rnd() * 900 + 1)
                    .dblY = 0
                    If Int(Rnd() * 2 + 1) = 1 Then
                        .shtsX = 1
                    Else
                        .shtsX = -1
                    End If
                    .shtsY = 1
                    .blnActive = False

                    Dim picNewSprite As New PictureBox
                    With picNewSprite
                        .ImageLocation = strPicturePath
                        .Size = New Size(35, 35)
                        .SizeMode = PictureBoxSizeMode.Zoom
                    End With
                    picNewSprite.Left = .dblX
                    picNewSprite.Top = .dblY
                    picNewSprite.Visible = False
                    picNewSprite.BringToFront()
                    frmGame.Controls.Add(picNewSprite)
                    .picSprite = picNewSprite
                    .picSprite.BringToFront()
                End With

                frmGame.tmrSpawner.Enabled = True
                frmGame.tmrEnemy.Enabled = True
            Next
        End Sub
        Sub Spawn()
            Dim i As Short
            With arrEnemies(shtActiveEnemies)
                .blnActive = True
            End With
            shtActiveEnemies += 1
            If shtActiveEnemies = 30 Then
                frmGame.tmrSpawner.Interval = 750
            ElseIf shtActiveEnemies = 75 Then
                frmGame.tmrSpawner.Interval = 500
            ElseIf shtActiveEnemies = 150 Then
                frmGame.tmrSpawner.Interval = 300
            ElseIf shtActiveEnemies = 250 Then
                frmGame.tmrSpawner.Interval = 100
            End If
        End Sub
        Sub GetPwned(shtID As Short)
            With arrEnemies(shtID)
                If .blnActive = True Then
                    .blnActive = False
                    .picSprite.ImageLocation = "F:\CP2\VB.NET Project Files\RocketWar2.0\resources\Explosion.png"
                    pyrList.pyrCurrent.lngScore += 100
                End If
            End With
        End Sub
    End Structure
    Structure Bullet
        Dim dblX As Double
        Dim dblY As Double
        Dim shtsX As Short
        Dim shtsY As Short
        Dim blnActive As Boolean
    End Structure
    Structure Gun
        Dim arrBullets() As Bullet
        Dim shtShot As Short
        Sub Initialize()
            ReDim arrBullets(24)
            Dim i As Short

            shtShot = 0

            For i = 0 To 24
                With arrBullets(i)
                    .dblX = 0
                    .dblY = 0
                    .shtsX = 0
                    .shtsY = -1
                    .blnActive = False
                End With
            Next

            frmGame.tmrBullet.Enabled = True
        End Sub
        Sub Trigger()
            frmGame.tmrTrigger.Enabled = True
        End Sub
        Sub Shoot()
            If shtShot < 25 Then
                With arrBullets(shtShot)
                    .blnActive = True
                    .dblX = frmGame.dblPlayerX + frmGame.shtPlayerWidth
                    frmGame.arrSprites(shtShot).Left = .dblX
                    .dblY = frmGame.dblPlayerY
                End With
                shtShot += 1
            ElseIf shtShot = 25 Then
                frmGame.tmrReload.Enabled = True
            End If
            Call UpdateAmmo()
        End Sub
        Sub Release()
            frmGame.tmrTrigger.Enabled = False
        End Sub
        Sub Reload()
            Dim i As Short

            shtShot = 0

            For i = 0 To 24
                arrBullets(i).blnActive = False
            Next i
            Call UpdateAmmo()
        End Sub
        Sub UpdateAmmo()
            frmGame.lblAmmo.Text = Trim(Str(Math.Abs(shtShot - 25))) + "/25"
        End Sub
    End Structure
    Structure Player
        Dim dblX As Double
        Dim dblY As Double
        Dim shtsX As Short
        Dim shtsY As Short
        Dim blnUp As Boolean
        Dim blnDown As Boolean
        Dim blnLeft As Boolean
        Dim blnRight As Boolean
        Dim lngScore As Long
        Dim shtHealth As Short
        Sub Initialize()
            dblX = (frmGame.Width / 2) + 40
            dblY = frmGame.Height - 160
            shtsX = 0
            shtsY = 0
            lngScore = 0
            shtHealth = 100
            frmGame.tmrMovement.Enabled = True
            blnUp = False
            blnDown = False
            blnLeft = False
            blnRight = False
        End Sub
        Sub Move(shtDirection As Short)
            Select Case shtDirection
                Case 1
                    shtsY = -1
                    blnUp = True
                Case 2
                    shtsX = 1
                    blnLeft = True
                Case 3
                    shtsY = 1
                    blnDown = True
                Case 4
                    shtsX = -1
                    blnRight = True
            End Select
        End Sub
        Sub Release(shtDirection As Short)
            Select Case shtDirection
                Case 1
                    blnUp = False
                    If blnDown = False And blnUp = False Then
                        shtsY = 0
                    End If
                Case 2
                    blnLeft = False
                    If blnLeft = False And blnRight = False Then
                        shtsX = 0
                    End If
                Case 3
                    blnDown = False
                    If blnDown = False And blnUp = False Then
                        shtsY = 0
                    End If
                Case 4
                    blnRight = False
                    If blnLeft = False And blnRight = False Then
                        shtsX = 0
                    End If
            End Select
        End Sub
    End Structure
    Dim pyrGamer As Player
    Dim gunGamer As Gun
    Dim etm As EnemyTeam
    Dim arrSprites(24) As PictureBox
    Dim dblPlayerX As Double
    Dim dblPlayerY As Double
    Dim shtPlayerWidth As Short
    Dim intReloadCount As Integer
    Sub InitializeBullets()
        arrSprites(0) = picSprite0
        arrSprites(1) = picSprite1
        arrSprites(2) = picSprite2
        arrSprites(3) = picSprite3
        arrSprites(4) = picSprite4
        arrSprites(5) = picSprite5
        arrSprites(6) = picSprite6
        arrSprites(7) = picSprite7
        arrSprites(8) = picSprite8
        arrSprites(9) = picSprite9
        arrSprites(10) = picSprite10
        arrSprites(11) = picSprite11
        arrSprites(12) = picSprite12
        arrSprites(13) = picSprite13
        arrSprites(14) = picSprite14
        arrSprites(15) = picSprite15
        arrSprites(16) = picSprite16
        arrSprites(17) = picSprite17
        arrSprites(18) = picSprite18
        arrSprites(19) = picSprite19
        arrSprites(20) = picSprite20
        arrSprites(21) = picSprite21
        arrSprites(22) = picSprite22
        arrSprites(23) = picSprite23
        arrSprites(24) = picSprite24

        For i = 0 To 24
            With arrSprites(i)
                .Visible = False
                .Top = 0
                .Left = 0
            End With
        Next i
    End Sub
    Sub GameOver()
        Dim i As Short
        For i = 0 To 399
            With etm.arrEnemies(i)
                .blnActive = False
                .shtsX = 0
                .shtsY = 0
            End With
        Next
        For i = 0 To 24
            With gunGamer.arrBullets(i)
                .blnActive = False
                .shtsY = 0
            End With
        Next
        picShip.ImageLocation = "F:\CP2\VB.NET Project Files\RocketWar2.0\resources\Explosion.png"
        tmrMovement.Enabled = False
        tmrBullet.Enabled = False
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play("F:\CP2\VB.NET Project Files\RocketWar2.0\resources\question.wav", AudioPlayMode.WaitToComplete)
        MsgBox("You got an F! You now have " + Trim(Str(pyrList.pyrCurrent.lngScore)) + " points!", MsgBoxStyle.Critical)
        System.Threading.Thread.Sleep(2000)
        pyrList.pyrCurrent.shtPlays += 1
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrBullet.Interval = 1000 / 60
        tmrMovement.Interval = 1000 / 60
        tmrEnemy.Interval = 1000 / 60
        pyrGamer.Initialize()
        gunGamer.Initialize()
        etm.Initialize()
        Call InitializeBullets()
        shtPlayerWidth = Int(picShip.Width / 2)
        intReloadCount = 0
        My.Computer.Audio.Play("F:\CP2\VB.NET Project Files\RocketWar2.0\resources\music.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub frmGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim shtCode As Short
        shtCode = e.KeyValue
        Select Case shtCode
            Case 87
                pyrGamer.Move(1)
            Case 65
                pyrGamer.Move(4)
            Case 83
                pyrGamer.Move(3)
            Case 68
                pyrGamer.Move(2)
        End Select
    End Sub
    Private Sub frmGame_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Dim shtCode As Short
        shtCode = e.KeyValue
        Select Case shtCode
            Case 87
                pyrGamer.Release(1)
            Case 65
                pyrGamer.Release(4)
            Case 83
                pyrGamer.Release(3)
            Case 68
                pyrGamer.Release(2)
        End Select
    End Sub
    Private Sub tmrMovement_Tick(sender As Object, e As EventArgs) Handles tmrMovement.Tick
        With pyrGamer
            .dblX += .shtsX * 15
            .dblY += .shtsY * 15
            dblPlayerX = .dblX
            dblPlayerY = .dblY
        End With
        With picShip
            .Left = pyrGamer.dblX
            .Top = pyrGamer.dblY
        End With
    End Sub
    Private Sub frmGame_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        gunGamer.Trigger()
    End Sub
    Private Sub frmGame_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        gunGamer.Release()
    End Sub
    Private Sub tmrBullet_Tick(sender As Object, e As EventArgs) Handles tmrBullet.Tick
        Dim i As Short
        For i = 0 To 24
            With gunGamer.arrBullets(i)
                If .blnActive = True Then
                    .dblY += .shtsY * 20
                    arrSprites(i).Visible = True
                    arrSprites(i).Top = .dblY
                End If
            End With
        Next i
    End Sub
    Private Sub tmrTrigger_Tick(sender As Object, e As EventArgs) Handles tmrTrigger.Tick
        gunGamer.Shoot()
    End Sub
    Private Sub tmrReload_Tick(sender As Object, e As EventArgs) Handles tmrReload.Tick
        intReloadCount += 1
        If intReloadCount = 4 Then
            gunGamer.Reload()
            intReloadCount = 0
            tmrReload.Enabled = False
        End If
    End Sub
    Private Sub tmrSpawner_Tick(sender As Object, e As EventArgs) Handles tmrSpawner.Tick
        etm.Spawn()
    End Sub
    Private Sub tmrEnemy_Tick(sender As Object, e As EventArgs) Handles tmrEnemy.Tick
        Dim i As Short
        Dim j As Short
        For i = 0 To 399
            With etm.arrEnemies(i)
                If .blnActive = True Then
                    .dblX += .shtsX * 5
                    .dblY += .shtsY * 5
                    .picSprite.Visible = True
                    .picSprite.Top = .dblY
                    .picSprite.Left = .dblX
                End If

                If .dblX + .picSprite.Width > Me.Width Then
                    .shtsX = - .shtsX
                ElseIf .dblX < 0 Then
                    .shtsX = - .shtsX
                End If

                If .dblX + .picSprite.Width > pyrGamer.dblX + 35 And .dblX < pyrGamer.dblX + 60 And .dblY + .picSprite.Height > pyrGamer.dblY And .dblY < pyrGamer.dblY + 160 And .blnActive = True Then
                    Call GameOver()
                End If

                For j = 0 To 24
                    If gunGamer.arrBullets(j).dblX + 5 > .dblX And gunGamer.arrBullets(j).dblX < .dblX + 35 And gunGamer.arrBullets(j).dblY + 5 > .dblY And gunGamer.arrBullets(j).dblY < .dblY + 35 And gunGamer.arrBullets(j).blnActive = True Then
                        Call etm.GetPwned(i)
                    End If
                Next j
            End With
        Next i
    End Sub
End Class