Public Class FormRechercheConcession
    ' Sert à retrouver une concession existante sur base d'infos fournies par le demandeur
    Private ListeConcessions As SortableBindingList(Of Concession.InfosPourListe)
    Private _csnSelect As Concession
    Public ReadOnly Property CsnSelect As Concession
        Get
            Return _csnSelect
        End Get
    End Property


    ' à faire :
    ' - charger la liste des concessions

    Private Sub FormRechercheConcession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabFiltre.Text = ""
        DgvConcessions.AutoGenerateColumns = False
        ChargerListe()

    End Sub

    Private Sub TbChampRecherche_KeyDown(sender As Object, e As KeyEventArgs) Handles TbChampRecherche.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtChercher_Click(BtChercher, Nothing)
            e.Handled = True
        End If
    End Sub

    Private Sub ChargerListe(Optional AvecExpirees As Boolean = False)

    End Sub

    Private Sub BtChercher_Click(sender As Object, e As EventArgs) Handles BtChercher.Click
        Dim f = TbChampRecherche.Text.Trim
        ListeConcessions.Filter = f
        If f = "" Then
            LabFiltre.Text = ""
        Else
            LabFiltre.Text = "Recherche : " & f
        End If
    End Sub

    '' couleur différente aux concessions expirées
    'Private Sub ColorLignes(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvConcessions.CellFormatting
    '    Dim larow As DataGridViewRow = DgvConcessions.Rows(e.RowIndex)
    '    Dim datefin As Date? = CType(larow.DataBoundItem, Concession.InfosPourListe).DateFin
    '    Dim expire As Boolean = datefin.HasValue AndAlso datefin < Today
    '    Dim impair As Boolean = e.RowIndex Mod 2 <> 0
    '    If expire Then
    '        If impair Then
    '            larow.DefaultCellStyle.BackColor = Color.FromArgb(212, 212, 212)
    '            larow.DefaultCellStyle.ForeColor = SystemColors.GrayText
    '        Else
    '            larow.DefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222)
    '            larow.DefaultCellStyle.ForeColor = SystemColors.GrayText
    '        End If
    '    End If
    'End Sub

    Private Function FiltrerElement(elem As Object, f As String)
        Dim celem = CType(elem, Concession.InfosPourListe)
        Return UzineAGaz.ReduireString(String.Concat(celem.NomCsnr, celem.NomsBenefs, celem.NomsDefunts, celem.RefEmpl)).Contains(UzineAGaz.ReduireString(f))
    End Function

    Private Sub DgvConcessions_SelectionChanged(sender As Object, e As EventArgs) Handles DgvConcessions.SelectionChanged
        If Not DgvConcessions.SelectedRows.Count > 0 Then
            _csnSelect = Nothing
            LabCsnrNom.Text = ""
            LabCsnrDomicile.Text = ""
            LabCsnrTel.Text = ""
            LabCsnrDateNaiss.Text = ""
            LabCsnrNoRegistre.Text = ""
            LabRefEmplacement.Text = ""
            LabDateDebut.Text = ""
            LabDateFin.Text = ""
            LabEmplPlaces.Text = ""
            LabCommentaireCsn.Text = ""
            FlpBeneficiaires.Controls.Clear()
            FlpOccupants.Controls.Clear()
            GbCommentaire.Visible = False
            LabCommentaireCsn.Text = ""
        Else

            ' affiche les infos
            ' Concessionnaire
            With _csnSelect.Concessionnaire
                LabCsnrNom.Text = .NomComplet
                LabCsnrDomicile.Text = .AdresseComplete
                LabCsnrTel.Text = .Tel
                LabCsnrDateNaiss.Text = If(.DateNaiss.HasValue, .DateNaiss.Value.ToString("dd/MM/yyyy"), "")
                LabCsnrNoRegistre.Text = If(.NoRegistre, "")
            End With

            ' Cadre Emplacement
            With _csnSelect.Emplacement
                If _csnSelect.Emplacement IsNot Nothing Then LabRefEmplacement.Text = .Reference Else LabRefEmplacement.Text = "(Réf. emplacement non disponible)"
                LabDateDebut.Text = If(_csnSelect.DateDebut.HasValue, "Depuis " & _csnSelect.DateDebut.Value.ToString("dd/MM/yyyy"), "")
                LabDateFin.Text = If(_csnSelect.DateFin.HasValue, "Expire " & _csnSelect.DateFin.Value.ToString("dd/MM/yyyy"), "")
                LabEmplPlaces.Text = If(_csnSelect.Emplacement IsNot Nothing AndAlso .NbPlaces.HasValue, "Places (en tout) : " & .NbPlaces, "")     ' À FAIRE : décompter les places prises
                LabCommentaireEmpl.Text = If(_csnSelect.Emplacement IsNot Nothing, .Commentaire, "")
            End With

            ' Bénéficiaires
            With _csnSelect.MentionsBenefs ' collection
                FlpBeneficiaires.Controls.Clear()         ' dispose ?
                If Not .Count > 0 Then
                    FlpBeneficiaires.Controls.Add(New Label With {.Text = "Aucun bénéficiaire n'a été spécifié.", .AutoSize = True})
                Else
                    For Each men In _csnSelect.MentionsBenefs
                        FlpBeneficiaires.Controls.Add(New Label With {.Text = men.Beneficiaire.NomComplet, .AutoSize = True})
                    Next
                End If
            End With

            ' Occupants
            ' de emplacement -> get défunts dont c'est le séjour actuel
            If _csnSelect.Emplacement IsNot Nothing Then

                FlpOccupants.Controls.Clear()

            End If
            ' Commentaire
            If _csnSelect.Commentaire <> "" Then
                GbCommentaire.Visible = True
                LabCommentaireCsn.Text = _csnSelect.Commentaire
            Else
                GbCommentaire.Visible = False
                LabCommentaireCsn.Text = ""
            End If
        End If
    End Sub

    Private Sub BtMontrerExpirees_Click(sender As Object, e As EventArgs) Handles BtMontrerExpirees.Click
        BtMontrerExpirees.Visible = False
        Dim idconcselect As Integer? = If(DgvConcessions.SelectedRows.Count > 0, CType(DgvConcessions.SelectedRows(0).DataBoundItem, Concession.InfosPourListe).Id, Nothing)
        ChargerListe(True)
        If idconcselect IsNot Nothing Then
            Dim rowselect = (From r As DataGridViewRow In DgvConcessions.Rows
                             Where r.DataBoundItem.id = idconcselect) _
                            .FirstOrDefault
            If rowselect IsNot Nothing Then rowselect.Selected = True
        End If
    End Sub

    Private Sub DgvConcessions_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvConcessions.KeyDown
        If e.KeyCode = Keys.Enter Then
            DialogResult = DialogResult.OK
            Me.Close()
            e.Handled = True
        End If
    End Sub

    Private Sub DgvConcessions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvConcessions.CellDoubleClick

    End Sub

    Private Sub BtTermine_Click(sender As Object, e As EventArgs) Handles BtTermine.Click
        DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class