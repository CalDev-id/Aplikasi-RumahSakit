<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Latihan
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
        Me.BtnNow = New System.Windows.Forms.Button()
        Me.BtnTime = New System.Windows.Forms.Button()
        Me.TimePickerTime = New System.Windows.Forms.DateTimePicker()
        Me.BtnDate = New System.Windows.Forms.Button()
        Me.DatePickTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.BtnFormatOutput = New System.Windows.Forms.Button()
        Me.DatePickTanggalLahir1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnOpenCatatan = New System.Windows.Forms.Button()
        Me.RTBoxCatatan = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.BtnOpenFoto = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnChangeColor = New System.Windows.Forms.Button()
        Me.LblColorChange = New System.Windows.Forms.Label()
        Me.LblColorCode = New System.Windows.Forms.Label()
        Me.TxtColorCode = New System.Windows.Forms.TextBox()
        Me.PnlColorChange = New System.Windows.Forms.Panel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BtnChangeGreen = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNow
        '
        Me.BtnNow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnNow.Location = New System.Drawing.Point(37, 180)
        Me.BtnNow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnNow.Name = "BtnNow"
        Me.BtnNow.Size = New System.Drawing.Size(419, 44)
        Me.BtnNow.TabIndex = 41
        Me.BtnNow.Text = "Show Time Now"
        Me.BtnNow.UseVisualStyleBackColor = True
        '
        'BtnTime
        '
        Me.BtnTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTime.Location = New System.Drawing.Point(278, 79)
        Me.BtnTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnTime.Name = "BtnTime"
        Me.BtnTime.Size = New System.Drawing.Size(178, 44)
        Me.BtnTime.TabIndex = 40
        Me.BtnTime.Text = "Show Time"
        Me.BtnTime.UseVisualStyleBackColor = True
        '
        'TimePickerTime
        '
        Me.TimePickerTime.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimePickerTime.Location = New System.Drawing.Point(37, 84)
        Me.TimePickerTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TimePickerTime.Name = "TimePickerTime"
        Me.TimePickerTime.Size = New System.Drawing.Size(228, 27)
        Me.TimePickerTime.TabIndex = 39
        '
        'BtnDate
        '
        Me.BtnDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDate.Location = New System.Drawing.Point(278, 31)
        Me.BtnDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDate.Name = "BtnDate"
        Me.BtnDate.Size = New System.Drawing.Size(178, 44)
        Me.BtnDate.TabIndex = 38
        Me.BtnDate.Text = "Show Date"
        Me.BtnDate.UseVisualStyleBackColor = True
        '
        'DatePickTanggalLahir
        '
        Me.DatePickTanggalLahir.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DatePickTanggalLahir.Location = New System.Drawing.Point(37, 37)
        Me.DatePickTanggalLahir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DatePickTanggalLahir.Name = "DatePickTanggalLahir"
        Me.DatePickTanggalLahir.Size = New System.Drawing.Size(228, 27)
        Me.DatePickTanggalLahir.TabIndex = 37
        '
        'BtnFormatOutput
        '
        Me.BtnFormatOutput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnFormatOutput.Location = New System.Drawing.Point(278, 127)
        Me.BtnFormatOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnFormatOutput.Name = "BtnFormatOutput"
        Me.BtnFormatOutput.Size = New System.Drawing.Size(178, 44)
        Me.BtnFormatOutput.TabIndex = 43
        Me.BtnFormatOutput.Text = "Format Output"
        Me.BtnFormatOutput.UseVisualStyleBackColor = True
        '
        'DatePickTanggalLahir1
        '
        Me.DatePickTanggalLahir1.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DatePickTanggalLahir1.Location = New System.Drawing.Point(37, 133)
        Me.DatePickTanggalLahir1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DatePickTanggalLahir1.Name = "DatePickTanggalLahir1"
        Me.DatePickTanggalLahir1.Size = New System.Drawing.Size(228, 27)
        Me.DatePickTanggalLahir1.TabIndex = 42
        '
        'BtnOpenCatatan
        '
        Me.BtnOpenCatatan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnOpenCatatan.Location = New System.Drawing.Point(481, 180)
        Me.BtnOpenCatatan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnOpenCatatan.Name = "BtnOpenCatatan"
        Me.BtnOpenCatatan.Size = New System.Drawing.Size(419, 44)
        Me.BtnOpenCatatan.TabIndex = 44
        Me.BtnOpenCatatan.Text = "Open Catatan"
        Me.BtnOpenCatatan.UseVisualStyleBackColor = True
        '
        'RTBoxCatatan
        '
        Me.RTBoxCatatan.Location = New System.Drawing.Point(481, 35)
        Me.RTBoxCatatan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RTBoxCatatan.Name = "RTBoxCatatan"
        Me.RTBoxCatatan.Size = New System.Drawing.Size(419, 132)
        Me.RTBoxCatatan.TabIndex = 45
        Me.RTBoxCatatan.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(37, 253)
        Me.PicFoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(419, 244)
        Me.PicFoto.TabIndex = 46
        Me.PicFoto.TabStop = False
        '
        'BtnOpenFoto
        '
        Me.BtnOpenFoto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnOpenFoto.Location = New System.Drawing.Point(37, 509)
        Me.BtnOpenFoto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnOpenFoto.Name = "BtnOpenFoto"
        Me.BtnOpenFoto.Size = New System.Drawing.Size(419, 80)
        Me.BtnOpenFoto.TabIndex = 47
        Me.BtnOpenFoto.Text = "Open Foto"
        Me.BtnOpenFoto.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'BtnChangeColor
        '
        Me.BtnChangeColor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnChangeColor.Location = New System.Drawing.Point(481, 253)
        Me.BtnChangeColor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnChangeColor.Name = "BtnChangeColor"
        Me.BtnChangeColor.Size = New System.Drawing.Size(200, 44)
        Me.BtnChangeColor.TabIndex = 48
        Me.BtnChangeColor.Text = "Change Color"
        Me.BtnChangeColor.UseVisualStyleBackColor = True
        '
        'LblColorChange
        '
        Me.LblColorChange.AutoSize = True
        Me.LblColorChange.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblColorChange.Location = New System.Drawing.Point(520, 301)
        Me.LblColorChange.Name = "LblColorChange"
        Me.LblColorChange.Size = New System.Drawing.Size(135, 37)
        Me.LblColorChange.TabIndex = 49
        Me.LblColorChange.Text = "Text Color"
        '
        'LblColorCode
        '
        Me.LblColorCode.AutoSize = True
        Me.LblColorCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblColorCode.Location = New System.Drawing.Point(533, 368)
        Me.LblColorCode.Name = "LblColorCode"
        Me.LblColorCode.Size = New System.Drawing.Size(111, 28)
        Me.LblColorCode.TabIndex = 50
        Me.LblColorCode.Text = "Color Code"
        '
        'TxtColorCode
        '
        Me.TxtColorCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtColorCode.Location = New System.Drawing.Point(481, 404)
        Me.TxtColorCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtColorCode.Name = "TxtColorCode"
        Me.TxtColorCode.Size = New System.Drawing.Size(199, 34)
        Me.TxtColorCode.TabIndex = 51
        '
        'PnlColorChange
        '
        Me.PnlColorChange.Location = New System.Drawing.Point(481, 456)
        Me.PnlColorChange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlColorChange.Name = "PnlColorChange"
        Me.PnlColorChange.Size = New System.Drawing.Size(200, 133)
        Me.PnlColorChange.TabIndex = 52
        '
        'BtnChangeGreen
        '
        Me.BtnChangeGreen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnChangeGreen.Location = New System.Drawing.Point(694, 256)
        Me.BtnChangeGreen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnChangeGreen.Name = "BtnChangeGreen"
        Me.BtnChangeGreen.Size = New System.Drawing.Size(207, 336)
        Me.BtnChangeGreen.TabIndex = 53
        Me.BtnChangeGreen.Text = "Change To Green"
        Me.BtnChangeGreen.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.Location = New System.Drawing.Point(924, 31)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(171, 561)
        Me.BtnBack.TabIndex = 54
        Me.BtnBack.Text = "Back To Pendaftaran"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Latihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 624)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnChangeGreen)
        Me.Controls.Add(Me.PnlColorChange)
        Me.Controls.Add(Me.TxtColorCode)
        Me.Controls.Add(Me.LblColorCode)
        Me.Controls.Add(Me.LblColorChange)
        Me.Controls.Add(Me.BtnChangeColor)
        Me.Controls.Add(Me.BtnOpenFoto)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.RTBoxCatatan)
        Me.Controls.Add(Me.BtnOpenCatatan)
        Me.Controls.Add(Me.BtnFormatOutput)
        Me.Controls.Add(Me.DatePickTanggalLahir1)
        Me.Controls.Add(Me.BtnNow)
        Me.Controls.Add(Me.BtnTime)
        Me.Controls.Add(Me.TimePickerTime)
        Me.Controls.Add(Me.BtnDate)
        Me.Controls.Add(Me.DatePickTanggalLahir)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Latihan"
        Me.Text = "Latihan"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNow As Button
    Friend WithEvents BtnTime As Button
    Friend WithEvents TimePickerTime As DateTimePicker
    Friend WithEvents BtnDate As Button
    Friend WithEvents DatePickTanggalLahir As DateTimePicker
    Friend WithEvents BtnFormatOutput As Button
    Friend WithEvents DatePickTanggalLahir1 As DateTimePicker
    Friend WithEvents BtnOpenCatatan As Button
    Friend WithEvents RTBoxCatatan As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents BtnOpenFoto As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents BtnChangeColor As Button
    Friend WithEvents LblColorChange As Label
    Friend WithEvents LblColorCode As Label
    Friend WithEvents TxtColorCode As TextBox
    Friend WithEvents PnlColorChange As Panel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BtnChangeGreen As Button
    Friend WithEvents BtnBack As Button
End Class
