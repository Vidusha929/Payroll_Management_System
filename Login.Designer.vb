<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Panel1 = New Panel()
        TxtUsername = New TextBox()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        TxtPassword = New TextBox()
        PictureBox3 = New PictureBox()
        CheckBox1 = New CheckBox()
        BtnLogin = New Button()
        BtnCancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Modern No. 20", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(139, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(467, 31)
        Label2.TabIndex = 15
        Label2.Text = "Suhada Gas Distributors (pvt) Ltd."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Modern No. 20", 28.1999989F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.ImageKey = "(none)"
        Label1.Location = New Point(75, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(586, 48)
        Label1.TabIndex = 14
        Label1.Text = "Payroll Management System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(258, 141)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(247, 226)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(310, 398)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 46)
        Label3.TabIndex = 17
        Label3.Text = "Sign in"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TxtUsername)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(165, 466)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(418, 57)
        Panel1.TabIndex = 18
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Font = New Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(72, 12)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(332, 33)
        TxtUsername.TabIndex = 20
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(63, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 19
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(TxtPassword)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(165, 542)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(418, 53)
        Panel2.TabIndex = 21
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Font = New Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(72, 10)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(332, 33)
        TxtPassword.TabIndex = 20
        TxtPassword.UseSystemPasswordChar = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(63, 48)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 19
        PictureBox3.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.ForeColor = SystemColors.ButtonHighlight
        CheckBox1.Location = New Point(294, 618)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(147, 24)
        CheckBox1.TabIndex = 22
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = SystemColors.Highlight
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogin.Location = New Point(270, 670)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(211, 46)
        BtnLogin.TabIndex = 23
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = SystemColors.Highlight
        BtnCancel.Cursor = Cursors.Hand
        BtnCancel.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.Location = New Point(270, 735)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(211, 46)
        BtnCancel.TabIndex = 24
        BtnCancel.Text = "Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(751, 803)
        Controls.Add(BtnCancel)
        Controls.Add(BtnLogin)
        Controls.Add(CheckBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCancel As Button
End Class
