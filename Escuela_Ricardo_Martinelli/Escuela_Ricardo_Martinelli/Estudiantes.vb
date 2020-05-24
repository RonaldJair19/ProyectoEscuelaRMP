Imports System.Data.SqlClient
Public Class Estudiantes
    Dim band As Char
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxBuscarCedulaEstudiante.Clear()
        Desplegar_Estudiantes("SELECT * FROM V_ESTUDIANTES", "V_ESTUDIANTES")
    End Sub
    Private Sub Procedimiento_Estudiantes(Accion As Char, CedulaEstudiante As String, CedulaEstudianteNueva As String, NombreEstudiante As String, SegundoNombreEstudiante As String, PrimerApellidoEstudiante As String, SegundoApellidoEstudiante As String, Direccion As String, FechaNacimiento As String, AcudienteEstudiante As String, CodGrupo As String, GeneroEstudiante As String, CorreoEstudiante As String, TipoSangre As String, Discapacidad As String, Alergias As String, EscuelaProcedencia As String)
        con.Open()
        Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_ESTUDIANTES"
        Dim cmd As New SqlCommand(Sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Accion", Accion)
        cmd.Parameters.AddWithValue("@CedulaEstudiante", CedulaEstudiante)
        cmd.Parameters.AddWithValue("@CedulaEstudianteNueva", CedulaEstudianteNueva)
        cmd.Parameters.AddWithValue("@NombreEstudiante", NombreEstudiante)
        cmd.Parameters.AddWithValue("@SegundoNombreEstudiante", SegundoNombreEstudiante)
        cmd.Parameters.AddWithValue("@PrimerApellidoEstudiante", PrimerApellidoEstudiante)
        cmd.Parameters.AddWithValue("@SegundoApellidoEstudiante", SegundoApellidoEstudiante)
        cmd.Parameters.AddWithValue("@Direccion", Direccion)
        cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
        cmd.Parameters.AddWithValue("@AcudienteEstudiante", AcudienteEstudiante)
        cmd.Parameters.AddWithValue("@CodGrupo", CodGrupo)
        cmd.Parameters.AddWithValue("@GeneroEstudiante", GeneroEstudiante)
        cmd.Parameters.AddWithValue("@CorreoEstudiante", CorreoEstudiante)
        cmd.Parameters.AddWithValue("@TipoSangre", TipoSangre)
        cmd.Parameters.AddWithValue("@Discapacidad", Discapacidad)
        cmd.Parameters.AddWithValue("@Alergias", Alergias)
        cmd.Parameters.AddWithValue("@EscuelaProcedencia", EscuelaProcedencia)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Llenar_ComboBox()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [Código del Grupo], ([Nivel]+' '+[Letra del Grupo]) AS 'Grupo' FROM V_GRUPOS", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxGrupo.DataSource = ds
        ComboBoxGrupo.DisplayMember = "Grupo" 'Campo a mostrar
        ComboBoxGrupo.ValueMember = "Código del Grupo" 'Clave primaria de la tabla
        ComboBoxCodigoGrupo.DataSource = ds
        ComboBoxCodigoGrupo.DisplayMember = "Código del Grupo"
        ComboBoxCodigoGrupo.ValueMember = ComboBoxGrupo.DisplayMember

    End Sub

    Private Sub Desplegar_Estudiantes(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_EstudianteDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim i As Integer
        'Me.TB_ESTUDIANTETableAdapter.FillBy(Me.EscuelaRMPDataSet.TB_ESTUDIANTE, TextBoxBuscarCedulaEstudiante.Text)
        Desplegar_Estudiantes("SELECT * FROM V_ESTUDIANTES WHERE [Cédula] LIKE '%'+'" & TextBoxBuscarCedulaEstudiante.Text & "'+'%' OR [Nombre] LIKE '%'+'" & TextBoxBuscarCedulaEstudiante.Text & "'+'%' OR [Segundo Nombre] LIKE '%'+'" & TextBoxBuscarCedulaEstudiante.Text & "'+'%' OR [Apellido] LIKE '%'+'" & TextBoxBuscarCedulaEstudiante.Text & "'+'%' OR [Segundo Apellido] LIKE '%'+'" & TextBoxBuscarCedulaEstudiante.Text & "'+'%'", "V_ESTUDIANTES")
        Try
            i = Info_EstudianteDataGridView.CurrentRow.Index
        Catch ex As Exception
            MsgBox("Registro no encontrado!")
            'Me.TB_ESTUDIANTETableAdapter.Fill(Me.EscuelaRMPDataSet.TB_ESTUDIANTE)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desplegar_Estudiantes("SELECT * FROM V_ESTUDIANTES", "V_ESTUDIANTES")
        DesactivarBotones()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Desplegar_Estudiantes("SELECT * FROM V_ESTUDIANTES", "V_ESTUDIANTES")
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        band = "M"
        'Agregando datos del datagrid a los textbox
        ActivarBotones()
        ButtonModificar.Enabled = False
        ButtonCancelar.Enabled = True
        ButtonGuardar.Enabled = True
        ButtonNuevo.Enabled = False
        Dim i As Integer
        i = Info_EstudianteDataGridView.CurrentRow.Index
        TextBoxCedulaEstudiante.Text = Info_EstudianteDataGridView.Item(0, i).Value()
        TextBoxPrimerNombreEst.Text = Info_EstudianteDataGridView.Item(1, i).Value()
        If Info_EstudianteDataGridView.Item(2, i).Value() Is DBNull.Value Then
            TextBoxSegundoNombreEst.Text = Nothing
        Else
            TextBoxSegundoNombreEst.Text = Info_EstudianteDataGridView.Item(2, i).Value()
        End If

        TextBoxPrimerApellidoEst.Text = Info_EstudianteDataGridView.Item(3, i).Value()

        If Info_EstudianteDataGridView.Item(4, i).Value() Is DBNull.Value Then
            TextBoxSegundoApellidoEst.Text = Nothing
        Else
            TextBoxSegundoApellidoEst.Text = Info_EstudianteDataGridView.Item(4, i).Value()
        End If
        TextBoxDireccionEst.Text = Info_EstudianteDataGridView.Item(5, i).Value()
        TextBoxFechaNaciemientoEst.Text = Info_EstudianteDataGridView.Item(6, i).Value()
        TextBoxAcudiente.Text = Info_EstudianteDataGridView.Item(7, i).Value()
        'ComboBoxGrupo.Text = Info_EstudianteDataGridView.Item(8, i).Value()
        ComboBoxCodigoGrupo.Text = Info_EstudianteDataGridView.Item(8, i).Value()
        ComboBoxGeneroEst.Text = Info_EstudianteDataGridView.Item(9, i).Value()
        If Info_EstudianteDataGridView.Item(10, i).Value() Is DBNull.Value Then
            TextBoxCorreoEst.Text = Nothing
        Else
            TextBoxCorreoEst.Text = Info_EstudianteDataGridView.Item(10, i).Value()
        End If
        If Info_EstudianteDataGridView.Item(11, i).Value() Is DBNull.Value Then
            ComboBoxTipoSangre.Text = Nothing
        Else
            ComboBoxTipoSangre.Text = Info_EstudianteDataGridView.Item(11, i).Value()
        End If
        If Info_EstudianteDataGridView.Item(12, i).Value() Is DBNull.Value Then
            TextBoxDiscapacidad.Text = Nothing
        Else
            TextBoxDiscapacidad.Text = Info_EstudianteDataGridView.Item(12, i).Value()
        End If
        If Info_EstudianteDataGridView.Item(13, i).Value() Is DBNull.Value Then
            TextBoxAlergias.Text = Nothing
        Else
            TextBoxAlergias.Text = Info_EstudianteDataGridView.Item(13, i).Value()
        End If
        If Info_EstudianteDataGridView.Item(14, i).Value() Is DBNull.Value Then
            TextBoxEscuela.Text = Nothing
        Else
            TextBoxEscuela.Text = Info_EstudianteDataGridView.Item(14, i).Value()
        End If
        'Evita errores en los textbox

    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        LimpiarTextbox()
    End Sub

    Private Sub LimpiarTextbox()
        ButtonCancelar.Enabled = False
        ButtonGuardar.Enabled = False
        ButtonModificar.Enabled = True
        ButtonNuevo.Enabled = True
        TextBoxCedulaEstudiante.Clear()
        TextBoxPrimerNombreEst.Clear()
        TextBoxSegundoNombreEst.Clear()
        TextBoxPrimerApellidoEst.Clear()
        TextBoxSegundoApellidoEst.Clear()
        TextBoxDireccionEst.Clear()
        TextBoxFechaNaciemientoEst.Clear()
        TextBoxAcudiente.Clear()
        ComboBoxGrupo.Text = Nothing
        ComboBoxCodigoGrupo.Text = Nothing
        ComboBoxGeneroEst.Text = Nothing
        TextBoxCorreoEst.Clear()
        ComboBoxTipoSangre.Text = Nothing
        TextBoxDiscapacidad.Clear()
        TextBoxAlergias.Clear()
        TextBoxEscuela.Clear()
        DesactivarBotones()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If band = "N" Then
            'Capturador de error al insertar los datos
            Try
                Procedimiento_Estudiantes("I", TextBoxCedulaEstudiante.Text, "''", TextBoxPrimerNombreEst.Text, TextBoxSegundoNombreEst.Text, TextBoxPrimerApellidoEst.Text, TextBoxSegundoApellidoEst.Text, TextBoxDireccionEst.Text, TextBoxFechaNaciemientoEst.Text, TextBoxAcudiente.Text, ComboBoxCodigoGrupo.Text, ComboBoxGeneroEst.Text, TextBoxCorreoEst.Text, ComboBoxTipoSangre.Text, TextBoxDiscapacidad.Text, TextBoxAlergias.Text, TextBoxEscuela.Text)
                MsgBox("Registro agregado correctamente !")
                Desplegar_Estudiantes("SELECT * FROM V_ESTUDIANTES", "V_ESTUDIANTES")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al insertar los datos, porfavor revisar los campos marcados con un ( * )")
            End Try
        ElseIf band = "M" Then
            Try
                Dim Codigo As String
                Dim i As Integer
                i = Info_EstudianteDataGridView.CurrentRow.Index
                Codigo = Info_EstudianteDataGridView.Item(0, i).Value()
                Procedimiento_Estudiantes("A", Codigo, TextBoxCedulaEstudiante.Text, TextBoxPrimerNombreEst.Text, TextBoxSegundoNombreEst.Text, TextBoxPrimerApellidoEst.Text, TextBoxSegundoApellidoEst.Text, TextBoxDireccionEst.Text, TextBoxFechaNaciemientoEst.Text, TextBoxAcudiente.Text, ComboBoxCodigoGrupo.Text, ComboBoxGeneroEst.Text, TextBoxCorreoEst.Text, ComboBoxTipoSangre.Text, TextBoxDiscapacidad.Text, TextBoxAlergias.Text, TextBoxEscuela.Text)
                MsgBox("Registro actualizado correctamente !")
                Desplegar_Estudiantes("SELECT * FROM V_ESTUDIANTES", "V_ESTUDIANTES")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al intentar modificar los datos, revise no existen campos vacios marcados con ( * )")
            End Try
        End If
        'Me.TB_ESTUDIANTETableAdapter.Fill(Me.EscuelaRMPDataSet.TB_ESTUDIANTE)

    End Sub
    Private Sub DesactivarBotones()
        'Desactivando Botones
        TextBoxCedulaEstudiante.Enabled = False
        TextBoxPrimerNombreEst.Enabled = False
        TextBoxSegundoNombreEst.Enabled = False
        TextBoxPrimerApellidoEst.Enabled = False
        TextBoxSegundoApellidoEst.Enabled = False
        TextBoxDireccionEst.Enabled = False
        TextBoxFechaNaciemientoEst.Enabled = False
        TextBoxAcudiente.Enabled = False
        ComboBoxGrupo.Enabled = False
        ComboBoxCodigoGrupo.Enabled = False
        ComboBoxGeneroEst.Enabled = False
        TextBoxCorreoEst.Enabled = False
        ComboBoxTipoSangre.Enabled = False
        TextBoxDiscapacidad.Enabled = False
        TextBoxAlergias.Enabled = False
        TextBoxEscuela.Enabled = False
        ButtonAgregarEst.Enabled = True
    End Sub
    Private Sub ActivarBotones()
        'Activando Botones
        TextBoxCedulaEstudiante.Enabled = True
        TextBoxPrimerNombreEst.Enabled = True
        TextBoxSegundoNombreEst.Enabled = True
        TextBoxPrimerApellidoEst.Enabled = True
        TextBoxSegundoApellidoEst.Enabled = True
        TextBoxDireccionEst.Enabled = True
        TextBoxFechaNaciemientoEst.Enabled = True
        TextBoxAcudiente.Enabled = True
        ComboBoxGrupo.Enabled = True
        ComboBoxCodigoGrupo.Enabled = True
        ComboBoxGeneroEst.Enabled = True
        TextBoxCorreoEst.Enabled = True
        ComboBoxTipoSangre.Enabled = True
        TextBoxDiscapacidad.Enabled = True
        TextBoxAlergias.Enabled = True
        TextBoxEscuela.Enabled = True
        ButtonAgregarEst.Enabled = False
        Llenar_ComboBox()
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        band = "N"
        ActivarBotones()
        ButtonGuardar.Enabled = True
        ButtonModificar.Enabled = False
        ButtonCancelar.Enabled = True
        ButtonNuevo.Enabled = False
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim i As Integer
        Dim eliminar As String
        Try
            i = Info_EstudianteDataGridView.CurrentRow.Index
            eliminar = Info_EstudianteDataGridView.Item(0, i).Value()
            'Procedimiento_Estudiantes("E", eliminar, "''", "''", "''", "''", "''", "''", " ", "''", "''", "''", "''", "''", "''", "''", "''")
            If MessageBox.Show("Desea eliminar el registro con cedula: " & eliminar, "Borrar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Procedimiento_Estudiantes("E", eliminar, "''", "''", "''", "''", "''", "''", " ", "''", "''", "''", "''", "''", "''", "''", "''")
                MsgBox("Registro eliminado exitosamente")
                Desplegar_Estudiantes("SELECT * FROM V_ESTUDIANTES", "V_ESTUDIANTES")
            End If
        Catch ex As Exception
            MsgBox("Registro no valido para eliminar")
        End Try
        TextBoxBuscarCedulaEstudiante.Clear()
        'Me.TB_ESTUDIANTETableAdapter.Fill(Me.EscuelaRMPDataSet.TB_ESTUDIANTE)
    End Sub

    Private Sub ButtonAgregarEst_Click(sender As Object, e As EventArgs) Handles ButtonAgregarEst.Click
        Dim i As Integer
        i = Info_EstudianteDataGridView.CurrentRow.Index
        TextBoxAgregarEstudiante.Text = Info_EstudianteDataGridView.Item(0, i).Value()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBoxAgregarEstudiante.Clear()
    End Sub
End Class