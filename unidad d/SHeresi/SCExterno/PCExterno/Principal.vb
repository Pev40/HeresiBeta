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
    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoToolStripMenuItem.Click
        VTitulo = "Mantenimientos"
        Dim hijo As New ContGen
        hijo.MdiParent = Me
        hijo.Show()
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
            TextBox1.Text = "Buenos Días " & Enf & " Has iniciado Sesión hoy:  " & Date.Now.ToLocalTime
        ElseIf Doc <> "" And Enf = "" Then
            TextBox1.Text = "Buenos Días " & Doc & " Has iniciado Sesión hoy:  " & Date.Now.ToLocalTime
        Else
            TextBox1.Text = "Buenos Días Administrador has iniciado Sesión hoy:  " & Date.Now.ToLocalTime
        End If
    End Sub
End Class
