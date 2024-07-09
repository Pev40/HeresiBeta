Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Rep_EstMed
    Dim n As Int16
    Dim m, a As Integer
    Private Sub cargarReporte(ByVal crd As ReportDocument, ByVal ruta As String, ByVal txtMes As String, ByVal Mes As Integer, ByVal Año As Integer, ByVal Fecha As DateTime)
        Dim pdv As New ParameterDiscreteValue
        crd5.Load(ruta)
        pdv.Value = txtMes
        crd5.ParameterFields(0).CurrentValues.Add(pdv)
        pdv.Value = Mes
        crd5.ParameterFields(1).CurrentValues.Add(pdv)
        pdv.Value = Año
        crd5.ParameterFields(2).CurrentValues.Add(pdv)
        pdv.Value = Fecha
        crd5.ParameterFields(3).CurrentValues.Add(pdv)
        crv5.ReportSource = crd5
    End Sub

    Private Sub Rep_EstMed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For n = 1 To 12
            mes.Items.Add(StrConv(MonthName(n), VbStrConv.ProperCase))
        Next
        crv5.DisplayGroupTree = False
        crv5.Anchor = AnchorStyles.Left + Right + Top + Bottom
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            For n = 0 To 11
                If mes.SelectedIndex = n Then
                    m = n + 1
                    Exit For
                End If
            Next
            cargarReporte(crd5, "RepEstMed.rpt", mes.Text, m, CInt(año.Text), Date.Today.ToShortDateString)
        Catch ex As Exception
            MessageBox.Show("Escoja un Mes de la lista " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class