Public Class Ea060clasmerc : Inherits RBase

#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "a060clasmerc"

    Private msRequeridos As String = "tipo" & sString_ & sSF_ &
                                       "codclasificacion" & sInteger_ & sSF_ &
                                       "nombre" & sString_ & sSF_ &
                                       "abreviado" & sString_ & sSF_ &
                                       "listaprecio" & sString_

    Private msCampos_PK() As Integer = {0, 1}
    Private msAutonumerado As String = "codclasificacion"
    Private msFiltroClave As String = FiltroClave(msRequeridos, msCampos_PK, msAutonumerado)
#End Region

#Region "Campos requeridos"
    Private msTipo As String
    Private miCodClasificacion As Integer
    Private msNombre As String
    Private msAbreviado As String
    Private msListaPrecio As String
#End Region
    Public Property tipo As String
        Get
            Return msTipo
        End Get
        Set(value As String)
            msTipo = value
        End Set
    End Property

    Public Property codclasificacion As Integer
        Get
            Return miCodClasificacion
        End Get
        Set(value As Integer)
            miCodClasificacion = value
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

    Public Property listaprecio As String
        Get
            Return msListaPrecio
        End Get
        Set(value As String)
            msListaPrecio = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        SetParametros(msRama, msTableName, msRequeridos, msCampos_PK, Me)
        Conectar(msTableName)
        ConteoRegistros(msTableName)
    End Sub

    Public Function ReservarRegistro(Optional ByVal psTipo As String = sEntrada_) As Integer
        tipo = psTipo
        Dim liNumero As Integer = SiguienteNumero(msAutonumerado, msTableName, msFiltroClave)
        If liNumero = 1 Then
            Select Case psTipo
                Case sSalida_
                    liNumero = Integer.Parse(GFsParametroObtener(sGeneral_, "Ea060clasmerc.Salida.Autonumerado.Desde"))
            End Select
        End If
        tipo = psTipo
        codclasificacion = liNumero
        nombre = sRESERVADO_
        abreviado = sRESERVADO_
        listaprecio = sNo_
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
