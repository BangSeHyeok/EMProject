Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmptyCheck() Then
            'DB에서 ID와 PW확인
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    Function EmptyCheck() As Boolean
        'DB 아이디 비밀번호 공백 확인 부분
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("아이디를 입력해주세요")
            Return False
        ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
            MsgBox("비밀번호를 입력해주세요")
            Return False
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class