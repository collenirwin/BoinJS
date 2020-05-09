Public Class AboutForm

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text &= Form1.VersionNumber
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
