' sert juste à forcer un type entité dans des fonctions (au moins Bdd.Add(IEntity))

Public Class IEntity

    ' ne pas utiliser comme type générique du style Function machin(Of T as IEntity) ou Function machin(arg as IEntity),
    ' mais utiliser IEntityInterface (qui garantit qu'il y a un Id)

    ' vérifie que deux entités n'ont pas d'infos contradictoires
    ' ignore un champ si celui-ci est est vide chez au moins une des deux entités
    ' pour les strings, ne tient pas compte de la casse et, en option, fait une comparaison "tolérante" (ignore les espaces/ponctuation/accents)
    ' Renvoie les champs différents sous forme d'un dictionnaire "nom de la propriété" => boolean est_différent
    Public Function Differences(csnr2 As IEntity, Optional Tolerant As Boolean = False) As Dictionary(Of String, Boolean)
        Dim props = csnr2.GetType.GetProperties
        Dim res As New Dictionary(Of String, Boolean)
        Dim StrDiff As Func(Of String, String, Boolean) =
            If(Tolerant, Function(s1, s2) Not UzineAGaz.MemesLettres(s1, s2),
                         Function(s1, s2) Not String.Compare(s1, s2, True) = 0)
        Dim tp As Type
        For Each prop In props
            tp = prop.PropertyType
            ' ne pas comparer les id
            If prop.Name <> "Id" And (tp.IsValueType Or tp Is GetType(String)) Then
                ' si type string
                If tp Is GetType(String) Then
                    val1 = prop.GetValue(Me, Nothing)
                    val2 = prop.GetValue(csnr2, Nothing)
                    res.Add(prop.Name, val1 <> Nothing AndAlso val2 <> Nothing AndAlso StrDiff(val1, val2))
                    ' si nullable, en tenir compte
                ElseIf tp.IsGenericType AndAlso tp.GetGenericTypeDefinition() = GetType(Nullable(Of )) Then
                    val1 = prop.GetValue(Me, Nothing)
                    val2 = prop.GetValue(csnr2, Nothing)
                    res.Add(prop.Name, val1 IsNot Nothing AndAlso val2 IsNot Nothing AndAlso val1 <> val2)
                    ' si autre, comparaison normale
                ElseIf tp.IsValueType Then
                    val1 = prop.GetValue(Me, Nothing)
                    val2 = prop.GetValue(csnr2, Nothing)
                    res.Add(prop.Name, prop.GetValue(Me, Nothing) <> prop.GetValue(csnr2, Nothing))
                End If
                ' si collection ou objet, pas de comparaison (éviter les props de navigation)
            End If
        Next
        Return res
    End Function

    Public Class Condense
        Public Property Id As Integer?
        Public Property Texte As String
        Public Overrides Function ToString() As String
            Return Me.Texte
        End Function
    End Class

End Class
