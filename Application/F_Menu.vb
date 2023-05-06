Public Class F_Menu
    Private Sub btncategories_Click(sender As Object, e As EventArgs) Handles btncategories.Click
        F_categorie.ShowDialog()
    End Sub

    Private Sub btnanimals_Click(sender As Object, e As EventArgs) Handles btnanimals.Click
        Form1.ShowDialog()
    End Sub

    Private Sub btncustomers_Click(sender As Object, e As EventArgs) Handles btncustomers.Click
        F_Client.ShowDialog()
    End Sub

    Private Sub btn_user_Click(sender As Object, e As EventArgs) Handles btn_user.Click
        F_User.ShowDialog()
    End Sub

    Private Sub btnsales_Click(sender As Object, e As EventArgs) Handles btnsales.Click
        F_Vente.ShowDialog()
    End Sub

    Private Sub btnfoodstuffs_Click(sender As Object, e As EventArgs) Handles btnfoodstuffs.Click

    End Sub
End Class