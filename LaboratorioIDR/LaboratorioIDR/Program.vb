Public Module Program
    Private inicio As Form

    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        ConfigurarDependencias()
        Application.Run(inicio)
    End Sub

    Private Sub ConfigurarDependencias()
        inicio = New FormMenu()
    End Sub
End Module
