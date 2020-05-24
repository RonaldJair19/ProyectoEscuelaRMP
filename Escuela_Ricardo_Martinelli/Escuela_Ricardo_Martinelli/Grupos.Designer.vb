<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grupos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grupos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBuscarCodGrupo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Info_GruposDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxCodigoProfesor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBoxAnio = New System.Windows.Forms.ComboBox()
        Me.ComboBoxNombreProfesor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxNivel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLetra = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEspecialidad = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTurno = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCodigoGrupo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Info_GruposDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese código del grupo"
        '
        'TextBoxBuscarCodGrupo
        '
        Me.TextBoxBuscarCodGrupo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscarCodGrupo.Location = New System.Drawing.Point(223, 22)
        Me.TextBoxBuscarCodGrupo.Name = "TextBoxBuscarCodGrupo"
        Me.TextBoxBuscarCodGrupo.Size = New System.Drawing.Size(184, 26)
        Me.TextBoxBuscarCodGrupo.TabIndex = 2
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
        Me.ButtonBuscar.Location = New System.Drawing.Point(413, 20)
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
        Me.Button2.Location = New System.Drawing.Point(341, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 48)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Limpiar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "Limpia el cuadro de búsqueda")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Info_GruposDataGridView
        '
        Me.Info_GruposDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Info_GruposDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Info_GruposDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Info_GruposDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Info_GruposDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Info_GruposDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Info_GruposDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Info_GruposDataGridView.ColumnHeadersHeight = 35
        Me.Info_GruposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Info_GruposDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.Info_GruposDataGridView.EnableHeadersVisualStyles = False
        Me.Info_GruposDataGridView.GridColor = System.Drawing.Color.SteelBlue
        Me.Info_GruposDataGridView.Location = New System.Drawing.Point(12, 183)
        Me.Info_GruposDataGridView.Name = "Info_GruposDataGridView"
        Me.Info_GruposDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Info_GruposDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Info_GruposDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Info_GruposDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Info_GruposDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Info_GruposDataGridView.Size = New System.Drawing.Size(696, 381)
        Me.Info_GruposDataGridView.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(90, 63)
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
        Me.GroupBox1.Controls.Add(Me.TextBoxBuscarCodGrupo)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(50, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 129)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar grupos"
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
        Me.PanelInfo.Size = New System.Drawing.Size(389, 661)
        Me.PanelInfo.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(14, 568)
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
        Me.ButtonModificar.Location = New System.Drawing.Point(297, 21)
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
        Me.ButtonCancelar.Location = New System.Drawing.Point(197, 21)
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
        Me.ButtonGuardar.Location = New System.Drawing.Point(103, 21)
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
        Me.ButtonNuevo.Location = New System.Drawing.Point(17, 21)
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
        Me.GroupBox2.Controls.Add(Me.ComboBoxCodigoProfesor)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBoxAnio)
        Me.GroupBox2.Controls.Add(Me.ComboBoxNombreProfesor)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ComboBoxNivel)
        Me.GroupBox2.Controls.Add(Me.ComboBoxLetra)
        Me.GroupBox2.Controls.Add(Me.ComboBoxEspecialidad)
        Me.GroupBox2.Controls.Add(Me.ComboBoxTurno)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxCodigoGrupo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(17, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 390)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del los grupos"
        '
        'ComboBoxCodigoProfesor
        '
        Me.ComboBoxCodigoProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCodigoProfesor.Enabled = False
        Me.ComboBoxCodigoProfesor.FormattingEnabled = True
        Me.ComboBoxCodigoProfesor.Items.AddRange(New Object() {"Matutino", "Vespertino"})
        Me.ComboBoxCodigoProfesor.Location = New System.Drawing.Point(180, 303)
        Me.ComboBoxCodigoProfesor.Name = "ComboBoxCodigoProfesor"
        Me.ComboBoxCodigoProfesor.Size = New System.Drawing.Size(174, 28)
        Me.ComboBoxCodigoProfesor.Sorted = True
        Me.ComboBoxCodigoProfesor.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Cédula del Profesor: *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 349)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Año Lectivo: "
        '
        'ComboBoxAnio
        '
        Me.ComboBoxAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAnio.FormattingEnabled = True
        Me.ComboBoxAnio.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBoxAnio.Location = New System.Drawing.Point(180, 346)
        Me.ComboBoxAnio.Name = "ComboBoxAnio"
        Me.ComboBoxAnio.Size = New System.Drawing.Size(174, 28)
        Me.ComboBoxAnio.TabIndex = 35
        '
        'ComboBoxNombreProfesor
        '
        Me.ComboBoxNombreProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNombreProfesor.FormattingEnabled = True
        Me.ComboBoxNombreProfesor.Items.AddRange(New Object() {"Matutino", "Vespertino"})
        Me.ComboBoxNombreProfesor.Location = New System.Drawing.Point(180, 259)
        Me.ComboBoxNombreProfesor.Name = "ComboBoxNombreProfesor"
        Me.ComboBoxNombreProfesor.Size = New System.Drawing.Size(174, 28)
        Me.ComboBoxNombreProfesor.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Profesor Consejero: *"
        '
        'ComboBoxNivel
        '
        Me.ComboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNivel.FormattingEnabled = True
        Me.ComboBoxNivel.Items.AddRange(New Object() {"I", "II", "III", "IV", "V", "VI"})
        Me.ComboBoxNivel.Location = New System.Drawing.Point(148, 72)
        Me.ComboBoxNivel.Name = "ComboBoxNivel"
        Me.ComboBoxNivel.Size = New System.Drawing.Size(206, 28)
        Me.ComboBoxNivel.TabIndex = 14
        '
        'ComboBoxLetra
        '
        Me.ComboBoxLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLetra.FormattingEnabled = True
        Me.ComboBoxLetra.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.ComboBoxLetra.Location = New System.Drawing.Point(148, 119)
        Me.ComboBoxLetra.Name = "ComboBoxLetra"
        Me.ComboBoxLetra.Size = New System.Drawing.Size(206, 28)
        Me.ComboBoxLetra.TabIndex = 13
        '
        'ComboBoxEspecialidad
        '
        Me.ComboBoxEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEspecialidad.FormattingEnabled = True
        Me.ComboBoxEspecialidad.Items.AddRange(New Object() {"Ciencias"})
        Me.ComboBoxEspecialidad.Location = New System.Drawing.Point(148, 167)
        Me.ComboBoxEspecialidad.Name = "ComboBoxEspecialidad"
        Me.ComboBoxEspecialidad.Size = New System.Drawing.Size(206, 28)
        Me.ComboBoxEspecialidad.TabIndex = 12
        '
        'ComboBoxTurno
        '
        Me.ComboBoxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTurno.FormattingEnabled = True
        Me.ComboBoxTurno.Items.AddRange(New Object() {"Matutino", "Vespertino"})
        Me.ComboBoxTurno.Location = New System.Drawing.Point(148, 213)
        Me.ComboBoxTurno.Name = "ComboBoxTurno"
        Me.ComboBoxTurno.Size = New System.Drawing.Size(206, 28)
        Me.ComboBoxTurno.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Turno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Especialidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Letra de Grupo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nivel: *"
        '
        'TextBoxCodigoGrupo
        '
        Me.TextBoxCodigoGrupo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodigoGrupo.Location = New System.Drawing.Point(168, 30)
        Me.TextBoxCodigoGrupo.Name = "TextBoxCodigoGrupo"
        Me.TextBoxCodigoGrupo.Size = New System.Drawing.Size(186, 26)
        Me.TextBoxCodigoGrupo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código del Grupo: *"
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
        Me.ButtonEliminar.Location = New System.Drawing.Point(617, 43)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(72, 58)
        Me.ButtonEliminar.TabIndex = 12
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.ButtonEliminar, "Elimina el registro seleccionado")
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'Grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 661)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.PanelInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Info_GruposDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Grupos"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Info_GruposDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelInfo.ResumeLayout(False)
        Me.PanelInfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBuscarCodGrupo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Info_GruposDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelInfo As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonNuevo As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardar As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents ButtonModificar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCodigoGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTurno As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxNivel As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxLetra As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxAnio As ComboBox
    Friend WithEvents ComboBoxNombreProfesor As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxCodigoProfesor As ComboBox
    Friend WithEvents Label9 As Label
End Class
