<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prueba2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prueba2))
        Dim Nombre_EstudianteLabel As System.Windows.Forms.Label
        Dim PrimerApellido_EstudianteLabel As System.Windows.Forms.Label
        Dim SegundoApellido_EstudianteLabel As System.Windows.Forms.Label
        Dim Cedula_EstudianteLabel As System.Windows.Forms.Label
        Dim Direccion_EstudianteLabel As System.Windows.Forms.Label
        Dim Fecha_Nacimiento_EstudianteLabel As System.Windows.Forms.Label
        Dim Acudiente_EstudianteLabel As System.Windows.Forms.Label
        Dim Fecha_MatriculaLabel As System.Windows.Forms.Label
        Dim Cod_GrupoLabel As System.Windows.Forms.Label
        Dim Genero_EstudianteLabel As System.Windows.Forms.Label
        Dim Correo_EstudianteLabel As System.Windows.Forms.Label
        Dim SegundoNombre_EstudianteLabel As System.Windows.Forms.Label
        'Me.EscuelaRMPDataSet = New Escuela_Ricardo_Martinelli.EscuelaRMPDataSet1()
        'Me.TB_ESTUDIANTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.TB_ESTUDIANTETableAdapter = New Escuela_Ricardo_Martinelli.EscuelaRMPDataSet1TableAdapters.TB_ESTUDIANTETableAdapter()
        'Me.TableAdapterManager = New Escuela_Ricardo_Martinelli.EscuelaRMPDataSet1TableAdapters.TableAdapterManager()
        Me.TB_ESTUDIANTEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TB_ESTUDIANTEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Nombre_EstudianteTextBox = New System.Windows.Forms.TextBox()
        Me.PrimerApellido_EstudianteTextBox = New System.Windows.Forms.TextBox()
        Me.SegundoApellido_EstudianteTextBox = New System.Windows.Forms.TextBox()
        Me.Cedula_EstudianteTextBox = New System.Windows.Forms.TextBox()
        Me.Direccion_EstudianteTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_Nacimiento_EstudianteDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Acudiente_EstudianteTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_MatriculaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cod_GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.Genero_EstudianteTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_EstudianteTextBox = New System.Windows.Forms.TextBox()
        Me.SegundoNombre_EstudianteTextBox = New System.Windows.Forms.TextBox()
        Nombre_EstudianteLabel = New System.Windows.Forms.Label()
        PrimerApellido_EstudianteLabel = New System.Windows.Forms.Label()
        SegundoApellido_EstudianteLabel = New System.Windows.Forms.Label()
        Cedula_EstudianteLabel = New System.Windows.Forms.Label()
        Direccion_EstudianteLabel = New System.Windows.Forms.Label()
        Fecha_Nacimiento_EstudianteLabel = New System.Windows.Forms.Label()
        Acudiente_EstudianteLabel = New System.Windows.Forms.Label()
        Fecha_MatriculaLabel = New System.Windows.Forms.Label()
        Cod_GrupoLabel = New System.Windows.Forms.Label()
        Genero_EstudianteLabel = New System.Windows.Forms.Label()
        Correo_EstudianteLabel = New System.Windows.Forms.Label()
        SegundoNombre_EstudianteLabel = New System.Windows.Forms.Label()
        'CType(Me.EscuelaRMPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_ESTUDIANTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_ESTUDIANTEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TB_ESTUDIANTEBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'EscuelaRMPDataSet
        '
        'Me.EscuelaRMPDataSet.DataSetName = "EscuelaRMPDataSet"
        'Me.EscuelaRMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        ''
        ''TB_ESTUDIANTEBindingSource
        ''
        'Me.TB_ESTUDIANTEBindingSource.DataMember = "TB_ESTUDIANTE"
        'Me.TB_ESTUDIANTEBindingSource.DataSource = Me.EscuelaRMPDataSet
        ''
        ''TB_ESTUDIANTETableAdapter
        ''
        'Me.TB_ESTUDIANTETableAdapter.ClearBeforeFill = True
        ''
        ''TableAdapterManager
        ''
        'Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager.TB_ASIGNATURATableAdapter = Nothing
        'Me.TableAdapterManager.TB_AULATableAdapter = Nothing
        'Me.TableAdapterManager.TB_CURSOTableAdapter = Nothing
        'Me.TableAdapterManager.TB_ESTUDIANTE_TELEFONOSTableAdapter = Nothing
        'Me.TableAdapterManager.TB_ESTUDIANTETableAdapter = Me.TB_ESTUDIANTETableAdapter
        'Me.TableAdapterManager.TB_GRUPOTableAdapter = Nothing
        'Me.TableAdapterManager.TB_PROFESORTableAdapter = Nothing
        'Me.TableAdapterManager.TB_TELEFONOS_PROFESORTableAdapter = Nothing
        'Me.TableAdapterManager.UpdateOrder = Escuela_Ricardo_Martinelli.EscuelaRMPDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TB_ESTUDIANTEBindingNavigator
        '
        Me.TB_ESTUDIANTEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TB_ESTUDIANTEBindingNavigator.BindingSource = Me.TB_ESTUDIANTEBindingSource
        Me.TB_ESTUDIANTEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TB_ESTUDIANTEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TB_ESTUDIANTEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TB_ESTUDIANTEBindingNavigatorSaveItem})
        Me.TB_ESTUDIANTEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TB_ESTUDIANTEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TB_ESTUDIANTEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TB_ESTUDIANTEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TB_ESTUDIANTEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TB_ESTUDIANTEBindingNavigator.Name = "TB_ESTUDIANTEBindingNavigator"
        Me.TB_ESTUDIANTEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TB_ESTUDIANTEBindingNavigator.Size = New System.Drawing.Size(719, 25)
        Me.TB_ESTUDIANTEBindingNavigator.TabIndex = 0
        Me.TB_ESTUDIANTEBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'TB_ESTUDIANTEBindingNavigatorSaveItem
        '
        Me.TB_ESTUDIANTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TB_ESTUDIANTEBindingNavigatorSaveItem.Image = CType(resources.GetObject("TB_ESTUDIANTEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TB_ESTUDIANTEBindingNavigatorSaveItem.Name = "TB_ESTUDIANTEBindingNavigatorSaveItem"
        Me.TB_ESTUDIANTEBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TB_ESTUDIANTEBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Nombre_EstudianteLabel
        '
        Nombre_EstudianteLabel.AutoSize = True
        Nombre_EstudianteLabel.Location = New System.Drawing.Point(164, 103)
        Nombre_EstudianteLabel.Name = "Nombre_EstudianteLabel"
        Nombre_EstudianteLabel.Size = New System.Drawing.Size(100, 13)
        Nombre_EstudianteLabel.TabIndex = 1
        Nombre_EstudianteLabel.Text = "Nombre Estudiante:"
        '
        'Nombre_EstudianteTextBox
        '
        Me.Nombre_EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "Nombre_Estudiante", True))
        Me.Nombre_EstudianteTextBox.Location = New System.Drawing.Point(319, 100)
        Me.Nombre_EstudianteTextBox.Name = "Nombre_EstudianteTextBox"
        Me.Nombre_EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Nombre_EstudianteTextBox.TabIndex = 2
        '
        'PrimerApellido_EstudianteLabel
        '
        PrimerApellido_EstudianteLabel.AutoSize = True
        PrimerApellido_EstudianteLabel.Location = New System.Drawing.Point(164, 129)
        PrimerApellido_EstudianteLabel.Name = "PrimerApellido_EstudianteLabel"
        PrimerApellido_EstudianteLabel.Size = New System.Drawing.Size(132, 13)
        PrimerApellido_EstudianteLabel.TabIndex = 3
        PrimerApellido_EstudianteLabel.Text = "Primer Apellido Estudiante:"
        '
        'PrimerApellido_EstudianteTextBox
        '
        Me.PrimerApellido_EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "PrimerApellido_Estudiante", True))
        Me.PrimerApellido_EstudianteTextBox.Location = New System.Drawing.Point(319, 126)
        Me.PrimerApellido_EstudianteTextBox.Name = "PrimerApellido_EstudianteTextBox"
        Me.PrimerApellido_EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrimerApellido_EstudianteTextBox.TabIndex = 4
        '
        'SegundoApellido_EstudianteLabel
        '
        SegundoApellido_EstudianteLabel.AutoSize = True
        SegundoApellido_EstudianteLabel.Location = New System.Drawing.Point(164, 155)
        SegundoApellido_EstudianteLabel.Name = "SegundoApellido_EstudianteLabel"
        SegundoApellido_EstudianteLabel.Size = New System.Drawing.Size(146, 13)
        SegundoApellido_EstudianteLabel.TabIndex = 5
        SegundoApellido_EstudianteLabel.Text = "Segundo Apellido Estudiante:"
        '
        'SegundoApellido_EstudianteTextBox
        '
        Me.SegundoApellido_EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "SegundoApellido_Estudiante", True))
        Me.SegundoApellido_EstudianteTextBox.Location = New System.Drawing.Point(319, 152)
        Me.SegundoApellido_EstudianteTextBox.Name = "SegundoApellido_EstudianteTextBox"
        Me.SegundoApellido_EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SegundoApellido_EstudianteTextBox.TabIndex = 6
        '
        'Cedula_EstudianteLabel
        '
        Cedula_EstudianteLabel.AutoSize = True
        Cedula_EstudianteLabel.Location = New System.Drawing.Point(164, 181)
        Cedula_EstudianteLabel.Name = "Cedula_EstudianteLabel"
        Cedula_EstudianteLabel.Size = New System.Drawing.Size(96, 13)
        Cedula_EstudianteLabel.TabIndex = 7
        Cedula_EstudianteLabel.Text = "Cedula Estudiante:"
        '
        'Cedula_EstudianteTextBox
        '
        Me.Cedula_EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "Cedula_Estudiante", True))
        Me.Cedula_EstudianteTextBox.Location = New System.Drawing.Point(319, 178)
        Me.Cedula_EstudianteTextBox.Name = "Cedula_EstudianteTextBox"
        Me.Cedula_EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cedula_EstudianteTextBox.TabIndex = 8
        '
        'Direccion_EstudianteLabel
        '
        Direccion_EstudianteLabel.AutoSize = True
        Direccion_EstudianteLabel.Location = New System.Drawing.Point(164, 207)
        Direccion_EstudianteLabel.Name = "Direccion_EstudianteLabel"
        Direccion_EstudianteLabel.Size = New System.Drawing.Size(108, 13)
        Direccion_EstudianteLabel.TabIndex = 9
        Direccion_EstudianteLabel.Text = "Direccion Estudiante:"
        '
        'Direccion_EstudianteTextBox
        '
        Me.Direccion_EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "Direccion_Estudiante", True))
        Me.Direccion_EstudianteTextBox.Location = New System.Drawing.Point(319, 204)
        Me.Direccion_EstudianteTextBox.Name = "Direccion_EstudianteTextBox"
        Me.Direccion_EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Direccion_EstudianteTextBox.TabIndex = 10
        '
        'Fecha_Nacimiento_EstudianteLabel
        '
        Fecha_Nacimiento_EstudianteLabel.AutoSize = True
        Fecha_Nacimiento_EstudianteLabel.Location = New System.Drawing.Point(164, 234)
        Fecha_Nacimiento_EstudianteLabel.Name = "Fecha_Nacimiento_EstudianteLabel"
        Fecha_Nacimiento_EstudianteLabel.Size = New System.Drawing.Size(149, 13)
        Fecha_Nacimiento_EstudianteLabel.TabIndex = 11
        Fecha_Nacimiento_EstudianteLabel.Text = "Fecha Nacimiento Estudiante:"
        '
        'Fecha_Nacimiento_EstudianteDateTimePicker
        '
        Me.Fecha_Nacimiento_EstudianteDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TB_ESTUDIANTEBindingSource, "Fecha_Nacimiento_Estudiante", True))
        Me.Fecha_Nacimiento_EstudianteDateTimePicker.Location = New System.Drawing.Point(319, 230)
        Me.Fecha_Nacimiento_EstudianteDateTimePicker.Name = "Fecha_Nacimiento_EstudianteDateTimePicker"
        Me.Fecha_Nacimiento_EstudianteDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_Nacimiento_EstudianteDateTimePicker.TabIndex = 12
        '
        'Acudiente_EstudianteLabel
        '
        Acudiente_EstudianteLabel.AutoSize = True
        Acudiente_EstudianteLabel.Location = New System.Drawing.Point(164, 259)
        Acudiente_EstudianteLabel.Name = "Acudiente_EstudianteLabel"
        Acudiente_EstudianteLabel.Size = New System.Drawing.Size(111, 13)
        Acudiente_EstudianteLabel.TabIndex = 13
        Acudiente_EstudianteLabel.Text = "Acudiente Estudiante:"
        '
        'Acudiente_EstudianteTextBox
        '
        Me.Acudiente_EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "Acudiente_Estudiante", True))
        Me.Acudiente_EstudianteTextBox.Location = New System.Drawing.Point(319, 256)
        Me.Acudiente_EstudianteTextBox.Name = "Acudiente_EstudianteTextBox"
        Me.Acudiente_EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Acudiente_EstudianteTextBox.TabIndex = 14
        '
        'Fecha_MatriculaLabel
        '
        Fecha_MatriculaLabel.AutoSize = True
        Fecha_MatriculaLabel.Location = New System.Drawing.Point(164, 286)
        Fecha_MatriculaLabel.Name = "Fecha_MatriculaLabel"
        Fecha_MatriculaLabel.Size = New System.Drawing.Size(86, 13)
        Fecha_MatriculaLabel.TabIndex = 15
        Fecha_MatriculaLabel.Text = "Fecha Matricula:"
        '
        'Fecha_MatriculaDateTimePicker
        '
        Me.Fecha_MatriculaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TB_ESTUDIANTEBindingSource, "Fecha_Matricula", True))
        Me.Fecha_MatriculaDateTimePicker.Location = New System.Drawing.Point(319, 282)
        Me.Fecha_MatriculaDateTimePicker.Name = "Fecha_MatriculaDateTimePicker"
        Me.Fecha_MatriculaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_MatriculaDateTimePicker.TabIndex = 16
        '
        'Cod_GrupoLabel
        '
        Cod_GrupoLabel.AutoSize = True
        Cod_GrupoLabel.Location = New System.Drawing.Point(164, 311)
        Cod_GrupoLabel.Name = "Cod_GrupoLabel"
        Cod_GrupoLabel.Size = New System.Drawing.Size(61, 13)
        Cod_GrupoLabel.TabIndex = 17
        Cod_GrupoLabel.Text = "Cod Grupo:"
        '
        'Cod_GrupoTextBox
        '
        Me.Cod_GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "Cod_Grupo", True))
        Me.Cod_GrupoTextBox.Location = New System.Drawing.Point(319, 308)
        Me.Cod_GrupoTextBox.Name = "Cod_GrupoTextBox"
        Me.Cod_GrupoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cod_GrupoTextBox.TabIndex = 18
        '
        'Genero_EstudianteLabel
        '
        Genero_EstudianteLabel.AutoSize = True
        Genero_EstudianteLabel.Location = New System.Drawing.Point(164, 337)
        Genero_EstudianteLabel.Name = "Genero_EstudianteLabel"
        Genero_EstudianteLabel.Size = New System.Drawing.Size(98, 13)
        Genero_EstudianteLabel.TabIndex = 19
        Genero_EstudianteLabel.Text = "Genero Estudiante:"
        '
        'Genero_EstudianteTextBox
        '
        Me.Genero_EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "Genero_Estudiante", True))
        Me.Genero_EstudianteTextBox.Location = New System.Drawing.Point(319, 334)
        Me.Genero_EstudianteTextBox.Name = "Genero_EstudianteTextBox"
        Me.Genero_EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Genero_EstudianteTextBox.TabIndex = 20
        '
        'Correo_EstudianteLabel
        '
        Correo_EstudianteLabel.AutoSize = True
        Correo_EstudianteLabel.Location = New System.Drawing.Point(164, 363)
        Correo_EstudianteLabel.Name = "Correo_EstudianteLabel"
        Correo_EstudianteLabel.Size = New System.Drawing.Size(94, 13)
        Correo_EstudianteLabel.TabIndex = 21
        Correo_EstudianteLabel.Text = "Correo Estudiante:"
        '
        'Correo_EstudianteTextBox
        '
        Me.Correo_EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "Correo_Estudiante", True))
        Me.Correo_EstudianteTextBox.Location = New System.Drawing.Point(319, 360)
        Me.Correo_EstudianteTextBox.Name = "Correo_EstudianteTextBox"
        Me.Correo_EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Correo_EstudianteTextBox.TabIndex = 22
        '
        'SegundoNombre_EstudianteLabel
        '
        SegundoNombre_EstudianteLabel.AutoSize = True
        SegundoNombre_EstudianteLabel.Location = New System.Drawing.Point(164, 389)
        SegundoNombre_EstudianteLabel.Name = "SegundoNombre_EstudianteLabel"
        SegundoNombre_EstudianteLabel.Size = New System.Drawing.Size(146, 13)
        SegundoNombre_EstudianteLabel.TabIndex = 23
        SegundoNombre_EstudianteLabel.Text = "Segundo Nombre Estudiante:"
        '
        'SegundoNombre_EstudianteTextBox
        '
        Me.SegundoNombre_EstudianteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TB_ESTUDIANTEBindingSource, "SegundoNombre_Estudiante", True))
        Me.SegundoNombre_EstudianteTextBox.Location = New System.Drawing.Point(319, 386)
        Me.SegundoNombre_EstudianteTextBox.Name = "SegundoNombre_EstudianteTextBox"
        Me.SegundoNombre_EstudianteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SegundoNombre_EstudianteTextBox.TabIndex = 24
        '
        'Prueba2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 442)
        Me.Controls.Add(Nombre_EstudianteLabel)
        Me.Controls.Add(Me.Nombre_EstudianteTextBox)
        Me.Controls.Add(PrimerApellido_EstudianteLabel)
        Me.Controls.Add(Me.PrimerApellido_EstudianteTextBox)
        Me.Controls.Add(SegundoApellido_EstudianteLabel)
        Me.Controls.Add(Me.SegundoApellido_EstudianteTextBox)
        Me.Controls.Add(Cedula_EstudianteLabel)
        Me.Controls.Add(Me.Cedula_EstudianteTextBox)
        Me.Controls.Add(Direccion_EstudianteLabel)
        Me.Controls.Add(Me.Direccion_EstudianteTextBox)
        Me.Controls.Add(Fecha_Nacimiento_EstudianteLabel)
        Me.Controls.Add(Me.Fecha_Nacimiento_EstudianteDateTimePicker)
        Me.Controls.Add(Acudiente_EstudianteLabel)
        Me.Controls.Add(Me.Acudiente_EstudianteTextBox)
        Me.Controls.Add(Fecha_MatriculaLabel)
        Me.Controls.Add(Me.Fecha_MatriculaDateTimePicker)
        Me.Controls.Add(Cod_GrupoLabel)
        Me.Controls.Add(Me.Cod_GrupoTextBox)
        Me.Controls.Add(Genero_EstudianteLabel)
        Me.Controls.Add(Me.Genero_EstudianteTextBox)
        Me.Controls.Add(Correo_EstudianteLabel)
        Me.Controls.Add(Me.Correo_EstudianteTextBox)
        Me.Controls.Add(SegundoNombre_EstudianteLabel)
        Me.Controls.Add(Me.SegundoNombre_EstudianteTextBox)
        Me.Controls.Add(Me.TB_ESTUDIANTEBindingNavigator)
        Me.Name = "Prueba2"
        Me.Text = "Prueba2"
        'CType(Me.EscuelaRMPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_ESTUDIANTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_ESTUDIANTEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TB_ESTUDIANTEBindingNavigator.ResumeLayout(False)
        Me.TB_ESTUDIANTEBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents EscuelaRMPDataSet As Escuela_Ricardo_Martinelli.EscuelaRMPDataSet1
    Friend WithEvents TB_ESTUDIANTEBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents TB_ESTUDIANTETableAdapter As Escuela_Ricardo_Martinelli.EscuelaRMPDataSet1TableAdapters.TB_ESTUDIANTETableAdapter
    'Friend WithEvents TableAdapterManager As Escuela_Ricardo_Martinelli.EscuelaRMPDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TB_ESTUDIANTEBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TB_ESTUDIANTEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nombre_EstudianteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrimerApellido_EstudianteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SegundoApellido_EstudianteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cedula_EstudianteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Direccion_EstudianteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_Nacimiento_EstudianteDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Acudiente_EstudianteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_MatriculaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cod_GrupoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Genero_EstudianteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_EstudianteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SegundoNombre_EstudianteTextBox As System.Windows.Forms.TextBox
End Class
