Imports System.Data.SqlClient

Public Class FrmANCreg
    '// To Do:
    '2. Design The ANC form
    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)
        con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        cmd = New SqlCommand("Select * from Pt_profile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = txtsearch.Text

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
            txtlga.Text = tbl.Rows(0)(13).ToString()
            txtstate.Text = tbl.Rows(0)(14).ToString()
            txtnat.Text = tbl.Rows(0)(15).ToString()
            txtadd.Text = tbl.Rows(0)(16).ToString()
            txtphone.Text = tbl.Rows(0)(17).ToString()
            txtprov.Text = tbl.Rows(0)(23).ToString()
            txtenrolletype.Text = tbl.Rows(0)(24).ToString()
            txtemployer.Text = tbl.Rows(0)(25).ToString()
            txtenrolnum.Text = tbl.Rows(0)(26).ToString()

            LOADPTAGe()
        Else
            MsgBox("HOSPITAL NUMBER DOES NOT EXIST, PLEASE REGISTER", MsgBoxStyle.OkOnly, "ANC REGISTER")

        End If

    End Sub

    Private Sub LOADPTAGe()
        cmd = New SqlCommand("Select * from VwPtProfile where Hospital_Num=@Hosp_Num", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = txtsearch.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            txtyear.Text = tbl.Rows(0)(4).ToString()
            Txtdob.Text = tbl.Rows(0)(3)
        End If
    End Sub

    Private Sub BtnCls_Click(sender As Object, e As EventArgs) Handles BtnCls.Click
        Me.Close()
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If txtsex.Text = "Male" Then
            MsgBox("THIS IS A MALE PATIENT AND CANNOT BE BOOKED FOR ANC", MsgBoxStyle.Information, "ANC REGISTER")

            '// VAlidate Husband Info
        ElseIf txthusadd.Text = "" Or
            txthusempl.Text = "" Or
            txthusname.Text = "" Or
            txtHusoccup.Text = "" Or
            txthusphone.Text = "" Then

            MsgBox("PLEASE COMPLETE HER HUSBAND DETAILS", MsgBoxStyle.Information, "ANC REGISTER")

            txthusname.Focus()

        Else
            '// Check If pt has been register today
            Dim cmd As New SqlCommand("Select * from ANCRegister where Hospital_Num = '" & txtsearch.Text & "' AND Delivery_Status = '" & lblstatus.Text & "'", con)

            Dim adpt As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()

            adpt.Fill(tbl)

            If tbl.Rows.Count() > 0 Then
                MsgBox("PATIENT HAS BEEN REGISTERED ", MsgBoxStyle.Critical, "ANC REGISTER")
                txtsearch.Focus()
            Else
                '//Validate passord

                If Txtpword.Text = "" Then
                    MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "ANC REGISTER")
                    txtsearch.Focus()
                Else

                    '//Insert details 
                    Try

                        cmd.CommandType = System.Data.CommandType.Text
                        cmd.CommandText = "insert into ANCRegister values ('" & dtreg.Value & "', '" & txtsearch.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & Txtdob.Text & "', '" & txtyear.Text & "', '" & txtsex.Text & "', '" & txtmarital.Text & "', '" & txtreli.Text & "', '" & txtoccup.Text & "', '" & txtlga.Text & "', '" & txtstate.Text & "', '" & txtnat.Text & "', '" & txtadd.Text & "', '" & txtphone.Text & "', '" & txtaccount.Text & "', '" & txtprov.Text & "', '" & txtenrolletype.Text & "', '" & txtemployer.Text & "', '" & txtenrolnum.Text & "', '" & txthusname.Text & "', '" & txthusadd.Text & "', '" & txthusphone.Text & "', '" & txtHusoccup.Text & "', '" & txthusempl.Text & "', '" & lbluser.Text & "','" & lblstatus.Text & "')"

                        cmd.Connection = con

                        con.Open()
                        cmd.ExecuteNonQuery()

                        MsgBox("NEW ANC PATIENT REGISTERED", MsgBoxStyle.Information, "ANC REGISTER")



                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    End Try
                    con.Close()

                    BookAncAppointmnt()
                    populatevitals()
                    Cleaentries()
                    Me.Close()
                End If
            End If
        End If

        Frmrecords.sortApptfolder()
        frmNursing.sortvitalssigns()
        Frmrecords.sortANC()


    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Txtpword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "ANC REGISTER")
            Txtpword.Focus()

        Else
            lbluser.Text = tbl.Rows(0)(1).ToString()

        End If
    End Sub

    Private Sub Txtpword_Leave(sender As Object, e As EventArgs) Handles Txtpword.Leave
        CheckPassowrd()
    End Sub

    Private Sub Cleaentries()
        txtsearch.Text = ""
        txtsurname.Text = ""
        txtothernames.Text = ""
        txtaccount.Text = ""
        txtyear.Text = ""
        txtsex.Text = ""
        txtmarital.Text = ""
        txtoccup.Text = ""
        txtemployer.Text = ""
        txtprov.Text = ""
        txtphone.Text = ""
        txtlga.Text = ""
        txtstate.Text = ""
        txtnat.Text = ""
        txtenrolletype.Text = ""
        txtenrolnum.Text = ""
        txthusadd.Text = ""
        txthusempl.Text = ""
        txthusname.Text = ""
        txtHusoccup.Text = ""
        txthusphone.Text = ""
        Txtpword.Text = ""
        lbluser.Text = ""
    End Sub

    Private Sub BookAncAppointmnt()
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Appntmnt values ('" & dtreg.Value & "', '" & lbltime.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & txtsearch.Text & "', '" & txtyear.Text & "', '" & txtsex.Text & "', '" & txtaccount.Text & "', '" & lblclinic.Text & "')"

            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()
            'MsgBox("SUCCESSFUL", MsgBoxStyle.Information, "APPOINTMENT")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub populatevitals()

        '//  Populate the Pending vital signs table
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Pending_Vitals values ('" & dtreg.Value & "', '" & lbltime.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & txtsearch.Text & "', '" & txtyear.Text & "', '" & txtsex.Text & "', '" & txtaccount.Text & "', '" & lblclinic.Text & "')"

            cmd.Connection = con

            con.Open()

            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub FrmANCreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltime.Text = TimeOfDay
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        If Txtpword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Critical, "ANC REGISTER")
            txtsearch.Focus()
        Else

            Try
                Dim Updat As String = "Update ANCRegister Set Husband_Name='" & txthusname.Text & "', Husband_Address='" & txthusadd.Text & "', Husband_Phone='" & txthusphone.Text & "', Husband_Occupation='" & txtHusoccup.Text & "', Husband_Employer='" & txthusempl.Text & "', Registered_By= '" & lbluser.Text + " Edited Record " & "'  WHERE Hospital_Num='" & txtsearch.Text & "'"

                con.Open()
                ExecuteQuery(Updat)
                con.Close()

                MessageBox.Show("ANC REGISTERED HAS BEEN UPDATED", "ANC REGISTER", MessageBoxButtons.OK)


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            Me.Close()
        End If
    End Sub

End Class