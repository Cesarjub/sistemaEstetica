<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Citas))
        Me.TablaCitas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BotonLimpiarCampos = New System.Windows.Forms.Button()
        Me.BotonRefrescar = New System.Windows.Forms.Button()
        Me.BotonRegistrar = New System.Windows.Forms.Button()
        Me.BotonModificar = New System.Windows.Forms.Button()
        Me.BotonEliminar = New System.Windows.Forms.Button()
        Me.labelID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.labelDescripcion = New System.Windows.Forms.Label()
        Me.labelTarifa = New System.Windows.Forms.Label()
        Me.labelTrabajador = New System.Windows.Forms.Label()
        Me.labelFecha = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtTarifa = New System.Windows.Forms.TextBox()
        Me.ClienteTrabajador = New System.Windows.Forms.ComboBox()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.labelCliente = New System.Windows.Forms.Label()
        Me.BotonCerrar = New System.Windows.Forms.Button()
        Me.BuscarCita = New System.Windows.Forms.TextBox()
        Me.BotonBuscar = New System.Windows.Forms.Button()
        Me.LogoCitas = New System.Windows.Forms.Label()
        Me.calendarioFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.TablaCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TablaCitas
        '
        Me.TablaCitas.AllowUserToAddRows = False
        Me.TablaCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TablaCitas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TablaCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaCitas.Location = New System.Drawing.Point(12, 81)
        Me.TablaCitas.Name = "TablaCitas"
        Me.TablaCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaCitas.Size = New System.Drawing.Size(810, 150)
        Me.TablaCitas.TabIndex = 51
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.calendarioFecha)
        Me.Panel1.Controls.Add(Me.BotonLimpiarCampos)
        Me.Panel1.Controls.Add(Me.BotonRefrescar)
        Me.Panel1.Controls.Add(Me.BotonRegistrar)
        Me.Panel1.Controls.Add(Me.BotonModificar)
        Me.Panel1.Controls.Add(Me.BotonEliminar)
        Me.Panel1.Controls.Add(Me.labelID)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.labelDescripcion)
        Me.Panel1.Controls.Add(Me.labelTarifa)
        Me.Panel1.Controls.Add(Me.labelTrabajador)
        Me.Panel1.Controls.Add(Me.labelFecha)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtTarifa)
        Me.Panel1.Controls.Add(Me.ClienteTrabajador)
        Me.Panel1.Controls.Add(Me.ComboCliente)
        Me.Panel1.Controls.Add(Me.labelCliente)
        Me.Panel1.Controls.Add(Me.BotonCerrar)
        Me.Panel1.Controls.Add(Me.BuscarCita)
        Me.Panel1.Controls.Add(Me.BotonBuscar)
        Me.Panel1.Controls.Add(Me.LogoCitas)
        Me.Panel1.Controls.Add(Me.TablaCitas)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 495)
        Me.Panel1.TabIndex = 53
        '
        'BotonLimpiarCampos
        '
        Me.BotonLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonLimpiarCampos.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonLimpiarCampos.Image = CType(resources.GetObject("BotonLimpiarCampos.Image"), System.Drawing.Image)
        Me.BotonLimpiarCampos.Location = New System.Drawing.Point(747, 386)
        Me.BotonLimpiarCampos.Name = "BotonLimpiarCampos"
        Me.BotonLimpiarCampos.Size = New System.Drawing.Size(75, 58)
        Me.BotonLimpiarCampos.TabIndex = 73
        Me.BotonLimpiarCampos.UseVisualStyleBackColor = True
        '
        'BotonRefrescar
        '
        Me.BotonRefrescar.AccessibleDescription = ""
        Me.BotonRefrescar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonRefrescar.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonRefrescar.Image = CType(resources.GetObject("BotonRefrescar.Image"), System.Drawing.Image)
        Me.BotonRefrescar.Location = New System.Drawing.Point(666, 386)
        Me.BotonRefrescar.Name = "BotonRefrescar"
        Me.BotonRefrescar.Size = New System.Drawing.Size(75, 58)
        Me.BotonRefrescar.TabIndex = 72
        Me.BotonRefrescar.Tag = ""
        Me.BotonRefrescar.UseVisualStyleBackColor = True
        '
        'BotonRegistrar
        '
        Me.BotonRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonRegistrar.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonRegistrar.Image = CType(resources.GetObject("BotonRegistrar.Image"), System.Drawing.Image)
        Me.BotonRegistrar.Location = New System.Drawing.Point(12, 391)
        Me.BotonRegistrar.Name = "BotonRegistrar"
        Me.BotonRegistrar.Size = New System.Drawing.Size(132, 63)
        Me.BotonRegistrar.TabIndex = 68
        Me.BotonRegistrar.UseVisualStyleBackColor = True
        '
        'BotonModificar
        '
        Me.BotonModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonModificar.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonModificar.Image = CType(resources.GetObject("BotonModificar.Image"), System.Drawing.Image)
        Me.BotonModificar.Location = New System.Drawing.Point(178, 391)
        Me.BotonModificar.Name = "BotonModificar"
        Me.BotonModificar.Size = New System.Drawing.Size(132, 63)
        Me.BotonModificar.TabIndex = 69
        Me.BotonModificar.UseVisualStyleBackColor = True
        '
        'BotonEliminar
        '
        Me.BotonEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonEliminar.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonEliminar.Image = CType(resources.GetObject("BotonEliminar.Image"), System.Drawing.Image)
        Me.BotonEliminar.Location = New System.Drawing.Point(347, 391)
        Me.BotonEliminar.Name = "BotonEliminar"
        Me.BotonEliminar.Size = New System.Drawing.Size(132, 63)
        Me.BotonEliminar.TabIndex = 70
        Me.BotonEliminar.UseVisualStyleBackColor = True
        '
        'labelID
        '
        Me.labelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelID.Location = New System.Drawing.Point(576, 241)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(100, 38)
        Me.labelID.TabIndex = 67
        Me.labelID.Text = "ID:"
        Me.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(680, 244)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(142, 35)
        Me.txtID.TabIndex = 66
        '
        'labelDescripcion
        '
        Me.labelDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelDescripcion.Location = New System.Drawing.Point(366, 342)
        Me.labelDescripcion.Name = "labelDescripcion"
        Me.labelDescripcion.Size = New System.Drawing.Size(150, 38)
        Me.labelDescripcion.TabIndex = 65
        Me.labelDescripcion.Text = "Descripción:"
        Me.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelTarifa
        '
        Me.labelTarifa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTarifa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelTarifa.Location = New System.Drawing.Point(576, 290)
        Me.labelTarifa.Name = "labelTarifa"
        Me.labelTarifa.Size = New System.Drawing.Size(100, 38)
        Me.labelTarifa.TabIndex = 64
        Me.labelTarifa.Text = "Tarifa:"
        Me.labelTarifa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelTrabajador
        '
        Me.labelTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTrabajador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelTrabajador.Location = New System.Drawing.Point(12, 290)
        Me.labelTrabajador.Name = "labelTrabajador"
        Me.labelTrabajador.Size = New System.Drawing.Size(137, 38)
        Me.labelTrabajador.TabIndex = 63
        Me.labelTrabajador.Text = "Trabajador:"
        Me.labelTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelFecha
        '
        Me.labelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelFecha.Location = New System.Drawing.Point(12, 342)
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(100, 38)
        Me.labelFecha.TabIndex = 62
        Me.labelFecha.Text = "Fecha:"
        Me.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(522, 345)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 35)
        Me.txtDescripcion.TabIndex = 61
        '
        'txtTarifa
        '
        Me.txtTarifa.Location = New System.Drawing.Point(680, 293)
        Me.txtTarifa.Multiline = True
        Me.txtTarifa.Name = "txtTarifa"
        Me.txtTarifa.Size = New System.Drawing.Size(142, 35)
        Me.txtTarifa.TabIndex = 59
        '
        'ClienteTrabajador
        '
        Me.ClienteTrabajador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClienteTrabajador.FormattingEnabled = True
        Me.ClienteTrabajador.Location = New System.Drawing.Point(165, 298)
        Me.ClienteTrabajador.Name = "ClienteTrabajador"
        Me.ClienteTrabajador.Size = New System.Drawing.Size(388, 21)
        Me.ClienteTrabajador.TabIndex = 58
        '
        'ComboCliente
        '
        Me.ComboCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(118, 250)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(435, 21)
        Me.ComboCliente.TabIndex = 57
        '
        'labelCliente
        '
        Me.labelCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelCliente.Location = New System.Drawing.Point(12, 241)
        Me.labelCliente.Name = "labelCliente"
        Me.labelCliente.Size = New System.Drawing.Size(100, 38)
        Me.labelCliente.TabIndex = 56
        Me.labelCliente.Text = "Cliente:"
        Me.labelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.BotonCerrar.TabIndex = 55
        Me.BotonCerrar.UseVisualStyleBackColor = False
        '
        'BuscarCita
        '
        Me.BuscarCita.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BuscarCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarCita.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BuscarCita.Location = New System.Drawing.Point(267, 12)
        Me.BuscarCita.Multiline = True
        Me.BuscarCita.Name = "BuscarCita"
        Me.BuscarCita.Size = New System.Drawing.Size(300, 47)
        Me.BuscarCita.TabIndex = 54
        Me.BuscarCita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BotonBuscar
        '
        Me.BotonBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonBuscar.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonBuscar.Image = CType(resources.GetObject("BotonBuscar.Image"), System.Drawing.Image)
        Me.BotonBuscar.Location = New System.Drawing.Point(568, 9)
        Me.BotonBuscar.Name = "BotonBuscar"
        Me.BotonBuscar.Size = New System.Drawing.Size(67, 55)
        Me.BotonBuscar.TabIndex = 53
        Me.BotonBuscar.UseVisualStyleBackColor = True
        '
        'LogoCitas
        '
        Me.LogoCitas.ForeColor = System.Drawing.Color.White
        Me.LogoCitas.Image = CType(resources.GetObject("LogoCitas.Image"), System.Drawing.Image)
        Me.LogoCitas.Location = New System.Drawing.Point(28, 9)
        Me.LogoCitas.Name = "LogoCitas"
        Me.LogoCitas.Size = New System.Drawing.Size(182, 69)
        Me.LogoCitas.TabIndex = 52
        '
        'calendarioFecha
        '
        Me.calendarioFecha.Location = New System.Drawing.Point(110, 352)
        Me.calendarioFecha.Name = "calendarioFecha"
        Me.calendarioFecha.Size = New System.Drawing.Size(214, 20)
        Me.calendarioFecha.TabIndex = 74
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 456)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Citas"
        Me.Text = "Citas"
        CType(Me.TablaCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TablaCitas As DataGridView
    Friend WithEvents Panel1 As Panel
    Private WithEvents BuscarCita As TextBox
    Private WithEvents BotonBuscar As Button
    Private WithEvents LogoCitas As Label
    Private WithEvents BotonCerrar As Button
    Private WithEvents labelID As Label
    Private WithEvents txtID As TextBox
    Private WithEvents labelDescripcion As Label
    Private WithEvents labelTarifa As Label
    Private WithEvents labelTrabajador As Label
    Private WithEvents labelFecha As Label
    Private WithEvents txtDescripcion As TextBox
    Private WithEvents txtTarifa As TextBox
    Private WithEvents ClienteTrabajador As ComboBox
    Private WithEvents ComboCliente As ComboBox
    Private WithEvents labelCliente As Label
    Friend WithEvents BotonLimpiarCampos As Button
    Friend WithEvents BotonRefrescar As Button
    Friend WithEvents BotonRegistrar As Button
    Friend WithEvents BotonModificar As Button
    Friend WithEvents BotonEliminar As Button
    Friend WithEvents calendarioFecha As DateTimePicker
End Class
