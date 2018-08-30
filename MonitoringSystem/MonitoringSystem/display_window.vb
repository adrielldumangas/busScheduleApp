﻿Public Class display_window
    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
    Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
    ' dayOfWeek.ToString() would return "Sunday" but it's an enum value,
    ' the correct dayname can be retrieved via DateTimeFormat.
    ' Following returns "Sonntag" for me since i'm in germany '
    Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)

    Private Sub display_window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time_lbl.Text = Now.ToString("hh:mm:ss tt")
        date_lbl.Text = Now.ToString("dd MMM yyyy")
        day_lbl.Text = dayName

    End Sub
End Class