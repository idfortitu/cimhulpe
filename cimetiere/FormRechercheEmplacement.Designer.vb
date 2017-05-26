<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRechercheEmplacement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRechercheEmplacement))
        Me.PlanCimetiere1 = New cimetiere.PlanCimetiere()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlanCimetiere1
        '
        Me.PlanCimetiere1.BackgroundImage = CType(resources.GetObject("PlanCimetiere1.BackgroundImage"), System.Drawing.Image)
        Me.PlanCimetiere1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlanCimetiere1.IdEmplSelect = -1
        Me.PlanCimetiere1.Location = New System.Drawing.Point(0, 0)
        Me.PlanCimetiere1.Name = "PlanCimetiere1"
        Me.PlanCimetiere1.Size = New System.Drawing.Size(670, 817)
        Me.PlanCimetiere1.TabIndex = 0
        Me.PlanCimetiere1.ZoneEmplSelect = Nothing
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PlanCimetiere1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 650)
        Me.Panel1.TabIndex = 1
        '
        'FormRechercheEmplacement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 662)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormRechercheEmplacement"
        Me.Text = "FormRechercheEmplacement"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlanCimetiere1 As PlanCimetiere
    Friend WithEvents Panel1 As Panel
End Class
