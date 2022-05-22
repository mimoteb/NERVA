<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TankTableForm
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
        Me.PremiumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedmiumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeavyTankToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TankDestroyerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SPGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Premium = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefencePoints = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Spotted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Frags = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Winrate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Damage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vehicle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpectedValuesGrid = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ExpectedValuesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PremiumToolStripMenuItem
        '
        Me.PremiumToolStripMenuItem.Name = "PremiumToolStripMenuItem"
        Me.PremiumToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.PremiumToolStripMenuItem.Text = "Premium"
        '
        'MedmiumToolStripMenuItem
        '
        Me.MedmiumToolStripMenuItem.Checked = True
        Me.MedmiumToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MedmiumToolStripMenuItem.Name = "MedmiumToolStripMenuItem"
        Me.MedmiumToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MedmiumToolStripMenuItem.Text = "Medmium"
        '
        'HeavyTankToolStripMenuItem
        '
        Me.HeavyTankToolStripMenuItem.Checked = True
        Me.HeavyTankToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HeavyTankToolStripMenuItem.Name = "HeavyTankToolStripMenuItem"
        Me.HeavyTankToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.HeavyTankToolStripMenuItem.Text = "Heavy"
        '
        'TankDestroyerToolStripMenuItem
        '
        Me.TankDestroyerToolStripMenuItem.Checked = True
        Me.TankDestroyerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TankDestroyerToolStripMenuItem.Name = "TankDestroyerToolStripMenuItem"
        Me.TankDestroyerToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TankDestroyerToolStripMenuItem.Text = "Tank Destroyer"
        '
        'SPGToolStripMenuItem
        '
        Me.SPGToolStripMenuItem.Checked = True
        Me.SPGToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SPGToolStripMenuItem.Name = "SPGToolStripMenuItem"
        Me.SPGToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SPGToolStripMenuItem.Text = "SPG"
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SPGToolStripMenuItem, Me.TankDestroyerToolStripMenuItem, Me.HeavyTankToolStripMenuItem, Me.MedmiumToolStripMenuItem, Me.LightToolStripMenuItem})
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClassToolStripMenuItem.Text = "Class"
        '
        'LightToolStripMenuItem
        '
        Me.LightToolStripMenuItem.Checked = True
        Me.LightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LightToolStripMenuItem.Name = "LightToolStripMenuItem"
        Me.LightToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.LightToolStripMenuItem.Text = "Light"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Checked = True
        Me.ToolStripMenuItem11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem11.Text = "10"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Checked = True
        Me.ToolStripMenuItem10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem10.Text = "9"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Checked = True
        Me.ToolStripMenuItem9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem9.Text = "8"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Checked = True
        Me.ToolStripMenuItem8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem8.Text = "7"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Checked = True
        Me.ToolStripMenuItem7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem7.Text = "6"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Checked = True
        Me.ToolStripMenuItem6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem6.Text = "5"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Checked = True
        Me.ToolStripMenuItem5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem5.Text = "4"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Checked = True
        Me.ToolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem4.Text = "3"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Checked = True
        Me.ToolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem3.Text = "2"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Checked = True
        Me.ToolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripMenuItem2.Text = "1"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FilterToolStripMenuItem.Text = "Tier"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem, Me.ClassToolStripMenuItem, Me.PremiumToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1401, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Premium
        '
        Me.Premium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Premium.HeaderText = "Premium"
        Me.Premium.Name = "Premium"
        Me.Premium.ReadOnly = True
        Me.Premium.Width = 72
        '
        'Nation
        '
        Me.Nation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nation.HeaderText = "Nation"
        Me.Nation.Name = "Nation"
        Me.Nation.ReadOnly = True
        Me.Nation.Width = 63
        '
        'Tier
        '
        Me.Tier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tier.HeaderText = "Tier"
        Me.Tier.Name = "Tier"
        Me.Tier.ReadOnly = True
        Me.Tier.Width = 50
        '
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 56
        '
        'DefencePoints
        '
        Me.DefencePoints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DefencePoints.HeaderText = "Defence Points"
        Me.DefencePoints.Name = "DefencePoints"
        Me.DefencePoints.ReadOnly = True
        Me.DefencePoints.Width = 96
        '
        'Spotted
        '
        Me.Spotted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Spotted.HeaderText = "Spotted"
        Me.Spotted.Name = "Spotted"
        Me.Spotted.ReadOnly = True
        Me.Spotted.Width = 69
        '
        'Frags
        '
        Me.Frags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Frags.HeaderText = "Frags"
        Me.Frags.Name = "Frags"
        Me.Frags.ReadOnly = True
        Me.Frags.Width = 58
        '
        'Winrate
        '
        Me.Winrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Winrate.HeaderText = "Winrate"
        Me.Winrate.Name = "Winrate"
        Me.Winrate.ReadOnly = True
        Me.Winrate.Width = 69
        '
        'Damage
        '
        Me.Damage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Damage.HeaderText = "Damage"
        Me.Damage.Name = "Damage"
        Me.Damage.ReadOnly = True
        Me.Damage.Width = 72
        '
        'Vehicle
        '
        Me.Vehicle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Vehicle.HeaderText = "Vehicle"
        Me.Vehicle.Name = "Vehicle"
        Me.Vehicle.ReadOnly = True
        Me.Vehicle.Width = 67
        '
        'ExpectedValuesGrid
        '
        Me.ExpectedValuesGrid.AllowUserToAddRows = False
        Me.ExpectedValuesGrid.AllowUserToDeleteRows = False
        Me.ExpectedValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExpectedValuesGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Vehicle, Me.Damage, Me.Winrate, Me.Frags, Me.Spotted, Me.DefencePoints, Me.Type, Me.Tier, Me.Nation, Me.Premium})
        Me.ExpectedValuesGrid.Location = New System.Drawing.Point(12, 27)
        Me.ExpectedValuesGrid.Name = "ExpectedValuesGrid"
        Me.ExpectedValuesGrid.ReadOnly = True
        Me.ExpectedValuesGrid.Size = New System.Drawing.Size(875, 374)
        Me.ExpectedValuesGrid.TabIndex = 4
        '
        'TankTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1401, 738)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ExpectedValuesGrid)
        Me.Name = "TankTableForm"
        Me.Text = "TankTableForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ExpectedValuesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PremiumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedmiumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeavyTankToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TankDestroyerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SPGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Premium As DataGridViewTextBoxColumn
    Friend WithEvents Nation As DataGridViewTextBoxColumn
    Friend WithEvents Tier As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents DefencePoints As DataGridViewTextBoxColumn
    Friend WithEvents Spotted As DataGridViewTextBoxColumn
    Friend WithEvents Frags As DataGridViewTextBoxColumn
    Friend WithEvents Winrate As DataGridViewTextBoxColumn
    Friend WithEvents Damage As DataGridViewTextBoxColumn
    Friend WithEvents Vehicle As DataGridViewTextBoxColumn
    Friend WithEvents ExpectedValuesGrid As DataGridView
End Class
