Imports MySql.Data.MySqlClient
Public Class Authentification
    Private Sub Connexion_Click(sender As Object, e As EventArgs) Handles Connexion.Click
        Dim cn As New MySqlConnection
        'connection à la base de donnée
        cn.ConnectionString = "server=localhost; username= root; password= ; database= db_mivamivo "
        cn.Open()
        'requête d'insertion
        Dim str As String = "select * from users where pseudo = '" & usertxt.Text & "' and password = '" & passwordtxt.Text & "'"
        cmd = New MySqlCommand(str, cn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            F_Menu.ShowDialog()
            dr.Close()
            cn.Close()
            Me.Hide()
        Else
            MessageBox.Show("Nom d'utilisateur ou Mot de passe incorrect")
            usertxt.Clear()
            passwordtxt.Clear()
            usertxt.Focus()
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            'voir le mot de passe en tous caratère
            passwordtxt.UseSystemPasswordChar = False
        Else
            'Ne pas afficher le mot de passe
            passwordtxt.UseSystemPasswordChar = True
        End If
    End Sub
End Class