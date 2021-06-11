Imports System.Data.SqlClient

Public Class FrmRadrequest

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Public Sub CboclinicItems()
        Me.cboclinic.Items.Add("ART")
        Me.cboclinic.Items.Add("ANC")
        Me.cboclinic.Items.Add("GYNAE")
        Me.cboclinic.Items.Add("GOPD")
        Me.cboclinic.Items.Add("MOPD")
        Me.cboclinic.Items.Add("POPD")
        Me.cboclinic.Items.Add("SOPD")
        Me.cboclinic.Items.Add("DENTAL")
        Me.cboclinic.Items.Add("ORTHOPAEDIC")
        Me.cboclinic.Items.Add("NEUROLOGY")
        Me.cboclinic.Items.Add("UROLOGY")
        Me.cboclinic.Items.Add("DERMATOLOGY")
        Me.cboclinic.Items.Add("PHYSIOTHERAPY")
        Me.cboclinic.Items.Add("EPU")

    End Sub

    Public Sub generatenum()

        Try

            '// This code will automatically generate Request number from the database and show it in the textbox
            '// It picks the maximum value in the table and increment it by one.
            con.Open()

            cmd = New SqlCommand("Select  MAX(Request_Num) from RadRequestAndResult", con)


            Dim dt As SqlDataReader = cmd.ExecuteReader
            If dt.Read = True Then
                'Me.txtRqstNum.Text = dt.Item(0) + 1

                For Cols As Integer = 0 To dtgRadrequest.Rows.Count() - 1
                    dtgRadrequest.Rows(Cols).Cells(0).Value = dt.Item(0) + 1
                Next

                dt.Close()

            Else

                ' con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lblsendername.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpassword.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            txtpassword.Focus()


        Else

        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        CheckPassowrd()
        showusername()
    End Sub

    Public Sub PopulatePendRadRequest()
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Pend_RadRequest Values ('" & dtgRadrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmPtRecords.Lblhopnum.Text & "', '" & FrmPtRecords.Lblsurname.Text & "', '" & FrmPtRecords.Lblothernmaes.Text & "',  '" & FrmPtRecords.lblage.Text & "', '" & FrmPtRecords.lblsex.Text & "', '" & FrmPtRecords.lblacct.Text & "','" & FrmPtRecords.Profile1.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveRadRequest()
        generatenum()
        PopulatePendRadRequest()

        Try

            For Each row As DataGridViewRow In dtgRadrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO RadRequestAndResult VALUES(@RqstNum, @Date, @Time, @InvName, @Comm, @Hospnum, @Surname, @Othernames, @Age, @Sex, @Account, @Accntcat, @Clinic, @Diag, @PrescBY, @rlt, @dtrprt, @timrprt, @rptdBy,@stat)", con)


                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.


                        cmd.Parameters.AddWithValue("@RqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@InvName", row.Cells("Investgtn").Value) '// Insert the value in the Datagridview Investigation cell
                        cmd.Parameters.Add("@Comm", SqlDbType.VarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@Hospnum", SqlDbType.VarChar).Value = FrmPtRecords.Lblhopnum.Text
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = FrmPtRecords.Lblsurname.Text
                        cmd.Parameters.Add("@Othernames", SqlDbType.VarChar).Value = FrmPtRecords.Lblothernmaes.Text
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmPtRecords.lblage.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmPtRecords.lblsex.Text
                        cmd.Parameters.Add("@Account", SqlDbType.VarChar).Value = FrmPtRecords.lblacct.Text
                        cmd.Parameters.Add("@Accntcat", SqlDbType.VarChar).Value = FrmPtRecords.Profile1.txtprov.Text
                        cmd.Parameters.Add("@Clinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@PrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '//this below will send a null value to the fields in sqlserver
                        cmd.Parameters.Add("@timrprt", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Dtrprt", SqlDbType.Date).Value = DBNull.Value
                        cmd.Parameters.Add("@rlt", SqlDbType.NVarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@rptdby", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Stat", SqlDbType.VarChar).Value = DBNull.Value



                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("RADIOLOGY REQUEST SENT", vbOKOnly, "RADIOLOGY REQUEST")

            dtgRadrequest.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnsendrequest_Click(sender As Object, e As EventArgs) Handles btnsendrequest.Click

        '// This code is a really breakthru for me and I thank God The father for The gift Of the Holy Spirit who taught me
        '// This code will export all the datat in a datagridview to a textbox all at once.

        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "RADIOLOGY REQUEST")
            cboclinic.Focus()

        ElseIf txtdiagn.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "RADIOLOGY REQUEST")
            txtdiagn.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "RADIOLOGY REQUEST")
            txtpassword.Focus()

        Else

            For cols As Integer = 0 To dtgRadrequest.Rows.Count - 1 Step ++1

                frmGenConsult.TxtRadinv.Text = frmGenConsult.TxtRadinv.Text + "\\" + dtgRadrequest.Rows(cols).Cells(1).Value '// This target cell 1 only

                frmGenConsult.TxtRadinv.Text = frmGenConsult.TxtRadinv.Text + "."
            Next

            SaveRadRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""


        End If
        FrmRadiology.SortPendRadRqst()
        FrmPtRecords.PtRadHist1.LoadRAdilogicalHx()
        con.Close()
    End Sub

    Private Sub btnaddInv_Click(sender As Object, e As EventArgs) Handles btnaddInv.Click

        dtgRadrequest.Rows.Add(txtRqstNum.Text, txtInvType.Text) '//txtnul is to hold empty values for the colums

        txtInvType.Text = ""
        txtInvType.Focus()

    End Sub

    Private Sub FrmRadrequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldate.Text = Date.Now.Date
        lbltime.Text = TimeOfDay

        CboclinicItems() '// loads clinic to combobox at form load event

    End Sub

    Public Sub LoadRAdlist()
        '// This code loads the drugs list to the textbox and allow the textbox to perform autocomplete function
        Try

            Dim tbl As New DataTable
            cmd = New SqlCommand("Select INVESTIGATION from Xray_ScanList", con)


            adapt = New SqlDataAdapter(cmd)

            con.Open()   ' Open connection

            adapt.Fill(tbl)

            Dim rw As DataRow

            txtInvType.AutoCompleteCustomSource.Clear()

            For Each rw In tbl.Rows
                txtInvType.AutoCompleteCustomSource.Add(rw.Item(0).ToString)
            Next

            'generatenum()

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

        Me.dtgRadrequest.Rows.Clear()
    End Sub

    '//This is for ANC 
    Public Sub PopulateANCRadRequest()

        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into Pend_RadRequest Values ('" & dtgRadrequest.Rows(0).Cells(0).Value & "', '" & lbldate.Text.ToString & "', '" & lbltime.Text.ToString & "', '" & FrmANCform.lblhospnum.Text & "', '" & FrmANCform.AncProfile2.Txtsurname.Text & "', '" & FrmANCform.AncProfile2.txtothernames.Text & "',  '" & FrmANCform.AncProfile2.txtyear.Text & "', '" & FrmANCform.AncProfile2.txtsex.Text & "', '" & FrmANCform.AncProfile2.txtaccount.Text & "', '" & FrmANCform.AncProfile2.txtprov.Text & "', '" & cboclinic.Text.ToString & "', '" & txtdiagn.Text & "', '" & lblsendername.Text.ToString & "')"

            cmd.Connection = con
            ' con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Public Sub SaveANCRadRequest()

        generatenum()

        PopulateANCRadRequest()

        Try

            For Each row As DataGridViewRow In dtgRadrequest.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO RadRequestAndResult VALUES(@RqstNum, @Date, @Time, @InvName, @Comm, @Hospnum, @Surname, @Othernames, @Age, @Sex, @Account, @Acctcat, @Clinic, @Diag, @PrescBY, @rlt, @dtrprt, @timrprt, @rptdBy,@stat)", con)


                        '// This insertion styles is a combination of datagridview values and other objects such as textboxex and label
                        '// All will be inserted alongside the values in Drugs presc form dtagridviews rows all at once.


                        cmd.Parameters.AddWithValue("@RqstNum", row.Cells("Request_Num").Value) '// Insert the value in the Datagridview requst num cell
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = lbldate.Text
                        cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = lbltime.Text
                        cmd.Parameters.AddWithValue("@InvName", row.Cells("Investgtn").Value) '// Insert the value in the Datagridview Investigation cell
                        cmd.Parameters.Add("@Comm", SqlDbType.VarChar).Value = txtcomment.Text
                        cmd.Parameters.Add("@Hospnum", SqlDbType.VarChar).Value = FrmANCform.lblhospnum.Text
                        cmd.Parameters.Add("@Surname", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.Txtsurname.Text
                        cmd.Parameters.Add("@Othernames", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtothernames.Text
                        cmd.Parameters.Add("@Age", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtyear.Text
                        cmd.Parameters.Add("@Sex", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtsex.Text
                        cmd.Parameters.Add("@Account", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtaccount.Text
                        cmd.Parameters.Add("@Acctcat", SqlDbType.VarChar).Value = FrmANCform.AncProfile2.txtprov.Text
                        cmd.Parameters.Add("@Clinic", SqlDbType.VarChar).Value = cboclinic.Text
                        cmd.Parameters.Add("@Diag", SqlDbType.VarChar).Value = txtdiagn.Text
                        cmd.Parameters.Add("@PrescBY", SqlDbType.VarChar).Value = lblsendername.Text

                        '//this below will send a null value to the fields in sqlserver
                        cmd.Parameters.Add("@timrprt", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Dtrprt", SqlDbType.Date).Value = DBNull.Value
                        cmd.Parameters.Add("@rlt", SqlDbType.NVarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@rptdby", SqlDbType.VarChar).Value = DBNull.Value
                        cmd.Parameters.Add("@Stat", SqlDbType.VarChar).Value = DBNull.Value



                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            Next

            MsgBox("RADIOLOGY REQUEST SENT", vbOKOnly, "RADIOLOGY REQUEST")

            dtgRadrequest.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSndAncRad_Click(sender As Object, e As EventArgs) Handles BtnSndAncRad.Click

        If cboclinic.Text = "" Then
            MsgBox("PLEASE SELECT CLINIC", MsgBoxStyle.Information, "RADIOLOGY REQUEST")
            cboclinic.Focus()

        ElseIf txtdiagn.Text = "" Then
            MsgBox("PLEASE ENTER YOUR DIAGNOSIS", MsgBoxStyle.Information, "RADIOLOGY REQUEST")
            txtdiagn.Focus()

        ElseIf txtpassword.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "RADIOLOGY REQUEST")
            txtpassword.Focus()

        Else

            SaveANCRadRequest()

            Me.Close()
            txtpassword.Text = ""
            lblsendername.Text = ""
            txtdiagn.Text = ""


        End If
        FrmRadiology.SortPendRadRqst()
        FrmPtRecords.PtRadHist1.LoadRAdilogicalHx()
        con.Close()

    End Sub



End Class