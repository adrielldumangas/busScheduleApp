<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addDriver_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addDriver_form))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.bday_picker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.middlename_txtbx = New System.Windows.Forms.TextBox()
        Me.firstname_txtbx = New System.Windows.Forms.TextBox()
        Me.lastname_txtbx = New System.Windows.Forms.TextBox()
        Me.address_txtbx = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Driver's Info"
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.Color.Transparent
        Me.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.save_btn.Location = New System.Drawing.Point(95, 429)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(109, 48)
        Me.save_btn.TabIndex = 26
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.FlatAppearance.BorderSize = 0
        Me.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(269, -3)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(32, 33)
        Me.exit_btn.TabIndex = 24
        Me.exit_btn.TabStop = False
        Me.exit_btn.Text = "x"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'bday_picker
        '
        Me.bday_picker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bday_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.bday_picker.Location = New System.Drawing.Point(50, 255)
        Me.bday_picker.Name = "bday_picker"
        Me.bday_picker.Size = New System.Drawing.Size(200, 23)
        Me.bday_picker.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Birth Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Last Name"
        '
        'middlename_txtbx
        '
        Me.middlename_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.middlename_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.middlename_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename_txtbx.Location = New System.Drawing.Point(50, 202)
        Me.middlename_txtbx.Name = "middlename_txtbx"
        Me.middlename_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.middlename_txtbx.TabIndex = 15
        '
        'firstname_txtbx
        '
        Me.firstname_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.firstname_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstname_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname_txtbx.Location = New System.Drawing.Point(50, 149)
        Me.firstname_txtbx.Name = "firstname_txtbx"
        Me.firstname_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.firstname_txtbx.TabIndex = 14
        '
        'lastname_txtbx
        '
        Me.lastname_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.lastname_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lastname_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname_txtbx.Location = New System.Drawing.Point(50, 96)
        Me.lastname_txtbx.Name = "lastname_txtbx"
        Me.lastname_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.lastname_txtbx.TabIndex = 13
        '
        'address_txtbx
        '
        Me.address_txtbx.BackColor = System.Drawing.Color.White
        Me.address_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.address_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_txtbx.Location = New System.Drawing.Point(50, 308)
        Me.address_txtbx.Name = "address_txtbx"
        Me.address_txtbx.Size = New System.Drawing.Size(200, 96)
        Me.address_txtbx.TabIndex = 28
        Me.address_txtbx.Text = ""
        '
        'addDriver_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 500)
        Me.Controls.Add(Me.address_txtbx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.bday_picker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.middlename_txtbx)
        Me.Controls.Add(Me.firstname_txtbx)
        Me.Controls.Add(Me.lastname_txtbx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addDriver_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "add_driver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents bday_picker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents middlename_txtbx As TextBox
    Friend WithEvents firstname_txtbx As TextBox
    Friend WithEvents lastname_txtbx As TextBox
    Friend WithEvents address_txtbx As RichTextBox
End Class
