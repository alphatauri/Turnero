Public Class AbmProfesionales
    Private ds As DataSet
    Private Prof As ClassProfesionales
    Private ProfMetodo As New MetodoProfesionales

    Private Sub AbmProfesionales2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_grilla()
        TxtDNIProf.Focus()
        ControlBox = False 'Eliminar botones "Minimizar, Maximizar, Cerrar"
        TxtApeProf.Enabled = False
        TxtNomProf.Enabled = False
        TxtPrefijoProf.Enabled = False
        TxtTelProf.Enabled = False
        DTPProfesionales.Enabled = False
        BtnAgregar.Text = "Agregar"
        BtnModificar.Text = "Modificar"
    End Sub
    'Datos
    Private Sub Datos()
        Prof = New ClassProfesionales
        Prof.DNIProf = TxtDNIProf.Text
        Prof.NomProf = StrConv(TxtNomProf.Text, VbStrConv.ProperCase) 'Letra Capital
        Prof.ApeProf = StrConv(TxtApeProf.Text, VbStrConv.ProperCase) 'Letra Capital
        Prof.FecIngProf = DTPProfesionales.Value
        Prof.PrefijoProf = TxtPrefijoProf.Text
        Prof.TelProf = TxtTelProf.Text
    End Sub
    'Agregar
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If BtnAgregar.Text = "Agregar" Then
                TxtApeProf.Enabled = True
                TxtNomProf.Enabled = True
                TxtPrefijoProf.Enabled = True
                TxtTelProf.Enabled = True
                DTPProfesionales.Enabled = True
                BtnAgregar.Text = "Guardar"
            Else
                If TxtNomProf.Text = Nothing Or TxtApeProf.Text = Nothing Or DTPProfesionales.Value = Nothing Or TxtTelProf.Text = Nothing Then
                    MessageBox.Show("Todos los campos deben estar completos" & vbCrLf & " Realice una busqueda por DNI o Apellido, o seleccione el Profecional haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Datos()
                    ProfMetodo.agregar(Prof)
                    llenar_grilla()
                    limpiar_Campos()
                    TxtDNIProf.Focus()
                    TxtApeProf.Enabled = False
                    TxtNomProf.Enabled = False
                    TxtPrefijoProf.Enabled = False
                    TxtTelProf.Enabled = False
                    DTPProfesionales.Enabled = False
                    BtnAgregar.Text = "Agregar"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "El Profesional ya se encuentra en el padrón")
        End Try
    End Sub
    'Modificar
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If BtnModificar.Text = "Modificar" And TxtDNIProf.Text <> Nothing Then
            TxtApeProf.Enabled = True
            TxtNomProf.Enabled = True
            TxtPrefijoProf.Enabled = True
            TxtTelProf.Enabled = True
            DTPProfesionales.Enabled = True
            BtnModificar.Text = "Guardar"
            TxtDNIProf.Focus()

        Else
            If TxtNomProf.Text = Nothing Or TxtApeProf.Text = Nothing Or DTPProfesionales.Value = Nothing Or TxtTelProf.Text = Nothing Then
                MessageBox.Show("Todos los campos deben estar completos. " & vbCrLf & " Realice una busqueda por DNI o Apellido, o seleccione el Profecional haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtDNIProf.Focus()
            Else
                Dim resp As Integer
                resp = MessageBox.Show("¿Esta seguro de que desea realizar los cambios?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resp = vbYes Then
                    Datos()
                    ProfMetodo.modificar_Profesionales(Prof)
                    ds = New DataSet
                    Datos()
                    ds = ProfMetodo.Buscar_Apellido(Prof)
                    DGVProfesionales.DataSource = ds.Tables("busqueda_apellido")
                    limpiar_Campos()
                    llenar_grilla()
                    TxtDNIProf.Focus()
                    TxtApeProf.Enabled = False
                    TxtNomProf.Enabled = False
                    TxtPrefijoProf.Enabled = False
                    TxtTelProf.Enabled = False
                    DTPProfesionales.Enabled = False
                    BtnModificar.Text = "Modificar"

                End If
            End If
        End If

    End Sub
    'Llenar TextBox con DataGridView
    Private Sub DGVProfesionales_DoubleClick(sender As Object, e As System.EventArgs) Handles DGVProfesionales.DoubleClick
        TxtDNIProf.Text = CStr(DGVProfesionales.Item(0, DGVProfesionales.CurrentRow.Index).Value)

        ProfMetodo = New MetodoProfesionales
        Dim dr As DataRow
        dr = ProfMetodo.cargar_campos(TxtDNIProf.Text)
        TxtDNIProf.Text = CStr(dr("DNIProf"))
        TxtNomProf.Text = CStr(dr("NomProf"))
        TxtApeProf.Text = CStr(dr("ApeProf"))
        DTPProfesionales.Value = CDate(dr("FecIngProf"))
        TxtTelProf.Text = CStr(dr("TelProf"))
        TxtPrefijoProf.Text = CStr(dr("CarTelProf"))
        TxtDNIProf.Focus()

    End Sub
    'Llenar Grilla
    Private Sub llenar_grilla()
        ds = New DataSet
        ds = ProfMetodo.cargarGrilla()
        DGVProfesionales.DataSource = ds.Tables("grilla_completa")
    End Sub
    'Limpiar campos
    Private Sub limpiar_Campos()
        TxtDNIProf.Text = Nothing
        TxtNomProf.Text = Nothing
        TxtApeProf.Text = Nothing
        DTPProfesionales.Value = Today
        TxtTelProf.Text = Nothing
        TxtPrefijoProf.Text = Nothing
        TxtApeProf.Enabled = False
        TxtNomProf.Enabled = False
        TxtPrefijoProf.Enabled = False
        TxtTelProf.Enabled = False
        DTPProfesionales.Enabled = False
        BtnAgregar.Text = "Agregar"
        BtnModificar.Text = "Modificar"
    End Sub
    'Limpiar Campos con Boton
    Private Sub BtnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCampos.Click
        limpiar_Campos()
        llenar_grilla()
        TxtDNIProf.Focus()
        BtnAgregar.Text = "Agregar"
        BtnModificar.Text = "Modificar"
    End Sub
    'Salir con Boton
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        BtnAgregar.Text = "Agregar"
        BtnModificar.Text = "Modificar"
        Me.Close()
    End Sub
    'Eliminar
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtNomProf.Text = Nothing Or TxtApeProf.Text = Nothing Or DTPProfesionales.Value = Nothing Or TxtTelProf.Text = Nothing Or TxtPrefijoProf.Text = Nothing Then
            MessageBox.Show("Todos los campos deben estar completos" & vbCrLf & " Realice una busqueda por DNI o Apellido, o seleccione el Profecional haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtDNIProf.Focus()
        Else
            Dim resp As Integer
            resp = MessageBox.Show("¿Esta seguro de que desea ELIMINAR este Profecional?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = vbYes Then
                Datos()
                ProfMetodo.eliminar_Profesional(Prof)
                llenar_grilla()
                limpiar_Campos()
                TxtDNIProf.Focus()
            End If
        End If
    End Sub
    'Buscar por DNI
    Private Sub BtnBuscarDNIProf_Click(sender As Object, e As EventArgs) Handles BtnBuscarDNIProf.Click
        If TxtDNIProf.Text = Nothing Then
            MessageBox.Show("El campo DNI, debe estar completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtDNIProf.Focus()
        Else
            Dim dr As DataRow
            Dim ds2 As DataSet

            ds = New DataSet
            Datos()
            ds = ProfMetodo.buscar_DNI(Prof)

            If ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No se ha encontrado el DNI solicitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtDNIProf.Focus()
            Else
                dr = ds.Tables(0).Rows(0)
                TxtDNIProf.Text = CStr(dr("DNIProf"))
                TxtApeProf.Text = CStr(dr("ApeProf"))
                TxtNomProf.Text = CStr(dr("NomProf"))
                DTPProfesionales.Value = CDate(dr("FecIngProf"))
                TxtTelProf.Text = CStr(dr("TelProf"))
                TxtPrefijoProf.Text = CStr(dr("CarTelProf"))

                'ds2 = ProfMetodo.cargarGrilla.DNI(Prof)

                'DGVProfesionales.DataSource = ds2.Tables("consulta_DNI_grilla")
                ds2 = ProfMetodo.cargar_grilla_DNI(Prof)

                DGVProfesionales.DataSource = ds2.Tables("consulta_DNI_grilla")
                TxtDNIProf.Focus()
            End If

        End If
    End Sub

    Private Sub TxtDNIProf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDNIProf.KeyPress
        'solo acepta numeros
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo o boton con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            BtnBuscarDNIProf.Focus()
        End If
    End Sub

    Private Sub TxtNomProf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNomProf.KeyPress
        'solo acepta letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo o boton con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            TxtApeProf.Focus()
        End If
    End Sub

    Private Sub TxtApeProf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApeProf.KeyPress
        'solo acepta letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo o boton con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            DTPProfesionales.Focus()
        End If
    End Sub
    Private Sub TxtPrefijoProf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrefijoProf.KeyPress
        'solo acepta numeros
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo o boton con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            DTPProfesionales.Focus()
        End If
    End Sub
    Private Sub TxtTelProf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelProf.KeyPress

        'solo acepta numeros
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo o boton con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            BtnAgregar.Focus()
        End If
    End Sub
    ' Valida la fecha de ingreso no sea mayor a hoy
    Private Sub DTPProfesionales_LostFocus(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles DTPProfesionales.LostFocus
        If DTPProfesionales.Value > Today Then
            MessageBox.Show("La fecha de Ingreso no puede ser mayor a Hoy ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DTPProfesionales.Focus()
        End If
    End Sub

    Private Sub DTPProfesionales_ValueChanged(sender As Object, e As EventArgs) Handles DTPProfesionales.ValueChanged

    End Sub
End Class