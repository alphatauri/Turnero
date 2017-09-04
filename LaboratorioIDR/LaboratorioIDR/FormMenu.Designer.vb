<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtorgarTurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerTurnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProfesionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AgendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GESTIONDEUSUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'TurnosToolStripMenuItem
        '
        Me.TurnosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtorgarTurnosToolStripMenuItem, Me.ToolStripSeparator4, Me.VerTurnosToolStripMenuItem})
        Me.TurnosToolStripMenuItem.Name = "TurnosToolStripMenuItem"
        Me.TurnosToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.TurnosToolStripMenuItem.Text = "RECEPCION"
        '
        'OtorgarTurnosToolStripMenuItem
        '
        Me.OtorgarTurnosToolStripMenuItem.Enabled = False
        Me.OtorgarTurnosToolStripMenuItem.Name = "OtorgarTurnosToolStripMenuItem"
        Me.OtorgarTurnosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.OtorgarTurnosToolStripMenuItem.Text = "ASIGNAR TURNOS"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(188, 6)
        '
        'VerTurnosToolStripMenuItem
        '
        Me.VerTurnosToolStripMenuItem.Enabled = False
        Me.VerTurnosToolStripMenuItem.Name = "VerTurnosToolStripMenuItem"
        Me.VerTurnosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.VerTurnosToolStripMenuItem.Text = "INFORME DE TURNOS"
        '
        'AdministrarToolStripMenuItem
        '
        Me.AdministrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacientesToolStripMenuItem, Me.ToolStripSeparator2, Me.ProfesionalesToolStripMenuItem, Me.ToolStripSeparator3, Me.AgendasToolStripMenuItem, Me.ToolStripSeparator1, Me.GESTIONDEUSUARIOSToolStripMenuItem})
        Me.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem"
        Me.AdministrarToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.AdministrarToolStripMenuItem.Text = "ADMINISTRACION"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.PacientesToolStripMenuItem.Text = "GESTION DE PACIENTES"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(227, 6)
        '
        'ProfesionalesToolStripMenuItem
        '
        Me.ProfesionalesToolStripMenuItem.Name = "ProfesionalesToolStripMenuItem"
        Me.ProfesionalesToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ProfesionalesToolStripMenuItem.Text = "GESTION DE PROFESIONALES"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(227, 6)
        '
        'AgendasToolStripMenuItem
        '
        Me.AgendasToolStripMenuItem.Name = "AgendasToolStripMenuItem"
        Me.AgendasToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.AgendasToolStripMenuItem.Text = "GESTION DE HORARIOS"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(227, 6)
        '
        'GESTIONDEUSUARIOSToolStripMenuItem
        '
        Me.GESTIONDEUSUARIOSToolStripMenuItem.Name = "GESTIONDEUSUARIOSToolStripMenuItem"
        Me.GESTIONDEUSUARIOSToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.GESTIONDEUSUARIOSToolStripMenuItem.Text = "GESTION DE USUARIOS"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SalirToolStripMenuItem.Text = "SALIR"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AyudaToolStripMenuItem.Text = "Acerca de"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnosToolStripMenuItem, Me.AdministrarToolStripMenuItem, Me.SalirToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(485, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.LaboratorioIDR.My.Resources.Resources.images
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(485, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turnos Laboratorio  Di Rienzo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Timer1 As Timer
    Friend WithEvents TurnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtorgarTurnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents VerTurnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ProfesionalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AgendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GESTIONDEUSUARIOSToolStripMenuItem As ToolStripMenuItem
End Class
