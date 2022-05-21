Public Class Eb060perautgest : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "b060perautgest"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "tipoperfil" & sString_ & sSF_ &
                                       "tipodocumento" & sString_ & sSF_ &
                                       "nrodocumento" & sString_ & sSF_ &
                                       "codmoneda" & sString_ & sSF_ &
                                       "diasvencimiento" & sInteger_ & sSF_ &
                                       "limitecredito" & sDecimal_ & sSF_ &
                                       "limitehabilitacion" & sDecimal_ & sSF_ &
                                       "codsucursal" & sInteger_

    Private msCampos_PK() As Integer = {0, 1, 2, 3}
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private msTipoPerfil As String
    Private msTipoDocumento As String
    Private msNroDocumento As String
    Private msCodMoneda As String
    Private miDiasVencimiento As Integer
    Private mdLimiteCredito As Decimal
    Private mdLimiteHabilitacion As Decimal
    Private miCodSucursal As Integer
#End Region

    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property

    Public Property tipoPerfil As String
        Get
            Return msTipoPerfil
        End Get
        Set(value As String)
            msTipoPerfil = value
        End Set
    End Property

    Public Property tipoDocumento As String
        Get
            Return msTipoDocumento
        End Get
        Set(value As String)
            msTipoDocumento = value
        End Set
    End Property

    Public Property nroDocumento As String
        Get
            Return msNroDocumento
        End Get
        Set(value As String)
            msNroDocumento = value
        End Set
    End Property

    Public Property codMoneda As String
        Get
            Return msCodMoneda
        End Get
        Set(value As String)
            msCodMoneda = value
        End Set
    End Property

    Public Property diasVencimiento As Integer
        Get
            Return miDiasVencimiento
        End Get
        Set(value As Integer)
            miDiasVencimiento = value
        End Set
    End Property

    Public Property limiteCredito As Decimal
        Get
            Return mdLimiteCredito
        End Get
        Set(value As Decimal)
            mdLimiteCredito = value
        End Set
    End Property

    Public Property limiteHabilitacion As Decimal
        Get
            Return mdLimiteHabilitacion
        End Get
        Set(value As Decimal)
            mdLimiteHabilitacion = value
        End Set
    End Property

    Public Property codSucursal As Integer
        Get
            Return miCodSucursal
        End Get
        Set(value As Integer)
            miCodSucursal = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        SetParametros(msRama, msTableName, msRequeridos, msCampos_PK, Me)
        Conectar(msTableName)
        ConteoRegistros(msTableName)
    End Sub

    Public Sub CerrarConexion()
        ConteoRegistros(msTableName, "CerrarConexion")
        Desconectar(msTableName)
    End Sub

    Protected Overloads Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
