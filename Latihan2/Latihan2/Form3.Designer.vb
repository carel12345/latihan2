<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkontak
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
        Me.Groupdatasiswa = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.cmdjeniskelamin = New System.Windows.Forms.ComboBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnik = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Groupdatasiswa.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Groupdatasiswa
        '
        Me.Groupdatasiswa.Controls.Add(Me.Button1)
        Me.Groupdatasiswa.Controls.Add(Me.Button5)
        Me.Groupdatasiswa.Controls.Add(Me.Button4)
        Me.Groupdatasiswa.Controls.Add(Me.btnedit)
        Me.Groupdatasiswa.Controls.Add(Me.Button2)
        Me.Groupdatasiswa.Controls.Add(Me.btntambah)
        Me.Groupdatasiswa.Controls.Add(Me.cmdjeniskelamin)
        Me.Groupdatasiswa.Controls.Add(Me.txtalamat)
        Me.Groupdatasiswa.Controls.Add(Me.txtemail)
        Me.Groupdatasiswa.Controls.Add(Me.txtnotelp)
        Me.Groupdatasiswa.Controls.Add(Me.txtnama)
        Me.Groupdatasiswa.Controls.Add(Me.txtnik)
        Me.Groupdatasiswa.Controls.Add(Me.Label6)
        Me.Groupdatasiswa.Controls.Add(Me.Label5)
        Me.Groupdatasiswa.Controls.Add(Me.Label4)
        Me.Groupdatasiswa.Controls.Add(Me.Label3)
        Me.Groupdatasiswa.Controls.Add(Me.Label2)
        Me.Groupdatasiswa.Controls.Add(Me.Label1)
        Me.Groupdatasiswa.Location = New System.Drawing.Point(12, 12)
        Me.Groupdatasiswa.Name = "Groupdatasiswa"
        Me.Groupdatasiswa.Size = New System.Drawing.Size(572, 214)
        Me.Groupdatasiswa.TabIndex = 0
        Me.Groupdatasiswa.TabStop = False
        Me.Groupdatasiswa.Text = "DATA SISWA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(382, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "HAPUS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(291, 166)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "BATAL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(200, 166)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 23)
        Me.btnedit.TabIndex = 14
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(110, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(20, 166)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 12
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'cmdjeniskelamin
        '
        Me.cmdjeniskelamin.FormattingEnabled = True
        Me.cmdjeniskelamin.Items.AddRange(New Object() {"L", "P"})
        Me.cmdjeniskelamin.Location = New System.Drawing.Point(113, 112)
        Me.cmdjeniskelamin.Name = "cmdjeniskelamin"
        Me.cmdjeniskelamin.Size = New System.Drawing.Size(100, 21)
        Me.cmdjeniskelamin.TabIndex = 11
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(408, 109)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(100, 20)
        Me.txtalamat.TabIndex = 10
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(408, 68)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 9
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(408, 28)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(100, 20)
        Me.txtnotelp.TabIndex = 8
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(113, 75)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(100, 20)
        Me.txtnama.TabIndex = 7
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(113, 37)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(100, 20)
        Me.txtnik.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ALAMAT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(331, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EMAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NO.TELP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JENIS KELAMIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 232)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(572, 194)
        Me.DataGridView1.TabIndex = 1
        '
        'frmkontak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 438)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Groupdatasiswa)
        Me.Name = "frmkontak"
        Me.Text = "kontak"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Groupdatasiswa.ResumeLayout(False)
        Me.Groupdatasiswa.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Groupdatasiswa As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents cmdjeniskelamin As System.Windows.Forms.ComboBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtnotelp As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
