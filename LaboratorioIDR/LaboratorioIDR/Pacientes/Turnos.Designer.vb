<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turnos
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
        Me.CBProfesionales = New System.Windows.Forms.ComboBox()
        Me.DTPFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.LbFecDsdPlan = New System.Windows.Forms.Label()
        Me.LbProfPlan = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbPaciente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbBox = New System.Windows.Forms.Label()
        Me.lbProfesional = New System.Windows.Forms.Label()
        Me.lbDniPacienteTurno = New System.Windows.Forms.Label()
        Me.lbPacienteTurno = New System.Windows.Forms.Label()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBProfesionales
        '
        Me.CBProfesionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProfesionales.FormattingEnabled = True
        Me.CBProfesionales.Location = New System.Drawing.Point(125, 6)
        Me.CBProfesionales.Name = "CBProfesionales"
        Me.CBProfesionales.Size = New System.Drawing.Size(218, 21)
        Me.CBProfesionales.TabIndex = 20
        '
        'DTPFechaAtencion
        '
        Me.DTPFechaAtencion.CustomFormat = "dd/MM/yyyy"
        Me.DTPFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFechaAtencion.Location = New System.Drawing.Point(125, 33)
        Me.DTPFechaAtencion.MinDate = New Date(2017, 6, 24, 0, 0, 0, 0)
        Me.DTPFechaAtencion.Name = "DTPFechaAtencion"
        Me.DTPFechaAtencion.Size = New System.Drawing.Size(218, 20)
        Me.DTPFechaAtencion.TabIndex = 21
        Me.DTPFechaAtencion.Value = New Date(2017, 6, 24, 20, 28, 35, 0)
        '
        'LbFecDsdPlan
        '
        Me.LbFecDsdPlan.AutoSize = True
        Me.LbFecDsdPlan.Location = New System.Drawing.Point(12, 37)
        Me.LbFecDsdPlan.Name = "LbFecDsdPlan"
        Me.LbFecDsdPlan.Size = New System.Drawing.Size(82, 13)
        Me.LbFecDsdPlan.TabIndex = 23
        Me.LbFecDsdPlan.Text = "Fecha Atención"
        '
        'LbProfPlan
        '
        Me.LbProfPlan.AutoSize = True
        Me.LbProfPlan.Location = New System.Drawing.Point(12, 9)
        Me.LbProfPlan.Name = "LbProfPlan"
        Me.LbProfPlan.Size = New System.Drawing.Size(59, 13)
        Me.LbProfPlan.TabIndex = 22
        Me.LbProfPlan.Text = "Profesional"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Documento Paciente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(125, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(218, 20)
        Me.TextBox1.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbPaciente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(349, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 73)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paciente"
        '
        'lbPaciente
        '
        Me.lbPaciente.AutoSize = True
        Me.lbPaciente.Location = New System.Drawing.Point(82, 27)
        Me.lbPaciente.Name = "lbPaciente"
        Me.lbPaciente.Size = New System.Drawing.Size(57, 13)
        Me.lbPaciente.TabIndex = 1
        Me.lbPaciente.Text = "lbPaciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 85)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(328, 277)
        Me.FlowLayoutPanel1.TabIndex = 28
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbBox)
        Me.GroupBox2.Controls.Add(Me.lbProfesional)
        Me.GroupBox2.Controls.Add(Me.lbDniPacienteTurno)
        Me.GroupBox2.Controls.Add(Me.lbPacienteTurno)
        Me.GroupBox2.Controls.Add(Me.lbHora)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnLiberar)
        Me.GroupBox2.Controls.Add(Me.btnAsignar)
        Me.GroupBox2.Location = New System.Drawing.Point(349, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 277)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Turno"
        '
        'lbBox
        '
        Me.lbBox.AutoSize = True
        Me.lbBox.Location = New System.Drawing.Point(94, 149)
        Me.lbBox.Name = "lbBox"
        Me.lbBox.Size = New System.Drawing.Size(45, 13)
        Me.lbBox.TabIndex = 11
        Me.lbBox.Text = "Label12"
        '
        'lbProfesional
        '
        Me.lbProfesional.AutoSize = True
        Me.lbProfesional.Location = New System.Drawing.Point(94, 121)
        Me.lbProfesional.Name = "lbProfesional"
        Me.lbProfesional.Size = New System.Drawing.Size(45, 13)
        Me.lbProfesional.TabIndex = 10
        Me.lbProfesional.Text = "Label11"
        '
        'lbDniPacienteTurno
        '
        Me.lbDniPacienteTurno.AutoSize = True
        Me.lbDniPacienteTurno.Location = New System.Drawing.Point(94, 93)
        Me.lbDniPacienteTurno.Name = "lbDniPacienteTurno"
        Me.lbDniPacienteTurno.Size = New System.Drawing.Size(45, 13)
        Me.lbDniPacienteTurno.TabIndex = 9
        Me.lbDniPacienteTurno.Text = "Label10"
        '
        'lbPacienteTurno
        '
        Me.lbPacienteTurno.AutoSize = True
        Me.lbPacienteTurno.Location = New System.Drawing.Point(94, 63)
        Me.lbPacienteTurno.Name = "lbPacienteTurno"
        Me.lbPacienteTurno.Size = New System.Drawing.Size(39, 13)
        Me.lbPacienteTurno.TabIndex = 8
        Me.lbPacienteTurno.Text = "Label9"
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Location = New System.Drawing.Point(94, 33)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(39, 13)
        Me.lbHora.TabIndex = 7
        Me.lbHora.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Box"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Profesional"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dni"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hora"
        '
        'btnLiberar
        '
        Me.btnLiberar.Location = New System.Drawing.Point(245, 241)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(75, 23)
        Me.btnLiberar.TabIndex = 1
        Me.btnLiberar.Text = "Liberar"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(164, 241)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(75, 23)
        Me.btnAsignar.TabIndex = 0
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'Turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 374)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CBProfesionales)
        Me.Controls.Add(Me.DTPFechaAtencion)
        Me.Controls.Add(Me.LbFecDsdPlan)
        Me.Controls.Add(Me.LbProfPlan)
        Me.Name = "Turnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBProfesionales As ComboBox
    Friend WithEvents DTPFechaAtencion As DateTimePicker
    Friend WithEvents LbFecDsdPlan As Label
    Friend WithEvents LbProfPlan As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbPaciente As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLiberar As Button
    Friend WithEvents btnAsignar As Button
    Friend WithEvents lbBox As Label
    Friend WithEvents lbProfesional As Label
    Friend WithEvents lbDniPacienteTurno As Label
    Friend WithEvents lbPacienteTurno As Label
    Friend WithEvents lbHora As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
