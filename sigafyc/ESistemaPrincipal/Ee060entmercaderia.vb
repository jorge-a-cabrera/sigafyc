Public Class Ee060entmercaderia : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e060entmercaderia"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "coddeposito" & sInteger_ & sSF_ &
                                       "orgdocumento" & sInteger_ & sSF_ &
                                       "orgtransaccion" & sInteger_ & sSF_ &
                                       "fecoperacion" & sString_ & sSF_ &
                                       "fecrendicion" & sString_ & sSF_ &
                                       "fase" & sString_

    Private msCampos_PK() As Integer = {0, 1}
    Private msAutonumerado As String = "numtransaccion"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region
#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miNumTransaccion As Integer
    Private miCodDeposito As Integer
    Private miOrgDocumento As Integer
    Private miOrgTransaccion As Integer
    Private msFecOperacion As String
    Private msFecRendicion As String
    Private msFase As String
#End Region
    Public Property codempresa As Integer
        Get
            Return miCodEmpresa
        End Get
        Set(value As Integer)
            miCodEmpresa = value
        End Set
    End Property
    Public Property numtransaccion As Integer
        Get
            Return miNumTransaccion
        End Get
        Set(value As Integer)
            miNumTransaccion = value
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
    Public Property orgdocumento As Integer
        Get
            Return miOrgDocumento
        End Get
        Set(value As Integer)
            miOrgDocumento = value
        End Set
    End Property
    Public Property orgtransaccion As Integer
        Get
            Return miOrgTransaccion
        End Get
        Set(value As Integer)
            miOrgTransaccion = value
        End Set
    End Property
    Public Property fecoperacion As String
        Get
            Return msFecOperacion
        End Get
        Set(value As String)
            msFecOperacion = value
        End Set
    End Property
    Public Property fecrendicion As String
        Get
            Return msFecRendicion
        End Get
        Set(value As String)
            msFecRendicion = value
        End Set
    End Property
    Public Property fase As String
        Get
            Return msFase
        End Get
        Set(value As String)
            msFase = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        SetParametros(msRama, msTableName, msRequeridos, msCampos_PK, Me)
        Conectar(msTableName)
    End Sub
    Public Function ReservarRegistro(Optional ByVal piCodEmpresa As Integer = 0) As Integer
        codempresa = piCodEmpresa
        Dim liNumero As Integer = SiguienteNumero(msAutonumerado, msTableName, msFiltroClave)
        codempresa = piCodEmpresa
        numtransaccion = liNumero
        coddeposito = 0
        orgdocumento = 0
        orgtransaccion = 0
        fecoperacion = sRESERVADO_
        fecrendicion = sRESERVADO_
        fase = sRESERVADO_
        Add(sNo_, sNo_)
        Return liNumero
    End Function
    Public Sub CerrarConexion()
        Desconectar(msTableName)
    End Sub
    Protected Overloads Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
