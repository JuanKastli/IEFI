
Option Strict On
    Option Explicit Off
Module ModuloPrincipal
    Public ClienteList As New ClientesCollection
    Public ProvinciaList As New ProvinciasCollection

    Public Sub main()

        Application.Run(ClientesGrid)
    End Sub



End Module
