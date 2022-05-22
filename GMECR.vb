Imports System.Xml
Public Class GMECR
    Dim front_id As String = "renaissance_bg"
    Dim event_id As String = "renaissance"
    Dim participants As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim link As String = String.Format("https://api.worldoftanks.{0}/wot/globalmap/eventrating/?application_id={1}&event_id={2}&front_id={3}&limit={4}&page_no={5}", APIRealm, APIID, event_id, front_id, txtLimit.Text, txtPage.Text)
        DownloadAPI(link, "EventClanRatings")
        Dim Doc As New XmlDocument
        Doc.Load("data\EventClanRatings.xml")
        participants = Val(Doc.ChildNodes(0).ChildNodes(1).ChildNodes(1).InnerText) * Val(txtLimit.Text)
        Dim i As Integer = 0
        For Each item As XmlNode In Doc.ChildNodes(0)
            i += 1
            If i > 2 Then
                Dim AwardLevel As String = item.ChildNodes(0).InnerText
                Dim ClanName As String = item.ChildNodes(1).InnerText
                Dim ClanColor As String = item.ChildNodes(2).InnerText
                Dim ClanBattleFamePoints As String = item.ChildNodes(3).InnerText
                Dim ClanRankDelta As String = item.ChildNodes(4).InnerText
                Dim ClanTag As String = item.ChildNodes(5).InnerText
                Dim ClanUpdatedAt As String = item.ChildNodes(6).InnerText
                Dim ClanRank As String = item.ChildNodes(7).InnerText
                Dim ClanTotalFamePoints As String = item.ChildNodes(8).InnerText
                Dim ClanID As String = item.ChildNodes(9).InnerText
                Dim clanTaskFamePoints As String = item.ChildNodes(10).InnerText

                dgvEventAccountRating.Rows.Add(AwardLevel, ClanName, ClanTotalFamePoints)
            End If
        Next
    End Sub

    'https://api.worldoftanks.eu/wot/globalmap/eventrating/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&event_id=renaissance&front_id=renaissance_bg&limit=10&page_no=1

End Class