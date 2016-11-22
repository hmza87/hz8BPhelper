Public Class Form1
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As UInt32) As Integer


    Dim mousepos As Point
    Dim drag, follow As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim fball As Point
    Function GSet(ByVal name As String, ByVal def As String)
        Return GetSetting("The8Pt", "Setz", name, def)
    End Function
    Function sSet(ByVal name As String, ByVal val As String)
        SaveSetting("The8Pt", "Setz", name, val)
        Return True
    End Function

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sSet("top", Me.Top)
        sSet("left", Me.Left)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.Top = GSet("top", Screen.PrimaryScreen.WorkingArea.Height / 2 - Me.Height / 2)
        Me.Left = GSet("left", Screen.PrimaryScreen.WorkingArea.Width / 2 - Me.Width / 2)
    End Sub

    Private Sub RealTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealTime.Tick
        Dim CTRL As Boolean
        Dim SHFT As Boolean
        Dim p As Long = GetCursorPos(mousepos)
        CTRL = GetAsyncKeyState(Keys.ControlKey)
        SHFT = GetAsyncKeyState(Keys.ShiftKey)
        Dim x, y As Integer
        Dim BorderWidth As Integer = (Me.Width - Me.ClientSize.Width) / 2
        Dim TitlebarHeight As Integer = Me.Height - Me.ClientSize.Height - 1 * BorderWidth
        x = mousepos.X - Me.Left - BorderWidth
        y = mousepos.Y - Me.Top - TitlebarHeight

        'x = gr.Width - x
        'y = gr.Height = y


        If CTRL And Not SHFT Then
            If Not wball.Visible Then wball.Visible = True
            Cap(mousepos)





            wball.Left = x - wball.Width / 2
            wball.Top = y - wball.Height / 2
            Dim bm As New Bitmap(19, 19, Drawing.Imaging.PixelFormat.Format32bppPArgb)
            Dim gf As Graphics = Graphics.FromImage(bm)
            'Dim gf As Graphics = wball.CreateGraphics
            gf.DrawEllipse(Pens.Red, 1, 1, 17, 17)
            bm.SetResolution(900.0F, 900.0F)


            wball.Image = bm

            '//// Clear img

            gr.CreateGraphics.Clear(Color.FromArgb(255, 255, 192, 255))








        Else
            zoomer.Timer1.Enabled = 1

        End If

        If SHFT Then follow = True Else follow = False


        If follow Then



            Dim g As Graphics
            Dim bp As New Bitmap(gr.Width, gr.Height, Drawing.Imaging.PixelFormat.Format32bppPArgb)
            bp.SetResolution(1900.0F, 1900.0F)

            g = Graphics.FromImage(bp) 'gr.CreateGraphics
            gr.Image = bp
            g.Clear(Color.FromArgb(255, 255, 192, 255))

            Dim pi As New Pen(Color.Black, 2)
            Dim piback As New Pen(Color.White, 19)
            Dim pii As New Pen(Color.Red, 2)
            Dim el As New SolidBrush(Color.White)

            'g.FillEllipse(el, x - 9, y - 9, 18, 18)
            'g.DrawEllipse(pi, x - 9, y - 9, 18, 18)

            'If Not x < Me.Left And Not x > Me.Left + Me.Width And Not y < Me.Top And Not y > Me.Top + Me.Height Then
            Dim tX, tY, bX, bY, bx1, by1, bx2, by2 As Long

            bx1 = wball.Left - gr.Left + 10
            by1 = wball.Top - gr.Top + 10
            tX = x - gr.Left
            tY = y - gr.Top





            Dim t2 As New Point(x - gr.Left, y - gr.Top)
            Dim t1 As New Point(wball.Left - gr.Left + 10, wball.Top - gr.Top + 10)

            Dim b1 As New Point(t1.X, t1.Y)
            Dim b2 As New Point(b1.X - (t2.X - t1.X), b1.Y + (t1.Y - t2.Y))


            Dim newP As New Point
            Dim asx As Integer
            t2.Y -= 5.6
            If t2.X > t1.X Then
                newP = LineQ(t1, t2, t2.X - 15)
                asx = gr.Width
            ElseIf t2.X < t1.X Then
                asx = 0
                newP = LineQ(t1, t2, t2.X + 15)

            Else
                asx = gr.Width / 2
                newP = LineQ(t1, t2, t2.X + 15)
            End If

            g.DrawLine(pii, t1, LineQ(t1, newP, asx))
            'g.DrawLine(pi, b1, b2)




            Dim ppp As New Pen(Color.Red, 10)
            g.DrawEllipse(ppp, LineQ(t1, newP, asx).X, LineQ(t1, newP, asx).Y, 20, 20)




            'g.DrawLine(pi, b1, b2)

            ' g.DrawLine(piback, b1, LineQ(t1, t2, nxx))
            ' g.DrawLine(pi, b1, LineQ(t1, t2, nxx))



            'End If


            ' g.DrawEllipse(pi, fball.X, fball.Y, 20, 20)


        End If




    End Sub



    Private Sub wball_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles wball.Paint

    End Sub
    Sub findBall()
        Me.Tag = Now.Ticks
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Me.Bounds
        Dim sB As Rectangle = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        'screenshot.Save("d:\x.bmp", Imaging.ImageFormat.Bmp)











        Using fp As New FastPix(screenshot)
            Dim bf As New FastPix(FastPix.ConvertFormat(My.Resources.detectball1, Imaging.PixelFormat.Format32bppPArgb))
            'Make a local reference to the array; it is roughly 4x as fast as direct references to fp.PixelArray:
            Dim pixels As Integer() = fp.PixelArray
            Me.Text = ""
            Dim opix As Integer() = bf.PixelArray
            Dim tmp As Integer() = opix

            For i As Integer = 0 To pixels.Length - 1


                If pixels(i) = opix(0) Then

                    For o As Integer = 0 To opix.Length - 1
                        tmp(o) = pixels(i + o)

                    Next
                    If Compar(opix, tmp) Then
                        Me.Text = "FOUND IT"
                        '### Marking ball place
                        For k As Integer = 0 To tmp.Length - 1

                        Next
                    Else
                        Me.Text = "NOO"
                    End If
                Else


                End If




            Next
        End Using
        Me.Text = Me.Text & " " & ((Now.Ticks - Me.Tag) / 10000) & " Mills"
    End Sub
    Function Compar(pxl1 As Integer(), pxl2 As Integer()) As Boolean
        Try
            For i As Integer = 0 To pxl1.Length - 1
                If pxl1(i) = pxl1(i) Then

                Else
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Function lookforit() As Rectangle
        Dim r As New Rectangle()
        Dim btl, bbl As Bitmap
        btl = My.Resources.detectball1
        bbl = My.Resources.detectball2

        '#### Screenshot
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics
        bounds = Me.Bounds
        Dim sB As Rectangle = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        '##### END Screenshot

        For w As Integer = 0 To screenshot.Width

            For h As Integer = 0 To screenshot.Height
                If screenshot.GetPixel(w, h) = btl.GetPixel(w, h) And screenshot.GetPixel(w + 1, h + 1) = btl.GetPixel(w + 1, h + 1) And screenshot.GetPixel(w + 2, h + 2) = btl.GetPixel(w + 2, h + 2) Then



                End If
            Next



        Next



    End Function
    Sub test()
        Using fp As New FastPix(My.Resources.Capturefg)
            'Make a local reference to the array; it is roughly 4x as fast as direct references to fp.PixelArray:
            Dim pixels As Integer() = fp.PixelArray

            For i As Integer = 0 To pixels.Length - 1

                'example: substitute a color
                If pixels(i) = Color.Red.ToArgb Then pixels(i) = Color.Blue.ToArgb

                'example: invert the color
                pixels(i) = pixels(i) Xor 0 '$HFFFFFF

            Next
        End Using
    End Sub
End Class
