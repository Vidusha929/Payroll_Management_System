Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Text = "Username"
        TxtUsername.ForeColor = Color.DarkGray

        TxtPassword.Text = "Password"
        TxtPassword.ForeColor = Color.DarkGray
    End Sub

    Private Sub TxtUsername_GotFocus(sender As Object, e As EventArgs) Handles TxtUsername.GotFocus
        If TxtUsername.Text = "Username" Then
            TxtUsername.Text = ""
            TxtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUsername_LostFocus(sender As Object, e As EventArgs) Handles TxtUsername.LostFocus
        If TxtUsername.Text = "" Then
            TxtUsername.Text = "Username"
            TxtUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TxtPassword_GotFocus(sender As Object, e As EventArgs) Handles TxtPassword.GotFocus
        If TxtPassword.Text = "Password" Then
            TxtPassword.Text = ""
            TxtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        If TxtPassword.Text = "" Then
            TxtPassword.Text = "Password"
            TxtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtUsername.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Please enter Username and Password")
        ElseIf TxtUsername.Text = "Admin" And TxtPassword.Text = "" Then
            MsgBox("Please enter Password")
        ElseIf TxtUsername.Text = "" And TxtPassword.Text = "Ad881" Then
            MsgBox("Please enter Username")
        ElseIf TxtUsername.Text = "Admin" And TxtPassword.Text = "Ad881" Then
            Dim obj = New Form1
            obj.Show()
        ElseIf TxtUsername.Text <> "Admin" And TxtPassword.Text = "Ad881" Then
            MessageBox.Show("Username is incorrect ! Check and try again", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsername.Text = ""
            TxtPassword.Text = ""
        ElseIf TxtUsername.Text <> "Admin" And TxtPassword.Text <> "Ad881" Then
            MessageBox.Show("Username & Password are incorrect ! Check and try again", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsername.Text = ""
            TxtPassword.Text = ""
        Else
            MessageBox.Show("Password is incorrect ! Check and try again", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtUsername.Text = ""
            TxtPassword.Text = ""



        End If



    End Sub


End Class