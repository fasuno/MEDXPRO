
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmRADResult
    Public Sub LoadPatientRadInestigation()

        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Investigation, Status, Reported_By FROM VwRadRequestAndResult Where Request_Num=@Rqnum", con)
        cmd.Parameters.Add("Rqnum", SqlDbType.Int).Value = FrmRadiology.DtgRadBilled.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Dtgradinvest.DataSource = tbls
        Dtgradinvest.AutoResizeColumns()
 
        Dtgradinvest.Columns(2).Visible = False

    End Sub

    Public Sub showusername()
        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = TxtPass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim mtbl As New DataTable()

        adpt.Fill(mtbl)

        If mtbl.Rows.Count() > 0 Then

            'Display the person data

            Lblreprtby.Text = mtbl.Rows(0)(1).ToString()
            TxtPass.Text = ""

        Else
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            TxtPass.Focus()

        End If

    End Sub

    Private Sub frmRADResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbldte.Text = Now.Date
        lbltim.Text = TimeOfDay
        LoadPatientRadInestigation()

        TxtRadresult.Text = ""
        TxtRadresult.Focus()
        lblinvest.Text = ""
        TxtRadresult.Enabled = False
        TxtPass.Text = ""
        Lblreprtby.Text = ""

    End Sub

    Private Sub Dtgradinvest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgradinvest.CellClick

        cmd = New SqlCommand("Select * from VwRadRequestAndResult Where Request_Num=@Rqstno AND investigation=@inv", con) '//instead of ALLRADBILL
        cmd.Parameters.Add("Rqstno", SqlDbType.Int).Value = Lblrqstnum.Text
        cmd.Parameters.Add("inv", SqlDbType.VarChar).Value = Dtgradinvest.CurrentRow.Cells(0).Value

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            TxtRadresult.Text = tbl.Rows(0)(19).ToString()

            lblinvest.Text = Dtgradinvest.CurrentRow.Cells(0).Value.ToString
            Lblreprtby.Text = Dtgradinvest.CurrentRow.Cells(2).Value.ToString

            TxtRadresult.Enabled = True


        Else
        End If

    End Sub

    Public Sub ExecuteQuery(query As String)
        con.Close()
        Dim cmd As New SqlCommand(query, con)

        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub Btncls_Click(sender As Object, e As EventArgs)

        If TxtPass.Text = "" Then
            MsgBox("ENTER YOUR PASSWORD", vbCritical, "RADIOLOGY")

            ' TxtPass.Focus()

        Else
            'showusername()


            Me.Close()

        End If
        con.Close()

    End Sub

    Private Sub TxtPass_Leave(sender As Object, e As EventArgs) Handles TxtPass.Leave

        If TxtPass.Text = "" Then
            MsgBox("PLEASE ENTER PASSWORD", MsgBoxStyle.Critical, "User Validation")
        Else

            showusername()


            '  Try
            ' Dim Updat As String = ("Update AllRADBilled Set Result='" & TxtRadresult.Text.ToString & "', Date_Reported='" & lbldte.Text.ToString & "', Time_Reported='" & lbltim.Text.ToString & "', Reported_By='" & Lblreprtby.Text.ToString & "' WHERE Request_Num='" & Lblrqstnum.Text.ToString & "' AND Investigation='" & lblinvest.Text.ToString & "'")

            'con.Open()
            'ExecuteQuery(Updat)
            'con.Close()

            'Catch ex As Exception
            'MessageBox.Show(ex.Message)
            'TxtRadresult.Focus()

            'End Try
        End If
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        If chkcomp.CheckState = CheckState.Checked Then

            Dim msg = MsgBox("ARE YOU SURE YOU WANT TO SAVE ?", MsgBoxStyle.YesNo, "RADIOLOGY")
            If msg = MsgBoxResult.Yes Then

                UpdateREsult()
                'MsgBox("Pease Click on the Complete Checkbox if all Report(s) are Ready. Else Click on close", vbOKOnly, "RADIOLOGY")

                RemovefromBilled()
                FrmRadiology.SortPendRADBill()
                FrmRadiology.SortTreatedList()
                Me.Close()

            Else
                TxtPass.Focus()
            End If

        ElseIf chkcomp.Checked = False Then
            UpdateREsult()
            FrmRadiology.SortPendRADBill()
        End If

    End Sub

    Public Sub RemovefromBilled()

        Dim Delquery As String = " Delete From Pend_RADBill Where Request_Num = '" & Lblrqstnum.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Public Sub UpdateREsult()

        Try
            Dim Updat As String = ("Update RadRequestAndResult Set Result = '" & TxtRadresult.Text.ToString & "', Date_reported = '" & lbldte.Text & "', Time_reported = '" & lbltim.Text & "', Reported_by = '" & Lblreprtby.Text & "', Status='" & lbltrtd.Text.ToString & "' WHERE Request_Num='" & Lblrqstnum.Text & "' AND Investigation = '" & lblinvest.Text.ToString & "'")

            con.Open()
            ExecuteQuery(Updat)
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            TxtRadresult.Focus()

        End Try
        ' LoadPatientRadInestigation()
    End Sub

    Private Sub BTNcancel_Click(sender As Object, e As EventArgs) Handles BTNcancel.Click
        Me.Close()

    End Sub

    Private Sub frmRADResult_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dtgradinvest.DataSource = Nothing
        lblinvest.Text = ""
    End Sub

    Private Sub TxtRadresult_Leave(sender As Object, e As EventArgs) Handles TxtRadresult.Leave
        If TxtRadresult.Text = "" Then
            TxtRadresult.Focus()
        Else

            Dim msg = MsgBox("DO YOU WANT TO SAVE YOUR ENTRIES", MsgBoxStyle.YesNo, "RADIOLOGY")
            If msg = MsgBoxResult.Yes Then
                TxtPass.Focus()
                Btnsave.Enabled = True

            Else
                TxtRadresult.Text = ""
                Me.Close()
            End If

        End If

    End Sub

    Private Sub chkcomp_CheckedChanged(sender As Object, e As EventArgs) Handles chkcomp.CheckedChanged
        If chkcomp.Checked = True Then
            Btnsave.Enabled = True
        Else
        End If
    End Sub

End Class