<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.RL = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.TL = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.BL = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LL = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RealTime = New System.Windows.Forms.Timer(Me.components)
        Me.wball = New System.Windows.Forms.PictureBox
        Me.gr = New System.Windows.Forms.PictureBox
        Me.sBall = New System.Windows.Forms.PictureBox
        CType(Me.wball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RL
        '
        Me.RL.BorderColor = System.Drawing.Color.White
        Me.RL.Name = "RL"
        Me.RL.X1 = 623
        Me.RL.X2 = 623
        Me.RL.Y1 = 310
        Me.RL.Y2 = 70
        '
        'TL
        '
        Me.TL.BorderColor = System.Drawing.Color.White
        Me.TL.Name = "TL"
        Me.TL.X1 = 69
        Me.TL.X2 = 600
        Me.TL.Y1 = 46
        Me.TL.Y2 = 46
        '
        'BL
        '
        Me.BL.BorderColor = System.Drawing.Color.White
        Me.BL.Name = "BL"
        Me.BL.X1 = 68
        Me.BL.X2 = 599
        Me.BL.Y1 = 335
        Me.BL.Y2 = 335
        '
        'LL
        '
        Me.LL.BorderColor = System.Drawing.Color.White
        Me.LL.Name = "LL"
        Me.LL.X1 = 44
        Me.LL.X2 = 44
        Me.LL.Y1 = 308
        Me.LL.Y2 = 70
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LL, Me.BL, Me.TL, Me.RL})
        Me.ShapeContainer1.Size = New System.Drawing.Size(668, 383)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RealTime
        '
        Me.RealTime.Enabled = True
        Me.RealTime.Interval = 1
        '
        'wball
        '
        Me.wball.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.wball.Location = New System.Drawing.Point(299, 168)
        Me.wball.Name = "wball"
        Me.wball.Size = New System.Drawing.Size(20, 20)
        Me.wball.TabIndex = 2
        Me.wball.TabStop = False
        Me.wball.Visible = False
        '
        'gr
        '
        Me.gr.BackColor = System.Drawing.Color.Transparent
        Me.gr.Location = New System.Drawing.Point(45, 47)
        Me.gr.Name = "gr"
        Me.gr.Size = New System.Drawing.Size(578, 288)
        Me.gr.TabIndex = 0
        Me.gr.TabStop = False
        '
        'sBall
        '
        Me.sBall.Location = New System.Drawing.Point(435, 190)
        Me.sBall.Name = "sBall"
        Me.sBall.Size = New System.Drawing.Size(20, 20)
        Me.sBall.TabIndex = 3
        Me.sBall.TabStop = False
        Me.sBall.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 383)
        Me.Controls.Add(Me.sBall)
        Me.Controls.Add(Me.wball)
        Me.Controls.Add(Me.gr)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Opacity = 0.3
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.wball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gr As System.Windows.Forms.PictureBox
    Friend WithEvents RL As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TL As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents BL As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LL As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RealTime As System.Windows.Forms.Timer
    Friend WithEvents wball As System.Windows.Forms.PictureBox
    Friend WithEvents sBall As System.Windows.Forms.PictureBox

End Class
