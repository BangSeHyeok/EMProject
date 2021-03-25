Imports System.Data.SqlClient

Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As MSDB = New MSDB
        Dim Information_list As List(Of InformationVO) = db.Information_User("[EMProject].[dbo].[Information]", NumberVO._Number)
        txt_Name.Text = Information_list(0)._E_Name
        txt_IntroDuction.Text = Information_list(0)._E_IntroDuction
        txt_Number.Text = Information_list(0)._E_Number
        Dim count = db.WorkTime_Select_Count("[EMProject].[dbo].[WorkTime]", NumberVO._Number, DateTime.Now.ToString("yyyy-MM-dd"))
    End Sub
End Class