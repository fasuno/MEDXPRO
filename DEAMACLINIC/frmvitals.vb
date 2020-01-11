
Imports System.Data.SqlClient

Public Class frmvitals

    Private Sub chkDoc_CheckedChanged(sender As Object, e As EventArgs) Handles chkDoc.CheckedChanged

        If chkDoc.Checked = True Then
            cbodoctor.Enabled = True
            chkRoom.Checked = False
            cborooms.Enabled = False
            cborooms.Text = ""

            PopulateCboDOCTOR()


        End If
    End Sub

    Private Sub chkRoom_CheckedChanged(sender As Object, e As EventArgs) Handles chkRoom.CheckedChanged
        If chkRoom.Checked = True Then
            cbodoctor.Enabled = False
            chkDoc.Checked = False
            cborooms.Enabled = True
            cbodoctor.Text = ""

        End If
    End Sub

    Private Sub Btncls_Click(sender As Object, e As EventArgs) Handles Btncls.Click
        Me.Close()
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        checkuserAndSave()
        frmNursing.sortvitalssigns()
        frmNursing.sorttreatvitals()
    End Sub

    Public Sub checkuserAndSave()

        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @pword", con)

        cmd.Parameters.Add("@pword", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            txtpass.Focus()
        Else

            '// Else if password is right, Commit the entry to datatbase



            Try

                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "insert into Treated_Vitals values ('" & Datetaken.Value & "', '" & lbltime.Text & "', '" & lblsurname.Text & "', '" & lblothernames.Text & "', '" & lblhospnum.Text & "', '" & lblage.Text & "', '" & lblsex.Text & "', '" & lblaccounttype.Text & "', '" & TxtBp.Text & "', '" & txtTemp.Text & "', '" & txtPulse.Text & "', '" & txtWeight.Text & "', '" & txtHeight.Text & "', '" & txtResp.Text & "', '" & lblclinic.Text & "', '" & cbodoctor.Text & "', '" & cborooms.Text & "', '" & lbluser.Text & "')"


                cmd.Connection = con

                con.Open()

                cmd.ExecuteNonQuery()

                MsgBox("SEND PATIENT TO DOCTOR", MsgBoxStyle.OkOnly, "VITAL SIGNS")


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            Populatewaitinglist()
            '// Remove the patient from pending
            removefrompending()

            frmAllwaitingList.LoadAllPendLIst()
            FrmMywaitinglist.LoadDocPendLIst()

            Me.Close()
        End If
        ' Populatewaitinglist()

    End Sub

    Public Sub removefrompending()

        Dim Delquery As String = " Delete From Pending_Vitals Where Hospital_No = '" & lblhospnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub reloadTreatedVitalsigns()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * from Treated_Vitals", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        frmNursing.dtgtreatedvitals.DataSource = tbl
        con.Close()     '
    End Sub

    Public Sub updatewaitinglist()

        Try
            Dim Updat As String = "Update Pend_WaitingList Set date='" & Datetaken.Value & "', time='" & lbltime.Text & "', BP='" & TxtBp.Text & "', Temp='" & txtTemp.Text & "', Pulse='" & txtPulse.Text & "', Weight='" & txtWeight.Text & "',Height='" & txtHeight.Text & "', Respiration='" & txtResp.Text & "', See_Doctor='" & cbodoctor.Text & "',Room='" & cborooms.Text & "' WHERE Hospital_No='" & lblhospnum.Text & "' AND date='" & Datetaken.Text.ToString & "'"

            con.Open()
            ExecuteQuery(Updat)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        Me.Close()
    End Sub

    Private Sub BtnChng_Click(sender As Object, e As EventArgs) Handles BtnChng.Click
        Try
            Dim Updat As String = "Update Treated_Vitals Set Date='" & Datetaken.Value & "', time='" & lbltime.Text & "', BP='" & TxtBp.Text & "', Temp='" & txtTemp.Text & "', Pulse='" & txtPulse.Text & "', Weight='" & txtWeight.Text & "', Height='" & txtHeight.Text & "', Respiration='" & txtResp.Text & "', See_Doctor='" & cbodoctor.Text & "',Room='" & cborooms.Text & "' WHERE Hospital_No='" & lblhospnum.Text & "' AND date='" & Datetaken.Text.ToString & "'"

            con.Open()
            ExecuteQuery(Updat)

            ' MessageBox.Show("Appointment Rescheduled", "Appointment", MessageBoxButtons.OK)


            reloadTreatedVitalsigns()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        frmNursing.sorttreatvitals()

        updatewaitinglist()
        frmAllwaitingList.LoadAllPendLIst()
        FrmMywaitinglist.LoadDocPendLIst()

        Me.Close()

    End Sub

    Public Sub PopulateCboDOCTOR()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select Full_Name from UsersReg WHERE Role='Medical Doctor'", con)


        adapt = New SqlDataAdapter(cmd)

        con.Open()   ' Open connection

        adapt.Fill(tbl)
        cbodoctor.DataSource = tbl
        cbodoctor.DisplayMember = "Full_Name"


        con.Close()

    End Sub

    Public Sub showusername()
        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lbluser.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs) Handles txtpass.Leave
        showusername()
    End Sub

    Public Sub Populatewaitinglist()

        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Pend_WaitingList values ('" & Datetaken.Value & "', '" & lbltime.Text & "', '" & lblsurname.Text & "', '" & lblothernames.Text & "', '" & lblhospnum.Text & "', '" & lblage.Text & "', '" & lblsex.Text & "', '" & lblaccounttype.Text & "', '" & TxtBp.Text & "', '" & txtTemp.Text & "', '" & txtPulse.Text & "', '" & txtWeight.Text & "', '" & txtHeight.Text & "', '" & txtResp.Text & "', '" & lblclinic.Text & "', '" & cbodoctor.Text & "', '" & cborooms.Text & "', '" & lbluser.Text & "')"

            cmd.Connection = con

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub frmvitals_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbltime.Text = timetaken.Text
    End Sub

    Private Sub timetaken_ValueChanged(sender As Object, e As EventArgs) Handles timetaken.ValueChanged
        lbltime.Text = timetaken.Text
    End Sub

    Public Sub cleartxt()
        TxtBp.Text = ""
        txtHeight.Text = ""
        txtpass.Text = ""
        txtPulse.Text = ""
        txtTemp.Text = ""
        txtWeight.Text = ""
    End Sub
End Class