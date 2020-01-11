<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPharmacy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPharmacy))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DttreatTo = New System.Windows.Forms.DateTimePicker()
        Me.Dttreat = New System.Windows.Forms.DateTimePicker()
        Me.txtfintreated = New System.Windows.Forms.TextBox()
        Me.btnrloadtrtd = New System.Windows.Forms.Button()
        Me.chkAllRqst = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RqstTo = New System.Windows.Forms.DateTimePicker()
        Me.RqstFrm = New System.Windows.Forms.DateTimePicker()
        Me.txtFindRqst = New System.Windows.Forms.TextBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnfindRqst = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnfindtrtd = New System.Windows.Forms.Button()
        Me.dtgTreatrqst = New System.Windows.Forms.DataGridView()
        Me.TabTreated = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPend = New System.Windows.Forms.TabPage()
        Me.DtgPendDrugrqst = New System.Windows.Forms.DataGridView()
        Me.tabpharm = New System.Windows.Forms.TabControl()
        Me.TabBilled = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkAllbill = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtbillto = New System.Windows.Forms.DateTimePicker()
        Me.dtbillfrom = New System.Windows.Forms.DateTimePicker()
        Me.txtfindbill = New System.Windows.Forms.TextBox()
        Me.Btnrefbill = New System.Windows.Forms.Button()
        Me.btnfindbill = New System.Windows.Forms.Button()
        Me.Dtgbiiled = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgTreatrqst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTreated.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPend.SuspendLayout()
        CType(Me.DtgPendDrugrqst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpharm.SuspendLayout()
        Me.TabBilled.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Dtgbiiled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(230, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "To"
        '
        'DttreatTo
        '
        Me.DttreatTo.Location = New System.Drawing.Point(260, 11)
        Me.DttreatTo.Name = "DttreatTo"
        Me.DttreatTo.Size = New System.Drawing.Size(210, 21)
        Me.DttreatTo.TabIndex = 15
        '
        'Dttreat
        '
        Me.Dttreat.Location = New System.Drawing.Point(8, 11)
        Me.Dttreat.Name = "Dttreat"
        Me.Dttreat.Size = New System.Drawing.Size(211, 21)
        Me.Dttreat.TabIndex = 14
        '
        'txtfintreated
        '
        Me.txtfintreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfintreated.Location = New System.Drawing.Point(854, 11)
        Me.txtfintreated.Name = "txtfintreated"
        Me.txtfintreated.Size = New System.Drawing.Size(153, 21)
        Me.txtfintreated.TabIndex = 12
        '
        'btnrloadtrtd
        '
        Me.btnrloadtrtd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrloadtrtd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrloadtrtd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrloadtrtd.ForeColor = System.Drawing.Color.Navy
        Me.btnrloadtrtd.Location = New System.Drawing.Point(479, 10)
        Me.btnrloadtrtd.Name = "btnrloadtrtd"
        Me.btnrloadtrtd.Size = New System.Drawing.Size(68, 23)
        Me.btnrloadtrtd.TabIndex = 11
        Me.btnrloadtrtd.Text = "Refresh"
        Me.btnrloadtrtd.UseVisualStyleBackColor = False
        '
        'chkAllRqst
        '
        Me.chkAllRqst.AutoSize = True
        Me.chkAllRqst.ForeColor = System.Drawing.Color.Black
        Me.chkAllRqst.Location = New System.Drawing.Point(811, 14)
        Me.chkAllRqst.Name = "chkAllRqst"
        Me.chkAllRqst.Size = New System.Drawing.Size(70, 19)
        Me.chkAllRqst.TabIndex = 17
        Me.chkAllRqst.Text = "View All"
        Me.chkAllRqst.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(236, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "To"
        '
        'RqstTo
        '
        Me.RqstTo.Location = New System.Drawing.Point(266, 13)
        Me.RqstTo.Name = "RqstTo"
        Me.RqstTo.Size = New System.Drawing.Size(210, 21)
        Me.RqstTo.TabIndex = 15
        '
        'RqstFrm
        '
        Me.RqstFrm.Location = New System.Drawing.Point(14, 13)
        Me.RqstFrm.Name = "RqstFrm"
        Me.RqstFrm.Size = New System.Drawing.Size(211, 21)
        Me.RqstFrm.TabIndex = 14
        '
        'txtFindRqst
        '
        Me.txtFindRqst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFindRqst.Location = New System.Drawing.Point(887, 12)
        Me.txtFindRqst.Name = "txtFindRqst"
        Me.txtFindRqst.Size = New System.Drawing.Size(153, 21)
        Me.txtFindRqst.TabIndex = 12
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnrefresh.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.Navy
        Me.btnrefresh.Location = New System.Drawing.Point(485, 12)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(68, 23)
        Me.btnrefresh.TabIndex = 11
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btnfindRqst
        '
        Me.btnfindRqst.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindRqst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfindRqst.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindRqst.ForeColor = System.Drawing.Color.Green
        Me.btnfindRqst.Location = New System.Drawing.Point(1045, 11)
        Me.btnfindRqst.Name = "btnfindRqst"
        Me.btnfindRqst.Size = New System.Drawing.Size(65, 24)
        Me.btnfindRqst.TabIndex = 13
        Me.btnfindRqst.Text = "Search"
        Me.btnfindRqst.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DttreatTo)
        Me.Panel2.Controls.Add(Me.Dttreat)
        Me.Panel2.Controls.Add(Me.txtfintreated)
        Me.Panel2.Controls.Add(Me.btnrloadtrtd)
        Me.Panel2.Controls.Add(Me.btnfindtrtd)
        Me.Panel2.Location = New System.Drawing.Point(4, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1120, 38)
        Me.Panel2.TabIndex = 2
        '
        'btnfindtrtd
        '
        Me.btnfindtrtd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindtrtd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfindtrtd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindtrtd.ForeColor = System.Drawing.Color.Green
        Me.btnfindtrtd.Location = New System.Drawing.Point(1013, 10)
        Me.btnfindtrtd.Name = "btnfindtrtd"
        Me.btnfindtrtd.Size = New System.Drawing.Size(75, 24)
        Me.btnfindtrtd.TabIndex = 13
        Me.btnfindtrtd.Text = "Search"
        Me.btnfindtrtd.UseVisualStyleBackColor = False
        '
        'dtgTreatrqst
        '
        Me.dtgTreatrqst.AllowUserToAddRows = False
        Me.dtgTreatrqst.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy
        Me.dtgTreatrqst.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgTreatrqst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgTreatrqst.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dtgTreatrqst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgTreatrqst.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgTreatrqst.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgTreatrqst.Location = New System.Drawing.Point(3, 51)
        Me.dtgTreatrqst.Name = "dtgTreatrqst"
        Me.dtgTreatrqst.ReadOnly = True
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dtgTreatrqst.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgTreatrqst.Size = New System.Drawing.Size(1119, 440)
        Me.dtgTreatrqst.TabIndex = 6
        '
        'TabTreated
        '
        Me.TabTreated.Controls.Add(Me.dtgTreatrqst)
        Me.TabTreated.Controls.Add(Me.Label4)
        Me.TabTreated.Controls.Add(Me.Label5)
        Me.TabTreated.Controls.Add(Me.Panel2)
        Me.TabTreated.ForeColor = System.Drawing.Color.Transparent
        Me.TabTreated.Location = New System.Drawing.Point(4, 24)
        Me.TabTreated.Name = "TabTreated"
        Me.TabTreated.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTreated.Size = New System.Drawing.Size(1128, 490)
        Me.TabTreated.TabIndex = 1
        Me.TabTreated.Text = "  TREATED"
        Me.TabTreated.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(111, 496)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = " Records found."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkAllRqst)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.RqstTo)
        Me.Panel1.Controls.Add(Me.RqstFrm)
        Me.Panel1.Controls.Add(Me.txtFindRqst)
        Me.Panel1.Controls.Add(Me.btnrefresh)
        Me.Panel1.Controls.Add(Me.btnfindRqst)
        Me.Panel1.Location = New System.Drawing.Point(1, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 40)
        Me.Panel1.TabIndex = 0
        '
        'TabPend
        '
        Me.TabPend.Controls.Add(Me.DtgPendDrugrqst)
        Me.TabPend.Controls.Add(Me.Panel1)
        Me.TabPend.ForeColor = System.Drawing.Color.Black
        Me.TabPend.Location = New System.Drawing.Point(4, 24)
        Me.TabPend.Name = "TabPend"
        Me.TabPend.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPend.Size = New System.Drawing.Size(1128, 490)
        Me.TabPend.TabIndex = 0
        Me.TabPend.Text = "  PENDING"
        Me.TabPend.UseVisualStyleBackColor = True
        '
        'DtgPendDrugrqst
        '
        Me.DtgPendDrugrqst.AllowUserToAddRows = False
        Me.DtgPendDrugrqst.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DtgPendDrugrqst.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgPendDrugrqst.BackgroundColor = System.Drawing.Color.White
        Me.DtgPendDrugrqst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtgPendDrugrqst.DefaultCellStyle = DataGridViewCellStyle5
        Me.DtgPendDrugrqst.Location = New System.Drawing.Point(0, 51)
        Me.DtgPendDrugrqst.Name = "DtgPendDrugrqst"
        Me.DtgPendDrugrqst.ReadOnly = True
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.DtgPendDrugrqst.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DtgPendDrugrqst.Size = New System.Drawing.Size(1125, 433)
        Me.DtgPendDrugrqst.TabIndex = 1
        '
        'tabpharm
        '
        Me.tabpharm.Controls.Add(Me.TabPend)
        Me.tabpharm.Controls.Add(Me.TabBilled)
        Me.tabpharm.Controls.Add(Me.TabTreated)
        Me.tabpharm.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpharm.Location = New System.Drawing.Point(3, 9)
        Me.tabpharm.Name = "tabpharm"
        Me.tabpharm.SelectedIndex = 0
        Me.tabpharm.Size = New System.Drawing.Size(1136, 518)
        Me.tabpharm.TabIndex = 1
        '
        'TabBilled
        '
        Me.TabBilled.Controls.Add(Me.Panel3)
        Me.TabBilled.Controls.Add(Me.Dtgbiiled)
        Me.TabBilled.Location = New System.Drawing.Point(4, 24)
        Me.TabBilled.Name = "TabBilled"
        Me.TabBilled.Size = New System.Drawing.Size(1128, 490)
        Me.TabBilled.TabIndex = 2
        Me.TabBilled.Text = "BILLED"
        Me.TabBilled.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Maroon
        Me.Panel3.Controls.Add(Me.ChkAllbill)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.dtbillto)
        Me.Panel3.Controls.Add(Me.dtbillfrom)
        Me.Panel3.Controls.Add(Me.txtfindbill)
        Me.Panel3.Controls.Add(Me.Btnrefbill)
        Me.Panel3.Controls.Add(Me.btnfindbill)
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1128, 40)
        Me.Panel3.TabIndex = 1
        '
        'ChkAllbill
        '
        Me.ChkAllbill.AutoSize = True
        Me.ChkAllbill.ForeColor = System.Drawing.Color.White
        Me.ChkAllbill.Location = New System.Drawing.Point(811, 14)
        Me.ChkAllbill.Name = "ChkAllbill"
        Me.ChkAllbill.Size = New System.Drawing.Size(70, 19)
        Me.ChkAllbill.TabIndex = 17
        Me.ChkAllbill.Text = "View All"
        Me.ChkAllbill.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(232, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "To"
        '
        'dtbillto
        '
        Me.dtbillto.Location = New System.Drawing.Point(262, 13)
        Me.dtbillto.Name = "dtbillto"
        Me.dtbillto.Size = New System.Drawing.Size(210, 21)
        Me.dtbillto.TabIndex = 15
        '
        'dtbillfrom
        '
        Me.dtbillfrom.Location = New System.Drawing.Point(10, 13)
        Me.dtbillfrom.Name = "dtbillfrom"
        Me.dtbillfrom.Size = New System.Drawing.Size(211, 21)
        Me.dtbillfrom.TabIndex = 14
        '
        'txtfindbill
        '
        Me.txtfindbill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfindbill.Location = New System.Drawing.Point(887, 12)
        Me.txtfindbill.Name = "txtfindbill"
        Me.txtfindbill.Size = New System.Drawing.Size(153, 21)
        Me.txtfindbill.TabIndex = 12
        '
        'Btnrefbill
        '
        Me.Btnrefbill.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnrefbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnrefbill.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnrefbill.ForeColor = System.Drawing.Color.DarkRed
        Me.Btnrefbill.Location = New System.Drawing.Point(481, 12)
        Me.Btnrefbill.Name = "Btnrefbill"
        Me.Btnrefbill.Size = New System.Drawing.Size(68, 23)
        Me.Btnrefbill.TabIndex = 11
        Me.Btnrefbill.Text = "Refresh"
        Me.Btnrefbill.UseVisualStyleBackColor = False
        '
        'btnfindbill
        '
        Me.btnfindbill.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfindbill.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindbill.ForeColor = System.Drawing.Color.DarkRed
        Me.btnfindbill.Location = New System.Drawing.Point(1045, 11)
        Me.btnfindbill.Name = "btnfindbill"
        Me.btnfindbill.Size = New System.Drawing.Size(65, 24)
        Me.btnfindbill.TabIndex = 13
        Me.btnfindbill.Text = "Search"
        Me.btnfindbill.UseVisualStyleBackColor = False
        '
        'Dtgbiiled
        '
        Me.Dtgbiiled.AllowUserToAddRows = False
        Me.Dtgbiiled.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.Dtgbiiled.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dtgbiiled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dtgbiiled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgbiiled.Location = New System.Drawing.Point(5, 49)
        Me.Dtgbiiled.Name = "Dtgbiiled"
        Me.Dtgbiiled.ReadOnly = True
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Maroon
        Me.Dtgbiiled.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Dtgbiiled.Size = New System.Drawing.Size(1120, 438)
        Me.Dtgbiiled.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(95, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = " Records found."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "0"
        '
        'FrmPharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1137, 559)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tabpharm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPharmacy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   PHARMACY  DISPENSARY"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dtgTreatrqst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTreated.ResumeLayout(False)
        Me.TabTreated.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPend.ResumeLayout(False)
        CType(Me.DtgPendDrugrqst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpharm.ResumeLayout(False)
        Me.TabBilled.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Dtgbiiled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DttreatTo As DateTimePicker
    Friend WithEvents Dttreat As DateTimePicker
    Friend WithEvents txtfintreated As TextBox
    Friend WithEvents btnrloadtrtd As Button
    Friend WithEvents chkAllRqst As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RqstTo As DateTimePicker
    Friend WithEvents RqstFrm As DateTimePicker
    Friend WithEvents txtFindRqst As TextBox
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btnfindRqst As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnfindtrtd As Button
    Friend WithEvents dtgTreatrqst As DataGridView
    Friend WithEvents TabTreated As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPend As TabPage
    Friend WithEvents tabpharm As TabControl
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DtgPendDrugrqst As DataGridView
    Friend WithEvents TabBilled As TabPage
    Friend WithEvents Dtgbiiled As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ChkAllbill As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtbillto As DateTimePicker
    Friend WithEvents dtbillfrom As DateTimePicker
    Friend WithEvents txtfindbill As TextBox
    Friend WithEvents Btnrefbill As Button
    Friend WithEvents btnfindbill As Button
End Class
