<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_User
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
        Me.GroupBoxUser = New System.Windows.Forms.GroupBox()
        Me.id_user = New System.Windows.Forms.TextBox()
        Me.btnsaveuser = New System.Windows.Forms.Button()
        Me.btndeletetextbox = New System.Windows.Forms.Button()
        Me.statustxt = New System.Windows.Forms.ComboBox()
        Me.status = New System.Windows.Forms.Label()
        Me.pseudo = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.Label()
        Me.pseudotxt = New System.Windows.Forms.TextBox()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.phonetxt = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewUser = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btndeleteuser = New System.Windows.Forms.Button()
        Me.btnupdateuser = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxUser.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(0, -3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(996, 58)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBoxUser
        '
        Me.GroupBoxUser.Controls.Add(Me.id_user)
        Me.GroupBoxUser.Controls.Add(Me.btnsaveuser)
        Me.GroupBoxUser.Controls.Add(Me.btndeletetextbox)
        Me.GroupBoxUser.Controls.Add(Me.statustxt)
        Me.GroupBoxUser.Controls.Add(Me.status)
        Me.GroupBoxUser.Controls.Add(Me.pseudo)
        Me.GroupBoxUser.Controls.Add(Me.firstname)
        Me.GroupBoxUser.Controls.Add(Me.pseudotxt)
        Me.GroupBoxUser.Controls.Add(Me.passwordtxt)
        Me.GroupBoxUser.Controls.Add(Me.phonetxt)
        Me.GroupBoxUser.Controls.Add(Me.password)
        Me.GroupBoxUser.Controls.Add(Me.phone)
        Me.GroupBoxUser.Location = New System.Drawing.Point(24, 70)
        Me.GroupBoxUser.Name = "GroupBoxUser"
        Me.GroupBoxUser.Size = New System.Drawing.Size(332, 383)
        Me.GroupBoxUser.TabIndex = 4
        Me.GroupBoxUser.TabStop = False
        '
        'id_user
        '
        Me.id_user.Location = New System.Drawing.Point(24, 35)
        Me.id_user.Name = "id_user"
        Me.id_user.Size = New System.Drawing.Size(77, 20)
        Me.id_user.TabIndex = 21
        Me.id_user.Visible = False
        '
        'btnsaveuser
        '
        Me.btnsaveuser.BackColor = System.Drawing.Color.DarkGreen
        Me.btnsaveuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsaveuser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsaveuser.Location = New System.Drawing.Point(193, 344)
        Me.btnsaveuser.Name = "btnsaveuser"
        Me.btnsaveuser.Size = New System.Drawing.Size(115, 32)
        Me.btnsaveuser.TabIndex = 20
        Me.btnsaveuser.Text = "CREATION"
        Me.btnsaveuser.UseVisualStyleBackColor = False
        '
        'btndeletetextbox
        '
        Me.btndeletetextbox.BackColor = System.Drawing.Color.DarkGreen
        Me.btndeletetextbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletetextbox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletetextbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndeletetextbox.Location = New System.Drawing.Point(21, 344)
        Me.btndeletetextbox.Name = "btndeletetextbox"
        Me.btndeletetextbox.Size = New System.Drawing.Size(115, 32)
        Me.btndeletetextbox.TabIndex = 19
        Me.btndeletetextbox.Text = "ANNULATION"
        Me.btndeletetextbox.UseVisualStyleBackColor = False
        '
        'statustxt
        '
        Me.statustxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statustxt.FormattingEnabled = True
        Me.statustxt.Items.AddRange(New Object() {"Administrateur", "Gérant", "Invité"})
        Me.statustxt.Location = New System.Drawing.Point(21, 217)
        Me.statustxt.Name = "statustxt"
        Me.statustxt.Size = New System.Drawing.Size(287, 21)
        Me.statustxt.TabIndex = 13
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(21, 191)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(30, 13)
        Me.status.TabIndex = 12
        Me.status.Text = "Profil"
        '
        'pseudo
        '
        Me.pseudo.AutoSize = True
        Me.pseudo.Location = New System.Drawing.Point(18, 63)
        Me.pseudo.Name = "pseudo"
        Me.pseudo.Size = New System.Drawing.Size(84, 13)
        Me.pseudo.TabIndex = 11
        Me.pseudo.Text = "Nom d'utilisateur"
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.Location = New System.Drawing.Point(18, 87)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(0, 13)
        Me.firstname.TabIndex = 1
        '
        'pseudotxt
        '
        Me.pseudotxt.Location = New System.Drawing.Point(21, 87)
        Me.pseudotxt.Name = "pseudotxt"
        Me.pseudotxt.Size = New System.Drawing.Size(287, 20)
        Me.pseudotxt.TabIndex = 10
        '
        'passwordtxt
        '
        Me.passwordtxt.Location = New System.Drawing.Point(21, 151)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(287, 20)
        Me.passwordtxt.TabIndex = 9
        '
        'phonetxt
        '
        Me.phonetxt.Location = New System.Drawing.Point(21, 280)
        Me.phonetxt.Name = "phonetxt"
        Me.phonetxt.Size = New System.Drawing.Size(287, 20)
        Me.phonetxt.TabIndex = 8
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(18, 125)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(71, 13)
        Me.password.TabIndex = 4
        Me.password.Text = "Mot de passe"
        '
        'phone
        '
        Me.phone.AutoSize = True
        Me.phone.Location = New System.Drawing.Point(18, 258)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(58, 13)
        Me.phone.TabIndex = 3
        Me.phone.Text = "Telephone"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewUser)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(416, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 284)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTES DES UTILISATEURS "
        '
        'DataGridViewUser
        '
        Me.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewUser.Location = New System.Drawing.Point(3, 19)
        Me.DataGridViewUser.Name = "DataGridViewUser"
        Me.DataGridViewUser.Size = New System.Drawing.Size(562, 262)
        Me.DataGridViewUser.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 30
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "pseudo"
        Me.Column2.HeaderText = "Non de l'utilisateur"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 180
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "password"
        Me.Column3.HeaderText = "Mot de passe"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "status"
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "phone"
        Me.Column5.HeaderText = "Contact"
        Me.Column5.Name = "Column5"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(834, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 32)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "ACTUALISATION"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btndeleteuser
        '
        Me.btndeleteuser.BackColor = System.Drawing.Color.DarkGreen
        Me.btndeleteuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeleteuser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndeleteuser.Location = New System.Drawing.Point(637, 414)
        Me.btndeleteuser.Name = "btndeleteuser"
        Me.btndeleteuser.Size = New System.Drawing.Size(121, 32)
        Me.btndeleteuser.TabIndex = 23
        Me.btndeleteuser.Text = "SUPPRESSION"
        Me.btndeleteuser.UseVisualStyleBackColor = False
        '
        'btnupdateuser
        '
        Me.btnupdateuser.BackColor = System.Drawing.Color.DarkGreen
        Me.btnupdateuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdateuser.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdateuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnupdateuser.Location = New System.Drawing.Point(422, 414)
        Me.btnupdateuser.Name = "btnupdateuser"
        Me.btnupdateuser.Size = New System.Drawing.Size(121, 32)
        Me.btnupdateuser.TabIndex = 22
        Me.btnupdateuser.Text = "MODIFICATION"
        Me.btnupdateuser.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSearch.Location = New System.Drawing.Point(552, 81)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(94, 27)
        Me.BtnSearch.TabIndex = 31
        Me.BtnSearch.Text = "RECHERCHE"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(671, 84)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(292, 20)
        Me.Search.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(395, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "GESTION DES UTILISATEURS"
        '
        'F_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 465)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btndeleteuser)
        Me.Controls.Add(Me.btnupdateuser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxUser)
        Me.Controls.Add(Me.Button1)
        Me.Name = "F_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.GroupBoxUser.ResumeLayout(False)
        Me.GroupBoxUser.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBoxUser As GroupBox
    Friend WithEvents id_user As TextBox
    Friend WithEvents btnsaveuser As Button
    Friend WithEvents btndeletetextbox As Button
    Friend WithEvents statustxt As ComboBox
    Friend WithEvents status As Label
    Friend WithEvents pseudo As Label
    Friend WithEvents firstname As Label
    Friend WithEvents pseudotxt As TextBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents phonetxt As TextBox
    Friend WithEvents password As Label
    Friend WithEvents phone As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewUser As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents btndeleteuser As Button
    Friend WithEvents btnupdateuser As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
