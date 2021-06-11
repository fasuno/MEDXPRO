﻿Imports System.Data.SqlClient

Public Class CompanyInfo
    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Public Sub ExecuteQuery(query As String)
        Dim cmd As New SqlCommand(query, con)
        con.Close()

        con.Open()
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Dim updateQuery As String = "Update Companyinfo Set  Name= '" & Txtcompname.Text & "', Address= '" & txtadd.Text & "', Phone= '" & txtemail.Text & "' WHERE ID = '" & lblid.Text & "'"

        ExecuteQuery(updateQuery)

        MessageBox.Show("COMPANY DETAILS SUCCESSFULLY EDITED")

    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        Txtcompname.Text = ""
        txtadd.Text = ""
        txtphone.Text = ""
        txtemail.Text = ""
    End Sub

    Public Sub showCompDetails()

        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from Companyinfo", con)

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then


            Txtcompname.Text = tbl.Rows(0)(0).ToString()
            txtadd.Text = tbl.Rows(0)(1).ToString()
            txtphone.Text = tbl.Rows(0)(2).ToString()
            txtemail.Text = tbl.Rows(0)(3).ToString()
            lblid.Text = tbl.Rows(0)(4).ToString()

        Else
        End If

    End Sub

    Private Sub CompanyInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showCompDetails()
    End Sub
End Class
