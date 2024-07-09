Imports System.Data
Imports System.Data.SqlClient
Public Class PartDia
    Dim cn As New SqlConnection(Conexion)
    Dim IdEnf As Integer
    Dim BorrarT As SqlCommand
    Dim Borrar As SqlCommand

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Parte = True
        NParte = 0
        Volver()
    End Sub

    Private Sub EliminarT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarT.Click
        Editar_Registro = False
        NHClinica.Enabled = True
        Buscar_hra.Enabled = True
        If NParte = 0 Then
            NParte = CInt(Index)
        End If
        Try
            BorrarT = New SqlCommand("Delete from DetPartDia where IdPart = " & NParte, cn)
            cn.Open()
            BorrarT.ExecuteNonQuery()
            cn.Close()
            'Grilla
            Dim LLenarGrilla As New SqlCommand("sp_MDetPartDia", cn)
            LLenarGrilla.CommandType = CommandType.StoredProcedure
            LLenarGrilla.Parameters.Add("@Nparte", SqlDbType.Int).Value = NParte
            Dim da As New SqlDataAdapter(LLenarGrilla)
            Dim ds2 As New DataSet
            da.Fill(ds2, "PartDia")
            Grilla.DataSource = ds2.Tables("PartDia")
            'Modulo de limpieza
            NHClinica.Text = ""
            ApePat.Text = ""
            ApeMat.Text = ""
            NomPac.Text = ""
            Procedencia.Text = ""
            RbVaron.Checked = False
            RbMujer.Checked = False
            Estado.SelectedIndex = 0
            Categoria.SelectedIndex = 0
            Diagnostico.SelectedIndex = 11
            'Modulo de recalculos 
            'Estados
            Nuevos.Text = "0"
            Continuadores.Text = "0"
            Reingresantes.Text = "0"
            Total.Text = "0"
            'Fin Estados
            'Sexos
            Mujeres.Text = "0"
            Varones.Text = "0"
            'Fin Sexos
            'Edades
            Niños.Text = "0"
            Jovenes.Text = "0"
            Adultos.Text = "0"
            Ancianos.Text = "0"
        Catch ex As Exception
            MessageBox.Show("Error al eliminar registros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        Editar_Registro = False
        NHClinica.Enabled = True
        Buscar_hra.Enabled = True
        PD = Grilla.Item(0, Grilla.CurrentRow.Index).Value ' Almacena el Nro Parte elegido de la grilla 
        NH = Grilla.Item(1, Grilla.CurrentRow.Index).Value ' Almacena el Nro Hra elegido de la grilla de
        Try
            Borrar = New SqlCommand("Delete from DetPartDia where IdPart = " & PD & " and NroHra = " & NH, cn)
            cn.Open()
            Borrar.ExecuteNonQuery()
            cn.Close()
            'Grilla
            Dim LLenarGrilla As New SqlCommand("sp_MDetPartDia", cn)
            LLenarGrilla.CommandType = CommandType.StoredProcedure
            LLenarGrilla.Parameters.Add("@Nparte", SqlDbType.Int).Value = PD
            Dim da As New SqlDataAdapter(LLenarGrilla)
            Dim ds2 As New DataSet
            da.Fill(ds2, "PartDia")
            Grilla.DataSource = ds2.Tables("PartDia")
            If NParte = 0 Then
                NParte = CInt(Index)
            End If
            Recalculos()
            'Modulo de limpieza
            NHClinica.Text = ""
            ApePat.Text = ""
            ApeMat.Text = ""
            NomPac.Text = ""
            Procedencia.Text = ""
            RbVaron.Checked = False
            RbMujer.Checked = False
            Estado.SelectedIndex = 0
            Categoria.SelectedIndex = 0
            Diagnostico.SelectedIndex = 11
        Catch ex As Exception
            MessageBox.Show("Error al intentar eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

    Function SearchInComboBox(ByVal cmb As ComboBox, _
                              ByVal txtToFind As String, _
                              Optional ByVal colPos As Integer = 0) _
                              As Integer
        Dim I As Integer
        With cmb
            For I = 0 To .Items.Count - 1
                If .Items(I)(colPos).ToString() = txtToFind Then
                    Return I
                End If
            Next I
        End With
        Return -1
    End Function

    Private Sub Grilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick
        Editar_Registro = True
        NHClinica.Enabled = False
        Buscar_hra.Enabled = False
        If IsDBNull(Grilla.Item(0, Grilla.CurrentRow.Index).Value) Or IsDBNull(Grilla.Item(1, Grilla.CurrentRow.Index).Value) Then
            Exit Sub
        Else
            PD = Grilla.Item(0, Grilla.CurrentRow.Index).Value ' Almacena el Nro Parte elegido de la grilla 
            NH = Grilla.Item(1, Grilla.CurrentRow.Index).Value ' Almacena el Nro Hra elegido de la grilla del actual Parte
        End If
        Try
            NHClinica.Text = NH
            Dim LlenarCampos As New SqlCommand("sp_LlenarCamposPart", cn)
            LlenarCampos.CommandType = CommandType.StoredProcedure
            LlenarCampos.Parameters.Add("@S3Index", SqlDbType.Int).Value = NH
            Dim dr As SqlDataReader
            cn.Open()
            dr = LlenarCampos.ExecuteReader()
            If dr.Read Then
                If IsDBNull(dr(0)) Then
                    ApePat.Text = ""
                Else
                    ApePat.Text = dr(0)
                End If
                If IsDBNull(dr(1)) Then
                    ApeMat.Text = ""
                Else
                    ApeMat.Text = dr(1)
                End If
                If IsDBNull(dr(2)) Then
                    NomPac.Text = ""
                Else
                    NomPac.Text = dr(2)
                End If
                If dr(3) = "M" Then
                    RbVaron.Checked = True
                Else
                    RbMujer.Checked = True
                End If
                If IsDBNull(dr(4)) Then
                    Edad.Text = ""
                Else
                    Edad.Text = dr(4)
                End If
                If IsDBNull(dr(5)) Then
                    Procedencia.Text = ""
                Else
                    Procedencia.Text = dr(5)
                End If
            Else
                Exit Sub
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
        Try
            Dim LlenarCombos As New SqlCommand("sp_LlenarCamposPartCombos", cn)
            LlenarCombos.CommandType = CommandType.StoredProcedure
            LlenarCombos.Parameters.Add("@IdPart", SqlDbType.Int).Value = PD
            LlenarCombos.Parameters.Add("@NroHra", SqlDbType.Int).Value = NH
            LlenarCombos.Parameters.Add("@IdcPac", SqlDbType.Int).Direction = ParameterDirection.Output
            LlenarCombos.Parameters.Add("@IdDiag", SqlDbType.VarChar, 15).Direction = ParameterDirection.Output
            LlenarCombos.Parameters.Add("@IdTipPac", SqlDbType.Int).Direction = ParameterDirection.Output
            cn.Open()
            LlenarCombos.ExecuteReader()
            cn.Close()
            Estado.SelectedIndex = LlenarCombos.Parameters("@IdcPac").Value - 1
            Categoria.SelectedIndex = LlenarCombos.Parameters("@IdTipPac").Value - 1
            Diagnostico.SelectedIndex = SearchInComboBox(Diagnostico, LlenarCombos.Parameters("@IdDiag").Value)
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Parte = True
        Try
            Dim Enf As New SqlCommand("select IdEnfm from TabEnfm where NumDoc = " & Validar, cn)
            cn.Open()
            IdEnf = Enf.ExecuteScalar
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error extrayendo ID de la Enfermera " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try

        'Editando o Guardando
        If Editar_Registro = True Then
            'Editando
            Try
                Dim Actualizar As New SqlCommand("sp_ADetPartDia", cn)
                Actualizar.CommandType = CommandType.StoredProcedure
                Actualizar.Parameters.Add("@IdcPac", SqlDbType.Int).Value = Estado.SelectedValue
                Actualizar.Parameters.Add("@IdTipPac", SqlDbType.Int).Value = Categoria.SelectedValue
                If Diagnostico.Text = "" Then
                    Diagnostico.SelectedIndex = 11
                    Actualizar.Parameters.Add("@IdDiag", SqlDbType.VarChar, 15).Value = Diagnostico.SelectedValue
                Else
                    Actualizar.Parameters.Add("@IdDiag", SqlDbType.VarChar, 15).Value = Diagnostico.SelectedValue
                End If
                Actualizar.Parameters.Add("@IdPart", SqlDbType.Int).Value = PD
                Actualizar.Parameters.Add("@NroHra", SqlDbType.Int).Value = NH
                cn.Open()
                Actualizar.ExecuteNonQuery()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("No se puede actualizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Finally
                cn.Close()
            End Try
            'Modulo de limpieza
            NHClinica.Text = ""
            ApePat.Text = ""
            ApeMat.Text = ""
            NomPac.Text = ""
            Procedencia.Text = ""
            RbVaron.Checked = False
            RbMujer.Checked = False
            Estado.SelectedIndex = 0
            Categoria.SelectedIndex = 0
            Diagnostico.SelectedIndex = 11
            If NParte = 0 Then
                NParte = CInt(Index)
            End If
            Recalculos()
        Else
            'Guardando
            Try
                If NParte = 0 Then
                    NParte = CInt(Index)
                End If
                Dim Insertar As New SqlCommand("sp_IDetPartDia", cn)
                Insertar.CommandType = CommandType.StoredProcedure
                Insertar.Parameters.Add("@IdPart", SqlDbType.Int).Value = NParte
                If S3Index > 0 Then
                    Insertar.Parameters.Add("@NroHra", SqlDbType.Int).Value = S3Index
                    S3Index = 0
                Else
                    Insertar.Parameters.Add("@NroHra", SqlDbType.Int).Value = CInt(NHClinica.Text)
                End If
                Insertar.Parameters.Add("@IdcPac", SqlDbType.Int).Value = Estado.SelectedValue
                Insertar.Parameters.Add("@IdDiag", SqlDbType.VarChar, 15).Value = Diagnostico.SelectedValue
                Insertar.Parameters.Add("@IdTipPac", SqlDbType.Int).Value = Categoria.SelectedValue
                Insertar.Parameters.Add("@IdEnfm", SqlDbType.Int).Value = IdEnf
                cn.Open()
                Insertar.ExecuteNonQuery()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("No se puede guardar. Por favor revise los datos ingresados" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Finally
                cn.Close()
            End Try
            'Modulo de limpieza
            NHClinica.Text = ""
            ApePat.Text = ""
            ApeMat.Text = ""
            NomPac.Text = ""
            Procedencia.Text = ""
            RbVaron.Checked = False
            RbMujer.Checked = False
            Estado.SelectedIndex = 0
            Categoria.SelectedIndex = 0
            Diagnostico.SelectedIndex = 11
            Recalculos()
        End If
        'Grilla
        If Editar_Registro = True Then
            Try
                'Grilla
                Dim LLenarGrilla As New SqlCommand("sp_MDetPartDia", cn)
                LLenarGrilla.CommandType = CommandType.StoredProcedure
                LLenarGrilla.Parameters.Add("@Nparte", SqlDbType.Int).Value = PD
                Dim da As New SqlDataAdapter(LLenarGrilla)
                Dim ds2 As New DataSet
                da.Fill(ds2, "PartDia")
                Grilla.DataSource = ds2.Tables("PartDia")
            Catch ex As Exception
                MessageBox.Show("Error al cargar la grilla de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Finally
                cn.Close()
            End Try
        Else
            Refrescar_Grilla()
        End If
        Editar_Registro = False
        NHClinica.Enabled = True
        Buscar_hra.Enabled = True
    End Sub

    Private Sub PartDia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Try
            If Editar_Registro = True Then
                Dim ONdoctor As New SqlCommand("select Apepat + ' ' + ApeMat from tabdoct where Iddoct = " & CInt(Index2), cn)
                cn.Open()
                Doctor.Text = ONdoctor.ExecuteScalar
                cn.Close()
                FecParte.Text = Index3
                Try
                    'Grilla
                    Dim LLenarGrilla As New SqlCommand("sp_MDetPartDia", cn)
                    LLenarGrilla.CommandType = CommandType.StoredProcedure
                    LLenarGrilla.Parameters.Add("@Nparte", SqlDbType.Int).Value = CInt(Index)
                    Dim da As New SqlDataAdapter(LLenarGrilla)
                    Dim ds2 As New DataSet
                    da.Fill(ds2, "PartDia")
                    Grilla.DataSource = ds2.Tables("PartDia")
                Catch ex As Exception
                    MessageBox.Show("Error al cargar la grilla de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Finally
                    cn.Close()
                End Try
                If NParte = 0 Then
                    NParte = CInt(Index)
                End If
                Recalculos()
            Else
                Dim ONdoctor As New SqlCommand("select Apepat + ' ' + ApeMat from tabdoct where Iddoct = " & NDoctor, cn)
                cn.Open()
                Doctor.Text = ONdoctor.ExecuteScalar
                cn.Close()
                FecParte.Text = (FParte)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al intentar editar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
        Try
            Dim OCont As New SqlDataAdapter("select IdcPac,DescPac from ContPac", cn)
            Dim ds As New DataSet
            OCont.Fill(ds, "ContPac")
            Estado.DataSource = ds.Tables("ContPac")
            Estado.DisplayMember = "DescPac"
            Estado.ValueMember = "IdcPac"
        Catch ex As Exception
            MessageBox.Show("Error en CbCont: " & ex.Message)
        End Try
        Try
            Dim OCategoria As New SqlDataAdapter("select IdTipPac,CodTipPac from TipPac", cn)
            Dim ds As New DataSet
            OCategoria.Fill(ds, "TipPac")
            Categoria.DataSource = ds.Tables("TipPac")
            Categoria.DisplayMember = "CodTipPac"
            Categoria.ValueMember = "IdTipPac"
        Catch ex As Exception
            MessageBox.Show("Error en CbCat: " & ex.Message)
        End Try
        Try
            Dim cmd8 As New SqlCommand("sp_MDiag", cn)
            cmd8.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd8)
            Dim ds As New DataSet
            da.Fill(ds, "TabDiag")
            Diagnostico.DataSource = ds.Tables("TabDiag")
            Diagnostico.DisplayMember = "Categoría"
            Diagnostico.ValueMember = "Categoría"
        Catch ex As Exception
            MessageBox.Show("Error en CbDiag: " & ex.Message)
        End Try
        S2Index = ""
        Diagnostico.SelectedIndex = 11
        Editar_Registro = False

    End Sub

    Sub Refrescar_Grilla()
        Try
            'Grilla
            Dim LLenarGrilla As New SqlCommand("sp_MDetPartDia", cn)
            LLenarGrilla.CommandType = CommandType.StoredProcedure
            LLenarGrilla.Parameters.Add("@Nparte", SqlDbType.Int).Value = NParte
            Dim da As New SqlDataAdapter(LLenarGrilla)
            Dim ds2 As New DataSet
            da.Fill(ds2, "PartDia")
            Grilla.DataSource = ds2.Tables("PartDia")
        Catch ex As Exception
            MessageBox.Show("Error al cargar la grilla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Buscar_hra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar_hra.Click
        Try
            NHClinica.Focus()
            BHraCli.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Buscar_Dia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar_Dia.Click
        'Buscar Diagnósticos
        Diagnostico.Focus()
        TabDiag.ShowDialog()
    End Sub

    Sub Volver()
        Dim hijo As New ContGen
        hijo.MdiParent = Principal
        hijo.Show()
        Me.Close()
    End Sub

    Private Sub NHClinica_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NHClinica.GotFocus
        Try
            'S3 contiene Nro Hra
            'S4 contiene Nro Pac
            NHClinica.Text = S3Index
            Dim LlenarCampos As New SqlCommand("sp_LlenarCamposPart", cn)
            LlenarCampos.CommandType = CommandType.StoredProcedure
            LlenarCampos.Parameters.Add("@S3Index", SqlDbType.Int).Value = S3Index
            Dim dr As SqlDataReader
            cn.Open()
            dr = LlenarCampos.ExecuteReader()
            If dr.Read Then
                If IsDBNull(dr(0)) Then
                    ApePat.Text = ""
                Else
                    ApePat.Text = dr(0)
                End If
                If IsDBNull(dr(1)) Then
                    ApeMat.Text = ""
                Else
                    ApeMat.Text = dr(1)
                End If
                If IsDBNull(dr(2)) Then
                    NomPac.Text = ""
                Else
                    NomPac.Text = dr(2)
                End If
                If dr(3) = "M" Then
                    RbVaron.Checked = True
                Else
                    RbMujer.Checked = True
                End If
                If IsDBNull(dr(4)) Then
                    Edad.Text = ""
                Else
                    Edad.Text = dr(4)
                End If
                If IsDBNull(dr(5)) Then
                    Procedencia.Text = ""
                Else
                    Procedencia.Text = dr(5)
                End If
            Else
                Exit Sub
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error llenando campos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub NHClinica_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NHClinica.TextChanged
        Try
            'S3 contiene Nro Hra
            'S4 contiene Nro Pac
            Dim LlenarCampos As New SqlCommand("sp_LlenarCamposPart", cn)
            LlenarCampos.CommandType = CommandType.StoredProcedure
            If NHClinica.Text <> "" Then
                LlenarCampos.Parameters.Add("@S3Index", SqlDbType.Int).Value = CInt(NHClinica.Text)
            Else
                ApePat.Text = ""
                ApeMat.Text = ""
                NomPac.Text = ""
                RbVaron.Checked = False
                RbMujer.Checked = False
                Edad.Text = ""
                Procedencia.Text = ""
                Exit Sub
            End If

            Dim dr As SqlDataReader
            cn.Open()
            dr = LlenarCampos.ExecuteReader()
            If dr.Read Then
                If IsDBNull(dr(0)) Then
                    ApePat.Text = ""
                Else
                    ApePat.Text = dr(0)
                End If
                If IsDBNull(dr(1)) Then
                    ApeMat.Text = ""
                Else
                    ApeMat.Text = dr(1)
                End If
                If IsDBNull(dr(2)) Then
                    NomPac.Text = ""
                Else
                    NomPac.Text = dr(2)
                End If
                If dr(3) = "M" Then
                    RbVaron.Checked = True
                Else
                    RbMujer.Checked = True
                End If
                If IsDBNull(dr(4)) Then
                    Edad.Text = ""
                Else
                    Edad.Text = dr(4)
                End If
                If IsDBNull(dr(5)) Then
                    Procedencia.Text = ""
                Else
                    Procedencia.Text = dr(5)
                End If
            Else
                NHClinica.Text = ""
                Exit Sub
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error llenando campos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Diagnostico_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Diagnostico.GotFocus
        Diagnostico.Text = S2Index
    End Sub

    Sub Recalculos()
        'Modulo de recalculos 
        'Estados
        Try
            Dim i As Integer = 0
            For i = 2 To 4
                Dim CalculadorE As New SqlCommand("sp_ContadorEstados", cn)
                CalculadorE.CommandType = CommandType.StoredProcedure
                CalculadorE.Parameters.Add("@IdcPac", SqlDbType.Int).Value = i
                CalculadorE.Parameters.Add("@IdPart", SqlDbType.Int).Value = NParte 'Numero de parte actual
                cn.Open()
                If i = 2 Then
                    Nuevos.Text = CalculadorE.ExecuteScalar
                End If
                If i = 3 Then
                    Continuadores.Text = CalculadorE.ExecuteScalar
                End If
                If i = 4 Then
                    Reingresantes.Text = CalculadorE.ExecuteScalar
                End If
                cn.Close()
                CalculadorE.Parameters.Clear()
            Next
            Total.Text = CInt(Nuevos.Text) + CInt(Continuadores.Text) + CInt(Reingresantes.Text)
        Catch ex As Exception
            MessageBox.Show("Error obteniendo estados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
        'Fin Estados

        'Sexos
        Try
            Dim CalculadorM As New SqlCommand("sp_ContarMujeres", cn)
            CalculadorM.CommandType = CommandType.StoredProcedure
            CalculadorM.Parameters.Add("@IdPart", SqlDbType.Int).Value = NParte 'Numero de parte actual
            cn.Open()
            Mujeres.Text = CalculadorM.ExecuteScalar
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error obteniendo Sexos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
        Try
            Dim CalculadorV As New SqlCommand("sp_ContarVarones", cn)
            CalculadorV.CommandType = CommandType.StoredProcedure
            CalculadorV.Parameters.Add("@IdPart", SqlDbType.Int).Value = NParte 'Numero de parte actual
            cn.Open()
            Varones.Text = CalculadorV.ExecuteScalar
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error obteniendo numero de varones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
        'Fin Sexos
        'Edades
        Try
            Dim cmdniños As New SqlCommand("sp_Niños", cn)
            cmdniños.CommandType = CommandType.StoredProcedure
            cmdniños.Parameters.Add("@NParte", SqlDbType.Int).Value = NParte
            cn.Open()
            Niños.Text = cmdniños.ExecuteScalar
            cn.Close()
            Dim cmdJovenes As New SqlCommand("sp_Jovenes", cn)
            cmdJovenes.CommandType = CommandType.StoredProcedure
            cmdJovenes.Parameters.Add("@NParte", SqlDbType.Int).Value = NParte
            cn.Open()
            Jovenes.Text = cmdJovenes.ExecuteScalar
            cn.Close()
            Dim cmdAdultos As New SqlCommand("sp_Adultos", cn)
            cmdAdultos.CommandType = CommandType.StoredProcedure
            cmdAdultos.Parameters.Add("@NParte", SqlDbType.Int).Value = NParte
            cn.Open()
            Adultos.Text = cmdAdultos.ExecuteScalar
            cn.Close()
            Dim cmdAncianos As New SqlCommand("sp_Ancianos", cn)
            cmdAncianos.CommandType = CommandType.StoredProcedure
            cmdAncianos.Parameters.Add("@NParte", SqlDbType.Int).Value = NParte
            cn.Open()
            Ancianos.Text = cmdAncianos.ExecuteScalar
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Error obteniendo edades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
        'Fin Edades
    End Sub

End Class