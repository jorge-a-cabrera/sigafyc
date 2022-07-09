Imports System.Data.Common

Module modGFiCotizacion
    Public Function GFiCotizacion(ByVal psCodMoneda1 As String, ByVal psCodMoneda2 As String, ByVal psVigencia As String) As Integer()
        Dim liResultado() As Integer
        Dim ldVigencia As Date
        If IsDate(psVigencia) Then
            ldVigencia = Date.Parse(psVigencia)
            psVigencia = ldVigencia.ToString(sFormatoFecha1_)
        Else
            psVigencia = Today.ToString(sFormatoFecha1_)
        End If

        liResultado = LFiTraeCotizaciones(psCodMoneda1, psCodMoneda2, psVigencia)
        If liResultado(0) + liResultado(1) = 0 Then
            liResultado = LFiTraeCotizaciones(psCodMoneda2, psCodMoneda1, psVigencia)
        End If

        Return liResultado
    End Function
    Public Function GFiCotizacion(ByVal psCodMoneda1 As String, ByVal psCodMoneda2 As String, ByVal psVigencia As String, ByVal psTipoCotizacion As String) As Integer
        Dim liResultado As Integer
        Dim liValores() As Integer
        Dim ldVigencia As Date
        If IsDate(psVigencia) Then
            ldVigencia = Date.Parse(psVigencia)
            psVigencia = ldVigencia.ToString(sFormatoFecha1_)
        Else
            psVigencia = Today.ToString(sFormatoFecha1_)
        End If

        liValores = LFiTraeCotizaciones(psCodMoneda1, psCodMoneda2, psVigencia)
        If liValores(0) + liValores(1) = 0 Then
            liValores = LFiTraeCotizaciones(psCodMoneda2, psCodMoneda1, psVigencia)
        End If

        Select Case psTipoCotizacion
            Case sCompra_
                liResultado = liValores(0)
            Case sVenta_
                liResultado = liValores(1)
            Case sSemisuma_
                liResultado = (liValores(0) + liValores(1)) \ 2
        End Select

        Return liResultado
    End Function
    Private Function LFiTraeCotizaciones(ByVal psMoneda1 As String, ByVal psMoneda2 As String, ByVal psDesde As String) As Integer()
        Dim liRetorno() As Integer = {0, 0}
        Dim loB030 As New Eb030cotizaciones
        Dim loDat As DbDataReader = Nothing
        Dim lsSQLoriginal As String = GFsGeneraSQL("Cotizaciones")
        Dim lsSQL As String = lsSQLoriginal

        loB030.codMoneda1 = psMoneda1
        loB030.codMoneda2 = psMoneda2
        loDat = loB030.RecuperarConsulta(lsSQL)

        While loDat.Read
            If loDat.Item("valido").ToString <= psDesde Then
                liRetorno(0) = Integer.Parse(loDat.Item("compra").ToString)
                liRetorno(1) = Integer.Parse(loDat.Item("venta").ToString)
                Exit While
            End If
        End While
        loB030.CerrarConexion()
        Return liRetorno
    End Function
End Module
