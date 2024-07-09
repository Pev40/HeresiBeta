<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MCondAlta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MCondAlta))
        Me.grilla = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Guardar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.TextBox
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grilla
        '
        Me.grilla.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.grilla.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grilla.BackgroundColor = System.Drawing.Color.LightGray
        Me.grilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grilla.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.grilla.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.grilla.DataMember = ""
        Me.grilla.FlatMode = True
        Me.grilla.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.grilla.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grilla.GridLineColor = System.Drawing.Color.Gainsboro
        Me.grilla.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.grilla.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.grilla.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.grilla.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.grilla.LinkColor = System.Drawing.Color.Teal
        Me.grilla.Location = New System.Drawing.Point(12, 12)
        Me.grilla.Name = "grilla"
        Me.grilla.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.grilla.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.grilla.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.grilla.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.grilla.Size = New System.Drawing.Size(212, 151)
        Me.grilla.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Descripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(230, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 151)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los Tipos"
        '
        'Guardar
        '
        Me.Guardar.BackgroundImage = CType(resources.GetObject("Guardar.BackgroundImage"), System.Drawing.Image)
        Me.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.Location = New System.Drawing.Point(37, 72)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(76, 73)
        Me.Guardar.TabIndex = 1
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.BackgroundImage = CType(resources.GetObject("Cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.Location = New System.Drawing.Point(119, 72)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(76, 73)
        Me.Cancelar.TabIndex = 2
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción"
        '
        'Descripcion
        '
        Me.Descripcion.Location = New System.Drawing.Point(119, 29)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(125, 23)
        Me.Descripcion.TabIndex = 0
        '
        'MCondAlta
        '
        Me.AcceptButton = Me.Guardar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(492, 176)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grilla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MCondAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Condiciones de Alta - Mantenimiento"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grilla As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
End Class
