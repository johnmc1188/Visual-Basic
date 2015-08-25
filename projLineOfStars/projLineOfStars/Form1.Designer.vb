<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtStars = New System.Windows.Forms.TextBox()
        Me.cmdStars = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtStars
        '
        Me.txtStars.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStars.Location = New System.Drawing.Point(18, 43)
        Me.txtStars.Multiline = True
        Me.txtStars.Name = "txtStars"
        Me.txtStars.Size = New System.Drawing.Size(240, 21)
        Me.txtStars.TabIndex = 1
        Me.txtStars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdStars
        '
        Me.cmdStars.Location = New System.Drawing.Point(12, 130)
        Me.cmdStars.Name = "cmdStars"
        Me.cmdStars.Size = New System.Drawing.Size(106, 56)
        Me.cmdStars.TabIndex = 2
        Me.cmdStars.Text = "Create a line of stars"
        Me.cmdStars.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(166, 130)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(106, 56)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 202)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdStars)
        Me.Controls.Add(Me.txtStars)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStars As System.Windows.Forms.TextBox
    Friend WithEvents cmdStars As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button

End Class
