<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProlongation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProlongation))
        Me.ProlongRBCaveau = New System.Windows.Forms.RadioButton()
        Me.ProlongLabelEndroit = New System.Windows.Forms.Label()
        Me.ProlongRBColumb = New System.Windows.Forms.RadioButton()
        Me.ProlongRBpleineterr = New System.Windows.Forms.RadioButton()
        Me.ProlongLabRemarque = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProlongTBLien = New System.Windows.Forms.TextBox()
        Me.ProlongTBEndroit = New System.Windows.Forms.TextBox()
        Me.ProlongTBRemarque = New System.Windows.Forms.TextBox()
        Me.ProlongBTerminer = New System.Windows.Forms.Button()
        Me.FormProlPanPersDem = New System.Windows.Forms.Panel()
        Me.ListBoxCustomActeurs1 = New cimetiere.ListBoxCustomActeurs()
        Me.FormProlPanType = New System.Windows.Forms.Panel()
        Me.FormProlGBType = New System.Windows.Forms.GroupBox()
        Me.FormProlPanFormProlPanPersonne = New System.Windows.Forms.Panel()
        Me.FormProlGBPersonne = New System.Windows.Forms.GroupBox()
        Me.FormProlPanInfoSup = New System.Windows.Forms.Panel()
        Me.FormProlGBInfoSup = New System.Windows.Forms.GroupBox()
        Me.ListeBeneficiairesNvCon1 = New cimetiere.ListeBeneficiairesNvCon()
        Me.ProlongLabLien = New System.Windows.Forms.Label()
        Me.FormProlPanPersDem.SuspendLayout()
        Me.FormProlPanType.SuspendLayout()
        Me.FormProlGBType.SuspendLayout()
        Me.FormProlPanFormProlPanPersonne.SuspendLayout()
        Me.FormProlGBPersonne.SuspendLayout()
        Me.FormProlPanInfoSup.SuspendLayout()
        Me.FormProlGBInfoSup.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProlongRBCaveau
        '
        Me.ProlongRBCaveau.AutoSize = True
        Me.ProlongRBCaveau.Location = New System.Drawing.Point(31, 52)
        Me.ProlongRBCaveau.Margin = New System.Windows.Forms.Padding(4)
        Me.ProlongRBCaveau.Name = "ProlongRBCaveau"
        Me.ProlongRBCaveau.Size = New System.Drawing.Size(184, 21)
        Me.ProlongRBCaveau.TabIndex = 145
        Me.ProlongRBCaveau.TabStop = True
        Me.ProlongRBCaveau.Text = "Emplacement en caveau"
        Me.ProlongRBCaveau.UseVisualStyleBackColor = True
        '
        'ProlongLabelEndroit
        '
        Me.ProlongLabelEndroit.AutoSize = True
        Me.ProlongLabelEndroit.Location = New System.Drawing.Point(8, 70)
        Me.ProlongLabelEndroit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProlongLabelEndroit.Name = "ProlongLabelEndroit"
        Me.ProlongLabelEndroit.Size = New System.Drawing.Size(401, 17)
        Me.ProlongLabelEndroit.TabIndex = 126
        Me.ProlongLabelEndroit.Text = "Situation approximative de l'endroit où se trouve la sépulture : "
        '
        'ProlongRBColumb
        '
        Me.ProlongRBColumb.AutoSize = True
        Me.ProlongRBColumb.Location = New System.Drawing.Point(31, 80)
        Me.ProlongRBColumb.Margin = New System.Windows.Forms.Padding(4)
        Me.ProlongRBColumb.Name = "ProlongRBColumb"
        Me.ProlongRBColumb.Size = New System.Drawing.Size(218, 21)
        Me.ProlongRBColumb.TabIndex = 146
        Me.ProlongRBColumb.TabStop = True
        Me.ProlongRBColumb.Text = "Emplacement en columbarium"
        Me.ProlongRBColumb.UseVisualStyleBackColor = True
        '
        'ProlongRBpleineterr
        '
        Me.ProlongRBpleineterr.AutoSize = True
        Me.ProlongRBpleineterr.Location = New System.Drawing.Point(31, 23)
        Me.ProlongRBpleineterr.Margin = New System.Windows.Forms.Padding(4)
        Me.ProlongRBpleineterr.Name = "ProlongRBpleineterr"
        Me.ProlongRBpleineterr.Size = New System.Drawing.Size(210, 21)
        Me.ProlongRBpleineterr.TabIndex = 154
        Me.ProlongRBpleineterr.TabStop = True
        Me.ProlongRBpleineterr.Text = "Emplacement en pleine terre"
        Me.ProlongRBpleineterr.UseVisualStyleBackColor = True
        '
        'ProlongLabRemarque
        '
        Me.ProlongLabRemarque.AutoSize = True
        Me.ProlongLabRemarque.Location = New System.Drawing.Point(8, 118)
        Me.ProlongLabRemarque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProlongLabRemarque.Name = "ProlongLabRemarque"
        Me.ProlongLabRemarque.Size = New System.Drawing.Size(158, 17)
        Me.ProlongLabRemarque.TabIndex = 155
        Me.ProlongLabRemarque.Text = "Remarque éventuelles :"
        '
        'Button3
        '
        Me.Button3.Image = Global.cimetiere.My.Resources.Resources.Table_16x
        Me.Button3.Location = New System.Drawing.Point(407, 66)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 25)
        Me.Button3.TabIndex = 158
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProlongTBLien
        '
        Me.ProlongTBLien.Location = New System.Drawing.Point(12, 42)
        Me.ProlongTBLien.Margin = New System.Windows.Forms.Padding(4)
        Me.ProlongTBLien.Name = "ProlongTBLien"
        Me.ProlongTBLien.Size = New System.Drawing.Size(132, 22)
        Me.ProlongTBLien.TabIndex = 159
        '
        'ProlongTBEndroit
        '
        Me.ProlongTBEndroit.Location = New System.Drawing.Point(12, 90)
        Me.ProlongTBEndroit.Margin = New System.Windows.Forms.Padding(4)
        Me.ProlongTBEndroit.Name = "ProlongTBEndroit"
        Me.ProlongTBEndroit.Size = New System.Drawing.Size(132, 22)
        Me.ProlongTBEndroit.TabIndex = 160
        '
        'ProlongTBRemarque
        '
        Me.ProlongTBRemarque.Location = New System.Drawing.Point(12, 138)
        Me.ProlongTBRemarque.Margin = New System.Windows.Forms.Padding(4)
        Me.ProlongTBRemarque.Name = "ProlongTBRemarque"
        Me.ProlongTBRemarque.Size = New System.Drawing.Size(132, 22)
        Me.ProlongTBRemarque.TabIndex = 161
        '
        'ProlongBTerminer
        '
        Me.ProlongBTerminer.Location = New System.Drawing.Point(597, 897)
        Me.ProlongBTerminer.Margin = New System.Windows.Forms.Padding(4)
        Me.ProlongBTerminer.Name = "ProlongBTerminer"
        Me.ProlongBTerminer.Size = New System.Drawing.Size(100, 28)
        Me.ProlongBTerminer.TabIndex = 162
        Me.ProlongBTerminer.Text = "Terminer"
        Me.ProlongBTerminer.UseVisualStyleBackColor = True
        '
        'FormProlPanPersDem
        '
        Me.FormProlPanPersDem.BackColor = System.Drawing.Color.SeaGreen
        Me.FormProlPanPersDem.Controls.Add(Me.ListBoxCustomActeurs1)
        Me.FormProlPanPersDem.Location = New System.Drawing.Point(8, 15)
        Me.FormProlPanPersDem.Margin = New System.Windows.Forms.Padding(4)
        Me.FormProlPanPersDem.Name = "FormProlPanPersDem"
        Me.FormProlPanPersDem.Size = New System.Drawing.Size(781, 188)
        Me.FormProlPanPersDem.TabIndex = 178
        '
        'ListBoxCustomActeurs1
        '
        Me.ListBoxCustomActeurs1.AspectActif = True
        Me.ListBoxCustomActeurs1.BackColor = System.Drawing.Color.GhostWhite
        Me.ListBoxCustomActeurs1.DataSource = Nothing
        Me.ListBoxCustomActeurs1.Location = New System.Drawing.Point(6, 6)
        Me.ListBoxCustomActeurs1.Name = "ListBoxCustomActeurs1"
        Me.ListBoxCustomActeurs1.Size = New System.Drawing.Size(768, 174)
        Me.ListBoxCustomActeurs1.TabIndex = 0
        '
        'FormProlPanType
        '
        Me.FormProlPanType.BackColor = System.Drawing.Color.SeaGreen
        Me.FormProlPanType.Controls.Add(Me.FormProlGBType)
        Me.FormProlPanType.Location = New System.Drawing.Point(8, 348)
        Me.FormProlPanType.Margin = New System.Windows.Forms.Padding(4)
        Me.FormProlPanType.Name = "FormProlPanType"
        Me.FormProlPanType.Size = New System.Drawing.Size(693, 126)
        Me.FormProlPanType.TabIndex = 179
        '
        'FormProlGBType
        '
        Me.FormProlGBType.BackColor = System.Drawing.Color.GhostWhite
        Me.FormProlGBType.Controls.Add(Me.ProlongRBCaveau)
        Me.FormProlGBType.Controls.Add(Me.ProlongRBpleineterr)
        Me.FormProlGBType.Controls.Add(Me.ProlongRBColumb)
        Me.FormProlGBType.Location = New System.Drawing.Point(12, 6)
        Me.FormProlGBType.Margin = New System.Windows.Forms.Padding(4)
        Me.FormProlGBType.Name = "FormProlGBType"
        Me.FormProlGBType.Padding = New System.Windows.Forms.Padding(4)
        Me.FormProlGBType.Size = New System.Drawing.Size(671, 113)
        Me.FormProlGBType.TabIndex = 0
        Me.FormProlGBType.TabStop = False
        Me.FormProlGBType.Text = "Type de sépulture"
        '
        'FormProlPanFormProlPanPersonne
        '
        Me.FormProlPanFormProlPanPersonne.BackColor = System.Drawing.Color.SeaGreen
        Me.FormProlPanFormProlPanPersonne.Controls.Add(Me.FormProlGBPersonne)
        Me.FormProlPanFormProlPanPersonne.Location = New System.Drawing.Point(8, 481)
        Me.FormProlPanFormProlPanPersonne.Margin = New System.Windows.Forms.Padding(4)
        Me.FormProlPanFormProlPanPersonne.Name = "FormProlPanFormProlPanPersonne"
        Me.FormProlPanFormProlPanPersonne.Size = New System.Drawing.Size(693, 212)
        Me.FormProlPanFormProlPanPersonne.TabIndex = 180
        '
        'FormProlGBPersonne
        '
        Me.FormProlGBPersonne.BackColor = System.Drawing.Color.GhostWhite
        Me.FormProlGBPersonne.Controls.Add(Me.ListeBeneficiairesNvCon1)
        Me.FormProlGBPersonne.Location = New System.Drawing.Point(12, 6)
        Me.FormProlGBPersonne.Margin = New System.Windows.Forms.Padding(4)
        Me.FormProlGBPersonne.Name = "FormProlGBPersonne"
        Me.FormProlGBPersonne.Padding = New System.Windows.Forms.Padding(4)
        Me.FormProlGBPersonne.Size = New System.Drawing.Size(671, 198)
        Me.FormProlGBPersonne.TabIndex = 0
        Me.FormProlGBPersonne.TabStop = False
        Me.FormProlGBPersonne.Text = "Dans cette sépulture les restes mortels de la (des) personne(s) suivante(s) :"
        '
        'FormProlPanInfoSup
        '
        Me.FormProlPanInfoSup.BackColor = System.Drawing.Color.SeaGreen
        Me.FormProlPanInfoSup.Controls.Add(Me.FormProlGBInfoSup)
        Me.FormProlPanInfoSup.Location = New System.Drawing.Point(8, 700)
        Me.FormProlPanInfoSup.Margin = New System.Windows.Forms.Padding(4)
        Me.FormProlPanInfoSup.Name = "FormProlPanInfoSup"
        Me.FormProlPanInfoSup.Size = New System.Drawing.Size(693, 191)
        Me.FormProlPanInfoSup.TabIndex = 181
        '
        'FormProlGBInfoSup
        '
        Me.FormProlGBInfoSup.BackColor = System.Drawing.Color.GhostWhite
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongLabLien)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongLabelEndroit)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongLabRemarque)
        Me.FormProlGBInfoSup.Controls.Add(Me.Button3)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongTBLien)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongTBRemarque)
        Me.FormProlGBInfoSup.Controls.Add(Me.ProlongTBEndroit)
        Me.FormProlGBInfoSup.Location = New System.Drawing.Point(12, 10)
        Me.FormProlGBInfoSup.Margin = New System.Windows.Forms.Padding(4)
        Me.FormProlGBInfoSup.Name = "FormProlGBInfoSup"
        Me.FormProlGBInfoSup.Padding = New System.Windows.Forms.Padding(4)
        Me.FormProlGBInfoSup.Size = New System.Drawing.Size(671, 172)
        Me.FormProlGBInfoSup.TabIndex = 0
        Me.FormProlGBInfoSup.TabStop = False
        Me.FormProlGBInfoSup.Text = "Informations supplémentaires"
        '
        'ListeBeneficiairesNvCon1
        '
        Me.ListeBeneficiairesNvCon1.AutoScroll = True
        Me.ListeBeneficiairesNvCon1.BackColor = System.Drawing.Color.AliceBlue
        Me.ListeBeneficiairesNvCon1.Location = New System.Drawing.Point(0, 23)
        Me.ListeBeneficiairesNvCon1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListeBeneficiairesNvCon1.Name = "ListeBeneficiairesNvCon1"
        Me.ListeBeneficiairesNvCon1.Size = New System.Drawing.Size(874, 67)
        Me.ListeBeneficiairesNvCon1.TabIndex = 162
        '
        'ProlongLabLien
        '
        Me.ProlongLabLien.AutoSize = True
        Me.ProlongLabLien.Location = New System.Drawing.Point(8, 22)
        Me.ProlongLabLien.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ProlongLabLien.Name = "ProlongLabLien"
        Me.ProlongLabLien.Size = New System.Drawing.Size(262, 17)
        Me.ProlongLabLien.TabIndex = 127
        Me.ProlongLabLien.Text = "Lien(s) de parenté avec le demandeur : "
        '
        'FormProlongation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1025, 932)
        Me.Controls.Add(Me.FormProlPanInfoSup)
        Me.Controls.Add(Me.FormProlPanFormProlPanPersonne)
        Me.Controls.Add(Me.FormProlPanType)
        Me.Controls.Add(Me.FormProlPanPersDem)
        Me.Controls.Add(Me.ProlongBTerminer)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormProlongation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProlongation"
        Me.FormProlPanPersDem.ResumeLayout(False)
        Me.FormProlPanType.ResumeLayout(False)
        Me.FormProlGBType.ResumeLayout(False)
        Me.FormProlGBType.PerformLayout()
        Me.FormProlPanFormProlPanPersonne.ResumeLayout(False)
        Me.FormProlGBPersonne.ResumeLayout(False)
        Me.FormProlPanInfoSup.ResumeLayout(False)
        Me.FormProlGBInfoSup.ResumeLayout(False)
        Me.FormProlGBInfoSup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProlongRBCaveau As System.Windows.Forms.RadioButton
    Friend WithEvents ProlongLabelEndroit As System.Windows.Forms.Label
    Friend WithEvents ProlongRBColumb As System.Windows.Forms.RadioButton
    Friend WithEvents ProlongRBpleineterr As System.Windows.Forms.RadioButton
    Friend WithEvents ProlongLabRemarque As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ProlongTBLien As System.Windows.Forms.TextBox
    Friend WithEvents ProlongTBEndroit As System.Windows.Forms.TextBox
    Friend WithEvents ProlongTBRemarque As System.Windows.Forms.TextBox
    Friend WithEvents ProlongBTerminer As System.Windows.Forms.Button
    Friend WithEvents FormProlPanPersDem As System.Windows.Forms.Panel
    Friend WithEvents FormProlPanType As System.Windows.Forms.Panel
    Friend WithEvents FormProlGBType As System.Windows.Forms.GroupBox
    Friend WithEvents FormProlPanFormProlPanPersonne As System.Windows.Forms.Panel
    Friend WithEvents FormProlGBPersonne As System.Windows.Forms.GroupBox
    Friend WithEvents FormProlPanInfoSup As System.Windows.Forms.Panel
    Friend WithEvents FormProlGBInfoSup As System.Windows.Forms.GroupBox
    Friend WithEvents ProlongLabLien As System.Windows.Forms.Label
    Friend WithEvents ListBoxCustomActeurs1 As ListBoxCustomActeurs
    Friend WithEvents ListeBeneficiairesNvCon1 As ListeBeneficiairesNvCon
End Class
