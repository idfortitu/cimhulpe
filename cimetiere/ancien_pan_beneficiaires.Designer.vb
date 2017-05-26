<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ancien_pan_beneficiaires
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
        Me.dtpCsnrDateNaiss = New System.Windows.Forms.DateTimePicker()
        Me.tbCsnrAdresse = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tbCsnrNom = New System.Windows.Forms.TextBox()
        Me.tbCsnrVille = New System.Windows.Forms.TextBox()
        Me.FaddDLNomCons = New System.Windows.Forms.Label()
        Me.tbCsnrPays = New System.Windows.Forms.TextBox()
        Me.FaddDLPrenomCons = New System.Windows.Forms.Label()
        Me.FaddDLPaysCons = New System.Windows.Forms.Label()
        Me.tbCsnrCp = New System.Windows.Forms.TextBox()
        Me.tbCsnrPrenom = New System.Windows.Forms.TextBox()
        Me.Lien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.naissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prénoms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaddDLCodePostalCons = New System.Windows.Forms.Label()
        Me.FaddDLDateNaissCons = New System.Windows.Forms.Label()
        Me.FaddDDGCons = New System.Windows.Forms.DataGridView()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbCnsrTel = New System.Windows.Forms.TextBox()
        Me.FaddDLNumRegistreCons = New System.Windows.Forms.Label()
        Me.FaddDLTelCons = New System.Windows.Forms.Label()
        Me.tbCsnrNoNational = New System.Windows.Forms.TextBox()
        Me.FaddDLAdresseCons = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        CType(Me.FaddDDGCons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpCsnrDateNaiss
        '
        Me.dtpCsnrDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCsnrDateNaiss.Location = New System.Drawing.Point(118, 42)
        Me.dtpCsnrDateNaiss.Name = "dtpCsnrDateNaiss"
        Me.dtpCsnrDateNaiss.Size = New System.Drawing.Size(108, 20)
        Me.dtpCsnrDateNaiss.TabIndex = 143
        '
        'tbCsnrAdresse
        '
        Me.tbCsnrAdresse.Location = New System.Drawing.Point(69, 65)
        Me.tbCsnrAdresse.Multiline = True
        Me.tbCsnrAdresse.Name = "tbCsnrAdresse"
        Me.tbCsnrAdresse.Size = New System.Drawing.Size(334, 20)
        Me.tbCsnrAdresse.TabIndex = 89
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(198, 92)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 13)
        Me.Label30.TabIndex = 141
        Me.Label30.Text = "Ville :"
        '
        'tbCsnrNom
        '
        Me.tbCsnrNom.Location = New System.Drawing.Point(52, 18)
        Me.tbCsnrNom.Name = "tbCsnrNom"
        Me.tbCsnrNom.Size = New System.Drawing.Size(100, 20)
        Me.tbCsnrNom.TabIndex = 79
        '
        'tbCsnrVille
        '
        Me.tbCsnrVille.Location = New System.Drawing.Point(236, 89)
        Me.tbCsnrVille.Name = "tbCsnrVille"
        Me.tbCsnrVille.Size = New System.Drawing.Size(116, 20)
        Me.tbCsnrVille.TabIndex = 142
        '
        'FaddDLNomCons
        '
        Me.FaddDLNomCons.AutoSize = True
        Me.FaddDLNomCons.Location = New System.Drawing.Point(11, 21)
        Me.FaddDLNomCons.Name = "FaddDLNomCons"
        Me.FaddDLNomCons.Size = New System.Drawing.Size(35, 13)
        Me.FaddDLNomCons.TabIndex = 80
        Me.FaddDLNomCons.Text = "Nom :"
        '
        'tbCsnrPays
        '
        Me.tbCsnrPays.Location = New System.Drawing.Point(409, 89)
        Me.tbCsnrPays.Name = "tbCsnrPays"
        Me.tbCsnrPays.Size = New System.Drawing.Size(100, 20)
        Me.tbCsnrPays.TabIndex = 98
        '
        'FaddDLPrenomCons
        '
        Me.FaddDLPrenomCons.AutoSize = True
        Me.FaddDLPrenomCons.Location = New System.Drawing.Point(155, 21)
        Me.FaddDLPrenomCons.Name = "FaddDLPrenomCons"
        Me.FaddDLPrenomCons.Size = New System.Drawing.Size(49, 13)
        Me.FaddDLPrenomCons.TabIndex = 81
        Me.FaddDLPrenomCons.Text = "Prenom :"
        '
        'FaddDLPaysCons
        '
        Me.FaddDLPaysCons.AutoSize = True
        Me.FaddDLPaysCons.Location = New System.Drawing.Point(366, 92)
        Me.FaddDLPaysCons.Name = "FaddDLPaysCons"
        Me.FaddDLPaysCons.Size = New System.Drawing.Size(36, 13)
        Me.FaddDLPaysCons.TabIndex = 97
        Me.FaddDLPaysCons.Text = "Pays :"
        '
        'tbCsnrCp
        '
        Me.tbCsnrCp.Location = New System.Drawing.Point(87, 89)
        Me.tbCsnrCp.Name = "tbCsnrCp"
        Me.tbCsnrCp.Size = New System.Drawing.Size(100, 20)
        Me.tbCsnrCp.TabIndex = 96
        '
        'tbCsnrPrenom
        '
        Me.tbCsnrPrenom.Location = New System.Drawing.Point(205, 18)
        Me.tbCsnrPrenom.Name = "tbCsnrPrenom"
        Me.tbCsnrPrenom.Size = New System.Drawing.Size(100, 20)
        Me.tbCsnrPrenom.TabIndex = 83
        '
        'Lien
        '
        Me.Lien.HeaderText = "Lien(s) de parenté"
        Me.Lien.Name = "Lien"
        '
        'naissance
        '
        Me.naissance.HeaderText = "Date(s) de naissance"
        Me.naissance.Name = "naissance"
        Me.naissance.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Prénoms
        '
        Me.Prénoms.HeaderText = "Prénoms"
        Me.Prénoms.Name = "Prénoms"
        '
        'FaddDLCodePostalCons
        '
        Me.FaddDLCodePostalCons.AutoSize = True
        Me.FaddDLCodePostalCons.Location = New System.Drawing.Point(11, 92)
        Me.FaddDLCodePostalCons.Name = "FaddDLCodePostalCons"
        Me.FaddDLCodePostalCons.Size = New System.Drawing.Size(70, 13)
        Me.FaddDLCodePostalCons.TabIndex = 95
        Me.FaddDLCodePostalCons.Text = "Code Postal :"
        '
        'FaddDLDateNaissCons
        '
        Me.FaddDLDateNaissCons.AutoSize = True
        Me.FaddDLDateNaissCons.Location = New System.Drawing.Point(10, 45)
        Me.FaddDLDateNaissCons.Name = "FaddDLDateNaissCons"
        Me.FaddDLDateNaissCons.Size = New System.Drawing.Size(102, 13)
        Me.FaddDLDateNaissCons.TabIndex = 84
        Me.FaddDLDateNaissCons.Text = "Date de naissance :"
        '
        'FaddDDGCons
        '
        Me.FaddDDGCons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FaddDDGCons.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nom, Me.Prénoms, Me.naissance, Me.Lien})
        Me.FaddDDGCons.Location = New System.Drawing.Point(13, 115)
        Me.FaddDDGCons.Name = "FaddDDGCons"
        Me.FaddDDGCons.Size = New System.Drawing.Size(522, 127)
        Me.FaddDDGCons.TabIndex = 92
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom(s) du(es) bénéficiaires"
        Me.Nom.Name = "Nom"
        '
        'tbCnsrTel
        '
        Me.tbCnsrTel.Location = New System.Drawing.Point(301, 42)
        Me.tbCnsrTel.Name = "tbCnsrTel"
        Me.tbCnsrTel.Size = New System.Drawing.Size(102, 20)
        Me.tbCnsrTel.TabIndex = 91
        '
        'FaddDLNumRegistreCons
        '
        Me.FaddDLNumRegistreCons.AutoSize = True
        Me.FaddDLNumRegistreCons.Location = New System.Drawing.Point(313, 22)
        Me.FaddDLNumRegistreCons.Name = "FaddDLNumRegistreCons"
        Me.FaddDLNumRegistreCons.Size = New System.Drawing.Size(117, 13)
        Me.FaddDLNumRegistreCons.TabIndex = 86
        Me.FaddDLNumRegistreCons.Text = "N° de registre national :"
        '
        'FaddDLTelCons
        '
        Me.FaddDLTelCons.AutoSize = True
        Me.FaddDLTelCons.Location = New System.Drawing.Point(231, 45)
        Me.FaddDLTelCons.Name = "FaddDLTelCons"
        Me.FaddDLTelCons.Size = New System.Drawing.Size(64, 13)
        Me.FaddDLTelCons.TabIndex = 90
        Me.FaddDLTelCons.Text = "Téléphone :"
        '
        'tbCsnrNoNational
        '
        Me.tbCsnrNoNational.Location = New System.Drawing.Point(435, 19)
        Me.tbCsnrNoNational.Name = "tbCsnrNoNational"
        Me.tbCsnrNoNational.Size = New System.Drawing.Size(100, 20)
        Me.tbCsnrNoNational.TabIndex = 87
        '
        'FaddDLAdresseCons
        '
        Me.FaddDLAdresseCons.AutoSize = True
        Me.FaddDLAdresseCons.Location = New System.Drawing.Point(10, 68)
        Me.FaddDLAdresseCons.Name = "FaddDLAdresseCons"
        Me.FaddDLAdresseCons.Size = New System.Drawing.Size(51, 13)
        Me.FaddDLAdresseCons.TabIndex = 88
        Me.FaddDLAdresseCons.Text = "Adresse :"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox5.Controls.Add(Me.dtpCsnrDateNaiss)
        Me.GroupBox5.Controls.Add(Me.tbCsnrAdresse)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.tbCsnrNom)
        Me.GroupBox5.Controls.Add(Me.tbCsnrVille)
        Me.GroupBox5.Controls.Add(Me.FaddDLNomCons)
        Me.GroupBox5.Controls.Add(Me.tbCsnrPays)
        Me.GroupBox5.Controls.Add(Me.FaddDLPrenomCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLPaysCons)
        Me.GroupBox5.Controls.Add(Me.tbCsnrCp)
        Me.GroupBox5.Controls.Add(Me.tbCsnrPrenom)
        Me.GroupBox5.Controls.Add(Me.FaddDLCodePostalCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLDateNaissCons)
        Me.GroupBox5.Controls.Add(Me.FaddDDGCons)
        Me.GroupBox5.Controls.Add(Me.tbCnsrTel)
        Me.GroupBox5.Controls.Add(Me.FaddDLNumRegistreCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLTelCons)
        Me.GroupBox5.Controls.Add(Me.tbCsnrNoNational)
        Me.GroupBox5.Controls.Add(Me.FaddDLAdresseCons)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(590, 252)
        Me.GroupBox5.TabIndex = 145
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Concessionnaire"
        '
        'ancien_pan_beneficiaires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "ancien_pan_beneficiaires"
        Me.Size = New System.Drawing.Size(607, 267)
        CType(Me.FaddDDGCons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpCsnrDateNaiss As DateTimePicker
    Friend WithEvents tbCsnrAdresse As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents tbCsnrNom As TextBox
    Friend WithEvents tbCsnrVille As TextBox
    Friend WithEvents FaddDLNomCons As Label
    Friend WithEvents tbCsnrPays As TextBox
    Friend WithEvents FaddDLPrenomCons As Label
    Friend WithEvents FaddDLPaysCons As Label
    Friend WithEvents tbCsnrCp As TextBox
    Friend WithEvents tbCsnrPrenom As TextBox
    Friend WithEvents Lien As DataGridViewTextBoxColumn
    Friend WithEvents naissance As DataGridViewTextBoxColumn
    Friend WithEvents Prénoms As DataGridViewTextBoxColumn
    Friend WithEvents FaddDLCodePostalCons As Label
    Friend WithEvents FaddDLDateNaissCons As Label
    Friend WithEvents FaddDDGCons As DataGridView
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents tbCnsrTel As TextBox
    Friend WithEvents FaddDLNumRegistreCons As Label
    Friend WithEvents FaddDLTelCons As Label
    Friend WithEvents tbCsnrNoNational As TextBox
    Friend WithEvents FaddDLAdresseCons As Label
    Friend WithEvents GroupBox5 As GroupBox
End Class
