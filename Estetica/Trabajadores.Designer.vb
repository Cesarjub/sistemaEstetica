<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trabajadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trabajadores))
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCrearId = New System.Windows.Forms.Button()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.labelSalario = New System.Windows.Forms.Label()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelID = New System.Windows.Forms.Label()
        Me.BotonCerrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.LogoTrabajador = New System.Windows.Forms.Label()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.AllowUserToAddRows = False
        Me.DataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridViewTable.Location = New System.Drawing.Point(12, 75)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewTable.Size = New System.Drawing.Size(810, 191)
        Me.DataGridViewTable.TabIndex = 62
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemEditar, Me.ToolStripMenuItemEliminar, Me.ToolStripMenuItemSelectAll})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 70)
        '
        'ToolStripMenuItemEditar
        '
        Me.ToolStripMenuItemEditar.Image = CType(resources.GetObject("ToolStripMenuItemEditar.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemEditar.Name = "ToolStripMenuItemEditar"
        Me.ToolStripMenuItemEditar.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItemEditar.Text = "Editar"
        '
        'ToolStripMenuItemEliminar
        '
        Me.ToolStripMenuItemEliminar.Image = CType(resources.GetObject("ToolStripMenuItemEliminar.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemEliminar.Name = "ToolStripMenuItemEliminar"
        Me.ToolStripMenuItemEliminar.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItemEliminar.Text = "Eliminar"
        '
        'ToolStripMenuItemSelectAll
        '
        Me.ToolStripMenuItemSelectAll.Image = CType(resources.GetObject("ToolStripMenuItemSelectAll.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemSelectAll.Name = "ToolStripMenuItemSelectAll"
        Me.ToolStripMenuItemSelectAll.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItemSelectAll.Text = "Seleccionar Todo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.btnRefrescar)
        Me.Panel1.Controls.Add(Me.btnRegistrar)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnCrearId)
        Me.Panel1.Controls.Add(Me.txtSalario)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.labelSalario)
        Me.Panel1.Controls.Add(Me.labelNombre)
        Me.Panel1.Controls.Add(Me.labelID)
        Me.Panel1.Controls.Add(Me.BotonCerrar)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.buscar)
        Me.Panel1.Controls.Add(Me.LogoTrabajador)
        Me.Panel1.Controls.Add(Me.DataGridViewTable)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 495)
        Me.Panel1.TabIndex = 64
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(747, 386)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 58)
        Me.btnLimpiar.TabIndex = 84
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.AccessibleDescription = ""
        Me.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.Location = New System.Drawing.Point(666, 386)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(75, 58)
        Me.btnRefrescar.TabIndex = 83
        Me.btnRefrescar.Tag = ""
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"), System.Drawing.Image)
        Me.btnRegistrar.Location = New System.Drawing.Point(12, 391)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(132, 63)
        Me.btnRegistrar.TabIndex = 80
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(178, 391)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(132, 63)
        Me.btnModificar.TabIndex = 81
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(347, 391)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(132, 63)
        Me.btnEliminar.TabIndex = 82
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnCrearId
        '
        Me.btnCrearId.BackColor = System.Drawing.Color.White
        Me.btnCrearId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearId.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCrearId.Image = CType(resources.GetObject("btnCrearId.Image"), System.Drawing.Image)
        Me.btnCrearId.Location = New System.Drawing.Point(310, 280)
        Me.btnCrearId.Name = "btnCrearId"
        Me.btnCrearId.Size = New System.Drawing.Size(48, 55)
        Me.btnCrearId.TabIndex = 79
        Me.btnCrearId.UseVisualStyleBackColor = False
        '
        'txtSalario
        '
        Me.txtSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalario.Location = New System.Drawing.Point(615, 288)
        Me.txtSalario.Multiline = True
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(166, 35)
        Me.txtSalario.TabIndex = 72
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(151, 350)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(377, 35)
        Me.txtNombre.TabIndex = 71
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(97, 288)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(207, 35)
        Me.txtId.TabIndex = 70
        '
        'labelSalario
        '
        Me.labelSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSalario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelSalario.Location = New System.Drawing.Point(469, 285)
        Me.labelSalario.Name = "labelSalario"
        Me.labelSalario.Size = New System.Drawing.Size(137, 38)
        Me.labelSalario.TabIndex = 69
        Me.labelSalario.Text = "Salario:"
        Me.labelSalario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelNombre
        '
        Me.labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelNombre.Location = New System.Drawing.Point(50, 347)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(137, 38)
        Me.labelNombre.TabIndex = 68
        Me.labelNombre.Text = "Nombre:"
        Me.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelID
        '
        Me.labelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelID.Location = New System.Drawing.Point(50, 285)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(137, 38)
        Me.labelID.TabIndex = 67
        Me.labelID.Text = "ID:"
        Me.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BotonCerrar
        '
        Me.BotonCerrar.BackColor = System.Drawing.Color.White
        Me.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCerrar.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonCerrar.Image = CType(resources.GetObject("BotonCerrar.Image"), System.Drawing.Image)
        Me.BotonCerrar.Location = New System.Drawing.Point(764, 12)
        Me.BotonCerrar.Name = "BotonCerrar"
        Me.BotonCerrar.Size = New System.Drawing.Size(58, 57)
        Me.BotonCerrar.TabIndex = 66
        Me.BotonCerrar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(568, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 55)
        Me.btnBuscar.TabIndex = 65
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'buscar
        '
        Me.buscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.buscar.Location = New System.Drawing.Point(267, 12)
        Me.buscar.Multiline = True
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(300, 47)
        Me.buscar.TabIndex = 64
        Me.buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogoTrabajador
        '
        Me.LogoTrabajador.Image = CType(resources.GetObject("LogoTrabajador.Image"), System.Drawing.Image)
        Me.LogoTrabajador.Location = New System.Drawing.Point(-15, 15)
        Me.LogoTrabajador.Name = "LogoTrabajador"
        Me.LogoTrabajador.Size = New System.Drawing.Size(281, 51)
        Me.LogoTrabajador.TabIndex = 63
        Me.LogoTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Trabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 456)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Trabajadores"
        Me.Text = "Trabajadores"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents Panel1 As Panel
    Private WithEvents btnBuscar As Button
    Private WithEvents buscar As TextBox
    Private WithEvents LogoTrabajador As Label
    Private WithEvents BotonCerrar As Button
    Private WithEvents txtSalario As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents txtId As TextBox
    Private WithEvents labelSalario As Label
    Private WithEvents labelNombre As Label
    Private WithEvents labelID As Label
    Friend WithEvents btnCrearId As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemEditar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemEliminar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSelectAll As ToolStripMenuItem
End Class
