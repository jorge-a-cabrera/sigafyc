Public Class Ee040ventas : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e040ventas"
    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "coddocumento" & sInteger_ & sSF_ &
                                       "condventa" & sString_ & sSF_ &
                                       "timbrado" & sString_ & sSF_ &
                                       "codsucursal" & sInteger_ & sSF_ &
                                       "prefijo" & sString_ & sSF_ &
                                       "numfactura" & sInteger_ & sSF_ &
                                       "fecoperacion" & sString_ & sSF_ &
                                       "fecrendicion" & sString_ & sSF_ &
                                       "codmoneda_mo" & sString_ & sSF_ &
                                       "cotizacion" & sInteger_ & sSF_ &
                                       "tipodocumento" & sString_ & sSF_ &
                                       "numdocumento" & sString_ & sSF_ &
                                       "codvendedor" & sInteger_ & sSF_ &
                                       "aplicacion" & sString_ & sSF_ &
                                       "totexenta_mo" & sDecimal_ & sSF_ &
                                       "totgrav05_mo" & sDecimal_ & sSF_ &
                                       "totgrav10_mo" & sDecimal_ & sSF_ &
                                       "descuento_mo" & sDecimal_ & sSF_ &
                                       "ivagrav05_mo" & sDecimal_ & sSF_ &
                                       "ivagrav10_mo" & sDecimal_ & sSF_ &
                                       "totexenta_mb" & sDecimal_ & sSF_ &
                                       "totgrav05_mb" & sDecimal_ & sSF_ &
                                       "totgrav10_mb" & sDecimal_ & sSF_ &
                                       "descuento_mb" & sDecimal_ & sSF_ &
                                       "ivagrav05_mb" & sDecimal_ & sSF_ &
                                       "ivagrav10_mb" & sDecimal_
    Private msCampos_PK() As Integer = {0, 1}
    Private msAutonumerado As String = "numtransaccion"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miNumTransaccion As Integer
    Private miCodDocumento As Integer
    Private msCondVenta As String
    Private msTimbrado As String
    Private miCodSucursal As Integer
    Private msPrefijo As String
    Private miNumFactura As Integer
    Private msFecOperacion As String
    Private msFecRendicion As String
    Private msCodMoneda_mo As String
    Private miCotizacion As Integer
    Private msTipoDocumento As String
    Private msNumDocumento As String
    Private miCodVendedor As Integer
    Private msAplicacion As String
    Private mdTotExenta_mo As Decimal
    Private mdTotGrav05_mo As Decimal
    Private mdTotGrav10_mo As Decimal
    Private mdDescuento_mo As Decimal
    Private mdIvaGrav05_mo As Decimal
    Private mdIvaGrav10_mo As Decimal
    Private mdTotExenta_mb As Decimal
    Private mdTotGrav05_mb As Decimal
    Private mdTotGrav10_mb As Decimal
    Private mdDescuento_mb As Decimal
    Private mdIvaGrav05_mb As Decimal
    Private mdIvaGrav10_mb As Decimal
#End Region

    Public Property codEmpresa As Integer
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
    Public Property codDocumento As Integer
        Get
            Return miCodDocumento
        End Get
        Set(value As Integer)
            miCodDocumento = value
        End Set
    End Property
    Public Property condventa As String
        Get
            Return msCondVenta
        End Get
        Set(value As String)
            msCondVenta = value
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
    Public Property codsucursal As Integer
        Get
            Return miCodSucursal
        End Get
        Set(value As Integer)
            miCodSucursal = value
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
    Public Property numfactura As Integer
        Get
            Return miNumFactura
        End Get
        Set(value As Integer)
            miNumFactura = value
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
    Public Property codvendedor As Integer
        Get
            Return miCodVendedor
        End Get
        Set(value As Integer)
            miCodVendedor = value
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
    Public Function ReservarRegistro(Optional ByVal piCodEmpresa As Integer = 0) As Integer
        codEmpresa = piCodEmpresa
        Dim liNumero As Integer = SiguienteNumero(msAutonumerado, msTableName, msFiltroClave)
        codEmpresa = piCodEmpresa
        numtransaccion = liNumero
        codDocumento = 0
        timbrado = sRESERVADO_
        codsucursal = 0
        prefijo = sRESERVADO_
        numfactura = 0
        fecoperacion = sRESERVADO_
        fecrendicion = sRESERVADO_
        codmoneda_mo = sCero3_
        cotizacion = 0
        tipodocumento = sRESERVADO_
        numdocumento = sRESERVADO_
        codvendedor = 0
        aplicacion = sRESERVADO_
        totexenta_mo = 0.00D
        totgrav05_mo = 0.00D
        totgrav10_mo = 0.00D
        descuento_mo = 0.00D
        ivagrav05_mo = 0.00D
        ivagrav10_mo = 0.00D
        totexenta_mb = 0.00D
        totgrav05_mb = 0.00D
        totgrav10_mb = 0.00D
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
