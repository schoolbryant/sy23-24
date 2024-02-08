Public Class Form1
    Dim WithEvents cs As New Coinslot

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.Insertquarter()
        Label1.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.Insertdollar()
        Label1.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.Insertdime()
        Label1.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.Insertnickel()
        Label1.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.Coinreturn()
        Label1.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub cs_CoinreturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles cs.CoinreturnEvent
        Me.BackColor = Color.Red
    End Sub
End Class
