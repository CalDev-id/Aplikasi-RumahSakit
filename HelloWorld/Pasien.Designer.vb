<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pasien
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
        Me.PictBoxFoto = New System.Windows.Forms.PictureBox()
        Me.LblNameValue = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblCatatanDokterValue = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblAlamatValue = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblLayananValue = New System.Windows.Forms.Label()
        Me.ListBoxKeluhan = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblTanggalLahirValue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblJenisKelaminValue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNIKValue = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictBoxFoto
        '
        Me.PictBoxFoto.Location = New System.Drawing.Point(30, 23)
        Me.PictBoxFoto.Name = "PictBoxFoto"
        Me.PictBoxFoto.Size = New System.Drawing.Size(183, 196)
        Me.PictBoxFoto.TabIndex = 0
        Me.PictBoxFoto.TabStop = False
        '
        'LblNameValue
        '
        Me.LblNameValue.AutoSize = True
        Me.LblNameValue.BackColor = System.Drawing.Color.Transparent
        Me.LblNameValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNameValue.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNameValue.Location = New System.Drawing.Point(240, 23)
        Me.LblNameValue.Name = "LblNameValue"
        Me.LblNameValue.Size = New System.Drawing.Size(74, 30)
        Me.LblNameValue.TabIndex = 2
        Me.LblNameValue.Text = "Nama"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.LblCatatanDokterValue)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.LblAlamatValue)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.LblLayananValue)
        Me.Panel1.Controls.Add(Me.ListBoxKeluhan)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.LblTanggalLahirValue)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LblJenisKelaminValue)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(240, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(569, 243)
        Me.Panel1.TabIndex = 3
        '
        'LblCatatanDokterValue
        '
        Me.LblCatatanDokterValue.AutoSize = True
        Me.LblCatatanDokterValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblCatatanDokterValue.Location = New System.Drawing.Point(205, 442)
        Me.LblCatatanDokterValue.MaximumSize = New System.Drawing.Size(328, 0)
        Me.LblCatatanDokterValue.Name = "LblCatatanDokterValue"
        Me.LblCatatanDokterValue.Size = New System.Drawing.Size(158, 30)
        Me.LblCatatanDokterValue.TabIndex = 15
        Me.LblCatatanDokterValue.Text = "Catatan Dokter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(0, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(158, 30)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Catatan Dokter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(0, 252)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 30)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Keluhan :"
        '
        'LblAlamatValue
        '
        Me.LblAlamatValue.AutoSize = True
        Me.LblAlamatValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblAlamatValue.ForeColor = System.Drawing.SystemColors.Control
        Me.LblAlamatValue.Location = New System.Drawing.Point(205, 130)
        Me.LblAlamatValue.MaximumSize = New System.Drawing.Size(328, 0)
        Me.LblAlamatValue.Name = "LblAlamatValue"
        Me.LblAlamatValue.Size = New System.Drawing.Size(87, 30)
        Me.LblAlamatValue.TabIndex = 12
        Me.LblAlamatValue.Text = "Alamat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(0, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 30)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Alamat"
        '
        'LblLayananValue
        '
        Me.LblLayananValue.AutoSize = True
        Me.LblLayananValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblLayananValue.ForeColor = System.Drawing.SystemColors.Control
        Me.LblLayananValue.Location = New System.Drawing.Point(205, 85)
        Me.LblLayananValue.Name = "LblLayananValue"
        Me.LblLayananValue.Size = New System.Drawing.Size(98, 30)
        Me.LblLayananValue.TabIndex = 10
        Me.LblLayananValue.Text = "Layanan"
        '
        'ListBoxKeluhan
        '
        Me.ListBoxKeluhan.FormattingEnabled = True
        Me.ListBoxKeluhan.ItemHeight = 15
        Me.ListBoxKeluhan.Location = New System.Drawing.Point(0, 285)
        Me.ListBoxKeluhan.Name = "ListBoxKeluhan"
        Me.ListBoxKeluhan.Size = New System.Drawing.Size(549, 139)
        Me.ListBoxKeluhan.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(0, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 30)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Layanan"
        '
        'LblTanggalLahirValue
        '
        Me.LblTanggalLahirValue.AutoSize = True
        Me.LblTanggalLahirValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTanggalLahirValue.ForeColor = System.Drawing.SystemColors.Control
        Me.LblTanggalLahirValue.Location = New System.Drawing.Point(205, 42)
        Me.LblTanggalLahirValue.Name = "LblTanggalLahirValue"
        Me.LblTanggalLahirValue.Size = New System.Drawing.Size(152, 30)
        Me.LblTanggalLahirValue.TabIndex = 8
        Me.LblTanggalLahirValue.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(0, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 30)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tanggal Lahir"
        '
        'LblJenisKelaminValue
        '
        Me.LblJenisKelaminValue.AutoSize = True
        Me.LblJenisKelaminValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJenisKelaminValue.ForeColor = System.Drawing.SystemColors.Control
        Me.LblJenisKelaminValue.Location = New System.Drawing.Point(205, 0)
        Me.LblJenisKelaminValue.Name = "LblJenisKelaminValue"
        Me.LblJenisKelaminValue.Size = New System.Drawing.Size(153, 30)
        Me.LblJenisKelaminValue.TabIndex = 6
        Me.LblJenisKelaminValue.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(240, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NIK"
        '
        'LblNIKValue
        '
        Me.LblNIKValue.AutoSize = True
        Me.LblNIKValue.BackColor = System.Drawing.Color.Transparent
        Me.LblNIKValue.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblNIKValue.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNIKValue.Location = New System.Drawing.Point(444, 67)
        Me.LblNIKValue.Name = "LblNIKValue"
        Me.LblNIKValue.Size = New System.Drawing.Size(51, 30)
        Me.LblNIKValue.TabIndex = 5
        Me.LblNIKValue.Text = "NIK"
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnTutup.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTutup.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnTutup.Location = New System.Drawing.Point(691, 368)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(97, 38)
        Me.BtnTutup.TabIndex = 6
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vis_Heical_Chandra_2107411022.My.Resources.Resources._1282799
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(841, 446)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.LblNIKValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblNameValue)
        Me.Controls.Add(Me.PictBoxFoto)
        Me.Name = "Pasien"
        Me.Text = "Pasien"
        CType(Me.PictBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictBoxFoto As PictureBox
    Friend WithEvents LblNameValue As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBoxKeluhan As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblNIKValue As Label
    Friend WithEvents LblJenisKelaminValue As Label
    Friend WithEvents LblTanggalLahirValue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblAlamatValue As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblLayananValue As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnTutup As Button
    Friend WithEvents LblCatatanDokterValue As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
