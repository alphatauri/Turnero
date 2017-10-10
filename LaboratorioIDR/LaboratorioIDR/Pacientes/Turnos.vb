Imports LaboratorioIDR
Imports LaboratorioIDR.Datos
Imports LaboratorioIDR.Negocio

Public Class Turnos
    Private ReadOnly controlador As Turnos_Controlador

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
            btn.Width = 260
            btn.Height = 30
            FlowLayoutPanel1.Controls.Add(btn)
        Next
    End Sub

    Friend Sub MostrarPaciente(paciente As Paciente)
        lbPaciente.Text = paciente.NombreCompleto
    End Sub

    Friend Sub MostrarMensaje(mensaje As String)
        MessageBox.Show(mensaje)
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Dim paciente = controlador.BuscarPaciente(TextBox1.Text)
        Dim profesional = CType(CBProfesionales.SelectedValue, Profesional)
        Dim fecha = DTPFechaAtencion.Value

        controlador.BuscarTurnos(profesional, fecha)
    End Sub
End Class