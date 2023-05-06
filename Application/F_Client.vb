Public Class F_Client

    Private Sub F_Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        managercodeclient(codeclttxt)
        datetxt.Text = today
    End Sub
    Private Sub DataGridViewCoustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCoustomer.CellContentClick
        idclt.Text = DataGridViewCoustomer.CurrentRow.Cells(0).Value
        datetxt.Text = DataGridViewCoustomer.CurrentRow.Cells(1).Value
        codeclttxt.Text = DataGridViewCoustomer.CurrentRow.Cells(2).Value
        typeclttxt.Text = DataGridViewCoustomer.CurrentRow.Cells(3).Value
        nameclttxt.Text = DataGridViewCoustomer.CurrentRow.Cells(4).Value
        countryclttxt.Text = DataGridViewCoustomer.CurrentRow.Cells(5).Value
        addresseclttxt.Text = DataGridViewCoustomer.CurrentRow.Cells(6).Value
        emailclttxt.Text = DataGridViewCoustomer.CurrentRow.Cells(7).Value
        phone1clttxt.Text = DataGridViewCoustomer.CurrentRow.Cells(8).Value
        phone2clttxt.Text = DataGridViewCoustomer.CurrentRow.Cells(9).Value
        whatsappclttxt.Text = DataGridViewCoustomer.CurrentRow.Cells(10).Value
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btndeletetextbox_Click(sender As Object, e As EventArgs) Handles btndeletetextbox.Click
        codeclttxt.Clear()
        typeclttxt.Items.Clear()
        nameclttxt.Clear()
        countryclttxt.Items.Clear()
        addresseclttxt.Clear()
        emailclttxt.Clear()
        phone1clttxt.Clear()
        phone2clttxt.Clear()
        whatsappclttxt.Clear()
        datetxt.Text = today
        managercodeclient(codeclttxt)
    End Sub

    Private Sub btnsavecustomer_Click(sender As Object, e As EventArgs) Handles btnsavecustomer.Click
        If nameclttxt.Text = "" Then
            nameclttxt.Focus()
        ElseIf countryclttxt.Text = "" Then
            countryclttxt.Focus()
        ElseIf addresseclttxt.Text = "" Then
            addresseclttxt.Focus()
        ElseIf emailclttxt.Text = "" Then
            emailclttxt.Focus()
        ElseIf phone1clttxt.Text = "" Then
            phone1clttxt.Focus()
        Else

            Try
                create("insert into clients(date,code,type,nom,ville,addresse,email,contact1,contact2,whatsapp) values('" & datetxt.Text & "','" & codeclttxt.Text & "','" & typeclttxt.Text & "','" & nameclttxt.Text & "','" & countryclttxt.Text & "','" & addresseclttxt.Text & "','" & emailclttxt.Text & "','" & phone1clttxt.Text & "','" & phone2clttxt.Text & "','" & whatsappclttxt.Text & "') ")
                codeclttxt.Clear()
                typeclttxt.Items.Clear()
                nameclttxt.Clear()
                countryclttxt.Items.Clear()
                addresseclttxt.Clear()
                emailclttxt.Clear()
                phone1clttxt.Clear()
                phone2clttxt.Clear()
                whatsappclttxt.Clear()
                nameclttxt.Focus()
                datetxt.Text = today
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        managercodeclient(codeclttxt)
    End Sub

    Private Sub btnreloadclt_Click(sender As Object, e As EventArgs) Handles btnreloadclt.Click
        Try
            reload("select*from clients", DataGridViewCoustomer)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnudpdateclt_Click(sender As Object, e As EventArgs) Handles btnudpdateclt.Click
        Try
            updates("UPDATE clients SET id='" & idclt.Text & "', date='" & datetxt.Text & "', code='" & codeclttxt.Text & "', type='" & typeclttxt.Text & "', nom='" & nameclttxt.Text & "', ville='" & countryclttxt.Text & "', addresse='" & addresseclttxt.Text & "', email='" & emailclttxt.Text & "', contact1='" & phone1clttxt.Text & "', contact2='" & phone2clttxt.Text & "', whatsapp='" & whatsappclttxt.Text & "' WHERE id='" & idclt.Text & "'")

            codeclttxt.Clear()
            typeclttxt.Items.Clear()
            nameclttxt.Clear()
            countryclttxt.Items.Clear()
            addresseclttxt.Clear()
            emailclttxt.Clear()
            phone1clttxt.Clear()
            phone2clttxt.Clear()
            whatsappclttxt.Clear()
            nameclttxt.Focus()
            datetxt.Text = today
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndeleteclt_Click(sender As Object, e As EventArgs) Handles btndeleteclt.Click
        Try
            delete("DELETE FROM clients WHERE id= '" & idclt.Text & "' ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        dt = New DataTable
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = " SELECT id, date, code, type, nom, ville, addresse, email, contact1, contact2, whatsapp FROM clients WHERE nom LIKE '%" & Search.Text & "%'"
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridViewCoustomer.DataSource = dt
        cn.Close()

        cmd.CommandText = " SELECT nameclttxt FROM  clients WHERE  nameclttxt LIKE '%" & Search.Text & "%'"
    End Sub

    Private Sub btnsprinteclt_Click(sender As Object, e As EventArgs) Handles btnsprinteclt.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.DataGridViewCoustomer.Width, Me.DataGridViewCoustomer.Height)
        DataGridViewCoustomer.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.DataGridViewCoustomer.Width, Me.DataGridViewCoustomer.Height))
        e.Graphics.DrawImage(imagebmp, 150, 100)
    End Sub


End Class