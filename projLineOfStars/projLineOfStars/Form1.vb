Public Class Form1

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdStars_Click(sender As Object, e As EventArgs) Handles cmdStars.Click
        Dim iCount As Integer
        txtStars.Text = ""
        For iCount = 1 To 20
            txtStars.Text = txtStars.Text & "*"
            Application.DoEvents()
        Next
    End Sub
End Class
