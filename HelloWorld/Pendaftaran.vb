Imports System.Configuration
Imports System.IO

Public Class Pendaftaran

    Dim layanan As New List(Of String) From {"Inap", "Poliklinik", "Spesialis"}

    Dim max_char_alamat As Integer = 50
    Dim max_char As Integer = 50

    Public Shared Kamar As Integer = 100

    Public Shared foto_pasien
    Public Shared nama
    Public Shared nik
    Public Shared jenis_kelamin As String
    Public Shared tanggal_lahir
    Public Shared alamat
    Public Shared layanan_value
    Public Shared catatan_dokter
    Public Shared keluhan_list As New List(Of String)
    'ini tugas kali
    Public Shared fungsiKamar As FungsiKamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'LabelsJumlahKamar.Text = Kamar.ToString()
        LblLimiter.Text = max_char
        'ComboBoxLayanan.DataSource = layanan


        fungsiKamar = New FungsiKamar()

        LabelsJumlahKamar.Text = fungsiKamar.GSJumlahKamar
        ComboBoxLayanan.DataSource = layanan

    End Sub
    Private Sub TambahKamar_Click(sender As Object, e As EventArgs) Handles TambahKamar.Click
        Dim tambah_kamar = New TambahKamar()
        tambah_kamar.Show()
    End Sub

    Private Sub BtnTampilkanKeluhan_Click(sender As Object, e As EventArgs)
        Dim tampilkan_keluhan = New Keluhan()
        tampilkan_keluhan.Show()
    End Sub

    Private Sub Pendaftaran_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        fungsiKamar.GSJumlahKamar = Kamar
        LabelsJumlahKamar.Text = fungsiKamar.GSJumlahKamar
    End Sub

    Private Sub TxtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNIK.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TxtNama_Leave(sender As Object, e As EventArgs) Handles TxtNama.Leave
        If TxtNama.Text.Length < 1 Then
            TxtNama.Select()
            MessageBox.Show("Please add At least 1 String")
        End If
    End Sub

    Private Sub RTBAlamat_TextChanged(sender As Object, e As EventArgs) Handles RTBAlamat.TextChanged
        If RTBAlamat.Text.Length <= max_char_alamat Then
            LblLimiter.Text = (max_char_alamat - RTBAlamat.Text.Length).ToString()
        End If
    End Sub

    Private Sub RTBAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTBAlamat.KeyPress
        If RTBAlamat.Text.Length = max_char_alamat Then
            MessageBox.Show("Max Length")
            e.Handled = True
        End If
    End Sub

    Private Sub RdLaki_CheckedChanged(sender As Object, e As EventArgs) Handles RdLaki.CheckedChanged
        jenis_kelamin = "Laki-Laki"
    End Sub

    Private Sub RdPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles RdPerempuan.CheckedChanged
        jenis_kelamin = "Perempuan"
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs)
        MessageBox.Show(jenis_kelamin)
    End Sub

    Private Sub BtnSetLaki_Click(sender As Object, e As EventArgs)
        RdLaki.Checked = True
    End Sub

    Private Sub BtnSetPerempuan_Click(sender As Object, e As EventArgs)
        RdPerempuan.Checked = True
    End Sub

    Private Sub TambahKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKamarToolStripMenuItem.Click
        Dim tambah_kamar = New TambahKamar()
        tambah_kamar.Show()
    End Sub

    Private Sub LatihanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim latihan = New Latihan()
        latihan.Show()
    End Sub

    Private Sub Pertemuan4CheckBoxListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pertemuan4CheckBoxListBoxToolStripMenuItem.Click
        Dim latihan4 = New Keluhan()
        latihan4.Show()
    End Sub

    Private Sub Pertemuan5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pertemuan5ToolStripMenuItem.Click
        Dim latihan5 = New Latihan()
        latihan5.Show()
    End Sub

    Private Sub BtnTambahFoto_Click(sender As Object, e As EventArgs) Handles BtnTambahFoto.Click
        OpenFileDialog2.Title = "Open Foto"
        OpenFileDialog2.Filter = "All Format|*.*|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|Image|*.bmp"
        OpenFileDialog2.ShowDialog()

        PicBoxFoto.Load(OpenFileDialog2.FileName)
        PicBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage

        'foto_pasien = PicBoxFoto.ImageLocation
        fungsiKamar.GSFotoPasien = PicBoxFoto.ImageLocation
    End Sub

    Private Sub BtnOpenCatatan_Click(sender As Object, e As EventArgs) Handles BtnOpenCatatan.Click
        Dim fileReader As System.IO.StreamReader
        OpenFileDialog1.InitialDirectory = "~\Documents"
        OpenFileDialog1.Title = "Buka Catatan Dokter"
        OpenFileDialog1.Filter = "Text File [*.txt]|*.txt|All Files [*.*]|*.*"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.OpenFile()
            fileReader = File.OpenText(OpenFileDialog1.FileName)
            RTBoxCatatan.Text = fileReader.ReadToEnd()
            fileReader.Close()
        End If
    End Sub

    Private Sub PasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasienToolStripMenuItem.Click
        Dim pasien = New Pasien()
        pasien.Show()
    End Sub

    Private Sub BtnTambahPasien_Click(sender As Object, e As EventArgs) Handles BtnTambahPasien.Click

        fungsiKamar.GSNama = TxtNama.Text.ToString()
        'nama = TxtNama.Text
        nama = fungsiKamar.GSNama

        fungsiKamar.GSNik = TxtNIK.Text
        nik = fungsiKamar.GSNik

        'tanggal_lahir = DatePickTanggalLahir.Value.ToShortDateString
        fungsiKamar.GSTanggalLahir = DatePickTanggalLahir.Value.ToShortDateString
        tanggal_lahir = fungsiKamar.GSTanggalLahir

        'alamat = RTBAlamat.Text
        fungsiKamar.GSAlamat = RTBAlamat.Text
        alamat = fungsiKamar.GSAlamat

        'layanan_value = ComboBoxLayanan.SelectedItem()
        fungsiKamar.GSLayananValue = ComboBoxLayanan.SelectedItem()
        layanan_value = fungsiKamar.GSLayananValue


        'catatan_dokter = RTBoxCatatan.Text
        fungsiKamar.GSCatatanDokter = RTBoxCatatan.Text
        catatan_dokter = fungsiKamar.GSCatatanDokter

        If ChkPusing.Checked() Then
            fungsiKamar.GSKeluhanList.Add("Pusing")
        End If

        If ChkMual.Checked() Then
            fungsiKamar.GSKeluhanList.Add("Mual")
        End If

        If ChkDemam.Checked() Then
            fungsiKamar.GSKeluhanList.Add("Demam")
        End If

        Kamar -= 1

        Dim pasien_form = New Pasien()
        Pasien.Show()
    End Sub

    Private Sub VariableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VariableToolStripMenuItem.Click
        Dim variable = New variable()
        variable.Show()
    End Sub

    Private Sub BthHitungBiaya_Click(sender As Object, e As EventArgs) Handles BthHitungBiaya.Click
        If TxtHariInap.Text.Length > 0 Then
            fungsiKamar.SHariInap = Integer.Parse(TxtHariInap.Text)
            Dim biaya As Integer = fungsiKamar.HitungBiaya()
            LblTotalBiaya.Text = biaya
        End If
    End Sub

    Private Sub TxtNIK_TextChanged(sender As Object, e As EventArgs) Handles TxtNIK.TextChanged

    End Sub

    Private Sub PicBoxFoto_Click(sender As Object, e As EventArgs) Handles PicBoxFoto.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBoxLayanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLayanan.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

