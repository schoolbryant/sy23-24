Imports System.Drawing.Drawing2D
Public Class Form1
    Dim WithEvents cs As New Coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Timer1.Enabled = Not Timer1.Enabled
        Me.BackColor = Color.BurlyWood
        If cs.Total >= 1 Then
            ReelControl1.Spin()
            ReelControl2.Spin()
            ReelControl3.Spin()
            cs.spin()
            Timer1.Enabled = True
            totalLabel.Text = cs.Total.ToString("c2")
        End If
    End Sub
    Public Sub Spin()
        'Generate a random number'
        Dim rand As New Random
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        Label1.Text = r

        'Show a Picture from the image list
        'PictureBox1.Image = ImageList1.Images(r)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Spin()
        Label1.Text = ReelControl1.ItemValue
        Label2.Text = ReelControl2.ItemValue
        Label3.Text = ReelControl3.ItemValue
        If ReelControl1.ItemValue = ReelControl2.ItemValue And ReelControl1.ItemValue = ReelControl3.ItemValue And ReelControl1.ItemValue <> 0 Then
            cs.Dollars = cs.Dollars + 5
            totalLabel.Text = cs.Total.ToString("c2")
            Me.BackColor = Color.Green
        End If
        If ReelControl1.ItemValue = ReelControl2.ItemValue And ReelControl1.ItemValue = ReelControl3.ItemValue And ReelControl1.ItemValue = 0 Then
            Me.BackColor = Color.Green
            cs.Dollars = cs.Dollars + 10
            totalLabel.Text = cs.Total.ToString("c2")
        End If

        Timer1.Enabled = False
    End Sub

    ' Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '  Label1.Text = ReelControl1.ItemValue
    '   Label2.Text = ReelControl2.ItemValue
    '   Label3.Text = ReelControl3.ItemValue
    'f ReelControl1.ItemValue = ReelControl2.ItemValue And ReelControl1.ItemValue = ReelControl3.ItemValue Then
    'Me.BackColor = Color.Green
    'Else
    'Me.BackColor = Color.BurlyWood
    ' End If
    ' End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        cs.Insertdollar()
        totalLabel.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cs.Insertquarter()
        totalLabel.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        cs.Insertdime()
        totalLabel.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        cs.Insertnickel()
        totalLabel.Text = cs.Total.ToString("c2")
    End Sub
End Class
