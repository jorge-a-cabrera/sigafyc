Public Class Ee062entmercaderia : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e062entmercaderia"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "numorden" & sInteger_ & sSF_ &
                                       "orgdocumento" & sInteger_ & sSF_ &
                                       "orgtransaccion" & sInteger_ & sSF_ &
                                       "impneto_mb" & sDecimal_ & sSF_ &
                                       "impuesto_mb" & sDecimal_

    Private msCampos_PK() As Integer = {0, 1, 2}
    Private msAutonumerado As String = "numorden"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region
#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miNumTransaccion As Integer
    Private miNumOrden As Integer
    Private miOrgDocumento As Integer
    Private miOrgTransaccion As Integer
    Private mdImpNeto_mb As Decimal
    Private mdImpuesto_mb As Decimal
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
    Public Property numorden As Integer
        Get
            Return miNumOrden
        End Get
        Set(value As Integer)
            miNumOrden = value
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
    Public Property impneto_mb As Decimal
        Get
            Return mdImpNeto_mb
        End Get
        Set(value As Decimal)
            mdImpNeto_mb = value
        End Set
    End Property
    Public Property impuesto_mb As Decimal
        Get
            Return mdImpuesto_mb
        End Get
        Set(value As Decimal)
            mdImpuesto_mb = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        SetParametros(msRama, msTableName, msRequeridos, msCampos_PK, Me)
        Conectar(msTableName)
    End Sub
    Public Function ReservarRegistro(Optional ByVal piCodEmpresa As Integer = 0, Optional ByVal piNumTransaccion As Integer = 0) As Integer
        codempresa = piCodEmpresa
        numtransaccion = piNumTransaccion
        Dim liNumero As Integer = SiguienteNumero(msAutonumerado, msTableName, msFiltroClave)
        codempresa = piCodEmpresa
        numtransaccion = piNumTransaccion
        numorden = liNumero
        orgdocumento = 0
        orgtransaccion = 0
        impneto_mb = 0.00D
        impuesto_mb = 0.00D
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
