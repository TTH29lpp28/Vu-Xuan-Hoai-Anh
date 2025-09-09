<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQLSV
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
        Me.dgvSinhvien = New System.Windows.Forms.DataGridView()
        Me.btThem = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.txtTimkiem = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbBang = New System.Windows.Forms.ComboBox()
        Me.cmbTimkiem = New System.Windows.Forms.ComboBox()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.grbTimkiem = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvSinhvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grbTimkiem.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSinhvien
        '
        Me.dgvSinhvien.AllowUserToAddRows = False
        Me.dgvSinhvien.AllowUserToDeleteRows = False
        Me.dgvSinhvien.BackgroundColor = System.Drawing.Color.White
        Me.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinhvien.Location = New System.Drawing.Point(198, 129)
        Me.dgvSinhvien.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSinhvien.MultiSelect = False
        Me.dgvSinhvien.Name = "dgvSinhvien"
        Me.dgvSinhvien.ReadOnly = True
        Me.dgvSinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSinhvien.Size = New System.Drawing.Size(529, 187)
        Me.dgvSinhvien.TabIndex = 0
        '
        'btThem
        '
        Me.btThem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btThem.Location = New System.Drawing.Point(33, 154)
        Me.btThem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(126, 28)
        Me.btThem.TabIndex = 1
        Me.btThem.Text = "Thêm sinh viên"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'btSua
        '
        Me.btSua.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btSua.Location = New System.Drawing.Point(33, 190)
        Me.btSua.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(126, 28)
        Me.btSua.TabIndex = 1
        Me.btSua.Text = "Chỉnh sửa"
        Me.btSua.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btXoa.Location = New System.Drawing.Point(33, 226)
        Me.btXoa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(126, 28)
        Me.btXoa.TabIndex = 1
        Me.btXoa.Text = "Xóa sinh viên"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'txtTimkiem
        '
        Me.txtTimkiem.Location = New System.Drawing.Point(120, 23)
        Me.txtTimkiem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTimkiem.Name = "txtTimkiem"
        Me.txtTimkiem.Size = New System.Drawing.Size(319, 23)
        Me.txtTimkiem.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbBang)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(520, 56)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(188, 55)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bảng"
        '
        'cmbBang
        '
        Me.cmbBang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cmbBang.FormattingEnabled = True
        Me.cmbBang.Location = New System.Drawing.Point(16, 21)
        Me.cmbBang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbBang.Name = "cmbBang"
        Me.cmbBang.Size = New System.Drawing.Size(156, 21)
        Me.cmbBang.TabIndex = 0
        '
        'cmbTimkiem
        '
        Me.cmbTimkiem.FormattingEnabled = True
        Me.cmbTimkiem.Location = New System.Drawing.Point(6, 23)
        Me.cmbTimkiem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTimkiem.Name = "cmbTimkiem"
        Me.cmbTimkiem.Size = New System.Drawing.Size(108, 24)
        Me.cmbTimkiem.TabIndex = 5
        '
        'btThoat
        '
        Me.btThoat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btThoat.Location = New System.Drawing.Point(33, 262)
        Me.btThoat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(126, 28)
        Me.btThoat.TabIndex = 6
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'grbTimkiem
        '
        Me.grbTimkiem.Controls.Add(Me.cmbTimkiem)
        Me.grbTimkiem.Controls.Add(Me.txtTimkiem)
        Me.grbTimkiem.Location = New System.Drawing.Point(33, 56)
        Me.grbTimkiem.Name = "grbTimkiem"
        Me.grbTimkiem.Size = New System.Drawing.Size(458, 53)
        Me.grbTimkiem.TabIndex = 7
        Me.grbTimkiem.TabStop = False
        Me.grbTimkiem.Text = "Tìm Kiếm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Quản Lý Sinh Viên"
        '
        'frmQLSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(755, 360)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btThoat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btSua)
        Me.Controls.Add(Me.btThem)
        Me.Controls.Add(Me.dgvSinhvien)
        Me.Controls.Add(Me.grbTimkiem)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmQLSV"
        Me.Text = "Quản Lý Sinh Viên"
        CType(Me.dgvSinhvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.grbTimkiem.ResumeLayout(False)
        Me.grbTimkiem.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSinhvien As System.Windows.Forms.DataGridView
    Friend WithEvents btThem As System.Windows.Forms.Button
    Friend WithEvents btSua As System.Windows.Forms.Button
    Friend WithEvents btXoa As System.Windows.Forms.Button
    Friend WithEvents txtTimkiem As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBang As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTimkiem As System.Windows.Forms.ComboBox
    Friend WithEvents btThoat As Button
    Friend WithEvents grbTimkiem As GroupBox
    Friend WithEvents Label2 As Label
End Class
