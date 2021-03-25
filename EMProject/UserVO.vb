Public Class UserVO

    Private E_Number As String
    Private E_PW As String
    Private E_Name As String
    Private E_Category As Integer

    Public Sub New(E_Number As String, E_PW As String, E_Name As String, E_Category As Integer)

        Me.E_Number = E_Number
        Me.E_PW = E_PW
        Me.E_Name = E_Name
        Me.E_Category = E_Category

    End Sub

    Property _E_Number As String
        Get
            Return Me.E_Number
        End Get
        Set(value As String)
            Me.E_Number = value
        End Set
    End Property

    Property _E_PW As String
        Get
            Return Me.E_PW
        End Get
        Set(value As String)
            Me.E_PW = value
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
    Property _E_Category As Integer
        Get
            Return Me.E_Category
        End Get
        Set(value As Integer)
            Me.E_Category = value
        End Set
    End Property



End Class
