<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopupRecherche
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LbListeEntrees = New System.Windows.Forms.ListBox()
        Me.TbChampRecherche = New System.Windows.Forms.TextBox()
        Me.BtRechercher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbListeEntrees
        '
        Me.LbListeEntrees.FormattingEnabled = True
        Me.LbListeEntrees.Location = New System.Drawing.Point(5, 45)
        Me.LbListeEntrees.Name = "LbListeEntrees"
        Me.LbListeEntrees.Size = New System.Drawing.Size(227, 95)
        Me.LbListeEntrees.TabIndex = 3
        '
        'TbChampRecherche
        '
        Me.TbChampRecherche.Location = New System.Drawing.Point(5, 4)
        Me.TbChampRecherche.Name = "TbChampRecherche"
        Me.TbChampRecherche.Size = New System.Drawing.Size(134, 20)
        Me.TbChampRecherche.TabIndex = 1
        '
        'BtRechercher
        '
        Me.BtRechercher.Image = Global.cimetiere.My.Resources.Resources.SearchContract_16x
        Me.BtRechercher.Location = New System.Drawing.Point(145, 4)
        Me.BtRechercher.Name = "BtRechercher"
        Me.BtRechercher.Size = New System.Drawing.Size(27, 20)
        Me.BtRechercher.TabIndex = 2
        Me.BtRechercher.TabStop = False
        Me.BtRechercher.UseVisualStyleBackColor = True
        '
        'PopupRecherche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LbListeEntrees)
        Me.Controls.Add(Me.TbChampRecherche)
        Me.Controls.Add(Me.BtRechercher)
        Me.Name = "PopupRecherche"
        Me.Size = New System.Drawing.Size(258, 156)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbListeEntrees As ListBox
    Friend WithEvents TbChampRecherche As TextBox
    Friend WithEvents BtRechercher As Button
End Class
