
Public Class Information

    Dim db As MSDB = New MSDB
    Dim Information_list As List(Of InformationVO) = db.Information_User("[EMProject].[dbo].[Information]", NumberVO._Number)
    Dim User_list As List(Of UserVO) = db.User_All("[EMProject].[dbo].[User]")
    Dim WorkTime_list As List(Of WorkTimeVO) = db.workTime_total("[EMProject].[dbo].[WorkTime]", Information_list(0)._E_Number)

    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '회사원 리스트 정보 출력
        officeList()

        '인포메이션 메인화면 정보 출력
        '프로그레스 Bar 달 근무시간 출력
        worktime()

        '月근무 이력 
        WorkList()


        '인포메이션 메인화면 정보 출력
        lbl_Name.Text = Information_list(0)._E_Name
        txt_IntroDuction.Text = Information_list(0)._E_IntroDuction
        lbl_Number.Text = Information_list(0)._E_Number

    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Dim db As MSDB = New MSDB

        Dim table As String = "[EMProject].[dbo].[Information] "

        ' 바꿀것들 
        Dim u_set As String = " E_IntroDuction = '" & txt_IntroDuction.Text

        ' 조건
        Dim u_where As String = " E_Number = " & Information_list(0)._E_Number
        db.Update(table, u_set, u_where)


    End Sub

    Private Sub officeList()

        lv_list.Items.Clear()

        Dim x As ListViewItem

        For Each i In User_list
            x = New ListViewItem(i._E_Name)
            x.SubItems.Add(i._E_Number)
            lv_list.Items.Add(x)
        Next

    End Sub

    ' 현재月 근무 진행도
    Private Sub worktime()

        '현재 月 해야할 근무시간 체크 
        worktimeCheck()

        '로그인人　근무시간 가져오기   
        workertime()

        '현재 月 근무 진행 상황 (시간으로 변환, 소수점없이)
        Dim workrate As Integer = pb_Worktime.Value / 60

        '프로그래스 Bar 위에 진행율 표시.
        lbl_percent.Text = workrate & "/" & pb_Worktime.Maximum / 60 & "        " & Mid(pb_Worktime.Value / pb_Worktime.Maximum * 100 & "%", 1, 2) & " %진행중..."

    End Sub

    Private Sub worktimeCheck()
        ' 현재月 근무 해야하는 시간

        Dim year As Integer = DateTime.Now.ToString("yyyy")
        Dim month As Integer = DateTime.Now.ToString("MM")

        '월 일수 추출
        Dim days As String = Mid(DateSerial(year, month + 1, 1 - 1), 9, 2)

        'For문을 위한 i 선언
        Dim i As Long

        '평일 카운트 변수
        Dim dcount As Integer = 0

        For i = 1 To days
            Dim dt As New Date(year, month, i)
            If dt.DayOfWeek <> DayOfWeek.Saturday And dt.DayOfWeek <> DayOfWeek.Sunday Then
                dcount = dcount + 1
            End If
        Next

        '月 최대 근무 시간 분 으로 계산
        Dim monthworktime As Integer = dcount * 8 * 60

        If monthworktime > 178 * 60 Then
            monthworktime = 177 * 60
        End If

        pb_Worktime.Maximum = monthworktime

    End Sub

    Public Sub workertime()

        '시간계산을 하기위한 TimeSpan 함수 
        Dim TSpan As TimeSpan

        '분으로 계산한 총합 그릇.
        Dim worktotal As Integer = 0

        'span에서 분 추출
        Dim minutetotal As Integer = 0


        For Each i In WorkTime_list
            If i._E_qtw <> "" Then
                TSpan = Convert.ToDateTime(i._E_qtn).Subtract(Convert.ToDateTime(i._E_qtw))

                '점심시간 때문에 60 한번 빼준다.
                worktotal = TSpan.Hours * 60 + TSpan.Minutes - 60

                minutetotal = minutetotal + worktotal

            End If

        Next

        '현재 근무 시간
        pb_Worktime.Value = minutetotal

    End Sub

    Public Sub WorkList()

        lv_WorkList.Items.Clear()

        Dim x As ListViewItem

        For Each i In WorkTime_list
            x = New ListViewItem(i._E_Date)
            x.SubItems.Add(i._E_qtw)
            x.SubItems.Add(i._E_qtn)
            x.SubItems.Add(i._E_Number)
            lv_WorkList.Items.Add(x)
        Next

    End Sub


End Class
