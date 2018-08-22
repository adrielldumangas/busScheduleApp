<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_window
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_window))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dateTime_lbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fullname_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addDriver_btn = New System.Windows.Forms.Button()
        Me.newSched_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.display_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dateTime_lbl)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.fullname_label)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 480)
        Me.Panel1.TabIndex = 0
        '
        'dateTime_lbl
        '
        Me.dateTime_lbl.AutoSize = True
        Me.dateTime_lbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTime_lbl.Location = New System.Drawing.Point(19, 454)
        Me.dateTime_lbl.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.dateTime_lbl.Name = "dateTime_lbl"
        Me.dateTime_lbl.Size = New System.Drawing.Size(50, 17)
        Me.dateTime_lbl.TabIndex = 7
        Me.dateTime_lbl.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 29)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Monitoring"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 29)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Terminal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(35, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Terminal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(30, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Naval"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(35, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Naval"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(60, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'fullname_label
        '
        Me.fullname_label.AutoSize = True
        Me.fullname_label.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname_label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.fullname_label.Location = New System.Drawing.Point(31, 152)
        Me.fullname_label.Name = "fullname_label"
        Me.fullname_label.Size = New System.Drawing.Size(90, 24)
        Me.fullname_label.TabIndex = 1
        Me.fullname_label.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(31, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hello,"
        '
        'addDriver_btn
        '
        Me.addDriver_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.addDriver_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.addDriver_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addDriver_btn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addDriver_btn.Image = CType(resources.GetObject("addDriver_btn.Image"), System.Drawing.Image)
        Me.addDriver_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.addDriver_btn.Location = New System.Drawing.Point(258, 79)
        Me.addDriver_btn.Margin = New System.Windows.Forms.Padding(10)
        Me.addDriver_btn.Name = "addDriver_btn"
        Me.addDriver_btn.Size = New System.Drawing.Size(123, 132)
        Me.addDriver_btn.TabIndex = 1
        Me.addDriver_btn.Text = "Add Driver"
        Me.addDriver_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.addDriver_btn.UseVisualStyleBackColor = False
        '
        'newSched_btn
        '
        Me.newSched_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.newSched_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.newSched_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newSched_btn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newSched_btn.Image = CType(resources.GetObject("newSched_btn.Image"), System.Drawing.Image)
        Me.newSched_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.newSched_btn.Location = New System.Drawing.Point(440, 79)
        Me.newSched_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.newSched_btn.Name = "newSched_btn"
        Me.newSched_btn.Size = New System.Drawing.Size(123, 132)
        Me.newSched_btn.TabIndex = 1
        Me.newSched_btn.Text = "New Schedule"
        Me.newSched_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.newSched_btn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(258, 266)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 132)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View/ Manage Trips"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'display_btn
        '
        Me.display_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.display_btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.display_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.display_btn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display_btn.Image = CType(resources.GetObject("display_btn.Image"), System.Drawing.Image)
        Me.display_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.display_btn.Location = New System.Drawing.Point(440, 266)
        Me.display_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.display_btn.Name = "display_btn"
        Me.display_btn.Size = New System.Drawing.Size(123, 132)
        Me.display_btn.TabIndex = 1
        Me.display_btn.Text = "Display Trips"
        Me.display_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.display_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.FlatAppearance.BorderSize = 0
        Me.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(595, -2)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(32, 33)
        Me.exit_btn.TabIndex = 6
        Me.exit_btn.Text = "x"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'main_window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(625, 480)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.display_btn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.newSched_btn)
        Me.Controls.Add(Me.addDriver_btn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_window"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_window"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents fullname_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents addDriver_btn As Button
    Friend WithEvents newSched_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents display_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dateTime_lbl As Label
End Class
