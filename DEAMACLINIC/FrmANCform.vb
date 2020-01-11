Public Class FrmANCform
    Private Sub Btnprof_Click(sender As Object, e As EventArgs) Handles Btnprof.Click
        AncProfile2.BringToFront()
    End Sub

    Private Sub FrmANCform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AncProfile2.BringToFront()
        lblhospnum.ForeColor = Color.White
        lblbkid.ForeColor = Color.White
    End Sub

    Private Sub Btnseedoc_Click(sender As Object, e As EventArgs) Handles Btnseedoc.Click
        Dim frms = New frmvitals

        frms.lblsurname.Text = AncProfile2.Txtsurname.Text
        frms.lblothernames.Text = AncProfile2.txtothernames.Text
        frms.lblage.Text = AncProfile2.txtyear.Text
        frms.lblclinic.Text = "ANC"
        frms.lblaccounttype.Text = AncProfile2.txtaccount.Text
        frms.lblhospnum.Text = lblhospnum.Text
        frms.lblsex.Text = AncProfile2.txtsex.Text


        frms.ShowDialog()
    End Sub

    Private Sub btnbooking_Click(sender As Object, e As EventArgs) Handles btnbooking.Click
        AncBooking1.BringToFront()
    End Sub

    Private Sub btnfolwup_Click(sender As Object, e As EventArgs) Handles btnfolwup.Click
        AnCfollowup1.BringToFront()
    End Sub

    Private Sub btnlab_Click(sender As Object, e As EventArgs) Handles btnlab.Click
        Dim frm = New FrmLabrequest
        frm.LoadLAbTest()
        frm.ShowDialog()
    End Sub

    Private Sub btnrad_Click(sender As Object, e As EventArgs) Handles btnrad.Click
        Dim fr = New FrmRadrequest
        fr.LoadRAdlist()
        fr.ShowDialog()
    End Sub

    Private Sub btndrug_Click(sender As Object, e As EventArgs) Handles btndrug.Click
        Dim frrm = New FrmDrugsPresc
        frrm.LoadDrugs()
        frrm.ShowDialog()
    End Sub

End Class