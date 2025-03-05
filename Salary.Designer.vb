<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Salary))
        BtnSave = New Button()
        BtnUpdate = New Button()
        BtnCalculate = New Button()
        TxtEName = New TextBox()
        LblBsalary = New Label()
        LblDR = New Label()
        LblDOB = New Label()
        TxtBsalary = New TextBox()
        TxtPresentDates = New TextBox()
        TxtNIC = New TextBox()
        LblTA = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label5 = New Label()
        LblID = New Label()
        LblEID = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        PictureBox7 = New PictureBox()
        Label4 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        TxtReg = New Label()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        LblNIC = New Label()
        Panel1 = New Panel()
        Btndelete = New Button()
        Button1 = New Button()
        TxtSID = New TextBox()
        LblSID = New Label()
        CmbAId = New ComboBox()
        Label2 = New Label()
        CmbId = New ComboBox()
        TxtTAllowance = New TextBox()
        TxtTDeduction = New TextBox()
        LblTD = New Label()
        TxtDRate = New TextBox()
        LblNS = New Label()
        TxtNSalary = New TextBox()
        Label8 = New Label()
        TxtETF = New TextBox()
        LblEPF = New Label()
        TxtEPF = New TextBox()
        DataGridView1 = New DataGridView()
        Column11 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        LblPD = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.Navy
        BtnSave.Font = New Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSave.ForeColor = SystemColors.ButtonHighlight
        BtnSave.Location = New Point(66, 261)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(149, 43)
        BtnSave.TabIndex = 32
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.BackColor = Color.ForestGreen
        BtnUpdate.Font = New Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnUpdate.ForeColor = SystemColors.ButtonHighlight
        BtnUpdate.Location = New Point(308, 261)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(143, 43)
        BtnUpdate.TabIndex = 31
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnCalculate
        ' 
        BtnCalculate.BackColor = Color.DarkGoldenrod
        BtnCalculate.Font = New Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCalculate.ForeColor = Color.Transparent
        BtnCalculate.Location = New Point(1013, 261)
        BtnCalculate.Name = "BtnCalculate"
        BtnCalculate.Size = New Size(124, 43)
        BtnCalculate.TabIndex = 30
        BtnCalculate.Text = "Calculate"
        BtnCalculate.UseVisualStyleBackColor = False
        ' 
        ' TxtEName
        ' 
        TxtEName.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtEName.Location = New Point(30, 217)
        TxtEName.Name = "TxtEName"
        TxtEName.Size = New Size(216, 28)
        TxtEName.TabIndex = 25
        ' 
        ' LblBsalary
        ' 
        LblBsalary.AutoSize = True
        LblBsalary.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblBsalary.Location = New Point(274, 189)
        LblBsalary.Name = "LblBsalary"
        LblBsalary.Size = New Size(111, 22)
        LblBsalary.TabIndex = 23
        LblBsalary.Text = "Basic Salary"
        ' 
        ' LblDR
        ' 
        LblDR.AutoSize = True
        LblDR.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblDR.Location = New Point(561, 120)
        LblDR.Name = "LblDR"
        LblDR.Size = New Size(95, 22)
        LblDR.TabIndex = 22
        LblDR.Text = "Daily Rate"
        ' 
        ' LblDOB
        ' 
        LblDOB.AutoSize = True
        LblDOB.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblDOB.Location = New Point(75, 452)
        LblDOB.Name = "LblDOB"
        LblDOB.Size = New Size(110, 22)
        LblDOB.TabIndex = 21
        LblDOB.Text = "Date of birth"
        ' 
        ' TxtBsalary
        ' 
        TxtBsalary.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtBsalary.Location = New Point(274, 216)
        TxtBsalary.Name = "TxtBsalary"
        TxtBsalary.Size = New Size(257, 28)
        TxtBsalary.TabIndex = 20
        ' 
        ' TxtPresentDates
        ' 
        TxtPresentDates.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPresentDates.Location = New Point(413, 145)
        TxtPresentDates.Name = "TxtPresentDates"
        TxtPresentDates.Size = New Size(118, 28)
        TxtPresentDates.TabIndex = 16
        ' 
        ' TxtNIC
        ' 
        TxtNIC.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNIC.Location = New Point(75, 417)
        TxtNIC.Name = "TxtNIC"
        TxtNIC.Size = New Size(261, 28)
        TxtNIC.TabIndex = 15
        ' 
        ' LblTA
        ' 
        LblTA.AutoSize = True
        LblTA.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblTA.Location = New Point(561, 190)
        LblTA.Name = "LblTA"
        LblTA.Size = New Size(144, 23)
        LblTA.TabIndex = 13
        LblTA.Text = "Total Allowance"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(8, 156)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(59, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 49
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DodgerBlue
        Panel3.Controls.Add(PictureBox4)
        Panel3.Location = New Point(0, 422)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(77, 71)
        Panel3.TabIndex = 54
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(8, 5)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(59, 61)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 50
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 254)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(59, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(8, 338)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(59, 51)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 51
        PictureBox3.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(30, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 22)
        Label5.TabIndex = 8
        Label5.Text = "Employee Name"
        ' 
        ' LblID
        ' 
        LblID.AutoSize = True
        LblID.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblID.Location = New Point(274, 417)
        LblID.Name = "LblID"
        LblID.Size = New Size(114, 22)
        LblID.TabIndex = 7
        LblID.Text = "Employee ID"
        ' 
        ' LblEID
        ' 
        LblEID.AutoSize = True
        LblEID.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblEID.Location = New Point(30, 120)
        LblEID.Name = "LblEID"
        LblEID.Size = New Size(114, 22)
        LblEID.TabIndex = 7
        LblEID.Text = "Employee ID"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DodgerBlue
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(PictureBox7)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TxtReg)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1286, 59)
        Panel2.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.ForeColor = SystemColors.ButtonHighlight
        Panel4.Location = New Point(741, 52)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(98, 6)
        Panel4.TabIndex = 2
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(1224, 0)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(64, 59)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 6
        PictureBox7.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(739, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 42)
        Label4.TabIndex = 5
        Label4.Text = "Salary"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(80, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 42)
        Label1.TabIndex = 2
        Label1.Text = "Home"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(495, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 42)
        Label3.TabIndex = 4
        Label3.Text = "Attendence"
        ' 
        ' TxtReg
        ' 
        TxtReg.AutoSize = True
        TxtReg.Font = New Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        TxtReg.ForeColor = SystemColors.ButtonHighlight
        TxtReg.Location = New Point(248, 7)
        TxtReg.Name = "TxtReg"
        TxtReg.Size = New Size(203, 42)
        TxtReg.TabIndex = 3
        TxtReg.Text = "Registration"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(10, 7)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(59, 52)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 53
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(8, 626)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(59, 65)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 52
        PictureBox5.TabStop = False
        ' 
        ' LblNIC
        ' 
        LblNIC.AutoSize = True
        LblNIC.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblNIC.Location = New Point(75, 392)
        LblNIC.Name = "LblNIC"
        LblNIC.Size = New Size(43, 22)
        LblNIC.TabIndex = 11
        LblNIC.Text = "NIC"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Btndelete)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TxtSID)
        Panel1.Controls.Add(LblSID)
        Panel1.Controls.Add(CmbAId)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CmbId)
        Panel1.Controls.Add(TxtTAllowance)
        Panel1.Controls.Add(TxtTDeduction)
        Panel1.Controls.Add(LblTD)
        Panel1.Controls.Add(TxtDRate)
        Panel1.Controls.Add(LblNS)
        Panel1.Controls.Add(TxtNSalary)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(TxtETF)
        Panel1.Controls.Add(LblEPF)
        Panel1.Controls.Add(TxtEPF)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(BtnSave)
        Panel1.Controls.Add(BtnUpdate)
        Panel1.Controls.Add(BtnCalculate)
        Panel1.Controls.Add(TxtEName)
        Panel1.Controls.Add(LblBsalary)
        Panel1.Controls.Add(LblDR)
        Panel1.Controls.Add(LblDOB)
        Panel1.Controls.Add(TxtBsalary)
        Panel1.Controls.Add(TxtPresentDates)
        Panel1.Controls.Add(TxtNIC)
        Panel1.Controls.Add(LblTA)
        Panel1.Controls.Add(LblPD)
        Panel1.Controls.Add(LblNIC)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(LblID)
        Panel1.Controls.Add(LblEID)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(75, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1286, 691)
        Panel1.TabIndex = 48
        ' 
        ' Btndelete
        ' 
        Btndelete.BackColor = Color.Red
        Btndelete.Font = New Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btndelete.ForeColor = Color.White
        Btndelete.Location = New Point(555, 261)
        Btndelete.Name = "Btndelete"
        Btndelete.Size = New Size(124, 43)
        Btndelete.TabIndex = 54
        Btndelete.Text = "Delete"
        Btndelete.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.Font = New Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(782, 261)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 43)
        Button1.TabIndex = 53
        Button1.Text = "Reset"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TxtSID
        ' 
        TxtSID.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSID.Location = New Point(30, 87)
        TxtSID.Name = "TxtSID"
        TxtSID.Size = New Size(86, 28)
        TxtSID.TabIndex = 52
        ' 
        ' LblSID
        ' 
        LblSID.AutoSize = True
        LblSID.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblSID.Location = New Point(30, 62)
        LblSID.Name = "LblSID"
        LblSID.Size = New Size(86, 22)
        LblSID.TabIndex = 51
        LblSID.Text = "Salary ID"
        ' 
        ' CmbAId
        ' 
        CmbAId.FormattingEnabled = True
        CmbAId.Location = New Point(274, 145)
        CmbAId.Name = "CmbAId"
        CmbAId.Size = New Size(123, 28)
        CmbAId.TabIndex = 50
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(274, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 22)
        Label2.TabIndex = 49
        Label2.Text = "Attendance ID"
        ' 
        ' CmbId
        ' 
        CmbId.FormattingEnabled = True
        CmbId.Location = New Point(30, 145)
        CmbId.Name = "CmbId"
        CmbId.Size = New Size(216, 28)
        CmbId.TabIndex = 48
        ' 
        ' TxtTAllowance
        ' 
        TxtTAllowance.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtTAllowance.Location = New Point(561, 217)
        TxtTAllowance.Name = "TxtTAllowance"
        TxtTAllowance.Size = New Size(180, 28)
        TxtTAllowance.TabIndex = 47
        ' 
        ' TxtTDeduction
        ' 
        TxtTDeduction.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtTDeduction.Location = New Point(768, 217)
        TxtTDeduction.Name = "TxtTDeduction"
        TxtTDeduction.Size = New Size(234, 28)
        TxtTDeduction.TabIndex = 46
        ' 
        ' LblTD
        ' 
        LblTD.AutoSize = True
        LblTD.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblTD.Location = New Point(768, 190)
        LblTD.Name = "LblTD"
        LblTD.Size = New Size(143, 23)
        LblTD.TabIndex = 45
        LblTD.Text = "Total Deduction"
        ' 
        ' TxtDRate
        ' 
        TxtDRate.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDRate.Location = New Point(561, 145)
        TxtDRate.Name = "TxtDRate"
        TxtDRate.Size = New Size(180, 28)
        TxtDRate.TabIndex = 44
        ' 
        ' LblNS
        ' 
        LblNS.AutoSize = True
        LblNS.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblNS.Location = New Point(1013, 189)
        LblNS.Name = "LblNS"
        LblNS.Size = New Size(100, 23)
        LblNS.TabIndex = 43
        LblNS.Text = "Net Salary"
        ' 
        ' TxtNSalary
        ' 
        TxtNSalary.BackColor = SystemColors.Window
        TxtNSalary.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TxtNSalary.ForeColor = SystemColors.InfoText
        TxtNSalary.Location = New Point(1013, 217)
        TxtNSalary.Name = "TxtNSalary"
        TxtNSalary.Size = New Size(238, 34)
        TxtNSalary.TabIndex = 41
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(768, 120)
        Label8.Name = "Label8"
        Label8.Size = New Size(234, 22)
        Label8.TabIndex = 40
        Label8.Text = "ETF(3% from Basic Salary)"
        ' 
        ' TxtETF
        ' 
        TxtETF.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtETF.Location = New Point(768, 145)
        TxtETF.Name = "TxtETF"
        TxtETF.Size = New Size(234, 28)
        TxtETF.TabIndex = 38
        ' 
        ' LblEPF
        ' 
        LblEPF.AutoSize = True
        LblEPF.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblEPF.Location = New Point(1013, 120)
        LblEPF.Name = "LblEPF"
        LblEPF.Size = New Size(243, 22)
        LblEPF.TabIndex = 37
        LblEPF.Text = "EPF(12% from Basic Salary)"
        ' 
        ' TxtEPF
        ' 
        TxtEPF.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        TxtEPF.Location = New Point(1013, 145)
        TxtEPF.Name = "TxtEPF"
        TxtEPF.Size = New Size(238, 28)
        TxtEPF.TabIndex = 35
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ActiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column11, Column1, Column2, Column12, Column4, Column3, Column6, Column7, Column5, Column8, Column9, Column10})
        DataGridView1.Location = New Point(8, 318)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1277, 353)
        DataGridView1.TabIndex = 33
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column11.HeaderText = "SalaryID"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Employee ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Employee Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column12
        ' 
        Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column12.HeaderText = "AttendanceID"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Present Dates"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Daily Rate"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "EPF"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 61
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "ETF"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 61
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Basic Salary"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column8.HeaderText = "Total Allowance"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Total Deduction"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 132
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "Net Salary"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Width = 98
        ' 
        ' LblPD
        ' 
        LblPD.AutoSize = True
        LblPD.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblPD.Location = New Point(413, 120)
        LblPD.Name = "LblPD"
        LblPD.Size = New Size(118, 22)
        LblPD.TabIndex = 12
        LblPD.Text = "Present Dates"
        ' 
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(1361, 691)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel3)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Salary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Salary"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents TxtEName As TextBox
    Friend WithEvents LblBsalary As Label
    Friend WithEvents LblDR As Label
    Friend WithEvents LblDOB As Label
    Friend WithEvents TxtBsalary As TextBox
    Friend WithEvents TxtPresentDates As TextBox
    Friend WithEvents TxtNIC As TextBox
    Friend WithEvents LblTA As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LblID As Label
    Friend WithEvents LblEID As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtReg As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LblNIC As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblPD As Label
    Friend WithEvents LblNS As Label
    Friend WithEvents TxtNSalary As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtETF As TextBox
    Friend WithEvents LblEPF As Label
    Friend WithEvents TxtEPF As TextBox
    Friend WithEvents TxtTDeduction As TextBox
    Friend WithEvents LblTD As Label
    Friend WithEvents TxtDRate As TextBox
    Friend WithEvents TxtTAllowance As TextBox
    Friend WithEvents CmbId As ComboBox
    Friend WithEvents CmbAId As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSID As TextBox
    Friend WithEvents LblSID As Label
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Btndelete As Button
End Class
