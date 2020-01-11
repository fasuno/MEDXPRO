<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPtRecords
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblacct = New System.Windows.Forms.Label()
        Me.lblsex = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.Lblothernmaes = New System.Windows.Forms.Label()
        Me.Lblsurname = New System.Windows.Forms.Label()
        Me.Lblhopnum = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnAdm = New System.Windows.Forms.Button()
        Me.BtbnPharm = New System.Windows.Forms.Button()
        Me.BtnRad = New System.Windows.Forms.Button()
        Me.btnLab = New System.Windows.Forms.Button()
        Me.Btnconsult = New System.Windows.Forms.Button()
        Me.BtnProfile = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtresp = New System.Windows.Forms.TextBox()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.txtweight = New System.Windows.Forms.TextBox()
        Me.txtpulse = New System.Windows.Forms.TextBox()
        Me.Txtbp = New System.Windows.Forms.TextBox()
        Me.txttemp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Consultations1 = New DEAMACLINIC.Consultations()
        Me.PtRadHist1 = New DEAMACLINIC.PtRadHist()
        Me.PtLabHist1 = New DEAMACLINIC.PtLabHist()
        Me.PtDrugs11 = New DEAMACLINIC.PtDrugs1()
        Me.Profile1 = New DEAMACLINIC.Profile()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblacct)
        Me.Panel1.Controls.Add(Me.lblsex)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblage)
        Me.Panel1.Controls.Add(Me.Lblothernmaes)
        Me.Panel1.Controls.Add(Me.Lblsurname)
        Me.Panel1.Controls.Add(Me.Lblhopnum)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 33)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Wide Latin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(963, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblacct
        '
        Me.lblacct.AutoSize = True
        Me.lblacct.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacct.ForeColor = System.Drawing.Color.Purple
        Me.lblacct.Location = New System.Drawing.Point(713, 9)
        Me.lblacct.Name = "lblacct"
        Me.lblacct.Size = New System.Drawing.Size(53, 17)
        Me.lblacct.TabIndex = 8
        Me.lblacct.Text = "Label3"
        '
        'lblsex
        '
        Me.lblsex.AutoSize = True
        Me.lblsex.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsex.ForeColor = System.Drawing.Color.Purple
        Me.lblsex.Location = New System.Drawing.Point(615, 9)
        Me.lblsex.Name = "lblsex"
        Me.lblsex.Size = New System.Drawing.Size(53, 17)
        Me.lblsex.TabIndex = 7
        Me.lblsex.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(563, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "yrs"
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.ForeColor = System.Drawing.Color.Purple
        Me.lblage.Location = New System.Drawing.Point(527, 9)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(32, 17)
        Me.lblage.TabIndex = 5
        Me.lblage.Text = "000"
        '
        'Lblothernmaes
        '
        Me.Lblothernmaes.AutoSize = True
        Me.Lblothernmaes.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblothernmaes.ForeColor = System.Drawing.Color.Purple
        Me.Lblothernmaes.Location = New System.Drawing.Point(315, 9)
        Me.Lblothernmaes.Name = "Lblothernmaes"
        Me.Lblothernmaes.Size = New System.Drawing.Size(53, 17)
        Me.Lblothernmaes.TabIndex = 4
        Me.Lblothernmaes.Text = "Label3"
        '
        'Lblsurname
        '
        Me.Lblsurname.AutoSize = True
        Me.Lblsurname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsurname.ForeColor = System.Drawing.Color.Purple
        Me.Lblsurname.Location = New System.Drawing.Point(167, 9)
        Me.Lblsurname.Name = "Lblsurname"
        Me.Lblsurname.Size = New System.Drawing.Size(53, 17)
        Me.Lblsurname.TabIndex = 3
        Me.Lblsurname.Text = "Label2"
        '
        'Lblhopnum
        '
        Me.Lblhopnum.AutoSize = True
        Me.Lblhopnum.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblhopnum.ForeColor = System.Drawing.Color.Purple
        Me.Lblhopnum.Location = New System.Drawing.Point(54, 9)
        Me.Lblhopnum.Name = "Lblhopnum"
        Me.Lblhopnum.Size = New System.Drawing.Size(16, 17)
        Me.Lblhopnum.TabIndex = 2
        Me.Lblhopnum.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Purple
        Me.Panel2.Controls.Add(Me.BtnAdm)
        Me.Panel2.Controls.Add(Me.BtbnPharm)
        Me.Panel2.Controls.Add(Me.BtnRad)
        Me.Panel2.Controls.Add(Me.btnLab)
        Me.Panel2.Controls.Add(Me.Btnconsult)
        Me.Panel2.Controls.Add(Me.BtnProfile)
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 588)
        Me.Panel2.TabIndex = 1
        '
        'BtnAdm
        '
        Me.BtnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdm.ForeColor = System.Drawing.Color.White
        Me.BtnAdm.Location = New System.Drawing.Point(16, 385)
        Me.BtnAdm.Name = "BtnAdm"
        Me.BtnAdm.Size = New System.Drawing.Size(117, 34)
        Me.BtnAdm.TabIndex = 7
        Me.BtnAdm.Text = "Admission Hx"
        Me.BtnAdm.UseVisualStyleBackColor = True
        '
        'BtbnPharm
        '
        Me.BtbnPharm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtbnPharm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtbnPharm.ForeColor = System.Drawing.Color.White
        Me.BtbnPharm.Location = New System.Drawing.Point(16, 345)
        Me.BtbnPharm.Name = "BtbnPharm"
        Me.BtbnPharm.Size = New System.Drawing.Size(117, 34)
        Me.BtbnPharm.TabIndex = 6
        Me.BtbnPharm.Text = "Pharmacy"
        Me.BtbnPharm.UseVisualStyleBackColor = True
        '
        'BtnRad
        '
        Me.BtnRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRad.ForeColor = System.Drawing.Color.White
        Me.BtnRad.Location = New System.Drawing.Point(16, 305)
        Me.BtnRad.Name = "BtnRad"
        Me.BtnRad.Size = New System.Drawing.Size(117, 34)
        Me.BtnRad.TabIndex = 5
        Me.BtnRad.Text = "Radiology"
        Me.BtnRad.UseVisualStyleBackColor = True
        '
        'btnLab
        '
        Me.btnLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLab.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLab.ForeColor = System.Drawing.Color.White
        Me.btnLab.Location = New System.Drawing.Point(16, 265)
        Me.btnLab.Name = "btnLab"
        Me.btnLab.Size = New System.Drawing.Size(117, 34)
        Me.btnLab.TabIndex = 4
        Me.btnLab.Text = "Laboratory"
        Me.btnLab.UseVisualStyleBackColor = True
        '
        'Btnconsult
        '
        Me.Btnconsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnconsult.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconsult.ForeColor = System.Drawing.Color.White
        Me.Btnconsult.Location = New System.Drawing.Point(16, 225)
        Me.Btnconsult.Name = "Btnconsult"
        Me.Btnconsult.Size = New System.Drawing.Size(117, 34)
        Me.Btnconsult.TabIndex = 3
        Me.Btnconsult.Text = "Consultation"
        Me.Btnconsult.UseVisualStyleBackColor = True
        '
        'BtnProfile
        '
        Me.BtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProfile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfile.ForeColor = System.Drawing.Color.White
        Me.BtnProfile.Location = New System.Drawing.Point(16, 185)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Size = New System.Drawing.Size(117, 34)
        Me.BtnProfile.TabIndex = 2
        Me.BtnProfile.Text = "Profile"
        Me.BtnProfile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtresp)
        Me.GroupBox1.Controls.Add(Me.txtheight)
        Me.GroupBox1.Controls.Add(Me.txtweight)
        Me.GroupBox1.Controls.Add(Me.txtpulse)
        Me.GroupBox1.Controls.Add(Me.Txtbp)
        Me.GroupBox1.Controls.Add(Me.txttemp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(172, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 115)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VITAL SIGNS"
        '
        'txtresp
        '
        Me.txtresp.BackColor = System.Drawing.Color.White
        Me.txtresp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtresp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtresp.ForeColor = System.Drawing.Color.Black
        Me.txtresp.Location = New System.Drawing.Point(259, 84)
        Me.txtresp.Name = "txtresp"
        Me.txtresp.Size = New System.Drawing.Size(72, 22)
        Me.txtresp.TabIndex = 18
        '
        'txtheight
        '
        Me.txtheight.BackColor = System.Drawing.Color.White
        Me.txtheight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtheight.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtheight.ForeColor = System.Drawing.Color.Black
        Me.txtheight.Location = New System.Drawing.Point(333, 56)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(72, 22)
        Me.txtheight.TabIndex = 17
        '
        'txtweight
        '
        Me.txtweight.BackColor = System.Drawing.Color.White
        Me.txtweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtweight.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtweight.ForeColor = System.Drawing.Color.Black
        Me.txtweight.Location = New System.Drawing.Point(174, 56)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(72, 22)
        Me.txtweight.TabIndex = 16
        '
        'txtpulse
        '
        Me.txtpulse.BackColor = System.Drawing.Color.White
        Me.txtpulse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpulse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpulse.ForeColor = System.Drawing.Color.Black
        Me.txtpulse.Location = New System.Drawing.Point(385, 28)
        Me.txtpulse.Name = "txtpulse"
        Me.txtpulse.Size = New System.Drawing.Size(72, 22)
        Me.txtpulse.TabIndex = 15
        '
        'Txtbp
        '
        Me.Txtbp.BackColor = System.Drawing.Color.White
        Me.Txtbp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtbp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbp.ForeColor = System.Drawing.Color.Black
        Me.Txtbp.Location = New System.Drawing.Point(75, 28)
        Me.Txtbp.Name = "Txtbp"
        Me.Txtbp.Size = New System.Drawing.Size(115, 22)
        Me.Txtbp.TabIndex = 4
        '
        'txttemp
        '
        Me.txttemp.BackColor = System.Drawing.Color.White
        Me.txttemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttemp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttemp.ForeColor = System.Drawing.Color.Black
        Me.txttemp.Location = New System.Drawing.Point(252, 28)
        Me.txttemp.Name = "txttemp"
        Me.txttemp.Size = New System.Drawing.Size(72, 22)
        Me.txttemp.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(206, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Resp:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(269, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Height:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(109, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Weight:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(330, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Pulse:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(196, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Temp:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Bp:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Purple
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(146, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(852, 125)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Purple
        Me.Panel4.Location = New System.Drawing.Point(146, 611)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(852, 10)
        Me.Panel4.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Consultations1)
        Me.Panel5.Controls.Add(Me.PtRadHist1)
        Me.Panel5.Controls.Add(Me.PtLabHist1)
        Me.Panel5.Controls.Add(Me.PtDrugs11)
        Me.Panel5.Controls.Add(Me.Profile1)
        Me.Panel5.Location = New System.Drawing.Point(149, 159)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(846, 451)
        Me.Panel5.TabIndex = 5
        '
        'Consultations1
        '
        Me.Consultations1.BackColor = System.Drawing.Color.White
        Me.Consultations1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Consultations1.ForeColor = System.Drawing.Color.Black
        Me.Consultations1.Location = New System.Drawing.Point(20, 4)
        Me.Consultations1.Name = "Consultations1"
        Me.Consultations1.Size = New System.Drawing.Size(807, 441)
        Me.Consultations1.TabIndex = 4
        '
        'PtRadHist1
        '
        Me.PtRadHist1.BackColor = System.Drawing.Color.White
        Me.PtRadHist1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PtRadHist1.ForeColor = System.Drawing.Color.Black
        Me.PtRadHist1.Location = New System.Drawing.Point(20, 4)
        Me.PtRadHist1.Name = "PtRadHist1"
        Me.PtRadHist1.Size = New System.Drawing.Size(807, 441)
        Me.PtRadHist1.TabIndex = 3
        '
        'PtLabHist1
        '
        Me.PtLabHist1.BackColor = System.Drawing.Color.White
        Me.PtLabHist1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PtLabHist1.Location = New System.Drawing.Point(20, 4)
        Me.PtLabHist1.Name = "PtLabHist1"
        Me.PtLabHist1.Size = New System.Drawing.Size(807, 440)
        Me.PtLabHist1.TabIndex = 2
        '
        'PtDrugs11
        '
        Me.PtDrugs11.BackColor = System.Drawing.Color.White
        Me.PtDrugs11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PtDrugs11.ForeColor = System.Drawing.Color.Black
        Me.PtDrugs11.Location = New System.Drawing.Point(20, 4)
        Me.PtDrugs11.Name = "PtDrugs11"
        Me.PtDrugs11.Size = New System.Drawing.Size(807, 441)
        Me.PtDrugs11.TabIndex = 1
        '
        'Profile1
        '
        Me.Profile1.BackColor = System.Drawing.Color.White
        Me.Profile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Profile1.Location = New System.Drawing.Point(20, 3)
        Me.Profile1.Name = "Profile1"
        Me.Profile1.Size = New System.Drawing.Size(807, 441)
        Me.Profile1.TabIndex = 0
        '
        'FrmPtRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(998, 621)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPtRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPtRecords"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnAdm As Button
    Friend WithEvents BtbnPharm As Button
    Friend WithEvents BtnRad As Button
    Friend WithEvents btnLab As Button
    Friend WithEvents Btnconsult As Button
    Friend WithEvents BtnProfile As Button
    Friend WithEvents Lblhopnum As Label
    Friend WithEvents Lblothernmaes As Label
    Friend WithEvents Lblsurname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblage As Label
    Friend WithEvents lblacct As Label
    Friend WithEvents lblsex As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txtbp As TextBox
    Friend WithEvents txttemp As TextBox
    Friend WithEvents txtpulse As TextBox
    Friend WithEvents txtheight As TextBox
    Friend WithEvents txtweight As TextBox
    Friend WithEvents txtresp As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Consultations1 As Consultations
    Friend WithEvents PtRadHist1 As PtRadHist
    Friend WithEvents PtLabHist1 As PtLabHist
    Friend WithEvents PtDrugs11 As PtDrugs1
    Friend WithEvents Profile1 As Profile
    Friend WithEvents Button1 As Button
End Class
