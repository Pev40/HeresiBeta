<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep_EstMed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rep_EstMed))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.mes = New System.Windows.Forms.ComboBox
        Me.año = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.OK = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.crv5 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crd5 = New PCExterno.RepEstMed
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mes)
        Me.GroupBox2.Controls.Add(Me.año)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.OK)
        Me.GroupBox2.Controls.Add(Me.Cancelar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1028, 54)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Para emitir un reporte especifique el mes y año"
        '
        'mes
        '
        Me.mes.FormattingEnabled = True
        Me.mes.Location = New System.Drawing.Point(39, 22)
        Me.mes.Name = "mes"
        Me.mes.Size = New System.Drawing.Size(121, 21)
        Me.mes.TabIndex = 14
        '
        'año
        '
        Me.año.Location = New System.Drawing.Point(198, 22)
        Me.año.Name = "año"
        Me.año.Size = New System.Drawing.Size(43, 20)
        Me.año.TabIndex = 13
        Me.año.Text = "2007"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(166, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Año"
        '
        'OK
        '
        Me.OK.BackgroundImage = CType(resources.GetObject("OK.BackgroundImage"), System.Drawing.Image)
        Me.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK.Location = New System.Drawing.Point(247, 17)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(29, 29)
        Me.OK.TabIndex = 10
        '
        'Cancelar
        '
        Me.Cancelar.BackgroundImage = CType(resources.GetObject("Cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.Location = New System.Drawing.Point(282, 17)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(30, 29)
        Me.Cancelar.TabIndex = 11
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Mes"
        '
        'crv5
        '
        Me.crv5.ActiveViewIndex = -1
        Me.crv5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv5.Location = New System.Drawing.Point(0, 54)
        Me.crv5.Name = "crv5"
        Me.crv5.SelectionFormula = ""
        Me.crv5.Size = New System.Drawing.Size(1028, 632)
        Me.crv5.TabIndex = 9
        Me.crv5.ViewTimeSelectionFormula = ""
        '
        'Rep_EstMed
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1028, 686)
        Me.Controls.Add(Me.crv5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rep_EstMed"
        Me.Text = "Reporte - Estadística de consultorios externos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents mes As System.Windows.Forms.ComboBox
    Friend WithEvents año As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents crv5 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crd5 As PCExterno.RepEstMed
End Class
