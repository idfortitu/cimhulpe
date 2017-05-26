<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanCimEdit
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tbref = New System.Windows.Forms.TextBox()
        Me.tbplaces = New System.Windows.Forms.TextBox()
        Me.tbcom = New System.Windows.Forms.TextBox()
        Me.cbclasse = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbtype = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbref
        '
        Me.tbref.Location = New System.Drawing.Point(966, 46)
        Me.tbref.Name = "tbref"
        Me.tbref.Size = New System.Drawing.Size(100, 20)
        Me.tbref.TabIndex = 1
        '
        'tbplaces
        '
        Me.tbplaces.Location = New System.Drawing.Point(966, 236)
        Me.tbplaces.Name = "tbplaces"
        Me.tbplaces.Size = New System.Drawing.Size(100, 20)
        Me.tbplaces.TabIndex = 3
        '
        'tbcom
        '
        Me.tbcom.Location = New System.Drawing.Point(966, 287)
        Me.tbcom.Name = "tbcom"
        Me.tbcom.Size = New System.Drawing.Size(100, 20)
        Me.tbcom.TabIndex = 4
        '
        'cbclasse
        '
        Me.cbclasse.AutoSize = True
        Me.cbclasse.Location = New System.Drawing.Point(966, 348)
        Me.cbclasse.Name = "cbclasse"
        Me.cbclasse.Size = New System.Drawing.Size(56, 17)
        Me.cbclasse.TabIndex = 5
        Me.cbclasse.Text = "classé"
        Me.cbclasse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(853, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ref"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(870, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(870, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "nb places"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(856, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "com"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1018, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "nekst"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbtype
        '
        Me.lbtype.FormattingEnabled = True
        Me.lbtype.Items.AddRange(New Object() {"caveau", "caveau_urne", "concession", "concession_urne", "fosse", "vide"})
        Me.lbtype.Location = New System.Drawing.Point(966, 97)
        Me.lbtype.Name = "lbtype"
        Me.lbtype.Size = New System.Drawing.Size(120, 95)
        Me.lbtype.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.cimetiere.My.Resources.Resources.planA3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(783, 804)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PlanCimEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lbtype)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbclasse)
        Me.Controls.Add(Me.tbcom)
        Me.Controls.Add(Me.tbplaces)
        Me.Controls.Add(Me.tbref)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PlanCimEdit"
        Me.Size = New System.Drawing.Size(1271, 846)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbref As TextBox
    Friend WithEvents tbplaces As TextBox
    Friend WithEvents tbcom As TextBox
    Friend WithEvents cbclasse As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbtype As ListBox
End Class
