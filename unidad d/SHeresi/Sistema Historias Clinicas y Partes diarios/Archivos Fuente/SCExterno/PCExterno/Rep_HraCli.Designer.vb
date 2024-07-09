<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rep_HraCli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rep_HraCli))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.OK = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Buscar = New System.Windows.Forms.Button
        Me.NroHra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.crd = New PCExterno.RepHraCli
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OK)
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.NroHra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1028, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Para emitir un reporte deberá ingresar el número de Historia Clínica correspondie" & _
            "nte"
        '
        'OK
        '
        Me.OK.BackgroundImage = CType(resources.GetObject("OK.BackgroundImage"), System.Drawing.Image)
        Me.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OK.Location = New System.Drawing.Point(296, 15)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(29, 29)
        Me.OK.TabIndex = 3
        '
        'Cancelar
        '
        Me.Cancelar.BackgroundImage = CType(resources.GetObject("Cancelar.BackgroundImage"), System.Drawing.Image)
        Me.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar.Location = New System.Drawing.Point(331, 15)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(30, 29)
        Me.Cancelar.TabIndex = 5
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.AllowDrop = True
        Me.Buscar.BackgroundImage = CType(resources.GetObject("Buscar.BackgroundImage"), System.Drawing.Image)
        Me.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buscar.Location = New System.Drawing.Point(238, 15)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(30, 29)
        Me.Buscar.TabIndex = 4
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'NroHra
        '
        Me.NroHra.Location = New System.Drawing.Point(123, 20)
        Me.NroHra.Name = "NroHra"
        Me.NroHra.Size = New System.Drawing.Size(109, 21)
        Me.NroHra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Historia Clínica Nº"
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.AutoSize = True
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 50)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(1028, 696)
        Me.crv.TabIndex = 1
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'Rep_HraCli
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.Cancelar
        Me.ClientSize = New System.Drawing.Size(1028, 746)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Rep_HraCli"
        Me.Text = "Reportes - Historias Clinicas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NroHra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crd As PCExterno.RepHraCli
End Class
