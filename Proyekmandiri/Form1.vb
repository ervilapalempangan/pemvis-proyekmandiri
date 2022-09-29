Imports System.Data.OleDb

Public Class frmpasien
    Private Sub btnsimpan1_Click(sender As Object, e As EventArgs) Handles btnsimpan1.Click
        'pemeriksaan textbox kosong
        If txtkodetransaksi1.Text = "" Or txtnamapasien2.Text = "" Or txtbiayapemeriksaan3.Text = "" Or txtobat4.Text = "" Or txttotalbiaya5.Text = "" Then
            MessageBox.Show("semua data wajib diisi")
            Exit Sub
        End If


        Try
            Call koneksi()
            Dim str As String
            str = "insert into TblPasien values ('" & txtkodetransaksi1.Text & "','" & txtnamapasien2.Text & "','" & cmbdokter.Text & "','" & txtbiayapemeriksaan3.Text & "','" & txtobat4.Text & "','" & txttotalbiaya5.Text & "')"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Disimpan")
            Call bersih2()
            txtkodetransaksi1.Clear()

        Catch ex As Exception
            MessageBox.Show("Data Gagal Disimpan")
            MessageBox.Show(ErrorToString)
        End Try


    End Sub

    Private Sub btnjumlahkan8_Click(sender As Object, e As EventArgs) Handles btnjumlahkan8.Click
        txttotalbiaya5.Text = CInt(txtbiayapemeriksaan3.Text) + CInt(txtobat4.Text)
    End Sub

    Private Sub btnubah2_Click(sender As Object, e As EventArgs) Handles btnubah2.Click
        Dim pilihan As MsgBoxResult
        pilihan = MessageBox.Show("apakah Anda ingin mengedit data ini?", "Perhatian!!", MessageBoxButtons.YesNo)

        'kalau yes
        If pilihan = MsgBoxResult.Yes Then
            Call koneksi()
            Dim str As String
            str = "UPDATE TblPasien SET nama = '" & txtnamapasien2.Text & "' , dokter= '" & cmbdokter.Text & "' , biaya_periksa= '" & txtbiayapemeriksaan3.Text & "' , obat='" & txtobat4.Text & "', total_biaya='" & txttotalbiaya5.Text & "' WHERE kode = '" & txtkodetransaksi1.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil diedit")
            Call bersih2()
            txtkodetransaksi1.Clear()
        End If
    End Sub

    Private Sub btnhapus3_Click(sender As Object, e As EventArgs) Handles btnhapus3.Click
        Dim pilihan As MsgBoxResult
        pilihan = MessageBox.Show("Apakah Anda Yakin Ingin menghapus data", "PERHATIAN!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'kalau yakin 
        If pilihan = MsgBoxResult.Yes Then
            Call koneksi()
            Dim str As String
            str = "DELETE * FROM TblPasien WHERE kode= '" & txtkodetransaksi1.Text & "' or nama='" & txtnamapasien2.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Di Hapus")
            Call bersih2()
            txtkodetransaksi1.Clear()

        End If

        'kalau pilihan no
        If pilihan = MsgBoxResult.No Then
            MessageBox.Show("baiklah")
        End If
    End Sub

    Private Sub btncari7_Click(sender As Object, e As EventArgs) Handles btncari7.Click
        Call koneksi()
        Dim str As String
        str = "select * from tblpasien where nama= '" & txtnamapasien2.Text & "' or kode= '" & txtkodetransaksi1.Text & "'"
        cmd = New OleDbCommand(str, conn)
        RD = cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            txtkodetransaksi1.Text = RD.Item("kode")
            txtbiayapemeriksaan3.Text = RD.Item("biaya_periksa")
            txtobat4.Text = RD.Item("obat")
            txttotalbiaya5.Text = RD.Item("total_biaya")
            txtnamapasien2.Text = RD.Item("nama")
            cmbdokter.Text = RD.Item("dokter")
        Else
            MessageBox.Show("Data tidak ditemukan")
            txtkodetransaksi1.Clear()
            txtnamapasien2.Clear()
        End If

    End Sub

    Private Sub btnproses5_Click(sender As Object, e As EventArgs) Handles btnproses5.Click
        Call tutupselainproses()
        Call bukaproses()
        txttotalbiayapasien.Text = Val(txttotalbiaya5.Text)

    End Sub

    Sub tutupselainproses()
        txtnamapasien2.Enabled = False
        txtkodetransaksi1.Enabled = False
        txtbiayapemeriksaan3.Enabled = False
        txtobat4.Enabled = False
        txttotalbiaya5.Enabled = False
        btnjumlahkan8.Enabled = False
        btncari7.Enabled = False
        btnhapus3.Enabled = False
        btnsimpan1.Enabled = False
        btnubah2.Enabled = False
    End Sub

    Sub bukaselainproses()
        txtnamapasien2.Enabled = True
        txtkodetransaksi1.Enabled = True
        txtbiayapemeriksaan3.Enabled = True
        txtobat4.Enabled = True
        txttotalbiaya5.Enabled = True
        btnjumlahkan8.Enabled = True
        btncari7.Enabled = True
        btnhapus3.Enabled = True
        btnsimpan1.Enabled = True
        btnubah2.Enabled = True
    End Sub

    Sub tutupproses()
        txtuangproses.Enabled = False
        txttotalbiayapasien.Enabled = False
        txtkembalian.Enabled = False
        btnhitung.Enabled = False
    End Sub

    Sub bukaproses()
        txtuangproses.Enabled = True
        txttotalbiayapasien.Enabled = True
        txtkembalian.Enabled = True
        btnhitung.Enabled = True
    End Sub

    Sub bersih2()
        txtnamapasien2.Clear()
        txtkodetransaksi1.Clear()
        txtbiayapemeriksaan3.Clear()
        txtobat4.Clear()
        txttotalbiaya5.Clear()
        txtuangproses.Clear()
        txttotalbiayapasien.Clear()
        txtkembalian.Clear()
        cmbdokter.SelectedIndex = -1
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        txtkembalian.Text = Val(txtuangproses.Text) - Val(txttotalbiayapasien.Text)
    End Sub

    Private Sub frmpasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tutupproses()
    End Sub

    Private Sub btnselesai_Click(sender As Object, e As EventArgs) Handles btnselesai.Click
        Call bukaselainproses()
        Call bersih2()
        Call tutupproses()
    End Sub

    Private Sub btnexit6_Click(sender As Object, e As EventArgs) Handles btnexit6.Click
        End
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        frmutama.Show()
        Me.Close()
    End Sub
End Class
