Public Class Ee020listaprecio : Inherits RBase

#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e020listaprecio"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "codmercaderia" & sString_ & sSF_ &
                                       "codunidad" & sString_ & sSF_ &
                                       "vigencia" & sString_ & sSF_ &
                                       "tipoprecio" & sString_ & sSF_ &
                                       "valor" & sDecimal_ & sSF_ &
                                       "codmoneda" & sString_

    Private msCampos_PK() As Integer = {0, 1, 2, 3}
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private msCodMercaderia As String
    Private msCodUnidad As String
    Private msVigencia As String
    Private msTipoPrecio As String
    Private mdValor As Decimal
    Private msCodMoneda As String
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

    Public Property codunidad As String
        Get
            Return msCodUnidad
        End Get
        Set(value As String)
            msCodUnidad = value
        End Set
    End Property

    Public Property vigencia As String
        Get
            Return msVigencia
        End Get
        Set(value As String)
            msVigencia = value
        End Set
    End Property

    Public Property tipoprecio As String
        Get
            Return msTipoPrecio
        End Get
        Set(value As String)
            msTipoPrecio = value
        End Set
    End Property

    Public Property valor As Decimal
        Get
            Return mdValor
        End Get
        Set(value As Decimal)
            mdValor = value
        End Set
    End Property

    Public Property codmoneda As String
        Get
            Return msCodMoneda
        End Get
        Set(value As String)
            msCodMoneda = value
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
