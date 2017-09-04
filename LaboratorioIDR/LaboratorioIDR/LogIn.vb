Imports System.Data.SqlClient

Public Class FormLogIn

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        ControlBox = False
        If TxtUsuario.Text = Nothing Or TxtContraseña.Text = Nothing Then
            MessageBox.Show("Debe completar los campos Usuario y Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim ds As New DataSet
            Dim con As New SqlConnection
            Dim objcon As New conexion
            Dim da As New SqlDataAdapter
            Dim str As String
            Try
                con = objcon.abrir
                str = "select * from login where Usuario = '" & TxtUsuario.Text & "' and Contrasena = '" & TxtContraseña.Text & "'"
                da = New SqlDataAdapter(str, con)
                da.Fill(ds, "consulta")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            If ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("Usuario y/o Contraseña Incorrectos." & vbCrLf & " Por favor intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.Hide()
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