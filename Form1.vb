Public Class Form1
    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles btnFood.Click
        pnlFood.Height = btnFood.Height
        pnlFood.Top = btnFood.Top
        pnlThirdFood.Visible = True
        pnlThirdDrinks.Visible = False
        pnlThirdDeserts.Visible = False
        pnlThirdCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlDrinks.Height = btnDrinks.Height
        pnlDrinks.Top = btnDrinks.Top
        pnlThirdFood.Visible = False
        pnlThirdDrinks.Visible = True
        pnlThirdDeserts.Visible = False
        pnlThirdCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub btnDeserts_Click(sender As Object, e As EventArgs) Handles btnDeserts.Click
        pnlDeserts.Height = btnDeserts.Height
        pnlDeserts.Top = btnDeserts.Top
        pnlThirdFood.Visible = False
        pnlThirdDrinks.Visible = False
        pnlThirdDeserts.Visible = True
        pnlThirdCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        pnlCart.Height = btnCart.Height
        pnlCart.Top = btnCart.Top
        pnlThirdFood.Visible = False
        pnlThirdDrinks.Visible = False
        pnlThirdDeserts.Visible = False
        pnlThirdCart.Visible = True
        pnlAbout.Visible = False
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pnlAbout.Height = btnAboutUs.Height
        pnlAbout.Top = btnAboutUs.Top
        pnlThirdFood.Visible = False
        pnlThirdDrinks.Visible = False
        pnlThirdDeserts.Visible = False
        pnlThirdCart.Visible = False
        pnlAbout.Visible = True
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMini_Click(sender As Object, e As EventArgs) Handles picMini.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picMax_Click(sender As Object, e As EventArgs) Handles picMax.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub
End Class
