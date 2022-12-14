Public Class Pasien

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If Not String.IsNullOrEmpty(Pendaftaran.fungsiKamar.GSFotoPasien) Then
            PictBoxFoto.Load(Pendaftaran.fungsiKamar.GSFotoPasien)
            PictBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNameValue.Text = Pendaftaran.nama
        LblNIKValue.Text = Pendaftaran.nik
        LblJenisKelaminValue.Text = Pendaftaran.jenis_kelamin
        LblTanggalLahirValue.Text = Pendaftaran.tanggal_lahir
        LblLayananValue.Text = Pendaftaran.layanan_value
        LblAlamatValue.Text = Pendaftaran.alamat

        ListBoxKeluhan.Items.Clear()
        For Each kel In Pendaftaran.fungsiKamar.GSKeluhanList
            'For Each kel In Pendaftaran.keluhan_list
            ListBoxKeluhan.Items.Add(kel)
        Next

        'Pendaftaran.fungsiKamar.GSKeluhanList.clear()
        LblCatatanDokterValue.Text = Pendaftaran.catatan_dokter
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub LblNIKValue_Click(sender As Object, e As EventArgs) Handles LblNIKValue.Click

    End Sub

    Private Sub LblTanggalLahirValue_Click(sender As Object, e As EventArgs) Handles LblTanggalLahirValue.Click

    End Sub

    Private Sub PictBoxFoto_Click(sender As Object, e As EventArgs) Handles PictBoxFoto.Click

    End Sub
End Class