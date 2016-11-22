Public Class test
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer


    Dim mousepos As Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub test_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        
    End Sub
    Private Sub test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim p As Long = GetCursorPos(mousepos)
        Dim x, y As Integer
        Dim BorderWidth As Integer = (Me.Width - Me.ClientSize.Width) / 2
        Dim TitlebarHeight As Integer = Me.Height - Me.ClientSize.Height - 1 * BorderWidth
        x = mousepos.X - Me.Left - BorderWidth - 13
        y = mousepos.Y - Me.Top - TitlebarHeight - 13

        Dim b As New Bitmap(ruy.Width, ruy.Height)
        Dim g As Graphics = Graphics.FromImage(b)
        ruy.Image = b

        g.DrawLine(Pens.Red, 0, y, ruy.Width, y)
        drawXRule(x)
    End Sub
    Function drawXRule(ByVal x As Integer)
        Dim b As New Bitmap(rux.Width, rux.Height)
        Dim g As Graphics = Graphics.FromImage(b)
        rux.Image = b

        g.DrawLine(Pens.Red, x, 0, x, rux.Height)
    End Function

    Private Sub test_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Dim g As Graphics = Me.CreateGraphics
        g.FillEllipse(Brushes.Red, e.X - 3, e.Y - 3, 7, 7)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As Long = GetCursorPos(mousepos)
        Dim x, y As Integer
        Dim BorderWidth As Integer = (Me.Width - Me.ClientSize.Width) / 2
        Dim TitlebarHeight As Integer = Me.Height - Me.ClientSize.Height - 1 * BorderWidth
        x = mousepos.X - Me.Left - BorderWidth - 13
        y = mousepos.Y - Me.Top - TitlebarHeight - 13

        Dim pii As New Pen(Color.SteelBlue, 3)
        Dim g As Graphics = Me.CreateGraphics
        Dim p1 As New Point(p1x.Text + 13, p1y.Text + 13)
        Dim p2 As New Point(p2x.Text + 13, p2y.Text + 13)
        g.DrawLine(pii, p1, p2)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim b As New Bitmap(My.Resources.rules)
        Me.BackgroundImage = b
    End Sub

    Private Sub p2x_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2x.TextChanged
        nx.Text = p2x.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim p As Long = GetCursorPos(mousepos)
        Dim x, y As Integer
        Dim BorderWidth As Integer = (Me.Width - Me.ClientSize.Width) / 2
        Dim TitlebarHeight As Integer = Me.Height - Me.ClientSize.Height - 1 * BorderWidth
        x = mousepos.X - Me.Left - BorderWidth - 13
        y = mousepos.Y - Me.Top - TitlebarHeight - 13

        Dim pii As New Pen(Color.SpringGreen, 3)
        Dim g As Graphics = Me.CreateGraphics
        Dim p1 As New Point(p2x.Text + 13, p2y.Text + 13)

        'Dim ny, m, b, xx, yy As Double
        'xx = p2x.Text - p1x.Text
        'yy = p2y.Text - p1y.Text
        'm = (yy) / (xx)
        ''b = p1y.Text - (xx / yy) * (p1x.Text)
        'b = p1y.Text - m * (p1x.Text)
        'ny = m * nx.Text + b

        'Dim p2 As New Point(nx.Text + 13, ny + 13)
        Dim p2 As New Point(LineQ(p1x.Text, p1y.Text, p2x.Text, p2y.Text, nx.Text))
        p2.X += 13 : p2.Y += 13
        g.DrawLine(pii, p1, p2)
        'Me.Text = "x=" & p2.X & "y=" & p2.Y
    End Sub
End Class