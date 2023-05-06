Imports MySql.Data.MySqlClient
Public Class F_User
    Private Sub btndeletetextbox_Click(sender As Object, e As EventArgs) Handles btndeletetextbox.Click
        pseudotxt.Clear()
        passwordtxt.Clear()
        statustxt.Items.Clear()
        phonetxt.Clear()
        pseudotxt.Focus()
    End Sub

    Private Sub btnsaveuser_Click(sender As Object, e As EventArgs) Handles btnsaveuser.Click
        If pseudotxt.Text = "" Then
            pseudotxt.Focus()
        ElseIf passwordtxt.Text = "" Then
            passwordtxt.Focus()
        ElseIf statustxt.Text = "" Then
            statustxt.Focus()
        ElseIf phonetxt.Text = "" Then
            phonetxt.Focus()

        Else

            Try
                create("insert into users(pseudo, password, status, phone) values('" & pseudotxt.Text & "','" & passwordtxt.Text & "','" & statustxt.Text & "','" & phonetxt.Text & "') ")
                pseudotxt.Clear()
                passwordtxt.Clear()
                statustxt.Items.Clear()
                phonetxt.Clear()
                pseudotxt.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            reload("select*from users", DataGridViewUser)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndeleteuser_Click(sender As Object, e As EventArgs) Handles btndeleteuser.Click
        Try
            delete("DELETE FROM users WHERE id= '" & id_user.Text & "' ")
            pseudotxt.Clear()
            passwordtxt.Clear()
            statustxt.Items.Clear()
            phonetxt.Clear()
            pseudotxt.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnupdateuser_Click(sender As Object, e As EventArgs) Handles btnupdateuser.Click
        Try
            updates("UPDATE users SET pseudo='" & pseudotxt.Text & "', password='" & passwordtxt.Text & "', status='" & statustxt.Text & "', phone='" & phonetxt.Text & "' WHERE id='" & id_user.Text & "'")
            pseudotxt.Clear()
            passwordtxt.Clear()
            statustxt.Items.Clear()
            phonetxt.Clear()
            pseudotxt.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        dt = New DataTable
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = " SELECT id, pseudo, password, status, phone FROM users WHERE pseudo LIKE '%" & Search.Text & "%'"
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridViewUser.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridViewUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUser.CellClick
        id_user.Text = DataGridViewUser.CurrentRow.Cells(0).Value
        pseudotxt.Text = DataGridViewUser.CurrentRow.Cells(1).Value
        passwordtxt.Text = DataGridViewUser.CurrentRow.Cells(2).Value
        statustxt.Text = DataGridViewUser.CurrentRow.Cells(3).Value
        phonetxt.Text = DataGridViewUser.CurrentRow.Cells(4).Value
    End Sub

    Private Sub F_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class