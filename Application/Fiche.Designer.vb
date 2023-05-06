<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fiche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fiche))
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.DataGridViewFiche = New System.Windows.Forms.DataGridView()
        Me.BtnZoomP = New System.Windows.Forms.Button()
        Me.BtnZoomM = New System.Windows.Forms.Button()
        Me.BtnImprimer = New System.Windows.Forms.Button()
        CType(Me.DataGridViewFiche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'DataGridViewFiche
        '
        Me.DataGridViewFiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFiche.Location = New System.Drawing.Point(288, 279)
        Me.DataGridViewFiche.Name = "DataGridViewFiche"
        Me.DataGridViewFiche.Size = New System.Drawing.Size(263, 118)
        Me.DataGridViewFiche.TabIndex = 2
        '
        'BtnZoomP
        '
        Me.BtnZoomP.Location = New System.Drawing.Point(114, 14)
        Me.BtnZoomP.Name = "BtnZoomP"
        Me.BtnZoomP.Size = New System.Drawing.Size(94, 26)
        Me.BtnZoomP.TabIndex = 4
        Me.BtnZoomP.Text = "Zoom ++"
        Me.BtnZoomP.UseVisualStyleBackColor = True
        '
        'BtnZoomM
        '
        Me.BtnZoomM.Location = New System.Drawing.Point(214, 12)
        Me.BtnZoomM.Name = "BtnZoomM"
        Me.BtnZoomM.Size = New System.Drawing.Size(95, 29)
        Me.BtnZoomM.TabIndex = 5
        Me.BtnZoomM.Text = "Zoom - -"
        Me.BtnZoomM.UseVisualStyleBackColor = True
        '
        'BtnImprimer
        '
        Me.BtnImprimer.Location = New System.Drawing.Point(12, 12)
        Me.BtnImprimer.Name = "BtnImprimer"
        Me.BtnImprimer.Size = New System.Drawing.Size(95, 28)
        Me.BtnImprimer.TabIndex = 3
        Me.BtnImprimer.Text = "Imprimer"
        Me.BtnImprimer.UseVisualStyleBackColor = True
        '
        'Fiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 543)
        Me.Controls.Add(Me.BtnZoomP)
        Me.Controls.Add(Me.BtnZoomM)
        Me.Controls.Add(Me.BtnImprimer)
        Me.Controls.Add(Me.DataGridViewFiche)
        Me.Name = "Fiche"
        Me.Text = "Fiche"
        CType(Me.DataGridViewFiche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents DataGridViewFiche As DataGridView
    Friend WithEvents BtnZoomP As Button
    Friend WithEvents BtnZoomM As Button
    Friend WithEvents BtnImprimer As Button
End Class
