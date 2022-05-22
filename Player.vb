Imports System.IO
Imports System.Net
Imports System.Xml

Public Class Player
    Dim player_id As String
    Dim Player_Name As String
    Public clan_id As String

    'Achievements

    Public achievements As String
    Public frags As String
    Public max_series As String


    'Global Map
    Dim award_level As String
    Dim clan_rank As String
    Dim rank_delta As String
    Dim fame_points_to_improve_award As String
    Dim updated_at As String
    Dim battles As String
    Dim rank As String
    Dim fame_points_since_turn As String
    Dim battles_to_award As String
    Dim fame_points As String

    'Account Player Personal Data

    Public client_language As String
    Public last_battle_time As String
    Public created_at As String
    Public global_rating As String

    'Random statistics
    Public Randoms_spotted As String
    Public Randoms_battles_on_stunning_vehicles As String
    Public Randoms_max_xp As String
    Public Randoms_avg_damage_blocked As String
    Public Randoms_direct_hits_received As String
    Public Randoms_explosion_hits As String
    Public Randoms_piercings_received As String
    Public Randoms_piercings As String
    Public Randoms_max_damage_tank_id As String
    Public Randoms_xp As String
    Public Randoms_survived_battles As String
    Public Randoms_dropped_capture_points As String
    Public Randoms_hits_percents As String
    Public Randoms_draws As String
    Public Randoms_max_xp_tank_id As String
    Public Randoms_battles As String
    Public Randoms_damage_received As String
    Public Randoms_avg_damage_assisted As String
    Public Randoms_max_frags_tank_id As String
    Public Randoms_avg_damage_assisted_track As String
    Public Randoms_frags As String
    Public Randoms_stun_number As String
    Public Randoms_avg_damage_assisted_radio As String
    Public Randoms_capture_points As String
    Public Randoms_stun_assisted_damage As String
    Public Randoms_max_damage As String
    Public Randoms_hits As String
    Public Randoms_battle_avg_xp As String
    Public Randoms_wins As String
    Public Randoms_losses As String
    Public Randoms_damage_dealt As String
    Public Randoms_no_damage_direct_hits_received As String
    Public Randoms_max_frags As String
    Public Randoms_shots As String
    Public Randoms_explosion_hits_received As String
    Public Randoms_tanking_factor As String

    'stronghold_defense
    Public adv_spotted As String
    Public adv_battles_on_stunning_vehicles As String
    Public adv_max_xp As String
    Public adv_avg_damage_blocked As String
    Public adv_direct_hits_received As String
    Public adv_explosion_hits As String
    Public adv_piercings_received As String
    Public adv_piercings As String
    Public adv_max_damage_tank_id As String
    Public adv_xp As String
    Public adv_survived_battles As String
    Public adv_dropped_capture_points As String
    Public adv_hits_percents As String
    Public adv_draws As String
    Public adv_max_xp_tank_id As String
    Public adv_battles As String
    Public adv_damage_received As String
    Public adv_avg_damage_assisted As String
    Public adv_max_frags_tank_id As String
    Public adv_avg_damage_assisted_track As String
    Public adv_frags As String
    Public adv_stun_number As String
    Public adv_avg_damage_assisted_radio As String
    Public adv_capture_points As String
    Public adv_stun_assisted_damage As String
    Public adv_max_damage As String
    Public adv_hits As String
    Public adv_battle_avg_xp As String
    Public adv_wins As String
    Public adv_losses As String
    Public adv_damage_dealt As String
    Public adv_no_damage_direct_hits_received As String
    Public adv_max_frags As String
    Public adv_shots As String
    Public adv_explosion_hits_received As String
    Public adv_tanking_factor As String

    Public nickname As String
    Public logout_at As String

    'Player's Vehicles
    Public Vehicle_wins As String
    Public Vehicle_battles As String
    Public Vehicle_mark_of_mastery As String
    Public tank_id As String
    Public XMLData As XmlDocument
    Public ReadOnly Property GM_AwardLevel() As String
        Get
            Return award_level
        End Get
    End Property
    Public ReadOnly Property GM_ClanRank() As String
        Get
            Return clan_rank
        End Get

    End Property
    Public ReadOnly Property GM_RankDelta() As String
        Get
            Return rank_delta
        End Get
    End Property
    Public ReadOnly Property GM_FamePointsToImporve() As String
        Get
            Return fame_points_to_improve_award
        End Get
    End Property
    Public ReadOnly Property GM_updatedAt() As String
        Get
            Return updated_at
        End Get
    End Property
    Public ReadOnly Property GM_battles() As String
        Get
            Return battles
        End Get
    End Property
    Public ReadOnly Property GM_clanid() As String
        Get
            Return clan_id
        End Get
    End Property
    Public ReadOnly Property GM_Rank() As String
        Get
            Return rank
        End Get
    End Property
    Public ReadOnly Property GM_famePointsSinceTurn() As String
        Get
            Return fame_points_since_turn
        End Get
    End Property
    Public ReadOnly Property GM_battles_to_award() As String
        Get
            Return battles_to_award
        End Get
    End Property
    Public ReadOnly Property GM_FamePoints() As String
        Get
            Return fame_points
        End Get
    End Property
    Public Property ID() As String
        Get
            Return player_id
        End Get
        Set(ByVal value As String)
            player_id = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return Player_Name
        End Get
        Set(value As String)
            Player_Name = value
        End Set
    End Property

    Public Function GetPlayerID() As String
        'api url
        Dim sURL As String = String.Format("https://api.worldoftanks.{0}/wot/account/list/?application_id={1}&search={2}&language={3}&limit=1", APIRealm, APIID, Player_Name, APILang)
        Dim respo As String = New StreamReader(WebRequest.Create(sURL).GetResponse.GetResponseStream()).ReadToEnd
        Dim resXML As XmlDocument = Json2XML(respo)
        If resXML.ChildNodes(0).ChildNodes(1).InnerText > 1 Then
            player_id = resXML.ChildNodes(0).ChildNodes(2).ChildNodes(1).InnerText
        Else
            player_id = resXML.ChildNodes(0).ChildNodes(2).ChildNodes(1).InnerText
        End If
        Return player_id
    End Function

    Sub New(ByVal name As String)
        Player_Name = name
        player_id = GetPlayerID()
        'https://api.worldoftanks.eu/wot/account/info/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee
        XMLData = DownloadAPI(String.Format("https://api.worldoftanks.{0}/wot/account/info/?application_id={1}&account_id={2}", APIRealm, APIID, ID))




        client_language = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(0).InnerText
        last_battle_time = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(1).InnerText
        created_at = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(3).InnerText
        updated_at = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(4).InnerText
        'Personal Rating
        global_rating = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(6).InnerText
        clan_id = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(7).InnerText
        logout_at = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(10).InnerText

        'All (Random Battles)
        Randoms_spotted = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(0).InnerText
        Randoms_battles_on_stunning_vehicles = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(1).InnerText
        Randoms_max_xp = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(2).InnerText
        Randoms_avg_damage_blocked = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(3).InnerText
        Randoms_direct_hits_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(4).InnerText
        Randoms_explosion_hits = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(5).InnerText
        Randoms_piercings_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(6).InnerText
        Randoms_piercings = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(7).InnerText
        Randoms_max_damage_tank_id = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(8).InnerText
        Randoms_xp = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(9).InnerText
        Randoms_survived_battles = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(10).InnerText
        Randoms_dropped_capture_points = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(11).InnerText
        Randoms_hits_percents = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(12).InnerText
        Randoms_draws = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(13).InnerText
        Randoms_max_xp_tank_id = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(14).InnerText
        Randoms_battles = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(15).InnerText
        Randoms_damage_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(16).InnerText
        Randoms_avg_damage_assisted = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(17).InnerText
        Randoms_max_frags_tank_id = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(18).InnerText
        Randoms_avg_damage_assisted_track = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(19).InnerText
        Randoms_frags = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(20).InnerText
        Randoms_stun_number = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(21).InnerText
        Randoms_avg_damage_assisted_radio = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(22).InnerText
        Randoms_capture_points = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(23).InnerText
        Randoms_stun_assisted_damage = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(24).InnerText
        Randoms_max_damage = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(25).InnerText
        Randoms_hits = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(26).InnerText
        Randoms_battle_avg_xp = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(27).InnerText
        Randoms_wins = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(28).InnerText
        Randoms_losses = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(29).InnerText
        Randoms_damage_dealt = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(30).InnerText
        Randoms_no_damage_direct_hits_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(31).InnerText
        Randoms_max_frags = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(32).InnerText
        Randoms_shots = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(33).InnerText
        Randoms_explosion_hits_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(34).InnerText
        Randoms_tanking_factor = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(1).ChildNodes(35).InnerText


        'StrongholdDefense : advances
        adv_spotted = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(0).InnerText
        adv_battles_on_stunning_vehicles = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(1).InnerText
        adv_max_xp = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(2).InnerText
        adv_direct_hits_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(3).InnerText
        adv_explosion_hits = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(4).InnerText
        adv_piercings_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(6).InnerText
        adv_piercings = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(6).InnerText
        adv_xp = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(7).InnerText
        adv_survived_battles = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(8).InnerText
        adv_dropped_capture_points = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(9).InnerText
        adv_hits_percents = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(10).InnerText
        adv_draws = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(11).InnerText
        adv_max_xp_tank_id = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(12).InnerText
        adv_battles = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(13).InnerText
        adv_damage_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(14).InnerText
        adv_max_frags_tank_id = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(15).InnerText
        adv_frags = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(16).InnerText
        adv_stun_number = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(17).InnerText
        adv_stun_assisted_damage = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(18).InnerText
        adv_max_damage_tank_id = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(19).InnerText
        adv_max_damage = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(20).InnerText
        adv_hits = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(21).InnerText
        adv_battle_avg_xp = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(22).InnerText
        adv_wins = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(23).InnerText
        adv_losses = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(24).InnerText
        adv_damage_dealt = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(25).InnerText
        adv_no_damage_direct_hits_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(26).InnerText
        adv_max_frags = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(27).InnerText
        adv_shots = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(28).InnerText
        adv_explosion_hits_received = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(29).InnerText
        adv_tanking_factor = XMLData.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(8).ChildNodes(6).ChildNodes(30).InnerText

    End Sub


    Sub getAchievements(ByVal account_id As String, Optional ByVal Realm As String = "eu", Optional ByVal application_id As String = "demo", Optional ByVal Language As String = "en")
        'api url {0}
        Dim sURL As String = String.Format("https://api.worldoftanks.{0}/wot/account/achievements/?application_id={1}&account_id={2}&language={3}", Realm, application_id, account_id, Language)
        Dim respo As String = New StreamReader(WebRequest.Create(sURL).GetResponse.GetResponseStream()).ReadToEnd
        Dim resXML As XmlDocument = Json2XML(respo)

    End Sub
    Sub getplayerpersonaldata(ByVal application_id As String, Optional ByVal Realm As String = "eu", Optional ByVal Language As String = "en")
        'api url {0} "https://api.worldoftanks.eu/wot/account/info/?application_id=" & application_id & "&account_id=" & Account_id & "&language=" & Lang
        Dim sURL As String = String.Format("https://api.worldoftanks.{0}/wot/account/info/?application_id={1}&account_id={2}&language={3}", Realm, application_id, 0, Language)
        Dim respo As String = New StreamReader(WebRequest.Create(sURL).GetResponse.GetResponseStream()).ReadToEnd
        Dim resXML As XmlDocument = Json2XML(respo)

    End Sub
    Sub GetPlayerVehicles(ByVal application_id As String, ByVal account_id As String, Optional ByVal Realm As String = "eu", Optional ByVal Language As String = "en")
        Dim sURL As String = String.Format("https://api.worldoftanks.{0}/wot/account/tanks/?application_id={1}&account_id={2}&language={3}", Realm, application_id, account_id, Language)
        Dim respo As String = New StreamReader(WebRequest.Create(sURL).GetResponse.GetResponseStream()).ReadToEnd

        Dim resXML As XmlDocument = Json2XML(respo)

    End Sub
End Class