Public Class TambahKamar
    'Private fungsiKamar As FungsiKamar
    Public TotalAddKamar As Integer = 0


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JumlahKamar.Text = Pendaftaran.Kamar.ToString()

        'fungsiKamar = New FungsiKamar()
        JumlahKamar.Text = Pendaftaran.fungsiKamar.GSJumlahKamar
        TxtValueKamar.Text = TotalAddKamar
        'LblKamarTersedia.Text = Pendaftaran.fungsiKamar.GSJumlahKamar
        If TotalAddKamar < 1 Then
            BtnRemove1Kamar.Enabled = False
        End If
    End Sub

    Private Sub BtnRemove1Kamar_Click(sender As Object, e As EventArgs) Handles BtnRemove1Kamar.Click
        TotalAddKamar = TotalAddKamar - 1
        TxtValueKamar.Text = TotalAddKamar

        If TotalAddKamar < 1 Then
            BtnRemove1Kamar.Enabled = False
        End If
    End Sub

    Private Sub BtnAdd1Kamar_Click(sender As Object, e As EventArgs) Handles BtnAdd1Kamar.Click
        TotalAddKamar = TotalAddKamar + 1
        TxtValueKamar.Text = TotalAddKamar

        If TotalAddKamar >= 1 Then
            BtnRemove1Kamar.Enabled = True
        End If
    End Sub

    Private Sub BtnTambahKamar_Click(sender As Object, e As EventArgs) Handles BtnTambahKamar.Click
        'Pendaftaran.Kamar += Integer.Parse(TxtValueKamar.Text)
        Pendaftaran.Kamar = Pendaftaran.fungsiKamar.TambahKamar(TotalAddKamar)
        'Pendaftaran.fungsiKamar.TambahKamar(Integer.Parse(TxtValueKamar.Text))
        Me.Close()
    End Sub

End Class