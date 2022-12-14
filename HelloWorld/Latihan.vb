Imports System.IO

Public Class Latihan

    Dim colors As DialogResult

    Private Sub BtnDate_Click(sender As Object, e As EventArgs) Handles BtnDate.Click
        MessageBox.Show(DatePickTanggalLahir.Value.ToShortDateString)
    End Sub

    Private Sub BtnTime_Click(sender As Object, e As EventArgs) Handles BtnTime.Click
        MessageBox.Show(TimePickerTime.Value.ToShortTimeString)
    End Sub

    Private Sub BtnFormatOutput_Click(sender As Object, e As EventArgs) Handles BtnFormatOutput.Click
        MessageBox.Show(DatePickTanggalLahir1.Value.ToString("dd/MM/yyyy"))
    End Sub

    Private Sub BtnNow_Click(sender As Object, e As EventArgs) Handles BtnNow.Click
        Dim current_time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        MessageBox.Show(current_time)
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

    Private Sub BtnOpenFoto_Click(sender As Object, e As EventArgs) Handles BtnOpenFoto.Click
        OpenFileDialog2.Title = "Open Foto"
        OpenFileDialog2.Filter = "All Format|*.*|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif|Image|*.bmp"
        OpenFileDialog2.ShowDialog()

        PicFoto.Load(OpenFileDialog2.FileName)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub BtnChangeColor_Click(sender As Object, e As EventArgs) Handles BtnChangeColor.Click
        colors = ColorDialog1.ShowDialog()

        If colors = Windows.Forms.DialogResult.OK Then
            LblColorChange.ForeColor = ColorDialog1.Color
            LblColorCode.Text = ColorDialog1.Color.ToArgb
            TxtColorCode.Text = ColorDialog1.Color.ToArgb
            PnlColorChange.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub BtnChangeGreen_Click(sender As Object, e As EventArgs) Handles BtnChangeGreen.Click
        LblColorChange.ForeColor = Color.FromArgb("-16711808")
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub
End Class