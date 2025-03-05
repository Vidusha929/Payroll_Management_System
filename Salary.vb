Imports MySql.Data.MySqlClient


Public Class Salary
    Dim connectionString As String = "server=localhost; port=3306; username=root; password=; database=payroll_management_system"
    Dim conn As New MySqlConnection(connectionString)


    Dim dr As MySqlDataReader

    Dim ta As Integer
    Dim epf As Integer
    Dim etf As Integer
    Dim td As Integer


    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadID()
        LoadAttendanceID()
        DGV_load()
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
            Dim query As String = "SELECT Name, B_Salary FROM registration WHERE ID = @ID"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@ID", selectedEmpId)
            conn.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                TxtEName.Text = reader("name").ToString()
                TxtBsalary.Text = reader("B_Salary").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading employee details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadAttendanceID()
        Try
            Dim query As String = "SELECT Attendance_ID FROM attendance"
            Dim command As New MySqlCommand(query, conn)
            conn.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                CmbAId.Items.Add(reader("Attendance_ID").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading Attendance_ID: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CmbAId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAId.SelectedIndexChanged
        Try
            Dim selectedAttendnceID As String = CmbAId.SelectedItem.ToString()
            Dim query As String = "SELECT Present_dates FROM attendance WHERE Attendance_ID = @Attendance_ID"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@Attendance_ID", selectedAttendnceID)
            conn.Open()

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                TxtPresentDates.Text = reader("Present_dates").ToString()

            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading employee details: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        ta = (TxtPresentDates.Text * TxtDRate.Text)
        TxtTAllowance.Text = ta

        etf = (TxtBsalary.Text * 0.03)
        TxtETF.Text = etf
        epf = (TxtBsalary.Text * 0.12)
        TxtEPF.Text = epf
        TxtTDeduction.Text = etf + epf

        CalculateNetSalary()



    End Sub

    Private Sub CalculateNetSalary()


        Dim basicSalary As Double = Double.Parse(TxtBsalary.Text)
        Dim totalAllowance As Double = Double.Parse(TxtTAllowance.Text)
        Dim totalDeduction As Double = Double.Parse(TxtTDeduction.Text)


        Dim netSalary As Double = basicSalary + totalAllowance - totalDeduction


        TxtNSalary.Text = netSalary.ToString()

    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM salary", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("Salary_ID"), dr.Item("Employee_ID"), dr.Item("Employee_Name"), dr.Item("AttendanceId"), dr.Item("Present_Dates"), dr.Item("Daily_Rate"), dr.Item("EPF"), dr.Item("ETF"), dr.Item("Basic_Salary"), dr.Item("Total_Allowance"), dr.Item("Total_Deduction"), dr.Item("Net_Salary"))

            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrEmpty(TxtSID.Text) Or String.IsNullOrEmpty(CmbId.Text) Or String.IsNullOrEmpty(TxtEName.Text) Or String.IsNullOrEmpty(CmbAId.Text) Or String.IsNullOrEmpty(TxtPresentDates.Text) Or String.IsNullOrEmpty(TxtDRate.Text) Or String.IsNullOrEmpty(TxtEPF.Text) Or String.IsNullOrEmpty(TxtETF.Text) Or String.IsNullOrEmpty(TxtBsalary.Text) Or String.IsNullOrEmpty(TxtTAllowance.Text) Or String.IsNullOrEmpty(TxtTDeduction.Text) Or String.IsNullOrEmpty(TxtNSalary.Text) Then
            MessageBox.Show("Missing information")

        End If
        Save()

        DGV_load()
    End Sub

    Public Sub Save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `salary`(`Salary_ID`, `Employee_ID`, `Employee_Name`, `AttendanceId`, `Present_Dates`, `Daily_Rate`, `EPF`, `ETF`, `Basic_Salary`, `Total_Allowance`, `Total_Deduction`, `Net_Salary`) VALUES (@Salary_ID, @Employee_ID, @Employee_Name, @AttendanceId, @Present_Dates, @Daily_Rate, @EPF, @ETF, @Basic_Salary, @Total_Allowance, @Total_Deduction, @Net_Salary)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Salary_ID", TxtSID.Text)
            cmd.Parameters.AddWithValue("@Employee_ID", CmbId.Text)
            cmd.Parameters.AddWithValue("@Employee_Name", TxtEName.Text)
            cmd.Parameters.AddWithValue("@AttendanceId", CmbAId.Text)
            cmd.Parameters.AddWithValue("@Present_Dates", TxtPresentDates.Text)
            cmd.Parameters.AddWithValue("@Daily_Rate", TxtDRate.Text)
            cmd.Parameters.AddWithValue("@EPF", TxtEPF.Text)
            cmd.Parameters.AddWithValue("@ETF", TxtETF.Text)
            cmd.Parameters.AddWithValue("@Basic_Salary", TxtBsalary.Text)
            cmd.Parameters.AddWithValue("@Total_Allowance", TxtTAllowance.Text)
            cmd.Parameters.AddWithValue("@Total_Deduction", TxtTDeduction.Text)
            cmd.Parameters.AddWithValue("@Net_Salary", TxtNSalary.Text)

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Salary save succsesfull !", "Salary", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Salary save failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Clear()

    End Sub


    Public Sub Clear()
        TxtSID.Clear()
        CmbId.SelectedItem = ""
        TxtEName.Clear()
        CmbAId.SelectedItem = ""
        TxtPresentDates.Clear()
        TxtDRate.Clear()
        TxtEPF.Clear()
        TxtETF.Clear()
        TxtBsalary.Clear()
        TxtTAllowance.Clear()
        TxtTDeduction.Clear()
        TxtNSalary.Clear()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TxtSID.Text = DataGridView1.CurrentRow.Cells(0).Value
        CmbId.Text = DataGridView1.CurrentRow.Cells(1).Value
        TxtEName.Text = DataGridView1.CurrentRow.Cells(2).Value
        CmbAId.Text = DataGridView1.CurrentRow.Cells(3).Value
        TxtPresentDates.Text = DataGridView1.CurrentRow.Cells(4).Value
        TxtDRate.Text = DataGridView1.CurrentRow.Cells(5).Value
        TxtEPF.Text = DataGridView1.CurrentRow.Cells(6).Value
        TxtETF.Text = DataGridView1.CurrentRow.Cells(7).Value
        TxtBsalary.Text = DataGridView1.CurrentRow.Cells(8).Value
        TxtTAllowance.Text = DataGridView1.CurrentRow.Cells(9).Value
        TxtTDeduction.Text = DataGridView1.CurrentRow.Cells(10).Value
        TxtNSalary.Text = DataGridView1.CurrentRow.Cells(11).Value
    End Sub

    Overloads Sub Update()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `salary` SET `Employee_ID`=@Employee_ID,`Employee_Name`=@Employee_Name,`AttendanceId`=@AttendanceId,`Present_Dates`=@Present_Dates,`Daily_Rate`=@Daily_Rate,`EPF`=@EPF,`ETF`=@ETF,`Basic_Salary`=@Basic_Salary,`Total_Allowance`=@Total_Allowance,`Total_Deduction`=@Total_Deduction,`Net_Salary`=@Net_Salary WHERE `Salary_ID`=@Salary_ID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Salary_ID", TxtSID.Text)
            cmd.Parameters.AddWithValue("@Employee_ID", CmbId.Text)
            cmd.Parameters.AddWithValue("@Employee_Name", TxtEName.Text)
            cmd.Parameters.AddWithValue("@AttendanceId", CmbAId.Text)
            cmd.Parameters.AddWithValue("@Present_Dates", TxtPresentDates.Text)
            cmd.Parameters.AddWithValue("@Daily_Rate", TxtDRate.Text)
            cmd.Parameters.AddWithValue("@EPF", TxtEPF.Text)
            cmd.Parameters.AddWithValue("@ETF", TxtETF.Text)
            cmd.Parameters.AddWithValue("@Basic_Salary", TxtBsalary.Text)
            cmd.Parameters.AddWithValue("@Total_Allowance", TxtTAllowance.Text)
            cmd.Parameters.AddWithValue("@Total_Deduction", TxtTDeduction.Text)
            cmd.Parameters.AddWithValue("@Net_Salary", TxtNSalary.Text)

            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Salary Update Succesful !", "Salary", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Salary Update Faile !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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
                Dim cmd As New MySqlCommand("DELETE FROM `salary` WHERE `Salary_ID`=@Salary_ID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Salary_ID", TxtSID.Text)


                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Attendance Delete Succesful !", "Salary", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Update()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim obj = New Form1()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim obj = New Attendence()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub TxtReg_Click(sender As Object, e As EventArgs) Handles TxtReg.Click
        Dim obj = New Registration()
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

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Delete()
    End Sub
End Class

