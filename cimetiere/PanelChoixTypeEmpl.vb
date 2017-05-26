Public Class PanelChoixTypeEmpl

    Sub New()
        InitializeComponent()
        OffChkCavCom(Nothing, Nothing)        ' désactive checkbox 'caveau communal' si choix non sélectionné
    End Sub

    Public Event SelectionChanged()
    Private Sub Nimportequoi_CheckedChanged(sender As Object, e As EventArgs) Handles RbTypeEmpl10.CheckedChanged, RbTypeEmpl1a.CheckedChanged, RbTypeEmpl1b.CheckedChanged, RbTypeEmpl2a.CheckedChanged,
                                                      RbTypeEmpl2b.CheckedChanged, RbTypeEmpl3a.CheckedChanged, RbTypeEmpl3b.CheckedChanged, RbTypeEmpl4a.CheckedChanged,
                                                      RbTypeEmpl4b.CheckedChanged, RbTypeEmpl5.CheckedChanged, RbTypeEmpl6.CheckedChanged, RbTypeEmpl7.CheckedChanged,
                                                      RbTypeEmpl8.CheckedChanged, RbTypeEmpl9.CheckedChanged, cbCaveauCom.CheckedChanged
        If Not (TypeOf sender Is RadioButton AndAlso sender.checked = False) Then RaiseEvent SelectionChanged()   ' ne traite pas les dé-check des radio button pour ne pas lancer l'évènement deux fois
    End Sub

    Public Function GetChoix() As String
        Dim choice As String = ""
        Select Case True
            Case RbTypeEmpl1a.Checked
                choice = "pl_ordinaire_cercueil"
            Case RbTypeEmpl1b.Checked
                choice = "pl_ordinaire_urne"
            Case RbTypeEmpl2a.Checked
                choice = "pl_1pers_15ans_cercueil"
            Case RbTypeEmpl2b.Checked
                choice = "pl_1pers_15ans_urne"
            Case RbTypeEmpl3a.Checked
                choice = "pl_2pers_15ans_cercueil"
            Case RbTypeEmpl3b.Checked
                choice = "pl_2pers_15ans_urne"
            Case RbTypeEmpl4a.Checked
                choice = If(Not cbCaveauCom.Checked, "caveau_30ans_cercueil", "caveau_30ans_cercueil_cavcom")
            Case RbTypeEmpl4b.Checked
                choice = If(Not cbCaveauCom.Checked, "caveau_30ans_urne", "caveau_30ans_urne_cavcom")
            Case RbTypeEmpl5.Checked
                choice = "ouverture_caveau"
            Case RbTypeEmpl6.Checked
                choice = "urne_colomb_ordinaire"
            Case RbTypeEmpl7.Checked
                choice = "urne_colomb_15ans"
            Case RbTypeEmpl8.Checked
                choice = "urne_colomb_30ans"
            Case RbTypeEmpl9.Checked
                choice = "cavurne_communal"
            Case RbTypeEmpl10.Checked
                choice = "dispersion_cendres"
        End Select
        Return choice
    End Function

    ' Ergonomie

    ' obsolète
    ' si on clique sur un sous-choix 'cercueil/urne', active le choix parent
    'Private Sub RbTypeEmplSous_Click(sender As Object, e As EventArgs)
    '    If sender.checked Then
    '        Select Case sender.Name
    '            Case "RbTypeEmpl1a", "RbTypeEmpl1b"
    '                RbTypeEmpl1.Checked = True
    '            Case "RbTypeEmpl2a", "RbTypeEmpl2b"
    '                RbTypeEmpl2.Checked = True
    '            Case "RbTypeEmpl3a", "RbTypeEmpl3b"
    '                RbTypeEmpl3.Checked = True
    '            Case "RbTypeEmpl4a", "RbTypeEmpl4b"
    '                RbTypeEmpl4.Checked = True
    '        End Select
    '    End If
    'End Sub

    '' obsolète
    '' désélectionne la sous-option quand une option est désélectionnée
    'Private Sub RbTypeEmpl1_CheckedChanged(sender As Object, e As EventArgs)
    '    If Not sender.Checked Then
    '        Select Case sender.Name
    '            Case "RbTypeEmpl1"
    '                RbTypeEmpl1a.Checked = False
    '                RbTypeEmpl1b.Checked = False
    '            Case "RbTypeEmpl2"
    '                RbTypeEmpl2a.Checked = False
    '                RbTypeEmpl2b.Checked = False
    '            Case "RbTypeEmpl3"
    '                RbTypeEmpl3a.Checked = False
    '                RbTypeEmpl3b.Checked = False
    '            Case "RbTypeEmpl4"
    '                RbTypeEmpl4a.Checked = False
    '                RbTypeEmpl4b.Checked = False
    '                cbCaveauCom.Checked = False
    '        End Select
    '    End If
    'End Sub

    ' (dés) active la checkbox quand pas pertinente
    Private Sub OffChkCavCom(sender As Object, e As EventArgs) Handles RbTypeEmpl4a.CheckedChanged, RbTypeEmpl4b.CheckedChanged
        cbCaveauCom.Enabled = RbTypeEmpl4a.Checked Or RbTypeEmpl4b.Checked
    End Sub

End Class
