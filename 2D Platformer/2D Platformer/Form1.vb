Public Class Form1
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Dim score As Integer = 0
    Dim scoreSee As Integer = 0
    Dim coin As Integer
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += moveSpeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= moveSpeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
        TextBox1.Select()

    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
                If b.Tag = "win" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        cakePictureBox.Visible = False
                        TextBox1.Visible = False
                        picPlayer.Visible = False
                        fatWin.Visible = True
                        fatWin.Height = 200
                        fatWin.Width = 200
                        fatWin.Location = New Point(87, 6)
                    End If
                End If
                If b.Tag = "coin" Then
                    If b.Visible And picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                        coin += 1
                        scoreLabel.Text = coin
                    End If
                End If
                If b.Tag = "enemy" Then
                    If b.Visible And picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                        coin -= 1
                        scoreLabel.Text = coin
                    End If
                End If



            End If
        Next
        'If picPlayer.Bounds.IntersectsWith(coin1PB.Bounds) Then
        '    If coin1PB.Visible = True Then
        '        scoreLabel.Text = score + 1
        '        score = score + 1
        '    End If
        '    coin1PB.Visible = False
        'End If
        '    If picPlayer.Bounds.IntersectsWith(coin2PB.Bounds) Then
        '    If coin2PB.Visible = True Then
        '        scoreLabel.Text = score + 1
        '        score = score + 1
        '    End If
        '    coin2PB.Visible = False
        'End If
        'If picPlayer.Bounds.IntersectsWith(coin3PB.Bounds) Then
        '    If coin3PB.Visible = True Then
        '        scoreLabel.Text = score + 1
        '        score = score + 1
        '    End If
        '    coin3PB.Visible = False
        'End If
        'If picPlayer.Bounds.IntersectsWith(coin4PB.Bounds) Then
        '    If coin4PB.Visible = True Then
        '        scoreLabel.Text = score + 1
        '        score = score + 1
        '    End If
        '    coin4PB.Visible = False
        'End If
        'If picPlayer.Bounds.IntersectsWith(Enemy1PB.Bounds) Then
        '    coin = 0
        '    scoreLabel.Text = coin
        '    picPlayer.Location = New Point(563, 380)
        '    coin1PB.Visible = True
        '    coin2PB.Visible = True
        '    coin3PB.Visible = True
        '    coin4PB.Visible = True
        'End If

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += moveSpeed
    End Sub
End Class
