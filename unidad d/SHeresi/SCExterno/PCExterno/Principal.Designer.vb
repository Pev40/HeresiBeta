<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HistoriaClínicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ParteDiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RepMensualServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuincenalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InformeMensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.SL = New System.Windows.Forms.ToolStripStatusLabel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Operaciones"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MantenimientoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.MantenimientoToolStripMenuItem.Text = "&Mantenimientos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoriaClínicaToolStripMenuItem, Me.ParteDiarioToolStripMenuItem, Me.RepMensualServiciosToolStripMenuItem, Me.InformeMensualToolStripMenuItem})
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'HistoriaClínicaToolStripMenuItem
        '
        Me.HistoriaClínicaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.HistoriaClínicaToolStripMenuItem.Name = "HistoriaClínicaToolStripMenuItem"
        Me.HistoriaClínicaToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.HistoriaClínicaToolStripMenuItem.Text = "&Historia Clínica"
        '
        'ParteDiarioToolStripMenuItem
        '
        Me.ParteDiarioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ParteDiarioToolStripMenuItem.Name = "ParteDiarioToolStripMenuItem"
        Me.ParteDiarioToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ParteDiarioToolStripMenuItem.Text = "&Parte Diario"
        '
        'RepMensualServiciosToolStripMenuItem
        '
        Me.RepMensualServiciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuincenalToolStripMenuItem, Me.MensualToolStripMenuItem})
        Me.RepMensualServiciosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RepMensualServiciosToolStripMenuItem.Name = "RepMensualServiciosToolStripMenuItem"
        Me.RepMensualServiciosToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.RepMensualServiciosToolStripMenuItem.Text = "Rep. &Servicios"
        '
        'QuincenalToolStripMenuItem
        '
        Me.QuincenalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.QuincenalToolStripMenuItem.Name = "QuincenalToolStripMenuItem"
        Me.QuincenalToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.QuincenalToolStripMenuItem.Text = "&Quincenal"
        '
        'MensualToolStripMenuItem
        '
        Me.MensualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MensualToolStripMenuItem.Name = "MensualToolStripMenuItem"
        Me.MensualToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.MensualToolStripMenuItem.Text = "&Mensual"
        '
        'InformeMensualToolStripMenuItem
        '
        Me.InformeMensualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.InformeMensualToolStripMenuItem.Name = "InformeMensualToolStripMenuItem"
        Me.InformeMensualToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.InformeMensualToolStripMenuItem.Text = "&Informe Mensual"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.SalirToolStripMenuItem1.Text = "&Salir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SL})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 305)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(795, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SL
        '
        Me.SL.BackColor = System.Drawing.SystemColors.MenuBar
        Me.SL.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SL.Name = "SL"
        Me.SL.Size = New System.Drawing.Size(153, 17)
        Me.SL.Text = "ToolStripStatusLabel1"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Enabled = False
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.Location = New System.Drawing.Point(0, 275)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(795, 30)
        Me.TextBox1.TabIndex = 5
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(795, 327)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "Consultorio Externo - CENTRO DE SALUD MENTAL ""MOISES HERESI"""
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoriaClínicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParteDiarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepMensualServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuincenalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MensualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformeMensualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
