<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmtambahuser
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
        Me.lbljudul = New System.Windows.Forms.Label()
        Me.lbluserid = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txttambahuser = New System.Windows.Forms.TextBox()
        Me.txttambahpassword = New System.Windows.Forms.TextBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbljudul
        '
        Me.lbljudul.AutoSize = True
        Me.lbljudul.BackColor = System.Drawing.Color.Transparent
        Me.lbljudul.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljudul.Location = New System.Drawing.Point(122, 31)
        Me.lbljudul.Name = "lbljudul"
        Me.lbljudul.Size = New System.Drawing.Size(170, 35)
        Me.lbljudul.TabIndex = 0
        Me.lbljudul.Text = "Tambah User"
        '
        'lbluserid
        '
        Me.lbluserid.AutoSize = True
        Me.lbluserid.BackColor = System.Drawing.Color.Transparent
        Me.lbluserid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluserid.Location = New System.Drawing.Point(27, 93)
        Me.lbluserid.Name = "lbluserid"
        Me.lbluserid.Size = New System.Drawing.Size(46, 15)
        Me.lbluserid.TabIndex = 3
        Me.lbluserid.Text = "User Id"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblpassword.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(27, 139)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(59, 15)
        Me.lblpassword.TabIndex = 4
        Me.lblpassword.Text = "Password"
        '
        'txttambahuser
        '
        Me.txttambahuser.Location = New System.Drawing.Point(128, 88)
        Me.txttambahuser.Name = "txttambahuser"
        Me.txttambahuser.Size = New System.Drawing.Size(100, 20)
        Me.txttambahuser.TabIndex = 10
        '
        'txttambahpassword
        '
        Me.txttambahpassword.Location = New System.Drawing.Point(128, 137)
        Me.txttambahpassword.Name = "txttambahpassword"
        Me.txttambahpassword.Size = New System.Drawing.Size(100, 20)
        Me.txttambahpassword.TabIndex = 11
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Beige
        Me.btnkeluar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnkeluar.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Image = Global.Proyekmandiri.My.Resources.Resources.exit_icon_icons_com_70975
        Me.btnkeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkeluar.Location = New System.Drawing.Point(314, 205)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(87, 47)
        Me.btnkeluar.TabIndex = 9
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'btncari
        '
        Me.btncari.BackColor = System.Drawing.Color.Beige
        Me.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncari.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.Image = Global.Proyekmandiri.My.Resources.Resources.xmag_search_find_export_locate_5984
        Me.btncari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari.Location = New System.Drawing.Point(277, 88)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(73, 46)
        Me.btncari.TabIndex = 8
        Me.btncari.Text = "Cari"
        Me.btncari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncari.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Beige
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnhapus.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Image = Global.Proyekmandiri.My.Resources.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus.Location = New System.Drawing.Point(221, 205)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(87, 47)
        Me.btnhapus.TabIndex = 7
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Beige
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnedit.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Image = Global.Proyekmandiri.My.Resources.Resources.DocumentEdit_40924
        Me.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnedit.Location = New System.Drawing.Point(128, 205)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(78, 46)
        Me.btnedit.TabIndex = 6
        Me.btnedit.Text = "Edit"
        Me.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.Beige
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsimpan.Font = New System.Drawing.Font("Javanese Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Image = Global.Proyekmandiri.My.Resources.Resources.Save_icon_icons_com_73702_1_
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.Location = New System.Drawing.Point(30, 205)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(86, 46)
        Me.btnsimpan.TabIndex = 1
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.Color.Black
        Me.btnkembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnkembali.ForeColor = System.Drawing.Color.White
        Me.btnkembali.Location = New System.Drawing.Point(-1, 0)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(87, 27)
        Me.btnkembali.TabIndex = 12
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'frmtambahuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyekmandiri.My.Resources.Resources.e813299eae5db09e8bbf7118d1b34099
        Me.ClientSize = New System.Drawing.Size(430, 297)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.txttambahpassword)
        Me.Controls.Add(Me.txttambahuser)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lbluserid)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.lbljudul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmtambahuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbljudul As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents lbluserid As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btncari As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents txttambahuser As TextBox
    Friend WithEvents txttambahpassword As TextBox
    Friend WithEvents btnkembali As Button
End Class
