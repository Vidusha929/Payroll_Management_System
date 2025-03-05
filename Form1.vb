Public Class Form1
    Private Sub LblReg_Click(sender As Object, e As EventArgs) Handles LblReg.Click
        Dim obj = New Registration()
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub LblAttendence_Click(sender As Object, e As EventArgs) Handles LblAttendence.Click
        Dim obj = New Attendence()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim obj = New Salary()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub
End Class
