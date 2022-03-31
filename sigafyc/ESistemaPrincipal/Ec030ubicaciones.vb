Public Class Ec030ubicaciones : Inherits RBase

#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "c030ubicaciones"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "coddeposito" & sInteger_ & sSF_ &
                                       "codubicacion" & sString_ & sSF_ &
                                       "nombre" & sString_

    Private msCampos_PK() As Integer = {0, 1, 2}
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miCodDeposito As Integer
    Private msCodUbicacion As String
    Private msNombre As String
#End Region

    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property

    Public Property codDeposito As Integer
        Get
            Return miCodDeposito
        End Get
        Set(value As Integer)
            miCodDeposito = value
        End Set
    End Property

    Public Property codUbicacion As String
        Get
            Return msCodUbicacion
        End Get
        Set(value As String)
            msCodUbicacion = value
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
