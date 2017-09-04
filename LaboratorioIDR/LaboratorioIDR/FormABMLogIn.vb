Public Class FormABMLogIn
    Dim ds As DataSet
    Dim log As ClassLogIn
    Dim logMetodo As New MetodoLogIn

    'Datos
    Public Sub Datos()
        log = New ClassLogIn

        log.Usuario = TxtUsuario.Text
        log.Contrasena = TxtContraseña.Text

    End Sub
    'Boton Agregar
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtUsuario.Text = Nothing Or TxtContraseña.Text = Nothing Then
            MessageBox.Show("Deben completarese todos los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Datos()
            logMetodo.Agregar(log)
            llenar_grilla()
            limpiar_Campos()
        End If
    End Sub
    'Cargar Formulario LogIn
    Private Sub FormABMLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar_Campos()
        llenar_grilla()
        ControlBox = False 'Eliminar botones "Minimizar, Maximizar y Cerrar"
    End Sub
    'Boton Eliminar
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        'If TxtUsuario.Text = Nothing Or TxtContraseña.Text = Nothing Then
        '    MessageBox.Show("Todos los campos deben estar completos" & vbCrLf & "Seleccione el Paciente haciendo doble clic sobre la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Else
        Dim resp As Integer
            resp = MessageBox.Show("¿Esta seguro de que desea ELIMINAR este Usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = vbYes Then
                Datos()
                logMetodo.Eliminar_Usuario(log)
                llenar_grilla()
                limpiar_Campos()
            End If
        'End If
    End Sub
    'Llenar Grilla
    Private Sub llenar_grilla()
        ds = New DataSet
        ds = logMetodo.CargarGrilla()
        DGVLogIn.DataSource = ds.Tables("grilla_completa")
    End Sub
    'Limpiar campos
    Private Sub limpiar_Campos()
        TxtUsuario.Text = Nothing
        TxtContraseña.Text = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class