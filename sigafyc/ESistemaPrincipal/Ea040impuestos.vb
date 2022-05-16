Public Class Ea040impuestos : Inherits RBase
#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "a040impuestos"

    Private msRequeridos As String = "operacion" & sString_ & sSF_ &
                                     "codimpuesto" & sString_ & sSF_ &
                                     "nombre" & sString_ & sSF_ &
                                     "porcbaseimpo" & sDecimal_ & sSF_ &
                                     "tipovalor" & sString_ & sSF_ &
                                     "codmoneda" & sString_ & sSF_ &
                                     "valor" & sDecimal_

    Private msCampos_PK() As Integer = {0, 1}
#End Region

#Region "Campos requeridos"
    Private msOperacion As String
    Private msCodImpuesto As String
    Private msNombre As String
    Private mdPorcBaseImpo As Decimal
    Private msTipoValor As String
    Private msCodMoneda As String
    Private mdValor As Decimal
#End Region

    Public Property operacion As String
        Get
            Return msOperacion
        End Get
        Set(value As String)
            msOperacion = value
        End Set
    End Property

    Public Property codImpuesto As String
        Get
            Return msCodImpuesto
        End Get
        Set(value As String)
            msCodImpuesto = value
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

    Public Property porcBaseImpo As Decimal
        Get
            Return mdPorcBaseImpo
        End Get
        Set(value As Decimal)
            mdPorcBaseImpo = value
        End Set
    End Property

    Public Property tipoValor As String
        Get
            Return msTipoValor
        End Get
        Set(value As String)
            msTipoValor = value
        End Set
    End Property

    Public Property codMoneda As String
        Get
            Return msCodMoneda
        End Get
        Set(value As String)
            msCodMoneda = value
        End Set
    End Property

    Public Property valor As Decimal
        Get
            Return mdValor
        End Get
        Set(value As Decimal)
            mdValor = value
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
