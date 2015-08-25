<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrainees
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
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblCOB = New System.Windows.Forms.Label()
        Me.cboCOB1 = New System.Windows.Forms.ComboBox()
        Me.lblCOB2 = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.rbtMale = New System.Windows.Forms.RadioButton()
        Me.rbtFemale = New System.Windows.Forms.RadioButton()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cboCOB2 = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(92, 33)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(164, 20)
        Me.txtFirstname.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(5, 40)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(54, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "FirstName"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(5, 112)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(36, 13)
        Me.lblDOB.TabIndex = 2
        Me.lblDOB.Text = "D.O.B"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(5, 76)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(49, 13)
        Me.lblSurname.TabIndex = 3
        Me.lblSurname.Text = "Surname"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(428, 110)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(164, 20)
        Me.txtMobile.TabIndex = 4
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(92, 69)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(164, 20)
        Me.txtSurname.TabIndex = 5
        '
        'lblCOB
        '
        Me.lblCOB.AutoSize = True
        Me.lblCOB.Location = New System.Drawing.Point(5, 153)
        Me.lblCOB.Name = "lblCOB"
        Me.lblCOB.Size = New System.Drawing.Size(81, 13)
        Me.lblCOB.TabIndex = 7
        Me.lblCOB.Text = "Country Of Birth"
        '
        'cboCOB1
        '
        Me.cboCOB1.AllowDrop = True
        Me.cboCOB1.FormattingEnabled = True
        Me.cboCOB1.Items.AddRange(New Object() {"Ireland", "Albania", "Andorra", "Armenia", "Austria", "Azerbaijan", "Belarus", "Belgium", "Bosnia & Herzegovina", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Georgia", "Germany", "Greece", "Hungary", "Iceland", "Italy", "Kosovo", "Latvia", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Malta", "Moldova", "Monaco", "Montenegro", "The Netherlands", "Norway", "Poland", "Portugal", "Romania", "Russia", "San Marino", "Serbia", "Slovakia", "Slovenia", "Spain", "Sweden", "Switzerland", "Turkey", "Ukraine", "United Kingdom"})
        Me.cboCOB1.Location = New System.Drawing.Point(92, 145)
        Me.cboCOB1.Name = "cboCOB1"
        Me.cboCOB1.Size = New System.Drawing.Size(164, 21)
        Me.cboCOB1.TabIndex = 10
        '
        'lblCOB2
        '
        Me.lblCOB2.AutoSize = True
        Me.lblCOB2.Location = New System.Drawing.Point(5, 186)
        Me.lblCOB2.Name = "lblCOB2"
        Me.lblCOB2.Size = New System.Drawing.Size(81, 13)
        Me.lblCOB2.TabIndex = 12
        Me.lblCOB2.Text = "Country Of Birth"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(357, 40)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 15
        Me.lblGender.Text = "Gender"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(353, 113)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(541, 399)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(113, 38)
        Me.cmdExit.TabIndex = 17
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'rbtMale
        '
        Me.rbtMale.AutoSize = True
        Me.rbtMale.Location = New System.Drawing.Point(416, 40)
        Me.rbtMale.Name = "rbtMale"
        Me.rbtMale.Size = New System.Drawing.Size(48, 17)
        Me.rbtMale.TabIndex = 18
        Me.rbtMale.TabStop = True
        Me.rbtMale.Text = "Male"
        Me.rbtMale.UseVisualStyleBackColor = True
        '
        'rbtFemale
        '
        Me.rbtFemale.AutoSize = True
        Me.rbtFemale.Location = New System.Drawing.Point(416, 69)
        Me.rbtFemale.Name = "rbtFemale"
        Me.rbtFemale.Size = New System.Drawing.Size(59, 17)
        Me.rbtFemale.TabIndex = 19
        Me.rbtFemale.TabStop = True
        Me.rbtFemale.Text = "Female"
        Me.rbtFemale.UseVisualStyleBackColor = True
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(353, 162)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(35, 13)
        Me.lblNotes.TabIndex = 20
        Me.lblNotes.Text = "Notes"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(92, 106)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(164, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'cboCOB2
        '
        Me.cboCOB2.AllowDrop = True
        Me.cboCOB2.FormattingEnabled = True
        Me.cboCOB2.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cboCOB2.Location = New System.Drawing.Point(92, 178)
        Me.cboCOB2.Name = "cboCOB2"
        Me.cboCOB2.Size = New System.Drawing.Size(164, 21)
        Me.cboCOB2.TabIndex = 13
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(428, 159)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(164, 106)
        Me.txtNotes.TabIndex = 23
        '
        'frmTrainees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(666, 449)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.rbtFemale)
        Me.Controls.Add(Me.rbtMale)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.cboCOB2)
        Me.Controls.Add(Me.lblCOB2)
        Me.Controls.Add(Me.cboCOB1)
        Me.Controls.Add(Me.lblCOB)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstname)
        Me.Name = "frmTrainees"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblCOB As System.Windows.Forms.Label
    Friend WithEvents cboCOB1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblCOB2 As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents rbtMale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFemale As System.Windows.Forms.RadioButton
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCOB2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox

End Class
