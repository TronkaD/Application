Imports MySql.Data.MySqlClient
Public Class F_Vente

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtNQ.TextChanged

    End Sub

    Private Sub F_Vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateVenteTxt.Text = today
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

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        cn.Open()
        cmd.Connection = cn
        cmd1.Connection = cn
        cmd2.Connection = cn
        cmd.CommandText = "update sous_categories set qte_stock = '" & Resultat.Text & "' where libelle = '" & CbSousCategorie.Text & "'"
        cmd.ExecuteNonQuery()
        cmd1.CommandText = "INSERT INTO ventes(vendeur, date_vt, nom_clt, type_reglem, categorie, designation, qte_command, prix_unitaire,montant) values ('" & CbVendeur.Text & "','" & DateVenteTxt.Text & "','" & CbClient.Text & "','" & CbTypeReglement.Text & "', '" & CbCategorie.Text & "', '" & CbSousCategorie.Text & "','" & QteCommand.Text & "','" & PrixUnitaire.Text & "', '" & PrixTotal.Text & "')"
        cmd1.ExecuteNonQuery()
        cmd2.CommandText = "INSERT INTO sortie(NF, vendeur, date_vt, nom_clt, type_reglem, categorie, designation, qte_command, prix_unitaire,montant) values ('" & TxtNF.Text & "','" & CbVendeur.Text & "','" & DateVenteTxt.Text & "','" & CbClient.Text & "','" & CbTypeReglement.Text & "','" & CbCategorie.Text & "','" & CbSousCategorie.Text & "','" & QteCommand.Text & "','" & PrixUnitaire.Text & "','" & PrixTotal.Text & "')"
        cmd2.ExecuteNonQuery()
        da = New MySqlDataAdapter("SELECT * FROM ventes", cn)
        da.Fill(dt)
        DataGridViewVente.DataSource = dt
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

    Private Sub BtnImprimer_Click(sender As Object, e As EventArgs)
        Fiche.ShowDialog()
        customer = CbClient.Text
        NF = TxtNUMF.Text
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "update fiche set NF = '" & TxtNNF.Text & "' where N = '" & TxtNUMF.Text & "'"
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub TxtNF_TextChanged(sender As Object, e As EventArgs) Handles TxtNF.TextChanged
        'Ce code permet d'incrémenté le numéro de l' affiche
        TxtNNF.Text = Val(TxtNF.Text) + 1
    End Sub

    Private Sub BtnNewClt_Click(sender As Object, e As EventArgs) Handles BtnNewClt.Click
        F_Client.ShowDialog()
    End Sub

    Private Sub QteStockDispo_TextChanged(sender As Object, e As EventArgs) Handles QteStockDispo.TextChanged

    End Sub

    Private Sub PrixUnitaire_TextChanged(sender As Object, e As EventArgs) Handles PrixUnitaire.TextChanged
        PrixTotal.Text = Val(QteCommand.Text) * Val(PrixUnitaire.Text)
    End Sub

    Private Sub DataGridViewVente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewVente.CellContentClick
        IdvtTxt.Text = DataGridViewVente.CurrentRow.Cells(0).Value
        CbVendeur.Text = DataGridViewVente.CurrentRow.Cells(1).Value
        DateVenteTxt.Text = DataGridViewVente.CurrentRow.Cells(2).Value
        CbClient.Text = DataGridViewVente.CurrentRow.Cells(3).Value
        CbTypeReglement.Text = DataGridViewVente.CurrentRow.Cells(4).Value
        CbCategorie.Text = DataGridViewVente.CurrentRow.Cells(5).Value
        CbSousCategorie.Text = DataGridViewVente.CurrentRow.Cells(6).Value
        QteCommand.Text = DataGridViewVente.CurrentRow.Cells(7).Value
        PrixUnitaire.Text = DataGridViewVente.CurrentRow.Cells(8).Value
        PrixTotal.Text = DataGridViewVente.CurrentRow.Cells(9).Value
    End Sub

    Private Sub ButEdit_Click(sender As Object, e As EventArgs) Handles ButEdit.Click
        Try
            updates("UPDATE ventes SET id_vt='" & IdvtTxt.Text & "',vendeur='" & CbVendeur.Text & "', date_vt='" & DateVenteTxt.Text & "', nom_clt='" & CbClient.Text & "', type_reglem='" & CbTypeReglement.Text & "', categorie='" & CbCategorie.Text & "', designation='" & CbSousCategorie.Text & "', qte_command='" & QteCommand.Text & "', prix_unitaire='" & PrixUnitaire.Text & "', montant='" & PrixTotal.Text & " WHERE id_vt ='" & IdvtTxt.Text & "'")
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

    Private Sub btndeleteproduct_Click(sender As Object, e As EventArgs) Handles btndeleteproduct.Click
        Try
            delete("DELETE FROM ventes WHERE id_vt='" & IdvtTxt.Text & "' AND vendeur='" & CbVendeur.Text & "'AND date_vt='" & DateVenteTxt.Text & "'AND nom_clt='" & CbClient.Text & "'AND type_reglem='" & CbTypeReglement.Text & "'AND categorie='" & CbCategorie.Text & "'AND designation='" & CbSousCategorie.Text & "'AND qte_command='" & QteCommand.Text & "'AND prix_unitaire='" & PrixUnitaire.Text & "'AND montant='" & PrixTotal.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class