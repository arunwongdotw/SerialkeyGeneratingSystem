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
        Me.bntClose = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLoginUsername = New System.Windows.Forms.Button()
        Me.btnLoginPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(64, 370)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(133, 34)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "เข้าสู่ระบบ"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'bntClose
        '
        Me.bntClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.bntClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntClose.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntClose.ForeColor = System.Drawing.Color.White
        Me.bntClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bntClose.Location = New System.Drawing.Point(198, 370)
        Me.bntClose.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(133, 34)
        Me.bntClose.TabIndex = 4
        Me.bntClose.Text = "ปิดการใช้งาน"
        Me.bntClose.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(157, 256)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUsername.Size = New System.Drawing.Size(173, 22)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(157, 304)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPassword.Size = New System.Drawing.Size(173, 22)
        Me.txtPassword.TabIndex = 2
        '
        'btnLoginUsername
        '
        Me.btnLoginUsername.BackColor = System.Drawing.Color.White
        Me.btnLoginUsername.FlatAppearance.BorderSize = 0
        Me.btnLoginUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnLoginUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnLoginUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoginUsername.Location = New System.Drawing.Point(73, 253)
        Me.btnLoginUsername.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnLoginUsername.Name = "btnLoginUsername"
        Me.btnLoginUsername.Size = New System.Drawing.Size(79, 29)
        Me.btnLoginUsername.TabIndex = 5
        Me.btnLoginUsername.TabStop = False
        Me.btnLoginUsername.Text = "ชื่อผู้ใช้ :"
        Me.btnLoginUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoginUsername.UseVisualStyleBackColor = False
        '
        'btnLoginPassword
        '
        Me.btnLoginPassword.BackColor = System.Drawing.Color.White
        Me.btnLoginPassword.FlatAppearance.BorderSize = 0
        Me.btnLoginPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnLoginPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnLoginPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoginPassword.Location = New System.Drawing.Point(66, 299)
        Me.btnLoginPassword.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLoginPassword.Name = "btnLoginPassword"
        Me.btnLoginPassword.Size = New System.Drawing.Size(86, 25)
        Me.btnLoginPassword.TabIndex = 6
        Me.btnLoginPassword.TabStop = False
        Me.btnLoginPassword.Text = "รหัสผ่าน :"
        Me.btnLoginPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLoginPassword.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.bgLoginND
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(398, 500)
        Me.Controls.Add(Me.btnLoginPassword)
        Me.Controls.Add(Me.btnLoginUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.btnLogin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เข้าสู่ระบบ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents bntClose As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLoginUsername As System.Windows.Forms.Button
    Friend WithEvents btnLoginPassword As System.Windows.Forms.Button

End Class
