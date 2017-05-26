<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SimpleQuestion
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
        Me.PanelLabel = New System.Windows.Forms.Panel()
        Me.LeLabel = New System.Windows.Forms.Label()
        Me.FlowPanelOptions = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelLabel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLabel
        '
        Me.PanelLabel.AutoSize = True
        Me.PanelLabel.Controls.Add(Me.LeLabel)
        Me.PanelLabel.Location = New System.Drawing.Point(0, 0)
        Me.PanelLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLabel.Name = "PanelLabel"
        Me.PanelLabel.Size = New System.Drawing.Size(303, 44)
        Me.PanelLabel.TabIndex = 1
        '
        'LeLabel
        '
        Me.LeLabel.AutoEllipsis = True
        Me.LeLabel.AutoSize = True
        Me.LeLabel.Location = New System.Drawing.Point(4, 12)
        Me.LeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LeLabel.Name = "LeLabel"
        Me.LeLabel.Size = New System.Drawing.Size(54, 17)
        Me.LeLabel.TabIndex = 1
        Me.LeLabel.Text = "zaezae"
        '
        'FlowPanelOptions
        '
        Me.FlowPanelOptions.AutoSize = True
        Me.FlowPanelOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowPanelOptions.Location = New System.Drawing.Point(310, 0)
        Me.FlowPanelOptions.MaximumSize = New System.Drawing.Size(150, 0)
        Me.FlowPanelOptions.MinimumSize = New System.Drawing.Size(150, 0)
        Me.FlowPanelOptions.Name = "FlowPanelOptions"
        Me.FlowPanelOptions.Size = New System.Drawing.Size(150, 0)
        Me.FlowPanelOptions.TabIndex = 2
        '
        'SimpleQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.FlowPanelOptions)
        Me.Controls.Add(Me.PanelLabel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SimpleQuestion"
        Me.Size = New System.Drawing.Size(683, 48)
        Me.PanelLabel.ResumeLayout(False)
        Me.PanelLabel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelLabel As Panel
    Friend WithEvents LeLabel As Label
    Friend WithEvents FlowPanelOptions As FlowLayoutPanel
End Class
