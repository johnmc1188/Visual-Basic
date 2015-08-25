<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetricConversion
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
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.txtKilometres = New System.Windows.Forms.TextBox()
        Me.lblKilometers = New System.Windows.Forms.Label()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.GroupBoxDistance = New System.Windows.Forms.GroupBox()
        Me.GroupBoxTemp = New System.Windows.Forms.GroupBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.txtCelsius = New System.Windows.Forms.TextBox()
        Me.lblFahrenheit = New System.Windows.Forms.Label()
        Me.lblCelsius = New System.Windows.Forms.Label()
        Me.radDistance = New System.Windows.Forms.RadioButton()
        Me.radTemp = New System.Windows.Forms.RadioButton()
        Me.GroupBoxDistance.SuspendLayout()
        Me.GroupBoxTemp.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(9, 63)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(143, 20)
        Me.txtMiles.TabIndex = 0
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.Location = New System.Drawing.Point(6, 31)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(126, 13)
        Me.lblMiles.TabIndex = 1
        Me.lblMiles.Text = "Enter the number of miles"
        '
        'txtKilometres
        '
        Me.txtKilometres.Location = New System.Drawing.Point(9, 134)
        Me.txtKilometres.Name = "txtKilometres"
        Me.txtKilometres.Size = New System.Drawing.Size(143, 20)
        Me.txtKilometres.TabIndex = 2
        '
        'lblKilometers
        '
        Me.lblKilometers.AutoSize = True
        Me.lblKilometers.Location = New System.Drawing.Point(9, 99)
        Me.lblKilometers.Name = "lblKilometers"
        Me.lblKilometers.Size = New System.Drawing.Size(55, 13)
        Me.lblKilometers.TabIndex = 3
        Me.lblKilometers.Text = "Kilometres"
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(442, 152)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubmit.TabIndex = 4
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(442, 236)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(442, 193)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'GroupBoxDistance
        '
        Me.GroupBoxDistance.Controls.Add(Me.lblMiles)
        Me.GroupBoxDistance.Controls.Add(Me.txtMiles)
        Me.GroupBoxDistance.Controls.Add(Me.txtKilometres)
        Me.GroupBoxDistance.Controls.Add(Me.lblKilometers)
        Me.GroupBoxDistance.Enabled = False
        Me.GroupBoxDistance.Location = New System.Drawing.Point(12, 116)
        Me.GroupBoxDistance.Name = "GroupBoxDistance"
        Me.GroupBoxDistance.Size = New System.Drawing.Size(158, 174)
        Me.GroupBoxDistance.TabIndex = 9
        Me.GroupBoxDistance.TabStop = False
        Me.GroupBoxDistance.Text = "Distance"
        '
        'GroupBoxTemp
        '
        Me.GroupBoxTemp.Controls.Add(Me.txtFahrenheit)
        Me.GroupBoxTemp.Controls.Add(Me.txtCelsius)
        Me.GroupBoxTemp.Controls.Add(Me.lblFahrenheit)
        Me.GroupBoxTemp.Controls.Add(Me.lblCelsius)
        Me.GroupBoxTemp.Enabled = False
        Me.GroupBoxTemp.Location = New System.Drawing.Point(247, 116)
        Me.GroupBoxTemp.Name = "GroupBoxTemp"
        Me.GroupBoxTemp.Size = New System.Drawing.Size(158, 174)
        Me.GroupBoxTemp.TabIndex = 10
        Me.GroupBoxTemp.TabStop = False
        Me.GroupBoxTemp.Text = "Temperature"
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(7, 134)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(145, 20)
        Me.txtFahrenheit.TabIndex = 3
        '
        'txtCelsius
        '
        Me.txtCelsius.Location = New System.Drawing.Point(10, 63)
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.Size = New System.Drawing.Size(142, 20)
        Me.txtCelsius.TabIndex = 2
        '
        'lblFahrenheit
        '
        Me.lblFahrenheit.AutoSize = True
        Me.lblFahrenheit.Location = New System.Drawing.Point(47, 99)
        Me.lblFahrenheit.Name = "lblFahrenheit"
        Me.lblFahrenheit.Size = New System.Drawing.Size(57, 13)
        Me.lblFahrenheit.TabIndex = 1
        Me.lblFahrenheit.Text = "Fahrenheit"
        '
        'lblCelsius
        '
        Me.lblCelsius.AutoSize = True
        Me.lblCelsius.Location = New System.Drawing.Point(47, 31)
        Me.lblCelsius.Name = "lblCelsius"
        Me.lblCelsius.Size = New System.Drawing.Size(40, 13)
        Me.lblCelsius.TabIndex = 0
        Me.lblCelsius.Text = "Celsius"
        '
        'radDistance
        '
        Me.radDistance.AutoSize = True
        Me.radDistance.Location = New System.Drawing.Point(65, 54)
        Me.radDistance.Name = "radDistance"
        Me.radDistance.Size = New System.Drawing.Size(67, 17)
        Me.radDistance.TabIndex = 11
        Me.radDistance.TabStop = True
        Me.radDistance.Text = "Distance"
        Me.radDistance.UseVisualStyleBackColor = True
        '
        'radTemp
        '
        Me.radTemp.AutoSize = True
        Me.radTemp.Location = New System.Drawing.Point(283, 54)
        Me.radTemp.Name = "radTemp"
        Me.radTemp.Size = New System.Drawing.Size(85, 17)
        Me.radTemp.TabIndex = 12
        Me.radTemp.TabStop = True
        Me.radTemp.Text = "Temperature"
        Me.radTemp.UseVisualStyleBackColor = True
        '
        'MetricConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(541, 324)
        Me.ControlBox = False
        Me.Controls.Add(Me.radTemp)
        Me.Controls.Add(Me.radDistance)
        Me.Controls.Add(Me.GroupBoxTemp)
        Me.Controls.Add(Me.GroupBoxDistance)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Name = "MetricConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertor"
        Me.GroupBoxDistance.ResumeLayout(False)
        Me.GroupBoxDistance.PerformLayout()
        Me.GroupBoxTemp.ResumeLayout(False)
        Me.GroupBoxTemp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox
    Friend WithEvents lblMiles As System.Windows.Forms.Label
    Friend WithEvents txtKilometres As System.Windows.Forms.TextBox
    Friend WithEvents lblKilometers As System.Windows.Forms.Label
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents GroupBoxDistance As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxTemp As System.Windows.Forms.GroupBox
    Friend WithEvents txtFahrenheit As System.Windows.Forms.TextBox
    Friend WithEvents txtCelsius As System.Windows.Forms.TextBox
    Friend WithEvents lblFahrenheit As System.Windows.Forms.Label
    Friend WithEvents lblCelsius As System.Windows.Forms.Label
    Friend WithEvents radDistance As System.Windows.Forms.RadioButton
    Friend WithEvents radTemp As System.Windows.Forms.RadioButton

End Class
