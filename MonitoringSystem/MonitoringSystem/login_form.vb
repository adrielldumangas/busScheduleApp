Imports System.Data.OleDb

Public Class login_form
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public tableName As String = "Logins"
    Public driverTable As String = "DriverInfo"
    Public scheduleTable As String = "Schedules"
    Dim directoryPath As String = "C:\Test\"
    Dim dbFilename As String = "test.mdb"
    Public dbFullPath As String = directoryPath & dbFilename

    'Run all codes in here when this form loads
    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = login_btn

        'Check if the DIRECTORY PATH to be created DOESN'T EXIST
        'and if not, create it
        If Not IO.Directory.Exists(directoryPath) Then
            IO.Directory.CreateDirectory(directoryPath)
        End If

        'Check if the DATABASE FILE to be created DOESN'T EXIST
        'and if not, create it
        If Not IO.File.Exists(dbFullPath) Then
            CreateAccessDatabase(dbFullPath)
        End If

        If IO.File.Exists(dbFullPath) Then
            Try
                Dim con As New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source =" & dbFullPath)
                con.Open()
                'Get database schema
                Dim dbSchemaLogins As DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, tableName, "TABLE"})
                Dim dbSchemaDriver As DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, driverTable, "TABLE"})
                Dim dbSchemaSchedule As DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, scheduleTable, "TABLE"})
                con.Close()

                ' If the table exists, the count = 1
                'Create table for Login Credentials/Signing up
                If dbSchemaLogins.Rows.Count > 0 Then
                    ' do whatever you want to do if the table exists
                Else
                    'do whatever you want to do if the table does not exist
                    ' e.g. create a table
                    Dim cmd As New OleDbCommand("CREATE TABLE [" + tableName + "] " &
                                                      "([ID] COUNTER PRIMARY KEY, " &
                                                      "[LastName] TEXT(50), " &
                                                      "[FirstName] TEXT(50), " &
                                                      "[MiddleName] TEXT(50), " &
                                                      "[BirthDay] DATETIME, " &
                                                      "[Email] TEXT(50), " &
                                                      "[Username] TEXT(20), " &
                                                      "[Password] TEXT(30))", con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If

                'Create table for Driver's Info
                If dbSchemaDriver.Rows.Count > 0 Then
                    ' do whatever you want to do if the table exists
                Else
                    'do whatever you want to do if the table does not exist
                    ' e.g. create a table
                    Dim cmd As New OleDbCommand("CREATE TABLE [" + driverTable + "] " &
                                                      "([ID] COUNTER PRIMARY KEY, " &
                                                      "[LastName] TEXT(50), " &
                                                      "[FirstName] TEXT(50), " &
                                                      "[MiddleName] TEXT(50), " &
                                                      "[BirthDay] DATETIME, " &
                                                      "[Address] TEXT(255))", con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If

                'Create table for Schedules
                If dbSchemaSchedule.Rows.Count > 0 Then
                    ' do whatever you want to do if the table exists
                Else
                    'do whatever you want to do if the table does not exist
                    ' e.g. create a table
                    Dim cmd As New OleDbCommand("CREATE TABLE [" + scheduleTable + "] " &
                                                      "([ID] COUNTER PRIMARY KEY, " &
                                                      "[Departure] DATETIME, " &
                                                      "[VehicleID] TEXT(10), " &
                                                      "[PlateNumber] TEXT(20), " &
                                                      "[Route] TEXT(20), " &
                                                      "[CarType] TEXT(10))", con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ERROR")
            End Try
        End If

    End Sub

    'Function for creating an Access Database File
    Public Function CreateAccessDatabase(ByVal DatabaseFullPath As String) As Boolean
        Dim bAns As Boolean
        Dim cat As New ADOX.Catalog()
        Try
            Dim sCreateString As String
            sCreateString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseFullPath & ";Jet OLEDB:Engine Type=5"
            cat.Create(sCreateString)

            bAns = True

        Catch Excep As Runtime.InteropServices.COMException
            bAns = False

        Finally
            cat = Nothing
        End Try
        Return bAns
    End Function

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Application.ExitThread()
    End Sub

    Private Sub signUp_btn_Click(sender As Object, e As EventArgs) Handles signUp_btn.Click
        signUp_form.Show()
        Hide()
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Try
            provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
            'Change the following to your access database location
            dataFile = dbFullPath
            connString = provider & dataFile
            myConnection.ConnectionString = connString

            myConnection.Open()
            'the query:
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [" & tableName & "] WHERE [Username] = '" & username_txtbx.Text & "' AND [Password] = '" & password_txtbx.Text & "'", myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            ' the following variable will hold true if user is found, and false if user is not found 
            Dim userFound As Boolean = False
            ' the following variables will hold the user first and last name if found.
            Dim FirstName As String = ""
            'Dim LastName As String = ""

            'if found:
            While dr.Read
                userFound = True
                FirstName = dr("FirstName").ToString
                'LastName = dr("LastName").ToString
            End While

            'checking the result
            If userFound = True Then
                main_window.Show()
                main_window.fullname_label.Text = FirstName & "!"
                Close()
            Else
                cmd.Dispose()
                myConnection.Close()
                MsgBox("Username or password not found", MsgBoxStyle.Exclamation, "Invalid Login")
                username_txtbx.Clear()
                password_txtbx.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
