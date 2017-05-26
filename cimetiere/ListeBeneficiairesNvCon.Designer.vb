<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListeBeneficiairesNvCon
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
        Me.LabTitre = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btAjoutBenef = New System.Windows.Forms.Button()
        Me.LbSuggestions = New cimetiere.ListboxEntites()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabTitre
        '
        Me.LabTitre.AutoSize = True
        Me.LabTitre.Location = New System.Drawing.Point(5, 1)
        Me.LabTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTitre.Name = "LabTitre"
        Me.LabTitre.Size = New System.Drawing.Size(32, 17)
        Me.LabTitre.TabIndex = 7
        Me.LabTitre.Text = "titre"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btAjoutBenef)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 20)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(32, 31)
        Me.FlowLayoutPanel1.TabIndex = 8
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'btAjoutBenef
        '
        Me.btAjoutBenef.Image = Global.cimetiere.My.Resources.Resources.Add_16x
        Me.btAjoutBenef.Location = New System.Drawing.Point(0, 1)
        Me.btAjoutBenef.Margin = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.btAjoutBenef.Name = "btAjoutBenef"
        Me.btAjoutBenef.Size = New System.Drawing.Size(32, 30)
        Me.btAjoutBenef.TabIndex = 0
        Me.btAjoutBenef.UseVisualStyleBackColor = True
        '
        'LbSuggestions
        '
        Me.LbSuggestions.BackColor = System.Drawing.Color.LightYellow
        Me.LbSuggestions.DataSource = Nothing
        Me.LbSuggestions.DisplayMember = "Nom"
        Me.LbSuggestions.Filtre = ""
        Me.LbSuggestions.FormattingEnabled = True
        Me.LbSuggestions.IntegralHeight = False
        Me.LbSuggestions.ItemHeight = 16
        Me.LbSuggestions.Location = New System.Drawing.Point(65, 21)
        Me.LbSuggestions.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
        Me.LbSuggestions.Name = "LbSuggestions"
        Me.LbSuggestions.Size = New System.Drawing.Size(132, 45)
        Me.LbSuggestions.TabIndex = 9
        Me.LbSuggestions.TabStop = False
        Me.LbSuggestions.ValueMember = "Id"
        '
        'ListeBeneficiairesNvCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.Controls.Add(Me.LbSuggestions)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.LabTitre)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ListeBeneficiairesNvCon"
        Me.Size = New System.Drawing.Size(874, 67)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btAjoutBenef As Button
    Friend WithEvents LabTitre As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents LbSuggestions As ListboxEntites
End Class
