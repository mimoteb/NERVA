Imports System.Net.NetworkInformation
Imports System.Xml

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'StartupForm.ShowDialog()

        conn.Open()
        'lblPlayerID.Text = player.ID
        'lblPlayerNick.Text = player.Name
        'lblGMTotalFamePoints.Text = player.GM_FamePoints
        'lblGMRank.Text = player.GM_Rank
        FamePointsBattleLog.ShowDialog()

    End Sub

    Private Sub ExitTeabagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitTeabagToolStripMenuItem.Click
        Application.Exit()
    End Sub



#Region "Menus"
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub


    Private Sub ClansToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClansToolStripMenuItem1.Click
        GMECR.Show()
    End Sub


    Private Sub PlayersToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles PlayersToolStripMenuItem1.Click
        GMEAR.Show()
    End Sub

    Private Sub tmrInterfaceUpdate_Tick(sender As Object, e As EventArgs) Handles tmrInterfaceUpdate.Tick
        Dim Doc As New XmlDocument
        Doc = DownloadAPI(String.Format("https://api.worldoftanks.{0}/wgn/servers/info/?application_id={1}&language={2}", APIRealm, APIID, APILang))
        Dim eu1 As String = Doc.ChildNodes(0).ChildNodes(1).ChildNodes(2).ChildNodes(0).InnerText
        Dim eu2 As String = Doc.ChildNodes(0).ChildNodes(1).ChildNodes(1).ChildNodes(0).InnerText
        Dim eu1PingReq As New Ping
        Dim eu1Ping As String = "EU1: " & eu1PingReq.Send("login.p1.worldoftanks.eu").RoundtripTime
        Dim eu2PingReq As New Ping
        Dim EU2Ping As String = "EU2: " & eu2PingReq.Send("login.p2.worldoftanks.eu").RoundtripTime
        lblServerStatus.Text = "Eu1: " & eu1 & " (" & eu1Ping & " ms) Eu2: " & eu2 & " (" & EU2Ping & " ms) - Total Online: " & Val(eu1) + Val(eu2)
    End Sub

    Private Sub MyProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyProfileToolStripMenuItem.Click
        PlayerViewForm.Show()
    End Sub


#End Region

End Class
