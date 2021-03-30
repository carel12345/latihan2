Public Class frmkontak

    Sub kosongkanfrom()
        txtnik.Text = ""
        txtnama.Text = ""
        cmdjeniskelamin.Text = ""
        txtnotelp.Text = ""
        txtemail.Text = ""
        txtalamat.Text = ""
    End Sub

    Sub matikanfrom()
        txtnik.Enabled = False
        txtnama.Enabled = False
        cmdjeniskelamin.Enabled = False
        txtnotelp.Enabled = False
        txtemail.Enabled = False
        txtalamat.Enabled = False
    End Sub

    Sub hidupkanfrom()
        txtnik.Enabled = True
        txtnama.Enabled = True
        cmdjeniskelamin.Enabled = True
        txtnotelp.Enabled = True
        txtemail.Enabled = True
        txtalamat.Enabled = True
    End Sub


    Sub tampilkandata()
        Call koneksioDB()
        DA = New OleDb.OleDbDataAdapter("select * from kontak", CONN)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksioDB()
        Call matikanfrom()
        Call tampilkandata()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call hidupkanfrom()
        Call kosongkanfrom()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call matikanfrom()
        Call kosongkanfrom()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtnik.Text = "" Or txtnama.Text = "" Or cmdjeniskelamin.Text = "" Then
            MsgBox("HARAP DATA DI ISI....")
            Exit Sub
        Else
            Call koneksioDB()
            CMD = New OleDb.OleDbCommand("select * from kontak where nik='" & txtnik.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call koneksioDB()
                Dim simpan As String
                simpan = "insert into kontak values('" & txtnik.Text & "', '" & txtnama.Text & "','" & cmdjeniskelamin.Text & "','" & txtnotelp.Text & "','" & txtemail.Text & "','" & txtalamat.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("INPUT DATA SUKSES...")
            Else
                MsgBox("DATA TELAT SUDAH ADA...")
            End If
            Call kosongkanfrom()
            Call matikanfrom()
            Call tampilkandata()
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        txtnik.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        cmdjeniskelamin.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txtnotelp.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txtemail.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txtalamat.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

        Call hidupkanfrom()
        txtnik.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        If txtnik.Text = "" Or txtnama.Text = "" Or cmdjeniskelamin.Text = "" Then
            MsgBox("DATA TIDAK LENGKAP...")
            Exit Sub
        Else
            Call koneksioDB()
            CMD = New OleDb.OleDbCommand("update kontak set nama='" & txtnama.Text & "',jenis_kelamin='" & cmdjeniskelamin.Text & "',no_telp='" & txtnotelp.Text & "',email='" & txtemail.Text & "',alamat_rumah='" & txtalamat.Text & "' where nik='" & txtnik.Text & "'", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("DATA BERHASIL DI UPDATE...")
        End If
        Call matikanfrom()
        Call kosongkanfrom()
        Call tampilkandata()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If txtnik.Text = "" Then
            MsgBox("TIDAK ADA DATA YANG TERHAPUS...")
            Exit Sub
        Else
            If MessageBox.Show("ANDA YAKIN INGIN MENGHAPUS DATA INI", "KONFIRMASI", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Call koneksioDB()
                CMD = New OleDb.OleDbCommand("delete from kontak where nik='" & txtnik.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MsgBox("DATA TELAH TERHAPUS....")
                Call matikanfrom()
                Call kosongkanfrom()
                Call tampilkandata()
            Else
                Call matikanfrom()
                Call kosongkanfrom()
            End If
        End If
    End Sub
End Class