<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRandom
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
        Me.lblNoOfAttempts = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.txtNoOfAtempts = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.cmdDie1 = New System.Windows.Forms.Button()
        Me.cmdDie2 = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtDie1 = New System.Windows.Forms.TextBox()
        Me.lblDie1 = New System.Windows.Forms.Label()
        Me.lblDie2 = New System.Windows.Forms.Label()
        Me.txtDie2 = New System.Windows.Forms.TextBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNoOfAttempts
        '
        Me.lblNoOfAttempts.AutoSize = True
        Me.lblNoOfAttempts.Location = New System.Drawing.Point(9, 57)
        Me.lblNoOfAttempts.Name = "lblNoOfAttempts"
        Me.lblNoOfAttempts.Size = New System.Drawing.Size(99, 13)
        Me.lblNoOfAttempts.TabIndex = 0
        Me.lblNoOfAttempts.Text = "Number Of Atempts"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(9, 126)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(94, 13)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Score This Atempt"
        '
        'txtNoOfAtempts
        '
        Me.txtNoOfAtempts.Location = New System.Drawing.Point(114, 57)
        Me.txtNoOfAtempts.Name = "txtNoOfAtempts"
        Me.txtNoOfAtempts.Size = New System.Drawing.Size(100, 20)
        Me.txtNoOfAtempts.TabIndex = 2
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(114, 123)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(100, 20)
        Me.txtScore.TabIndex = 3
        '
        'cmdDie1
        '
        Me.cmdDie1.Location = New System.Drawing.Point(134, 220)
        Me.cmdDie1.Name = "cmdDie1"
        Me.cmdDie1.Size = New System.Drawing.Size(75, 23)
        Me.cmdDie1.TabIndex = 4
        Me.cmdDie1.Text = "Die1"
        Me.cmdDie1.UseVisualStyleBackColor = True
        '
        'cmdDie2
        '
        Me.cmdDie2.Location = New System.Drawing.Point(215, 220)
        Me.cmdDie2.Name = "cmdDie2"
        Me.cmdDie2.Size = New System.Drawing.Size(75, 23)
        Me.cmdDie2.TabIndex = 5
        Me.cmdDie2.Text = "Die2"
        Me.cmdDie2.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(296, 220)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtDie1
        '
        Me.txtDie1.Location = New System.Drawing.Point(296, 57)
        Me.txtDie1.Name = "txtDie1"
        Me.txtDie1.Size = New System.Drawing.Size(100, 20)
        Me.txtDie1.TabIndex = 7
        '
        'lblDie1
        '
        Me.lblDie1.AutoSize = True
        Me.lblDie1.Location = New System.Drawing.Point(296, 38)
        Me.lblDie1.Name = "lblDie1"
        Me.lblDie1.Size = New System.Drawing.Size(29, 13)
        Me.lblDie1.TabIndex = 8
        Me.lblDie1.Text = "Die1"
        '
        'lblDie2
        '
        Me.lblDie2.AutoSize = True
        Me.lblDie2.Location = New System.Drawing.Point(293, 105)
        Me.lblDie2.Name = "lblDie2"
        Me.lblDie2.Size = New System.Drawing.Size(29, 13)
        Me.lblDie2.TabIndex = 10
        Me.lblDie2.Text = "Die2"
        '
        'txtDie2
        '
        Me.txtDie2.Location = New System.Drawing.Point(296, 126)
        Me.txtDie2.Name = "txtDie2"
        Me.txtDie2.Size = New System.Drawing.Size(100, 20)
        Me.txtDie2.TabIndex = 9
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(53, 220)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(75, 23)
        Me.cmdReset.TabIndex = 11
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'frmRandom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(421, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.lblDie2)
        Me.Controls.Add(Me.txtDie2)
        Me.Controls.Add(Me.lblDie1)
        Me.Controls.Add(Me.txtDie1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdDie2)
        Me.Controls.Add(Me.cmdDie1)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtNoOfAtempts)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblNoOfAttempts)
        Me.Name = "frmRandom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNoOfAttempts As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents txtNoOfAtempts As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents cmdDie1 As System.Windows.Forms.Button
    Friend WithEvents cmdDie2 As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtDie1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDie1 As System.Windows.Forms.Label
    Friend WithEvents lblDie2 As System.Windows.Forms.Label
    Friend WithEvents txtDie2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdReset As System.Windows.Forms.Button

End Class
