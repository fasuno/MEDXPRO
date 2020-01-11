
Imports System.Data.SqlClient

Public Class FrmAppointment
    Private Sub FrmAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MdiParent = frmMain
        lbltime.Text = Apptime.Text
    End Sub

    Private Sub Btnsearch_Click(sender As Object, e As EventArgs) Handles Btnsearch.Click


        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = txtsearch.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            txtsurname.Text = tbl.Rows(0)(1).ToString()
            txtothernames.Text = tbl.Rows(0)(2).ToString()
            txtsex.Text = tbl.Rows(0)(9).ToString()
            txtaccount.Text = tbl.Rows(0)(17).ToString()
            txtage.Text = tbl.Rows(0)(4).ToString()



        Else

            MsgBox("The Hospital ID does not exist", MsgBoxStyle.Information, "Appointment")

        End If


    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        '// CAll the Checkappointment method

        Checkappointment() '// See Checkappointment method
        Frmrecords.sortApptfolder()
        frmNursing.sortvitalssigns() '// Refresh the vital signs to the current date
        con.Close()
    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)
        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        'con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub reloadApptmntfolder()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * from Appntmnt", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        Frmrecords.DtgApt.DataSource = tbl
        con.Close()     '   I disable the close connection bcos i'm calling it in the save button where a connection is already open

    End Sub

    Public Sub reloadVitalsigns()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * from Pending_Vitals", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        frmNursing.dtgpendingvitals.DataSource = tbl
        con.Close()     '
    End Sub

    Public Sub Checkappointment()

        If cboClinic.Text = "" Then
            MsgBox("Please select clinic", MsgBoxStyle.Information, "Appointment")
            cboClinic.Focus()

        Else

            ''// Firtst check if the appointment hass been booked for the selected date

            Dim cmd As New SqlCommand("Select * from Appntmnt where Appointment_date= @Date AND Hospital_num=@hospID", con)

            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = Apptdate.Value
            cmd.Parameters.Add("@hospID", SqlDbType.Int).Value = txtsearch.Text

            Dim adpt As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()

            adpt.Fill(tbl)

            '// if the appointment date exist for the patient then
            If tbl.Rows.Count() > 0 Then
                MsgBox("PATIENT HAD BEEN BOOKED", MsgBoxStyle.Critical, "APPOINTMENT")
                txtsearch.Focus()

                txtaccount.Text = ""
                txtothernames.Text = ""
                ' txtsearch.Text = ""
                txtsex.Text = ""
                txtage.Text = ""
                txtsurname.Text = ""

            Else

                Try

                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "insert into Appntmnt values ('" & Apptdate.Value & "', '" & lbltime.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & txtsearch.Text & "', '" & txtage.Text & "', '" & txtsex.Text & "', '" & txtaccount.Text & "', '" & cboClinic.SelectedItem & "')"

                    cmd.Connection = con

                    con.Open()

                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("SUCCESSFUL", MsgBoxStyle.Information, "APPOINTMENT")



                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

                '--------------------------------------------------------------
                '// SAve the same data to the pending vital signs table
                '----------------------------------------------------
                populatevitals()

                txtaccount.Text = ""
                txtothernames.Text = ""
                txtsearch.Text = ""
                txtsex.Text = ""
                txtage.Text = ""
                txtsurname.Text = ""
                cboClinic.Text = ""

                Me.Close()

                reloadApptmntfolder()

                reloadVitalsigns()

            End If
        End If
        con.Close()
    End Sub

    Private Sub BtnReschedule_Click(sender As Object, e As EventArgs) Handles BtnReschedule.Click
        Try
            Dim Updat As String = "Update Appntmnt Set Appointment_date='" & Apptdate.Value & "', Appointment_time='" & lbltime.Text & "', Surname='" & txtsurname.Text & "', Other_names='" & txtothernames.Text & "', Age='" & txtage.Text & "', Sex='" & txtsex.Text & "',Account_type='" & txtaccount.Text & "', Clinic='" & cboClinic.Text & "' WHERE Hospital_Num='" & txtsearch.Text & "' AND  Appointment_date='" & Apptdate.Value & "'"

            con.Open()
            ExecuteQuery(Updat)
            con.Close()

            MessageBox.Show("Appointment Rescheduled", "Appointment", MessageBoxButtons.OK)

            'Call the reload method for folder datagrid to refresh datagrid
            reloadApptmntfolder()
            updatevitalsafterreschedule()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        Me.Close()

        '// Call the refresh appointment grid method from the records form

        Frmrecords.sortApptfolder()
        frmNursing.sortvitalssigns()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Public Sub populatevitals()

        '//  Populate the Pending vital signs table
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Pending_Vitals values ('" & Apptdate.Value & "', '" & lbltime.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & txtsearch.Text & "', '" & txtage.Text & "', '" & txtsex.Text & "', '" & txtaccount.Text & "', '" & cboClinic.SelectedItem & "')"

            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Public Sub updatevitalsafterreschedule()

        Try
            Dim Updat As String = "Update Pending_Vitals Set Appointment_date='" & Apptdate.Value & "', Appointment_time='" & lbltime.Text & "', Surname='" & txtsurname.Text & "', Other_names='" & txtothernames.Text & "', Age='" & txtage.Text & "', Sex='" & txtsex.Text & "',Account_type='" & txtaccount.Text & "', Clinic='" & cboClinic.Text & "' WHERE Hospital_No='" & txtsearch.Text & "'"

            con.Open()
            ExecuteQuery(Updat)

            ' MessageBox.Show("Appointment Rescheduled", "Appointment", MessageBoxButtons.OK)

            'Call the reload method for folder datagrid to refresh datagrid
            reloadVitalsigns()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



        Me.Close()


    End Sub

    Private Sub Apptime_ValueChanged(sender As Object, e As EventArgs) Handles Apptime.ValueChanged
        lbltime.Text = Apptime.Text
    End Sub
End Class


