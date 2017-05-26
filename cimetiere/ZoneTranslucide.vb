Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging

' adapté de https://www.codeproject.com/Articles/4390/AlphaBlendTextBox-A-transparent-translucent-textbo

Public Class ZoneTranslucide
    Inherits Control
    Private myUpToDate As Boolean = False
    Private myBitmap As Bitmap
    Private myAlphaBitmap As Bitmap

    Private myBackColor As Color = Color.White
    Private myBackAlpha As Integer = 10

    Public Sub New()
        Me.BackColor = myBackColor
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Protected Overrides Sub OnGiveFeedback(gfbevent As GiveFeedbackEventArgs)
        MyBase.OnGiveFeedback(gfbevent)
        myUpToDate = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        myUpToDate = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        MyBase.OnLostFocus(e)
        myUpToDate = False
        Me.Invalidate()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = win32.WM_PAINT Then
            If Not myUpToDate Then
                GetBitmaps()
            End If
            myUpToDate = True
        End If
    End Sub

    Public Shadows Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set
            myBackColor = Value
            MyBase.BackColor = Value
            myUpToDate = False
        End Set
    End Property

    Private Sub GetBitmaps()

        If myBitmap Is Nothing _
        OrElse myAlphaBitmap Is Nothing _
        OrElse myBitmap.Width <> Width _
        OrElse myBitmap.Height <> Height _
        OrElse myAlphaBitmap.Width <> Width _
        OrElse myAlphaBitmap.Height <> Height Then
            myBitmap = Nothing
            myAlphaBitmap = Nothing
        End If

        If myBitmap Is Nothing Then
            myBitmap = New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
            myUpToDate = False
        End If

        If Not myUpToDate Then
            ' Capture the control window
            Me.SetStyle(ControlStyles.UserPaint, False)
            win32.CaptureWindow(Me, myBitmap)

            Me.SetStyle(ControlStyles.UserPaint, True)
            Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            Me.BackColor = Color.FromArgb(myBackAlpha, myBackColor)
        End If

        Dim r2 As New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height)
        Dim tempImageAttr As New ImageAttributes()

        Dim tempColorMap As ColorMap() = New ColorMap(0) {}
        tempColorMap(0) = New ColorMap()
        tempColorMap(0).OldColor = Color.FromArgb(255, myBackColor)
        tempColorMap(0).NewColor = Color.FromArgb(myBackAlpha, myBackColor)

        tempImageAttr.SetRemapTable(tempColorMap)

        If myAlphaBitmap IsNot Nothing Then
            myAlphaBitmap.Dispose()
        End If

        myAlphaBitmap = New Bitmap(Me.ClientRectangle.Width, Me.ClientRectangle.Height)
        Me.BackgroundImage = myAlphaBitmap

    End Sub

    <Category("Appearance"), Description("The alpha value used to blend the control's background. Valid values are 0 through 255."), Browsable(True), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BackAlpha() As Integer
        Get
            Return myBackAlpha
        End Get
        Set
            Dim v As Integer = Value
            If v > 255 Then
                v = 255
            End If
            myBackAlpha = v
            myUpToDate = False
            Invalidate()
        End Set
    End Property

    Public Class win32

        Public Const WM_PAINT As Integer = &HF
        Public Const WM_PRINT As Integer = &H317

        Const PRF_CLIENT As Long = &H4L
        Const PRF_ERASEBKGND As Long = &H8L
        Const PRF_OWNED As Long = &H20L

        <DllImport("USER32.DLL", EntryPoint:="SendMessage")>
        Public Shared Function SendMessage(hwnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As Integer
        End Function

        Public Shared Function CaptureWindow(control As System.Windows.Forms.Control, ByRef bitmap As System.Drawing.Bitmap) As Boolean
            'This function captures the contents of a window or control
            Dim g2 As Graphics = Graphics.FromImage(bitmap)
            Dim meint As Integer = CInt(PRF_CLIENT Or PRF_ERASEBKGND)
            Dim meptr As New System.IntPtr(meint)
            Dim hdc As System.IntPtr = g2.GetHdc()
            win32.SendMessage(control.Handle, win32.WM_PRINT, hdc, meptr)
            g2.ReleaseHdc(hdc)
            g2.Dispose()
            Return True
        End Function



    End Class
End Class
