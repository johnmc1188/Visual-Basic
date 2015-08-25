Public Class MetricConversion

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMiles.TextChanged

    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        If radDistance.Checked Then
            If IsNumeric(txtMiles.Text) Or IsNumeric(txtKilometres.Text) Then

                If (txtKilometres.Text = "") Then
                    txtKilometres.Text = txtMiles.Text / 0.625
                Else
                    txtMiles.Text = txtKilometres.Text * 0.625
                End If
            Else
                MessageBox.Show("Not Valid")
            End If
        Else


            If IsNumeric(txtCelsius.Text) Or IsNumeric(txtFahrenheit.Text) Then

                If (txtFahrenheit.Text = "") Then
                    txtFahrenheit.Text = (txtCelsius.Text * 1.8) + 32
                Else
                    txtCelsius.Text = (txtFahrenheit.Text - 32) / 1.8
                End If
            Else
                MessageBox.Show("Not Valid")

            End If
        End If





    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtCelsius.Clear()
        txtFahrenheit.Clear()
        txtMiles.Clear()
        txtKilometres.Clear()
    End Sub

    Private Sub radDistance_CheckedChanged(sender As Object, e As EventArgs) Handles radDistance.CheckedChanged
        cmdClear.PerformClick()
        If (radDistance.Checked = True) Then
            GroupBoxDistance.Enabled = True
        ElseIf (radDistance.Checked = False) Then
            GroupBoxDistance.Enabled = False


        End If
    End Sub

    Private Sub radTemp_CheckedChanged(sender As Object, e As EventArgs) Handles radTemp.CheckedChanged
        If (radTemp.Checked = True) Then
            GroupBoxTemp.Enabled = True
        ElseIf (radTemp.Checked = False) Then
            GroupBoxTemp.Enabled = False


        End If
    End Sub
End Class
