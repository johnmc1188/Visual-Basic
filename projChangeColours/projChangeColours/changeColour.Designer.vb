<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeColour
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
        Me.cmdChangeColours = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.backColour1 = New System.Windows.Forms.TextBox()
        Me.backColour2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdChangeColours
        '
        Me.cmdChangeColours.Location = New System.Drawing.Point(12, 153)
        Me.cmdChangeColours.Name = "cmdChangeColours"
        Me.cmdChangeColours.Size = New System.Drawing.Size(89, 42)
        Me.cmdChangeColours.TabIndex = 0
        Me.cmdChangeColours.Text = "Change Colours"
        Me.cmdChangeColours.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(183, 153)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(89, 42)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'backColour1
        '
        Me.backColour1.BackColor = System.Drawing.Color.Green
        Me.backColour1.Location = New System.Drawing.Point(24, 48)
        Me.backColour1.Name = "backColour1"
        Me.backColour1.Size = New System.Drawing.Size(248, 20)
        Me.backColour1.TabIndex = 2
        '
        'backColour2
        '
        Me.backColour2.BackColor = System.Drawing.Color.Blue
        Me.backColour2.Location = New System.Drawing.Point(24, 92)
        Me.backColour2.Name = "backColour2"
        Me.backColour2.Size = New System.Drawing.Size(248, 20)
        Me.backColour2.TabIndex = 3
        '
        'changeColour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 198)
        Me.Controls.Add(Me.backColour2)
        Me.Controls.Add(Me.backColour1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdChangeColours)
        Me.Name = "changeColour"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdChangeColours As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents backColour1 As System.Windows.Forms.TextBox
    Friend WithEvents backColour2 As System.Windows.Forms.TextBox

End Class
