Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBoxBuscarCedula.Clear()
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        'Me.V_Estudiante_NotasTableAdapter.FillBy(Me.EscuelaRMPDataSet.V_Estudiante_Notas, TextBoxBuscarCedula.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EscuelaRMPDataSet.V_Estudiante_Notas' Puede moverla o quitarla según sea necesario.
        'Me.V_Estudiante_NotasTableAdapter.Fill(Me.EscuelaRMPDataSet.V_Estudiante_Notas)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.V_Estudiante_NotasTableAdapter.Fill(Me.EscuelaRMPDataSet.V_Estudiante_Notas)
    End Sub
End Class