Public Class Eb080timbotros : Inherits RBase

#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_

    Private msTableName As String = "b080timbotros"

    Private msRequeridos As String = "numtimbrado" & sString_ & sSF_ &
                                       "tipodocumento" & sString_ & sSF_ &
                                       "nrodocumento" & sString_ & sSF_ &
                                       "valido" & sString_ & sSF_ &
                                       "expira" & sString_

    Private msCampos_PK() As Integer = {0}
#End Region

#Region "Campos requeridos"
    Private msNumTimbrado As String
    Private msTipoDocumento As String
    Private msNroDocumento As String
    Private msValido As String
    Private msExpira As String
#End Region

    Public Property numTimbrado As String
        Get
            Return msNumTimbrado
        End Get
        Set(value As String)
            msNumTimbrado = value
        End Set
    End Property

    Public Property tipodocumento As String
        Get
            Return msTipoDocumento
        End Get
        Set(value As String)
            msTipoDocumento = value
        End Set
    End Property

    Public Property nrodocumento As String
        Get
            Return msNroDocumento
        End Get
        Set(value As String)
            msNroDocumento = value
        End Set
    End Property

    Public Property valido As String
        Get
            Return msValido
        End Get
        Set(value As String)
            msValido = value
        End Set
    End Property

    Public Property expira As String
        Get
            Return msExpira
        End Get
        Set(value As String)
            msExpira = value
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
