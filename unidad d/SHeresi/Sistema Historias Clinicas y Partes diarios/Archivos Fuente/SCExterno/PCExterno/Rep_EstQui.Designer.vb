<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep_EstQui
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rep_EstQui))
        Me.OK = New System.Windows.Forms.Button
        Me.crv3 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Fecha1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Fecha2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.crd3 = New PCExterno.RepEstQui
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK
        '
        Me.OK.BackgroundImage = CType(resources.GetObject("OK.BackgroundImage"), System.Drawing.Image)
        Me.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK.Location = New System.Drawing.Point(475, 15)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(29, 29)
        Me.OK.TabIndex = 3
        '
        'crv3
        '
        Me.crv3.ActiveViewIndex = -1
        Me.crv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv3.Location = New System.Drawing.Point(0, 50)
        Me.crv3.Name = "crv3"
        Me.crv3.SelectionFormula = ""
        Me.crv3.Size = New System.Drawing.Size(1028, 636)
        Me.crv3.TabIndex = 0
        Me.crv3.ViewTimeSelectionFormula = ""
        '
        'Cancelar
        '
        Me.Cancelar.BackgroundImage = CType(resources.GetObject("Cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.Location = New System.Drawing.Point(510, 15)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(30, 29)
        Me.Cancelar.TabIndex = 5
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Fecha1
        '
        Me.Fecha1.Location = New System.Drawing.Point(122, 20)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(109, 21)
        Me.Fecha1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Fecha2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.OK)
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.Fecha1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1028, 50)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Para emitir un reporte deberá ingresar las fechas correspondientes, siguiendo el " & _
            "orden : Dia/Mes/Año"
        '
        'Fecha2
        '
        Me.Fecha2.Location = New System.Drawing.Point(360, 20)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(109, 21)
        Me.Fecha2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(242, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Segunda Quincena"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Primera Quincena"
        '
        'Rep_EstQui
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(1028, 686)
        Me.Controls.Add(Me.crv3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rep_EstQui"
        Me.Text = "Reporte estadístico por periodos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Fecha1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fecha2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents crv3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crd3 As PCExterno.RepEstQui
End Class
