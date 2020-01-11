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

    Sub Showbookingdetails()

        cmd = New SqlCommand("Select * from ANCBooking where Hospital_Num=@Hosp_Num and Booking_ID=@Bkid", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = FrmANCform.lblhospnum.Text
        cmd.Parameters.Add("@Bkid", SqlDbType.Int).Value = FrmANCform.lblbkid.Text

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            dtbook.Value = tbl.Rows(0)(2)
            dtlmp.Value = tbl.Rows(0)(3)
            dtedd.Value = tbl.Rows(0)(4)
            txtgrav.Text = tbl.Rows(0)(5)
            txtpar.Text = tbl.Rows(0)(6)


        End If
        'ShowprevPreg()
    End Sub

    Public Sub removefrompending()

        Dim Delquery As String = " Delete From Pending_Vitals Where Hospital_No = '" & FrmANCform.lblhospnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Public Sub showusername()
        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtpassw.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person fullname

            lblusername.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub BtnDrugs_Click(sender As Object, e As EventArgs) Handles BtnDrugs.Click
        Dim frm = New FrmDrugsPresc
        frm.LoadDrugs()
        frm.ShowDialog()
    End Sub

    Private Sub btnLAB_Click(sender As Object, e As EventArgs) Handles btnLAB.Click
        Dim frms = New FrmLabrequest
        frms.LoadLAbTest()
        frms.ShowDialog()
    End Sub

    Private Sub BtnScan_Click(sender As Object, e As EventArgs) Handles BtnScan.Click
        Dim fr = New FrmRadrequest
        fr.LoadRAdlist()
        fr.ShowDialog()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtpassw.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "USER VALIDATION")

        Else

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
        End If


    End Sub

    Private Sub FrmANCfollowUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Showbookingdetails()

    End Sub


End Class