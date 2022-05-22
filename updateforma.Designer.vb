<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateforma
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
        Me.DownloadedLabel = New System.Windows.Forms.Label()
        Me.RemainedLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.output = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DownloadedLabel
        '
        Me.DownloadedLabel.AutoSize = True
        Me.DownloadedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadedLabel.Location = New System.Drawing.Point(145, 453)
        Me.DownloadedLabel.Name = "DownloadedLabel"
        Me.DownloadedLabel.Size = New System.Drawing.Size(168, 25)
        Me.DownloadedLabel.TabIndex = 13
        Me.DownloadedLabel.Text = "Downloaded: 0"
        '
        'RemainedLabel
        '
        Me.RemainedLabel.AutoSize = True
        Me.RemainedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemainedLabel.Location = New System.Drawing.Point(374, 453)
        Me.RemainedLabel.Name = "RemainedLabel"
        Me.RemainedLabel.Size = New System.Drawing.Size(144, 25)
        Me.RemainedLabel.TabIndex = 14
        Me.RemainedLabel.Text = "Remained: 0"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(586, 453)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(150, 25)
        Me.TotalLabel.TabIndex = 15
        Me.TotalLabel.Text = "Total Files: 0"
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(145, 489)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(614, 23)
        Me.Progress.TabIndex = 12
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Black
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.Yellow
        Me.StartButton.Location = New System.Drawing.Point(-1, 453)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(140, 59)
        Me.StartButton.TabIndex = 11
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'output
        '
        Me.output.BackColor = System.Drawing.Color.Black
        Me.output.ForeColor = System.Drawing.Color.Yellow
        Me.output.Location = New System.Drawing.Point(-1, 40)
        Me.output.Multiline = True
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(776, 407)
        Me.output.TabIndex = 10
        '
        'updateforma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 855)
        Me.Controls.Add(Me.DownloadedLabel)
        Me.Controls.Add(Me.RemainedLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.output)
        Me.Name = "updateforma"
        Me.Text = "updateforma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DownloadedLabel As Label
    Friend WithEvents RemainedLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents StartButton As Button
    Friend WithEvents output As TextBox
End Class
