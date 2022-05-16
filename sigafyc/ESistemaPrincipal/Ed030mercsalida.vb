Public Class Ed030mercsalida : Inherits RBase

#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "d030mercsalida"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "codmercaderia" & sString_ & sSF_ &
                                       "nombre" & sString_ & sSF_ &
                                       "abreviado" & sString_ & sSF_ &
                                       "codunidad" & sString_ & sSF_ &
                                       "codclasificacion" & sInteger_ & sSF_ &
                                       "listaprecio" & sString_ & sSF_ &
                                       "codbarra" & sString_

    Private msCampos_PK() As Integer = {0, 1}
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private msCodMercaderia As String
    Private msNombre As String
    Private msAbreviado As String
    Private msCodUnidad As String
    Private miCodClasificacion As Integer
    Private msListaPrecio As String
    Private msCodBarra As String
#End Region

    Public Property codempresa As Integer
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

    Public Property nombre As String
        Get
            Return msNombre
        End Get
        Set(value As String)
            msNombre = value
        End Set
    End Property

    Public Property abreviado As String
        Get
            Return msAbreviado
        End Get
        Set(value As String)
            msAbreviado = value
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

    Public Property codclasificacion As Integer
        Get
            Return miCodClasificacion
        End Get
        Set(value As Integer)
            miCodClasificacion = value
        End Set
    End Property

    Public Property listaprecio As String
        Get
            Return msListaPrecio
        End Get
        Set(value As String)
            msListaPrecio = value
        End Set
    End Property

    Public Property codbarra As String
        Get
            Return msCodBarra
        End Get
        Set(value As String)
            msCodBarra = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        SetParametros(msRama, msTableName, msRequeridos, msCampos_PK, Me)
        Conectar(msTableName)
        ConteoRegistros(msTableName)
    End Sub

    Public Sub CerrarConexion()
        ConteoRegistros(msTableName)
        Desconectar(msTableName)
    End Sub

    Protected Overloads Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
