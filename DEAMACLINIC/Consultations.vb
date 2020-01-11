Imports System.Data.SqlClient

Public Class Consultations

    Private Sub btnnewconsult_Click(sender As Object, e As EventArgs) Handles btnnewconsult.Click
        'frmGenConsult.Close()
        Dim fr = New frmGenConsult
        fr.ShowDialog()
    End Sub

    Public Sub LoadConsultationgrid()

        Dim tbl As New DataTable

        cmd = New SqlCommand("Select Date, Time, Complaint, Pres_Complain, Assessment, Examination, Past_MedHx, Immunization, Family_Hx, Social_Hx, Lab_Investigation, Rad_Investigation, Treatment, Summary, Clinic, Doctor, BP, Temp, Pulse, Weight, Height, Respiration from Consultations WHERE Hospital_Num=@hospnum", con)

        cmd.Parameters.Add("@hospnum", SqlDbType.Int).Value = FrmPtRecords.LblHopNum.Text

        adapt = New SqlDataAdapter(cmd)

        adapt.Fill(tbl)
        Me.Dtggenconsult.DataSource = tbl

    End Sub

    Private Sub consultaition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadConsultationgrid()
        '// Note we will do the same for all other special clinics
    End Sub

    Private Sub Dtggenconsult_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtggenconsult.CellClick
        Dim frm = New frmGenConsult

        ' frmGenConsult.lbldate.Text = Dtggenconsult.CurrentRow.Cells(0).Value.ToString()
        ' frmGenConsult.lbltime.Text = Dtggenconsult.CurrentRow.Cells(1).Value.ToString()
        frmGenConsult.Cboclinic.Text = Dtggenconsult.CurrentRow.Cells(14).Value.ToString()
        frmGenConsult.TxtComp.Text = Dtggenconsult.CurrentRow.Cells(2).Value.ToString()
        frmGenConsult.TxtPresComp.Text = Dtggenconsult.CurrentRow.Cells(3).Value.ToString()
        frmGenConsult.TxtPastmed.Text = Dtggenconsult.CurrentRow.Cells(6).Value.ToString()
        frmGenConsult.TxtImmun.Text = Dtggenconsult.CurrentRow.Cells(7).Value.ToString()
        frmGenConsult.TxtFamhx.Text = Dtggenconsult.CurrentRow.Cells(8).Value.ToString()
        frmGenConsult.TxtSocial.Text = Dtggenconsult.CurrentRow.Cells(9).Value.ToString()
        frmGenConsult.TxtExam.Text = Dtggenconsult.CurrentRow.Cells(5).Value.ToString()
        frmGenConsult.TxtDiag.Text = Dtggenconsult.CurrentRow.Cells(4).Value.ToString()
        frmGenConsult.Txtlabinv.Text = Dtggenconsult.CurrentRow.Cells(10).Value.ToString()
        frmGenConsult.TxtRadinv.Text = Dtggenconsult.CurrentRow.Cells(11).Value.ToString()
        frmGenConsult.TxtTreatmnt.Text = Dtggenconsult.CurrentRow.Cells(12).Value.ToString()
        frmGenConsult.txtSumm.Text = Dtggenconsult.CurrentRow.Cells(13).Value.ToString()
        FrmPtRecords.Txtbp.Text = Dtggenconsult.CurrentRow.Cells(16).Value.ToString()
        FrmPtRecords.txtheight.Text = Dtggenconsult.CurrentRow.Cells(20).Value.ToString()
        FrmPtRecords.txtweight.Text = Dtggenconsult.CurrentRow.Cells(19).Value.ToString()
        FrmPtRecords.txtpulse.Text = Dtggenconsult.CurrentRow.Cells(18).Value.ToString()
        FrmPtRecords.Label7.Text = Dtggenconsult.CurrentRow.Cells(17).Value.ToString() ''//this label shows temperature
        FrmPtRecords.txtresp.Text = Dtggenconsult.CurrentRow.Cells(21).Value.ToString()


        '//Disable all the buttons to avoid user making changes to the consultation
        frmGenConsult.Btnsave.Enabled = False
        frmGenConsult.btnLAB.Enabled = False
        frmGenConsult.BtnScan.Enabled = False
        frmGenConsult.BtnDrugs.Enabled = False
        frmGenConsult.Btnadmit.Enabled = False

        '// Make all the textboxes readonly

        frmGenConsult.TxtExam.ReadOnly = True
        frmGenConsult.TxtComp.ReadOnly = True
        frmGenConsult.TxtPresComp.ReadOnly = True
        frmGenConsult.TxtPastmed.ReadOnly = True
        frmGenConsult.TxtDiag.ReadOnly = True
        frmGenConsult.TxtFamhx.ReadOnly = True
        frmGenConsult.TxtImmun.ReadOnly = True
        frmGenConsult.Txtlabinv.ReadOnly = True
        frmGenConsult.TxtRadinv.ReadOnly = True
        frmGenConsult.TxtSocial.ReadOnly = True
        frmGenConsult.txtSumm.ReadOnly = True
        frmGenConsult.TxtTreatmnt.ReadOnly = True

        '// Have to bring this to down bcos i have already make the label boxes to show current date and time on the formload event
        '// So by doing this, it will pick the date on the grid
        frmGenConsult.lbldate.Text = Dtggenconsult.CurrentRow.Cells(0).Value
        frmGenConsult.lbltime.Text = Dtggenconsult.CurrentRow.Cells(1).Value

        frmGenConsult.ShowDialog()
    End Sub


End Class
