Public Class frmTrainees

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cboCOB2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCOB2.SelectedIndexChanged

    End Sub

    Private Sub cboCOB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCOB1.SelectedIndexChanged
        If cboCOB1.Text <> "Ireland" Then
            cboCOB2.Enabled = False
        Else
            cboCOB2.Enabled = True

        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub
End Class
