Imports System.Data.SQLite
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json

Module Functions
    Public BaseDir As String = My.Application.Info.DirectoryPath & "\"
    Public conn As New SQLiteConnection("Data Source=" & BaseDir & "data\db.db;Version=3;UseUTF16Encoding=True;")
    Public cmd As New SQLiteCommand(conn)
    Public Reader As SQLiteDataReader
    Public APIRealm As String = "eu"
    Public APILang As String = "en"
    Public EventID As String = "renaissance"
    Public FrontID As String = "renaissance_bg"
    Public APIID As String = "0736c8bb8838d6b17b7e7f29b8a319ee"
    'Public TankopediaLink As String = "https://api.worldoftanks.ru/wot/encyclopedia/vehicles/?application_id=" & application_id & "&language=" & Lang
    'Public ProvisionsLink As String = "https://api.worldoftanks.eu/wot/encyclopedia/provisions/?application_id=" & application_id & "&language=" & Lang
    'Public AchievementsLink As String = "https://api.worldoftanks.eu/wot/encyclopedia/achievements/?application_id=" & application_id & "&language=" & Lang
    'Public ExpectedValuesLink As String = "https://static.modxvm.com/wn8-data-exp/json/wn8exp.json"
    'Public BadgesLink As String = "https://api.worldoftanks.eu/wot/encyclopedia/badges/?application_id=" & application_id & "&language=" & Lang
    'Public EquipmentsLink As String = "https://api.worldoftanks.eu/wot/encyclopedia/provisions/?application_id=" & application_id & "&language=" & Lang
    'Public MapsLink As String = "https://api.worldoftanks.eu/wot/encyclopedia/arenas/?application_id=" & application_id & "&language=" & Lang
    'Public PersonalMissionsLink As String = "https://api.worldoftanks.eu/wot/encyclopedia/personalmissions/?application_id=" & application_id & "&language=" & Lang
    'Public ModulesLink As String = "https://api.worldoftanks.eu/wot/encyclopedia/modules/?application_id=" & application_id & "&language=" & Lang
    'Public SkillsLink As String = "https://api.worldoftanks.eu/wot/encyclopedia/crewskills/?application_id=" & application_id & "&language=" & Lang
    'Public CrewLink As String = "https://api.worldoftanks.eu/wot/encyclopedia/crewroles/?application_id=" & application_id & "&language=" & Lang
    'Public PlayerPersonalDataLink As String = 
    'Public PlayersVehicles As String = "https://api.worldoftanks.eu/wot/account/tanks/?application_id=" & application_id & "&account_id=" & Account_id & "&language=" & Lang
    'Public ServerStatusLink As String = "https://api.worldoftanks.eu/wgn/servers/info/?application_id=" & application_id & "&language=" & Lang
    Dim _nickname As String = Nothing
    Public Nickname As String,
    TankID As String, TankName As String, TankClass As String, TankTier As String,
     TankNation As String, TankPremium As String, TankImage As String,
     TankImageSmall As String, TankContour As String, expDamage As String,
     expWinRate As String, expDef As String, expSpot As String, expFrag,
     TankDescription As String, TankPriceCredits As String, TankPriceGold As String,
     TankPriceXP As String, TankCrew As String, TankRadios As String, TankSuspensions As String,
     TankShortName As String, TankTag As String, TankProvisions As String, TankEngines As String,
     TankGuns As String
    Public Function DownloadFile(ByVal Link As String, ByRef FileName As String) As Boolean
        DownloadFile = False
        'MsgBox(Link & vbNewLine & FileName)
        Dim wc As New WebClient
        Try
            If File.Exists(FileName) = False Then
                wc.DownloadFile(Link, FileName)
            End If
            DownloadFile = True
        Catch ex As Exception
            ' MsgBox(ex.Message)
            Debug.WriteLine(ex.Message)
        End Try
        Return DownloadFile
    End Function


    Public Function Json2XML(ByVal json As String) As XmlDocument
        Return JsonConvert.DeserializeXmlNode(json, "Root")
    End Function


    Public Function UrlExists(ByVal url As String) As Boolean

        Dim exists As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(url)
        Dim response As System.Net.HttpWebResponse

        Try
            req = System.Net.WebRequest.Create(url)
            response = DirectCast(req.GetResponse(), System.Net.HttpWebResponse)
            exists = True
        Catch ex As Exception
        End Try

        Return exists
    End Function
    Public Function CalculateWN8(ByVal avgDmg As String, ByVal expDmg As String, ByVal avgSpot As String, expSpot As String, avgFrag As String,
                                avgDef As String, avgWinRate As String) As String
        'rDAMAGE = avgDmg / expDmg
        'rSPOT = avgSpot / expSpot
        'rFRAG = avgFrag / expFrag
        'rDEF = avgDef / expDef
        'rWIN = avgWinRate / expWinRate
        'rWINc = max(0, (rWIN - 0.71) / (1 - 0.71))
        'rDAMAGEc = max(0, (rDAMAGE - 0.22) / (1 - 0.22))
        'rFRAGc = max(0, min(rDAMAGEc + 0.2, (rFRAG - 0.12) / (1 - 0.12)))
        'rSPOTc = max(0, min(rDAMAGEc + 0.1, (rSPOT - 0.38) / (1 - 0.38)))
        'rDEFc = max(0, min(rDAMAGEc + 0.1, (rDEF - 0.1) / (1 - 0.1)))
        'WN8 = 980 * rDAMAGEc + 210 * rDAMAGEc * rFRAGc + 155 * rFRAGc * rSPOTc + 75 * rDEFc * rFRAGc + 145 * MIN(1.8, rWINc)
        Return Nothing
    End Function
    Public Function CalculatePlayerWN8(ByVal ID As String) As String
        Return Nothing
    End Function
    Public Function CalculatedVehicleWN8(ByVal ID As String) As String
        Return Nothing
    End Function
    Public Function WinrateCalculator(ByVal battles As String, ByVal wins As String) As String
        WinrateCalculator = CDbl(wins) / CDbl(battles)
        WinrateCalculator = 100 * CDbl(WinrateCalculator)
        WinrateCalculator = Strings.Left(WinrateCalculator, 5) & "%"
        Return WinrateCalculator
    End Function
    Public Function DownloadAPI(ByVal Link As String, DestinationFile As String) As Boolean
        DownloadAPI = False
        Debug.WriteLine(Link)
        Try
            If File.Exists("data\" & DestinationFile & ".xml") Then
                DownloadAPI = True
                Return True
                Exit Try
            End If
            If File.Exists("data\" & DestinationFile & ".json") = False Then My.Computer.Network.DownloadFile(Link, "data\" & DestinationFile & ".json")
            Dim sr As New StreamReader("data\" & DestinationFile & ".json")
            Dim sw As New StreamWriter("data\" & DestinationFile & ".xml")

            sw.Write(Json2XML(sr.ReadToEnd).InnerXml)
            sr.Close()
            sw.Close()
            DownloadAPI = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return DownloadAPI
    End Function
    Public Sub savset(ByRef conf As String, newValue As String)
        cmd.CommandText = "update conf set setval=@newValue where setname=@conf"
        cmd.Parameters.AddWithValue("@conf", conf)
        cmd.Parameters.AddWithValue("@newValue", newValue)
        cmd.ExecuteNonQuery()
    End Sub

    Public Function DownloadAPI(ByVal Link As String) As XmlDocument
        Try
            Dim str As String
            Dim client As New Net.WebClient
            client.Encoding = Encoding.UTF8
            str = client.DownloadString(Link)
            DownloadAPI = Json2XML(str)
        Catch ex As Exception
            DownloadAPI = Nothing
            MsgBox(ex.Message)
        End Try
        Return DownloadAPI
    End Function
End Module
