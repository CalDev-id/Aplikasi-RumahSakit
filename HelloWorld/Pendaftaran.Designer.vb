<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pendaftaran
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
        Me.LblNama = New System.Windows.Forms.Label()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.LblNIK = New System.Windows.Forms.Label()
        Me.LblJenisKelamin = New System.Windows.Forms.Label()
        Me.TxtNIK = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnTambahPasien = New System.Windows.Forms.Button()
        Me.TambahKamar = New System.Windows.Forms.Button()
        Me.LblPNJ = New System.Windows.Forms.Label()
        Me.LblRumahSakit = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelsJumlahKamar = New System.Windows.Forms.Label()
        Me.RdLaki = New System.Windows.Forms.RadioButton()
        Me.RdPerempuan = New System.Windows.Forms.RadioButton()
        Me.LblAlamat = New System.Windows.Forms.Label()
        Me.RTBAlamat = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblLimiter = New System.Windows.Forms.Label()
        Me.DatePickTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MsinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LatihanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan4CheckBoxListBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pertemuan5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExerciseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendaftaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VariableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblTanggalLahir = New System.Windows.Forms.Label()
        Me.RTBoxCatatan = New System.Windows.Forms.RichTextBox()
        Me.BtnOpenCatatan = New System.Windows.Forms.Button()
        Me.LblCatatandDokter = New System.Windows.Forms.Label()
        Me.ComboBoxLayanan = New System.Windows.Forms.ComboBox()
        Me.LblLayanan = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkDemam = New System.Windows.Forms.CheckBox()
        Me.ChkMual = New System.Windows.Forms.CheckBox()
        Me.ChkPusing = New System.Windows.Forms.CheckBox()
        Me.LblKeluhan = New System.Windows.Forms.Label()
        Me.BtnTambahFoto = New System.Windows.Forms.Button()
        Me.PicBoxFoto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtHariInap = New System.Windows.Forms.TextBox()
        Me.BthHitungBiaya = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTotalBiaya = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNama
        '
        Me.LblNama.BackColor = System.Drawing.Color.Transparent
        Me.LblNama.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNama.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNama.Location = New System.Drawing.Point(251, 233)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(99, 33)
        Me.LblNama.TabIndex = 0
        Me.LblNama.Text = "Nama"
        '
        'PnlLogo
        '
        Me.PnlLogo.BackColor = System.Drawing.Color.Transparent
        Me.PnlLogo.BackgroundImage = Global.Vis_Heical_Chandra_2107411022.My.Resources.Resources.Logo_PNJ_Politeknik_Negeri_Jakarta_Terbaru_PNG
        Me.PnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PnlLogo.Location = New System.Drawing.Point(37, 47)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(99, 100)
        Me.PnlLogo.TabIndex = 1
        '
        'LblNIK
        '
        Me.LblNIK.BackColor = System.Drawing.Color.Transparent
        Me.LblNIK.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNIK.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNIK.Location = New System.Drawing.Point(251, 188)
        Me.LblNIK.Name = "LblNIK"
        Me.LblNIK.Size = New System.Drawing.Size(99, 31)
        Me.LblNIK.TabIndex = 2
        Me.LblNIK.Text = "NIK"
        '
        'LblJenisKelamin
        '
        Me.LblJenisKelamin.BackColor = System.Drawing.Color.Transparent
        Me.LblJenisKelamin.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJenisKelamin.ForeColor = System.Drawing.SystemColors.Control
        Me.LblJenisKelamin.Location = New System.Drawing.Point(251, 276)
        Me.LblJenisKelamin.Name = "LblJenisKelamin"
        Me.LblJenisKelamin.Size = New System.Drawing.Size(145, 46)
        Me.LblJenisKelamin.TabIndex = 3
        Me.LblJenisKelamin.Text = "Jenis Kelamin"
        '
        'TxtNIK
        '
        Me.TxtNIK.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNIK.Location = New System.Drawing.Point(414, 185)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(363, 36)
        Me.TxtNIK.TabIndex = 4
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNama.Location = New System.Drawing.Point(414, 230)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(363, 36)
        Me.TxtNama.TabIndex = 5
        '
        'BtnTambahPasien
        '
        Me.BtnTambahPasien.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnTambahPasien.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahPasien.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnTambahPasien.Location = New System.Drawing.Point(1006, 694)
        Me.BtnTambahPasien.Name = "BtnTambahPasien"
        Me.BtnTambahPasien.Size = New System.Drawing.Size(201, 41)
        Me.BtnTambahPasien.TabIndex = 6
        Me.BtnTambahPasien.Text = "Tambah Pasien"
        Me.BtnTambahPasien.UseVisualStyleBackColor = False
        '
        'TambahKamar
        '
        Me.TambahKamar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TambahKamar.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TambahKamar.ForeColor = System.Drawing.SystemColors.Control
        Me.TambahKamar.Location = New System.Drawing.Point(575, 93)
        Me.TambahKamar.Name = "TambahKamar"
        Me.TambahKamar.Size = New System.Drawing.Size(201, 41)
        Me.TambahKamar.TabIndex = 7
        Me.TambahKamar.Text = "Tambah Kamar"
        Me.TambahKamar.UseVisualStyleBackColor = False
        '
        'LblPNJ
        '
        Me.LblPNJ.BackColor = System.Drawing.Color.Transparent
        Me.LblPNJ.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblPNJ.ForeColor = System.Drawing.SystemColors.Control
        Me.LblPNJ.Location = New System.Drawing.Point(152, 99)
        Me.LblPNJ.Name = "LblPNJ"
        Me.LblPNJ.Size = New System.Drawing.Size(453, 54)
        Me.LblPNJ.TabIndex = 8
        Me.LblPNJ.Text = "Politeknik Negeri Jakarta"
        '
        'LblRumahSakit
        '
        Me.LblRumahSakit.BackColor = System.Drawing.Color.Transparent
        Me.LblRumahSakit.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblRumahSakit.ForeColor = System.Drawing.SystemColors.Control
        Me.LblRumahSakit.Location = New System.Drawing.Point(152, 53)
        Me.LblRumahSakit.Name = "LblRumahSakit"
        Me.LblRumahSakit.Size = New System.Drawing.Size(392, 46)
        Me.LblRumahSakit.TabIndex = 9
        Me.LblRumahSakit.Text = "Rumah Sehat"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(575, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Jumlah Kamar :"
        '
        'LabelsJumlahKamar
        '
        Me.LabelsJumlahKamar.BackColor = System.Drawing.Color.Transparent
        Me.LabelsJumlahKamar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelsJumlahKamar.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelsJumlahKamar.Location = New System.Drawing.Point(726, 59)
        Me.LabelsJumlahKamar.Name = "LabelsJumlahKamar"
        Me.LabelsJumlahKamar.Size = New System.Drawing.Size(50, 31)
        Me.LabelsJumlahKamar.TabIndex = 13
        Me.LabelsJumlahKamar.Text = "100"
        '
        'RdLaki
        '
        Me.RdLaki.AutoSize = True
        Me.RdLaki.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdLaki.Location = New System.Drawing.Point(15, 22)
        Me.RdLaki.Name = "RdLaki"
        Me.RdLaki.Size = New System.Drawing.Size(104, 29)
        Me.RdLaki.TabIndex = 10
        Me.RdLaki.TabStop = True
        Me.RdLaki.Text = "Laki-Laki"
        Me.RdLaki.UseVisualStyleBackColor = True
        '
        'RdPerempuan
        '
        Me.RdPerempuan.AutoSize = True
        Me.RdPerempuan.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdPerempuan.Location = New System.Drawing.Point(15, 57)
        Me.RdPerempuan.Name = "RdPerempuan"
        Me.RdPerempuan.Size = New System.Drawing.Size(126, 29)
        Me.RdPerempuan.TabIndex = 11
        Me.RdPerempuan.TabStop = True
        Me.RdPerempuan.Text = "Perempuan"
        Me.RdPerempuan.UseVisualStyleBackColor = True
        '
        'LblAlamat
        '
        Me.LblAlamat.BackColor = System.Drawing.Color.Transparent
        Me.LblAlamat.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblAlamat.ForeColor = System.Drawing.SystemColors.Control
        Me.LblAlamat.Location = New System.Drawing.Point(251, 430)
        Me.LblAlamat.Name = "LblAlamat"
        Me.LblAlamat.Size = New System.Drawing.Size(99, 33)
        Me.LblAlamat.TabIndex = 14
        Me.LblAlamat.Text = "Alamat"
        '
        'RTBAlamat
        '
        Me.RTBAlamat.Location = New System.Drawing.Point(415, 427)
        Me.RTBAlamat.Name = "RTBAlamat"
        Me.RTBAlamat.Size = New System.Drawing.Size(362, 135)
        Me.RTBAlamat.TabIndex = 15
        Me.RTBAlamat.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdPerempuan)
        Me.GroupBox1.Controls.Add(Me.RdLaki)
        Me.GroupBox1.Location = New System.Drawing.Point(415, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 102)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'LblLimiter
        '
        Me.LblLimiter.BackColor = System.Drawing.Color.Transparent
        Me.LblLimiter.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblLimiter.ForeColor = System.Drawing.SystemColors.Control
        Me.LblLimiter.Location = New System.Drawing.Point(781, 540)
        Me.LblLimiter.Name = "LblLimiter"
        Me.LblLimiter.Size = New System.Drawing.Size(41, 31)
        Me.LblLimiter.TabIndex = 20
        Me.LblLimiter.Text = "50"
        '
        'DatePickTanggalLahir
        '
        Me.DatePickTanggalLahir.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DatePickTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePickTanggalLahir.Location = New System.Drawing.Point(415, 390)
        Me.DatePickTanggalLahir.Name = "DatePickTanggalLahir"
        Me.DatePickTanggalLahir.Size = New System.Drawing.Size(362, 23)
        Me.DatePickTanggalLahir.TabIndex = 32
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsinToolStripMenuItem, Me.KamarToolStripMenuItem, Me.LatihanToolStripMenuItem1, Me.ExerciseToolStripMenuItem, Me.VariableToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1240, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MsinToolStripMenuItem
        '
        Me.MsinToolStripMenuItem.Name = "MsinToolStripMenuItem"
        Me.MsinToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MsinToolStripMenuItem.Text = "Main"
        '
        'KamarToolStripMenuItem
        '
        Me.KamarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKamarToolStripMenuItem})
        Me.KamarToolStripMenuItem.Name = "KamarToolStripMenuItem"
        Me.KamarToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.KamarToolStripMenuItem.Text = "Kamar"
        '
        'TambahKamarToolStripMenuItem
        '
        Me.TambahKamarToolStripMenuItem.Name = "TambahKamarToolStripMenuItem"
        Me.TambahKamarToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.TambahKamarToolStripMenuItem.Text = "Tambah Kamar"
        '
        'LatihanToolStripMenuItem1
        '
        Me.LatihanToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pertemuan4CheckBoxListBoxToolStripMenuItem, Me.Pertemuan5ToolStripMenuItem})
        Me.LatihanToolStripMenuItem1.Name = "LatihanToolStripMenuItem1"
        Me.LatihanToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.LatihanToolStripMenuItem1.Text = "Latihan"
        '
        'Pertemuan4CheckBoxListBoxToolStripMenuItem
        '
        Me.Pertemuan4CheckBoxListBoxToolStripMenuItem.Name = "Pertemuan4CheckBoxListBoxToolStripMenuItem"
        Me.Pertemuan4CheckBoxListBoxToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.Pertemuan4CheckBoxListBoxToolStripMenuItem.Text = "Pertemuan 4 - CheckBox_ListBox"
        '
        'Pertemuan5ToolStripMenuItem
        '
        Me.Pertemuan5ToolStripMenuItem.Name = "Pertemuan5ToolStripMenuItem"
        Me.Pertemuan5ToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.Pertemuan5ToolStripMenuItem.Text = "Pertemuan 5 - Date Time Picker & Picture Box"
        '
        'ExerciseToolStripMenuItem
        '
        Me.ExerciseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendaftaranToolStripMenuItem, Me.PasienToolStripMenuItem})
        Me.ExerciseToolStripMenuItem.Name = "ExerciseToolStripMenuItem"
        Me.ExerciseToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ExerciseToolStripMenuItem.Text = "Exercise"
        '
        'PendaftaranToolStripMenuItem
        '
        Me.PendaftaranToolStripMenuItem.Name = "PendaftaranToolStripMenuItem"
        Me.PendaftaranToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PendaftaranToolStripMenuItem.Text = "Pendaftaran"
        '
        'PasienToolStripMenuItem
        '
        Me.PasienToolStripMenuItem.Name = "PasienToolStripMenuItem"
        Me.PasienToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PasienToolStripMenuItem.Text = "Pasien"
        '
        'VariableToolStripMenuItem
        '
        Me.VariableToolStripMenuItem.Name = "VariableToolStripMenuItem"
        Me.VariableToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.VariableToolStripMenuItem.Text = "variable"
        '
        'LblTanggalLahir
        '
        Me.LblTanggalLahir.BackColor = System.Drawing.Color.Transparent
        Me.LblTanggalLahir.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTanggalLahir.ForeColor = System.Drawing.SystemColors.Control
        Me.LblTanggalLahir.Location = New System.Drawing.Point(251, 384)
        Me.LblTanggalLahir.Name = "LblTanggalLahir"
        Me.LblTanggalLahir.Size = New System.Drawing.Size(145, 33)
        Me.LblTanggalLahir.TabIndex = 38
        Me.LblTanggalLahir.Text = "Tanggal Lahir"
        '
        'RTBoxCatatan
        '
        Me.RTBoxCatatan.Location = New System.Drawing.Point(813, 221)
        Me.RTBoxCatatan.Name = "RTBoxCatatan"
        Me.RTBoxCatatan.Size = New System.Drawing.Size(394, 139)
        Me.RTBoxCatatan.TabIndex = 39
        Me.RTBoxCatatan.Text = ""
        '
        'BtnOpenCatatan
        '
        Me.BtnOpenCatatan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnOpenCatatan.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnOpenCatatan.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnOpenCatatan.Location = New System.Drawing.Point(1067, 366)
        Me.BtnOpenCatatan.Name = "BtnOpenCatatan"
        Me.BtnOpenCatatan.Size = New System.Drawing.Size(140, 41)
        Me.BtnOpenCatatan.TabIndex = 40
        Me.BtnOpenCatatan.Text = "Buka File"
        Me.BtnOpenCatatan.UseVisualStyleBackColor = False
        '
        'LblCatatandDokter
        '
        Me.LblCatatandDokter.BackColor = System.Drawing.Color.Transparent
        Me.LblCatatandDokter.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblCatatandDokter.ForeColor = System.Drawing.SystemColors.Control
        Me.LblCatatandDokter.Location = New System.Drawing.Point(813, 187)
        Me.LblCatatandDokter.Name = "LblCatatandDokter"
        Me.LblCatatandDokter.Size = New System.Drawing.Size(176, 31)
        Me.LblCatatandDokter.TabIndex = 41
        Me.LblCatatandDokter.Text = "Catatan Dokter"
        '
        'ComboBoxLayanan
        '
        Me.ComboBoxLayanan.FormattingEnabled = True
        Me.ComboBoxLayanan.Location = New System.Drawing.Point(414, 573)
        Me.ComboBoxLayanan.Name = "ComboBoxLayanan"
        Me.ComboBoxLayanan.Size = New System.Drawing.Size(362, 23)
        Me.ComboBoxLayanan.TabIndex = 43
        '
        'LblLayanan
        '
        Me.LblLayanan.BackColor = System.Drawing.Color.Transparent
        Me.LblLayanan.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblLayanan.ForeColor = System.Drawing.SystemColors.Control
        Me.LblLayanan.Location = New System.Drawing.Point(251, 567)
        Me.LblLayanan.Name = "LblLayanan"
        Me.LblLayanan.Size = New System.Drawing.Size(99, 33)
        Me.LblLayanan.TabIndex = 44
        Me.LblLayanan.Text = "Layanan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkDemam)
        Me.GroupBox2.Controls.Add(Me.ChkMual)
        Me.GroupBox2.Controls.Add(Me.ChkPusing)
        Me.GroupBox2.Location = New System.Drawing.Point(415, 604)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 131)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Keluhan"
        '
        'ChkDemam
        '
        Me.ChkDemam.AutoSize = True
        Me.ChkDemam.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkDemam.Location = New System.Drawing.Point(17, 91)
        Me.ChkDemam.Name = "ChkDemam"
        Me.ChkDemam.Size = New System.Drawing.Size(96, 29)
        Me.ChkDemam.TabIndex = 48
        Me.ChkDemam.Text = "Demam"
        Me.ChkDemam.UseVisualStyleBackColor = True
        '
        'ChkMual
        '
        Me.ChkMual.AutoSize = True
        Me.ChkMual.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkMual.Location = New System.Drawing.Point(17, 56)
        Me.ChkMual.Name = "ChkMual"
        Me.ChkMual.Size = New System.Drawing.Size(74, 29)
        Me.ChkMual.TabIndex = 47
        Me.ChkMual.Text = "Mual"
        Me.ChkMual.UseVisualStyleBackColor = True
        '
        'ChkPusing
        '
        Me.ChkPusing.AutoSize = True
        Me.ChkPusing.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChkPusing.Location = New System.Drawing.Point(17, 21)
        Me.ChkPusing.Name = "ChkPusing"
        Me.ChkPusing.Size = New System.Drawing.Size(88, 29)
        Me.ChkPusing.TabIndex = 46
        Me.ChkPusing.Text = "Pusing"
        Me.ChkPusing.UseVisualStyleBackColor = True
        '
        'LblKeluhan
        '
        Me.LblKeluhan.BackColor = System.Drawing.Color.Transparent
        Me.LblKeluhan.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblKeluhan.ForeColor = System.Drawing.SystemColors.Control
        Me.LblKeluhan.Location = New System.Drawing.Point(251, 613)
        Me.LblKeluhan.Name = "LblKeluhan"
        Me.LblKeluhan.Size = New System.Drawing.Size(99, 33)
        Me.LblKeluhan.TabIndex = 45
        Me.LblKeluhan.Text = "Keluhan"
        '
        'BtnTambahFoto
        '
        Me.BtnTambahFoto.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnTambahFoto.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahFoto.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnTambahFoto.Location = New System.Drawing.Point(32, 422)
        Me.BtnTambahFoto.Name = "BtnTambahFoto"
        Me.BtnTambahFoto.Size = New System.Drawing.Size(180, 41)
        Me.BtnTambahFoto.TabIndex = 46
        Me.BtnTambahFoto.Text = "Tambah Foto"
        Me.BtnTambahFoto.UseVisualStyleBackColor = False
        '
        'PicBoxFoto
        '
        Me.PicBoxFoto.Location = New System.Drawing.Point(32, 188)
        Me.PicBoxFoto.Name = "PicBoxFoto"
        Me.PicBoxFoto.Size = New System.Drawing.Size(180, 229)
        Me.PicBoxFoto.TabIndex = 47
        Me.PicBoxFoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(813, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 31)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Hari Inap"
        '
        'TxtHariInap
        '
        Me.TxtHariInap.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtHariInap.Location = New System.Drawing.Point(907, 54)
        Me.TxtHariInap.Name = "TxtHariInap"
        Me.TxtHariInap.Size = New System.Drawing.Size(145, 36)
        Me.TxtHariInap.TabIndex = 49
        '
        'BthHitungBiaya
        '
        Me.BthHitungBiaya.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BthHitungBiaya.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BthHitungBiaya.ForeColor = System.Drawing.SystemColors.Control
        Me.BthHitungBiaya.Location = New System.Drawing.Point(1067, 52)
        Me.BthHitungBiaya.Name = "BthHitungBiaya"
        Me.BthHitungBiaya.Size = New System.Drawing.Size(96, 38)
        Me.BthHitungBiaya.TabIndex = 50
        Me.BthHitungBiaya.Text = "Hitung"
        Me.BthHitungBiaya.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(813, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 31)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Total Biaya : "
        '
        'LblTotalBiaya
        '
        Me.LblTotalBiaya.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalBiaya.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTotalBiaya.ForeColor = System.Drawing.SystemColors.Control
        Me.LblTotalBiaya.Location = New System.Drawing.Point(939, 111)
        Me.LblTotalBiaya.Name = "LblTotalBiaya"
        Me.LblTotalBiaya.Size = New System.Drawing.Size(213, 31)
        Me.LblTotalBiaya.TabIndex = 52
        Me.LblTotalBiaya.Text = "100.000"
        '
        'Pendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vis_Heical_Chandra_2107411022.My.Resources.Resources._1282799
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1240, 761)
        Me.Controls.Add(Me.LblTotalBiaya)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BthHitungBiaya)
        Me.Controls.Add(Me.TxtHariInap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblRumahSakit)
        Me.Controls.Add(Me.PicBoxFoto)
        Me.Controls.Add(Me.BtnTambahFoto)
        Me.Controls.Add(Me.LblKeluhan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblLayanan)
        Me.Controls.Add(Me.ComboBoxLayanan)
        Me.Controls.Add(Me.LblCatatandDokter)
        Me.Controls.Add(Me.BtnOpenCatatan)
        Me.Controls.Add(Me.RTBoxCatatan)
        Me.Controls.Add(Me.LblTanggalLahir)
        Me.Controls.Add(Me.DatePickTanggalLahir)
        Me.Controls.Add(Me.LblLimiter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RTBAlamat)
        Me.Controls.Add(Me.LblAlamat)
        Me.Controls.Add(Me.LabelsJumlahKamar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TambahKamar)
        Me.Controls.Add(Me.BtnTambahPasien)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtNIK)
        Me.Controls.Add(Me.LblJenisKelamin)
        Me.Controls.Add(Me.LblNIK)
        Me.Controls.Add(Me.PnlLogo)
        Me.Controls.Add(Me.LblNama)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LblPNJ)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pendaftaran"
        Me.Text = "Pendaftaran"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PicBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNama As Label
    Friend WithEvents PnlLogo As Panel
    Friend WithEvents LblNIK As Label
    Friend WithEvents LblJenisKelamin As Label
    Friend WithEvents TxtNIK As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents BtnTambahPasien As Button
    Friend WithEvents TambahKamar As Button
    Friend WithEvents LblPNJ As Label
    Friend WithEvents LblRumahSakit As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelsJumlahKamar As Label
    Friend WithEvents RdLaki As RadioButton
    Friend WithEvents RdPerempuan As RadioButton
    Friend WithEvents LblAlamat As Label
    Friend WithEvents RTBAlamat As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblLimiter As Label
    Friend WithEvents DatePickTanggalLahir As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblTanggalLahir As Label
    Friend WithEvents RTBoxCatatan As RichTextBox
    Friend WithEvents BtnOpenCatatan As Button
    Friend WithEvents LblCatatandDokter As Label
    Friend WithEvents LatihanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Pertemuan4CheckBoxListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pertemuan5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MsinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBoxLayanan As ComboBox
    Friend WithEvents LblLayanan As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChkDemam As CheckBox
    Friend WithEvents ChkMual As CheckBox
    Friend WithEvents ChkPusing As CheckBox
    Friend WithEvents LblKeluhan As Label
    Friend WithEvents BtnTambahFoto As Button
    Friend WithEvents PicBoxFoto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents ExerciseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendaftaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VariableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtHariInap As TextBox
    Friend WithEvents BthHitungBiaya As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTotalBiaya As Label
End Class
