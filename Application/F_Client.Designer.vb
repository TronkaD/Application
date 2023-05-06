<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Client))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewCoustomer = New System.Windows.Forms.DataGridView()
        Me.btnsprinteclt = New System.Windows.Forms.Button()
        Me.btndeleteclt = New System.Windows.Forms.Button()
        Me.btnudpdateclt = New System.Windows.Forms.Button()
        Me.btnreloadclt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.countryclttxt = New System.Windows.Forms.ComboBox()
        Me.typeclttxt = New System.Windows.Forms.ComboBox()
        Me.btndeletetextbox = New System.Windows.Forms.Button()
        Me.btnsavecustomer = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datetxt = New System.Windows.Forms.TextBox()
        Me.whatsappclttxt = New System.Windows.Forms.TextBox()
        Me.phone2clttxt = New System.Windows.Forms.TextBox()
        Me.phone1clttxt = New System.Windows.Forms.TextBox()
        Me.emailclttxt = New System.Windows.Forms.TextBox()
        Me.addresseclttxt = New System.Windows.Forms.TextBox()
        Me.nameclttxt = New System.Windows.Forms.TextBox()
        Me.codeclttxt = New System.Windows.Forms.TextBox()
        Me.idclt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewCoustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.Search)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnsprinteclt)
        Me.Panel1.Controls.Add(Me.btndeleteclt)
        Me.Panel1.Controls.Add(Me.btnudpdateclt)
        Me.Panel1.Controls.Add(Me.btnreloadclt)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-4, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 750)
        Me.Panel1.TabIndex = 0
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSearch.Location = New System.Drawing.Point(564, 437)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(94, 27)
        Me.BtnSearch.TabIndex = 41
        Me.BtnSearch.Text = "RECHERCHE"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(675, 441)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(292, 20)
        Me.Search.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridViewCoustomer)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(35, 470)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(938, 269)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTE DES CLIENTS"
        '
        'DataGridViewCoustomer
        '
        Me.DataGridViewCoustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCoustomer.Location = New System.Drawing.Point(6, 26)
        Me.DataGridViewCoustomer.Name = "DataGridViewCoustomer"
        Me.DataGridViewCoustomer.Size = New System.Drawing.Size(926, 237)
        Me.DataGridViewCoustomer.TabIndex = 0
        '
        'btnsprinteclt
        '
        Me.btnsprinteclt.BackColor = System.Drawing.Color.DarkGreen
        Me.btnsprinteclt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsprinteclt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsprinteclt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsprinteclt.Location = New System.Drawing.Point(845, 366)
        Me.btnsprinteclt.Name = "btnsprinteclt"
        Me.btnsprinteclt.Size = New System.Drawing.Size(128, 32)
        Me.btnsprinteclt.TabIndex = 38
        Me.btnsprinteclt.Text = "IMPRESSION"
        Me.btnsprinteclt.UseVisualStyleBackColor = False
        '
        'btndeleteclt
        '
        Me.btndeleteclt.BackColor = System.Drawing.Color.DarkGreen
        Me.btndeleteclt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeleteclt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteclt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndeleteclt.Location = New System.Drawing.Point(845, 287)
        Me.btndeleteclt.Name = "btndeleteclt"
        Me.btndeleteclt.Size = New System.Drawing.Size(128, 32)
        Me.btndeleteclt.TabIndex = 37
        Me.btndeleteclt.Text = "SUPPRESSION"
        Me.btndeleteclt.UseVisualStyleBackColor = False
        '
        'btnudpdateclt
        '
        Me.btnudpdateclt.BackColor = System.Drawing.Color.DarkGreen
        Me.btnudpdateclt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnudpdateclt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnudpdateclt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnudpdateclt.Location = New System.Drawing.Point(845, 212)
        Me.btnudpdateclt.Name = "btnudpdateclt"
        Me.btnudpdateclt.Size = New System.Drawing.Size(128, 32)
        Me.btnudpdateclt.TabIndex = 36
        Me.btnudpdateclt.Text = "MODIFICATION"
        Me.btnudpdateclt.UseVisualStyleBackColor = False
        '
        'btnreloadclt
        '
        Me.btnreloadclt.BackColor = System.Drawing.Color.DarkGreen
        Me.btnreloadclt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreloadclt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreloadclt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnreloadclt.Location = New System.Drawing.Point(845, 135)
        Me.btnreloadclt.Name = "btnreloadclt"
        Me.btnreloadclt.Size = New System.Drawing.Size(128, 32)
        Me.btnreloadclt.TabIndex = 35
        Me.btnreloadclt.Text = "ACTUALISATION"
        Me.btnreloadclt.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.countryclttxt)
        Me.GroupBox1.Controls.Add(Me.typeclttxt)
        Me.GroupBox1.Controls.Add(Me.btndeletetextbox)
        Me.GroupBox1.Controls.Add(Me.btnsavecustomer)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.datetxt)
        Me.GroupBox1.Controls.Add(Me.whatsappclttxt)
        Me.GroupBox1.Controls.Add(Me.phone2clttxt)
        Me.GroupBox1.Controls.Add(Me.phone1clttxt)
        Me.GroupBox1.Controls.Add(Me.emailclttxt)
        Me.GroupBox1.Controls.Add(Me.addresseclttxt)
        Me.GroupBox1.Controls.Add(Me.nameclttxt)
        Me.GroupBox1.Controls.Add(Me.codeclttxt)
        Me.GroupBox1.Controls.Add(Me.idclt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 295)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'countryclttxt
        '
        Me.countryclttxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.countryclttxt.FormattingEnabled = True
        Me.countryclttxt.Items.AddRange(New Object() {"Aného", "Atakpamé", "Badou ", "Bafilo ", "Bassar ", "Biankouri", "Dapaong ", "Galangachi ", "Kandé ", "Kara", "Kpagouda ", "Kpalimé ", "Lomé ", "Mango", "Niamtougou ", "Notsé ", "Sokodé", "Sotouboua ", "Tabligbo ", "Tchamba ", "Tsévié", "Vogan "})
        Me.countryclttxt.Location = New System.Drawing.Point(19, 138)
        Me.countryclttxt.Name = "countryclttxt"
        Me.countryclttxt.Size = New System.Drawing.Size(175, 21)
        Me.countryclttxt.TabIndex = 53
        '
        'typeclttxt
        '
        Me.typeclttxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typeclttxt.FormattingEnabled = True
        Me.typeclttxt.Items.AddRange(New Object() {"CI : Vente au comptant", "PE : Permanent", "CR : Vente à crédit", "CO : Contact"})
        Me.typeclttxt.Location = New System.Drawing.Point(240, 75)
        Me.typeclttxt.Name = "typeclttxt"
        Me.typeclttxt.Size = New System.Drawing.Size(194, 21)
        Me.typeclttxt.TabIndex = 52
        '
        'btndeletetextbox
        '
        Me.btndeletetextbox.BackColor = System.Drawing.Color.DarkGreen
        Me.btndeletetextbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletetextbox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletetextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndeletetextbox.Location = New System.Drawing.Point(19, 247)
        Me.btndeletetextbox.Name = "btndeletetextbox"
        Me.btndeletetextbox.Size = New System.Drawing.Size(130, 32)
        Me.btndeletetextbox.TabIndex = 51
        Me.btndeletetextbox.Text = "ANNULATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btndeletetextbox.UseVisualStyleBackColor = False
        '
        'btnsavecustomer
        '
        Me.btnsavecustomer.BackColor = System.Drawing.Color.DarkGreen
        Me.btnsavecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsavecustomer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavecustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsavecustomer.Location = New System.Drawing.Point(621, 247)
        Me.btnsavecustomer.Name = "btnsavecustomer"
        Me.btnsavecustomer.Size = New System.Drawing.Size(131, 32)
        Me.btnsavecustomer.TabIndex = 50
        Me.btnsavecustomer.Text = "CREATION"
        Me.btnsavecustomer.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label13.Location = New System.Drawing.Point(545, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 14)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "DATE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label12.Location = New System.Drawing.Point(493, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 14)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Whatsapp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label11.Location = New System.Drawing.Point(237, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 14)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Contact 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label10.Location = New System.Drawing.Point(16, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 14)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Contact 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(493, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 14)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(237, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 14)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Adresse"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(16, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 14)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Ville"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(493, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 14)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Nom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(237, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 14)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Type"
        '
        'datetxt
        '
        Me.datetxt.Location = New System.Drawing.Point(596, 12)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(156, 20)
        Me.datetxt.TabIndex = 40
        '
        'whatsappclttxt
        '
        Me.whatsappclttxt.Location = New System.Drawing.Point(496, 203)
        Me.whatsappclttxt.Name = "whatsappclttxt"
        Me.whatsappclttxt.Size = New System.Drawing.Size(256, 20)
        Me.whatsappclttxt.TabIndex = 39
        '
        'phone2clttxt
        '
        Me.phone2clttxt.Location = New System.Drawing.Point(240, 203)
        Me.phone2clttxt.Name = "phone2clttxt"
        Me.phone2clttxt.Size = New System.Drawing.Size(199, 20)
        Me.phone2clttxt.TabIndex = 38
        '
        'phone1clttxt
        '
        Me.phone1clttxt.Location = New System.Drawing.Point(19, 203)
        Me.phone1clttxt.Name = "phone1clttxt"
        Me.phone1clttxt.Size = New System.Drawing.Size(175, 20)
        Me.phone1clttxt.TabIndex = 37
        '
        'emailclttxt
        '
        Me.emailclttxt.Location = New System.Drawing.Point(496, 141)
        Me.emailclttxt.Name = "emailclttxt"
        Me.emailclttxt.Size = New System.Drawing.Size(256, 20)
        Me.emailclttxt.TabIndex = 36
        '
        'addresseclttxt
        '
        Me.addresseclttxt.Location = New System.Drawing.Point(240, 141)
        Me.addresseclttxt.Name = "addresseclttxt"
        Me.addresseclttxt.Size = New System.Drawing.Size(199, 20)
        Me.addresseclttxt.TabIndex = 35
        '
        'nameclttxt
        '
        Me.nameclttxt.Location = New System.Drawing.Point(496, 75)
        Me.nameclttxt.Name = "nameclttxt"
        Me.nameclttxt.Size = New System.Drawing.Size(256, 20)
        Me.nameclttxt.TabIndex = 33
        '
        'codeclttxt
        '
        Me.codeclttxt.Location = New System.Drawing.Point(19, 75)
        Me.codeclttxt.Name = "codeclttxt"
        Me.codeclttxt.Size = New System.Drawing.Size(175, 20)
        Me.codeclttxt.TabIndex = 31
        '
        'idclt
        '
        Me.idclt.Location = New System.Drawing.Point(19, 9)
        Me.idclt.Name = "idclt"
        Me.idclt.Size = New System.Drawing.Size(55, 20)
        Me.idclt.TabIndex = 28
        Me.idclt.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(16, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 14)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(410, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "GESTION DES  CLIENTS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1011, 58)
        Me.Button1.TabIndex = 4
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
        'F_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_Client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewCoustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewCoustomer As DataGridView
    Friend WithEvents btnsprinteclt As Button
    Friend WithEvents btndeleteclt As Button
    Friend WithEvents btnudpdateclt As Button
    Friend WithEvents btnreloadclt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents countryclttxt As ComboBox
    Friend WithEvents typeclttxt As ComboBox
    Friend WithEvents btndeletetextbox As Button
    Friend WithEvents btnsavecustomer As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents datetxt As TextBox
    Friend WithEvents whatsappclttxt As TextBox
    Friend WithEvents phone2clttxt As TextBox
    Friend WithEvents phone1clttxt As TextBox
    Friend WithEvents emailclttxt As TextBox
    Friend WithEvents addresseclttxt As TextBox
    Friend WithEvents nameclttxt As TextBox
    Friend WithEvents codeclttxt As TextBox
    Friend WithEvents idclt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Search As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
