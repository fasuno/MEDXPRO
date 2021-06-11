<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPtreg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPtreg))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.regdate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txthospnum = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Txtdays = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtmonths = New System.Windows.Forms.TextBox()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.txtnin = New System.Windows.Forms.TextBox()
        Me.txtstate = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.cbostate = New System.Windows.Forms.ComboBox()
        Me.cbolga = New System.Windows.Forms.ComboBox()
        Me.cbooccup = New System.Windows.Forms.ComboBox()
        Me.cborelig = New System.Windows.Forms.ComboBox()
        Me.cbonat = New System.Windows.Forms.ComboBox()
        Me.cbomarital = New System.Windows.Forms.ComboBox()
        Me.cbosex = New System.Windows.Forms.ComboBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dbo = New System.Windows.Forms.DateTimePicker()
        Me.txtothernames = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Txtprovi = New System.Windows.Forms.ComboBox()
        Me.txtemployer = New System.Windows.Forms.TextBox()
        Me.txtenrolnum = New System.Windows.Forms.TextBox()
        Me.cboenrol = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboacct = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtkinphone = New System.Windows.Forms.TextBox()
        Me.cborelat = New System.Windows.Forms.ComboBox()
        Me.txtkinname = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtkinadd = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncls = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtrecptnum = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbluser = New System.Windows.Forms.Label()
        Me.Btnupdate = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtcaution = New System.Windows.Forms.TextBox()
        Me.btncaution = New System.Windows.Forms.Button()
        Me.Btnupload = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.regdate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txthospnum)
        Me.Panel1.Location = New System.Drawing.Point(3, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 62)
        Me.Panel1.TabIndex = 0
        '
        'regdate
        '
        Me.regdate.CalendarForeColor = System.Drawing.Color.Navy
        Me.regdate.Enabled = False
        Me.regdate.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.regdate.Location = New System.Drawing.Point(110, 33)
        Me.regdate.Name = "regdate"
        Me.regdate.Size = New System.Drawing.Size(103, 20)
        Me.regdate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hospital Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date Registered:"
        '
        'txthospnum
        '
        Me.txthospnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthospnum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txthospnum.Location = New System.Drawing.Point(110, 9)
        Me.txthospnum.Name = "txthospnum"
        Me.txthospnum.Size = New System.Drawing.Size(153, 20)
        Me.txthospnum.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Txtdays)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtmonths)
        Me.GroupBox1.Controls.Add(Me.txtyear)
        Me.GroupBox1.Controls.Add(Me.txtnin)
        Me.GroupBox1.Controls.Add(Me.txtstate)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtadd)
        Me.GroupBox1.Controls.Add(Me.cbostate)
        Me.GroupBox1.Controls.Add(Me.cbolga)
        Me.GroupBox1.Controls.Add(Me.cbooccup)
        Me.GroupBox1.Controls.Add(Me.cborelig)
        Me.GroupBox1.Controls.Add(Me.cbonat)
        Me.GroupBox1.Controls.Add(Me.cbomarital)
        Me.GroupBox1.Controls.Add(Me.cbosex)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtphone)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.dbo)
        Me.GroupBox1.Controls.Add(Me.txtothernames)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtsurname)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 256)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "   PERSONAL DETAILS"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(348, 85)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(26, 13)
        Me.Label30.TabIndex = 43
        Me.Label30.Text = "Dys"
        '
        'Txtdays
        '
        Me.Txtdays.Enabled = False
        Me.Txtdays.ForeColor = System.Drawing.Color.White
        Me.Txtdays.Location = New System.Drawing.Point(321, 81)
        Me.Txtdays.Name = "Txtdays"
        Me.Txtdays.Size = New System.Drawing.Size(27, 22)
        Me.Txtdays.TabIndex = 42
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(236, 85)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(25, 13)
        Me.Label32.TabIndex = 41
        Me.Label32.Text = "Yrs"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(291, 86)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(28, 13)
        Me.Label31.TabIndex = 40
        Me.Label31.Text = "Mth"
        '
        'txtmonths
        '
        Me.txtmonths.Enabled = False
        Me.txtmonths.ForeColor = System.Drawing.Color.White
        Me.txtmonths.Location = New System.Drawing.Point(264, 80)
        Me.txtmonths.Name = "txtmonths"
        Me.txtmonths.Size = New System.Drawing.Size(26, 22)
        Me.txtmonths.TabIndex = 39
        '
        'txtyear
        '
        Me.txtyear.Enabled = False
        Me.txtyear.ForeColor = System.Drawing.Color.White
        Me.txtyear.Location = New System.Drawing.Point(205, 79)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(29, 22)
        Me.txtyear.TabIndex = 38
        '
        'txtnin
        '
        Me.txtnin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnin.Location = New System.Drawing.Point(99, 218)
        Me.txtnin.Name = "txtnin"
        Me.txtnin.Size = New System.Drawing.Size(179, 22)
        Me.txtnin.TabIndex = 36
        '
        'txtstate
        '
        Me.txtstate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstate.Location = New System.Drawing.Point(490, 189)
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(135, 22)
        Me.txtstate.TabIndex = 35
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(403, 190)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 15)
        Me.Label29.TabIndex = 34
        Me.Label29.Text = "Non Nigerian:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(48, 226)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 14)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "(if any):"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(21, 226)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 15)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "NIN:"
        '
        'txtadd
        '
        Me.txtadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtadd.ForeColor = System.Drawing.Color.Black
        Me.txtadd.Location = New System.Drawing.Point(100, 106)
        Me.txtadd.Multiline = True
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(271, 54)
        Me.txtadd.TabIndex = 31
        '
        'cbostate
        '
        Me.cbostate.AutoCompleteCustomSource.AddRange(New String() {"States", "Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa", "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Enugu", "Edo", "Ekiti", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano", "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa", "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers", "Sokoto", "Taraba", "Yobe", "Zamfara"})
        Me.cbostate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbostate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbostate.FormattingEnabled = True
        Me.cbostate.Items.AddRange(New Object() {"States", "Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa", "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Enugu", "Edo", "Ekiti", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano", "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa", "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers", "Sokoto", "Taraba", "Yobe", "Zamfara"})
        Me.cbostate.Location = New System.Drawing.Point(490, 158)
        Me.cbostate.Name = "cbostate"
        Me.cbostate.Size = New System.Drawing.Size(135, 24)
        Me.cbostate.TabIndex = 30
        '
        'cbolga
        '
        Me.cbolga.AutoCompleteCustomSource.AddRange(New String() {"Abadam", "Abaji", "Abak", "Abakaliki", "Aba North", "Aba South", "Abeokuta North", "Abeokuta South", "Abi", "Aboh Mbaise", "Abua/Odual", "Adavi", "Ado Ekiti", "Ado-Odo/Ota", "Afijio", "Afikpo North", "Afikpo South (Edda)", "Agaie", "Agatu", "Agwara", "Agege", "Aguata", "Ahiazu Mbaise", "Ahoada East", "Ahoada West", "Ajaokuta", "Ajeromi-Ifelodun", "Ajingi", "Akamkpa", "Akinyele", "Akko", "Akoko-Edo", "Akoko North-East", "Akoko North-West", "Akoko South-West", "Akoko South-East", "Akpabuyo", "Akuku-Toru", "Akure North", "Akure South", "Akwanga", "Albasu", "Aleiro", "Alimosho", "Alkaleri", "Amuwo-Odofin", "Anambra East", "Anambra West", "Anaocha", "Andoni", "Aninri", "Aniocha North", "Aniocha South", "Anka", "Ankpa", "Apa", "Apapa", "Ado", "Ardo Kola", "Arewa Dandi", "Argungu", "Arochukwu", "Asa", "Asari-Toru", "Askira/Uba", "Atakunmosa East", "Atakunmosa West", "Atiba", "Atisbo", "Augie", "Auyo", "Awe", "Awgu", "Awka North", "Awka South", "Ayamelum", "Aiyedaade", "Aiyedire", "Babura", "Badagry", "Bagudo", "Bagwai", "Bakassi", "Bokkos", "Bakori", "Bakura", "Balanga", "Bali", "Bama", "Bade", "Barkin Ladi", "Baruten", "Bassa", "Bassa", "Batagarawa", "Batsari", "Bauchi", "Baure", "Bayo", "Bebeji", "Bekwarra", "Bende", "Biase", "Bichi", "Bida", "Billiri", "Bindawa", "Binji", "Biriniwa", "Birnin Gwari", "Birnin Kebbi", "Birnin Kudu", "Birnin Magaji/Kiyaw", "Biu", "Bodinga", "Bogoro", "Boki", "Boluwaduro", "Bomadi", "Bonny", "Borgu", "Boripe", "Bursari", "Bosso", "Brass", "Buji", "Bukkuyum", "Buruku", "Bungudu", "Bunkure", "Bunza", "Burutu", "Bwari", "Calabar Municipal", "Calabar South", "Chanchaga", "Charanchi", "Chibok", "Chikun", "Dala", "Damaturu", "Damban", "Dambatta", "Damboa", "Dandi", "Dandume", "Dange Shuni", "Danja", "Dan Musa", "Darazo", "Dass", "Daura", "Dawakin Kudu", "Dawakin Tofa", "Degema", "Dekina", "Demsa", "Dikwa", "Doguwa", "Doma", "Donga", "Dukku", "Dunukofia", "Dutse", "Dutsi", "Dutsin Ma", "Eastern Obolo", "Ebonyi", "Edati", "Ede North", "Ede South", "Edu", "Ife Central", "Ife East", "Ife North", "Ife South", "Efon", "Yewa North", "Yewa South", "Egbeda", "Egbedore", "Egor", "Ehime Mbano", "Ejigbo", "Ekeremor", "Eket", "Ekiti", "Ekiti East", "Ekiti South-West", "Ekiti West", "Ekwusigo", "Eleme", "Emuoha", "Emure", "Enugu East", "Enugu North", "Enugu South", "Epe", "Esan Central", "Esan North-East", "Esan South-East", "Esan West", "Ese Odo", "Esit Eket", "Essien Udim", "Etche", "Ethiope East", "Ethiope West", "Etim Ekpo", "Etinan", "Eti Osa", "Etsako Central", "Etsako East", "Etsako West", "Etung", "Ewekoro", "Ezeagu", "Ezinihitte", "Ezza North", "Ezza South", "Fagge", "Fakai", "Faskari", "Fika", "Fufure", "Funakaye", "Fune", "Funtua", "Gabasawa", "Gada", "Gagarawa", "Gamawa", "Ganjuwa", "Ganye", "Garki", "Garko", "Garun Mallam", "Gashaka", "Gassol", "Gaya", "Gayuk", "Gezawa", "Gbako", "Gboko", "Gbonyin", "Geidam", "Giade", "Giwa", "Gokana", "Gombe", "Gombi", "Goronyo", "Grie", "Gubio", "Gudu", "Gujba", "Gulani", "Guma", "Gumel", "Gummi", "Gurara", "Guri", "Gusau", "Guzamala", "Gwadabawa", "Gwagwalada", "Gwale", "Gwandu", "Gwaram", "Gwarzo", "Gwer East", "Gwer West", "Gwiwa", "Gwoza", "Hadejia", "Hawul", "Hong", "Ibadan North", "Ibadan North-East", "Ibadan North-West", "Ibadan South-East", "Ibadan South-West", "Ibaji", "Ibarapa Central", "Ibarapa East", "Ibarapa North", "Ibeju-Lekki", "Ibeno", "Ibesikpo Asutan", "Ibi", "Ibiono-Ibom", "Idah", "Idanre", "Ideato North", "Ideato South", "Idemili North", "Idemili South", "Ido", "Ido Osi", "Ifako-Ijaiye", "Ifedayo", "Ifedore", "Ifelodun", "Ifelodun", "Ifo", "Igabi", "Igalamela Odolu", "Igbo Etiti", "Igbo Eze North", "Igbo Eze South", "Igueben", "Ihiala", "Ihitte/Uboma", "Ilaje", "Ijebu East", "Ijebu North", "Ijebu North East", "Ijebu Ode", "Ijero", "Ijumu", "Ika", "Ika North East", "Ikara", "Ika South", "Ikeduru", "Ikeja", "Ikenne", "Ikere", "Ikole", "Ikom", "Ikono", "Ikorodu", "Ikot Abasi", "Ikot Ekpene", "Ikpoba Okha", "Ikwerre", "Ikwo", "Ikwuano", "Ila", "Ilejemeje", "Ile Oluji/Okeigbo", "Ilesa East", "Ilesa West", "Illela", "Ilorin East", "Ilorin South", "Ilorin West", "Imeko Afon", "Ingawa", "Ini", "Ipokia", "Irele", "Irepo", "Irepodun", "Irepodun", "Irepodun/Ifelodun", "Irewole", "Isa", "Ise/Orun", "Iseyin", "Ishielu", "Isiala Mbano", "Isiala Ngwa North", "Isiala Ngwa South", "Isin", "Isi Uzo", "Isokan", "Isoko North", "Isoko South", "Isu", "Isuikwuato", "Itas/Gadau", "Itesiwaju", "Itu", "Ivo", "Iwajowa", "Iwo", "Izzi", "Jaba", "Jada", "Jahun", "Jakusko", "Jalingo", "Jama'are", "Jega", "Jema'a", "Jere", "Jibia", "Jos East", "Jos North", "Jos South", "Kabba/Bunu", "Kabo", "Kachia", "Kaduna North", "Kaduna South", "Kafin Hausa", "Kafur", "Kaga", "Kagarko", "Kaiama", "Kaita", "Kajola", "Kajuru", "Kala/Balge", "Kalgo", "Kaltungo", "Kanam", "Kankara", "Kanke", "Kankia", "Kano Municipal", "Karasuwa", "Karaye", "Karim Lamido", "Karu", "Katagum", "Katcha", "Katsina", "Katsina-Ala", "Kaura", "Kaura Namoda", "Kauru", "Kazaure", "Keana", "Kebbe", "Keffi", "Khana", "Kibiya", "Kirfi", "Kiri Kasama", "Kiru", "Kiyawa", "Kogi", "Koko/Besse", "Kokona", "Kolokuma/Opokuma", "Konduga", "Konshisha", "Kontagora", "Kosofe", "Kaugama", "Kubau", "Kudan", "Kuje", "Kukawa", "Kumbotso", "Kumi", "Kunchi", "Kura", "Kurfi", "Kusada", "Kwali", "Kwande", "Kwami", "Kware", "Kwaya Kusar", "Lafia", "Lagelu", "Lagos Island", "Lagos Mainland", "Langtang South", "Langtang North", "Lapai", "Lamurde", "Lau", "Lavun", "Lere", "Logo", "Lokoja", "Machina", "Madagali", "Madobi", "Mafa", "Magama", "Magumeri", "Mai'Adua", "Maiduguri", "Maigatari", "Maiha", "Maiyama", "Makarfi", "Makoda", "Malam Madori", "Malumfashi", "Mangu", "Mani", "Maradun", "Mariga", "Makurdi", "Marte", "Maru", "Mashegu", "Mashi", "Matazu", "Mayo Belwa", "Mbaitoli", "Mbo", "Michika", "Miga", "Mikang", "Minjibir", "Misau", "Moba", "Mobbar", "Mubi North", "Mubi South", "Mokwa", "Monguno", "Mopa Muro", "Moro", "Moya", "Mkpat-Enin", "Municipal Area Council", "Musawa", "Mushin", "Nafada", "Nangere", "Nasarawa", "Nasarawa", "Nasarawa Egon", "Ndokwa East", "Ndokwa West", "Nembe", "Ngala", "Nganzai", "Ngaski", "Ngor Okpala", "Nguru", "Ningi", "Njaba", "Njikoka", "Nkanu East", "Nkanu West", "Nkwerre", "Nnewi North", "Nnewi South", "Nsit-Atai", "Nsit-Ibom", "Nsit-Ubium", "Nsukka", "Numan", "Nwangele", "Obafemi Owode", "Obanliku", "Obi", "Obi", "Obi Ngwa", "Obio/Akpor", "Obokun", "Obot Akara", "Obowo", "Obubra", "Obudu", "Odeda", "Odigbo", "Odogbolu", "Odo Otin", "Odukpani", "Offa", "Ofu", "Ogba/Egbema/Ndoni", "Ogbadibo", "Ogbaru", "Ogbia", "Ogbomosho North", "Ogbomosho South", "Ogu/Bolo", "Ogoja", "Ogo Oluwa", "Ogori/Magongo", "Ogun Waterside", "Oguta", "Ohafia", "Ohaji/Egbema", "Ohaozara", "Ohaukwu", "Ohimini", "Orhionmwon", "Oji River", "Ojo", "Oju", "Okehi", "Okene", "Oke Ero", "Okigwe", "Okitipupa", "Okobo", "Okpe", "Okrika", "Olamaboro", "Ola Oluwa", "Olorunda", "Olorunsogo", "Oluyole", "Omala", "Omuma", "Ona Ara", "Ondo East", "Ondo West", "Onicha", "Onitsha North", "Onitsha South", "Onna", "Okpokwu", "Opobo/Nkoro", "Oredo", "Orelope", "Oriade", "Ori Ire", "Orlu", "Orolu", "Oron", "Orsu", "Oru East", "Oruk Anam", "Orumba North", "Orumba South", "Oru West", "Ose", "Oshimili North", "Oshimili South", "Oshodi-Isolo", "Osisioma", "Osogbo", "Oturkpo", "Ovia North-East", "Ovia South-West", "Owan East", "Owan West", "Owerri Municipal", "Owerri North", "Owerri West", "Owo", "Oye", "Oyi", "Oyigbo", "Oyo West", "Oyo East", "Oyun", "Paikoro", "Pankshin", "Patani", "Pategi", "Port Harcourt", "Potiskum", "Qua'an Pan", "Rabah", "Rafi", "Rano", "Remo North", "Rijau", "Rimi", "Rimin Gado", "Ringim", "Riyom", "Rogo", "Roni", "Sabon Birni", "Sabon Gari", "Sabuwa", "Safana", "Sagbama", "Sakaba", "Saki East", "Saki West", "Sandamu", "Sanga", "Sapele", "Sardauna", "Shagamu", "Shagari", "Shanga", "Shani", "Shanono", "Shelleng", "Shendam", "Shinkafi", "Shira", "Shiroro", "Shongom", "Shomolu", "Silame", "Soba", "Sokoto North", "Sokoto South", "Song", "Southern Ijaw", "Suleja", "Sule Tankarkar", "Sumaila", "Suru", "Surulere", "Surulere", "Tafa", "Tafawa Balewa", "Tai", "Takai", "Takum", "Talata Mafara", "Tambuwal", "Tangaza", "Tarauni", "Tarka", "Tarmuwa", "Taura", "Toungo", "Tofa", "Toro", "Toto", "Chafe", "Tsanyawa", "Tudun Wada", "Tureta", "Udenu", "Udi", "Udu", "Udung-Uko", "Ughelli North", "Ughelli South", "Ugwunagbo", "Uhunmwonde", "Ukanafun", "Ukum", "Ukwa East", "Ukwa West", "Ukwuani", "Umuahia North", "Umuahia South", "Umu Nneochi", "Ungogo", "Unuimo", "Uruan", "Urue-Offong/Oruko", "Ushongo", "Ussa", "Uvwie", "Uyo", "Uzo-Uwani", "Vandeikya", "Wamako", "Wamba", "Warawa", "Warji", "Warri North", "Warri South", "Warri South West", "Wasagu/Danko", "Wase", "Wudil", "Wukari", "Wurno", "Wushishi", "Yabo", "Yagba East", "Yagba West", "Yakuur", "Obi", "Obi", "Obi Ngwa", "Obio/Akpor", "Obokun", "Obot Akara", "Obowo", "Obubra", "Yala", "Yamaltu/Deba", "Yankwashi", "Yauri", "Yenagoa", "Yola North", "Yola South", "Yorro", "Yunusari", "Yusufari", "Zaki", "Zango", "Zangon Kataf", "Zaria", "Zing", "Zurmi", "Zuru"})
        Me.cbolga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbolga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbolga.FormattingEnabled = True
        Me.cbolga.Items.AddRange(New Object() {"Abadam", "Abaji", "Abak", "Abakaliki", "Aba North", "Aba South", "Abeokuta North", "Abeokuta South", "Abi", "Aboh Mbaise", "Abua/Odual", "Adavi", "Ado Ekiti", "Ado-Odo/Ota", "Afijio", "Afikpo North", "Afikpo South (Edda)", "Agaie", "Agatu", "Agwara", "Agege", "Aguata", "Ahiazu Mbaise", "Ahoada East", "Ahoada West", "Ajaokuta", "Ajeromi-Ifelodun", "Ajingi", "Akamkpa", "Akinyele", "Akko", "Akoko-Edo", "Akoko North-East", "Akoko North-West", "Akoko South-West", "Akoko South-East", "Akpabuyo", "Akuku-Toru", "Akure North", "Akure South", "Akwanga", "Albasu", "Aleiro", "Alimosho", "Alkaleri", "Amuwo-Odofin", "Anambra East", "Anambra West", "Anaocha", "Andoni", "Aninri", "Aniocha North", "Aniocha South", "Anka", "Ankpa", "Apa", "Apapa", "Ado", "Ardo Kola", "Arewa Dandi", "Argungu", "Arochukwu", "Asa", "Asari-Toru", "Askira/Uba", "Atakunmosa East", "Atakunmosa West", "Atiba", "Atisbo", "Augie", "Auyo", "Awe", "Awgu", "Awka North", "Awka South", "Ayamelum", "Aiyedaade", "Aiyedire", "Babura", "Badagry", "Bagudo", "Bagwai", "Bakassi", "Bokkos", "Bakori", "Bakura", "Balanga", "Bali", "Bama", "Bade", "Barkin Ladi", "Baruten", "Bassa", "Bassa", "Batagarawa", "Batsari", "Bauchi", "Baure", "Bayo", "Bebeji", "Bekwarra", "Bende", "Biase", "Bichi", "Bida", "Billiri", "Bindawa", "Binji", "Biriniwa", "Birnin Gwari", "Birnin Kebbi", "Birnin Kudu", "Birnin Magaji/Kiyaw", "Biu", "Bodinga", "Bogoro", "Boki", "Boluwaduro", "Bomadi", "Bonny", "Borgu", "Boripe", "Bursari", "Bosso", "Brass", "Buji", "Bukkuyum", "Buruku", "Bungudu", "Bunkure", "Bunza", "Burutu", "Bwari", "Calabar Municipal", "Calabar South", "Chanchaga", "Charanchi", "Chibok", "Chikun", "Dala", "Damaturu", "Damban", "Dambatta", "Damboa", "Dandi", "Dandume", "Dange Shuni", "Danja", "Dan Musa", "Darazo", "Dass", "Daura", "Dawakin Kudu", "Dawakin Tofa", "Degema", "Dekina", "Demsa", "Dikwa", "Doguwa", "Doma", "Donga", "Dukku", "Dunukofia", "Dutse", "Dutsi", "Dutsin Ma", "Eastern Obolo", "Ebonyi", "Edati", "Ede North", "Ede South", "Edu", "Ife Central", "Ife East", "Ife North", "Ife South", "Efon", "Yewa North", "Yewa South", "Egbeda", "Egbedore", "Egor", "Ehime Mbano", "Ejigbo", "Ekeremor", "Eket", "Ekiti", "Ekiti East", "Ekiti South-West", "Ekiti West", "Ekwusigo", "Eleme", "Emuoha", "Emure", "Enugu East", "Enugu North", "Enugu South", "Epe", "Esan Central", "Esan North-East", "Esan South-East", "Esan West", "Ese Odo", "Esit Eket", "Essien Udim", "Etche", "Ethiope East", "Ethiope West", "Etim Ekpo", "Etinan", "Eti Osa", "Etsako Central", "Etsako East", "Etsako West", "Etung", "Ewekoro", "Ezeagu", "Ezinihitte", "Ezza North", "Ezza South", "Fagge", "Fakai", "Faskari", "Fika", "Fufure", "Funakaye", "Fune", "Funtua", "Gabasawa", "Gada", "Gagarawa", "Gamawa", "Ganjuwa", "Ganye", "Garki", "Garko", "Garun Mallam", "Gashaka", "Gassol", "Gaya", "Gayuk", "Gezawa", "Gbako", "Gboko", "Gbonyin", "Geidam", "Giade", "Giwa", "Gokana", "Gombe", "Gombi", "Goronyo", "Grie", "Gubio", "Gudu", "Gujba", "Gulani", "Guma", "Gumel", "Gummi", "Gurara", "Guri", "Gusau", "Guzamala", "Gwadabawa", "Gwagwalada", "Gwale", "Gwandu", "Gwaram", "Gwarzo", "Gwer East", "Gwer West", "Gwiwa", "Gwoza", "Hadejia", "Hawul", "Hong", "Ibadan North", "Ibadan North-East", "Ibadan North-West", "Ibadan South-East", "Ibadan South-West", "Ibaji", "Ibarapa Central", "Ibarapa East", "Ibarapa North", "Ibeju-Lekki", "Ibeno", "Ibesikpo Asutan", "Ibi", "Ibiono-Ibom", "Idah", "Idanre", "Ideato North", "Ideato South", "Idemili North", "Idemili South", "Ido", "Ido Osi", "Ifako-Ijaiye", "Ifedayo", "Ifedore", "Ifelodun", "Ifelodun", "Ifo", "Igabi", "Igalamela Odolu", "Igbo Etiti", "Igbo Eze North", "Igbo Eze South", "Igueben", "Ihiala", "Ihitte/Uboma", "Ilaje", "Ijebu East", "Ijebu North", "Ijebu North East", "Ijebu Ode", "Ijero", "Ijumu", "Ika", "Ika North East", "Ikara", "Ika South", "Ikeduru", "Ikeja", "Ikenne", "Ikere", "Ikole", "Ikom", "Ikono", "Ikorodu", "Ikot Abasi", "Ikot Ekpene", "Ikpoba Okha", "Ikwerre", "Ikwo", "Ikwuano", "Ila", "Ilejemeje", "Ile Oluji/Okeigbo", "Ilesa East", "Ilesa West", "Illela", "Ilorin East", "Ilorin South", "Ilorin West", "Imeko Afon", "Ingawa", "Ini", "Ipokia", "Irele", "Irepo", "Irepodun", "Irepodun", "Irepodun/Ifelodun", "Irewole", "Isa", "Ise/Orun", "Iseyin", "Ishielu", "Isiala Mbano", "Isiala Ngwa North", "Isiala Ngwa South", "Isin", "Isi Uzo", "Isokan", "Isoko North", "Isoko South", "Isu", "Isuikwuato", "Itas/Gadau", "Itesiwaju", "Itu", "Ivo", "Iwajowa", "Iwo", "Izzi", "Jaba", "Jada", "Jahun", "Jakusko", "Jalingo", "Jama'are", "Jega", "Jema'a", "Jere", "Jibia", "Jos East", "Jos North", "Jos South", "Kabba/Bunu", "Kabo", "Kachia", "Kaduna North", "Kaduna South", "Kafin Hausa", "Kafur", "Kaga", "Kagarko", "Kaiama", "Kaita", "Kajola", "Kajuru", "Kala/Balge", "Kalgo", "Kaltungo", "Kanam", "Kankara", "Kanke", "Kankia", "Kano Municipal", "Karasuwa", "Karaye", "Karim Lamido", "Karu", "Katagum", "Katcha", "Katsina", "Katsina-Ala", "Kaura", "Kaura Namoda", "Kauru", "Kazaure", "Keana", "Kebbe", "Keffi", "Khana", "Kibiya", "Kirfi", "Kiri Kasama", "Kiru", "Kiyawa", "Kogi", "Koko/Besse", "Kokona", "Kolokuma/Opokuma", "Konduga", "Konshisha", "Kontagora", "Kosofe", "Kaugama", "Kubau", "Kudan", "Kuje", "Kukawa", "Kumbotso", "Kumi", "Kunchi", "Kura", "Kurfi", "Kusada", "Kwali", "Kwande", "Kwami", "Kware", "Kwaya Kusar", "Lafia", "Lagelu", "Lagos Island", "Lagos Mainland", "Langtang South", "Langtang North", "Lapai", "Lamurde", "Lau", "Lavun", "Lere", "Logo", "Lokoja", "Machina", "Madagali", "Madobi", "Mafa", "Magama", "Magumeri", "Mai'Adua", "Maiduguri", "Maigatari", "Maiha", "Maiyama", "Makarfi", "Makoda", "Malam Madori", "Malumfashi", "Mangu", "Mani", "Maradun", "Mariga", "Makurdi", "Marte", "Maru", "Mashegu", "Mashi", "Matazu", "Mayo Belwa", "Mbaitoli", "Mbo", "Michika", "Miga", "Mikang", "Minjibir", "Misau", "Moba", "Mobbar", "Mubi North", "Mubi South", "Mokwa", "Monguno", "Mopa Muro", "Moro", "Moya", "Mkpat-Enin", "Municipal Area Council", "Musawa", "Mushin", "Nafada", "Nangere", "Nasarawa", "Nasarawa", "Nasarawa Egon", "Ndokwa East", "Ndokwa West", "Nembe", "Ngala", "Nganzai", "Ngaski", "Ngor Okpala", "Nguru", "Ningi", "Njaba", "Njikoka", "Nkanu East", "Nkanu West", "Nkwerre", "Nnewi North", "Nnewi South", "Nsit-Atai", "Nsit-Ibom", "Nsit-Ubium", "Nsukka", "Numan", "Nwangele", "Obafemi Owode", "Obanliku", "Obi", "Obi", "Obi Ngwa", "Obio/Akpor", "Obokun", "Obot Akara", "Obowo", "Obubra", "Obudu", "Odeda", "Odigbo", "Odogbolu", "Odo Otin", "Odukpani", "Offa", "Ofu", "Ogba/Egbema/Ndoni", "Ogbadibo", "Ogbaru", "Ogbia", "Ogbomosho North", "Ogbomosho South", "Ogu/Bolo", "Ogoja", "Ogo Oluwa", "Ogori/Magongo", "Ogun Waterside", "Oguta", "Ohafia", "Ohaji/Egbema", "Ohaozara", "Ohaukwu", "Ohimini", "Orhionmwon", "Oji River", "Ojo", "Oju", "Okehi", "Okene", "Oke Ero", "Okigwe", "Okitipupa", "Okobo", "Okpe", "Okrika", "Olamaboro", "Ola Oluwa", "Olorunda", "Olorunsogo", "Oluyole", "Omala", "Omuma", "Ona Ara", "Ondo East", "Ondo West", "Onicha", "Onitsha North", "Onitsha South", "Onna", "Okpokwu", "Opobo/Nkoro", "Oredo", "Orelope", "Oriade", "Ori Ire", "Orlu", "Orolu", "Oron", "Orsu", "Oru East", "Oruk Anam", "Orumba North", "Orumba South", "Oru West", "Ose", "Oshimili North", "Oshimili South", "Oshodi-Isolo", "Osisioma", "Osogbo", "Oturkpo", "Ovia North-East", "Ovia South-West", "Owan East", "Owan West", "Owerri Municipal", "Owerri North", "Owerri West", "Owo", "Oye", "Oyi", "Oyigbo", "Oyo West", "Oyo East", "Oyun", "Paikoro", "Pankshin", "Patani", "Pategi", "Port Harcourt", "Potiskum", "Qua'an Pan", "Rabah", "Rafi", "Rano", "Remo North", "Rijau", "Rimi", "Rimin Gado", "Ringim", "Riyom", "Rogo", "Roni", "Sabon Birni", "Sabon Gari", "Sabuwa", "Safana", "Sagbama", "Sakaba", "Saki East", "Saki West", "Sandamu", "Sanga", "Sapele", "Sardauna", "Shagamu", "Shagari", "Shanga", "Shani", "Shanono", "Shelleng", "Shendam", "Shinkafi", "Shira", "Shiroro", "Shongom", "Shomolu", "Silame", "Soba", "Sokoto North", "Sokoto South", "Song", "Southern Ijaw", "Suleja", "Sule Tankarkar", "Sumaila", "Suru", "Surulere", "Surulere", "Tafa", "Tafawa Balewa", "Tai", "Takai", "Takum", "Talata Mafara", "Tambuwal", "Tangaza", "Tarauni", "Tarka", "Tarmuwa", "Taura", "Toungo", "Tofa", "Toro", "Toto", "Chafe", "Tsanyawa", "Tudun Wada", "Tureta", "Udenu", "Udi", "Udu", "Udung-Uko", "Ughelli North", "Ughelli South", "Ugwunagbo", "Uhunmwonde", "Ukanafun", "Ukum", "Ukwa East", "Ukwa West", "Ukwuani", "Umuahia North", "Umuahia South", "Umu Nneochi", "Ungogo", "Unuimo", "Uruan", "Urue-Offong/Oruko", "Ushongo", "Ussa", "Uvwie", "Uyo", "Uzo-Uwani", "Vandeikya", "Wamako", "Wamba", "Warawa", "Warji", "Warri North", "Warri South", "Warri South West", "Wasagu/Danko", "Wase", "Wudil", "Wukari", "Wurno", "Wushishi", "Yabo", "Yagba East", "Yagba West", "Yakuur", "Obi", "Obi", "Obi Ngwa", "Obio/Akpor", "Obokun", "Obot Akara", "Obowo", "Obubra", "Yala", "Yamaltu/Deba", "Yankwashi", "Yauri", "Yenagoa", "Yola North", "Yola South", "Yorro", "Yunusari", "Yusufari", "Zaki", "Zango", "Zangon Kataf", "Zaria", "Zing", "Zurmi", "Zuru"})
        Me.cbolga.Location = New System.Drawing.Point(490, 132)
        Me.cbolga.Name = "cbolga"
        Me.cbolga.Size = New System.Drawing.Size(135, 24)
        Me.cbolga.TabIndex = 29
        '
        'cbooccup
        '
        Me.cbooccup.AutoCompleteCustomSource.AddRange(New String() {"Student", "Engineer", "Doctor", "Nurse", "Accountant", "Civil Servant", "Programmer", "Data Analyst"})
        Me.cbooccup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbooccup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbooccup.FormattingEnabled = True
        Me.cbooccup.Items.AddRange(New Object() {"Student", "Engineer", "Doctor", "Nurse", "Accountant", "Civil Servant", "Programmer", "Data Analyst"})
        Me.cbooccup.Location = New System.Drawing.Point(490, 103)
        Me.cbooccup.Name = "cbooccup"
        Me.cbooccup.Size = New System.Drawing.Size(135, 24)
        Me.cbooccup.TabIndex = 28
        '
        'cborelig
        '
        Me.cborelig.AutoCompleteCustomSource.AddRange(New String() {"Christianity", "Islam", "Catholic", "Judaism", "Hinduism", "Pegan"})
        Me.cborelig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cborelig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cborelig.FormattingEnabled = True
        Me.cborelig.Items.AddRange(New Object() {"Christianity", "Islam", "Catholic", "Judaism", "Hinduism", "Pegan"})
        Me.cborelig.Location = New System.Drawing.Point(490, 77)
        Me.cborelig.Name = "cborelig"
        Me.cborelig.Size = New System.Drawing.Size(135, 24)
        Me.cborelig.TabIndex = 27
        '
        'cbonat
        '
        Me.cbonat.AutoCompleteCustomSource.AddRange(New String() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cabo Verde", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Curacao", "Cyprus", "Czechia", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (see Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "Norway", "Oman", "Pakistan", "Palau", "Palestinian Territories", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Sint Maarten", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United State of America", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.cbonat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbonat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbonat.FormattingEnabled = True
        Me.cbonat.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burma", "Burundi", "Cambodia", "Cameroon", "Canada", "Cabo Verde", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Curacao", "Cyprus", "Czechia", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor (see Timor-Leste)", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Holy See", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "Norway", "Oman", "Pakistan", "Palau", "Palestinian Territories", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Sint Maarten", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United State of America", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"})
        Me.cbonat.Location = New System.Drawing.Point(490, 216)
        Me.cbonat.Name = "cbonat"
        Me.cbonat.Size = New System.Drawing.Size(135, 24)
        Me.cbonat.TabIndex = 21
        '
        'cbomarital
        '
        Me.cbomarital.AutoCompleteCustomSource.AddRange(New String() {"Single", "Married", "Divorced"})
        Me.cbomarital.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbomarital.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbomarital.FormattingEnabled = True
        Me.cbomarital.Items.AddRange(New Object() {"Single", "Married", "Divorced"})
        Me.cbomarital.Location = New System.Drawing.Point(490, 53)
        Me.cbomarital.Name = "cbomarital"
        Me.cbomarital.Size = New System.Drawing.Size(135, 24)
        Me.cbomarital.TabIndex = 21
        '
        'cbosex
        '
        Me.cbosex.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.cbosex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbosex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbosex.FormattingEnabled = True
        Me.cbosex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbosex.Location = New System.Drawing.Point(490, 27)
        Me.cbosex.Name = "cbosex"
        Me.cbosex.Size = New System.Drawing.Size(135, 24)
        Me.cbosex.TabIndex = 22
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemail.Location = New System.Drawing.Point(99, 189)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(232, 22)
        Me.txtemail.TabIndex = 26
        '
        'txtphone
        '
        Me.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtphone.Location = New System.Drawing.Point(100, 164)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(178, 22)
        Me.txtphone.TabIndex = 25
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(411, 110)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 15)
        Me.Label28.TabIndex = 24
        Me.Label28.Text = "Occupation:"
        '
        'dbo
        '
        Me.dbo.CustomFormat = ""
        Me.dbo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dbo.Location = New System.Drawing.Point(100, 79)
        Me.dbo.Name = "dbo"
        Me.dbo.Size = New System.Drawing.Size(99, 21)
        Me.dbo.TabIndex = 7
        '
        'txtothernames
        '
        Me.txtothernames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtothernames.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtothernames.Location = New System.Drawing.Point(100, 51)
        Me.txtothernames.Name = "txtothernames"
        Me.txtothernames.Size = New System.Drawing.Size(271, 22)
        Me.txtothernames.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(426, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Religion:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(396, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 15)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Marital status:"
        '
        'txtsurname
        '
        Me.txtsurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsurname.Location = New System.Drawing.Point(100, 27)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(231, 22)
        Me.txtsurname.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(413, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 15)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Nationality:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(396, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 15)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "State of origin:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(424, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 15)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "L.G.A:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(453, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Sex:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 30)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Current " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date of birth:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Other names:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Surname:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 432)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Txtprovi)
        Me.GroupBox4.Controls.Add(Me.txtemployer)
        Me.GroupBox4.Controls.Add(Me.txtenrolnum)
        Me.GroupBox4.Controls.Add(Me.cboenrol)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.cboacct)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(321, 263)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(322, 163)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ACCOUNT DETAILS :"
        '
        'Txtprovi
        '
        Me.Txtprovi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txtprovi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txtprovi.ForeColor = System.Drawing.Color.Black
        Me.Txtprovi.FormattingEnabled = True
        Me.Txtprovi.Items.AddRange(New Object() {"NORMAL", "CLASSIC", "VIP", "ELITE"})
        Me.Txtprovi.Location = New System.Drawing.Point(123, 54)
        Me.Txtprovi.Name = "Txtprovi"
        Me.Txtprovi.Size = New System.Drawing.Size(196, 23)
        Me.Txtprovi.TabIndex = 35
        '
        'txtemployer
        '
        Me.txtemployer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemployer.Enabled = False
        Me.txtemployer.ForeColor = System.Drawing.Color.Black
        Me.txtemployer.Location = New System.Drawing.Point(123, 107)
        Me.txtemployer.Name = "txtemployer"
        Me.txtemployer.Size = New System.Drawing.Size(197, 22)
        Me.txtemployer.TabIndex = 33
        '
        'txtenrolnum
        '
        Me.txtenrolnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtenrolnum.Enabled = False
        Me.txtenrolnum.ForeColor = System.Drawing.Color.Black
        Me.txtenrolnum.Location = New System.Drawing.Point(123, 133)
        Me.txtenrolnum.Name = "txtenrolnum"
        Me.txtenrolnum.Size = New System.Drawing.Size(197, 22)
        Me.txtenrolnum.TabIndex = 34
        '
        'cboenrol
        '
        Me.cboenrol.AutoCompleteCustomSource.AddRange(New String() {"Principal", "Spouse", "Child"})
        Me.cboenrol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboenrol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboenrol.Enabled = False
        Me.cboenrol.ForeColor = System.Drawing.Color.Black
        Me.cboenrol.FormattingEnabled = True
        Me.cboenrol.Items.AddRange(New Object() {"Principal", "Spouse", "Child"})
        Me.cboenrol.Location = New System.Drawing.Point(123, 80)
        Me.cboenrol.Name = "cboenrol"
        Me.cboenrol.Size = New System.Drawing.Size(196, 23)
        Me.cboenrol.TabIndex = 23
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(22, 137)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(98, 15)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "Enrolle Number:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(40, 84)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 15)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Enrolle Type:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(61, 57)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(57, 15)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Caegory:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(57, 110)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 15)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Employer:"
        '
        'cboacct
        '
        Me.cboacct.AutoCompleteCustomSource.AddRange(New String() {"Private", "NHIS ", "Retainership"})
        Me.cboacct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboacct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboacct.ForeColor = System.Drawing.Color.Black
        Me.cboacct.FormattingEnabled = True
        Me.cboacct.Location = New System.Drawing.Point(123, 27)
        Me.cboacct.Name = "cboacct"
        Me.cboacct.Size = New System.Drawing.Size(196, 23)
        Me.cboacct.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Account/ Provider:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtkinphone)
        Me.GroupBox2.Controls.Add(Me.cborelat)
        Me.GroupBox2.Controls.Add(Me.txtkinname)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtkinadd)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 167)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  NEXT OF KIN DETAILS"
        '
        'txtkinphone
        '
        Me.txtkinphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkinphone.ForeColor = System.Drawing.Color.Black
        Me.txtkinphone.Location = New System.Drawing.Point(92, 103)
        Me.txtkinphone.Name = "txtkinphone"
        Me.txtkinphone.Size = New System.Drawing.Size(167, 22)
        Me.txtkinphone.TabIndex = 32
        '
        'cborelat
        '
        Me.cborelat.AutoCompleteCustomSource.AddRange(New String() {"Father", "Mother", "Husband", "WIfe", "Son", "Daughter", "Brother", "Sister", "Cousin", "Nephew", "Friend"})
        Me.cborelat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cborelat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cborelat.ForeColor = System.Drawing.Color.Black
        Me.cborelat.FormattingEnabled = True
        Me.cborelat.Items.AddRange(New Object() {"Father", "Mother", "Husband", "WIfe", "Son", "Daughter", "Brother", "Sister", "Cousin", "Nephew", "Friend"})
        Me.cborelat.Location = New System.Drawing.Point(92, 132)
        Me.cborelat.Name = "cborelat"
        Me.cborelat.Size = New System.Drawing.Size(167, 23)
        Me.cborelat.TabIndex = 21
        '
        'txtkinname
        '
        Me.txtkinname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkinname.ForeColor = System.Drawing.Color.Black
        Me.txtkinname.Location = New System.Drawing.Point(92, 22)
        Me.txtkinname.Name = "txtkinname"
        Me.txtkinname.Size = New System.Drawing.Size(220, 22)
        Me.txtkinname.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(10, 134)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 15)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Relationship:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(19, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Full Name:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(41, 108)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 15)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Phone:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(30, 49)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 15)
        Me.Label23.TabIndex = 17
        Me.Label23.Text = "Address:"
        '
        'txtkinadd
        '
        Me.txtkinadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkinadd.ForeColor = System.Drawing.Color.Black
        Me.txtkinadd.Location = New System.Drawing.Point(92, 46)
        Me.txtkinadd.Multiline = True
        Me.txtkinadd.Name = "txtkinadd"
        Me.txtkinadd.Size = New System.Drawing.Size(221, 54)
        Me.txtkinadd.TabIndex = 22
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.White
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Green
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.Location = New System.Drawing.Point(263, 29)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(89, 25)
        Me.btnsave.TabIndex = 33
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncls
        '
        Me.btncls.BackColor = System.Drawing.Color.White
        Me.btncls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncls.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncls.ForeColor = System.Drawing.Color.DarkRed
        Me.btncls.Image = CType(resources.GetObject("btncls.Image"), System.Drawing.Image)
        Me.btncls.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncls.Location = New System.Drawing.Point(353, 29)
        Me.btncls.Name = "btncls"
        Me.btncls.Size = New System.Drawing.Size(88, 25)
        Me.btncls.TabIndex = 34
        Me.btncls.Text = "      CANCEL"
        Me.btncls.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(2, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 15)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Receipt number:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(33, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 15)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Password:"
        '
        'txtrecptnum
        '
        Me.txtrecptnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrecptnum.Location = New System.Drawing.Point(103, 35)
        Me.txtrecptnum.Name = "txtrecptnum"
        Me.txtrecptnum.Size = New System.Drawing.Size(111, 20)
        Me.txtrecptnum.TabIndex = 32
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Location = New System.Drawing.Point(102, 9)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.txtpass.Size = New System.Drawing.Size(112, 20)
        Me.txtpass.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Lbluser)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.txtrecptnum)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.txtpass)
        Me.Panel3.Controls.Add(Me.btncls)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.Btnupdate)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(337, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(511, 62)
        Me.Panel3.TabIndex = 35
        '
        'Lbluser
        '
        Me.Lbluser.AutoSize = True
        Me.Lbluser.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser.Location = New System.Drawing.Point(260, 8)
        Me.Lbluser.Name = "Lbluser"
        Me.Lbluser.Size = New System.Drawing.Size(10, 15)
        Me.Lbluser.TabIndex = 44
        Me.Lbluser.Text = " "
        Me.Lbluser.Visible = False
        '
        'Btnupdate
        '
        Me.Btnupdate.BackColor = System.Drawing.Color.White
        Me.Btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnupdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnupdate.ForeColor = System.Drawing.Color.Green
        Me.Btnupdate.Image = CType(resources.GetObject("Btnupdate.Image"), System.Drawing.Image)
        Me.Btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnupdate.Location = New System.Drawing.Point(263, 29)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(87, 25)
        Me.Btnupdate.TabIndex = 35
        Me.Btnupdate.Text = "UPDATE"
        Me.Btnupdate.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.txtcaution)
        Me.Panel4.Controls.Add(Me.btncaution)
        Me.Panel4.Location = New System.Drawing.Point(653, 74)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(193, 256)
        Me.Panel4.TabIndex = 36
        '
        'txtcaution
        '
        Me.txtcaution.BackColor = System.Drawing.Color.White
        Me.txtcaution.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcaution.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcaution.ForeColor = System.Drawing.Color.Red
        Me.txtcaution.Location = New System.Drawing.Point(3, 3)
        Me.txtcaution.Multiline = True
        Me.txtcaution.Name = "txtcaution"
        Me.txtcaution.ReadOnly = True
        Me.txtcaution.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtcaution.Size = New System.Drawing.Size(184, 209)
        Me.txtcaution.TabIndex = 4
        '
        'btncaution
        '
        Me.btncaution.BackColor = System.Drawing.Color.Red
        Me.btncaution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncaution.ForeColor = System.Drawing.Color.White
        Me.btncaution.Location = New System.Drawing.Point(10, 218)
        Me.btncaution.Name = "btncaution"
        Me.btncaution.Size = New System.Drawing.Size(177, 34)
        Me.btncaution.TabIndex = 3
        Me.btncaution.Text = "Special Caution/ Allegies"
        Me.btncaution.UseVisualStyleBackColor = False
        '
        'Btnupload
        '
        Me.Btnupload.BackColor = System.Drawing.Color.White
        Me.Btnupload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnupload.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnupload.ForeColor = System.Drawing.Color.Green
        Me.Btnupload.Location = New System.Drawing.Point(674, 338)
        Me.Btnupload.Name = "Btnupload"
        Me.Btnupload.Size = New System.Drawing.Size(155, 27)
        Me.Btnupload.TabIndex = 5
        Me.Btnupload.Text = "UPLOAD DOCUMENTS"
        Me.Btnupload.UseVisualStyleBackColor = False
        '
        'FrmPtreg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(852, 509)
        Me.Controls.Add(Me.Btnupload)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPtreg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " PATIENT PROFILE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txthospnum As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dbo As DateTimePicker
    Friend WithEvents txtkinadd As TextBox
    Friend WithEvents txtothernames As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cboacct As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtadd As TextBox
    Friend WithEvents cbostate As ComboBox
    Friend WithEvents cbolga As ComboBox
    Friend WithEvents cbooccup As ComboBox
    Friend WithEvents cborelig As ComboBox
    Friend WithEvents cbonat As ComboBox
    Friend WithEvents cbomarital As ComboBox
    Friend WithEvents cbosex As ComboBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtkinphone As TextBox
    Friend WithEvents cborelat As ComboBox
    Friend WithEvents txtkinname As TextBox
    Friend WithEvents txtemployer As TextBox
    Friend WithEvents txtenrolnum As TextBox
    Friend WithEvents cboenrol As ComboBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btncls As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtrecptnum As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtstate As TextBox
    Friend WithEvents txtnin As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btncaution As Button
    Friend WithEvents Btnupdate As Button
    Friend WithEvents txtcaution As TextBox
    Friend WithEvents txtyear As TextBox
    Friend WithEvents txtmonths As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents regdate As DateTimePicker
    Friend WithEvents Label30 As Label
    Friend WithEvents Txtdays As TextBox
    Friend WithEvents Txtprovi As ComboBox
    Friend WithEvents Lbluser As Label
    Friend WithEvents Btnupload As Button
End Class
