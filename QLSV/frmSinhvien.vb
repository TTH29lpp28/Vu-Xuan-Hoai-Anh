Public Class frmSinhvien
    'Khai bao bien truy xuat DB tu lop DBAcccess
    Private _DBAccess As New DataBaseAccess

    'Khai bao bien de biet trang thai dang la Edit hay Insert
    Private _isEdit As Boolean = False
    Public Sub New(IsEdit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    'Dinh nghia Ham them ban ghi Sinh vien vao database
    Private Function ThemSinhVien() As Boolean
        Dim sqlQuery As String = ("INSERT INTO Sinhvien (MaSV, TenSV, Ngaysinh, Quequan, Tenmonhoc) ")
        sqlQuery += String.Format("VALUES ('{0}','{1}','{2}','{3}','{4}');INSERT INTO Diem (MaSV, TenSV, Tenmonhoc, Diem) VALUES ('{5}','{6}','{7}','{8}')",
             txtMaSV.Text, txtTenSV.Text, txtNgaysinh.Text, txtQuequan.Text, cbMonhoc.Text,
            txtMaSV.Text, txtTenSV.Text, cbMonhoc.Text, txtDiem.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'Dinh nghia Ham Update 
    Private Function SuaSinhVien() As Boolean
        Dim sqlQuery As String = String.Format("UPDATE Sinhvien SET TenSV = '{0}', Ngaysinh ='{1}', Quequan ='{2}' ,Tenmonhoc ='{3}' WHERE MaSV = '{4}';
                                                UPDATE Diem SET Diem =N'{5}' WHERE MaSV = '{6}';",
                                              Me.txtTenSV.Text, Me.txtNgaysinh.Text, Me.txtQuequan.Text, Me.cbMonhoc.Text, Me.txtMaSV.Text,
                                              Me.txtDiem.Text.Replace(",", "."), Me.txtMaSV.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'Dinh nghia ham kiem tra gia tri truoc khi insert du lieu vao database
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txtTenSV.Text) OrElse String.IsNullOrEmpty(txtNgaysinh.Text) OrElse
                String.IsNullOrEmpty(txtQuequan.Text) OrElse String.IsNullOrEmpty(cbMonhoc.Text) OrElse
                String.IsNullOrEmpty(txtMaSV.Text) OrElse String.IsNullOrEmpty(txtDiem.Text))
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmpty() Then   'Kiem tra truong du lieu truoc khi thuc hien THEM, SUA
            MessageBox.Show("Hay nhap gia tri vao truoc khi ghi vao database", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then     'Neu la Edit thi goi ham Update
                If SuaSinhVien() Then 'Neu Update thanh cong thi thong bao
                    MessageBox.Show("Sua du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else        'Neu co loi khi sua thi thong bao loi
                    MessageBox.Show("Loi sua du lieu!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else                'Neu khong phai Edit thi goi ham Insert
                If ThemSinhVien() Then 'Neu insert thanh cong thi thong bao
                    MessageBox.Show("Them du lieu thanh cong!", "Infomation", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Loi Them du lieu!!", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            End If

            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class