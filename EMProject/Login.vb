﻿Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As MSDB = New MSDB
        If EmptyCheck() Then
            'DB에서 ID와 PW확인

            Dim Number As String = txt_Number.Text
            Dim PW As String = txt_PW.Text
            Dim User_list As List(Of UserVO) = db.User_All("[EMProject].[dbo].[User]")
            For Each i In User_list
                If i._E_Number.Equals(Number) And i._E_PW.Equals(PW) Then
                    Me.DialogResult = DialogResult.OK
                    NumberVO._Number = i._E_Number
                    Exit Sub
                End If
            Next

            MessageBox.Show("아이디와 비밀번호를 확인해주세요.")


        End If
    End Sub

    Function EmptyCheck() As Boolean
        'DB 아이디 비밀번호 공백 확인 부분
        If String.IsNullOrEmpty(txt_Number.Text) Then
            MsgBox("아이디를 입력해주세요")
            Return False
        ElseIf String.IsNullOrEmpty(txt_PW.Text) Then
            MsgBox("비밀번호를 입력해주세요")
            Return False
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class