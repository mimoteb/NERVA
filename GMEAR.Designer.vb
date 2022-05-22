<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMEAR
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtLimit = New System.Windows.Forms.TextBox()
        Me.txtPage = New System.Windows.Forms.TextBox()
        Me.dgvEventAccountRating = New System.Windows.Forms.DataGridView()
        Me.clnRank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnAwardLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnAccountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnEventID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnRankDelta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFamePointsToImprove = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnLastUpdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnBattles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnClanID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnURL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnBattlesToAward = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFamePoints = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnFrontID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEventAccountRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(314, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "te"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtLimit
        '
        Me.txtLimit.Location = New System.Drawing.Point(57, 6)
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.Size = New System.Drawing.Size(100, 20)
        Me.txtLimit.TabIndex = 2
        Me.txtLimit.Text = "10"
        '
        'txtPage
        '
        Me.txtPage.Location = New System.Drawing.Point(208, 6)
        Me.txtPage.Name = "txtPage"
        Me.txtPage.Size = New System.Drawing.Size(100, 20)
        Me.txtPage.TabIndex = 2
        Me.txtPage.Text = "1"
        '
        'dgvEventAccountRating
        '
        Me.dgvEventAccountRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEventAccountRating.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnRank, Me.clnAwardLevel, Me.clnAccountID, Me.clnEventID, Me.clnRankDelta, Me.clnFamePointsToImprove, Me.clnLastUpdate, Me.clnBattles, Me.clnClanID, Me.clnURL, Me.clnBattlesToAward, Me.clnFamePoints, Me.clnFrontID})
        Me.dgvEventAccountRating.Location = New System.Drawing.Point(12, 32)
        Me.dgvEventAccountRating.Name = "dgvEventAccountRating"
        Me.dgvEventAccountRating.Size = New System.Drawing.Size(1069, 383)
        Me.dgvEventAccountRating.TabIndex = 3
        '
        'clnRank
        '
        Me.clnRank.HeaderText = "Rank"
        Me.clnRank.Name = "clnRank"
        '
        'clnAwardLevel
        '
        Me.clnAwardLevel.HeaderText = "Award Level"
        Me.clnAwardLevel.Name = "clnAwardLevel"
        '
        'clnAccountID
        '
        Me.clnAccountID.HeaderText = "Account ID"
        Me.clnAccountID.Name = "clnAccountID"
        '
        'clnEventID
        '
        Me.clnEventID.HeaderText = "EventID"
        Me.clnEventID.Name = "clnEventID"
        '
        'clnRankDelta
        '
        Me.clnRankDelta.HeaderText = "RankDelta"
        Me.clnRankDelta.Name = "clnRankDelta"
        '
        'clnFamePointsToImprove
        '
        Me.clnFamePointsToImprove.HeaderText = "Fame Points To Improve"
        Me.clnFamePointsToImprove.Name = "clnFamePointsToImprove"
        '
        'clnLastUpdate
        '
        Me.clnLastUpdate.HeaderText = "Last Update"
        Me.clnLastUpdate.Name = "clnLastUpdate"
        '
        'clnBattles
        '
        Me.clnBattles.HeaderText = "Battles"
        Me.clnBattles.Name = "clnBattles"
        '
        'clnClanID
        '
        Me.clnClanID.HeaderText = "Clan ID"
        Me.clnClanID.Name = "clnClanID"
        '
        'clnURL
        '
        Me.clnURL.HeaderText = "URL"
        Me.clnURL.Name = "clnURL"
        '
        'clnBattlesToAward
        '
        Me.clnBattlesToAward.HeaderText = "Battles To Award"
        Me.clnBattlesToAward.Name = "clnBattlesToAward"
        '
        'clnFamePoints
        '
        Me.clnFamePoints.HeaderText = "Fame Points"
        Me.clnFamePoints.Name = "clnFamePoints"
        '
        'clnFrontID
        '
        Me.clnFrontID.HeaderText = "Front ID"
        Me.clnFrontID.Name = "clnFrontID"
        '
        'GMEAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 450)
        Me.Controls.Add(Me.dgvEventAccountRating)
        Me.Controls.Add(Me.txtPage)
        Me.Controls.Add(Me.txtLimit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GMEAR"
        Me.Text = "GMEAR"
        CType(Me.dgvEventAccountRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtLimit As TextBox
    Friend WithEvents txtPage As TextBox
    Friend WithEvents dgvEventAccountRating As DataGridView
    Friend WithEvents clnRank As DataGridViewTextBoxColumn
    Friend WithEvents clnAwardLevel As DataGridViewTextBoxColumn
    Friend WithEvents clnAccountID As DataGridViewTextBoxColumn
    Friend WithEvents clnEventID As DataGridViewTextBoxColumn
    Friend WithEvents clnRankDelta As DataGridViewTextBoxColumn
    Friend WithEvents clnFamePointsToImprove As DataGridViewTextBoxColumn
    Friend WithEvents clnLastUpdate As DataGridViewTextBoxColumn
    Friend WithEvents clnBattles As DataGridViewTextBoxColumn
    Friend WithEvents clnClanID As DataGridViewTextBoxColumn
    Friend WithEvents clnURL As DataGridViewTextBoxColumn
    Friend WithEvents clnBattlesToAward As DataGridViewTextBoxColumn
    Friend WithEvents clnFamePoints As DataGridViewTextBoxColumn
    Friend WithEvents clnFrontID As DataGridViewTextBoxColumn
End Class
