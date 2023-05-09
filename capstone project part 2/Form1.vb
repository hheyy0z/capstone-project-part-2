Public Class Form1
    Dim startSpin As Integer
    Dim endSpin As Integer

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click

        endSpin = Int(Rnd() * 24 + 50)
        Timer1.Enabled = True


    End Sub

    Public Sub changeImage(num As Integer)
        If num = 1 Then
            PicWheel.Image = My.Resources.WOF1

        ElseIf num = 2 Then
            PicWheel.Image = My.Resources.WOF3

        ElseIf num = 3 Then
            PicWheel.Image = My.Resources.WOF4

        ElseIf num = 4 Then
            PicWheel.Image = My.Resources.WOF5

        ElseIf num = 5 Then
            PicWheel.Image = My.Resources.WOF6

        ElseIf num = 6 Then
            PicWheel.Image = My.Resources.WOF7

        ElseIf num = 7 Then
            PicWheel.Image = My.Resources.WOF8

        ElseIf num = 8 Then
            PicWheel.Image = My.Resources.wof9

        ElseIf num = 9 Then
            PicWheel.Image = My.Resources.wof10

        ElseIf num = 10 Then
            PicWheel.Image = My.Resources.wof11

        ElseIf num = 11 Then
            PicWheel.Image = My.Resources.wof12

        ElseIf num = 12 Then
            PicWheel.Image = My.Resources.wof13

        ElseIf num = 13 Then
            PicWheel.Image = My.Resources.wof14

        ElseIf num = 14 Then
            PicWheel.Image = My.Resources.wof15

        ElseIf num = 15 Then
            PicWheel.Image = My.Resources.wof16

        ElseIf num = 16 Then
            PicWheel.Image = My.Resources.wof17

        ElseIf num = 17 Then
            PicWheel.Image = My.Resources.wof18

        ElseIf num = 18 Then
            PicWheel.Image = My.Resources.wof19

        ElseIf num = 19 Then
            PicWheel.Image = My.Resources.WOF2

        ElseIf num = 20 Then
            PicWheel.Image = My.Resources.wof21

        ElseIf num = 21 Then
            PicWheel.Image = My.Resources.wof22

        ElseIf num = 22 Then
            PicWheel.Image = My.Resources.wof23

        ElseIf num = 23 Then
            PicWheel.Image = My.Resources.wof24

        ElseIf num = 24 Then
            PicWheel.Image = My.Resources.wof25

        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        changeImage(startSpin Mod 25)


        If startSpin = endSpin Then
            Timer1.Enabled = False
            finalImage(startSpin)
        End If

        startSpin = startSpin + 1

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
