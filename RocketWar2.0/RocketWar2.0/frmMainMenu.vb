Imports System.ComponentModel
Public Class frmMainMenu
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If pyrList.blnGoodLogin = False Then
            MsgBox("You must log in first.")
        Else
            Me.Hide()
            frmGame.Show()
        End If
    End Sub
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pyrList.Initialize()
        pyrList.Save()
    End Sub
    Private Sub frmMainMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        pyrList.Save()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim shtID As Short
        shtID = InputBox("Please enter your player ID:", "Login", "0")
        pyrList.Login(shtID)
        If pyrList.blnGoodLogin = True Then
            MsgBox("Welcome, " + pyrList.pyrCurrent.strInitials + "!")
        End If
    End Sub
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim strInitials As String
        strInitials = InputBox("Please enter your initials:", "Add")
        pyrList.Add(strInitials)
        MsgBox(pyrList.pyrCurrent.strInitials + ", please remember your ID: " + Trim(Str(pyrList.pyrCurrent.shtID)))
    End Sub
    Private Sub btnPlayers_Click(sender As Object, e As EventArgs) Handles btnPlayers.Click
        Me.Hide()
        frmPlayers.Show()
    End Sub
    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        Me.Hide()
        frmHighScore.Show()
    End Sub
    Private Sub frmMainMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        pyrList.Save()
    End Sub
End Class