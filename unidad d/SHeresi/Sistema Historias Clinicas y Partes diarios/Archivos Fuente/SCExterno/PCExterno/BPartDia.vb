Imports System.Data
Imports System.Data.SqlClient
Public Class BPartDia
    Dim cn As New SqlConnection(Conexion)
    Dim ds As New DataSet
    Dim Filtrador As New BindingSource

    Private Sub BPartDia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Restaura la ventana a Normal
            Me.WindowState = FormWindowState.Normal
            'Grilla.Columns.Clear()
            If Grilla.RowCount <= 0 Then
                Dim cmd As New SqlCommand("sp_MCabPart", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds, "CabPartDia")
                Grilla.DataSource = ds.Tables("CabPartDia")
            Else
                ds.Clear()
                Grilla.DataSource = Nothing
                Grilla.Rows.Clear()
                Dim cmd As New SqlCommand("sp_MCabPart", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds, "CabPartDia")
                Grilla.DataSource = ds.Tables("CabPartDia")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario" & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Seleccionar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Seleccionar.Click
        Try
            S3Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
        Catch ex As Exception
            MessageBox.Show("No hay registros en el índice señalado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Me.Close()
    End Sub

    Private Sub Grilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        Try
            S3Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
        Catch ex As Exception
            MessageBox.Show("No hay registros en el índice señalado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Me.Close()
    End Sub

    Private Sub Filtro_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Filtro.TextChanged
        Try
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MCabPart", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "CabPartDia")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "CabPartDia"
            Filtrador.Filter = "Fecha_Parte = '" & Filtro.Text.Trim & "'"
            Grilla.DataSource = Filtrador
        Catch ex As Exception
            Filtrador.Filter = ""
            Grilla.DataSource = Filtrador
            Exit Sub
        End Try
    End Sub

    Private Sub Cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class