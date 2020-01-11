<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnserv = New System.Windows.Forms.Button()
        Me.BtnAccount = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ServiceSetings1 = New DEAMACLINIC.ServiceSetings()
        Me.AccountSet1 = New DEAMACLINIC.AccountSet()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnserv)
        Me.Panel1.Controls.Add(Me.BtnAccount)
        Me.Panel1.Location = New System.Drawing.Point(3, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(119, 277)
        Me.Panel1.TabIndex = 0
        '
        'btnserv
        '
        Me.btnserv.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnserv.Location = New System.Drawing.Point(7, 73)
        Me.btnserv.Name = "btnserv"
        Me.btnserv.Size = New System.Drawing.Size(107, 24)
        Me.btnserv.TabIndex = 1
        Me.btnserv.Text = "Services"
        Me.btnserv.UseVisualStyleBackColor = True
        '
        'BtnAccount
        '
        Me.BtnAccount.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccount.Location = New System.Drawing.Point(7, 43)
        Me.BtnAccount.Name = "BtnAccount"
        Me.BtnAccount.Size = New System.Drawing.Size(107, 24)
        Me.BtnAccount.TabIndex = 0
        Me.BtnAccount.Text = "Account Type"
        Me.BtnAccount.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ServiceSetings1)
        Me.Panel2.Controls.Add(Me.AccountSet1)
        Me.Panel2.Location = New System.Drawing.Point(128, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(486, 277)
        Me.Panel2.TabIndex = 1
        '
        'ServiceSetings1
        '
        Me.ServiceSetings1.Location = New System.Drawing.Point(3, 12)
        Me.ServiceSetings1.Name = "ServiceSetings1"
        Me.ServiceSetings1.Size = New System.Drawing.Size(479, 261)
        Me.ServiceSetings1.TabIndex = 1
        '
        'AccountSet1
        '
        Me.AccountSet1.BackColor = System.Drawing.Color.Transparent
        Me.AccountSet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccountSet1.Location = New System.Drawing.Point(3, 10)
        Me.AccountSet1.Name = "AccountSet1"
        Me.AccountSet1.Size = New System.Drawing.Size(479, 266)
        Me.AccountSet1.TabIndex = 0
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 290)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SETTINGS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAccount As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AccountSet1 As AccountSet
    Friend WithEvents btnserv As Button
    Friend WithEvents ServiceSetings1 As ServiceSetings
End Class
