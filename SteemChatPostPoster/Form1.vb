﻿Imports System.IO
Imports System.Text
Imports Rocket.Chat.Net.Driver
Imports Rocket.Chat.Net.Interfaces
Imports Rocket.Chat.Net.Models.LoginOptions

Public Class Form1
    Dim loginOption As ILoginOption
    Dim driver As IRocketChatDriver
    Dim SteemitLinks As New ListBox
    Private Sub AddToListButton_Click(sender As Object, e As EventArgs) Handles AddToListButton.Click
        If String.IsNullOrEmpty(RoomName.Text) = False Then
            RoomsList.Items.Add(RoomName.Text)
            If RemoveButton.Enabled = False Then RemoveButton.Enabled = True
            My.Settings.Rooms.Clear()
            For Each item In RoomsList.Items
                My.Settings.Rooms.Add(item)
            Next
            My.Settings.Save()
        Else
            If EnglishRButton.Checked Then
                MsgBox("Channel Name cannot be empty. Please type a Channel Name.")
            Else
                MsgBox("El nombre del canal no puede estar vacio. Por favor, escriba un canal.")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        If RoomsList.SelectedIndex <> -1 Then
            RoomsList.Items.RemoveAt(RoomsList.SelectedIndex)
            My.Settings.Rooms.Clear()
            For Each item In RoomsList.Items
                My.Settings.Rooms.Add(item)
            Next
            My.Settings.Save()
        End If
        If RoomsList.Items.Count = 0 Then
            RemoveButton.Enabled = False
        End If
    End Sub
    Private Function ValidateEnglish() As String
        Dim ValidationMessage As String = "The following fields are empty:" & vbCrLf
        Dim ValidationError As Boolean = False
        If String.IsNullOrEmpty(Server.Text) Then
            ValidationMessage += "-Server" & vbCrLf
            ValidationError = True
        End If
        If String.IsNullOrEmpty(UserName.Text) Then
            ValidationMessage += "-Username" & vbCrLf
            ValidationError = True
        End If
        If String.IsNullOrEmpty(Password.Text) Then
            ValidationMessage += "-Password" & vbCrLf
            ValidationError = True
        End If
        If RoomsList.Items.Count = 0 Then
            ValidationMessage += "-Channel Name(s)" & vbCrLf
            ValidationError = True
        End If
        If String.IsNullOrEmpty(SteemitPostLink.Text) Then
            ValidationMessage += "-Post Link or message" & vbCrLf
            ValidationError = True
        End If
        If ValidationError Then
            ValidationMessage += vbCrLf & "Please fill the above fields to start using this Bot"
            MessageBox.Show(ValidationMessage)
        End If
        Return ValidationError
    End Function
    Private Function ValidateSpanish() As String
        Dim ValidationMessage As String = "Los siguientes campos están vacíos:" & vbCrLf
        Dim ValidationError As Boolean = False
        If String.IsNullOrEmpty(Server.Text) Then
            ValidationMessage += "-Servidor" & vbCrLf
            ValidationError = True
        End If
        If String.IsNullOrEmpty(UserName.Text) Then
            ValidationMessage += "-Nombre de usuario" & vbCrLf
            ValidationError = True
        End If
        If String.IsNullOrEmpty(Password.Text) Then
            ValidationMessage += "-Contraseña" & vbCrLf
            ValidationError = True
        End If
        If RoomsList.Items.Count = 0 Then
            ValidationMessage += "-Nombre del canal o de los canales" & vbCrLf
            ValidationError = True
        End If
        If String.IsNullOrEmpty(SteemitPostLink.Text) Then
            ValidationMessage += "-Link del post o mensaje" & vbCrLf
            ValidationError = True
        End If
        If ValidationError Then
            ValidationMessage += vbCrLf & "Por favor, corrija los campos mencionados arriba para poder utilizar este bot"
            MessageBox.Show(ValidationMessage)
        End If
        Return ValidationError
    End Function
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Dim ValidationError As Boolean = False
        Dim PostedMessage As String = String.Empty
        Dim ThankYouMessage As String = String.Empty
        If EnglishRButton.Checked Then
            ValidationError = ValidateEnglish()
            PostedMessage = "Posted Link to "
            ThankYouMessage = "--------" + vbCrLf + "Thanks for using this software. " + vbCrLf + "It would be appreciated if you vote @moisesmcardona as a Witness. Press the ""Vote Witness"" menu item above to vote him as a Witness."
        Else
            ValidationError = ValidateSpanish()
            PostedMessage = "Link posteado en "
            ThankYouMessage = "--------" + vbCrLf + "Gracias por utilizar este programa." + vbCrLf + "Agradeceré que votes al Witness @moisesmcardona. Presiona el menú titulado ""Votar Witness"" para votarlo. ¡Gracias!"
        End If
        If ValidationError = False Then
            loginOption = New LdapLoginOption() With {.Username = UserName.Text, .Password = Password.Text}
            driver = New RocketChatDriver(Server.Text, True)
            Await driver.ConnectAsync()
            Await driver.LoginAsync(loginOption)
            If driver.Username IsNot Nothing Then
                For Each item In RoomsList.Items
                    Dim getChannelID = Await driver.GetRoomIdAsync(item)
                    Dim RoomIDResult = getChannelID.Result
                    Await driver.SubscribeToRoomAsync(RoomIDResult)
                    Await driver.SendMessageAsync(SteemitPostLink.Text, RoomIDResult)
                    Log.Text += PostedMessage + item + vbCrLf
                Next
                Log.Text += ThankYouMessage
            Else
                If EnglishRButton.Checked Then
                    MessageBox.Show("The username and/or password provided is invalid")
                Else
                    MessageBox.Show("El nombre de usuario o contraseña es inválido")
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Rooms Is Nothing Then
            My.Settings.Rooms = New Specialized.StringCollection
        End If
        UserName.Text = My.Settings.Username
        Password.Text = My.Settings.Password
        For Each item In My.Settings.Rooms
            RoomsList.Items.Add(item)
        Next
        If RoomsList.Items.Count > 0 Then
            RemoveButton.Enabled = True
        End If
        If String.IsNullOrEmpty(My.Settings.SteemitUsername) Then
            SteemitUsername.Text = "@username"
        Else
            SteemitUsername.Text = My.Settings.SteemitUsername
        End If
        If My.Settings.Language = 1 Then
            EnglishRButton.Checked = True
        Else
            SpanishRButton.Checked = True
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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles EnglishRButton.CheckedChanged
        If EnglishRButton.Checked Then
            ServerLabel.Text = "Server:"
            UsernameLabel.Text = "Username:"
            PasswordLabel.Text = "Password:"
            ChannelNameLabel.Text = "Channel Name:"
            AddToListButton.Text = "Add To List"
            RemoveButton.Text = "Remove"
            LinkLabel.Text = "Link of the Post to send to Steem.Chat:"
            SendButton.Text = "Send to Steem.Chat!"
            SteemUsernameLabel.Text = "Your Steem Username:"
            GetPostsButton.Text = "Get your latest posts!"
            VoteWitnessToolStripMenuItem.Text = "Vote Witness"
            DonationsToolStripMenuItem.Text = "Donations"
            ChannelListToolStripMenuItem.Text = "Channel List"
            ExportToolStripMenuItem.Text = "Export"
            ImportToolStripMenuItem.Text = "Import"
            SteemUserLink.Text = "By Witness @moisesmcardona"
        End If
        My.Settings.Language = 1
        My.Settings.Save()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles SpanishRButton.CheckedChanged
        If SpanishRButton.Checked Then
            ServerLabel.Text = "Servidor:"
            UsernameLabel.Text = "Usuario:"
            PasswordLabel.Text = "Contraseña:"
            ChannelNameLabel.Text = "Nombre del canal:"
            AddToListButton.Text = "Añadir a Lista"
            RemoveButton.Text = "Remover"
            LinkLabel.Text = "Link del post a enviar a Steem.Chat:"
            SendButton.Text = "¡Enviar a Steem.Chat!"
            SteemUsernameLabel.Text = "Tu usuario de Steem:"
            GetPostsButton.Text = "¡Obtener posts!"
            VoteWitnessToolStripMenuItem.Text = "Votar Witness"
            DonationsToolStripMenuItem.Text = "Donar"
            ChannelListToolStripMenuItem.Text = "Lista de canales"
            ExportToolStripMenuItem.Text = "Exportar"
            ImportToolStripMenuItem.Text = "Importar"
            SteemUserLink.Text = "Por Witness @moisesmcardona"
        End If
        My.Settings.Language = 2
        My.Settings.Save()
    End Sub

    Private Sub DonateLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Donations.ShowDialog()
    End Sub

    Private Sub UserName_TextChanged(sender As Object, e As EventArgs) Handles UserName.TextChanged
        My.Settings.Username = UserName.Text
        My.Settings.Save()
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        My.Settings.Password = Password.Text
        My.Settings.Save()
    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        Dim BrowseMessage As String = String.Empty
        If EnglishRButton.Checked Then
            BrowseMessage = "Browse for a channel list file"
        Else
            BrowseMessage = "Busque un archivo de lista de canales"
        End If
        Dim BrowseChannelList As New OpenFileDialog With {
            .Title = BrowseMessage,
            .FileName = "",
            .Filter = "Channel List (*.lis)|*.lis"
        }
        Dim PressedOK As MsgBoxResult = BrowseChannelList.ShowDialog
        If PressedOK = MsgBoxResult.Ok Then
            Dim ChannelList As New StreamReader(BrowseChannelList.FileName)
            My.Settings.Rooms.Clear()
            RoomsList.Items.Clear()
            While Not ChannelList.EndOfStream
                Dim channel As String = ChannelList.ReadLine
                If Not String.IsNullOrEmpty(channel) Then
                    RoomsList.Items.Add(channel)
                    My.Settings.Rooms.Add(channel)
                End If
            End While
            ChannelList.Close()
            If RemoveButton.Enabled = False Then RemoveButton.Enabled = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Dim SuccessMessage As String = String.Empty
        Dim BrowseMessage As String = String.Empty
        If EnglishRButton.Checked Then
            SuccessMessage = "Channel list saved successfully"
            BrowseMessage = "Browse for a location to save the channel list"
        Else
            SuccessMessage = "La lista de canales ha sido guardada exitosamente."
            BrowseMessage = "Busque un lugar para guardar la lista de canales"
        End If
        Dim BrowseSaveLocation As New SaveFileDialog With {
             .Title = BrowseMessage,
            .FileName = "",
            .Filter = "Channel List (*.lis)|*.lis"
        }
        Dim PressedOK As MsgBoxResult = BrowseSaveLocation.ShowDialog
        If PressedOK = MsgBoxResult.Ok Then
            Dim channels As String = String.Empty
            Dim ChannelList As New StreamWriter(BrowseSaveLocation.FileName, False)
            For Each item In RoomsList.Items
                ChannelList.WriteLine(item)
            Next
            ChannelList.Close()
            MessageBox.Show(SuccessMessage)
        End If
    End Sub

    Private Sub SteemUserLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SteemUserLink.LinkClicked
        Process.Start("https://steemit.com/@moisesmcardona")
    End Sub

    Private Sub VoteWitnessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoteWitnessToolStripMenuItem.Click
        Process.Start("https://v2.steemconnect.com/sign/account-witness-vote?witness=moisesmcardona&approve=1")
    End Sub

    Private Sub DonationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonationsToolStripMenuItem.Click
        Donations.ShowDialog()
    End Sub
End Class
