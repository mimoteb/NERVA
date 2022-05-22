Public Class FamePointsBattleLog
    Private Sub FamePointsBattleLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = Today.ToString("dd.MM.yyyy")
        cboCurrentBooster.SelectedIndex = 0
        updateStatistics()
    End Sub

    Private Sub updateStatistics()
        Dim BattlesPlayed As String = 0
        Dim TotalBaseFamePoints As String = 0
        Dim totalFamePointsWithBonus As String = 0
        Dim TotalFamePointsFarmedByBonuses As String = 0
        Dim BonusImpact As String = ""
        ' Battles Played
        cmd.CommandText = "SELECT count(ID) from PersonalFamePointsBattlesLog"
        Reader = cmd.ExecuteReader
        While Reader.Read
            BattlesPlayed = CInt(Reader.GetValue(0)) + 1
        End While
        lblBattlesPlayed.Text = "Battles Played: " & BattlesPlayed
        Reader.Close()

        'Total Base Fame Points
        cmd.CommandText = "select sum(Base) FROM PersonalFamePointsBattlesLog"
        Reader = cmd.ExecuteReader
        While Reader.Read
            TotalBaseFamePoints = Reader.GetValue(0)
        End While
        lblTotalBaseFamePoints.Text = "Total Base Fame Points: " & TotalBaseFamePoints
        Reader.Close()

        'Total Fame Points With Bonus
        cmd.CommandText = "SELECT sum(Income) from PersonalFamePointsBattlesLog"
        Reader = cmd.ExecuteReader
        While Reader.Read
            totalFamePointsWithBonus = Reader.GetValue(0)
        End While
        lblTotalFamePointsWithBonus.Text = "Total Fame Points With Bonus: " & totalFamePointsWithBonus
        Reader.Close()
        'Total Fame points Farmed By Bonuses
        cmd.CommandText = "select sum(Addition) FROM PersonalFamePointsBattlesLog"
        Reader = cmd.ExecuteReader
        While Reader.Read
            TotalFamePointsFarmedByBonuses = Reader.GetValue(0).ToString
        End While
        lblTotalFamePointsFarmedByBonuses.Text = "Total Fame Points Farmed By Bonuses: " & TotalFamePointsFarmedByBonuses
        Reader.Close()

        'Bonus Impact
        BonusImpact = CInt(totalFamePointsWithBonus) - CInt(TotalBaseFamePoints)
        lblBonusImpact.Text = "Bonus Impact: " & BonusImpact
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Base As String = ""
        Dim Income As String = ""
        Dim Addition As String = ""
        If cboCurrentBooster.SelectedIndex = 0 Then
            Base = txtIncome.Text
            Income = Base
            Addition = "0"
        Else
            Income = txtIncome.Text
            Dim Percentage As Integer = Strings.Replace(cboCurrentBooster.SelectedItem, "%", "")
            Percentage = 100 + Percentage
            Addition = Math.Round(Income - (Income * 100) / Percentage)
            Base = Math.Round((Income * 100) / Percentage)
        End If
        cmd.CommandText = "INSERT INTO PersonalFamePointsBattlesLog (ID, BattleDate, Base, Income, Addition, Level) VALUES(@ID, @BattleDate, @Base, @Income, @Addition, @Level)"
        cmd.Parameters.AddWithValue("@ID", txtAccountID.Text)
        cmd.Parameters.AddWithValue("@BattleDate", txtDate.Text)
        cmd.Parameters.AddWithValue("@Base", Base)
        cmd.Parameters.AddWithValue("@Income", Income)
        cmd.Parameters.AddWithValue("@Addition", Addition)
        cmd.Parameters.AddWithValue("@Level", cboCurrentBooster.SelectedIndex)

        cmd.ExecuteNonQuery()
        MsgBox("Income: " & Income & vbNewLine & " base fame points from the battle: " & Base & vbNewLine & "Rewarded from the Bonus: " & Addition)
        updateStatistics()
    End Sub
End Class