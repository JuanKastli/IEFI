Public Class ClienteClass
    Dim Id_ As Integer
    Dim Nombre_ As String
    Dim IdProvincia_ As Integer
    Dim Fecha_ As String
    Dim Saldo_ As String

    Public Property Id() As Integer
        Get
            Return Id_

        End Get
        Set(ByVal value As Integer)

            Id_ = value

        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Nombre_

        End Get
        Set(ByVal value As String)

            Nombre_ = value

        End Set
    End Property

    Public Property IdProvincia() As Integer
        Get
            Return IdProvincia_

        End Get
        Set(ByVal value As Integer)

            IdProvincia_ = value

        End Set
    End Property

    Dim nomprovincia_ As String
    Public ReadOnly Property nomprovincia() As String
        Get
            For Each Provincia In ProvinciaList
                If Provincia.Id = IdProvincia_ Then
                    nomprovincia_ = Provincia.Provincia
                    Exit For
                End If
            Next
            Return nomprovincia_
        End Get
    End Property
    Public Property Fecha() As String
        Get
            Return Fecha_

        End Get
        Set(ByVal value As String)

            Fecha_ = value

        End Set
    End Property
    Public Property Saldo() As String
        Get
            Return Saldo_

        End Get
        Set(ByVal value As String)

            Saldo_ = value

        End Set
    End Property
End Class
