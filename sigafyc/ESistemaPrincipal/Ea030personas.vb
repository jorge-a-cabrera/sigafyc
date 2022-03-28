Public Class Ea030personas : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "a030personas"

    Private msRequeridos As String = "tipodocumento" & sString_ & sSF_ &
                                       "nrodocumento" & sString_ & sSF_ &
                                       "nombre" & sString_ & sSF_ &
                                       "abreviado" & sString_ & sSF_ &
                                       "direccion" & sString_ & sSF_ &
                                       "ciudad" & sString_ & sSF_ &
                                       "telefono" & sString_ & sSF_ &
                                       "email" & sString_

    Private msCampos_PK() As Integer = {0, 1}
#End Region

#Region "Campos requeridos"
    Private msTipoDocumento As String
    Private msNroDocumento As String
    Private msNombre As String
    Private msAbreviado As String
    Private msDireccion As String
    Private msCiudad As String
    Private msTelefono As String
    Private msEmail As String
#End Region

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

    Public Property direccion As String
        Get
            Return msDireccion
        End Get
        Set(value As String)
            msDireccion = value
        End Set
    End Property

    Public Property ciudad As String
        Get
            Return msCiudad
        End Get
        Set(value As String)
            msCiudad = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return msTelefono
        End Get
        Set(value As String)
            msTelefono = value
        End Set
    End Property

    Public Property email As String
        Get
            Return msEmail
        End Get
        Set(value As String)
            msEmail = value
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
