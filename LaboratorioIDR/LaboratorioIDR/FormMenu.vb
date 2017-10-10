Public Class FormMenu
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLogIn.ShowDialog()
    End Sub
    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem.Click
        Pacientes.ShowDialog()
        Pacientes.Close()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub ProfesionalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesionalesToolStripMenuItem.Click
        AbmProfesionales.ShowDialog()
    End Sub
    Private Sub AyudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Acerca.ShowDialog()
    End Sub

    Private Sub AgendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendasToolStripMenuItem.Click
        FormHorarios.ShowDialog()
        FormHorarios.Close()
    End Sub

    Private Sub GESTIONDEUSUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GESTIONDEUSUARIOSToolStripMenuItem.Click
        FormABMLogIn.ShowDialog()
    End Sub

    Private Sub ASIGNACIÓNDETURNOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGNACIÓNDETURNOSToolStripMenuItem.Click
        Turnos.ShowDialog()
        Turnos.Close()
    End Sub
End Class