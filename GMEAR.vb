Imports System.Xml

Public Class GMEAR
    Private Sub GMEAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'https://api.worldoftanks.eu/wot/globalmap/eventaccountratings/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&front_id=renaissance_bg&event_id=renaissance&page_no=1&limit=20&in_rating=1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(txtLimit.Text) < 10 Then
            MsgBox("Accounts limit Min value is 10. Maximum value: 100." & vbNewLine & "will show now 10 instead")
            txtLimit.Text = "10"
        End If
        If Val(txtPage.Text) < 1 Then
            MsgBox("page number min value is 1" & vbNewLine & "I will show you page no. 1 instad")
            txtPage.Text = "1"
        End If

        Dim link As String = String.Format("https://api.worldoftanks.{0}/wot/globalmap/eventaccountratings/?application_id={1}&front_id={2}&event_id={3}&page_no={4}&limit={5}&in_rating=1", APIRealm, APIID, FrontID, EventID, txtPage.Text, txtLimit.Text)
        Dim Doc As XmlDocument = DownloadAPI(link)
        Dim i As Integer = 0
        For Each item As XmlNode In Doc.ChildNodes(0)
            i += 1
            If i > 2 Then
                Dim AccountRank As String = item.ChildNodes(0).InnerText
                Dim AccountAwardLevel As String = item.ChildNodes(1).InnerText
                Dim AccountID As String = item.ChildNodes(2).InnerText
                Dim AccountEventID As String = item.ChildNodes(3).InnerText
                Dim AccountRankDelta As String = item.ChildNodes(4).InnerText
                Dim AccountFamePointsToImproveAward As String = item.ChildNodes(5).InnerText
                Dim AccountUpdatedAt As String = item.ChildNodes(6).InnerText
                Dim AccountBattles As String = item.ChildNodes(7).InnerText
                Dim AccountClanRank As String = item.ChildNodes(8).InnerText
                Dim AccountClanID As String = item.ChildNodes(9).InnerText
                Dim AccountURL As String = item.ChildNodes(10).InnerText
                Dim AccountBattlesToAward As String = item.ChildNodes(11).InnerText
                Dim AccountFamePoints As String = item.ChildNodes(12).InnerText
                Dim AccountFrontID As String = item.ChildNodes(13).InnerText

                dgvEventAccountRating.Rows.Add(AccountRank, AccountID, AccountBattles, AccountFamePoints, AccountClanID, AccountClanRank)
            End If
        Next
    End Sub

End Class