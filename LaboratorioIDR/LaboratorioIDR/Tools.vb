Imports System.Runtime.CompilerServices

Public Module Tools
    <Extension()>
    Public Function SiEsEnterTab(ByVal form As ContainerControl, keychar As Char) As Boolean
        If keychar = vbCr Then
            form.SelectNextControl(form.ActiveControl, True, True, False, True)
            Return True
        End If
        Return False
    End Function

    Public Function EsLetra(keychar As Char) As Boolean
        Return Char.IsLetter(keychar)
    End Function
    Public Function EsEspacio(keychar As Char) As Boolean
        Return Char.IsWhiteSpace(keychar)
    End Function

    Public Function EsNumero(keychar As Char) As Boolean
        Return Char.IsNumber(keychar)
    End Function

    Public Function EsControl(keychar As Char) As Boolean
        Return Char.IsControl(keychar)
    End Function
End Module
