<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estudiantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estudiantes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBuscarCedulaEstudiante = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Info_EstudianteDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBoxCodigoGrupo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGrupo = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxEscuela = New System.Windows.Forms.TextBox()
        Me.TextBoxAlergias = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBoxTipoSangre = New System.Windows.Forms.ComboBox()
        Me.TextBoxFechaNaciemientoEst = New System.Windows.Forms.TextBox()
        Me.ComboBoxGeneroEst = New System.Windows.Forms.ComboBox()
        Me.TextBoxCorreoEst = New System.Windows.Forms.TextBox()
        Me.TextBoxDiscapacidad = New System.Windows.Forms.TextBox()
        Me.TextBoxAcudiente = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccionEst = New System.Windows.Forms.TextBox()
        Me.TextBoxSegundoApellidoEst = New System.Windows.Forms.TextBox()
        Me.TextBoxPrimerApellidoEst = New System.Windows.Forms.TextBox()
        Me.TextBoxSegundoNombreEst = New System.Windows.Forms.TextBox()
        Me.TextBoxPrimerNombreEst = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCedulaEstudiante = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonCrearFactura = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonAgregarEst = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBoxAgregarEstudiante = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Info_EstudianteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese una cédula o" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "un nombre de estudiante"
        '
        'TextBoxBuscarCedulaEstudiante
        '
        Me.TextBoxBuscarCedulaEstudiante.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscarCedulaEstudiante.Location = New System.Drawing.Point(222, 36)
        Me.TextBoxBuscarCedulaEstudiante.Name = "TextBoxBuscarCedulaEstudiante"
        Me.TextBoxBuscarCedulaEstudiante.Size = New System.Drawing.Size(205, 26)
        Me.TextBoxBuscarCedulaEstudiante.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Cerrar pestaña")
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBuscar.ForeColor = System.Drawing.Color.White
        Me.ButtonBuscar.Image = CType(resources.GetObject("ButtonBuscar.Image"), System.Drawing.Image)
        Me.ButtonBuscar.Location = New System.Drawing.Point(445, 35)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(94, 28)
        Me.ButtonBuscar.TabIndex = 5
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.ButtonBuscar, "Realizar busqueda en los registros")
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(325, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 48)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Limpiar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "Limpia el cuadro de búsqueda")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Info_EstudianteDataGridView
        '
        Me.Info_EstudianteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Info_EstudianteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Info_EstudianteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Info_EstudianteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Info_EstudianteDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Info_EstudianteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Info_EstudianteDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Info_EstudianteDataGridView.ColumnHeadersHeight = 35
        Me.Info_EstudianteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Info_EstudianteDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.Info_EstudianteDataGridView.EnableHeadersVisualStyles = False
        Me.Info_EstudianteDataGridView.GridColor = System.Drawing.Color.SteelBlue
        Me.Info_EstudianteDataGridView.Location = New System.Drawing.Point(12, 169)
        Me.Info_EstudianteDataGridView.Name = "Info_EstudianteDataGridView"
        Me.Info_EstudianteDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Info_EstudianteDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Info_EstudianteDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Info_EstudianteDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Info_EstudianteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Info_EstudianteDataGridView.Size = New System.Drawing.Size(707, 381)
        Me.Info_EstudianteDataGridView.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(85, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 48)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Mostrar todos"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Despliega todos los registros de profesores")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxBuscarCedulaEstudiante)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(69, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 145)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar datos del estudiante"
        '
        'PanelInfo
        '
        Me.PanelInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelInfo.Controls.Add(Me.Label17)
        Me.PanelInfo.Controls.Add(Me.ButtonModificar)
        Me.PanelInfo.Controls.Add(Me.ButtonCancelar)
        Me.PanelInfo.Controls.Add(Me.ButtonGuardar)
        Me.PanelInfo.Controls.Add(Me.ButtonNuevo)
        Me.PanelInfo.Controls.Add(Me.GroupBox2)
        Me.PanelInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelInfo.Location = New System.Drawing.Point(725, 0)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Size = New System.Drawing.Size(389, 761)
        Me.PanelInfo.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(14, 727)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(364, 15)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Los campos marcados con un ( * ) son obligatorios !"
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ButtonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonModificar.FlatAppearance.BorderSize = 0
        Me.ButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificar.ForeColor = System.Drawing.Color.White
        Me.ButtonModificar.Image = CType(resources.GetObject("ButtonModificar.Image"), System.Drawing.Image)
        Me.ButtonModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonModificar.Location = New System.Drawing.Point(297, 9)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(80, 58)
        Me.ButtonModificar.TabIndex = 14
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ButtonModificar, "Modificar el registro seleccionado")
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ButtonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonCancelar.Enabled = False
        Me.ButtonCancelar.FlatAppearance.BorderSize = 0
        Me.ButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.ForeColor = System.Drawing.Color.White
        Me.ButtonCancelar.Image = CType(resources.GetObject("ButtonCancelar.Image"), System.Drawing.Image)
        Me.ButtonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonCancelar.Location = New System.Drawing.Point(197, 9)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(80, 58)
        Me.ButtonCancelar.TabIndex = 13
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ButtonCancelar, "Cancela la operación emprendida")
        Me.ButtonCancelar.UseVisualStyleBackColor = False
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ButtonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonGuardar.Enabled = False
        Me.ButtonGuardar.FlatAppearance.BorderSize = 0
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardar.Image = CType(resources.GetObject("ButtonGuardar.Image"), System.Drawing.Image)
        Me.ButtonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonGuardar.Location = New System.Drawing.Point(103, 9)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(73, 58)
        Me.ButtonGuardar.TabIndex = 12
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ButtonGuardar, "Guarda la información ingresada")
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'ButtonNuevo
        '
        Me.ButtonNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ButtonNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonNuevo.FlatAppearance.BorderSize = 0
        Me.ButtonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNuevo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNuevo.ForeColor = System.Drawing.Color.White
        Me.ButtonNuevo.Image = CType(resources.GetObject("ButtonNuevo.Image"), System.Drawing.Image)
        Me.ButtonNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonNuevo.Location = New System.Drawing.Point(17, 9)
        Me.ButtonNuevo.Name = "ButtonNuevo"
        Me.ButtonNuevo.Size = New System.Drawing.Size(59, 58)
        Me.ButtonNuevo.TabIndex = 11
        Me.ButtonNuevo.Text = "Nuevo"
        Me.ButtonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ButtonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ButtonNuevo, "Agregar un nuevo registro")
        Me.ButtonNuevo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCodigoGrupo)
        Me.GroupBox2.Controls.Add(Me.ComboBoxGrupo)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TextBoxEscuela)
        Me.GroupBox2.Controls.Add(Me.TextBoxAlergias)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ComboBoxTipoSangre)
        Me.GroupBox2.Controls.Add(Me.TextBoxFechaNaciemientoEst)
        Me.GroupBox2.Controls.Add(Me.ComboBoxGeneroEst)
        Me.GroupBox2.Controls.Add(Me.TextBoxCorreoEst)
        Me.GroupBox2.Controls.Add(Me.TextBoxDiscapacidad)
        Me.GroupBox2.Controls.Add(Me.TextBoxAcudiente)
        Me.GroupBox2.Controls.Add(Me.TextBoxDireccionEst)
        Me.GroupBox2.Controls.Add(Me.TextBoxSegundoApellidoEst)
        Me.GroupBox2.Controls.Add(Me.TextBoxPrimerApellidoEst)
        Me.GroupBox2.Controls.Add(Me.TextBoxSegundoNombreEst)
        Me.GroupBox2.Controls.Add(Me.TextBoxPrimerNombreEst)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxCedulaEstudiante)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(17, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 649)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del profesor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(30, 361)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(159, 20)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "- Código del Grupo: "
        '
        'ComboBoxCodigoGrupo
        '
        Me.ComboBoxCodigoGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCodigoGrupo.FormattingEnabled = True
        Me.ComboBoxCodigoGrupo.Location = New System.Drawing.Point(193, 358)
        Me.ComboBoxCodigoGrupo.Name = "ComboBoxCodigoGrupo"
        Me.ComboBoxCodigoGrupo.Size = New System.Drawing.Size(161, 28)
        Me.ComboBoxCodigoGrupo.TabIndex = 40
        '
        'ComboBoxGrupo
        '
        Me.ComboBoxGrupo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ComboBoxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGrupo.FormattingEnabled = True
        Me.ComboBoxGrupo.Location = New System.Drawing.Point(148, 323)
        Me.ComboBoxGrupo.Name = "ComboBoxGrupo"
        Me.ComboBoxGrupo.Size = New System.Drawing.Size(206, 28)
        Me.ComboBoxGrupo.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 597)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 40)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Escuela de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Procedencia: "
        '
        'TextBoxEscuela
        '
        Me.TextBoxEscuela.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEscuela.Location = New System.Drawing.Point(148, 597)
        Me.TextBoxEscuela.Multiline = True
        Me.TextBoxEscuela.Name = "TextBoxEscuela"
        Me.TextBoxEscuela.Size = New System.Drawing.Size(206, 40)
        Me.TextBoxEscuela.TabIndex = 37
        '
        'TextBoxAlergias
        '
        Me.TextBoxAlergias.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlergias.Location = New System.Drawing.Point(148, 565)
        Me.TextBoxAlergias.Name = "TextBoxAlergias"
        Me.TextBoxAlergias.Size = New System.Drawing.Size(206, 26)
        Me.TextBoxAlergias.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 568)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 20)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Alérgias: *"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 475)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 20)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Tipo de sangre:"
        '
        'ComboBoxTipoSangre
        '
        Me.ComboBoxTipoSangre.FormattingEnabled = True
        Me.ComboBoxTipoSangre.Location = New System.Drawing.Point(148, 472)
        Me.ComboBoxTipoSangre.Name = "ComboBoxTipoSangre"
        Me.ComboBoxTipoSangre.Size = New System.Drawing.Size(206, 28)
        Me.ComboBoxTipoSangre.TabIndex = 33
        '
        'TextBoxFechaNaciemientoEst
        '
        Me.TextBoxFechaNaciemientoEst.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFechaNaciemientoEst.Location = New System.Drawing.Point(193, 251)
        Me.TextBoxFechaNaciemientoEst.Name = "TextBoxFechaNaciemientoEst"
        Me.TextBoxFechaNaciemientoEst.Size = New System.Drawing.Size(161, 26)
        Me.TextBoxFechaNaciemientoEst.TabIndex = 30
        '
        'ComboBoxGeneroEst
        '
        Me.ComboBoxGeneroEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGeneroEst.FormattingEnabled = True
        Me.ComboBoxGeneroEst.Items.AddRange(New Object() {"F", "M"})
        Me.ComboBoxGeneroEst.Location = New System.Drawing.Point(148, 397)
        Me.ComboBoxGeneroEst.Name = "ComboBoxGeneroEst"
        Me.ComboBoxGeneroEst.Size = New System.Drawing.Size(206, 28)
        Me.ComboBoxGeneroEst.TabIndex = 11
        '
        'TextBoxCorreoEst
        '
        Me.TextBoxCorreoEst.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCorreoEst.Location = New System.Drawing.Point(148, 436)
        Me.TextBoxCorreoEst.Name = "TextBoxCorreoEst"
        Me.TextBoxCorreoEst.Size = New System.Drawing.Size(206, 26)
        Me.TextBoxCorreoEst.TabIndex = 29
        '
        'TextBoxDiscapacidad
        '
        Me.TextBoxDiscapacidad.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDiscapacidad.Location = New System.Drawing.Point(148, 511)
        Me.TextBoxDiscapacidad.Multiline = True
        Me.TextBoxDiscapacidad.Name = "TextBoxDiscapacidad"
        Me.TextBoxDiscapacidad.Size = New System.Drawing.Size(206, 48)
        Me.TextBoxDiscapacidad.TabIndex = 26
        '
        'TextBoxAcudiente
        '
        Me.TextBoxAcudiente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAcudiente.Location = New System.Drawing.Point(148, 288)
        Me.TextBoxAcudiente.Name = "TextBoxAcudiente"
        Me.TextBoxAcudiente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBoxAcudiente.Size = New System.Drawing.Size(206, 26)
        Me.TextBoxAcudiente.TabIndex = 24
        '
        'TextBoxDireccionEst
        '
        Me.TextBoxDireccionEst.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDireccionEst.Location = New System.Drawing.Point(148, 214)
        Me.TextBoxDireccionEst.Name = "TextBoxDireccionEst"
        Me.TextBoxDireccionEst.Size = New System.Drawing.Size(206, 26)
        Me.TextBoxDireccionEst.TabIndex = 22
        '
        'TextBoxSegundoApellidoEst
        '
        Me.TextBoxSegundoApellidoEst.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSegundoApellidoEst.Location = New System.Drawing.Point(148, 177)
        Me.TextBoxSegundoApellidoEst.Name = "TextBoxSegundoApellidoEst"
        Me.TextBoxSegundoApellidoEst.Size = New System.Drawing.Size(206, 26)
        Me.TextBoxSegundoApellidoEst.TabIndex = 20
        '
        'TextBoxPrimerApellidoEst
        '
        Me.TextBoxPrimerApellidoEst.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrimerApellidoEst.Location = New System.Drawing.Point(148, 140)
        Me.TextBoxPrimerApellidoEst.Name = "TextBoxPrimerApellidoEst"
        Me.TextBoxPrimerApellidoEst.Size = New System.Drawing.Size(206, 26)
        Me.TextBoxPrimerApellidoEst.TabIndex = 19
        '
        'TextBoxSegundoNombreEst
        '
        Me.TextBoxSegundoNombreEst.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSegundoNombreEst.Location = New System.Drawing.Point(148, 103)
        Me.TextBoxSegundoNombreEst.Name = "TextBoxSegundoNombreEst"
        Me.TextBoxSegundoNombreEst.Size = New System.Drawing.Size(206, 26)
        Me.TextBoxSegundoNombreEst.TabIndex = 18
        '
        'TextBoxPrimerNombreEst
        '
        Me.TextBoxPrimerNombreEst.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrimerNombreEst.Location = New System.Drawing.Point(148, 67)
        Me.TextBoxPrimerNombreEst.Name = "TextBoxPrimerNombreEst"
        Me.TextBoxPrimerNombreEst.Size = New System.Drawing.Size(206, 26)
        Me.TextBoxPrimerNombreEst.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 439)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Correo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Fecha de Nacimiento: *"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 526)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 20)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Discapacidad: *"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Acudiente: *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Grupo: *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Dirección: *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Género: *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Segundo Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Primer Apellido: *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Segundo Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre: *"
        '
        'TextBoxCedulaEstudiante
        '
        Me.TextBoxCedulaEstudiante.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCedulaEstudiante.Location = New System.Drawing.Point(148, 30)
        Me.TextBoxCedulaEstudiante.Name = "TextBoxCedulaEstudiante"
        Me.TextBoxCedulaEstudiante.Size = New System.Drawing.Size(206, 26)
        Me.TextBoxCedulaEstudiante.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cédula: *"
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ButtonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonEliminar.FlatAppearance.BorderSize = 0
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEliminar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.White
        Me.ButtonEliminar.Image = CType(resources.GetObject("ButtonEliminar.Image"), System.Drawing.Image)
        Me.ButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonEliminar.Location = New System.Drawing.Point(636, 46)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(72, 58)
        Me.ButtonEliminar.TabIndex = 12
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ButtonEliminar, "Elimina el registro seleccionado")
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonCrearFactura
        '
        Me.ButtonCrearFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ButtonCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCrearFactura.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCrearFactura.ForeColor = System.Drawing.Color.White
        Me.ButtonCrearFactura.Image = CType(resources.GetObject("ButtonCrearFactura.Image"), System.Drawing.Image)
        Me.ButtonCrearFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCrearFactura.Location = New System.Drawing.Point(10, 82)
        Me.ButtonCrearFactura.Name = "ButtonCrearFactura"
        Me.ButtonCrearFactura.Size = New System.Drawing.Size(229, 48)
        Me.ButtonCrearFactura.TabIndex = 8
        Me.ButtonCrearFactura.Text = "Nueva Factura"
        Me.ButtonCrearFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.ButtonCrearFactura, "Despliega un nuevo formulario para agregar una factura nueva al estudiante selecc" &
        "ionado")
        Me.ButtonCrearFactura.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(267, 82)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 48)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Limpiar"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button4, "Limpia el cuadro de búsqueda")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ButtonAgregarEst
        '
        Me.ButtonAgregarEst.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ButtonAgregarEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgregarEst.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregarEst.ForeColor = System.Drawing.Color.White
        Me.ButtonAgregarEst.Image = CType(resources.GetObject("ButtonAgregarEst.Image"), System.Drawing.Image)
        Me.ButtonAgregarEst.Location = New System.Drawing.Point(443, 29)
        Me.ButtonAgregarEst.Name = "ButtonAgregarEst"
        Me.ButtonAgregarEst.Size = New System.Drawing.Size(99, 34)
        Me.ButtonAgregarEst.TabIndex = 14
        Me.ButtonAgregarEst.Text = "Agregar"
        Me.ButtonAgregarEst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.ButtonAgregarEst, "Agrega desde el cuadro de datos hacia la caja vacía")
        Me.ButtonAgregarEst.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(58, 580)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 162)
        Me.Panel1.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonConsultar)
        Me.GroupBox3.Controls.Add(Me.ButtonAgregarEst)
        Me.GroupBox3.Controls.Add(Me.TextBoxAgregarEstudiante)
        Me.GroupBox3.Controls.Add(Me.ButtonCrearFactura)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(14, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(566, 145)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Crear Factura de Matrícula"
        '
        'TextBoxAgregarEstudiante
        '
        Me.TextBoxAgregarEstudiante.Enabled = False
        Me.TextBoxAgregarEstudiante.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAgregarEstudiante.Location = New System.Drawing.Point(223, 33)
        Me.TextBoxAgregarEstudiante.Name = "TextBoxAgregarEstudiante"
        Me.TextBoxAgregarEstudiante.ReadOnly = True
        Me.TextBoxAgregarEstudiante.Size = New System.Drawing.Size(205, 26)
        Me.TextBoxAgregarEstudiante.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(9, 36)
        Me.Label19.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(190, 19)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Agregue un estudiante:"
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ButtonConsultar.Enabled = False
        Me.ButtonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConsultar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultar.ForeColor = System.Drawing.Color.White
        Me.ButtonConsultar.Image = CType(resources.GetObject("ButtonConsultar.Image"), System.Drawing.Image)
        Me.ButtonConsultar.Location = New System.Drawing.Point(432, 85)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(126, 41)
        Me.ButtonConsultar.TabIndex = 14
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonConsultar.UseVisualStyleBackColor = False
        '
        'Estudiantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 761)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.PanelInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Info_EstudianteDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Estudiantes"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Info_EstudianteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelInfo.ResumeLayout(False)
        Me.PanelInfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBuscarCedulaEstudiante As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Info_EstudianteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelInfo As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonNuevo As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents ButtonModificar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCedulaEstudiante As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCorreoEst As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDiscapacidad As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAcudiente As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDireccionEst As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSegundoApellidoEst As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrimerApellidoEst As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSegundoNombreEst As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrimerNombreEst As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxGeneroEst As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents TextBoxFechaNaciemientoEst As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBoxTipoSangre As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBoxEscuela As TextBox
    Friend WithEvents TextBoxAlergias As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBoxCodigoGrupo As ComboBox
    Friend WithEvents ComboBoxGrupo As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBoxAgregarEstudiante As TextBox
    Friend WithEvents ButtonCrearFactura As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ButtonAgregarEst As Button
    Friend WithEvents ButtonConsultar As Button
End Class
