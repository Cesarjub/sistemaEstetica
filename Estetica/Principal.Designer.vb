<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.BotonCitas = New System.Windows.Forms.Button()
        Me.BotonClientes = New System.Windows.Forms.Button()
        Me.BotonEmpleados = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BotonCerrar = New System.Windows.Forms.Button()
        Me.ImagenBienvenido = New System.Windows.Forms.Label()
        Me.ImagenLogo = New System.Windows.Forms.Label()
        Me.ImagenCara = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BotonCitas
        '
        Me.BotonCitas.BackColor = System.Drawing.Color.White
        Me.BotonCitas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCitas.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonCitas.Image = CType(resources.GetObject("BotonCitas.Image"), System.Drawing.Image)
        Me.BotonCitas.Location = New System.Drawing.Point(525, 76)
        Me.BotonCitas.Name = "BotonCitas"
        Me.BotonCitas.Size = New System.Drawing.Size(380, 105)
        Me.BotonCitas.TabIndex = 10
        Me.BotonCitas.UseVisualStyleBackColor = True
        '
        'BotonClientes
        '
        Me.BotonClientes.BackColor = System.Drawing.Color.White
        Me.BotonClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonClientes.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonClientes.Image = CType(resources.GetObject("BotonClientes.Image"), System.Drawing.Image)
        Me.BotonClientes.Location = New System.Drawing.Point(498, 205)
        Me.BotonClientes.Name = "BotonClientes"
        Me.BotonClientes.Size = New System.Drawing.Size(407, 107)
        Me.BotonClientes.TabIndex = 10
        Me.BotonClientes.UseVisualStyleBackColor = True
        '
        'BotonEmpleados
        '
        Me.BotonEmpleados.BackColor = System.Drawing.Color.White
        Me.BotonEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonEmpleados.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonEmpleados.Image = CType(resources.GetObject("BotonEmpleados.Image"), System.Drawing.Image)
        Me.BotonEmpleados.Location = New System.Drawing.Point(457, 329)
        Me.BotonEmpleados.Name = "BotonEmpleados"
        Me.BotonEmpleados.Size = New System.Drawing.Size(448, 110)
        Me.BotonEmpleados.TabIndex = 10
        Me.BotonEmpleados.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BotonCerrar)
        Me.Panel1.Controls.Add(Me.BotonCitas)
        Me.Panel1.Controls.Add(Me.BotonClientes)
        Me.Panel1.Controls.Add(Me.BotonEmpleados)
        Me.Panel1.Controls.Add(Me.ImagenBienvenido)
        Me.Panel1.Controls.Add(Me.ImagenLogo)
        Me.Panel1.Controls.Add(Me.ImagenCara)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 450)
        Me.Panel1.TabIndex = 3
        '
        'BotonCerrar
        '
        Me.BotonCerrar.BackColor = System.Drawing.Color.White
        Me.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCerrar.ForeColor = System.Drawing.SystemColors.Window
        Me.BotonCerrar.Image = CType(resources.GetObject("BotonCerrar.Image"), System.Drawing.Image)
        Me.BotonCerrar.Location = New System.Drawing.Point(847, 13)
        Me.BotonCerrar.Name = "BotonCerrar"
        Me.BotonCerrar.Size = New System.Drawing.Size(58, 57)
        Me.BotonCerrar.TabIndex = 10
        Me.BotonCerrar.UseVisualStyleBackColor = False
        '
        'ImagenBienvenido
        '
        Me.ImagenBienvenido.Image = CType(resources.GetObject("ImagenBienvenido.Image"), System.Drawing.Image)
        Me.ImagenBienvenido.Location = New System.Drawing.Point(23, 26)
        Me.ImagenBienvenido.Name = "ImagenBienvenido"
        Me.ImagenBienvenido.Size = New System.Drawing.Size(197, 51)
        Me.ImagenBienvenido.TabIndex = 9
        '
        'ImagenLogo
        '
        Me.ImagenLogo.Image = CType(resources.GetObject("ImagenLogo.Image"), System.Drawing.Image)
        Me.ImagenLogo.Location = New System.Drawing.Point(5, 73)
        Me.ImagenLogo.Name = "ImagenLogo"
        Me.ImagenLogo.Size = New System.Drawing.Size(94, 96)
        Me.ImagenLogo.TabIndex = 8
        '
        'ImagenCara
        '
        Me.ImagenCara.Image = CType(resources.GetObject("ImagenCara.Image"), System.Drawing.Image)
        Me.ImagenCara.Location = New System.Drawing.Point(-27, -25)
        Me.ImagenCara.Name = "ImagenCara"
        Me.ImagenCara.Size = New System.Drawing.Size(585, 504)
        Me.ImagenCara.TabIndex = 7
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(919, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Private WithEvents BotonCerrar As Button
    Private WithEvents ImagenBienvenido As Label
    Private WithEvents ImagenLogo As Label
    Private WithEvents ImagenCara As Label
    Private WithEvents BotonCitas As Button
    Private WithEvents BotonClientes As Button
    Private WithEvents BotonEmpleados As Button
End Class
