<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class schedule_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(schedule_form))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.depart_date_picker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plateNumber_txtbx = New System.Windows.Forms.TextBox()
        Me.vehicleID_txtbx = New System.Windows.Forms.TextBox()
        Me.schedID_txtbx = New System.Windows.Forms.TextBox()
        Me.vehicleType_cb = New System.Windows.Forms.ComboBox()
        Me.VehicleTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet = New MonitoringSystem.testDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.VehicleTypeTableAdapter = New MonitoringSystem.testDataSetTableAdapters.VehicleTypeTableAdapter()
        Me.route_cb = New System.Windows.Forms.ComboBox()
        Me.RouteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RouteTableAdapter = New MonitoringSystem.testDataSetTableAdapters.RouteTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fare_cb = New System.Windows.Forms.ComboBox()
        Me.FareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FareTableAdapter = New MonitoringSystem.testDataSetTableAdapters.FareTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.time_cb = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DriverInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriverInfoTableAdapter = New MonitoringSystem.testDataSetTableAdapters.DriverInfoTableAdapter()
        CType(Me.VehicleTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RouteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Route"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 24)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "New Schedule"
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.Color.Transparent
        Me.save_btn.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.AliceBlue
        Me.save_btn.Location = New System.Drawing.Point(95, 440)
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
        Me.exit_btn.Location = New System.Drawing.Point(270, -3)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(32, 33)
        Me.exit_btn.TabIndex = 24
        Me.exit_btn.TabStop = False
        Me.exit_btn.Text = "x"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'depart_date_picker
        '
        Me.depart_date_picker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depart_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.depart_date_picker.Location = New System.Drawing.Point(49, 120)
        Me.depart_date_picker.Name = "depart_date_picker"
        Me.depart_date_picker.Size = New System.Drawing.Size(106, 23)
        Me.depart_date_picker.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Departure Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Plate No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Vehicle ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Schedule ID"
        '
        'plateNumber_txtbx
        '
        Me.plateNumber_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.plateNumber_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.plateNumber_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plateNumber_txtbx.Location = New System.Drawing.Point(49, 231)
        Me.plateNumber_txtbx.Name = "plateNumber_txtbx"
        Me.plateNumber_txtbx.Size = New System.Drawing.Size(200, 23)
        Me.plateNumber_txtbx.TabIndex = 22
        '
        'vehicleID_txtbx
        '
        Me.vehicleID_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.vehicleID_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vehicleID_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleID_txtbx.Location = New System.Drawing.Point(49, 175)
        Me.vehicleID_txtbx.Name = "vehicleID_txtbx"
        Me.vehicleID_txtbx.Size = New System.Drawing.Size(80, 23)
        Me.vehicleID_txtbx.TabIndex = 15
        '
        'schedID_txtbx
        '
        Me.schedID_txtbx.BackColor = System.Drawing.Color.AliceBlue
        Me.schedID_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.schedID_txtbx.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedID_txtbx.Location = New System.Drawing.Point(49, 65)
        Me.schedID_txtbx.Name = "schedID_txtbx"
        Me.schedID_txtbx.Size = New System.Drawing.Size(80, 23)
        Me.schedID_txtbx.TabIndex = 13
        '
        'vehicleType_cb
        '
        Me.vehicleType_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.vehicleType_cb.DataSource = Me.VehicleTypeBindingSource
        Me.vehicleType_cb.DisplayMember = "VehicleType"
        Me.vehicleType_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicleType_cb.FormattingEnabled = True
        Me.vehicleType_cb.Location = New System.Drawing.Point(143, 173)
        Me.vehicleType_cb.Name = "vehicleType_cb"
        Me.vehicleType_cb.Size = New System.Drawing.Size(106, 25)
        Me.vehicleType_cb.TabIndex = 30
        '
        'VehicleTypeBindingSource
        '
        Me.VehicleTypeBindingSource.DataMember = "VehicleType"
        Me.VehicleTypeBindingSource.DataSource = Me.TestDataSet
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(140, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Vehicle Type"
        '
        'VehicleTypeTableAdapter
        '
        Me.VehicleTypeTableAdapter.ClearBeforeFill = True
        '
        'route_cb
        '
        Me.route_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.route_cb.DataSource = Me.RouteBindingSource
        Me.route_cb.DisplayMember = "Route"
        Me.route_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.route_cb.FormattingEnabled = True
        Me.route_cb.Location = New System.Drawing.Point(49, 286)
        Me.route_cb.Name = "route_cb"
        Me.route_cb.Size = New System.Drawing.Size(200, 25)
        Me.route_cb.TabIndex = 30
        '
        'RouteBindingSource
        '
        Me.RouteBindingSource.DataMember = "Route"
        Me.RouteBindingSource.DataSource = Me.TestDataSet
        '
        'RouteTableAdapter
        '
        Me.RouteTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fare"
        '
        'fare_cb
        '
        Me.fare_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.fare_cb.DataSource = Me.FareBindingSource
        Me.fare_cb.DisplayMember = "Fare"
        Me.fare_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fare_cb.FormattingEnabled = True
        Me.fare_cb.Location = New System.Drawing.Point(49, 398)
        Me.fare_cb.Name = "fare_cb"
        Me.fare_cb.Size = New System.Drawing.Size(80, 25)
        Me.fare_cb.TabIndex = 30
        '
        'FareBindingSource
        '
        Me.FareBindingSource.DataMember = "Fare"
        Me.FareBindingSource.DataSource = Me.TestDataSet
        '
        'FareTableAdapter
        '
        Me.FareTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(167, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Time"
        '
        'time_cb
        '
        Me.time_cb.BackColor = System.Drawing.Color.AliceBlue
        Me.time_cb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_cb.FormattingEnabled = True
        Me.time_cb.Items.AddRange(New Object() {"11:00 AM", "12:00 PM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM"})
        Me.time_cb.Location = New System.Drawing.Point(170, 118)
        Me.time_cb.Name = "time_cb"
        Me.time_cb.Size = New System.Drawing.Size(80, 25)
        Me.time_cb.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Driver"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.ComboBox1.DataSource = Me.DriverInfoBindingSource
        Me.ComboBox1.DisplayMember = "FirstName"
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(49, 343)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 25)
        Me.ComboBox1.TabIndex = 30
        '
        'DriverInfoBindingSource
        '
        Me.DriverInfoBindingSource.DataMember = "DriverInfo"
        Me.DriverInfoBindingSource.DataSource = Me.TestDataSet
        '
        'DriverInfoTableAdapter
        '
        Me.DriverInfoTableAdapter.ClearBeforeFill = True
        '
        'schedule_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 500)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.route_cb)
        Me.Controls.Add(Me.time_cb)
        Me.Controls.Add(Me.fare_cb)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.vehicleType_cb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.depart_date_picker)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plateNumber_txtbx)
        Me.Controls.Add(Me.vehicleID_txtbx)
        Me.Controls.Add(Me.schedID_txtbx)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "schedule_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "schedule_form"
        CType(Me.VehicleTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RouteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents depart_date_picker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents plateNumber_txtbx As TextBox
    Friend WithEvents vehicleID_txtbx As TextBox
    Friend WithEvents schedID_txtbx As TextBox
    Friend WithEvents vehicleType_cb As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents VehicleTypeBindingSource As BindingSource
    Friend WithEvents VehicleTypeTableAdapter As testDataSetTableAdapters.VehicleTypeTableAdapter
    Friend WithEvents route_cb As ComboBox
    Friend WithEvents RouteBindingSource As BindingSource
    Friend WithEvents RouteTableAdapter As testDataSetTableAdapters.RouteTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents fare_cb As ComboBox
    Friend WithEvents FareBindingSource As BindingSource
    Friend WithEvents FareTableAdapter As testDataSetTableAdapters.FareTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents time_cb As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DriverInfoBindingSource As BindingSource
    Friend WithEvents DriverInfoTableAdapter As testDataSetTableAdapters.DriverInfoTableAdapter
End Class
