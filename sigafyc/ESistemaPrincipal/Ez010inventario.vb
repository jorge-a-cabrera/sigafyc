Public Class Ez010inventario : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "z010inventario"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "codmercaderia" & sString_ & sSF_ &
                                       "tipo" & sString_ & sSF_ &
                                       "periodo" & sString_ & sSF_ &
                                       "coddeposito" & sInteger_ & sSF_ &
                                       "codubicacion" & sString_ & sSF_ &
                                       "cantentrada" & sDecimal_ & sSF_ &
                                       "cantsalida" & sDecimal_ & sSF_ &
                                       "impentneto_mb" & sDecimal_ & sSF_ &
                                       "impentimpuesto_mb" & sDecimal_ & sSF_ &
                                       "impsalneto_mb" & sDecimal_ & sSF_ &
                                       "impsalimpuesto_mb" & sDecimal_

    Private msCampos_PK() As Integer = {0, 1, 2, 3, 4, 5}
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private msCodMercaderia As String
    Private msTipo As String
    Private msPeriodo As String
    Private miCodDeposito As Integer
    Private msCodUbicacion As String
    Private mdCantEntrada As Decimal
    Private mdCantSalida As Decimal
    Private mdImpEntNeto_mb As Decimal
    Private mdImpEntImpuesto_mb As Decimal
    Private mdImpSalNeto_mb As Decimal
    Private mdImpSalImpuesto_mb As Decimal
#End Region

    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
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
    Public Property tipo As String
        Get
            Return msTipo
        End Get
        Set(value As String)
            msTipo = value
        End Set
    End Property
    Public Property periodo As String
        Get
            Return msPeriodo
        End Get
        Set(value As String)
            msPeriodo = value
        End Set
    End Property
    Public Property coddeposito As Integer
        Get
            Return miCodDeposito
        End Get
        Set(value As Integer)
            miCodDeposito = value
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
    Public Property impentneto_mb As Decimal
        Get
            Return mdImpEntNeto_mb
        End Get
        Set(value As Decimal)
            mdImpEntNeto_mb = value
        End Set
    End Property
    Public Property impentimpuesto_mb As Decimal
        Get
            Return mdImpEntImpuesto_mb
        End Get
        Set(value As Decimal)
            mdImpEntImpuesto_mb = value
        End Set
    End Property
    Public Property impsalneto_mb As Decimal
        Get
            Return mdImpSalNeto_mb
        End Get
        Set(value As Decimal)
            mdImpSalNeto_mb = value
        End Set
    End Property
    Public Property impsalimpuesto_mb As Decimal
        Get
            Return mdImpSalImpuesto_mb
        End Get
        Set(value As Decimal)
            mdImpSalImpuesto_mb = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        SetParametros(msRama, msTableName, msRequeridos, msCampos_PK, Me)
        Conectar(msTableName)
    End Sub
    Public Sub CerrarConexion()
        Desconectar(msTableName)
    End Sub
    Protected Overloads Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
