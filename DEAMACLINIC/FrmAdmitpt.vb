Imports System.Data.SqlClient

Public Class FrmAdmitpt

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub FrmAdmitpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbldat.Text = Date.Now
        lbltim.Text = TimeOfDay

        showAllwards()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select Ward_Name, COUNT(Bed_status) AS Beds_Available From Bedlist WHERE Bed_Status= 'Free' GROUP BY Ward_name, Bed_Status", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        Dgvbedlist.DataSource = tbl

        '===============
        'ShowWards()

    End Sub

    Public Sub LoadDiagnosis()

        Try

            Dim tbls As New DataTable
            cmd = New SqlCommand("Select Disease_Name From ICDCODE", con)


            adapt = New SqlDataAdapter(cmd)

            con.Open()   ' Open connection

            adapt.Fill(tbls)

            Dim rw As DataRow

            txtdiagnosis.AutoCompleteCustomSource.Clear()

            For Each rw In tbls.Rows
                txtdiagnosis.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try
        txtdiagnosis.Focus()

    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-Pro")
        Else

            Dim res As MsgBoxResult
            res = MsgBox("ARE YOU SURE YOU WANT TO ADMIT THIS PATIENT?", MsgBoxStyle.YesNo, "Medx-Pro")
            If (res = MsgBoxResult.Yes) Then

                Try

                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "insert into AdmissionRequest values ('" & lbldat.Text & "', '" & lbltim.Text & "', '" & FrmPtRecords.Lblhopnum.Text & "', '" & FrmPtRecords.Lblsurname.Text & "', '" & FrmPtRecords.Lblothernmaes.Text & "', '" & FrmPtRecords.lblsex.Text & "', '" & FrmPtRecords.lblage.Text & "', '" & txtdiagnosis.Text & "', '" & Cboadmtyp.Text & "', '" & cboward.Text & "', '" & txtinstr.Text & "', '" & lblname.Text & "', '" & Cboclinic.Text & "')"


                    cmd.Connection = con
                    con.Open()
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
                Me.Close()
            Else
                txtdiagnosis.Focus()
            End If
        End If

    End Sub

    Public Sub showusername()

        '==============CHECK USER VALIDITY
        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @pword", con)

        cmd.Parameters.Add("@pword", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbls As New DataTable()

        adpt.Fill(tbls)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbls.Rows.Count() <= 0 Then
            MsgBox("INVALID PASSWORD", MsgBoxStyle.Critical, "User Validation")
            Txtpass.Focus()
        Else

            '// Show users name after log in, this method will be called on frmlogin LOGIN button
            cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = Txtpass.Text

            Dim adpts As New SqlDataAdapter(cmd)
            Dim tbl As New DataTable()

        adpt.Fill(tbl)

            If tbl.Rows.Count() > 0 Then

                'Display the person data

                lblname.Text = tbl.Rows(0)(1).ToString()

            Else
            End If

        End If

    End Sub

    Private Sub Btnorderadmit_Click(sender As Object, e As EventArgs) Handles Btnorderadmit.Click

        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medx-Pro")
        Else

            Dim res As MsgBoxResult
            res = MsgBox("ARE YOU SURE YOU WANT TO ADMIT THIS PATIENT?", MsgBoxStyle.YesNo, "Medx-Pro")
            If (res = MsgBoxResult.Yes) Then

                Try

                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "insert into AdmissionRequest values ('" & lbldat.Text & "', '" & lbltim.Text & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile1.Txtsurname.Text & "', '" & FrmANCform.AncProfile1.txtothernames.Text & "', '" & FrmANCform.AncProfile1.txtsex.Text & "', '" & FrmANCform.AncProfile1.txtyear.Text & "', '" & txtdiagnosis.Text & "', '" & Cboadmtyp.Text & "', '" & cboward.Text & "', '" & txtinstr.Text & "', '" & lblname.Text & "', '" & Cboclinic.Text & "')"


                    cmd.Connection = con
                    con.Open()
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
                Me.Close()
            Else
                txtdiagnosis.Focus()
            End If
        End If

    End Sub

    Public Sub showAllwards()
        Dim tb As New DataTable
        cmd = New SqlCommand("Select DISTINCT Ward_Name FROM Bedlist WHERE Bed_Status='Free'", con)

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        cboward.DataSource = tb
        cboward.DisplayMember = "Ward_Name"

    End Sub

    Private Sub Txtpass_Leave(sender As Object, e As EventArgs) Handles Txtpass.Leave
        showusername()
    End Sub


End Class