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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbPaciente = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
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
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(349, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 277)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Turno"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Asignar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(245, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Liberar"
        Me.Button2.UseVisualStyleBackColor = True
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
