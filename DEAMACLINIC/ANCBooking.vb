
Imports System.Data.SqlClient

Public Class ANCBooking
    Private Sub BtnNewBook_Click(sender As Object, e As EventArgs) Handles BtnNewBook.Click
        Dim frm = New FrmANCinfo
        frm.ShowDialog()

    End Sub

    Public Sub LoadAncBookings()
        '// This code will show all patients antenatal bokkings to grid
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select Booking_Date, Booking_ID, LMP, EDD, Consultant, Delivery_Status from ANCBooking WHERE Hospital_Num=@Hnum", con)
        cmd.Parameters.Add("@Hnum", SqlDbType.Int).Value = FrmANCform.lblhospnum.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)

        DtgAncbook.DataSource = tbl
        DtgAncbook.AutoResizeColumns()


    End Sub

    Private Sub ANCBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAncBookings()
    End Sub

    Sub ShowprevPreg()
        Dim tbl As New DataTable()
        cmd = New SqlCommand("Select Date_of_Delivery, Duration, Complication, Labour, Sex, Peuperium, Birth_Weight from ANCPREVPREG WHERE Booking_ID=@BknID And Hospital_num=@Hno", con)
        cmd.Parameters.Add("@BknID", SqlDbType.Int).Value = FrmANCform.AncBooking1.DtgAncbook.CurrentRow.Cells(1).Value
        cmd.Parameters.Add("@Hno", SqlDbType.Int).Value = FrmANCform.lblhospnum.Text

        Dim adpter As New SqlDataAdapter(cmd)
        adpter.Fill(tbl)
        FrmANCinfo.dtgprepreg.DataSource = tbl
        FrmANCinfo.dtgprepreg.AutoResizeColumns()

    End Sub

    Sub Showbookingdetails()

        cmd = New SqlCommand("Select * from ANCBooking where Hospital_Num=@Hosp_Num and Booking_ID=@Bkid", con)
        cmd.Parameters.Add("@Hosp_Num", SqlDbType.Int).Value = FrmANCform.lblhospnum.Text
        cmd.Parameters.Add("@Bkid", SqlDbType.Int).Value = FrmANCform.AncBooking1.DtgAncbook.CurrentRow.Cells(1).Value

        adapt = New SqlDataAdapter(cmd)
        Dim tbl As New DataTable

        adapt.Fill(tbl)
        If tbl.Rows.Count() > 0 Then

            FrmANCinfo.DtBooked.Value = tbl.Rows(0)(2)
            FrmANCinfo.DtLMP.Value = tbl.Rows(0)(3)
            FrmANCinfo.DtEDD.Value = tbl.Rows(0)(4)
            FrmANCinfo.txtGrav.Text = tbl.Rows(0)(5)
            FrmANCinfo.TxtPar.Text = tbl.Rows(0)(6)
            FrmANCinfo.txtindication.Text = tbl.Rows(0)(7)
            FrmANCinfo.Txtspecpoint.Text = tbl.Rows(0)(8)
            FrmANCinfo.Txtconsultant.Text = tbl.Rows(0)(9)
            FrmANCinfo.txtbleed.Text = tbl.Rows(0)(10)
            FrmANCinfo.Txtdisch.Text = tbl.Rows(0)(11)
            FrmANCinfo.TxtSwell.Text = tbl.Rows(0)(12)
            FrmANCinfo.TxtUsymp.Text = tbl.Rows(0)(13)
            FrmANCinfo.TxtOsympt.Text = tbl.Rows(0)(14)
            FrmANCinfo.TxtGencond.Text = tbl.Rows(0)(15)
            FrmANCinfo.TxtBres.Text = tbl.Rows(0)(16)
            FrmANCinfo.Txtcvc.Text = tbl.Rows(0)(17)
            FrmANCinfo.TxtAbdom.Text = tbl.Rows(0)(18)
            FrmANCinfo.TxtxRs.Text = tbl.Rows(0)(19)
            FrmANCinfo.Txtpelvis.Text = tbl.Rows(0)(20)
            FrmANCinfo.cbogen.Text = tbl.Rows(0)(22)
            FrmANCinfo.CboBldgp.Text = tbl.Rows(0)(23)
            FrmANCinfo.CboGrpRH.Text = tbl.Rows(0)(24)
            FrmANCinfo.Txtretrov.Text = tbl.Rows(0)(25)
            FrmANCinfo.TxtVdrl.Text = tbl.Rows(0)(26)
            FrmANCinfo.TxtHb.Text = tbl.Rows(0)(27)
            FrmANCinfo.txtBP.Text = tbl.Rows(0)(28)
            FrmANCinfo.Txturin.Text = tbl.Rows(0)(29)
            FrmANCinfo.Txtheight.Text = tbl.Rows(0)(30)
            ' FrmANCinfo.txtweight.Text = tbl.Rows(0)(31)
            FrmANCinfo.TxtPeupInstr.Text = tbl.Rows(0)(32)
            FrmANCinfo.TxtHtDis.Text = tbl.Rows(0)(33)
            FrmANCinfo.TxtChestDis.Text = tbl.Rows(0)(34)
            FrmANCinfo.TxtKidnDis.Text = tbl.Rows(0)(35)
            FrmANCinfo.TxtBldTrans.Text = tbl.Rows(0)(36)
            FrmANCinfo.TxtOper.Text = tbl.Rows(0)(37)
            FrmANCinfo.TxtMultPre.Text = tbl.Rows(0)(38)
            FrmANCinfo.Txttuber.Text = tbl.Rows(0)(39)
            FrmANCinfo.TxtHyper.Text = tbl.Rows(0)(40)
            FrmANCinfo.Txtothers.Text = tbl.Rows(0)(41)
            FrmANCinfo.txtdelivsta.Text = tbl.Rows(0)(43)

        End If
        ShowprevPreg()
    End Sub

    Private Sub DtgAncBook_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgAncbook.CellDoubleClick
        'Dim frms = New FrmANCinfo

        Showbookingdetails()
        FrmANCinfo.dtgprepreg.BringToFront()
        FrmANCinfo.btnsave.Enabled = False
        FrmANCinfo.txtpass.ReadOnly = True
        FrmANCinfo.ShowDialog()

    End Sub

End Class
