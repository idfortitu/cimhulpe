<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelInfosCsnr
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
        Me.FaddDLAdresseCons = New System.Windows.Forms.Label()
        Me.FaddDLTelCons = New System.Windows.Forms.Label()
        Me.FaddDLNumRegistreCons = New System.Windows.Forms.Label()
        Me.FaddDLDateNaissCons = New System.Windows.Forms.Label()
        Me.FaddDLCodePostalCons = New System.Windows.Forms.Label()
        Me.FaddDLPaysCons = New System.Windows.Forms.Label()
        Me.FaddDLPrenomCons = New System.Windows.Forms.Label()
        Me.FaddDLNomCons = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.dtpCsnrDateNaiss = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TbCsnrPays = New cimetiere.TextBoxNullable()
        Me.TbCsnrVille = New cimetiere.TextBoxNullable()
        Me.TbCsnrAdresse = New cimetiere.TextBoxNullable()
        Me.TbCsnrTel = New cimetiere.TextBoxNullable()
        Me.TbCsnrPrenom = New cimetiere.TextBoxNullable()
        Me.TbCsnrNom = New cimetiere.TextBoxNullable()
        Me.tbCsnrCp = New cimetiere.TextBoxIntNullable()
        Me.tbCsnrNoNational = New cimetiere.TextBoxIntNullable()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'FaddDLAdresseCons
        '
        Me.FaddDLAdresseCons.AutoSize = True
        Me.FaddDLAdresseCons.Location = New System.Drawing.Point(13, 84)
        Me.FaddDLAdresseCons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FaddDLAdresseCons.Name = "FaddDLAdresseCons"
        Me.FaddDLAdresseCons.Size = New System.Drawing.Size(68, 17)
        Me.FaddDLAdresseCons.TabIndex = 88
        Me.FaddDLAdresseCons.Text = "Adresse :"
        '
        'FaddDLTelCons
        '
        Me.FaddDLTelCons.AutoSize = True
        Me.FaddDLTelCons.Location = New System.Drawing.Point(308, 55)
        Me.FaddDLTelCons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FaddDLTelCons.Name = "FaddDLTelCons"
        Me.FaddDLTelCons.Size = New System.Drawing.Size(84, 17)
        Me.FaddDLTelCons.TabIndex = 90
        Me.FaddDLTelCons.Text = "Téléphone :"
        '
        'FaddDLNumRegistreCons
        '
        Me.FaddDLNumRegistreCons.AutoSize = True
        Me.FaddDLNumRegistreCons.Location = New System.Drawing.Point(417, 27)
        Me.FaddDLNumRegistreCons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FaddDLNumRegistreCons.Name = "FaddDLNumRegistreCons"
        Me.FaddDLNumRegistreCons.Size = New System.Drawing.Size(158, 17)
        Me.FaddDLNumRegistreCons.TabIndex = 86
        Me.FaddDLNumRegistreCons.Text = "N° de registre national :"
        '
        'FaddDLDateNaissCons
        '
        Me.FaddDLDateNaissCons.AutoSize = True
        Me.FaddDLDateNaissCons.Location = New System.Drawing.Point(13, 55)
        Me.FaddDLDateNaissCons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FaddDLDateNaissCons.Name = "FaddDLDateNaissCons"
        Me.FaddDLDateNaissCons.Size = New System.Drawing.Size(134, 17)
        Me.FaddDLDateNaissCons.TabIndex = 84
        Me.FaddDLDateNaissCons.Text = "Date de naissance :"
        '
        'FaddDLCodePostalCons
        '
        Me.FaddDLCodePostalCons.AutoSize = True
        Me.FaddDLCodePostalCons.Location = New System.Drawing.Point(15, 113)
        Me.FaddDLCodePostalCons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FaddDLCodePostalCons.Name = "FaddDLCodePostalCons"
        Me.FaddDLCodePostalCons.Size = New System.Drawing.Size(92, 17)
        Me.FaddDLCodePostalCons.TabIndex = 95
        Me.FaddDLCodePostalCons.Text = "Code Postal :"
        '
        'FaddDLPaysCons
        '
        Me.FaddDLPaysCons.AutoSize = True
        Me.FaddDLPaysCons.Location = New System.Drawing.Point(488, 113)
        Me.FaddDLPaysCons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FaddDLPaysCons.Name = "FaddDLPaysCons"
        Me.FaddDLPaysCons.Size = New System.Drawing.Size(47, 17)
        Me.FaddDLPaysCons.TabIndex = 97
        Me.FaddDLPaysCons.Text = "Pays :"
        '
        'FaddDLPrenomCons
        '
        Me.FaddDLPrenomCons.AutoSize = True
        Me.FaddDLPrenomCons.Location = New System.Drawing.Point(207, 26)
        Me.FaddDLPrenomCons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FaddDLPrenomCons.Name = "FaddDLPrenomCons"
        Me.FaddDLPrenomCons.Size = New System.Drawing.Size(65, 17)
        Me.FaddDLPrenomCons.TabIndex = 81
        Me.FaddDLPrenomCons.Text = "Prenom :"
        '
        'FaddDLNomCons
        '
        Me.FaddDLNomCons.AutoSize = True
        Me.FaddDLNomCons.Location = New System.Drawing.Point(15, 26)
        Me.FaddDLNomCons.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FaddDLNomCons.Name = "FaddDLNomCons"
        Me.FaddDLNomCons.Size = New System.Drawing.Size(45, 17)
        Me.FaddDLNomCons.TabIndex = 80
        Me.FaddDLNomCons.Text = "Nom :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(264, 113)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(42, 17)
        Me.Label30.TabIndex = 141
        Me.Label30.Text = "Ville :"
        '
        'dtpCsnrDateNaiss
        '
        Me.dtpCsnrDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCsnrDateNaiss.Location = New System.Drawing.Point(157, 52)
        Me.dtpCsnrDateNaiss.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpCsnrDateNaiss.Name = "dtpCsnrDateNaiss"
        Me.dtpCsnrDateNaiss.Size = New System.Drawing.Size(143, 22)
        Me.dtpCsnrDateNaiss.TabIndex = 143
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TbCsnrPays)
        Me.GroupBox5.Controls.Add(Me.TbCsnrVille)
        Me.GroupBox5.Controls.Add(Me.TbCsnrAdresse)
        Me.GroupBox5.Controls.Add(Me.TbCsnrTel)
        Me.GroupBox5.Controls.Add(Me.TbCsnrPrenom)
        Me.GroupBox5.Controls.Add(Me.TbCsnrNom)
        Me.GroupBox5.Controls.Add(Me.tbCsnrCp)
        Me.GroupBox5.Controls.Add(Me.tbCsnrNoNational)
        Me.GroupBox5.Controls.Add(Me.dtpCsnrDateNaiss)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.FaddDLNomCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLPrenomCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLPaysCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLCodePostalCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLDateNaissCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLNumRegistreCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLTelCons)
        Me.GroupBox5.Controls.Add(Me.FaddDLAdresseCons)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(787, 149)
        Me.GroupBox5.TabIndex = 144
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Concessionnaire"
        '
        'TbCsnrPays
        '
        Me.TbCsnrPays.CueBanner = Nothing
        Me.TbCsnrPays.Location = New System.Drawing.Point(544, 113)
        Me.TbCsnrPays.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCsnrPays.Name = "TbCsnrPays"
        Me.TbCsnrPays.Size = New System.Drawing.Size(164, 22)
        Me.TbCsnrPays.TabIndex = 159
        Me.TbCsnrPays.Value = Nothing
        '
        'TbCsnrVille
        '
        Me.TbCsnrVille.CueBanner = Nothing
        Me.TbCsnrVille.Location = New System.Drawing.Point(315, 110)
        Me.TbCsnrVille.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCsnrVille.Name = "TbCsnrVille"
        Me.TbCsnrVille.Size = New System.Drawing.Size(164, 22)
        Me.TbCsnrVille.TabIndex = 158
        Me.TbCsnrVille.Value = Nothing
        '
        'TbCsnrAdresse
        '
        Me.TbCsnrAdresse.CueBanner = Nothing
        Me.TbCsnrAdresse.Location = New System.Drawing.Point(89, 80)
        Me.TbCsnrAdresse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCsnrAdresse.Name = "TbCsnrAdresse"
        Me.TbCsnrAdresse.Size = New System.Drawing.Size(379, 22)
        Me.TbCsnrAdresse.TabIndex = 157
        Me.TbCsnrAdresse.Value = Nothing
        '
        'TbCsnrTel
        '
        Me.TbCsnrTel.CueBanner = Nothing
        Me.TbCsnrTel.Location = New System.Drawing.Point(401, 52)
        Me.TbCsnrTel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCsnrTel.Name = "TbCsnrTel"
        Me.TbCsnrTel.Size = New System.Drawing.Size(148, 22)
        Me.TbCsnrTel.TabIndex = 156
        Me.TbCsnrTel.Value = Nothing
        '
        'TbCsnrPrenom
        '
        Me.TbCsnrPrenom.CueBanner = Nothing
        Me.TbCsnrPrenom.Location = New System.Drawing.Point(277, 23)
        Me.TbCsnrPrenom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCsnrPrenom.Name = "TbCsnrPrenom"
        Me.TbCsnrPrenom.Size = New System.Drawing.Size(131, 22)
        Me.TbCsnrPrenom.TabIndex = 155
        Me.TbCsnrPrenom.Value = Nothing
        '
        'TbCsnrNom
        '
        Me.TbCsnrNom.CueBanner = Nothing
        Me.TbCsnrNom.Location = New System.Drawing.Point(67, 23)
        Me.TbCsnrNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCsnrNom.Name = "TbCsnrNom"
        Me.TbCsnrNom.Size = New System.Drawing.Size(131, 22)
        Me.TbCsnrNom.TabIndex = 154
        Me.TbCsnrNom.Value = Nothing
        '
        'tbCsnrCp
        '
        Me.tbCsnrCp.CueBanner = Nothing
        Me.tbCsnrCp.Location = New System.Drawing.Point(113, 110)
        Me.tbCsnrCp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCsnrCp.Name = "tbCsnrCp"
        Me.tbCsnrCp.Size = New System.Drawing.Size(120, 22)
        Me.tbCsnrCp.TabIndex = 150
        Me.tbCsnrCp.Value = Nothing
        '
        'tbCsnrNoNational
        '
        Me.tbCsnrNoNational.CueBanner = Nothing
        Me.tbCsnrNoNational.Location = New System.Drawing.Point(581, 22)
        Me.tbCsnrNoNational.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbCsnrNoNational.Name = "tbCsnrNoNational"
        Me.tbCsnrNoNational.Size = New System.Drawing.Size(165, 22)
        Me.tbCsnrNoNational.TabIndex = 149
        Me.tbCsnrNoNational.Value = Nothing
        '
        'PanelInfosCsnr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.Controls.Add(Me.GroupBox5)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PanelInfosCsnr"
        Me.Size = New System.Drawing.Size(791, 165)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FaddDLAdresseCons As Label
    Friend WithEvents FaddDLTelCons As Label
    Friend WithEvents FaddDLNumRegistreCons As Label
    Friend WithEvents FaddDLDateNaissCons As Label
    Friend WithEvents FaddDLCodePostalCons As Label
    Friend WithEvents FaddDLPaysCons As Label
    Friend WithEvents FaddDLPrenomCons As Label
    Friend WithEvents FaddDLNomCons As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents dtpCsnrDateNaiss As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents tbCsnrNoNational As TextBoxIntNullable
    Friend WithEvents tbCsnrCp As TextBoxIntNullable
    Friend WithEvents TbCsnrPays As TextBoxNullable
    Friend WithEvents TbCsnrVille As TextBoxNullable
    Friend WithEvents TbCsnrAdresse As TextBoxNullable
    Friend WithEvents TbCsnrTel As TextBoxNullable
    Friend WithEvents TbCsnrPrenom As TextBoxNullable
    Friend WithEvents TbCsnrNom As TextBoxNullable
End Class
