Public Class changeColour

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        txtMyName.BackColor = Color.Blue
        txtMyName.ForeColor = Color.Red
    End Sub

    Private Sub cmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click
        txtMyName.BackColor = Color.Red
        txtMyName.ForeColor = Color.Blue
    End Sub
End Class
