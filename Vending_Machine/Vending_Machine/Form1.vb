Public Class Form1
    Dim WithEvents cs As New Coinslot

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.Insertquarter()
        totalLabel.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.Insertdollar()
        totalLabel.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.Insertdime()
        totalLabel.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.Insertnickel()
        totalLabel.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.Coinreturn()
        totalLabel.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub cs_CoinreturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles cs.CoinreturnEvent
        If d > 0 Then
            dollarPicturebox.Visible = True
        Else
            dollarPicturebox.Visible = False
        End If
        If q > 0 Then
            quarterPicturebox.Visible = True
        Else
            quarterPicturebox.Visible = False
        End If
        If dm > 0 Then
            dimePicturebox.Visible = True
        Else
            dimePicturebox.Visible = False
        End If
        If n > 0 Then
            nickelPicturebox.Visible = True
        Else
            nickelPicturebox.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDtextbox.Text
            Case Productcontrol1.ProductID
                cs.Buy(Productcontrol1)
            Case Productcontrol2.ProductID
                cs.Buy(Productcontrol2)
            Case Productcontrol3.ProductID
                cs.Buy(Productcontrol3)
            Case Productcontrol4.ProductID
                cs.Buy(Productcontrol4)
            Case Productcontrol5.ProductID
                cs.Buy(Productcontrol5)
            Case Productcontrol6.ProductID
                cs.Buy(Productcontrol6)
            Case Productcontrol7.ProductID
                cs.Buy(Productcontrol7)
            Case Productcontrol8.ProductID
                cs.Buy(Productcontrol8)
            Case Productcontrol9.ProductID
                cs.Buy(Productcontrol9)
            Case Productcontrol10.ProductID
                cs.Buy(Productcontrol10)
            Case Productcontrol11.ProductID
                cs.Buy(Productcontrol11)
            Case Productcontrol12.ProductID
                cs.Buy(Productcontrol12)
            Case Productcontrol13.ProductID
                cs.Buy(Productcontrol13)
            Case Productcontrol14.ProductID
                cs.Buy(Productcontrol14)
            Case Productcontrol15.ProductID
                cs.Buy(Productcontrol15)
            Case Productcontrol16.ProductID
                cs.Buy(Productcontrol16)

        End Select
        totalLabel.Text = cs.Total.ToString("C2")
    End Sub

    Private Sub cs_Dispense(p As Image) Handles cs.Dispense
        ProductPB.Image = p
    End Sub
End Class
