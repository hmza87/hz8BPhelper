<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.p1x = New System.Windows.Forms.TextBox
        Me.p1y = New System.Windows.Forms.TextBox
        Me.p2y = New System.Windows.Forms.TextBox
        Me.p2x = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rux = New System.Windows.Forms.PictureBox
        Me.ruy = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.nx = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.rux, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ruy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p1x
        '
        Me.p1x.Location = New System.Drawing.Point(658, 30)
        Me.p1x.Name = "p1x"
        Me.p1x.Size = New System.Drawing.Size(68, 20)
        Me.p1x.TabIndex = 0
        '
        'p1y
        '
        Me.p1y.Location = New System.Drawing.Point(732, 30)
        Me.p1y.Name = "p1y"
        Me.p1y.Size = New System.Drawing.Size(64, 20)
        Me.p1y.TabIndex = 1
        '
        'p2y
        '
        Me.p2y.Location = New System.Drawing.Point(732, 56)
        Me.p2y.Name = "p2y"
        Me.p2y.Size = New System.Drawing.Size(64, 20)
        Me.p2y.TabIndex = 3
        '
        'p2x
        '
        Me.p2x.Location = New System.Drawing.Point(658, 56)
        Me.p2x.Name = "p2x"
        Me.p2x.Size = New System.Drawing.Size(68, 20)
        Me.p2x.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(612, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Point 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(612, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Point 2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'rux
        '
        Me.rux.BackColor = System.Drawing.Color.Transparent
        Me.rux.Location = New System.Drawing.Point(13, 0)
        Me.rux.Name = "rux"
        Me.rux.Size = New System.Drawing.Size(794, 24)
        Me.rux.TabIndex = 6
        Me.rux.TabStop = False
        '
        'ruy
        '
        Me.ruy.BackColor = System.Drawing.Color.Transparent
        Me.ruy.Location = New System.Drawing.Point(0, 13)
        Me.ruy.Name = "ruy"
        Me.ruy.Size = New System.Drawing.Size(22, 409)
        Me.ruy.TabIndex = 7
        Me.ruy.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(695, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Draw"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(747, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(732, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Draw"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'nx
        '
        Me.nx.Location = New System.Drawing.Point(658, 141)
        Me.nx.Name = "nx"
        Me.nx.Size = New System.Drawing.Size(68, 20)
        Me.nx.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(612, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "New X"
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The8Pt.My.Resources.Resources.rules
        Me.ClientSize = New System.Drawing.Size(808, 422)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.nx)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ruy)
        Me.Controls.Add(Me.rux)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.p2y)
        Me.Controls.Add(Me.p2x)
        Me.Controls.Add(Me.p1y)
        Me.Controls.Add(Me.p1x)
        Me.Name = "test"
        Me.Text = "test"
        CType(Me.rux, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ruy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents p1x As System.Windows.Forms.TextBox
    Friend WithEvents p1y As System.Windows.Forms.TextBox
    Friend WithEvents p2y As System.Windows.Forms.TextBox
    Friend WithEvents p2x As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents rux As System.Windows.Forms.PictureBox
    Friend WithEvents ruy As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents nx As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
