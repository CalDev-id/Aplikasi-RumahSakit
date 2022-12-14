<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKamar
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
        Me.LblKamarTersedia = New System.Windows.Forms.Label()
        Me.JumlahKamar = New System.Windows.Forms.Label()
        Me.BtnRemove1Kamar = New System.Windows.Forms.Button()
        Me.BtnAdd1Kamar = New System.Windows.Forms.Button()
        Me.TxtValueKamar = New System.Windows.Forms.TextBox()
        Me.BtnTambahKamar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblKamarTersedia
        '
        Me.LblKamarTersedia.AutoSize = True
        Me.LblKamarTersedia.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKamarTersedia.Location = New System.Drawing.Point(134, 48)
        Me.LblKamarTersedia.Name = "LblKamarTersedia"
        Me.LblKamarTersedia.Size = New System.Drawing.Size(348, 45)
        Me.LblKamarTersedia.TabIndex = 0
        Me.LblKamarTersedia.Text = "Kamar Tersedia Saat Ini"
        '
        'JumlahKamar
        '
        Me.JumlahKamar.AutoSize = True
        Me.JumlahKamar.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.JumlahKamar.Location = New System.Drawing.Point(273, 109)
        Me.JumlahKamar.Name = "JumlahKamar"
        Me.JumlahKamar.Size = New System.Drawing.Size(71, 45)
        Me.JumlahKamar.TabIndex = 1
        Me.JumlahKamar.Text = "100"
        '
        'BtnRemove1Kamar
        '
        Me.BtnRemove1Kamar.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnRemove1Kamar.Location = New System.Drawing.Point(24, 193)
        Me.BtnRemove1Kamar.Name = "BtnRemove1Kamar"
        Me.BtnRemove1Kamar.Size = New System.Drawing.Size(56, 50)
        Me.BtnRemove1Kamar.TabIndex = 2
        Me.BtnRemove1Kamar.Text = "-"
        Me.BtnRemove1Kamar.UseVisualStyleBackColor = True
        '
        'BtnAdd1Kamar
        '
        Me.BtnAdd1Kamar.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdd1Kamar.Location = New System.Drawing.Point(536, 193)
        Me.BtnAdd1Kamar.Name = "BtnAdd1Kamar"
        Me.BtnAdd1Kamar.Size = New System.Drawing.Size(56, 50)
        Me.BtnAdd1Kamar.TabIndex = 3
        Me.BtnAdd1Kamar.Text = "+"
        Me.BtnAdd1Kamar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnAdd1Kamar.UseVisualStyleBackColor = True
        '
        'TxtValueKamar
        '
        Me.TxtValueKamar.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtValueKamar.Location = New System.Drawing.Point(96, 193)
        Me.TxtValueKamar.Name = "TxtValueKamar"
        Me.TxtValueKamar.Size = New System.Drawing.Size(424, 50)
        Me.TxtValueKamar.TabIndex = 4
        Me.TxtValueKamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnTambahKamar
        '
        Me.BtnTambahKamar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahKamar.Location = New System.Drawing.Point(24, 253)
        Me.BtnTambahKamar.Name = "BtnTambahKamar"
        Me.BtnTambahKamar.Size = New System.Drawing.Size(568, 40)
        Me.BtnTambahKamar.TabIndex = 5
        Me.BtnTambahKamar.Text = "Tambah"
        Me.BtnTambahKamar.UseVisualStyleBackColor = True
        '
        'TambahKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 304)
        Me.Controls.Add(Me.BtnTambahKamar)
        Me.Controls.Add(Me.TxtValueKamar)
        Me.Controls.Add(Me.BtnAdd1Kamar)
        Me.Controls.Add(Me.BtnRemove1Kamar)
        Me.Controls.Add(Me.JumlahKamar)
        Me.Controls.Add(Me.LblKamarTersedia)
        Me.Name = "TambahKamar"
        Me.Text = "Tambah Kamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblKamarTersedia As Label
    Friend WithEvents JumlahKamar As Label
    Friend WithEvents BtnRemove1Kamar As Button
    Friend WithEvents BtnAdd1Kamar As Button
    Friend WithEvents TxtValueKamar As TextBox
    Friend WithEvents BtnTambahKamar As Button
End Class
