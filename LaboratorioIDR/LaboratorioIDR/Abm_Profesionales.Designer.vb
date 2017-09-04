<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profesionales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnLimpiarCamposProf = New System.Windows.Forms.Button()
        Me.BtnSalirProf = New System.Windows.Forms.Button()
        Me.DTPFechaIngProf = New System.Windows.Forms.DateTimePicker()
        Me.DGVProfesionales = New System.Windows.Forms.DataGridView()
        Me.TxtTelProf = New System.Windows.Forms.TextBox()
        Me.TxtEspecialidad = New System.Windows.Forms.TextBox()
        Me.TxtApeProf = New System.Windows.Forms.TextBox()
        Me.TxtNombreProf = New System.Windows.Forms.TextBox()
        Me.TxtDNIProf = New System.Windows.Forms.TextBox()
        Me.BtnEliminarProf = New System.Windows.Forms.Button()
        Me.BtnModificarProf = New System.Windows.Forms.Button()
        Me.BtnAgregarProf = New System.Windows.Forms.Button()
        Me.BtnBuscarDNIProf = New System.Windows.Forms.Button()
        Me.LbTelProf = New System.Windows.Forms.Label()
        Me.LbEspecialidadProf = New System.Windows.Forms.Label()
        Me.LbFechaIngProf = New System.Windows.Forms.Label()
        Me.LbApellido = New System.Windows.Forms.Label()
        Me.LbNombreProf = New System.Windows.Forms.Label()
        Me.LbDNIProf = New System.Windows.Forms.Label()
        CType(Me.DGVProfesionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLimpiarCamposProf
        '
        Me.BtnLimpiarCamposProf.Location = New System.Drawing.Point(417, 199)
        Me.BtnLimpiarCamposProf.Name = "BtnLimpiarCamposProf"
        Me.BtnLimpiarCamposProf.Size = New System.Drawing.Size(115, 21)
        Me.BtnLimpiarCamposProf.TabIndex = 51
        Me.BtnLimpiarCamposProf.Text = "Limpiar Campos"
        Me.BtnLimpiarCamposProf.UseVisualStyleBackColor = True
        '
        'BtnSalirProf
        '
        Me.BtnSalirProf.Location = New System.Drawing.Point(508, 54)
        Me.BtnSalirProf.Name = "BtnSalirProf"
        Me.BtnSalirProf.Size = New System.Drawing.Size(82, 26)
        Me.BtnSalirProf.TabIndex = 50
        Me.BtnSalirProf.Text = "Salir"
        Me.BtnSalirProf.UseVisualStyleBackColor = True
        '
        'DTPFechaIngProf
        '
        Me.DTPFechaIngProf.Location = New System.Drawing.Point(157, 67)
        Me.DTPFechaIngProf.Name = "DTPFechaIngProf"
        Me.DTPFechaIngProf.Size = New System.Drawing.Size(200, 20)
        Me.DTPFechaIngProf.TabIndex = 49
        '
        'DGVProfesionales
        '
        Me.DGVProfesionales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGVProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProfesionales.Location = New System.Drawing.Point(12, 241)
        Me.DGVProfesionales.Name = "DGVProfesionales"
        Me.DGVProfesionales.Size = New System.Drawing.Size(618, 178)
        Me.DGVProfesionales.TabIndex = 48
        '
        'TxtTelProf
        '
        Me.TxtTelProf.Location = New System.Drawing.Point(155, 129)
        Me.TxtTelProf.Name = "TxtTelProf"
        Me.TxtTelProf.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelProf.TabIndex = 47
        '
        'TxtEspecialidad
        '
        Me.TxtEspecialidad.Location = New System.Drawing.Point(157, 96)
        Me.TxtEspecialidad.Name = "TxtEspecialidad"
        Me.TxtEspecialidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtEspecialidad.TabIndex = 43
        '
        'TxtApeProf
        '
        Me.TxtApeProf.Location = New System.Drawing.Point(363, 31)
        Me.TxtApeProf.Name = "TxtApeProf"
        Me.TxtApeProf.Size = New System.Drawing.Size(100, 20)
        Me.TxtApeProf.TabIndex = 42
        '
        'TxtNombreProf
        '
        Me.TxtNombreProf.Location = New System.Drawing.Point(157, 34)
        Me.TxtNombreProf.Name = "TxtNombreProf"
        Me.TxtNombreProf.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombreProf.TabIndex = 41
        '
        'TxtDNIProf
        '
        Me.TxtDNIProf.Location = New System.Drawing.Point(157, 4)
        Me.TxtDNIProf.Name = "TxtDNIProf"
        Me.TxtDNIProf.Size = New System.Drawing.Size(100, 20)
        Me.TxtDNIProf.TabIndex = 40
        '
        'BtnEliminarProf
        '
        Me.BtnEliminarProf.Location = New System.Drawing.Point(299, 199)
        Me.BtnEliminarProf.Name = "BtnEliminarProf"
        Me.BtnEliminarProf.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarProf.TabIndex = 39
        Me.BtnEliminarProf.Text = "Eliminar"
        Me.BtnEliminarProf.UseVisualStyleBackColor = True
        '
        'BtnModificarProf
        '
        Me.BtnModificarProf.Location = New System.Drawing.Point(155, 199)
        Me.BtnModificarProf.Name = "BtnModificarProf"
        Me.BtnModificarProf.Size = New System.Drawing.Size(75, 22)
        Me.BtnModificarProf.TabIndex = 38
        Me.BtnModificarProf.Text = "Modificar"
        Me.BtnModificarProf.UseVisualStyleBackColor = True
        '
        'BtnAgregarProf
        '
        Me.BtnAgregarProf.Location = New System.Drawing.Point(37, 199)
        Me.BtnAgregarProf.Name = "BtnAgregarProf"
        Me.BtnAgregarProf.Size = New System.Drawing.Size(75, 20)
        Me.BtnAgregarProf.TabIndex = 37
        Me.BtnAgregarProf.Text = "Agregar"
        Me.BtnAgregarProf.UseVisualStyleBackColor = True
        '
        'BtnBuscarDNIProf
        '
        Me.BtnBuscarDNIProf.Location = New System.Drawing.Point(508, 4)
        Me.BtnBuscarDNIProf.Name = "BtnBuscarDNIProf"
        Me.BtnBuscarDNIProf.Size = New System.Drawing.Size(115, 23)
        Me.BtnBuscarDNIProf.TabIndex = 36
        Me.BtnBuscarDNIProf.Text = "Buscar por DNI"
        Me.BtnBuscarDNIProf.UseVisualStyleBackColor = True
        '
        'LbTelProf
        '
        Me.LbTelProf.AutoSize = True
        Me.LbTelProf.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbTelProf.Location = New System.Drawing.Point(34, 132)
        Me.LbTelProf.Name = "LbTelProf"
        Me.LbTelProf.Size = New System.Drawing.Size(49, 13)
        Me.LbTelProf.TabIndex = 35
        Me.LbTelProf.Text = "Telefono"
        '
        'LbEspecialidadProf
        '
        Me.LbEspecialidadProf.AutoSize = True
        Me.LbEspecialidadProf.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbEspecialidadProf.Location = New System.Drawing.Point(36, 96)
        Me.LbEspecialidadProf.Name = "LbEspecialidadProf"
        Me.LbEspecialidadProf.Size = New System.Drawing.Size(67, 13)
        Me.LbEspecialidadProf.TabIndex = 31
        Me.LbEspecialidadProf.Text = "Especialidad"
        '
        'LbFechaIngProf
        '
        Me.LbFechaIngProf.AutoSize = True
        Me.LbFechaIngProf.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbFechaIngProf.Location = New System.Drawing.Point(36, 67)
        Me.LbFechaIngProf.Name = "LbFechaIngProf"
        Me.LbFechaIngProf.Size = New System.Drawing.Size(93, 13)
        Me.LbFechaIngProf.TabIndex = 30
        Me.LbFechaIngProf.Text = "Fecha Nacimiento"
        '
        'LbApellido
        '
        Me.LbApellido.AutoSize = True
        Me.LbApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbApellido.Location = New System.Drawing.Point(296, 37)
        Me.LbApellido.Name = "LbApellido"
        Me.LbApellido.Size = New System.Drawing.Size(44, 13)
        Me.LbApellido.TabIndex = 29
        Me.LbApellido.Text = "Apellido"
        '
        'LbNombreProf
        '
        Me.LbNombreProf.AutoSize = True
        Me.LbNombreProf.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbNombreProf.Location = New System.Drawing.Point(34, 38)
        Me.LbNombreProf.Name = "LbNombreProf"
        Me.LbNombreProf.Size = New System.Drawing.Size(44, 13)
        Me.LbNombreProf.TabIndex = 28
        Me.LbNombreProf.Text = "Nombre"
        '
        'LbDNIProf
        '
        Me.LbDNIProf.AutoSize = True
        Me.LbDNIProf.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbDNIProf.Location = New System.Drawing.Point(36, 4)
        Me.LbDNIProf.Name = "LbDNIProf"
        Me.LbDNIProf.Size = New System.Drawing.Size(26, 13)
        Me.LbDNIProf.TabIndex = 27
        Me.LbDNIProf.Text = "DNI"
        '
        'Profesionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(642, 431)
        Me.Controls.Add(Me.BtnLimpiarCamposProf)
        Me.Controls.Add(Me.BtnSalirProf)
        Me.Controls.Add(Me.DTPFechaIngProf)
        Me.Controls.Add(Me.DGVProfesionales)
        Me.Controls.Add(Me.TxtTelProf)
        Me.Controls.Add(Me.TxtEspecialidad)
        Me.Controls.Add(Me.TxtApeProf)
        Me.Controls.Add(Me.TxtNombreProf)
        Me.Controls.Add(Me.TxtDNIProf)
        Me.Controls.Add(Me.BtnEliminarProf)
        Me.Controls.Add(Me.BtnModificarProf)
        Me.Controls.Add(Me.BtnAgregarProf)
        Me.Controls.Add(Me.BtnBuscarDNIProf)
        Me.Controls.Add(Me.LbTelProf)
        Me.Controls.Add(Me.LbEspecialidadProf)
        Me.Controls.Add(Me.LbFechaIngProf)
        Me.Controls.Add(Me.LbApellido)
        Me.Controls.Add(Me.LbNombreProf)
        Me.Controls.Add(Me.LbDNIProf)
        Me.Name = "Profesionales"
        Me.Text = "AbmProfesionales"
        CType(Me.DGVProfesionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLimpiarCamposProf As Button
    Friend WithEvents BtnSalirProf As Button
    Friend WithEvents DTPFechaIngProf As DateTimePicker
    Friend WithEvents DGVProfesionales As DataGridView
    Friend WithEvents TxtTelProf As TextBox
    Friend WithEvents TxtEspecialidad As TextBox
    Friend WithEvents TxtApeProf As TextBox
    Friend WithEvents TxtNombreProf As TextBox
    Friend WithEvents TxtDNIProf As TextBox
    Friend WithEvents BtnEliminarProf As Button
    Friend WithEvents BtnModificarProf As Button
    Friend WithEvents BtnAgregarProf As Button
    Friend WithEvents BtnBuscarDNIProf As Button
    Friend WithEvents LbTelProf As Label
    Friend WithEvents LbEspecialidadProf As Label
    Friend WithEvents LbFechaIngProf As Label
    Friend WithEvents LbApellido As Label
    Friend WithEvents LbNombreProf As Label
    Friend WithEvents LbDNIProf As Label
End Class
