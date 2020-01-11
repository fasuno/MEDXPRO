<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRadiology
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRadiology))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Dtgpendrad = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Txtfinrad = New System.Windows.Forms.TextBox()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.DateFrm = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DtgRadBilled = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btnfindbill = New System.Windows.Forms.Button()
        Me.TxtfindBill = New System.Windows.Forms.TextBox()
        Me.ChkViewBill = New System.Windows.Forms.CheckBox()
        Me.RefBill = New System.Windows.Forms.Button()
        Me.DatebillTo = New System.Windows.Forms.DateTimePicker()
        Me.Datebillfrm = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DtgRAdtreated = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btnsearchtrtd = New System.Windows.Forms.Button()
        Me.TxtfindTrtd = New System.Windows.Forms.TextBox()
        Me.ViewallTrtd = New System.Windows.Forms.CheckBox()
        Me.BtnRefTrtd = New System.Windows.Forms.Button()
        Me.DateTrtdTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTrtdFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblrec = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dtgpendrad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DtgRadBilled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DtgRAdtreated, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(4, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1132, 518)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Dtgpendrad)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1124, 490)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PENDING"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Dtgpendrad
        '
        Me.Dtgpendrad.AllowUserToAddRows = False
        Me.Dtgpendrad.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Dtgpendrad.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dtgpendrad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgpendrad.Location = New System.Drawing.Point(7, 54)
        Me.Dtgpendrad.Name = "Dtgpendrad"
        Me.Dtgpendrad.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Dtgpendrad.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Dtgpendrad.Size = New System.Drawing.Size(1111, 430)
        Me.Dtgpendrad.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.Txtfinrad)
        Me.Panel1.Controls.Add(Me.ChkAll)
        Me.Panel1.Controls.Add(Me.BtnRefresh)
        Me.Panel1.Controls.Add(Me.DateTo)
        Me.Panel1.Controls.Add(Me.DateFrm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1111, 42)
        Me.Panel1.TabIndex = 0
        '
        'BtnSearch
        '
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.ForeColor = System.Drawing.Color.Green
        Me.BtnSearch.Location = New System.Drawing.Point(1041, 6)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(63, 26)
        Me.BtnSearch.TabIndex = 7
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'Txtfinrad
        '
        Me.Txtfinrad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtfinrad.Location = New System.Drawing.Point(872, 10)
        Me.Txtfinrad.Name = "Txtfinrad"
        Me.Txtfinrad.Size = New System.Drawing.Size(165, 21)
        Me.Txtfinrad.TabIndex = 6
        '
        'ChkAll
        '
        Me.ChkAll.AutoSize = True
        Me.ChkAll.ForeColor = System.Drawing.Color.DarkBlue
        Me.ChkAll.Location = New System.Drawing.Point(796, 11)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(70, 19)
        Me.ChkAll.TabIndex = 5
        Me.ChkAll.Text = "View All"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRefresh.ForeColor = System.Drawing.Color.DarkBlue
        Me.BtnRefresh.Location = New System.Drawing.Point(470, 6)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(68, 26)
        Me.BtnRefresh.TabIndex = 4
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'DateTo
        '
        Me.DateTo.Location = New System.Drawing.Point(254, 8)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(205, 21)
        Me.DateTo.TabIndex = 3
        '
        'DateFrm
        '
        Me.DateFrm.Location = New System.Drawing.Point(12, 8)
        Me.DateFrm.Name = "DateFrm"
        Me.DateFrm.Size = New System.Drawing.Size(207, 21)
        Me.DateFrm.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(228, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "To"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DtgRadBilled)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1124, 490)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INCOMPLETE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DtgRadBilled
        '
        Me.DtgRadBilled.AllowUserToAddRows = False
        Me.DtgRadBilled.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple
        Me.DtgRadBilled.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DtgRadBilled.BackgroundColor = System.Drawing.Color.White
        Me.DtgRadBilled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRadBilled.Location = New System.Drawing.Point(6, 54)
        Me.DtgRadBilled.Name = "DtgRadBilled"
        Me.DtgRadBilled.ReadOnly = True
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DtgRadBilled.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DtgRadBilled.Size = New System.Drawing.Size(1111, 430)
        Me.DtgRadBilled.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cornsilk
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Btnfindbill)
        Me.Panel2.Controls.Add(Me.TxtfindBill)
        Me.Panel2.Controls.Add(Me.ChkViewBill)
        Me.Panel2.Controls.Add(Me.RefBill)
        Me.Panel2.Controls.Add(Me.DatebillTo)
        Me.Panel2.Controls.Add(Me.Datebillfrm)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(5, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1111, 42)
        Me.Panel2.TabIndex = 2
        '
        'Btnfindbill
        '
        Me.Btnfindbill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnfindbill.ForeColor = System.Drawing.Color.Green
        Me.Btnfindbill.Location = New System.Drawing.Point(1041, 6)
        Me.Btnfindbill.Name = "Btnfindbill"
        Me.Btnfindbill.Size = New System.Drawing.Size(63, 26)
        Me.Btnfindbill.TabIndex = 7
        Me.Btnfindbill.Text = "Search"
        Me.Btnfindbill.UseVisualStyleBackColor = True
        '
        'TxtfindBill
        '
        Me.TxtfindBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtfindBill.Location = New System.Drawing.Point(872, 10)
        Me.TxtfindBill.Name = "TxtfindBill"
        Me.TxtfindBill.Size = New System.Drawing.Size(165, 21)
        Me.TxtfindBill.TabIndex = 6
        '
        'ChkViewBill
        '
        Me.ChkViewBill.AutoSize = True
        Me.ChkViewBill.ForeColor = System.Drawing.Color.DarkBlue
        Me.ChkViewBill.Location = New System.Drawing.Point(796, 11)
        Me.ChkViewBill.Name = "ChkViewBill"
        Me.ChkViewBill.Size = New System.Drawing.Size(70, 19)
        Me.ChkViewBill.TabIndex = 5
        Me.ChkViewBill.Text = "View All"
        Me.ChkViewBill.UseVisualStyleBackColor = True
        '
        'RefBill
        '
        Me.RefBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RefBill.ForeColor = System.Drawing.Color.DarkBlue
        Me.RefBill.Location = New System.Drawing.Point(464, 7)
        Me.RefBill.Name = "RefBill"
        Me.RefBill.Size = New System.Drawing.Size(68, 26)
        Me.RefBill.TabIndex = 4
        Me.RefBill.Text = "Refresh"
        Me.RefBill.UseVisualStyleBackColor = True
        '
        'DatebillTo
        '
        Me.DatebillTo.Location = New System.Drawing.Point(248, 9)
        Me.DatebillTo.Name = "DatebillTo"
        Me.DatebillTo.Size = New System.Drawing.Size(205, 21)
        Me.DatebillTo.TabIndex = 3
        '
        'Datebillfrm
        '
        Me.Datebillfrm.Location = New System.Drawing.Point(6, 9)
        Me.Datebillfrm.Name = "Datebillfrm"
        Me.Datebillfrm.Size = New System.Drawing.Size(207, 21)
        Me.Datebillfrm.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(222, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DtgRAdtreated)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1124, 490)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TREATED"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DtgRAdtreated
        '
        Me.DtgRAdtreated.AllowUserToAddRows = False
        Me.DtgRAdtreated.AllowUserToDeleteRows = False
        Me.DtgRAdtreated.AllowUserToOrderColumns = True
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy
        Me.DtgRAdtreated.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DtgRAdtreated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgRAdtreated.Location = New System.Drawing.Point(5, 54)
        Me.DtgRAdtreated.Name = "DtgRAdtreated"
        Me.DtgRAdtreated.ReadOnly = True
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.DtgRAdtreated.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DtgRAdtreated.Size = New System.Drawing.Size(1111, 430)
        Me.DtgRAdtreated.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Btnsearchtrtd)
        Me.Panel3.Controls.Add(Me.TxtfindTrtd)
        Me.Panel3.Controls.Add(Me.ViewallTrtd)
        Me.Panel3.Controls.Add(Me.BtnRefTrtd)
        Me.Panel3.Controls.Add(Me.DateTrtdTo)
        Me.Panel3.Controls.Add(Me.DateTrtdFrom)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1111, 42)
        Me.Panel3.TabIndex = 2
        '
        'Btnsearchtrtd
        '
        Me.Btnsearchtrtd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btnsearchtrtd.ForeColor = System.Drawing.Color.Green
        Me.Btnsearchtrtd.Location = New System.Drawing.Point(1041, 6)
        Me.Btnsearchtrtd.Name = "Btnsearchtrtd"
        Me.Btnsearchtrtd.Size = New System.Drawing.Size(63, 26)
        Me.Btnsearchtrtd.TabIndex = 7
        Me.Btnsearchtrtd.Text = "Search"
        Me.Btnsearchtrtd.UseVisualStyleBackColor = True
        '
        'TxtfindTrtd
        '
        Me.TxtfindTrtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtfindTrtd.Location = New System.Drawing.Point(872, 10)
        Me.TxtfindTrtd.Name = "TxtfindTrtd"
        Me.TxtfindTrtd.Size = New System.Drawing.Size(165, 21)
        Me.TxtfindTrtd.TabIndex = 6
        '
        'ViewallTrtd
        '
        Me.ViewallTrtd.AutoSize = True
        Me.ViewallTrtd.ForeColor = System.Drawing.Color.DarkBlue
        Me.ViewallTrtd.Location = New System.Drawing.Point(796, 11)
        Me.ViewallTrtd.Name = "ViewallTrtd"
        Me.ViewallTrtd.Size = New System.Drawing.Size(70, 19)
        Me.ViewallTrtd.TabIndex = 5
        Me.ViewallTrtd.Text = "View All"
        Me.ViewallTrtd.UseVisualStyleBackColor = True
        '
        'BtnRefTrtd
        '
        Me.BtnRefTrtd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRefTrtd.ForeColor = System.Drawing.Color.DarkBlue
        Me.BtnRefTrtd.Location = New System.Drawing.Point(464, 7)
        Me.BtnRefTrtd.Name = "BtnRefTrtd"
        Me.BtnRefTrtd.Size = New System.Drawing.Size(68, 26)
        Me.BtnRefTrtd.TabIndex = 4
        Me.BtnRefTrtd.Text = "Refresh"
        Me.BtnRefTrtd.UseVisualStyleBackColor = True
        '
        'DateTrtdTo
        '
        Me.DateTrtdTo.Location = New System.Drawing.Point(248, 9)
        Me.DateTrtdTo.Name = "DateTrtdTo"
        Me.DateTrtdTo.Size = New System.Drawing.Size(205, 21)
        Me.DateTrtdTo.TabIndex = 3
        '
        'DateTrtdFrom
        '
        Me.DateTrtdFrom.Location = New System.Drawing.Point(6, 9)
        Me.DateTrtdFrom.Name = "DateTrtdFrom"
        Me.DateTrtdFrom.Size = New System.Drawing.Size(207, 21)
        Me.DateTrtdFrom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(222, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "To"
        '
        'lblrec
        '
        Me.lblrec.AutoSize = True
        Me.lblrec.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrec.Location = New System.Drawing.Point(27, 535)
        Me.lblrec.Name = "lblrec"
        Me.lblrec.Size = New System.Drawing.Size(14, 15)
        Me.lblrec.TabIndex = 1
        Me.lblrec.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 535)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Records Found."
        '
        'FrmRadiology
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1137, 559)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblrec)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmRadiology"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   RADIOLOGY"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Dtgpendrad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DtgRadBilled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DtgRAdtreated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dtgpendrad As DataGridView
    Friend WithEvents DateTo As DateTimePicker
    Friend WithEvents DateFrm As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtfinrad As TextBox
    Friend WithEvents ChkAll As CheckBox
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DtgRadBilled As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btnfindbill As Button
    Friend WithEvents TxtfindBill As TextBox
    Friend WithEvents ChkViewBill As CheckBox
    Friend WithEvents RefBill As Button
    Friend WithEvents DatebillTo As DateTimePicker
    Friend WithEvents Datebillfrm As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DtgRAdtreated As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btnsearchtrtd As Button
    Friend WithEvents TxtfindTrtd As TextBox
    Friend WithEvents ViewallTrtd As CheckBox
    Friend WithEvents BtnRefTrtd As Button
    Friend WithEvents DateTrtdTo As DateTimePicker
    Friend WithEvents DateTrtdFrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents lblrec As Label
    Friend WithEvents Label5 As Label
End Class
