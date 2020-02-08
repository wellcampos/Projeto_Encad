Public Class TipoPecas
    Private _Id As Integer
    Public Property ID() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property
    Private _nome As String
    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property
    Private _barNumber As String
    Public Property BarNumber() As String
        Get
            Return _barNumber
        End Get
        Set(ByVal value As String)
            _barNumber = value
        End Set
    End Property
End Class
