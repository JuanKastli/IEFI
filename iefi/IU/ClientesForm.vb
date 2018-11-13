Public Class ClientesForm
    Dim operacion_ As String
    Dim MiCliente As New ClienteClass
    Dim IdProvinciaCombo_ As Integer

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As String

    Public Property indice() As String
        Get
            Return indice_
        End Get
        Set(ByVal value As String)
            indice_ = value
        End Set
    End Property

    Public Property idprovincia() As Integer
        Get
            Return IdProvinciaCombo_
        End Get
        Set(ByVal value As Integer)
            IdProvinciaCombo_ = value
        End Set
    End Property
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub
    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        MiCliente.Nombre = NombreTextBox.Text
        MiCliente.IdProvincia = IdProvinciaComboBox.SelectedIndex


        If operacion_ <> "Agregar" Then
            MiCliente.Id = CInt(Id.Text)
        End If

        Select Case operacion_

            Case "Agregar"
                ClienteList.InsertarCliente(MiCliente)

            Case "Eliminar"
                ClienteList.EliminarCliente(indice_)

            Case "Modificar"
                ClienteList.ActualizarCliente(MiCliente)

                ClientesGrid.DataGridView1.Refresh()


        End Select

        Me.Close()
    End Sub

    Private Sub ClienteForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'De donde traigo los datos
        IdProvinciaComboBox.DataSource = ClienteList.TraerTodo
        'Los valores que quiero mostrar
        IdProvinciaComboBox.DisplayMember = "Nombre"
        IdProvinciaComboBox.ValueMember = "Id"

        IdProvinciaComboBox.SelectedValue = idprovincia

        MiCliente.IdProvincia = CInt(IdProvinciaComboBox.SelectedValue)
    End Sub

End Class