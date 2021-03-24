Imports System.Data.SqlClient
Imports System.Data

Public Class Home
    Dim conn As SqlConnection
    Dim str As String = String.Format("Data Source=DESKTOP-2A61KR5; Initial Catalog=EMProject;Integrated Security=False; uid=User1; pwd=1111")

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim csds As New DataSet
        Dim csda As New SqlDataAdapter


        Try
            conn = New SqlConnection(str)
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

        Dim strsql As String = "select * from [EMProject].[dbo].[User] "
        csda.SelectCommand = New SqlCommand(strsql, conn)
        csda.Fill(csds)


    End Sub

End Class

