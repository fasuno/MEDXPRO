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
        Me.BtnNewcons = New System.Windows.Forms.Button()
        Me.Dtggenconsult = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnNewanc = New System.Windows.Forms.Button()
        Me.Dgvanc = New System.Windows.Forms.DataGridView()
        Me.btnnewconsult = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabConsult.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Dtggenconsult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dgvanc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabConsult
        '
        Me.tabConsult.Controls.Add(Me.TabPage1)
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
        Me.TabPage1.Text = "GENERAL"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnNewcons)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 39)
        Me.Panel1.TabIndex = 1
        '
        'BtnNewcons
        '
        Me.BtnNewcons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewcons.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewcons.ForeColor = System.Drawing.Color.Green
        Me.BtnNewcons.Image = CType(resources.GetObject("BtnNewcons.Image"), System.Drawing.Image)
        Me.BtnNewcons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewcons.Location = New System.Drawing.Point(714, 5)
        Me.BtnNewcons.Name = "BtnNewcons"
        Me.BtnNewcons.Size = New System.Drawing.Size(69, 31)
        Me.BtnNewcons.TabIndex = 0
        Me.BtnNewcons.Text = "    New"
        Me.BtnNewcons.UseVisualStyleBackColor = True
        '
        'Dtggenconsult
        '
        Me.Dtggenconsult.AllowUserToAddRows = False
        Me.Dtggenconsult.AllowUserToDeleteRows = False
        Me.Dtggenconsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtggenconsult.Location = New System.Drawing.Point(2, 46)
        Me.Dtggenconsult.Name = "Dtggenconsult"
        Me.Dtggenconsult.Size = New System.Drawing.Size(790, 347)
        Me.Dtggenconsult.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Panel2)
        Me.TabPage6.Controls.Add(Me.Dgvanc)
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(793, 397)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "ANC VISIT"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.BtnNewanc)
        Me.Panel2.Location = New System.Drawing.Point(4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(786, 39)
        Me.Panel2.TabIndex = 2
        '
        'BtnNewanc
        '
        Me.BtnNewanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewanc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewanc.ForeColor = System.Drawing.Color.Green
        Me.BtnNewanc.Image = CType(resources.GetObject("BtnNewanc.Image"), System.Drawing.Image)
        Me.BtnNewanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewanc.Location = New System.Drawing.Point(676, 3)
        Me.BtnNewanc.Name = "BtnNewanc"
        Me.BtnNewanc.Size = New System.Drawing.Size(107, 33)
        Me.BtnNewanc.TabIndex = 0
        Me.BtnNewanc.Text = "      Follow-up"
        Me.BtnNewanc.UseVisualStyleBackColor = True
        '
        'Dgvanc
        '
        Me.Dgvanc.AllowUserToAddRows = False
        Me.Dgvanc.AllowUserToDeleteRows = False
        Me.Dgvanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvanc.Location = New System.Drawing.Point(5, 48)
        Me.Dgvanc.Name = "Dgvanc"
        Me.Dgvanc.Size = New System.Drawing.Size(784, 346)
        Me.Dgvanc.TabIndex = 0
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(843, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 54)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 22)
        Me.Label2.TabIndex = 3
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
        CType(Me.Dtggenconsult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dgvanc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabConsult As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dtggenconsult As DataGridView
    Friend WithEvents btnnewconsult As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnNewcons As Button
    Friend WithEvents Dgvanc As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnNewanc As Button
End Class
