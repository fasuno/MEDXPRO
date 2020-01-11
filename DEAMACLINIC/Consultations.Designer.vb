<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultations
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultations))
        Me.tabConsult = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnnewconsult = New System.Windows.Forms.Button()
        Me.Dtggenconsult = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnneweyeconsult = New System.Windows.Forms.Button()
        Me.Dtgeyeclinic = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnnewgyanecoculst = New System.Windows.Forms.Button()
        Me.Dtggynae = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnnewdentalconsult = New System.Windows.Forms.Button()
        Me.Dtgdental = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.tabConsult.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtggenconsult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtgeyeclinic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtggynae, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtgdental, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabConsult
        '
        Me.tabConsult.Controls.Add(Me.TabPage1)
        Me.tabConsult.Controls.Add(Me.TabPage2)
        Me.tabConsult.Controls.Add(Me.TabPage3)
        Me.tabConsult.Controls.Add(Me.TabPage4)
        Me.tabConsult.Controls.Add(Me.TabPage5)
        Me.tabConsult.Controls.Add(Me.TabPage6)
        Me.tabConsult.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabConsult.Location = New System.Drawing.Point(3, 8)
        Me.tabConsult.Name = "tabConsult"
        Me.tabConsult.SelectedIndex = 0
        Me.tabConsult.Size = New System.Drawing.Size(801, 425)
        Me.tabConsult.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Dtggenconsult)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(793, 397)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnnewconsult)
        Me.Panel1.Location = New System.Drawing.Point(7, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 40)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CONSULTATION HISTORY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(843, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 54)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnnewconsult
        '
        Me.btnnewconsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewconsult.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewconsult.ForeColor = System.Drawing.Color.Green
        Me.btnnewconsult.Location = New System.Drawing.Point(667, 6)
        Me.btnnewconsult.Name = "btnnewconsult"
        Me.btnnewconsult.Size = New System.Drawing.Size(113, 31)
        Me.btnnewconsult.TabIndex = 0
        Me.btnnewconsult.Text = "New Consult"
        Me.btnnewconsult.UseVisualStyleBackColor = True
        '
        'Dtggenconsult
        '
        Me.Dtggenconsult.AllowUserToAddRows = False
        Me.Dtggenconsult.AllowUserToDeleteRows = False
        Me.Dtggenconsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtggenconsult.Location = New System.Drawing.Point(3, 51)
        Me.Dtggenconsult.Name = "Dtggenconsult"
        Me.Dtggenconsult.Size = New System.Drawing.Size(790, 340)
        Me.Dtggenconsult.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Dtgeyeclinic)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(793, 397)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = " Eye Clinic"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.btnneweyeconsult)
        Me.Panel2.Location = New System.Drawing.Point(6, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 38)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(838, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 59)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnneweyeconsult
        '
        Me.btnneweyeconsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnneweyeconsult.Font = New System.Drawing.Font("TITUS Cyberbit Basic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnneweyeconsult.ForeColor = System.Drawing.Color.Green
        Me.btnneweyeconsult.Location = New System.Drawing.Point(698, 4)
        Me.btnneweyeconsult.Name = "btnneweyeconsult"
        Me.btnneweyeconsult.Size = New System.Drawing.Size(83, 31)
        Me.btnneweyeconsult.TabIndex = 0
        Me.btnneweyeconsult.Text = "New"
        Me.btnneweyeconsult.UseVisualStyleBackColor = True
        '
        'Dtgeyeclinic
        '
        Me.Dtgeyeclinic.AllowUserToAddRows = False
        Me.Dtgeyeclinic.AllowUserToDeleteRows = False
        Me.Dtgeyeclinic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgeyeclinic.Location = New System.Drawing.Point(3, 49)
        Me.Dtgeyeclinic.Name = "Dtgeyeclinic"
        Me.Dtgeyeclinic.Size = New System.Drawing.Size(790, 342)
        Me.Dtgeyeclinic.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.Dtggynae)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.ForeColor = System.Drawing.Color.Black
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(793, 397)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gynae"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.btnnewgyanecoculst)
        Me.Panel3.Location = New System.Drawing.Point(7, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(783, 38)
        Me.Panel3.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(835, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(72, 64)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'btnnewgyanecoculst
        '
        Me.btnnewgyanecoculst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewgyanecoculst.Font = New System.Drawing.Font("TITUS Cyberbit Basic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewgyanecoculst.ForeColor = System.Drawing.Color.Green
        Me.btnnewgyanecoculst.Location = New System.Drawing.Point(693, 3)
        Me.btnnewgyanecoculst.Name = "btnnewgyanecoculst"
        Me.btnnewgyanecoculst.Size = New System.Drawing.Size(87, 31)
        Me.btnnewgyanecoculst.TabIndex = 0
        Me.btnnewgyanecoculst.Text = "New"
        Me.btnnewgyanecoculst.UseVisualStyleBackColor = True
        '
        'Dtggynae
        '
        Me.Dtggynae.AllowUserToAddRows = False
        Me.Dtggynae.AllowUserToDeleteRows = False
        Me.Dtggynae.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtggynae.Location = New System.Drawing.Point(5, 49)
        Me.Dtggynae.Name = "Dtggynae"
        Me.Dtggynae.Size = New System.Drawing.Size(788, 342)
        Me.Dtggynae.TabIndex = 4
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Controls.Add(Me.Dtgdental)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.ForeColor = System.Drawing.Color.Black
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(793, 397)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Dental"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.btnnewdentalconsult)
        Me.Panel4.Location = New System.Drawing.Point(7, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(783, 37)
        Me.Panel4.TabIndex = 5
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(836, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(71, 53)
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'btnnewdentalconsult
        '
        Me.btnnewdentalconsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnewdentalconsult.Font = New System.Drawing.Font("TITUS Cyberbit Basic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnewdentalconsult.ForeColor = System.Drawing.Color.Green
        Me.btnnewdentalconsult.Location = New System.Drawing.Point(694, 3)
        Me.btnnewdentalconsult.Name = "btnnewdentalconsult"
        Me.btnnewdentalconsult.Size = New System.Drawing.Size(86, 29)
        Me.btnnewdentalconsult.TabIndex = 0
        Me.btnnewdentalconsult.Text = "New"
        Me.btnnewdentalconsult.UseVisualStyleBackColor = True
        '
        'Dtgdental
        '
        Me.Dtgdental.AllowUserToAddRows = False
        Me.Dtgdental.AllowUserToDeleteRows = False
        Me.Dtgdental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgdental.Location = New System.Drawing.Point(5, 48)
        Me.Dtgdental.Name = "Dtgdental"
        Me.Dtgdental.Size = New System.Drawing.Size(785, 343)
        Me.Dtgdental.TabIndex = 4
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Panel5)
        Me.TabPage5.Controls.Add(Me.DataGridView5)
        Me.TabPage5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage5.ForeColor = System.Drawing.Color.Black
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(793, 397)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "ART"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Location = New System.Drawing.Point(7, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(783, 35)
        Me.Panel5.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("TITUS Cyberbit Basic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Green
        Me.Button5.Location = New System.Drawing.Point(700, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 29)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "New"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(7, 43)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(786, 345)
        Me.DataGridView5.TabIndex = 4
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(793, 397)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "ANC"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Consultations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.tabConsult)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Consultations"
        Me.Size = New System.Drawing.Size(807, 441)
        Me.tabConsult.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtggenconsult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtgeyeclinic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtggynae, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtgdental, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabConsult As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnnewconsult As Button
    Friend WithEvents Dtggenconsult As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnneweyeconsult As Button
    Friend WithEvents Dtgeyeclinic As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnnewgyanecoculst As Button
    Friend WithEvents Dtggynae As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnnewdentalconsult As Button
    Friend WithEvents Dtgdental As DataGridView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents TabPage6 As TabPage
End Class
