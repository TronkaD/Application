<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Commande
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnActualser = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.DataGridViewCommand = New System.Windows.Forms.DataGridView()
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
        Me.BtnActualiser = New System.Windows.Forms.Button()
        Me.BtnEdite = New System.Windows.Forms.Button()
        Me.btncmd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdcmdTxt = New System.Windows.Forms.TextBox()
        Me.TxtNNF = New System.Windows.Forms.TextBox()
        Me.TxtNQ = New System.Windows.Forms.TextBox()
        Me.TxtCodeP = New System.Windows.Forms.TextBox()
        Me.TxtNUMF = New System.Windows.Forms.TextBox()
        Me.TxtNF = New System.Windows.Forms.TextBox()
        Me.TxtDate = New System.Windows.Forms.DateTimePicker()
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
        Me.QteStockDispo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewCommand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnActualser)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.Search)
        Me.Panel1.Controls.Add(Me.DataGridViewCommand)
        Me.Panel1.Controls.Add(Me.BtnActualiser)
        Me.Panel1.Controls.Add(Me.BtnEdite)
        Me.Panel1.Controls.Add(Me.btncmd)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Location = New System.Drawing.Point(-4, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1379, 839)
        Me.Panel1.TabIndex = 0
        '
        'BtnActualser
        '
        Me.BtnActualser.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnActualser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnActualser.Location = New System.Drawing.Point(1176, 358)
        Me.BtnActualser.Name = "BtnActualser"
        Me.BtnActualser.Size = New System.Drawing.Size(164, 32)
        Me.BtnActualser.TabIndex = 62
        Me.BtnActualser.Text = "ACTUALISATION"
        Me.BtnActualser.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(1176, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 32)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "IMPRESSION"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSearch.Location = New System.Drawing.Point(893, 467)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(94, 27)
        Me.BtnSearch.TabIndex = 60
        Me.BtnSearch.Text = "RECHERCHE"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(1032, 471)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(292, 20)
        Me.Search.TabIndex = 59
        '
        'DataGridViewCommand
        '
        Me.DataGridViewCommand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCommand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridViewCommand.Location = New System.Drawing.Point(33, 516)
        Me.DataGridViewCommand.Name = "DataGridViewCommand"
        Me.DataGridViewCommand.Size = New System.Drawing.Size(1291, 120)
        Me.DataGridViewCommand.TabIndex = 58
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_cmd"
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
        'BtnActualiser
        '
        Me.BtnActualiser.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnActualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualiser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualiser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnActualiser.Location = New System.Drawing.Point(1176, 106)
        Me.BtnActualiser.Name = "BtnActualiser"
        Me.BtnActualiser.Size = New System.Drawing.Size(164, 32)
        Me.BtnActualiser.TabIndex = 55
        Me.BtnActualiser.Text = "Créer le client"
        Me.BtnActualiser.UseVisualStyleBackColor = False
        '
        'BtnEdite
        '
        Me.BtnEdite.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnEdite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdite.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdite.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEdite.Location = New System.Drawing.Point(1176, 171)
        Me.BtnEdite.Name = "BtnEdite"
        Me.BtnEdite.Size = New System.Drawing.Size(164, 32)
        Me.BtnEdite.TabIndex = 56
        Me.BtnEdite.Text = "MODIFICATION"
        Me.BtnEdite.UseVisualStyleBackColor = False
        '
        'btncmd
        '
        Me.btncmd.BackColor = System.Drawing.Color.DarkGreen
        Me.btncmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncmd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncmd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncmd.Location = New System.Drawing.Point(1176, 237)
        Me.btncmd.Name = "btncmd"
        Me.btncmd.Size = New System.Drawing.Size(164, 32)
        Me.btncmd.TabIndex = 54
        Me.btncmd.Text = "SUPPRESSION"
        Me.btncmd.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdcmdTxt)
        Me.GroupBox1.Controls.Add(Me.TxtNNF)
        Me.GroupBox1.Controls.Add(Me.TxtNQ)
        Me.GroupBox1.Controls.Add(Me.TxtCodeP)
        Me.GroupBox1.Controls.Add(Me.TxtNUMF)
        Me.GroupBox1.Controls.Add(Me.TxtNF)
        Me.GroupBox1.Controls.Add(Me.TxtDate)
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
        Me.GroupBox1.Controls.Add(Me.QteStockDispo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1096, 316)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'IdcmdTxt
        '
        Me.IdcmdTxt.Location = New System.Drawing.Point(965, 19)
        Me.IdcmdTxt.Name = "IdcmdTxt"
        Me.IdcmdTxt.Size = New System.Drawing.Size(70, 20)
        Me.IdcmdTxt.TabIndex = 71
        Me.IdcmdTxt.Visible = False
        '
        'TxtNNF
        '
        Me.TxtNNF.Location = New System.Drawing.Point(881, 19)
        Me.TxtNNF.Name = "TxtNNF"
        Me.TxtNNF.Size = New System.Drawing.Size(73, 20)
        Me.TxtNNF.TabIndex = 70
        Me.TxtNNF.Visible = False
        '
        'TxtNQ
        '
        Me.TxtNQ.Location = New System.Drawing.Point(701, 19)
        Me.TxtNQ.Name = "TxtNQ"
        Me.TxtNQ.Size = New System.Drawing.Size(70, 20)
        Me.TxtNQ.TabIndex = 69
        Me.TxtNQ.Visible = False
        '
        'TxtCodeP
        '
        Me.TxtCodeP.Location = New System.Drawing.Point(622, 19)
        Me.TxtCodeP.Name = "TxtCodeP"
        Me.TxtCodeP.Size = New System.Drawing.Size(66, 20)
        Me.TxtCodeP.TabIndex = 68
        Me.TxtCodeP.Visible = False
        '
        'TxtNUMF
        '
        Me.TxtNUMF.Location = New System.Drawing.Point(786, 19)
        Me.TxtNUMF.Name = "TxtNUMF"
        Me.TxtNUMF.Size = New System.Drawing.Size(74, 20)
        Me.TxtNUMF.TabIndex = 67
        Me.TxtNUMF.Visible = False
        '
        'TxtNF
        '
        Me.TxtNF.Location = New System.Drawing.Point(121, 19)
        Me.TxtNF.Name = "TxtNF"
        Me.TxtNF.Size = New System.Drawing.Size(98, 20)
        Me.TxtNF.TabIndex = 65
        Me.TxtNF.Visible = False
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(718, 52)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(317, 20)
        Me.TxtDate.TabIndex = 59
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
        Me.Label3.Size = New System.Drawing.Size(93, 14)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Date de Livraison"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(56, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 14)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Vendeur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(570, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 23)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "GESTION DES COMMANDE "
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Location = New System.Drawing.Point(0, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(1380, 58)
        Me.Button7.TabIndex = 51
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Commande"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commande"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewCommand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents QteStockDispo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnActualiser As Button
    Friend WithEvents BtnEdite As Button
    Friend WithEvents btncmd As Button
    Friend WithEvents DataGridViewCommand As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Search As TextBox
    Friend WithEvents TxtDate As DateTimePicker
    Friend WithEvents IdcmdTxt As TextBox
    Friend WithEvents TxtNNF As TextBox
    Friend WithEvents TxtNQ As TextBox
    Friend WithEvents TxtCodeP As TextBox
    Friend WithEvents TxtNUMF As TextBox
    Friend WithEvents TxtNF As TextBox
    Friend WithEvents BtnActualser As Button
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
End Class
