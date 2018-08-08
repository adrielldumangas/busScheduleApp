Imports System.Data.OleDb

Public Class addDriver_form
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Close()
    End Sub

    Private Sub save_btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles save_btn.Click
        If String.IsNullOrWhiteSpace(lastname_txtbx.Text) Or
            String.IsNullOrWhiteSpace(firstname_txtbx.Text) Or
            String.IsNullOrWhiteSpace(middlename_txtbx.Text) Or
            String.IsNullOrWhiteSpace(address_txtbx.Text) Then

            MsgBox("Please fill up ALL the fields.", MsgBoxStyle.Exclamation, "ERROR")
        Else
            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
            'Change the following to your access database location
            dataFile = login_form.dbFullPath
            connString = provider & dataFile
            myConnection.ConnectionString = connString

            myConnection.Open()
            Dim str As String
            str = "insert into " & login_form.driverTable & " ([LastName], [FirstName], [MiddleName], " &
                                                            "[BirthDay], [Address]) values (?, ?, ?, ?, ?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            cmd.Parameters.Add(New OleDbParameter("LastName", lastname_txtbx.Text))
            cmd.Parameters.Add(New OleDbParameter("FirstName", firstname_txtbx.Text))
            cmd.Parameters.Add(New OleDbParameter("MiddleName", middlename_txtbx.Text))
            cmd.Parameters.Add(New OleDbParameter("BirthDay", bday_picker.Text))
            cmd.Parameters.Add(New OleDbParameter("Address", address_txtbx.Text))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()

                lastname_txtbx.Clear()
                firstname_txtbx.Clear()
                middlename_txtbx.Clear()
                address_txtbx.Clear()

                MsgBox("Driver's info has been saved!", MsgBoxStyle.Information, "Congratulations!")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub addDriver_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = save_btn
    End Sub
End Class