
Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmGenConsult
    Private Sub frmGenConsult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = frmMain
        'lbldate.Text = Date.Now.Date
        'lbltime.Text = TimeOfDay

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub removefrompendingwaitinglist()

        Dim Delquery As String = " Delete From Pend_WaitingList Where Hospital_No = '" & FrmPtRecords.Lblhopnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Public Sub checkuserAndSave()

        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "USER VALIDATION")
            txtPword.Focus()
        Else

            '// Else if password is right, Commit the entry to datatbase

            Dim res As MsgBoxResult
            res = MsgBox("SAVE CONSULTAION TO DATABASE?", MsgBoxStyle.YesNo)
            If (res = MsgBoxResult.Yes) Then


                Try


                    cmd = New SqlCommand("INSERT INTO Consultations VALUES(@Date, @Time, @SName, @Oname, @Hnum, @Age, @Sex, @Clinic, @Doc, @Comp,  @Pcomp,  @Assmt,  @Exam, @Pmhx,  @ImmHx,  @FamHx,  @SocHx,  @Lab,  @Rad,  @Treat,  @Summ,  @Bp,  @Temp,  @Pulse,  @Weight,  @Height,  @Resp)", con)

                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
                    cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = lbltime.Text
                    cmd.Parameters.Add("@SName", SqlDbType.VarChar).Value = FrmPtRecords.lblsurname.Text
                    cmd.Parameters.Add("@Oname", SqlDbType.VarChar).Value = FrmPtRecords.lblothernmaes.Text
                    cmd.Parameters.Add("@Hnum", SqlDbType.Int).Value = FrmPtRecords.LblHopNum.Text
                    cmd.Parameters.Add("@Age", SqlDbType.Int).Value = FrmPtRecords.lblage.Text
                    cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                    cmd.Parameters.Add("@Clinic", SqlDbType.VarChar).Value = Cboclinic.Text.ToString
                    cmd.Parameters.Add("@Doc", SqlDbType.VarChar).Value = lblusrrname.Text.ToString

                    cmd.Parameters.Add("@Comp", SqlDbType.NVarChar).Value = TxtComp.Text.ToString
                    cmd.Parameters.Add("@Pcomp", SqlDbType.NVarChar).Value = TxtPresComp.Text.ToString
                    cmd.Parameters.Add("@Assmt", SqlDbType.NVarChar).Value = TxtDiag.Text.ToString
                    cmd.Parameters.Add("@Exam", SqlDbType.NVarChar).Value = TxtExam.Text.ToString
                    cmd.Parameters.Add("@Pmhx", SqlDbType.NVarChar).Value = TxtPastmed.Text.ToString
                    cmd.Parameters.Add("@Immhx", SqlDbType.NVarChar).Value = TxtImmun.Text.ToString
                    cmd.Parameters.Add("@FamHx", SqlDbType.NVarChar).Value = TxtFamhx.Text.ToString
                    cmd.Parameters.Add("@SocHx", SqlDbType.NVarChar).Value = TxtSocial.Text.ToString

                    ' cmd.Parameters.Add(" @Assmt", SqlDbType.NVarChar).Value = Txtas.Text.ToString
                    cmd.Parameters.Add("@Lab", SqlDbType.NVarChar).Value = Txtlabinv.Text.ToString
                    cmd.Parameters.Add("@Rad", SqlDbType.NVarChar).Value = TxtRadinv.Text.ToString
                    cmd.Parameters.Add("@Treat", SqlDbType.NVarChar).Value = TxtTreatmnt.Text.ToString
                    cmd.Parameters.Add("@Summ", SqlDbType.NVarChar).Value = txtSumm.Text.ToString
                    cmd.Parameters.Add("@Bp", SqlDbType.NVarChar).Value = FrmPtRecords.Txtbp.Text.ToString
                    cmd.Parameters.Add("@Temp", SqlDbType.NVarChar).Value = FrmPtRecords.txttemp.Text.ToString
                    cmd.Parameters.Add("@Pulse", SqlDbType.NVarChar).Value = FrmPtRecords.txtpulse.Text.ToString
                    cmd.Parameters.Add("@Weight", SqlDbType.NVarChar).Value = FrmPtRecords.txtheight.Text.ToString
                    cmd.Parameters.Add("@Height", SqlDbType.NVarChar).Value = FrmPtRecords.txtweight.Text.ToString
                    cmd.Parameters.Add("@Resp", SqlDbType.NVarChar).Value = FrmPtRecords.txtresp.Text.ToString

                    cmd.Connection = con

                    con.Open()

                    cmd.ExecuteNonQuery()

                    '  MsgBox("SAVE CONSULTATION", MsgBoxStyle.OkOnly, "CONSULTATION")


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

                '// Remove the patient from pending''''''''''''''''''''''''''''

                removefrompendingwaitinglist()

                '//SAve data totreated'''''''''''''''''''''''''''''''''''''
                populateTreatedwaitinglist()

                '''''''''''''''''''''''''''''''''''''

                '//....................
                FrmPtRecords.Consultations1.LoadConsultationgrid()
                FrmPtRecords.PtDrugs11.LoadDrugsHx()
                FrmPtRecords.PtLabHist1.LoadLabReqstHx()
                FrmPtRecords.PtRadHist1.LoadRAdilogicalHx()


                Me.Close()
            Else
                TxtDiag.Focus()
            End If
        End If

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If Cboclinic.Text = "" Then

            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "CONSULTATION")
        Else

            checkuserAndSave()
            frmAllwaitingList.LoadAllPendLIst()
            frmAllwaitingList.LoadAllTreatedList()
            FrmMywaitinglist.LoadDocPendLIst()
            FrmMywaitinglist.LoadDocTreatedList()
            ' Reloadtreatedwaitinlist()
            con.Close()
        End If

    End Sub

    Public Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtPword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lblusrrname.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Public Sub populateTreatedwaitinglist()

        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Treated_Waitinglist values ('" & lbldate.Text & "', '" & lbltime.Text & "', '" & FrmPtRecords.Lblsurname.Text & "', '" & FrmPtRecords.Lblothernmaes.Text & "', '" & FrmPtRecords.Lblhopnum.Text & "', '" & FrmPtRecords.lblage.Text & "', '" & FrmPtRecords.lblsex.Text & "', '" & FrmPtRecords.lblacct.Text & "', '" & FrmPtRecords.Profile1.txtprov.Text & "', '" & Cboclinic.Text & "', '" & lblusrrname.Text & "')"


            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try
        'con.Close()

    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtPword.Leave
        '// I use this trick to save the actual name of the user performing this tack instead of targeting the password textbox
        '// I place a labelbox beside the password textbox which will be invible at runtime
        '// So once the user enter his/her passowrd and the cusor is taking away from the txtpassword, the user's FULL name will show on the label box
        '// So i am inserting the full name and not the password


        showusername()
    End Sub

    Public Sub reloadpendwaitinglist()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * from Pend_WaitingList WHERE See_Doctor = @Doc AND Date BETWEEN @datefrom AND @dateto", con)

        cmd.Parameters.Add("@Doc", SqlDbType.VarChar).Value = frmMain.lblname.Text

        cmd.Parameters.Add("@datefrom", SqlDbType.Date).Value = FrmMywaitinglist.dtfrmpend.Value
        cmd.Parameters.Add("@dateto", SqlDbType.Date).Value = FrmMywaitinglist.dttopend.Value

        adapt = New SqlDataAdapter(cmd)

        'con.Open()

        adapt.Fill(tbl)
        FrmMywaitinglist.Dtgmypendlist.DataSource = tbl


        ' con.Close()
    End Sub

    Public Sub Reloadtreatedwaitinlist()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * from Treated_Waitinglist WHERE Consultation_By = @Doc AND Date BETWEEN @dafrom AND @dato", con)

        cmd.Parameters.Add("@Doc", SqlDbType.VarChar).Value = frmMain.lblname.Text

        cmd.Parameters.Add("@dafrom", SqlDbType.Date).Value = FrmMywaitinglist.Dttrtedfrom.Value
        cmd.Parameters.Add("@dato", SqlDbType.Date).Value = FrmMywaitinglist.Dttrtedto.Value

        adapt = New SqlDataAdapter(cmd)

        'con.Open()

        adapt.Fill(tbl)
        frmAllwaitingList.DtgAllPendWaitlist.DataSource = tbl
        'FrmMywaitinglist.Label15.Text = FrmMywaitinglist.DtgMyconsultation.RowCount

    End Sub

    Private Sub btnLAB_Click(sender As Object, e As EventArgs) Handles btnLAB.Click
        ' Dim form As New FrmLabrequest
        FrmLabrequest.LoadLAbTest()
        FrmLabrequest.ShowDialog()
        FrmLabrequest.txttestname.Focus()

    End Sub

    Private Sub BtnDrugs_Click(sender As Object, e As EventArgs) Handles BtnDrugs.Click

        ' Dim form As New FrmDrugsPresc
        FrmDrugsPresc.LoadDrugs()
        FrmDrugsPresc.ShowDialog()
        FrmDrugsPresc.txtdrugname.Focus()
    End Sub

    Private Sub BtnScan_Click(sender As Object, e As EventArgs) Handles BtnScan.Click

        ' Dim form As New FrmRadrequest

        FrmRadrequest.LoadRAdlist()
        FrmRadrequest.ShowDialog()
        FrmRadrequest.txtInvType.Focus()
    End Sub

    Private Sub frmGenConsult_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        TxtComp.Text = ""
        TxtPresComp.Text = ""
        TxtExam.Text = ""
        txtPword.Text = ""
        TxtPastmed.Text = ""
        TxtImmun.Text = ""
        TxtFamhx.Text = ""
        TxtRadinv.Text = ""
        TxtSocial.Text = ""
        txtSumm.Text = ""
        TxtTreatmnt.Text = ""
        Txtlabinv.Text = ""
        TxtDiag.Text = ""


    End Sub

    Public Sub Clearall()
        TxtExam.Text = ""
        TxtFamhx.Text = ""
        TxtImmun.Text = ""
        Txtlabinv.Text = ""
        TxtPastmed.Text = ""
        TxtPresComp.Text = ""
        txtPword.Text = ""
        TxtRadinv.Text = ""
        TxtSocial.Text = ""
        txtSumm.Text = ""
        TxtTreatmnt.Text = ""
        TxtComp.Text = ""
        TxtDiag.Text = ""
        Btnsave.Enabled = True
        btnLAB.Enabled = True
        BtnDrugs.Enabled = True
        BtnScan.Enabled = True
        Btnadmit.Enabled = True
        lbldate.Text = ""
        lbltime.Text = ""
    End Sub

    Private Sub Btnadmit_Click(sender As Object, e As EventArgs) Handles Btnadmit.Click
        FrmAdmitpt.btnsend.BringToFront()
        FrmAdmitpt.LoadDiagnosis()
        FrmAdmitpt.ShowDialog()
    End Sub


End Class