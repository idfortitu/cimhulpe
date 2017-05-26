Public Class PlanCimetiere

    'Public :
    ' Sub AddListeEmplacements(empls as List(Of Emplacement))
    '  /!\ le contrôle créé reste lié à l'objet Emplacement, mais son nom/id et propriétés visuelles ne changent plus même si l'objet Emplacement est modifié

    ' Evènements : EmplClicked, EmplDoubleClicked, SelectionChanged (ce dernier n'est pas lancé si on reclique sur une zone déjà sélectionnée)
    '  avec (sender as PlanCimetiere, e as PlanCimEventArgs)
    '  où PlanCimEventArgs comprend .ZoneEmpl (le contrôle concerné), qui à son tour comprend .EmplacementLie (l'objet Emplacement)
    '  (attention, .ZoneEmpl peut être Nothing pour l'evt SelectionChanged)


    ' Ne gère pas spécialement les emplacements sans id, ne prévoit pas qu'un emplacement puisse changer d'id (ni de n'importe quoi en fait)

    Const PARCELLE = ""     ' critère de recherche pour récupérer les emplacements en bdd. Une chaîne vide sera interprétée comme "tous"
    Const NOMFIC_IMAGE_PLAN = "planA3.JPG"
    Const PREFIXE_CTRL_EMPL = "ctrl_empl_"
    Const LG_PREFIXE_CTRL_EMPL = 10 
    Const COORDS_ECHELLE_BASE = 2000       ' les coordonnées des emplacements sont représentées comme si l'image faisait 2000x2000, puis sont mises à l'échelle pour l'affichage
    Private CouleurZoneBase = Color.Purple    ' en faire des propriétés ?
    Private AlphaZoneBase = 100      ' sur 255
    Private CouleurZoneSelect = Color.Red
    Private AlphaZoneSelect = 180

    Private ttip As New TooltipL With {.AutoPopDelay = 1000000, .InitialDelay = 0, .ReshowDelay = 500, .ShowAlways = True}


    Public Emplacements As List(Of Emplacement)


    ' Emplacement sélectionné sur le plan
    Public Property IdEmplSelect As Integer
        Get
            If _ZoneEmplSelect IsNot Nothing Then
                Return _ZoneEmplSelect.EmplacementLie.Id
            Else
                Return -1
            End If
        End Get
        Set(value As Integer)
            Me.ZoneEmplSelect = If(value = -1, Nothing, Me.Controls(PREFIXE_CTRL_EMPL & value))
        End Set
    End Property

    Private _ZoneEmplSelect As ZoneEmplacement
    Public Property ZoneEmplSelect As ZoneEmplacement
        Get
            Return _ZoneEmplSelect
        End Get
        Set(zempl As ZoneEmplacement)
            If zempl IsNot _ZoneEmplSelect Then
                If _ZoneEmplSelect IsNot Nothing Then
                    _ZoneEmplSelect.BackColor = CouleurZoneBase
                    _ZoneEmplSelect.BackAlpha = AlphaZoneBase
                End If
                _ZoneEmplSelect = zempl
                RaiseEvent SelectionChanged(Me, New PlanCimEventArgs(zempl))
                If _ZoneEmplSelect IsNot Nothing Then
                    _ZoneEmplSelect.BackColor = CouleurZoneSelect
                    _ZoneEmplSelect.BackAlpha = AlphaZoneSelect
                End If
            End If
        End Set
    End Property

    Public Class PlanCimEventArgs
        Inherits EventArgs
        Public ZoneEmpl As ZoneEmplacement
        Sub New(empl As ZoneEmplacement)
            Me.ZoneEmpl = empl
        End Sub
    End Class

    Sub Me_Clicked(sender As Object, f As EventArgs) Handles Me.Click
        ZoneEmplSelect = Nothing
    End Sub

    Delegate Sub EmplClickEventHandler(sender As Object, e As PlanCimEventArgs)             ' utile ? tester sans
    Public Event EmplClicked As EmplClickEventHandler
    Private Sub RaiseEmplClicked(sender As ZoneEmplacement, e As EventArgs)        ' handler lié à chaque zone
        RaiseEvent EmplClicked(Me, New PlanCimEventArgs(sender))
        ZoneEmplSelect = sender
    End Sub

    Delegate Sub EmplDoubleClickEventHandler(sender As Object, e As PlanCimEventArgs)             ' utile ? tester sans
    Public Event EmplDoubleClicked As EmplDoubleClickEventHandler
    Private Sub RaiseEmplDoubleClicked(sender As ZoneEmplacement, e As EventArgs)        ' handler lié à chaque zone
        RaiseEvent EmplDoubleClicked(Me, New PlanCimEventArgs(sender))
    End Sub

    Delegate Sub SelectionChangedEventHandler(sender As Object, e As PlanCimEventArgs)             ' utile ? tester sans
    Public Event SelectionChanged As SelectionChangedEventHandler

    Public Sub AddListeEmplacements(empls As List(Of Emplacement))
        If Not DesignMode Then
            For Each empl In empls
                Me.AddEmplacement(empl)
            Next
        End If
    End Sub

    ' Crée le contrôle pour un emplacement
    Private Sub AddEmplacement(empl As Emplacement)

        ' Ne rien faire si un emplacement avec cet id existe déjà
        Dim NomCtrl As String = PREFIXE_CTRL_EMPL & empl.Id
        If Me.Controls(NomCtrl) IsNot Nothing Then
            Return
        End If

        Dim ctrl As ZoneEmplacement = Nothing

        Try     ' intercepte à la grosse louche ce qui peut foirer quand les coordonnées sont incorrectes

            ' à faire : ramener les coords à l'échelle de la taille de l'image / du contrôle
            ' donne la position (pluspetitx,pluspetity) et sa forme (liste de points poly) du contrôle à partir des coordonnées de l'empl
            Dim pluspetitx As Integer = 65535
            Dim plusgrandx As Integer = 0
            Dim pluspetity As Integer = 65535
            Dim plusgrandy As Integer = 0
            Dim poly((empl.Coords.Count >> 2) - 1) As Point
            Dim rapport_l As Single = COORDS_ECHELLE_BASE / Me.Size.Width
            Dim rapport_h As Single = COORDS_ECHELLE_BASE / Me.Size.Height

            Dim i_poly As Integer = 0
            Dim i_coords As Integer = 0


            Dim tmpx, tmpy As Integer
            While i_coords < empl.Coords.Count
                tmpx = empl.Coords(i_coords)
                i_coords += 1
                tmpx += empl.Coords(i_coords) * &H100              ' cast ? memorystream ?
                i_coords += 1

                tmpx /= rapport_l

                If tmpx < pluspetitx Then
                    pluspetitx = tmpx
                ElseIf tmpx > plusgrandx Then
                    plusgrandx = tmpx
                End If

                tmpy = empl.Coords(i_coords)
                i_coords += 1
                tmpy += empl.Coords(i_coords) * &H100
                i_coords += 1

                tmpy /= rapport_h

                If tmpy < pluspetity Then
                    pluspetity = tmpy
                ElseIf tmpy > plusgrandy Then
                    plusgrandy = tmpy
                End If

                poly(i_poly) = New Point(tmpx, tmpy)
                i_poly += 1
            End While


            ' Translation, ramène la forme au niveau du coin supérieur gauche du contrôle (sa position d'origine étant par rapport au coin sup gauche du plan)
            i_poly = 0
            While i_poly < poly.Count
                poly(i_poly).X -= pluspetitx
                poly(i_poly).Y -= pluspetity
                i_poly += 1
            End While

            ctrl = New ZoneEmplacement
            ctrl.Location = New Point(pluspetitx, pluspetity)
            ctrl.Size = New Size(plusgrandx - pluspetitx, plusgrandy - pluspetity)
            Dim forme As New System.Drawing.Drawing2D.GraphicsPath
            forme.AddPolygon(poly)
            ctrl.Region = New System.Drawing.Region(forme)
            ctrl.BackColor = Color.Purple ''
            ctrl.BackAlpha = AlphaZoneBase

            ctrl.EmplacementLie = empl

            ctrl.Name = NomCtrl

            Dim txttip As String = empl.Reference & Environment.NewLine & empl.Type
            ' À FAIRE :  continuer texte tooltip descriptif
            ' il faudrait afficher le nombre de places libres, mais ça demande une jointure avec la table séjours
            'ttip.SetToolTip(ctrl.myPictureBox, txttip)
            ttip.SetToolTip(ctrl, txttip)

            AddHandler ctrl.Click, AddressOf RaiseEmplClicked
            AddHandler ctrl.DoubleClick, AddressOf RaiseEmplDoubleClicked

        Catch ex As Exception
            If ctrl IsNot Nothing Then
                ctrl.Dispose()
                ctrl = Nothing
            End If
        End Try

        If ctrl IsNot Nothing Then Me.Controls.Add(ctrl)

    End Sub



    '''''  test




    ' à faire éventuellement : mettre à jour la position et forme des contrôles emplacements au resize

    Function GetCtrlEmplById(Id As Integer) As ZoneEmplacement    ' As à changer si les contrôles utilisent une autre classe
        Return Me.Controls(PREFIXE_CTRL_EMPL & Id)               ' voir si cast nécessaire ' à faire : tester ce qui se passe si le contrôle n'existe pas
    End Function

    Sub zea() Handles Me.Load

        Me.BackgroundImage = Image.FromFile(NOMFIC_IMAGE_PLAN)

        ' (exemple d'ajout d'un contrôle ZoneEmplacement)
        'Dim osef = New ZoneEmplacement
        'osef.Size = New Size(40, 40)
        'osef.Location = New Point(100, 100)
        'osef.BackAlpha = 200
        'osef.BackColor = Color.Red
        'Me.Controls.Add(osef)


        ' (exemple : donner une forme à un contrôle)
        'Dim formeempl As New System.Drawing.Drawing2D.GraphicsPath()
        'Dim rectzone = New Rectangle(50, 50, 150, 150)
        ''formeempl.AddEllipse(rectzone)
        'formeempl.AddPolygon({New Point(20, 20), New Point(40, 30), New Point(50, 60), New Point(30, 70), New Point(10, 40), New Point(20, 20)})
        'zoneempl.Region = New System.Drawing.Region(formeempl)
        ''zoneempl.BackColor = Color.Purple
        ''zoneempl.Show()
        'Me.Controls.Add(zoneempl)

        'If Not DesignMode Then
        '    Dim empls = Bdd.GetEmplacements()
        '    For Each empl In empls
        '        Me.AddEmplacement(empl)
        '    Next
        'End If


    End Sub






    'Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
    ' (vieux) exemple de dessin sur le contrôle
    '    Dim opaqueBrush As New SolidBrush(Color.FromArgb(255, 0, 0, 255))
    '    Dim semiTransBrush As New SolidBrush(Color.FromArgb(128, 0, 0, 255))
    '    e.Graphics.FillEllipse(opaqueBrush, 335, 245, 45, 30)
    '    e.Graphics.FillEllipse(semiTransBrush, 386, 245, 45, 30)

    '    e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.GammaCorrected      'CompositingQuality.GammaCorrected
    '    e.Graphics.FillEllipse(semiTransBrush, 340, 290, 86, 30)
    'End Sub

    'Private Sub Button1_Paint(sender As Object, e As PaintEventArgs)
    'Dim patte As New System.Drawing.Drawing2D.GraphicsPath()
    'Dim rect As Rectangle = Button1.ClientRectangle
    'rect.Inflate(-10, -10)
    ''e.Graphics.DrawEllipse(System.Drawing.Pens.Black, rect)
    'rect.Inflate(1, 1)
    'patte.AddEllipse(rect)
    'e.Graphics.DrawPath(Pens.Black, patte)
    'Button1.Region = New System.Drawing.Region(patte)


    'Dim zoneempl As New ZoneEmplPlan
    'ZoneEmplPlan
    'Dim formeempl As New System.Drawing.Drawing2D.GraphicsPath()

    'Dim rect As Rectangle = .ClientRectangle
    'formeempl.AddEllipse()

    'Dim osef As New ZoneEmplPlan(formeempl)


    'End Sub

    Public Class ZoneEmplacement
        Inherits ZoneTranslucide
        Public EmplacementLie As Emplacement
    End Class

    ' Tooltip personnalisé d'une taille de police plus grande
    Private Class TooltipL

        Inherits ToolTip

        Public myfont = New Font(SystemFonts.DefaultFont.FontFamily, 12)
        Sub New()
            MyBase.New()
            Me.OwnerDraw = True
        End Sub
        Public Sub New(ByVal Cont As System.ComponentModel.IContainer)
            MyBase.New(Cont)
            Me.OwnerDraw = True
        End Sub
        Private Sub OnPopup(sender As Object, e As PopupEventArgs) Handles Me.Popup
            Dim s As Size = Size.Round(e.AssociatedControl.CreateGraphics().MeasureString(Me.GetToolTip(e.AssociatedControl), myfont))
            s.Height += 4
            e.ToolTipSize = s
        End Sub
        Private Sub OnDraw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs) Handles Me.Draw
            newe = New DrawToolTipEventArgs(e.Graphics, e.AssociatedWindow, e.AssociatedControl, e.Bounds, e.ToolTipText, Me.BackColor, Me.ForeColor,
                                            myfont)
            newe.DrawBackground()
            newe.DrawBorder()
            newe.DrawText(TextFormatFlags.LeftAndRightPadding)
        End Sub

    End Class





End Class
