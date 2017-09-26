Imports LaboratorioIDR
Imports LaboratorioIDR.Datos
Imports LaboratorioIDR.Negocio

Public Class Pacientes
    Private ReadOnly controlador As Abm_Pacientes_Controlador
    Private ReadOnly dbPacientes As New BindingSource()

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
        BtnAgregar.Text = "Agregar"
        BtnAgregar.Enabled = True
    End Sub

    Friend Sub mostrarMensajeOk(mensaje As String)
        MessageBox.Show(Me, mensaje, "Mensaje")
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

    Friend Sub mostrarListaPacientes(pacientes As List(Of Paciente))
        dbPacientes.DataSource = pacientes
        DGVPacientes.DataSource = dbPacientes
        dbPacientes.ResetBindings(False)

        Dim nombres = New List(Of String) From {"Column1", "Column2", "Column3"}

        Dim columnas = DGVPacientes.Columns.GetColumnCount(DataGridViewElementStates.None) - 1
        For index = columnas To 0 Step -1
            If (Not nombres.Contains(DGVPacientes.Columns.Item(index).Name)) Then
                DGVPacientes.Columns.RemoveAt(index)
            End If
        Next
    End Sub

    Friend Sub inhabilitar_CampoDNI()
        TxtDNI.Enabled = False
    End Sub

    Friend Sub habilitarAccionEditarEliminar()
        BtnModificar.Text = "Modificar"
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
        DGVPacientes.Enabled = False
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
    End Sub

    Friend Sub inhabilitar_Campos()
        TxtDNI.Enabled = True
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
        DGVPacientes.Enabled = True
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

    Friend Function mostrarMensajeSiNo(v As String) As Boolean
        Return MessageBox.Show(Me, v, "Si / No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes
    End Function

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

        TxtDNI.Focus()
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
        If EsLetra(e.KeyChar) Or EsEspacio(e.KeyChar) Or EsControl(e.KeyChar) Then
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
            If paciente Is Nothing Then
                Return
            End If
            controlador.CommandoGuardar(paciente)
        End If
    End Sub

    Private Function cargarPaciente() As Paciente
        Try

            Dim p = New Paciente()
            p.Nombre = Capitalizar(TxtNombre.Text)
            p.Apellido = Capitalizar(TxtApellido.Text)
            p.Dni = TxtDNI.Text
            p.DomicilioCalle = Capitalizar(TxtCalle.Text)
            p.DomicilioCiudad = Capitalizar(TxtCiudad.Text)
            p.DomicilioNumero = TxtDNI.Text
            p.Genero = Capitalizar(ComboBoxGenero.Text)
            p.Nacimiento = DTPFechaNac.Value
            p.TelefonoNumero = TxtTelefono.Text
            p.TelefonoPrefijo = TxtPreFijoPac.Text

            Return p
        Catch ex As Exception
            mostrarMensajeOk("Se produjo un error al intentar leer los datos del paciente")
        End Try
    End Function

    Private Function Capitalizar(text As String) As String
        Dim palabras = text.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        For i As Integer = 0 To palabras.Count() - 1
            palabras(i) = StrConv(palabras(i), VbStrConv.ProperCase)
        Next
        Return String.Join(" ", palabras)
    End Function

    Private Sub BtnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCampos.Click
        controlador.CommandoCancelar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If BtnModificar.Text = "Modificar" Then
            controlador.CommandoModificar()
        Else
            controlador.CommandoCancelar()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim paciente = cargarPaciente()
        If paciente Is Nothing Then
            Return
        End If
        controlador.commandoEliminar(paciente)
    End Sub

    Private Sub DGVPacientes_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVPacientes.CellMouseDoubleClick
        If dbPacientes.Count < 1 Then
            Return
        End If
        controlador.SetPacienteActual(dbPacientes.Current)
    End Sub
End Class
