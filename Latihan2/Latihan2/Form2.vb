Public Class Form2

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Call koneksioDB()
        Dim login As String
        login = "select * from admin where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'"
        CMD = New OleDb.OleDbCommand(login, CONN)
        DR = CMD.ExecuteReader
        If DR.Read Then
            MsgBox("login berhasil")
            Me.Hide()
            Form1.Show()
            txtusername.Text = ""
            txtpassword.Text = ""
        Else
            MsgBox("LOGIN GAGAL...")
            txtusername.Text = ""
            txtpassword.Text = ""
        End If
    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If (e.KeyChar = Chr(13)) Then
            btnlogin.Focus()
        End If
    End Sub
End Class