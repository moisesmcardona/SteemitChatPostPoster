Imports Rocket.Chat.Net.Driver
Imports Rocket.Chat.Net.Interfaces
Imports Rocket.Chat.Net.Models.LoginOptions

Public Class Form1
    Dim loginOption As ILoginOption
    Dim driver As IRocketChatDriver
    Dim SteemitLinks As New ListBox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(RoomName.Text) = False Then
            ListBox1.Items.Add(RoomName.Text)
            If Button3.Enabled = False Then Button3.Enabled = True
        Else
            MsgBox("Channel Name cannot be empty. Please type a Channel Name")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
        If ListBox1.Items.Count = 0 Then
            Button3.Enabled = False
        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
            Button3.Enabled = True
        End If
        If String.IsNullOrEmpty(My.Settings.SteemitUsername) Then
            SteemitUsername.Text = "@username"
        Else
            SteemitUsername.Text = My.Settings.SteemitUsername
        End If

    End Sub

    Private Sub SteemitUsername_TextChanged(sender As Object, e As EventArgs) Handles SteemitUsername.TextChanged
        My.Settings.SteemitUsername = SteemitUsername.Text
        My.Settings.Save()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox2.Items.Clear()
        SteemitLinks.Items.Clear()
        WebBrowser1.Navigate("https://steemit.com/" & SteemitUsername.Text)

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        SteemitPostLink.Text = "https://steemit.com" & SteemitLinks.Items.Item(ListBox2.SelectedIndex)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Try
            Dim parse1 As CsQuery.CQ = CsQuery.CQ.Create(WebBrowser1.DocumentText, CsQuery.HtmlParsingMode.Auto, CsQuery.HtmlParsingOptions.IgnoreComments)
            Dim parseArticle As CsQuery.CQ = parse1("article.PostSummary.hentry.with-image")
            Dim SteemItURL As String = "https://steemit.com"
            Dim SQLInsert As String = ""
            For Each div In parseArticle
                Dim innerHTML As CsQuery.CQ = div.InnerHTML
                SteemitLinks.Items.Add(innerHTML("div.PostSummary__content > div.PostSummary__header.show-for-medium > h3 > a").Attr("href"))
                ListBox2.Items.Add(innerHTML("div.PostSummary__content > div.PostSummary__header.show-for-medium > h3 > a").Text())
            Next
        Catch ex As Exception
            MsgBox("An error has occured. Please check the error below: " & vbNewLine & ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Donations.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://steemit.com/@moisesmcardona")
    End Sub
End Class
