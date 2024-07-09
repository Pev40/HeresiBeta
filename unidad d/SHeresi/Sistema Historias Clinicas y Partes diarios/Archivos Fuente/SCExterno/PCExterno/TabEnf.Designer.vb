<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabEnf
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TabEnf))
        Me.TDocumento = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Nombres = New System.Windows.Forms.TextBox
        Me.ApeMat = New System.Windows.Forms.TextBox
        Me.ApePat = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Clave2 = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Guardar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Clave1 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NDocumento = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Grilla = New System.Windows.Forms.DataGrid
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TDocumento
        '
        Me.TDocumento.FormattingEnabled = True
        Me.TDocumento.Location = New System.Drawing.Point(158, 111)
        Me.TDocumento.Name = "TDocumento"
        Me.TDocumento.Size = New System.Drawing.Size(107, 24)
        Me.TDocumento.TabIndex = 3
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label34.Location = New System.Drawing.Point(139, 112)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 16)
        Me.Label34.TabIndex = 36
        Me.Label34.Text = ":"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label35.Location = New System.Drawing.Point(6, 114)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(125, 16)
        Me.Label35.TabIndex = 35
        Me.Label35.Text = "Tipo Documento"
        '
        'Nombres
        '
        Me.Nombres.Location = New System.Drawing.Point(158, 83)
        Me.Nombres.Name = "Nombres"
        Me.Nombres.Size = New System.Drawing.Size(249, 23)
        Me.Nombres.TabIndex = 2
        '
        'ApeMat
        '
        Me.ApeMat.Location = New System.Drawing.Point(158, 54)
        Me.ApeMat.Name = "ApeMat"
        Me.ApeMat.Size = New System.Drawing.Size(189, 23)
        Me.ApeMat.TabIndex = 1
        '
        'ApePat
        '
        Me.ApePat.Location = New System.Drawing.Point(158, 25)
        Me.ApePat.Name = "ApePat"
        Me.ApePat.Size = New System.Drawing.Size(189, 23)
        Me.ApePat.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label11.Location = New System.Drawing.Point(139, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label9.Location = New System.Drawing.Point(139, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label12.Location = New System.Drawing.Point(6, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Nombres"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label8.Location = New System.Drawing.Point(139, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label10.Location = New System.Drawing.Point(6, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Apellido Materno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Apellido Paterno"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label37.Location = New System.Drawing.Point(276, 115)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(26, 16)
        Me.Label37.TabIndex = 38
        Me.Label37.Text = "Nº"
        '
        'Clave2
        '
        Me.Clave2.Location = New System.Drawing.Point(158, 169)
        Me.Clave2.Name = "Clave2"
        Me.Clave2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Clave2.Size = New System.Drawing.Size(153, 23)
        Me.Clave2.TabIndex = 6
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Guardar)
        Me.GroupBox5.Controls.Add(Me.Cancelar)
        Me.GroupBox5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(95, 204)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(234, 115)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "      Guardar           Cancelar"
        '
        'Guardar
        '
        Me.Guardar.BackgroundImage = CType(resources.GetObject("Guardar.BackgroundImage"), System.Drawing.Image)
        Me.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.Location = New System.Drawing.Point(12, 19)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(102, 93)
        Me.Guardar.TabIndex = 0
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.BackgroundImage = CType(resources.GetObject("Cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.Location = New System.Drawing.Point(120, 19)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(98, 93)
        Me.Cancelar.TabIndex = 1
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.Location = New System.Drawing.Point(139, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label5.Location = New System.Drawing.Point(6, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Repita la Clave"
        '
        'Clave1
        '
        Me.Clave1.Location = New System.Drawing.Point(158, 141)
        Me.Clave1.Name = "Clave1"
        Me.Clave1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Clave1.Size = New System.Drawing.Size(153, 23)
        Me.Clave1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox2.Controls.Add(Me.Clave2)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Clave1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.NDocumento)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.TDocumento)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Nombres)
        Me.GroupBox2.Controls.Add(Me.ApeMat)
        Me.GroupBox2.Controls.Add(Me.ApePat)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 325)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingrese los Datos "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Location = New System.Drawing.Point(139, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.Location = New System.Drawing.Point(6, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Clave de Acceso"
        '
        'NDocumento
        '
        Me.NDocumento.Location = New System.Drawing.Point(308, 112)
        Me.NDocumento.Name = "NDocumento"
        Me.NDocumento.Size = New System.Drawing.Size(99, 23)
        Me.NDocumento.TabIndex = 4
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label36.Location = New System.Drawing.Point(298, 115)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(13, 16)
        Me.Label36.TabIndex = 39
        Me.Label36.Text = ":"
        '
        'EP
        '
        Me.EP.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Grilla)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(453, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 319)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros de Enfermeras"
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
        Me.Grilla.Location = New System.Drawing.Point(6, 22)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.Grilla.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.Grilla.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.Grilla.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.Grilla.Size = New System.Drawing.Size(483, 288)
        Me.Grilla.TabIndex = 60
        '
        'TabEnf
        '
        Me.AcceptButton = Me.Guardar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(960, 350)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TabEnf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enfermeras - Mantenimiento"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Nombres As System.Windows.Forms.TextBox
    Friend WithEvents ApeMat As System.Windows.Forms.TextBox
    Friend WithEvents ApePat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Clave2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Clave1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents EP As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Grilla As System.Windows.Forms.DataGrid
End Class
