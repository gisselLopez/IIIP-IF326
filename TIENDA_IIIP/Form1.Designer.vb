<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtPsw = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnDesencriptar = New System.Windows.Forms.Button()
        Me.txtModificado = New System.Windows.Forms.TextBox()
        Me.btnEncriptar = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtResultado)
        Me.GroupBox1.Controls.Add(Me.txtModificado)
        Me.GroupBox1.Controls.Add(Me.cmbRol)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtPsw)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 247)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos usuario"
        '
        'cmbRol
        '
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Items.AddRange(New Object() {"Activo", "Eliminado"})
        Me.cmbRol.Location = New System.Drawing.Point(323, 20)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(126, 24)
        Me.cmbRol.TabIndex = 13
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(323, 89)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(126, 22)
        Me.txtCorreo.TabIndex = 12
        '
        'txtPsw
        '
        Me.txtPsw.Location = New System.Drawing.Point(107, 131)
        Me.txtPsw.Name = "txtPsw"
        Me.txtPsw.Size = New System.Drawing.Size(126, 22)
        Me.txtPsw.TabIndex = 11
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(323, 56)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(126, 22)
        Me.txtUsername.TabIndex = 10
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(107, 92)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(126, 22)
        Me.txtApellido.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(107, 59)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(126, 22)
        Me.txtNombre.TabIndex = 8
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(107, 23)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(126, 22)
        Me.txtCodigo.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(243, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Correo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(243, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Rol"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(8, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(243, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(8, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(27, 265)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(117, 31)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnDesencriptar
        '
        Me.btnDesencriptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesencriptar.Location = New System.Drawing.Point(254, 265)
        Me.btnDesencriptar.Name = "btnDesencriptar"
        Me.btnDesencriptar.Size = New System.Drawing.Size(105, 32)
        Me.btnDesencriptar.TabIndex = 2
        Me.btnDesencriptar.Text = "Desencriptar"
        Me.btnDesencriptar.UseVisualStyleBackColor = True
        '
        'txtModificado
        '
        Me.txtModificado.Location = New System.Drawing.Point(109, 164)
        Me.txtModificado.Multiline = True
        Me.txtModificado.Name = "txtModificado"
        Me.txtModificado.Size = New System.Drawing.Size(124, 31)
        Me.txtModificado.TabIndex = 14
        '
        'btnEncriptar
        '
        Me.btnEncriptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncriptar.Location = New System.Drawing.Point(145, 265)
        Me.btnEncriptar.Name = "btnEncriptar"
        Me.btnEncriptar.Size = New System.Drawing.Size(100, 32)
        Me.btnEncriptar.TabIndex = 3
        Me.btnEncriptar.Text = "Encriptar"
        Me.btnEncriptar.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(109, 205)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(124, 30)
        Me.txtResultado.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(13, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Encriptar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(6, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Desencriptar"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(364, 265)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(112, 32)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(495, 307)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEncriptar)
        Me.Controls.Add(Me.btnDesencriptar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmUsuario"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtPsw As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnDesencriptar As Button
    Friend WithEvents txtModificado As TextBox
    Friend WithEvents btnEncriptar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnSalir As Button
End Class
