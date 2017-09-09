Imports LaboratorioIDR.Datos
Imports LaboratorioIDR.Negocio

Public Class FormLogIn
    Private myServicioLogin As LoginService

    Sub New()
        InitializeComponent()

        InicializarDependencias()
    End Sub

    Private Sub InicializarDependencias()
        myServicioLogin = New LoginService(New UsuarioRepositorio())
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        ControlBox = False
        If TxtUsuario.Text = Nothing Or TxtContraseña.Text = Nothing Then
            MessageBox.Show("Debe completar los campos Usuario y Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If myServicioLogin.EsUsuarioValido(TxtUsuario.Text, TxtContraseña.Text) Then
                Me.Hide()
            Else
                MessageBox.Show("Usuario y/o Contraseña Incorrectos." & vbCrLf & " Por favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub frm_inicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtContraseña.Text = Nothing
        TxtUsuario.Text = Nothing
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        FormMenu.Close()
        Close()
    End Sub
    Private Function SiEsEnterTab(keychar As Char) As Boolean
        If Asc(keychar) = 13 Then
            SelectNextControl(ActiveControl, True, True, False, True)
            Return True
        End If
        Return False
    End Function

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress, TxtContraseña.KeyPress
        e.Handled = SiEsEnterTab(e.KeyChar)
    End Sub
End Class