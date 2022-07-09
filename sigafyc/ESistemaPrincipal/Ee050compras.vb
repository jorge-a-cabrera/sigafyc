Public Class Ee050compras : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e050compras"
    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "timbrado" & sString_ & sSF_ &
                                       "tipodocumento" & sString_ & sSF_ &
                                       "numdocumento" & sString_ & sSF_ &
                                       "coddocumento" & sInteger_ & sSF_ &
                                       "prefijo" & sString_ & sSF_ &
                                       "numcompra" & sInteger_ & sSF_ &
                                       "fecoperacion" & sString_ & sSF_ &
                                       "fecrendicion" & sString_ & sSF_ &
                                       "codmoneda_mo" & sString_ & sSF_ &
                                       "cotizacion" & sInteger_ & sSF_ &
                                       "condoperacion" & sString_ & sSF_ &
                                       "aplicacion" & sString_ & sSF_ &
                                       "totexenta_in" & sDecimal_ & sSF_ &
                                       "totgrav05_in" & sDecimal_ & sSF_ &
                                       "totgrav10_in" & sDecimal_ & sSF_ &
                                       "ivagrav05_in" & sDecimal_ & sSF_ &
                                       "ivagrav10_in" & sDecimal_ & sSF_ &
                                       "totexenta_mo" & sDecimal_ & sSF_ &
                                       "totgrav05_mo" & sDecimal_ & sSF_ &
                                       "totgrav10_mo" & sDecimal_ & sSF_ &
                                       "ivagrav05_mo" & sDecimal_ & sSF_ &
                                       "ivagrav10_mo" & sDecimal_ & sSF_ &
                                       "totexenta_mb" & sDecimal_ & sSF_ &
                                       "totgrav05_mb" & sDecimal_ & sSF_ &
                                       "totgrav10_mb" & sDecimal_ & sSF_ &
                                       "ivagrav05_mb" & sDecimal_ & sSF_ &
                                       "ivagrav10_mb" & sDecimal_
    Private msCampos_PK() As Integer = {0, 1}
    Private msAutonumerado As String = "numtransaccion"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region
