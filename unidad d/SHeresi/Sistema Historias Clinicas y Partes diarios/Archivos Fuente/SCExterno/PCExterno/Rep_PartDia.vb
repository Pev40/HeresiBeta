Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Rep_PartDia

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        cargarReporte(crd2, "D:\SHeresi\SCExterno\PCExterno\RepPartDia.rpt", PartDia.Text)
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Try
            PartDia.Focus()
            BPartDia.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Rep_PartDia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        crv2.DisplayGroupTree = False
        crv2.Anchor = AnchorStyles.Left + Right + Top + Bottom
    End Sub

    Private Sub PartDia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PartDia.GotFocus
        PartDia.Text = S3Index
    End Sub

    Private Sub PartDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PartDia.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cargarReporte(crd2, "RepPartDia.rpt", PartDia.Text)
        End If
    End Sub

    Private Sub cargarReporte(ByVal crd As ReportDocument, ByVal ruta As String, ByVal NroHraCli As String)
        Dim pdv As New ParameterDiscreteValue
        crd2.Load(ruta)
        pdv.Value = NroHraCli
        crd2.ParameterFields(0).CurrentValues.Add(pdv)
        crv2.ReportSource = crd2
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class