Imports System.IO
Imports System.Text
Imports Rocket.Chat.Net.Driver
Imports Rocket.Chat.Net.Interfaces
Imports Rocket.Chat.Net.Models.LoginOptions

Public Class Form1
    Dim loginOption As ILoginOption
    Dim driver As IRocketChatDriver
    Dim SteemitLinks As New ListBox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddToListButton.Click
        If String.IsNullOrEmpty(RoomName.Text) = False Then
            ListBox1.Items.Add(RoomName.Text)
            If RemoveButton.Enabled = False Then RemoveButton.Enabled = True
        Else
            MsgBox("Channel Name cannot be empty. Please type a Channel Name")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
        If ListBox1.Items.Count = 0 Then
            RemoveButton.Enabled = False
        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Dim ErrorMessage As String = "The following fields are empty:" & vbCrLf
        Dim ErrorsFound As Boolean = False
        If String.IsNullOrEmpty(Server.Text) Then
            ErrorMessage += "-Server" & vbCrLf
            ErrorsFound = True
        End If
        If String.IsNullOrEmpty(UserName.Text) Then
            ErrorMessage += "-Username" & vbCrLf
            ErrorsFound = True
        End If
        If String.IsNullOrEmpty(Password.Text) Then
            ErrorMessage += "-Password" & vbCrLf
            ErrorsFound = True
        End If
        If ListBox1.Items.Count = 0 Then
            ErrorMessage += "-Channel Name(s)" & vbCrLf
            ErrorsFound = True
        End If
        If ErrorsFound = False Then
            My.Settings.Server = Server.Text
            My.Settings.Username = UserName.Text
            My.Settings.Password = Password.Text
            My.Settings.Rooms.Clear()
            For Each item In ListBox1.Items
                My.Settings.Rooms.Add(item)
            Next
            My.Settings.Save()
            loginOption = New LdapLoginOption() With {.Username = UserName.Text, .Password = Password.Text}
            driver = New RocketChatDriver(Server.Text, True)
            Await driver.ConnectAsync()
            Await driver.LoginAsync(loginOption)
            For Each item In ListBox1.Items
                Dim getChannelID = Await driver.GetRoomIdAsync(item)
                Dim RoomIDResult = getChannelID.Result
                Await driver.SubscribeToRoomAsync(RoomIDResult)
                Await driver.SendMessageAsync(SteemitPostLink.Text, RoomIDResult)
                Log.Text += "Posted Link to " & item & vbCrLf
            Next
        Else
            ErrorMessage += vbCrLf & "Please fill the above fields to start using this Bot"
            MsgBox(ErrorMessage)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Rooms Is Nothing Then
            My.Settings.Rooms = New Specialized.StringCollection
        End If
        UserName.Text = My.Settings.Username
        Password.Text = My.Settings.Password
        For Each item In My.Settings.Rooms
            ListBox1.Items.Add(item)
        Next
        If ListBox1.Items.Count > 0 Then
            RemoveButton.Enabled = True
        End If
        If String.IsNullOrEmpty(My.Settings.SteemitUsername) Then
            SteemitUsername.Text = "@username"
        Else
            SteemitUsername.Text = My.Settings.SteemitUsername
        End If
        If My.Settings.Language = 1 Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If

    End Sub

    Private Sub SteemitUsername_TextChanged(sender As Object, e As EventArgs) Handles SteemitUsername.TextChanged
        My.Settings.SteemitUsername = SteemitUsername.Text
        My.Settings.Save()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles GetPostsButton.Click
        ListBox2.Items.Clear()
        SteemitLinks.Items.Clear()
        Dim myWebRequest As Net.WebRequest = Net.WebRequest.Create("https://steemdb.com/" & SteemitUsername.Text & "/posts")
        Dim myWebResponse As Net.WebResponse = myWebRequest.GetResponse()
        Dim ReceiveStream As Stream = myWebResponse.GetResponseStream()
        Dim encode As Encoding = System.Text.Encoding.GetEncoding("utf-8")
        Dim readStream As New StreamReader(ReceiveStream, encode)
        Dim RequestResult As String = readStream.ReadToEnd
        Dim parse1 As CsQuery.CQ = CsQuery.CQ.Create(RequestResult, CsQuery.HtmlParsingMode.Auto, CsQuery.HtmlParsingOptions.IgnoreComments)
        Dim parse2 As CsQuery.CQ = parse1("div.ui.internally.celled.stackable.grid > div")
        For Each div In parse2
            Dim innerHTML As CsQuery.CQ = div.InnerHTML
            SteemitLinks.Items.Add(innerHTML("div.ui.large.header > a").Attr("href"))
            ListBox2.Items.Add(innerHTML("div.ui.large.header > a").Text().TrimStart)
        Next
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        SteemitPostLink.Text = "https://steemit.com" & SteemitLinks.Items.Item(ListBox2.SelectedIndex)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles VoteWitnessLink.LinkClicked
        Process.Start("https://v2.steemconnect.com/sign/account-witness-vote?witness=moisesmcardona&approve=1")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ServerLabel.Text = "Server:"
            UsernameLabel.Text = "Username:"
            PasswordLabel.Text = "Password:"
            ChannelNameLabel.Text = "Channel Name:"
            AddToListButton.Text = "Add To List"
            RemoveButton.Text = "Remove"
            LinkLabel.Text = "Link of the Post to send to Steemit.Chat:"
            SendButton.Text = "Send to Steemit.Chat!"
            SteemitUsernameLabel.Text = "Your Steemit Username:"
            GetPostsButton.Text = "Get your latest posts!"
            CreditsAndVersionLabel.Text = "By: @moisesmcardona" & vbCrLf & "v1.1"
            VoteWitnessLink.Text = "Click Here to Vote Him as Witness!"
            DonateLink.Text = "Or Donate!"
        End If
        My.Settings.Language = 1
        My.Settings.Save()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ServerLabel.Text = "Servidor:"
            UsernameLabel.Text = "Usuario:"
            PasswordLabel.Text = "Contraseña:"
            ChannelNameLabel.Text = "Nombre del canal:"
            AddToListButton.Text = "Añadir a Lista"
            RemoveButton.Text = "Remover"
            LinkLabel.Text = "Link del post a enviar a Steemit.Chat:"
            SendButton.Text = "¡Enviar a Steemit.Chat!"
            SteemitUsernameLabel.Text = "Tu usuario de Steemit:"
            GetPostsButton.Text = "¡Obtener posts!"
            CreditsAndVersionLabel.Text = "Por: @moisesmcardona" & vbCrLf & "v1.1"
            VoteWitnessLink.Text = "¡Click aquí para votarlo como Witness!"
            DonateLink.Text = "¡O Dona!"
        End If
        My.Settings.Language = 2
        My.Settings.Save()
    End Sub

    Private Sub DonateLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DonateLink.LinkClicked
        Donations.ShowDialog()
    End Sub
End Class
