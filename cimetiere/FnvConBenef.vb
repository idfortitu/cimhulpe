'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class FnvConBenef
    Public Property Id As Integer
    Public Property Nom As String
    Public Property Prenom As String
    Public Property DateNaiss As Nullable(Of Date)
    Public Property LienParente As String
    Public Property Adresse As String
    Public Property Ville As String
    Public Property Cp As Nullable(Of Integer)
    Public Property Pays As String
    Public Property FkDemNvcon As Integer

    Public Overridable Property DemNvCon As DemandeNvConcession

End Class
