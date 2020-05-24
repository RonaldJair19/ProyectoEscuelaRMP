Imports System.Runtime.InteropServices

Public Class InterfazN3
#Region "Funcionalidades del Formulario"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMA�O
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs) Handles BotonCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BotonMaximizar_Click(sender As Object, e As EventArgs) Handles BotonMaximizar.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height
        BotonMaximizar.Visible = False
        BotonRestaurar.Visible = True
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    End Sub
    Dim lx, ly As Integer
    Dim sw, sh As Integer
    Private Sub BotonRestaurar_Click(sender As Object, e As EventArgs) Handles BotonRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        BotonMaximizar.Visible = True
        BotonRestaurar.Visible = False
    End Sub


    Private Sub BotonMinimizar_Click(sender As Object, e As EventArgs) Handles BotonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

    'Metodo de abrir formulario
    Private Sub AbrirFormPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarForm
            Formulario.Show()
            Formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'AbrirFormPanel(Of Form1)()
        'ButtonNotas.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    'Metodo/Evento al cerrar forms
    Private Sub CerrarForm(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'Condicion si el form esta abierto
        'If (Application.OpenForms("Form1") Is Nothing) Then
        '    ButtonNotas.BackColor = Color.FromArgb(4, 41, 68)
        'End If
        If (Application.OpenForms("Info_Est") Is Nothing) Then
            ButtonInfo_Profesor.BackColor = Color.FromArgb(4, 41, 68)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonInfo_Profesor.Click
        AbrirFormPanel(Of Info_Prof)()
        ButtonInfo_Profesor.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Login.Show()
        Me.Close()
    End Sub
End Class