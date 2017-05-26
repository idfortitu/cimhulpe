<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dvlptAjEmpl
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
        Me.PlanCimEdit1 = New cimetiere.PlanCimEdit()
        Me.SuspendLayout()
        '
        'PlanCimEdit1
        '
        Me.PlanCimEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlanCimEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PlanCimEdit1.Name = "PlanCimEdit1"
        Me.PlanCimEdit1.Size = New System.Drawing.Size(1271, 846)
        Me.PlanCimEdit1.TabIndex = 0
        '
        'dvlptAjEmpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 861)
        Me.Controls.Add(Me.PlanCimEdit1)
        Me.Name = "dvlptAjEmpl"
        Me.Text = "dvlptAjEmpl"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlanCimEdit1 As PlanCimEdit
End Class
