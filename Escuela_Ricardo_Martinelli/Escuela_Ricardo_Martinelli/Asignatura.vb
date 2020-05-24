Imports System.Data.SqlClient
Public Class Asignatura
    Dim band As Char
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxBuscarLaAsignatura.Clear()
        Desplegar_Asignatura("SELECT * FROM V_ASIGNATURAS", "V_ASIGNATURAS")
    End Sub

    Private Sub Desplegar_Asignatura(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.Info_AsignaturaDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Procedimiento_Asignatura(Accion As String, NombreAsignatura As String, CodAsignatura As String, CodAsignaturaNuevo As String, CantHorasAsignatura As String, Laboratorio As String, NivelAsignatura As String)
        con.Open()
        Sql = "P_ELIMINAR_ACTUALIZAR_INSERTAR_ASIGNATURA"
        Dim cmd As New SqlCommand(Sql, con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Accion", Accion)
        cmd.Parameters.AddWithValue("@NombreAsignatura", NombreAsignatura)
        cmd.Parameters.AddWithValue("@CodAsignatura", CodAsignatura)
        cmd.Parameters.AddWithValue("@CodAsignturaNuevo", CodAsignaturaNuevo)
        cmd.Parameters.AddWithValue("@CantHorasAsignatura", CantHorasAsignatura)
        cmd.Parameters.AddWithValue("@Laboratorio", Laboratorio)
        cmd.Parameters.AddWithValue("@NivelAsignatura", NivelAsignatura)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim i As Integer
        Desplegar_Asignatura("SELECT * FROM V_ASIGNATURAS WHERE [Nombre de la asignatura] LIKE '" & TextBoxBuscarLaAsignatura.Text & "' OR [Código] = '" & TextBoxBuscarLaAsignatura.Text & "'", "V_ASIGNATURAS")

        Try
            i = Info_AsignaturaDataGridView.CurrentRow.Index
        Catch ex As Exception

            MsgBox("Registro no encontrado!")
            'Me.TB_ESTUDIANTETableAdapter.Fill(Me.EscuelaRMPDataSet.TB_ESTUDIANTE)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EscuelaRMPDataSet.TB_ESTUDIANTE' Puede moverla o quitarla según sea necesario.
        'Me.TB_ESTUDIANTETableAdapter.Fill(Me.EscuelaRMPDataSet.TB_ESTUDIANTE)
        DesactivarBotones()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Desplegar_Asignatura("SELECT * FROM V_ASIGNATURAS", "V_ASIGNATURAS")
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
        i = Info_AsignaturaDataGridView.CurrentRow.Index
        TextBoxNombreAsignatura.Text = Info_AsignaturaDataGridView.Item(0, i).Value()
        TextBoxCodigoAsignatura.Text = Info_AsignaturaDataGridView.Item(1, i).Value()
        If Info_AsignaturaDataGridView.Item(2, i).Value() Is DBNull.Value Then
            TextBoxCantHoras.Text = Nothing
        Else
            TextBoxCantHoras.Text = Info_AsignaturaDataGridView.Item(2, i).Value()
        End If
        ComboBoxLaboratorio.Text = Info_AsignaturaDataGridView.Item(3, i).Value()
        ComboBoxNivelAsignatura.Text = Info_AsignaturaDataGridView.Item(4, i).Value()

    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        LimpiarTextbox()
    End Sub

    Private Sub LimpiarTextbox()
        ButtonCancelar.Enabled = False
        ButtonGuardar.Enabled = False
        ButtonModificar.Enabled = True
        ButtonNuevo.Enabled = True
        TextBoxNombreAsignatura.Clear()
        TextBoxCodigoAsignatura.Clear()
        TextBoxCantHoras.Clear()
        ComboBoxNivelAsignatura.Text = Nothing
        ComboBoxLaboratorio.Text = Nothing
        DesactivarBotones()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If band = "N" Then
            'Capturador de error al insertar los datos
            Try
                Procedimiento_Asignatura("I", TextBoxNombreAsignatura.Text, TextBoxCodigoAsignatura.Text, "''", TextBoxCantHoras.Text, ComboBoxLaboratorio.Text, ComboBoxNivelAsignatura.Text)
                MsgBox("Registro agregado correctamente !")
                Desplegar_Asignatura("SELECT * FROM V_ASIGNATURAS", "V_ASIGNATURAS")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al insertar los datos, porfavor revisar los campos marcados con un ( * )")
            End Try
        ElseIf band = "M" Then
            Try
                Dim Codigo As String
                Dim i As Integer
                i = Info_AsignaturaDataGridView.CurrentRow.Index
                Codigo = Info_AsignaturaDataGridView.Item(1, i).Value()
                Procedimiento_Asignatura("A", TextBoxNombreAsignatura.Text, Codigo, TextBoxCodigoAsignatura.Text, TextBoxCantHoras.Text, ComboBoxLaboratorio.Text, ComboBoxNivelAsignatura.Text)
                Desplegar_Asignatura("SELECT * FROM V_ASIGNATURAS", "V_ASIGNATURAS")
                MsgBox("Registro actualizado correctamente !")
                LimpiarTextbox()
            Catch ex As Exception
                MsgBox("Error al intentar modificar los datos, revise no existen campos vacios marcados con ( * )")
            End Try
        End If
        'Me.TB_ESTUDIANTETableAdapter.Fill(Me.EscuelaRMPDataSet.TB_ESTUDIANTE)

    End Sub
    Private Sub DesactivarBotones()
        'Desactivando Botones
        TextBoxNombreAsignatura.Enabled = False
        TextBoxCodigoAsignatura.Enabled = False
        TextBoxCantHoras.Enabled = False
        ComboBoxNivelAsignatura.Enabled = False
        ComboBoxLaboratorio.Enabled = False

    End Sub
    Private Sub ActivarBotones()
        'Activando Botones
        TextBoxNombreAsignatura.Enabled = True
        TextBoxCodigoAsignatura.Enabled = True
        TextBoxCantHoras.Enabled = True
        ComboBoxNivelAsignatura.Enabled = True
        ComboBoxLaboratorio.Enabled = True
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
            i = Info_AsignaturaDataGridView.CurrentRow.Index
            eliminar = Info_AsignaturaDataGridView.Item(1, i).Value()
            If MessageBox.Show("Desea eliminar el registro con cedula: " & eliminar, "Borrar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Procedimiento_Asignatura("E", "''", eliminar, "''", "", "''", "''")
                MsgBox("Registro eliminado exitosamente")
                Desplegar_Asignatura("SELECT * FROM V_ASIGNATURAS", "V_ASIGNATURAS")
                'Me.TB_ESTUDIANTETableAdapter.EliminarEst(eliminar)
            End If
        Catch ex As Exception
            MsgBox("Registro no valido para eliminar")
        End Try
        TextBoxBuscarAsignatura.Clear()
        'Me.TB_ESTUDIANTETableAdapter.Fill(Me.EscuelaRMPDataSet.TB_ESTUDIANTE)
    End Sub

End Class