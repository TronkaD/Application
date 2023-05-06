Imports MySql.Data.MySqlClient
Public Class Fiche

    ' for PrintDialog, PrintPreviewDialog and PrintDocument:
    Private prnDialog As System.Windows.Forms.PrintDialog
    Private prnPreview As System.Windows.Forms.PrintPreviewDialog
    Private prnDocument As System.Drawing.Printing.PrintDocument

    ' for Invoice Head:
    Private InvTitle As String
    Private InvSubTitle1 As String
    Private InvSubTitle2 As String
    Private InvSubTitle3 As String
    Private InvImage As String

    ' for Report:
    Private CurrentY As Integer
    Private CurrentX As Integer
    Private leftMargin As Integer
    Private rightMargin As Integer
    Private topMargin As Integer
    Private bottomMargin As Integer
    Private InvoiceWidth As Integer
    Private InvoiceHeight As Integer
    Private CustomerName As String
    Private CustomerCity As String
    Private SellerName As String
    Private SaleID As String
    Private SaleDate As String
    Private SaleFreight As Decimal
    Private SubTotal As Decimal
    Private InvoiceTotal As Decimal
    Private ReadInvoice As Boolean
    Private AmountPosition As Integer

    ' Font and Color:------------------
    ' Title Font
    Private InvTitleFont As Font = New Font("Arial", 24, FontStyle.Regular)
    ' Title Font height
    Private InvTitleHeight As Integer
    ' SubTitle Font
    Private InvSubTitleFont As Font = New Font("Arial", 14, FontStyle.Regular)
    ' SubTitle Font height
    Private InvSubTitleHeight As Integer
    ' Invoice Font
    Private InvoiceFont As Font = New Font("Arial", 12, FontStyle.Regular)
    ' Invoice Font height
    Private InvoiceFontHeight As Integer
    ' Blue Color
    Private BlueBrush As SolidBrush = New SolidBrush(Color.Blue)
    ' Red Color
    Private RedBrush As SolidBrush = New SolidBrush(Color.Red)
    ' Black Color
    Private BlackBrush As SolidBrush = New SolidBrush(Color.Black)

    Private Sub Fiche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Get Invoice Data:
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = ("SELECT * FROM ventes")
            da.SelectCommand = cmd
            DataGridViewFiche.DataSource = dt
            da.Fill(dt)

            ' Create a TableStyle to format Datagrid columns.
            Dim tableStyle As DataGridTableStyle = New DataGridTableStyle

            For Each dc As DataColumn In dt.Columns
                Dim txtColumn As DataGridTextBoxColumn = New DataGridTextBoxColumn
                txtColumn.MappingName = dc.ColumnName
                txtColumn.HeaderText = dc.Caption
                Select Case (dc.ColumnName.ToString())
                    Case "code"
                        txtColumn.HeaderText = "code"
                        txtColumn.Width = 60
                    Case "designation"
                        txtColumn.HeaderText = "vendeur"
                        txtColumn.Width = 110
                    Case "prix_unitaire"
                        txtColumn.HeaderText = "prix_unitaire"
                        txtColumn.Format = "0.00"
                        txtColumn.Alignment = HorizontalAlignment.Right
                        txtColumn.Width = 60
                    Case "montant"
                        txtColumn.HeaderText = "montant"
                        txtColumn.Format = "0.00"
                        txtColumn.Alignment = HorizontalAlignment.Right
                        txtColumn.Width = 60
                    Case "qte_command"
                        txtColumn.HeaderText = "qte_command"
                        txtColumn.Alignment = HorizontalAlignment.Right
                        txtColumn.Width = 50
                        'Case "ExtendedPrice" ' Extended Price 
                        'txtColumn.HeaderText = "Extended Price"
                        'txtColumn.Format = "0.00"
                        'txtColumn.Alignment = HorizontalAlignment.Right
                        'txtColumn.Width = 90
                End Select
                tableStyle.GridColumnStyles.Add(txtColumn)
            Next

            tableStyle.MappingName = dt.TableName
            'DataGridViewFiche.TableStyles.Add(tableStyle)
            ' set DataSource of DataGrid 
            DataGridViewFiche.DataSource = dt.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub SetInvoiceHead(ByVal g As Graphics)
        ReadInvoiceHead()

        CurrentY = topMargin
        CurrentX = leftMargin
        Dim ImageHeight As Integer = 0

        ' Draw Invoice image:
        If (System.IO.File.Exists(InvImage)) Then
            Dim oInvImage As Bitmap = New Bitmap(InvImage)
            ' Set Image Left to center Image:
            Dim xImage As Integer = CurrentX + (InvoiceWidth - oInvImage.Width) / 2
            ImageHeight = oInvImage.Height ' Get Image Height
            g.DrawImage(oInvImage, xImage, CurrentY)
        End If

        InvTitleHeight = Convert.ToInt32(InvTitleFont.GetHeight(g))
        InvSubTitleHeight = Convert.ToInt32(InvSubTitleFont.GetHeight(g))
        ' Get Titles Length:
        Dim lenInvTitle As Integer = Convert.ToInt32(g.MeasureString(InvTitle, InvTitleFont).Width)
        Dim lenInvSubTitle1 As Integer = Convert.ToInt32(g.MeasureString(InvSubTitle1, InvSubTitleFont).Width)
        Dim lenInvSubTitle2 As Integer = Convert.ToInt32(g.MeasureString(InvSubTitle2, InvSubTitleFont).Width)
        Dim lenInvSubTitle3 As Integer = Convert.ToInt32(g.MeasureString(InvSubTitle3, InvSubTitleFont).Width)
        ' Set Titles Left:
        Dim xInvTitle As Integer = CurrentX + (InvoiceWidth - lenInvTitle) / 2
        Dim xInvSubTitle1 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2
        Dim xInvSubTitle2 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2
        Dim xInvSubTitle3 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2

        ' Draw Invoice Head:
        If (InvTitle <> "") Then
            CurrentY = CurrentY + ImageHeight
            g.DrawString(InvTitle, InvTitleFont, BlueBrush, xInvTitle, CurrentY)
        End If
        If (InvSubTitle1 <> "") Then
            CurrentY = CurrentY + InvTitleHeight
            g.DrawString(InvSubTitle1, InvSubTitleFont, BlueBrush, xInvSubTitle1, CurrentY)
        End If
        If (InvSubTitle2 <> "") Then
            CurrentY = CurrentY + InvSubTitleHeight
            g.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2, CurrentY)
        End If
        If (InvSubTitle3 <> "") Then
            CurrentY = CurrentY + InvSubTitleHeight
            g.DrawString(InvSubTitle3, InvSubTitleFont, BlueBrush, xInvSubTitle3, CurrentY)
        End If

        ' Draw line:
        CurrentY = CurrentY + InvSubTitleHeight + 8
        g.DrawLine(New Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin, CurrentY)
    End Sub
    Private Sub ReadInvoiceHead()
        'Titles and Image of invoice:
        InvTitle = "Ferme Mivamivo"
        InvSubTitle1 = "Hahotoé Chidémé"
        InvSubTitle2 = "TOGO-Lomé"
        InvSubTitle3 = "Phone 90010304"
        'InvImage = Application.StartupPath & "\Images\" + "InvPic.jpg"
    End Sub
    Private Sub PrintReport()
        Try
            prnDocument.Print()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub DisplayDialog()
        Try
            prnDialog.Document = Me.prnDocument
            Dim ButtonPressed As DialogResult = prnDialog.ShowDialog()
            ' If user Click 'OK', Print Invoice
            If (ButtonPressed = DialogResult.OK) Then
                prnDocument.Print()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub DisplayInvoice()
        prnPreview.Document = Me.prnDocument
        Try
            prnPreview.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        leftMargin = Convert.ToInt32(e.MarginBounds.Left)
        rightMargin = Convert.ToInt32(e.MarginBounds.Right)
        topMargin = Convert.ToInt32(e.MarginBounds.Top)
        bottomMargin = Convert.ToInt32(e.MarginBounds.Bottom)
        InvoiceWidth = Convert.ToInt32(e.MarginBounds.Width)
        InvoiceHeight = Convert.ToInt32(e.MarginBounds.Height)

        SetInvoiceHead(e.Graphics) ' Draw Invoice Head
        ReadInvoice = True
    End Sub
    Private Sub BtnImprimer_Click(sender As Object, e As EventArgs) Handles BtnImprimer.Click
        PrintReport()
    End Sub
End Class