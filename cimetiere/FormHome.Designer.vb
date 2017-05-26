<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FAccTBNewConcession = New System.Windows.Forms.Button()
        Me.FAccTBProlongation = New System.Windows.Forms.Button()
        Me.FAccTBConstatAbandon = New System.Windows.Forms.Button()
        Me.FAccTBConsulter = New System.Windows.Forms.Button()
        Me.FormHomePanNotif = New System.Windows.Forms.Panel()
        Me.FormHomeBMasque = New System.Windows.Forms.Button()
        Me.FormHomeLabNotif = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtDebug = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FAccTBReserv = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FormHomePanNotif.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.SeaGreen
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.FAccTBNewConcession)
        Me.FlowLayoutPanel1.Controls.Add(Me.FAccTBReserv)
        Me.FlowLayoutPanel1.Controls.Add(Me.FAccTBConsulter)
        Me.FlowLayoutPanel1.Controls.Add(Me.FAccTBProlongation)
        Me.FlowLayoutPanel1.Controls.Add(Me.FAccTBConstatAbandon)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(52, 107)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(651, 227)
        Me.FlowLayoutPanel1.TabIndex = 63
        '
        'FAccTBNewConcession
        '
        Me.FAccTBNewConcession.BackColor = System.Drawing.Color.SeaGreen
        Me.FAccTBNewConcession.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FAccTBNewConcession.ForeColor = System.Drawing.Color.Transparent
        Me.FAccTBNewConcession.Location = New System.Drawing.Point(3, 3)
        Me.FAccTBNewConcession.Name = "FAccTBNewConcession"
        Me.FAccTBNewConcession.Size = New System.Drawing.Size(209, 101)
        Me.FAccTBNewConcession.TabIndex = 55
        Me.FAccTBNewConcession.Text = "Nouvelle concession"
        Me.FAccTBNewConcession.UseVisualStyleBackColor = False
        '
        'FAccTBProlongation
        '
        Me.FAccTBProlongation.BackColor = System.Drawing.Color.SeaGreen
        Me.FAccTBProlongation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FAccTBProlongation.ForeColor = System.Drawing.Color.Transparent
        Me.FAccTBProlongation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FAccTBProlongation.Location = New System.Drawing.Point(90, 113)
        Me.FAccTBProlongation.Margin = New System.Windows.Forms.Padding(90, 3, 3, 3)
        Me.FAccTBProlongation.Name = "FAccTBProlongation"
        Me.FAccTBProlongation.Size = New System.Drawing.Size(209, 104)
        Me.FAccTBProlongation.TabIndex = 56
        Me.FAccTBProlongation.Text = "Prolongation de concession"
        Me.FAccTBProlongation.UseVisualStyleBackColor = False
        '
        'FAccTBConstatAbandon
        '
        Me.FAccTBConstatAbandon.BackColor = System.Drawing.Color.SeaGreen
        Me.FAccTBConstatAbandon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FAccTBConstatAbandon.ForeColor = System.Drawing.Color.Transparent
        Me.FAccTBConstatAbandon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FAccTBConstatAbandon.Location = New System.Drawing.Point(342, 113)
        Me.FAccTBConstatAbandon.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
        Me.FAccTBConstatAbandon.Name = "FAccTBConstatAbandon"
        Me.FAccTBConstatAbandon.Size = New System.Drawing.Size(209, 104)
        Me.FAccTBConstatAbandon.TabIndex = 57
        Me.FAccTBConstatAbandon.Text = "Constat d'abandon"
        Me.FAccTBConstatAbandon.UseVisualStyleBackColor = False
        '
        'FAccTBConsulter
        '
        Me.FAccTBConsulter.BackColor = System.Drawing.Color.SeaGreen
        Me.FAccTBConsulter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FAccTBConsulter.ForeColor = System.Drawing.Color.Transparent
        Me.FAccTBConsulter.Location = New System.Drawing.Point(433, 3)
        Me.FAccTBConsulter.Name = "FAccTBConsulter"
        Me.FAccTBConsulter.Size = New System.Drawing.Size(209, 104)
        Me.FAccTBConsulter.TabIndex = 58
        Me.FAccTBConsulter.Text = "Consulter données"
        Me.FAccTBConsulter.UseVisualStyleBackColor = False
        '
        'FormHomePanNotif
        '
        Me.FormHomePanNotif.BackColor = System.Drawing.Color.SeaGreen
        Me.FormHomePanNotif.Controls.Add(Me.FormHomeBMasque)
        Me.FormHomePanNotif.Controls.Add(Me.FormHomeLabNotif)
        Me.FormHomePanNotif.Location = New System.Drawing.Point(-7, 400)
        Me.FormHomePanNotif.Name = "FormHomePanNotif"
        Me.FormHomePanNotif.Size = New System.Drawing.Size(769, 100)
        Me.FormHomePanNotif.TabIndex = 62
        '
        'FormHomeBMasque
        '
        Me.FormHomeBMasque.Location = New System.Drawing.Point(666, 8)
        Me.FormHomeBMasque.Name = "FormHomeBMasque"
        Me.FormHomeBMasque.Size = New System.Drawing.Size(73, 23)
        Me.FormHomeBMasque.TabIndex = 1
        Me.FormHomeBMasque.Text = "Masquer"
        Me.FormHomeBMasque.UseVisualStyleBackColor = True
        '
        'FormHomeLabNotif
        '
        Me.FormHomeLabNotif.AutoSize = True
        Me.FormHomeLabNotif.BackColor = System.Drawing.Color.Transparent
        Me.FormHomeLabNotif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FormHomeLabNotif.ForeColor = System.Drawing.Color.Transparent
        Me.FormHomeLabNotif.Location = New System.Drawing.Point(10, 10)
        Me.FormHomeLabNotif.Name = "FormHomeLabNotif"
        Me.FormHomeLabNotif.Size = New System.Drawing.Size(98, 18)
        Me.FormHomeLabNotif.TabIndex = 0
        Me.FormHomeLabNotif.Text = "Notifications :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(703, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(603, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Welkom User"
        '
        'BtDebug
        '
        Me.BtDebug.BackColor = System.Drawing.Color.Magenta
        Me.BtDebug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtDebug.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen
        Me.BtDebug.Font = New System.Drawing.Font("Curlz MT", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDebug.ForeColor = System.Drawing.Color.Yellow
        Me.BtDebug.Location = New System.Drawing.Point(369, 349)
        Me.BtDebug.Name = "BtDebug"
        Me.BtDebug.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtDebug.Size = New System.Drawing.Size(154, 45)
        Me.BtDebug.TabIndex = 66
        Me.BtDebug.Text = "debug tests"
        Me.BtDebug.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen
        Me.Button1.Font = New System.Drawing.Font("Curlz MT", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Button1.Location = New System.Drawing.Point(209, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(154, 45)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "test empls"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FAccTBReserv
        '
        Me.FAccTBReserv.BackColor = System.Drawing.Color.SeaGreen
        Me.FAccTBReserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FAccTBReserv.ForeColor = System.Drawing.Color.Transparent
        Me.FAccTBReserv.Location = New System.Drawing.Point(218, 3)
        Me.FAccTBReserv.Name = "FAccTBReserv"
        Me.FAccTBReserv.Size = New System.Drawing.Size(209, 104)
        Me.FAccTBReserv.TabIndex = 59
        Me.FAccTBReserv.Text = "Afficher le Plan"
        Me.FAccTBReserv.UseVisualStyleBackColor = False
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(758, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtDebug)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FormHomePanNotif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "FormHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHome"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FormHomePanNotif.ResumeLayout(False)
        Me.FormHomePanNotif.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FAccTBProlongation As System.Windows.Forms.Button
    Friend WithEvents FAccTBConstatAbandon As System.Windows.Forms.Button
    Friend WithEvents FAccTBConsulter As System.Windows.Forms.Button
    Friend WithEvents FAccTBNewConcession As System.Windows.Forms.Button
    Friend WithEvents FormHomePanNotif As System.Windows.Forms.Panel
    Public WithEvents FormHomeBMasque As System.Windows.Forms.Button
    Friend WithEvents FormHomeLabNotif As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtDebug As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents FAccTBReserv As Button
End Class
