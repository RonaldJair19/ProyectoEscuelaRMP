Imports System.Data.SqlClient
Public Class ReciboMatricula
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim Sql As String

    Private Sub Desplegar_ReciboMatricula(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.InfoRecibo_GridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Desplegar_DetalleReciboMatricula(V_Sql As String, V_da As String)
        Sql = V_Sql
        Dim cmd As New SqlCommand(Sql, con)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, V_da)
            Me.InfoDetalleRecibo_GridView.DataSource = ds.Tables(V_da)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReciboMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desplegar_ReciboMatricula("SELECT * FROM V_FACTURA_MATRICULA ORDER BY [Código de la factura] ASC", "V_FACTURA_MATRICULA")
    End Sub

    Private Sub ButtonMostrarTodos_Click(sender As Object, e As EventArgs) Handles ButtonMostrarTodos.Click
        Try
            Dim i As Integer
            Dim Codigo As String
            i = InfoRecibo_GridView.CurrentRow.Index
            Codigo = InfoRecibo_GridView.Item(0, i).Value()
            Desplegar_DetalleReciboMatricula("EXEC C_DETALLE_FACTURA_MATRICULA '" & Codigo & "'", "C_DETALLE_FACTURA_MATRICULA")
        Catch ex As Exception
            MsgBox("Error 404")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class