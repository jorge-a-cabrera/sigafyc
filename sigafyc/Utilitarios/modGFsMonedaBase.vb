Module modGFsMonedaBase
    Public Function GFsMonedaBase(ByVal piCodEmpresa As Integer) As String
        Dim lsResultado As String = ""
        Dim loC001 As New Ec001empresas
        loC001.codEmpresa = piCodEmpresa
        If loC001.GetPK = sOk_ Then
            lsResultado = loC001.codMoneda
        End If
        loC001.CerrarConexion()
        Return lsResultado
    End Function
End Module
