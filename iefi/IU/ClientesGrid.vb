Public Class ClientesGrid

    Private Sub ClienteGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'ClienteCollectionBindingSource.DataSource = ClienteList.InsertarCliente

        'Si la cantidad de filas es mayor a cero, entonces selecciono la primer fila.
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

    End Sub

    Private Sub llenarform()

            'Número de fila seleccionado del datagridview
            Dim fila As Integer = DataGridView1.CurrentRow.Index

        ClientesForm.IdTextBox.Text = ClienteList.Item(fila).Id
        ClientesForm.NombreTextBox.Text = ClienteList.Item(fila).Nombre

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Dispose()

    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs)
        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        ClientesForm.Text = "Modificar Rubro"
        ClientesForm.Label1.Text = "Modificar Rubro"
        ClientesForm.operacion = "Modificar"
        ClientesForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ClientesForm.Show()

        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows.Item(fila).Selected = False
        DataGridView1.Rows.Item(fila).Selected = True

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs)
        'Determina si existen filas en el DataGridView

        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        ClientesForm.Text = "Eliminar Cliente"
        ClientesForm.Label1.Text = "Eliminar Cliente"
        ClientesForm.operacion = "Eliminar"
        ClientesForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ClientesForm.Show()

    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs)

        ClientesForm.operacion = "Agregar"

        ClientesForm.Text = "Alta de Cliente"

        ClientesForm.Show()

    End Sub
End Class