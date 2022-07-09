Public Class Eb110undalternativas : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "b110undalternativas"
    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "tipo" & sString_ & sSF_ &
                                       "codmercaderia" & sString_ & sSF_ &
                                       "codunidad" & sString_ & sSF_ &
                                       "nomunidad" & sString_ & sSF_ &
                                       "cantidad" & sDecimal_
    Private msCampos_PK() As Integer = {0, 1, 2, 3}
#End Region
#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private msTipo As String
    Private msCodMercaderia As String
    Private msCodUnidad As String
    Private msNomUnidad As String
    Private mdCantidad As Decimal
#End Region
    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
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
    Public Property codmercaderia As String
        Get
            Return msCodMercaderia
        End Get
        Set(value As String)
            msCodMercaderia = value
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
    Public Property nomunidad As String
        Get
            Return msNomUnidad
        End Get
        Set(value As String)
            msNomUnidad = value
        End Set
    End Property
    Public Property cantidad As Decimal
        Get
            Return mdCantidad
        End Get
        Set(value As Decimal)
            mdCantidad = value
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
