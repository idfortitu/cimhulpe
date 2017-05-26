Public Class FormEmplacements
    Private ListeEmplacements As List(Of Emplacement)
    Private ListeEmplacementsBind As SortableBindingList(Of Emplacement)

    Public Sub New()
        ' This call is required by the designer.

    End Sub
    Sub OnPlanSelectionChanged(sender As PlanCimetiere, e As PlanCimetiere.PlanCimEventArgs) Handles PlanCimetiere1.SelectionChanged
        ' Identifie la row d'après sa colonne Id... il doit y avoir plus optimal, name, dictionnaire ?
        If PlanCimetiere1.IdEmplSelect <> -1 Then
            Dim laligne As DataGridViewRow = (From l In DataGridView1.Rows()
                                              Where l.cells("Id").value = PlanCimetiere1.IdEmplSelect).Single
            laligne.Selected = True

            'If Not laligne.Displayed Then DataGridView1.FirstDisplayedScrollingRowIndex = laligne.Index
            ' Scrolle si la ligne n'est affichée, ou pas entièrement
            ' suppose qu'il y ait au moins une ligne (en plus de l'Id, invisible)
            If Not laligne.Displayed Or
                DataGridView1.GetCellDisplayRectangle(1, laligne.Index, True).Height _
                   < DataGridView1.GetCellDisplayRectangle(1, laligne.Index, False).Height Then
                DataGridView1.FirstDisplayedScrollingRowIndex = laligne.Index
            End If
        Else
            DataGridView1.ClearSelection()
        End If
    End Sub

    Sub OnListEmplSelect(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count = 0 Then
            PlanCimetiere1.IdEmplSelect = -1
        Else
            PlanCimetiere1.IdEmplSelect = DataGridView1.SelectedRows(0).Cells("Id").Value
        End If
    End Sub


End Class