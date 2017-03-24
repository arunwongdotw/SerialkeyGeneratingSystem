<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testDLL
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
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtEncrypted = New System.Windows.Forms.TextBox()
        Me.txtDecrypted = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(485, 78)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnEncrypt.TabIndex = 0
        Me.btnEncrypt.Text = "encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(575, 178)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnDecrypt.TabIndex = 1
        Me.btnDecrypt.Text = "decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(155, 78)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(287, 20)
        Me.txtInput.TabIndex = 2
        '
        'txtEncrypted
        '
        Me.txtEncrypted.Location = New System.Drawing.Point(118, 138)
        Me.txtEncrypted.Multiline = True
        Me.txtEncrypted.Name = "txtEncrypted"
        Me.txtEncrypted.Size = New System.Drawing.Size(380, 97)
        Me.txtEncrypted.TabIndex = 3
        '
        'txtDecrypted
        '
        Me.txtDecrypted.Location = New System.Drawing.Point(155, 281)
        Me.txtDecrypted.Name = "txtDecrypted"
        Me.txtDecrypted.Size = New System.Drawing.Size(385, 20)
        Me.txtDecrypted.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "จำนวน"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(269, 333)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(12, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "x"
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Location = New System.Drawing.Point(269, 44)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(12, 13)
        Me.txt1.TabIndex = 8
        Me.txt1.Text = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "จำนวน"
        '
        'testDLL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 430)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDecrypted)
        Me.Controls.Add(Me.txtEncrypted)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Name = "testDLL"
        Me.Text = "testDLL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtEncrypted As System.Windows.Forms.TextBox
    Friend WithEvents txtDecrypted As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
