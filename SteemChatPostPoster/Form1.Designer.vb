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
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.Server = New System.Windows.Forms.TextBox()
        Me.ServerLabel = New System.Windows.Forms.Label()
        Me.AddToListButton = New System.Windows.Forms.Button()
        Me.RoomsList = New System.Windows.Forms.ListBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.SteemitPostLink = New System.Windows.Forms.TextBox()
        Me.LinkLabel = New System.Windows.Forms.Label()
        Me.SteemitUsername = New System.Windows.Forms.TextBox()
        Me.SteemUsernameLabel = New System.Windows.Forms.Label()
        Me.GetPostsButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.VoteWitnessLink = New System.Windows.Forms.LinkLabel()
        Me.EnglishRButton = New System.Windows.Forms.RadioButton()
        Me.SpanishRButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DonateLink = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChannelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SteemUserLink = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(146, 64)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(248, 98)
        Me.SendButton.TabIndex = 5
        Me.SendButton.Text = "Send to Steem.Chat!"
        Me.SendButton.UseVisualStyleBackColor = true
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = true
        Me.UsernameLabel.Location = New System.Drawing.Point(12, 64)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(58, 13)
        Me.UsernameLabel.TabIndex = 1
        Me.UsernameLabel.Text = "Username:"
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(15, 80)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(125, 20)
        Me.UserName.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = true
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 103)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(56, 13)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Password:"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(15, 119)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password.Size = New System.Drawing.Size(125, 20)
        Me.Password.TabIndex = 3
        '
        'ChannelNameLabel
        '
        Me.ChannelNameLabel.AutoSize = true
        Me.ChannelNameLabel.Location = New System.Drawing.Point(12, 142)
        Me.ChannelNameLabel.Name = "ChannelNameLabel"
        Me.ChannelNameLabel.Size = New System.Drawing.Size(80, 13)
        Me.ChannelNameLabel.TabIndex = 5
        Me.ChannelNameLabel.Text = "Channel Name:"
        '
        'RoomName
        '
        Me.RoomName.Location = New System.Drawing.Point(15, 158)
        Me.RoomName.Name = "RoomName"
        Me.RoomName.Size = New System.Drawing.Size(125, 20)
        Me.RoomName.TabIndex = 4
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = true
        Me.VersionLabel.Location = New System.Drawing.Point(154, 380)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(28, 13)
        Me.VersionLabel.TabIndex = 7
        Me.VersionLabel.Text = "v1.3"
        '
        'Server
        '
        Me.Server.Location = New System.Drawing.Point(15, 40)
        Me.Server.Name = "Server"
        Me.Server.ReadOnly = true
        Me.Server.Size = New System.Drawing.Size(125, 20)
        Me.Server.TabIndex = 1
        Me.Server.Text = "steem.chat"
        '
        'ServerLabel
        '
        Me.ServerLabel.AutoSize = true
        Me.ServerLabel.Location = New System.Drawing.Point(12, 24)
        Me.ServerLabel.Name = "ServerLabel"
        Me.ServerLabel.Size = New System.Drawing.Size(41, 13)
        Me.ServerLabel.TabIndex = 8
        Me.ServerLabel.Text = "Server:"
        '
        'AddToListButton
        '
        Me.AddToListButton.Location = New System.Drawing.Point(15, 184)
        Me.AddToListButton.Name = "AddToListButton"
        Me.AddToListButton.Size = New System.Drawing.Size(125, 23)
        Me.AddToListButton.TabIndex = 9
        Me.AddToListButton.Text = "Add To List"
        Me.AddToListButton.UseVisualStyleBackColor = true
        '
        'RoomsList
        '
        Me.RoomsList.FormattingEnabled = true
        Me.RoomsList.Location = New System.Drawing.Point(15, 213)
        Me.RoomsList.Name = "RoomsList"
        Me.RoomsList.Size = New System.Drawing.Size(125, 95)
        Me.RoomsList.TabIndex = 10
        '
        'RemoveButton
        '
        Me.RemoveButton.Enabled = false
        Me.RemoveButton.Location = New System.Drawing.Point(15, 314)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(125, 23)
        Me.RemoveButton.TabIndex = 11
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = true
        '
        'SteemitPostLink
        '
        Me.SteemitPostLink.Location = New System.Drawing.Point(146, 38)
        Me.SteemitPostLink.Name = "SteemitPostLink"
        Me.SteemitPostLink.Size = New System.Drawing.Size(248, 20)
        Me.SteemitPostLink.TabIndex = 12
        '
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = true
        Me.LinkLabel.Location = New System.Drawing.Point(143, 22)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(189, 13)
        Me.LinkLabel.TabIndex = 13
        Me.LinkLabel.Text = "Link of the Post to send to Steem.Chat"
        '
        'SteemitUsername
        '
        Me.SteemitUsername.Location = New System.Drawing.Point(400, 37)
        Me.SteemitUsername.Name = "SteemitUsername"
        Me.SteemitUsername.Size = New System.Drawing.Size(383, 20)
        Me.SteemitUsername.TabIndex = 14
        '
        'SteemUsernameLabel
        '
        Me.SteemUsernameLabel.AutoSize = true
        Me.SteemUsernameLabel.Location = New System.Drawing.Point(397, 21)
        Me.SteemUsernameLabel.Name = "SteemUsernameLabel"
        Me.SteemUsernameLabel.Size = New System.Drawing.Size(116, 13)
        Me.SteemUsernameLabel.TabIndex = 15
        Me.SteemUsernameLabel.Text = "Your Steem Username:"
        '
        'GetPostsButton
        '
        Me.GetPostsButton.Location = New System.Drawing.Point(400, 63)
        Me.GetPostsButton.Name = "GetPostsButton"
        Me.GetPostsButton.Size = New System.Drawing.Size(383, 34)
        Me.GetPostsButton.TabIndex = 16
        Me.GetPostsButton.Text = "Get my latest posts"
        Me.GetPostsButton.UseVisualStyleBackColor = true
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(143, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Log:"
        '
        'Log
        '
        Me.Log.Location = New System.Drawing.Point(146, 184)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(248, 153)
        Me.Log.TabIndex = 18
        Me.Log.Text = ""
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = true
        Me.ListBox2.Location = New System.Drawing.Point(400, 103)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(383, 290)
        Me.ListBox2.TabIndex = 19
        '
        'VoteWitnessLink
        '
        Me.VoteWitnessLink.AutoSize = true
        Me.VoteWitnessLink.Location = New System.Drawing.Point(12, 361)
        Me.VoteWitnessLink.Name = "VoteWitnessLink"
        Me.VoteWitnessLink.Size = New System.Drawing.Size(170, 13)
        Me.VoteWitnessLink.TabIndex = 22
        Me.VoteWitnessLink.TabStop = true
        Me.VoteWitnessLink.Text = "Click Here to Vote him as Witness!"
        '
        'EnglishRButton
        '
        Me.EnglishRButton.AutoSize = true
        Me.EnglishRButton.Location = New System.Drawing.Point(6, 19)
        Me.EnglishRButton.Name = "EnglishRButton"
        Me.EnglishRButton.Size = New System.Drawing.Size(59, 17)
        Me.EnglishRButton.TabIndex = 23
        Me.EnglishRButton.TabStop = true
        Me.EnglishRButton.Text = "English"
        Me.EnglishRButton.UseVisualStyleBackColor = true
        '
        'SpanishRButton
        '
        Me.SpanishRButton.AutoSize = true
        Me.SpanishRButton.Location = New System.Drawing.Point(71, 19)
        Me.SpanishRButton.Name = "SpanishRButton"
        Me.SpanishRButton.Size = New System.Drawing.Size(63, 17)
        Me.SpanishRButton.TabIndex = 24
        Me.SpanishRButton.TabStop = true
        Me.SpanishRButton.Text = "Español"
        Me.SpanishRButton.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EnglishRButton)
        Me.GroupBox1.Controls.Add(Me.SpanishRButton)
        Me.GroupBox1.Location = New System.Drawing.Point(255, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(139, 42)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Language / Idioma"
        '
        'DonateLink
        '
        Me.DonateLink.AutoSize = true
        Me.DonateLink.Location = New System.Drawing.Point(12, 377)
        Me.DonateLink.Name = "DonateLink"
        Me.DonateLink.Size = New System.Drawing.Size(59, 13)
        Me.DonateLink.TabIndex = 26
        Me.DonateLink.TabStop = true
        Me.DonateLink.Text = "Or Donate!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChannelListToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChannelListToolStripMenuItem
        '
        Me.ChannelListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.ChannelListToolStripMenuItem.Name = "ChannelListToolStripMenuItem"
        Me.ChannelListToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ChannelListToolStripMenuItem.Text = "Channel List"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'SteemUserLink
        '
        Me.SteemUserLink.AutoSize = true
        Me.SteemUserLink.Location = New System.Drawing.Point(12, 346)
        Me.SteemUserLink.Name = "SteemUserLink"
        Me.SteemUserLink.Size = New System.Drawing.Size(115, 13)
        Me.SteemUserLink.TabIndex = 28
        Me.SteemUserLink.TabStop = true
        Me.SteemUserLink.Text = "By: @moisesmcardona"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 407)
        Me.Controls.Add(Me.SteemUserLink)
        Me.Controls.Add(Me.DonateLink)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VoteWitnessLink)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GetPostsButton)
        Me.Controls.Add(Me.SteemitUsername)
        Me.Controls.Add(Me.SteemUsernameLabel)
        Me.Controls.Add(Me.SteemitPostLink)
        Me.Controls.Add(Me.LinkLabel)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.RoomsList)
        Me.Controls.Add(Me.AddToListButton)
        Me.Controls.Add(Me.Server)
        Me.Controls.Add(Me.ServerLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.RoomName)
        Me.Controls.Add(Me.ChannelNameLabel)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.Name = "Form1"
        Me.Text = "Steem.Chat Post Poster"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents SendButton As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents UserName As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents ChannelNameLabel As Label
    Friend WithEvents RoomName As TextBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents Server As TextBox
    Friend WithEvents ServerLabel As Label
    Friend WithEvents AddToListButton As Button
    Friend WithEvents RoomsList As ListBox
    Friend WithEvents RemoveButton As Button
    Friend WithEvents SteemitPostLink As TextBox
    Friend WithEvents LinkLabel As Label
    Friend WithEvents SteemitUsername As TextBox
    Friend WithEvents SteemUsernameLabel As Label
    Friend WithEvents GetPostsButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Log As RichTextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents VoteWitnessLink As LinkLabel
    Friend WithEvents EnglishRButton As RadioButton
    Friend WithEvents SpanishRButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DonateLink As LinkLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChannelListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SteemUserLink As LinkLabel
End Class
