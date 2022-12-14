Public Class variable

    ' type variable dan value nya
    Dim artists As Short = 2500
    Dim hours As UShort = 5000
    Dim population As Integer = 375000
    Dim seconds As UInteger = 3000000
    Dim bugs As Long = 7800000016
    Dim sandGrains As ULong = 1800000000000000000
    Dim unitCost As Single = 899.99
    Dim pi As Double = 3.1415926535
    Dim debt As Decimal = 7600300.5D
    Dim retKey As Byte = 13
    Dim negNum As SByte = -20
    Dim unicodeChar As Char = "A"c
    Dim greeting As String = "hello world"
    Dim flag As Boolean = True
    Dim birthday As Date = #3/17/1900#

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxExampleVariable.SelectedIndexChanged
        Dim tipeVariable As String = ListBoxExampleVariable.SelectedItem()

        'if operator

        If tipeVariable = "short" Then
            TxtVariableWithIf.Text = artists
        ElseIf tipeVariable = "Ushort" Then
            TxtVariableWithIf.Text = hours
        ElseIf tipeVariable = "Integer" Then
            TxtVariableWithIf.Text = population
        ElseIf tipeVariable = "UInteger" Then
            TxtVariableWithIf.Text = seconds
        ElseIf tipeVariable = "Long" Then
            TxtVariableWithIf.Text = bugs
        ElseIf tipeVariable = "ULong" Then
            TxtVariableWithIf.Text = sandGrains
        ElseIf tipeVariable = "Single" Then
            TxtVariableWithIf.Text = unitCost
        ElseIf tipeVariable = "Double" Then
            TxtVariableWithIf.Text = pi
        ElseIf tipeVariable = "Decimal" Then
            TxtVariableWithIf.Text = debt
        ElseIf tipeVariable = "Byte" Then
            TxtVariableWithIf.Text = retKey
        ElseIf tipeVariable = "SByte" Then
            TxtVariableWithIf.Text = negNum
        ElseIf tipeVariable = "Char" Then
            TxtVariableWithIf.Text = unicodeChar
        ElseIf tipeVariable = "String" Then
            TxtVariableWithIf.Text = greeting
        ElseIf tipeVariable = "Boolean" Then
            TxtVariableWithIf.Text = flag.ToString()
        ElseIf tipeVariable = "Date" Then
            TxtVariableWithIf.Text = birthday

        End If
    End Sub

    Private Sub BtnToString_Click(sender As Object, e As EventArgs) Handles BtnToString.Click
        Dim originInt As Integer = 12345
        Dim convertString As String
        convertString = originInt.ToString()
        TxtConvertedString.Text = convertString
    End Sub

    Private Sub BtnParseInt_Click(sender As Object, e As EventArgs) Handles BtnParseInt.Click
        Dim originString As String = "1234"
        Dim convertedInteger As Integer
        convertedInteger = Integer.Parse(originString)
        TxtConvertedInteger.Text = convertedInteger
    End Sub

    Private Sub BtnCInt_Click(sender As Object, e As EventArgs) Handles BtnCInt.Click
        Dim originDouble As Double = 3.1415926535
        Dim convertDbltoInt = CInt(originDouble)
        TxtConvInteger.Text = convertDbltoInt
    End Sub

    Private Sub ListBoxTipeVariableSwitch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTipeVariableSwitch.SelectedIndexChanged
        Dim tipeVariable As String = ListBoxTipeVariableSwitch.SelectedItem()

        Select Case tipeVariable
            Case "Short"
                TxtVariableWithSwitch.Text = artists
            Case "Ushort"
                TxtVariableWithSwitch.Text = hours
            Case "Integer"
                TxtVariableWithSwitch.Text = population
            Case "UInteger"
                TxtVariableWithSwitch.Text = seconds
            Case "Long"
                TxtVariableWithSwitch.Text = bugs
            Case "ULong"
                TxtVariableWithSwitch.Text = sandGrains
            Case "Single"
                TxtVariableWithSwitch.Text = unitCost
            Case "Double"
                TxtVariableWithSwitch.Text = pi
            Case "Decimal"
                TxtVariableWithSwitch.Text = debt
            Case "Byte"
                TxtVariableWithSwitch.Text = retKey
            Case "SByte"
                TxtVariableWithSwitch.Text = negNum
            Case "Char"
                TxtVariableWithSwitch.Text = unicodeChar
            Case "String"
                TxtVariableWithSwitch.Text = greeting
            Case "Boolean"
                TxtVariableWithSwitch.Text = flag.ToString()
            Case "Date"
                TxtVariableWithSwitch.Text = birthday
        End Select
    End Sub

    Private Sub BtnFor1_Click(sender As Object, e As EventArgs) Handles BtnFor1.Click
        ListBoxLoop.Items.Clear()
        Dim i As Integer
        For i = 0 To 20
            ListBoxLoop.Items.Add(i)
        Next
    End Sub

    Private Sub BtnFor2_Click(sender As Object, e As EventArgs) Handles BtnFor2.Click
        ListBoxLoop.Items.Clear()
        Dim i As Integer
        For i = 0 To 20 Step 5
            ListBoxLoop.Items.Add(i)
        Next
    End Sub

    Private Sub BtnDo1_Click(sender As Object, e As EventArgs) Handles BtnDo1.Click
        ListBoxLoop.Items.Clear()
        Dim i As Integer
        Do While i <= 20
            ListBoxLoop.Items.Add(i)
            i += 1
        Loop
    End Sub

    Private Sub BtnDo2_Click(sender As Object, e As EventArgs) Handles BtnDo2.Click
        ListBoxLoop.Items.Clear()
        Dim i As Integer
        Do
            ListBoxLoop.Items.Add(i)
            i += 5
        Loop While i <= 20
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtUmur.TextChanged


        If TxtUmur.Text.Length > 0 Then

            Dim umur As Integer = Integer.Parse(TxtUmur.Text)

            If umur <= 5 And umur >= 0 Then
                LblDenganIF.Text = "Balita"
            ElseIf umur <= 11 And umur >= 6 Then
                LblDenganIF.Text = "Anak-anak"
            ElseIf umur <= 16 And umur >= 12 Then
                LblDenganIF.Text = "Remaja Awal"
            ElseIf umur <= 25 And umur >= 17 Then
                LblDenganIF.Text = "Remaja Akhir"
            ElseIf umur <= 35 And umur >= 26 Then
                LblDenganIF.Text = "Dewasa Awal"
            ElseIf umur <= 45 And umur >= 36 Then
                LblDenganIF.Text = "Dewasa Akhir"
            ElseIf umur <= 55 And umur >= 46 Then
                LblDenganIF.Text = "Lansia Awal"
            ElseIf umur <= 65 And umur >= 56 Then
                LblDenganIF.Text = "Lansia Akhir"
            ElseIf umur > 65 Then
                LblDenganIF.Text = "Manula"
            End If

            Select Case umur
                Case 0 To 5
                    LblSwitch.Text = "Balita"
                Case 6 To 11
                    LblSwitch.Text = "Dewasa"
                Case 12 To 16
                    LblSwitch.Text = "Remaja Awal"
                Case 17 To 25
                    LblSwitch.Text = "Remaja Akhir"
                Case 26 To 35
                    LblSwitch.Text = "Dewasa Awal"
                Case 36 To 45
                    LblSwitch.Text = "Dewasa Akhir"
                Case 46 To 55
                    LblSwitch.Text = "Lansia Awal"
                Case 56 To 65
                    LblSwitch.Text = "Lansia Akhir"
                Case > 65
                    LblSwitch.Text = "Manula"
            End Select
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Integer = Txt1.Text
        Dim B As Integer = Txt2.Text

        hasil.Text = A ^ B
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim A As Integer = Txt1.Text
        Dim B As Integer = Txt2.Text

        hasil.Text = A + B
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim A As Integer = Txt1.Text
        Dim B As Integer = Txt2.Text

        hasil.Text = A * B
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A As Integer = Txt1.Text
        Dim B As Integer = Txt2.Text

        hasil.Text = A / B
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim A As Integer = Txt1.Text
        Dim B As Integer = Txt2.Text

        hasil.Text = A - B
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim A As Integer = Txt1.Text
        Dim B As Integer = Txt2.Text

        hasil.Text = A Mod B
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim A As Integer = Txt1.Text
        Dim B As Integer = Txt2.Text

        hasil.Text = A & B
    End Sub

    Private Sub ListBoxLoop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxLoop.SelectedIndexChanged

    End Sub
End Class