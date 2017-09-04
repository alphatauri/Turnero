Public Class FormHorarios
    Dim ds As DataSet
    Dim agen As ClassHorarios
    Dim agenMetodo As New MetodoHorarios
    Dim cb As ComboBox

    'Datos
    Public Sub Datos()
        agen = New ClassHorarios

        agen.DNIProf = CBProf.SelectedValue
        'LbDNIProfAgenda.Text
        'agen.NomProf = CBProf.SelectedText
        agen.Consultorio = CBConsultorio.SelectedItem
        agen.FecDsd = DTPFecDsdPlan.Value.ToShortDateString
        agen.FecHst = DTPFecHstPlan.Value.ToShortDateString
        agen.HoraDsd = DTPHoraDsdPlan.Value.ToShortTimeString
        agen.HoraHst = DTPHoraHstPlan.Value.ToShortTimeString
        agen.Slot = NUDSlot.Value

        agen.Lunes = CBLunes.Checked
        agen.Martes = CBMartes.Checked
        agen.Miercoles = CBMiercoles.Checked
        agen.Jueves = CBJueves.Checked
        agen.Viernes = CBViernes.Checked


    End Sub
    'Boton Cargar
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If CBConsultorio.SelectedItem = Nothing Or NUDSlot.Value = Nothing Then
                MessageBox.Show("Deben completarese todos los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Datos()
                agenMetodo.Agregar(agen)
                llenar_grilla()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    'Cargar Formulario
    Private Sub FormHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        agenMetodo.LlenarComboBox(CBProf)

        CBProf.SelectedIndex = 0
        CBConsultorio.SelectedIndex = 0
        DTPFecDsdPlan.Value = Today
        DTPFecHstPlan.Value = Today
        DTPHoraDsdPlan.Value = Now
        DTPHoraHstPlan.Value = Now

        CBLunes.Checked = False
        CBMartes.Checked = False
        CBMiercoles.Checked = False
        CBJueves.Checked = False
        CBViernes.Checked = False

        NUDSlot.Value = 0

        llenar_grilla()
    End Sub
    'Llenar Grilla
    Private Sub llenar_grilla()
        ds = New DataSet
        ds = agenMetodo.CargarGrilla()
        DGVAgenda.DataSource = ds.Tables("grilla_completa")
    End Sub
    'Boton Limpiar Campos
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        agen = New ClassHorarios

        CBProf.SelectedIndex = 0
        CBConsultorio.SelectedIndex = 0

        DTPFecDsdPlan.Value = Today
        DTPFecHstPlan.Value = Today
        DTPHoraDsdPlan.Value = Now
        DTPHoraHstPlan.Value = Now

        CBLunes.Checked = False
        CBMartes.Checked = False
        CBMiercoles.Checked = False
        CBJueves.Checked = False
        CBViernes.Checked = False

        NUDSlot.Value = 0

    End Sub

End Class