Imports System.Data
Imports System.Data.SqlClient
Public Class TabDoc
    Dim cn As New SqlConnection(Conexion)
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Doct = True
        Volver()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Doct = True
        If Editar_Registro = True Then
            Try 'Para Editar y Guardar Registros
                'Regresando el Parámetro a su estado original para poder actualizar después
                Editar_Registro = False
                'Envío de las Variables que actualizarán a las antiguas
                Dim cmd As New SqlCommand("sp_ADoct", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cmd.Parameters.Add("@ApePat", SqlDbType.VarChar, 50).Value = ApePat.Text
                cmd.Parameters.Add("@ApeMat", SqlDbType.VarChar, 50).Value = ApeMat.Text
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = Nombres.Text
                cmd.Parameters.Add("@IdDocu", SqlDbType.Int).Value = CInt(TDocumento.SelectedValue)
                cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Value = CInt(NDocumento.Text)
                If Clave2.Text.Trim = Clave1.Text.Trim Then
                    cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 20).Value = Clave2.Text
                Else
                    MessageBox.Show("Introduzca la misma contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Clave1.Text = ""
                    Clave2.Text = ""
                    Clave1.Focus()
                    Exit Sub
                End If

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
                Dim cmd As New SqlCommand("sp_IDoct", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ApePat", SqlDbType.VarChar, 50).Value = ApePat.Text
                cmd.Parameters.Add("@ApeMat", SqlDbType.VarChar, 50).Value = ApeMat.Text
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = Nombres.Text
                cmd.Parameters.Add("@IdDocu", SqlDbType.Int).Value = CInt(TDocumento.SelectedValue)
                cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Value = CInt(NDocumento.Text)
                If Clave2.Text.Trim = Clave1.Text.Trim Then
                    cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 20).Value = Clave2.Text
                Else
                    MessageBox.Show("Introduzca la misma contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Clave1.Text = ""
                    Clave2.Text = ""
                    Clave1.Focus()
                    Exit Sub
                End If
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Refrescar_grilla()
                ApePat.Text = ""
                ApeMat.Text = ""
                Nombres.Text = ""
                TDocumento.Text = ""
                NDocumento.Text = ""
                Clave1.Text = ""
                Clave2.Text = ""
                ApePat.Focus()
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
            Dim cmd As New SqlCommand("sp_MDoct", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabDoct")
            Grilla.DataSource = ds.Tables("TabDoct")
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la grilla de datos: " & ex.Message)
        End Try
    End Sub
#Region "Validando Entradas"
    Private Sub NDocumento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NDocumento.Validating
        If Not IsNumeric(NDocumento.Text) Then
            EP.SetError(NDocumento, "Ingrese valores numéricos")
            e.Cancel = False
        Else
            EP.SetError(NDocumento, "")
        End If
    End Sub

#End Region

    Private Sub TabDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Llenando el ComboBox con los datos actuales Tipo Documentos
        Try
            Dim cmd As New SqlCommand("sp_MTipDoc", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabDocu")
            TDocumento.DataSource = ds.Tables("TabDocu")
            TDocumento.DisplayMember = "DesDocu"
            TDocumento.ValueMember = "IdDocu"
        Catch ex As Exception
            MessageBox.Show("No se puede llenar el ComboBox: " & ex.Message)
        End Try
        Try
            If Editar_Registro = True Then
                'Refrescando la Grilla con el valor seleccionado para actualizar
                Dim cmdr As New SqlCommand("sp_MURDoct", cn)
                cmdr.CommandType = CommandType.StoredProcedure
                cmdr.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                Dim da As New SqlDataAdapter(cmdr)
                Dim ds As New DataSet
                da.Fill(ds, "TabDoct")
                Grilla.DataSource = ds.Tables("TabDoct")
                'Obtención del Parámetro de Salida para colocarlo en el campo descripción
                Dim cmd As New SqlCommand("sp_RDDoct", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cmd.Parameters.Add("@ApePat", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@ApeMat", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdDocu", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@Clave", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output
                cn.Open()
                cmd.ExecuteReader()
                cn.Close()
                'Llenando los campos con los resultados obtenidos del procedimiento
                ApePat.Text = cmd.Parameters("@ApePat").Value
                ApeMat.Text = cmd.Parameters("@ApeMat").Value
                Nombres.Text = cmd.Parameters("@Nombre").Value
                Try
                    Dim cmdDocu As New SqlCommand("select DesDocu from TabDocu where IdDocu = " & cmd.Parameters("@IdDocu").Value, cn)
                    cn.Open()
                    TDocumento.Text = cmdDocu.ExecuteScalar()
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo Documento " & ex.Message)
                End Try
                'TDocumento.Text = cmd.Parameters("@IdDocu").Value
                NDocumento.Text = cmd.Parameters("@NumDoc").Value
                Clave1.Text = cmd.Parameters("@Clave").Value
                Clave2.Text = cmd.Parameters("@Clave").Value
                ApePat.Focus()
            Else
                TDocumento.SelectedIndex = 0
                Refrescar_grilla()
                ApePat.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class