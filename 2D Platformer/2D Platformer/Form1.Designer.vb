<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.Mover6 = New _2D_Platformer.Mover()
        Me.Mover5 = New _2D_Platformer.Mover()
        Me.Mover4 = New _2D_Platformer.Mover()
        Me.Mover3 = New _2D_Platformer.Mover()
        Me.Mover1 = New _2D_Platformer.Mover()
        Me.Mover2 = New _2D_Platformer.Mover()
        Me.Enemy2PB = New System.Windows.Forms.PictureBox()
        Me.fatWin = New System.Windows.Forms.PictureBox()
        Me.Enemy1PB = New System.Windows.Forms.PictureBox()
        Me.coin1PB = New System.Windows.Forms.PictureBox()
        Me.coin2PB = New System.Windows.Forms.PictureBox()
        Me.coin3PB = New System.Windows.Forms.PictureBox()
        Me.coin4PB = New System.Windows.Forms.PictureBox()
        Me.cakePictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        CType(Me.Enemy2PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fatWin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin1PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin2PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin3PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coin4PB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cakePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 20
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 20
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 20
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 20
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(135, 497)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 22)
        Me.TextBox1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(805, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Score:"
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Location = New System.Drawing.Point(822, 49)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(14, 16)
        Me.scoreLabel.TabIndex = 26
        Me.scoreLabel.Text = "0"
        '
        'Mover6
        '
        Me.Mover6.BackColor = System.Drawing.Color.Transparent
        Me.Mover6.interval = 500
        Me.Mover6.Location = New System.Drawing.Point(108, 268)
        Me.Mover6.Name = "Mover6"
        Me.Mover6.Size = New System.Drawing.Size(8, 121)
        Me.Mover6.speed = 17
        Me.Mover6.sprite = Me.Enemy1PB
        Me.Mover6.TabIndex = 24
        '
        'Mover5
        '
        Me.Mover5.BackColor = System.Drawing.Color.Transparent
        Me.Mover5.interval = 500
        Me.Mover5.Location = New System.Drawing.Point(347, 335)
        Me.Mover5.Name = "Mover5"
        Me.Mover5.Size = New System.Drawing.Size(11, 11)
        Me.Mover5.speed = 7
        Me.Mover5.sprite = Me.coin1PB
        Me.Mover5.TabIndex = 22
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 500
        Me.Mover4.Location = New System.Drawing.Point(734, 235)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(11, 11)
        Me.Mover4.speed = 7
        Me.Mover4.sprite = Me.coin2PB
        Me.Mover4.TabIndex = 21
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(-1, 315)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(11, 11)
        Me.Mover3.speed = 7
        Me.Mover3.sprite = Me.coin3PB
        Me.Mover3.TabIndex = 20
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(131, 78)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(137, 14)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.cakePictureBox
        Me.Mover1.TabIndex = 16
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(550, 131)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(21, 19)
        Me.Mover2.speed = 7
        Me.Mover2.sprite = Me.coin4PB
        Me.Mover2.TabIndex = 19
        '
        'Enemy2PB
        '
        Me.Enemy2PB.Image = Global._2D_Platformer.My.Resources.Resources.Waddle_Dee
        Me.Enemy2PB.Location = New System.Drawing.Point(504, 454)
        Me.Enemy2PB.Name = "Enemy2PB"
        Me.Enemy2PB.Size = New System.Drawing.Size(83, 65)
        Me.Enemy2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Enemy2PB.TabIndex = 28
        Me.Enemy2PB.TabStop = False
        Me.Enemy2PB.Tag = "enemy"
        '
        'fatWin
        '
        Me.fatWin.Image = Global._2D_Platformer.My.Resources.Resources.fat_kirby
        Me.fatWin.Location = New System.Drawing.Point(703, 12)
        Me.fatWin.Name = "fatWin"
        Me.fatWin.Size = New System.Drawing.Size(82, 74)
        Me.fatWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fatWin.TabIndex = 27
        Me.fatWin.TabStop = False
        Me.fatWin.Visible = False
        '
        'Enemy1PB
        '
        Me.Enemy1PB.Image = Global._2D_Platformer.My.Resources.Resources.king_dedede
        Me.Enemy1PB.Location = New System.Drawing.Point(125, 370)
        Me.Enemy1PB.Name = "Enemy1PB"
        Me.Enemy1PB.Size = New System.Drawing.Size(68, 70)
        Me.Enemy1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Enemy1PB.TabIndex = 23
        Me.Enemy1PB.TabStop = False
        Me.Enemy1PB.Tag = "enemy"
        '
        'coin1PB
        '
        Me.coin1PB.Image = Global._2D_Platformer.My.Resources.Resources.Star1
        Me.coin1PB.Location = New System.Drawing.Point(347, 328)
        Me.coin1PB.Name = "coin1PB"
        Me.coin1PB.Size = New System.Drawing.Size(72, 60)
        Me.coin1PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.coin1PB.TabIndex = 13
        Me.coin1PB.TabStop = False
        Me.coin1PB.Tag = "coin"
        '
        'coin2PB
        '
        Me.coin2PB.Image = Global._2D_Platformer.My.Resources.Resources.Star1
        Me.coin2PB.Location = New System.Drawing.Point(734, 228)
        Me.coin2PB.Name = "coin2PB"
        Me.coin2PB.Size = New System.Drawing.Size(72, 60)
        Me.coin2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.coin2PB.TabIndex = 14
        Me.coin2PB.TabStop = False
        Me.coin2PB.Tag = "coin"
        '
        'coin3PB
        '
        Me.coin3PB.Image = Global._2D_Platformer.My.Resources.Resources.Star1
        Me.coin3PB.Location = New System.Drawing.Point(-1, 308)
        Me.coin3PB.Name = "coin3PB"
        Me.coin3PB.Size = New System.Drawing.Size(72, 60)
        Me.coin3PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.coin3PB.TabIndex = 15
        Me.coin3PB.TabStop = False
        Me.coin3PB.Tag = "coin"
        '
        'coin4PB
        '
        Me.coin4PB.Image = Global._2D_Platformer.My.Resources.Resources.Star1
        Me.coin4PB.Location = New System.Drawing.Point(564, 152)
        Me.coin4PB.Name = "coin4PB"
        Me.coin4PB.Size = New System.Drawing.Size(72, 60)
        Me.coin4PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.coin4PB.TabIndex = 18
        Me.coin4PB.TabStop = False
        Me.coin4PB.Tag = "coin"
        '
        'cakePictureBox
        '
        Me.cakePictureBox.Image = Global._2D_Platformer.My.Resources.Resources.Strawberry_Short_CAke
        Me.cakePictureBox.Location = New System.Drawing.Point(271, 98)
        Me.cakePictureBox.Name = "cakePictureBox"
        Me.cakePictureBox.Size = New System.Drawing.Size(104, 75)
        Me.cakePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cakePictureBox.TabIndex = 12
        Me.cakePictureBox.TabStop = False
        Me.cakePictureBox.Tag = "win"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox9.Image = Global._2D_Platformer.My.Resources.Resources.Star_block
        Me.PictureBox9.Location = New System.Drawing.Point(-2, 392)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(76, 65)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "bound"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox8.Image = Global._2D_Platformer.My.Resources.Resources.Star_block
        Me.PictureBox8.Location = New System.Drawing.Point(69, 454)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(76, 65)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "bound"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox7.Image = Global._2D_Platformer.My.Resources.Resources.Star_block
        Me.PictureBox7.Location = New System.Drawing.Point(-2, 454)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(76, 65)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "bound"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox6.Image = Global._2D_Platformer.My.Resources.Resources.Star_block
        Me.PictureBox6.Location = New System.Drawing.Point(291, 412)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 21)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "bound"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox5.Image = Global._2D_Platformer.My.Resources.Resources.Star_block
        Me.PictureBox5.Location = New System.Drawing.Point(152, 167)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(99, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox4.Image = Global._2D_Platformer.My.Resources.Resources.Star_block
        Me.PictureBox4.Location = New System.Drawing.Point(248, 167)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(99, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox3.Image = Global._2D_Platformer.My.Resources.Resources.Star_block
        Me.PictureBox3.Location = New System.Drawing.Point(60, 167)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(99, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Image = Global._2D_Platformer.My.Resources.Resources.Star_block
        Me.PictureBox2.Location = New System.Drawing.Point(384, 412)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Image = Global._2D_Platformer.My.Resources.Resources.Star_block
        Me.PictureBox1.Location = New System.Drawing.Point(725, 315)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.picPlayer.Image = Global._2D_Platformer.My.Resources.Resources.Kirby
        Me.picPlayer.Location = New System.Drawing.Point(750, 476)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(56, 43)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picGround.BackgroundImage = Global._2D_Platformer.My.Resources.Resources.Grass_Texture
        Me.picGround.Location = New System.Drawing.Point(-2, 516)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(929, 73)
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'picAir
        '
        Me.picAir.BackgroundImage = Global._2D_Platformer.My.Resources.Resources.Sky_with_Clouds
        Me.picAir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAir.Location = New System.Drawing.Point(-2, -6)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(929, 499)
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(926, 583)
        Me.Controls.Add(Me.Enemy2PB)
        Me.Controls.Add(Me.fatWin)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mover6)
        Me.Controls.Add(Me.Enemy1PB)
        Me.Controls.Add(Me.Mover5)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.coin4PB)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.coin3PB)
        Me.Controls.Add(Me.coin2PB)
        Me.Controls.Add(Me.coin1PB)
        Me.Controls.Add(Me.cakePictureBox)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.Mover2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Enemy2PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fatWin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin1PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin2PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin3PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coin4PB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cakePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents cakePictureBox As PictureBox
    Friend WithEvents coin1PB As PictureBox
    Friend WithEvents coin2PB As PictureBox
    Friend WithEvents coin3PB As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents coin4PB As PictureBox
    Friend WithEvents Mover2 As Mover
    Friend WithEvents Mover3 As Mover
    Friend WithEvents Mover4 As Mover
    Friend WithEvents Mover5 As Mover
    Friend WithEvents Enemy1PB As PictureBox
    Friend WithEvents Mover6 As Mover
    Friend WithEvents Label1 As Label
    Friend WithEvents scoreLabel As Label
    Friend WithEvents fatWin As PictureBox
    Friend WithEvents Enemy2PB As PictureBox
End Class
