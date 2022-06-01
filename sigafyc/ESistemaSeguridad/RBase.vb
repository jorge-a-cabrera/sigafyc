Imports System.Data.Common

Public Class RBase : Inherits Ebase

    Public Overloads Function GetPK(Optional ByVal psHash_Pk As String = sNo_) As String
        Dim lsResultado As String = ""
        Try
            lsResultado = MyBase.GetPK(psHash_Pk)
        Catch ex As BitacoraRegistrar
            BitacoraDatos.Registrar(ex.accion, ex.despues, ex.antes, ex.parametroConexion)
        End Try
        Return lsResultado
    End Function


    Public Overloads Sub Add(Optional ByVal psConfirmar As String = sSi_, Optional ByVal psBitacora As String = sSi_, Optional psDesplegarRegistro As String = sNo_, Optional psMensaje As String = "")
        Try
            MyBase.Add(psConfirmar, psBitacora, psDesplegarRegistro, psMensaje)
        Catch ex As BitacoraRegistrar
            BitacoraDatos.Registrar(ex.accion, ex.despues, ex.antes, ex.parametroConexion)
        End Try
    End Sub

    Public Overloads Sub Del(Optional ByVal psConfirmar As String = sSi_, Optional ByVal psBitacora As String = sSi_)
        Try
            MyBase.Del(psConfirmar, psBitacora)
        Catch ex As BitacoraRegistrar
            BitacoraDatos.Registrar(ex.accion, ex.despues, ex.antes, ex.parametroConexion)
        End Try

    End Sub

    Public Overloads Sub Put(Optional ByVal psConfirmar As String = sSi_, Optional ByVal psBitacora As String = sSi_, Optional ByVal psAccion As String = "")
        Try
            MyBase.Put(psConfirmar, psBitacora, psAccion)
        Catch ex As BitacoraRegistrar
            BitacoraDatos.Registrar(ex.accion, ex.despues, ex.antes, ex.parametroConexion)
        Catch ex As ConfirmacionCancelado
            Throw New ConfirmacionCancelado
        End Try
    End Sub

    Public Function SiguienteNumero(ByVal psAutoNumerado As String, ByVal psTableName As String, Optional ByVal psFiltroClave As String = "") As Integer
        Dim liResultado As Integer = 0
        Dim lsSQL As String = GFsGeneraSQL("Autonumerado")
        lsSQL = lsSQL.Replace("@autonumerado", psAutoNumerado)
        lsSQL = lsSQL.Replace("@tablename", psTableName)
        lsSQL = lsSQL.Replace("@filtrocamposclave", psFiltroClave)
        Dim loDatos As DbDataReader = Nothing
        Try
            loDatos = RecuperarConsulta(lsSQL)
            If loDatos.Read Then
                If Not loDatos.Item("ultimo") Is DBNull.Value Then
                    liResultado = Integer.Parse(loDatos.Item("ultimo").ToString)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("RBase.SiguienteNumero.Read" & ControlChars.CrLf & ex.Message)
        End Try
        loDatos.Close()
        liResultado += 1
        Return liResultado
    End Function

    Public Function FiltroClave(ByVal psRequeridos As String, ByVal piCampos_PK() As Integer, ByVal psAutonumerado As String) As String
        Dim lsResultado As String = ""
        Dim lsCampos() As String = psRequeridos.Split(sSF_)
        For liNDX As Integer = 0 To piCampos_PK.Count - 1
            Dim lsParte() As String = lsCampos(piCampos_PK(liNDX)).Split(sSeparador_)
            If lsParte(0) <> psAutonumerado Then
                If lsResultado.Trim.Length = 0 Then
                    lsResultado &= "AND " & lsParte(0) & " = " & sPrefijoParam_ & lsParte(0)
                Else
                    lsResultado &= ControlChars.CrLf & "AND " & lsParte(0) & " = " & sPrefijoParam_ & lsParte(0)
                End If
            End If
        Next
        Return lsResultado
    End Function

    Public Sub ConteoRegistros(ByVal psTableName As String, Optional ByVal psMomento As String = "Conectar")
        Dim lsKey As String = "ConteoRegistros"
        Dim liResultado As Integer = 0
        Dim lsSQL As String = GFsGeneraSQL(lsKey)
        lsSQL = lsSQL.Replace("&tablename", psTableName)
        Dim loDatos As DbDataReader = Nothing
        Try
            loDatos = RecuperarConsulta(lsSQL)
            If loDatos.Read Then
                If Not loDatos.Item("rowcount") Is DBNull.Value Then
                    liResultado = Integer.Parse(loDatos.Item("rowcount").ToString)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("RBase.ConteoRegistros.Read [" & lsSQL & "]" & ControlChars.CrLf & ex.Message)
        End Try
        loDatos.Close()

        Select Case psMomento
            Case "Conectar"
                Dim lsValor As String = GFsParametroObtener(sGeneral_, lsKey & "_" & psTableName)
                If lsValor = sRESERVADO_ Then
                    GPParametroGuardar(sGeneral_, lsKey & "_" & psTableName, liResultado.ToString)
                Else
                    If IsNumeric(lsValor) Then
                        If liResultado > Integer.Parse(lsValor) Then
                            GPParametroGuardar(sGeneral_, lsKey & "_" & psTableName, liResultado.ToString)
                        Else
                            If liResultado < Integer.Parse(lsValor) Then
                                Dim liDiferencia As Integer = Integer.Parse(lsValor) - liResultado
                                GFsAvisar("Ha(n) sido eliminada(s) de la tabla " & psTableName.ToUpper & ", " & liDiferencia.ToString & " registro(s) fuera del sistema.", sViolacion_, "Esta sesión no podrá continuar, hasta que este problema sea esclarecido y subsanado.")
                            End If
                        End If
                    End If
                End If
            Case Else
                GPParametroGuardar(sGeneral_, lsKey & "_" & psTableName, liResultado.ToString)
        End Select
    End Sub
End Class
