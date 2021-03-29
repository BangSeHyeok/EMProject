﻿Public Class Information

    Dim db As MSDB = New MSDB
    Dim Information_list As List(Of InformationVO) = db.Information_User("[EMProject].[dbo].[Information]", NumberVO._Number)
    Dim User_list As List(Of UserVO) = db.User_All("[EMProject].[dbo].[User]")

    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '회사원 리스트 정보 출력
        officeList()

        '인포메이션 메인화면 정보 출력
        '프로그레스 Bar 달 근무시간 출력
        worktime()

        '인포메이션 메인화면 정보 출력
        lbl_Name.Text = Information_list(0)._E_Name
        txt_IntroDuction.Text = Information_list(0)._E_IntroDuction
        lbl_Number.Text = Information_list(0)._E_Number

    End Sub

    Private Function test() As List(Of UserVO)

        Dim userlist As New List(Of UserVO)

        Return userlist

    End Function

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Dim db As MSDB = New MSDB

        Dim table As String = "[EMProject].[dbo].[Information] "

        ' 바꿀것들 
        Dim u_set As String = " E_IntroDuction = '" & txt_IntroDuction.Text

        ' 조건
        Dim u_where As String = " E_Number = " & Information_list(0)._E_Number

        db.Update(table, u_set, u_where)


    End Sub

    Private Sub worktime()

        pb_Worktime.Value = Val(30)

    End Sub
    Private Sub officeList()

        LV_list.Items.Clear()

        Dim x As ListViewItem

        For Each i In User_list
            x = New ListViewItem(i._E_Name)
            x.SubItems.Add(i._E_Number)
            LV_list.Items.Add(x)
        Next

    End Sub

End Class