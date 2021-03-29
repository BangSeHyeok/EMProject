Imports System.Data.SqlClient

Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As MSDB = New MSDB
        Dim Information_list As List(Of InformationVO) = db.Information_User("[EMProject].[dbo].[Information]", NumberVO._Number)
        ' MsgBox(Information_list.Count)
        txt_Name.Text = Information_list(0)._E_Name
        txt_IntroDuction.Text = Information_list(0)._E_IntroDuction
        txt_Number.Text = Information_list(0)._E_Number
        Dim count = db.WorkTime_Count("[EMProject].[dbo].[WorkTime]", NumberVO._Number, DateTime.Now.ToString("yyyy-MM-dd"))
        If count = 2 Then
            btn_gtw.Enabled = False
            btn_gth.Enabled = False
        ElseIf count = 0 Then
            btn_gtw.Enabled = False
            btn_gth.Enabled = True
        Else
            btn_gtw.Enabled = True
            btn_gth.Enabled = False
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
End Class