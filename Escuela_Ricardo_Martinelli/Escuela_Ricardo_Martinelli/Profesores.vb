Imports System.Data.SqlClient
Public Class Profesores
    Dim band As Char
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String

    Private Sub Desplegar_Profesor(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_ProfesorDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Llenar_ComboBox()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [Código], [Nombre de la comisión] FROM V_COMISION", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxNombreComision.DataSource = ds
        ComboBoxNombreComision.DisplayMember = "Nombre de la comisión" 'Campo a mostrar
        ComboBoxNombreComision.ValueMember = "Código" 'Clave primaria de la tabla
        ComboBoxCodigoComision.DataSource = ds
        ComboBoxCodigoComision.DisplayMember = "Código"
        ComboBoxCodigoComision.ValueMember = ComboBoxNombreComision.DisplayMember
    End Sub

    Private Sub Procedimiento_Profesores(Accion As Char, Cedula As String, CedulaNueva As String, Nombre As String, SegundoNombre As String, Apellido As String, SegundoApellido As String, Direccion As String, Correo As String, Sueldo As String, HorasClase As String, FechaNombramiento As String, FechaNacimiento As String, CodComision As String, Genero As Char)
        con.Open()
        Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_PROFESOR"
        Dim cmd As New SqlCommand(Sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Accion", Accion)
        cmd.Parameters.AddWithValue("@CedulaProfesor", Cedula)
        cmd.Parameters.AddWithValue("@CedulaProfesorNueva", CedulaNueva)
        cmd.Parameters.AddWithValue("@NombreProfesor", Nombre)
        cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
        cmd.Parameters.AddWithValue("@PrimerApellido", Apellido)
        cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
        cmd.Parameters.AddWithValue("@Direccion", Direccion)
        cmd.Parameters.AddWithValue("@Correo", Correo)
        cmd.Parameters.AddWithValue("@SueldoProfesor", Sueldo)
        cmd.Parameters.AddWithValue("@HorasClase", HorasClase)
        cmd.Parameters.AddWithValue("@FechaNombramiento", FechaNombramiento)
        cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
        cmd.Parameters.AddWithValue("@CodComision", CodComision)
        cmd.Parameters.AddWithValue("@Genero", Genero)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxBuscarCedulaProfesor.Clear()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim i As Integer
        'Me.TB_PROFESORTableAdapter.FillBy(Me.EscuelaRMPDataSet.TB_PROFESOR, TextBoxBuscarCedulaProfesor.Text)
        Desplegar_Profesor("SELECT * FROM V_PROFESORES WHERE [Cédula] LIKE '" & TextBoxBuscarCedulaProfesor.Text & "'", "V_PROFESORES")
        'Try
        '    i = Info_ProfesorDataGridView.CurrentRow.Index
        'Catch ex As Exception
        '    MsgBox("Registro no encontrado!")
        'End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EscuelaRMPDataSet.TB_TELEFONOS_PROFESOR' Puede moverla o quitarla según sea necesario.
        'Me.TB_TELEFONOS_PROFESORTableAdapter.Fill(Me.EscuelaRMPDataSet.TB_TELEFONOS_PROFESOR)
        'TODO: esta línea de código carga datos en la tabla 'EscuelaRMPDataSet.TB_PROFESOR' Puede moverla o quitarla según sea necesario.
        'Me.TB_PROFESORTableAdapter.Fill(Me.EscuelaRMPDataSet.TB_PROFESOR)
        DesactivarBotones()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Desplegar_Profesor("SELECT * FROM V_PROFESORES", "V_PROFESORES")
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
        i = Info_ProfesorDataGridView.CurrentRow.Index
        TextBoxCedula.Text = Info_ProfesorDataGridView.Item(0, i).Value()
        TextBoxNombre.Text = Info_ProfesorDataGridView.Item(1, i).Value()
        TextBoxSNombre.Text = Info_ProfesorDataGridView.Item(2, i).Value()
        TextBoxApellido.Text = Info_ProfesorDataGridView.Item(3, i).Value()
        TextBoxSApellido.Text = Info_ProfesorDataGridView.Item(4, i).Value()
        TextBoxDireccion.Text = Info_ProfesorDataGridView.Item(5, i).Value()
        TextBoxCorreo.Text = Info_ProfesorDataGridView.Item(6, i).Value()
        TextBoxSueldo.Text = Info_ProfesorDataGridView.Item(7, i).Value()
        TextBoxH_Clases.Text = Info_ProfesorDataGridView.Item(8, i).Value()
        TextBoxFNombramiento11.Text = Info_ProfesorDataGridView.Item(9, i).Value()
        TextBoxFNacimiento.Text = Info_ProfesorDataGridView.Item(10, i).Value()
        'If Info_ProfesorDataGridView.Item(11, i).Value() Is DBNull.Value Then
        '    TextBoxCodComision.Text = Nothing
        'Else
        '    TextBoxCodComision.Text = Info_ProfesorDataGridView.Item(11, i).Value()
        'End If
        ComboBoxCodigoComision.Text = Info_ProfesorDataGridView.Item(11, i).Value()
        ComboBoxGenero.Text = Info_ProfesorDataGridView.Item(12, i).Value()

        'Evita errores en los textbox
        'If Info_ProfesorDataGridView.Item(8, i).Value() Is DBNull.Value Then
        '    TextBox9.Text = Nothing
        'Else
        '    TextBox9.Text = Info_ProfesorDataGridView.Item(8, i).Value()
        'End If
        'TextBox.Value = Info_ProfesorDataGridView.Item(11, i).Value()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        LimpiarTextbox()
    End Sub

    Private Sub LimpiarTextbox()
        ButtonCancelar.Enabled = False
        ButtonGuardar.Enabled = False
        ButtonModificar.Enabled = True
        ButtonNuevo.Enabled = True
        TextBoxCedula.Clear()
        TextBoxNombre.Clear()
        TextBoxSNombre.Clear()
        TextBoxApellido.Clear()
        TextBoxSApellido.Clear()
        ComboBoxGenero.Text = Nothing
        TextBoxDireccion.Clear()
        TextBoxSueldo.Clear()
        TextBoxH_Clases.Clear()
        TextBoxFNombramiento11.Clear()
        TextBoxFNacimiento.Clear()
        'TextBoxCodComision.Clear()
        TextBoxCorreo.Clear()
        ComboBoxCodigoComision.Text = Nothing
        ComboBoxNombreComision.Text = Nothing
        DesactivarBotones()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If band = "N" Then
            'Capturador de error al insertar los datos
            Try
                'Me.TB_PROFESORTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, TextBox14.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, ComboBoxGenero.Text, TextBox3.Text)
                Procedimiento_Profesores("I", TextBoxCedula.Text, "''", TextBoxNombre.Text, TextBoxSNombre.Text, TextBoxApellido.Text, TextBoxSApellido.Text, TextBoxDireccion.Text, TextBoxCorreo.Text, Val(TextBoxSueldo.Text), TextBoxH_Clases.Text, TextBoxFNombramiento11.Text, TextBoxFNacimiento.Text, ComboBoxCodigoComision.Text, ComboBoxGenero.Text)
                MsgBox("Registro agregado correctamente !")
                Desplegar_Profesor("SELECT * FROM V_PROFESORES", "V_PROFESORES")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al insertar los datos, porfavor revisar los campos marcados con un ( * )")
            End Try
        ElseIf band = "M" Then
            Try
                Dim Cedula As String
                Dim i As Integer
                i = Info_ProfesorDataGridView.CurrentRow.Index
                Cedula = Info_ProfesorDataGridView.Item(0, i).Value()
                'Me.TB_PROFESORTableAdapter.Editar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, ComboBoxGenero.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text)
                If MessageBox.Show("Desea modificar el registro con cedula: " & Cedula, "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Procedimiento_Profesores("A", Cedula, TextBoxCedula.Text, TextBoxNombre.Text, TextBoxSNombre.Text, TextBoxApellido.Text, TextBoxSApellido.Text, TextBoxDireccion.Text, TextBoxCorreo.Text, Val(TextBoxSueldo.Text), TextBoxH_Clases.Text, TextBoxFNombramiento11.Text, TextBoxFNacimiento.Text, ComboBoxCodigoComision.Text, ComboBoxGenero.Text)
                    MsgBox("Registro actualizado correctamente !")
                    Desplegar_Profesor("SELECT * FROM V_PROFESORES", "V_PROFESORES")
                    LimpiarTextbox()
                End If
            Catch ex As Exception
                MsgBox("Error al intentar modificar los datos, revise no existen campos vacios marcados con ( * )")
            End Try
        End If
        'Me.TB_PROFESORTableAdapter.Fill(Me.EscuelaRMPDataSet.TB_PROFESOR)

    End Sub
    Private Sub DesactivarBotones()
        'Desactivando Botones
        TextBoxCedula.Enabled = False
        TextBoxNombre.Enabled = False
        TextBoxSNombre.Enabled = False
        TextBoxApellido.Enabled = False
        TextBoxSApellido.Enabled = False
        ComboBoxGenero.Enabled = False
        TextBoxDireccion.Enabled = False
        TextBoxSueldo.Enabled = False
        TextBoxH_Clases.Enabled = False
        TextBoxFNombramiento11.Enabled = False
        TextBoxFNacimiento.Enabled = False
        'TextBoxCodComision.Enabled = False
        TextBoxCorreo.Enabled = False
        ComboBoxCodigoComision.Enabled = False
        ComboBoxNombreComision.Enabled = False
    End Sub
    Private Sub ActivarBotones()
        'Activando Botones
        TextBoxCedula.Enabled = True
        TextBoxNombre.Enabled = True
        TextBoxSNombre.Enabled = True
        TextBoxApellido.Enabled = True
        TextBoxSApellido.Enabled = True
        ComboBoxGenero.Enabled = True
        TextBoxDireccion.Enabled = True
        TextBoxSueldo.Enabled = True
        TextBoxH_Clases.Enabled = True
        TextBoxFNombramiento11.Enabled = True
        TextBoxFNacimiento.Enabled = True
        'TextBoxCodComision.Enabled = True
        TextBoxCorreo.Enabled = True
        ComboBoxCodigoComision.Enabled = True
        ComboBoxNombreComision.Enabled = True
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
            i = Info_ProfesorDataGridView.CurrentRow.Index
            eliminar = Info_ProfesorDataGridView.Item(0, i).Value()
            If MessageBox.Show("Desea eliminar el registro con cedula: " & eliminar, "Borrar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Procedimiento_Profesores("E", eliminar, "''", "''", "''", "''", "''", "''", "''", " ", " ", " ", " ", "''", "''")
                MsgBox("Registro eliminado exitosamente")
                Desplegar_Profesor("SELECT * FROM V_PROFESORES", "V_PROFESORES")
                'Me.TB_PROFESORTableAdapter.EliminarProfesor(eliminar)
            End If
        Catch ex As Exception
            MsgBox("Registro no valido para eliminar")
        End Try
        TextBoxBuscarCedulaProfesor.Clear()
    End Sub


End Class