#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miNumTransaccion As Integer
    Private msTimbrado As String
    Private msTipoDocumento As String
    Private msNumDocumento As String
    Private miCodDocumento As Integer
    Private msPrefijo As String
    Private miNumCompra As Integer
    Private msFecOperacion As String
    Private msFecRendicion As String
    Private msCodMoneda_mo As String
    Private miCotizacion As Integer
    Private msCondOperacion As String
    Private msAplicacion As String
    Private mdTotExenta_in As Decimal
    Private mdTotGrav05_in As Decimal
    Private mdTotGrav10_in As Decimal
    Private mdIvaGrav05_in As Decimal
    Private mdIvaGrav10_in As Decimal
    Private mdTotExenta_mo As Decimal
    Private mdTotGrav05_mo As Decimal
    Private mdTotGrav10_mo As Decimal
    Private mdIvaGrav05_mo As Decimal
    Private mdIvaGrav10_mo As Decimal
    Private mdTotExenta_mb As Decimal
    Private mdTotGrav05_mb As Decimal
    Private mdTotGrav10_mb As Decimal
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
    Public Property timbrado As String
        Get
            Return msTimbrado
        End Get
        Set(value As String)
            msTimbrado = value
        End Set
    End Property
    Public Property tipodocumento As String
        Get
            Return msTipoDocumento
        End Get
        Set(value As String)
            msTipoDocumento = value
        End Set
    End Property
    Public Property numdocumento As String
        Get
            Return msNumDocumento
        End Get
        Set(value As String)
            msNumDocumento = value
        End Set
    End Property
    Public Property coddocumento As Integer
        Get
            Return miCodDocumento
        End Get
        Set(value As Integer)
            miCodDocumento = value
        End Set
    End Property
    Public Property prefijo As String
        Get
            Return msPrefijo
        End Get
        Set(value As String)
            msPrefijo = value
        End Set
    End Property
    Public Property numcompra As Integer
        Get
            Return miNumCompra
        End Get
        Set(value As Integer)
            miNumCompra = value
        End Set
    End Property
    Public Property fecoperacion As String
        Get
            Return msFecOperacion
        End Get
        Set(value As String)
            msFecOperacion = value
        End Set
    End Property
    Public Property fecrendicion As String
        Get
            Return msFecRendicion
        End Get
        Set(value As String)
            msFecRendicion = value
        End Set
    End Property
    Public Property codmoneda_mo As String
        Get
            Return msCodMoneda_mo
        End Get
        Set(value As String)
            msCodMoneda_mo = value
        End Set
    End Property
    Public Property cotizacion As Integer
        Get
            Return miCotizacion
        End Get
        Set(value As Integer)
            miCotizacion = value
        End Set
    End Property
    Public Property condoperacion As String
        Get
            Return msCondOperacion
        End Get
        Set(value As String)
            msCondOperacion = value
        End Set
    End Property
    Public Property aplicacion As String
        Get
            Return msAplicacion
        End Get
        Set(value As String)
            msAplicacion = value
        End Set
    End Property
    Public Property totexenta_in As Decimal
        Get
            Return mdTotExenta_in
        End Get
        Set(value As Decimal)
            mdTotExenta_in = value
        End Set
    End Property
    Public Property totgrav05_in As Decimal
        Get
            Return mdTotGrav05_in
        End Get
        Set(value As Decimal)
            mdTotGrav05_in = value
        End Set
    End Property
    Public Property totgrav10_in As Decimal
        Get
            Return mdTotGrav10_in
        End Get
        Set(value As Decimal)
            mdTotGrav10_in = value
        End Set
    End Property
    Public Property ivagrav05_in As Decimal
        Get
            Return mdIvaGrav05_in
        End Get
        Set(value As Decimal)
            mdIvaGrav05_in = value
        End Set
    End Property
    Public Property ivagrav10_in As Decimal
        Get
            Return mdIvaGrav10_in
        End Get
        Set(value As Decimal)
            mdIvaGrav10_in = value
        End Set
    End Property
    Public Property totexenta_mo As Decimal
        Get
            Return mdTotExenta_mo
        End Get
        Set(value As Decimal)
            mdTotExenta_mo = value
        End Set
    End Property
    Public Property totgrav05_mo As Decimal
        Get
            Return mdTotGrav05_mo
        End Get
        Set(value As Decimal)
            mdTotGrav05_mo = value
        End Set
    End Property
    Public Property totgrav10_mo As Decimal
        Get
            Return mdTotGrav10_mo
        End Get
        Set(value As Decimal)
            mdTotGrav10_mo = value
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
    Public Property totexenta_mb As Decimal
        Get
            Return mdTotExenta_mb
        End Get
        Set(value As Decimal)
            mdTotExenta_mb = value
        End Set
    End Property
    Public Property totgrav05_mb As Decimal
        Get
            Return mdTotGrav05_mb
        End Get
        Set(value As Decimal)
            mdTotGrav05_mb = value
        End Set
    End Property
    Public Property totgrav10_mb As Decimal
        Get
            Return mdTotGrav10_mb
        End Get
        Set(value As Decimal)
            mdTotGrav10_mb = value
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
    Public Function ReservarRegistro(Optional ByVal piCodEmpresa As Integer = 0) As Integer
        codempresa = piCodEmpresa
        Dim liNumero As Integer = SiguienteNumero(msAutonumerado, msTableName, msFiltroClave)
        codempresa = piCodEmpresa
        numtransaccion = liNumero
        timbrado = sRESERVADO_
        tipodocumento = sRESERVADO_
        numdocumento = sRESERVADO_
        coddocumento = 0
        prefijo = sRESERVADO_
        numcompra = 0
        fecoperacion = sFormatoFecha1_
        fecrendicion = sFormatoFecha1_
        codmoneda_mo = sCero3_
        cotizacion = 0
        condoperacion = sRESERVADO_
        aplicacion = sRESERVADO_
        totexenta_in = 0.00D
        totgrav05_in = 0.00D
        totgrav10_in = 0.00D
        ivagrav05_in = 0.00D
        ivagrav10_in = 0.00D
        totexenta_mo = 0.00D
        totgrav05_mo = 0.00D
        totgrav10_mo = 0.00D
        ivagrav05_mo = 0.00D
        ivagrav10_mo = 0.00D
        totexenta_mb = 0.00D
        totgrav05_mb = 0.00D
        totgrav10_mb = 0.00D
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
