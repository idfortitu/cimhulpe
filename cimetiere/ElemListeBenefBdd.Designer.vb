<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElemListeBenefBdd
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LabNom = New System.Windows.Forms.Label()
        Me.LabPrenom = New System.Windows.Forms.Label()
        Me.LabDateNaiss = New System.Windows.Forms.Label()
        Me.LabAdresse = New System.Windows.Forms.Label()
        Me.BtRetirerBeneficiaire = New System.Windows.Forms.Button()
        Me.TbLienParente = New cimetiere.TextBoxNullable()
        Me.BtModifier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Location = New System.Drawing.Point(39, 3)
        Me.LabNom.MaximumSize = New System.Drawing.Size(125, 0)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(51, 17)
        Me.LabNom.TabIndex = 0
        Me.LabNom.Text = "Label1"
        '
        'LabPrenom
        '
        Me.LabPrenom.AutoSize = True
        Me.LabPrenom.Location = New System.Drawing.Point(170, 3)
        Me.LabPrenom.MaximumSize = New System.Drawing.Size(135, 0)
        Me.LabPrenom.Name = "LabPrenom"
        Me.LabPrenom.Size = New System.Drawing.Size(51, 17)
        Me.LabPrenom.TabIndex = 17
        Me.LabPrenom.Text = "Label2"
        '
        'LabDateNaiss
        '
        Me.LabDateNaiss.AutoSize = True
        Me.LabDateNaiss.Location = New System.Drawing.Point(311, 3)
        Me.LabDateNaiss.MaximumSize = New System.Drawing.Size(161, 0)
        Me.LabDateNaiss.Name = "LabDateNaiss"
        Me.LabDateNaiss.Size = New System.Drawing.Size(51, 17)
        Me.LabDateNaiss.TabIndex = 18
        Me.LabDateNaiss.Text = "Label3"
        '
        'LabAdresse
        '
        Me.LabAdresse.AutoEllipsis = True
        Me.LabAdresse.AutoSize = True
        Me.LabAdresse.Location = New System.Drawing.Point(478, 3)
        Me.LabAdresse.MaximumSize = New System.Drawing.Size(178, 0)
        Me.LabAdresse.Name = "LabAdresse"
        Me.LabAdresse.Size = New System.Drawing.Size(51, 17)
        Me.LabAdresse.TabIndex = 19
        Me.LabAdresse.Text = "Label4"
        '
        'BtRetirerBeneficiaire
        '
        Me.BtRetirerBeneficiaire.Image = Global.cimetiere.My.Resources.Resources.moins
        Me.BtRetirerBeneficiaire.Location = New System.Drawing.Point(-1, -1)
        Me.BtRetirerBeneficiaire.Margin = New System.Windows.Forms.Padding(4)
        Me.BtRetirerBeneficiaire.Name = "BtRetirerBeneficiaire"
        Me.BtRetirerBeneficiaire.Size = New System.Drawing.Size(32, 30)
        Me.BtRetirerBeneficiaire.TabIndex = 1
        Me.BtRetirerBeneficiaire.UseVisualStyleBackColor = True
        '
        'TbLienParente
        '
        Me.TbLienParente.CueBanner = "Lien de parenté"
        Me.TbLienParente.Location = New System.Drawing.Point(197, 40)
        Me.TbLienParente.Name = "TbLienParente"
        Me.TbLienParente.Size = New System.Drawing.Size(167, 22)
        Me.TbLienParente.TabIndex = 2
        Me.TbLienParente.Value = Nothing
        '
        'BtModifier
        '
        Me.BtModifier.Location = New System.Drawing.Point(383, 41)
        Me.BtModifier.Name = "BtModifier"
        Me.BtModifier.Size = New System.Drawing.Size(76, 23)
        Me.BtModifier.TabIndex = 3
        Me.BtModifier.Text = "Modifier"
        Me.BtModifier.UseVisualStyleBackColor = True
        '
        'ElemListeBenefBdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.BtModifier)
        Me.Controls.Add(Me.BtRetirerBeneficiaire)
        Me.Controls.Add(Me.TbLienParente)
        Me.Controls.Add(Me.LabAdresse)
        Me.Controls.Add(Me.LabDateNaiss)
        Me.Controls.Add(Me.LabPrenom)
        Me.Controls.Add(Me.LabNom)
        Me.Name = "ElemListeBenefBdd"
        Me.Size = New System.Drawing.Size(782, 102)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabNom As Label
    Friend WithEvents LabPrenom As Label
    Friend WithEvents LabDateNaiss As Label
    Friend WithEvents LabAdresse As Label
    Friend WithEvents TbLienParente As TextBoxNullable
    Friend WithEvents BtRetirerBeneficiaire As Button
    Friend WithEvents BtModifier As Button
End Class
