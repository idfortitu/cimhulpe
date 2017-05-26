Imports System.Runtime.InteropServices
Imports System.ComponentModel


Public Class TextBoxCBanner
    Inherits TextBox
    'Private _cueBanner As String        ' en principe il faudrait le lire avec une fonction windows mais le code fait planter le programme

    <DllImport("USER32.DLL", EntryPoint:="SendMessage")>
    Public Shared Function SendMessage(hwnd As IntPtr, msg As UInt32, wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Integer
    End Function

    Private Property _cueBanner
    <Category("Appearance"), Description("Texte grisé qui apparaît quand la boîte est vide"), Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property CueBanner As String
        Get
            Return _cueBanner
            '    Get
            '        'Dim res As String = Space(510)      ' censé réserver de la place pour le texte renvoyé
            '        'SendMessage(Me.Handle, &H1502, 0, res)   ' &H1502 = EM_GETCUEBANNER
            '        'Return res
        End Get
        Set(value As String)
            _cueBanner = value
            SendMessage(Me.Handle, &H1501, 0, value)    ' &H1501 = EM_SETCUEBANNER
        End Set
    End Property
End Class
