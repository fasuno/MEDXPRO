Imports System.Data.SqlClient
Public Class FrmRadTreatResult
    Public Sub LoadPatientRadInestigation()

        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Investigation, Status, Date_Reported FROM VwRadRequestAndResult  Where Request_Num=@Rqnum", con)
        cmd.Parameters.Add("@Rqnum", SqlDbType.Int).Value = FrmPtRecords.PtRadHist1.DtgRadHx.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Dtgradinvest.DataSource = tbls
        Dtgradinvest.AutoResizeColumns()

    End Sub

    Private Sub FrmRadTreatResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadPatientRadInestigation()
        Txtradresult.Text = ""
        Txtradresult.ReadOnly = True
        lblinvest.Text = ""
        Lblrqstnum.Text = FrmPtRecords.PtRadHist1.DtgRadHx.CurrentRow.Cells(0).Value

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub Dtgradinvest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgradinvest.CellClick

        cmd = New SqlCommand("Select * from VwRadRequestAndResult Where Request_Num=@Rqstno AND investigation=@inv", con)
        cmd.Parameters.Add("@Rqstno", SqlDbType.Int).Value = Lblrqstnum.Text
        cmd.Parameters.Add("@inv", SqlDbType.VarChar).Value = Dtgradinvest.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            Txtradresult.Text = tbl.Rows(0)(19).ToString()
            ' TxtDaterpt.Text = tbl.Rows(0)(14).ToString()
            Txtrptby.Text = tbl.Rows(0)(16).ToString()

            lblinvest.Text = Dtgradinvest.CurrentRow.Cells(0).Value
            TxtDaterpt.Text = Dtgradinvest.CurrentRow.Cells(2).Value.ToString
            'TxtDaterpt.Text = Format(CDate(TxtDaterpt.Text), "MM/dd/yyyy")

        Else
            MsgBox("NO RESULT FOUND FOR THE SELECTED INVESTIGATION", MsgBoxStyle.Information, "RADIOLOGY")
        End If

    End Sub


End Class