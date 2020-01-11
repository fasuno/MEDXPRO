Imports System.Data.SqlClient

Public Class FrmDrugPreview
    Private Sub FrmDrugPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tbl As New DataTable

        cmd = New SqlCommand("Select DISTINCT Drug_name, Prescription from AllDrugPresc WHERE Presc_Num = @pnum", con)

        cmd.Parameters.Add("@pnum", SqlDbType.VarChar).Value = FrmPtRecords.PtDrugs11.DtgDrugshx.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)

        Me.Dtgdrugprev.DataSource = tbl
        Dtgdrugprev.AutoResizeColumns()
    End Sub

End Class