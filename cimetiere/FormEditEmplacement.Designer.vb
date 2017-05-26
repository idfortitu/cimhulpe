<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditEmplacement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TbReference = New cimetiere.TextBoxNullable()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbNbPlaces = New cimetiere.TextBoxIntNullable()
        Me.TbCommentaire = New cimetiere.TextBoxNullable()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbMonumentClasse = New System.Windows.Forms.CheckBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbReference
        '
        Me.TbReference.CueBanner = Nothing
        Me.TbReference.Location = New System.Drawing.Point(98, 6)
        Me.TbReference.Name = "TbReference"
        Me.TbReference.Size = New System.Drawing.Size(74, 22)
        Me.TbReference.TabIndex = 0
        Me.TbReference.Value = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Référence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Places"
        '
        'TbNbPlaces
        '
        Me.TbNbPlaces.CueBanner = Nothing
        Me.TbNbPlaces.Location = New System.Drawing.Point(98, 34)
        Me.TbNbPlaces.Name = "TbNbPlaces"
        Me.TbNbPlaces.Size = New System.Drawing.Size(74, 22)
        Me.TbNbPlaces.TabIndex = 3
        Me.TbNbPlaces.Value = Nothing
        '
        'TbCommentaire
        '
        Me.TbCommentaire.CueBanner = Nothing
        Me.TbCommentaire.Location = New System.Drawing.Point(15, 79)
        Me.TbCommentaire.Multiline = True
        Me.TbCommentaire.Name = "TbCommentaire"
        Me.TbCommentaire.Size = New System.Drawing.Size(220, 76)
        Me.TbCommentaire.TabIndex = 4
        Me.TbCommentaire.Value = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Commentaire"
        '
        'CbMonumentClasse
        '
        Me.CbMonumentClasse.AutoSize = True
        Me.CbMonumentClasse.Location = New System.Drawing.Point(15, 171)
        Me.CbMonumentClasse.Name = "CbMonumentClasse"
        Me.CbMonumentClasse.Size = New System.Drawing.Size(140, 21)
        Me.CbMonumentClasse.TabIndex = 7
        Me.CbMonumentClasse.Text = "Monument classé"
        Me.CbMonumentClasse.UseVisualStyleBackColor = True
        '
        'BtAnnuler
        '
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.Location = New System.Drawing.Point(46, 208)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(81, 31)
        Me.BtAnnuler.TabIndex = 8
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.Location = New System.Drawing.Point(167, 208)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(102, 31)
        Me.BtEnregistrer.TabIndex = 9
        Me.BtEnregistrer.Text = "Enregistrer"
        Me.BtEnregistrer.UseVisualStyleBackColor = True
        '
        'FormEditEmplacement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(318, 264)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.CbMonumentClasse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbCommentaire)
        Me.Controls.Add(Me.TbNbPlaces)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbReference)
        Me.Name = "FormEditEmplacement"
        Me.Text = "FormEditEmplacement"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbReference As TextBoxNullable
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbNbPlaces As TextBoxIntNullable
    Friend WithEvents TbCommentaire As TextBoxNullable
    Friend WithEvents Label3 As Label
    Friend WithEvents CbMonumentClasse As CheckBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BtAnnuler As Button
    Friend WithEvents BtEnregistrer As Button
End Class
