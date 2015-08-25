Public Class frmRandom
    Dim Counter As Integer = 0


    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdDie1_Click(sender As Object, e As EventArgs) Handles cmdDie1.Click
        Dim Die1 As New Random
        Dim dieResult As Integer = Die1.Next(1, 7)
        txtDie1.Text = dieResult.ToString

        cmdDie1.Enabled = False
        cmdDie2.Enabled = True
    End Sub

    Private Sub cmdDie2_Click(sender As Object, e As EventArgs) Handles cmdDie2.Click
        Dim Die2 As New Random
        Dim die2Result As Integer = Die2.Next(1, 7)
        txtDie2.Text = die2Result.ToString

        txtScore.Text = Integer.Parse(txtDie1.Text) + Integer.Parse(txtDie2.Text)
        Counter = Counter + 1
        txtNoOfAtempts.Text = Counter

        If txtScore.Text >= 9 Then
            MessageBox.Show("Well done it took you" + " " + txtNoOfAtempts.Text + " " + "times to reach 9 or greater")
        End If

        cmdDie1.Enabled = True
        cmdDie2.Enabled = False

    End Sub

    Private Sub txtScore_TextChanged(sender As Object, e As EventArgs) Handles txtScore.TextChanged

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        txtScore.Clear()
        txtNoOfAtempts.Clear()
        txtDie1.Clear()
        txtDie2.Clear()
        Counter = 0
    End Sub

    Private Sub frmRandom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdDie2.Enabled = False
    End Sub
End Class
