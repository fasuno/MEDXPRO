Imports System.Data.SqlClient

Public Class PtRadHist
    Private Sub Btnnew_Click(sender As Object, e As EventArgs) Handles Btnnew.Click
        FrmRadrequest.LoadRAdlist()
        FrmRadrequest.ShowDialog()
    End Sub

    Public Sub LoadRAdilogicalHx()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select DISTINCT Request_NUm, Date_Requested, Requested_by, Date_Reported from VwRadRequestAndResult WHERE Hospital_No = @hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Me.DtgRadHx.DataSource = tbl

    End Sub

    Private Sub PtRadHist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRAdilogicalHx()
    End Sub

    Private Sub DtgRadHx_DoubleClick(sender As Object, e As EventArgs) Handles DtgRadHx.DoubleClick
        Dim frm = New FrmRadTreatResult

        FrmRadTreatResult.TxtRqstdate.Text = DtgRadHx.CurrentRow.Cells(1).Value
        FrmRadTreatResult.txtRqstby.Text = DtgRadHx.CurrentRow.Cells(2).Value.ToString

        FrmRadTreatResult.ShowDialog()
    End Sub

End Class
