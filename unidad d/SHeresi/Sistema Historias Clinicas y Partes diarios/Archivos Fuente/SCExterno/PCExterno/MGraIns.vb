Imports System.Data
Imports System.Data.SqlClient
Public Class MGraIns
    Dim cn As New SqlConnection(Conexion)
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        GI = True
        Volver()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        GI = True
        If Editar_Registro = True Then
            Try 'Para Editar y Guardar Registros
                'Regresando el Par�metro a su estado original para poder actualizar despu�s
                Editar_Registro = False
                'Env�o de las Variables que actualizar�n a las antiguas
                Dim cmd As New SqlCommand("sp_AGI", cn)
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
                MessageBox.Show("No se pudo actualizar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Finally
                cn.Close()
            End Try
        Else
            Try 'Para solo Guardar Registros
                Dim cmd As New SqlCommand("sp_IGI", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 20).Value = Descripcion.Text
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Refrescar_grilla()
                Descripcion.Text = ""
                Descripcion.Focus()
            Catch ex As Exception
                MessageBox.Show("Se encontr� un error en la aplicaci�n y no se pudo guardar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Finally
                cn.Close()
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
            Dim cmd As New SqlCommand("sp_MGI", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabGins")
            Grilla.DataSource = ds.Tables("TabGins")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la grilla de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub MGraIns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Editar_Registro = True Then
                'Refrescando la Grilla con el valor seleccionado para actualizar
                Dim cmdr As New SqlCommand("sp_MURGI", cn)
                cmdr.CommandType = CommandType.StoredProcedure
                cmdr.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                Dim da As New SqlDataAdapter(cmdr)
                Dim ds As New DataSet
                da.Fill(ds, "TabGins")
                Grilla.DataSource = ds.Tables("TabGins")
                'Obtenci�n del Par�metro de Salida para colocarlo en el campo descripci�n
                Dim cmd As New SqlCommand("sp_RDGI", cn)
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
            MessageBox.Show("Error al cargar el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub
End Class