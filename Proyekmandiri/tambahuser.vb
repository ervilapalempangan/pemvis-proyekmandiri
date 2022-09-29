Imports System.Data.OleDb
Public Class frmtambahuser
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            Call koneksi()
            Dim str As String
            str = " insert into tbllogin values ('" & txttambahuser.Text & "' , '" & txttambahpassword.Text & "')"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("data user berhasil disimpan")
            txttambahpassword.Clear()
            txttambahuser.Clear()
        Catch ex As Exception
            MessageBox.Show("data user gagal disimpan")
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim pilihan As MsgBoxResult
        pilihan = MessageBox.Show("apakah anda ingin mengedit data user ini?", "perhatian!!", MessageBoxButtons.YesNo)

        'jika yes
        If pilihan = MsgBoxResult.Yes Then
            Call koneksi()
            Dim str As String
            str = "Update tbllogin set [password]= '" & txttambahpassword.Text & "' where iduser='" & txttambahuser.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("data user berhasil diedit")
            txttambahpassword.Clear()
            txttambahuser.Clear()
        End If

        'jika no
        If pilihan = MsgBoxResult.No Then
            MessageBox.Show("data gagal diedit")
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim pilihan As MsgBoxResult
        pilihan = MessageBox.Show("apakah anda ingin menghapus data user ini?", "perhatian!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'jika yes
        If pilihan = MsgBoxResult.Yes Then
            Call koneksi()
            Dim str As String
            str = "Delete * from tbllogin where iduser ='" & txttambahuser.Text & "'"
            cmd = New OleDbCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("data user berhasil dihapus")
            txttambahpassword.Clear()
            txttambahuser.Clear()
        End If

        'jika no
        If pilihan = MsgBoxResult.No Then
            MessageBox.Show("data gagal hapus")
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Call koneksi()
        Dim str As String
        str = "select * from tbllogin where iduser= '" & txttambahuser.Text & "'"
        cmd = New OleDbCommand(str, conn)
        RD = cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            txttambahpassword.Text = RD.Item("password")
        Else
            MessageBox.Show("Data tidak ditemukan")
            txttambahuser.Clear()
            txttambahpassword.Clear()
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        frmutama.Show()
        Me.Close()
    End Sub
End Class