﻿Imports System.Data.SqlClient
Public Class Info_Est
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String

    Private Sub Desplegar_Estudiantes(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.V_Estudiante_NotasDataGridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxBuscarCedula2.Clear()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        'Me.V_Informacion_EstudianteTableAdapter.FillBy(Me.EscuelaRMPDataSet.V_Informacion_Estudiante, TextBoxBuscarCedula2.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EscuelaRMPDataSet.V_Informacion_Estudiante' Puede moverla o quitarla según sea necesario.
        'Me.V_Informacion_EstudianteTableAdapter.Fill(Me.EscuelaRMPDataSet.V_Informacion_Estudiante)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Desplegar_Estudiantes("SELECT * FROM V_ESTUDIANTES", "V_ESTUDIANTES")
    End Sub

End Class