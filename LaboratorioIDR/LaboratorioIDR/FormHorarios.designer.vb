<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHorarios
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
        Me.LbProfPlan = New System.Windows.Forms.Label()
        Me.LbBoxPlan = New System.Windows.Forms.Label()
        Me.LbFecDsdPlan = New System.Windows.Forms.Label()
        Me.LbFecHstPlan = New System.Windows.Forms.Label()
        Me.LbHoraDsdPlan = New System.Windows.Forms.Label()
        Me.LbHoraHstPlan = New System.Windows.Forms.Label()
        Me.LbSlot = New System.Windows.Forms.Label()
        Me.DTPFecDsdPlan = New System.Windows.Forms.DateTimePicker()
        Me.DTPFecHstPlan = New System.Windows.Forms.DateTimePicker()
        Me.DTPHoraDsdPlan = New System.Windows.Forms.DateTimePicker()
        Me.DTPHoraHstPlan = New System.Windows.Forms.DateTimePicker()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.NUDSlot = New System.Windows.Forms.NumericUpDown()
        Me.CBLunes = New System.Windows.Forms.CheckBox()
        Me.CBMartes = New System.Windows.Forms.CheckBox()
        Me.CBMiercoles = New System.Windows.Forms.CheckBox()
        Me.CBJueves = New System.Windows.Forms.CheckBox()
        Me.CBViernes = New System.Windows.Forms.CheckBox()
        Me.CBProf = New System.Windows.Forms.ComboBox()
        Me.CBConsultorio = New System.Windows.Forms.ComboBox()
        Me.DGVAgenda = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.NUDSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbProfPlan
        '
        Me.LbProfPlan.AutoSize = True
        Me.LbProfPlan.Location = New System.Drawing.Point(12, 35)
        Me.LbProfPlan.Name = "LbProfPlan"
        Me.LbProfPlan.Size = New System.Drawing.Size(82, 13)
        Me.LbProfPlan.TabIndex = 17
        Me.LbProfPlan.Text = "PROFESIONAL"
        '
        'LbBoxPlan
        '
        Me.LbBoxPlan.AutoSize = True
        Me.LbBoxPlan.Location = New System.Drawing.Point(465, 38)
        Me.LbBoxPlan.Name = "LbBoxPlan"
        Me.LbBoxPlan.Size = New System.Drawing.Size(105, 13)
        Me.LbBoxPlan.TabIndex = 20
        Me.LbBoxPlan.Text = "BOX DE ATENCION"
        '
        'LbFecDsdPlan
        '
        Me.LbFecDsdPlan.AutoSize = True
        Me.LbFecDsdPlan.Location = New System.Drawing.Point(12, 93)
        Me.LbFecDsdPlan.Name = "LbFecDsdPlan"
        Me.LbFecDsdPlan.Size = New System.Drawing.Size(60, 13)
        Me.LbFecDsdPlan.TabIndex = 19
        Me.LbFecDsdPlan.Text = "DESDE EL"
        '
        'LbFecHstPlan
        '
        Me.LbFecHstPlan.AutoSize = True
        Me.LbFecHstPlan.Location = New System.Drawing.Point(381, 93)
        Me.LbFecHstPlan.Name = "LbFecHstPlan"
        Me.LbFecHstPlan.Size = New System.Drawing.Size(59, 13)
        Me.LbFecHstPlan.TabIndex = 21
        Me.LbFecHstPlan.Text = "HASTA EL"
        '
        'LbHoraDsdPlan
        '
        Me.LbHoraDsdPlan.AutoSize = True
        Me.LbHoraDsdPlan.Location = New System.Drawing.Point(96, 169)
        Me.LbHoraDsdPlan.Name = "LbHoraDsdPlan"
        Me.LbHoraDsdPlan.Size = New System.Drawing.Size(98, 13)
        Me.LbHoraDsdPlan.TabIndex = 24
        Me.LbHoraDsdPlan.Text = "A PARTIR DE LAS"
        '
        'LbHoraHstPlan
        '
        Me.LbHoraHstPlan.AutoSize = True
        Me.LbHoraHstPlan.Location = New System.Drawing.Point(285, 170)
        Me.LbHoraHstPlan.Name = "LbHoraHstPlan"
        Me.LbHoraHstPlan.Size = New System.Drawing.Size(66, 13)
        Me.LbHoraHstPlan.TabIndex = 25
        Me.LbHoraHstPlan.Text = "HASTA LAS"
        '
        'LbSlot
        '
        Me.LbSlot.AutoSize = True
        Me.LbSlot.Location = New System.Drawing.Point(465, 170)
        Me.LbSlot.Name = "LbSlot"
        Me.LbSlot.Size = New System.Drawing.Size(121, 13)
        Me.LbSlot.TabIndex = 26
        Me.LbSlot.Text = "LA CONSULTA DURA.."
        '
        'DTPFecDsdPlan
        '
        Me.DTPFecDsdPlan.CustomFormat = "dd/MM/yyyy"
        Me.DTPFecDsdPlan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFecDsdPlan.Location = New System.Drawing.Point(117, 87)
        Me.DTPFecDsdPlan.MinDate = New Date(2017, 6, 24, 0, 0, 0, 0)
        Me.DTPFecDsdPlan.Name = "DTPFecDsdPlan"
        Me.DTPFecDsdPlan.Size = New System.Drawing.Size(218, 20)
        Me.DTPFecDsdPlan.TabIndex = 2
        Me.DTPFecDsdPlan.Value = New Date(2017, 6, 24, 20, 28, 35, 0)
        '
        'DTPFecHstPlan
        '
        Me.DTPFecHstPlan.CustomFormat = "dd/MM/yyyy"
        Me.DTPFecHstPlan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFecHstPlan.Location = New System.Drawing.Point(484, 87)
        Me.DTPFecHstPlan.MinDate = New Date(2017, 6, 24, 0, 0, 0, 0)
        Me.DTPFecHstPlan.Name = "DTPFecHstPlan"
        Me.DTPFecHstPlan.Size = New System.Drawing.Size(217, 20)
        Me.DTPFecHstPlan.TabIndex = 3
        Me.DTPFecHstPlan.Value = New Date(2017, 6, 24, 20, 28, 46, 0)
        '
        'DTPHoraDsdPlan
        '
        Me.DTPHoraDsdPlan.CustomFormat = "HH:mm"
        Me.DTPHoraDsdPlan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPHoraDsdPlan.Location = New System.Drawing.Point(205, 167)
        Me.DTPHoraDsdPlan.Name = "DTPHoraDsdPlan"
        Me.DTPHoraDsdPlan.Size = New System.Drawing.Size(51, 20)
        Me.DTPHoraDsdPlan.TabIndex = 9
        '
        'DTPHoraHstPlan
        '
        Me.DTPHoraHstPlan.CustomFormat = "HH:mm"
        Me.DTPHoraHstPlan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPHoraHstPlan.Location = New System.Drawing.Point(360, 167)
        Me.DTPHoraHstPlan.Name = "DTPHoraHstPlan"
        Me.DTPHoraHstPlan.Size = New System.Drawing.Size(54, 20)
        Me.DTPHoraHstPlan.TabIndex = 10
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(239, 216)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 13
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(561, 216)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 15
        Me.BtnLimpiar.Text = "Limpiar Campos"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'NUDSlot
        '
        Me.NUDSlot.Location = New System.Drawing.Point(598, 167)
        Me.NUDSlot.Name = "NUDSlot"
        Me.NUDSlot.Size = New System.Drawing.Size(38, 20)
        Me.NUDSlot.TabIndex = 11
        '
        'CBLunes
        '
        Me.CBLunes.AutoSize = True
        Me.CBLunes.Location = New System.Drawing.Point(201, 125)
        Me.CBLunes.Name = "CBLunes"
        Me.CBLunes.Size = New System.Drawing.Size(62, 17)
        Me.CBLunes.TabIndex = 4
        Me.CBLunes.Text = "LUNES"
        Me.CBLunes.UseVisualStyleBackColor = True
        '
        'CBMartes
        '
        Me.CBMartes.AutoSize = True
        Me.CBMartes.Location = New System.Drawing.Point(302, 125)
        Me.CBMartes.Name = "CBMartes"
        Me.CBMartes.Size = New System.Drawing.Size(71, 17)
        Me.CBMartes.TabIndex = 5
        Me.CBMartes.Text = "MARTES"
        Me.CBMartes.UseVisualStyleBackColor = True
        '
        'CBMiercoles
        '
        Me.CBMiercoles.AutoSize = True
        Me.CBMiercoles.Location = New System.Drawing.Point(405, 125)
        Me.CBMiercoles.Name = "CBMiercoles"
        Me.CBMiercoles.Size = New System.Drawing.Size(88, 17)
        Me.CBMiercoles.TabIndex = 6
        Me.CBMiercoles.Text = "MIERCOLES"
        Me.CBMiercoles.UseVisualStyleBackColor = True
        '
        'CBJueves
        '
        Me.CBJueves.AutoSize = True
        Me.CBJueves.Location = New System.Drawing.Point(525, 125)
        Me.CBJueves.Name = "CBJueves"
        Me.CBJueves.Size = New System.Drawing.Size(67, 17)
        Me.CBJueves.TabIndex = 7
        Me.CBJueves.Text = "JUEVES"
        Me.CBJueves.UseVisualStyleBackColor = True
        '
        'CBViernes
        '
        Me.CBViernes.AutoSize = True
        Me.CBViernes.Location = New System.Drawing.Point(647, 125)
        Me.CBViernes.Name = "CBViernes"
        Me.CBViernes.Size = New System.Drawing.Size(73, 17)
        Me.CBViernes.TabIndex = 8
        Me.CBViernes.Text = "VIERNES"
        Me.CBViernes.UseVisualStyleBackColor = True
        '
        'CBProf
        '
        Me.CBProf.FormattingEnabled = True
        Me.CBProf.Location = New System.Drawing.Point(135, 32)
        Me.CBProf.Name = "CBProf"
        Me.CBProf.Size = New System.Drawing.Size(121, 21)
        Me.CBProf.TabIndex = 0
        '
        'CBConsultorio
        '
        Me.CBConsultorio.FormattingEnabled = True
        Me.CBConsultorio.Items.AddRange(New Object() {"Box 1", "Box 2", "Box 3", "Box 4"})
        Me.CBConsultorio.Location = New System.Drawing.Point(599, 35)
        Me.CBConsultorio.Name = "CBConsultorio"
        Me.CBConsultorio.Size = New System.Drawing.Size(121, 21)
        Me.CBConsultorio.TabIndex = 1
        '
        'DGVAgenda
        '
        Me.DGVAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAgenda.Location = New System.Drawing.Point(12, 262)
        Me.DGVAgenda.Name = "DGVAgenda"
        Me.DGVAgenda.Size = New System.Drawing.Size(721, 150)
        Me.DGVAgenda.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Días de la semana de atención"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "El Profesional Atenderá "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "En el Horario "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(644, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "MINUTOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "HS."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "HS."
        '
        'FormHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 424)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVAgenda)
        Me.Controls.Add(Me.CBConsultorio)
        Me.Controls.Add(Me.CBProf)
        Me.Controls.Add(Me.CBViernes)
        Me.Controls.Add(Me.CBJueves)
        Me.Controls.Add(Me.CBMiercoles)
        Me.Controls.Add(Me.CBMartes)
        Me.Controls.Add(Me.CBLunes)
        Me.Controls.Add(Me.NUDSlot)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DTPHoraHstPlan)
        Me.Controls.Add(Me.DTPHoraDsdPlan)
        Me.Controls.Add(Me.DTPFecHstPlan)
        Me.Controls.Add(Me.DTPFecDsdPlan)
        Me.Controls.Add(Me.LbSlot)
        Me.Controls.Add(Me.LbHoraHstPlan)
        Me.Controls.Add(Me.LbHoraDsdPlan)
        Me.Controls.Add(Me.LbFecHstPlan)
        Me.Controls.Add(Me.LbFecDsdPlan)
        Me.Controls.Add(Me.LbBoxPlan)
        Me.Controls.Add(Me.LbProfPlan)
        Me.Name = "FormHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planificador de Horarios"
        CType(Me.NUDSlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbProfPlan As Label
    Friend WithEvents LbBoxPlan As Label
    Friend WithEvents LbFecDsdPlan As Label
    Friend WithEvents LbFecHstPlan As Label
    Friend WithEvents LbHoraDsdPlan As Label
    Friend WithEvents LbHoraHstPlan As Label
    Friend WithEvents LbSlot As Label
    Friend WithEvents DTPFecDsdPlan As DateTimePicker
    Friend WithEvents DTPFecHstPlan As DateTimePicker
    Friend WithEvents DTPHoraDsdPlan As DateTimePicker
    Friend WithEvents DTPHoraHstPlan As DateTimePicker
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents NUDSlot As NumericUpDown
    Friend WithEvents CBLunes As CheckBox
    Friend WithEvents CBMartes As CheckBox
    Friend WithEvents CBMiercoles As CheckBox
    Friend WithEvents CBJueves As CheckBox
    Friend WithEvents CBViernes As CheckBox
    Friend WithEvents CBProf As ComboBox
    Friend WithEvents CBConsultorio As ComboBox
    Friend WithEvents DGVAgenda As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
