Imports LaboratorioIDR
Imports LaboratorioIDR.Datos
Imports LaboratorioIDR.Negocio

Public Class Turnos
    Private ReadOnly controlador As Turnos_Controlador
    Private pacienteActual As Paciente

    Sub New()
        InitializeComponent()

        Me.controlador = New Turnos_Controlador(Me,
                                                New ServicioTurnos(New RepositorioTurnos(), New RepositorioProfesionales()),
                                                New ServicioPacientes(New RepositorioPacientes()))
        DTPFechaAtencion.MinDate = DateTime.Today
        DTPFechaAtencion.MaxDate = DateTime.Today.AddMonths(6)
    End Sub

    Friend Sub MostrarProfesionales(profesionales As List(Of Profesional))
        profesionales.Sort()
        CBProfesionales.Items.Clear()
        CBProfesionales.DisplayMember = "NombreCompleto"
        CBProfesionales.DataSource = profesionales
    End Sub

    Friend Sub LimpiarControles()
        DTPFechaAtencion.Value = DateTime.Today

        LimpiarDatosPaciente()
        CBProfesionales.Focus()
    End Sub

    Private Sub Turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlador.Inicializar()
    End Sub

    Friend Sub LimpiarDatosPaciente()
        lbPaciente.Text = String.Empty
    End Sub

    Friend Sub MostrarAgenda(agenda As List(Of Turno))
        FlowLayoutPanel1.Controls.Clear()
        For Each turno In agenda
            Dim btn = New Button
            btn.Text = $"{turno.Hora} - {turno.PacienteNombre}({turno.PacienteDni})"
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Width = 300
            btn.Height = 30
            btn.Tag = turno
            AddHandler btn.Click, AddressOf btnTurno
            FlowLayoutPanel1.Controls.Add(btn)
        Next
    End Sub

    Friend Sub MostrarDatosTurno(turno As Turno)
        lbHora.Text = turno.Hora
        lbPacienteTurno.Text = turno.PacienteNombre
        lbBox.Text = turno.Consultorio
        lbProfesional.Text = CBProfesionales.Text
        lbDniPacienteTurno.Text = turno.PacienteDni
    End Sub

    Friend Sub HabilitarAsignarTurno()
        btnAsignar.Enabled = True
    End Sub

    Friend Sub DeshabilitarLiberarTurno()
        btnLiberar.Enabled = False
    End Sub

    Friend Sub DeshabilitarAsignarTurno()
        btnAsignar.Enabled = False
    End Sub

    Friend Sub HabilitarLiberarTurno()
        btnLiberar.Enabled = True
    End Sub

    Private Sub btnTurno(sender As Object, e As EventArgs)
        Dim btn As Button = sender
        Dim turno As Turno = btn.Tag
        controlador.TurnoSeleccionado(turno)
    End Sub

    Friend Sub MostrarPaciente(paciente As Paciente)
        Me.pacienteActual = paciente
        lbPaciente.Text = paciente.NombreCompleto
    End Sub

    Friend Sub MostrarMensaje(mensaje As String)
        MessageBox.Show(mensaje)
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        controlador.BuscarPaciente(TextBox1.Text)
        Dim profesional = CType(CBProfesionales.SelectedValue, Profesional)
        Dim fecha = DTPFechaAtencion.Value

        controlador.BuscarTurnos(profesional, fecha)
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        controlador.AsignarTurnoSeleccionadoAPaciente(pacienteActual)
    End Sub
End Class