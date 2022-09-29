<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpasien
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
        Me.lblkodetransaksi1 = New System.Windows.Forms.Label()
        Me.lblnamapasien2 = New System.Windows.Forms.Label()
        Me.lblbiaya3 = New System.Windows.Forms.Label()
        Me.lblobat4 = New System.Windows.Forms.Label()
        Me.lbltotal5 = New System.Windows.Forms.Label()
        Me.txtkodetransaksi1 = New System.Windows.Forms.TextBox()
        Me.txtnamapasien2 = New System.Windows.Forms.TextBox()
        Me.txtbiayapemeriksaan3 = New System.Windows.Forms.TextBox()
        Me.txtobat4 = New System.Windows.Forms.TextBox()
        Me.txttotalbiaya5 = New System.Windows.Forms.TextBox()
        Me.btnjumlahkan8 = New System.Windows.Forms.Button()
        Me.lbluangproses = New System.Windows.Forms.Label()
        Me.txtuangproses = New System.Windows.Forms.TextBox()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.lbltotalbiayapasien = New System.Windows.Forms.Label()
        Me.txttotalbiayapasien = New System.Windows.Forms.TextBox()
        Me.lblkembalian = New System.Windows.Forms.Label()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.btnselesai = New System.Windows.Forms.Button()
        Me.lbljuduldatapasien = New System.Windows.Forms.Label()
        Me.cmbdokter = New System.Windows.Forms.ComboBox()
        Me.lbldokter = New System.Windows.Forms.Label()
        Me.btncari7 = New System.Windows.Forms.Button()
        Me.btnexit6 = New System.Windows.Forms.Button()
        Me.btnproses5 = New System.Windows.Forms.Button()
        Me.btnhapus3 = New System.Windows.Forms.Button()
        Me.btnubah2 = New System.Windows.Forms.Button()
        Me.btnsimpan1 = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblkodetransaksi1
        '
        Me.lblkodetransaksi1.AutoSize = True
        Me.lblkodetransaksi1.BackColor = System.Drawing.Color.Transparent
        Me.lblkodetransaksi1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkodetransaksi1.Location = New System.Drawing.Point(36, 89)
        Me.lblkodetransaksi1.Name = "lblkodetransaksi1"
        Me.lblkodetransaksi1.Size = New System.Drawing.Size(91, 15)
        Me.lblkodetransaksi1.TabIndex = 0
        Me.lblkodetransaksi1.Text = "Kode Transaksi"
        '
        'lblnamapasien2
        '
        Me.lblnamapasien2.AutoSize = True
        Me.lblnamapasien2.BackColor = System.Drawing.Color.Transparent
        Me.lblnamapasien2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamapasien2.Location = New System.Drawing.Point(36, 120)
        Me.lblnamapasien2.Name = "lblnamapasien2"
        Me.lblnamapasien2.Size = New System.Drawing.Size(75, 15)
        Me.lblnamapasien2.TabIndex = 1
        Me.lblnamapasien2.Text = "Nama Pasien"
        '
        'lblbiaya3
        '
        Me.lblbiaya3.AutoSize = True
        Me.lblbiaya3.BackColor = System.Drawing.Color.Transparent
        Me.lblbiaya3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbiaya3.Location = New System.Drawing.Point(36, 182)
        Me.lblbiaya3.Name = "lblbiaya3"
        Me.lblbiaya3.Size = New System.Drawing.Size(106, 15)
        Me.lblbiaya3.TabIndex = 2
        Me.lblbiaya3.Text = "Biaya Pemeriksaan"
        '
        'lblobat4
        '
        Me.lblobat4.AutoSize = True
        Me.lblobat4.BackColor = System.Drawing.Color.Transparent
        Me.lblobat4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblobat4.Location = New System.Drawing.Point(36, 215)
        Me.lblobat4.Name = "lblobat4"
        Me.lblobat4.Size = New System.Drawing.Size(33, 15)
        Me.lblobat4.TabIndex = 3
        Me.lblobat4.Text = "Obat"
        '
        'lbltotal5
        '
        Me.lbltotal5.AutoSize = True
        Me.lbltotal5.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal5.Location = New System.Drawing.Point(36, 247)
        Me.lbltotal5.Name = "lbltotal5"
        Me.lbltotal5.Size = New System.Drawing.Size(67, 15)
        Me.lbltotal5.TabIndex = 4
        Me.lbltotal5.Text = "Total Biaya"
        '
        'txtkodetransaksi1
        '
        Me.txtkodetransaksi1.Location = New System.Drawing.Point(158, 86)
        Me.txtkodetransaksi1.Name = "txtkodetransaksi1"
        Me.txtkodetransaksi1.Size = New System.Drawing.Size(201, 20)
        Me.txtkodetransaksi1.TabIndex = 5
        '
        'txtnamapasien2
        '
        Me.txtnamapasien2.Location = New System.Drawing.Point(158, 115)
        Me.txtnamapasien2.Name = "txtnamapasien2"
        Me.txtnamapasien2.Size = New System.Drawing.Size(201, 20)
        Me.txtnamapasien2.TabIndex = 6
        '
        'txtbiayapemeriksaan3
        '
        Me.txtbiayapemeriksaan3.Location = New System.Drawing.Point(158, 177)
        Me.txtbiayapemeriksaan3.Name = "txtbiayapemeriksaan3"
        Me.txtbiayapemeriksaan3.Size = New System.Drawing.Size(201, 20)
        Me.txtbiayapemeriksaan3.TabIndex = 7
        '
        'txtobat4
        '
        Me.txtobat4.Location = New System.Drawing.Point(158, 210)
        Me.txtobat4.Name = "txtobat4"
        Me.txtobat4.Size = New System.Drawing.Size(201, 20)
        Me.txtobat4.TabIndex = 8
        '
        'txttotalbiaya5
        '
        Me.txttotalbiaya5.Location = New System.Drawing.Point(158, 243)
        Me.txttotalbiaya5.Name = "txttotalbiaya5"
        Me.txttotalbiaya5.Size = New System.Drawing.Size(201, 20)
        Me.txttotalbiaya5.TabIndex = 9
        '
        'btnjumlahkan8
        '
        Me.btnjumlahkan8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnjumlahkan8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnjumlahkan8.Location = New System.Drawing.Point(374, 239)
        Me.btnjumlahkan8.Name = "btnjumlahkan8"
        Me.btnjumlahkan8.Size = New System.Drawing.Size(75, 23)
        Me.btnjumlahkan8.TabIndex = 17
        Me.btnjumlahkan8.Text = "Totalkan"
        Me.btnjumlahkan8.UseVisualStyleBackColor = False
        '
        'lbluangproses
        '
        Me.lbluangproses.AutoSize = True
        Me.lbluangproses.BackColor = System.Drawing.Color.Transparent
        Me.lbluangproses.Location = New System.Drawing.Point(128, 392)
        Me.lbluangproses.Name = "lbluangproses"
        Me.lbluangproses.Size = New System.Drawing.Size(33, 13)
        Me.lbluangproses.TabIndex = 18
        Me.lbluangproses.Text = "Uang"
        '
        'txtuangproses
        '
        Me.txtuangproses.Location = New System.Drawing.Point(225, 392)
        Me.txtuangproses.Name = "txtuangproses"
        Me.txtuangproses.Size = New System.Drawing.Size(138, 20)
        Me.txtuangproses.TabIndex = 19
        '
        'btnhitung
        '
        Me.btnhitung.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnhitung.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnhitung.Location = New System.Drawing.Point(166, 462)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(75, 23)
        Me.btnhitung.TabIndex = 20
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = False
        '
        'lbltotalbiayapasien
        '
        Me.lbltotalbiayapasien.AutoSize = True
        Me.lbltotalbiayapasien.BackColor = System.Drawing.Color.Transparent
        Me.lbltotalbiayapasien.Location = New System.Drawing.Point(99, 425)
        Me.lbltotalbiayapasien.Name = "lbltotalbiayapasien"
        Me.lbltotalbiayapasien.Size = New System.Drawing.Size(95, 13)
        Me.lbltotalbiayapasien.TabIndex = 21
        Me.lbltotalbiayapasien.Text = "Total Biaya Pasien"
        '
        'txttotalbiayapasien
        '
        Me.txttotalbiayapasien.Location = New System.Drawing.Point(225, 418)
        Me.txttotalbiayapasien.Name = "txttotalbiayapasien"
        Me.txttotalbiayapasien.Size = New System.Drawing.Size(138, 20)
        Me.txttotalbiayapasien.TabIndex = 22
        '
        'lblkembalian
        '
        Me.lblkembalian.AutoSize = True
        Me.lblkembalian.BackColor = System.Drawing.Color.Transparent
        Me.lblkembalian.Location = New System.Drawing.Point(115, 513)
        Me.lblkembalian.Name = "lblkembalian"
        Me.lblkembalian.Size = New System.Drawing.Size(56, 13)
        Me.lblkembalian.TabIndex = 23
        Me.lblkembalian.Text = "Kembalian"
        '
        'txtkembalian
        '
        Me.txtkembalian.Location = New System.Drawing.Point(225, 506)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(138, 20)
        Me.txtkembalian.TabIndex = 24
        '
        'btnselesai
        '
        Me.btnselesai.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnselesai.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnselesai.Location = New System.Drawing.Point(303, 462)
        Me.btnselesai.Name = "btnselesai"
        Me.btnselesai.Size = New System.Drawing.Size(75, 23)
        Me.btnselesai.TabIndex = 25
        Me.btnselesai.Text = "Selesai "
        Me.btnselesai.UseVisualStyleBackColor = False
        '
        'lbljuduldatapasien
        '
        Me.lbljuduldatapasien.AutoSize = True
        Me.lbljuduldatapasien.BackColor = System.Drawing.Color.Transparent
        Me.lbljuduldatapasien.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljuduldatapasien.Location = New System.Drawing.Point(166, 32)
        Me.lbljuduldatapasien.Name = "lbljuduldatapasien"
        Me.lbljuduldatapasien.Size = New System.Drawing.Size(159, 29)
        Me.lbljuduldatapasien.TabIndex = 26
        Me.lbljuduldatapasien.Text = "Data Pasien"
        '
        'cmbdokter
        '
        Me.cmbdokter.FormattingEnabled = True
        Me.cmbdokter.Items.AddRange(New Object() {"dr. Indah Rusman, S.Ked., Sp.B", "dr. Andi Aulia, S.Ked., Sp.SPOG", "dr. Meylandani Jerisa, S.Ked., Sp.BS", "drg. Fauzan Nur, SKG., Sp.KGA", "dr. Heman Rizky, S.Ked., Sp.PD", "dr. Felicya Margaretha, S.Ked., Sp.An", "dr. Grace Simorangkir, S.Ked., Sp.BP-RE"})
        Me.cmbdokter.Location = New System.Drawing.Point(158, 150)
        Me.cmbdokter.Name = "cmbdokter"
        Me.cmbdokter.Size = New System.Drawing.Size(201, 21)
        Me.cmbdokter.TabIndex = 27
        '
        'lbldokter
        '
        Me.lbldokter.AutoSize = True
        Me.lbldokter.BackColor = System.Drawing.Color.Transparent
        Me.lbldokter.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldokter.Location = New System.Drawing.Point(36, 154)
        Me.lbldokter.Name = "lbldokter"
        Me.lbldokter.Size = New System.Drawing.Size(43, 15)
        Me.lbldokter.TabIndex = 28
        Me.lbldokter.Text = "Dokter"
        '
        'btncari7
        '
        Me.btncari7.BackColor = System.Drawing.Color.Thistle
        Me.btncari7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncari7.Image = Global.Proyekmandiri.My.Resources.Resources.xmag_search_find_export_locate_5984
        Me.btncari7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari7.Location = New System.Drawing.Point(374, 89)
        Me.btncari7.Name = "btncari7"
        Me.btncari7.Size = New System.Drawing.Size(62, 37)
        Me.btncari7.TabIndex = 16
        Me.btncari7.Text = "Cari"
        Me.btncari7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncari7.UseVisualStyleBackColor = False
        '
        'btnexit6
        '
        Me.btnexit6.BackColor = System.Drawing.Color.Thistle
        Me.btnexit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexit6.Image = Global.Proyekmandiri.My.Resources.Resources.exit_icon_icons_com_70975
        Me.btnexit6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexit6.Location = New System.Drawing.Point(441, 307)
        Me.btnexit6.Name = "btnexit6"
        Me.btnexit6.Size = New System.Drawing.Size(63, 44)
        Me.btnexit6.TabIndex = 15
        Me.btnexit6.Text = "Exit"
        Me.btnexit6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnexit6.UseVisualStyleBackColor = False
        '
        'btnproses5
        '
        Me.btnproses5.BackColor = System.Drawing.Color.Thistle
        Me.btnproses5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnproses5.Image = Global.Proyekmandiri.My.Resources.Resources.ic_history_128_28522
        Me.btnproses5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproses5.Location = New System.Drawing.Point(335, 307)
        Me.btnproses5.Name = "btnproses5"
        Me.btnproses5.Size = New System.Drawing.Size(76, 44)
        Me.btnproses5.TabIndex = 14
        Me.btnproses5.Text = "Proses"
        Me.btnproses5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnproses5.UseVisualStyleBackColor = False
        '
        'btnhapus3
        '
        Me.btnhapus3.BackColor = System.Drawing.Color.Thistle
        Me.btnhapus3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnhapus3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnhapus3.Image = Global.Proyekmandiri.My.Resources.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361
        Me.btnhapus3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus3.Location = New System.Drawing.Point(231, 307)
        Me.btnhapus3.Name = "btnhapus3"
        Me.btnhapus3.Size = New System.Drawing.Size(79, 44)
        Me.btnhapus3.TabIndex = 12
        Me.btnhapus3.Text = "Hapus"
        Me.btnhapus3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnhapus3.UseVisualStyleBackColor = False
        '
        'btnubah2
        '
        Me.btnubah2.BackColor = System.Drawing.Color.Thistle
        Me.btnubah2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnubah2.Image = Global.Proyekmandiri.My.Resources.Resources.DocumentEdit_40924
        Me.btnubah2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnubah2.Location = New System.Drawing.Point(133, 307)
        Me.btnubah2.Name = "btnubah2"
        Me.btnubah2.Size = New System.Drawing.Size(76, 44)
        Me.btnubah2.TabIndex = 11
        Me.btnubah2.Text = "Ubah"
        Me.btnubah2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnubah2.UseVisualStyleBackColor = False
        '
        'btnsimpan1
        '
        Me.btnsimpan1.BackColor = System.Drawing.Color.Thistle
        Me.btnsimpan1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsimpan1.Image = Global.Proyekmandiri.My.Resources.Resources.Save_icon_icons_com_73702_1_
        Me.btnsimpan1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan1.Location = New System.Drawing.Point(30, 307)
        Me.btnsimpan1.Name = "btnsimpan1"
        Me.btnsimpan1.Size = New System.Drawing.Size(79, 44)
        Me.btnsimpan1.TabIndex = 10
        Me.btnsimpan1.Text = "Simpan"
        Me.btnsimpan1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan1.UseVisualStyleBackColor = False
        '
        'btnkembali
        '
        Me.btnkembali.BackColor = System.Drawing.Color.Black
        Me.btnkembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnkembali.ForeColor = System.Drawing.Color.White
        Me.btnkembali.Location = New System.Drawing.Point(1, 2)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(87, 27)
        Me.btnkembali.TabIndex = 29
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = False
        '
        'frmpasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyekmandiri.My.Resources.Resources._7f4b8f6049707c49b10bd35ddd32db8e
        Me.ClientSize = New System.Drawing.Size(535, 547)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.lbldokter)
        Me.Controls.Add(Me.cmbdokter)
        Me.Controls.Add(Me.lbljuduldatapasien)
        Me.Controls.Add(Me.btnselesai)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.lblkembalian)
        Me.Controls.Add(Me.txttotalbiayapasien)
        Me.Controls.Add(Me.lbltotalbiayapasien)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.txtuangproses)
        Me.Controls.Add(Me.lbluangproses)
        Me.Controls.Add(Me.btnjumlahkan8)
        Me.Controls.Add(Me.btncari7)
        Me.Controls.Add(Me.btnexit6)
        Me.Controls.Add(Me.btnproses5)
        Me.Controls.Add(Me.btnhapus3)
        Me.Controls.Add(Me.btnubah2)
        Me.Controls.Add(Me.btnsimpan1)
        Me.Controls.Add(Me.txttotalbiaya5)
        Me.Controls.Add(Me.txtobat4)
        Me.Controls.Add(Me.txtbiayapemeriksaan3)
        Me.Controls.Add(Me.txtnamapasien2)
        Me.Controls.Add(Me.txtkodetransaksi1)
        Me.Controls.Add(Me.lbltotal5)
        Me.Controls.Add(Me.lblobat4)
        Me.Controls.Add(Me.lblbiaya3)
        Me.Controls.Add(Me.lblnamapasien2)
        Me.Controls.Add(Me.lblkodetransaksi1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmpasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Pemeriksaan Pasien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblkodetransaksi1 As Label
    Friend WithEvents lblnamapasien2 As Label
    Friend WithEvents lblbiaya3 As Label
    Friend WithEvents lblobat4 As Label
    Friend WithEvents lbltotal5 As Label
    Friend WithEvents txtkodetransaksi1 As TextBox
    Friend WithEvents txtnamapasien2 As TextBox
    Friend WithEvents txtbiayapemeriksaan3 As TextBox
    Friend WithEvents txtobat4 As TextBox
    Friend WithEvents txttotalbiaya5 As TextBox
    Friend WithEvents btnsimpan1 As Button
    Friend WithEvents btnubah2 As Button
    Friend WithEvents btnhapus3 As Button
    Friend WithEvents btnproses5 As Button
    Friend WithEvents btnexit6 As Button
    Friend WithEvents btncari7 As Button
    Friend WithEvents btnjumlahkan8 As Button
    Friend WithEvents lbluangproses As Label
    Friend WithEvents txtuangproses As TextBox
    Friend WithEvents btnhitung As Button
    Friend WithEvents lbltotalbiayapasien As Label
    Friend WithEvents txttotalbiayapasien As TextBox
    Friend WithEvents lblkembalian As Label
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents btnselesai As Button
    Friend WithEvents lbljuduldatapasien As Label
    Friend WithEvents cmbdokter As ComboBox
    Friend WithEvents lbldokter As Label
    Friend WithEvents btnkembali As Button
End Class
