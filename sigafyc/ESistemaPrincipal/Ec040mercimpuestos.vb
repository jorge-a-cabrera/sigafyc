Public Class Ec040mercimpuestos : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "c040mercimpuestos"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "operacion" & sString_ & sSF_ &
                                       "codmercaderia" & sInteger_ & sSF_ &
                                       "codimpuesto" & sString_

    Private msCampos_PK() As Integer = {0, 1, 2, 3}
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private msOperacion As String
    Private msCodMercaderia As String
    Private msCodImpuesto As String
#End Region

    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property

    Public Property operacion As String
        Get
            Return msOperacion
        End Get
        Set(value As String)
            msOperacion = value
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

    Public Property codImpuesto As String
        Get
            Return msCodImpuesto
        End Get
        Set(value As String)
            msCodImpuesto = value
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
