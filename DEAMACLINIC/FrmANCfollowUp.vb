Imports System.Data.SqlClient
Public Class FrmANCfollowUp

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub removefrompending()

        Dim Delquery As String = " Delete From Pending_Vitals Where Hospital_No = '" & FrmANCform.lblhospnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Public Sub showusername()
        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "Medx-pro")
            txtpassw.Focus()

        Else
            lblusername.Text = tbl.Rows(0)(1).ToString()

        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub BtnDrugs_Click(sender As Object, e As EventArgs) Handles BtnDrugs.Click
        Dim frm = New FrmDrugsPresc

        frm.BtnANCdrugs.BringToFront()
        frm.LoadDrugs()
        frm.ShowDialog()
    End Sub

    Private Sub btnLAB_Click(sender As Object, e As EventArgs) Handles btnLAB.Click
        Dim frms = New FrmLabrequest

        frms.BtnSndAncLab.BringToFront()
        frms.LoadLAbTest()
        frms.ShowDialog()
    End Sub

    Private Sub BtnScan_Click(sender As Object, e As EventArgs) Handles BtnScan.Click
        Dim fr = New FrmRadrequest

        fr.BtnSndAncRad.BringToFront()
        fr.LoadRAdlist()
        fr.ShowDialog()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtpassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "USER VALIDATION")

        Else

            Dim res As MsgBoxResult
            res = MsgBox("ARE YOU SURE YOU WANT TO SAVE?", MsgBoxStyle.YesNo, "Medx-Pro")
            If (res = MsgBoxResult.Yes) Then

                Try

                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "insert into ANCVitals Values ('" & FrmANCform.lblbkid.Text & "','" & FrmANCform.lblhospnum.Text & "',  '" & dtfolwup.Value & "', '" & dtflwuptime.Value & "', '" & txtga.Text & "', '" & txtheght.Text & "', '" & txtprepos.Text & "', '" & txtlie.Text & "', '" & txtfh.Text & "', '" & txtbp.Text & "', '" & txturine.Text & "', '" & txtwght.Text & "', '" & cboappnmnt.Text & "', '" & lblusername.Text & "', '" & Txtremark.Text & "')"

                    cmd.Connection = con
                    con.Open()
                    cmd.ExecuteNonQuery()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
                con.Close()

                Me.Close()
            End If
        End If

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtpassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "USER VALIDATION")

        Else

            Try
                Dim Updat As String = "Update ANCVitals Set GA='" & txtga.Text & "', Fundal='" & txtheght.Text & "', Presentation='" & txtprepos.Text & "', Lie='" & txtlie.Text & "', Foetal_Heart='" & txtfh.Text & "', Bp='" & txtbp.Text & "', Urine='" & txturine.Text & "', Weight='" & txtwght.Text & "', Next_Appointment='" & cboappnmnt.Text & "', Remarks='" & lblusername.Text & "', Remarks='" & Txtremark.Text & "' WHERE Hospital_Num='" & FrmANCform.lblhospnum.Text & "' AND  Date='" & dtfolwup.Value & "'"

                con.Open()
                ExecuteQuery(Updat)
                con.Close()

                MessageBox.Show("FOLLOW UP VITAL EDITED", "ANC", MessageBoxButtons.OK)

                FrmANCform.LoadAncVitals()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
        Me.Close()

        '// Call the refresh appointment grid method from the records form

    End Sub

    Private Sub removeANCfrompend()

        Dim Delquery As String = " Delete From Pending_Vitals Where Hospital_No = '" & FrmANCform.lblhospnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Private Sub Btnadmit_Click(sender As Object, e As EventArgs) Handles Btnadmit.Click

        FrmAdmitpt.LoadDiagnosis()
        FrmAdmitpt.Btnorderadmit.BringToFront()
        FrmAdmitpt.ShowDialog()

    End Sub

    Private Sub Btnsendvitals_Click(sender As Object, e As EventArgs) Handles Btnsendvitals.Click

        If txtpassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "USER VALIDATION")

        Else

            Dim res As MsgBoxResult
            res = MsgBox("ARE YOU SURE YOU WANT TO SAVE?", MsgBoxStyle.YesNo, "Medx-Pro")
            If (res = MsgBoxResult.Yes) Then

                Try

                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "insert into ANCVitals Values ('" & lblbkid.Text & "','" & FrmPtRecords.Lblhopnum.Text & "',  '" & dtfolwup.Value & "', '" & dtflwuptime.Value & "', '" & txtga.Text & "', '" & txtheght.Text & "', '" & txtprepos.Text & "', '" & txtlie.Text & "', '" & txtfh.Text & "', '" & txtbp.Text & "', '" & txturine.Text & "', '" & txtwght.Text & "', '" & cboappnmnt.Text & "', '" & lblusername.Text & "', '" & Txtremark.Text & "')"

                    cmd.Connection = con
                    con.Open()
                    cmd.ExecuteNonQuery()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
                con.Close()

                Me.Close()
            End If
        End If

        FrmPtRecords.Consultations1.LoadANCtogrid()

    End Sub

    Private Sub txtpassw_Leave(sender As Object, e As EventArgs) Handles txtpassw.Leave
        showusername()
    End Sub
End Class