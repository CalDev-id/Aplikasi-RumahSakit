Public Class FungsiKamar
    Private tarifInap As Integer = 10000
    Private jumlahKamar As Integer
    Private hariInap As Integer

    'tugas
    Private foto_pasien As String
    Private nama As String
    Private nik As String
    Private jenis_kelamin As String
    Private tanggal_lahir As String
    Private alamat As String
    Private layanan_value As String
    Private catatan_dokter As String
    Private keluhan_list As New List(Of String)



    Public Property GSNama() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property

    Public Property GSFotoPasien() As String
        Get
            Return foto_pasien
        End Get
        Set(ByVal value As String)
            foto_pasien = value
        End Set
    End Property

    Public Property GSNik() As String
        Get
            Return nik
        End Get
        Set(ByVal value As String)
            nik = value
        End Set
    End Property

    Public Property GSJenisKelamin() As Integer
        Get
            Return jenis_kelamin
        End Get
        Set(ByVal value As Integer)
            jenis_kelamin = value
        End Set
    End Property

    Public Property GSTanggalLahir() As String
        Get
            Return tanggal_lahir
        End Get
        Set(ByVal value As String)
            tanggal_lahir = value
        End Set
    End Property

    Public Property GSAlamat() As String
        Get
            Return alamat
        End Get
        Set(ByVal value As String)
            alamat = value
        End Set
    End Property

    Public Property GSLayananValue()
        Get
            Return layanan_value
        End Get
        Set(ByVal value)
            layanan_value = value
        End Set
    End Property

    Public Property GSCatatanDokter()
        Get
            Return catatan_dokter
        End Get
        Set(ByVal value)
            catatan_dokter = value
        End Set
    End Property

    Public Property GSKeluhanList()
        Get
            Return keluhan_list
        End Get
        Set(ByVal value)
            keluhan_list = value
        End Set
    End Property

    'batas

    Public Property GSTarifInap() As Integer
        Get
            Return tarifInap
        End Get
        Set(value As Integer)
            tarifInap = value
        End Set
    End Property

    Public Property GSJumlahKamar() As String
        Get
            Return jumlahKamar
        End Get
        Set(value As String)
            jumlahKamar = value
        End Set
    End Property

    Public WriteOnly Property SHariInap() As Integer
        Set(ByVal value As Integer)
            hariInap = value
        End Set
    End Property

    Public Function HitungBiaya() As Integer
        Return hariInap * tarifInap
    End Function

    Public Function KurangiKamar(requestKamar As Integer) As Integer
        jumlahKamar = jumlahKamar - requestKamar
        Return jumlahKamar
    End Function

    Public Function TambahKamar(requestKamar As Integer) As Integer
        jumlahKamar = jumlahKamar + requestKamar
        Return jumlahKamar
    End Function

End Class
