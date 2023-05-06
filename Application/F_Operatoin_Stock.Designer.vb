<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Operatoin_Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Operatoin_Stock))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Cbcaprins = New System.Windows.Forms.ComboBox()
        Me.Cbchiken = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewOperation = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnEdie = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Idoptxt = New System.Windows.Forms.TextBox()
        Me.CbLibelleOp = New System.Windows.Forms.ComboBox()
        Me.Resultat = New System.Windows.Forms.TextBox()
        Me.btndeletetextbox = New System.Windows.Forms.Button()
        Me.BtnSaveOperation = New System.Windows.Forms.Button()
        Me.QteStock = New System.Windows.Forms.TextBox()
        Me.codeoptxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.Operation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dateoperationtxt = New System.Windows.Forms.TextBox()
        Me.Btnreload = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnupdateprod = New System.Windows.Forms.Button()
        Me.BtnProduit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewOperation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Cbcaprins)
        Me.Panel1.Controls.Add(Me.Cbchiken)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnupdateprod)
        Me.Panel1.Controls.Add(Me.BtnProduit)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1250, 763)
        Me.Panel1.TabIndex = 0
        '
        'Cbcaprins
        '
        Me.Cbcaprins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbcaprins.FormattingEnabled = True
        Me.Cbcaprins.Location = New System.Drawing.Point(54, 271)
        Me.Cbcaprins.Name = "Cbcaprins"
        Me.Cbcaprins.Size = New System.Drawing.Size(168, 21)
        Me.Cbcaprins.TabIndex = 73
        '
        'Cbchiken
        '
        Me.Cbchiken.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbchiken.FormattingEnabled = True
        Me.Cbchiken.Location = New System.Drawing.Point(54, 153)
        Me.Cbchiken.Name = "Cbchiken"
        Me.Cbchiken.Size = New System.Drawing.Size(168, 21)
        Me.Cbchiken.TabIndex = 72
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.BtnSearch)
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.Button18)
        Me.Panel3.Controls.Add(Me.Btndelete)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.BtnEdie)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Btnreload)
        Me.Panel3.Location = New System.Drawing.Point(284, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1086, 812)
        Me.Panel3.TabIndex = 69
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSearch.Location = New System.Drawing.Point(457, 457)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(94, 27)
        Me.BtnSearch.TabIndex = 67
        Me.BtnSearch.Text = "RECHERCHE"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(589, 464)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(292, 20)
        Me.Search.TabIndex = 66
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridViewOperation)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 490)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(865, 255)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTES DES OPERATIONS"
        '
        'DataGridViewOperation
        '
        Me.DataGridViewOperation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOperation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridViewOperation.Location = New System.Drawing.Point(6, 31)
        Me.DataGridViewOperation.Name = "DataGridViewOperation"
        Me.DataGridViewOperation.Size = New System.Drawing.Size(852, 180)
        Me.DataGridViewOperation.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_op"
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 30
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "sous_categorie"
        Me.Column2.HeaderText = "Désignation"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "date_op"
        Me.Column3.HeaderText = "Date de Opération"
        Me.Column3.MinimumWidth = 10
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 180
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "libelle_op"
        Me.Column4.HeaderText = "Operation"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "operation"
        Me.Column5.HeaderText = "Quantité"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "qte_stock"
        Me.Column6.HeaderText = "Quantité en stock"
        Me.Column6.Name = "Column6"
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.DarkGreen
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button18.Location = New System.Drawing.Point(793, 361)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(131, 32)
        Me.Button18.TabIndex = 58
        Me.Button18.Text = "IMPRESSION"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.DarkGreen
        Me.Btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndelete.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btndelete.Location = New System.Drawing.Point(793, 271)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(131, 32)
        Me.Btndelete.TabIndex = 64
        Me.Btndelete.Text = "SUPPRESSION"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(336, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 23)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "OPERATION SUR LE STOCK"
        '
        'BtnEdie
        '
        Me.BtnEdie.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnEdie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdie.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdie.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEdie.Location = New System.Drawing.Point(793, 184)
        Me.BtnEdie.Name = "BtnEdie"
        Me.BtnEdie.Size = New System.Drawing.Size(131, 32)
        Me.BtnEdie.TabIndex = 63
        Me.BtnEdie.Text = "MODIFICATION"
        Me.BtnEdie.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Idoptxt)
        Me.GroupBox1.Controls.Add(Me.CbLibelleOp)
        Me.GroupBox1.Controls.Add(Me.Resultat)
        Me.GroupBox1.Controls.Add(Me.btndeletetextbox)
        Me.GroupBox1.Controls.Add(Me.BtnSaveOperation)
        Me.GroupBox1.Controls.Add(Me.QteStock)
        Me.GroupBox1.Controls.Add(Me.codeoptxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.idtxt)
        Me.GroupBox1.Controls.Add(Me.Operation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Dateoperationtxt)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 320)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(561, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 19)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Code du produit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(561, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 19)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Numéro du produit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(25, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Nombre"
        '
        'Idoptxt
        '
        Me.Idoptxt.Location = New System.Drawing.Point(27, 11)
        Me.Idoptxt.Name = "Idoptxt"
        Me.Idoptxt.Size = New System.Drawing.Size(71, 20)
        Me.Idoptxt.TabIndex = 45
        Me.Idoptxt.Visible = False
        '
        'CbLibelleOp
        '
        Me.CbLibelleOp.FormattingEnabled = True
        Me.CbLibelleOp.Location = New System.Drawing.Point(29, 140)
        Me.CbLibelleOp.Name = "CbLibelleOp"
        Me.CbLibelleOp.Size = New System.Drawing.Size(339, 21)
        Me.CbLibelleOp.TabIndex = 44
        '
        'Resultat
        '
        Me.Resultat.Location = New System.Drawing.Point(295, 219)
        Me.Resultat.Name = "Resultat"
        Me.Resultat.Size = New System.Drawing.Size(73, 20)
        Me.Resultat.TabIndex = 40
        '
        'btndeletetextbox
        '
        Me.btndeletetextbox.BackColor = System.Drawing.Color.DarkGreen
        Me.btndeletetextbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletetextbox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletetextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndeletetextbox.Location = New System.Drawing.Point(64, 269)
        Me.btndeletetextbox.Name = "btndeletetextbox"
        Me.btndeletetextbox.Size = New System.Drawing.Size(122, 32)
        Me.btndeletetextbox.TabIndex = 37
        Me.btndeletetextbox.Text = "ANNULATION"
        Me.btndeletetextbox.UseVisualStyleBackColor = False
        '
        'BtnSaveOperation
        '
        Me.BtnSaveOperation.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSaveOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveOperation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveOperation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSaveOperation.Location = New System.Drawing.Point(536, 269)
        Me.BtnSaveOperation.Name = "BtnSaveOperation"
        Me.BtnSaveOperation.Size = New System.Drawing.Size(122, 32)
        Me.BtnSaveOperation.TabIndex = 38
        Me.BtnSaveOperation.Text = "CREATION"
        Me.BtnSaveOperation.UseVisualStyleBackColor = False
        '
        'QteStock
        '
        Me.QteStock.Location = New System.Drawing.Point(161, 219)
        Me.QteStock.Name = "QteStock"
        Me.QteStock.Size = New System.Drawing.Size(73, 20)
        Me.QteStock.TabIndex = 39
        '
        'codeoptxt
        '
        Me.codeoptxt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeoptxt.ForeColor = System.Drawing.Color.DarkGreen
        Me.codeoptxt.Location = New System.Drawing.Point(565, 56)
        Me.codeoptxt.Name = "codeoptxt"
        Me.codeoptxt.Size = New System.Drawing.Size(139, 26)
        Me.codeoptxt.TabIndex = 35
        Me.codeoptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(25, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Choisissez l'opération à effectuer"
        '
        'idtxt
        '
        Me.idtxt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtxt.ForeColor = System.Drawing.Color.DarkGreen
        Me.idtxt.Location = New System.Drawing.Point(565, 138)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(139, 26)
        Me.idtxt.TabIndex = 21
        Me.idtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Operation
        '
        Me.Operation.Location = New System.Drawing.Point(29, 219)
        Me.Operation.Name = "Operation"
        Me.Operation.Size = New System.Drawing.Size(73, 20)
        Me.Operation.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(25, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Date de l'opération"
        '
        'Dateoperationtxt
        '
        Me.Dateoperationtxt.Location = New System.Drawing.Point(29, 56)
        Me.Dateoperationtxt.Name = "Dateoperationtxt"
        Me.Dateoperationtxt.Size = New System.Drawing.Size(339, 20)
        Me.Dateoperationtxt.TabIndex = 15
        '
        'Btnreload
        '
        Me.Btnreload.BackColor = System.Drawing.Color.DarkGreen
        Me.Btnreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnreload.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnreload.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnreload.Location = New System.Drawing.Point(793, 93)
        Me.Btnreload.Name = "Btnreload"
        Me.Btnreload.Size = New System.Drawing.Size(131, 32)
        Me.Btnreload.TabIndex = 62
        Me.Btnreload.Text = "ACTUALISATION"
        Me.Btnreload.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button3.Location = New System.Drawing.Point(0, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(284, 391)
        Me.Button3.TabIndex = 71
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button2.Location = New System.Drawing.Point(0, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(284, 78)
        Me.Button2.TabIndex = 71
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(0, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(284, 78)
        Me.Button1.TabIndex = 71
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnupdateprod
        '
        Me.btnupdateprod.BackColor = System.Drawing.Color.White
        Me.btnupdateprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdateprod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdateprod.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnupdateprod.Location = New System.Drawing.Point(0, 0)
        Me.btnupdateprod.Name = "btnupdateprod"
        Me.btnupdateprod.Size = New System.Drawing.Size(284, 78)
        Me.btnupdateprod.TabIndex = 70
        Me.btnupdateprod.Text = "Catégories"
        Me.btnupdateprod.UseVisualStyleBackColor = False
        '
        'BtnProduit
        '
        Me.BtnProduit.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProduit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProduit.ForeColor = System.Drawing.Color.White
        Me.BtnProduit.Location = New System.Drawing.Point(0, 316)
        Me.BtnProduit.Name = "BtnProduit"
        Me.BtnProduit.Size = New System.Drawing.Size(284, 58)
        Me.BtnProduit.TabIndex = 68
        Me.BtnProduit.Text = "Gestion sous catégorie"
        Me.BtnProduit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProduit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Location = New System.Drawing.Point(281, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1089, 757)
        Me.Panel2.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkGreen
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(0, 196)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(284, 53)
        Me.Button9.TabIndex = 67
        Me.Button9.Text = "Caprins"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkGreen
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(0, 76)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(284, 49)
        Me.Button8.TabIndex = 66
        Me.Button8.Text = "Volailles"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
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
        'F_Operatoin_Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_Operatoin_Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operatoin_Stock"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewOperation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnupdateprod As Button
    Friend WithEvents BtnProduit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewOperation As DataGridView
    Friend WithEvents Button18 As Button
    Friend WithEvents Btndelete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnEdie As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Idoptxt As TextBox
    Friend WithEvents CbLibelleOp As ComboBox
    Friend WithEvents Resultat As TextBox
    Friend WithEvents btndeletetextbox As Button
    Friend WithEvents BtnSaveOperation As Button
    Friend WithEvents QteStock As TextBox
    Friend WithEvents codeoptxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents idtxt As TextBox
    Friend WithEvents Operation As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Dateoperationtxt As TextBox
    Friend WithEvents Btnreload As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Cbcaprins As ComboBox
    Friend WithEvents Cbchiken As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Search As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
