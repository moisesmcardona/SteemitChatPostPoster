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
        Me.SendButton = New System.Windows.Forms.Button()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ChannelNameLabel = New System.Windows.Forms.Label()
        Me.RoomName = New System.Windows.Forms.TextBox()
        Me.CreditsAndVersionLabel = New System.Windows.Forms.Label()
        Me.Server = New System.Windows.Forms.TextBox()
        Me.ServerLabel = New System.Windows.Forms.Label()
        Me.AddToListButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SteemitPostLink = New System.Windows.Forms.TextBox()
        Me.LinkLabel = New System.Windows.Forms.Label()
        Me.SteemitUsername = New System.Windows.Forms.TextBox()
        Me.SteemitUsernameLabel = New System.Windows.Forms.Label()
        Me.GetPostsButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.VoteWitnessLink = New System.Windows.Forms.LinkLabel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DonateLink = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(141, 49)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(248, 98)
        Me.SendButton.TabIndex = 5
        Me.SendButton.Text = "Send to Steemit.Chat!"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(7, 49)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(58, 13)
        Me.UsernameLabel.TabIndex = 1
        Me.UsernameLabel.Text = "Username:"
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(10, 65)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(125, 20)
        Me.UserName.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(7, 88)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(56, 13)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password:"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(10, 104)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password.Size = New System.Drawing.Size(125, 20)
        Me.Password.TabIndex = 3
        '
        'ChannelNameLabel
        '
        Me.ChannelNameLabel.AutoSize = True
        Me.ChannelNameLabel.Location = New System.Drawing.Point(7, 127)
        Me.ChannelNameLabel.Name = "ChannelNameLabel"
        Me.ChannelNameLabel.Size = New System.Drawing.Size(80, 13)
        Me.ChannelNameLabel.TabIndex = 5
        Me.ChannelNameLabel.Text = "Channel Name:"
        '
        'RoomName
        '
        Me.RoomName.Location = New System.Drawing.Point(10, 143)
        Me.RoomName.Name = "RoomName"
        Me.RoomName.Size = New System.Drawing.Size(125, 20)
        Me.RoomName.TabIndex = 4
        '
        'CreditsAndVersionLabel
        '
        Me.CreditsAndVersionLabel.AutoSize = True
        Me.CreditsAndVersionLabel.Location = New System.Drawing.Point(7, 333)
        Me.CreditsAndVersionLabel.Name = "CreditsAndVersionLabel"
        Me.CreditsAndVersionLabel.Size = New System.Drawing.Size(115, 26)
        Me.CreditsAndVersionLabel.TabIndex = 7
        Me.CreditsAndVersionLabel.Text = "By: @moisesmcardona" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "v1.1"
        '
        'Server
        '
        Me.Server.Location = New System.Drawing.Point(10, 25)
        Me.Server.Name = "Server"
        Me.Server.ReadOnly = True
        Me.Server.Size = New System.Drawing.Size(125, 20)
        Me.Server.TabIndex = 1
        Me.Server.Text = "steemit.chat"
        '
        'ServerLabel
        '
        Me.ServerLabel.AutoSize = True
        Me.ServerLabel.Location = New System.Drawing.Point(7, 9)
        Me.ServerLabel.Name = "ServerLabel"
        Me.ServerLabel.Size = New System.Drawing.Size(41, 13)
        Me.ServerLabel.TabIndex = 8
        Me.ServerLabel.Text = "Server:"
        '
        'AddToListButton
        '
        Me.AddToListButton.Location = New System.Drawing.Point(10, 169)
        Me.AddToListButton.Name = "AddToListButton"
        Me.AddToListButton.Size = New System.Drawing.Size(125, 23)
        Me.AddToListButton.TabIndex = 9
        Me.AddToListButton.Text = "Add To List"
        Me.AddToListButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(10, 198)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(125, 95)
        Me.ListBox1.TabIndex = 10
        '
        'RemoveButton
        '
        Me.RemoveButton.Enabled = False
        Me.RemoveButton.Location = New System.Drawing.Point(10, 299)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(125, 23)
        Me.RemoveButton.TabIndex = 11
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'SteemitPostLink
        '
        Me.SteemitPostLink.Location = New System.Drawing.Point(141, 23)
        Me.SteemitPostLink.Name = "SteemitPostLink"
        Me.SteemitPostLink.Size = New System.Drawing.Size(248, 20)
        Me.SteemitPostLink.TabIndex = 12
        '
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = True
        Me.LinkLabel.Location = New System.Drawing.Point(138, 7)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(194, 13)
        Me.LinkLabel.TabIndex = 13
        Me.LinkLabel.Text = "Link of the Post to send to Steemit.Chat"
        '
        'SteemitUsername
        '
        Me.SteemitUsername.Location = New System.Drawing.Point(395, 22)
        Me.SteemitUsername.Name = "SteemitUsername"
        Me.SteemitUsername.Size = New System.Drawing.Size(383, 20)
        Me.SteemitUsername.TabIndex = 14
        '
        'SteemitUsernameLabel
        '
        Me.SteemitUsernameLabel.AutoSize = True
        Me.SteemitUsernameLabel.Location = New System.Drawing.Point(392, 6)
        Me.SteemitUsernameLabel.Name = "SteemitUsernameLabel"
        Me.SteemitUsernameLabel.Size = New System.Drawing.Size(121, 13)
        Me.SteemitUsernameLabel.TabIndex = 15
        Me.SteemitUsernameLabel.Text = "Your Steemit Username:"
        '
        'GetPostsButton
        '
        Me.GetPostsButton.Location = New System.Drawing.Point(395, 48)
        Me.GetPostsButton.Name = "GetPostsButton"
        Me.GetPostsButton.Size = New System.Drawing.Size(383, 34)
        Me.GetPostsButton.TabIndex = 16
        Me.GetPostsButton.Text = "Get my latest posts"
        Me.GetPostsButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(138, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Log:"
        '
        'Log
        '
        Me.Log.Location = New System.Drawing.Point(141, 169)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(248, 153)
        Me.Log.TabIndex = 18
        Me.Log.Text = ""
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(395, 88)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(383, 290)
        Me.ListBox2.TabIndex = 19
        '
        'VoteWitnessLink
        '
        Me.VoteWitnessLink.AutoSize = True
        Me.VoteWitnessLink.Location = New System.Drawing.Point(7, 365)
        Me.VoteWitnessLink.Name = "VoteWitnessLink"
        Me.VoteWitnessLink.Size = New System.Drawing.Size(170, 13)
        Me.VoteWitnessLink.TabIndex = 22
        Me.VoteWitnessLink.TabStop = True
        Me.VoteWitnessLink.Text = "Click Here to Vote him as Witness!"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton1.TabIndex = 23
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "English"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(71, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton2.TabIndex = 24
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Español"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(250, 333)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 42)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Language / Idioma"
        '
        'DonateLink
        '
        Me.DonateLink.AutoSize = True
        Me.DonateLink.Location = New System.Drawing.Point(191, 365)
        Me.DonateLink.Name = "DonateLink"
        Me.DonateLink.Size = New System.Drawing.Size(59, 13)
        Me.DonateLink.TabIndex = 26
        Me.DonateLink.TabStop = True
        Me.DonateLink.Text = "Or Donate!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 393)
        Me.Controls.Add(Me.DonateLink)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VoteWitnessLink)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GetPostsButton)
        Me.Controls.Add(Me.SteemitUsername)
        Me.Controls.Add(Me.SteemitUsernameLabel)
        Me.Controls.Add(Me.SteemitPostLink)
        Me.Controls.Add(Me.LinkLabel)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.AddToListButton)
        Me.Controls.Add(Me.Server)
        Me.Controls.Add(Me.ServerLabel)
        Me.Controls.Add(Me.CreditsAndVersionLabel)
        Me.Controls.Add(Me.RoomName)
        Me.Controls.Add(Me.ChannelNameLabel)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.SendButton)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Steemit.Chat Post Poster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SendButton As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents UserName As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents ChannelNameLabel As Label
    Friend WithEvents RoomName As TextBox
    Friend WithEvents CreditsAndVersionLabel As Label
    Friend WithEvents Server As TextBox
    Friend WithEvents ServerLabel As Label
    Friend WithEvents AddToListButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents RemoveButton As Button
    Friend WithEvents SteemitPostLink As TextBox
    Friend WithEvents LinkLabel As Label
    Friend WithEvents SteemitUsername As TextBox
    Friend WithEvents SteemitUsernameLabel As Label
    Friend WithEvents GetPostsButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Log As RichTextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents VoteWitnessLink As LinkLabel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DonateLink As LinkLabel
End Class
