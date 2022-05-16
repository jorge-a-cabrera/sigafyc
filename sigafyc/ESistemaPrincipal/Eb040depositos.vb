Public Class Eb040depositos : Inherits RBase

#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "b040depositos"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "coddeposito" & sInteger_ & sSF_ &
                                       "nombre" & sString_ & sSF_ &
                                       "abreviado" & sString_ & sSF_ &
                                       "tipdeposito" & sString_ & sSF_ &
                                       "ubicaciones" & sString_

    Private msCampos_PK() As Integer = {0, 1}
    Private msAutonumerado As String = "coddeposito"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miCodDeposito As Integer
    Private msNombre As String
    Private msAbreviado As String
    Private msTipDeposito As String
    Private msUbicaciones As String
#End Region

    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
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

    Public Property tipdeposito As String
        Get
            Return msTipDeposito
        End Get
        Set(value As String)
            msTipDeposito = value
        End Set
    End Property

    Public Property ubicaciones As String
        Get
            Return msUbicaciones
        End Get
        Set(value As String)
            msUbicaciones = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        SetParametros(msRama, msTableName, msRequeridos, msCampos_PK, Me)
        Conectar(msTableName)
        ConteoRegistros(msTableName)
    End Sub

    Public Function ReservarRegistro(Optional ByVal piCodEmpresa As Integer = 0) As Integer
        codEmpresa = piCodEmpresa
        Dim liNumero As Integer = SiguienteNumero(msAutonumerado, msTableName, msFiltroClave)
        codEmpresa = piCodEmpresa
        coddeposito = liNumero
        nombre = sRESERVADO_
        abreviado = sRESERVADO_
        tipdeposito = sRESERVADO_
        ubicaciones = sNo_
        Add(sNo_, sNo_)
        Return liNumero
    End Function

    Public Sub CerrarConexion()
        ConteoRegistros(msTableName)
        Desconectar(msTableName)
    End Sub

    Protected Overloads Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
