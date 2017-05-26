<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditConcession
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditConcession))
        Me.MtbDateDebut = New cimetiere.MaskedTextBoxDate()
        Me.MtbDateFin = New cimetiere.MaskedTextBoxDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbfMontantPaye = New cimetiere.TextBoxFloatNullable()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbHistoire = New cimetiere.TextBoxNullable()
        Me.TbCommentaire = New cimetiere.TextBoxNullable()
        Me.TbiRenouvellements = New cimetiere.TextBoxIntNullable()
        Me.BtTerminer = New System.Windows.Forms.Button()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MtbDateDebut
        '
        Me.MtbDateDebut.DateValue = Nothing
        Me.MtbDateDebut.IntArrayValue = CType(resources.GetObject("MtbDateDebut.IntArrayValue"), System.Collections.Generic.List(Of System.Nullable(Of Integer)))
        Me.MtbDateDebut.Location = New System.Drawing.Point(93, 6)
        Me.MtbDateDebut.Mask = "00/00/0000"
        Me.MtbDateDebut.Name = "MtbDateDebut"
        Me.MtbDateDebut.Size = New System.Drawing.Size(115, 22)
        Me.MtbDateDebut.TabIndex = 0
        Me.MtbDateDebut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MtbDateFin
        '
        Me.MtbDateFin.DateValue = Nothing
        Me.MtbDateFin.IntArrayValue = CType(resources.GetObject("MtbDateFin.IntArrayValue"), System.Collections.Generic.List(Of System.Nullable(Of Integer)))
        Me.MtbDateFin.Location = New System.Drawing.Point(93, 37)
        Me.MtbDateFin.Mask = "00/00/0000"
        Me.MtbDateFin.Name = "MtbDateFin"
        Me.MtbDateFin.Size = New System.Drawing.Size(115, 22)
        Me.MtbDateFin.TabIndex = 1
        Me.MtbDateFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Valable du"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "au"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Renouvellements :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Montant payé :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Commentaire"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Histoire"
        '
        'TbfMontantPaye
        '
        Me.TbfMontantPaye.CueBanner = Nothing
        Me.TbfMontantPaye.Location = New System.Drawing.Point(120, 67)
        Me.TbfMontantPaye.Name = "TbfMontantPaye"
        Me.TbfMontantPaye.Size = New System.Drawing.Size(88, 22)
        Me.TbfMontantPaye.TabIndex = 8
        Me.TbfMontantPaye.Value = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "€"
        '
        'TbHistoire
        '
        Me.TbHistoire.CueBanner = Nothing
        Me.TbHistoire.Location = New System.Drawing.Point(15, 149)
        Me.TbHistoire.Name = "TbHistoire"
        Me.TbHistoire.Size = New System.Drawing.Size(194, 22)
        Me.TbHistoire.TabIndex = 10
        Me.TbHistoire.Value = Nothing
        '
        'TbCommentaire
        '
        Me.TbCommentaire.CueBanner = Nothing
        Me.TbCommentaire.Location = New System.Drawing.Point(14, 199)
        Me.TbCommentaire.Multiline = True
        Me.TbCommentaire.Name = "TbCommentaire"
        Me.TbCommentaire.Size = New System.Drawing.Size(194, 79)
        Me.TbCommentaire.TabIndex = 11
        Me.TbCommentaire.Value = Nothing
        '
        'TbiRenouvellements
        '
        Me.TbiRenouvellements.CueBanner = Nothing
        Me.TbiRenouvellements.Location = New System.Drawing.Point(144, 100)
        Me.TbiRenouvellements.Name = "TbiRenouvellements"
        Me.TbiRenouvellements.Size = New System.Drawing.Size(64, 22)
        Me.TbiRenouvellements.TabIndex = 12
        Me.TbiRenouvellements.Value = Nothing
        '
        'BtTerminer
        '
        Me.BtTerminer.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtTerminer.Location = New System.Drawing.Point(120, 297)
        Me.BtTerminer.Name = "BtTerminer"
        Me.BtTerminer.Size = New System.Drawing.Size(97, 38)
        Me.BtTerminer.TabIndex = 31
        Me.BtTerminer.Text = "Enregistrer"
        Me.BtTerminer.UseVisualStyleBackColor = True
        '
        'BtAnnuler
        '
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.Location = New System.Drawing.Point(8, 301)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(91, 34)
        Me.BtAnnuler.TabIndex = 30
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'FormEditConcession
        '
        Me.AcceptButton = Me.BtTerminer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(641, 468)
        Me.Controls.Add(Me.BtTerminer)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.TbiRenouvellements)
        Me.Controls.Add(Me.TbCommentaire)
        Me.Controls.Add(Me.TbHistoire)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TbfMontantPaye)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MtbDateFin)
        Me.Controls.Add(Me.MtbDateDebut)
        Me.Name = "FormEditConcession"
        Me.Text = "FormEditConcession"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MtbDateDebut As MaskedTextBoxDate
    Friend WithEvents MtbDateFin As MaskedTextBoxDate
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbfMontantPaye As TextBoxFloatNullable
    Friend WithEvents Label7 As Label
    Friend WithEvents TbHistoire As TextBoxNullable
    Friend WithEvents TbCommentaire As TextBoxNullable
    Friend WithEvents TbiRenouvellements As TextBoxIntNullable
    Friend WithEvents BtTerminer As Button
    Friend WithEvents BtAnnuler As Button
End Class
