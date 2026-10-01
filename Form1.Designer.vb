<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        LeftPanel = New Panel()
        LabelWelcome = New Label()
        LabelLogo = New Label()
        LoginPanel = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        LabelSubtitle = New Label()
        Label1 = New Label()
        LeftPanel.SuspendLayout()
        LoginPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' LeftPanel
        ' 
        LeftPanel.BackColor = Color.FromArgb(CByte(31), CByte(122), CByte(78))
        LeftPanel.Controls.Add(LabelWelcome)
        LeftPanel.Controls.Add(LabelLogo)
        LeftPanel.Dock = DockStyle.Left
        LeftPanel.Location = New Point(0, 0)
        LeftPanel.Margin = New Padding(3, 2, 3, 2)
        LeftPanel.Name = "LeftPanel"
        LeftPanel.Size = New Size(298, 390)
        LeftPanel.TabIndex = 0
        ' 
        ' LabelWelcome
        ' 
        LabelWelcome.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        LabelWelcome.ForeColor = Color.White
        LabelWelcome.Location = New Point(26, 142)
        LabelWelcome.Name = "LabelWelcome"
        LabelWelcome.Size = New Size(245, 45)
        LabelWelcome.TabIndex = 1
        LabelWelcome.Text = "Welcome!"
        LabelWelcome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelLogo
        ' 
        LabelLogo.Font = New Font("Segoe UI Emoji", 52F)
        LabelLogo.ForeColor = Color.White
        LabelLogo.Location = New Point(79, 60)
        LabelLogo.Name = "LabelLogo"
        LabelLogo.Size = New Size(140, 75)
        LabelLogo.TabIndex = 0
        LabelLogo.Text = "🍴"
        LabelLogo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginPanel
        ' 
        LoginPanel.BackColor = Color.White
        LoginPanel.Controls.Add(Button2)
        LoginPanel.Controls.Add(Button1)
        LoginPanel.Controls.Add(ComboBox1)
        LoginPanel.Controls.Add(TextBox2)
        LoginPanel.Controls.Add(TextBox1)
        LoginPanel.Controls.Add(Label4)
        LoginPanel.Controls.Add(Label3)
        LoginPanel.Controls.Add(Label2)
        LoginPanel.Controls.Add(LabelSubtitle)
        LoginPanel.Controls.Add(Label1)
        LoginPanel.Location = New Point(350, 34)
        LoginPanel.Margin = New Padding(3, 2, 3, 2)
        LoginPanel.Name = "LoginPanel"
        LoginPanel.Size = New Size(341, 322)
        LoginPanel.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        Button2.Location = New Point(214, 264)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(88, 34)
        Button2.TabIndex = 9
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(31), CByte(122), CByte(78))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(42, 264)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 34)
        Button1.TabIndex = 8
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(248))
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 11F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Cashier", "Manager"})
        ComboBox1.Location = New Point(39, 223)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(263, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(248))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 11F)
        TextBox2.Location = New Point(39, 168)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Enter your password"
        TextBox2.Size = New Size(263, 27)
        TextBox2.TabIndex = 5
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(248))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.Location = New Point(39, 113)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter your username"
        TextBox1.Size = New Size(263, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Label4.Location = New Point(39, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 19)
        Label4.TabIndex = 6
        Label4.Text = "Role"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Label3.Location = New Point(39, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 19)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Label2.Location = New Point(39, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 19)
        Label2.TabIndex = 2
        Label2.Text = "Username"
        ' 
        ' LabelSubtitle
        ' 
        LabelSubtitle.Font = New Font("Segoe UI", 10F)
        LabelSubtitle.ForeColor = Color.Gray
        LabelSubtitle.Location = New Point(31, 58)
        LabelSubtitle.Name = "LabelSubtitle"
        LabelSubtitle.Size = New Size(280, 19)
        LabelSubtitle.TabIndex = 1
        LabelSubtitle.Text = "Sign in to continue"
        LabelSubtitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(31), CByte(122), CByte(78))
        Label1.Location = New Point(18, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(332, 41)
        Label1.TabIndex = 0
        Label1.Text = "School Canteen"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(237), CByte(241), CByte(239))
        CancelButton = Button2
        ClientSize = New Size(744, 390)
        Controls.Add(LoginPanel)
        Controls.Add(LeftPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Canteen Management System"
        LeftPanel.ResumeLayout(False)
        LoginPanel.ResumeLayout(False)
        LoginPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LeftPanel As Panel
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents LabelLogo As Label
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class