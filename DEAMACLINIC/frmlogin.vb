
Imports System.Data.SqlClient

Public Class frmlogin
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim Con As New SqlConnection("Server=HAVILAH; DAtabase=PROMEDDB; Integrated Security=true")
        Dim cmd As New SqlCommand("Select * from UsersReg where Username = @Username and Password = @password", Con)

        cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtusername.Text

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpassword.Text


        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() <= 0 Then
            MessageBox.Show("Invalid Username or Password")

            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        Else
            Me.Hide()
            frmMain.lblmail.Text = txtusername.Text
            frmMain.showusername()
        End If
    End Sub



End Class