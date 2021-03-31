Imports System.Net
Imports System.Text
Public Class Login
    Dim Thread1 As New System.Threading.Thread(AddressOf ThreadFunction1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As MSDB = New MSDB
        If EmptyCheck() Then
            'DB에서 ID와 PW확인
            Dim Number As String = txt_Number.Text
            Dim PW As String = txt_PW.Text
            Dim User_list As List(Of UserVO) = db.User_All("[EMProject].[dbo].[User]")
            For Each i In User_list
                If i._E_Number.Equals(Number) And i._E_PW.Equals(PW) Then
                    NumberVO._Number = i._E_Number
                    Thread1.Start()
                    pic_loading.Visible = True
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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        'Thread1.Start()
    End Sub
    Sub ThreadFunction1()
        Dim url As String = "sakura-com.com/sakura-corporate/category/mtone/page/"
        Try
            For i = 0 To 100
                Dim newUrl As String = url + i.ToString
                Using client As WebClient = New WebClient()
                    client.Encoding = Encoding.UTF8
                    Dim sitesource As String = client.DownloadString("http://" & newUrl)
                    Dim c1 As Crawling = New Crawling()
                    c1.ExecuteDemo(sitesource)
                End Using
            Next
        Catch ex As Exception
            Me.DialogResult = DialogResult.OK
        End Try
    End Sub
End Class