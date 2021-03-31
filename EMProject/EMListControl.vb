Imports System.ComponentModel

Public Class EMListControl
    Public Sub New()
        InitializeComponent()
    End Sub
    <Category("사용자 정의 항목"), Description("사원 번호")>
    Public Property Control_Number As String
        Get
            Return lbl_ControlNumber.Text
        End Get
        Set(ByVal value As String)
            lbl_ControlNumber.Text = value
        End Set
    End Property
    <Category("사용자 정의 항목"), Description("사원 이름")>
    Public Property Control_Name As String
        Get
            Return lbl_ControlName.Text
        End Get
        Set(ByVal value As String)
            lbl_ControlName.Text = value
        End Set
    End Property
    <Category("사용자 정의 항목"), Description("출근 시간")>
    Public Property Control_gtw As String
        Get
            Return lbl_Controlgtw.Text
        End Get
        Set(ByVal value As String)
            lbl_Controlgtw.Text = value
        End Set
    End Property
    <Category("사용자 정의 항목"), Description("퇴근 시간")>
    Public Property Control_gtn As String
        Get
            Return lbl_Controlgtn.Text
        End Get
        Set(ByVal value As String)
            lbl_Controlgtn.Text = value
        End Set
    End Property
    <Category("사용자 정의 항목"), Description("사원 직급")>
    Public Property Control_Position As String
        Get
            Return lbl_ControlPosition.Text
        End Get
        Set(ByVal value As String)
            lbl_ControlPosition.Text = value
        End Set
    End Property
End Class
