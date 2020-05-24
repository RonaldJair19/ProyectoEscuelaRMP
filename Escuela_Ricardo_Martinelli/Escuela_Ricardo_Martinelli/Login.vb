Imports System.Runtime.InteropServices
Public Class Login
#Region "From Behaviors"
    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Application.Exit()
    End Sub

    Private Sub BottonMinimizar_Click(sender As Object, e As EventArgs) Handles BottonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, WParam As Integer, Iparam As Integer)
    End Sub

#End Region


    Private Sub Titulobarra_MouseMove(sender As Object, e As MouseEventArgs) Handles Titulobarra.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#Region "Customize Constrols"
    'Private Sub CustomizeComponents()
    '    'TextBoxPass.UseSystemPasswordChar = True
    '    If CheckBox1.Checked = True Then
    '        TextBoxPass.UseSystemPasswordChar = False
    '    Else
    '        TextBoxPass.UseSystemPasswordChar = True
    '    End If
    'End Sub
#End Region
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CustomizeComponents()
    End Sub


    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim MyRectangle As Rectangle = Button1.ClientRectangle
        MyRectangle.Inflate(0, 35)
        buttonPath.AddEllipse(MyRectangle)
        Button1.Region = New Region(buttonPath)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBoxUsuario.Text = "Estudiante" And TextBoxPass.Text = "estudiante" Then
            Me.Hide()
            InterfazN2.Show()
            'Me.WindowState = FormWindowState.Minimized

        ElseIf ComboBoxUsuario.Text = "Administrativo" And TextBoxPass.Text = "administrativo" Then
            Me.Hide()
            InterfazN1.Show()
            'Me.WindowState = FormWindowState.Minimized
        ElseIf ComboBoxUsuario.Text = "Profesor" And TextBoxPass.Text = "profesor" Then
            Me.Hide()
            InterfazN3.Show()
        Else
            MsgBox("Contraseña Incorrecta")
        End If
        TextBoxPass.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBoxPass.UseSystemPasswordChar = False
        Else
            TextBoxPass.UseSystemPasswordChar = True
        End If
        'TextBoxPass.Update()
    End Sub

    Private Sub TextBoxPass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPass.TextChanged
        TextBoxPass.UseSystemPasswordChar = True
    End Sub
End Class
