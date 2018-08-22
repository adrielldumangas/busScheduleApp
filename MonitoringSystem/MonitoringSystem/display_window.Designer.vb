<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class display_window
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(display_window))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_lbl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.day_lbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Broadway", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departures"
        '
        'date_lbl
        '
        Me.date_lbl.AutoSize = True
        Me.date_lbl.Font = New System.Drawing.Font("Broadway", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_lbl.Location = New System.Drawing.Point(742, 19)
        Me.date_lbl.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.Size = New System.Drawing.Size(269, 42)
        Me.date_lbl.TabIndex = 0
        Me.date_lbl.Text = "01 Jan 2018"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.Font = New System.Drawing.Font("Broadway", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_lbl.Location = New System.Drawing.Point(1051, 19)
        Me.time_lbl.Margin = New System.Windows.Forms.Padding(3, 10, 10, 0)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(274, 42)
        Me.time_lbl.TabIndex = 0
        Me.time_lbl.Text = "00:00:00 AM"
        '
        'day_lbl
        '
        Me.day_lbl.AutoSize = True
        Me.day_lbl.Font = New System.Drawing.Font("Broadway", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day_lbl.Location = New System.Drawing.Point(439, 19)
        Me.day_lbl.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.day_lbl.Name = "day_lbl"
        Me.day_lbl.Size = New System.Drawing.Size(258, 42)
        Me.day_lbl.TabIndex = 0
        Me.day_lbl.Text = "Wednesday"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1025, 650)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 60)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'display_window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 729)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.time_lbl)
        Me.Controls.Add(Me.day_lbl)
        Me.Controls.Add(Me.date_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "display_window"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule of Trips"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents date_lbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents time_lbl As Label
    Friend WithEvents day_lbl As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
