﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashier))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnFindbill = New System.Windows.Forms.Button()
        Me.Txtfindbill = New System.Windows.Forms.TextBox()
        Me.BtnreLbills = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RdateTo = New System.Windows.Forms.DateTimePicker()
        Me.Rdatfrom = New System.Windows.Forms.DateTimePicker()
        Me.DtgPendbills = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timeto = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.timeFrm = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.Chkviewall = New System.Windows.Forms.CheckBox()
        Me.Btnreload = New System.Windows.Forms.Button()
        Me.BtnFind = New System.Windows.Forms.Button()
        Me.Txtfindreceipt = New System.Windows.Forms.TextBox()
        Me.Cbocashiers = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.Datefrom = New System.Windows.Forms.DateTimePicker()
        Me.Dtgreceipts = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DtgPendbills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dtgreceipts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1113, 460)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.DtgPendbills)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1105, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PENDING BILLS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnFindbill)
        Me.Panel1.Controls.Add(Me.Txtfindbill)
        Me.Panel1.Controls.Add(Me.BtnreLbills)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RdateTo)
        Me.Panel1.Controls.Add(Me.Rdatfrom)
        Me.Panel1.Location = New System.Drawing.Point(6, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1086, 38)
        Me.Panel1.TabIndex = 2
        '
        'BtnFindbill
        '
        Me.BtnFindbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFindbill.ForeColor = System.Drawing.Color.Red
        Me.BtnFindbill.Location = New System.Drawing.Point(1017, 5)
        Me.BtnFindbill.Name = "BtnFindbill"
        Me.BtnFindbill.Size = New System.Drawing.Size(61, 27)
        Me.BtnFindbill.TabIndex = 12
        Me.BtnFindbill.Text = "Find"
        Me.BtnFindbill.UseVisualStyleBackColor = True
        '
        'Txtfindbill
        '
        Me.Txtfindbill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtfindbill.Location = New System.Drawing.Point(823, 8)
        Me.Txtfindbill.Name = "Txtfindbill"
        Me.Txtfindbill.Size = New System.Drawing.Size(188, 22)
        Me.Txtfindbill.TabIndex = 11
        '
        'BtnreLbills
        '
        Me.BtnreLbills.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnreLbills.ForeColor = System.Drawing.Color.Black
        Me.BtnreLbills.Location = New System.Drawing.Point(502, 4)
        Me.BtnreLbills.Name = "BtnreLbills"
        Me.BtnreLbills.Size = New System.Drawing.Size(61, 27)
        Me.BtnreLbills.TabIndex = 10
        Me.BtnreLbills.Text = "Reload"
        Me.BtnreLbills.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(238, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "To"
        '
        'RdateTo
        '
        Me.RdateTo.Location = New System.Drawing.Point(269, 7)
        Me.RdateTo.Name = "RdateTo"
        Me.RdateTo.Size = New System.Drawing.Size(216, 22)
        Me.RdateTo.TabIndex = 3
        '
        'Rdatfrom
        '
        Me.Rdatfrom.Location = New System.Drawing.Point(12, 7)
        Me.Rdatfrom.Name = "Rdatfrom"
        Me.Rdatfrom.Size = New System.Drawing.Size(214, 22)
        Me.Rdatfrom.TabIndex = 2
        '
        'DtgPendbills
        '
        Me.DtgPendbills.AllowUserToAddRows = False
        Me.DtgPendbills.AllowUserToDeleteRows = False
        Me.DtgPendbills.AllowUserToOrderColumns = True
        Me.DtgPendbills.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        Me.DtgPendbills.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgPendbills.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DtgPendbills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPendbills.Location = New System.Drawing.Point(-4, 49)
        Me.DtgPendbills.Name = "DtgPendbills"
        Me.DtgPendbills.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DtgPendbills.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgPendbills.Size = New System.Drawing.Size(1096, 345)
        Me.DtgPendbills.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.lbltotal)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Timeto)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.timeFrm)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Dtgreceipts)
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1105, 432)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RECEIPTS"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(636, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 28)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(121, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "To"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.DarkRed
        Me.lbltotal.Location = New System.Drawing.Point(388, 401)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(21, 19)
        Me.lbltotal.TabIndex = 28
        Me.lbltotal.Text = " 0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(364, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 19)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "N"
        '
        'Timeto
        '
        Me.Timeto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timeto.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Timeto.Location = New System.Drawing.Point(147, 400)
        Me.Timeto.Name = "Timeto"
        Me.Timeto.ShowUpDown = True
        Me.Timeto.Size = New System.Drawing.Size(104, 22)
        Me.Timeto.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(278, 402)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Total Sales:"
        '
        'timeFrm
        '
        Me.timeFrm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeFrm.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeFrm.Location = New System.Drawing.Point(16, 400)
        Me.timeFrm.Name = "timeFrm"
        Me.timeFrm.ShowUpDown = True
        Me.timeFrm.Size = New System.Drawing.Size(102, 22)
        Me.timeFrm.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCyan
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnCreate)
        Me.Panel2.Controls.Add(Me.Chkviewall)
        Me.Panel2.Controls.Add(Me.Btnreload)
        Me.Panel2.Controls.Add(Me.BtnFind)
        Me.Panel2.Controls.Add(Me.Txtfindreceipt)
        Me.Panel2.Controls.Add(Me.Cbocashiers)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DateTo)
        Me.Panel2.Controls.Add(Me.Datefrom)
        Me.Panel2.Location = New System.Drawing.Point(5, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1091, 38)
        Me.Panel2.TabIndex = 3
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.White
        Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreate.ForeColor = System.Drawing.Color.Green
        Me.BtnCreate.Location = New System.Drawing.Point(10, 3)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(67, 28)
        Me.BtnCreate.TabIndex = 11
        Me.BtnCreate.Text = " NEW"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'Chkviewall
        '
        Me.Chkviewall.AutoSize = True
        Me.Chkviewall.Location = New System.Drawing.Point(812, 7)
        Me.Chkviewall.Name = "Chkviewall"
        Me.Chkviewall.Size = New System.Drawing.Size(72, 19)
        Me.Chkviewall.TabIndex = 10
        Me.Chkviewall.Text = "View All"
        Me.Chkviewall.UseVisualStyleBackColor = True
        '
        'Btnreload
        '
        Me.Btnreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnreload.ForeColor = System.Drawing.Color.Black
        Me.Btnreload.Location = New System.Drawing.Point(563, 4)
        Me.Btnreload.Name = "Btnreload"
        Me.Btnreload.Size = New System.Drawing.Size(61, 25)
        Me.Btnreload.TabIndex = 9
        Me.Btnreload.Text = "Reload"
        Me.Btnreload.UseVisualStyleBackColor = True
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.ForeColor = System.Drawing.Color.Red
        Me.BtnFind.Location = New System.Drawing.Point(1023, 4)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(61, 27)
        Me.BtnFind.TabIndex = 8
        Me.BtnFind.Text = "Find"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'Txtfindreceipt
        '
        Me.Txtfindreceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtfindreceipt.Location = New System.Drawing.Point(865, 7)
        Me.Txtfindreceipt.Name = "Txtfindreceipt"
        Me.Txtfindreceipt.Size = New System.Drawing.Size(152, 22)
        Me.Txtfindreceipt.TabIndex = 7
        '
        'Cbocashiers
        '
        Me.Cbocashiers.BackColor = System.Drawing.Color.Beige
        Me.Cbocashiers.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbocashiers.FormattingEnabled = True
        Me.Cbocashiers.Location = New System.Drawing.Point(630, 5)
        Me.Cbocashiers.Name = "Cbocashiers"
        Me.Cbocashiers.Size = New System.Drawing.Size(162, 23)
        Me.Cbocashiers.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(315, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To"
        '
        'DateTo
        '
        Me.DateTo.Location = New System.Drawing.Point(341, 7)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(216, 22)
        Me.DateTo.TabIndex = 3
        '
        'Datefrom
        '
        Me.Datefrom.Location = New System.Drawing.Point(95, 7)
        Me.Datefrom.Name = "Datefrom"
        Me.Datefrom.Size = New System.Drawing.Size(214, 22)
        Me.Datefrom.TabIndex = 2
        '
        'Dtgreceipts
        '
        Me.Dtgreceipts.AllowUserToAddRows = False
        Me.Dtgreceipts.AllowUserToDeleteRows = False
        Me.Dtgreceipts.AllowUserToOrderColumns = True
        Me.Dtgreceipts.AllowUserToResizeRows = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Dtgreceipts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dtgreceipts.BackgroundColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dtgreceipts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dtgreceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgreceipts.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtgreceipts.Location = New System.Drawing.Point(3, 50)
        Me.Dtgreceipts.Name = "Dtgreceipts"
        Me.Dtgreceipts.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dtgreceipts.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.Dtgreceipts.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Dtgreceipts.Size = New System.Drawing.Size(1093, 344)
        Me.Dtgreceipts.TabIndex = 0
        '
        'frmCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1113, 470)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "     PAYMENT FORM"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DtgPendbills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Dtgreceipts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DtgPendbills As DataGridView
    Friend WithEvents Dtgreceipts As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RdateTo As DateTimePicker
    Friend WithEvents Rdatfrom As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTo As DateTimePicker
    Friend WithEvents Datefrom As DateTimePicker
    Friend WithEvents BtnFind As Button
    Friend WithEvents Txtfindreceipt As TextBox
    Friend WithEvents Cbocashiers As ComboBox
    Friend WithEvents Btnreload As Button
    Friend WithEvents BtnreLbills As Button
    Friend WithEvents BtnFindbill As Button
    Friend WithEvents Txtfindbill As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timeto As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents timeFrm As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Chkviewall As CheckBox
    Friend WithEvents BtnCreate As Button
End Class
