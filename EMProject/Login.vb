Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmptyCheck() Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    Function EmptyCheck() As Boolean
        If String.IsNullOrEmpty(TextBox1.Text) Then
            Return False
        ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) 

    End Sub
End Class