Imports MySql.Data.MySqlClient
Public Class F_Operatoin_Stock
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
    'Fonction permettent de recuperer l'id , le code, et la quantité du produit en stock apres la selection du produit conserner
    Private Sub getdata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select distinct id_prod, code, qte_stock from sous_categories where libelle ='" & Cbchiken.Text & "' or libelle = '" & Cbcaprins.Text & "'"
        dr = cmd.ExecuteReader
        While (dr.Read)
            idtxt.Text = dr.GetValue(0)
            codeoptxt.Text = dr.GetValue(1)
            QteStock.Text = dr.GetValue(2)
        End While
        dr.Close()
        cn.Close()
    End Sub

    'Fonction permettent d'afficher tous les produits animals lorsque la catégorie est Volailles
    Private Sub getproductanimals()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT libelle FROM sous_categories WHERE categorie = 'Volailles'"
        dr = cmd.ExecuteReader
        While (dr.Read)
            Me.Cbchiken.Items.Add(dr("libelle")).ToString()
        End While
        dr.Close()
        cn.Close()
    End Sub

    'Fonction permettent d'afficher tous les produits animals lorsque la catégorie est Caprins
    Private Sub getproductanimalsducks()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT libelle FROM sous_categories WHERE categorie = 'Caprins'"
        dr = cmd.ExecuteReader
        While (dr.Read)
            Me.Cbcaprins.Items.Add(dr("libelle")).ToString()
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub GetTypeOperation()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT DISTINCT type_op FROM type_operation"
        dr = cmd.ExecuteReader
        While (dr.Read)
            Me.CbLibelleOp.Items.Add(dr("type_op")).ToString()
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub F_Operatoin_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getproductanimals()
        getproductanimalsducks()
        GetTypeOperation()
        Dateoperationtxt.Text = today
    End Sub

    Private Sub Cbchiken_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbchiken.SelectedIndexChanged
        getproductanimals()
        getdata()
    End Sub

    Private Sub Cbcaprins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbcaprins.SelectedIndexChanged
        getproductanimalsducks()
        getdata()
    End Sub

    Private Sub btndeletetextbox_Click(sender As Object, e As EventArgs) Handles btndeletetextbox.Click
        Cbchiken.Items.Clear()
        Dateoperationtxt.Clear()
        idtxt.Clear()
        codeoptxt.Clear()
        CbLibelleOp.Items.Clear()
        Operation.Clear()
        QteStock.Clear()
        Resultat.Clear()
        GetTypeOperation()
    End Sub

    Private Sub Btnreload_Click(sender As Object, e As EventArgs) Handles Btnreload.Click
        Try
            reload("select*from operation_stock", DataGridViewOperation)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Try
            delete("DELETE FROM operation_stock WHERE id_op= '" & Idoptxt.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnProduit_Click(sender As Object, e As EventArgs) Handles BtnProduit.Click
        Form1.ShowDialog()
    End Sub

    Private Sub BtnSaveOperation_Click(sender As Object, e As EventArgs) Handles BtnSaveOperation.Click
        If idtxt.Text = "" Then
            MessageBox.Show("Selection un sous produit")
        ElseIf CbLibelleOp.Text = "" Then
            CbLibelleOp.Focus()
        Else
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "update sous_categories set qte_stock = '" & Resultat.Text & "' where libelle = '" & Cbchiken.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            Try
                create("insert into operation_stock(id_op, sous_categorie, date_op, libelle_op, operation, qte_stock) values ('" & Idoptxt.Text & "','" & Cbchiken.Text & "','" & Dateoperationtxt.Text & "','" & CbLibelleOp.Text & "', '" & Operation.Text & "', '" & Resultat.Text & "')")
                Cbchiken.Text = ""
                Dateoperationtxt.Clear()
                idtxt.Clear()
                codeoptxt.Text = ""
                CbLibelleOp.Text = ""
                Operation.Clear()
                QteStock.Clear()
                Resultat.Clear()
                Cbchiken.Items.Clear()
                CbLibelleOp.Items.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        getproductanimals()
        getproductanimalsducks()
        getdata()
        GetTypeOperation()
        Dateoperationtxt.Text = today
    End Sub

    Private Sub BtnEdie_Click(sender As Object, e As EventArgs) Handles BtnEdie.Click
        Try
            updates("UPDATE operation_stock SET id_op='" & Idoptxt.Text & "', sous_categorie='" & Cbchiken.Text & "', date_op='" & Dateoperationtxt.Text & "', libelle_op='" & CbLibelleOp.Text & "', operation='" & Operation.Text & "', qte_stock='" & Resultat.Text & "' WHERE id_op='" & Idoptxt.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Cbchiken.Items.Clear()
        Dateoperationtxt.Clear()
        idtxt.Clear()
        codeoptxt.Clear()
        CbLibelleOp.Items.Clear()
        Operation.Clear()
        QteStock.Clear()
        Resultat.Clear()

        getproductanimals()
        getproductanimalsducks()
        Dateoperationtxt.Text = today
    End Sub



    Private Sub QteStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QteStock.KeyPress
        If Not theNumbers.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Operation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Operation.KeyPress
        If Not theNumbers.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Resultat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Resultat.KeyPress
        If Not theNumbers.Contains(e.KeyChar) And Not Asc(e.KeyChar) = 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Operation_TextChanged(sender As Object, e As EventArgs) Handles Operation.TextChanged
        If CbLibelleOp.Text = "Achat" Then
            Resultat.Text = Val(Operation.Text) + Val(QteStock.Text)
        ElseIf CbLibelleOp.Text = "Dons" Or CbLibelleOp.Text = "Mortalité" Then
            Resultat.Text = Val(QteStock.Text) - Val(Operation.Text)
        End If
    End Sub

    Private Sub DataGridViewOperation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOperation.CellClick
        Idoptxt.Text = DataGridViewOperation.CurrentRow.Cells(0).Value
        Cbchiken.Text = DataGridViewOperation.CurrentRow.Cells(1).Value
        Dateoperationtxt.Text = DataGridViewOperation.CurrentRow.Cells(2).Value
        CbLibelleOp.Text = DataGridViewOperation.CurrentRow.Cells(3).Value
        Operation.Text = DataGridViewOperation.CurrentRow.Cells(4).Value
        Resultat.Text = DataGridViewOperation.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        dt = New DataTable
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = " SELECT id_op, sous_categorie, date_op, libelle_op, operation, qte_stock FROM operation_stock  WHERE libelle_op LIKE '%" & Search.Text & "%'"
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridViewOperation.DataSource = dt
        cn.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridViewOperation.Width, Me.DataGridViewOperation.Height)
        DataGridViewOperation.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridViewOperation.Width, Me.DataGridViewOperation.Height))
        e.Graphics.DrawImage(imagebmp, 150, 100)
    End Sub
End Class