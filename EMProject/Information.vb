Public Class Information

    Dim db As MSDB = New MSDB
    Dim Information_list As List(Of InformationVO) = db.Information_User("[EMProject].[dbo].[Information]", NumberVO._Number)

    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lbl_Name.Text = Information_list(0)._E_Name
        txt_IntroDuction.Text = Information_list(0)._E_IntroDuction
        lbl_Number.Text = Information_list(0)._E_Number

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        MessageBox.Show(txt_IntroDuction.Text)
        MessageBox.Show(Information_list(0)._E_Number)

        Dim db As MSDB = New MSDB

        Dim table As String = "[EMProject].[dbo].[Information] "

        ' 바꿀것들 
        Dim u_set As String = " E_IntroDuction = " & txt_IntroDuction.Text

        ' 조건
        Dim u_where As String = " E_Number = " & Information_list(0)._E_Number

        db.Update(table, u_set, u_where)


    End Sub


End Class