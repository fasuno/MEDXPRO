<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceSetings
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
        Me.Btnaddserv = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgservice = New System.Windows.Forms.DataGridView()
        Me.txtserv = New System.Windows.Forms.TextBox()
        CType(Me.dtgservice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnaddserv
        '
        Me.Btnaddserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnaddserv.Location = New System.Drawing.Point(249, 61)
        Me.Btnaddserv.Name = "Btnaddserv"
        Me.Btnaddserv.Size = New System.Drawing.Size(107, 23)
        Me.Btnaddserv.TabIndex = 0
        Me.Btnaddserv.Text = "ADD SERVICE"
        Me.Btnaddserv.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Service"
        '
        'dtgservice
        '
        Me.dtgservice.BackgroundColor = System.Drawing.Color.White
        Me.dtgservice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgservice.Location = New System.Drawing.Point(13, 107)
        Me.dtgservice.Name = "dtgservice"
        Me.dtgservice.Size = New System.Drawing.Size(370, 107)
        Me.dtgservice.TabIndex = 3
        '
        'txtserv
        '
        Me.txtserv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtserv.Location = New System.Drawing.Point(90, 35)
        Me.txtserv.Name = "txtserv"
        Me.txtserv.Size = New System.Drawing.Size(266, 20)
        Me.txtserv.TabIndex = 4
        '
        'ServiceSetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtserv)
        Me.Controls.Add(Me.dtgservice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnaddserv)
        Me.Name = "ServiceSetings"
        Me.Size = New System.Drawing.Size(396, 239)
        CType(Me.dtgservice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnaddserv As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgservice As DataGridView
    Friend WithEvents txtserv As TextBox
End Class
