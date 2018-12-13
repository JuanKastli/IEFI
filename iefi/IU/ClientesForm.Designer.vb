<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.IdProvinciaComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Saldo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cancelar
        '
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(155, 258)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(117, 29)
        Me.Cancelar.TabIndex = 13
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.Location = New System.Drawing.Point(12, 258)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(109, 30)
        Me.Aceptar.TabIndex = 12
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.HideSelection = False
        Me.IdTextBox.Location = New System.Drawing.Point(95, 27)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(177, 20)
        Me.IdTextBox.TabIndex = 17
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.Location = New System.Drawing.Point(10, 27)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(23, 20)
        Me.Id.TabIndex = 16
        Me.Id.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "IdProvincia"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(95, 75)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(177, 20)
        Me.NombreTextBox.TabIndex = 23
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(10, 75)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(63, 20)
        Me.Nombre.TabIndex = 22
        Me.Nombre.Text = "nombre"
        '
        'IdProvinciaComboBox
        '
        Me.IdProvinciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdProvinciaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProvinciaComboBox.FormattingEnabled = True
        Me.IdProvinciaComboBox.Location = New System.Drawing.Point(95, 113)
        Me.IdProvinciaComboBox.Name = "IdProvinciaComboBox"
        Me.IdProvinciaComboBox.Size = New System.Drawing.Size(177, 21)
        Me.IdProvinciaComboBox.TabIndex = 24
        '
        'FechaTextBox
        '
        Me.FechaTextBox.Location = New System.Drawing.Point(95, 161)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(177, 20)
        Me.FechaTextBox.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(95, 206)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(177, 20)
        Me.TextBox2.TabIndex = 26
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Fecha.Location = New System.Drawing.Point(10, 159)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(54, 20)
        Me.Fecha.TabIndex = 27
        Me.Fecha.Text = "Fecha"
        '
        'Saldo
        '
        Me.Saldo.AutoSize = True
        Me.Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Saldo.Location = New System.Drawing.Point(10, 204)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(50, 20)
        Me.Saldo.TabIndex = 28
        Me.Saldo.Text = "Saldo"
        '
        'ClientesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 299)
        Me.Controls.Add(Me.Saldo)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(Me.IdProvinciaComboBox)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Name = "ClientesForm"
        Me.Text = "ClientesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancelar As Button
    Friend WithEvents Aceptar As Button
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Id As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents IdProvinciaComboBox As ComboBox
    Friend WithEvents FechaTextBox As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Fecha As Label
    Friend WithEvents Saldo As Label
End Class
