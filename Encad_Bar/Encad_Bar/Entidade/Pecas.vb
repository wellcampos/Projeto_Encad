Public Class Pecas
    Private _Id As Integer
    Public Property ID() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property
    Private _obra As Integer
    Public Property Obra() As Integer
        Get
            Return _obra
        End Get
        Set(ByVal value As Integer)
            _obra = value
        End Set
    End Property
    Private _tipopc As String
    Public Property TipoPC() As String
        Get
            Return _tipopc
        End Get
        Set(ByVal value As String)
            _tipopc = value
        End Set
    End Property
    Private _numEtiqueta As Integer
    Public Property NumEtiqueta() As Integer
        Get
            Return _numEtiqueta
        End Get
        Set(ByVal value As Integer)
            _numEtiqueta = value
        End Set
    End Property
End Class
