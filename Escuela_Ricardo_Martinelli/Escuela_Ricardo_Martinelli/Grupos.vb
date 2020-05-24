Imports System.Data.SqlClient
Public Class Grupos
    Dim band As Char
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String
    Private Sub Desplegar_Grupos(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_GruposDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Procedimiento_Grupos(Accion As Char, CodGrupo As String, CodGrupoNuevo As String, NivelGrupo As String, LetraGrupo As Char, EspecialidadGrupo As String, TurnoGrupo As String, CedProfesor As String, AnioLectivo As String)
        con.Open()
        Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_GRUPOS"
        Dim cmd As New SqlCommand(Sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Accion", Accion)
        cmd.Parameters.AddWithValue("@CodGrupo", CodGrupo)
        cmd.Parameters.AddWithValue("@CodGrupoNuevo", CodGrupoNuevo)
        cmd.Parameters.AddWithValue("@NivelGrupo", NivelGrupo)
        cmd.Parameters.AddWithValue("@LetraGrupo", LetraGrupo)
        cmd.Parameters.AddWithValue("@EspecialidadGrupo", EspecialidadGrupo)
        cmd.Parameters.AddWithValue("@TurnoGrupo", TurnoGrupo)
        cmd.Parameters.AddWithValue("@CedProfesor", CedProfesor)
        cmd.Parameters.AddWithValue("@AnioLectivo", AnioLectivo)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub



    Private Sub Llenar_ComboBox()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [Cédula] , ([Nombre]+' '+[Apellido]) AS 'Nombre Completo' FROM V_PROFESORES", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxNombreProfesor.DataSource = ds
        ComboBoxNombreProfesor.DisplayMember = "Nombre Completo" 'Campo a mostrar
        ComboBoxNombreProfesor.ValueMember = "Cédula" 'Clave primaria de la tabla
        ComboBoxCodigoProfesor.DataSource = ds
        ComboBoxCodigoProfesor.DisplayMember = "Cédula"
        ComboBoxCodigoProfesor.ValueMember = ComboBoxNombreProfesor.DisplayMember
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxBuscarCodGrupo.Clear()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        'Dim i As Integer
        'Me.TB_GRUPOTableAdapter.FillBy(Me.EscuelaRMPDataSet.TB_GRUPO, TextBoxBuscarCodGrupo.Text)
        Desplegar_Grupos("SELECT * FROM V_GRUPOS WHERE [Código del Grupo] = '" + TextBoxBuscarCodGrupo.Text + "'", "V_GRUPOS")
        'Try
        '    i = Info_GruposDataGridView.CurrentRow.Index


        'Catch ex As Exception
        '    MsgBox("Registro no encontrado!")
        '    'Me.TB_GRUPOTableAdapter.Fill(Me.EscuelaRMPDataSet.TB_GRUPO)
        'End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EscuelaRMPDataSet.TB_GRUPO' Puede moverla o quitarla según sea necesario.
        'Me.TB_GRUPOTableAdapter.Fill(Me.EscuelaRMPDataSet.TB_GRUPO)
        DesactivarBotones()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.TB_GRUPOTableAdapter.Fill(Me.EscuelaRMPDataSet.TB_GRUPO)
        Desplegar_Grupos("SELECT * FROM V_GRUPOS", "V_GRUPOS")
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
        i = Info_GruposDataGridView.CurrentRow.Index
        TextBoxCodigoGrupo.Text = Info_GruposDataGridView.Item(0, i).Value()
        ComboBoxNivel.Text = Info_GruposDataGridView.Item(1, i).Value()
        ComboBoxLetra.Text = Info_GruposDataGridView.Item(2, i).Value()
        If Info_GruposDataGridView.Item(3, i).Value() Is DBNull.Value Then
            ComboBoxEspecialidad.Text = Nothing
        Else
            ComboBoxEspecialidad.Text = Info_GruposDataGridView.Item(3, i).Value()
        End If
        If Info_GruposDataGridView.Item(4, i).Value() Is DBNull.Value Then
            ComboBoxTurno.Text = Nothing
        Else
            ComboBoxTurno.Text = Info_GruposDataGridView.Item(4, i).Value()
        End If
        If Info_GruposDataGridView.Item(6, i).Value() Is DBNull.Value Then
            ComboBoxAnio.Text = Nothing
        Else
            ComboBoxAnio.Text = Info_GruposDataGridView.Item(6, i).Value()
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
        TextBoxCodigoGrupo.Clear()
        ComboBoxTurno.Text = Nothing
        ComboBoxEspecialidad.Text = Nothing
        ComboBoxLetra.Text = Nothing
        ComboBoxNivel.Text = Nothing
        ComboBoxAnio.Text = Nothing
        ComboBoxCodigoProfesor.Text = Nothing
        ComboBoxNombreProfesor.Text = Nothing
        DesactivarBotones()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If band = "N" Then
            'Capturador de error al insertar los datos
            Try
                Procedimiento_Grupos("I", TextBoxCodigoGrupo.Text, "''", ComboBoxNivel.Text, ComboBoxLetra.Text, ComboBoxEspecialidad.Text, ComboBoxTurno.Text, ComboBoxCodigoProfesor.Text, ComboBoxAnio.Text)
                MsgBox("Registro agregado correctamente !")
                Desplegar_Grupos("SELECT * FROM V_GRUPOS", "V_GRUPOS")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al insertar los datos, porfavor revisar los campos marcados con un ( * )")
            End Try
        ElseIf band = "M" Then
            Try
                Dim Codigo As String
                Dim i As Integer
                i = Info_GruposDataGridView.CurrentRow.Index
                Codigo = Info_GruposDataGridView.Item(0, i).Value()
                'Me.TB_GRUPOTableAdapter.EditarGrupo(TextBoxCodigoGrupo.Text, ComboBoxNivel.Text, ComboBoxTurno.Text, ComboBoxLetra.Text, ComboBoxEspecialidad.Text)
                MsgBox("Registro actualizado correctamente !")
                Procedimiento_Grupos("A", Codigo, TextBoxCodigoGrupo.Text, ComboBoxNivel.Text, ComboBoxLetra.Text, ComboBoxEspecialidad.Text, ComboBoxTurno.Text, ComboBoxCodigoProfesor.Text, ComboBoxAnio.Text)
                Desplegar_Grupos("SELECT * FROM V_GRUPOS", "V_GRUPOS")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al intentar modificar los datos, revise no existen campos vacios marcados con ( * )")
            End Try
        End If
        'Me.TB_GRUPOTableAdapter.Fill(Me.EscuelaRMPDataSet.TB_GRUPO)

    End Sub
    Private Sub DesactivarBotones()
        'Desactivando Botones
        TextBoxCodigoGrupo.Enabled = False
        ComboBoxTurno.Enabled = False
        ComboBoxEspecialidad.Enabled = False
        ComboBoxLetra.Enabled = False
        ComboBoxNivel.Enabled = False
        ComboBoxAnio.Enabled = False
        ComboBoxNombreProfesor.Enabled = False
    End Sub
    Private Sub ActivarBotones()
        'Activando Botones
        TextBoxCodigoGrupo.Enabled = True
        ComboBoxEspecialidad.Enabled = True
        ComboBoxLetra.Enabled = True
        ComboBoxNivel.Enabled = True
        ComboBoxTurno.Enabled = True
        ComboBoxAnio.Enabled = True
        ComboBoxNombreProfesor.Enabled = True
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
            i = Info_GruposDataGridView.CurrentRow.Index
            eliminar = Info_GruposDataGridView.Item(0, i).Value()
            If MessageBox.Show("Desea eliminar el grupo con codigo: " & eliminar, "Borrar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Procedimiento_Grupos("E", eliminar, "''", "''", "''", "''", "''", "''", " ")
                MsgBox("Registro eliminado exitosamente")
                Desplegar_Grupos("SELECT * FROM V_GRUPOS", "V_GRUPOS")
                'Me.TB_GRUPOTableAdapter.EliminarGrupo(eliminar)
            End If
        Catch ex As Exception
            MsgBox("Registro no valido para eliminar")
        End Try
        TextBoxBuscarCodGrupo.Clear()
        'Me.TB_GRUPOTableAdapter.Fill(Me.EscuelaRMPDataSet.TB_GRUPO)
    End Sub

End Class