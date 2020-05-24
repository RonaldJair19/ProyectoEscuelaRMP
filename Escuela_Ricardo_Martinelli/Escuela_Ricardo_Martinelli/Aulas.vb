Imports System.Data.SqlClient

Public Class Aulas
    Dim band As Char
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String

    Private Sub Desplegar_Aulas(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_AulaDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Procedimiento_Aulas(Accion As Char, NumAula As String, NumAulaNuevo As String, Turno As String, Descripcion As String)
        con.Open()
        Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_AULAS"
        Dim cmd As New SqlCommand(Sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Accion", Accion)
        cmd.Parameters.AddWithValue("@NumeroAula", NumAula)
        cmd.Parameters.AddWithValue("@NumeroAulaNuevo", NumAulaNuevo)
        cmd.Parameters.AddWithValue("@TurnoOcupado", Turno)
        cmd.Parameters.AddWithValue("@Descripcion", Descripcion)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxBuscarAula.Clear()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim i As Integer
        Desplegar_Aulas("SELECT * FROM V_AULAS WHERE [# del Aula] = '" & TextBoxBuscarAula.Text & "'", "V_AULAS")
        'Try
        '    i = Info_AulaDataGridView.CurrentRow.Index
        '    Desplegar_Aulas("SELECT * FROM V_AULAS", "V_AULAS")
        'Catch ex As Exception
        '    MsgBox("Registro no encontrado!")
        'End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EscuelaRMPDataSet.TB_AULA' Puede moverla o quitarla según sea necesario.
        'Me.TB_AULATableAdapter.Fill(Me.EscuelaRMPDataSet.TB_AULA)
        DesactivarBotones()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Desplegar_Aulas("SELECT * FROM V_AULAS", "V_AULAS")
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
        i = Info_AulaDataGridView.CurrentRow.Index
        'TextBoxCodigo.Text = Info_AulaDataGridView.Item(0, i).Value()
        If Info_AulaDataGridView.Item(0, i).Value() Is DBNull.Value Then
            TextBoxNumeroAula.Text = Nothing
        Else
            TextBoxNumeroAula.Text = Info_AulaDataGridView.Item(0, i).Value()
        End If

        If Info_AulaDataGridView.Item(1, i).Value() Is DBNull.Value Then
            ComboBoxTurno.Text = Nothing
        Else
            ComboBoxTurno.Text = Info_AulaDataGridView.Item(1, i).Value()
        End If

        If Info_AulaDataGridView.Item(2, i).Value() Is DBNull.Value Then
            TextBoxDescripcion.Text = Nothing
        Else
            TextBoxDescripcion.Text = Info_AulaDataGridView.Item(2, i).Value()
        End If
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        LimpiarTextbox()
    End Sub

    Private Sub LimpiarTextbox()
        ButtonCancelar.Enabled = False
        ButtonGuardar.Enabled = False
        ButtonModificar.Enabled = True
        ButtonNuevo.Enabled = True
        'TextBoxCodigo.Clear()
        TextBoxNumeroAula.Clear()
        TextBoxDescripcion.Clear()
        ComboBoxTurno.Text = Nothing
        DesactivarBotones()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If band = "N" Then
            'Capturador de error al insertar los datos
            Try
                'Me.TB_AULATableAdapter.Insert(TextBoxCodigo.Text, TextBoxNumeroAula.Text, ComboBoxTurno.Text, TextBoxDescripcion.Text)
                'con.Open()
                'Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_AULAS"
                'Dim cmd As New SqlCommand(Sql, con)
                'cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.AddWithValue("@Accion", "I")
                'cmd.Parameters.AddWithValue("@CodAula", TextBoxCodigo.Text)
                'cmd.Parameters.AddWithValue("@NumeroAula", TextBoxNumeroAula.Text)
                'cmd.Parameters.AddWithValue("@TurnoOcupado", ComboBoxTurno.Text)
                'cmd.Parameters.AddWithValue("@Descripcion", TextBoxDescripcion.Text)
                'cmd.ExecuteNonQuery()
                'Desplegar_Aulas("SELECT * FROM V_AULAS", "V_AULAS")
                'con.Close()
                Procedimiento_Aulas("I", TextBoxNumeroAula.Text, " ", ComboBoxTurno.Text, TextBoxDescripcion.Text)
                MsgBox("Registro agregado correctamente !")
                Desplegar_Aulas("SELECT * FROM V_AULAS", "V_AULAS")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al insertar los datos, porfavor revisar los campos marcados con un ( * )")
            End Try
        ElseIf band = "M" Then
            Try
                Dim Codigo As String
                Dim i As Integer
                i = Info_AulaDataGridView.CurrentRow.Index
                Codigo = Info_AulaDataGridView.Item(0, i).Value()
                'Me.TB_AULATableAdapter.EditarAula(TextBoxCodigo.Text, TextBoxNumeroAula.Text, ComboBoxTurno.Text, TextBoxDescripcion.Text)
                'con.Open()
                'Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_AULAS"
                'Dim cmd As New SqlCommand(Sql, con)
                'cmd.CommandType = CommandType.StoredProcedure
                'cmd.Parameters.AddWithValue("@Accion", "A")
                'cmd.Parameters.AddWithValue("@CodAula", TextBoxCodigo.Text)
                'cmd.Parameters.AddWithValue("@NumeroAula", TextBoxNumeroAula.Text)
                'cmd.Parameters.AddWithValue("@TurnoOcupado", ComboBoxTurno.Text)
                'cmd.Parameters.AddWithValue("@Descripcion", TextBoxDescripcion.Text)
                'cmd.ExecuteNonQuery()
                'MsgBox("Registro actualizado correctamente !")
                'Desplegar_Aulas("SELECT * FROM V_AULAS", "V_AULAS")
                'con.Close()
                Procedimiento_Aulas("A", Codigo, TextBoxNumeroAula.Text, ComboBoxTurno.Text, TextBoxDescripcion.Text)
                MsgBox("Registro modificado exitosamente")
                Desplegar_Aulas("SELECT * FROM V_AULAS", "V_AULAS")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al intentar modificar los datos, revise no existen campos vacios marcados con ( * )")
            End Try
        End If
        'Me.TB_AULATableAdapter.Fill(Me.EscuelaRMPDataSet.TB_AULA)

    End Sub
    Private Sub DesactivarBotones()
        'Desactivando Botones
        'TextBoxCodigo.Enabled = False
        TextBoxNumeroAula.Enabled = False
        TextBoxDescripcion.Enabled = False
        ComboBoxTurno.Enabled = False
    End Sub
    Private Sub ActivarBotones()
        'Activando Botones
        'TextBoxCodigo.Enabled = True
        TextBoxNumeroAula.Enabled = True
        TextBoxDescripcion.Enabled = True
        ComboBoxTurno.Enabled = True
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
        i = Info_AulaDataGridView.CurrentRow.Index
        eliminar = Info_AulaDataGridView.Item(0, i).Value()

        'con.Open()
        'Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_AULAS"
        'Dim cmd As New SqlCommand(Sql, con)
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.AddWithValue("@Accion", "E")
        'cmd.Parameters.AddWithValue("@CodAula", eliminar)
        'cmd.Parameters.AddWithValue("@NumeroAula", " ")
        'cmd.Parameters.AddWithValue("@TurnoOcupado", "''")
        'cmd.Parameters.AddWithValue("@Descripcion", "''")
        'cmd.ExecuteNonQuery()
        'Desplegar_Aulas("SELECT * FROM V_AULAS", "V_AULAS")
        'con.Close()

        Try
            i = Info_AulaDataGridView.CurrentRow.Index
            eliminar = Info_AulaDataGridView.Item(0, i).Value()
            'con.Open()
            'Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_AULAS"
            'Dim cmd As New SqlCommand(Sql, con)
            'cmd.CommandType = CommandType.StoredProcedure
            If MessageBox.Show("Desea eliminar el aula # : " & eliminar, "Borrar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                'cmd.Parameters.AddWithValue("@Accion", "E")
                'cmd.Parameters.AddWithValue("@CodAula", eliminar)
                'cmd.Parameters.AddWithValue("@NumeroAula", " ")
                'cmd.Parameters.AddWithValue("@TurnoOcupado", "''")
                'cmd.Parameters.AddWithValue("@Descripcion", "''")
                Procedimiento_Aulas("E", eliminar, " ", "''", "''")
            End If
            'cmd.ExecuteNonQuery()
            MsgBox("Registro eliminado exitosamente")
            Desplegar_Aulas("SELECT * FROM V_AULAS", "V_AULAS")
        Catch ex As Exception
            MsgBox("Registro no valido para eliminar")
        End Try
        TextBoxBuscarAula.Clear()

        'con.Close()
    End Sub
End Class