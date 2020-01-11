Imports System.Data.SqlClient

Public Class AncProfile

    Private Sub ANCProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd = New SqlCommand("Select * from ANCRegister where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = FrmANCform.lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            dtreg.Value = tbl.Rows(0)(0)
            Txtsurname.Text = tbl.Rows(0)(2).ToString()
            txtothernames.Text = tbl.Rows(0)(3).ToString()
            'Txtdob.Text = tbl.Rows(0)(4).ToString()
            txtsex.Text = tbl.Rows(0)(6).ToString()
            txtmarital.Text = tbl.Rows(0)(7).ToString()
            txtreli.Text = tbl.Rows(0)(8).ToString()
            txtoccup.Text = tbl.Rows(0)(9).ToString()
            txtlga.Text = tbl.Rows(0)(10).ToString()
            txtstate.Text = tbl.Rows(0)(11).ToString()
            txtnat.Text = tbl.Rows(0)(12).ToString()
            txtadd.Text = tbl.Rows(0)(13).ToString()
            txtphone.Text = tbl.Rows(0)(14).ToString()
            txtaccount.Text = tbl.Rows(0)(15).ToString()
            txtprov.Text = tbl.Rows(0)(16).ToString()
            txtenrolletype.Text = tbl.Rows(0)(17).ToString()
            txtemployer.Text = tbl.Rows(0)(18).ToString()
            txtenrolnum.Text = tbl.Rows(0)(19).ToString()
            txthusname.Text = tbl.Rows(0)(20).ToString()
            txthusadd.Text = tbl.Rows(0)(21).ToString()
            txthusphone.Text = tbl.Rows(0)(22).ToString()
            txtHusoccup.Text = tbl.Rows(0)(23).ToString()
            txthusempl.Text = tbl.Rows(0)(24).ToString()
            FrmANCform.lblbkid.Text = tbl.Rows(0)(27).ToString()

        End If

        LOADPTAGes()

    End Sub

    Private Sub LOADPTAGes()
        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hop_Num", con)
        cmd.Parameters.Add("@Hop_Num", SqlDbType.Int).Value = FrmANCform.lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            txtyear.Text = tbl.Rows(0)(4).ToString
            txtdob.Text = tbl.Rows(0)(3)
        End If
    End Sub

End Class

