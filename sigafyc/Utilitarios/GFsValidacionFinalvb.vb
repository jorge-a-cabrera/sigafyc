Module GFsValidacionFinalvb
    Private Const sDatosRequeridos_ As String = "datos requeridos"

    Public Function GFsValidacionFinal(ByRef poTabControl As TabControl) As String
        Dim lsCamposValidado As String = ""
        Dim lsResultado As String = ""
        For Each loTabPage As TabPage In poTabControl.TabPages
            If loTabPage.Text.Trim.ToLower = sDatosRequeridos_ Then
                For Each loControl As Control In loTabPage.Controls
                    Select Case loControl.Name.Substring(0, 3)
                        Case sPrefijoTextBox_
                            If loControl.AccessibleName.Trim.Length > 0 Then
                                lsCamposValidado &= loControl.AccessibleName.Trim & "->" & loControl.Tag.ToString & ControlChars.CrLf
                            Else
                                lsCamposValidado &= loControl.Name.Trim & "->" & loControl.Tag.ToString & ControlChars.CrLf
                            End If
                            lsResultado &= loControl.Tag.ToString
                        Case sPrefijoComboBox_
                            If loControl.AccessibleName.Trim.Length > 0 Then
                                lsCamposValidado &= loControl.AccessibleName.Trim & "->" & loControl.Tag.ToString & ControlChars.CrLf
                            Else
                                lsCamposValidado &= loControl.Name.Trim & "->" & loControl.Tag.ToString & ControlChars.CrLf
                            End If
                            lsResultado &= loControl.Tag.ToString
                        'Case sPrefijoRadioButton_
                        '    If loControl.AccessibleName.Trim.Length > 0 Then
                        '        lsCamposValidado &= loControl.AccessibleName.Trim & "->" & loControl.Tag.ToString & ControlChars.CrLf
                        '    Else
                        '        lsCamposValidado &= loControl.Name.Trim & "->" & loControl.Tag.ToString & ControlChars.CrLf
                        '    End If
                        '    lsResultado &= loControl.Tag.ToString
                        Case sPrefijoGroupBox_
                            For Each loControl1 As Control In loControl.Controls
                                Select Case loControl1.Name.Substring(0, 3)
                                    Case sPrefijoTextBox_
                                        If loControl1.AccessibleName.Trim.Length > 0 Then
                                            lsCamposValidado &= loControl1.AccessibleName.Trim & "->" & loControl1.Tag.ToString & ControlChars.CrLf
                                        Else
                                            lsCamposValidado &= loControl1.Name.Trim & "->" & loControl1.Tag.ToString & ControlChars.CrLf
                                        End If
                                        lsResultado &= loControl1.Tag.ToString
                                    Case sPrefijoComboBox_
                                        If loControl1.AccessibleName.Trim.Length > 0 Then
                                            lsCamposValidado &= loControl1.AccessibleName.Trim & "->" & loControl1.Tag.ToString & ControlChars.CrLf
                                        Else
                                            lsCamposValidado &= loControl1.Name.Trim & "->" & loControl1.Tag.ToString & ControlChars.CrLf
                                        End If
                                        lsResultado &= loControl1.Tag.ToString
                                        'Case sPrefijoRadioButton_
                                        '    If loControl1.AccessibleName IsNot Nothing Then
                                        '        If loControl1.AccessibleName.Trim.Length > 0 Then
                                        '            lsCamposValidado &= loControl1.AccessibleName.Trim & "->" & loControl1.Tag.ToString & ControlChars.CrLf
                                        '        Else
                                        '            lsCamposValidado &= loControl1.Name.Trim & "->" & loControl1.Tag.ToString & ControlChars.CrLf
                                        '        End If
                                        '    End If
                                        '    lsResultado &= loControl1.Tag.ToString
                                End Select
                            Next
                    End Select
                Next
            End If
        Next
        Return lsResultado & sSF_ & lsCamposValidado
    End Function

End Module
