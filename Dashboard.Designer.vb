<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Panel1 = New Panel()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(31), CByte(122), CByte(78))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(900, 90)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(25, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(850, 60)
        Label1.TabIndex = 0
        Label1.Text = "SCHOOL CANTEEN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(35), CByte(85), CByte(120))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(35, 15)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 45)
        Button1.TabIndex = 0
        Button1.Text = "HOME"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(160))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(205, 15)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 45)
        Button2.TabIndex = 1
        Button2.Text = "ORDERS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(160))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10F)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(375, 15)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 45)
        Button3.TabIndex = 2
        Button3.Text = "INVENTORY"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(160))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 10F)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(545, 15)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 45)
        Button4.TabIndex = 3
        Button4.Text = "REPORTS"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Firebrick
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button5.ForeColor = Color.White
        Button5.Location = New Point(715, 15)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 45)
        Button5.TabIndex = 4
        Button5.Text = "LOGOUT"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(35), CByte(85), CByte(120))
        Label2.Location = New Point(290, 230)
        Label2.Name = "Label2"
        Label2.Size = New Size(320, 62)
        Label2.TabIndex = 2
        Label2.Text = "DASHBOARD"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 17F)
        Label3.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        Label3.Location = New Point(150, 310)
        Label3.Name = "Label3"
        Label3.Size = New Size(600, 45)
        Label3.TabIndex = 3
        Label3.Text = "Welcome to the School Canteen System!"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button5)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 90)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(900, 75)
        Panel2.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(150, 370)
        Label4.Name = "Label4"
        Label4.Size = New Size(600, 40)
        Label4.TabIndex = 4
        Label4.Text = "Select an option from the menu above."
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        ClientSize = New Size(900, 550)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Canteen Dashboard"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button

End Class