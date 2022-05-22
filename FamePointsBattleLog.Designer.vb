<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FamePointsBattleLog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.cboCurrentBooster = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.lblTotalBaseFamePoints = New System.Windows.Forms.Label()
        Me.lblTotalFamePointsWithBonus = New System.Windows.Forms.Label()
        Me.lblTotalFamePointsFarmedByBonuses = New System.Windows.Forms.Label()
        Me.lblBonusImpact = New System.Windows.Forms.Label()
        Me.lblBattlesPlayed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date:"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(70, 23)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 147)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Current Booster %:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Income:"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(76, 92)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(94, 20)
        Me.txtIncome.TabIndex = 1
        '
        'cboCurrentBooster
        '
        Me.cboCurrentBooster.FormattingEnabled = True
        Me.cboCurrentBooster.Items.AddRange(New Object() {"0%", "5%", "10%", "20%", "40%", "60%", "90%", "120%", "160%", "200%", "240%"})
        Me.cboCurrentBooster.Location = New System.Drawing.Point(112, 57)
        Me.cboCurrentBooster.Name = "cboCurrentBooster"
        Me.cboCurrentBooster.Size = New System.Drawing.Size(58, 21)
        Me.cboCurrentBooster.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "AccountID:"
        '
        'txtAccountID
        '
        Me.txtAccountID.Location = New System.Drawing.Point(76, 118)
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.Size = New System.Drawing.Size(94, 20)
        Me.txtAccountID.TabIndex = 1
        Me.txtAccountID.Text = "542250529"
        '
        'lblTotalBaseFamePoints
        '
        Me.lblTotalBaseFamePoints.AutoSize = True
        Me.lblTotalBaseFamePoints.Location = New System.Drawing.Point(200, 57)
        Me.lblTotalBaseFamePoints.Name = "lblTotalBaseFamePoints"
        Me.lblTotalBaseFamePoints.Size = New System.Drawing.Size(122, 13)
        Me.lblTotalBaseFamePoints.TabIndex = 4
        Me.lblTotalBaseFamePoints.Text = "Total Base Fame Points:"
        '
        'lblTotalFamePointsWithBonus
        '
        Me.lblTotalFamePointsWithBonus.AutoSize = True
        Me.lblTotalFamePointsWithBonus.Location = New System.Drawing.Point(200, 79)
        Me.lblTotalFamePointsWithBonus.Name = "lblTotalFamePointsWithBonus"
        Me.lblTotalFamePointsWithBonus.Size = New System.Drawing.Size(153, 13)
        Me.lblTotalFamePointsWithBonus.TabIndex = 4
        Me.lblTotalFamePointsWithBonus.Text = "Total Fame Points With Bonus:"
        '
        'lblTotalFamePointsFarmedByBonuses
        '
        Me.lblTotalFamePointsFarmedByBonuses.AutoSize = True
        Me.lblTotalFamePointsFarmedByBonuses.Location = New System.Drawing.Point(200, 99)
        Me.lblTotalFamePointsFarmedByBonuses.Name = "lblTotalFamePointsFarmedByBonuses"
        Me.lblTotalFamePointsFarmedByBonuses.Size = New System.Drawing.Size(192, 13)
        Me.lblTotalFamePointsFarmedByBonuses.TabIndex = 4
        Me.lblTotalFamePointsFarmedByBonuses.Text = "Total Fame Points Farmed By Bonuses:"
        '
        'lblBonusImpact
        '
        Me.lblBonusImpact.AutoSize = True
        Me.lblBonusImpact.Location = New System.Drawing.Point(200, 125)
        Me.lblBonusImpact.Name = "lblBonusImpact"
        Me.lblBonusImpact.Size = New System.Drawing.Size(75, 13)
        Me.lblBonusImpact.TabIndex = 4
        Me.lblBonusImpact.Text = "Bonus Impact:"
        Me.lblBonusImpact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBattlesPlayed
        '
        Me.lblBattlesPlayed.AutoSize = True
        Me.lblBattlesPlayed.Location = New System.Drawing.Point(200, 26)
        Me.lblBattlesPlayed.Name = "lblBattlesPlayed"
        Me.lblBattlesPlayed.Size = New System.Drawing.Size(77, 13)
        Me.lblBattlesPlayed.TabIndex = 4
        Me.lblBattlesPlayed.Text = "Battles Played:"
        '
        'FamePointsBattleLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 182)
        Me.Controls.Add(Me.lblBattlesPlayed)
        Me.Controls.Add(Me.lblBonusImpact)
        Me.Controls.Add(Me.lblTotalFamePointsFarmedByBonuses)
        Me.Controls.Add(Me.lblTotalFamePointsWithBonus)
        Me.Controls.Add(Me.lblTotalBaseFamePoints)
        Me.Controls.Add(Me.cboCurrentBooster)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAccountID)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FamePointsBattleLog"
        Me.Text = "FamePointsBattleLog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents cboCurrentBooster As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents lblTotalBaseFamePoints As Label
    Friend WithEvents lblTotalFamePointsWithBonus As Label
    Friend WithEvents lblTotalFamePointsFarmedByBonuses As Label
    Friend WithEvents lblBonusImpact As Label
    Friend WithEvents lblBattlesPlayed As Label
End Class
