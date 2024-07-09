<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabDiag
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabDiag))
        Me.Filtro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Seleccionar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Grilla = New System.Windows.Forms.DataGridView
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Filtro
        '
        Me.Filtro.Location = New System.Drawing.Point(252, 38)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(408, 23)
        Me.Filtro.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tambien puede filtrar datos desde este cuadro de texto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Seleccionar)
        Me.GroupBox2.Controls.Add(Me.Cancelar)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(373, 422)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 86)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccionar     Cancelar"
        '
        'Seleccionar
        '
        Me.Seleccionar.BackgroundImage = CType(resources.GetObject("Seleccionar.BackgroundImage"), System.Drawing.Image)
        Me.Seleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Seleccionar.Location = New System.Drawing.Point(20, 19)
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(58, 57)
        Me.Seleccionar.TabIndex = 0
        Me.Seleccionar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.BackgroundImage = CType(resources.GetObject("Cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.Location = New System.Drawing.Point(118, 19)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(57, 57)
        Me.Cancelar.TabIndex = 1
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Grilla)
        Me.GroupBox1.Controls.Add(Me.Filtro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 404)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                                                             Seleccione el Diagnó" & _
            "stico de la siguiente Grilla de Datos"
        '
        'Grilla
        '
        Me.Grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(6, 63)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(902, 335)
        Me.Grilla.TabIndex = 6
        '
        'TabDiag
        '
        Me.AcceptButton = Me.Seleccionar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(938, 520)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TabDiag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar diagnósticos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Seleccionar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
End Class
