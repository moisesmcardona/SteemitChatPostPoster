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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoomName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Server = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SteemitPostLink = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SteemitUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 98)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Send to Steemit.Chat!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(10, 65)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(125, 20)
        Me.UserName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(10, 104)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password.Size = New System.Drawing.Size(125, 20)
        Me.Password.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Channel Name:"
        '
        'RoomName
        '
        Me.RoomName.Location = New System.Drawing.Point(10, 143)
        Me.RoomName.Name = "RoomName"
        Me.RoomName.Size = New System.Drawing.Size(125, 20)
        Me.RoomName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "By: Moisés Cardona" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "v1.0"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Server:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Add To List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(10, 198)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(125, 95)
        Me.ListBox1.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(10, 299)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SteemitPostLink
        '
        Me.SteemitPostLink.Location = New System.Drawing.Point(141, 23)
        Me.SteemitPostLink.Name = "SteemitPostLink"
        Me.SteemitPostLink.Size = New System.Drawing.Size(248, 20)
        Me.SteemitPostLink.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(138, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Link of the Post to send to Steemit.Chat"
        '
        'SteemitUsername
        '
        Me.SteemitUsername.Location = New System.Drawing.Point(395, 22)
        Me.SteemitUsername.Name = "SteemitUsername"
        Me.SteemitUsername.Size = New System.Drawing.Size(383, 20)
        Me.SteemitUsername.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(392, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Your Steemit Username:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(395, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(383, 34)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Get my latest posts"
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.ListBox2.Size = New System.Drawing.Size(383, 238)
        Me.ListBox2.TabIndex = 19
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(784, 9)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(729, 320)
        Me.WebBrowser1.TabIndex = 20
        Me.WebBrowser1.Visible = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(141, 333)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(256, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Do you like this software? DONATE!"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 365)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.SteemitUsername)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SteemitPostLink)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Server)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RoomName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Steemit.Chat Post Poster"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RoomName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Server As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents SteemitPostLink As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SteemitUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Log As RichTextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button5 As Button
End Class
