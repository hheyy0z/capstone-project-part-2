
Imports System.IO
Public Class Form2


    Private targetWord As String
    Private displayWord As Char()

    Private Sub LoadTargetWordFromFile(filePath As String)
        If File.Exists(filePath) Then
            targetWord = File.ReadAllText(filePath).Trim().ToLower()
            displayWord = New String("_"c, targetWord.Length)
        Else
            MessageBox.Show("Target word file not found!")
        End If
    End Sub

    Private Sub LetterButton_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, F.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click
        If String.IsNullOrEmpty(targetWord) Then
            MessageBox.Show("Please load the target word first.")
            Return
        End If

        Dim clickedButton As Button = DirectCast(sender, Button)
        Dim guessedLetter As Char = clickedButton.Text(0)

        For i As Integer = 0 To targetWord.Length - 1
            If targetWord(i) = guessedLetter Then
                displayWord(i) = guessedLetter
            End If
        Next

        UpdateDisplay()
    End Sub


    Private Sub LoadTargetWordButton_Click As Object, e As EventArgs) Handles LoadTargetWordButton.Click
        Dim filePath As String = "WheelOfFortune.txt"
    End Sub


    Private Sub LoadTargetWordButton_Click(sender As Object, e As EventArgs) Handles LoadTargetWordButton.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = Application.StartupPath
        openFileDialog.Filter = "Text Files|*.txt"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            LoadTargetWordFromFile(filePath)
        End If
    End Sub
End Class

