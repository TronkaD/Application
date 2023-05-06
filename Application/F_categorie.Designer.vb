<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_categorie
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_categorie))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnImpression = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.btnreload = New System.Windows.Forms.Button()
        Me.btnEditCategry = New System.Windows.Forms.Button()
        Me.btnDeleteCategory = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewCategorie = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btndeletecal = New System.Windows.Forms.Button()
        Me.idcattxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.codetxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.categorietxt = New System.Windows.Forms.TextBox()
        Me.btnNewCategory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnImpression)
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.Search)
        Me.Panel1.Controls.Add(Me.btnreload)
        Me.Panel1.Controls.Add(Me.btnEditCategry)
        Me.Panel1.Controls.Add(Me.btnDeleteCategory)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1012, 504)
        Me.Panel1.TabIndex = 0
        '
        'BtnImpression
        '
        Me.BtnImpression.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnImpression.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImpression.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImpression.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnImpression.Location = New System.Drawing.Point(371, 363)
        Me.BtnImpression.Name = "BtnImpression"
        Me.BtnImpression.Size = New System.Drawing.Size(130, 32)
        Me.BtnImpression.TabIndex = 35
        Me.BtnImpression.Text = "IMPRESSION"
        Me.BtnImpression.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSearch.Location = New System.Drawing.Point(551, 131)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(94, 27)
        Me.BtnSearch.TabIndex = 34
        Me.BtnSearch.Text = "RECHERCHE"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(672, 138)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(292, 20)
        Me.Search.TabIndex = 33
        '
        'btnreload
        '
        Me.btnreload.BackColor = System.Drawing.Color.DarkGreen
        Me.btnreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreload.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreload.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnreload.Location = New System.Drawing.Point(371, 195)
        Me.btnreload.Name = "btnreload"
        Me.btnreload.Size = New System.Drawing.Size(130, 32)
        Me.btnreload.TabIndex = 25
        Me.btnreload.Text = "ACTUALISATION"
        Me.btnreload.UseVisualStyleBackColor = False
        '
        'btnEditCategry
        '
        Me.btnEditCategry.BackColor = System.Drawing.Color.DarkGreen
        Me.btnEditCategry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCategry.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCategry.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditCategry.Location = New System.Drawing.Point(371, 257)
        Me.btnEditCategry.Name = "btnEditCategry"
        Me.btnEditCategry.Size = New System.Drawing.Size(130, 32)
        Me.btnEditCategry.TabIndex = 23
        Me.btnEditCategry.Text = "MODIFICATION"
        Me.btnEditCategry.UseVisualStyleBackColor = False
        '
        'btnDeleteCategory
        '
        Me.btnDeleteCategory.BackColor = System.Drawing.Color.DarkGreen
        Me.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCategory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteCategory.Location = New System.Drawing.Point(371, 301)
        Me.btnDeleteCategory.Name = "btnDeleteCategory"
        Me.btnDeleteCategory.Size = New System.Drawing.Size(130, 32)
        Me.btnDeleteCategory.TabIndex = 24
        Me.btnDeleteCategory.Text = "SUPPRESSION"
        Me.btnDeleteCategory.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridViewCategorie)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(534, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 247)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTE DES CATEGORIES"
        '
        'DataGridViewCategorie
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCategorie.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCategorie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Code, Me.Column2})
        Me.DataGridViewCategorie.Location = New System.Drawing.Point(6, 26)
        Me.DataGridViewCategorie.Name = "DataGridViewCategorie"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCategorie.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewCategorie.Size = New System.Drawing.Size(418, 208)
        Me.DataGridViewCategorie.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_cat"
        Me.Column1.HeaderText = "N°"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 30
        '
        'Code
        '
        Me.Code.DataPropertyName = "code_cat"
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.Width = 160
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "libelle_cat"
        Me.Column2.HeaderText = "Libelle"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 210
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btndeletecal)
        Me.GroupBox1.Controls.Add(Me.idcattxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.codetxt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.categorietxt)
        Me.GroupBox1.Controls.Add(Me.btnNewCategory)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 303)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'btndeletecal
        '
        Me.btndeletecal.BackColor = System.Drawing.Color.DarkGreen
        Me.btndeletecal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeletecal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeletecal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndeletecal.Location = New System.Drawing.Point(18, 240)
        Me.btndeletecal.Name = "btndeletecal"
        Me.btndeletecal.Size = New System.Drawing.Size(114, 32)
        Me.btndeletecal.TabIndex = 21
        Me.btndeletecal.Text = "ANNULATION"
        Me.btndeletecal.UseVisualStyleBackColor = False
        '
        'idcattxt
        '
        Me.idcattxt.Location = New System.Drawing.Point(18, 15)
        Me.idcattxt.Name = "idcattxt"
        Me.idcattxt.Size = New System.Drawing.Size(51, 26)
        Me.idcattxt.TabIndex = 19
        Me.idcattxt.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(19, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Code "
        '
        'codetxt
        '
        Me.codetxt.Location = New System.Drawing.Point(18, 78)
        Me.codetxt.Name = "codetxt"
        Me.codetxt.Size = New System.Drawing.Size(281, 26)
        Me.codetxt.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(19, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Libelle"
        '
        'categorietxt
        '
        Me.categorietxt.Location = New System.Drawing.Point(18, 163)
        Me.categorietxt.Name = "categorietxt"
        Me.categorietxt.Size = New System.Drawing.Size(281, 26)
        Me.categorietxt.TabIndex = 11
        '
        'btnNewCategory
        '
        Me.btnNewCategory.BackColor = System.Drawing.Color.DarkGreen
        Me.btnNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewCategory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNewCategory.Location = New System.Drawing.Point(182, 240)
        Me.btnNewCategory.Name = "btnNewCategory"
        Me.btnNewCategory.Size = New System.Drawing.Size(117, 32)
        Me.btnNewCategory.TabIndex = 13
        Me.btnNewCategory.Text = "CREATION"
        Me.btnNewCategory.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(399, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "GESTION DES CATEGORIES"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(-10, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1022, 58)
        Me.Button1.TabIndex = 2
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
        'F_categorie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_categorie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorie"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnreload As Button
    Friend WithEvents btnEditCategry As Button
    Friend WithEvents btnDeleteCategory As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewCategorie As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndeletecal As Button
    Friend WithEvents idcattxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents codetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents categorietxt As TextBox
    Friend WithEvents btnNewCategory As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Search As TextBox
    Friend WithEvents BtnImpression As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
