<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRechercheConcession
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TbChampRecherche = New System.Windows.Forms.TextBox()
        Me.BtChercher = New System.Windows.Forms.Button()
        Me.LabFiltre = New System.Windows.Forms.Label()
        Me.GbConcessionnaire = New System.Windows.Forms.GroupBox()
        Me.FlpConcessionnaire = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabCsnrNom = New System.Windows.Forms.Label()
        Me.LabCsnrDomicile = New System.Windows.Forms.Label()
        Me.LabCsnrTel = New System.Windows.Forms.Label()
        Me.LabCsnrDateNaiss = New System.Windows.Forms.Label()
        Me.LabCsnrNoRegistre = New System.Windows.Forms.Label()
        Me.FlpInfosConcessionSelect = New System.Windows.Forms.FlowLayoutPanel()
        Me.GbInfosCsn = New System.Windows.Forms.GroupBox()
        Me.FlpEmplacement = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabRefEmplacement = New System.Windows.Forms.Label()
        Me.LabDateDebut = New System.Windows.Forms.Label()
        Me.LabDateFin = New System.Windows.Forms.Label()
        Me.LabEmplPlaces = New System.Windows.Forms.Label()
        Me.LabCommentaireEmpl = New System.Windows.Forms.Label()
        Me.GbBenefs = New System.Windows.Forms.GroupBox()
        Me.FlpBeneficiaires = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabBenefsIndiquesOuPas = New System.Windows.Forms.Label()
        Me.GbOccupants = New System.Windows.Forms.GroupBox()
        Me.FlpOccupants = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabOccupantsOuPas = New System.Windows.Forms.Label()
        Me.GbCommentaire = New System.Windows.Forms.GroupBox()
        Me.LabCommentaireCsn = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtMontrerExpirees = New System.Windows.Forms.Button()
        Me.BtTermine = New System.Windows.Forms.Button()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.DgvConcessions = New cimetiere.DataGridViewConcessions()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCsnr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Benefs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Defunts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbConcessionnaire.SuspendLayout()
        Me.FlpConcessionnaire.SuspendLayout()
        Me.FlpInfosConcessionSelect.SuspendLayout()
        Me.GbInfosCsn.SuspendLayout()
        Me.FlpEmplacement.SuspendLayout()
        Me.GbBenefs.SuspendLayout()
        Me.FlpBeneficiaires.SuspendLayout()
        Me.GbOccupants.SuspendLayout()
        Me.FlpOccupants.SuspendLayout()
        Me.GbCommentaire.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvConcessions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbChampRecherche
        '
        Me.TbChampRecherche.Location = New System.Drawing.Point(26, 39)
        Me.TbChampRecherche.Name = "TbChampRecherche"
        Me.TbChampRecherche.Size = New System.Drawing.Size(278, 25)
        Me.TbChampRecherche.TabIndex = 1
        '
        'BtChercher
        '
        Me.BtChercher.Location = New System.Drawing.Point(310, 36)
        Me.BtChercher.Name = "BtChercher"
        Me.BtChercher.Size = New System.Drawing.Size(84, 33)
        Me.BtChercher.TabIndex = 3
        Me.BtChercher.Text = "Chercher"
        Me.BtChercher.UseVisualStyleBackColor = True
        '
        'LabFiltre
        '
        Me.LabFiltre.AutoSize = True
        Me.LabFiltre.Location = New System.Drawing.Point(13, 113)
        Me.LabFiltre.Name = "LabFiltre"
        Me.LabFiltre.Size = New System.Drawing.Size(81, 20)
        Me.LabFiltre.TabIndex = 4
        Me.LabFiltre.Text = "(LabFiltre)"
        '
        'GbConcessionnaire
        '
        Me.GbConcessionnaire.AutoSize = True
        Me.GbConcessionnaire.BackColor = System.Drawing.SystemColors.Control
        Me.GbConcessionnaire.Controls.Add(Me.FlpConcessionnaire)
        Me.GbConcessionnaire.Location = New System.Drawing.Point(3, 3)
        Me.GbConcessionnaire.Name = "GbConcessionnaire"
        Me.GbConcessionnaire.Size = New System.Drawing.Size(359, 148)
        Me.GbConcessionnaire.TabIndex = 5
        Me.GbConcessionnaire.TabStop = False
        Me.GbConcessionnaire.Text = "Concessionnaire"
        '
        'FlpConcessionnaire
        '
        Me.FlpConcessionnaire.AutoSize = True
        Me.FlpConcessionnaire.BackColor = System.Drawing.SystemColors.Control
        Me.FlpConcessionnaire.Controls.Add(Me.LabCsnrNom)
        Me.FlpConcessionnaire.Controls.Add(Me.LabCsnrDomicile)
        Me.FlpConcessionnaire.Controls.Add(Me.LabCsnrTel)
        Me.FlpConcessionnaire.Controls.Add(Me.LabCsnrDateNaiss)
        Me.FlpConcessionnaire.Controls.Add(Me.LabCsnrNoRegistre)
        Me.FlpConcessionnaire.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlpConcessionnaire.Location = New System.Drawing.Point(6, 24)
        Me.FlpConcessionnaire.Name = "FlpConcessionnaire"
        Me.FlpConcessionnaire.Size = New System.Drawing.Size(347, 100)
        Me.FlpConcessionnaire.TabIndex = 0
        '
        'LabCsnrNom
        '
        Me.LabCsnrNom.AutoSize = True
        Me.LabCsnrNom.Location = New System.Drawing.Point(3, 0)
        Me.LabCsnrNom.Name = "LabCsnrNom"
        Me.LabCsnrNom.Size = New System.Drawing.Size(75, 20)
        Me.LabCsnrNom.TabIndex = 0
        Me.LabCsnrNom.Text = "CsnrNom"
        '
        'LabCsnrDomicile
        '
        Me.LabCsnrDomicile.AutoSize = True
        Me.LabCsnrDomicile.Location = New System.Drawing.Point(3, 20)
        Me.LabCsnrDomicile.Name = "LabCsnrDomicile"
        Me.LabCsnrDomicile.Size = New System.Drawing.Size(102, 20)
        Me.LabCsnrDomicile.TabIndex = 1
        Me.LabCsnrDomicile.Text = "CsnrDomicile"
        '
        'LabCsnrTel
        '
        Me.LabCsnrTel.AutoSize = True
        Me.LabCsnrTel.Location = New System.Drawing.Point(3, 40)
        Me.LabCsnrTel.Name = "LabCsnrTel"
        Me.LabCsnrTel.Size = New System.Drawing.Size(63, 20)
        Me.LabCsnrTel.TabIndex = 2
        Me.LabCsnrTel.Text = "CsnrTel"
        '
        'LabCsnrDateNaiss
        '
        Me.LabCsnrDateNaiss.AutoSize = True
        Me.LabCsnrDateNaiss.Location = New System.Drawing.Point(3, 60)
        Me.LabCsnrDateNaiss.Name = "LabCsnrDateNaiss"
        Me.LabCsnrDateNaiss.Size = New System.Drawing.Size(116, 20)
        Me.LabCsnrDateNaiss.TabIndex = 3
        Me.LabCsnrDateNaiss.Text = "CsnrDateNaiss"
        '
        'LabCsnrNoRegistre
        '
        Me.LabCsnrNoRegistre.AutoSize = True
        Me.LabCsnrNoRegistre.Location = New System.Drawing.Point(3, 80)
        Me.LabCsnrNoRegistre.Name = "LabCsnrNoRegistre"
        Me.LabCsnrNoRegistre.Size = New System.Drawing.Size(122, 20)
        Me.LabCsnrNoRegistre.TabIndex = 4
        Me.LabCsnrNoRegistre.Text = "CsnrNoRegistre"
        '
        'FlpInfosConcessionSelect
        '
        Me.FlpInfosConcessionSelect.AutoSize = True
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbConcessionnaire)
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbInfosCsn)
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbBenefs)
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbOccupants)
        Me.FlpInfosConcessionSelect.Controls.Add(Me.GbCommentaire)
        Me.FlpInfosConcessionSelect.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlpInfosConcessionSelect.Location = New System.Drawing.Point(3, 3)
        Me.FlpInfosConcessionSelect.Name = "FlpInfosConcessionSelect"
        Me.FlpInfosConcessionSelect.Size = New System.Drawing.Size(365, 624)
        Me.FlpInfosConcessionSelect.TabIndex = 6
        '
        'GbInfosCsn
        '
        Me.GbInfosCsn.AutoSize = True
        Me.GbInfosCsn.Controls.Add(Me.FlpEmplacement)
        Me.GbInfosCsn.Location = New System.Drawing.Point(3, 157)
        Me.GbInfosCsn.Name = "GbInfosCsn"
        Me.GbInfosCsn.Size = New System.Drawing.Size(359, 145)
        Me.GbInfosCsn.TabIndex = 6
        Me.GbInfosCsn.TabStop = False
        Me.GbInfosCsn.Text = "Emplacement"
        '
        'FlpEmplacement
        '
        Me.FlpEmplacement.AutoSize = True
        Me.FlpEmplacement.Controls.Add(Me.LabRefEmplacement)
        Me.FlpEmplacement.Controls.Add(Me.LabDateDebut)
        Me.FlpEmplacement.Controls.Add(Me.LabDateFin)
        Me.FlpEmplacement.Controls.Add(Me.LabEmplPlaces)
        Me.FlpEmplacement.Controls.Add(Me.LabCommentaireEmpl)
        Me.FlpEmplacement.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlpEmplacement.Location = New System.Drawing.Point(6, 21)
        Me.FlpEmplacement.MaximumSize = New System.Drawing.Size(347, 0)
        Me.FlpEmplacement.Name = "FlpEmplacement"
        Me.FlpEmplacement.Size = New System.Drawing.Size(347, 0)
        Me.FlpEmplacement.TabIndex = 7
        '
        'LabRefEmplacement
        '
        Me.LabRefEmplacement.AutoSize = True
        Me.LabRefEmplacement.Location = New System.Drawing.Point(3, 0)
        Me.LabRefEmplacement.Name = "LabRefEmplacement"
        Me.LabRefEmplacement.Size = New System.Drawing.Size(133, 20)
        Me.LabRefEmplacement.TabIndex = 9
        Me.LabRefEmplacement.Text = "RefEmplacement"
        '
        'LabDateDebut
        '
        Me.LabDateDebut.AutoSize = True
        Me.LabDateDebut.Location = New System.Drawing.Point(3, 20)
        Me.LabDateDebut.Name = "LabDateDebut"
        Me.LabDateDebut.Size = New System.Drawing.Size(88, 20)
        Me.LabDateDebut.TabIndex = 5
        Me.LabDateDebut.Text = "DateDebut"
        '
        'LabDateFin
        '
        Me.LabDateFin.AutoSize = True
        Me.LabDateFin.Location = New System.Drawing.Point(3, 40)
        Me.LabDateFin.Name = "LabDateFin"
        Me.LabDateFin.Size = New System.Drawing.Size(66, 20)
        Me.LabDateFin.TabIndex = 6
        Me.LabDateFin.Text = "DateFin"
        '
        'LabEmplPlaces
        '
        Me.LabEmplPlaces.AutoSize = True
        Me.LabEmplPlaces.Location = New System.Drawing.Point(3, 60)
        Me.LabEmplPlaces.Name = "LabEmplPlaces"
        Me.LabEmplPlaces.Size = New System.Drawing.Size(56, 20)
        Me.LabEmplPlaces.TabIndex = 10
        Me.LabEmplPlaces.Text = "Places"
        '
        'LabCommentaireEmpl
        '
        Me.LabCommentaireEmpl.AutoSize = True
        Me.LabCommentaireEmpl.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabCommentaireEmpl.Location = New System.Drawing.Point(3, 80)
        Me.LabCommentaireEmpl.Name = "LabCommentaireEmpl"
        Me.LabCommentaireEmpl.Size = New System.Drawing.Size(202, 20)
        Me.LabCommentaireEmpl.TabIndex = 7
        Me.LabCommentaireEmpl.Text = "CommentaireEmplacement"
        '
        'GbBenefs
        '
        Me.GbBenefs.AutoSize = True
        Me.GbBenefs.Controls.Add(Me.FlpBeneficiaires)
        Me.GbBenefs.Location = New System.Drawing.Point(3, 308)
        Me.GbBenefs.Name = "GbBenefs"
        Me.GbBenefs.Size = New System.Drawing.Size(356, 68)
        Me.GbBenefs.TabIndex = 7
        Me.GbBenefs.TabStop = False
        Me.GbBenefs.Text = "Bénéficiaires"
        '
        'FlpBeneficiaires
        '
        Me.FlpBeneficiaires.AutoSize = True
        Me.FlpBeneficiaires.Controls.Add(Me.LabBenefsIndiquesOuPas)
        Me.FlpBeneficiaires.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlpBeneficiaires.Location = New System.Drawing.Point(6, 24)
        Me.FlpBeneficiaires.Name = "FlpBeneficiaires"
        Me.FlpBeneficiaires.Size = New System.Drawing.Size(344, 20)
        Me.FlpBeneficiaires.TabIndex = 0
        '
        'LabBenefsIndiquesOuPas
        '
        Me.LabBenefsIndiquesOuPas.AutoSize = True
        Me.LabBenefsIndiquesOuPas.Location = New System.Drawing.Point(3, 0)
        Me.LabBenefsIndiquesOuPas.Name = "LabBenefsIndiquesOuPas"
        Me.LabBenefsIndiquesOuPas.Size = New System.Drawing.Size(169, 20)
        Me.LabBenefsIndiquesOuPas.TabIndex = 0
        Me.LabBenefsIndiquesOuPas.Text = "BenefsIndiquesOuPas"
        '
        'GbOccupants
        '
        Me.GbOccupants.AutoSize = True
        Me.GbOccupants.Controls.Add(Me.FlpOccupants)
        Me.GbOccupants.Location = New System.Drawing.Point(3, 382)
        Me.GbOccupants.Name = "GbOccupants"
        Me.GbOccupants.Size = New System.Drawing.Size(355, 68)
        Me.GbOccupants.TabIndex = 8
        Me.GbOccupants.TabStop = False
        Me.GbOccupants.Text = "Occupant(s)"
        '
        'FlpOccupants
        '
        Me.FlpOccupants.AutoSize = True
        Me.FlpOccupants.Controls.Add(Me.LabOccupantsOuPas)
        Me.FlpOccupants.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlpOccupants.Location = New System.Drawing.Point(6, 24)
        Me.FlpOccupants.Name = "FlpOccupants"
        Me.FlpOccupants.Size = New System.Drawing.Size(343, 20)
        Me.FlpOccupants.TabIndex = 0
        '
        'LabOccupantsOuPas
        '
        Me.LabOccupantsOuPas.AutoSize = True
        Me.LabOccupantsOuPas.Location = New System.Drawing.Point(3, 0)
        Me.LabOccupantsOuPas.Name = "LabOccupantsOuPas"
        Me.LabOccupantsOuPas.Size = New System.Drawing.Size(134, 20)
        Me.LabOccupantsOuPas.TabIndex = 0
        Me.LabOccupantsOuPas.Text = "OccupantsOuPas"
        '
        'GbCommentaire
        '
        Me.GbCommentaire.Controls.Add(Me.LabCommentaireCsn)
        Me.GbCommentaire.Location = New System.Drawing.Point(3, 456)
        Me.GbCommentaire.Name = "GbCommentaire"
        Me.GbCommentaire.Size = New System.Drawing.Size(349, 100)
        Me.GbCommentaire.TabIndex = 9
        Me.GbCommentaire.TabStop = False
        Me.GbCommentaire.Text = "Commentaire"
        Me.GbCommentaire.Visible = False
        '
        'LabCommentaireCsn
        '
        Me.LabCommentaireCsn.AutoSize = True
        Me.LabCommentaireCsn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabCommentaireCsn.Location = New System.Drawing.Point(9, 21)
        Me.LabCommentaireCsn.Name = "LabCommentaireCsn"
        Me.LabCommentaireCsn.Size = New System.Drawing.Size(187, 20)
        Me.LabCommentaireCsn.TabIndex = 0
        Me.LabCommentaireCsn.Text = "CommentaireConcession"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.FlpInfosConcessionSelect)
        Me.Panel1.Location = New System.Drawing.Point(734, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 652)
        Me.Panel1.TabIndex = 7
        '
        'BtMontrerExpirees
        '
        Me.BtMontrerExpirees.Location = New System.Drawing.Point(488, 99)
        Me.BtMontrerExpirees.Name = "BtMontrerExpirees"
        Me.BtMontrerExpirees.Size = New System.Drawing.Size(235, 34)
        Me.BtMontrerExpirees.TabIndex = 8
        Me.BtMontrerExpirees.Text = "Montrer les locations expirées"
        Me.BtMontrerExpirees.UseVisualStyleBackColor = True
        '
        'BtTermine
        '
        Me.BtTermine.Location = New System.Drawing.Point(610, 635)
        Me.BtTermine.Name = "BtTermine"
        Me.BtTermine.Size = New System.Drawing.Size(101, 33)
        Me.BtTermine.TabIndex = 10
        Me.BtTermine.Text = "Choisir"
        Me.BtTermine.UseVisualStyleBackColor = True
        '
        'BtAnnuler
        '
        Me.BtAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtAnnuler.Location = New System.Drawing.Point(491, 635)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(90, 33)
        Me.BtAnnuler.TabIndex = 11
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'DgvConcessions
        '
        Me.DgvConcessions.AllowUserToAddRows = False
        Me.DgvConcessions.AllowUserToDeleteRows = False
        Me.DgvConcessions.AllowUserToOrderColumns = True
        Me.DgvConcessions.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgvConcessions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvConcessions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvConcessions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvConcessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConcessions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.NomCsnr, Me.Empl, Me.Benefs, Me.Defunts})
        Me.DgvConcessions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvConcessions.EnableHeadersVisualStyles = False
        Me.DgvConcessions.Location = New System.Drawing.Point(14, 144)
        Me.DgvConcessions.MultiSelect = False
        Me.DgvConcessions.Name = "DgvConcessions"
        Me.DgvConcessions.ReadOnly = True
        Me.DgvConcessions.RowHeadersVisible = False
        Me.DgvConcessions.RowTemplate.Height = 24
        Me.DgvConcessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConcessions.Size = New System.Drawing.Size(709, 487)
        Me.DgvConcessions.TabIndex = 0
        '
        'No
        '
        Me.No.HeaderText = "N°"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 50
        '
        'NomCsnr
        '
        Me.NomCsnr.DataPropertyName = "NomCsnr"
        Me.NomCsnr.HeaderText = "Concessionnaire"
        Me.NomCsnr.Name = "NomCsnr"
        Me.NomCsnr.ReadOnly = True
        Me.NomCsnr.Width = 180
        '
        'Empl
        '
        Me.Empl.DataPropertyName = "RefEmpl"
        Me.Empl.HeaderText = "Empl."
        Me.Empl.Name = "Empl"
        Me.Empl.ReadOnly = True
        Me.Empl.Width = 70
        '
        'Benefs
        '
        Me.Benefs.DataPropertyName = "NomsBenefs"
        Me.Benefs.HeaderText = "Bénéficiaires"
        Me.Benefs.Name = "Benefs"
        Me.Benefs.ReadOnly = True
        Me.Benefs.Width = 200
        '
        'Defunts
        '
        Me.Defunts.DataPropertyName = "NomsDefunts"
        Me.Defunts.HeaderText = "Occupants"
        Me.Defunts.Name = "Defunts"
        Me.Defunts.ReadOnly = True
        Me.Defunts.Width = 220
        '
        'FormRechercheConcession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.CancelButton = Me.BtAnnuler
        Me.ClientSize = New System.Drawing.Size(1140, 676)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.BtTermine)
        Me.Controls.Add(Me.BtMontrerExpirees)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabFiltre)
        Me.Controls.Add(Me.BtChercher)
        Me.Controls.Add(Me.TbChampRecherche)
        Me.Controls.Add(Me.DgvConcessions)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.3!)
        Me.Name = "FormRechercheConcession"
        Me.Text = "FormRechercheConcession"
        Me.GbConcessionnaire.ResumeLayout(False)
        Me.GbConcessionnaire.PerformLayout()
        Me.FlpConcessionnaire.ResumeLayout(False)
        Me.FlpConcessionnaire.PerformLayout()
        Me.FlpInfosConcessionSelect.ResumeLayout(False)
        Me.FlpInfosConcessionSelect.PerformLayout()
        Me.GbInfosCsn.ResumeLayout(False)
        Me.GbInfosCsn.PerformLayout()
        Me.FlpEmplacement.ResumeLayout(False)
        Me.FlpEmplacement.PerformLayout()
        Me.GbBenefs.ResumeLayout(False)
        Me.GbBenefs.PerformLayout()
        Me.FlpBeneficiaires.ResumeLayout(False)
        Me.FlpBeneficiaires.PerformLayout()
        Me.GbOccupants.ResumeLayout(False)
        Me.GbOccupants.PerformLayout()
        Me.FlpOccupants.ResumeLayout(False)
        Me.FlpOccupants.PerformLayout()
        Me.GbCommentaire.ResumeLayout(False)
        Me.GbCommentaire.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvConcessions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvConcessions As DataGridViewConcessions
    Friend WithEvents TbChampRecherche As TextBox
    Friend WithEvents BtChercher As Button
    Friend WithEvents LabFiltre As Label
    Friend WithEvents GbConcessionnaire As GroupBox
    Friend WithEvents FlpConcessionnaire As FlowLayoutPanel
    Friend WithEvents LabCsnrNom As Label
    Friend WithEvents FlpInfosConcessionSelect As FlowLayoutPanel
    Friend WithEvents LabCsnrDomicile As Label
    Friend WithEvents LabCsnrTel As Label
    Friend WithEvents LabCsnrDateNaiss As Label
    Friend WithEvents LabCsnrNoRegistre As Label
    Friend WithEvents GbInfosCsn As GroupBox
    Friend WithEvents LabDateFin As Label
    Friend WithEvents FlpEmplacement As FlowLayoutPanel
    Friend WithEvents LabDateDebut As Label
    Friend WithEvents LabCommentaireEmpl As Label
    Friend WithEvents GbBenefs As GroupBox
    Friend WithEvents FlpBeneficiaires As FlowLayoutPanel
    Friend WithEvents LabBenefsIndiquesOuPas As Label
    Friend WithEvents GbOccupants As GroupBox
    Friend WithEvents FlpOccupants As FlowLayoutPanel
    Friend WithEvents LabOccupantsOuPas As Label
    Friend WithEvents GbCommentaire As GroupBox
    Friend WithEvents LabCommentaireCsn As Label
    Friend WithEvents LabRefEmplacement As Label
    Friend WithEvents LabEmplPlaces As Label
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents NomCsnr As DataGridViewTextBoxColumn
    Friend WithEvents Empl As DataGridViewTextBoxColumn
    Friend WithEvents Benefs As DataGridViewTextBoxColumn
    Friend WithEvents Defunts As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtMontrerExpirees As Button
    Friend WithEvents BtTermine As Button
    Friend WithEvents BtAnnuler As Button
End Class
