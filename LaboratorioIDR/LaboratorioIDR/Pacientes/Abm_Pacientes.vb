Imports LaboratorioIDR
Imports LaboratorioIDR.Datos
Imports LaboratorioIDR.Negocio

Public Class Pacientes
    Private ReadOnly controlador As Abm_Pacientes_Controlador

    Public Sub New()
        InitializeComponent()

        controlador = New Abm_Pacientes_Controlador(Me, New ServicioPacientes(New RepositorioPacientes()))
        DTPFechaNac.MaxDate = DateTime.Today
        DTPFechaNac.MinDate = DateTime.Today.AddYears(-130)
    End Sub

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlador.Inicializar()
    End Sub

    Friend Sub inhabilitarAccionEditarEliminar()
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Friend Sub habilitarAccionAgregar()
        BtnAgregar.Enabled = True
    End Sub

    Friend Sub mostrarMensajeOk(mensaje As String)
        MessageBox.Show(mensaje)
    End Sub

    Friend Sub mostrar_Paciente(pacienteActual As Paciente)
        TxtApellido.Text = pacienteActual.Apellido
        TxtNombre.Text = pacienteActual.Nombre
        DTPFechaNac.Value = pacienteActual.Nacimiento
        ComboBoxGenero.SelectedItem = pacienteActual.Genero
        TxtCalle.Text = pacienteActual.DomicilioCalle
        TxtAltura.Text = pacienteActual.DomicilioNumero
        TxtCiudad.Text = pacienteActual.DomicilioCiudad
        TxtPreFijoPac.Text = pacienteActual.TelefonoPrefijo
        TxtTelefono.Text = pacienteActual.TelefonoNumero
        TxtDNI.Text = pacienteActual.Dni
    End Sub

    Friend Sub habilitarAccionEditarEliminar()
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
    End Sub

    Friend Sub habilitar_Campos()
        TxtApellido.Enabled = True
        TxtNombre.Enabled = True
        DTPFechaNac.Enabled = True
        ComboBoxGenero.Enabled = True
        TxtCalle.Enabled = True
        TxtAltura.Enabled = True
        TxtCiudad.Enabled = True
        TxtPreFijoPac.Enabled = True
        TxtTelefono.Enabled = True
    End Sub

    Friend Sub habilitarAccionesAceptarCancelar()
        BtnAgregar.Enabled = True
        BtnAgregar.Text = "Aceptar"
        BtnModificar.Enabled = True
        BtnModificar.Text = "Cancelar"
        BtnEliminar.Enabled = False
        BtnLimpiarCampos.Enabled = False
        BtnSalir.Enabled = True
        BtnBuscarDNI.Enabled = False

        TxtDNI.Focus()
    End Sub

    Friend Sub inhabilitar_Campos()
        ComboBoxGenero.SelectedIndex = 0
        TxtApellido.Enabled = False
        TxtNombre.Enabled = False
        DTPFechaNac.Enabled = False
        ComboBoxGenero.Enabled = False
        TxtCalle.Enabled = False
        TxtAltura.Enabled = False
        TxtCiudad.Enabled = False
        TxtPreFijoPac.Enabled = False
        TxtTelefono.Enabled = False
    End Sub

    Friend Sub inhabilitarAccionesAceptarCancelar()
        BtnAgregar.Enabled = False
        BtnAgregar.Text = "Agregar"
        BtnModificar.Enabled = False
        BtnModificar.Text = "Modificar"
        BtnEliminar.Enabled = False
        BtnLimpiarCampos.Enabled = True
        BtnSalir.Enabled = True
        BtnBuscarDNI.Enabled = True
    End Sub

    Friend Sub limpiar_Campos()
        TxtDNI.Text = Nothing
        TxtNombre.Text = Nothing
        TxtApellido.Text = Nothing
        DTPFechaNac.Value = Today
        TxtCalle.Text = Nothing
        TxtAltura.Text = Nothing
        ComboBoxGenero.SelectedIndex = -1
        TxtCiudad.Text = Nothing
        TxtPreFijoPac.Text = Nothing
        TxtTelefono.Text = Nothing
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscarDNI_Click(sender As Object, e As EventArgs) Handles BtnBuscarDNI.Click
        controlador.BuscarPorDni(TxtDNI.Text)
    End Sub

    Private Sub DTPFechaNac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTPFechaNac.KeyPress
        e.Handled = SiEsEnterTab(e.KeyChar)
    End Sub

    Private Sub CampoSoloLetras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress, TxtApellido.KeyPress, ComboBoxGenero.KeyPress, TxtCalle.KeyPress, TxtCiudad.KeyPress
        If EsLetra(e.KeyChar) Or EsEspacio(e.KeyChar) Then
            e.Handled = False
        Else
            SiEsEnterTab(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub CampoSoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress, TxtPreFijoPac.KeyPress, TxtDNI.KeyPress, TxtAltura.KeyPress
        If EsNumero(e.KeyChar) Then
            e.Handled = False
        Else
            SiEsEnterTab(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If BtnAgregar.Text = "Agregar" Then
            controlador.CommandoAgregar()
        Else
            Dim paciente = cargarPaciente()
            controlador.CommandoGuardar(paciente)
        End If
    End Sub

    Private Function cargarPaciente() As Paciente
        Throw New NotImplementedException()
    End Function
End Class
