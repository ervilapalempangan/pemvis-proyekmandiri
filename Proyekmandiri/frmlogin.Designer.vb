<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.lbljudul = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lbljudul2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.Coral
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(139, 244)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(76, 26)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'lbljudul
        '
        Me.lbljudul.AutoSize = True
        Me.lbljudul.BackColor = System.Drawing.Color.Transparent
        Me.lbljudul.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.ForeColor = System.Drawing.Color.Cyan
        Me.lbljudul.Location = New System.Drawing.Point(12, 9)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(486, 35)
        Me.lbljudul.TabIndex = 1
        Me.lbljudul.Text = "Selamat Datang Di Rumah Sakit"
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.Silver
        Me.txtuser.Location = New System.Drawing.Point(239, 146)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(113, 20)
        Me.txtuser.TabIndex = 2
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(125, 149)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(51, 17)
        Me.lbluser.TabIndex = 3
        Me.lbluser.Text = "Id User"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.Silver
        Me.txtpassword.Location = New System.Drawing.Point(239, 191)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(113, 20)
        Me.txtpassword.TabIndex = 4
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(125, 194)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(64, 17)
        Me.lblpassword.TabIndex = 5
        Me.lblpassword.Text = "Password"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Coral
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(262, 244)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(81, 26)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lbljudul2
        '
        Me.lbljudul2.AutoSize = True
        Me.lbljudul2.BackColor = System.Drawing.Color.Transparent
        Me.lbljudul2.Font = New System.Drawing.Font("Lucida Sans Unicode", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul2.ForeColor = System.Drawing.Color.Cyan
        Me.lbljudul2.Location = New System.Drawing.Point(127, 44)
        Me.lbljudul2.Name = "lbljudul2"
        Me.lbljudul2.Size = New System.Drawing.Size(241, 35)
        Me.lbljudul2.TabIndex = 7
        Me.lbljudul2.Text = "Sejahterah Kita"
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.Proyekmandiri.My.Resources.Resources._000c73f78d9c4aeca8f002c06c0ba2cb
        Me.ClientSize = New System.Drawing.Size(516, 295)
        Me.Controls.Add(Me.lbljudul2)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lbljudul)
        Me.Controls.Add(Me.btnlogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnlogin As Button
    Friend WithEvents lbljudul As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents lbluser As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents lbljudul2 As Label
End Class
