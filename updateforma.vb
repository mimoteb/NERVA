Imports System.IO
Public Class updateforma
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartButton.Visible = False


        Dim DownloadList As New DataGridView
        DownloadList.Columns.Add("Link", "Link")
        DownloadList.Columns.Add("local", "local")
        'Tankopedia
        cmd.CommandText = "Select id,contour,image,imagesmall from tankopedia"
        Reader = cmd.ExecuteReader
        While Reader.Read
            DownloadList.Rows.Add(Reader.GetString(1), "data\tanks\contour\" & Reader.GetValue(0) & ".png")
            DownloadList.Rows.Add(Reader.GetString(2), "data\tanks\image\" & Reader.GetValue(0) & ".png")
            DownloadList.Rows.Add(Reader.GetString(3), "data\tanks\imagesmall\" & Reader.GetValue(0) & ".png")
        End While
        Reader.Close()
        'Achievments
        cmd.CommandText = "select name_id,image,image_big from achievements"
        Reader = cmd.ExecuteReader
        While Reader.Read
            If Reader.GetString(1).Length > 20 Then
                DownloadList.Rows.Add(Reader.GetString(1), BaseDir & "data\achievments\image\" & Reader.GetString(0) & ".png")
            End If
            If Reader.GetString(2).Length > 20 Then
                DownloadList.Rows.Add(Reader.GetString(2), BaseDir & "data\achievments\image_big\" & Reader.GetString(0) & ".png")
            End If
        End While
        Reader.Close()
        'Badges
        cmd.CommandText = "select badge_id,medium_icon,small_icon,big_icon from badges"
        Reader = cmd.ExecuteReader
        While Reader.Read
            DownloadList.Rows.Add(Reader.GetString(1), BaseDir & "data\badges\medium_icon\" & Reader.GetValue(0) & ".png")
            DownloadList.Rows.Add(Reader.GetString(2), BaseDir & "data\badges\small_icon\" & Reader.GetValue(0) & ".png")
            DownloadList.Rows.Add(Reader.GetString(3), BaseDir & "data\badges\big_icon\" & Reader.GetValue(0) & ".png")

        End While
        Reader.Close()
        'provisions
        cmd.CommandText = "select provision_id,image from provisions"
        Reader = cmd.ExecuteReader
        While Reader.Read
            DownloadList.Rows.Add(Reader.GetString(1), BaseDir & "data\provisions\" & Reader.GetValue(0) & ".png")
        End While
        Reader.Close()
        'Modules
        cmd.CommandText = "select module_id,image from modules"
        Reader = cmd.ExecuteReader
        While Reader.Read
            DownloadList.Rows.Add(Reader.GetString(1), BaseDir & "data\modules\" & Reader.GetValue(0) & ".png")
        End While
        Reader.Close()
        'skills
        cmd.CommandText = "select skill,small_icon,big_icon from skills"
        Reader = cmd.ExecuteReader
        While Reader.Read
            DownloadList.Rows.Add(Reader.GetString(1), BaseDir & "data\skills\small_icon\" & Reader.GetString(0) & ".png")
            DownloadList.Rows.Add(Reader.GetString(2), BaseDir & "data\skills\big_icon\" & Reader.GetString(0) & ".png")
        End While
        'Download Now
        Dim total As Integer = DownloadList.Rows.Count - 1
        Dim current As Integer = 0
        For Each row As DataGridViewRow In DownloadList.Rows
            DownloadFile(row.Cells(0).Value, row.Cells(1).Value)
            output.AppendText("downloaded: " & row.Cells(0).Value & vbNewLine)
            current += 1
            DownloadedLabel.Text = "Downloaded: " & current
            TotalLabel.Text = "Total Files: " & total
            Progress.Value = 100 * current / total
            RemainedLabel.Text = "Remained: " & CInt(total - current)
            Me.Update()
        Next
        StartButton.Visible = True
        MsgBox("finished")
    End Sub

    Private Sub updateforma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class