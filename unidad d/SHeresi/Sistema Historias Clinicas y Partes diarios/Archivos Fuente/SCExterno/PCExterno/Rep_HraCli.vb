Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Rep_HraCli

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Try
            NroHra.Focus()
            BHraCli.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub NroHra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NroHra.GotFocus
        NroHra.Text = S3Index
    End Sub

    Private Sub NroHra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NroHra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cargarReporte(crd, "D:\SHeresi\SCExterno\PCExterno\RepHraCli.rpt", NroHra.Text)
        End If
    End Sub

    Private Sub cargarReporte(ByVal crd As ReportDocument, ByVal ruta As String, ByVal NroHraCli As String)
        Dim pdv As New ParameterDiscreteValue
        crd.Load(ruta)
        pdv.Value = NroHraCli
        crd.ParameterFields(0).CurrentValues.Add(pdv)
        crv.ReportSource = crd
    End Sub

    Private Sub Rep_HraCli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        crv.DisplayGroupTree = False
        crv.Anchor = AnchorStyles.Left + Right + Top + Bottom
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        cargarReporte(crd, "RepHraCli.rpt", NroHra.Text)
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class