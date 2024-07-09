Imports System.Data
Imports System.Data.SqlClient
Public Class TabDiag
    Dim cn As New SqlConnection(Conexion)
    Dim ds As New DataSet
    Dim Filtrador As New BindingSource
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seleccionar.Click
        Try
            S2Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
        Catch ex As Exception
            MessageBox.Show("No hay registros en el índice señalado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Me.Close()
    End Sub

    Private Sub Grilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        Try
            S2Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
        Catch ex As Exception
            MessageBox.Show("No hay registros en el índice señalado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Me.Close()
    End Sub

    Private Sub TabDiag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Restaura la ventana a Normal
            Me.WindowState = FormWindowState.Normal
            'Grilla.Columns.Clear()
            If Grilla.RowCount <= 0 Then
                Dim cmd As New SqlCommand("sp_CDiag", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds, "TabDiag")
                Grilla.DataSource = ds.Tables("TabDiag")
            Else
                ds.Clear()
                Grilla.DataSource = Nothing
                Grilla.Rows.Clear()
                Dim cmd As New SqlCommand("sp_CDiag", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds, "TabDiag")
                Grilla.DataSource = ds.Tables("TabDiag")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtro.TextChanged
        Filtrador.DataSource = ds
        Filtrador.DataMember = "TabDiag"
        Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
        Grilla.DataSource = Filtrador
    End Sub
End Class