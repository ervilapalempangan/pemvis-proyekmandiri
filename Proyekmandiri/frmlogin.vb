Imports System.Data.OleDb
Public Class frmlogin
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Call koneksi()
        Dim str As String
        str = "SELECT * FROM tbllogin WHERE iduser = '" & txtuser.Text & "' AND password = '" & txtpassword.Text & "'"
        cmd = New OleDbCommand(str, conn)
        RD = cmd.ExecuteReader
        RD.Read()
        'jika ada di data base
        If RD.HasRows Then
            MessageBox.Show("Welcome")
            Me.Hide()
            frmutama.ShowDialog()
            Me.Close()
        End If

        'jika tidak ada
        If Not RD.HasRows Then
            MessageBox.Show("User ID atau Password Salah")
            txtpassword.Clear()
            txtuser.Clear()
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        End
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class