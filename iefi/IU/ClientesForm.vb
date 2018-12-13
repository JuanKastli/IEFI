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
        MiCliente.Fecha = Fecha.Text
        MiCliente.Saldo = Saldo.Text


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
        'IdProvinciaComboBox.DataSource = ClienteList.TraerTodo
        IdProvinciaComboBox.DataSource = ProvinciaList.TraerProvincia

        'Los valores que quiero mostrar
        'IdProvinciaComboBox.DisplayMember = "Nombre" No existe la columna nombre en ProvinciasList
        IdProvinciaComboBox.DisplayMember = "Provincia"

        IdProvinciaComboBox.ValueMember = "Id"

        IdProvinciaComboBox.SelectedValue = idprovincia

        MiCliente.IdProvincia = CInt(IdProvinciaComboBox.SelectedValue)
    End Sub


    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        'solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub FechaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FechaTextBox.KeyPress
        'Solo permite de dígitos, barra separadora y borrado.
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "/" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub FechaTexBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FechaTextBox.LostFocus
        Dim fec() As String
        Dim dia, mes, anio As Integer

        'Obtiene un array con el dia, mes y año.
        fec = TextBox2.Text.Split("/")

        dia = CInt(fec(0))
        mes = CInt(fec(1))
        anio = CInt(fec(2))

        'Vefica que el año este entre 1900 y 2100.
        If anio < 1900 Or anio > 2100 Then
            MsgBox("El año es incorrecto.")
            Exit Sub
        End If

        'Verifica que el año este entre 1 y 12.
        If mes < 1 Or mes > 12 Then
            MsgBox("El mes es incorrecto.")
            Exit Sub
        End If

        'Verifica el dia considerando año bisiesto y mes.
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                'Meses con 31 días.
                If dia < 1 Or dia > 31 Then
                    MsgBox("El dia es incorrecto.")
                    Exit Sub
                End If

            Case 4, 6, 9, 11
                'Meses con 30 días.
                If dia < 1 Or dia > 30 Then
                    MsgBox("El dia es incorrecto.")
                    Exit Sub
                End If

            Case 2
                'Año bisiesto.
                If anio Mod 4 = 0 Then
                    'Febrero con 29 días.
                    If dia < 1 Or dia > 29 Then
                        MsgBox("El dia es incorrecto.")
                        Exit Sub
                    End If
                Else
                    'Febrero con 28 días.
                    If dia < 1 Or dia > 28 Then
                        MsgBox("El dia es incorrecto.")
                        Exit Sub
                    End If
                End If

        End Select

    End Sub
End Class