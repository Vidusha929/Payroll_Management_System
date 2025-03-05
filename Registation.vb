Imports MySql.Data.MySqlClient
Public Class Registration

    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=payroll_management_system")
    Dim i As Integer
    Dim dr As MySqlDataReader


    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()

    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM registration", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Name"), dr.Item("Address"), dr.Item("NIC"), dr.Item("DOB"), dr.Item("P_Number"), dr.Item("Gender"), dr.Item("Position"), dr.Item("B_Salary"))

            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub


    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Save()
        DGV_load()
    End Sub

    Public Sub Save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `registration`(`ID`, `Name`, `Address`, `NIC`, `DOB`, `P_Number`, `Gender`, `Position`, `B_Salary`) VALUES (@ID,@Name,@Address,@NIC,@DOB,@P_Number,@Gender,@Position,@B_Salary)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ID", TxtID.Text)
            cmd.Parameters.AddWithValue("@Name", TxtName.Text)
            cmd.Parameters.AddWithValue("@Address", TxtAddress.Text)
            cmd.Parameters.AddWithValue("@NIC", TxtNIC.Text)
            cmd.Parameters.AddWithValue("@DOB", TxtDOB.Text)
            cmd.Parameters.AddWithValue("@P_Number", TxtPno.Text)
            cmd.Parameters.AddWithValue("@Gender", CmbGender.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Position", CmbPosition.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@B_Salary", TxtBsalary.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Employee Save Sucssesful !", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Employee Save Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.StackTrace)
        Finally
            conn.Close()
        End Try
        Clear()

    End Sub

    Public Sub Clear()
        TxtID.Clear()
        TxtName.Clear()
        TxtAddress.Clear()
        TxtNIC.Clear()
        TxtDOB.Clear()
        TxtPno.Clear()
        CmbGender.SelectedItem = ""
        CmbPosition.SelectedItem = ""
        TxtBsalary.Clear()


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TxtID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TxtName.Text = DataGridView1.CurrentRow.Cells(1).Value
        TxtAddress.Text = DataGridView1.CurrentRow.Cells(2).Value
        TxtNIC.Text = DataGridView1.CurrentRow.Cells(3).Value
        TxtDOB.Text = DataGridView1.CurrentRow.Cells(4).Value
        TxtPno.Text = DataGridView1.CurrentRow.Cells(5).Value
        CmbGender.SelectedItem = DataGridView1.CurrentRow.Cells(6).Value
        CmbPosition.SelectedItem = DataGridView1.CurrentRow.Cells(7).Value
        TxtBsalary.Text = DataGridView1.CurrentRow.Cells(8).Value

    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `registration` SET `Name`=@Name,`Address`=@Address,`NIC`=@NIC,`DOB`=@DOB,`P_Number`=@P_Number,`Gender`=@Gender,`Position`=@Position,`B_Salary`=@B_Salary WHERE `ID`=@ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ID", TxtID.Text)
            cmd.Parameters.AddWithValue("@Name", TxtName.Text)
            cmd.Parameters.AddWithValue("@Address", TxtAddress.Text)
            cmd.Parameters.AddWithValue("@NIC", TxtNIC.Text)
            cmd.Parameters.AddWithValue("@DOB", TxtDOB.Text)
            cmd.Parameters.AddWithValue("@P_Number", TxtPno.Text)
            cmd.Parameters.AddWithValue("@Gender", CmbGender.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Position", CmbPosition.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@B_Salary", TxtBsalary.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Employee Update Succesful !", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Employee Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        DGV_load()

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Edit()
    End Sub

    Public Sub Delete()
        If MsgBox("Are You sure delete this record", MsgBoxStyle.Question + vbYesNo) Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `registration` WHERE `ID`=@ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ID", TxtID.Text)


                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Employee Delete Succesful !", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Employee Delete Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            Clear()
            DGV_load()
        Else
            Return
        End If



    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Delete()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()

    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim obj = New Form1()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim obj = New Attendence()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim obj = New Salary()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Clear()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub
End Class