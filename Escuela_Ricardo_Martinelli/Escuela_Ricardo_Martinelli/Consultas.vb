Imports System.Data.SqlClient
Public Class Consultas
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String

    Private Sub Llenar_ComboBox_Grupos()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [Código del Grupo], ([Nivel]+' '+[Letra del Grupo]) AS 'Grupo' FROM V_GRUPOS", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxCondicional.DataSource = ds
        ComboBoxCondicional.DisplayMember = "Grupo" 'Campo a mostrar
        ComboBoxCondicional.ValueMember = "Código del Grupo" 'Clave primaria de la tabla
    End Sub

    Private Sub Llenar_ComboBox_Residencia()
        'Funcion para llenar un comboBox con datos de SQL
        Dim da As New SqlDataAdapter("SELECT [Dirección] FROM V_ESTUDIANTES GROUP BY [Dirección]", con) 'Consulta enviada a la base de datos
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBoxCondicional.DataSource = ds
        ComboBoxCondicional.DisplayMember = "Dirección" 'Campo a mostrar
        ComboBoxCondicional.ValueMember = "Dirección" 'Clave primaria de la tabla
    End Sub

    Private Sub Desplegar_Consultas(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.InfoConsultas_GridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        ButtonConsultar.Enabled = False
        ComboBoxConsulta.Enabled = True
        If ComboBoxConsulta.Text = "Grupos" Then
            Desplegar_Consultas("EXEC C_Grupo '" & ComboBoxCondicional.Text & "'", "C_Grupo")
        End If
        If ComboBoxConsulta.Text = "Estudiantes por residencia" Then
            Desplegar_Consultas("EXEC C_Residencia '" & ComboBoxCondicional.Text & "'", "C_Residencia")
        End If

        ComboBoxCondicional.Text = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If ComboBoxConsulta.Text = "Grupos" Then
        '    Llenar_ComboBox_Grupos()
        'End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Me.V_Informacion_EstudianteTableAdapter.Fill(Me.EscuelaRMPDataSet.V_Informacion_Estudiante)
        'Try
        '    Me.V_Informacion_EstudianteTableAdapter.Consulta1(Me.EscuelaRMPDataSet.V_Informacion_Estudiante)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        Desplegar_Consultas("SELECT * FROM V_Historial_Actividad_BD", "V_Historial_Actividad_BD")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonConsultar.Enabled = True
        ComboBoxConsulta.Enabled = False
        If ComboBoxConsulta.Text = "Grupos" Then
            Llenar_ComboBox_Grupos()
        End If
        If ComboBoxConsulta.Text = "Estudiantes por residencia" Then
            Llenar_ComboBox_Residencia()
        End If
    End Sub
End Class