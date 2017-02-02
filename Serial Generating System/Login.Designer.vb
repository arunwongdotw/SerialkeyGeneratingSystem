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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLoginUsername = New System.Windows.Forms.Button()
        Me.btnLoginPassword = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Teal
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(61, 295)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(167, 35)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "เข้าสู่ระบบ"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(239, 295)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 35)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ปิดการใช้งาน"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(149, 202)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(257, 33)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(149, 236)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(257, 33)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLoginUsername
        '
        Me.btnLoginUsername.BackColor = System.Drawing.Color.SeaShell
        Me.btnLoginUsername.FlatAppearance.BorderSize = 0
        Me.btnLoginUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginUsername.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoginUsername.Location = New System.Drawing.Point(61, 202)
        Me.btnLoginUsername.Name = "btnLoginUsername"
        Me.btnLoginUsername.Size = New System.Drawing.Size(93, 33)
        Me.btnLoginUsername.TabIndex = 5
        Me.btnLoginUsername.TabStop = False
        Me.btnLoginUsername.Text = "ชื่อผู้ใช้ :"
        Me.btnLoginUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoginUsername.UseVisualStyleBackColor = False
        '
        'btnLoginPassword
        '
        Me.btnLoginPassword.BackColor = System.Drawing.Color.SeaShell
        Me.btnLoginPassword.FlatAppearance.BorderSize = 0
        Me.btnLoginPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginPassword.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoginPassword.Location = New System.Drawing.Point(61, 236)
        Me.btnLoginPassword.Name = "btnLoginPassword"
        Me.btnLoginPassword.Size = New System.Drawing.Size(93, 33)
        Me.btnLoginPassword.TabIndex = 6
        Me.btnLoginPassword.TabStop = False
        Me.btnLoginPassword.Text = "รหัสผ่าน :"
        Me.btnLoginPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoginPassword.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.LogoSKGS
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(137, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 117)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.bgBlurColor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(468, 428)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLoginPassword)
        Me.Controls.Add(Me.btnLoginUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnLogin)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLoginUsername As System.Windows.Forms.Button
    Friend WithEvents btnLoginPassword As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
