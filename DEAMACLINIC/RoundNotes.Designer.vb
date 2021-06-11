<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoundNotes
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Txtnote = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dtgreport = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dtgreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Txtpass)
        Me.Panel1.Controls.Add(Me.Btnclear)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.Txtnote)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 294)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(697, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(826, 5)
        Me.Panel3.TabIndex = 4
        '
        'Txtpass
        '
        Me.Txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpass.Location = New System.Drawing.Point(667, 230)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(63)
        Me.Txtpass.Size = New System.Drawing.Size(156, 20)
        Me.Txtpass.TabIndex = 3
        '
        'Btnclear
        '
        Me.Btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclear.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnclear.Location = New System.Drawing.Point(741, 256)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(72, 23)
        Me.Btnclear.TabIndex = 2
        Me.Btnclear.Text = "CLEAR"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btnsave.Location = New System.Drawing.Point(670, 256)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(68, 23)
        Me.Btnsave.TabIndex = 1
        Me.Btnsave.Text = "SAVE"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Txtnote
        '
        Me.Txtnote.BackColor = System.Drawing.Color.White
        Me.Txtnote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtnote.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnote.Location = New System.Drawing.Point(4, 11)
        Me.Txtnote.Multiline = True
        Me.Txtnote.Name = "Txtnote"
        Me.Txtnote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Txtnote.Size = New System.Drawing.Size(657, 278)
        Me.Txtnote.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Dtgreport)
        Me.Panel2.Location = New System.Drawing.Point(13, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 153)
        Me.Panel2.TabIndex = 3
        '
        'Dtgreport
        '
        Me.Dtgreport.AllowUserToAddRows = False
        Me.Dtgreport.AllowUserToDeleteRows = False
        Me.Dtgreport.AllowUserToResizeColumns = False
        Me.Dtgreport.AllowUserToResizeRows = False
        Me.Dtgreport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dtgreport.BackgroundColor = System.Drawing.Color.White
        Me.Dtgreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgreport.Location = New System.Drawing.Point(3, 3)
        Me.Dtgreport.Name = "Dtgreport"
        Me.Dtgreport.ReadOnly = True
        Me.Dtgreport.Size = New System.Drawing.Size(799, 147)
        Me.Dtgreport.TabIndex = 0
        '
        'RoundNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "RoundNotes"
        Me.Size = New System.Drawing.Size(828, 451)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dtgreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txtpass As TextBox
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btnsave As Button
    Friend WithEvents Txtnote As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dtgreport As DataGridView
End Class
