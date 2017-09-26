Imports LaboratorioIDR
Imports LaboratorioIDR.Negocio

Public Class Abm_Pacientes_Controlador
    Private ReadOnly form As Pacientes
    Private ReadOnly servicioPacientes As IServicioPacientes
    Private estadoActual As Estados
    Private pacienteActual As Paciente

    Enum Estados
        Consulta
        Navegacion
        Edicion
        Nuevo
    End Enum

    Public Sub New(form As Pacientes, servicioPacientes As IServicioPacientes)
        Me.form = form
        Me.servicioPacientes = servicioPacientes
    End Sub

    Friend Sub Inicializar()
        SetEstado(Estados.Navegacion)
    End Sub

    Private Sub SetEstado(estado As Estados)
        Select Case estado
            Case Estados.Consulta
                form.inhabilitar_Campos()
                form.mostrar_Paciente(pacienteActual)
                form.habilitarAccionAgregar()
                form.habilitarAccionEditarEliminar()
            Case Estados.Navegacion
                form.inhabilitar_Campos()
                form.limpiar_Campos()
                form.habilitarAccionAgregar()
                form.inhabilitarAccionEditarEliminar()

                Dim pacientes = servicioPacientes.ListarTodos()
                form.mostrarListaPacientes(pacientes)
            Case Estados.Edicion
                If (estadoActual = Estados.Consulta) Then
                    form.inhabilitar_CampoDNI()
                    form.mostrar_Paciente(pacienteActual) 'por si modificó el campo dni antes de editar
                    form.habilitar_Campos()
                    form.habilitarAccionesAceptarCancelar()
                Else
                    form.mostrarMensajeOk("Acción no permitida")
                    Return
                End If
            Case Estados.Nuevo
                form.limpiar_Campos()
                form.habilitar_Campos()
                form.habilitarAccionesAceptarCancelar()
        End Select
        estadoActual = estado

    End Sub

    Friend Sub BuscarPorDni(text As String)
        If String.IsNullOrEmpty(text) Then
            form.mostrarMensajeOk("No es un DNI válido")
            Return
        Else
            Dim paciente = servicioPacientes.EncontarPacientePorDni(text)
            If paciente Is Nothing Then
                SetEstado(Estados.Navegacion)
                form.mostrarMensajeOk("Paciente no hallado")
            Else
                pacienteActual = paciente
                SetEstado(Estados.Consulta)
            End If
        End If
    End Sub

    Friend Sub CommandoAgregar()
        SetEstado(Estados.Nuevo)
    End Sub

    Friend Sub CommandoGuardar(p As Paciente)
        If estadoActual = Estados.Nuevo Then
            servicioPacientes.AgregarPaciente(p)
        Else
            servicioPacientes.ModificarPaciente(p)
        End If
        form.inhabilitarAccionesAceptarCancelar()
        form.mostrarMensajeOk("Los datos del paciente se han guardado")
        SetEstado(Estados.Navegacion)
    End Sub

    Friend Sub CommandoCancelar()
        If estadoActual = Estados.Nuevo Then
            SetEstado(Estados.Navegacion)
        Else
            SetEstado(Estados.Consulta)
        End If
    End Sub

    Friend Sub CommandoModificar()
        SetEstado(Estados.Edicion)
    End Sub

    Friend Sub CommandoEliminar(p As Paciente)
        If form.mostrarMensajeSiNo("¿Desea eliminar este paciente?") Then
            servicioPacientes.EliminarPaciente(p)
            SetEstado(Estados.Navegacion)
            form.mostrarMensajeOk("El paciente se ha eliminado correctamente")
        End If
    End Sub

    Friend Sub SetPacienteActual(current As Paciente)
        pacienteActual = current
        SetEstado(Estados.Consulta)
    End Sub
End Class
