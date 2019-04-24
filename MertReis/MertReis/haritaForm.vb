Imports GMap.NET.MapProviders
Imports GMap.NET

Public Class haritaForm
    Private Sub haritaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MertReisGMapControl.MapProvider = GMapProviders.GoogleMap
        MertReisGMapControl.MaxZoom = 25
        MertReisGMapControl.MinZoom = 2
        MertReisGMapControl.Position = New PointLatLng(37.166167, 28.376757)
        MertReisGMapControl.Zoom = 15

        'Haritaları Yükle
        Dim haritalar As New Dictionary(Of String, Guid)
        For Each Harita As GMapProvider In GMapProviders.List
            haritalar.Add(Harita.Name, Harita.Id)
        Next
        HaritalarComboBox.DisplayMember = "Key"
        HaritalarComboBox.ValueMember = "Value"
        HaritalarComboBox.DataSource = New BindingSource(haritalar, Nothing)
        'google map provider eklediğimiz için combo box da seçili hale getireceğiz
        HaritalarComboBox.SelectedValue = GMapProviders.GoogleMap.Id
        'yakınlaşma Zoom Ayarları

        NumericUpDownZoom.Maximum = MertReisGMapControl.MaxZoom
        NumericUpDownZoom.Minimum = MertReisGMapControl.MinZoom
        NumericUpDownZoom.Value = MertReisGMapControl.Zoom


    End Sub
    Private Sub HaritalarComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles HaritalarComboBox.SelectedValueChanged
        Dim id As Guid = HaritalarComboBox.SelectedValue
        Dim Harita As GMapProvider = GMapProviders.TryGetProvider(id)
        MertReisGMapControl.MapProvider = Harita
    End Sub

    Private Sub NumericUpDownZoom_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownZoom.ValueChanged
        MertReisGMapControl.Zoom = NumericUpDownZoom.Value
    End Sub

    Private Sub MertReisGMapControl_OnMapZoomChanged() Handles MertReisGMapControl.OnMapZoomChanged
        NumericUpDownZoom.Value = MertReisGMapControl.Zoom
    End Sub

    Private Sub KoordinatGitButton_Click(sender As Object, e As EventArgs) Handles KoordinatGitButton.Click
        Try
            If IsNumeric(EnlemTextBox.Text) And IsNumeric(BoylamTextBox.Text) Then
                Dim enlem As Decimal = CDbl(EnlemTextBox.Text)
                Dim boylam As Decimal = CDbl(BoylamTextBox.Text)
                MertReisGMapControl.Position = New PointLatLng(enlem, boylam)
            Else
                MessageBox.Show("Enlem ve boylam sayısal bilgi olmalıdır !")
            End If
        Catch ex As Exception
            MessageBox.Show("hata oluştu" & ex.Message, "hata")
        End Try
    End Sub

    Private Sub AdresButton_Click(sender As Object, e As EventArgs) Handles AdresButton.Click
        Try
            If AdresTextBox.Text.Trim.Length > 0 Then
                Dim adres As String = AdresTextBox.Text.Trim
                
                Dim durum As GeoCoderStatusCode
                durum = MertReisGMapControl.SetPositionByKeywords(adres)


                If durum <> GeoCoderStatusCode.G_GEO_SUCCESS Then
                    MessageBox.Show("Adres Bulunamadı", "adres hatası")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("hata oluştu" & ex.Message, "hata")
        End Try
    End Sub
End Class
