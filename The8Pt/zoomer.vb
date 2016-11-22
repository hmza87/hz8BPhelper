Public Class zoomer
    Private Sub zoomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left - (Me.Width + 50)
        Me.TopMost = True
        ' Timer1.Enabled = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If Form2.SHFT = False And Form2.CTRL = False Then
        Timer1.Enabled = False
        Me.Close()


    End Sub


End Class