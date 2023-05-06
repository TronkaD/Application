Imports MySql.Data.MySqlClient
Public Class F_categorie
    Private Sub btnNewCategory_Click(sender As Object, e As EventArgs) Handles btnNewCategory.Click
        If codetxt.Text = "" Then
            MessageBox.Show("Veuillez remplir ce champ")
            codetxt.Focus()
        ElseIf categorietxt.Text = "" Then
            MessageBox.Show("Veuillez remplir ce champ")
            categorietxt.Focus()
        Else

            Try
                create("insert into categories(code_cat,libelle_cat) values ('" & codetxt.Text & "','" & categorietxt.Text & "')")
                idcattxt.Clear()
                codetxt.Clear()
                categorietxt.Clear()
                codetxt.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnreload_Click(sender As Object, e As EventArgs) Handles btnreload.Click
        Try
            reload("select*from categories", DataGridViewCategorie)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEditCategry_Click(sender As Object, e As EventArgs) Handles btnEditCategry.Click
        Try
            updates("UPDATE categories SET code_cat='" & codetxt.Text & "', libelle_cat='" & categorietxt.Text & "' WHERE id_cat='" & idcattxt.Text & "'")
            idcattxt.Clear()
            codetxt.Clear()
            categorietxt.Clear()
            codetxt.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewCategorie_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCategorie.CellClick
        idcattxt.Text = DataGridViewCategorie.CurrentRow.Cells(0).Value
        codetxt.Text = DataGridViewCategorie.CurrentRow.Cells(1).Value
        categorietxt.Text = DataGridViewCategorie.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btnDeleteCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteCategory.Click
        Try
            delete("DELETE FROM categories WHERE id_cat = '" & idcattxt.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndeletecal_Click(sender As Object, e As EventArgs) Handles btndeletecal.Click
        idcattxt.Clear()
        codetxt.Clear()
        categorietxt.Clear()
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged

        dt = New DataTable
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = " SELECT id_cat, code_cat, libelle_cat FROM categories WHERE libelle_cat LIKE '%" & Search.Text & "%'"
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridViewCategorie.DataSource = dt
        cn.Close()

    End Sub

    Private Sub BtnImpression_Click(sender As Object, e As EventArgs) Handles BtnImpression.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridViewCategorie.Width, Me.DataGridViewCategorie.Height)
        DataGridViewCategorie.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridViewCategorie.Width, Me.DataGridViewCategorie.Height))
        e.Graphics.DrawImage(imagebmp, 150, 100)
    End Sub
End Class