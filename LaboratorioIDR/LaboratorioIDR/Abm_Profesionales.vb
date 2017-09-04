Public Class Profesionales
    Private ds As DataSet
    Private prof As ClassProfesionales
    Private profMetodo As New MetodoProfesionales

    Private Sub Profesionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_grilla()
        'eliminar los botones cerrar, minimizar y maximizar
        'ControlBox = False
    End Sub
    'Datos
    Private Sub Datos()
        prof = New ClassProfesionales
        prof.DNIProf = TxtDNIProf.Text
        prof.NombreProf = TxtNombreProf.Text
        prof.ApeProf = TxtApeProf.Text
        prof.FecIngProf = DTPFechaIngProf.Value
        prof.Especialidad = TxtEspecialidad.Text
        prof.TelProf = TxtTelProf.Text
    End Sub
    'Agregar
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregarProf.Click
        If TxtNombreProf.Text = Nothing Or TxtApeProf.Text = Nothing Or TxtEspecialidad.Text = Nothing Or TxtEspecialidad.Text = Nothing Or TxtTelProf.Text = Nothing Then
            MessageBox.Show("Todos los campos deben estar completos" & vbCrLf & " Realice una busqueda por DNI o Apellido, o seleccione el Profecional haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Datos()
            profMetodo.agregar(prof)
            llenar_grilla()
            limpiar_Campos()
        End If
    End Sub
    'Modificar
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificarProf.Click
        If TxtNombreProf.Text = Nothing Or TxtApeProf.Text = Nothing Or TxtEspecialidad.Text = Nothing Or TxtEspecialidad.Text = Nothing Or TxtTelProf.Text = Nothing Then
            MessageBox.Show("Todos los campos deben estar completos. " & vbCrLf & " Realice una busqueda por DNI o Apellido, o seleccione el Profecional haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim resp As Integer
            resp = MessageBox.Show("¿Esta seguro de que desea realizar los cambios?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = vbYes Then
                Datos()
                profMetodo.modificar_Profesionales(prof)
                ds = New DataSet
                Datos()
                ds = profMetodo.Buscar_Apellido(prof)
                DGVProfesionales.DataSource = ds.Tables("busqueda_apellido")
                limpiar_Campos()
                llenar_grilla()
            End If
        End If
    End Sub
    'Llenar TextBox con DataGridView
    Private Sub DGVProfesionales_DoubleClick(sender As Object, e As System.EventArgs) Handles DGVProfesionales.DoubleClick
        TxtDNIProf.Text = CStr(DGVProfesionales.Item(0, DGVProfesionales.CurrentRow.Index).Value)

        profMetodo = New MetodoProfesionales
        Dim dr As DataRow
        dr = profMetodo.cargar_campos(TxtDNIProf.Text)
        TxtDNIProf.Text = CStr(dr("DNIProf"))
        TxtNombreProf.Text = CStr(dr("NombreProf"))
        TxtApeProf.Text = CStr(dr("ApeProf"))
        DTPFechaIngProf.Value = CDate(dr("FecNacProf"))
        TxtEspecialidad.Text = CStr(dr("CalleProf"))
        TxtTelProf.Text = CStr(dr("TelProf"))

    End Sub
    'Llenar Grilla
    Private Sub llenar_grilla()
        ds = New DataSet
        ds = profMetodo.cargarGrilla()
        DGVProfesionales.DataSource = ds.Tables("grilla_completa")
    End Sub
    'Limpiar campos
    Private Sub limpiar_Campos()
        TxtDNIProf.Text = Nothing
        TxtNombreProf.Text = Nothing
        TxtApeProf.Text = Nothing
        DTPFechaIngProf.Value = Today
        TxtEspecialidad.Text = Nothing
        TxtTelProf.Text = Nothing
    End Sub
    'Salir
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalirProf.Click
        Me.Close()
    End Sub
    'Boton Limpiar Campos
    Private Sub BtnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCamposProf.Click
        limpiar_Campos()
    End Sub
    'Eliminar
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminarProf.Click
        If TxtNombreProf.Text = Nothing Or TxtApeProf.Text = Nothing Or TxtEspecialidad.Text = Nothing Or TxtEspecialidad.Text = Nothing Or TxtTelProf.Text = Nothing Then
            MessageBox.Show("Todos los campos deben estar completos" & vbCrLf & " Realice una busqueda por DNI o Apellido, o seleccione el Profecional haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim resp As Integer
            resp = MessageBox.Show("¿Esta seguro de que desea ELIMINAR este Profecional?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = vbYes Then
                Datos()
                MetodoProfesionales.eliminar_Profesional(prof)
                llenar_grilla()
                limpiar_Campos()
            End If
        End If
    End Sub
    'Buscar por DNI
    Private Sub BtnBuscarDNI_Click(sender As Object, e As EventArgs) Handles BtnBuscarDNIProf.Click
        If TxtDNIProf.Text = Nothing Then
            MessageBox.Show("El campo DNI, debe estar completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim dr As DataRow
            Dim ds2 As DataSet

            ds = New DataSet
            Datos()
            ds = profMetodo.buscar_DNI(prof)

            If ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No se ha encontrado el DNI solicitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dr = ds.Tables(0).Rows(0)
                TxtDNIProf.Text = CStr(dr("DNIProf"))
                TxtApeProf.Text = CStr(dr("ApeProf"))
                TxtNombreProf.Text = CStr(dr("NombreProf"))
                DTPFechaIngProf.Value = CDate(dr("FecNacProf"))
                TxtEspecialidad.Text = CStr(dr("CalleProf"))
                TxtTelProf.Text = CStr(dr("TelProf"))

                'ds2 = profMetodo.cargarGrilla.DNI(prof)

                'DGVProfesionales.DataSource = ds2.Tables("consulta_DNI_grilla")
                ds2 = profMetodo.cargar_grilla_DNI(prof)

                DGVProfesionales.DataSource = ds2.Tables("consulta_DNI_grilla")
            End If

        End If
    End Sub
End Class