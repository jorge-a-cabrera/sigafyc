Module modProcesoInventario
    Public Function GFsProcesaInventarioSaldo(ByVal piCodEmpresa As Integer, ByVal psCodMercaderia As String, ByVal psPeriodo As String, ByVal piCodDeposito As Integer, ByVal psCodUbicacion As String, ByVal psOperacion As String, ByVal pdCantidad As Decimal, ByVal pdImpNeto As Decimal, ByVal pdImpuesto As Decimal) As String
        Dim lsResultado As String = sError_

        lsResultado = LFsAddUpdateRecord(piCodEmpresa, psCodMercaderia, sFecha_, psPeriodo, piCodDeposito, psCodUbicacion, psOperacion, pdCantidad, pdImpNeto, pdImpuesto)
        If lsResultado = sOk_ Then
            lsResultado = LFsAddUpdateRecord(piCodEmpresa, psCodMercaderia, sMensual_, psPeriodo.ToString.Substring(0, 7), piCodDeposito, psCodUbicacion, psOperacion, pdCantidad, pdImpNeto, pdImpuesto)
        End If

        Return lsResultado
    End Function

    Private Function LFsAddUpdateRecord(ByVal piCodEmpresa As Integer, ByVal psCodMercaderia As String, ByVal psTipo As String, ByVal psPeriodo As String, ByVal piCodDeposito As Integer, ByVal psCodUbicacion As String, ByVal psOperacion As String, ByVal pdCantidad As Decimal, ByVal pdImpNeto As Decimal, ByVal pdImpuesto As Decimal) As String
        Dim lsResultado As String = sError_
        Dim loZ010 As New Ez010inventario
        loZ010.codEmpresa = piCodEmpresa
        loZ010.codmercaderia = psCodMercaderia
        loZ010.tipo = psTipo
        loZ010.periodo = psPeriodo
        loZ010.coddeposito = piCodDeposito
        loZ010.codubicacion = psCodUbicacion
        If loZ010.GetPK <> sOk_ Then
            loZ010.codEmpresa = piCodEmpresa
            loZ010.codmercaderia = psCodMercaderia
            loZ010.tipo = psTipo
            loZ010.periodo = psPeriodo
            loZ010.coddeposito = piCodDeposito
            loZ010.codubicacion = psCodUbicacion
            loZ010.cantentrada = 0.00D
            loZ010.cantsalida = 0.00D
            loZ010.impentneto_mb = 0.00D
            loZ010.impentimpuesto_mb = 0.00D
            loZ010.impsalneto_mb = 0.00D
            loZ010.impsalimpuesto_mb = 0.00D
            loZ010.estado = sActivo_
            loZ010.Add(sNo_, sNo_)
        End If
        loZ010.codEmpresa = piCodEmpresa
        loZ010.codmercaderia = psCodMercaderia
        loZ010.tipo = psTipo
        loZ010.periodo = psPeriodo
        loZ010.coddeposito = piCodDeposito
        loZ010.codubicacion = psCodUbicacion
        Select Case psOperacion
            Case sEntrada_
                loZ010.cantentrada += pdCantidad
                loZ010.impentneto_mb += pdImpNeto
                loZ010.impentimpuesto_mb += pdImpuesto
                loZ010.cantentrada = Decimal.Parse(loZ010.cantentrada.ToString(sFormatF_))
                loZ010.impentneto_mb = Decimal.Parse(loZ010.impentneto_mb.ToString(sFormatF_))
                loZ010.impentimpuesto_mb = Decimal.Parse(loZ010.impentimpuesto_mb.ToString(sFormatF_))
            Case sSalida_
                loZ010.cantsalida += pdCantidad
                loZ010.impsalneto_mb += pdImpNeto
                loZ010.impsalimpuesto_mb += pdImpuesto
                loZ010.cantsalida = Decimal.Parse(loZ010.cantsalida.ToString(sFormatF_))
                loZ010.impsalneto_mb = Decimal.Parse(loZ010.impsalneto_mb.ToString(sFormatF_))
                loZ010.impsalimpuesto_mb = Decimal.Parse(loZ010.impsalimpuesto_mb.ToString(sFormatF_))
        End Select
        Try
            loZ010.Put(sNo_, sNo_)
            lsResultado = sOk_
        Catch ex As Exception
            GFsAvisar("Error durante actualizacion saldos x " & psTipo, sMENSAJE_, "Por favor comuniquese con el Dpto. Informatica")
        End Try
        loZ010.CerrarConexion()
        Return lsResultado
    End Function
End Module
