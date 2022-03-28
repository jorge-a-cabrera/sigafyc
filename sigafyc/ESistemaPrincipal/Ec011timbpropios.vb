﻿Public Class Ec011timbpropios : Inherits RBase

#Region "Campos de control"
    Private msRama As String = sRegistryTablasPrincipal_
    Private msTableName As String = "c011timbpropios"

    Private msRequeridos As String = "numtimbrado" & sString_ & sSF_ &
                                       "codsucursal" & sInteger_ & sSF_ &
                                       "prefijo" & sString_ & sSF_ &
                                       "desdenumero" & sInteger_ & sSF_ &
                                       "hastanumero" & sInteger_

    Private msCampos_PK() As Integer = {0, 1, 2}
#End Region

#Region "Campos requeridos"
    Private msNumTimbrado As String
    Private miCodSucursal As Integer
    Private msPrefijo As String
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

    Public Property codSucursal As Integer
        Get
            Return miCodSucursal
        End Get
        Set(value As Integer)
            miCodSucursal = value
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
    End Sub

    Public Sub CerrarConexion()
        Desconectar(msTableName)
    End Sub

    Protected Overloads Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
