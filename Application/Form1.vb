Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub codecategorie()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select distinct libelle_cat from categories"
        dr = cmd.ExecuteReader
        While (dr.Read)
            Me.categorieprodtxt.Items.Add(dr("libelle_cat")).ToString()
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub managercode()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select distinct code_cat from categories where libelle_cat = '" & categorieprodtxt.Text & "'"
        dr = cmd.ExecuteReader
        While (dr.Read)
            codeprodtxt.Text = dr.GetValue(0)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codecategorie()
    End Sub

    Private Sub categorieprodtxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categorieprodtxt.SelectedIndexChanged
        managercode()
    End Sub

    Private Sub btndeletetextbox_Click(sender As Object, e As EventArgs) Handles btndeletetextbox.Click
        idprodtxt.Clear()
        categorieprodtxt.Items.Clear()
        codeprodtxt.Clear()
        libelleprodtxt.Clear()
        Qte.Clear()
        categorieprodtxt.Focus()
        codecategorie()
        managercode()
    End Sub

    Private Sub btnsaveproduct_Click(sender As Object, e As EventArgs) Handles btnsaveproduct.Click
        If categorieprodtxt.Text = "" Then
            categorieprodtxt.Focus()
        ElseIf codeprodtxt.Text = "" Then
            codeprodtxt.Focus()
        ElseIf libelleprodtxt.Text = "" Then
            libelleprodtxt.Focus()
        ElseIf categorieprodtxt.Text = "" Then
            categorieprodtxt.Focus()
        ElseIf Not IsNumeric(Qte.Text) Then
            MsgBox("Entrer un chiffre")
            Qte.Focus()

        Else

            Try
                create("insert into sous_categories(categorie, code, libelle, qte_stock) values ('" & categorieprodtxt.Text & "','" & codeprodtxt.Text & "','" & libelleprodtxt.Text & "','" & Qte.Text & "')")
                idprodtxt.Clear()
                categorieprodtxt.Items.Clear()
                codeprodtxt.Clear()
                libelleprodtxt.Clear()
                Qte.Clear()
                categorieprodtxt.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
        codecategorie()
        managercode()
    End Sub

    Private Sub btnreloadprod_Click(sender As Object, e As EventArgs) Handles btnreloadprod.Click
        Try
            reload("select*from sous_categories", DataGridViewProduit)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewProduit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProduit.CellClick
        idprodtxt.Text = DataGridViewProduit.CurrentRow.Cells(0).Value
        categorieprodtxt.Text = DataGridViewProduit.CurrentRow.Cells(1).Value
        codeprodtxt.Text = DataGridViewProduit.CurrentRow.Cells(2).Value
        libelleprodtxt.Text = DataGridViewProduit.CurrentRow.Cells(3).Value
        Qte.Text = DataGridViewProduit.CurrentRow.Cells(4).Value
    End Sub

    Private Sub btnupdateprod_Click(sender As Object, e As EventArgs) Handles btnupdateprod.Click
        Try
            updates("UPDATE sous_categories SET id_prod='" & idprodtxt.Text & "', categorie='" & categorieprodtxt.Text & "', code='" & codeprodtxt.Text & "', libelle='" & libelleprodtxt.Text & "', qte_stock='" & Qte.Text & "' WHERE id_prod='" & idprodtxt.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndeleteprod_Click(sender As Object, e As EventArgs) Handles btndeleteprod.Click
        Try
            delete("DELETE FROM sous_categories WHERE id_prod= '" & idprodtxt.Text & "' AND categorie='" & categorieprodtxt.Text & "' AND code='" & codeprodtxt.Text & "' AND libelle='" & libelleprodtxt.Text & "' AND qte_stock='" & Qte.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Qte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Qte.KeyPress
        If Not theNumbers.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        dt = New DataTable
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = " SELECT * FROM sous_categories WHERE categorie LIKE '%" & Search.Text & "%'"
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridViewProduit.DataSource = dt
    End Sub
End Class
