<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Vente
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnNewClt = New System.Windows.Forms.Button()
        Me.ButEdit = New System.Windows.Forms.Button()
        Me.btndeleteproduct = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewVente = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdvtTxt = New System.Windows.Forms.TextBox()
        Me.TxtNNF = New System.Windows.Forms.TextBox()
        Me.TxtNQ = New System.Windows.Forms.TextBox()
        Me.TxtCodeP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNUMF = New System.Windows.Forms.TextBox()
        Me.Resultat = New System.Windows.Forms.TextBox()
        Me.CbVendeur = New System.Windows.Forms.ComboBox()
        Me.CbTypeReglement = New System.Windows.Forms.TextBox()
        Me.CbCategorie = New System.Windows.Forms.ComboBox()
        Me.CbSousCategorie = New System.Windows.Forms.ComboBox()
        Me.CbClient = New System.Windows.Forms.ComboBox()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrixTotal = New System.Windows.Forms.TextBox()
        Me.PrixUnitaire = New System.Windows.Forms.TextBox()
        Me.QteCommand = New System.Windows.Forms.TextBox()
        Me.DateVenteTxt = New System.Windows.Forms.TextBox()
        Me.QteStockDispo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnActualser = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewVente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(-4, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1380, 58)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(601, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "GESTION DES VENTES"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnActualser)
        Me.Panel1.Controls.Add(Me.BtnNewClt)
        Me.Panel1.Controls.Add(Me.ButEdit)
        Me.Panel1.Controls.Add(Me.btndeleteproduct)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(-4, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1380, 699)
        Me.Panel1.TabIndex = 32
        '
        'BtnNewClt
        '
        Me.BtnNewClt.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnNewClt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewClt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewClt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNewClt.Location = New System.Drawing.Point(1152, 63)
        Me.BtnNewClt.Name = "BtnNewClt"
        Me.BtnNewClt.Size = New System.Drawing.Size(164, 32)
        Me.BtnNewClt.TabIndex = 51
        Me.BtnNewClt.Text = "Créer le client"
        Me.BtnNewClt.UseVisualStyleBackColor = False
        '
        'ButEdit
        '
        Me.ButEdit.BackColor = System.Drawing.Color.DarkGreen
        Me.ButEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButEdit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButEdit.Location = New System.Drawing.Point(1152, 123)
        Me.ButEdit.Name = "ButEdit"
        Me.ButEdit.Size = New System.Drawing.Size(164, 32)
        Me.ButEdit.TabIndex = 52
        Me.ButEdit.Text = "MODIFICATION"
        Me.ButEdit.UseVisualStyleBackColor = False
        '
        'btndeleteproduct
        '
        Me.btndeleteproduct.BackColor = System.Drawing.Color.DarkGreen
        Me.btndeleteproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeleteproduct.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndeleteproduct.Location = New System.Drawing.Point(1152, 188)
        Me.btndeleteproduct.Name = "btndeleteproduct"
        Me.btndeleteproduct.Size = New System.Drawing.Size(164, 32)
        Me.btndeleteproduct.TabIndex = 50
        Me.btndeleteproduct.Text = "SUPPRESSION"
        Me.btndeleteproduct.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridViewVente)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 415)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1308, 259)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'DataGridViewVente
        '
        Me.DataGridViewVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridViewVente.Location = New System.Drawing.Point(22, 33)
        Me.DataGridViewVente.Name = "DataGridViewVente"
        Me.DataGridViewVente.Size = New System.Drawing.Size(1261, 120)
        Me.DataGridViewVente.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_vt"
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 30
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "vendeur"
        Me.Column2.HeaderText = "Vendeur"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "date_vt"
        Me.Column3.HeaderText = "Date "
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "nom_clt"
        Me.Column4.HeaderText = "Nom du client"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "type_reglem"
        Me.Column5.HeaderText = "Type de règlement"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 180
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "categorie"
        Me.Column6.HeaderText = "Catégorie du produit"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "designation"
        Me.Column7.HeaderText = "Libelle du produit"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 200
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "qte_command"
        Me.Column8.HeaderText = "Quantité"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 80
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "prix_unitaire"
        Me.Column9.HeaderText = "Prix unitaire"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 80
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "montant"
        Me.Column10.HeaderText = "Montant"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdvtTxt)
        Me.GroupBox1.Controls.Add(Me.TxtNNF)
        Me.GroupBox1.Controls.Add(Me.TxtNQ)
        Me.GroupBox1.Controls.Add(Me.TxtCodeP)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtNUMF)
        Me.GroupBox1.Controls.Add(Me.Resultat)
        Me.GroupBox1.Controls.Add(Me.CbVendeur)
        Me.GroupBox1.Controls.Add(Me.CbTypeReglement)
        Me.GroupBox1.Controls.Add(Me.CbCategorie)
        Me.GroupBox1.Controls.Add(Me.CbSousCategorie)
        Me.GroupBox1.Controls.Add(Me.CbClient)
        Me.GroupBox1.Controls.Add(Me.BtnCreate)
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PrixTotal)
        Me.GroupBox1.Controls.Add(Me.PrixUnitaire)
        Me.GroupBox1.Controls.Add(Me.QteCommand)
        Me.GroupBox1.Controls.Add(Me.DateVenteTxt)
        Me.GroupBox1.Controls.Add(Me.QteStockDispo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNF)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1096, 316)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'IdvtTxt
        '
        Me.IdvtTxt.Location = New System.Drawing.Point(965, 16)
        Me.IdvtTxt.Name = "IdvtTxt"
        Me.IdvtTxt.Size = New System.Drawing.Size(70, 20)
        Me.IdvtTxt.TabIndex = 64
        '
        'TxtNNF
        '
        Me.TxtNNF.Location = New System.Drawing.Point(880, 16)
        Me.TxtNNF.Name = "TxtNNF"
        Me.TxtNNF.Size = New System.Drawing.Size(73, 20)
        Me.TxtNNF.TabIndex = 63
        '
        'TxtNQ
        '
        Me.TxtNQ.Location = New System.Drawing.Point(705, 16)
        Me.TxtNQ.Name = "TxtNQ"
        Me.TxtNQ.Size = New System.Drawing.Size(70, 20)
        Me.TxtNQ.TabIndex = 62
        '
        'TxtCodeP
        '
        Me.TxtCodeP.Location = New System.Drawing.Point(622, 16)
        Me.TxtCodeP.Name = "TxtCodeP"
        Me.TxtCodeP.Size = New System.Drawing.Size(66, 20)
        Me.TxtCodeP.TabIndex = 61
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label13.Location = New System.Drawing.Point(56, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 14)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "N° Fiche"
        '
        'TxtNUMF
        '
        Me.TxtNUMF.Location = New System.Drawing.Point(791, 16)
        Me.TxtNUMF.Name = "TxtNUMF"
        Me.TxtNUMF.Size = New System.Drawing.Size(74, 20)
        Me.TxtNUMF.TabIndex = 59
        '
        'Resultat
        '
        Me.Resultat.Enabled = False
        Me.Resultat.Location = New System.Drawing.Point(622, 252)
        Me.Resultat.Name = "Resultat"
        Me.Resultat.Size = New System.Drawing.Size(92, 20)
        Me.Resultat.TabIndex = 58
        '
        'CbVendeur
        '
        Me.CbVendeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbVendeur.FormattingEnabled = True
        Me.CbVendeur.Items.AddRange(New Object() {"Thomas", "Eric", "Eddie", "GRAND", "Autres"})
        Me.CbVendeur.Location = New System.Drawing.Point(121, 51)
        Me.CbVendeur.Name = "CbVendeur"
        Me.CbVendeur.Size = New System.Drawing.Size(343, 21)
        Me.CbVendeur.TabIndex = 56
        '
        'CbTypeReglement
        '
        Me.CbTypeReglement.Enabled = False
        Me.CbTypeReglement.Location = New System.Drawing.Point(59, 161)
        Me.CbTypeReglement.Name = "CbTypeReglement"
        Me.CbTypeReglement.Size = New System.Drawing.Size(405, 20)
        Me.CbTypeReglement.TabIndex = 55
        '
        'CbCategorie
        '
        Me.CbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCategorie.FormattingEnabled = True
        Me.CbCategorie.Location = New System.Drawing.Point(59, 216)
        Me.CbCategorie.Name = "CbCategorie"
        Me.CbCategorie.Size = New System.Drawing.Size(405, 21)
        Me.CbCategorie.TabIndex = 53
        '
        'CbSousCategorie
        '
        Me.CbSousCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSousCategorie.FormattingEnabled = True
        Me.CbSousCategorie.Location = New System.Drawing.Point(622, 104)
        Me.CbSousCategorie.Name = "CbSousCategorie"
        Me.CbSousCategorie.Size = New System.Drawing.Size(413, 21)
        Me.CbSousCategorie.TabIndex = 51
        '
        'CbClient
        '
        Me.CbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbClient.FormattingEnabled = True
        Me.CbClient.Location = New System.Drawing.Point(59, 104)
        Me.CbClient.Name = "CbClient"
        Me.CbClient.Size = New System.Drawing.Size(405, 21)
        Me.CbClient.TabIndex = 50
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnCreate.Enabled = False
        Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCreate.Location = New System.Drawing.Point(860, 274)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(120, 32)
        Me.BtnCreate.TabIndex = 48
        Me.BtnCreate.Text = "AJOUTER"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDelete.Location = New System.Drawing.Point(101, 274)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(129, 32)
        Me.BtnDelete.TabIndex = 47
        Me.BtnDelete.Text = "ANNULER"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label11.Location = New System.Drawing.Point(912, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 14)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Prix Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label10.Location = New System.Drawing.Point(619, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 14)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Prix Unitaire"
        '
        'PrixTotal
        '
        Me.PrixTotal.Enabled = False
        Me.PrixTotal.Location = New System.Drawing.Point(915, 217)
        Me.PrixTotal.Name = "PrixTotal"
        Me.PrixTotal.Size = New System.Drawing.Size(123, 20)
        Me.PrixTotal.TabIndex = 43
        '
        'PrixUnitaire
        '
        Me.PrixUnitaire.Location = New System.Drawing.Point(622, 217)
        Me.PrixUnitaire.Name = "PrixUnitaire"
        Me.PrixUnitaire.Size = New System.Drawing.Size(123, 20)
        Me.PrixUnitaire.TabIndex = 42
        '
        'QteCommand
        '
        Me.QteCommand.Location = New System.Drawing.Point(915, 161)
        Me.QteCommand.Name = "QteCommand"
        Me.QteCommand.Size = New System.Drawing.Size(120, 20)
        Me.QteCommand.TabIndex = 41
        '
        'DateVenteTxt
        '
        Me.DateVenteTxt.Enabled = False
        Me.DateVenteTxt.Location = New System.Drawing.Point(656, 48)
        Me.DateVenteTxt.Name = "DateVenteTxt"
        Me.DateVenteTxt.Size = New System.Drawing.Size(379, 20)
        Me.DateVenteTxt.TabIndex = 40
        '
        'QteStockDispo
        '
        Me.QteStockDispo.Enabled = False
        Me.QteStockDispo.Location = New System.Drawing.Point(622, 158)
        Me.QteStockDispo.Name = "QteStockDispo"
        Me.QteStockDispo.Size = New System.Drawing.Size(123, 20)
        Me.QteStockDispo.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(56, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Nom Du Client"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(56, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 14)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Catégorie"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(56, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 14)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Type de Règlement"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(619, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 14)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Quantité en Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(912, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 14)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Quantité commandé"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(619, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 14)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Désignation du produit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(619, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 14)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Date"
        '
        'TxtNF
        '
        Me.TxtNF.Location = New System.Drawing.Point(122, 19)
        Me.TxtNF.Name = "TxtNF"
        Me.TxtNF.Size = New System.Drawing.Size(98, 20)
        Me.TxtNF.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(56, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 14)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Vendeur"
        '
        'BtnActualser
        '
        Me.BtnActualser.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnActualser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnActualser.Location = New System.Drawing.Point(1152, 244)
        Me.BtnActualser.Name = "BtnActualser"
        Me.BtnActualser.Size = New System.Drawing.Size(164, 32)
        Me.BtnActualser.TabIndex = 54
        Me.BtnActualser.Text = "ACTUALISATION"
        Me.BtnActualser.UseVisualStyleBackColor = False
        '
        'F_Vente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "F_Vente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vente"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewVente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCodeP As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtNUMF As TextBox
    Friend WithEvents Resultat As TextBox
    Friend WithEvents CbVendeur As ComboBox
    Friend WithEvents CbTypeReglement As TextBox
    Friend WithEvents CbCategorie As ComboBox
    Friend WithEvents CbSousCategorie As ComboBox
    Friend WithEvents CbClient As ComboBox
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PrixTotal As TextBox
    Friend WithEvents PrixUnitaire As TextBox
    Friend WithEvents QteCommand As TextBox
    Friend WithEvents DateVenteTxt As TextBox
    Friend WithEvents QteStockDispo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewVente As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents BtnNewClt As Button
    Friend WithEvents ButEdit As Button
    Friend WithEvents btndeleteproduct As Button
    Friend WithEvents TxtNQ As TextBox
    Friend WithEvents TxtNNF As TextBox
    Friend WithEvents IdvtTxt As TextBox
    Friend WithEvents BtnActualser As Button
End Class
