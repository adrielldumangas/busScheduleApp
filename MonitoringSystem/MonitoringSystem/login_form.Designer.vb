<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_form))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.username_txtbx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.password_txtbx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.signUp_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ImageLocation = "D:\Documents\Visual Studio 2015\Projects\MonitoringSystem\Icons\desktop-monitor_2" &
    "00x200.png"
        Me.PictureBox1.Location = New System.Drawing.Point(50, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'username_txtbx
        '
        Me.username_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.username_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.username_txtbx.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txtbx.Location = New System.Drawing.Point(50, 291)
        Me.username_txtbx.Name = "username_txtbx"
        Me.username_txtbx.Size = New System.Drawing.Size(200, 26)
        Me.username_txtbx.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'password_txtbx
        '
        Me.password_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.password_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txtbx.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txtbx.Location = New System.Drawing.Point(50, 352)
        Me.password_txtbx.Name = "password_txtbx"
        Me.password_txtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txtbx.Size = New System.Drawing.Size(200, 26)
        Me.password_txtbx.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Naval Terminal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monitoring System"
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.Transparent
        Me.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.login_btn.Location = New System.Drawing.Point(97, 396)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(109, 48)
        Me.login_btn.TabIndex = 4
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.FlatAppearance.BorderSize = 0
        Me.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(270, -3)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(32, 33)
        Me.exit_btn.TabIndex = 5
        Me.exit_btn.Text = "x"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'signUp_btn
        '
        Me.signUp_btn.BackColor = System.Drawing.Color.Transparent
        Me.signUp_btn.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.signUp_btn.FlatAppearance.BorderSize = 0
        Me.signUp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.signUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signUp_btn.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signUp_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.signUp_btn.Location = New System.Drawing.Point(50, 457)
        Me.signUp_btn.Name = "signUp_btn"
        Me.signUp_btn.Size = New System.Drawing.Size(200, 31)
        Me.signUp_btn.TabIndex = 4
        Me.signUp_btn.Text = "Register as New User"
        Me.signUp_btn.UseVisualStyleBackColor = False
        '
        'login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(300, 500)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.signUp_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password_txtbx)
        Me.Controls.Add(Me.username_txtbx)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents username_txtbx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents password_txtbx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents login_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents signUp_btn As Button
End Class
