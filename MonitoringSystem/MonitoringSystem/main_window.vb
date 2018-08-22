Public Class main_window
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        login_form.Show()
        Close()
    End Sub

    Private Sub addDriver_btn_Click(sender As Object, e As EventArgs) Handles addDriver_btn.Click
        addDriver_form.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dateTime_lbl.Text = Now
    End Sub

    Private Sub display_btn_Click(sender As Object, e As EventArgs) Handles display_btn.Click
        display_window.Show()
    End Sub

    Private Sub newSched_btn_Click(sender As Object, e As EventArgs) Handles newSched_btn.Click
        schedule_form.Show()
    End Sub
End Class