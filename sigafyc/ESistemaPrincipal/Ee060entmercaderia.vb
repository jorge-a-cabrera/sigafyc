Public Class Ee060entmercaderia : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e060entmercaderia"

    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "coddeposito" & sInteger_ & sSF_ &
                                       "orgtransaccion" & sInteger_ & sSF_ &
                                       "fecoperacion" & sString_ & sSF_ &
                                       "fecvigencia" & sString_ & sSF_ &
                                       "compneta_mb" & sDecimal_ & sSF_ &
                                       "compimpuesto_mb" & sDecimal_ & sSF_ &
                                       "gastneto_mb" & sDecimal_ & sSF_ &
                                       "gastimpuesto_mb" & sDecimal_

    Private msCampos_PK() As Integer = {0, 1}
    Private msAutonumerado As String = "numtransaccion"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region
#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miNumTransaccion As Integer
    Private miCodDeposito As Integer
    Private miOrgTransaccion As Integer
    Private msFecOperacion As String
    Private msFecVigencia As String
    Private mdCompNeta_mb As Decimal
    Private mdCompImpuesto_mb As Decimal
    Private mdGastNeto_mb As Decimal
    Private mdGastImpuesto_mb As Decimal
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
    Public Property fecvigencia As String
        Get
            Return msFecVigencia
        End Get
        Set(value As String)
            msFecVigencia = value
        End Set
    End Property
    Public Property compneta_mb As Decimal
        Get
            Return mdCompNeta_mb
        End Get
        Set(value As Decimal)
            mdCompNeta_mb = value
        End Set
    End Property
    Public Property compimpuesto_mb As Decimal
        Get
            Return mdCompImpuesto_mb
        End Get
        Set(value As Decimal)
            mdCompImpuesto_mb = value
        End Set
    End Property
    Public Property gastneto_mb As Decimal
        Get
            Return mdGastNeto_mb
        End Get
        Set(value As Decimal)
            mdGastNeto_mb = value
        End Set
    End Property
    Public Property gastimpuesto_mb As Decimal
        Get
            Return mdGastImpuesto_mb
        End Get
        Set(value As Decimal)
            mdGastImpuesto_mb = value
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
        orgtransaccion = 0
        fecoperacion = sFormatoFecha1_
        fecvigencia = sFormatoFecha1_
        compneta_mb = 0.00D
        compimpuesto_mb = 0.00D
        gastneto_mb = 0.00D
        gastimpuesto_mb = 0.00D
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
