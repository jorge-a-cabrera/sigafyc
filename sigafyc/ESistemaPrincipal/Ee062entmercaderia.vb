Public Class Ee062entmercaderia : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "e062entmercaderia"

    'codempresa integer Not NULL,
    'numtransaccion integer Not NULL,
    'numorden integer Not NULL,
    'orgdocumento integer,
    'orgtransaccion integer,
    'gastneto_mb numeric(17, 2),
    'gastimpuesto_mb numeric(17,2),
    'estado character varying(15) COLLATE pg_catalog."default",
    'borrado character varying(1) COLLATE pg_catalog."default",
    'hashid character varying(64) COLLATE pg_catalog."default",
    'CONSTRAINT e052entmercaderia_pkey PRIMARY KEY (codempresa, numtransaccion, numorden)


    Private msRequeridos As String = "codempresa" & sInteger_ & sSF_ &
                                       "numtransaccion" & sInteger_ & sSF_ &
                                       "numorden" & sInteger_ & sSF_ &
                                       "orgtransaccion" & sInteger_ & sSF_ &
                                       "gastneto_mb" & sDecimal_ & sSF_ &
                                       "gastimpuesto_mb" & sDecimal_

    Private msCampos_PK() As Integer = {0, 1, 2}
    Private msAutonumerado As String = "numorden"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region
#Region "Campos requeridos"
    Private miCodEmpresa As Integer
    Private miNumTransaccion As Integer
    Private miNumOrden As Integer
    Private miOrgTransaccion As Integer
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
    Public Property numorden As Integer
        Get
            Return miNumOrden
        End Get
        Set(value As Integer)
            miNumOrden = value
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
    Public Function ReservarRegistro(Optional ByVal piCodEmpresa As Integer = 0, Optional ByVal piNumTransaccion As Integer = 0) As Integer
        codempresa = piCodEmpresa
        numtransaccion = piNumTransaccion
        Dim liNumero As Integer = SiguienteNumero(msAutonumerado, msTableName, msFiltroClave)
        codempresa = piCodEmpresa
        numtransaccion = piNumTransaccion
        numorden = liNumero
        orgtransaccion = 0
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
