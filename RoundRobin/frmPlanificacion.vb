Public Class frmPlanificacion

    'Esta variable sirve para el random de los colores
    Private m_Rnd As New Random

    Private Ultima_Fila As Integer = 0
    Private Ultima_Columa As Integer = 0

    Private Sub frmPlanificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Agrega 100 lineas a la lista de planificación
        For i As Integer = 0 To 300
            dgridRoundRobin.Rows.Add()
        Next

    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click

        Try

            'Este procedimiento agrega los procesos con el requerimiento del CPU
            If (txtProceso.Text.Trim = "") Then

                MsgBox("Ingrese el nombre del proceso", MsgBoxStyle.Information, Me.Text)

            ElseIf txtRequerimientoCPU.Value = 0 Then

                MsgBox("Ingrese el requerimiento de CPU >0 ", MsgBoxStyle.Information, Me.Text)

            Else

                Dim vColor As Color = RandomColor()
                tblprocesos.Rows.Add(txtProceso.Text, txtRequerimientoCPU.Value, vColor.Name.ToString, txtRequerimientoCPU.Value)

                txtProceso.Text = ""
                txtProceso.Focus()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function RandomColor() As Color

        Try

            'Asigna un color random al proceso
            Dim names As KnownColor() = DirectCast([Enum].GetValues(GetType(KnownColor)), KnownColor())
            Dim randomColorName As KnownColor = names(m_Rnd.[Next](names.Length))
            RandomColor = Color.FromKnownColor(randomColorName)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function

    Private Sub txtProceso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProceso.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtProceso.Text.Trim <> "" Then
                txtRequerimientoCPU.Focus()
            End If
        End If
    End Sub

    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar.Click
        'time.Enabled = True
        Procesar()
    End Sub

    'RECIBE CUANTAS FILAS CONTIENE LA TABLA PROCESOS
    Public Function fiprocesos() As Integer
        Dim filas As Integer = tblprocesos.Rows.Count
        Return filas
    End Function
    'METOD QUE SE USA PARA ESCRIBIR EN LA TABLA DE PLANIFICACION
    Public Sub escribir_planificacion(ByVal dato As String, ByVal x As Integer, ByVal y As Integer, ByVal tabla As DataGridView)
        tabla(y, x).Value = dato
    End Sub

    'VARIABLES QUE SE USAN COMO BANDERAS , QUE NOS INDICAN EN QUE COORDENAS SE VAN
    'A PINTAR, Y "d" EN QUE FILA VAMOS A TOMAR EL COLOR DE LA TABLA PROCESOS
    Dim xx As Integer = 0, yy As Integer = 0
    'coordenadas que sirviran para pintar
    Dim d As Integer = 0

    Private Sub Encontra_ultima_Fila_ultima_Col()

        Try

            Dim J As Integer = 0
            Dim I As Integer = 0


            For J = 0 To dgridRoundRobin.Columns.Count - 1

                Ultima_Columa = J

                For I = 0 To dgridRoundRobin.Rows.Count - 1

                    If Not dgridRoundRobin.Item(J, I).Value Is Nothing Then
                        If dgridRoundRobin.Item(J, I).Value = "" Then
                            Ultima_Fila = I
                            Exit Sub
                        End If                    
                    End If

                Next

            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Procesar()

        Try


            Dim No_Procesos As Integer = fiprocesos() - 1

            If No_Procesos > 0 Then

                Dim estado As Integer = 0
                Dim cpu As Integer = 0
                Dim nombreProceso As String = ""
                Dim valresta As Integer = 0
                Dim color As String = ""
                Dim pendientevalor As Integer = 0
                Dim fila As Integer = 0
                Dim Columna As Integer = 0
                Dim Contador_Procesos_en_cero As Integer = 0

                'Encontra_ultima_Fila_ultima_Col()

                fila = Ultima_Fila
                Columna = Ultima_Columa

                While (d <= No_Procesos) AndAlso (estado = 0)

                    cpu = tblprocesos.Item(3, d).Value 'CUANTO USO DE CPU TIENE ASIGNADO
                    nombreProceso = tblprocesos.Item(0, d).Value 'NOMBRE DEL PROCESO

                    If cpu > 0 Then

                        'ASIGNA EL QUANTUM DISPONIBLE PARA ESE PROCESO Y DEJA LA DIFERENCIA PENDIENTE
                        valresta = Val(cpu) - txtQuantum.Value

                        'CUANDO EL VALOR ES MAYOR O IGUAL QUE 0
                        If valresta >= 0 Then

                            'ASIGNAMOS LO QUE QUEDO PENDIENTE
                            tblprocesos.Item(3, d).Value = valresta

                            'OBTENEMOS EL NOMBRE DEL COLOR PARA ESTE PROCESO
                            color = tblprocesos.Item(2, d).Value

                            'EL CICLO LLENA UNA CASILLA POR CADA UN QUANTUM
                            For i = 1 To txtQuantum.Value

                                dgridRoundRobin.Item(Columna, fila).Value = nombreProceso
                                pintar(color, fila, Columna, dgridRoundRobin)

                                If Columna = dgridRoundRobin.Columns.Count - 1 Then
                                    fila += 1
                                    Columna = 0
                                Else
                                    Columna += 1
                                End If

                            Next


                        ElseIf valresta < 0 Then

                            'EN CASO QUE EL VALOR DEL CPU ES MENOR QUE 0
                            pendientevalor = tblprocesos.Item(3, d).Value

                            'obtiene nombre de color
                            color = tblprocesos.Item(2, d).Value

                            escribir_planificacion(nombreProceso, fila, Columna, dgridRoundRobin)

                            For cant As Integer = 1 To pendientevalor

                                escribir_planificacion(nombreProceso, fila, Columna, dgridRoundRobin)

                                pintar(color, fila, Columna, dgridRoundRobin)

                                If Columna = dgridRoundRobin.Columns.Count - 1 Then
                                    fila += 1
                                    Columna = 0
                                Else
                                    Columna += 1
                                End If

                            Next

                            tblprocesos.Item(3, d).Value = 0

                        End If

                        If d + 1 = No_Procesos Then
                            'QUE RETORNE A LA PRIMERA FILA EN CASO QUE LLEGO AL ULTIMO PROCESO.
                            d = 0
                        Else
                            d += 1
                        End If

                    Else

                        If Contador_Procesos_en_cero = No_Procesos Then
                            estado = 1
                            time.Enabled = False
                        Else

                            Contador_Procesos_en_cero = Procesos_En_Cero()

                            If d + 1 = No_Procesos Then
                                'QUE RETORNE A LA PRIMERA FILA EN CASO QUE LLEGO AL ULTIMO PROCESO.
                                d = 0
                            Else
                                d += 1
                            End If

                        End If

                    End If 'fin if(cpu!=0);


                End While

                Ultima_Fila = fila
                Ultima_Columa = Columna

                dgridRoundRobin.Refresh()
                dgridRoundRobin.ResumeLayout()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Procesos_En_Cero() As Integer

        Procesos_En_Cero = 0

        For i As Integer = 0 To tblprocesos.Rows.Count - 1

            If Not tblprocesos.Item(3, i).Value Is Nothing Then
                If tblprocesos.Item(3, i).Value = 0 Then
                    Procesos_En_Cero += 1
                End If
            End If

        Next

    End Function

    'Public Sub Planificar()


    '    Try

    '        Dim RequeridoCPU As Integer = 0
    '        Dim NomProceso As String = ""
    '        Dim Pendiente As Double = 0
    '        Dim Color As String = ""
    '        Dim Fila As Integer = 0
    '        Dim Columna As Integer = 0


    '        For i As Integer = 0 To tblprocesos.Rows.Count - 1

    '            While tblprocesos.Item(3, i).Value <> 0

    '                RequeridoCPU = tblprocesos.Item(3, i).Value 'CUANTO USO DE CPU TIENE ASIGNADO
    '                NomProceso = tblprocesos.Item(0, i).Value 'NOMBRE DEL PROCESO

    '                If RequeridoCPU > 0 Then

    '                    Pendiente = RequeridoCPU - txtQuantum.Value

    '                    If Pendiente >= 0 Then

    '                        'ASIGNAMOS LO QUE QUEDO PENDIENTE
    '                        tblprocesos.Item(3, i).Value = Pendiente

    '                        'OBTENEMOS EL NOMBRE DEL COLOR PARA ESTE PROCESO
    '                        Color = tblprocesos.Item(2, i).Value

    '                        'EL CICLO LLENA UNA CASILLA POR CADA UN QUANTUM
    '                        For j = 1 To txtQuantum.Value

    '                            dgridRoundRobin.Item(Columna, Fila).Value = NomProceso
    '                            pintar(Color, Fila, Columna, dgridRoundRobin)

    '                            If Columna = dgridRoundRobin.Columns.Count - 1 Then
    '                                Fila += 1
    '                                Columna = 0
    '                            Else
    '                                Columna += 1
    '                            End If

    '                        Next

    '                    Else

    '                        'EN CASO QUE EL VALOR DEL CPU ES MENOR QUE 0
    '                        Pendiente = tblprocesos.Item(3, i).Value

    '                        'obtiene nombre de color
    '                        Color = tblprocesos.Item(2, i).Value

    '                        escribir_planificacion(NomProceso, Fila, Columna, dgridRoundRobin)

    '                        For cant As Integer = 1 To Pendiente

    '                            escribir_planificacion(NomProceso, Fila, Columna, dgridRoundRobin)

    '                            pintar(Color, xx, yy, dgridRoundRobin)

    '                            If Columna = dgridRoundRobin.Columns.Count - 1 Then
    '                                Fila += 1
    '                                Columna = 0
    '                            Else
    '                                Columna += 1
    '                            End If

    '                        Next

    '                        tblprocesos.Item(3, d).Value = 0

    '                    End If 'Pendiente > 0

    '                End If 'Requerido CPU >0

    '            End While

    '        Next



    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try


    'End Sub

    'METODO QUE SE USA PARA PINTAR LAS CELDAS EN LA TABLA PLANIFICACION
    Public Sub pintar(ByVal color__1 As String, ByVal xFila As Integer, ByVal yColumna As Integer, ByVal tabla As DataGridView)

        'metodo que pinta las celdas de acuerdo a las posiciones
        Dim col As Color = Color.FromName(color__1)
        'le asignamos un color de acuerdo al parametro

        tabla.Rows(xFila).Cells(yColumna).Style.BackColor = col
        'pintar celdas de acuerdo al color
        '----------------------------------------------------------------
        tabla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Select Case color__1.ToUpper
            Case "RED", "BLACK", "BLUE", "ORANGE", "VIOLET", "BROWN", _
             "GREEN", "GRAY", "INFO TEXT", "DESKTOP", "INACTIVECAPTION", "BLACK"
                tabla.Rows(xFila).Cells(yColumna).Style.ForeColor = Color.White
                'tabla.ForeColor = Color.White;
                Exit Select
            Case Else
                'tabla.ForeColor = Color.Black;
                tabla.Rows(xFila).Cells(yColumna).Style.ForeColor = Color.Black
                Exit Select
        End Select

    End Sub

    Private Sub time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time.Tick
        time.Enabled = False
        Procesar()
        time.Enabled = True
    End Sub

    Private Sub txtRequerimientoCPU_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRequerimientoCPU.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdAgregar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub lblRoundRobin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRoundRobin.Click

    End Sub

    Private Sub dgridRoundRobin_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgridRoundRobin.CellContentClick

    End Sub
End Class


