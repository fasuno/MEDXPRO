Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        frmlogin.ShowDialog()
        frmlogin.MdiParent = Me
        lblmail.Visible = False

        lbldate.Text = Now.ToLocalTime
    End Sub

    Public Sub showusername()
        '// Show users name after log in, this method will be called on frmlogin LOGIN button
        cmd = New SqlCommand("Select * from UsersReg where Username=@user", con)
        cmd.Parameters.Add("user", SqlDbType.VarChar).Value = frmlogin.txtusername.Text

        Dim adpt As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()

        adpt.Fill(tbl)

        If tbl.Rows.Count() > 0 Then

            'Display the person data

            lblname.Text = tbl.Rows(0)(1).ToString()
            lblrole.Text = tbl.Rows(0)(5).ToString()


        Else


        End If

    End Sub

    Private Sub Btnregister_Click(sender As Object, e As EventArgs) Handles Btnregister.Click
        Frmrecords.MdiParent = Me
        Frmrecords.Show()
    End Sub

    Private Sub btnlogoff_Click(sender As Object, e As EventArgs) Handles btnlogoff.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        lblmail.Text = ""
        lblname.Text = ""

        frmlogin.WindowState = FormWindowState.Normal
        frmlogin.ShowDialog()
        frmlogin.MdiParent = Me
        frmlogin.txtusername.Focus()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnvitals_Click(sender As Object, e As EventArgs) Handles btnvitals.Click
        frmNursing.Show()
        frmNursing.MdiParent = Me
    End Sub

    Private Sub btnmylist_Click(sender As Object, e As EventArgs) Handles btnmylist.Click

        FrmMywaitinglist.Show()
        FrmMywaitinglist.MdiParent = Me
    End Sub

    Private Sub btnAlllist_Click(sender As Object, e As EventArgs) Handles btnAlllist.Click
        frmAllwaitingList.Show()
        frmAllwaitingList.MdiParent = Me
    End Sub

    Private Sub btnexits_Click(sender As Object, e As EventArgs) Handles btnexits.Click
        Me.Close()
    End Sub

    Private Sub btnlabinvest_Click(sender As Object, e As EventArgs) Handles btnlabinvest.Click
        frmLABORATORY.Show()
        frmLABORATORY.MdiParent = Me
    End Sub

    Private Sub btnlabtestlist_Click(sender As Object, e As EventArgs) Handles btnlabtestlist.Click
        frmLabTestList.Show()
        frmLabTestList.MdiParent = Me
    End Sub

    Private Sub btndruglist_Click(sender As Object, e As EventArgs) Handles btndruglist.Click
        frmAllDrugs.Show()
        frmAllDrugs.MdiParent = Me
    End Sub

    Private Sub btndrugrest_Click(sender As Object, e As EventArgs) Handles btndrugrest.Click
        FrmPharmacy.Show()
        FrmPharmacy.MdiParent = Me
    End Sub

    Private Sub btnnewdrg_Click(sender As Object, e As EventArgs) Handles btnnewdrg.Click
        FrmNewdrugs.Show()
        FrmNewdrugs.MdiParent = Me
    End Sub

    Private Sub btnradrqst_Click(sender As Object, e As EventArgs) Handles btnradrqst.Click
        FrmRadiology.Show()
        FrmRadiology.MdiParent = Me
    End Sub

    Private Sub btncashpoint_Click(sender As Object, e As EventArgs) Handles btncashpoint.Click
        frmCashier.Show()
        frmCashier.MdiParent = Me
    End Sub
    Private Sub btnnewuser_Click(sender As Object, e As EventArgs) Handles btnnewuser.Click
        frmusers.MdiParent = Me
        frmusers.Show()
    End Sub

    Private Sub btnsetservice_Click(sender As Object, e As EventArgs) Handles btnsetservice.Click
        FrmSettings.ShowDialog()
    End Sub

    Private Sub btnanc_Click_1(sender As Object, e As EventArgs) Handles btnanc.Click
        Dim frm = New FrmANCreg
        frm.ShowDialog()
    End Sub
End Class
