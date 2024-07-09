Imports System.Data
Imports System.Data.SqlClient
Public Class MTabOcu
    Dim cn As New SqlConnection(Conexion)
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Ocupaciones = True
        Volver()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Ocupaciones = True
        If Editar_Registro = True Then
            Try 'Para Editar y Guardar Registros
                'Regresando el Par�metro a su estado original para poder actualizar despu�s
                Editar_Registro = False
                'Env�o de las Variables que actualizar�n a las antiguas
                Dim cmd As New SqlCommand("sp_AOcupaciones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = Descripcion.Text
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
                Dim cmd As New SqlCommand("sp_IOcupaciones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = Descripcion.Text
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Refrescar_grilla()
                Descripcion.Text = ""
                Descripcion.Focus()
            Catch ex As Exception
                MessageBox.Show("Se encontr� un error en la aplicaci�n y no se pudo guardar el registro: " & ex.Message)
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
            Dim cmd As New SqlCommand("sp_MOcupaciones", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabOcup")
            Grilla.DataSource = ds.Tables("TabOcup")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la grilla de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub MTabOcu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Editar_Registro = True Then
                'Refrescando la Grilla con el valor seleccionado para actualizar
                Dim cmdr As New SqlCommand("sp_MUROcupaciones", cn)
                cmdr.CommandType = CommandType.StoredProcedure
                cmdr.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                Dim da As New SqlDataAdapter(cmdr)
                Dim ds As New DataSet
                da.Fill(ds, "TabOcup")
                Grilla.DataSource = ds.Tables("TabOcup")
                'Obtenci�n del Par�metro de Salida para colocarlo en el campo descripci�n
                Dim cmd As New SqlCommand("sp_RDOcupaciones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
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