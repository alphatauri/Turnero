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
        LimpiarDatosPaciente()
    End Sub

    Friend Sub MostrarProfesionales(profesionales As List(Of Profesional))
        profesionales.Sort(New ComparadorProfesionales)
        CBProfesionales.Items.Clear()
        CBProfesionales.DisplayMember = "NombreCompleto"
        CBProfesionales.DataSource = profesionales
    End Sub

    Friend Sub LimpiarControles()
        LimpiarDatosTurno()
        CBProfesionales.Focus()
    End Sub

    Private Sub LimpiarDatosTurno()
        lbHora.Text = ""
        lbPacienteTurno.Text = ""
        lbBox.Text = ""
        lbProfesional.Text = ""
        lbDniPacienteTurno.Text = ""
    End Sub

    Private Sub Turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlador.Inicializar()
    End Sub

    Friend Sub LimpiarDatosPaciente()
        lbPaciente.Text = String.Empty
    End Sub

    Friend Sub MostrarAgenda(agenda As List(Of Turno))
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.Controls.Clear()
        For Each turno In agenda
            Dim btn = New Button
            btn.Text = $"{turno.Hora} - {turno.PacienteNombre}({turno.PacienteDni})"
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Width = 300
            btn.Height = 30
            btn.Tag = turno
            AddHandler btn.Click, AddressOf BtnTurno
            FlowLayoutPanel1.Controls.Add(btn)
        Next
        FlowLayoutPanel1.ResumeLayout()
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

    Private Sub BtnTurno(sender As Object, e As EventArgs)
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

    Private Sub DniPaciente_Leave(sender As Object, e As EventArgs) Handles DniPacienteTB.Leave
        controlador.BuscarPaciente(DniPacienteTB.Text)
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        controlador.AsignarTurnoSeleccionadoAPaciente(pacienteActual)
    End Sub

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click
        controlador.LiberarTurnoSeleccionado()
    End Sub

    Private Sub DniPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DniPacienteTB.KeyPress
        If EsNumero(e.KeyChar) Then
            e.Handled = False
        Else
            SiEsEnterTab(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub CBProfesionales_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBProfesionales.SelectedValueChanged
        Dim profesionalSeleccionado As Profesional = CBProfesionales.SelectedValue
        If profesionalSeleccionado Is Nothing Then
            Return
        End If

        controlador.CambioDeProfesional(profesionalSeleccionado)
    End Sub

    Private Sub DTPFechaAtencion_ValueChanged(sender As Object, e As EventArgs) Handles DTPFechaAtencion.ValueChanged
        Dim fechaSeleccionada As Date = DTPFechaAtencion.Value

        If controlador IsNot Nothing Then
            controlador.CambioDeFecha(fechaSeleccionada)
            DTPFechaAtencion.Focus()
        End If
    End Sub

    Friend Class ComparadorProfesionales : Implements IComparer(Of Profesional)

        Public Function Compare(x As Profesional, y As Profesional) As Integer Implements IComparer(Of Profesional).Compare
            Return x.NombreCompleto.CompareTo(y.NombreCompleto)
        End Function
    End Class
End Class