Public Class Keluhan

    Dim keluhan As String = ""
    Dim keluhan_arrlist As New List(Of String)
    Dim keluhan_arrlist_id As New List(Of String)

    Dim layanan As New List(Of String) From {"Inap", "Poliklinik", "Spesialis"}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxLayanan.DataSource = layanan
    End Sub

    Private Sub BtnOutput_Click(sender As Object, e As EventArgs) Handles BtnOutput.Click
        If ChkPusing.Checked() Then
            keluhan_arrlist.Add("Pusing")
        End If

        If ChkMual.Checked() Then
            keluhan_arrlist.Add("Mual")
        End If

        If ChkDemam.Checked() Then
            keluhan_arrlist.Add("Demam")
        End If

        Dim keluhan_str = String.Join(", ", keluhan_arrlist.ToArray)
        MessageBox.Show(keluhan_str)

        keluhan_arrlist.Clear()
    End Sub

    Private Sub BtnTransfer1_Click(sender As Object, e As EventArgs) Handles BtnTransfer1.Click
        ListBoxKeluhan.Items.Clear()

        If ChkPusing.Checked() Then
            keluhan_arrlist.Add("Pusing")
        End If

        If ChkMual.Checked() Then
            keluhan_arrlist.Add("Mual")
        End If

        If ChkDemam.Checked() Then
            keluhan_arrlist.Add("Demam")
        End If

        For Each kel In keluhan_arrlist
            ListBoxKeluhan.Items.Add(kel)
        Next

        keluhan_arrlist.Clear()
    End Sub

    Private Sub BtnTransferListCheck_Click(sender As Object, e As EventArgs) Handles BtnTransferListCheck.Click
        CheckedListBoxKeluhan.Items.Clear()

        If ChkPusing.Checked() Then
            keluhan_arrlist.Add("Pusing")
        End If

        If ChkMual.Checked() Then
            keluhan_arrlist.Add("Mual")
        End If

        If ChkDemam.Checked() Then
            keluhan_arrlist.Add("Demam")
        End If

        For Each kel In keluhan_arrlist
            CheckedListBoxKeluhan.Items.Add(kel)
        Next

        keluhan_arrlist.Clear()
    End Sub

    Private Sub BtnAddItemListBox_Click(sender As Object, e As EventArgs) Handles BtnAddItemListBox.Click
        Dim add_item = TxtAddItem.Text
        ListBoxKeluhanAdd.Items.Add(add_item)
    End Sub

    Private Sub BtnRemoveItemListBox_Click(sender As Object, e As EventArgs) Handles BtnRemoveItemListBox.Click
        Dim remove_item = ListBoxKeluhanAdd.SelectedItem()
        ListBoxKeluhanAdd.Items.Remove(remove_item)
    End Sub

    Private Sub BtnSelectedItem_Click(sender As Object, e As EventArgs) Handles BtnSelectedItem.Click
        MessageBox.Show(ListBoxKeluhanSelect.SelectedItem())
    End Sub

    Private Sub BtnCheckedListBox_Click(sender As Object, e As EventArgs) Handles BtnCheckedListBox.Click
        For i = 0 To ListBoxKeluhanChecked.Items.Count - 1
            Dim Item As Object = ListBoxKeluhanChecked.Items(i)

            If ListBoxKeluhanChecked.GetItemChecked(i) Then
                keluhan_arrlist.Add(ListBoxKeluhanChecked.Items(i))
            End If
        Next

        Dim keluhan_str = String.Join(", ", keluhan_arrlist.ToArray)
        MessageBox.Show(keluhan_str)

        keluhan_arrlist.Clear()
    End Sub

    Private Sub Keluhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnTransferSelected_Click(sender As Object, e As EventArgs) Handles BtnTransferSelected.Click
        ' Unchecked All Item, (Reset Selected Item)

        For i As Integer = 0 To CheckedListBoxChckd.Items.Count - 1
            CheckedListBoxChckd.SetItemChecked(i, False)
        Next

        ' Check Item

        If ChkPusing.Checked() Then
            keluhan_arrlist_id.Add(0)
        End If

        If ChkMual.Checked() Then
            keluhan_arrlist_id.Add(1)
        End If

        If ChkDemam.Checked() Then
            keluhan_arrlist_id.Add(2)
        End If

        For Each kel In keluhan_arrlist_id
            CheckedListBoxChckd.SetItemChecked(kel, True)
        Next

        keluhan_arrlist_id.Clear()
    End Sub

    Private Sub BtnShowCbSel_Click(sender As Object, e As EventArgs) Handles BtnShowCbSel.Click
        Dim layanan_item = ComboBoxLayanan.SelectedItem()
        MessageBox.Show(layanan_item)
    End Sub

    Private Sub BtnShowCbSel2_Click(sender As Object, e As EventArgs) Handles BtnShowCbSel2.Click
        Dim layanan_item = ComboBoxLayanan2.SelectedItem()
        MessageBox.Show(layanan_item)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub ListBoxKeluhan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxKeluhan.SelectedIndexChanged

    End Sub
End Class