Public Class DHraCli

    Private Sub DHraCli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Restaura la ventana a Normal
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        'Llamar al formulario Hracli dentro de Principal
        Dim hijo As New HraCli
        hijo.MdiParent = Principal
        hijo.Show()
        Me.Close()
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click

    End Sub
End Class