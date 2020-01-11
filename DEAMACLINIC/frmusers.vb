Imports System.Data.SqlClient

Public Class frmusers

    'Dim Con As New SqlConnection("Server=HAVILAH-PC; DAtabase=DEAMACLINIC; Integrated Security=true")

    ' establish a query  execution command
    Public Sub ExecuteQuery(query As String)
        Dim cmd As New SqlCommand(query, Con)
        con.Close()

        con.Open()
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        Me.Hide()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        con.Open()

        Dim cmd As New SqlCommand("Select * from UsersReg where Username = @User", con)

        cmd.Parameters.AddWithValue("@User", txtusername.Text)

        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("THE USERNAME ALREADY EXIST, PLEASE CHOOSE ANOTHER", MsgBoxStyle.Information, "NEW USER")
            txtusername.Text = ""
            txtusername.Focus()

            con.Close()

        Else
            dr.Close()

            Try
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "INSERT INTO  UsersReg VALUES('" & txtid.Text & "', '" & txtfullname.Text & "', '" & txtusername.Text & "', '" & txtpassword.Text & "','" & cbodept.Text & "', '" & cborole.Text & "')"

            cmd.Connection = con
                cmd.ExecuteNonQuery()

                MsgBox("NEW USER CREATED", MsgBoxStyle.Information, "NEW USER")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

            txtid.Text = ""
        txtfullname.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        cborole.Text = ""
        cbodept.Text = ""
        txtid.Focus()

        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        Dim updateQuery As String = "Update UsersRwg Set  User_id= '" & txtid.Text & "', Full_name = '" & txtfullname.Text & "', Username = '" & txtusername.Text & "', Password = '" & txtpassword.Text & "', Department= '" & cbodept.Text & "', Role= '" & cborole.Text & "', WHERE User_id = '" & txtid.Text & "'"

        ExecuteQuery(updateQuery)

        MessageBox.Show("User Details Edited Successfully")

        txtid.Text = ""
        txtfullname.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        cbodept.Text = ""
        cborole.Text = ""

    End Sub

    Private Sub txtusername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        '// This will add the texh on label17 @havilah.com to the useername.

        ' Dim a As String

        'a = txtusername.Text + Label7.Text
        'txtusername.Text = a
    End Sub

    Public Sub checkusername()


        con.Open()
        cmd = New SqlCommand("Select * from UsersReg where Username=@user", Con)

        cmd.Parameters.AddWithValue("@user", txtusername.Text)
        Using dtr As SqlDataReader = cmd.ExecuteReader

            '// If it Then exist show message Erase hospital number textbox For New entry

            If dtr.HasRows Then
                MsgBox("The USERNAME already exist", MsgBoxStyle.Information, "USERS REGISTRATION")
                txtusername.Text = ""
                txtusername.Focus()

            Else
                dtr.Close()


                '//Close the datareader and insert the following data when the save button is hit again


                'con.Close()
            End If
        End Using

    End Sub


End Class