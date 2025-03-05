Imports MySql.Data.MySqlClient

Module DBconnection
    Private ReadOnly host = "localhost"
    Private ReadOnly user = "root"
    Private ReadOnly password = ""
    Private ReadOnly database = "payroll_management_system"
    Public connect As MySqlConnection
    Public command As New MySqlCommand

    Public Sub Connectbd()


        connect = New MySqlConnection
        Dim str As String = String.Format("host={0};user={1};password={2};database={3};", host, user, password, database)

        Try
            If connect.State = ConnectionState.Closed Then
                connect.ConnectionString = str
                connect.Open()
                MsgBox("Login succesfull")

            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

    End Sub

End Module
