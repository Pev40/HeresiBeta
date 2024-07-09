<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MTabPac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MTabPac))
        Me.Filtro = New System.Windows.Forms.TextBox
        Me.Nuevo = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Grilla_d_pd = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Eliminar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Editar = New System.Windows.Forms.Button
        CType(Me.Grilla_d_pd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Filtro
        '
        Me.Filtro.Location = New System.Drawing.Point(6, 22)
        Me.Filtro.Name = "Filtro"
        Me.Filtro.Size = New System.Drawing.Size(718, 23)
        Me.Filtro.TabIndex = 1
        '
        'Nuevo
        '
        Me.Nuevo.BackgroundImage = CType(resources.GetObject("Nuevo.BackgroundImage"), System.Drawing.Image)
        Me.Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Nuevo.Location = New System.Drawing.Point(6, 22)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(77, 82)
        Me.Nuevo.TabIndex = 2
        Me.Nuevo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(264, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cancelar"
        '
        'Grilla_d_pd
        '
        Me.Grilla_d_pd.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.Grilla_d_pd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Grilla_d_pd.BackgroundColor = System.Drawing.Color.LightGray
        Me.Grilla_d_pd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Grilla_d_pd.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.Grilla_d_pd.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.Grilla_d_pd.DataMember = ""
        Me.Grilla_d_pd.FlatMode = True
        Me.Grilla_d_pd.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Grilla_d_pd.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Grilla_d_pd.GridLineColor = System.Drawing.Color.Gainsboro
        Me.Grilla_d_pd.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.Grilla_d_pd.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.Grilla_d_pd.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Grilla_d_pd.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grilla_d_pd.LinkColor = System.Drawing.Color.Teal
        Me.Grilla_d_pd.Location = New System.Drawing.Point(6, 51)
        Me.Grilla_d_pd.Name = "Grilla_d_pd"
        Me.Grilla_d_pd.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.Grilla_d_pd.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.Grilla_d_pd.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Grilla_d_pd.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grilla_d_pd.Size = New System.Drawing.Size(718, 366)
        Me.Grilla_d_pd.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Filtro)
        Me.GroupBox2.Controls.Add(Me.Grilla_d_pd)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 423)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "                Utilice el siguiente cuadro de texto para escribir el dato que Ud" & _
            ". Requiere filtrar"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(185, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Eliminar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(106, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Editar"
        '
        'Eliminar
        '
        Me.Eliminar.BackgroundImage = CType(resources.GetObject("Eliminar.BackgroundImage"), System.Drawing.Image)
        Me.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar.Location = New System.Drawing.Point(177, 22)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(78, 82)
        Me.Eliminar.TabIndex = 4
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.BackgroundImage = CType(resources.GetObject("Cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.Location = New System.Drawing.Point(261, 22)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(79, 82)
        Me.Cancelar.TabIndex = 5
        Me.Cancelar.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(203, 430)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 110)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Editar
        '
        Me.Editar.BackgroundImage = CType(resources.GetObject("Editar.BackgroundImage"), System.Drawing.Image)
        Me.Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar.Location = New System.Drawing.Point(91, 22)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(80, 82)
        Me.Editar.TabIndex = 3
        Me.Editar.UseVisualStyleBackColor = True
        '
        'MTabPac
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(742, 546)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MTabPac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla Pacientes - Mantenimiento"
        CType(Me.Grilla_d_pd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Filtro As System.Windows.Forms.TextBox
    Friend WithEvents Nuevo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Grilla_d_pd As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Editar As System.Windows.Forms.Button
End Class
