Imports System.IO
Imports System.Net
Imports System.Xml

Public Class Clan
    Dim clan_id As String
    Dim clan_name As String
    Dim clan_tag As String
    Dim APILanguage As String = "eu"
    Dim application_id As String = "demo"
    Dim _Realm As String = "eu"
    Public status As String
    Public count As String
    'Global Map

    Public elo_10 As String
    Public elo_8 As String
    Public elo_6 As String
    Public updated_at As String
    Public battles_10_level As String
    Public wins As String
    Public losses As String
    Public battles As String
    Public battles_8_level As String
    Public wins_10_level As String
    Public captures As String
    Public provinces_count As String
    Public wins_6_level As String
    Public wins_8_level As String
    Public battles_6_level As String

    'get clan provinces
    Public landing_type As String
    Public province_id As String
    Public arena_id As String
    Public prime_time As String
    Public revenue_level As String
    Public daily_revenue As String
    Public pillage_end_at As String
    Public turns_owned As String
    Public max_vehicle_level As String
    Public arena_name As String
    Public province_name As String

    Public Property ID() As String
        Get
            Return clan_id
        End Get
        Set(ByVal value As String)
            clan_id = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return clan_name
        End Get
        Set(value As String)
            clan_name = value
        End Set
    End Property

    Public ReadOnly Property ClanTag() As String
        Get
            Return clan_tag
        End Get
    End Property
    Public Property Realm() As String
        Get
            Return _Realm
        End Get
        Set(value As String)
            _Realm = value
        End Set
    End Property
    Public Property applicationID() As String
        Get
            Return application_id
        End Get
        Set(value As String)
            application_id = value
        End Set
    End Property
    Sub getGMClanDetails(ByVal application_id As String, ByVal clan_id As String, Optional ByVal Realm As String = "eu")
        'api url {0}
        Dim sURL As String = String.Format("https://api.worldoftanks.{0}/wot/globalmap/claninfo/?application_id={1}&clan_id={2}", Realm, application_id, clan_id)
        Dim respo As String = New StreamReader(WebRequest.Create(sURL).GetResponse.GetResponseStream()).ReadToEnd
        Dim resXML As XmlDocument = Json2XML(respo)

    End Sub
    Sub GetClanProvinces(ByVal application_id As String, Optional ByVal Language As String = "en", Optional ByVal Realm As String = "eu")
        'api url {0}
        Dim sURL As String = String.Format("https://api.worldoftanks.{0}/wot/globalmap/clanprovinces/?application_id={1}&clan_id={2}&language={3}", Realm, application_id, clan_id, Language)
        Dim respo As String = New StreamReader(WebRequest.Create(sURL).GetResponse.GetResponseStream()).ReadToEnd
        Dim resXML As XmlDocument = Json2XML(respo)

    End Sub
End Class


