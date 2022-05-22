<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClanPortal
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPNickName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPPR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPBTL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPWinrate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPXP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPDMG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPFRAGS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPBATTLESPERDAY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPWn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPFamePoints = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MPID, Me.MPNickName, Me.MPPR, Me.MPBTL, Me.MPWinrate, Me.MPXP, Me.MPDMG, Me.MPFRAGS, Me.MPBATTLESPERDAY, Me.MPDays, Me.MPPosition, Me.MPWn8, Me.MPFamePoints, Me.MPRank})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1449, 296)
        Me.DataGridView1.TabIndex = 0
        '
        'MPID
        '
        Me.MPID.HeaderText = "ID"
        Me.MPID.Name = "MPID"
        Me.MPID.ReadOnly = True
        '
        'MPNickName
        '
        Me.MPNickName.HeaderText = "Nickname"
        Me.MPNickName.Name = "MPNickName"
        Me.MPNickName.ReadOnly = True
        '
        'MPPR
        '
        Me.MPPR.HeaderText = "Personal Rating"
        Me.MPPR.Name = "MPPR"
        Me.MPPR.ReadOnly = True
        '
        'MPBTL
        '
        Me.MPBTL.HeaderText = "Battles"
        Me.MPBTL.Name = "MPBTL"
        Me.MPBTL.ReadOnly = True
        '
        'MPWinrate
        '
        Me.MPWinrate.HeaderText = "Winrate"
        Me.MPWinrate.Name = "MPWinrate"
        Me.MPWinrate.ReadOnly = True
        '
        'MPXP
        '
        Me.MPXP.HeaderText = "Experience"
        Me.MPXP.Name = "MPXP"
        Me.MPXP.ReadOnly = True
        '
        'MPDMG
        '
        Me.MPDMG.HeaderText = "Damage"
        Me.MPDMG.Name = "MPDMG"
        Me.MPDMG.ReadOnly = True
        '
        'MPFRAGS
        '
        Me.MPFRAGS.HeaderText = "Kills"
        Me.MPFRAGS.Name = "MPFRAGS"
        Me.MPFRAGS.ReadOnly = True
        '
        'MPBATTLESPERDAY
        '
        Me.MPBATTLESPERDAY.HeaderText = "Battles Per Day"
        Me.MPBATTLESPERDAY.Name = "MPBATTLESPERDAY"
        Me.MPBATTLESPERDAY.ReadOnly = True
        '
        'MPDays
        '
        Me.MPDays.HeaderText = "Days in clan"
        Me.MPDays.Name = "MPDays"
        Me.MPDays.ReadOnly = True
        '
        'MPPosition
        '
        Me.MPPosition.HeaderText = "Position"
        Me.MPPosition.Name = "MPPosition"
        Me.MPPosition.ReadOnly = True
        '
        'MPWn8
        '
        Me.MPWn8.HeaderText = "WN8"
        Me.MPWn8.Name = "MPWn8"
        Me.MPWn8.ReadOnly = True
        '
        'MPFamePoints
        '
        Me.MPFamePoints.HeaderText = "FamePoints"
        Me.MPFamePoints.Name = "MPFamePoints"
        Me.MPFamePoints.ReadOnly = True
        '
        'MPRank
        '
        Me.MPRank.HeaderText = "Rank"
        Me.MPRank.Name = "MPRank"
        Me.MPRank.ReadOnly = True
        '
        'ClanPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1528, 818)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ClanPortal"
        Me.Text = "ClanPortal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MPID As DataGridViewTextBoxColumn
    Friend WithEvents MPNickName As DataGridViewTextBoxColumn
    Friend WithEvents MPPR As DataGridViewTextBoxColumn
    Friend WithEvents MPBTL As DataGridViewTextBoxColumn
    Friend WithEvents MPWinrate As DataGridViewTextBoxColumn
    Friend WithEvents MPXP As DataGridViewTextBoxColumn
    Friend WithEvents MPDMG As DataGridViewTextBoxColumn
    Friend WithEvents MPFRAGS As DataGridViewTextBoxColumn
    Friend WithEvents MPBATTLESPERDAY As DataGridViewTextBoxColumn
    Friend WithEvents MPDays As DataGridViewTextBoxColumn
    Friend WithEvents MPPosition As DataGridViewTextBoxColumn
    Friend WithEvents MPWn8 As DataGridViewTextBoxColumn
    Friend WithEvents MPFamePoints As DataGridViewTextBoxColumn
    Friend WithEvents MPRank As DataGridViewTextBoxColumn
End Class
