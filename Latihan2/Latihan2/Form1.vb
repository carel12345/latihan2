Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hidesubmenu()
    End Sub

    Private Sub hidesubmenu()
        Panelhome.Visible = False
    End Sub

    Private Sub showsubmenu(ByVal submenu As Panel)
        If submenu.Visible = False Then
            hidesubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub Btnhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnhome.Click
        showsubmenu(Panelhome)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        openchlidform(New frmkontak)
        hidesubmenu()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninfo.Click
        hidesubmenu()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvia.Click
        hidesubmenu()
    End Sub

    Private currentform As Form = Nothing
    Private Sub openchlidform(ByVal childform As Form)
        If currentform IsNot Nothing Then currentform.Close()
        currentform = childform
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        Panelchildform.Controls.Add(childform)
        Panelchildform.Tag = childform
        childform.BringToFront()
        childform.Show()
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class
