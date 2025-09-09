<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttk = New System.Windows.Forms.TextBox()
        Me.txtmk = New System.Windows.Forms.TextBox()
        Me.btdangnhap = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài khoản:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật khẩu:"
        '
        'txttk
        '
        Me.txttk.Location = New System.Drawing.Point(108, 63)
        Me.txttk.Name = "txttk"
        Me.txttk.Size = New System.Drawing.Size(100, 20)
        Me.txttk.TabIndex = 2
        '
        'txtmk
        '
        Me.txtmk.Location = New System.Drawing.Point(108, 94)
        Me.txtmk.Name = "txtmk"
        Me.txtmk.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmk.Size = New System.Drawing.Size(100, 20)
        Me.txtmk.TabIndex = 3
        '
        'btdangnhap
        '
        Me.btdangnhap.Location = New System.Drawing.Point(93, 133)
        Me.btdangnhap.Name = "btdangnhap"
        Me.btdangnhap.Size = New System.Drawing.Size(75, 23)
        Me.btdangnhap.TabIndex = 4
        Me.btdangnhap.Text = "Đăng nhập"
        Me.btdangnhap.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Đăng nhập"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(262, 185)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btdangnhap)
        Me.Controls.Add(Me.txtmk)
        Me.Controls.Add(Me.txttk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLogin"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txttk As TextBox
    Friend WithEvents txtmk As TextBox
    Friend WithEvents btdangnhap As Button
    Friend WithEvents Label3 As Label
End Class
