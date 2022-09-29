Public Class frmutama
    Private Sub btntambahuser_Click(sender As Object, e As EventArgs) Handles btntambahuser.Click
        Me.Hide()
        frmtambahuser.ShowDialog()

    End Sub

    Private Sub btnpasien_Click_1(sender As Object, e As EventArgs) Handles btnpasien.Click
        Me.Hide()
        frmpasien.ShowDialog()

    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub
End Class