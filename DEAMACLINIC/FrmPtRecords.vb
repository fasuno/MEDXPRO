Public Class FrmPtRecords
    Private Sub FrmPtRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Consultations1.BringToFront()

    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        Profile1.BringToFront()
    End Sub

    Private Sub Btnconsult_Click(sender As Object, e As EventArgs) Handles Btnconsult.Click
        Consultations1.BringToFront()
    End Sub

    Private Sub btnLab_Click(sender As Object, e As EventArgs) Handles btnLab.Click
        PtLabHist1.BringToFront()
    End Sub

    Private Sub BtnRad_Click(sender As Object, e As EventArgs) Handles BtnRad.Click
        PtRadHist1.BringToFront()
    End Sub

    Private Sub BtbnPharm_Click(sender As Object, e As EventArgs) Handles BtbnPharm.Click
        PtDrugs11.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


End Class