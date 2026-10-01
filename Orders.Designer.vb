<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Orders
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(35), CByte(85), CByte(120))
        Label1.Location = New Point(250, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 62)
        Label1.TabIndex = 1
        Label1.Text = "ORDER MENU"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(200, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(500, 32)
        Label2.TabIndex = 2
        Label2.Text = "Choose a food category"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RoyalBlue
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(24, 55)
        Button1.Name = "Button1"
        Button1.Size = New Size(180, 57)
        Button1.TabIndex = 0
        Button1.Text = "MEALS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(24, 55)
        Button2.Name = "Button2"
        Button2.Size = New Size(180, 57)
        Button2.TabIndex = 0
        Button2.Text = "SNACKS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(180))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(24, 55)
        Button3.Name = "Button3"
        Button3.Size = New Size(180, 57)
        Button3.TabIndex = 0
        Button3.Text = "DRINKS"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Firebrick
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(335, 426)
        Button4.Name = "Button4"
        Button4.Size = New Size(244, 42)
        Button4.TabIndex = 6
        Button4.Text = "BACK TO DASHBOARD"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(70, 184)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(230, 167)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button2)
        Panel2.Location = New Point(335, 184)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(230, 167)
        Panel2.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Button3)
        Panel3.Location = New Point(600, 184)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(230, 167)
        Panel3.TabIndex = 5
        ' 
        ' Orders
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        ClientSize = New Size(900, 520)
        Controls.Add(Button4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Orders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Canteen - Orders"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel

End Class