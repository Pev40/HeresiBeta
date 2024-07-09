<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContGen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContGen))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Editar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Nuevo = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Eliminar = New System.Windows.Forms.Button
        Me.Filtro = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Grilla = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CbTipos = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(174, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Eliminar"
        '
        'Cancelar
        '
        Me.Cancelar.BackgroundImage = CType(resources.GetObject("Cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.Location = New System.Drawing.Point(251, 22)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(79, 82)
        Me.Cancelar.TabIndex = 3
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(100, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Editar"
        '
        'Editar
        '
        Me.Editar.BackgroundImage = CType(resources.GetObject("Editar.BackgroundImage"), System.Drawing.Image)
        Me.Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar.Location = New System.Drawing.Point(85, 22)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(80, 82)
        Me.Editar.TabIndex = 1
        Me.Editar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Nuevo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Editar)
        Me.GroupBox1.Controls.Add(Me.Eliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(209, 504)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 108)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Nuevo
        '
        Me.Nuevo.BackgroundImage = CType(resources.GetObject("Nuevo.BackgroundImage"), System.Drawing.Image)
        Me.Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Nuevo.Location = New System.Drawing.Point(6, 22)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(77, 82)
        Me.Nuevo.TabIndex = 0
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(254, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Location = New System.Drawing.Point(18, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nuevo"
        '
        'Eliminar
        '
        Me.Eliminar.BackgroundImage = CType(resources.GetObject("Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar.Location = New System.Drawing.Point(168, 22)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(78, 82)
        Me.Eliminar.TabIndex = 2
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Filtro
        '
        Me.Filtro.Location = New System.Drawing.Point(6, 28)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(718, 23)
        Me.Filtro.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Grilla)
        Me.GroupBox2.Controls.Add(Me.Filtro)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 423)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Utilice el siguiente cuadro de texto para escribir la palabra que Ud. quiere busc" & _
            "ar"
        '
        'Grilla
        '
        Me.Grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(6, 57)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ReadOnly = True
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(718, 360)
        Me.Grilla.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CbTipos)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(439, 56)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Seleccione un módulo"
        '
        'CbTipos
        '
        Me.CbTipos.FormattingEnabled = True
        Me.CbTipos.Location = New System.Drawing.Point(9, 21)
        Me.CbTipos.Name = "CbTipos"
        Me.CbTipos.Size = New System.Drawing.Size(418, 24)
        Me.CbTipos.TabIndex = 0
        '
        'ContGen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(742, 624)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ContGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de Módulos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Editar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Filtro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CbTipos As System.Windows.Forms.ComboBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
End Class
