<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListBox
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
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.cboCounties = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(12, 26)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(120, 20)
        Me.txtItem.TabIndex = 1
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(374, 26)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(100, 23)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(374, 85)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(100, 23)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(12, 76)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(120, 108)
        Me.lstItems.TabIndex = 0
        '
        'cboCounties
        '
        Me.cboCounties.FormattingEnabled = True
        Me.cboCounties.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cboCounties.Location = New System.Drawing.Point(194, 24)
        Me.cboCounties.Name = "cboCounties"
        Me.cboCounties.Size = New System.Drawing.Size(121, 21)
        Me.cboCounties.TabIndex = 4
        '
        'frmListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 219)
        Me.Controls.Add(Me.cboCounties)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lstItems)
        Me.Name = "frmListBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lstItems As System.Windows.Forms.ListBox
    Friend WithEvents cboCounties As System.Windows.Forms.ComboBox

End Class
