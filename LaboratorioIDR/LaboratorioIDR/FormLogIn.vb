Imports System.Data.SqlClient
Imports LaboratorioIDR.Datos
Imports LaboratorioIDR.Negocio
Imports LaboratorioIDR.PresentationLogic

Public Class FormLogIn : Implements ILoginView
    Private myServicioLogin As ServicioLogin

    Sub New()
        InitializeComponent()

        InicializarDependencias()
    End Sub

    Private Sub InicializarDependencias()
        myServicioLogin = New ServicioLogin(New UsuarioRepositorio())
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
    'Pasa de campos con la tecla enter sin sonido de fin de linea
    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True 'saca el sonido de fin de linea
            TxtContraseña.Focus()
        End If
    End Sub

    Private Sub TxtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            BtnIngresar.Focus()
        End If
    End Sub
End Class