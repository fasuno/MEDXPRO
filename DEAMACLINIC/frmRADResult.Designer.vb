﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRADResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRADResult))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lblreprtby = New System.Windows.Forms.Label()
        Me.lbltim = New System.Windows.Forms.Label()
        Me.lbldte = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Lblrqstnum = New System.Windows.Forms.Label()
        Me.lblbilledby = New System.Windows.Forms.Label()
        Me.txtOname = New System.Windows.Forms.TextBox()
        Me.txtRqstby = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtsex = New System.Windows.Forms.TextBox()
        Me.TxtSname = New System.Windows.Forms.TextBox()
        Me.TxtRqstdate = New System.Windows.Forms.TextBox()
        Me.txtacct = New System.Windows.Forms.TextBox()
        Me.txtHnum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblinvest = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkcomp = New System.Windows.Forms.CheckBox()
        Me.BTNcancel = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Dtgradinvest = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtRadresult = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltrtd = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Dtgradinvest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Lblreprtby)
        Me.Panel3.Controls.Add(Me.lbltim)
        Me.Panel3.Controls.Add(Me.lbldte)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(4, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1011, 100)
        Me.Panel3.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(866, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "ReportedBy"
        '
        'Lblreprtby
        '
        Me.Lblreprtby.AutoSize = True
        Me.Lblreprtby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblreprtby.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblreprtby.ForeColor = System.Drawing.Color.Navy
        Me.Lblreprtby.Location = New System.Drawing.Point(831, 43)
        Me.Lblreprtby.Name = "Lblreprtby"
        Me.Lblreprtby.Size = New System.Drawing.Size(14, 19)
        Me.Lblreprtby.TabIndex = 23
        Me.Lblreprtby.Text = " "
        '
        'lbltim
        '
        Me.lbltim.AutoSize = True
        Me.lbltim.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltim.Location = New System.Drawing.Point(907, 74)
        Me.lbltim.Name = "lbltim"
        Me.lbltim.Size = New System.Drawing.Size(47, 17)
        Me.lbltim.TabIndex = 18
        Me.lbltim.Text = "Time:"
        '
        'lbldte
        '
        Me.lbldte.AutoSize = True
        Me.lbldte.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldte.Location = New System.Drawing.Point(823, 74)
        Me.lbldte.Name = "lbldte"
        Me.lbldte.Size = New System.Drawing.Size(44, 17)
        Me.lbldte.TabIndex = 17
        Me.lbldte.Text = "Date:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Lblrqstnum)
        Me.Panel4.Controls.Add(Me.lblbilledby)
        Me.Panel4.Controls.Add(Me.txtOname)
        Me.Panel4.Controls.Add(Me.txtRqstby)
        Me.Panel4.Controls.Add(Me.txtage)
        Me.Panel4.Controls.Add(Me.txtsex)
        Me.Panel4.Controls.Add(Me.TxtSname)
        Me.Panel4.Controls.Add(Me.TxtRqstdate)
        Me.Panel4.Controls.Add(Me.txtacct)
        Me.Panel4.Controls.Add(Me.txtHnum)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(10, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(803, 88)
        Me.Panel4.TabIndex = 16
        '
        'Lblrqstnum
        '
        Me.Lblrqstnum.AutoSize = True
        Me.Lblrqstnum.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblrqstnum.ForeColor = System.Drawing.Color.Navy
        Me.Lblrqstnum.Location = New System.Drawing.Point(661, 57)
        Me.Lblrqstnum.Name = "Lblrqstnum"
        Me.Lblrqstnum.Size = New System.Drawing.Size(95, 17)
        Me.Lblrqstnum.TabIndex = 22
        Me.Lblrqstnum.Text = "Request num"
        Me.Lblrqstnum.Visible = False
        '
        'lblbilledby
        '
        Me.lblbilledby.AutoSize = True
        Me.lblbilledby.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbilledby.ForeColor = System.Drawing.Color.Navy
        Me.lblbilledby.Location = New System.Drawing.Point(577, 57)
        Me.lblbilledby.Name = "lblbilledby"
        Me.lblbilledby.Size = New System.Drawing.Size(71, 17)
        Me.lblbilledby.TabIndex = 21
        Me.lblbilledby.Text = "Billed by:"
        Me.lblbilledby.Visible = False
        '
        'txtOname
        '
        Me.txtOname.BackColor = System.Drawing.Color.White
        Me.txtOname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOname.ForeColor = System.Drawing.Color.Black
        Me.txtOname.Location = New System.Drawing.Point(455, 4)
        Me.txtOname.Name = "txtOname"
        Me.txtOname.ReadOnly = True
        Me.txtOname.Size = New System.Drawing.Size(339, 21)
        Me.txtOname.TabIndex = 20
        '
        'txtRqstby
        '
        Me.txtRqstby.BackColor = System.Drawing.Color.White
        Me.txtRqstby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRqstby.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRqstby.ForeColor = System.Drawing.Color.Black
        Me.txtRqstby.Location = New System.Drawing.Point(308, 56)
        Me.txtRqstby.Name = "txtRqstby"
        Me.txtRqstby.ReadOnly = True
        Me.txtRqstby.Size = New System.Drawing.Size(263, 21)
        Me.txtRqstby.TabIndex = 19
        '
        'txtage
        '
        Me.txtage.BackColor = System.Drawing.Color.White
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.ForeColor = System.Drawing.Color.Black
        Me.txtage.Location = New System.Drawing.Point(430, 30)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(44, 21)
        Me.txtage.TabIndex = 18
        '
        'txtsex
        '
        Me.txtsex.BackColor = System.Drawing.Color.White
        Me.txtsex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsex.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.ForeColor = System.Drawing.Color.Black
        Me.txtsex.Location = New System.Drawing.Point(308, 30)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.ReadOnly = True
        Me.txtsex.Size = New System.Drawing.Size(85, 21)
        Me.txtsex.TabIndex = 17
        '
        'TxtSname
        '
        Me.TxtSname.BackColor = System.Drawing.Color.White
        Me.TxtSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSname.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSname.ForeColor = System.Drawing.Color.Black
        Me.TxtSname.Location = New System.Drawing.Point(100, 5)
        Me.TxtSname.Name = "TxtSname"
        Me.TxtSname.ReadOnly = True
        Me.TxtSname.Size = New System.Drawing.Size(259, 21)
        Me.TxtSname.TabIndex = 16
        '
        'TxtRqstdate
        '
        Me.TxtRqstdate.BackColor = System.Drawing.Color.White
        Me.TxtRqstdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRqstdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRqstdate.ForeColor = System.Drawing.Color.Black
        Me.TxtRqstdate.Location = New System.Drawing.Point(100, 56)
        Me.TxtRqstdate.Name = "TxtRqstdate"
        Me.TxtRqstdate.ReadOnly = True
        Me.TxtRqstdate.Size = New System.Drawing.Size(107, 21)
        Me.TxtRqstdate.TabIndex = 14
        '
        'txtacct
        '
        Me.txtacct.BackColor = System.Drawing.Color.White
        Me.txtacct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtacct.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacct.ForeColor = System.Drawing.Color.Black
        Me.txtacct.Location = New System.Drawing.Point(567, 31)
        Me.txtacct.Name = "txtacct"
        Me.txtacct.ReadOnly = True
        Me.txtacct.Size = New System.Drawing.Size(227, 21)
        Me.txtacct.TabIndex = 13
        '
        'txtHnum
        '
        Me.txtHnum.BackColor = System.Drawing.Color.White
        Me.txtHnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHnum.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHnum.ForeColor = System.Drawing.Color.Black
        Me.txtHnum.Location = New System.Drawing.Point(100, 30)
        Me.txtHnum.Name = "txtHnum"
        Me.txtHnum.ReadOnly = True
        Me.txtHnum.Size = New System.Drawing.Size(162, 21)
        Me.txtHnum.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(271, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Sex:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(3, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Requested:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(365, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Other Names:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(41, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Surname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(13, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Hospital_Num:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(213, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Requested By:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(399, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Age:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(480, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Account type:"
        '
        'lblinvest
        '
        Me.lblinvest.AutoSize = True
        Me.lblinvest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvest.ForeColor = System.Drawing.Color.DarkRed
        Me.lblinvest.Location = New System.Drawing.Point(306, 13)
        Me.lblinvest.Name = "lblinvest"
        Me.lblinvest.Size = New System.Drawing.Size(39, 15)
        Me.lblinvest.TabIndex = 2
        Me.lblinvest.Text = "fgdfgf"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkcomp)
        Me.Panel1.Controls.Add(Me.BTNcancel)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TxtPass)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Dtgradinvest)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.lbltrtd)
        Me.Panel1.Location = New System.Drawing.Point(6, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 394)
        Me.Panel1.TabIndex = 2
        '
        'chkcomp
        '
        Me.chkcomp.AutoSize = True
        Me.chkcomp.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcomp.ForeColor = System.Drawing.Color.DarkGreen
        Me.chkcomp.Location = New System.Drawing.Point(841, 290)
        Me.chkcomp.Name = "chkcomp"
        Me.chkcomp.Size = New System.Drawing.Size(125, 21)
        Me.chkcomp.TabIndex = 9
        Me.chkcomp.Text = "COMPLETED"
        Me.chkcomp.UseVisualStyleBackColor = True
        '
        'BTNcancel
        '
        Me.BTNcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNcancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNcancel.ForeColor = System.Drawing.Color.OrangeRed
        Me.BTNcancel.Location = New System.Drawing.Point(838, 350)
        Me.BTNcancel.Name = "BTNcancel"
        Me.BTNcancel.Size = New System.Drawing.Size(75, 32)
        Me.BTNcancel.TabIndex = 7
        Me.BTNcancel.Text = "CANCEL"
        Me.BTNcancel.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(772, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Password:"
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPass.Location = New System.Drawing.Point(838, 326)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.TxtPass.Size = New System.Drawing.Size(160, 20)
        Me.TxtPass.TabIndex = 4
        '
        'Btnsave
        '
        Me.Btnsave.Enabled = False
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.DarkGreen
        Me.Btnsave.Location = New System.Drawing.Point(919, 352)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(75, 30)
        Me.Btnsave.TabIndex = 2
        Me.Btnsave.Text = "SAVE "
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Dtgradinvest
        '
        Me.Dtgradinvest.AllowUserToAddRows = False
        Me.Dtgradinvest.AllowUserToDeleteRows = False
        Me.Dtgradinvest.BackgroundColor = System.Drawing.Color.White
        Me.Dtgradinvest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgradinvest.GridColor = System.Drawing.Color.Black
        Me.Dtgradinvest.Location = New System.Drawing.Point(776, 32)
        Me.Dtgradinvest.Name = "Dtgradinvest"
        Me.Dtgradinvest.ReadOnly = True
        Me.Dtgradinvest.Size = New System.Drawing.Size(221, 242)
        Me.Dtgradinvest.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(5, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(761, 382)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TxtRadresult)
        Me.TabPage1.Controls.Add(Me.lblinvest)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(753, 354)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RESULT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TxtRadresult
        '
        Me.TxtRadresult.Location = New System.Drawing.Point(6, 31)
        Me.TxtRadresult.Multiline = True
        Me.TxtRadresult.Name = "TxtRadresult"
        Me.TxtRadresult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtRadresult.Size = New System.Drawing.Size(741, 320)
        Me.TxtRadresult.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(753, 354)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "IMAGES"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLACE A DICON IMAGE VIEWER ORPDF,JPEG, OR OTHER IMAGES"
        '
        'lbltrtd
        '
        Me.lbltrtd.AutoSize = True
        Me.lbltrtd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltrtd.ForeColor = System.Drawing.Color.DarkRed
        Me.lbltrtd.Location = New System.Drawing.Point(851, 359)
        Me.lbltrtd.Name = "lbltrtd"
        Me.lbltrtd.Size = New System.Drawing.Size(48, 15)
        Me.lbltrtd.TabIndex = 8
        Me.lbltrtd.Text = "Treated"
        Me.lbltrtd.Visible = False
        '
        'frmRADResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRADResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "       RADIOLOGY RESULT FORM"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Dtgradinvest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbltim As Label
    Friend WithEvents lbldte As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblbilledby As Label
    Friend WithEvents txtOname As TextBox
    Friend WithEvents txtRqstby As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtsex As TextBox
    Friend WithEvents TxtSname As TextBox
    Friend WithEvents TxtRqstdate As TextBox
    Friend WithEvents txtacct As TextBox
    Friend WithEvents txtHnum As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Dtgradinvest As DataGridView
    Friend WithEvents lblinvest As Label
    Friend WithEvents Lblrqstnum As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Btnsave As Button
    Friend WithEvents Lblreprtby As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BTNcancel As Button
    Friend WithEvents lbltrtd As Label
    Friend WithEvents TxtRadresult As TextBox
    Friend WithEvents chkcomp As CheckBox
End Class
