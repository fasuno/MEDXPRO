Imports System.Data.SqlClient

Public Class FrmWardManager

    Public Sub LoadAdmitreqst()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select * FROM AdmissionRequest", con)

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Me.Dgvpend.DataSource = tbl

        Dgvpend.Columns(0).Visible = False

    End Sub

    Public Sub LoadPTonadmission()

        Dim tbls As New DataTable

        cmd = New SqlCommand("Select Admit_Id, Date_Admitted, Time, Hospital_Num, Surname, Other_names, Sex, Age, Diagnosis, Ward, Bed_No, Consultant, Admitted_By, Admission_Status FROM Admitted WHERE Admission_Status='On admission' ", con)

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbls)
        Me.Dgvonadmision.DataSource = tbls

        Dgvonadmision.Columns(0).Visible = False

    End Sub

    Public Sub LoadDischargedPT()

        Dim tb As New DataTable
        cmd = New SqlCommand("Select Admit_Id, Date_Admitted, Time, Hospital_Num, Surname, Other_names, Sex, Age, Diagnosis, Ward, Bed_No, Consultant, Admitted_By, Admission_Status FROM Admitted WHERE Admission_Status='Discharged' ", con)
        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tb)
        Me.DgvDischrged.DataSource = tb

        DgvDischrged.Columns(0).Visible = False

    End Sub

    Private Sub FrmWardManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAdmitreqst()
        LoadPTonadmission()
        LoadDischargedPT()
    End Sub

    Private Sub Dgvpend_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvpend.CellDoubleClick

        Dim frm = New FrmNewAdmit

        FrmNewAdmit.Lbladmitid.Text = Dgvpend.CurrentRow.Cells(0).Value
        FrmNewAdmit.Txthospnum.Text = Dgvpend.CurrentRow.Cells(3).Value
        FrmNewAdmit.txtsname.Text = Dgvpend.CurrentRow.Cells(4).Value
        FrmNewAdmit.TxtOname.Text = Dgvpend.CurrentRow.Cells(5).Value
        FrmNewAdmit.Txtsex.Text = Dgvpend.CurrentRow.Cells(6).Value
        FrmNewAdmit.Txtage.Text = Dgvpend.CurrentRow.Cells(7).Value
        FrmNewAdmit.Txtdiag.Text = Dgvpend.CurrentRow.Cells(8).Value
        FrmNewAdmit.Txtadmtyp.Text = Dgvpend.CurrentRow.Cells(9).Value
        FrmNewAdmit.Txtinstr.Text = Dgvpend.CurrentRow.Cells(11).Value
        FrmNewAdmit.Txtclinic.Text = Dgvpend.CurrentRow.Cells(13).Value

        FrmNewAdmit.cboward.Text = ""
        FrmNewAdmit.cbobedno.Text = ""

        FrmNewAdmit.ShowDialog()
    End Sub

    Private Sub Dgvonadmision_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgvonadmision.CellDoubleClick
        FrmAdmitFolder.Lblhospnum.Text = Dgvonadmision.CurrentRow.Cells(3).Value
        FrmAdmitFolder.Lblsex.Text = Dgvonadmision.CurrentRow.Cells(6).Value
        FrmAdmitFolder.Lblage.Text = Dgvonadmision.CurrentRow.Cells(7).Value
        FrmAdmitFolder.Lbldiag.Text = Dgvonadmision.CurrentRow.Cells(8).Value
        FrmAdmitFolder.LbladmitID.Text = Dgvonadmision.CurrentRow.Cells(0).Value


        FrmAdmitFolder.LoadProfile()

        FrmAdmitFolder.Show()

    End Sub


End Class