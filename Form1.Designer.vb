<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        PictureBox9 = New PictureBox()
        PictureBox8 = New PictureBox()
        Panel2 = New Panel()
        Panel4 = New Panel()
        PictureBox7 = New PictureBox()
        Label4 = New Label()
        LblHome = New Label()
        LblAttendence = New Label()
        LblReg = New Label()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DodgerBlue
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(-5, 166)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(85, 73)
        Panel3.TabIndex = 40
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(14, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(59, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 35
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 269)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(59, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Menu
        Panel1.Controls.Add(PictureBox9)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(78, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1283, 691)
        Panel1.TabIndex = 34
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(643, 88)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(615, 553)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 2
        PictureBox9.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(23, 88)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(614, 553)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 1
        PictureBox8.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DodgerBlue
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(PictureBox7)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(LblHome)
        Panel2.Controls.Add(LblAttendence)
        Panel2.Controls.Add(LblReg)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1283, 56)
        Panel2.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Location = New Point(75, 48)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(96, 6)
        Panel4.TabIndex = 2
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(1219, 0)
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
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(734, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 42)
        Label4.TabIndex = 5
        Label4.Text = "Salary"
        ' 
        ' LblHome
        ' 
        LblHome.AutoSize = True
        LblHome.Font = New Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblHome.ForeColor = SystemColors.ControlLightLight
        LblHome.Location = New Point(75, 4)
        LblHome.Name = "LblHome"
        LblHome.Size = New Size(104, 42)
        LblHome.TabIndex = 2
        LblHome.Text = "Home"
        ' 
        ' LblAttendence
        ' 
        LblAttendence.AutoSize = True
        LblAttendence.Font = New Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblAttendence.ForeColor = SystemColors.ButtonHighlight
        LblAttendence.Location = New Point(490, 4)
        LblAttendence.Name = "LblAttendence"
        LblAttendence.Size = New Size(184, 42)
        LblAttendence.TabIndex = 4
        LblAttendence.Text = "Attendence"
        ' 
        ' LblReg
        ' 
        LblReg.AutoSize = True
        LblReg.Font = New Font("Sitka Small", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblReg.ForeColor = SystemColors.ControlLightLight
        LblReg.Location = New Point(243, 4)
        LblReg.Name = "LblReg"
        LblReg.Size = New Size(189, 42)
        LblReg.TabIndex = 3
        LblReg.Text = "Registation"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(10, 4)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(59, 52)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 39
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(10, 613)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(59, 65)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 38
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(10, 434)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(59, 61)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 36
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(10, 352)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(59, 51)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 37
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1361, 691)
        Controls.Add(Panel3)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LblHome As Label
    Friend WithEvents LblAttendence As Label
    Friend WithEvents LblReg As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
End Class
