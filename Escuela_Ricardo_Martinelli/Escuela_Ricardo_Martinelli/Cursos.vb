Imports System.Data.SqlClient
Public Class Cursos
    Dim band As Char
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String
    Dim CedulaEstudiante, CedulaProfesor, CodigoAsignatura, NumeroAula, AñoLectivo As String
    Private Sub Procedimiento_Cursos(Accion As Char, TrimestreCurso As String, Calificacion1 As String, Calificacion2 As String, Calificacion3 As String, Promedio As String, CodigoAsignatura As String, CodigoAsignaturaNuevo As String, CedulaEstudiante As String, CedulaEstudianteNuevo As String, NumeroAula As String, NumeroAulaNuevo As String, CedulaProfesor As String, CedulaProfesorNuevo As String, AñoLectivo As String, AñoLectivoNuevo As String)
        con.Open()
        Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_CURSOS"
        Dim cmd As New SqlCommand(Sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Accion", Accion)
        cmd.Parameters.AddWithValue("@Trimestre_Curso", TrimestreCurso)
        cmd.Parameters.AddWithValue("@Calificacion1", Val(Calificacion1))
        cmd.Parameters.AddWithValue("@Calificacion2", Val(Calificacion2))
        cmd.Parameters.AddWithValue("@Calificacion3", Val(Calificacion3))
        cmd.Parameters.AddWithValue("@Promedio", Val(Promedio))
        cmd.Parameters.AddWithValue("@CodigoAsignatura", CodigoAsignatura)
        cmd.Parameters.AddWithValue("@CodigoAsignaturaNuevo", CodigoAsignaturaNuevo)
        cmd.Parameters.AddWithValue("@CedulaEstudiante", CedulaEstudiante)
        cmd.Parameters.AddWithValue("@CedulaEstudianteNuevo", CedulaEstudianteNuevo)
        cmd.Parameters.AddWithValue("@NumeroAula", NumeroAula)
        cmd.Parameters.AddWithValue("@NumeroAulaNuevo", NumeroAulaNuevo)
        cmd.Parameters.AddWithValue("@CedulaProfesor", CedulaProfesor)
        cmd.Parameters.AddWithValue("@CedulaProfesorNuevo", CedulaProfesorNuevo)
        cmd.Parameters.AddWithValue("@AñoLectivo", AñoLectivo)
        cmd.Parameters.AddWithValue("@AñoLectivoNuevo", AñoLectivoNuevo)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Llenar_ComboBox_Asignatura()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [Código],([Nombre de la asignatura]+' de ' +[Nivel de la asignatura]+ ' Año') AS 'Asignatura' FROM V_ASIGNATURAS", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxNombreAsignatura.DataSource = ds
        ComboBoxNombreAsignatura.DisplayMember = "Asignatura" 'Campo a mostrar
        ComboBoxNombreAsignatura.ValueMember = "Código" 'Clave primaria de la tabla
        ComboBoxCodigoAsignatura.DataSource = ds
        ComboBoxCodigoAsignatura.DisplayMember = "Código"
        ComboBoxCodigoAsignatura.ValueMember = ComboBoxNombreAsignatura.DisplayMember
    End Sub

    Private Sub Llenar_ComboBox_Profesor()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [Cédula], ([Nombre]+' '+[Segundo Nombre]+' '+[Apellido]+' '+[Segundo Apellido]) AS 'Nombre Profesor' FROM V_PROFESORES", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxNombreProfesor.DataSource = ds
        ComboBoxNombreProfesor.DisplayMember = "Nombre Profesor" 'Campo a mostrar
        ComboBoxNombreProfesor.ValueMember = "Cédula" 'Clave primaria de la tabla
        ComboBoxCedulaProfesor.DataSource = ds
        ComboBoxCedulaProfesor.DisplayMember = "Cédula"
        ComboBoxCedulaProfesor.ValueMember = ComboBoxNombreProfesor.DisplayMember

    End Sub

    Private Sub Llenar_ComboBox_Estudiantes()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [Cédula], ([Nombre]+' '+[Segundo Nombre]+' '+[Apellido]+' '+[Segundo Apellido]) AS 'Nombre Estudiante'FROM V_ESTUDIANTES", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxNombreEstudiante.DataSource = ds
        ComboBoxNombreEstudiante.DisplayMember = "Nombre Estudiante" 'Campo a mostrar
        ComboBoxNombreEstudiante.ValueMember = "Cédula" 'Clave primaria de la tabla
        ComboBoxCedulaEstudiante.DataSource = ds
        ComboBoxCedulaEstudiante.DisplayMember = "Cédula" 'Campo a mostrar
        ComboBoxCedulaEstudiante.ValueMember = ComboBoxNombreEstudiante.DisplayMember  'Clave primaria de la tabla
    End Sub

    Private Sub Llenar_ComboBox_Aula()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [# del Aula] FROM V_AULAS", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxAula.DataSource = ds
        ComboBoxAula.DisplayMember = "# del Aula" 'Campo a mostrar
        ComboBoxAula.ValueMember = "# del Aula" 'Clave primaria de la tabla
    End Sub

    Private Sub Desplegar_Cursos(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_CursosDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Desplegar_Profesores_Cursos(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_AgregarProfesorDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Desplegar_Estudiante_Cursos(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_AgregarEstudianteDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAgregarEst.Click
        'Agregar cedula del estudiante al textbox
        Dim i As Integer
        Try
            i = Info_AgregarEstudianteDataGridView.CurrentRow.Index
            ComboBoxCedulaEstudiante.Text = Info_AgregarEstudianteDataGridView.Item(0, i).Value()
            ComboBoxNombreEstudiante.Text = Info_AgregarEstudianteDataGridView.Item(1, i).Value()
        Catch ex As Exception
            MsgBox("Ningún registro seleccionado")
        End Try

    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscarEst.Click
        Dim i As Integer
        Try
            'Desplegar_Estudiante_Cursos("SELECT * FROM Buscar_Estudiante_Curso('" & TextBoxBuscarCedulaEstudiante.Text & "')", "Buscar_Estudiante_Curso")
            Desplegar_Estudiante_Cursos("EXEC P_ESTUDIANTES_CURSOS '" & TextBoxBuscarCedulaEstudiante.Text & "'", "P_ESTUDIANTES_CURSOS")
        Catch ex As Exception
            MsgBox("Registro no encontrado!")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desplegar_Cursos("SELECT * FROM V_CURSOS", "V_CURSOS")
        ComboBoxAula.Text = Nothing
        ComboBoxCodigoAsignatura.Text = Nothing

        DesactivarBotones()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles TodosEst.Click
        Desplegar_Estudiante_Cursos("SELECT [Cédula], ([Nombre]+' '+[Segundo Nombre]+' '+[Apellido]+' '+[Segundo Apellido]) AS 'Nombre del Estudiante' FROM V_ESTUDIANTES", "V_ESTUDIANTES")
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Dim i As Integer

        Try
        band = "M"
            ButtonEliminar.Enabled = True
            'Agregando datos del datagrid a los textbox
            ActivarBotones()
            ButtonModificar.Enabled = False
            ButtonCancelar.Enabled = True
            ButtonGuardar.Enabled = True
            ButtonNuevo.Enabled = False
            ButtonAgregarEst.Enabled = True
            ButtonAgregarProf.Enabled = True
            i = Info_CursosDataGridView.CurrentRow.Index
            'TextBoxCedEstudiante.Text = Info_CursosDataGridView.Item(0, i).Value()
            'TextBoxNombreEstudiante.Text = Info_CursosDataGridView.Item(0, i).Value()
            ComboBoxNombreEstudiante.Text = Info_CursosDataGridView.Item(0, i).Value()
            ComboBoxNombreAsignatura.Text = Info_CursosDataGridView.Item(1, i).Value()
            ComboBoxTrimestre.Text = Info_CursosDataGridView.Item(2, i).Value()
            If Info_CursosDataGridView.Item(3, i).Value() Is DBNull.Value Then
                TextBoxNota1.Text = Nothing
            Else
                TextBoxNota1.Text = Info_CursosDataGridView.Item(3, i).Value()
            End If
            If Info_CursosDataGridView.Item(4, i).Value() Is DBNull.Value Then
                TextBoxNota2.Text = Nothing
            Else
                TextBoxNota2.Text = Info_CursosDataGridView.Item(4, i).Value()
            End If
            If Info_CursosDataGridView.Item(5, i).Value() Is DBNull.Value Then
                TextBoxNota3.Text = Nothing
            Else
                TextBoxNota3.Text = Info_CursosDataGridView.Item(5, i).Value()
            End If
            TextBoxPromedio.Text = Info_CursosDataGridView.Item(6, i).Value()
            ComboBoxAula.Text = Info_CursosDataGridView.Item(7, i).Value()
            'TextBoxNombreProfesor.Text = Info_CursosDataGridView.Item(8, i).Value()
            ComboBoxNombreProfesor.Text = Info_CursosDataGridView.Item(8, i).Value()
            ComboBoxAnioLectivo.Text = Info_CursosDataGridView.Item(9, i).Value()

            CedulaEstudiante = ComboBoxCedulaEstudiante.Text
            CedulaProfesor = ComboBoxCedulaProfesor.Text
            CodigoAsignatura = ComboBoxCodigoAsignatura.Text
            AñoLectivo = ComboBoxAnioLectivo.Text
            NumeroAula = ComboBoxAula.Text
        Catch ex As Exception
            MsgBox("No se ha seleccionado ningun registro !")
            LimpiarTextbox()
        End Try

    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        LimpiarTextbox()
        ButtonEliminar.Enabled = False
    End Sub

    Private Sub LimpiarTextbox()
        ButtonCancelar.Enabled = False
        ButtonGuardar.Enabled = False
        ButtonModificar.Enabled = True
        ButtonNuevo.Enabled = True
        ButtonAgregarEst.Enabled = False
        ButtonAgregarProf.Enabled = False
        'TextBoxCedEstudiante.Clear()
        'TextBoxCedulaProfesor.Clear()
        ComboBoxCodigoAsignatura.Text = Nothing
        ComboBoxNombreAsignatura.Text = Nothing
        TextBoxNota2.Clear()
        TextBoxNota1.Clear()
        ComboBoxAula.Text = Nothing
        TextBoxNota3.Clear()
        TextBoxPromedio.Clear()
        ComboBoxTrimestre.Text = Nothing
        ComboBoxAnioLectivo.Text = Nothing
        'TextBoxNombreEstudiante.Clear()
        ComboBoxNombreEstudiante.Text = Nothing
        'TextBoxNombreProfesor.Clear()
        ComboBoxNombreProfesor.Text = Nothing
        ComboBoxCedulaEstudiante.Text = Nothing
        ComboBoxCedulaProfesor.Text = Nothing
        DesactivarBotones()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If band = "N" Then
            'Capturador de error al insertar los datos
            If TextBoxNota1.Text Is Nothing Then
                TextBoxNota1.Text = " "
            End If
            If TextBoxNota2.Text Is Nothing Then
                TextBoxNota2.Text = " "
            End If
            If TextBoxNota2.Text Is Nothing Then
                TextBoxNota2.Text = " "
            End If
            If TextBoxPromedio.Text Is Nothing Then
                TextBoxPromedio.Text = " "
            End If
            Try
                Procedimiento_Cursos("I", ComboBoxTrimestre.Text, TextBoxNota1.Text, TextBoxNota2.Text, TextBoxNota3.Text, TextBoxPromedio.Text, ComboBoxCodigoAsignatura.Text, "''", ComboBoxCedulaEstudiante.Text, "''", ComboBoxAula.Text, " ", ComboBoxCedulaProfesor.Text, "''", ComboBoxAnioLectivo.Text, " ")
                MsgBox("Registro agregado correctamente !")
                LimpiarTextbox()
                Desplegar_Cursos("SELECT * FROM V_CURSOS", "V_CURSOS")
            Catch ex As Exception
                MsgBox("Error al insertar los datos, porfavor revisar los campos marcados con un ( * )")
            End Try
        ElseIf band = "M" Then
            If TextBoxNota1.Text Is Nothing Then
                TextBoxNota1.Text = " "
            End If
            If TextBoxNota2.Text Is Nothing Then
                TextBoxNota2.Text = " "
            End If
            If TextBoxNota2.Text Is Nothing Then
                TextBoxNota2.Text = " "
            End If
            If TextBoxPromedio.Text Is Nothing Then
                TextBoxPromedio.Text = " "
            End If
            Try
                Procedimiento_Cursos("A", ComboBoxTrimestre.Text, TextBoxNota1.Text, TextBoxNota2.Text, TextBoxNota3.Text, TextBoxPromedio.Text, CodigoAsignatura, ComboBoxCodigoAsignatura.Text, CedulaEstudiante, ComboBoxCedulaEstudiante.Text, NumeroAula, ComboBoxAula.Text, CedulaProfesor, ComboBoxCedulaProfesor.Text, AñoLectivo, ComboBoxAnioLectivo.Text)
                MsgBox("Registro actualizado correctamente !")
                LimpiarTextbox()
                Desplegar_Cursos("SELECT * FROM V_CURSOS", "V_CURSOS")
            Catch ex As Exception
                MsgBox("Error al intentar modificar los datos, revise no existen campos vacios marcados con ( * )")
            End Try
        End If
    End Sub
    Private Sub DesactivarBotones()
        'Desactivando Botones
        'TextBoxNombreEstudiante.Enabled = False
        ComboBoxNombreEstudiante.Enabled = False
        'TextBoxCedEstudiante.Enabled = False
        'TextBoxCedulaProfesor.Enabled = False
        ComboBoxCodigoAsignatura.Enabled = False
        'TextBoxNombreProfesor.Enabled = False
        ComboBoxNombreProfesor.Enabled = False
        TextBoxNota2.Enabled = False
        TextBoxNota1.Enabled = False
        ComboBoxAula.Enabled = False
        TextBoxNota3.Enabled = False
        TextBoxPromedio.Enabled = False
        ComboBoxAnioLectivo.Enabled = False
        ComboBoxNombreAsignatura.Enabled = False
        ComboBoxTrimestre.Enabled = False
        TextBoxBuscarAgregarProf.Enabled = False
        'TextBoxCedEstudiante.Enabled = False
        TodosEst.Enabled = False
        ButtonBuscarEst.Enabled = False
        TodosProf.Enabled = False
        ButtonBuscarProf.Enabled = False
        TextBoxBuscarCedulaEstudiante.Enabled = False
    End Sub
    Private Sub ActivarBotones()
        'Activando Botones
        'TextBoxCedEstudiante.Enabled = True
        'TextBoxCedulaProfesor.Enabled = True
        ComboBoxCodigoAsignatura.Enabled = True
        TextBoxNota2.Enabled = True
        TextBoxNota1.Enabled = True
        ComboBoxAula.Enabled = True
        ComboBoxNombreAsignatura.Enabled = True
        TextBoxNota3.Enabled = True
        TextBoxPromedio.Enabled = True
        ComboBoxAnioLectivo.Enabled = True
        ComboBoxTrimestre.Enabled = True
        TextBoxBuscarAgregarProf.Enabled = True
        TodosEst.Enabled = True
        ButtonBuscarEst.Enabled = True
        TodosProf.Enabled = True
        TextBoxBuscarCedulaEstudiante.Enabled = True
        ButtonBuscarProf.Enabled = True
        Llenar_ComboBox_Asignatura()
        Llenar_ComboBox_Aula()
        Llenar_ComboBox_Profesor()
        Llenar_ComboBox_Estudiantes()
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        band = "N"
        ActivarBotones()
        ButtonGuardar.Enabled = True
        ButtonModificar.Enabled = False
        ButtonCancelar.Enabled = True
        ButtonNuevo.Enabled = False
        ButtonAgregarEst.Enabled = True
        ButtonAgregarProf.Enabled = True
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim eliminarEst, eliminarProf, eliminarAula, eliminarAsig, eliminarAnio As String
        Try
            'eliminarEst = ComboBoxCedulaEstudiante.Text
            'eliminarAsig = ComboBoxCodigoAsignatura.Text
            'eliminarProf = ComboBoxCedulaProfesor.Text
            'eliminarAula = ComboBoxAula.Text
            'eliminarAnio = ComboBoxAnioLectivo.Text
            If MessageBox.Show("Desea eliminar el registro con cedula: " & eliminarEst & " para el curso: " & eliminarAsig & " con el profesor " & eliminarProf & " en el aula " & eliminarAula & " en el año lectivo " & eliminarAnio, " Borrar Registro ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Procedimiento_Cursos("E", "''", " ", " ", " ", " ", ComboBoxCodigoAsignatura.Text, "''", ComboBoxCedulaEstudiante.Text, "''", ComboBoxAula.Text, " ", ComboBoxCedulaProfesor.Text, "''", ComboBoxAnioLectivo.Text, " ")
                MsgBox("Registro eliminado exitosamente")
                LimpiarTextbox()
                Desplegar_Cursos("SELECT * FROM V_CURSOS", "V_CURSOS")
                ButtonEliminar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Registro no valido para eliminar")
        End Try
        TextBoxBuscarCurso.Clear()
        'Me.TB_CURSOTableAdapter.Fill(Me.EscuelaRMPDataSet1.TB_CURSO)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles TodosProf.Click
        Desplegar_Profesores_Cursos("SELECT [Cédula], ([Nombre]+' '+[Segundo Nombre]+' '+[Apellido]+' '+[Segundo Apellido]) AS 'Nombre Profesor' FROM V_PROFESORES", "V_PROFESORES")
    End Sub

    Private Sub ButtonBuscarProf_Click(sender As Object, e As EventArgs) Handles ButtonBuscarProf.Click
        Dim i As Integer
        Try
            'Desplegar_Profesores_Cursos("SELECT * FROM Buscar_Profesor_Cursos('" & TextBoxBuscarAgregarProf.Text & "')", "Buscar_Profesor_Cursos")
            Desplegar_Profesores_Cursos("EXEC P_PROFESORES_CURSOS '" & TextBoxBuscarAgregarProf.Text & "'", "P_PROFESORES_CURSOS")
        Catch ex As Exception
            MsgBox("Registro no encontrado!")
        End Try
    End Sub

    Private Sub ButtonBuscarCurso_Click(sender As Object, e As EventArgs) Handles ButtonBuscarCurso.Click
        Try
            Desplegar_Cursos("SELECT * FROM Buscar_Curso('" & TextBoxBuscarCurso.Text & "')", "Buscar_Curso")
        Catch ex As Exception
            MsgBox("Registro no encontrado!")
        End Try
    End Sub


    Private Sub ButtonTodosCursos_Click(sender As Object, e As EventArgs) Handles ButtonTodosCursos.Click
        Desplegar_Cursos("SELECT * FROM V_CURSOS", "V_CURSOS")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBoxBuscarCurso.Clear()
        Desplegar_Cursos("SELECT * FROM V_CURSOS", "V_CURSOS")
    End Sub

    Private Sub ButtonAgregarProf_Click(sender As Object, e As EventArgs) Handles ButtonAgregarProf.Click
        Dim i As Integer
        Try
            i = Info_AgregarProfesorDataGridView.CurrentRow.Index
            ComboBoxCedulaProfesor.Text = Info_AgregarProfesorDataGridView.Item(0, i).Value()
            ComboBoxNombreProfesor.Text = Info_AgregarProfesorDataGridView.Item(1, i).Value()
        Catch ex As Exception
            MsgBox("Ningún registro seleccionado")
        End Try

    End Sub

End Class