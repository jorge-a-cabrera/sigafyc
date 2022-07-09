Public Class Ee041ventas : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e041ventas"
    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "numorden" & sInteger_ & sSF_ &
                                       "codmercaderia" & sString_ & sSF_ &
                                       "nommercaderia" & sString_ & sSF_ &
                                       "codunidad" & sString_ & sSF_ &
                                       "cantventa" & sDecimal_ & sSF_ &
                                       "cantventa_real" & sDecimal_ & sSF_ &
                                       "iva" & sString_ & sSF_ &
                                       "precunitario_in" & sDecimal_ & sSF_ &
                                       "precunitario_mo" & sDecimal_ & sSF_ &
                                       "precunitaiva_mo" & sDecimal_ & sSF_ &
                                       "precunitario_mb" & sDecimal_ & sSF_ &
                                       "precunitaiva_mb" & sDecimal_ & sSF_ &
                                       "preclista_mo" & sDecimal_ & sSF_ &
                                       "preclistaiva_mo" & sDecimal_ & sSF_ &
                                       "preclista_mb" & sDecimal_ & sSF_ &
                                       "preclistaiva_mb" & sDecimal_ & sSF_ &
                                       "importe_in" & sDecimal_ & sSF_ &
                                       "impexenta_mo" & sDecimal_ & sSF_ &
                                       "impgrav05_mo" & sDecimal_ & sSF_ &
                                       "impgrav10_mo" & sDecimal_ & sSF_ &
                                       "descuento_mo" & sDecimal_ & sSF_ &
                                       "ivagrav05_mo" & sDecimal_ & sSF_ &
                                       "ivagrav10_mo" & sDecimal_ & sSF_ &
                                       "impexenta_mb" & sDecimal_ & sSF_ &
                                       "impgrav05_mb" & sDecimal_ & sSF_ &
                                       "impgrav10_mb" & sDecimal_ & sSF_ &
                                       "descuento_mb" & sDecimal_ & sSF_ &
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
    Private mdCantVenta As Decimal
    Private mdCantVenta_real As Decimal
    Private msIva As String
    Private mdPrecUnitario_in As Decimal
    Private mdPrecUnitario_mo As Decimal
    Private mdPrecUnitaIva_mo As Decimal
    Private mdPrecUnitario_mb As Decimal
    Private mdPrecUnitaIva_mb As Decimal
    Private mdPrecLista_mo As Decimal
    Private mdPrecListaIva_mo As Decimal
    Private mdPrecLista_mb As Decimal
    Private mdPrecListaIva_mb As Decimal
    Private mdImporte_in As Decimal
    Private mdImpExenta_mo As Decimal
    Private mdImpGrav05_mo As Decimal
    Private mdImpGrav10_mo As Decimal
    Private mdDescuento_mo As Decimal
    Private mdIvaGrav05_mo As Decimal
    Private mdIvaGrav10_mo As Decimal
    Private mdImpExenta_mb As Decimal
    Private mdImpGrav05_mb As Decimal
    Private mdImpGrav10_mb As Decimal
    Private mdDescuento_mb As Decimal
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
            Return minumorden
        End Get
        Set(value As Integer)
            minumorden = value
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
    Public Property cantventa As Decimal
        Get
            Return mdCantVenta
        End Get
        Set(value As Decimal)
            mdCantVenta = value
        End Set
    End Property
    Public Property cantventa_real As Decimal
        Get
            Return mdCantVenta_real
        End Get
        Set(value As Decimal)
            mdCantVenta_real = value
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
    Public Property preclista_mo As Decimal
        Get
            Return mdPrecLista_mo
        End Get
        Set(value As Decimal)
            mdPrecLista_mo = value
        End Set
    End Property
    Public Property preclistaiva_mo As Decimal
        Get
            Return mdPrecListaIva_mo
        End Get
        Set(value As Decimal)
            mdPrecListaIva_mo = value
        End Set
    End Property
    Public Property preclista_mb As Decimal
        Get
            Return mdPrecLista_mb
        End Get
        Set(value As Decimal)
            mdPrecLista_mb = value
        End Set
    End Property
    Public Property preclistaiva_mb As Decimal
        Get
            Return mdPrecListaIva_mb
        End Get
        Set(value As Decimal)
            mdPrecListaIva_mb = value
        End Set
    End Property
    Public Property importe_in As Decimal
        Get
            Return mdImporte_in
        End Get
        Set(value As Decimal)
            mdImporte_in = value
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
    Public Property descuento_mo As Decimal
        Get
            Return mdDescuento_mo
        End Get
        Set(value As Decimal)
            mdDescuento_mo = value
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
    Public Property descuento_mb As Decimal
        Get
            Return mdDescuento_mb
        End Get
        Set(value As Decimal)
            mdDescuento_mb = value
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
        codunidad = sRESERVADO_
        cantventa = 0.00D
        cantventa_real = 0.00D
        iva = sRESERVADO_
        precunitario_mo = 0.00D
        precunitaiva_mo = 0.00D
        precunitario_mb = 0.00D
        precunitaiva_mb = 0.00D
        preclista_mo = 0.00D
        preclistaiva_mo = 0.00D
        preclista_mb = 0.00D
        preclistaiva_mb = 0.00D
        importe_in = 0.00D
        impexenta_mo = 0.00D
        impgrav05_mo = 0.00D
        impgrav10_mo = 0.00D
        descuento_mo = 0.00D
        ivagrav05_mo = 0.00D
        ivagrav10_mo = 0.00D
        impexenta_mb = 0.00D
        impgrav05_mb = 0.00D
        impgrav10_mb = 0.00D
        descuento_mb = 0.00D
        ivagrav05_mb = 0.00D
        ivagrav10_mb = 0.00D
        Add(sNo_, sNo_)
        Return liNumero
    End Function
    Public Sub CerrarConexion()
        Desconectar(msTableName)
    End Sub
    Protected Overloads Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
