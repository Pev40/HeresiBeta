<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CabPartDia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CabPartDia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Doctor = New System.Windows.Forms.ComboBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.FecParte = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.Doctor)
        Me.GroupBox1.Controls.Add(Me.Aceptar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.FecParte)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 149)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un doctor para generar el nuevo parte"
        '
        'Cancelar
        '
        Me.Cancelar.BackgroundImage = CType(resources.GetObject("Cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.Location = New System.Drawing.Point(232, 84)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(57, 57)
        Me.Cancelar.TabIndex = 2
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Doctor
        '
        Me.Doctor.FormattingEnabled = True
        Me.Doctor.Location = New System.Drawing.Point(97, 22)
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Size = New System.Drawing.Size(353, 24)
        Me.Doctor.TabIndex = 0
        '
        'Aceptar
        '
        Me.Aceptar.BackgroundImage = CType(resources.GetObject("Aceptar.BackgroundImage"), System.Drawing.Image)
        Me.Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Aceptar.Location = New System.Drawing.Point(168, 84)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(58, 57)
        Me.Aceptar.TabIndex = 1
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label7.Location = New System.Drawing.Point(78, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label5.Location = New System.Drawing.Point(78, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = ":"
        '
        'FecParte
        '
        Me.FecParte.BackColor = System.Drawing.SystemColors.Highlight
        Me.FecParte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FecParte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FecParte.Location = New System.Drawing.Point(97, 52)
        Me.FecParte.Name = "FecParte"
        Me.FecParte.Size = New System.Drawing.Size(121, 23)
        Me.FecParte.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label3.Location = New System.Drawing.Point(16, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Doctor"
        '
        'CabPartDia
        '
        Me.AcceptButton = Me.Aceptar
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(473, 168)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CabPartDia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generando Nuevo Parte Diario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FecParte As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
End Class
