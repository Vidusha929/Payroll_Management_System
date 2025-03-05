Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities

Public Class Attendence
    Dim conn As New MySqlConnection("server=localhost; port=3306; username=root; password=; database=payroll_management_system")
    Dim dr As MySqlDataReader

    Private Sub Attendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
        LoadID()
    End Sub

    Private Sub LoadID()
        Try
            Dim query As String = "SELECT Id FROM registration"
            Dim command As New MySqlCommand(query, conn)
            conn.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                CmbId.Items.Add(reader("ID").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading ID: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CmbId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbId.SelectedIndexChanged
        Try
            Dim selectedEmpId As String = CmbId.SelectedItem.ToString()
            Dim query As String = "SELECT Name FROM registration WHERE ID = @ID"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@ID", selectedEmpId)
            conn.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                TxtEmpName.Text = reader("name").ToString()

            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading employee details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM attendance", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("Attendance_ID"), dr.Item("Emp_ID"), dr.Item("Emp_Name"), dr.Item("Present_dates"), dr.Item("Absent_dates"), dr.Item("Month"))

            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Save()
        DGV_load()
    End Sub

    Public Sub Save()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("INSERT INTO `attendance`(`Attendance_ID`, `Emp_ID`, `Emp_Name`, `Present_dates`, `Absent_dates`, `Month`) VALUES (@Attendance_ID,@Emp_ID,@Emp_Name,@Present_dates,@Absent_dates,@Month)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Attendance_ID", TxtAId.Text)
            cmd.Parameters.AddWithValue("Emp_ID", CmbId.Text)
            cmd.Parameters.AddWithValue("Emp_Name", TxtEmpName.Text)
            cmd.Parameters.AddWithValue("Present_dates", txtPresent.Text)
            cmd.Parameters.AddWithValue("Absent_dates", txtAbsent.Text)
            cmd.Parameters.AddWithValue("Month", cmbMonth.Text)

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Attendance Save Succesfull !", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Attendance Save Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.StackTrace)
        Finally
            conn.Close()

        End Try

    End Sub

    Public Sub Clear()
        TxtAId.Clear()
        CmbId.SelectedItem = ""
        TxtEmpName.Clear()
        txtPresent.Clear()
        txtAbsent.Clear()
        cmbMonth.SelectedItem = ""

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        TxtAId.Text = DataGridView1.CurrentRow.Cells(0).Value
        CmbId.SelectedItem = DataGridView1.CurrentRow.Cells(1).Value
        TxtEmpName.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtPresent.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtAbsent.Text = DataGridView1.CurrentRow.Cells(4).Value
        cmbMonth.SelectedItem = DataGridView1.CurrentRow.Cells(5).Value

    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `attendance` SET `Emp_ID`=@Emp_ID,`Emp_Name`=@Emp_Name,`Present_dates`=@Present_dates,`Absent_dates`=@Absent_dates,`Month`=@Month WHERE `Attendance_ID`=@Attendance_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Attendance_ID", TxtAId.Text)
            cmd.Parameters.AddWithValue("@Emp_ID", CmbId.Text)
            cmd.Parameters.AddWithValue("@Emp_Name", TxtEmpName.Text)
            cmd.Parameters.AddWithValue("@Present_dates", txtPresent.Text)
            cmd.Parameters.AddWithValue("@Absent_dates", txtAbsent.Text)
            cmd.Parameters.AddWithValue("@Month", cmbMonth.Text)


            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Attendance Update Succesful !", "Attendence", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Attendance Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        DGV_load()


    End Sub

    Public Sub Delete()
        If MsgBox("Are You sure delete this record", MsgBoxStyle.Question + vbYesNo) Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `attendance` WHERE `Attendance_ID`=@Attendance_ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Attendance_ID", TxtAId.Text)


                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Attendance Delete Succesful !", "Attendence", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Attendance Delete Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.StackTrace)
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim obj = New Form1()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub LoadDataGridViewData()
        Dim query As String = "SELECT * FROM attendance;"
        conn.Open()

        Using adapter As New MySqlDataAdapter(query, conn)
            Dim data As New DataTable()
            adapter.Fill(data)

            DataGridView1.DataSource = data
        End Using

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Edit()
    End Sub

    Private Sub TxtReg_Click(sender As Object, e As EventArgs) Handles TxtReg.Click
        Dim obj = New Registration()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim obj = New Salary()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim obj = New Login()
        obj.Show()
        Me.Hide()
    End Sub
End Class
