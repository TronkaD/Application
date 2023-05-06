<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewProduit = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnImpression = New System.Windows.Forms.Button()
        Me.btnupdateprod = New System.Windows.Forms.Button()
        Me.btndeleteprod = New System.Windows.Forms.Button()
        Me.btnreloadprod = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Qte = New System.Windows.Forms.TextBox()
        Me.btnsaveproduct = New System.Windows.Forms.Button()
        Me.btndeletetextbox = New System.Windows.Forms.Button()
        Me.categorieprodtxt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.codeprodtxt = New System.Windows.Forms.TextBox()
        Me.libelleprodtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idprodtxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.Search)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.BtnImpression)
        Me.Panel1.Controls.Add(Me.btnupdateprod)
        Me.Panel1.Controls.Add(Me.btndeleteprod)
        Me.Panel1.Controls.Add(Me.btnreloadprod)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 502)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(410, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 23)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "GESTION DES SOUS CATEGORIES"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSearch.Location = New System.Drawing.Point(605, 130)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(94, 27)
        Me.BtnSearch.TabIndex = 32
        Me.BtnSearch.Text = "RECHERCHE"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(726, 137)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(292, 20)
        Me.Search.TabIndex = 31
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridViewProduit)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(491, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 269)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTES DES SOUS CATEGORIES"
        '
        'DataGridViewProduit
        '
        Me.DataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProduit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column})
        Me.DataGridViewProduit.Location = New System.Drawing.Point(6, 33)
        Me.DataGridViewProduit.Name = "DataGridViewProduit"
        Me.DataGridViewProduit.Size = New System.Drawing.Size(521, 230)
        Me.DataGridViewProduit.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_prod"
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "categorie"
        Me.Column2.HeaderText = "Categorie"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "code"
        Me.Column3.HeaderText = "Code"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "libelle"
        Me.Column4.HeaderText = "Libelle"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 130
        '
        'Column
        '
        Me.Column.DataPropertyName = "qte_stock"
        Me.Column.HeaderText = "Quantité"
        Me.Column.Name = "Column"
        '
        'BtnImpression
        '
        Me.BtnImpression.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnImpression.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImpression.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImpression.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnImpression.Location = New System.Drawing.Point(338, 399)
        Me.BtnImpression.Name = "BtnImpression"
        Me.BtnImpression.Size = New System.Drawing.Size(130, 32)
        Me.BtnImpression.TabIndex = 27
        Me.BtnImpression.Text = "IMPRESSION"
        Me.BtnImpression.UseVisualStyleBackColor = False
        '
        'btnupdateprod
        '
        Me.btnupdateprod.BackColor = System.Drawing.Color.DarkGreen
        Me.btnupdateprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdateprod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdateprod.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnupdateprod.Location = New System.Drawing.Point(338, 268)
        Me.btnupdateprod.Name = "btnupdateprod"
        Me.btnupdateprod.Size = New System.Drawing.Size(130, 32)
        Me.btnupdateprod.TabIndex = 26
        Me.btnupdateprod.Text = "MODIFICATION"
        Me.btnupdateprod.UseVisualStyleBackColor = False
        '
        'btndeleteprod
        '
        Me.btndeleteprod.BackColor = System.Drawing.Color.DarkGreen
        Me.btndeleteprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeleteprod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteprod.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndeleteprod.Location = New System.Drawing.Point(338, 321)
        Me.btndeleteprod.Name = "btndeleteprod"
        Me.btndeleteprod.Size = New System.Drawing.Size(130, 32)
        Me.btndeleteprod.TabIndex = 25
        Me.btndeleteprod.Text = "SUPPRESSION"
        Me.btndeleteprod.UseVisualStyleBackColor = False
        '
        'btnreloadprod
        '
        Me.btnreloadprod.BackColor = System.Drawing.Color.DarkGreen
        Me.btnreloadprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreloadprod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreloadprod.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnreloadprod.Location = New System.Drawing.Point(338, 193)
        Me.btnreloadprod.Name = "btnreloadprod"
        Me.btnreloadprod.Size = New System.Drawing.Size(130, 32)
        Me.btnreloadprod.TabIndex = 24
        Me.btnreloadprod.Text = "ACTUALISATION"
        Me.btnreloadprod.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Qte)
        Me.GroupBox1.Controls.Add(Me.btnsaveproduct)
        Me.GroupBox1.Controls.Add(Me.btndeletetextbox)
        Me.GroupBox1.Controls.Add(Me.categorieprodtxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.codeprodtxt)
        Me.GroupBox1.Controls.Add(Me.libelleprodtxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.idprodtxt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 350)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(15, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 14)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Quantité en stock"
        '
        'Qte
        '
        Me.Qte.Location = New System.Drawing.Point(115, 234)
        Me.Qte.Name = "Qte"
        Me.Qte.Size = New System.Drawing.Size(175, 20)
        Me.Qte.TabIndex = 22
        '
        'btnsaveproduct
        '
        Me.btnsaveproduct.BackColor = System.Drawing.Color.DarkGreen
        Me.btnsaveproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsaveproduct.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsaveproduct.Location = New System.Drawing.Point(176, 297)
        Me.btnsaveproduct.Name = "btnsaveproduct"
        Me.btnsaveproduct.Size = New System.Drawing.Size(114, 32)
        Me.btnsaveproduct.TabIndex = 21
        Me.btnsaveproduct.Text = "CREATION"
        Me.btnsaveproduct.UseVisualStyleBackColor = False
        '
        'btndeletetextbox
        '
        Me.btndeletetextbox.BackColor = System.Drawing.Color.DarkGreen
        Me.btndeletetextbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletetextbox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletetextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndeletetextbox.Location = New System.Drawing.Point(18, 297)
        Me.btndeletetextbox.Name = "btndeletetextbox"
        Me.btndeletetextbox.Size = New System.Drawing.Size(114, 32)
        Me.btndeletetextbox.TabIndex = 20
        Me.btndeletetextbox.Text = "ANNULATION"
        Me.btndeletetextbox.UseVisualStyleBackColor = False
        '
        'categorieprodtxt
        '
        Me.categorieprodtxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categorieprodtxt.FormattingEnabled = True
        Me.categorieprodtxt.Location = New System.Drawing.Point(18, 58)
        Me.categorieprodtxt.Name = "categorieprodtxt"
        Me.categorieprodtxt.Size = New System.Drawing.Size(272, 21)
        Me.categorieprodtxt.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(15, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Sous Catégorie"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(15, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 14)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Code"
        '
        'codeprodtxt
        '
        Me.codeprodtxt.Location = New System.Drawing.Point(18, 108)
        Me.codeprodtxt.Name = "codeprodtxt"
        Me.codeprodtxt.Size = New System.Drawing.Size(272, 20)
        Me.codeprodtxt.TabIndex = 14
        '
        'libelleprodtxt
        '
        Me.libelleprodtxt.Location = New System.Drawing.Point(18, 178)
        Me.libelleprodtxt.Name = "libelleprodtxt"
        Me.libelleprodtxt.Size = New System.Drawing.Size(272, 20)
        Me.libelleprodtxt.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(15, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Catégorie"
        '
        'idprodtxt
        '
        Me.idprodtxt.Location = New System.Drawing.Point(18, 18)
        Me.idprodtxt.Name = "idprodtxt"
        Me.idprodtxt.Size = New System.Drawing.Size(45, 20)
        Me.idprodtxt.TabIndex = 11
        Me.idprodtxt.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1064, 58)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sous_Categories"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Search As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewProduit As DataGridView
    Friend WithEvents BtnImpression As Button
    Friend WithEvents btnupdateprod As Button
    Friend WithEvents btndeleteprod As Button
    Friend WithEvents btnreloadprod As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Qte As TextBox
    Friend WithEvents btnsaveproduct As Button
    Friend WithEvents btndeletetextbox As Button
    Friend WithEvents categorieprodtxt As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents codeprodtxt As TextBox
    Friend WithEvents libelleprodtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents idprodtxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column As DataGridViewTextBoxColumn
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
