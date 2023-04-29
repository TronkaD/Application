Imports MySql.Data.MySqlClient
Module ModuleCRUD
    Public Function db_connection() As MySqlConnection
        Return New MySqlConnection("server=localhost; username= root; password= ; database= db_mivamivo")
    End Function

    Public cn As MySqlConnection = db_connection()
    Public result As String
    Public cmd As New MySqlCommand
    Public cmd1 As New MySqlCommand
    Public cmd2 As New MySqlCommand
    Public cmd3 As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public dt1 As New DataTable
    Public dr As MySqlDataReader
    Public dr1 As MySqlDataReader
    Public today = DateTime.Now
    Public theNumbers() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Public MAP As Integer
    Public customer As String
    Public NF As String

    Public Sub create(ByVal sql As String)
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = sql
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MessageBox.Show("Echec d'enregistrement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Les données ont été enregistrer", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub updates(ByVal sql As String)
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = sql
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MessageBox.Show("Echec de mise à jour", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Les données ont été modifier ", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = sql
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MessageBox.Show("Echec de suppression", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("L'élement a été supprimer avec sucess ", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub managercodeclient(ByVal x As TextBox)
        Try
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "SELECT COUNT(*) FROM clients"
            Dim i As Integer
            Dim chaine As String
            i = cmd.ExecuteScalar
            chaine = "C0000"
            x.Text = chaine & (i + 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

End Module
