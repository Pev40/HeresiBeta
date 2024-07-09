Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Rep_RepMen
    Dim n As Int16
    Dim m, a As Integer
    Private Sub cargarReporte(ByVal crd As ReportDocument, ByVal ruta As String, ByVal Mes As Integer, ByVal Año As Integer)
        Dim pdv As New ParameterDiscreteValue
        crd4.Load(ruta)
        pdv.Value = Mes
        crd4.ParameterFields(0).CurrentValues.Add(pdv)
        crd4.ParameterFields(2).CurrentValues.Add(pdv)
        pdv.Value = Año
        crd4.ParameterFields(1).CurrentValues.Add(pdv)
        crd4.ParameterFields(3).CurrentValues.Add(pdv)
        crv4.ReportSource = crd4
    End Sub

    Private Sub Rep_RepMen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For n = 1 To 12
            mes.Items.Add(StrConv(MonthName(n), VbStrConv.ProperCase))
        Next
        crv4.DisplayGroupTree = False
        crv4.Anchor = AnchorStyles.Left + Right + Top + Bottom
    End Sub
    Private Sub OK_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            For n = 0 To 11
                If mes.SelectedIndex = n Then
                    m = n + 1
                    Exit For
                End If
            Next
            cargarReporte(crd4, "RepRepMen.rpt", m, CInt(año.Text))
        Catch ex As Exception
            MessageBox.Show("Escoja un Mes de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class