Public Class Eb081timbotros : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_

    Private msTableName As String = "b081timbotros"

    Private msRequeridos As String = "numtimbrado" & sString_ & sSF_ &
                                       "prefijo" & sString_ & sSF_ &
                                       "tipo" & sString_ & sSF_ &
                                       "desdenumero" & sInteger_ & sSF_ &
                                       "hastanumero" & sInteger_

    Private msCampos_PK() As Integer = {0, 1}
#End Region

#Region "Campos requeridos"
    Private msNumTimbrado As String
    Private msPrefijo As String
    Private msTipo As String
    Private miDesdeNumero As Integer
    Private miHastaNumero As Integer
#End Region

    Public Property numTimbrado As String
        Get
            Return msNumTimbrado
        End Get
        Set(value As String)
            msNumTimbrado = value
        End Set
    End Property

    Public Property prefijo As String
        Get
            Return msPrefijo
        End Get
        Set(value As String)
            msPrefijo = value
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

    Public Property desdeNumero As Integer
        Get
            Return miDesdeNumero
        End Get
        Set(value As Integer)
            miDesdeNumero = value
        End Set
    End Property
    Public Property hastaNumero As Integer
        Get
            Return miHastaNumero
        End Get
        Set(value As Integer)
            miHastaNumero = value
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
