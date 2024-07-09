<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MContPac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MContPac))
        Me.Guardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.TextBox
        Me.Grilla = New System.Windows.Forms.DataGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Descripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(240, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 151)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los Tipos"
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
        'Grilla
        '
        Me.Grilla.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.Grilla.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Grilla.BackgroundColor = System.Drawing.Color.LightGray
        Me.Grilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grilla.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Grilla.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Grilla.DataMember = ""
        Me.Grilla.FlatMode = True
        Me.Grilla.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Grilla.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Grilla.GridLineColor = System.Drawing.Color.Gainsboro
        Me.Grilla.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Grilla.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Grilla.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Grilla.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grilla.LinkColor = System.Drawing.Color.Teal
        Me.Grilla.Location = New System.Drawing.Point(12, 12)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.Grilla.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.Grilla.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Grilla.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grilla.Size = New System.Drawing.Size(212, 151)
        Me.Grilla.TabIndex = 0
        '
        'MContPac
        '
        Me.AcceptButton = Me.Guardar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(492, 176)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grilla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MContPac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Continuidad del Paciente - Mantenimiento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGrid
End Class
