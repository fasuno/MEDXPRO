Imports System.Data.SqlClient
Public Class FrmAdmitFolder
    Public Sub LoadProfile()

        cmd = New SqlCommand("Select * from Pt_profile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = Lblhospnum.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            Profile1.txtsurname.Text = tbl.Rows(0)(1).ToString()
            Profile1.txtothernames.Text = tbl.Rows(0)(2).ToString()
            Profile1.txtaccount.Text = tbl.Rows(0)(7).ToString()
            Profile1.txtsex.Text = tbl.Rows(0)(9).ToString()
            Profile1.txtmarital.Text = tbl.Rows(0)(10).ToString()
            Profile1.txtreli.Text = tbl.Rows(0)(11).ToString()
            Profile1.txtoccup.Text = tbl.Rows(0)(12).ToString()
            Profile1.txtlfa.Text = tbl.Rows(0)(13).ToString()
            Profile1.txtstate.Text = tbl.Rows(0)(14).ToString()
            Profile1.txtnat.Text = tbl.Rows(0)(15).ToString()
            Profile1.txtadd.Text = tbl.Rows(0)(16).ToString()
            Profile1.txtphone.Text = tbl.Rows(0)(17).ToString()
            Profile1.txtemail.Text = tbl.Rows(0)(18).ToString()
            Profile1.txtkinname.Text = tbl.Rows(0)(19).ToString()
            Profile1.txtkinadd.Text = tbl.Rows(0)(20).ToString()
            Profile1.txtkinphone.Text = tbl.Rows(0)(21).ToString()
            Profile1.txtkinrel.Text = tbl.Rows(0)(22).ToString()
            Profile1.txtprov.Text = tbl.Rows(0)(23).ToString()
            Profile1.txtenrolletype.Text = tbl.Rows(0)(24).ToString()
            Profile1.txtemployer.Text = tbl.Rows(0)(25).ToString()
            Profile1.txtenrolnum.Text = tbl.Rows(0)(26).ToString()
            Profile1.txtnin.Text = tbl.Rows(0)(27).ToString()
            Profile1.txtotherstate.Text = tbl.Rows(0)(28).ToString()
            Profile1.txtcaution.Text = tbl.Rows(0)(29).ToString()



        End If
        LOADPTAGe()
    End Sub

    Private Sub LOADPTAGe()
        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = Lblhospnum.Text
        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            Profile1.txtyear.Text = tbl.Rows(0)(4).ToString()
            Profile1.txtmonths.Text = tbl.Rows(0)(5).ToString()
        End If
    End Sub

    Private Sub Btnprofile_Click(sender As Object, e As EventArgs) Handles Btnprofile.Click
        Profile1.BringToFront()
    End Sub

    Private Sub FrmAdmitFolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = frmMain
        Profile1.BringToFront()
    End Sub

    Private Sub BtnNurserpt_Click(sender As Object, e As EventArgs) Handles BtnNurserpt.Click
        NurseReport1.LoadDischargedPT()
        NurseReport1.BringToFront()
    End Sub
End Class