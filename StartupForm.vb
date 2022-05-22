Imports System.IO

Public Class StartupForm
    Private Sub StartupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDebug.AppendText("Initializing..." & vbNewLine)
        CreateDirectories(Me, e)
        UpdateWN8ExpectedValues()
        txtDebug.AppendText("Done.")
    End Sub
    Private Sub CreateDirectories(sender As Object, e As EventArgs)
        Try
            txtDebug.AppendText(BaseDir & "data" & vbNewLine)
            If Directory.Exists(BaseDir & "data") = False Then Directory.CreateDirectory(BaseDir & "data")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            txtDebug.AppendText(BaseDir & "data\tanks\contour" & vbNewLine)
            If Directory.Exists(BaseDir & "data\tanks\contour") = False Then Directory.CreateDirectory(BaseDir & "data\tanks\contour")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\tanks\contour" & vbNewLine)
            If Directory.Exists(BaseDir & "data\tanks\contour") = False Then Directory.CreateDirectory(BaseDir & "data\tanks\contour")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\tanks\image" & vbNewLine)
            If Directory.Exists(BaseDir & "data\tanks\image") = False Then Directory.CreateDirectory(BaseDir & "data\tanks\image")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\tanks\imagesmall" & vbNewLine)
            If Directory.Exists(BaseDir & "data\tanks\imagesmall") = False Then Directory.CreateDirectory(BaseDir & "data\tanks\imagesmall")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\achievments\image\" & vbNewLine)
            If Directory.Exists(BaseDir & "data\achievments\image\") = False Then Directory.CreateDirectory(BaseDir & "data\achievments\image\")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\achievments\image_big\" & vbNewLine)
            If Directory.Exists(BaseDir & "data\achievments\image_big\") = False Then Directory.CreateDirectory(BaseDir & "data\achievments\image_big\")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\badges\medium_icon" & vbNewLine)
            If Directory.Exists(BaseDir & "data\badges\medium_icon") = False Then Directory.CreateDirectory(BaseDir & "data\badges\medium_icon")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\badges\small_icon" & vbNewLine)
            If Directory.Exists(BaseDir & "data\badges\small_icon") = False Then Directory.CreateDirectory(BaseDir & "data\badges\small_icon")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\badges\big_icon" & vbNewLine)
            If Directory.Exists(BaseDir & "data\badges\big_icon") = False Then Directory.CreateDirectory(BaseDir & "data\badges\big_icon")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\provisions" & vbNewLine)
            If Directory.Exists(BaseDir & "data\provisions") = False Then Directory.CreateDirectory(BaseDir & "data\provisions")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\modules" & vbNewLine)
            If Directory.Exists(BaseDir & "data\modules") = False Then Directory.CreateDirectory(BaseDir & "data\modules")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\skills\small_icon" & vbNewLine)
            If Directory.Exists(BaseDir & "data\skills\small_icon") = False Then Directory.CreateDirectory(BaseDir & "data\skills\small_icon")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            txtDebug.AppendText(BaseDir & "data\skills\big_icon" & vbNewLine)
            If Directory.Exists(BaseDir & "data\skills\big_icon") = False Then Directory.CreateDirectory(BaseDir & "data\skills\big_icon")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub UpdateWN8ExpectedValues()
        txtDebug.AppendText("Updating WN8 Expected Values..." & vbNewLine)
        'If File.Exists(BaseDir & "data\wn8.xml") = True Then Exit Sub
        'Dim cw As New WebClient
        'Dim xmldoc As New XmlDocument
        'cw.DownloadFile(ExpectedValuesLink, BaseDir & "data\wn8.json")
        'Dim sr As New StreamReader(BaseDir & "data\wn8.json")
        'Dim sw As New StreamWriter(BaseDir & "data\wn8.xml")
        'sw.Write(Json2XML(sr.ReadToEnd).OuterXml)
        'sr.Close()
        'sw.Close()
        'xmldoc.Load(BaseDir & "data\wn8.xml")

        'For Each Child As XmlNode In xmldoc.ChildNodes(0)
        '    If Child.ChildNodes(0).InnerText.Length > 20 Then Exit For
        '    TankID = Child.ChildNodes(0).InnerText
        '    expFrag = Child.ChildNodes(2).InnerText
        '    expDamage = Child.ChildNodes(4).InnerText
        '    expSpot = Child.ChildNodes(3).InnerText
        '    expDef = Child.ChildNodes(1).InnerText
        '    expWinRate = Child.ChildNodes(5).InnerText
        '    cmd.CommandText = "SELECT EXISTS(SELECT 1 FROM Tankopedia WHERE id=@id)"
        '    cmd.Parameters.AddWithValue("@id", TankID)
        '    Reader = cmd.ExecuteReader
        '    Dim isExisted As Integer
        '    While Reader.Read
        '        isExisted = Reader.GetValue(0)
        '    End While

        '    Reader.Close()
        '    If isExisted = 0 Then
        '        cmd.CommandText = "INSERT INTO Tankopedia (id,expFrag,expDamage,expSpot,expDef,expWinRate) values (@id,@expFrag,@expDamage,@expSpot,@expDef,@expWinRate)"
        '        cmd.Parameters.AddWithValue("@id", TankID)
        '        cmd.Parameters.AddWithValue("@expFrag", expFrag)
        '        cmd.Parameters.AddWithValue("@expDamage", expDamage)
        '        cmd.Parameters.AddWithValue("@expSpot", expSpot)
        '        cmd.Parameters.AddWithValue("@expDef", expDef)
        '        cmd.Parameters.AddWithValue("@expWinRate", expWinRate)
        '        cmd.ExecuteNonQuery()
        '    End If
        'Next
    End Sub
End Class