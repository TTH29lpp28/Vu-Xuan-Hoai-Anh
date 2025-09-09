Imports System.Data.SqlClient

Public Class frmQLSV
    'Khai bao bien de truy xuat DB tu lop DataBaseAccess
    Private _DBAccess As New DataBaseAccess

    'Khai bao bien trang thai kiem tra du lieu dang Load
    Private _isLoading As Boolean = False

    'Dinh nghia thu tuc load du lieu tu bang Lop vao ComBobox
    Private Sub LoadDataOnComBobox()
        Dim sqlQuery As String = "SELECT name FROM sys.tables"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.cmbBang.DataSource = dTable
        Me.cmbBang.ValueMember = "name"
        Me.cmbBang.DisplayMember = "name"
    End Sub

    'Dinh nghia thu tuc load du lieu tu bang Sinh vien theo tung Lop vao Gridview
    Private Sub LoadDataOnGridView(Tenbang As String)
        Dim sqlQuery As String =
    String.Format("Select * FROM [" & Tenbang & "]")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        Me.dgvSinhvien.DataSource = dTable
        With Me.dgvSinhvien
            Select Case Tenbang
                Case "Sinhvien"
                    dgvSinhvien.Columns("MaSV").HeaderText = "Mã sinh viên"
                    dgvSinhvien.Columns("TenSV").HeaderText = "Tên sinh viên"
                    dgvSinhvien.Columns("TenSV").Width = 130
                    dgvSinhvien.Columns("Tenmonhoc").HeaderText = "Tên môn học"
                    dgvSinhvien.Columns("Ngaysinh").HeaderText = "Ngày sinh"
                    dgvSinhvien.Columns("Quequan").HeaderText = "Quê quán"
                Case "Monhoc"
                    dgvSinhvien.Columns("Tenmonhoc").HeaderText = "Tên môn học"
                    dgvSinhvien.Columns("TenGV").HeaderText = "Tên giáo viên"
                    dgvSinhvien.Columns("TenGV").Width = 130
                Case "Diem"
                    dgvSinhvien.Columns("MaSV").HeaderText = "Mã sinh viên"
                    dgvSinhvien.Columns("TenSV").HeaderText = "Tên sinh viên"
                    dgvSinhvien.Columns("TenSV").Width = 130
                    dgvSinhvien.Columns("Tenmonhoc").HeaderText = "Tên môn học"
                    dgvSinhvien.Columns("Diem").HeaderText = "Điểm"
            End Select

        End With
    End Sub


    Private Sub frmQLSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d = Date.Now()
        _isLoading = True   'True khi du lieu bat dau load

        LoadDataOnComBobox()
        LoadDataOnGridView(Me.cmbBang.SelectedValue)

        _isLoading = False  'False khi load du lieu xong
    End Sub

    Private Sub cmbBang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBang.SelectedIndexChanged
        If cmbBang.Text = "Sinhvien" Or cmbBang.Text = "Diem" Then
            cmbTimkiem.Items.Clear()
            cmbTimkiem.Items.Add("Mã sinh viên")
            cmbTimkiem.Items.Add("Tên sinh viên")
        Else
            cmbTimkiem.Items.Clear()
            cmbTimkiem.Items.Add("Tên môn học")
            cmbTimkiem.Items.Add("Tên giáo viên")
        End If
        If Not _isLoading Then  'Neu load du lieu xong
            LoadDataOnGridView(Me.cmbBang.SelectedValue)
        End If
    End Sub

    'Dinh nghia thu tuc hien thi ket qua Search: theo phuong phap tuong tu - Tim kiem tuong tu
    Private Sub Timkiemsinhvien(Tim As String, value As String)
        If cmbBang.Text = "Sinhvien" Then
            Dim sqlQuery As String =
                String.Format("SELECT MaSV, TenSV, Ngaysinh, Quequan, Tenmonhoc FROM dbo.Sinhvien WHERE ")
            If Me.cmbTimkiem.SelectedIndex = 0 Then      'Tim theo Student ID
                sqlQuery += String.Format(" MaSV LIKE '{0}%'", value)
            ElseIf Me.cmbTimkiem.SelectedIndex = 1 Then  'Tim theo Student Name
                sqlQuery += String.Format(" TenSV LIKE '{0}%'", value)
            End If
            Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
            Me.dgvSinhvien.DataSource = dTable
            With Me.dgvSinhvien
                .Columns(0).HeaderText = "Mã Sinh viên"
                .Columns(1).HeaderText = "Tên sinh viên"
                .Columns(1).Width = 140
                .Columns(2).HeaderText = "Tên môn học"
                .Columns(3).HeaderText = "Ngày sinh"
                .Columns(3).Width = 200
                .Columns(4).HeaderText = "Quê quán"
            End With
        ElseIf cmbBang.Text = "Monhoc" Then
            Dim sqlQuery As String =
                String.Format("SELECT Tenmonhoc, TenGV FROM dbo.Monhoc WHERE ")
            If Me.cmbTimkiem.SelectedIndex = 0 Then
                sqlQuery += String.Format(" Tenmonhoc LIKE '{0}%'", value)
            ElseIf Me.cmbTimkiem.SelectedIndex = 1 Then
                sqlQuery += String.Format(" TenGV LIKE '{0}%'", value)
            End If
            Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
            Me.dgvSinhvien.DataSource = dTable
            With Me.dgvSinhvien
                .Columns(0).HeaderText = "Tên Mmôn học"
                .Columns(1).HeaderText = "Tên giáo viên"
                .Columns(1).Width = 140
            End With
        Else
            Dim sqlQuery As String =
                String.Format("SELECT MaSV, TenSV,Tenmonhoc, Diem FROM dbo.Diem WHERE ")
            If Me.cmbTimkiem.SelectedIndex = 0 Then
                sqlQuery += String.Format(" MaSV LIKE '{0}%'", value)
            ElseIf Me.cmbTimkiem.SelectedIndex = 1 Then
                sqlQuery += String.Format(" TenSV LIKE '{0}%'", value)
            End If
            Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
            Me.dgvSinhvien.DataSource = dTable
            With Me.dgvSinhvien
                .Columns(0).HeaderText = "Mã sinh viên"
                .Columns(1).HeaderText = "Tên sinh viên"
                .Columns(1).Width = 140
                .Columns(2).HeaderText = "Điểm"
            End With
        End If
    End Sub
    Private Sub txtTimkiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimkiem.TextChanged
        Timkiemsinhvien(Me.cmbBang.SelectedValue, Me.txtTimkiem.Text)
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim frm As New frmSinhvien(False)
        frm.txtMaSV.Focus()
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            'Load du lieu
            LoadDataOnGridView(Me.cmbBang.SelectedValue)
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim frm As New frmSinhvien(True)
        frm.txtMaSV.ReadOnly = True
        With Me.dgvSinhvien
            If cmbBang.Text = "Sinhvien" Then
                frm.txtMaSV.Text = .Rows(.CurrentCell.RowIndex).Cells("MaSV").Value
                Dim So As String = .Rows(.CurrentCell.RowIndex).Cells("MaSV").Value
                frm.txtTenSV.Text = .Rows(.CurrentCell.RowIndex).Cells("TenSV").Value
                frm.txtNgaysinh.Text = .Rows(.CurrentCell.RowIndex).Cells("Ngaysinh").Value
                frm.txtQuequan.Text = .Rows(.CurrentCell.RowIndex).Cells("Quequan").Value
                frm.cbMonhoc.Text = .Rows(.CurrentCell.RowIndex).Cells("Tenmonhoc").Value
                frm.txtDiem.Text = _DBAccess.LayDiem("Diem", "dbo.Diem", "a", So)
            ElseIf cmbBang.Text = "Diem" Then
                frm.txtMaSV.Text = .Rows(.CurrentCell.RowIndex).Cells("MaSV").Value
                Dim So As String = .Rows(.CurrentCell.RowIndex).Cells("MaSV").Value
                frm.txtTenSV.Text = .Rows(.CurrentCell.RowIndex).Cells("TenSV").Value
                frm.txtNgaysinh.Text = DateTime.Parse(_DBAccess.LayDiem("Ngaysinh", "dbo.Sinhvien", "a", So))
                frm.txtQuequan.Text = _DBAccess.LayDiem("Quequan", "dbo.Sinhvien", "a", So)
                frm.cbMonhoc.Text = .Rows(.CurrentCell.RowIndex).Cells("Tenmonhoc").Value
                frm.txtDiem.Text = .Rows(.CurrentCell.RowIndex).Cells("Diem").Value
            End If
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then 'Sua du lieu thanh cong thi load lai du lieu vao gridview
            LoadDataOnGridView(Me.cmbBang.SelectedValue)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        'Khai bao bien lay StudentID ma dong can xoa da duoc chon tren gridview
        If cmbBang.Text <> "Monhoc" Then
            Dim MaSV As String = Me.dgvSinhvien.Rows(Me.dgvSinhvien.CurrentCell.RowIndex).Cells("MaSV").Value

            'Khai bao cau lenh Query de xoa
            Dim sqlQuery As String = String.Format("DELETE FROM Diem WHERE MaSV ='{0}'; DELETE FROM SinhVien WHERE MaSV ='{1}'", MaSV, MaSV)

            'Thuc hien xoa
            If _DBAccess.ExecuteNoneQuery(sqlQuery) Then    'Xoa thanh cong thi thong bao
                MessageBox.Show("Da xoa du lieu thanh cong!")
                'Load lai du lieu tren Gridview
                LoadDataOnGridView(Me.cmbBang.SelectedValue)
            Else
                MessageBox.Show("Loi xoa du lieu!")
            End If
        Else
            MessageBox.Show("Khong the xoa mon hoc!", "Warning", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btthoat_Click(sender As Object, e As EventArgs) Handles btThoat.Click
        End
    End Sub

End Class
