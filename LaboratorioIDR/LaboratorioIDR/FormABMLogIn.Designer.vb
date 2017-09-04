<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormABMLogIn
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
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.LbContraseña = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DGVLogIn = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGVLogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.Location = New System.Drawing.Point(12, 9)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LbUsuario.TabIndex = 0
        Me.LbUsuario.Text = "Usuario"
        '
        'LbContraseña
        '
        Me.LbContraseña.AutoSize = True
        Me.LbContraseña.Location = New System.Drawing.Point(12, 42)
        Me.LbContraseña.Name = "LbContraseña"
        Me.LbContraseña.Size = New System.Drawing.Size(61, 13)
        Me.LbContraseña.TabIndex = 1
        Me.LbContraseña.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(110, 12)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(219, 20)
        Me.TxtUsuario.TabIndex = 2
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(110, 39)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(219, 20)
        Me.TxtContraseña.TabIndex = 3
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(15, 94)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(138, 94)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 6
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'DGVLogIn
        '
        Me.DGVLogIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLogIn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DGVLogIn.Location = New System.Drawing.Point(372, 13)
        Me.DGVLogIn.Name = "DGVLogIn"
        Me.DGVLogIn.Size = New System.Drawing.Size(186, 268)
        Me.DGVLogIn.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormABMLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 293)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVLogIn)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LbContraseña)
        Me.Controls.Add(Me.LbUsuario)
        Me.Name = "FormABMLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormABMLogIn"
        CType(Me.DGVLogIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbUsuario As Label
    Friend WithEvents LbContraseña As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DGVLogIn As DataGridView
    Friend WithEvents Button1 As Button
End Class
