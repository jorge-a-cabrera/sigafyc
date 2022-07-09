Public Class Ee071salmercaderia : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e071salmercaderia"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "numorden" & sInteger_ & sSF_ &
                                       "codubicacion" & sString_ & sSF_ &
                                       "codmercaderia" & sString_ & sSF_ &
                                       "nommercaderia" & sString_ & sSF_ &
                                       "codunidad" & sString_ & sSF_ &
                                       "cantsalida" & sDecimal_ & sSF_ &
                                       "costo_mb" & sDecimal_ & sSF_ &
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
    Private msCodUbicacion As String
    Private msCodMercaderia As String
    Private msNomMercaderia As String
    Private msCodUnidad As String
    Private mdCantSalida As Decimal
    Private mdCosto_mb As Decimal
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
    Public Property codubicacion As String
        Get
            Return msCodUbicacion
        End Get
        Set(value As String)
            msCodUbicacion = value
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
    Public Property cantsalida As Decimal
        Get
            Return mdCantSalida
        End Get
        Set(value As Decimal)
            mdCantSalida = value
        End Set
    End Property
    Public Property costo_mb As Decimal
        Get
            Return mdCosto_mb
        End Get
        Set(value As Decimal)
            mdCosto_mb = value
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
        codubicacion = sRESERVADO_
        codmercaderia = sRESERVADO_
        nommercaderia = sRESERVADO_
        codunidad = sRESERVADO_
        cantsalida = 0.00D
        costo_mb = 0.00D
        impexenta_mb = 0.00D
        impgrav05_mb = 0.00D
        impgrav10_mb = 0.00D
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
