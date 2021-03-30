Public Class Form1
    Dim home As Home
    Dim calendar As Calendar
    Dim information As Information
    Dim notice As Notice
    Dim old_name As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As Login
        Dim result As DialogResult
        login = New Login()
        result = login.ShowDialog()
        If result <> DialogResult.OK Then
            Me.Close()
        Else
            MessageBox.Show("로그인 성공")
        End If
        home = New Home()
        home.TopLevel = False  'toplevel 을 false 로 변경하면 panel form 에 docking 가능
        home.Show()
        Me.Panel1.Controls.Add(home)
        old_name = "Home"
    End Sub
    Private Sub lbl_Main_Click(sender As Object, e As EventArgs) Handles lbl_Main.Click
        old_name = "Home"
        Panel_Find("Home")
    End Sub
    Private Sub Panel_Find(name As String)
        For Each p As Control In Panel1.Controls
            If old_name = p.Name Then
                Return
            End If
            Panel1.Controls.Remove(p)
            p.Dispose()
        Next
        If name = "Home" Then
            home = New Home()
            home.TopLevel = False
            home.Show()
            Me.Panel1.Controls.Add(home)
        ElseIf name = "Calendar" Then
            calendar = New Calendar
            calendar.TopLevel = False
            calendar.Show()
            Me.Panel1.Controls.Add(calendar)
        ElseIf name = "Information" Then
            information = New Information
            information.TopLevel = False
            information.Show()
            Me.Panel1.Controls.Add(information)
        ElseIf name = "Notice" Then
            notice = New Notice
            notice.TopLevel = False
            notice.Show()
            Me.Panel1.Controls.Add(notice)
        End If
    End Sub

    Private Sub lbl_Calendar_Click(sender As Object, e As EventArgs) Handles lbl_Calendar.Click
        old_name = "Calendar"
        Panel_Find("Calendar")
    End Sub

    Private Sub lbl_Information_Click(sender As Object, e As EventArgs) Handles lbl_Information.Click
        old_name = "Information"
        Panel_Find("Information")
    End Sub

    Private Sub lbl_Notice_Click(sender As Object, e As EventArgs) Handles lbl_Notice.Click
        old_name = "Notice"
        Panel_Find("Notice")
    End Sub
End Class
