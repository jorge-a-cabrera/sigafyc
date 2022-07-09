Public Class Ee051compras : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e051compras"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "numorden" & sInteger_ & sSF_ &
                                       "codmercaderia" & sString_ & sSF_ &
                                       "nommercaderia" & sString_ & sSF_ &
                                       "codunidad" & sString_ & sSF_ &
                                       "cantcompra" & sDecimal_ & sSF_ &
                                       "cantcompra_real" & sDecimal_ & sSF_ &
                                       "iva" & sString_ & sSF_ &
                                       "precunitario_in" & sDecimal_ & sSF_ &
                                       "precunitario_mo" & sDecimal_ & sSF_ &
                                       "precunitaiva_mo" & sDecimal_ & sSF_ &
                                       "precunitario_mb" & sDecimal_ & sSF_ &
                                       "precunitaiva_mb" & sDecimal_ & sSF_ &
                                       "imptotal_in" & sDecimal_ & sSF_ &
                                       "impexenta_mo" & sDecimal_ & sSF_ &
                                       "impgrav05_mo" & sDecimal_ & sSF_ &
                                       "impgrav10_mo" & sDecimal_ & sSF_ &
                                       "ivagrav05_mo" & sDecimal_ & sSF_ &
                                       "ivagrav10_mo" & sDecimal_ & sSF_ &
                                       "impexenta_mb" & sDecimal_ & sSF_ &
                                       "impgrav05_mb" & sDecimal_ & sSF_ &
                                       "impgrav10_mb" & sDecimal_ & sSF_ &
                                       "ivagrav05_mb" & sDecimal_ & sSF_ &
                                       "ivagrav10_mb" & sDecimal_

    Private msCampos_PK() As Integer = {0, 1, 2}
    Private msAutonumerado As String = "numorden"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region
#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miNumTransaccion As Integer
    Private miNumOrden As Integer
    Private msCodMercaderia As String
    Private msNomMercaderia As String
    Private msCodUnidad As String
    Private mdCantCompra As Decimal
    Private mdCantCompra_real As Decimal
    Private msIva As String
    Private mdPrecUnitario_in As Decimal
    Private mdPrecUnitario_mo As Decimal
    Private mdPrecUnitaIva_mo As Decimal
    Private mdPrecUnitario_mb As Decimal
    Private mdPrecUnitaIva_mb As Decimal
    Private mdImpTotal_in As Decimal
    Private mdImpExenta_mo As Decimal
    Private mdImpGrav05_mo As Decimal
    Private mdImpGrav10_mo As Decimal
    Private mdIvaGrav05_mo As Decimal
    Private mdIvaGrav10_mo As Decimal
    Private mdImpExenta_mb As Decimal
    Private mdImpGrav05_mb As Decimal
    Private mdImpGrav10_mb As Decimal
    Private mdIvaGrav05_mb As Decimal
    Private mdIvaGrav10_mb As Decimal
