Imports System.Data.SqlClient
Public Class FrmLabInvRqst
    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub FrmLabInvRqst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldte.Text = Date.Now.Date
        lbltim.Text = TimeOfDay
        BillPercentage()
        ShowPAtientTest()
        GetTotalCost()
    End Sub

    Public Sub ShowPAtientTest()

        Dim adapt As New SqlDataAdapter
        Dim Utbl As New DataTable

        With Me
            cmd = New SqlCommand("Select LabRequest.Test_Name, LabRequest.Comment, LAB_LIST.Cost FROM  LabRequest INNER JOIN LAB_LIST On LabRequest.Test_Name = LAB_LIST.TEST_NAME WHERE LabRequest.Request_Num=@RqstId", con)

            cmd.Parameters.Add("@RqstId", SqlDbType.Int).Value = frmLABORATORY.DtgPendLabReqst.CurrentRow.Cells(0).Value

            adapt = New SqlDataAdapter(cmd)

            adapt.Fill(Utbl)
            DtgPtLabTest.DataSource = Utbl
            DtgPtLabTest.AutoResizeColumns()
            DtgPtLabTest.ReadOnly = True

            BillPercentage()

            '''''''''''''''''''''''''''''

        End With

    End Sub

    Public Sub BillPercentage()

        cmd = New SqlCommand("Select * from BillSetting where Account_type=@Acct", con)
        cmd.Parameters.Add("@Acct", SqlDbType.NVarChar).Value = txtacct.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the percentage

            Txtperc.Text = tbl.Rows(0)(1).ToString()

        Else
        End If

        '// GEt the percenage of the price

        For s As Integer = 0 To DtgPtLabTest.Rows.Count() - 1
            DtgPtLabTest.Rows(s).Cells(2).Value = DtgPtLabTest.Rows(s).Cells(2).Value * Val(Txtperc.Text) / 100
            ' LblTotalcost.Text = DtgPtLabTest.Rows(s).Cells(2).Value
        Next

    End Sub  '/// Calculate Patients bill base on patient's account type

    Public Sub GetTotalCost()

        Dim Bill As Integer = 0
        For s As Integer = 0 To DtgPtLabTest.Rows.Count() - 1
            Bill += Val(DtgPtLabTest.Rows(s).Cells(2).Value)

        Next

        LblTotalcost.Text = Bill.ToString '("#,#")
    End Sub

    Public Sub showLabAttendatName()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person Full Name

            lblbilledby.Text = tbl.Rows(0)(1).ToString()

        Else
        End If

    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @Pass", con)

        cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtpword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            txtpword.Focus()


        Else

        End If
    End Sub

    Private Sub txtpword_Leave(sender As Object, e As EventArgs) Handles txtpword.Leave
        showLabAttendatName()
        CheckPassowrd()
    End Sub

    Public Sub PopulatePendLabBill()
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Pend_LABBill Values ('" & Txtrqstid.Text & "', '" & lbldte.Text.ToString & "', '" & lbltim.Text.ToString & "', '" & txtHno.Text & "', '" & TxtSname.Text & "', '" & txtOname.Text & "',  '" & txtage.Text & "', '" & txtsex.Text & "', '" & txtacct.Text & "', '" & LblTotalcost.Text & "', '" & lblbilledby.Text & "', '" & LblPayStatus.Text & "','" & txtrqstby.Text & "', '" & txtdate.Text & "')"

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub PopulatePendingBills()
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into PendingBills Values ('" & Txtrqstid.Text & "', '" & lbldte.Text.ToString & "', '" & lbltim.Text.ToString & "', '" & txtHno.Text & "', '" & TxtSname.Text & "', '" & txtOname.Text & "', '" & LblTotalcost.Text & "',  '" & lbllab.Text & "', '" & txtacct.Text & "', '" & lblbilledby.Text & "')"

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub  '// This is the Table that Cashiers will see

    Public Sub SaveToAllLabBill()

        Try

            For Each row As DataGridViewRow In DtgPtLabTest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO AllLABBilled VALUES(@RqstID, @Dte, @Tim, @Hnum, @Sname, @Onames, @TestName, @Comm, @Age, @Sex, @Acnt, @cost, @BBy, @Rby, @Service, @PayStat)", con)

                        cmd.Parameters.Add("@RqstID", SqlDbType.Int).Value = Txtrqstid.Text
                        cmd.Parameters.Add("@Dte", SqlDbType.Date).Value = lbldte.Text
                        cmd.Parameters.Add("@Tim", SqlDbType.VarChar).Value = lbltim.Text
                        cmd.Parameters.Add("@Hnum", SqlDbType.VarChar).Value = txtHno.Text
                        cmd.Parameters.Add("@Sname", SqlDbType.VarChar).Value = TxtSname.Text
                        cmd.Parameters.Add("@Onames", SqlDbType.VarChar).Value = txtOname.Text
                        cmd.Parameters.AddWithValue("@TestName", row.Cells("Test_Name").Value)
                        cmd.Parameters.AddWithValue("@Comm", row.Cells("Comment").Value)
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = txtage.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = txtsex.Text
                        cmd.Parameters.Add("@Acnt", SqlDbType.VarChar).Value = txtacct.Text
                        ' cmd.Parameters.AddWithValue("@Qtygvn", row.Cells("Qty_given").Value)
                        cmd.Parameters.AddWithValue("@cost", row.Cells("COST").Value)
                        'cmd.Parameters.Add("@cost", SqlDbType.Int).Value = DtgPtLabTest.Rows(0).Cells(2).Value
                        ' cmd.Parameters.AddWithValue("@Tcost", row.Cells("Total_Cost").Value)
                        cmd.Parameters.Add("@BBY", SqlDbType.VarChar).Value = lblbilledby.Text
                        cmd.Parameters.Add("@RBY", SqlDbType.VarChar).Value = txtrqstby.Text
                        cmd.Parameters.Add("@Service", SqlDbType.VarChar).Value = lbllab.Text
                        cmd.Parameters.Add("@PayStat", SqlDbType.VarChar).Value = LblPayStatus.Text


                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("PATIENT BILL SENT", vbOKOnly, "LABORATORY")



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub RemoveFromPendLabRqst()

        Dim Delquery As String = " Delete From Pend_LabRequest Where Hospital_No = '" & txtHno.Text & "' AND Request_Num='" & Txtrqstid.Text & "'"

        ExecuteQuery(Delquery)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        PopulatePendLabBill()
        PopulatePendingBills()
        SaveToAllLabBill()
        RemoveFromPendLabRqst()
        frmLABORATORY.SortPendlabRqst()
        frmLABORATORY.SortPendlabBill()
        frmCashier.sortPendingBilss()
        txtpword.Text = ""
        Me.Close()
    End Sub

End Class