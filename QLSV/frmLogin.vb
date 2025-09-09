Public Class frmLogin
    Private Sub btkhach_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmQLSV.Show()

    End Sub

    Private Sub btdangnhap_Click(sender As Object, e As EventArgs) Handles btdangnhap.Click
        If txttk.Text = "" And txtmk.Text = "" Then
            Me.Hide()
            frmQLSV.Show()

        Else
            MsgBox("Tài khoản hoặc mật khẩu sai!")
            txttk.Text = ""
            txtmk.Text = ""
        End If
    End Sub
End Class