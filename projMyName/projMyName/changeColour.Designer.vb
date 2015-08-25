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
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtMyName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(12, 130)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(79, 28)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "Start"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(97, 130)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(78, 28)
        Me.cmdChange.TabIndex = 1
        Me.cmdChange.Text = "Change"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(181, 130)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 28)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'txtMyName
        '
        Me.txtMyName.Location = New System.Drawing.Point(12, 57)
        Me.txtMyName.Name = "txtMyName"
        Me.txtMyName.Size = New System.Drawing.Size(242, 20)
        Me.txtMyName.TabIndex = 3
        Me.txtMyName.Text = "John McCarthy"
        Me.txtMyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 183)
        Me.Controls.Add(Me.txtMyName)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.cmdStart)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtMyName As System.Windows.Forms.TextBox

End Class
