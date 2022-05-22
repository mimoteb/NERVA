Imports System.IO
Imports System.Net
Imports System.Xml

Public Class UpdateForm


    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()


    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        'configurations !! remove files
        cmd.CommandText = "Delete From tankopedia;delete from achievement;delete from badges;delete from equipments;delete from maps;delete from missions;delete from modules;delete from profile;delete from provisions;delete from skills;"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub TankopediaButton_Click(sender As Object, e As EventArgs) Handles TankopediaButton.Click

    End Sub

    Private Sub ExpValuesButton_Click(sender As Object, e As EventArgs) Handles ExpValuesButton.Click

    End Sub

    Private Sub provisionsButton_Click(sender As Object, e As EventArgs) Handles provisionsButton.Click

    End Sub

    Private Sub ImagesButton_Click(sender As Object, e As EventArgs) Handles ImagesButton.Click

    End Sub

    Private Sub AchievementsButton_Click(sender As Object, e As EventArgs) Handles AchievementsButton.Click

    End Sub

    Private Sub BadgesButton_Click(sender As Object, e As EventArgs) Handles BadgesButton.Click

    End Sub

    Private Sub EquipButton_Click(sender As Object, e As EventArgs) Handles EquipButton.Click

    End Sub

    Private Sub MapsButton_Click(sender As Object, e As EventArgs) Handles MapsButton.Click

    End Sub

    Private Sub MissionsButton_Click(sender As Object, e As EventArgs) Handles MissionsButton.Click

    End Sub


    Private Sub UpdateNow_Click(sender As Object, e As EventArgs) Handles UpdateNow.Click

    End Sub

    Private Sub ModulesButton_Click(sender As Object, e As EventArgs) Handles ModulesButton.Click

    End Sub

    Private Sub SkillsButton_Click(sender As Object, e As EventArgs) Handles SkillsButton.Click

    End Sub

    Private Sub CrewButton_Click(sender As Object, e As EventArgs) Handles CrewButton.Click

    End Sub

    Private Sub ppdButton_Click(sender As Object, e As EventArgs) Handles ppdButton.Click

    End Sub

    Private Sub myVehiclesButton_Click(sender As Object, e As EventArgs) Handles myVehiclesButton.Click

    End Sub

    Private Sub serversButton_Click(sender As Object, e As EventArgs) Handles serversButton.Click
        'DownloadAPI(ServerStatusLink, "Serverstatus")
        'Dim xml As New XmlDocument
        'xml.Load("data\serverstatus.xml")
        'Dim eu1 As Integer = xml.ChildNodes(0).ChildNodes(1).ChildNodes(2).ChildNodes(0).InnerText
        'Dim eu2 As Integer = xml.ChildNodes(0).ChildNodes(1).ChildNodes(1).ChildNodes(0).InnerText
        'Dim all As String = eu1 + eu2
        'MsgBox(eu1 & vbNewLine & eu2 & vbNewLine & all)
    End Sub
End Class