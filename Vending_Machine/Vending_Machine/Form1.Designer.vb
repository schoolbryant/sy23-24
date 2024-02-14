<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dollarPicturebox = New System.Windows.Forms.PictureBox()
        Me.nickelPicturebox = New System.Windows.Forms.PictureBox()
        Me.dimePicturebox = New System.Windows.Forms.PictureBox()
        Me.quarterPicturebox = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDtextbox = New System.Windows.Forms.TextBox()
        Me.ProductPB = New System.Windows.Forms.PictureBox()
        Me.Productcontrol8 = New Vending_Machine.Productcontrol()
        Me.Productcontrol2 = New Vending_Machine.Productcontrol()
        Me.Productcontrol13 = New Vending_Machine.Productcontrol()
        Me.Productcontrol16 = New Vending_Machine.Productcontrol()
        Me.Productcontrol15 = New Vending_Machine.Productcontrol()
        Me.Productcontrol14 = New Vending_Machine.Productcontrol()
        Me.Productcontrol12 = New Vending_Machine.Productcontrol()
        Me.Productcontrol11 = New Vending_Machine.Productcontrol()
        Me.Productcontrol10 = New Vending_Machine.Productcontrol()
        Me.Productcontrol9 = New Vending_Machine.Productcontrol()
        Me.Productcontrol7 = New Vending_Machine.Productcontrol()
        Me.Productcontrol6 = New Vending_Machine.Productcontrol()
        Me.Productcontrol5 = New Vending_Machine.Productcontrol()
        Me.Productcontrol4 = New Vending_Machine.Productcontrol()
        Me.Productcontrol3 = New Vending_Machine.Productcontrol()
        Me.Productcontrol1 = New Vending_Machine.Productcontrol()
        CType(Me.dollarPicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nickelPicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimePicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quarterPicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(727, 213)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(51, 16)
        Me.totalLabel.TabIndex = 8
        Me.totalLabel.Text = "Label 1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(700, 270)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 30)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dollarPicturebox
        '
        Me.dollarPicturebox.Image = Global.Vending_Machine.My.Resources.Resources.dollar_coin
        Me.dollarPicturebox.Location = New System.Drawing.Point(665, 316)
        Me.dollarPicturebox.Name = "dollarPicturebox"
        Me.dollarPicturebox.Size = New System.Drawing.Size(71, 71)
        Me.dollarPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarPicturebox.TabIndex = 11
        Me.dollarPicturebox.TabStop = False
        Me.dollarPicturebox.Visible = False
        '
        'nickelPicturebox
        '
        Me.nickelPicturebox.Image = Global.Vending_Machine.My.Resources.Resources.nickle
        Me.nickelPicturebox.Location = New System.Drawing.Point(764, 404)
        Me.nickelPicturebox.Name = "nickelPicturebox"
        Me.nickelPicturebox.Size = New System.Drawing.Size(71, 71)
        Me.nickelPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nickelPicturebox.TabIndex = 14
        Me.nickelPicturebox.TabStop = False
        Me.nickelPicturebox.Visible = False
        '
        'dimePicturebox
        '
        Me.dimePicturebox.Image = Global.Vending_Machine.My.Resources.Resources.dime
        Me.dimePicturebox.Location = New System.Drawing.Point(665, 404)
        Me.dimePicturebox.Name = "dimePicturebox"
        Me.dimePicturebox.Size = New System.Drawing.Size(71, 71)
        Me.dimePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dimePicturebox.TabIndex = 13
        Me.dimePicturebox.TabStop = False
        Me.dimePicturebox.Visible = False
        '
        'quarterPicturebox
        '
        Me.quarterPicturebox.Image = Global.Vending_Machine.My.Resources.Resources.quarter
        Me.quarterPicturebox.Location = New System.Drawing.Point(764, 316)
        Me.quarterPicturebox.Name = "quarterPicturebox"
        Me.quarterPicturebox.Size = New System.Drawing.Size(71, 71)
        Me.quarterPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quarterPicturebox.TabIndex = 12
        Me.quarterPicturebox.TabStop = False
        Me.quarterPicturebox.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Vending_Machine.My.Resources.Resources.dollar_coin
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(661, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 70)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Dollars"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Vending_Machine.My.Resources.Resources.quarter
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(751, 122)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 70)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Nickels"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Vending_Machine.My.Resources.Resources.dime
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(661, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 70)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Dimes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Vending_Machine.My.Resources.Resources.quarter
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(751, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 70)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Quarters"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(509, 213)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IDtextbox
        '
        Me.IDtextbox.Location = New System.Drawing.Point(517, 242)
        Me.IDtextbox.Name = "IDtextbox"
        Me.IDtextbox.Size = New System.Drawing.Size(58, 22)
        Me.IDtextbox.TabIndex = 32
        '
        'ProductPB
        '
        Me.ProductPB.Location = New System.Drawing.Point(493, 270)
        Me.ProductPB.Name = "ProductPB"
        Me.ProductPB.Size = New System.Drawing.Size(110, 83)
        Me.ProductPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductPB.TabIndex = 33
        Me.ProductPB.TabStop = False
        '
        'Productcontrol8
        '
        Me.Productcontrol8.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol8.Count = 5
        Me.Productcontrol8.Location = New System.Drawing.Point(231, 247)
        Me.Productcontrol8.Name = "Productcontrol8"
        Me.Productcontrol8.Picture = Global.Vending_Machine.My.Resources.Resources.nature_valley
        Me.Productcontrol8.Price = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.Productcontrol8.ProductID = "C3"
        Me.Productcontrol8.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol8.TabIndex = 22
        '
        'Productcontrol2
        '
        Me.Productcontrol2.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol2.Count = 5
        Me.Productcontrol2.Location = New System.Drawing.Point(3, 122)
        Me.Productcontrol2.Name = "Productcontrol2"
        Me.Productcontrol2.Picture = Global.Vending_Machine.My.Resources.Resources.aquafina
        Me.Productcontrol2.Price = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Productcontrol2.ProductID = "B1"
        Me.Productcontrol2.Size = New System.Drawing.Size(108, 119)
        Me.Productcontrol2.TabIndex = 16
        '
        'Productcontrol13
        '
        Me.Productcontrol13.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol13.Count = 5
        Me.Productcontrol13.Location = New System.Drawing.Point(117, 122)
        Me.Productcontrol13.Name = "Productcontrol13"
        Me.Productcontrol13.Picture = Global.Vending_Machine.My.Resources.Resources.diet_coke
        Me.Productcontrol13.Price = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.Productcontrol13.ProductID = "B2"
        Me.Productcontrol13.Size = New System.Drawing.Size(108, 119)
        Me.Productcontrol13.TabIndex = 27
        '
        'Productcontrol16
        '
        Me.Productcontrol16.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol16.Count = 5
        Me.Productcontrol16.Location = New System.Drawing.Point(12, 12)
        Me.Productcontrol16.Name = "Productcontrol16"
        Me.Productcontrol16.Picture = Global.Vending_Machine.My.Resources.Resources.cheeto_puffs
        Me.Productcontrol16.Price = New Decimal(New Integer() {135, 0, 0, 131072})
        Me.Productcontrol16.ProductID = "A1"
        Me.Productcontrol16.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol16.TabIndex = 30
        '
        'Productcontrol15
        '
        Me.Productcontrol15.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol15.Count = 5
        Me.Productcontrol15.Location = New System.Drawing.Point(117, 12)
        Me.Productcontrol15.Name = "Productcontrol15"
        Me.Productcontrol15.Picture = Global.Vending_Machine.My.Resources.Resources.cheetos1
        Me.Productcontrol15.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol15.ProductID = "A2"
        Me.Productcontrol15.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol15.TabIndex = 29
        '
        'Productcontrol14
        '
        Me.Productcontrol14.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol14.Count = 5
        Me.Productcontrol14.Location = New System.Drawing.Point(231, 122)
        Me.Productcontrol14.Name = "Productcontrol14"
        Me.Productcontrol14.Picture = Global.Vending_Machine.My.Resources.Resources.coke
        Me.Productcontrol14.Price = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.Productcontrol14.ProductID = "B3"
        Me.Productcontrol14.Size = New System.Drawing.Size(108, 119)
        Me.Productcontrol14.TabIndex = 28
        '
        'Productcontrol12
        '
        Me.Productcontrol12.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol12.Count = 5
        Me.Productcontrol12.Location = New System.Drawing.Point(3, 357)
        Me.Productcontrol12.Name = "Productcontrol12"
        Me.Productcontrol12.Picture = Global.Vending_Machine.My.Resources.Resources.oreos
        Me.Productcontrol12.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol12.ProductID = "D1"
        Me.Productcontrol12.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol12.TabIndex = 26
        '
        'Productcontrol11
        '
        Me.Productcontrol11.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol11.Count = 5
        Me.Productcontrol11.Location = New System.Drawing.Point(345, 12)
        Me.Productcontrol11.Name = "Productcontrol11"
        Me.Productcontrol11.Picture = Global.Vending_Machine.My.Resources.Resources.doritos
        Me.Productcontrol11.Price = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Productcontrol11.ProductID = "A4"
        Me.Productcontrol11.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol11.TabIndex = 25
        '
        'Productcontrol10
        '
        Me.Productcontrol10.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol10.Count = 5
        Me.Productcontrol10.Location = New System.Drawing.Point(345, 122)
        Me.Productcontrol10.Name = "Productcontrol10"
        Me.Productcontrol10.Picture = Global.Vending_Machine.My.Resources.Resources.gatorade
        Me.Productcontrol10.Price = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.Productcontrol10.ProductID = "B4"
        Me.Productcontrol10.Size = New System.Drawing.Size(108, 119)
        Me.Productcontrol10.TabIndex = 24
        '
        'Productcontrol9
        '
        Me.Productcontrol9.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol9.Count = 5
        Me.Productcontrol9.Location = New System.Drawing.Point(231, 12)
        Me.Productcontrol9.Name = "Productcontrol9"
        Me.Productcontrol9.Picture = Global.Vending_Machine.My.Resources.Resources.lays
        Me.Productcontrol9.Price = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Productcontrol9.ProductID = "A3"
        Me.Productcontrol9.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol9.TabIndex = 23
        '
        'Productcontrol7
        '
        Me.Productcontrol7.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol7.Count = 5
        Me.Productcontrol7.Location = New System.Drawing.Point(3, 247)
        Me.Productcontrol7.Name = "Productcontrol7"
        Me.Productcontrol7.Picture = Global.Vending_Machine.My.Resources.Resources.pringles
        Me.Productcontrol7.Price = New Decimal(New Integer() {175, 0, 0, 131072})
        Me.Productcontrol7.ProductID = "C1"
        Me.Productcontrol7.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol7.TabIndex = 21
        '
        'Productcontrol6
        '
        Me.Productcontrol6.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol6.Count = 5
        Me.Productcontrol6.Location = New System.Drawing.Point(345, 247)
        Me.Productcontrol6.Name = "Productcontrol6"
        Me.Productcontrol6.Picture = Global.Vending_Machine.My.Resources.Resources.red_bull
        Me.Productcontrol6.Price = New Decimal(New Integer() {110, 0, 0, 131072})
        Me.Productcontrol6.ProductID = "C4"
        Me.Productcontrol6.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol6.TabIndex = 20
        '
        'Productcontrol5
        '
        Me.Productcontrol5.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol5.Count = 5
        Me.Productcontrol5.Location = New System.Drawing.Point(345, 357)
        Me.Productcontrol5.Name = "Productcontrol5"
        Me.Productcontrol5.Picture = Global.Vending_Machine.My.Resources.Resources.skittles
        Me.Productcontrol5.Price = New Decimal(New Integer() {120, 0, 0, 131072})
        Me.Productcontrol5.ProductID = "D4"
        Me.Productcontrol5.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol5.TabIndex = 19
        '
        'Productcontrol4
        '
        Me.Productcontrol4.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol4.Count = 5
        Me.Productcontrol4.Location = New System.Drawing.Point(117, 247)
        Me.Productcontrol4.Name = "Productcontrol4"
        Me.Productcontrol4.Picture = Global.Vending_Machine.My.Resources.Resources.slim_jim
        Me.Productcontrol4.Price = New Decimal(New Integer() {75, 0, 0, 131072})
        Me.Productcontrol4.ProductID = "C2"
        Me.Productcontrol4.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol4.TabIndex = 18
        '
        'Productcontrol3
        '
        Me.Productcontrol3.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol3.Count = 5
        Me.Productcontrol3.Location = New System.Drawing.Point(231, 357)
        Me.Productcontrol3.Name = "Productcontrol3"
        Me.Productcontrol3.Picture = Global.Vending_Machine.My.Resources.Resources.starburst
        Me.Productcontrol3.Price = New Decimal(New Integer() {120, 0, 0, 131072})
        Me.Productcontrol3.ProductID = "D3"
        Me.Productcontrol3.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol3.TabIndex = 17
        '
        'Productcontrol1
        '
        Me.Productcontrol1.BackColor = System.Drawing.Color.Linen
        Me.Productcontrol1.Count = 5
        Me.Productcontrol1.Location = New System.Drawing.Point(117, 357)
        Me.Productcontrol1.Name = "Productcontrol1"
        Me.Productcontrol1.Picture = Global.Vending_Machine.My.Resources.Resources.snickers
        Me.Productcontrol1.Price = New Decimal(New Integer() {100, 0, 0, 131072})
        Me.Productcontrol1.ProductID = "D2"
        Me.Productcontrol1.Size = New System.Drawing.Size(108, 104)
        Me.Productcontrol1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 497)
        Me.Controls.Add(Me.ProductPB)
        Me.Controls.Add(Me.IDtextbox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Productcontrol8)
        Me.Controls.Add(Me.Productcontrol2)
        Me.Controls.Add(Me.Productcontrol13)
        Me.Controls.Add(Me.Productcontrol16)
        Me.Controls.Add(Me.Productcontrol15)
        Me.Controls.Add(Me.Productcontrol14)
        Me.Controls.Add(Me.Productcontrol12)
        Me.Controls.Add(Me.Productcontrol11)
        Me.Controls.Add(Me.Productcontrol10)
        Me.Controls.Add(Me.Productcontrol9)
        Me.Controls.Add(Me.Productcontrol7)
        Me.Controls.Add(Me.Productcontrol6)
        Me.Controls.Add(Me.Productcontrol5)
        Me.Controls.Add(Me.Productcontrol4)
        Me.Controls.Add(Me.Productcontrol3)
        Me.Controls.Add(Me.Productcontrol1)
        Me.Controls.Add(Me.dollarPicturebox)
        Me.Controls.Add(Me.nickelPicturebox)
        Me.Controls.Add(Me.dimePicturebox)
        Me.Controls.Add(Me.quarterPicturebox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dollarPicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nickelPicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimePicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quarterPicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents totalLabel As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents dollarPicturebox As PictureBox
    Friend WithEvents quarterPicturebox As PictureBox
    Friend WithEvents dimePicturebox As PictureBox
    Friend WithEvents nickelPicturebox As PictureBox
    Friend WithEvents Productcontrol1 As Productcontrol
    Friend WithEvents Productcontrol2 As Productcontrol
    Friend WithEvents Productcontrol3 As Productcontrol
    Friend WithEvents Productcontrol4 As Productcontrol
    Friend WithEvents Productcontrol5 As Productcontrol
    Friend WithEvents Productcontrol6 As Productcontrol
    Friend WithEvents Productcontrol7 As Productcontrol
    Friend WithEvents Productcontrol8 As Productcontrol
    Friend WithEvents Productcontrol9 As Productcontrol
    Friend WithEvents Productcontrol10 As Productcontrol
    Friend WithEvents Productcontrol11 As Productcontrol
    Friend WithEvents Productcontrol12 As Productcontrol
    Friend WithEvents Productcontrol13 As Productcontrol
    Friend WithEvents Productcontrol14 As Productcontrol
    Friend WithEvents Productcontrol15 As Productcontrol
    Friend WithEvents Productcontrol16 As Productcontrol
    Friend WithEvents Button6 As Button
    Friend WithEvents IDtextbox As TextBox
    Friend WithEvents ProductPB As PictureBox
End Class
