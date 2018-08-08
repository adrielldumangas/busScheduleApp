Public Class main_window
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        login_form.Show()
        Close()
    End Sub

    Private Sub addDriver_btn_Click(sender As Object, e As EventArgs) Handles addDriver_btn.Click
        If Not Application.OpenForms().OfType(Of addDriver_form).Any Then
            addDriver_form.Show()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dateTime_lbl.Text = Now
    End Sub
End Class