#End Region
    Public Property codempresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property
    Public Property numtransaccion As Integer
        Get
            Return miNumTransaccion
        End Get
        Set(value As Integer)
            miNumTransaccion = value
        End Set
    End Property
    Public Property numorden As Integer
        Get
            Return miNumOrden
        End Get
        Set(value As Integer)
            miNumOrden = value
        End Set
    End Property
    Public Property codmercaderia As String
        Get
            Return msCodMercaderia
        End Get
        Set(value As String)
            msCodMercaderia = value
        End Set
    End Property
    Public Property nommercaderia As String
        Get
            Return msNomMercaderia
        End Get
        Set(value As String)
            msNomMercaderia = value
        End Set
    End Property
    Public Property codunidad As String
        Get
            Return msCodUnidad
        End Get
        Set(value As String)
            msCodUnidad = value
        End Set
    End Property
    Public Property cantcompra As Decimal
        Get
            Return mdCantCompra
        End Get
        Set(value As Decimal)
            mdCantCompra = value
        End Set
    End Property
    Public Property cantcompra_real As Decimal
        Get
            Return mdCantCompra_real
        End Get
        Set(value As Decimal)
            mdCantCompra_real = value
        End Set
    End Property
    Public Property iva As String
        Get
            Return msIva
        End Get
        Set(value As String)
            msIva = value
        End Set
    End Property
    Public Property precunitario_in As Decimal
        Get
            Return mdPrecUnitario_in
        End Get
        Set(value As Decimal)
            mdPrecUnitario_in = value
        End Set
    End Property
    Public Property precunitario_mo As Decimal
        Get
            Return mdPrecUnitario_mo
        End Get
        Set(value As Decimal)
            mdPrecUnitario_mo = value
        End Set
    End Property
    Public Property precunitaiva_mo As Decimal
        Get
            Return mdPrecUnitaIva_mo
        End Get
        Set(value As Decimal)
            mdPrecUnitaIva_mo = value
        End Set
    End Property
    Public Property precunitario_mb As Decimal
        Get
            Return mdPrecUnitario_mb
        End Get
        Set(value As Decimal)
            mdPrecUnitario_mb = value
        End Set
    End Property
    Public Property precunitaiva_mb As Decimal
        Get
            Return mdPrecUnitaIva_mb
        End Get
        Set(value As Decimal)
            mdPrecUnitaIva_mb = value
        End Set
    End Property
    Public Property imptotal_in As Decimal
        Get
            Return mdImpTotal_in
        End Get
        Set(value As Decimal)
            mdImpTotal_in = value
        End Set
    End Property
    Public Property impexenta_mo As Decimal
        Get
            Return mdImpExenta_mo
        End Get
        Set(value As Decimal)
            mdImpExenta_mo = value
        End Set
    End Property
    Public Property impgrav05_mo As Decimal
        Get
            Return mdImpGrav05_mo
        End Get
        Set(value As Decimal)
            mdImpGrav05_mo = value
        End Set
    End Property
    Public Property impgrav10_mo As Decimal
        Get
            Return mdImpGrav10_mo
        End Get
        Set(value As Decimal)
            mdImpGrav10_mo = value
        End Set
    End Property
    Public Property ivagrav05_mo As Decimal
        Get
            Return mdIvaGrav05_mo
        End Get
        Set(value As Decimal)
            mdIvaGrav05_mo = value
        End Set
    End Property
    Public Property ivagrav10_mo As Decimal
        Get
            Return mdIvaGrav10_mo
        End Get
        Set(value As Decimal)
            mdIvaGrav10_mo = value
        End Set
    End Property
    Public Property impexenta_mb As Decimal
        Get
            Return mdImpExenta_mb
        End Get
        Set(value As Decimal)
            mdImpExenta_mb = value
        End Set
    End Property
    Public Property impgrav05_mb As Decimal
        Get
            Return mdImpGrav05_mb
        End Get
        Set(value As Decimal)
            mdImpGrav05_mb = value
        End Set
    End Property
    Public Property impgrav10_mb As Decimal
        Get
            Return mdImpGrav10_mb
        End Get
        Set(value As Decimal)
            mdImpGrav10_mb = value
        End Set
    End Property
    Public Property ivagrav05_mb As Decimal
        Get
            Return mdIvaGrav05_mb
        End Get
        Set(value As Decimal)
            mdIvaGrav05_mb = value
        End Set
    End Property
    Public Property ivagrav10_mb As Decimal
        Get
            Return mdIvaGrav10_mb
        End Get
        Set(value As Decimal)
            mdIvaGrav10_mb = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        SetParametros(msRama, msTableName, msRequeridos, msCampos_PK, Me)
        Conectar(msTableName)
    End Sub
    Public Function ReservarRegistro(Optional ByVal piCodEmpresa As Integer = 0, Optional ByVal piNumTransaccion As Integer = 0) As Integer
        codempresa = piCodEmpresa
        numtransaccion = piNumTransaccion
        Dim liNumero As Integer = SiguienteNumero(msAutonumerado, msTableName, msFiltroClave)
        codempresa = piCodEmpresa
        numtransaccion = piNumTransaccion
        numorden = liNumero
        codmercaderia = sRESERVADO_
        nommercaderia = sRESERVADO_
        codunidad = sCero6_
        cantcompra = 0.00D
        cantcompra_real = 0.00D
        iva = sRESERVADO_
        precunitario_in = 0.00D
        precunitario_mo = 0.00D
        precunitaiva_mo = 0.00D
        precunitario_mb = 0.00D
        precunitaiva_mb = 0.00D
        imptotal_in = 0.00D
        impexenta_mo = 0.00D
        impgrav05_mo = 0.00D
        impgrav10_mo = 0.00D
        ivagrav05_mo = 0.00D
        ivagrav10_mo = 0.00D
        impexenta_mb = 0.00D
        impgrav05_mb = 0.00D
        impgrav10_mb = 0.00D
        ivagrav05_mb = 0.00D
        ivagrav10_mb = 0.00D
        Add(sNo_, sNo_)
        Return liNumero
    End Function
    '    Public Overloads Sub Add(Optional ByVal psConfirmar As String = sSi_, Optional ByVal psBitacora As String = sSi_, Optional psDesplegarRegistro As String = sNo_, Optional psMensaje As String = "", Optional psActualizar As String = sNo_)
    '        LPCompletaDatos
    '        MyBase.Add(psConfirmar, psBitacora, psDesplegarRegistro, psMensaje)
    '        If psActualizar = sSi_ Then
    '            Call ComenzarTransaccion()
    '            Dim loCabecera As New Ee050compras
    '            loCabecera.codempresa = miCodEmpresa
    '            loCabecera.numtransaccion = miNumTransaccion
    '            If loCabecera.GetPK = sOk_ Then
    '                'GPCuentaActualizaSaldo(miCodEmpresa, msCodCuenta, loCabecera.codSucursal, loCabecera.fecha, msTipoMovimiento, mdImporte_mb, sSumar_)
    '                Select Case msTipoMovimiento
    '                    Case sDebito_.Substring(0, msTipoMovimiento.Trim.Length)
    '                        loCabecera.debito_o += mdImporte_mo
    '                        loCabecera.debito_b += mdImporte_mb
    '                    Case sCredito_.Substring(0, msTipoMovimiento.Trim.Length)
    '                        loCabecera.credito_o += mdImporte_mo
    '                        loCabecera.credito_b += mdImporte_mb
    '                End Select
    '                loCabecera.Put(sNo_, sNo_)
    '            End If
    '            loCabecera.CerrarConexion()
    '            loCabecera = Nothing
    '            Call ConfirmarTransaccion()
    '        End If
    '    End Sub

    '    Public Overloads Sub Del(Optional ByVal psConfirmar As String = sSi_, Optional ByVal psBitacora As String = sSi_, Optional psActualizar As String = sNo_)
    '        Dim liCodEmpresa As Integer = miCodEmpresa
    '        Dim liNumTransaccion As Integer = miNumTransaccion
    '        MyBase.Del(psConfirmar, psBitacora)
    '        If psActualizar = sSi_ Then
    '            Call ComenzarTransaccion()
    '            Dim loCabecera As New Ee050compras
    '            loCabecera.codEmpresa = liCodEmpresa
    '            loCabecera.numtransaccion = liNumTransaccion
    '            If loCabecera.GetPK = sOk_ Then
    '                'GPCuentaActualizaSaldo(liCodEmpresa, lsCodCuenta, loCabecera.codSucursal, loCabecera.fecha, lsTipoMovimiento, ldImporte_mb, sRestar_)
    '                Select Case msTipoMovimiento
    '                    Case sDebito_.Substring(0, msTipoMovimiento.Trim.Length)
    '                        loCabecera.debito_o -= mdImporte_mo
    '                        loCabecera.debito_b -= mdImporte_mb
    '                    Case sCredito_.Substring(0, msTipoMovimiento.Trim.Length)
    '                        loCabecera.credito_o -= mdImporte_mo
    '                        loCabecera.credito_b -= mdImporte_mb
    '                End Select
    '                loCabecera.Put(sNo_, sNo_)
    '            End If
    '            loCabecera.CerrarConexion()
    '            loCabecera = Nothing
    '            Call ConfirmarTransaccion()
    '        End If
    '    End Sub

    '    Public Overloads Sub Put(Optional ByVal psConfirmar As String = sSi_, Optional ByVal psBitacora As String = sSi_, Optional ByVal psAccion As String = "", Optional ByVal psActualizar As String = sNo_, Optional ByVal poAnterior As Dd010asientosdetalles = Nothing)
    '        Dim liCodEmpresa As Integer = miCodEmpresa
    '        Dim liNumTransaccion As Integer = miNumTransaccion
    '        Call ComenzarTransaccion()
    '        MyBase.Put(psConfirmar, psBitacora, psAccion)
    '        If psActualizar = sSi_ Then
    '            Dim loCabecera As New Ee050compras
    '            loCabecera.codEmpresa = liCodEmpresa
    '            loCabecera.numtransaccion = liNumTransaccion
    '            If loCabecera.GetPK = sOk_ Then
    '                If psAccion <> sAGREGAR_ Then
    '                    'GPCuentaActualizaSaldo(liCodEmpresa, poAnterior.codCuenta, loCabecera.codSucursal, loCabecera.fecha, poAnterior.tipoMovimiento, poAnterior.importe_mb, sRestar_)
    '                    Select Case poAnterior.tipoMovimiento
    '                        Case sDebito_.Substring(0, poAnterior.tipoMovimiento.Trim.Length)
    '                            loCabecera.debito_o -= poAnterior.importe_mo
    '                            loCabecera.debito_b -= poAnterior.importe_mb
    '                        Case sCredito_.Substring(0, poAnterior.tipoMovimiento.Trim.Length)
    '                            loCabecera.credito_o -= poAnterior.importe_mo
    '                            loCabecera.credito_b -= poAnterior.importe_mb
    '                    End Select
    '                    loCabecera.Put(sNo_, sNo_)
    '                End If
    '                GPCuentaActualizaSaldo(miCodEmpresa, msCodCuenta, loCabecera.codSucursal, loCabecera.fecha, msTipoMovimiento, mdImporte_mb, sSumar_)
    '                Select Case msTipoMovimiento
    '                    Case sDebito_.Substring(0, msTipoMovimiento.Trim.Length)
    '                        loCabecera.debito_o += mdImporte_mo
    '                        loCabecera.debito_b += mdImporte_mb
    '                    Case sCredito_.Substring(0, msTipoMovimiento.Trim.Length)
    '                        loCabecera.credito_o += mdImporte_mo
    '                        loCabecera.credito_b += mdImporte_mb
    '                End Select
    '                loCabecera.Put(sNo_, sNo_)
    '            End If
    '            loCabecera.CerrarConexion()
    '            loCabecera = Nothing
    '        End If
    '        Call ConfirmarTransaccion()
    '    End Sub
    Public Sub CerrarConexion()
        Desconectar(msTableName)
    End Sub
    Protected Overloads Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub LPCompletaDatos()
        Dim loE050 As New Ee050compras
        loE050.codempresa = codempresa
        loE050.numtransaccion = numtransaccion
        If loE050.GetPK = sOk_ Then
            Dim loC020 As New Ec020documentos
            loC020.codempresa = loE050.codempresa
            loC020.coddocumento = loE050.coddocumento
            If loC020.GetPK = sOk_ Then
                Dim loD020 As New Ed020mercentrada
                loD020.codempresa = loC020.codempresa
                loD020.codmercaderia = codmercaderia
                If loD020.GetPK = sOk_ Then

                End If
            End If
        End If
    End Sub
End Class