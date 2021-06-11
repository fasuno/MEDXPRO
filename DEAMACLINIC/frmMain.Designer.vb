<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblrole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btnregister = New System.Windows.Forms.Button()
        Me.btnvitals = New System.Windows.Forms.Button()
        Me.btnadmit = New System.Windows.Forms.Button()
        Me.btninjection = New System.Windows.Forms.Button()
        Me.btnmylist = New System.Windows.Forms.Button()
        Me.btnAlllist = New System.Windows.Forms.Button()
        Me.btnlabinvest = New System.Windows.Forms.Button()
        Me.btnlabtestlist = New System.Windows.Forms.Button()
        Me.btndrugrest = New System.Windows.Forms.Button()
        Me.Btnstat = New System.Windows.Forms.Button()
        Me.btnnewdrg = New System.Windows.Forms.Button()
        Me.btndruglist = New System.Windows.Forms.Button()
        Me.btnradrqst = New System.Windows.Forms.Button()
        Me.btncashpoint = New System.Windows.Forms.Button()
        Me.btnnewuser = New System.Windows.Forms.Button()
        Me.btnedituser = New System.Windows.Forms.Button()
        Me.btnsetservice = New System.Windows.Forms.Button()
        Me.btnexits = New System.Windows.Forms.Button()
        Me.btnlogoff = New System.Windows.Forms.Button()
        Me.btnanc = New System.Windows.Forms.Button()
        Me.Btnappt = New System.Windows.Forms.Button()
        Me.btnreg = New System.Windows.Forms.Button()
        Me.BtnRadInv = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblhospname = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblroleid = New System.Windows.Forms.Label()
        Me.StatusStrip.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.White
        Me.StatusStrip.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabel1, Me.lblname, Me.ToolStripStatusLabel2, Me.lblrole})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1160, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(46, 17)
        Me.ToolStripStatusLabel.Text = "Status:"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(310, 17)
        Me.ToolStripStatusLabel1.Text = "                           You are Logged in as :                                " &
    "  "
        '
        'lblname
        '
        Me.lblname.ForeColor = System.Drawing.Color.Black
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(229, 17)
        Me.lblname.Text = "                                                                          "
        Me.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel2.Text = "            "
        '
        'lblrole
        '
        Me.lblrole.ForeColor = System.Drawing.Color.Black
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(151, 17)
        Me.lblrole.Text = "                                                "
        '
        'Btnregister
        '
        Me.Btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnregister.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnregister.Image = CType(resources.GetObject("Btnregister.Image"), System.Drawing.Image)
        Me.Btnregister.Location = New System.Drawing.Point(3, 2)
        Me.Btnregister.Name = "Btnregister"
        Me.Btnregister.Size = New System.Drawing.Size(47, 44)
        Me.Btnregister.TabIndex = 0
        Me.Btnregister.Text = " "
        Me.Btnregister.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btnregister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.Btnregister, "Registers")
        Me.Btnregister.UseVisualStyleBackColor = True
        '
        'btnvitals
        '
        Me.btnvitals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvitals.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvitals.Image = CType(resources.GetObject("btnvitals.Image"), System.Drawing.Image)
        Me.btnvitals.Location = New System.Drawing.Point(3, 2)
        Me.btnvitals.Name = "btnvitals"
        Me.btnvitals.Size = New System.Drawing.Size(47, 44)
        Me.btnvitals.TabIndex = 1
        Me.btnvitals.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnvitals.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnvitals, "Vital Sign")
        Me.btnvitals.UseVisualStyleBackColor = True
        '
        'btnadmit
        '
        Me.btnadmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmit.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadmit.Image = CType(resources.GetObject("btnadmit.Image"), System.Drawing.Image)
        Me.btnadmit.Location = New System.Drawing.Point(103, 2)
        Me.btnadmit.Name = "btnadmit"
        Me.btnadmit.Size = New System.Drawing.Size(47, 44)
        Me.btnadmit.TabIndex = 2
        Me.btnadmit.Text = " "
        Me.btnadmit.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnadmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnadmit, "Admission Register")
        Me.btnadmit.UseVisualStyleBackColor = True
        '
        'btninjection
        '
        Me.btninjection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninjection.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninjection.Image = CType(resources.GetObject("btninjection.Image"), System.Drawing.Image)
        Me.btninjection.Location = New System.Drawing.Point(53, 2)
        Me.btninjection.Name = "btninjection"
        Me.btninjection.Size = New System.Drawing.Size(47, 44)
        Me.btninjection.TabIndex = 3
        Me.btninjection.Text = " "
        Me.btninjection.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btninjection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btninjection, "Injection register")
        Me.btninjection.UseVisualStyleBackColor = True
        '
        'btnmylist
        '
        Me.btnmylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmylist.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmylist.Image = CType(resources.GetObject("btnmylist.Image"), System.Drawing.Image)
        Me.btnmylist.Location = New System.Drawing.Point(4, 3)
        Me.btnmylist.Name = "btnmylist"
        Me.btnmylist.Size = New System.Drawing.Size(47, 44)
        Me.btnmylist.TabIndex = 2
        Me.btnmylist.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnmylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnmylist, "My waiting List")
        Me.btnmylist.UseVisualStyleBackColor = True
        '
        'btnAlllist
        '
        Me.btnAlllist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlllist.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlllist.Image = CType(resources.GetObject("btnAlllist.Image"), System.Drawing.Image)
        Me.btnAlllist.Location = New System.Drawing.Point(54, 3)
        Me.btnAlllist.Name = "btnAlllist"
        Me.btnAlllist.Size = New System.Drawing.Size(47, 44)
        Me.btnAlllist.TabIndex = 3
        Me.btnAlllist.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAlllist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnAlllist, "General waiting list")
        Me.btnAlllist.UseVisualStyleBackColor = True
        '
        'btnlabinvest
        '
        Me.btnlabinvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlabinvest.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlabinvest.Image = CType(resources.GetObject("btnlabinvest.Image"), System.Drawing.Image)
        Me.btnlabinvest.Location = New System.Drawing.Point(3, 3)
        Me.btnlabinvest.Name = "btnlabinvest"
        Me.btnlabinvest.Size = New System.Drawing.Size(47, 44)
        Me.btnlabinvest.TabIndex = 3
        Me.btnlabinvest.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnlabinvest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnlabinvest, "Lab. Request")
        Me.btnlabinvest.UseVisualStyleBackColor = True
        '
        'btnlabtestlist
        '
        Me.btnlabtestlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlabtestlist.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlabtestlist.Image = CType(resources.GetObject("btnlabtestlist.Image"), System.Drawing.Image)
        Me.btnlabtestlist.Location = New System.Drawing.Point(54, 3)
        Me.btnlabtestlist.Name = "btnlabtestlist"
        Me.btnlabtestlist.Size = New System.Drawing.Size(47, 44)
        Me.btnlabtestlist.TabIndex = 4
        Me.btnlabtestlist.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnlabtestlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnlabtestlist, "Lab. Test list")
        Me.btnlabtestlist.UseVisualStyleBackColor = True
        '
        'btndrugrest
        '
        Me.btndrugrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndrugrest.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndrugrest.Image = CType(resources.GetObject("btndrugrest.Image"), System.Drawing.Image)
        Me.btndrugrest.Location = New System.Drawing.Point(4, 3)
        Me.btndrugrest.Name = "btndrugrest"
        Me.btndrugrest.Size = New System.Drawing.Size(47, 44)
        Me.btndrugrest.TabIndex = 3
        Me.btndrugrest.Text = " "
        Me.btndrugrest.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btndrugrest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btndrugrest, "Drugs request")
        Me.btndrugrest.UseVisualStyleBackColor = True
        '
        'Btnstat
        '
        Me.Btnstat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnstat.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnstat.Image = CType(resources.GetObject("Btnstat.Image"), System.Drawing.Image)
        Me.Btnstat.Location = New System.Drawing.Point(52, 2)
        Me.Btnstat.Name = "Btnstat"
        Me.Btnstat.Size = New System.Drawing.Size(47, 44)
        Me.Btnstat.TabIndex = 3
        Me.Btnstat.Text = " "
        Me.Btnstat.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btnstat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.Btnstat, "Statistics")
        Me.Btnstat.UseVisualStyleBackColor = True
        '
        'btnnewdrg
        '
        Me.btnnewdrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewdrg.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewdrg.Image = CType(resources.GetObject("btnnewdrg.Image"), System.Drawing.Image)
        Me.btnnewdrg.Location = New System.Drawing.Point(54, 3)
        Me.btnnewdrg.Name = "btnnewdrg"
        Me.btnnewdrg.Size = New System.Drawing.Size(47, 44)
        Me.btnnewdrg.TabIndex = 4
        Me.btnnewdrg.Text = " "
        Me.btnnewdrg.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnnewdrg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnnewdrg, "New Drug")
        Me.btnnewdrg.UseVisualStyleBackColor = True
        '
        'btndruglist
        '
        Me.btndruglist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndruglist.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndruglist.Image = CType(resources.GetObject("btndruglist.Image"), System.Drawing.Image)
        Me.btndruglist.Location = New System.Drawing.Point(104, 3)
        Me.btndruglist.Name = "btndruglist"
        Me.btndruglist.Size = New System.Drawing.Size(47, 44)
        Me.btndruglist.TabIndex = 5
        Me.btndruglist.Text = " "
        Me.btndruglist.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btndruglist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btndruglist, "Drug List")
        Me.btndruglist.UseVisualStyleBackColor = True
        '
        'btnradrqst
        '
        Me.btnradrqst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnradrqst.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnradrqst.Image = CType(resources.GetObject("btnradrqst.Image"), System.Drawing.Image)
        Me.btnradrqst.Location = New System.Drawing.Point(5, 3)
        Me.btnradrqst.Name = "btnradrqst"
        Me.btnradrqst.Size = New System.Drawing.Size(47, 44)
        Me.btnradrqst.TabIndex = 5
        Me.btnradrqst.Text = " "
        Me.btnradrqst.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnradrqst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnradrqst, "Rad. Request")
        Me.btnradrqst.UseVisualStyleBackColor = True
        '
        'btncashpoint
        '
        Me.btncashpoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncashpoint.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncashpoint.Image = CType(resources.GetObject("btncashpoint.Image"), System.Drawing.Image)
        Me.btncashpoint.Location = New System.Drawing.Point(4, 3)
        Me.btncashpoint.Name = "btncashpoint"
        Me.btncashpoint.Size = New System.Drawing.Size(47, 44)
        Me.btncashpoint.TabIndex = 6
        Me.btncashpoint.Text = " "
        Me.btncashpoint.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btncashpoint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btncashpoint, "Pay Point")
        Me.btncashpoint.UseVisualStyleBackColor = True
        '
        'btnnewuser
        '
        Me.btnnewuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewuser.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewuser.Image = CType(resources.GetObject("btnnewuser.Image"), System.Drawing.Image)
        Me.btnnewuser.Location = New System.Drawing.Point(4, 3)
        Me.btnnewuser.Name = "btnnewuser"
        Me.btnnewuser.Size = New System.Drawing.Size(47, 44)
        Me.btnnewuser.TabIndex = 7
        Me.btnnewuser.Text = " "
        Me.btnnewuser.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnnewuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnnewuser, "Create User")
        Me.btnnewuser.UseVisualStyleBackColor = True
        '
        'btnedituser
        '
        Me.btnedituser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedituser.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedituser.Image = CType(resources.GetObject("btnedituser.Image"), System.Drawing.Image)
        Me.btnedituser.Location = New System.Drawing.Point(55, 3)
        Me.btnedituser.Name = "btnedituser"
        Me.btnedituser.Size = New System.Drawing.Size(47, 44)
        Me.btnedituser.TabIndex = 8
        Me.btnedituser.Text = " "
        Me.btnedituser.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnedituser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnedituser, "Edit user profile")
        Me.btnedituser.UseVisualStyleBackColor = True
        '
        'btnsetservice
        '
        Me.btnsetservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsetservice.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsetservice.Image = CType(resources.GetObject("btnsetservice.Image"), System.Drawing.Image)
        Me.btnsetservice.Location = New System.Drawing.Point(3, 3)
        Me.btnsetservice.Name = "btnsetservice"
        Me.btnsetservice.Size = New System.Drawing.Size(47, 44)
        Me.btnsetservice.TabIndex = 8
        Me.btnsetservice.Text = " "
        Me.btnsetservice.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnsetservice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnsetservice, "Service settings")
        Me.btnsetservice.UseVisualStyleBackColor = True
        '
        'btnexits
        '
        Me.btnexits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexits.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexits.Image = CType(resources.GetObject("btnexits.Image"), System.Drawing.Image)
        Me.btnexits.Location = New System.Drawing.Point(53, 3)
        Me.btnexits.Name = "btnexits"
        Me.btnexits.Size = New System.Drawing.Size(47, 44)
        Me.btnexits.TabIndex = 8
        Me.btnexits.Text = " "
        Me.btnexits.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnexits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnexits, "Exit Medxpro")
        Me.btnexits.UseVisualStyleBackColor = True
        '
        'btnlogoff
        '
        Me.btnlogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogoff.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogoff.Image = CType(resources.GetObject("btnlogoff.Image"), System.Drawing.Image)
        Me.btnlogoff.Location = New System.Drawing.Point(3, 3)
        Me.btnlogoff.Name = "btnlogoff"
        Me.btnlogoff.Size = New System.Drawing.Size(47, 44)
        Me.btnlogoff.TabIndex = 9
        Me.btnlogoff.Text = " "
        Me.btnlogoff.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnlogoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnlogoff, "Log out")
        Me.btnlogoff.UseVisualStyleBackColor = True
        '
        'btnanc
        '
        Me.btnanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnanc.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnanc.Image = CType(resources.GetObject("btnanc.Image"), System.Drawing.Image)
        Me.btnanc.Location = New System.Drawing.Point(101, 2)
        Me.btnanc.Name = "btnanc"
        Me.btnanc.Size = New System.Drawing.Size(47, 44)
        Me.btnanc.TabIndex = 5
        Me.btnanc.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnanc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnanc, "Ante-natal")
        Me.btnanc.UseVisualStyleBackColor = True
        '
        'Btnappt
        '
        Me.Btnappt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnappt.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnappt.Image = CType(resources.GetObject("Btnappt.Image"), System.Drawing.Image)
        Me.Btnappt.Location = New System.Drawing.Point(150, 2)
        Me.Btnappt.Name = "Btnappt"
        Me.Btnappt.Size = New System.Drawing.Size(47, 44)
        Me.Btnappt.TabIndex = 6
        Me.Btnappt.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btnappt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.Btnappt, "Appointment")
        Me.Btnappt.UseVisualStyleBackColor = True
        '
        'btnreg
        '
        Me.btnreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreg.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg.Image = CType(resources.GetObject("btnreg.Image"), System.Drawing.Image)
        Me.btnreg.Location = New System.Drawing.Point(199, 2)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(47, 44)
        Me.btnreg.TabIndex = 7
        Me.btnreg.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnreg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.btnreg, "New Folder")
        Me.btnreg.UseVisualStyleBackColor = True
        '
        'BtnRadInv
        '
        Me.BtnRadInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRadInv.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRadInv.Image = CType(resources.GetObject("BtnRadInv.Image"), System.Drawing.Image)
        Me.BtnRadInv.Location = New System.Drawing.Point(54, 3)
        Me.BtnRadInv.Name = "BtnRadInv"
        Me.BtnRadInv.Size = New System.Drawing.Size(47, 44)
        Me.BtnRadInv.TabIndex = 6
        Me.BtnRadInv.Text = " "
        Me.BtnRadInv.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnRadInv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip.SetToolTip(Me.BtnRadInv, "Investigation List")
        Me.BtnRadInv.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1158, 79)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.White
        Me.TabPage8.Controls.Add(Me.btnlogoff)
        Me.TabPage8.Controls.Add(Me.btnexits)
        Me.TabPage8.Location = New System.Drawing.Point(4, 24)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "File   "
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.btnreg)
        Me.TabPage1.Controls.Add(Me.Btnappt)
        Me.TabPage1.Controls.Add(Me.btnanc)
        Me.TabPage1.Controls.Add(Me.Btnstat)
        Me.TabPage1.Controls.Add(Me.Btnregister)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Records   "
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.btninjection)
        Me.TabPage2.Controls.Add(Me.btnadmit)
        Me.TabPage2.Controls.Add(Me.btnvitals)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nursing Care   "
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.btnAlllist)
        Me.TabPage3.Controls.Add(Me.btnmylist)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Waiting List   "
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.btnlabtestlist)
        Me.TabPage4.Controls.Add(Me.btnlabinvest)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Laboratory   "
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Controls.Add(Me.btndruglist)
        Me.TabPage5.Controls.Add(Me.btnnewdrg)
        Me.TabPage5.Controls.Add(Me.btndrugrest)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Pharmacy   "
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Controls.Add(Me.BtnRadInv)
        Me.TabPage6.Controls.Add(Me.btnradrqst)
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Radiology   "
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.White
        Me.TabPage7.Controls.Add(Me.btncashpoint)
        Me.TabPage7.Location = New System.Drawing.Point(4, 24)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Account   "
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.Color.White
        Me.TabPage9.Controls.Add(Me.btnedituser)
        Me.TabPage9.Controls.Add(Me.btnnewuser)
        Me.TabPage9.Location = New System.Drawing.Point(4, 24)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Admin   "
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.Color.White
        Me.TabPage10.Controls.Add(Me.btnsetservice)
        Me.TabPage10.Location = New System.Drawing.Point(4, 24)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Settings   "
        '
        'TabPage11
        '
        Me.TabPage11.BackColor = System.Drawing.Color.White
        Me.TabPage11.Location = New System.Drawing.Point(4, 24)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(1150, 51)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "Help   "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblhospname)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1160, 26)
        Me.Panel1.TabIndex = 13
        '
        'lblhospname
        '
        Me.lblhospname.AutoSize = True
        Me.lblhospname.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhospname.ForeColor = System.Drawing.Color.White
        Me.lblhospname.Location = New System.Drawing.Point(336, 7)
        Me.lblhospname.Name = "lblhospname"
        Me.lblhospname.Size = New System.Drawing.Size(0, 15)
        Me.lblhospname.TabIndex = 19
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltime.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(1062, 3)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(10, 15)
        Me.lbltime.TabIndex = 18
        Me.lbltime.Text = " "
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbldate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Location = New System.Drawing.Point(954, 3)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(10, 15)
        Me.lbldate.TabIndex = 17
        Me.lbldate.Text = " "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Medx-pro"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(8, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 31)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TabControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1160, 80)
        Me.Panel3.TabIndex = 15
        '
        'Timer1
        '
        '
        'lblroleid
        '
        Me.lblroleid.AutoSize = True
        Me.lblroleid.BackColor = System.Drawing.Color.White
        Me.lblroleid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblroleid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroleid.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblroleid.Location = New System.Drawing.Point(1090, 29)
        Me.lblroleid.Name = "lblroleid"
        Me.lblroleid.Size = New System.Drawing.Size(10, 15)
        Me.lblroleid.TabIndex = 9
        Me.lblroleid.Text = " "
        Me.lblroleid.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1160, 453)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblroleid)
        Me.Controls.Add(Me.StatusStrip)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEDx-pro"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblname As ToolStripStatusLabel
    Friend WithEvents lblrole As ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents Btnregister As Button
    Friend WithEvents btnadmit As Button
    Friend WithEvents btnvitals As Button
    Friend WithEvents btninjection As Button
    Friend WithEvents btnAlllist As Button
    Friend WithEvents btnmylist As Button
    Friend WithEvents btnlabtestlist As Button
    Friend WithEvents btnlabinvest As Button
    Friend WithEvents Btnstat As Button
    Friend WithEvents btndrugrest As Button
    Friend WithEvents btnnewdrg As Button
    Friend WithEvents btndruglist As Button
    Friend WithEvents btnradrqst As Button
    Friend WithEvents btncashpoint As Button
    Friend WithEvents btnedituser As Button
    Friend WithEvents btnnewuser As Button
    Friend WithEvents btnsetservice As Button
    Friend WithEvents btnlogoff As Button
    Friend WithEvents btnexits As Button
    Friend WithEvents btnanc As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lbldate As Label
    Friend WithEvents btnreg As Button
    Friend WithEvents Btnappt As Button
    Friend WithEvents BtnRadInv As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbltime As Label
    Friend WithEvents lblroleid As Label
    Friend WithEvents lblhospname As Label
End Class
