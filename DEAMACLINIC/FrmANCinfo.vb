Imports System.Data.SqlClient
Public Class FrmANCinfo

    Public Sub ExecuteQuery(query As String)

        Dim cmd As New SqlCommand(query, con)

        'con.Close() ' This is use to close the connection after the execution of the (datareader)
        ' and then open the connection again as shown below for the execution of query comand.

        ' con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub Btnaddentry_Click(sender As Object, e As EventArgs) Handles Btnaddentry.Click
        If DtDeliv.Value.Date >= Now.Date Then
            MsgBox("PLEASE CHOOSE A CORRECT DELIVERY DATE", MsgBoxStyle.Critical, "ANC")
        Else

            DTgpreg.Rows.Add(FrmANCform.lblbkid.Text, FrmANCform.lblhospnum.Text, DtDeliv.Value.ToShortDateString, txtduration.Text, txtcompl.Text, txtlabor.Text, cbosex.Text, txtppm.Text, txtweight.Text)

            txtweight.Text = ""
            txtcompl.Text = ""
            txtlabor.Text = ""
            cbosex.Text = ""
            txtppm.Text = ""
            txtweight.Text = ""
            txtduration.Text = ""


        End If
    End Sub

    Public Sub SavePrevPregnancyHX()

        Try
            For Each row As DataGridViewRow In DTgpreg.Rows

                Using con As New SqlConnection(constring)
                    Using cmd As New SqlCommand("INSERT INTO ANCPREVPREG VALUES(@Bid, @Hnum, @DelDt, @Dura, @Com, @Labr, @Sexx, @Puepn, @Bw, @user)", con)

                        cmd.Parameters.AddWithValue("@Bid", row.Cells("Bkid").Value) '// Insert the value in the Datagridview presc num cell
                        cmd.Parameters.AddWithValue("@Hnum", row.Cells("HospNo").Value)
                        cmd.Parameters.AddWithValue("@Deldt", row.Cells("Delvdate").Value) '// Insert the value in the Datagridview Drug name cell
                        cmd.Parameters.AddWithValue("@Dura", row.Cells("Dur").Value)
                        cmd.Parameters.AddWithValue("@Com", row.Cells("Comp").Value)
                        cmd.Parameters.AddWithValue("@Labr", row.Cells("Lab").Value)
                        cmd.Parameters.AddWithValue("@Sexx", row.Cells("Sex").Value)
                        cmd.Parameters.AddWithValue("@Puepn", row.Cells("Puep").Value)
                        cmd.Parameters.AddWithValue("@Bw", row.Cells("Bthw").Value)
                        cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = lbluser.Text

                        con.Open()
                        cmd.ExecuteNonQuery()
                        ' con.Close()
                    End Using
                End Using
            Next

            DTgpreg.Rows.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub SAveBooking()
        Try

            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "insert into ANCBooking Values ('" & FrmANCform.lblbkid.Text & "','" & FrmANCform.lblhospnum.Text & "',  '" & DtBooked.Value & "', '" & DtLMP.Value & "', '" & DtEDD.Value & "', '" & txtGrav.Text & "', '" & TxtPar.Text & "', '" & txtindication.Text & "', '" & Txtspecpoint.Text & "', '" & Txtconsultant.Text & "', '" & txtbleed.Text & "', '" & Txtdisch.Text & "', '" & TxtSwell.Text & "', '" & TxtUsymp.Text & "', '" & TxtOsympt.Text & "', '" & TxtGencond.Text & "', '" & TxtBres.Text & "', '" & Txtcvc.Text & "', '" & TxtAbdom.Text & "', '" & TxtxRs.Text & "', '" & Txtpelvis.Text & "', '" & Txtothers.Text & "', '" & cbogen.Text & "', '" & CboBldgp.Text & "', '" & CboGrpRH.Text & "', '" & Txtretrov.Text & "','" & TxtVdrl.Text & "','" & TxtHb.Text & "', '" & txtBP.Text & "', '" & Txturin.Text & "', '" & Txtheight.Text & "', '" & Txtwght.Text & "', '" & TxtPeupInstr.Text & "', '" & TxtHtDis.Text & "', '" & TxtChestDis.Text & "', '" & TxtKidnDis.Text & "', '" & TxtBldTrans.Text & "', '" & TxtOper.Text & "', '" & TxtMultPre.Text & "', '" & Txttuber.Text & "', '" & TxtHyper.Text & "', '" & Txtothers.Text & "', '" & lbluser.Text & "', '" & txtdelivsta.Text & "')"

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        con.Close()
    End Sub

    Private Sub DtLMP_ValueChanged(sender As Object, e As EventArgs) Handles DtLMP.ValueChanged
        '// To Compute the expeted delivery date, Oxford handbook suugest this callculation
        '//Usual cycle length; LMP (a normal period?); Naegele's rule: expected delivery date â‰ˆ1yr and 7 days after LMP minus 3 monthsâ€”
        '//(not if last period a Pill withdrawal bleed; for cycles shorter than 28 days subtract the difference from 28; 
        '//If longer Then, add the difference from 28). 
        '// A revised rule suggests the addition Of 10 days rather than 7 Is more accurate.
        '// I adopt the revise rule here.

        '====Prevent Users from selecting future date for LMP.

        If DtLMP.Value > DateTime.Today Then
            MsgBox("YOU CANNOT CHOOSE FUTURE DATE", MsgBoxStyle.Critical, "INVALID LMP DATE")
            DtLMP.MaxDate = DateTime.Today
            DtLMP.Focus()
        Else
            '=======================
            Dim d As Date = DtLMP.Value
            Dim b As Date
            d = d.AddDays(+375)
            b = d.AddDays(-90)
            DtEDD.Value = b

            '// Now To get the Geatstational  Age, is the age of the pregnancy from the last normal menstrual period (LMP)
            '// I also Add this to the LOad event of the ANCbooking form, so the it will be gotten base on the LMP date loaded

            Dim d1, d2 As Date
            Dim tt As TimeSpan
            Dim ga As Integer
            d1 = DtLMP.Value
            d2 = Now.Date
            tt = d2 - d1
            ga = tt.Days / 7

            Txtgest.Text = ga

        End If
    End Sub

    Private Sub FrmANCinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '// Now To get the Geatstational  Age, is the age of the pregnancy from the last normal menstrual period (LMP)


        Dim d1, d2 As Date
        Dim tt As TimeSpan
        Dim ga As Integer
        d1 = DtLMP.Value
        d2 = Now.Date
        tt = d2 - d1
        ga = tt.Days / 7

        Txtgest.Text = ga

    End Sub

    Public Sub showusername()
        '// This method is use to know the name of the doctor and save the name on the DOCTOR column once the password is correct
        cmd = New SqlCommand("Select * from UsersReg where Password=@pass", con)
        cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            lbluser.Text = tbl.Rows(0)(1).ToString()

        Else


        End If

    End Sub

    Public Sub CheckPassowrd()

        cmd = New SqlCommand("Select * from UsersReg where Password = @password", con)

        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpass.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        '// Check the Usersreg table for entry, it the password is wrong show message below

        If tbl.Rows.Count() <= 0 Then
            MsgBox("Invalid Paswword", MsgBoxStyle.Critical, "User Validation")
            txtpass.Focus()


        Else

        End If
    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs)
        CheckPassowrd()
        showusername()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtpass.Text = "" Then
            MsgBox("PLEASE ENTER YOUR PASSWORD", MsgBoxStyle.Information, "ANC")

        Else

            Dim msg As String

            msg = MsgBox("ARE YOU SURE YOU WANT TO SAVE DETAILS ?", vbYesNo, "ANC")

            If msg = vbYes Then

                SAveBooking()
                SavePrevPregnancyHX()

                MsgBox("PATIENT BOOKING DETAILS SAVED SUCCESSFULLY", MsgBoxStyle.Information, "ANC")
                Me.Close()
            Else
                TxtPar.Focus()

            End If
        End If

    End Sub

    '//

End Class