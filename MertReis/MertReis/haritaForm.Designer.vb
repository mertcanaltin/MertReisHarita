<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class haritaForm
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
        Me.StatusStripMR = New System.Windows.Forms.StatusStrip()
        Me.SplitContainerMR = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HaritalarComboBox = New System.Windows.Forms.ComboBox()
        Me.MertReisGMapControl = New GMap.NET.WindowsForms.GMapControl()
        Me.NumericUpDownZoom = New System.Windows.Forms.NumericUpDown()
        Me.ZoomLabel = New System.Windows.Forms.Label()
        Me.GroupBoxKoordinat = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EnlemTextBox = New System.Windows.Forms.TextBox()
        Me.BoylamTextBox = New System.Windows.Forms.TextBox()
        Me.KoordinatGitButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AdresButton = New System.Windows.Forms.Button()
        Me.AdresTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.SplitContainerMR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMR.Panel1.SuspendLayout()
        Me.SplitContainerMR.Panel2.SuspendLayout()
        Me.SplitContainerMR.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxKoordinat.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStripMR
        '
        Me.StatusStripMR.Location = New System.Drawing.Point(0, 428)
        Me.StatusStripMR.Name = "StatusStripMR"
        Me.StatusStripMR.Size = New System.Drawing.Size(800, 22)
        Me.StatusStripMR.TabIndex = 0
        Me.StatusStripMR.Text = "StatusStrip1"
        '
        'SplitContainerMR
        '
        Me.SplitContainerMR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMR.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerMR.IsSplitterFixed = True
        Me.SplitContainerMR.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerMR.Name = "SplitContainerMR"
        Me.SplitContainerMR.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerMR.Panel1
        '
        Me.SplitContainerMR.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainerMR.Panel1.Controls.Add(Me.GroupBoxKoordinat)
        Me.SplitContainerMR.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainerMR.Panel2
        '
        Me.SplitContainerMR.Panel2.Controls.Add(Me.MertReisGMapControl)
        Me.SplitContainerMR.Size = New System.Drawing.Size(800, 428)
        Me.SplitContainerMR.SplitterDistance = 150
        Me.SplitContainerMR.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ZoomLabel)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownZoom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.HaritalarComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Haritalar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Harita Seç"
        '
        'HaritalarComboBox
        '
        Me.HaritalarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HaritalarComboBox.FormattingEnabled = True
        Me.HaritalarComboBox.Location = New System.Drawing.Point(15, 52)
        Me.HaritalarComboBox.Name = "HaritalarComboBox"
        Me.HaritalarComboBox.Size = New System.Drawing.Size(191, 21)
        Me.HaritalarComboBox.TabIndex = 1
        '
        'MertReisGMapControl
        '
        Me.MertReisGMapControl.Bearing = 0!
        Me.MertReisGMapControl.CanDragMap = True
        Me.MertReisGMapControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MertReisGMapControl.EmptyTileColor = System.Drawing.Color.Navy
        Me.MertReisGMapControl.GrayScaleMode = False
        Me.MertReisGMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.MertReisGMapControl.LevelsKeepInMemmory = 5
        Me.MertReisGMapControl.Location = New System.Drawing.Point(0, 0)
        Me.MertReisGMapControl.MarkersEnabled = True
        Me.MertReisGMapControl.MaxZoom = 2
        Me.MertReisGMapControl.MinZoom = 2
        Me.MertReisGMapControl.MouseWheelZoomEnabled = True
        Me.MertReisGMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.MertReisGMapControl.Name = "MertReisGMapControl"
        Me.MertReisGMapControl.NegativeMode = False
        Me.MertReisGMapControl.PolygonsEnabled = True
        Me.MertReisGMapControl.RetryLoadTile = 0
        Me.MertReisGMapControl.RoutesEnabled = True
        Me.MertReisGMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.MertReisGMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.MertReisGMapControl.ShowTileGridLines = False
        Me.MertReisGMapControl.Size = New System.Drawing.Size(800, 274)
        Me.MertReisGMapControl.TabIndex = 0
        Me.MertReisGMapControl.Zoom = 0R
        '
        'NumericUpDownZoom
        '
        Me.NumericUpDownZoom.Location = New System.Drawing.Point(15, 100)
        Me.NumericUpDownZoom.Name = "NumericUpDownZoom"
        Me.NumericUpDownZoom.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownZoom.TabIndex = 2
        '
        'ZoomLabel
        '
        Me.ZoomLabel.AutoSize = True
        Me.ZoomLabel.Location = New System.Drawing.Point(15, 81)
        Me.ZoomLabel.Name = "ZoomLabel"
        Me.ZoomLabel.Size = New System.Drawing.Size(47, 13)
        Me.ZoomLabel.TabIndex = 3
        Me.ZoomLabel.Text = "Yakınlaş"
        '
        'GroupBoxKoordinat
        '
        Me.GroupBoxKoordinat.Controls.Add(Me.KoordinatGitButton)
        Me.GroupBoxKoordinat.Controls.Add(Me.BoylamTextBox)
        Me.GroupBoxKoordinat.Controls.Add(Me.EnlemTextBox)
        Me.GroupBoxKoordinat.Controls.Add(Me.Label3)
        Me.GroupBoxKoordinat.Controls.Add(Me.Label2)
        Me.GroupBoxKoordinat.Location = New System.Drawing.Point(237, 3)
        Me.GroupBoxKoordinat.Name = "GroupBoxKoordinat"
        Me.GroupBoxKoordinat.Size = New System.Drawing.Size(200, 144)
        Me.GroupBoxKoordinat.TabIndex = 1
        Me.GroupBoxKoordinat.TabStop = False
        Me.GroupBoxKoordinat.Text = "Koordinat gir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enlem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Boylam"
        '
        'EnlemTextBox
        '
        Me.EnlemTextBox.Location = New System.Drawing.Point(6, 35)
        Me.EnlemTextBox.Name = "EnlemTextBox"
        Me.EnlemTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnlemTextBox.TabIndex = 2
        '
        'BoylamTextBox
        '
        Me.BoylamTextBox.Location = New System.Drawing.Point(9, 94)
        Me.BoylamTextBox.Name = "BoylamTextBox"
        Me.BoylamTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BoylamTextBox.TabIndex = 3
        '
        'KoordinatGitButton
        '
        Me.KoordinatGitButton.Location = New System.Drawing.Point(110, 58)
        Me.KoordinatGitButton.Name = "KoordinatGitButton"
        Me.KoordinatGitButton.Size = New System.Drawing.Size(75, 23)
        Me.KoordinatGitButton.TabIndex = 4
        Me.KoordinatGitButton.Text = "Git"
        Me.KoordinatGitButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AdresButton)
        Me.GroupBox2.Controls.Add(Me.AdresTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(455, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(178, 144)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adrese gir"
        '
        'AdresButton
        '
        Me.AdresButton.Location = New System.Drawing.Point(48, 61)
        Me.AdresButton.Name = "AdresButton"
        Me.AdresButton.Size = New System.Drawing.Size(75, 23)
        Me.AdresButton.TabIndex = 4
        Me.AdresButton.Text = "Git"
        Me.AdresButton.UseVisualStyleBackColor = True
        '
        'AdresTextBox
        '
        Me.AdresTextBox.Location = New System.Drawing.Point(6, 35)
        Me.AdresTextBox.Name = "AdresTextBox"
        Me.AdresTextBox.Size = New System.Drawing.Size(155, 20)
        Me.AdresTextBox.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adres"
        '
        'haritaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainerMR)
        Me.Controls.Add(Me.StatusStripMR)
        Me.Name = "haritaForm"
        Me.Text = "Mert Reis Harita Uygulaması"
        Me.SplitContainerMR.Panel1.ResumeLayout(False)
        Me.SplitContainerMR.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerMR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMR.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxKoordinat.ResumeLayout(False)
        Me.GroupBoxKoordinat.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub





    Friend WithEvents StatusStripMR As StatusStrip
    Friend WithEvents SplitContainerMR As SplitContainer
    Friend WithEvents MertReisGMapControl As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents HaritalarComboBox As ComboBox
    Friend WithEvents ZoomLabel As Label
    Friend WithEvents NumericUpDownZoom As NumericUpDown
    Friend WithEvents GroupBoxKoordinat As GroupBox
    Friend WithEvents KoordinatGitButton As Button
    Friend WithEvents BoylamTextBox As TextBox
    Friend WithEvents EnlemTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AdresButton As Button
    Friend WithEvents AdresTextBox As TextBox
    Friend WithEvents Label5 As Label
End Class
