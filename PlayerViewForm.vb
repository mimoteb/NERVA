Public Class PlayerViewForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim player As New Player("Dakillzor")
        lblPlayerNick.Text = player.Name
        lblPlayerID.Text = player.ID
        lblKillRecord.Text = "Kill Record: " & player.Randoms_max_frags
        lblAverageXP.Text = "Average XP: " & player.Randoms_battle_avg_xp
        lblXPRecord.Text = "XP Record: " & player.Randoms_max_xp
        lblHitRatio.Text = "Hit Ratio: " & player.Randoms_hits_percents & "%"
        lblPlayerClan.Text = "Clan"
        lblWN8.Text = "WN8 : " & ""
        lblWinRate.Text = "Winrate: " & WinrateCalculator(player.Randoms_battles, player.Randoms_wins)
        lblBattles.Text = "Battles: " & player.Randoms_battles
        lblPersonalRating.Text = "Personal Rating: " & player.global_rating
    End Sub
End Class