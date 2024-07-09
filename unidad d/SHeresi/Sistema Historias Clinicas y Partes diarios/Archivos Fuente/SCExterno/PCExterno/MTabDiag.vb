Imports System.Data
Imports System.Data.SqlClient
Public Class MTabDiag
    Dim cn As New SqlConnection(Conexion)
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Diag = True
        Volver()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Diag = True
        If Editar_Registro = True Then
            Try 'Para Editar y Guardar Registros
                'Regresando el Parámetro a su estado original para poder actualizar después
                Editar_Registro = False
                'Envío de las Variables que actualizarán a las antiguas
                Dim cmd As New SqlCommand("sp_ADiag", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.VarChar, 15).Value = Index
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 500).Value = Descripcion.Text
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Guardar.Enabled = False
                Refrescar_grilla()
                Volver()
            Catch ex As Exception
                MessageBox.Show("No se pudo actualizar el registro: " & ex.Message)
            End Try
        Else
            Try 'Para solo Guardar Registros
                Dim cmd As New SqlCommand("sp_IDiag", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar, 15).Value = Categoria.Text
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 500).Value = Descripcion.Text
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Refrescar_grilla()
                Categoria.Text = ""
                Descripcion.Text = ""
                Categoria.Focus()
            Catch ex As Exception
                MessageBox.Show("Se encontró un error en la aplicación y no se pudo guardar el registro: " & ex.Message)
            End Try
        End If
    End Sub

    Sub Volver()
        Dim hijo As New ContGen
        hijo.MdiParent = Principal
        hijo.Show()
        Me.Close()
    End Sub

    Sub Refrescar_grilla()
        Try
            Dim cmd As New SqlCommand("sp_MDiag", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabDiag")
            Grilla.DataSource = ds.Tables("TabDiag")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la grilla de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub MTabDiag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Categoria.Focus()
        Try
            If Editar_Registro = True Then
                Categoria.Focus()
                'Refrescando la Grilla con el valor seleccionado para actualizar
                Dim cmdr As New SqlCommand("sp_MURDiag", cn)
                cmdr.CommandType = CommandType.StoredProcedure
                cmdr.Parameters.Add("@Index", SqlDbType.VarChar, 15).Value = Index
                Dim da As New SqlDataAdapter(cmdr)
                Dim ds As New DataSet
                da.Fill(ds, "TabDiag")
                Grilla.DataSource = ds.Tables("TabDiag")
                'Obtención del Parámetro de Salida para colocarlo en el campo descripción
                Dim cmd As New SqlCommand("sp_RDDiag", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.VarChar, 15).Value = Index
                cmd.Parameters.Add("@Categoria", SqlDbType.VarChar, 15).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output
                cn.Open()
                cmd.ExecuteReader()
                cn.Close()
                Categoria.Text = cmd.Parameters("@Categoria").Value
                Descripcion.Text = cmd.Parameters("@Descripcion").Value
                Descripcion.Focus()
            Else
                Refrescar_grilla()
                Categoria.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class