Imports ESistemaSeguridad
Imports Utilitarios

Public Class Dss010sistemas

    Private msTableName As String = "ss010sistemas"

    Public Function TieneError(ByVal eSS010 As Ess010sistemas) As Boolean
        Return False
    End Function

    Public Function Insertar(ByVal eSS010 As Ess010sistemas, ByVal db As BaseDatos) As Integer

        Dim strSQL As String = "Insert Into " & msTableName & ControlChars.CrLf &
                                "(" & ControlChars.CrLf &
                                    "codigo," & ControlChars.CrLf &
                                    "nombre," & ControlChars.CrLf &
                                    "estado," & ControlChars.CrLf &
                                    "borrado," & ControlChars.CrLf &
                                    "hashid" & ControlChars.CrLf &
                                ")" & ControlChars.CrLf &
                                    "Values(" & ControlChars.CrLf &
                                    "@codigo," & ControlChars.CrLf &
                                    "@nombre," & ControlChars.CrLf &
                                    "@estado," & ControlChars.CrLf &
                                    "@borrado," & ControlChars.CrLf &
                                    "@hashid" & ControlChars.CrLf &
                                ");"

        db.CrearComando(strSQL)

        db.AsignarParametro("@codigo", eSS010.codigo)
        db.AsignarParametro("@nombre", eSS010.nombre)
        db.AsignarParametro("@estado", eSS010.estado)
        db.AsignarParametro("@borrado", eSS010.borrado)
        db.AsignarParametro("@hashid", eSS010.hashid)

        Return db.EjecutarEscalar()

    End Function

    Public Function Actualizar(ByVal eSS010 As Ess010sistemas, ByVal db As BaseDatos) As Integer

        Dim strSQL As String = "Update " & msTableName & ControlChars.CrLf &
                                "Set " &
                                    "nombre=@nombre, " & ControlChars.CrLf &
                                    "estado=@estado, " & ControlChars.CrLf &
                                    "borrado=@borrado, " & ControlChars.CrLf &
                                    "hashid=@hashid " & ControlChars.CrLf &
                                "Where " & ControlChars.CrLf &
                                    "codigo = @codigo"
        db.CrearComando(strSQL)

        db.AsignarParametro("@codigo", eSS010.codigo)
        db.AsignarParametro("@nombre", eSS010.nombre)
        db.AsignarParametro("@borrado", eSS010.borrado)
        db.AsignarParametro("@hashid", eSS010.hashid)

        Return db.EjecutarComandoNonQuery()
    End Function

    Public Function Eliminar(ByVal codigo As String, ByVal db As BaseDatos) As Integer

        Dim strSQL As String = "Delete From " & msTableName & ControlChars.CrLf &
                               "Where" & ControlChars.CrLf &
                               "codigo = @codigo"

        db.CrearComando(strSQL)

        db.AsignarParametro("@codigo", codigo)

        Return db.EjecutarComandoNonQuery()
    End Function

    Public Function RecuperarEntidad(ByVal car_codigo As Int32, ByVal db As BaseDatos) As ECargos

        Dim ecar As New ECargos

        Dim strSQL As String = "Select * From " & gsDelimitador & "cargos" & gsDelimitador _
                & "Where " & gsDelimitador & "car_codigo" & gsDelimitador & " = @car_codigo"

        db.CrearComando(strSQL)

        db.AsignarParametroEntero("@car_codigo", car_codigo)

        Select Case gsTipoDBMS
            Case sPostgreSQL_
                Dim Datos As NpgsqlDataReader = db.EjecutarConsultaPostgreSQL()

                If Datos.Read() Then
                    ecar.car_codigo = Datos.Item("car_codigo")
                    ecar.car_descripcion = Datos.Item("car_descripcion")
                End If
            Case sMYSQL_
                Dim Datos As MySqlDataReader = db.EjecutarConsultaMySQL()

                If Datos.Read() Then
                    ecar.car_codigo = Datos.Item("car_codigo")
                    ecar.car_descripcion = Datos.Item("car_descripcion")
                End If
            Case Else
                Dim Datos As NpgsqlDataReader = db.EjecutarConsultaPostgreSQL()

                If Datos.Read() Then
                    ecar.car_codigo = Datos.Item("car_codigo")
                    ecar.car_descripcion = Datos.Item("car_descripcion")
                End If
        End Select


        Return ecar

    End Function

    Public Function RecuperarBrows(ByVal db As BaseDatos) As DataSet

        Dim strSQL As String = "Select * From " & gsDelimitador & "cargos" & gsDelimitador

        db.CrearComando(strSQL)

        RecuperarBrows = db.EjecutarConsultaDataSet("cargos")

        Return RecuperarBrows

    End Function

    Public Function RecuperarBrows(ByVal cargos As Integer, ByVal db As BaseDatos) As DataSet

        Dim strSQL As String = "Select * From cargos " _
                            & " Where car_codigo = @car_codigo "


        db.CrearComando(strSQL)

        db.AsignarParametroEntero("@car_codigo", cargos)

        RecuperarBrows = db.EjecutarConsultaDataSet("cargos")

        Return RecuperarBrows

    End Function
End Class