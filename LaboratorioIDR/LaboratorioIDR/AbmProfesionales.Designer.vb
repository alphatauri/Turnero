<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AbmProfesionales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbmProfesionales))
        Me.LbDNIProf = New System.Windows.Forms.Label()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.LbApellidoProf = New System.Windows.Forms.Label()
        Me.LbFechaIngProf = New System.Windows.Forms.Label()
        Me.LbTelProf = New System.Windows.Forms.Label()
        Me.TxtDNIProf = New System.Windows.Forms.TextBox()
        Me.TxtNomProf = New System.Windows.Forms.TextBox()
        Me.TxtApeProf = New System.Windows.Forms.TextBox()
        Me.TxtTelProf = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnBuscarDNIProf = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DGVProfesionales = New System.Windows.Forms.DataGridView()
        Me.BtnLimpiarCampos = New System.Windows.Forms.Button()
        Me.DTPProfesionales = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPrefijoProf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVProfesionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbDNIProf
        '
        Me.LbDNIProf.AutoSize = True
        Me.LbDNIProf.ForeColor = System.Drawing.Color.Black
        Me.LbDNIProf.Location = New System.Drawing.Point(9, 18)
        Me.LbDNIProf.Name = "LbDNIProf"
        Me.LbDNIProf.Size = New System.Drawing.Size(26, 13)
        Me.LbDNIProf.TabIndex = 9
        Me.LbDNIProf.Text = "DNI"
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.ForeColor = System.Drawing.Color.Black
        Me.LbNombre.Location = New System.Drawing.Point(283, 57)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(61, 13)
        Me.LbNombre.TabIndex = 12
        Me.LbNombre.Text = "NOMBRES"
        '
        'LbApellidoProf
        '
        Me.LbApellidoProf.AutoSize = True
        Me.LbApellidoProf.ForeColor = System.Drawing.Color.Black
        Me.LbApellidoProf.Location = New System.Drawing.Point(9, 57)
        Me.LbApellidoProf.Name = "LbApellidoProf"
        Me.LbApellidoProf.Size = New System.Drawing.Size(59, 13)
        Me.LbApellidoProf.TabIndex = 10
        Me.LbApellidoProf.Text = "APELLIDO"
        '
        'LbFechaIngProf
        '
        Me.LbFechaIngProf.AutoSize = True
        Me.LbFechaIngProf.ForeColor = System.Drawing.Color.Black
        Me.LbFechaIngProf.Location = New System.Drawing.Point(283, 100)
        Me.LbFechaIngProf.Name = "LbFechaIngProf"
        Me.LbFechaIngProf.Size = New System.Drawing.Size(112, 13)
        Me.LbFechaIngProf.TabIndex = 13
        Me.LbFechaIngProf.Text = "FECHA DE INGRESO"
        '
        'LbTelProf
        '
        Me.LbTelProf.AutoSize = True
        Me.LbTelProf.ForeColor = System.Drawing.Color.Black
        Me.LbTelProf.Location = New System.Drawing.Point(9, 100)
        Me.LbTelProf.Name = "LbTelProf"
        Me.LbTelProf.Size = New System.Drawing.Size(64, 13)
        Me.LbTelProf.TabIndex = 11
        Me.LbTelProf.Text = "TELEFONO"
        '
        'TxtDNIProf
        '
        Me.TxtDNIProf.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtDNIProf.Location = New System.Drawing.Point(74, 15)
        Me.TxtDNIProf.MaxLength = 8
        Me.TxtDNIProf.Name = "TxtDNIProf"
        Me.TxtDNIProf.Size = New System.Drawing.Size(184, 20)
        Me.TxtDNIProf.TabIndex = 0
        '
        'TxtNomProf
        '
        Me.TxtNomProf.Location = New System.Drawing.Point(378, 54)
        Me.TxtNomProf.MaxLength = 20
        Me.TxtNomProf.Name = "TxtNomProf"
        Me.TxtNomProf.Size = New System.Drawing.Size(229, 20)
        Me.TxtNomProf.TabIndex = 2
        '
        'TxtApeProf
        '
        Me.TxtApeProf.Location = New System.Drawing.Point(74, 54)
        Me.TxtApeProf.MaxLength = 15
        Me.TxtApeProf.Name = "TxtApeProf"
        Me.TxtApeProf.Size = New System.Drawing.Size(184, 20)
        Me.TxtApeProf.TabIndex = 1
        '
        'TxtTelProf
        '
        Me.TxtTelProf.Location = New System.Drawing.Point(137, 97)
        Me.TxtTelProf.MaxLength = 9
        Me.TxtTelProf.Name = "TxtTelProf"
        Me.TxtTelProf.Size = New System.Drawing.Size(121, 20)
        Me.TxtTelProf.TabIndex = 4
        '
        'BtnAgregar
        '
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAgregar.Location = New System.Drawing.Point(6, 23)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnModificar.Location = New System.Drawing.Point(102, 23)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEliminar.Location = New System.Drawing.Point(201, 23)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnBuscarDNIProf
        '
        Me.BtnBuscarDNIProf.BackColor = System.Drawing.Color.LightSlateGray
        Me.BtnBuscarDNIProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarDNIProf.Location = New System.Drawing.Point(286, 12)
        Me.BtnBuscarDNIProf.Name = "BtnBuscarDNIProf"
        Me.BtnBuscarDNIProf.Size = New System.Drawing.Size(125, 28)
        Me.BtnBuscarDNIProf.TabIndex = 8
        Me.BtnBuscarDNIProf.Text = "Buscar por DNI"
        Me.BtnBuscarDNIProf.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSalir.Location = New System.Drawing.Point(483, 23)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DGVProfesionales
        '
        Me.DGVProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProfesionales.Location = New System.Drawing.Point(12, 239)
        Me.DGVProfesionales.Name = "DGVProfesionales"
        Me.DGVProfesionales.Size = New System.Drawing.Size(595, 148)
        Me.DGVProfesionales.TabIndex = 7
        '
        'BtnLimpiarCampos
        '
        Me.BtnLimpiarCampos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLimpiarCampos.Location = New System.Drawing.Point(369, 23)
        Me.BtnLimpiarCampos.Name = "BtnLimpiarCampos"
        Me.BtnLimpiarCampos.Size = New System.Drawing.Size(92, 23)
        Me.BtnLimpiarCampos.TabIndex = 3
        Me.BtnLimpiarCampos.Text = "Limpiar Campos"
        Me.BtnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'DTPProfesionales
        '
        Me.DTPProfesionales.Location = New System.Drawing.Point(407, 95)
        Me.DTPProfesionales.MaxDate = New Date(2020, 7, 25, 0, 0, 0, 0)
        Me.DTPProfesionales.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DTPProfesionales.Name = "DTPProfesionales"
        Me.DTPProfesionales.Size = New System.Drawing.Size(200, 20)
        Me.DTPProfesionales.TabIndex = 5
        Me.DTPProfesionales.Value = New Date(2017, 7, 3, 18, 57, 21, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiarCampos)
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 59)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'TxtPrefijoProf
        '
        Me.TxtPrefijoProf.Location = New System.Drawing.Point(74, 97)
        Me.TxtPrefijoProf.MaxLength = 5
        Me.TxtPrefijoProf.Name = "TxtPrefijoProf"
        Me.TxtPrefijoProf.Size = New System.Drawing.Size(41, 20)
        Me.TxtPrefijoProf.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "-"
        '
        'AbmProfesionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(631, 408)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPrefijoProf)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DTPProfesionales)
        Me.Controls.Add(Me.DGVProfesionales)
        Me.Controls.Add(Me.BtnBuscarDNIProf)
        Me.Controls.Add(Me.TxtTelProf)
        Me.Controls.Add(Me.TxtApeProf)
        Me.Controls.Add(Me.TxtNomProf)
        Me.Controls.Add(Me.TxtDNIProf)
        Me.Controls.Add(Me.LbTelProf)
        Me.Controls.Add(Me.LbFechaIngProf)
        Me.Controls.Add(Me.LbApellidoProf)
        Me.Controls.Add(Me.LbNombre)
        Me.Controls.Add(Me.LbDNIProf)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AbmProfesionales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Profesionales"
        CType(Me.DGVProfesionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbDNIProf As Label
    Friend WithEvents LbNombre As Label
    Friend WithEvents LbApellidoProf As Label
    Friend WithEvents LbFechaIngProf As Label
    Friend WithEvents LbTelProf As Label
    Friend WithEvents TxtDNIProf As TextBox
    Friend WithEvents TxtNomProf As TextBox
    Friend WithEvents TxtApeProf As TextBox
    Friend WithEvents TxtTelProf As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnBuscarDNIProf As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DGVProfesionales As DataGridView
    Friend WithEvents BtnLimpiarCampos As Button
    Friend WithEvents DTPProfesionales As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPrefijoProf As TextBox
    Friend WithEvents Label1 As Label
End Class
