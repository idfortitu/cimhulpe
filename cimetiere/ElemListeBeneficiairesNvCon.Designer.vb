<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ElemListeBeneficiairesNvCon
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DateNaiss = New System.Windows.Forms.DateTimePicker()
        Me.tbNom = New cimetiere.TextBoxNullable()
        Me.TbPrenom = New cimetiere.TextBoxNullable()
        Me.TbAdresse = New cimetiere.TextBoxNullable()
        Me.TbLienParente = New cimetiere.TextBoxNullable()
        Me.btRetirerBeneficiaire = New System.Windows.Forms.Button()
        Me.TbVille = New cimetiere.TextBoxNullable()
        Me.TbPays = New cimetiere.TextBoxNullable()
        Me.TbCp = New cimetiere.TextBoxIntNullable()
        Me.SuspendLayout()
        '
        'DateNaiss
        '
        Me.DateNaiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNaiss.Location = New System.Drawing.Point(302, 2)
        Me.DateNaiss.Margin = New System.Windows.Forms.Padding(4)
        Me.DateNaiss.Name = "DateNaiss"
        Me.DateNaiss.ShowCheckBox = True
        Me.DateNaiss.Size = New System.Drawing.Size(159, 23)
        Me.DateNaiss.TabIndex = 3
        '
        'tbNom
        '
        Me.tbNom.CueBanner = Nothing
        Me.tbNom.Location = New System.Drawing.Point(40, 2)
        Me.tbNom.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(121, 22)
        Me.tbNom.TabIndex = 1
        Me.tbNom.Value = Nothing
        '
        'TbPrenom
        '
        Me.TbPrenom.CueBanner = Nothing
        Me.TbPrenom.Location = New System.Drawing.Point(166, 2)
        Me.TbPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.TbPrenom.Name = "TbPrenom"
        Me.TbPrenom.Size = New System.Drawing.Size(131, 22)
        Me.TbPrenom.TabIndex = 2
        Me.TbPrenom.Value = Nothing
        '
        'TbAdresse
        '
        Me.TbAdresse.CueBanner = Nothing
        Me.TbAdresse.Location = New System.Drawing.Point(469, 2)
        Me.TbAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.TbAdresse.Name = "TbAdresse"
        Me.TbAdresse.Size = New System.Drawing.Size(166, 22)
        Me.TbAdresse.TabIndex = 4
        Me.TbAdresse.Value = Nothing
        '
        'TbLienParente
        '
        Me.TbLienParente.CueBanner = Nothing
        Me.TbLienParente.Location = New System.Drawing.Point(222, 34)
        Me.TbLienParente.Margin = New System.Windows.Forms.Padding(4)
        Me.TbLienParente.Name = "TbLienParente"
        Me.TbLienParente.Size = New System.Drawing.Size(167, 22)
        Me.TbLienParente.TabIndex = 6
        Me.TbLienParente.Value = Nothing
        '
        'btRetirerBeneficiaire
        '
        Me.btRetirerBeneficiaire.Image = Global.cimetiere.My.Resources.Resources.moins
        Me.btRetirerBeneficiaire.Location = New System.Drawing.Point(0, 0)
        Me.btRetirerBeneficiaire.Margin = New System.Windows.Forms.Padding(4)
        Me.btRetirerBeneficiaire.Name = "btRetirerBeneficiaire"
        Me.btRetirerBeneficiaire.Size = New System.Drawing.Size(32, 30)
        Me.btRetirerBeneficiaire.TabIndex = 0
        Me.btRetirerBeneficiaire.UseVisualStyleBackColor = True
        '
        'TbVille
        '
        Me.TbVille.CueBanner = Nothing
        Me.TbVille.Location = New System.Drawing.Point(397, 34)
        Me.TbVille.Margin = New System.Windows.Forms.Padding(4)
        Me.TbVille.Name = "TbVille"
        Me.TbVille.Size = New System.Drawing.Size(142, 22)
        Me.TbVille.TabIndex = 7
        Me.TbVille.Value = Nothing
        '
        'TbPays
        '
        Me.TbPays.CueBanner = Nothing
        Me.TbPays.Location = New System.Drawing.Point(547, 34)
        Me.TbPays.Margin = New System.Windows.Forms.Padding(4)
        Me.TbPays.Name = "TbPays"
        Me.TbPays.Size = New System.Drawing.Size(154, 22)
        Me.TbPays.TabIndex = 8
        Me.TbPays.Value = Nothing
        '
        'TbCp
        '
        Me.TbCp.CueBanner = Nothing
        Me.TbCp.Location = New System.Drawing.Point(642, 2)
        Me.TbCp.Name = "TbCp"
        Me.TbCp.Size = New System.Drawing.Size(59, 22)
        Me.TbCp.TabIndex = 5
        Me.TbCp.Value = Nothing
        '
        'ElemListeBeneficiairesNvCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.TbCp)
        Me.Controls.Add(Me.TbPays)
        Me.Controls.Add(Me.TbVille)
        Me.Controls.Add(Me.TbLienParente)
        Me.Controls.Add(Me.TbAdresse)
        Me.Controls.Add(Me.TbPrenom)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.btRetirerBeneficiaire)
        Me.Controls.Add(Me.DateNaiss)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "ElemListeBeneficiairesNvCon"
        Me.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.Size = New System.Drawing.Size(714, 66)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateNaiss As DateTimePicker
    Friend WithEvents btRetirerBeneficiaire As Button
    Friend WithEvents tbNom As TextBoxNullable
    Friend WithEvents TbPrenom As TextBoxNullable
    Friend WithEvents TbAdresse As TextBoxNullable
    Friend WithEvents TbLienParente As TextBoxNullable
    Friend WithEvents TbVille As TextBoxNullable
    Friend WithEvents TbPays As TextBoxNullable
    Friend WithEvents TbCp As TextBoxIntNullable
End Class
