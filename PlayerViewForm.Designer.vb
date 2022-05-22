<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerViewForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.output = New System.Windows.Forms.TextBox()
        Me.lblPlayerClanMoto = New System.Windows.Forms.Label()
        Me.lblPlayerClan = New System.Windows.Forms.Label()
        Me.lblDPG = New System.Windows.Forms.Label()
        Me.lblHitRatio = New System.Windows.Forms.Label()
        Me.lblPlayerClanName = New System.Windows.Forms.Label()
        Me.lblKillRecord = New System.Windows.Forms.Label()
        Me.lblWN8 = New System.Windows.Forms.Label()
        Me.lblWinRate = New System.Windows.Forms.Label()
        Me.lblBattles = New System.Windows.Forms.Label()
        Me.lblXPRecord = New System.Windows.Forms.Label()
        Me.lblAverageXP = New System.Windows.Forms.Label()
        Me.lblPersonalRating = New System.Windows.Forms.Label()
        Me.lblPlayerID = New System.Windows.Forms.Label()
        Me.lblPlayerNick = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1377, 620)
        Me.TabControl1.TabIndex = 38
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.output)
        Me.TabPage1.Controls.Add(Me.lblPlayerClanMoto)
        Me.TabPage1.Controls.Add(Me.lblPlayerClan)
        Me.TabPage1.Controls.Add(Me.lblDPG)
        Me.TabPage1.Controls.Add(Me.lblHitRatio)
        Me.TabPage1.Controls.Add(Me.lblPlayerClanName)
        Me.TabPage1.Controls.Add(Me.lblKillRecord)
        Me.TabPage1.Controls.Add(Me.lblWN8)
        Me.TabPage1.Controls.Add(Me.lblWinRate)
        Me.TabPage1.Controls.Add(Me.lblBattles)
        Me.TabPage1.Controls.Add(Me.lblXPRecord)
        Me.TabPage1.Controls.Add(Me.lblAverageXP)
        Me.TabPage1.Controls.Add(Me.lblPersonalRating)
        Me.TabPage1.Controls.Add(Me.lblPlayerID)
        Me.TabPage1.Controls.Add(Me.lblPlayerNick)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1369, 594)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Summary"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'output
        '
        Me.output.Location = New System.Drawing.Point(334, 117)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(100, 20)
        Me.output.TabIndex = 72
        '
        'lblPlayerClanMoto
        '
        Me.lblPlayerClanMoto.AutoSize = True
        Me.lblPlayerClanMoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerClanMoto.Location = New System.Drawing.Point(1268, 111)
        Me.lblPlayerClanMoto.Name = "lblPlayerClanMoto"
        Me.lblPlayerClanMoto.Size = New System.Drawing.Size(93, 25)
        Me.lblPlayerClanMoto.TabIndex = 71
        Me.lblPlayerClanMoto.Text = "PlayerID"
        '
        'lblPlayerClan
        '
        Me.lblPlayerClan.AutoSize = True
        Me.lblPlayerClan.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerClan.Location = New System.Drawing.Point(849, 3)
        Me.lblPlayerClan.Name = "lblPlayerClan"
        Me.lblPlayerClan.Size = New System.Drawing.Size(512, 108)
        Me.lblPlayerClan.TabIndex = 70
        Me.lblPlayerClan.Text = "PlayerClan"
        '
        'lblDPG
        '
        Me.lblDPG.AutoSize = True
        Me.lblDPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPG.Location = New System.Drawing.Point(329, 162)
        Me.lblDPG.Name = "lblDPG"
        Me.lblDPG.Size = New System.Drawing.Size(178, 25)
        Me.lblDPG.TabIndex = 67
        Me.lblDPG.Text = "Average Damage"
        '
        'lblHitRatio
        '
        Me.lblHitRatio.AutoSize = True
        Me.lblHitRatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHitRatio.Location = New System.Drawing.Point(9, 365)
        Me.lblHitRatio.Name = "lblHitRatio"
        Me.lblHitRatio.Size = New System.Drawing.Size(88, 25)
        Me.lblHitRatio.TabIndex = 66
        Me.lblHitRatio.Text = "HitRatio"
        '
        'lblPlayerClanName
        '
        Me.lblPlayerClanName.AutoSize = True
        Me.lblPlayerClanName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerClanName.Location = New System.Drawing.Point(9, 403)
        Me.lblPlayerClanName.Name = "lblPlayerClanName"
        Me.lblPlayerClanName.Size = New System.Drawing.Size(56, 25)
        Me.lblPlayerClanName.TabIndex = 63
        Me.lblPlayerClanName.Text = "Clan"
        '
        'lblKillRecord
        '
        Me.lblKillRecord.AutoSize = True
        Me.lblKillRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKillRecord.Location = New System.Drawing.Point(9, 162)
        Me.lblKillRecord.Name = "lblKillRecord"
        Me.lblKillRecord.Size = New System.Drawing.Size(116, 25)
        Me.lblKillRecord.TabIndex = 60
        Me.lblKillRecord.Text = "Kill Record"
        '
        'lblWN8
        '
        Me.lblWN8.AutoSize = True
        Me.lblWN8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWN8.Location = New System.Drawing.Point(9, 449)
        Me.lblWN8.Name = "lblWN8"
        Me.lblWN8.Size = New System.Drawing.Size(56, 25)
        Me.lblWN8.TabIndex = 59
        Me.lblWN8.Text = "Wn8"
        '
        'lblWinRate
        '
        Me.lblWinRate.AutoSize = True
        Me.lblWinRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinRate.Location = New System.Drawing.Point(9, 488)
        Me.lblWinRate.Name = "lblWinRate"
        Me.lblWinRate.Size = New System.Drawing.Size(86, 25)
        Me.lblWinRate.TabIndex = 58
        Me.lblWinRate.Text = "Winrate"
        '
        'lblBattles
        '
        Me.lblBattles.AutoSize = True
        Me.lblBattles.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBattles.Location = New System.Drawing.Point(9, 542)
        Me.lblBattles.Name = "lblBattles"
        Me.lblBattles.Size = New System.Drawing.Size(78, 25)
        Me.lblBattles.TabIndex = 57
        Me.lblBattles.Text = "Battles"
        '
        'lblXPRecord
        '
        Me.lblXPRecord.AutoSize = True
        Me.lblXPRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXPRecord.Location = New System.Drawing.Point(9, 321)
        Me.lblXPRecord.Name = "lblXPRecord"
        Me.lblXPRecord.Size = New System.Drawing.Size(115, 25)
        Me.lblXPRecord.TabIndex = 56
        Me.lblXPRecord.Text = "XP Record"
        '
        'lblAverageXP
        '
        Me.lblAverageXP.AutoSize = True
        Me.lblAverageXP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageXP.Location = New System.Drawing.Point(9, 275)
        Me.lblAverageXP.Name = "lblAverageXP"
        Me.lblAverageXP.Size = New System.Drawing.Size(126, 25)
        Me.lblAverageXP.TabIndex = 55
        Me.lblAverageXP.Text = "Average XP"
        '
        'lblPersonalRating
        '
        Me.lblPersonalRating.AutoSize = True
        Me.lblPersonalRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalRating.Location = New System.Drawing.Point(583, 41)
        Me.lblPersonalRating.Name = "lblPersonalRating"
        Me.lblPersonalRating.Size = New System.Drawing.Size(165, 25)
        Me.lblPersonalRating.TabIndex = 40
        Me.lblPersonalRating.Text = "Personal Rating"
        '
        'lblPlayerID
        '
        Me.lblPlayerID.AutoSize = True
        Me.lblPlayerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerID.Location = New System.Drawing.Point(9, 111)
        Me.lblPlayerID.Name = "lblPlayerID"
        Me.lblPlayerID.Size = New System.Drawing.Size(93, 25)
        Me.lblPlayerID.TabIndex = 39
        Me.lblPlayerID.Text = "PlayerID"
        '
        'lblPlayerNick
        '
        Me.lblPlayerNick.AutoSize = True
        Me.lblPlayerNick.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerNick.Location = New System.Drawing.Point(-4, 3)
        Me.lblPlayerNick.Name = "lblPlayerNick"
        Me.lblPlayerNick.Size = New System.Drawing.Size(502, 108)
        Me.lblPlayerNick.TabIndex = 38
        Me.lblPlayerNick.Text = "PlayerNick"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1369, 594)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advances"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 651)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlayerViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1389, 693)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "PlayerViewForm"
        Me.Text = "PlayerViewForm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblDPG As Label
    Friend WithEvents lblHitRatio As Label
    Friend WithEvents lblPlayerClanName As Label
    Friend WithEvents lblKillRecord As Label
    Friend WithEvents lblWN8 As Label
    Friend WithEvents lblWinRate As Label
    Friend WithEvents lblBattles As Label
    Friend WithEvents lblXPRecord As Label
    Friend WithEvents lblAverageXP As Label
    Friend WithEvents lblPersonalRating As Label
    Friend WithEvents lblPlayerID As Label
    Friend WithEvents lblPlayerNick As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblPlayerClanMoto As Label
    Friend WithEvents lblPlayerClan As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents output As TextBox
End Class
