Public Class Ee061entmercaderia : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e061entmercaderia"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "numorden" & sInteger_ & sSF_ &
                                       "codubicacion" & sString_ & sSF_ &
                                       "codmercaderia" & sString_ & sSF_ &
                                       "nommercaderia" & sString_ & sSF_ &
                                       "iva" & sString_ & sSF_ &
                                       "codunidad" & sString_ & sSF_ &
                                       "cantentrada" & sDecimal_ & sSF_ &
                                       "cantsalida" & sDecimal_ & sSF_ &
                                       "costo_mb" & sDecimal_ & sSF_ &
                                       "costoimpuesto_mb" & sDecimal_ & sSF_ &
                                       "compneta_mb" & sDecimal_ & sSF_ &
                                       "compimpuesto_mb" & sDecimal_ & sSF_ &
                                       "gastneto_mb" & sDecimal_ & sSF_ &
                                       "gastimpuesto_mb" & sDecimal_

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
    Private msIva As String
    Private msCodUnidad As String
    Private mdCantEntrada As Decimal
    Private mdCantSalida As Decimal
    Private mdCosto_mb As Decimal
    Private mdCostoImpuesto_mb As Decimal
    Private mdCompNeta_mb As Decimal
    Private mdCompImpuesto_mb As Decimal
    Private mdGastNeto_mb As Decimal
    Private mdGastImpuesto_mb As Decimal
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
    Public Property iva As String
        Get
            Return msIva
        End Get
        Set(value As String)
            msIva = value
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
    Public Property cantentrada As Decimal
        Get
            Return mdCantEntrada
        End Get
        Set(value As Decimal)
            mdCantEntrada = value
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
    Public Property costoimpuesto_mb As Decimal
        Get
            Return mdCostoImpuesto_mb
        End Get
        Set(value As Decimal)
            mdCostoImpuesto_mb = value
        End Set
    End Property
    Public Property compneta_mb As Decimal
        Get
            Return mdCompNeta_mb
        End Get
        Set(value As Decimal)
            mdCompNeta_mb = value
        End Set
    End Property
    Public Property compimpuesto_mb As Decimal
        Get
            Return mdCompImpuesto_mb
        End Get
        Set(value As Decimal)
            mdCompImpuesto_mb = value
        End Set
    End Property
    Public Property gastneto_mb As Decimal
        Get
            Return mdGastNeto_mb
        End Get
        Set(value As Decimal)
            mdGastNeto_mb = value
        End Set
    End Property
    Public Property gastimpuesto_mb As Decimal
        Get
            Return mdGastImpuesto_mb
        End Get
        Set(value As Decimal)
            mdGastImpuesto_mb = value
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
        iva = sRESERVADO_
        codunidad = sCero6_
        cantentrada = 0.00D
        cantsalida = 0.00D
        costo_mb = 0.00D
        costoimpuesto_mb = 0.00D
        compneta_mb = 0.00D
        compimpuesto_mb = 0.00D
        gastneto_mb = 0.00D
        gastimpuesto_mb = 0.00D
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
