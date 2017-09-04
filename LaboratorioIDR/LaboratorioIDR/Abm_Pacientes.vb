Public Class Pacientes
    Private ds As DataSet
    Private pac As ClassPacientes
    Private pacMetodo As New MetodoPacientes

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_grilla()
        TxtDNI.Focus()
        ComboBoxGenero.SelectedIndex = 0
        ControlBox = False 'Eliminar botones "Minimizar, Maximizar y Cerrar"
        TxtApellido.Enabled = False
        TxtNombre.Enabled = False
        DTPFechaNac.Enabled = False
        ComboBoxGenero.Enabled = False
        TxtCalle.Enabled = False
        TxtAltura.Enabled = False
        TxtCiudad.Enabled = False
        TxtPreFijoPac.Enabled = False
        TxtTelefono.Enabled = False
        BtnAgregar.Text = "Agregar"
        BtnModificar.Text = "Modificar"

    End Sub
    'Datos
    Private Sub Datos()
        pac = New ClassPacientes
        pac.DNIPac = TxtDNI.Text
        pac.NomPac = StrConv(TxtNombre.Text, VbStrConv.ProperCase) 'Letra Capital
        pac.ApePac = StrConv(TxtApellido.Text, VbStrConv.ProperCase) 'Letra Capital
        pac.FecNacPac = DTPFechaNac.Value.ToShortDateString
        pac.GeneroPac = ComboBoxGenero.SelectedItem
        pac.CallePac = StrConv(TxtCalle.Text, VbStrConv.ProperCase) 'Letra Capital
        pac.AlturaPac = TxtAltura.Text
        pac.CiudadPac = StrConv(TxtCiudad.Text, VbStrConv.ProperCase) 'Letra Capital
        pac.PreFijoPac = TxtPreFijoPac.Text
        pac.TelPac = TxtTelefono.Text
    End Sub
    'Agregar
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If BtnAgregar.Text = "Agregar" Then
            TxtApellido.Enabled = True
            TxtNombre.Enabled = True
            DTPFechaNac.Enabled = True
            ComboBoxGenero.Enabled = True
            TxtCalle.Enabled = True
            TxtAltura.Enabled = True
            TxtCiudad.Enabled = True
            TxtPreFijoPac.Enabled = True
            TxtTelefono.Enabled = True
            TxtDNI.Focus()
            BtnAgregar.Text = "Guardar"
        Else

            If TxtNombre.Text = Nothing Or TxtApellido.Text = Nothing Or TxtCalle.Text = Nothing Or TxtCiudad.Text = Nothing Or ComboBoxGenero.SelectedItem = Nothing Or TxtTelefono.Text = Nothing Then
                MessageBox.Show("Todos los campos deben estar completos" & vbCrLf & " Realice una busqueda por DNI o Apellido, o seleccione el paciente haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Datos()
                pacMetodo.agregar(pac)
                llenar_grilla()
                limpiar_Campos()
                TxtApellido.Enabled = False
                TxtNombre.Enabled = False
                DTPFechaNac.Enabled = False
                ComboBoxGenero.Enabled = False
                TxtCalle.Enabled = False
                TxtAltura.Enabled = False
                TxtCiudad.Enabled = False
                TxtPreFijoPac.Enabled = False
                TxtTelefono.Enabled = False
                TxtDNI.Focus()
                BtnAgregar.Text = "Agregar"
            End If
        End If
    End Sub
    'Modificar
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If BtnModificar.Text = "Modificar" Then
            TxtApellido.Enabled = True
            TxtNombre.Enabled = True
            DTPFechaNac.Enabled = True
            ComboBoxGenero.Enabled = True
            TxtCalle.Enabled = True
            TxtAltura.Enabled = True
            TxtCiudad.Enabled = True
            TxtPreFijoPac.Enabled = True
            TxtTelefono.Enabled = True
            TxtDNI.Focus()
            BtnModificar.Text = "Guardar"
        Else
            If TxtNombre.Text = Nothing Or TxtApellido.Text = Nothing Or TxtCalle.Text = Nothing Or TxtAltura.Text = Nothing Or ComboBoxGenero.SelectedItem = Nothing Or TxtPreFijoPac.Text = Nothing Or TxtTelefono.Text = Nothing Then
                MessageBox.Show("Todos los campos deben estar completos. " & vbCrLf & " Realice una busqueda por DNI o Apellido, o seleccione el paciente haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim resp As Integer
                resp = MessageBox.Show("¿Esta seguro de que desea realizar los cambios?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resp = vbYes Then
                    Datos()
                    pacMetodo.modificar_Pacientes(pac)
                    ds = New DataSet
                    Datos()
                    ds = pacMetodo.Buscar_Apellido(pac)
                    DGVPacientes.DataSource = ds.Tables("busqueda_apellido")
                    limpiar_Campos()
                    llenar_grilla()
                    TxtApellido.Enabled = False
                    TxtNombre.Enabled = False
                    DTPFechaNac.Enabled = False
                    ComboBoxGenero.Enabled = False
                    TxtCalle.Enabled = False
                    TxtAltura.Enabled = False
                    TxtCiudad.Enabled = False
                    TxtPreFijoPac.Enabled = False
                    TxtTelefono.Enabled = False
                    TxtDNI.Focus()
                    BtnModificar.Text = "Modificar"
                End If
            End If

        End If
    End Sub
    'Llenar TextBox con DataGridView
    Private Sub DGVPacientes_DoubleClick(sender As Object, e As System.EventArgs) Handles DGVPacientes.DoubleClick
        TxtDNI.Text = CStr(DGVPacientes.Item(0, DGVPacientes.CurrentRow.Index).Value)

        pacMetodo = New MetodoPacientes
        Dim dr As DataRow
        dr = pacMetodo.cargar_campos(TxtDNI.Text)
        TxtDNI.Text = CStr(dr("DNIPac"))
        TxtNombre.Text = CStr(dr("NomPac"))
        TxtApellido.Text = CStr(dr("ApePac"))
        DTPFechaNac.Value = CDate(dr("FecNacPac"))
        TxtCalle.Text = CStr(dr("CallePac"))
        TxtAltura.Text = CStr(dr("AlturaPac"))
        ComboBoxGenero.SelectedItem = CStr(dr("GeneroPac"))
        TxtCiudad.Text = CStr(dr("CiudadPac"))
        TxtPreFijoPac.Text = CInt(dr("CarTelPac"))
        TxtTelefono.Text = CStr(dr("TelPac"))

    End Sub
    'Llenar Grilla
    Private Sub llenar_grilla()
        ds = New DataSet
        ds = pacMetodo.cargarGrilla()
        DGVPacientes.DataSource = ds.Tables("grilla_completa")
    End Sub
    'Limpiar campos
    Private Sub limpiar_Campos()
        TxtDNI.Text = Nothing
        TxtNombre.Text = Nothing
        TxtApellido.Text = Nothing
        DTPFechaNac.Value = Today
        TxtCalle.Text = Nothing
        TxtAltura.Text = Nothing
        ComboBoxGenero.SelectedItem = Nothing
        TxtCiudad.Text = Nothing
        TxtPreFijoPac.Text = Nothing
        TxtTelefono.Text = Nothing
        TxtApellido.Enabled = False
        TxtNombre.Enabled = False
        DTPFechaNac.Enabled = False
        ComboBoxGenero.Enabled = False
        TxtCalle.Enabled = False
        TxtAltura.Enabled = False
        TxtCiudad.Enabled = False
        TxtPreFijoPac.Enabled = False
        TxtTelefono.Enabled = False
        TxtDNI.Focus()
    End Sub
    'Salir
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    'Boton Limpiar Campos
    Private Sub BtnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCampos.Click
        limpiar_Campos()
        llenar_grilla()
        TxtDNI.Focus()
        TxtApellido.Enabled = False
        TxtNombre.Enabled = False
        DTPFechaNac.Enabled = False
        ComboBoxGenero.Enabled = False
        TxtCalle.Enabled = False
        TxtAltura.Enabled = False
        TxtCiudad.Enabled = False
        'TxtPreFijoPac.Enabled = False
        TxtTelefono.Enabled = False
        BtnAgregar.Text = "Agregar"
        BtnModificar.Text = "Modificar"
    End Sub
    'Eliminar
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'If TxtNombre.Text = Nothing Or TxtApellido.Text = Nothing Or TxtCalle.Text = Nothing Or TxtAltura.Text = Nothing Or TxtCiudad.Text = Nothing Or TxtPrefijoPac.Text Or TxtTelefono.Text = Nothing Then
        '    MessageBox.Show("Todos los campos deben estar completos" & vbCrLf & " Realice una busqueda por DNI o Apellido, o seleccione el Paciente haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Else
        Dim resp As Integer
        resp = MessageBox.Show("¿Esta seguro de que desea ELIMINAR este Paciente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = vbYes Then
            Datos()
            pacMetodo.eliminar_Paciente(pac)
            llenar_grilla()
            limpiar_Campos()
        End If
        'End If
    End Sub
    'Buscar por DNI
    Private Sub BtnBuscarDNI_Click(sender As Object, e As EventArgs) Handles BtnBuscarDNI.Click
        If TxtDNI.Text = Nothing Then
            MessageBox.Show("El campo DNI, debe estar completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim dr As DataRow
            Dim ds2 As DataSet

            ds = New DataSet
            Datos()
            ds = pacMetodo.buscar_DNI(pac)

            If ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No se ha encontrado el DNI solicitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dr = ds.Tables(0).Rows(0)
                TxtDNI.Text = CStr(dr("DNIPac"))
                TxtApellido.Text = CStr(dr("ApePac"))
                TxtNombre.Text = CStr(dr("NomPac"))
                DTPFechaNac.Value = CDate(dr("FecNacPac"))
                TxtCalle.Text = CStr(dr("CallePac"))
                TxtAltura.Text = CStr(dr("AlturaPac"))
                ComboBoxGenero.SelectedItem = CStr(dr("GeneroPac"))
                TxtCiudad.Text = CStr(dr("CiudadPac"))
                TxtPreFijoPac.Text = CInt(dr("CarTelPac"))
                TxtTelefono.Text = CStr(dr("TelPac"))
                BtnAgregar.Text = "Agregar"

                'ds2 = pacMetodo.cargarGrilla.DNI(pac)

                'DGVPacientes.DataSource = ds2.Tables("consulta_DNI_grilla")
                ds2 = pacMetodo.cargar_grilla_DNI(pac)

                DGVPacientes.DataSource = ds2.Tables("consulta_DNI_grilla")
            End If

        End If
    End Sub

    Private Sub TxtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDNI.KeyPress
        'solo acepta numeros
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            BtnBuscarDNI.Focus()
        End If
    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        'solo acepta letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            TxtApellido.Focus()
        End If
    End Sub

    Private Sub TxtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellido.KeyPress
        'solo acepta letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            DTPFechaNac.Focus()
        End If
    End Sub

    Private Sub DTPFechaNac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTPFechaNac.KeyPress
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            ComboBoxGenero.SelectedItem.Focus()
        End If
    End Sub

    Private Sub TxtGenero_KeyPress(sender As Object, e As KeyPressEventArgs)
        'solo acepta letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            TxtCalle.Focus()
        End If
    End Sub

    Private Sub TxtCalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCalle.KeyPress
        'solo acepta letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            TxtAltura.Focus()
        End If
    End Sub

    Private Sub TxtAltura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAltura.KeyPress
        'solo acepta numeros
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            TxtCiudad.Focus()
        End If
    End Sub

    Private Sub TxtCiudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCiudad.KeyPress
        'solo acepta letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            TxtTelefono.Focus()
        End If
    End Sub
    Private Sub TxtPreFijoPac_KeyPress(sender As Object, e As KeyPressEventArgs)
        'solo acepta numeros
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            BtnAgregar.Focus()
        End If
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        'solo acepta numeros
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
        'pasa a otro campo con enter
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            BtnAgregar.Focus()
        End If
    End Sub

    'Valida la fecha de nacimiento menor a hoy
    Private Sub DTPFechaNac_LostFocus(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles DTPFechaNac.LostFocus
        If DTPFechaNac.Value > Today Then
            MessageBox.Show("La fecha de Nacimiento no puede ser mayor a Hoy ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            DTPFechaNac.Focus()
        End If
    End Sub
    '   Private Sub txtDNI_LostFocus(ByVal sender As Object,
    'ByVal e As System.EventArgs) Handles TxtDNI.LostFocus

    '   End Sub
End Class
