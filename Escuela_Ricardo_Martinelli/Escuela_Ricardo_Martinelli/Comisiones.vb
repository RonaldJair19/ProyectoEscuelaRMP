Imports System.Data.SqlClient
Public Class Comisiones
    Dim band As Char
    Dim band2 As String
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String

    Private Sub Llenar_ComboBox()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [Código] FROM V_COMISION", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxCodigoComision.DataSource = ds
        ComboBoxCodigoComision.DisplayMember = "Código" 'Campo a mostrar
        ComboBoxCodigoComision.ValueMember = "Código" 'Clave primaria de la tabla

    End Sub

    Private Sub Desplegar_Comision(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_ComisionesDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Desplegar_Reuniones_Comision(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_ReunionesDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Procedimiento_Reuniones(Accion As Char, FechaComisionReunion As String, FechaComsionNueva As String, CodigoComisionReunion As String, CodigoComisionNuevoReunion As String, CantidadAsistentes As String, TemaReunion As String, DescripcionReunion As String)
        con.Open()
        Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_REUNIONES"
        Dim cmd As New SqlCommand(Sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Accion", Accion)
        cmd.Parameters.AddWithValue("@FechaComisionReunion", FechaComisionReunion)
        cmd.Parameters.AddWithValue("@FechaComisionReunionNuevo", FechaComsionNueva)
        cmd.Parameters.AddWithValue("@CodigoComisionReunion", CodigoComisionReunion)
        cmd.Parameters.AddWithValue("@CodigoComisionNuevoReunion", CodigoComisionNuevoReunion)
        cmd.Parameters.AddWithValue("@CantidadAsistentes", CantidadAsistentes)
        cmd.Parameters.AddWithValue("@TemaReunion", TemaReunion)
        cmd.Parameters.AddWithValue("@DescripcionReunion", DescripcionReunion)
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub Procedimiento_Comisiones(Accion As Char, CodigoComision As String, CodigoComisionNuevo As String, NombreComision As String, Descripcion As String, Coordinador As String, Fecha As String)
        con.Open()
        Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_COMISION"
        Dim cmd As New SqlCommand(Sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Accion", Accion)
        cmd.Parameters.AddWithValue("@CodigoComision", CodigoComision)
        cmd.Parameters.AddWithValue("@CodigoComisionNuevo", CodigoComisionNuevo)
        cmd.Parameters.AddWithValue("@NombreComision", NombreComision)
        cmd.Parameters.AddWithValue("@DescripcionComision", Descripcion)
        cmd.Parameters.AddWithValue("@CoordinadorComision", Coordinador)
        cmd.Parameters.AddWithValue("@FechaComision", Fecha)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarComision.Click
        TextBoxBuscarComision.Clear()
        Desplegar_Comision("SELECT * FROM V_COMISION", "V_COMISION")
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscarComision.Click
        Dim i As Integer
        'Me.TB_PROFESORTableAdapter.FillBy(Me.EscuelaRMPDataSet.TB_PROFESOR, TextBoxBuscarCedulaProfesor.Text)
        Desplegar_Comision("SELECT * FROM Buscar_Comision('" & TextBoxBuscarComision.Text & "')", "Buscar_Comision")
        'Try
        '    i = Info_ProfesorDataGridView.CurrentRow.Index
        'Catch ex As Exception
        '    MsgBox("Registro no encontrado!")
        'End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desplegar_Comision("SELECT * FROM V_COMISION", "V_COMISION")
        DesactivarBotones()
        DesactivarCamposReunion()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonMostrarTodos.Click
        Desplegar_Comision("SELECT * FROM V_COMISION", "V_COMISION")
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificarComsion.Click
        band = "M"
        'Agregando datos del datagrid a los textbox
        ActivarBotones()
        ButtonModificarComsion.Enabled = False
        ButtonCancelarComsion.Enabled = True
        ButtonGuardarComision.Enabled = True
        ButtonNuevaComision.Enabled = False
        ButtonEliminarComsion.Enabled = False
        Dim i As Integer
        i = Info_ComisionesDataGridView.CurrentRow.Index
        TextBoxCodigoComision.Text = Info_ComisionesDataGridView.Item(0, i).Value()
        TextBoxNombreComision.Text = Info_ComisionesDataGridView.Item(1, i).Value()
        TextBoxDescripcionComision.Text = Info_ComisionesDataGridView.Item(2, i).Value()
        TextBoxCoordinador.Text = Info_ComisionesDataGridView.Item(3, i).Value()
        If Info_ComisionesDataGridView.Item(4, i).Value() Is DBNull.Value Then
            TextBoxFechaCreacion.Text = Nothing
        Else
            TextBoxFechaCreacion.Text = Info_ComisionesDataGridView.Item(4, i).Value()
        End If
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelarComsion.Click
        LimpiarTextbox()
    End Sub

    Private Sub LimpiarTextbox()
        ButtonCancelarComsion.Enabled = False
        ButtonGuardarComision.Enabled = False
        ButtonModificarComsion.Enabled = True
        ButtonNuevaComision.Enabled = True
        ButtonEliminarComsion.Enabled = True
        TextBoxCodigoComision.Clear()
        TextBoxNombreComision.Clear()
        TextBoxDescripcionComision.Clear()
        TextBoxCoordinador.Clear()
        TextBoxFechaCreacion.Clear()
        'ComboBoxGenero.Text = Nothing
        DesactivarBotones()
    End Sub

    Private Sub LimpiarTextBoxReuniones()
        'TextBoxDetalleCodigoComsion.Clear()
        TextBoxTemaReunion.Clear()
        TextBoxDescripcionReunion.Clear()
        TextBoxFechaReunion.Clear()
        TextBoxCantidadAsistentes.Clear()
        ComboBoxCodigoComision.Text = Nothing
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardarComision.Click
        If band = "N" Then
            'Capturador de error al insertar los datos
            Try
                Procedimiento_Comisiones("I", TextBoxCodigoComision.Text, "''", TextBoxNombreComision.Text, TextBoxDescripcionComision.Text, TextBoxCoordinador.Text, TextBoxFechaCreacion.Text)
                MsgBox("Registro agregado correctamente !")
                Desplegar_Comision("SELECT * FROM V_COMISION", "V_COMISION")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al insertar los datos, porfavor revisar los campos marcados con un ( * )")
            End Try
        ElseIf band = "M" Then
            Try
                Dim Codigo As String
                Dim i As Integer
                i = Info_ComisionesDataGridView.CurrentRow.Index
                Codigo = Info_ComisionesDataGridView.Item(0, i).Value()
                If MessageBox.Show("Desea modificar el registro con cedula: " & Codigo, "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    'Procedimiento_Profesores("A", Cedula, TextBoxCedula.Text, TextBoxNombre.Text, TextBoxSNombre.Text, TextBoxApellido.Text, TextBoxSApellido.Text, TextBoxDireccion.Text, TextBoxCorreo.Text, Val(TextBoxSueldo.Text), TextBoxH_Clases.Text, TextBoxFNombramiento11.Text, TextBoxFNacimiento.Text, TextBoxCodComision.Text, ComboBoxGenero.Text)
                    Procedimiento_Comisiones("A", Codigo, TextBoxCodigoComision.Text, TextBoxNombreComision.Text, TextBoxDescripcionComision.Text, TextBoxCoordinador.Text, TextBoxFechaCreacion.Text)
                    MsgBox("Registro actualizado correctamente !")
                    Desplegar_Comision("SELECT * FROM V_COMISION", "V_COMISION")
                    LimpiarTextbox()
                End If
            Catch ex As Exception
                MsgBox("Error al intentar modificar los datos, revise no existen campos vacios marcados con ( * )")
            End Try
        End If
    End Sub
    Private Sub DesactivarBotones()
        'Desactivando Botones
        TextBoxCodigoComision.Enabled = False
        TextBoxNombreComision.Enabled = False
        TextBoxDescripcionComision.Enabled = False
        TextBoxCoordinador.Enabled = False
        TextBoxFechaCreacion.Enabled = False
        'ComboBoxGenero.Enabled = False
    End Sub
    Private Sub ActivarBotones()
        'Activando Botones
        TextBoxCodigoComision.Enabled = True
        TextBoxNombreComision.Enabled = True
        TextBoxDescripcionComision.Enabled = True
        TextBoxCoordinador.Enabled = True
        TextBoxFechaCreacion.Enabled = True
        'ComboBoxGenero.Enabled = True

    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevaComision.Click
        band = "N"
        ActivarBotones()
        ButtonGuardarComision.Enabled = True
        ButtonModificarComsion.Enabled = False
        ButtonCancelarComsion.Enabled = True
        ButtonNuevaComision.Enabled = False
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminarComsion.Click
        Dim i As Integer
        Dim eliminar As String
        Try
            i = Info_ComisionesDataGridView.CurrentRow.Index
            eliminar = Info_ComisionesDataGridView.Item(0, i).Value()
            If MessageBox.Show("Desea eliminar la comision : " & eliminar, "Borrar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Procedimiento_Comisiones("E", eliminar, "''", "''", "''", "''", " ")
                Desplegar_Comision("SELECT * FROM V_COMISION", "V_COMISION")
                MsgBox("Registro eliminado exitosamente")
            End If
        Catch ex As Exception
            MsgBox("Registro no valido para eliminar")
        End Try

        TextBoxBuscarComision.Clear()

    End Sub

    Private Sub ButtonReunionesComision_Click(sender As Object, e As EventArgs) Handles ButtonReunionesComision.Click
        ImprimirReunionesPorComisiones()
        ActivarBotonesReuniones()
    End Sub

    Private Sub ImprimirReunionesPorComisiones()
        Dim i As Integer
        Dim Comision As String
        i = Info_ComisionesDataGridView.CurrentRow.Index
        Comision = Info_ComisionesDataGridView.Item(0, i).Value()
        Desplegar_Reuniones_Comision("SELECT * FROM Reunion_Comison('" & Comision & "')", "Reunion_Comison")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub ActivarBotonesReuniones()
        ButtonNuevaReunion.Enabled = True
        ButtonModificarReunion.Enabled = True
        ButtonEliminarReunion.Enabled = True
        ButtonGuardarReunion.Enabled = False
        ButtonCancelarReunion.Enabled = False
    End Sub

    Private Sub DesactivarBotonesReuniones()
        ButtonCancelarReunion.Enabled = True
        ButtonGuardarReunion.Enabled = True
        ButtonModificarReunion.Enabled = False
        ButtonNuevaReunion.Enabled = False
        ButtonEliminarReunion.Enabled = False
    End Sub

    Private Sub ActivarCamposReunion()
        'TextBoxDetalleCodigoComsion.Enabled = True
        TextBoxTemaReunion.Enabled = True
        TextBoxDescripcionReunion.Enabled = True
        TextBoxFechaReunion.Enabled = True
        TextBoxCantidadAsistentes.Enabled = True
        'ComboBoxCodigoComision.Enabled = True
        Llenar_ComboBox()
    End Sub

    Private Sub DesactivarCamposReunion()
        'TextBoxDetalleCodigoComsion.Enabled = False
        TextBoxTemaReunion.Enabled = False
        TextBoxDescripcionReunion.Enabled = False
        TextBoxFechaReunion.Enabled = False
        TextBoxCantidadAsistentes.Enabled = False
        ComboBoxCodigoComision.Enabled = False
    End Sub

    Private Sub ButtonNuevaReunion_Click(sender As Object, e As EventArgs) Handles ButtonNuevaReunion.Click
        band2 = "N2"
        DesactivarBotonesReuniones()
        ActivarCamposReunion()
        Dim Codigo As String
        Dim i As Integer
        i = Info_ComisionesDataGridView.CurrentRow.Index
        Codigo = Info_ComisionesDataGridView.Item(0, i).Value()
        'TextBoxDetalleCodigoComsion.Text = Codigo
        ComboBoxCodigoComision.Text = Codigo
    End Sub

    Private Sub ButtonCancelarReunion_Click(sender As Object, e As EventArgs) Handles ButtonCancelarReunion.Click
        LimpiarTextBoxReuniones()
        ActivarBotonesReuniones()
        DesactivarCamposReunion()
    End Sub

    Private Sub ButtonModificarReunion_Click(sender As Object, e As EventArgs) Handles ButtonModificarReunion.Click
        ComboBoxCodigoComision.Enabled = True
        band2 = "M2"
        DesactivarBotonesReuniones()
        ActivarCamposReunion()
        Dim i As Integer
        i = Info_ReunionesDataGridView.CurrentRow.Index
        TextBoxFechaReunion.Text = Info_ReunionesDataGridView.Item(0, i).Value()
        'TextBoxDetalleCodigoComsion.Text = Info_ReunionesDataGridView.Item(1, i).Value()
        ComboBoxCodigoComision.Text = Info_ReunionesDataGridView.Item(1, i).Value()
        If Info_ReunionesDataGridView.Item(2, i).Value() Is DBNull.Value Then
            TextBoxCantidadAsistentes.Text = Nothing
        Else
            TextBoxCantidadAsistentes.Text = Info_ReunionesDataGridView.Item(2, i).Value()
        End If
        If Info_ReunionesDataGridView.Item(3, i).Value() Is DBNull.Value Then
            TextBoxTemaReunion.Text = Nothing
        Else
            TextBoxTemaReunion.Text = Info_ReunionesDataGridView.Item(3, i).Value()
        End If
        If Info_ReunionesDataGridView.Item(4, i).Value() Is DBNull.Value Then
            TextBoxDescripcionReunion.Text = Nothing
        Else
            TextBoxDescripcionReunion.Text = Info_ReunionesDataGridView.Item(4, i).Value()
        End If
    End Sub

    Private Sub ButtonEliminarReunion_Click(sender As Object, e As EventArgs) Handles ButtonEliminarReunion.Click
        Dim i As Integer
        Dim Codigo As String
        Dim Fecha As String
        Try
            i = Info_ReunionesDataGridView.CurrentRow.Index
            Codigo = Info_ReunionesDataGridView.Item(1, i).Value()
            Fecha = Info_ReunionesDataGridView.Item(0, i).Value()
            If MessageBox.Show("Desea eliminar la reunion realizada el: " & Fecha & " de la comisión: " & Codigo, "Borrar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Procedimiento_Reuniones("E", Fecha, " ", Codigo, "''", "''", "''", "''")
                ImprimirReunionesPorComisiones()
                MsgBox("Registro eliminado exitosamente")
            End If
        Catch ex As Exception
            MsgBox("Registro no valido para eliminar")
        End Try
    End Sub

    Private Sub ButtonGuardarReunion_Click(sender As Object, e As EventArgs) Handles ButtonGuardarReunion.Click
        Dim Codigo As String
        Dim i As Integer
        Dim Fecha As String
        If band2 = "N2" Then
            'Capturador de error al insertar los datos
            Try
                'Procedimiento_Comisiones("I", TextBoxCodigoComision.Text, "''", TextBoxNombreComision.Text, TextBoxDescripcionComision.Text, TextBoxCoordinador.Text, TextBoxFechaCreacion.Text)
                Procedimiento_Reuniones("I", TextBoxFechaReunion.Text, " ", ComboBoxCodigoComision.Text, "''", TextBoxCantidadAsistentes.Text, TextBoxTemaReunion.Text, TextBoxDescripcionReunion.Text)
                MsgBox("Registro agregado correctamente !")
                ImprimirReunionesPorComisiones()
                LimpiarTextBoxReuniones()
                ActivarBotonesReuniones()
                DesactivarCamposReunion()
            Catch ex As Exception
                MsgBox("Error al insertar los datos, porfavor revisar los campos marcados con un ( * )")
            End Try
        ElseIf band2 = "M2" Then
            Try
                i = Info_ReunionesDataGridView.CurrentRow.Index
                Codigo = Info_ReunionesDataGridView.Item(1, i).Value()
                Fecha = Info_ReunionesDataGridView.Item(0, i).Value()
                If MessageBox.Show("Desea modificar los datos de la reunion: " & Codigo & " Con fecha : " & Fecha, "Modificar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Procedimiento_Reuniones("A", Fecha, TextBoxFechaReunion.Text, Codigo, ComboBoxCodigoComision.Text, TextBoxCantidadAsistentes.Text, TextBoxTemaReunion.Text, TextBoxDescripcionReunion.Text)
                    MsgBox("Registro actualizado correctamente !")
                    ImprimirReunionesPorComisiones()
                    LimpiarTextBoxReuniones()
                    ActivarBotonesReuniones()
                    DesactivarCamposReunion()
                End If
            Catch ex As Exception
                MsgBox("Error al intentar modificar los datos, revise no existen campos vacios marcados con ( * )")
            End Try
        End If
    End Sub
End Class