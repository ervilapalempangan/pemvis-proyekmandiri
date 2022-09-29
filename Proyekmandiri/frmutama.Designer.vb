<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmutama
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
        Me.lbljudulfrmutama = New System.Windows.Forms.Label()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnpasien = New System.Windows.Forms.Button()
        Me.btntambahuser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbljudulfrmutama
        '
        Me.lbljudulfrmutama.AutoSize = True
        Me.lbljudulfrmutama.BackColor = System.Drawing.Color.Transparent
        Me.lbljudulfrmutama.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudulfrmutama.Location = New System.Drawing.Point(45, 9)
        Me.lbljudulfrmutama.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbljudulfrmutama.Name = "lbljudulfrmutama"
        Me.lbljudulfrmutama.Size = New System.Drawing.Size(133, 45)
        Me.lbljudulfrmutama.TabIndex = 3
        Me.lbljudulfrmutama.Text = "MENU"
        '
        'btnkeluar
        '
        Me.btnkeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Image = Global.Proyekmandiri.My.Resources.Resources.exit_icon_icons_com_70975
        Me.btnkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkeluar.Location = New System.Drawing.Point(113, 272)
        Me.btnkeluar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(98, 49)
        Me.btnkeluar.TabIndex = 2
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnpasien
        '
        Me.btnpasien.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnpasien.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpasien.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnpasien.Image = Global.Proyekmandiri.My.Resources.Resources.Patient_Female_icon_icons_com_75052
        Me.btnpasien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpasien.Location = New System.Drawing.Point(45, 175)
        Me.btnpasien.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnpasien.Name = "btnpasien"
        Me.btnpasien.Size = New System.Drawing.Size(133, 49)
        Me.btnpasien.TabIndex = 1
        Me.btnpasien.Text = "Data Pasien"
        Me.btnpasien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnpasien.UseVisualStyleBackColor = True
        '
        'btntambahuser
        '
        Me.btntambahuser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btntambahuser.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambahuser.Image = Global.Proyekmandiri.My.Resources.Resources.user_person_customer_man_1532
        Me.btntambahuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambahuser.Location = New System.Drawing.Point(45, 100)
        Me.btntambahuser.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btntambahuser.Name = "btntambahuser"
        Me.btntambahuser.Size = New System.Drawing.Size(134, 49)
        Me.btntambahuser.TabIndex = 0
        Me.btntambahuser.Text = "Tambah User"
        Me.btntambahuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambahuser.UseVisualStyleBackColor = True
        '
        'frmutama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Proyekmandiri.My.Resources.Resources.cab4eb533b9b09da9c1424647c35dc78
        Me.ClientSize = New System.Drawing.Size(243, 346)
        Me.Controls.Add(Me.lbljudulfrmutama)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnpasien)
        Me.Controls.Add(Me.btntambahuser)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmutama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btntambahuser As Button
    Friend WithEvents btnpasien As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents lbljudulfrmutama As Label
End Class
