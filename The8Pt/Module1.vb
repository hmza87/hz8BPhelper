Module Module1
    Public Function LineQ(x1 As Double, y1 As Double, x2 As Double, y2 As Double, NewX As Double) As Point
        Dim p1 As New Point(x2, y2)

        Dim ny, m, b, xx, yy As Double
        xx = x2 - x1
        yy = y2 - y1
        m = (yy) / (xx)
        'b = p1y.Text - (xx / yy) * (p1x.Text)
        b = y1 - m * (x1)
        ny = m * NewX + b

       
        Return New Point(NewX, ny)
    End Function
    Public Function LineQ(Po1 As Point, Po2 As Point, NewX As Double) As Point

        Try
            Dim ny, m, b, xx, yy As Double
            xx = Po2.X - Po1.X
            yy = Po2.Y - Po1.Y
            m = (yy) / (xx)
            'b = p1y.Text - (xx / yy) * (p1x.Text)
            b = Po1.Y - m * (Po1.X)
            ny = m * NewX + b

            Return New Point(NewX, ny)
        Catch ex As Exception
            Debug.Print("ERROR : " & ex.Message)
        End Try

    End Function
    Function Cap(xP As Point)
        Dim bounds As Rectangle
        Dim screenshot As System.Drawing.Bitmap
        Dim graph As Graphics


        bounds = New Rectangle(xP, New Size(40, 40))
        screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
        graph = Graphics.FromImage(screenshot)
        If Form1.FormBorderStyle = FormBorderStyle.None Then
            graph.CopyFromScreen(xP.X - 12, xP.Y - 32, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        Else
            graph.CopyFromScreen(xP.X - 20, xP.Y - 20, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
        End If


        With zoomer
            .pic.Image = screenshot
            .Show()
        End With
    End Function
End Module
