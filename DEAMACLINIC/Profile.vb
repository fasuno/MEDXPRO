
Imports System.Data.SqlClient

Public Class Profile
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd = New SqlCommand("Select * from Pt_profile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = FrmPtRecords.Lblhopnum.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            txtsurname.Text = tbl.Rows(0)(1).ToString()
            txtothernames.Text = tbl.Rows(0)(2).ToString()
            txtaccount.Text = tbl.Rows(0)(7).ToString()
            txtsex.Text = tbl.Rows(0)(9).ToString()
            txtmarital.Text = tbl.Rows(0)(10).ToString()
            txtreli.Text = tbl.Rows(0)(11).ToString()
            txtoccup.Text = tbl.Rows(0)(12).ToString()
            txtlfa.Text = tbl.Rows(0)(13).ToString()
            txtstate.Text = tbl.Rows(0)(14).ToString()
            txtnat.Text = tbl.Rows(0)(15).ToString()
            txtadd.Text = tbl.Rows(0)(16).ToString()
            txtphone.Text = tbl.Rows(0)(17).ToString()
            txtemail.Text = tbl.Rows(0)(18).ToString()
            txtkinname.Text = tbl.Rows(0)(19).ToString()
            txtkinadd.Text = tbl.Rows(0)(20).ToString()
            txtkinphone.Text = tbl.Rows(0)(21).ToString()
            txtkinrel.Text = tbl.Rows(0)(22).ToString()
            txtprov.Text = tbl.Rows(0)(23).ToString()
            txtenrolletype.Text = tbl.Rows(0)(24).ToString()
            txtemployer.Text = tbl.Rows(0)(25).ToString()
            txtenrolnum.Text = tbl.Rows(0)(26).ToString()
            txtnin.Text = tbl.Rows(0)(27).ToString()
            txtotherstate.Text = tbl.Rows(0)(28).ToString()
            txtcaution.Text = tbl.Rows(0)(29).ToString()



        End If
        LOADPTAGe()
    End Sub

    Private Sub LOADPTAGe()
        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = FrmPtRecords.Lblhopnum.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            txtyear.Text = tbl.Rows(0)(4).ToString()
            txtmonths.Text = tbl.Rows(0)(5).ToString()
        End If
    End Sub
End Class
