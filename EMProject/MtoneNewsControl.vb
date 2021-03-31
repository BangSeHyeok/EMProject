Imports System.ComponentModel
Public Class MtoneNewsControl
    Public Sub New()
        InitializeComponent()
    End Sub
    Dim link As String = ""
    Public Property _Link As String
        Get
            Return link
        End Get
        Set(ByVal value As String)
            link = value
        End Set
    End Property

    <Category("사용자 정의 항목"), Description("인덱스")>
    Public Property Control_Index As String
        Get
            Return lbl_Control_Index.Text
        End Get
        Set(ByVal value As String)
            lbl_Control_Index.Text = value
        End Set
    End Property
    <Category("사용자 정의 항목"), Description("날짜")>
    Public Property Control_day As String
        Get
            Return lbl_Control_day.Text
        End Get
        Set(ByVal value As String)
            lbl_Control_day.Text = value
        End Set
    End Property
    <Category("사용자 정의 항목"), Description("제목")>
    Public Property Control_Title As String
        Get
            Return lbl_Control_Title.Text
        End Get
        Set(ByVal value As String)
            lbl_Control_Title.Text = value
        End Set
    End Property

    Private Sub lbl_Control_Title_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_Control_Title.LinkClicked
        Dim psi As New ProcessStartInfo(link) With {.UseShellExecute = True}
        Process.Start(psi)
    End Sub
End Class
