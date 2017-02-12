<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Decrypt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Decrypt))
        Me.lblSerialKey = New System.Windows.Forms.Label()
        Me.txtEncrypt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSerialKey = New System.Windows.Forms.TextBox()
        Me.txtINFO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSerialKey
        '
        Me.lblSerialKey.AutoSize = True
        Me.lblSerialKey.BackColor = System.Drawing.Color.PeachPuff
        Me.lblSerialKey.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialKey.Location = New System.Drawing.Point(46, 207)
        Me.lblSerialKey.Name = "lblSerialKey"
        Me.lblSerialKey.Size = New System.Drawing.Size(257, 34)
        Me.lblSerialKey.TabIndex = 96
        Me.lblSerialKey.Text = "ซีเรียลคีย์ที่ผ่านการถอดรหัส"
        '
        'txtEncrypt
        '
        Me.txtEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEncrypt.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.txtEncrypt.Location = New System.Drawing.Point(35, 72)
        Me.txtEncrypt.Multiline = True
        Me.txtEncrypt.Name = "txtEncrypt"
        Me.txtEncrypt.Size = New System.Drawing.Size(848, 115)
        Me.txtEncrypt.TabIndex = 97
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 34)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "ซีเรียลคีย์ที่ถูกเข้ารหัส"
        '
        'txtSerialKey
        '
        Me.txtSerialKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerialKey.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.txtSerialKey.Location = New System.Drawing.Point(35, 265)
        Me.txtSerialKey.Name = "txtSerialKey"
        Me.txtSerialKey.ReadOnly = True
        Me.txtSerialKey.Size = New System.Drawing.Size(848, 36)
        Me.txtSerialKey.TabIndex = 99
        '
        'txtINFO
        '
        Me.txtINFO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtINFO.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.txtINFO.Location = New System.Drawing.Point(35, 379)
        Me.txtINFO.Name = "txtINFO"
        Me.txtINFO.ReadOnly = True
        Me.txtINFO.Size = New System.Drawing.Size(848, 36)
        Me.txtINFO.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PeachPuff
        Me.Label2.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 34)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "ข้อมูลซีเรียลคีย์"
        '
        'Decrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 440)
        Me.Controls.Add(Me.txtINFO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSerialKey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEncrypt)
        Me.Controls.Add(Me.lblSerialKey)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Decrypt"
        Me.Text = "การถอดรหัสซีเรียลคีย์ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSerialKey As System.Windows.Forms.Label
    Friend WithEvents txtEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerialKey As System.Windows.Forms.TextBox
    Friend WithEvents txtINFO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
