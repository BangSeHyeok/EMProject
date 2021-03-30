Public Class WorkTimeVO

    Private E_Number As String
    Private E_Date As Date
    Private E_qtw As Date
    Private E_qtn As Date

    Public Sub New(E_Number As String, E_Date As Date, E_qtw As Date, E_qtn As Date)

        Me.E_Number = E_Number
        Me.E_Date = E_Date
        Me.E_qtw = E_qtw
        Me.E_qtn = E_qtn

    End Sub

    Property _E_Number As String
        Get
            Return Me.E_Number
        End Get
        Set(value As String)
            Me.E_Number = value
        End Set
    End Property

    Property _E_Date As Date
        Get
            Return Me.E_Date
        End Get
        Set(value As Date)
            Me.E_Date = value
        End Set
    End Property

    Property _E_qtw As Date
        Get
            Return Me.E_qtw
        End Get
        Set(value As Date)
            Me.E_qtw = value
        End Set
    End Property

    Property _E_qtn As Date
        Get
            Return Me.E_qtn
        End Get
        Set(value As Date)
            Me.E_qtn = value
        End Set
    End Property

End Class
