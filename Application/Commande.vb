Imports MySql.Data.MySqlClient
Public Class Commande

    'Afficher tous les clients enregistrer dans le combobox
    Private Sub Fillcombobox()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = ("SELECT DISTINCT nom FROM clients")
        dr = cmd.ExecuteReader
        While (dr.Read)
            Me.CbClient.Items.Add(dr("nom")).ToString()
        End While
        dr.Close()
        cn.Close()
    End Sub

    'Recuperer le type de reglement du client
    Private Sub Fillcomboboxtypereglement()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = ("SELECT DISTINCT type FROM clients  WHERE nom = '" & CbClient.Text & "'")
        dr = cmd.ExecuteReader
        While (dr.Read)
            CbTypeReglement.Text = dr.GetValue(0)
        End While
        dr.Close()
        cn.Close()
    End Sub

    'Afficher les différentes catégories dans le combobox
    Private Sub Codecategorie()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select distinct libelle_cat from categories"
        dr = cmd.ExecuteReader
        While (dr.Read)
            Me.CbCategorie.Items.Add(dr("libelle_cat")).ToString()
        End While
        dr.Close()
        cn.Close()

    End Sub

    Private Sub Managercodeclt()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT libelle FROM sous_categories WHERE categorie = '" & CbCategorie.Text & "'"
        dr = cmd.ExecuteReader
        While (dr.Read)
            Me.CbSousCategorie.Items.Add(dr("libelle")).ToString()
        End While
        dr.Close()
        cn.Close()
    End Sub

    'Recuperer la quantité en stock du produit selectionné
    Private Sub Getquantitystock()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select distinct code, qte_stock from sous_categories where libelle= '" & CbSousCategorie.Text & "'"
        dr = cmd.ExecuteReader
        While (dr.Read)
            QteStockDispo.Text = dr.GetValue(1)
            TxtCodeP.Text = dr.GetValue(0)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub CbVendeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVendeur.SelectedIndexChanged

    End Sub

    Private Sub CbClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbClient.SelectedIndexChanged
        Fillcomboboxtypereglement()
    End Sub

    Private Sub CbCategorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCategorie.SelectedIndexChanged
        Managercodeclt()
    End Sub

    Private Sub CbSousCategorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbSousCategorie.SelectedIndexChanged
        Getquantitystock()
    End Sub

    Private Sub QteStockDispo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QteStockDispo.KeyPress
        If Not theNumbers.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub QteCommand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QteCommand.KeyPress
        If Not theNumbers.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PrixUnitaire_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrixUnitaire.KeyPress
        If Not theNumbers.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub PrixTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrixTotal.KeyPress
        If Not theNumbers.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Resultat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Resultat.KeyPress
        If Not theNumbers.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub QteCommand_TextChanged(sender As Object, e As EventArgs) Handles QteCommand.TextChanged
        If Val(QteCommand.Text) > Val(QteStockDispo.Text) Then
            MsgBox("La quantité commandée est supérieur à la quantité disponible dans le stock", MsgBoxStyle.Critical, "Erreur quantité")
            QteCommand.Text = ""
            QteCommand.Focus()
        Else
            Resultat.Text = Val(QteStockDispo.Text) - Val(QteCommand.Text)
        End If
    End Sub

    Private Sub PrixTotal_TextChanged(sender As Object, e As EventArgs) Handles PrixTotal.TextChanged
        If PrixTotal.Text <> "" Then
            BtnCreate.Enabled = True
        Else
            BtnCreate.Enabled = False
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        CbVendeur.Text = ""
        CbClient.Text = ""
        CbTypeReglement.Text = ""
        CbCategorie.Text = ""
        CbSousCategorie.Text = ""
        QteStockDispo.Text = ""
        QteCommand.Text = ""
        PrixUnitaire.Text = ""
        PrixTotal.Text = ""
        Resultat.Text = ""
        CbCategorie.Items.Clear()
    End Sub

    Private Sub Commande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = " SELECT * FROM fiche"
        dr = cmd.ExecuteReader
        While (dr.Read)
            TxtNF.Text = dr.GetValue(1)
            TxtNUMF.Text = dr.GetValue(0)
        End While
        dr.Close()
        cn.Close()
        Fillcombobox()
        Codecategorie()
    End Sub

    Private Sub TxtCodeP_TextChanged(sender As Object, e As EventArgs) Handles TxtCodeP.TextChanged

    End Sub

    Private Sub TxtNF_TextChanged(sender As Object, e As EventArgs) Handles TxtNF.TextChanged
        'Ce code permet d'incrémenté le numéro de l' affiche
        TxtNNF.Text = Val(TxtNF.Text) + 1
    End Sub

    Private Sub BtnActualiser_Click(sender As Object, e As EventArgs) Handles BtnActualiser.Click
        F_Client.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click

        cn.Open()
        cmd.Connection = cn
        cmd1.Connection = cn
        cmd2.Connection = cn
        cmd.CommandText = "update sous_categories set qte_stock = '" & Resultat.Text & "' where libelle = '" & CbSousCategorie.Text & "'"
        cmd.ExecuteNonQuery()
        cmd1.CommandText = "INSERT INTO command(NF,vendeur, date_vt, nom_clt, type_reglem, categorie, designation, qte_command, prix_unitaire,montant) values ('" & TxtNF.Text & "','" & CbVendeur.Text & "','" & TxtDate.Text & "','" & CbClient.Text & "','" & CbTypeReglement.Text & "', '" & CbCategorie.Text & "', '" & CbSousCategorie.Text & "','" & QteCommand.Text & "','" & PrixUnitaire.Text & "', '" & PrixTotal.Text & "')"
        cmd1.ExecuteNonQuery()
        da = New MySqlDataAdapter("SELECT * FROM command", cn)
        da.Fill(dt)
        DataGridViewCommand.DataSource = dt
        cn.Close()
        CbCategorie.Text = ""
        CbSousCategorie.Text = ""
        QteStockDispo.Text = ""
        QteCommand.Text = ""
        PrixUnitaire.Text = ""
        PrixTotal.Text = ""
        Resultat.Text = ""
        CbCategorie.Items.Clear()
        Codecategorie()

    End Sub


    Private Sub DataGridViewCommand_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCommand.CellContentClick
        IdcmdTxt.Text = DataGridViewCommand.CurrentRow.Cells(0).Value
        CbVendeur.Text = DataGridViewCommand.CurrentRow.Cells(1).Value
        TxtDate.Text = DataGridViewCommand.CurrentRow.Cells(2).Value
        CbClient.Text = DataGridViewCommand.CurrentRow.Cells(3).Value
        CbTypeReglement.Text = DataGridViewCommand.CurrentRow.Cells(4).Value
        CbCategorie.Text = DataGridViewCommand.CurrentRow.Cells(5).Value
        CbSousCategorie.Text = DataGridViewCommand.CurrentRow.Cells(6).Value
        QteCommand.Text = DataGridViewCommand.CurrentRow.Cells(7).Value
        PrixUnitaire.Text = DataGridViewCommand.CurrentRow.Cells(8).Value
        PrixTotal.Text = DataGridViewCommand.CurrentRow.Cells(9).Value
    End Sub



    Private Sub BtnEdite_Click(sender As Object, e As EventArgs) Handles BtnEdite.Click
        Try
            updates("UPDATE command SET id_cmd='" & IdcmdTxt.Text & "',vendeur='" & CbVendeur.Text & "', date_vt='" & TxtDate.Text & "', nom_clt='" & CbClient.Text & "', type_reglem='" & CbTypeReglement.Text & "', categorie='" & CbCategorie.Text & "', designation='" & CbSousCategorie.Text & "', qte_command='" & QteCommand.Text & "', prix_unitaire='" & PrixUnitaire.Text & "', montant='" & PrixTotal.Text & " WHERE id_cmd ='" & IdcmdTxt.Text & "'")
            CbVendeur.Text = ""
            CbClient.Text = ""
            CbTypeReglement.Text = ""
            CbCategorie.Text = ""
            CbSousCategorie.Text = ""
            QteStockDispo.Text = ""
            QteCommand.Text = ""
            PrixUnitaire.Text = ""
            PrixTotal.Text = ""
            Resultat.Text = ""
            CbCategorie.Items.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualser_Click(sender As Object, e As EventArgs) Handles BtnActualser.Click
        Try
            reload("select*from command", DataGridViewCommand)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btncmd_Click(sender As Object, e As EventArgs) Handles btncmd.Click
        Try
            delete(" DELETE FROM command WHERE id_cmd= '" & IdcmdTxt.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrixUnitaire_TextChanged(sender As Object, e As EventArgs) Handles PrixUnitaire.TextChanged
        PrixTotal.Text = Val(QteCommand.Text) * Val(PrixUnitaire.Text)
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        dt = New DataTable
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = " SELECT id_cmd, vendeur, date_vt, nom_clt, type_reglem, categorie, designation, qte_command, prix_unitaire, montant FROM command WHERE date_vt LIKE '%" & Search.Text & "%'"
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridViewCommand.DataSource = dt
        cn.Close()
    End Sub
End Class