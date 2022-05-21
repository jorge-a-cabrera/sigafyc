Public Class Ec050mercvinculadas : Inherits RBase

#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "c050mercvinculadas"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "codsalida" & sString_ & sSF_ &
                                       "codentrada" & sString_ & sSF_ &
                                       "cantidad" & sDecimal_ & sSF_ &
                                       "codunidad" & sString_

    Private msCampos_PK() As Integer = {0, 1}
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private msCodSalida As String
    Private msCodEntrada As String
    Private mdCantidad As Decimal
    Private msCodUnidad As String
#End Region

    Public Property codempresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property

    Public Property codsalida As String
        Get
            Return msCodSalida
        End Get
        Set(value As String)
            msCodSalida = value
        End Set
    End Property
    Public Property codentrada As String
        Get
            Return msCodEntrada
        End Get
        Set(value As String)
            msCodEntrada = value
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

    Public Property codunidad As String
        Get
            Return msCodUnidad
        End Get
        Set(value As String)
            msCodUnidad = value
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
