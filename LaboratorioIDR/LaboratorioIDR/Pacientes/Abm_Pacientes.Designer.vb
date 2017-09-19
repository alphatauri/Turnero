<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pacientes))
        Me.LbDNI = New System.Windows.Forms.Label()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.LbApellido = New System.Windows.Forms.Label()
        Me.LbFechaNac = New System.Windows.Forms.Label()
        Me.LbGenero = New System.Windows.Forms.Label()
        Me.LbCalle = New System.Windows.Forms.Label()
        Me.LbAltura = New System.Windows.Forms.Label()
        Me.LbCiudad = New System.Windows.Forms.Label()
        Me.LbTelefono = New System.Windows.Forms.Label()
        Me.BtnBuscarDNI = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.TxtAltura = New System.Windows.Forms.TextBox()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.DGVPacientes = New System.Windows.Forms.DataGridView()
        Me.DTPFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiarCampos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxGenero = New System.Windows.Forms.ComboBox()
        Me.TxtPreFijoPac = New System.Windows.Forms.TextBox()
        CType(Me.DGVPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbDNI
        '
        Me.LbDNI.AutoSize = True
        Me.LbDNI.ForeColor = System.Drawing.Color.Black
        Me.LbDNI.Location = New System.Drawing.Point(12, 9)
        Me.LbDNI.Name = "LbDNI"
        Me.LbDNI.Size = New System.Drawing.Size(26, 13)
        Me.LbDNI.TabIndex = 9
        Me.LbDNI.Text = "DNI"
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.ForeColor = System.Drawing.Color.Black
        Me.LbNombre.Location = New System.Drawing.Point(389, 41)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(61, 13)
        Me.LbNombre.TabIndex = 12
        Me.LbNombre.Text = "NOMBRES"
        '
        'LbApellido
        '
        Me.LbApellido.AutoSize = True
        Me.LbApellido.ForeColor = System.Drawing.Color.Black
        Me.LbApellido.Location = New System.Drawing.Point(12, 41)
        Me.LbApellido.Name = "LbApellido"
        Me.LbApellido.Size = New System.Drawing.Size(59, 13)
        Me.LbApellido.TabIndex = 12
        Me.LbApellido.Text = "APELLIDO"
        '
        'LbFechaNac
        '
        Me.LbFechaNac.AutoSize = True
        Me.LbFechaNac.ForeColor = System.Drawing.Color.Black
        Me.LbFechaNac.Location = New System.Drawing.Point(12, 73)
        Me.LbFechaNac.Name = "LbFechaNac"
        Me.LbFechaNac.Size = New System.Drawing.Size(130, 13)
        Me.LbFechaNac.TabIndex = 15
        Me.LbFechaNac.Text = "FECHA DE NACIMIENTO"
        '
        'LbGenero
        '
        Me.LbGenero.AutoSize = True
        Me.LbGenero.ForeColor = System.Drawing.Color.Black
        Me.LbGenero.Location = New System.Drawing.Point(12, 105)
        Me.LbGenero.Name = "LbGenero"
        Me.LbGenero.Size = New System.Drawing.Size(36, 13)
        Me.LbGenero.TabIndex = 14
        Me.LbGenero.Text = "SEXO"
        '
        'LbCalle
        '
        Me.LbCalle.AutoSize = True
        Me.LbCalle.ForeColor = System.Drawing.Color.Black
        Me.LbCalle.Location = New System.Drawing.Point(12, 137)
        Me.LbCalle.Name = "LbCalle"
        Me.LbCalle.Size = New System.Drawing.Size(40, 13)
        Me.LbCalle.TabIndex = 15
        Me.LbCalle.Text = "CALLE"
        '
        'LbAltura
        '
        Me.LbAltura.AutoSize = True
        Me.LbAltura.ForeColor = System.Drawing.Color.Black
        Me.LbAltura.Location = New System.Drawing.Point(389, 137)
        Me.LbAltura.Name = "LbAltura"
        Me.LbAltura.Size = New System.Drawing.Size(55, 13)
        Me.LbAltura.TabIndex = 16
        Me.LbAltura.Text = "NUMERO"
        '
        'LbCiudad
        '
        Me.LbCiudad.AutoSize = True
        Me.LbCiudad.ForeColor = System.Drawing.Color.Black
        Me.LbCiudad.Location = New System.Drawing.Point(12, 169)
        Me.LbCiudad.Name = "LbCiudad"
        Me.LbCiudad.Size = New System.Drawing.Size(48, 13)
        Me.LbCiudad.TabIndex = 17
        Me.LbCiudad.Text = "CIUDAD"
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.ForeColor = System.Drawing.Color.Black
        Me.LbTelefono.Location = New System.Drawing.Point(389, 169)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(64, 13)
        Me.LbTelefono.TabIndex = 18
        Me.LbTelefono.Text = "TELEFONO"
        '
        'BtnBuscarDNI
        '
        Me.BtnBuscarDNI.BackColor = System.Drawing.Color.LightSlateGray
        Me.BtnBuscarDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarDNI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBuscarDNI.Location = New System.Drawing.Point(392, 1)
        Me.BtnBuscarDNI.Name = "BtnBuscarDNI"
        Me.BtnBuscarDNI.Size = New System.Drawing.Size(125, 28)
        Me.BtnBuscarDNI.TabIndex = 1
        Me.BtnBuscarDNI.Text = "Buscar por DNI"
        Me.BtnBuscarDNI.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAgregar.Location = New System.Drawing.Point(16, 19)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 11
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnModificar.Location = New System.Drawing.Point(116, 19)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 12
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEliminar.Location = New System.Drawing.Point(216, 19)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 13
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtDNI
        '
        Me.TxtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDNI.Location = New System.Drawing.Point(146, 6)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(221, 20)
        Me.TxtDNI.TabIndex = 0
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(464, 38)
        Me.TxtNombre.MaxLength = 20
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(234, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(146, 38)
        Me.TxtApellido.MaxLength = 15
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(221, 20)
        Me.TxtApellido.TabIndex = 2
        '
        'TxtCalle
        '
        Me.TxtCalle.Location = New System.Drawing.Point(146, 134)
        Me.TxtCalle.MaxLength = 20
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(221, 20)
        Me.TxtCalle.TabIndex = 6
        '
        'TxtAltura
        '
        Me.TxtAltura.Location = New System.Drawing.Point(464, 134)
        Me.TxtAltura.MaxLength = 5
        Me.TxtAltura.Name = "TxtAltura"
        Me.TxtAltura.Size = New System.Drawing.Size(53, 20)
        Me.TxtAltura.TabIndex = 7
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(146, 166)
        Me.TxtCiudad.MaxLength = 20
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(221, 20)
        Me.TxtCiudad.TabIndex = 8
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(549, 166)
        Me.TxtTelefono.MaxLength = 9
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefono.TabIndex = 10
        '
        'DGVPacientes
        '
        Me.DGVPacientes.AllowUserToAddRows = False
        Me.DGVPacientes.AllowUserToDeleteRows = False
        Me.DGVPacientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGVPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPacientes.Location = New System.Drawing.Point(30, 267)
        Me.DGVPacientes.Name = "DGVPacientes"
        Me.DGVPacientes.Size = New System.Drawing.Size(660, 188)
        Me.DGVPacientes.TabIndex = 16
        '
        'DTPFechaNac
        '
        Me.DTPFechaNac.Location = New System.Drawing.Point(146, 67)
        Me.DTPFechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPFechaNac.Name = "DTPFechaNac"
        Me.DTPFechaNac.Size = New System.Drawing.Size(221, 20)
        Me.DTPFechaNac.TabIndex = 4
        Me.DTPFechaNac.Value = New Date(2017, 7, 25, 23, 59, 59, 0)
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSalir.Location = New System.Drawing.Point(569, 19)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiarCampos
        '
        Me.BtnLimpiarCampos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLimpiarCampos.Location = New System.Drawing.Point(461, 19)
        Me.BtnLimpiarCampos.Name = "BtnLimpiarCampos"
        Me.BtnLimpiarCampos.Size = New System.Drawing.Size(89, 23)
        Me.BtnLimpiarCampos.TabIndex = 14
        Me.BtnLimpiarCampos.Text = "Limpiar Campos"
        Me.BtnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiarCampos)
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(30, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 57)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(523, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "-"
        '
        'ComboBoxGenero
        '
        Me.ComboBoxGenero.FormattingEnabled = True
        Me.ComboBoxGenero.Items.AddRange(New Object() {"Masculino", "Femenino", "Indefinido"})
        Me.ComboBoxGenero.Location = New System.Drawing.Point(146, 102)
        Me.ComboBoxGenero.Name = "ComboBoxGenero"
        Me.ComboBoxGenero.Size = New System.Drawing.Size(221, 21)
        Me.ComboBoxGenero.TabIndex = 5
        '
        'TxtPreFijoPac
        '
        Me.TxtPreFijoPac.Location = New System.Drawing.Point(464, 166)
        Me.TxtPreFijoPac.Name = "TxtPreFijoPac"
        Me.TxtPreFijoPac.Size = New System.Drawing.Size(53, 20)
        Me.TxtPreFijoPac.TabIndex = 9
        '
        'Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(724, 465)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.BtnBuscarDNI)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.DTPFechaNac)
        Me.Controls.Add(Me.ComboBoxGenero)
        Me.Controls.Add(Me.TxtCalle)
        Me.Controls.Add(Me.TxtAltura)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.TxtPreFijoPac)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVPacientes)
        Me.Controls.Add(Me.LbTelefono)
        Me.Controls.Add(Me.LbCiudad)
        Me.Controls.Add(Me.LbAltura)
        Me.Controls.Add(Me.LbCalle)
        Me.Controls.Add(Me.LbGenero)
        Me.Controls.Add(Me.LbFechaNac)
        Me.Controls.Add(Me.LbApellido)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.LbDNI)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Pacientes"
        CType(Me.DGVPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbDNI As Label
    Friend WithEvents LbNombre As Label
    Friend WithEvents LbApellido As Label
    Friend WithEvents LbFechaNac As Label
    Friend WithEvents LbGenero As Label
    Friend WithEvents LbCalle As Label
    Friend WithEvents LbAltura As Label
    Friend WithEvents LbCiudad As Label
    Friend WithEvents LbTelefono As Label
    Friend WithEvents BtnBuscarDNI As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents TxtAltura As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents DGVPacientes As DataGridView
    Friend WithEvents DTPFechaNac As DateTimePicker
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnLimpiarCampos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxGenero As ComboBox
    Friend WithEvents TxtPreFijoPac As TextBox
End Class
