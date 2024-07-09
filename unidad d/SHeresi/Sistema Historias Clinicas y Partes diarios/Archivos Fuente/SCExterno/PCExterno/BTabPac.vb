Imports System.Data
Imports System.Data.SqlClient
Public Class BTabPac
    Dim cn As New SqlConnection(Conexion)
    Dim ds As New DataSet
    Dim Filtrador As New BindingSource

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seleccionar.Click
        Try
            S1Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
        Catch ex As Exception
            MessageBox.Show("No hay registros en el índice señalado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Try
            Dim Bpac As New SqlCommand("select count(*) from hracli where idpcte = " & S1Index, cn)
            cn.Open()
            Dim contador As Integer = Bpac.ExecuteScalar
            cn.Close()
            If contador > 0 Then
                MessageBox.Show("El paciente que Ud. Ha seleccionado ya tiene una historia clínica creada. Porfavor seleccione una persona diferente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly)
                S1Index = ""
                Me.Close()
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Se generó un error seleccionando el Item:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Grilla_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellDoubleClick
        Try
            S1Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
        Catch ex As Exception
            MessageBox.Show("No hay registros en el índice señalado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Try
            Dim Bpac As New SqlCommand("select count(*) from hracli where idpcte = " & S1Index, cn)
            cn.Open()
            Dim contador As Integer = Bpac.ExecuteScalar
            cn.Close()
            If contador > 0 Then
                MessageBox.Show("El paciente que Ud. Ha seleccionado ya tiene una historia clínica creada. Porfavor seleccione una persona diferente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly)
                S1Index = ""
                Me.Close()
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Se generó un error seleccionando el item:" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub


    Private Sub BTabPac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Normal
            If Grilla.RowCount = 0 Then
                Dim cmd As New SqlCommand("sp_CPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds, "TabPac")
                Grilla.DataSource = ds.Tables("TabPac")
            Else
                ds.Clear()
                Grilla.DataSource = Nothing
                Grilla.Rows.Clear()
                Dim cmd As New SqlCommand("sp_CPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds, "TabPac")
                Grilla.DataSource = ds.Tables("TabPac")
            End If
        Catch ex As Exception
            MessageBox.Show("Se generó un error al cargar el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub Filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtro.TextChanged
        Try
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabPac"
            Filtrador.Filter = "Ap_Paterno like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        Catch ex As Exception
            MessageBox.Show("Se generó un error al filtrar el campo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

End Class