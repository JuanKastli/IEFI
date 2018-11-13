
Imports System.ComponentModel
    Imports System.Text

Public Class ProvinciasCollection

    Inherits BindingList(Of ProvinciaClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)
        e.NewObject = New ProvinciaClass
    End Sub



    ''' <summary>
    ''' Trae todos las Articulos.
    ''' </summary>
    ''' <returns></returns>
    Public Function TraerProvincia() As ProvinciasCollection

        'Si la lista ya esta cargada la limpiamos.
        If Me.Items.Count > 0 Then Me.ClearItems()

        Dim ObjBaseDatos As New BaseDatoClass
        Dim MiDataTable As New DataTable
        Dim MiCliente As ProvinciaClass


        ObjBaseDatos.objTabla = "Provincia"
        MiDataTable = ObjBaseDatos.TraerTodo

        For Each dr As DataRow In MiDataTable.Rows
            MiCliente = New ProvinciaClass

            MiCliente.Id = CInt(dr("Id"))
            MiCliente.Provincia = dr("Provincia")

            Me.Add(MiCliente)
        Next

        Return Me

    End Function
    Public Sub InsertarProvincia(ByVal MiCliente As ProvinciaClass)

        Dim ObjBasedeDato As New BaseDatoClass
        'busca la tabla personas 
        ObjBasedeDato.objTabla = "Cliente"

        Dim vsql As New StringBuilder

        vsql.Append("(Nombre)")

        vsql.Append(" VALUES ")

        vsql.Append("('" & MiCliente.Provincia & "'")


        MiCliente.Id = ObjBasedeDato.Insertar(vsql.ToString)

        'Evalúa el resultado del comando SQL.
        If MiCliente.Id = 0 Then
            MsgBox("No fue posible agregar el Cliente ")
            Exit Sub
        End If

        Me.Add(MiCliente)

    End Sub

    Public Sub EliminarProvincia(ByVal MiCliente As ProvinciaClass)

        'Instancio el el Objeto BaseDatoClass para acceder al la base.
        Dim objBaseDatos As New BaseDatoClass
        objBaseDatos.objTabla = "Provincia"

        For Each Cliente In ClienteList
            'Ejecuta el método base eliminar.
            Dim resultado As Boolean
            resultado = objBaseDatos.Eliminar(Cliente.Id)

            If Not resultado Then
                MessageBox.Show("No fue posible eliminar el registro.")
                Exit For
            End If

            'Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Cliente)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Next

        Me.ClearItems()

    End Sub

    Public Sub ActualizarProvincia(ByVal MiCliente As ProvinciaClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base productos.
        Dim objBaseDatos As New BaseDatoClass
        objBaseDatos.objTabla = "Provincia"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Provincia='" & MiCliente.Provincia & "'")


        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiCliente.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el registro.")
            Exit Sub
        End If

        'El código a continuación sirve para localizar el ítem en la lista
        'en este caso un persona.
        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiCliente)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Me.Items.Item(Me.FindCore(myProperty, MiCliente.Id)) = MiCliente

    End Sub
End Class
