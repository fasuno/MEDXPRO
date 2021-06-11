Imports System.Data.SqlClient

Public Class NurseReport

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If Txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "Medxpro")
            Txtnote.Focus()
        ElseIf Txtnote.Text = "" Then
            MsgBox("REPORT FIELD IS EMPTY", MsgBoxStyle.Information, "Medxpro")
            Txtnote.Focus()
        Else
            Try

                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "insert into NurseReport Values ('" & FrmAdmitFolder.LbladmitID.Text & "','" & FrmAdmitFolder.Lblhospnum.Text & "', '" & frmMain.lbldate.Text & "', '" & frmMain.lbltime.Text & "', '" & Txtnote.Text & "', '" & lblnursename.Text & "')"

                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()


            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            con.Close()
            Txtnote.Text = ""
        End If

        LoadDischargedPT()
    End Sub

    Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            lblnursename.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            Txtpass.Focus()


        Else

        End If
    End Sub

    Private Sub Txtpass_Leave(sender As Object, e As EventArgs) Handles Txtpass.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub LoadDischargedPT()

        Dim tb As New DataTable
        cmd = New SqlCommand("Select Date, Time, Report, Reported_By FROM NurseReport WHERE Admission_ID='" & FrmAdmitFolder.LbladmitID.Text & "'", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        Dtgreport.DataSource = tb

    End Sub

End Class
