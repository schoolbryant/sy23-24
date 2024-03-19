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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReelControl3 = New Slot_Machine.ReelControl()
        Me.ReelControl2 = New Slot_Machine.ReelControl()
        Me.ReelControl1 = New Slot_Machine.ReelControl()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "SM7.jfif")
        Me.ImageList1.Images.SetKeyName(1, "SMApple.jfif")
        Me.ImageList1.Images.SetKeyName(2, "SMDiamond.jfif")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Label3"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(557, 235)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(48, 16)
        Me.totalLabel.TabIndex = 9
        Me.totalLabel.Text = "Label4"
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.Slot_Machine.My.Resources.Resources.nickle
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.Location = New System.Drawing.Point(491, 368)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(76, 70)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "Nickels"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.Slot_Machine.My.Resources.Resources.dime
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.Location = New System.Drawing.Point(401, 368)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(76, 70)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Dimes"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.Slot_Machine.My.Resources.Resources.quarter
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Location = New System.Drawing.Point(491, 269)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(76, 70)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "Quarters"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.Slot_Machine.My.Resources.Resources.dollar_coin
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.Location = New System.Drawing.Point(401, 269)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(76, 70)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "Dollars"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Slot_Machine.My.Resources.Resources.SM_Lever
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(542, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 75)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReelControl3
        '
        Me.ReelControl3.BackColor = System.Drawing.Color.SlateBlue
        Me.ReelControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl3.ItemValue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(324, 92)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl3.SpinTime = 2000
        Me.ReelControl3.TabIndex = 6
        '
        'ReelControl2
        '
        Me.ReelControl2.BackColor = System.Drawing.Color.SlateBlue
        Me.ReelControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl2.ItemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(168, 92)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl2.SpinTime = 2000
        Me.ReelControl2.TabIndex = 5
        '
        'ReelControl1
        '
        Me.ReelControl1.BackColor = System.Drawing.Color.SlateBlue
        Me.ReelControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl1.ItemValue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(12, 92)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(150, 150)
        Me.ReelControl1.SpinTime = 2000
        Me.ReelControl1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
End Class
