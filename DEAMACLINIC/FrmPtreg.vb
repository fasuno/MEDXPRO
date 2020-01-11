Imports System.Data.SqlClient

Public Class FrmPtreg

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        '// This will check if an hospital number already exist in the database

        cmd = New SqlCommand("Select * from Pt_profile where Hospital_Num=@Hosp_Num", con)

        cmd.Parameters.Add("@hosp_num", SqlDbType.VarChar).Value = txthospnum.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim ctbl As New DataTable()
        adpt.Fill(ctbl)

        '// If it Then exist show message Erase hospital number textbox For New entry

        If ctbl.Rows.Count() > 0 Then
            MsgBox("Hospital Number has been used", MsgBoxStyle.Information, "Hospital number")
            txthospnum.Text = ""
            txthospnum.Focus()

        Else

            '// Call the Checkuser method   

            checkuser()      '// See the method to view code

        End If

        '// Call the reloaddtgfolder method to Refresh the folder datagrid

        reloaddtgfolder()

    End Sub

    Private Sub FrmPtreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Me.MdiParent = frmMain
        agecalc()
        'LoadAccountype()
    End Sub

    Private Sub btncls_Click(sender As Object, e As EventArgs) Handles btncls.Click
        Me.Close()
    End Sub

    Private Sub btncaution_Click(sender As Object, e As EventArgs) Handles btncaution.Click
        Dim input As String

        Try
            input = InputBox("Enter Special Precauition / Allegies", "Precaution", "")
            txtcaution.Text = (input.ToString)
        Catch ex As Exception
            MessageBox.Show("Invalid", "error", MessageBoxButtons.OK)

        End Try
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles Btnupdate.Click

        'con.Open() // Note" Connection must be closed, bcos i am calling the method 
        '// in the Save button command where i have the connection opened already


        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            txtpass.Focus()

        Else


            ' Try
            Dim Update As String = "Update Pt_profile Set  Surname= '" & txtsurname.Text & "', Other_Names='" & txtothernames.Text & "', Date_of_birth='" & dbo.Text.ToString & "', Age_in_Years='" & txtyear.Text & "',Age_in_Months='" & txtmonths.Text & "',Account_type='" & cboacct.Text & "',Date_Registered='" & regdate.Text.ToString & "',Sex='" & cbosex.Text & "',Marital_status='" & cbomarital.Text & "',Religion='" & cborelig.Text & "',Occupation='" & cbooccup.Text & "',LGA='" & cbolga.Text & "',State_of_origin='" & cbostate.Text & "',Nationality='" & cbonat.Text & "',Home_address='" & txtadd.Text & "',Phone='" & txtphone.Text & "',Email='" & txtemail.Text & "',Kin_Name='" & txtkinname.Text & "',Kin_Address='" & txtkinadd.Text & "',Kin_phone='" & txtkinphone.Text & "',Kin_relationship='" & cborelat.Text & "',Inssurance_provider='" & Txtprovi.Text & "',Enrolle_type='" & cboenrol.Text & "',Employer='" & txtemployer.Text & "',Enrolle_Number='" & txtenrolnum.Text & "',NIN='" & txtnin.Text & "',Non_Nigerian='" & txtstate.Text & "',Precaution='" & txtcaution.Text & "' WHERE Hospital_Num='" & txthospnum.Text & "'"
            ExecuteQuery(Update)

            MessageBox.Show("PATIENT PROFILE EDITED", "Update Profile", MessageBoxButtons.OK)

            'Call the reload method for folder datagrid to refresh datagrid
            reloaddtgfolder()

            ' Catch ex As Exception
            ' MessageBox.Show("", "UPDATE", MessageBoxButtons.OK)

            'End Try


            Me.Close()
        End If

    End Sub

    Public Sub LoadAccountype()

        Try

            Dim tbl As New DataTable
            cmd = New SqlCommand("Select Account_Type from BillSetting", con)


            adapt = New SqlDataAdapter(cmd)

            con.Open()   ' Open connection

            adapt.Fill(tbl)

            Dim rw As DataRow

            Txtprovi.AutoCompleteCustomSource.Clear()

            For Each rw In tbl.Rows
                Txtprovi.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Private Sub cboacct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboacct.SelectedIndexChanged
        If Me.cboacct.SelectedIndex = 1 Then

            Me.cboenrol.Enabled = True
            Me.Txtprovi.Enabled = True
            Me.txtenrolnum.Enabled = True
            Me.txtemployer.Enabled = True
            LoadAccountype() '// Load Account type

        ElseIf Me.cboacct.SelectedIndex = 0Then

            Txtprovi.Text = "Private"
            Me.cboenrol.Enabled = False
            Me.Txtprovi.Enabled = False
            Me.txtenrolnum.Enabled = False
            Me.txtemployer.Enabled = False

        End If
    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)
        con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub reloaddtgfolder()

        Dim tbl As New DataTable
        cmd = New SqlCommand("Select * from VwPtProfile", con)


        adapt = New SqlDataAdapter(cmd)

        'con.Open()   ' Open connection

        adapt.Fill(tbl)
        Frmrecords.Dtgfolder.DataSource = tbl
        con.Close()     '   I disable the close connection bcos i'm calling it in the save button where a connection is already open

    End Sub

    Public Sub checkuser()

        '// This method check if the password entere by the user is correct, if not
        '// it will show the error message "invalid password
        '// but if password is correct, it will save the data into the database

        Dim cmd As New SqlCommand("Select * from UsersReg where Password = @password", Con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpass.Text

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
                cmd.CommandText = "insert into Pt_Profile values ('" & txthospnum.Text & "', '" & txtsurname.Text & "', '" & txtothernames.Text & "', '" & dbo.Value & "', '" & txtyear.Text & "', '" & txtmonths.Text & "', '" & Txtdays.Text & "', '" & cboacct.Text & "', '" & regdate.Value & "', '" & cbosex.Text & "',  '" & cbomarital.Text & "', '" & cborelig.Text & "', '" & cbooccup.Text & "', '" & cbolga.Text & "', '" & cbostate.Text & "', '" & cbonat.Text & "', '" & txtadd.Text & "', '" & txtphone.Text & "', '" & txtemail.Text & "', '" & txtkinname.Text & "', '" & txtkinadd.Text & "', '" & txtkinphone.Text & "', '" & cborelat.Text & "', '" & Txtprovi.Text & "', '" & cboenrol.Text & "', '" & txtemployer.Text & "', '" & txtenrolnum.Text & "', '" & txtnin.Text & "', '" & txtstate.Text & "', '" & txtcaution.Text & "')"

                cmd.Connection = con

                con.Open()
                cmd.ExecuteNonQuery()

                MsgBox("New Patient Profile Created", MsgBoxStyle.Information, "New Folder")


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            con.Close()
            ' // Clear all textboxes for new entry
            dbo.Value = Now.Date
            txthospnum.Text = ""
            txtsurname.Text = ""
            txtothernames.Text = ""
            cboacct.Text = ""
            cboenrol.Text = ""
            cbolga.Text = ""
            cbomarital.Text = ""
            cbonat.Text = ""
            cbooccup.Text = ""
            Txtprovi.Text = ""
            cborelat.Text = ""
            cborelig.Text = ""
            cbosex.Text = ""
            cbostate.Text = ""
            cbonat.Text = ""
            txtadd.Text = ""
            txtemail.Text = ""
            Txtdays.Text = ""
            txtemployer.Text = ""
            txtenrolnum.Text = ""
            txthospnum.Text = ""
            txtkinadd.Text = ""
            txtkinname.Text = ""
            txtkinphone.Text = ""
            txtnin.Text = ""
            txtpass.Text = ""
            txtphone.Text = ""
            txtrecptnum.Text = ""
            txtstate.Text = ""
            txtcaution.Text = ""
            txtmonths.Text = ""
            txtyear.Text = ""
            txthospnum.Focus()

        End If

    End Sub

    Public Sub agecalc()

        Dim birthday As DateTime = dbo.Value.Date

        Dim intYears As Integer = DateDiff(DateInterval.Year, birthday, Today())
        If DateAdd(DateInterval.Year, intYears, birthday) > Today() Then intYears -= 1

        birthday = DateAdd(DateInterval.Year, intYears, birthday)

        Dim intMonths As Integer = DateDiff(DateInterval.Month, birthday, Today)
        If DateAdd(DateInterval.Month, intMonths, birthday) > Today Then intMonths -= 1

        birthday = DateAdd(DateInterval.Month, intMonths, birthday)

        Dim intDays As Integer = DateDiff(DateInterval.Day, birthday, Today)

        txtyear.Text = intYears.ToString
        Txtdays.Text = intDays.ToString
        txtmonths.Text = intMonths.ToString


        ' Convertion of datime to age in years and months

        ' Dim ageyr As Integer
        'Dim agemnt As Integer
        'ageyr = DateTime.Today.Year - dbo.Value.Year
        'agemnt = DateTime.Today.Month - dbo.Value.Month
        'txtyear.Text = ageyr.ToString()
        'txtmonths.Text = agemnt.ToString()

    End Sub

    Private Sub dbo_ValueChanged(sender As Object, e As EventArgs) Handles dbo.ValueChanged

        'call the age calculator method
        agecalc()
    End Sub


End Class




' TO DO
' Check if Password is correct and then put the name of the user in "Entry by" column
