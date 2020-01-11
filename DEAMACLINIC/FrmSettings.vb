Public Class FrmSettings
    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click
        AccountSet1.BringToFront()
    End Sub

    Private Sub btnserv_Click(sender As Object, e As EventArgs) Handles btnserv.Click
        ServiceSetings1.BringToFront()
    End Sub
End Class