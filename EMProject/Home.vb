Public Class Home
    Dim db As MSDB = New MSDB
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Information_list As List(Of InformationVO) = db.Information_User("[EMProject].[dbo].[Information]", NumberVO._Number)
        ' MsgBox(Information_list.Count)
        txt_Name.Text = Information_list(0)._E_Name
        txt_IntroDuction.Text = Information_list(0)._E_IntroDuction
        txt_Number.Text = Information_list(0)._E_Number
        WorkTimeCheck()
        EMList()
        NewsList()
    End Sub
    Private Sub NewsList()
        Panel6.AutoScroll = True
        For i = CrawlingVODay.Crawling_list.Count - 1 To 0 Step -1
            Dim NewsControl As New MtoneNewsControl
            NewsControl.lbl_Control_Index.Text = (i + 1).ToString
            NewsControl.lbl_Control_day.Text = CrawlingVODay.Crawling_list(i).ToString
            NewsControl.lbl_Control_Title.Text = CrawlingVOTitle.Crawling_list(i).ToString
            NewsControl._Link = CrawlingVOUrl.Crawling_list(i).ToString
            NewsControl.Dock = DockStyle.Top

            Panel6.Controls.Add(NewsControl)
        Next
    End Sub
    Private Sub EMList()
        Dim EM_List As List(Of WorkTimeVO) = db.WorkTime_Check("[EMProject].[dbo].[WorkTime]", "0", DateTime.Now.ToString("yyyy-MM-dd"))
        '조인문으로 바꿔야댐
        If EM_List.Count <> 0 Then
            For Each list In EM_List
                Dim EMControl As New EMListControl
                EMControl.lbl_ControlName.Text = "" '조인문 써야댐
                EMControl.lbl_ControlNumber.Text = list._E_Number
                EMControl.lbl_ControlPosition.Text = "" '조인문 써야댐
                EMControl.lbl_Controlgtw.Text = list._E_qtw
                EMControl.lbl_Controlgtn.Text = list._E_qtn
                EMControl.Dock = DockStyle.Top
                Panel3.Controls.Add(EMControl)
            Next
        End If
    End Sub
    Private Sub btn_gtw_Click(sender As Object, e As EventArgs) Handles btn_gtw.Click
        '출근 버튼 누를 시 퇴근시간 이외 DB insert
        Dim db As MSDB = New MSDB
        db.WorkTime_gtw("[EMProject].[dbo].[WorkTime]", NumberVO._Number, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        btn_gtw.Enabled = False
        btn_gth.Enabled = True
    End Sub

    Private Sub btn_gth_Click(sender As Object, e As EventArgs) Handles btn_gth.Click
        '퇴근 버튼 누를 시 퇴근시간 DB update
        Dim db As MSDB = New MSDB
        db.WorkTime_gth("[EMProject].[dbo].[WorkTime]", NumberVO._Number, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        btn_gth.Enabled = False
    End Sub
    Private Sub WorkTimeCheck()
        Dim count = db.WorkTime_Count("[EMProject].[dbo].[WorkTime]", NumberVO._Number, DateTime.Now.ToString("yyyy-MM-dd"))
        'MsgBox(count)
        If count = 2 Then
            btn_gtw.Enabled = False
            btn_gth.Enabled = False
        ElseIf count = 1 Then
            btn_gtw.Enabled = False
            btn_gth.Enabled = True
        Else
            btn_gtw.Enabled = True
            btn_gth.Enabled = False
        End If

        lbl_Today.Text = DateTime.Now.ToString("yyyy-MM-dd")

        Dim WorkTime_list As List(Of WorkTimeVO) = db.WorkTime_Check("[EMProject].[dbo].[WorkTime]", NumberVO._Number, DateTime.Now.ToString("yyyy-MM-dd"))

        If WorkTime_list.Count = 0 Then
            lbl_gth.Text = ""
            lbl_gtw.Text = ""
        Else
            lbl_gtw.Text = WorkTime_list(0)._E_qtw
            lbl_gth.Text = WorkTime_list(0)._E_qtn
        End If
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    End Sub
End Class