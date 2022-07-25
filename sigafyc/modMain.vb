Imports System.Data.Common

Module modMain
    Private moSesionActiva As SesionActiva
    Private moBitacoraProceso As BitacoraProceso

    Sub Main()
        LPInicializaRegistry()
        LPAbreSesionInicializaBitacora()
        LPInicializaTablaGeneral()

        Dim lsControl = moSesionActiva.VerificaControl
        If lsControl <> sOk_ Then
            Dim lsParte() As String = lsControl.Split(sSF_)
            GFsAvisar(lsParte(0), sViolacion_, lsParte(1))
        Else
            LPInicializaParametros()
            Dim loLoginAcceso As New frmFLoginAcceso
            loLoginAcceso.ShowDialog()
            If loLoginAcceso.Tag Is Nothing Then loLoginAcceso.Tag = sCancelar_

            If loLoginAcceso.Tag.ToString = sOk_ Then
                LPParametrosUsuarios()
                Dim loMenuPrincipal As New frmMenuPrincipal
                Application.Run(loMenuPrincipal)
            End If
        End If

        LPReseteaRegistry()
        LPControlesFinales()
    End Sub

    Private Sub LPInicializaRegistry()
        '------------------------------------------------------------------------------------
        '    INCLUIR EN ESTE PROCEDIMEINTO TODAS LAS INICIALIZACIONES QUE SEAN NECESARIAS
        '    TENER PARA QUE EL SISTEMA PUEDA FUNCIONAR.
        '------------------------------------------------------------------------------------
        If GFsGetRegistry(sSeguridad_, sPasswordReset_) = sNOAUTORIZADO_ Then
            GPSavRegistry(sSeguridad_, sPasswordReset_, sRESERVADO_)
        End If
        If GFsGetRegistry(sSeguridad_, sForcedSalt_) = sNOAUTORIZADO_ Then
            GPSavRegistry(sSeguridad_, sForcedSalt_, sRESERVADO_)
        End If

        If GFsGetRegistry(sSeguridad_, sUbicacionBitacora_) = sRESERVADO_ Then
            GPSavRegistry(sSeguridad_, sUbicacionBitacora_, My.Application.Info.DirectoryPath.Substring(0, 2) & sDS_ & My.Application.Info.AssemblyName & sDS_ & "Bitacoras")
        End If
        If GFsGetRegistry(sSesion_, "MenuPrincipal_X") = sRESERVADO_ Then
            GPSavRegistry(sSesion_, "MenuPrincipal_X", "100")
        End If
        If GFsGetRegistry(sSesion_, "MenuPrincipal_Y") = sRESERVADO_ Then
            GPSavRegistry(sSesion_, "MenuPrincipal_Y", "100")
        End If
    End Sub

    Private Sub LPInicializaTablaGeneral()
        Dim lsTipo As String = ""
        Dim lsClave As String = ""
        Dim lsValor As String = ""
        Dim lsCodigo As String = ""
        lsTipo = sGeneral_

        lsClave = "Tabla general - SQL del sistema"
        lsValor = "SQLGeneral"
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If
        GPTablaGeneralObtener(lsCodigo)

        lsClave = "Mail - Address - To"
        lsValor = "MailBitacora_AddressTo"
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If
        GPTablaGeneralObtener(lsCodigo)

        lsClave = "Mail - Address - CC"
        lsValor = "MailBitacora_AddressCC"
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If
        GPTablaGeneralObtener(lsCodigo)

        lsClave = "Mail - Address - CCO"
        lsValor = "MailBitacora_AddressCCO"
        lsCodigo = GFsParametroObtener(lsTipo, lsClave)
        If lsCodigo = sRESERVADO_ Then
            lsCodigo = lsValor
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If
        GPTablaGeneralObtener(lsCodigo)
    End Sub

    Private Sub LPAbreSesionInicializaBitacora()
        moSesionActiva = New SesionActiva
        moSesionActiva.CargaParametros()
        moBitacoraProceso = New BitacoraProceso
        moBitacoraProceso.Inicializa()
        moBitacoraProceso = Nothing
    End Sub

    Private Sub LPReseteaRegistry()
        GPSavRegistry(sSeguridad_, sPasswordReset_, sRESERVADO_)
    End Sub

    Private Function LFsConexionDBMS() As String
        Dim lsRama As String
        Dim lsTitulo As String = ""
        Dim lsResultado As String = ""

        lsRama = sRegistryTablasSeguridad_ & sGeneral_ & sDS_
        lsTitulo = sSeguridad_
        lsResultado &= LFsEstableceConexion(lsRama, lsTitulo)

        lsRama = sRegistryTablasPrincipal_ & sGeneral_ & sDS_
        lsTitulo = sPrincipal_
        lsResultado &= LFsEstableceConexion(lsRama, lsTitulo)

        lsRama = sRegistryTablasBasura_ & sGeneral_ & sDS_
        lsTitulo = sBasura_
        lsResultado &= LFsEstableceConexion(lsRama, lsTitulo)

        If InStr(lsResultado, sError_) > 0 Then
            lsResultado = sError_
        Else
            lsResultado = sOk_
        End If

        Return lsResultado
    End Function

    Private Sub LPInicializaParametros()
        LPParametrosGenerales()
        LPParametrosLocales()
        LPParametrosFechas()
        LPParametrosModulos()
    End Sub

    Private Sub LPParametrosGenerales()
        Dim lsProcedureName As String = "Parametros Generales"
        Dim lsTipo As String = sGeneral_
        Dim lsClave As String
        Dim lsValor As String

        lsClave = "Ubicacion - Imagen"
        lsValor = My.Application.Info.DirectoryPath.Substring(0, 2) & sDS_ & My.Application.Info.AssemblyName & sDS_ & "Imagenes"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
            GPDirectoryCheck(lsValor)
        End If

        lsClave = "Ubicacion - Audio"
        lsValor = My.Application.Info.DirectoryPath.Substring(0, 2) & sDS_ & My.Application.Info.AssemblyName & sDS_ & "Audios"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
            GPDirectoryCheck(lsValor)
        End If

        lsClave = "Ubicacion - PDF"
        lsValor = My.Application.Info.DirectoryPath.Substring(0, 2) & sDS_ & My.Application.Info.AssemblyName & sDS_ & "PDF"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
            GPDirectoryCheck(lsValor)
        End If

        lsClave = "Ubicacion - Archivos exportados"
        lsValor = My.Application.Info.DirectoryPath.Substring(0, 2) & sDS_ & My.Application.Info.AssemblyName & sDS_ & "Exportados"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
            GPDirectoryCheck(lsValor)
        End If

        lsClave = "Ubicacion - Archivo menu"
        lsValor = My.Application.Info.DirectoryPath.Substring(0, 2) & sDS_ & My.Application.Info.AssemblyName & sDS_ & "Menues"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
            GPDirectoryCheck(lsValor)
        End If

        lsClave = "Archivo menu"
        lsValor = My.Application.Info.AssemblyName & "_v" & My.Application.Info.Version.Major.ToString & My.Application.Info.Version.Minor.ToString & My.Application.Info.Version.Revision.ToString & "_menues.mnu"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Version Actual Sistema - Indicador de salida"
        lsValor = "1"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Informe - Titulo Complemento"
        lsValor = "<<*** //\\ ***>>"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Desarrollador sistema - email"
        lsValor = "jorge_antonio_cabrera@msn.com"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Desarrollador sistema - telefono"
        lsValor = "+595971519445"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Desarrollador sistema - sitio web"
        lsValor = "https://www.linkedin.com/in/jorge-antonio-cabrera-gonzalez-28319312"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Generar Archivos - Texto - Separador"
        lsValor = ";"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Confirmacion - Desplegar"
        lsValor = sSi_
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Envio de Mail - Max Tamaño en byte adjunto"
        lsValor = "1048576"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Mail - Servidor SMTP"
        lsValor = "smtp.gmail.com"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Mail - Servidor SMTP Port"
        lsValor = "587"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Mail - Username"
        lsValor = SesionActiva.sistema.ToLower & ".main"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Mail - Password"
        lsValor = "t3k0p1r3#864222"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Mail - Address - From Cuenta"
        lsValor = SesionActiva.sistema.ToLower & ".main@gmail.com"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Mail - Address - From Nombre Completo"
        Dim loSS010 As New Ess010sistemas
        loSS010.codigo = SesionActiva.sistema
        If loSS010.GetPK = sOk_ Then
            lsValor = loSS010.nombre
        Else
            lsValor = "Sistema de Auditoria y Seguridad"
        End If
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Mail - Address - To"
        lsValor = "MailBitacora_AddressTo"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Mail - Address - CC"
        lsValor = "MailBitacora_AddressCC"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Mail - Address - CCO"
        lsValor = "MailBitacora_AddressCCO"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Ea060clasmerc.Salida.Autonumerado.Desde"
        lsValor = "10001"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Sistema en Producción"
        lsValor = sNo_
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Ubicacion predeterminada por Deposito"
        lsValor = "Recepcionados"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If
    End Sub

    Private Sub LPParametrosLocales()
        Dim lsProcedureName As String = "Parametros Locales"
        Dim lsTipo As String = sLocal_
        Dim lsClave As String
        Dim lsValor As String
        ' GPBitacoraRegistrar(sENTRO_, lsProcedureName)

        lsClave = "Version Actual Sistema"
        lsValor = My.Application.Info.Version.ToString
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Version Actual Sistema - Diferencia permitida"
        lsValor = "5"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Informe - Tamaño pagina"
        lsValor = eTipoHoja.A4.ToString
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Informe - Orientacion pagina"
        lsValor = eOrientacion.Vertical.ToString
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Sesion - Fecha/Hora ultimo acceso_"
        lsValor = Now.ToString(sFormatoFechaHora1_)
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor, sNo_)
        End If

        lsClave = "Ubicacion - SQL"
        lsValor = My.Application.Info.DirectoryPath.Substring(0, 2) & sDS_ & My.Application.Info.AssemblyName & sDS_ & "SQL"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
            GPDirectoryCheck(lsValor)
        End If

        ' GPBitacoraRegistrar(sSALIO_, lsProcedureName)
    End Sub

    Private Sub LPParametrosUsuarios()
        Dim lsProcedureName As String = "Parametros Usuarios"
        Dim lsTipo As String = sUsuario_
        Dim lsClave As String
        Dim lsValor As String

        lsClave = "Informe - Borrar Archivos temporales"
        lsValor = sSi_
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Bitacora proceso - Eliminar despues enviar mail"
        lsValor = sSi_
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Archivo menu"
        lsValor = GFsParametroObtener(sGeneral_, lsClave)
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        lsClave = "Dias anteriores para carga de Compras"
        lsValor = "30"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor, sNo_)
        End If
    End Sub

    Private Sub LPParametrosFechas()
        Dim lsProcedureName As String = "Parametros Fechas"
        Dim lsTipo As String = sFecha_
        Dim lsClave As String
        Dim lsValor As String
        ' GPBitacoraRegistrar(sENTRO_, lsProcedureName)

        lsClave = "Caja - Hora de cierre"
        lsValor = "15:59:59"
        If GFsParametroObtener(lsTipo, lsClave) = sRESERVADO_ Then
            GPParametroGuardar(lsTipo, lsClave, lsValor)
        End If

        ' GPBitacoraRegistrar(sSALIO_, lsProcedureName)
    End Sub

    Private Sub LPParametrosModulos()
        '---------------------------------------------------------------------------
        'TODO: AQUI DEBEN INDICARSE LAS INICIALIZACIONES DE PARAMETROS PARA
        '      UN MODULO ESPECIFICO.
        '---------------------------------------------------------------------------
    End Sub

    Private Function LFsEstableceConexion(ByVal psRama As String, ByVal psTitulo As String) As String
        Dim lsResultado As String = sOk_
        Dim loParametroConexion As New ParametrosConexion
        Dim loConexion As BaseDatos
        loParametroConexion.dbms = LFsRecuperaParametroConexion(psRama, loParametroConexion.claveDbms)
        loParametroConexion.server = LFsRecuperaParametroConexion(psRama, loParametroConexion.claveServer)
        loParametroConexion.port = LFsRecuperaParametroConexion(psRama, loParametroConexion.clavePort)
        loParametroConexion.database = LFsRecuperaParametroConexion(psRama, loParametroConexion.claveDatabase)
        loParametroConexion.user = LFsRecuperaParametroConexion(psRama, loParametroConexion.claveUser)
        loParametroConexion.password = LFsRecuperaParametroConexion(psRama, loParametroConexion.clavePassword)
        loConexion = New BaseDatos
        Try
            loConexion.Configurar(loParametroConexion)
            loConexion.Conectar("ConexionDB")
        Catch ex As BaseDatosException
            Dim loParametroAviso As New ParametrosAviso
            loParametroAviso.titulo = psTitulo
            loParametroAviso.parametroConexion = loParametroConexion
            loParametroAviso.mensajeError = ex.Message
            GFsAvisar(loParametroAviso)
            lsResultado = sError_
        Catch ex As DbException
            Dim loParametroAviso As New ParametrosAviso
            loParametroAviso.titulo = psTitulo
            loParametroAviso.parametroConexion = loParametroConexion
            loParametroAviso.codigoError = ex.ErrorCode.ToString
            loParametroAviso.mensajeError = ex.Message
            GFsAvisar(loParametroAviso)
            lsResultado = sError_
        Finally
            loConexion.Desconectar("ConexionDB")
        End Try
        loConexion = Nothing

        Return lsResultado
    End Function

    Private Function LFsRecuperaParametroConexion(ByVal psRama As String, ByVal psClave As String) As String
        Dim lsRama As String = psRama & sResetear_ & sDS_
        Dim lsClave As String = psClave.Substring(0, psClave.Length - 1)
        Dim lsResultado As String

        lsResultado = GFsGetRegistry(lsRama, lsClave)
        If lsResultado <> sRESERVADO_ Then
            If SesionActiva.AutorizadoResetear(lsRama, lsClave, lsResultado) = sSi_ Then
                GPSavRegistry(psRama, psClave, lsResultado)
                GPSavRegistry(lsRama, lsClave, sRESERVADO_)
            End If
        End If

        lsResultado = GFsGetRegistry(psRama, psClave)
        Return lsResultado
    End Function

    Private Sub LPControlesFinales()
        Dim lsFilename As String = ""
        Dim lsArchivoBitacora As String = ""
        '-------------------------------------------------------------------------------------------
        'TODO: Incluir los Controles Finales antes de salir del sistema
        '-------------------------------------------------------------------------------------------
        GPActualizaUltimoAcceso()
        Dim loBitacoraProceso As New BitacoraProceso
        loBitacoraProceso.Cerrar()
        lsFilename = BitacoraProceso.fileName
        lsArchivoBitacora = BitacoraProceso.archivoBitacora
        loBitacoraProceso = Nothing
        moSesionActiva.EnviarBitacoraCorreo(lsFilename, lsArchivoBitacora)
        moSesionActiva = Nothing
    End Sub

End Module
