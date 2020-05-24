Imports System.Data.SqlClient
Public Class Prueba

    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(My.Settings.Conexion)
        'Dim Sql As String = "SELECT TBE.Cedula_Estudiante AS 'Cédula del Estudiante', (TBE.Nombre_Estudiante+' '+TBE.PrimerApellido_Estudiante) As 'Estudiante',AVG(TBC.Promedio_Final) AS 'Promedio Total', (TBG.Nivel_Grupo+' '+TBG.Letra_Grupo) AS 'Grupo', TBG.Especialidad_Grupo AS 'Especialidad' FROM TB_GRUPO AS TBG INNER JOIN TB_ESTUDIANTE AS TBE ON TBG.Cod_Grupo = TBE.Cod_Grupo INNER JOIN TB_CURSO AS TBC ON TBE.Cedula_Estudiante = TBC.Cedula_Estudiante GROUP BY TBE.Cedula_Estudiante, (TBE.Nombre_Estudiante+' '+TBE.PrimerApellido_Estudiante),(TBG.Nivel_Grupo+' '+TBG.Letra_Grupo) , TBG.Especialidad_Grupo HAVING AVG(TBC.Promedio_Final) > 4.5"
        'Dim Sql As String = "SELECT TDE.Cedula_Estudiante AS 'Cédula del Estudiante', (TDE.Nombre_Estudiante+' '+TDE.PrimerApellido_Estudiante) As 'Estudiante', TBA.Nombre_Asignatura AS 'Materia', TBG.Calificacion_Primer_Trimestre AS 'Nota I', TBG.Calificacion_Segundo_Trimestre AS 'Nota II', TBG.Calificacion_Tercer_Trimestre AS 'Nota III', TBG.Promedio_Final As 'Promedio', (TBP.Nombre_Profesor+' '+TBP.PrimerApellido_Profesor) AS 'Profesor', TBG.Año_Lectivo As 'Año' FROM TB_ESTUDIANTE AS TDE Inner Join TB_CURSO AS TBG ON TDE.Cedula_Estudiante = TBG.Cedula_Estudiante  Inner Join TB_ASIGNATURA AS TBA ON TBG.Cod_Asignatura = TBA.Cod_Asignatura Inner Join TB_PROFESOR AS TBP On TBP.Cedula_Profesor = TBG.Cedula_Profesor WHERE TBG.Promedio_Final < 3.0 "
        'Dim Sql As String = " SELECT TBE.Cedula_Estudiante AS 'Cédula del Estudiante', (TBE.Nombre_Estudiante+' '+TBE.PrimerApellido_Estudiante) As 'Estudiante',AVG(TBC.Promedio_Final) AS 'Promedio Total', (TBG.Nivel_Grupo+' '+TBG.Letra_Grupo) AS 'Grupo', TBG.Especialidad_Grupo AS 'Especialidad' FROM TB_GRUPO AS TBG INNER JOIN TB_ESTUDIANTE AS TBE ON TBG.Cod_Grupo = TBE.Cod_Grupo INNER JOIN TB_CURSO AS TBC ON TBE.Cedula_Estudiante = TBC.Cedula_Estudiante GROUP BY TBE.Cedula_Estudiante, (TBE.Nombre_Estudiante+' '+TBE.PrimerApellido_Estudiante),(TBG.Nivel_Grupo+' '+TBG.Letra_Grupo) , TBG.Especialidad_Grupo HAVING AVG(TBC.Promedio_Final) < 4.5 AND AVG(TBC.Promedio_Final) > 4.0"
        'Dim Sql As String = "SELECT COUNT(TBE.Cedula_Estudiante) AS 'Cantidad de Estudiantes', (TBG.Nivel_Grupo+' '+TBG.Letra_Grupo) AS 'Grupo', TBG.Especialidad_Grupo AS 'Especialidad', TBC.Año_Lectivo As 'Año' FROM TB_GRUPO AS TBG INNER JOIN TB_ESTUDIANTE AS TBE ON TBG.Cod_Grupo = TBE.Cod_Grupo INNER JOIN TB_CURSO AS TBC ON TBE.Cedula_Estudiante = TBC.Cedula_Estudiante GROUP BY (TBG.Nivel_Grupo+' '+TBG.Letra_Grupo), TBG.Especialidad_Grupo, TBC.Año_Lectivo "
        Dim Sql As String = "SELECT COUNT(TBC.Cedula_Estudiante) AS 'Cantidad de estudiantes', TBA.Numero_Aula AS 'Salón N°', TBA.Descripcion AS 'Descripcion del aula' FROM TB_AULA AS TBA INNER JOIN TB_CURSO AS TBC ON TBA.Cod_Aula = TBC.Cod_Aula GROUP BY TBA.Numero_Aula,TBA.Descripcion "
        Dim cmd As New SqlCommand(Sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TB_CURSO")
            Me.DataGridView1.DataSource = ds.Tables("TB_CURSO")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

End Class