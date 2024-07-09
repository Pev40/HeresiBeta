Imports System.Data
Imports System.Data.SqlClient
Public Class Principal
    Dim cn As New SqlConnection(Conexion)
    Dim Enf, Doc As String
    Private Sub ArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivoToolStripMenuItem.Click
        VTitulo = "Operaciones"
        Dim hijo As New ContGen
        hijo.MdiParent = Me
        hijo.Show()
        Estado.Visible = True
    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoToolStripMenuItem.Click
        VTitulo = "Mantenimientos"
        Dim hijo As New ContGen
        hijo.MdiParent = Me
        hijo.Show()
        Estado.Visible = True
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login.Visible = False
        SL.Text = "Ud. se ha identificado con el número de documento: " & Validar
        Dim cmdE As New SqlClient.SqlCommand("select Nomenf from TabEnfm where NumDoc= " & Validar, cn)
        Dim cmdD As New SqlClient.SqlCommand("select NomDoc from TabDoct where NumDoc= " & Validar, cn)
        cn.Open()
        Enf = cmdE.ExecuteScalar
        Doc = cmdD.ExecuteScalar
        cn.Close()
        If Enf <> "" And Doc = "" Then
            Estado.Text = "Buenos Días " & Enf & " Has iniciado Sesión hoy:  " & Date.Now.ToLocalTime
        ElseIf Doc <> "" And Enf = "" Then
            Estado.Text = "Buenos Días " & Doc & " Has iniciado Sesión hoy:  " & Date.Now.ToLocalTime
        Else
            Estado.Text = "Buenos Días Administrador has iniciado Sesión hoy:  " & Date.Now.ToLocalTime
        End If
    End Sub

    Private Sub RepHistoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepHistoriasToolStripMenuItem.Click
        Dim hijo As New Rep_HraCli
        hijo.MdiParent = Me
        hijo.Show()
        Estado.Visible = False
    End Sub

    Private Sub RepPartesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepPartesToolStripMenuItem.Click
        Dim hijo As New Rep_PartDia
        hijo.MdiParent = Me
        hijo.Show()
        Estado.Visible = False
    End Sub

    Private Sub QuincenalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuincenalToolStripMenuItem.Click
        Dim hijo As New Rep_EstQui
        hijo.MdiParent = Me
        hijo.Show()
        Estado.Visible = False
    End Sub

    Private Sub MensualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MensualToolStripMenuItem.Click
        Dim hijo As New Rep_RepMen
        hijo.MdiParent = Me
        hijo.Show()
        Estado.Visible = False
    End Sub

    Private Sub RepEstaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepEstaToolStripMenuItem.Click
        Dim hijo As New Rep_EstMed
        hijo.MdiParent = Me
        hijo.Show()
        Estado.Visible = False
    End Sub
End Class
