Imports System.Data
Imports System.Data.SqlClient
Public Class MEstCiv
    Dim cn As New SqlConnection(Conexion)
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        EstCiv = True
        Volver()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        EstCiv = True
        If Editar_Registro = True Then
            Try 'Para Editar y Guardar Registros
                'Regresando el Parámetro a su estado original para poder actualizar después
                Editar_Registro = False
                'Envío de las Variables que actualizarán a las antiguas
                Dim cmd As New SqlCommand("sp_AEstCiv", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 20).Value = Descripcion.Text
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
                Dim cmd As New SqlCommand("sp_IEstCiv", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 20).Value = Descripcion.Text
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Refrescar_grilla()
                Descripcion.Text = ""
                Descripcion.Focus()
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
            Dim cmd As New SqlCommand("sp_MEstCiv", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabEciv")
            Grilla.DataSource = ds.Tables("TabEciv")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la grilla de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub MEstCiv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Editar_Registro = True Then
                'Refrescando la Grilla con el valor seleccionado para actualizar
                Dim cmdr As New SqlCommand("sp_MUREstCiv", cn)
                cmdr.CommandType = CommandType.StoredProcedure
                cmdr.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                Dim da As New SqlDataAdapter(cmdr)
                Dim ds As New DataSet
                da.Fill(ds, "TabEciv")
                Grilla.DataSource = ds.Tables("TabEciv")
                'Obtención del Parámetro de Salida para colocarlo en el campo descripción
                Dim cmd As New SqlCommand("sp_RDEstCiv", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output
                cn.Open()
                cmd.ExecuteReader()
                cn.Close()
                Descripcion.Text = cmd.Parameters("@descripcion").Value
                Descripcion.Focus()
            Else
                Refrescar_grilla()
                Descripcion.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class