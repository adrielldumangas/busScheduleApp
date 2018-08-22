Public Class schedule_form
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Close()
    End Sub

    Private Sub schedule_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.DriverInfo' table. You can move, or remove it, as needed.
        Me.DriverInfoTableAdapter.Fill(Me.TestDataSet.DriverInfo)
        'TODO: This line of code loads data into the 'TestDataSet.Fare' table. You can move, or remove it, as needed.
        Me.FareTableAdapter.Fill(Me.TestDataSet.Fare)
        'TODO: This line of code loads data into the 'TestDataSet.Route' table. You can move, or remove it, as needed.
        Me.RouteTableAdapter.Fill(Me.TestDataSet.Route)
        'TODO: This line of code loads data into the 'TestDataSet.VehicleType' table. You can move, or remove it, as needed.
        Me.VehicleTypeTableAdapter.Fill(Me.TestDataSet.VehicleType)

    End Sub

End Class