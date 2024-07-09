Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Rep_EstQui

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        cargarReporte(crd3, "RepEstQui.rpt", Fecha1.Text, Fecha2.Text)
    End Sub

    Private Sub Rep_EstQui_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Date.Today.Month = 1 Then
            Fecha1.Text = (Date.Today.Day) & "/" & "12" & "/" & (Date.Today.Year)
        Else
            Fecha1.Text = (Date.Today.Day) & "/" & (Date.Today.Month - 1) & "/" & (Date.Today.Year)
        End If
        Fecha2.Text = Date.Today.ToShortDateString
        crv3.DisplayGroupTree = False
        crv3.Anchor = AnchorStyles.Left + Right + Top + Bottom
    End Sub
    Private Sub cargarReporte(ByVal crd As ReportDocument, ByVal ruta As String, ByVal Fecha1 As String, ByVal Fecha2 As String)
        Dim pdv As New ParameterDiscreteValue
        crd3.Load(ruta)
        pdv.Value = Fecha1
        crd3.ParameterFields(0).CurrentValues.Add(pdv)
        pdv.Value = Fecha2
        crd3.ParameterFields(1).CurrentValues.Add(pdv)
        crv3.ReportSource = crd3
    End Sub

    Private Sub Cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class