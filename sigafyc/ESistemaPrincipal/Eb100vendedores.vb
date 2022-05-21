Public Class Eb100vendedores : Inherits RBase

#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "b100vendedores"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "codvendedor" & sInteger_ & sSF_ &
                                       "nombre" & sString_ & sSF_ &
                                       "abreviado" & sString_ & sSF_ &
                                       "password" & sString_

    Private msCampos_PK() As Integer = {0, 1}
    Private msAutonumerado As String = "codvendedor"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region

#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miCodVendedor As Integer
    Private msNombre As String
    Private msAbreviado As String
    Private msPassword As String
#End Region

    Public Property codEmpresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property

    Public Property codVendedor As Integer
        Get
            Return miCodVendedor
        End Get
        Set(value As Integer)
            miCodVendedor = value
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

    Public Property password As String
        Get
            Return msPassword
        End Get
        Set(value As String)
            msPassword = value
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
        codVendedor = liNumero
        nombre = sRESERVADO_
        abreviado = sRESERVADO_
        password = sRESERVADO_
        Add(sNo_, sNo_)
        Return liNumero
    End Function

    Public Sub CerrarConexion()
        ConteoRegistros(msTableName, "CerrarConexion")
        Desconectar(msTableName)
    End Sub

    Protected Overloads Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
