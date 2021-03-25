Public Class InformationVO
    Private E_Number As String
    Private E_Name As String
    Private E_Vacation As Int32
    Private E_Photo As String
    Private E_IntroDuction As String
    Public Sub New(E_Number As String, E_Name As String, E_Vacation As Int32, E_Photo As String, E_IntroDuction As String)
        Me.E_Number = E_Number
        Me.E_Name = E_Name
        Me.E_Vacation = E_Vacation
        Me.E_Photo = E_Photo
        Me.E_IntroDuction = E_IntroDuction
    End Sub
    Property _E_Number As String
        Get
            Return Me.E_Number
        End Get
        Set(value As String)
            Me.E_Number = value
        End Set
    End Property
    Property _E_Name As String
        Get
            Return Me.E_Name
        End Get
        Set(value As String)
            Me.E_Name = value
        End Set
    End Property
    Property _E_Vacation As Int32
        Get
            Return Me.E_Vacation
        End Get
        Set(value As Int32)
            Me.E_Vacation = value
        End Set
    End Property
    Property _E_Photo As String
        Get
            Return Me.E_Photo
        End Get
        Set(value As String)
            Me.E_Photo = value
        End Set
    End Property
    Property _E_IntroDuction As String
        Get
            Return Me.E_IntroDuction
        End Get
        Set(value As String)
            Me.E_IntroDuction = value
        End Set
    End Property

End Class
