Public Class frmListBox

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

    End Sub

    Private Sub frmListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCounties.SelectedIndex = 0
    End Sub
End Class
