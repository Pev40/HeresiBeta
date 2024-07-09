Imports System.Data
Imports System.Data.SqlClient
Public Class TabPac
    Dim cn As New SqlConnection(Conexion)
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Pac = True
        Volver()
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Pac = True
        If Editar_Registro = True Then
            Try 'Para Editar y Guardar Registros
                'Regresando el Parámetro a su estado original para poder actualizar después
                Editar_Registro = False
                'Envío de las Variables que actualizarán a las antiguas
                Dim cmd As New SqlCommand("sp_APac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cmd.Parameters.Add("@ApePat", SqlDbType.VarChar, 50).Value = ApePat.Text
                cmd.Parameters.Add("@ApeMat", SqlDbType.VarChar, 50).Value = ApeMat.Text
                cmd.Parameters.Add("@NomPac", SqlDbType.VarChar, 100).Value = NomPac.Text
                If RbVaron.Checked = True Then
                    cmd.Parameters.Add("@SexPac", SqlDbType.Char, 1).Value = "M"
                Else
                    cmd.Parameters.Add("@SexPac", SqlDbType.Char, 1).Value = "F"
                End If
                If FecNac.Text = "" Then
                    cmd.Parameters.Add("@FecNac", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@FecNac", SqlDbType.DateTime).Value = FecNac.Text
                End If
                cmd.Parameters.Add("@IdDist", SqlDbType.Int).Value = CInt(Distrito.SelectedValue)
                cmd.Parameters.Add("@IdProv", SqlDbType.Int).Value = CInt(Provincia.SelectedValue)
                cmd.Parameters.Add("@IdDpto", SqlDbType.Int).Value = CInt(Departamento.SelectedValue)
                cmd.Parameters.Add("@IdDistN", SqlDbType.Int).Value = CInt(DistritoN.SelectedValue)
                cmd.Parameters.Add("@IdProvN", SqlDbType.Int).Value = CInt(ProvinciaN.SelectedValue)
                cmd.Parameters.Add("@IdDptoN", SqlDbType.Int).Value = CInt(DepartamentoN.SelectedValue)
                cmd.Parameters.Add("@DomPac", SqlDbType.VarChar, 100).Value = Domicilio.Text
                cmd.Parameters.Add("@IdRelg", SqlDbType.Int).Value = CInt(Religion.SelectedValue)
                cmd.Parameters.Add("@IdEciv", SqlDbType.Int).Value = CInt(ECivil.SelectedValue)
                cmd.Parameters.Add("@IdOcup", SqlDbType.Int).Value = CInt(Ocupacion.SelectedValue)
                cmd.Parameters.Add("@Centra", SqlDbType.VarChar, 100).Value = CTrabajo.Text
                If TDesocupacion.Text = "" Then
                    cmd.Parameters.Add("@TieDes", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@TieDes", SqlDbType.Int).Value = CInt(TDesocupacion.Text)
                End If
                If TResidencia.Text = "" Then
                    cmd.Parameters.Add("@TieRes", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@TieRes", SqlDbType.Int).Value = CInt(TResidencia.Text)
                End If
                cmd.Parameters.Add("@IdGins", SqlDbType.Int).Value = CInt(GInstruccion.SelectedValue)
                cmd.Parameters.Add("@IdDocu", SqlDbType.Int).Value = CInt(TDocumento.SelectedValue)
                If NDocumento.Text = "" Then
                    cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Value = CInt(NDocumento.Text)
                End If
                cmd.Parameters.Add("@IdIdma", SqlDbType.Int).Value = CInt(Idioma.SelectedValue)
                cmd.Parameters.Add("@RefPor", SqlDbType.VarChar, 100).Value = RefPor.Text
                cmd.Parameters.Add("@AppApo", SqlDbType.VarChar, 50).Value = AppApo.Text
                cmd.Parameters.Add("@ApmApo", SqlDbType.VarChar, 50).Value = ApmApo.Text
                cmd.Parameters.Add("@NomApo", SqlDbType.VarChar, 50).Value = NomApo.Text
                cmd.Parameters.Add("@DirApo", SqlDbType.VarChar, 100).Value = DirApo.Text
                If TelApo.Text = "" Then
                    cmd.Parameters.Add("@TelApo", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@TelApo", SqlDbType.Int).Value = CInt(TelApo.Text)
                End If
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                Guardar.Enabled = False
                Volver()
            Catch ex As Exception
                Editar_Registro = True
                MessageBox.Show("No se pudo actualizar el registro. Porfavor Revise que los campos esten correctamente llenados " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Finally
                cn.Close()
            End Try
        Else
            Try 'Para solo Guardar Registros
                Dim cmd As New SqlCommand("sp_IPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ApePat", SqlDbType.VarChar, 50).Value = ApePat.Text
                cmd.Parameters.Add("@ApeMat", SqlDbType.VarChar, 50).Value = ApeMat.Text
                cmd.Parameters.Add("@NomPac", SqlDbType.VarChar, 100).Value = NomPac.Text
                If RbVaron.Checked = True Then
                    cmd.Parameters.Add("@SexPac", SqlDbType.Char, 1).Value = "M"
                Else
                    cmd.Parameters.Add("@SexPac", SqlDbType.Char, 1).Value = "F"
                End If
                If FecNac.Text = "" Then
                    cmd.Parameters.Add("@FecNac", SqlDbType.DateTime).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@FecNac", SqlDbType.DateTime).Value = FecNac.Text
                End If
                cmd.Parameters.Add("@IdDist", SqlDbType.Int).Value = CInt(Distrito.SelectedValue)
                cmd.Parameters.Add("@IdProv", SqlDbType.Int).Value = CInt(Provincia.SelectedValue)
                cmd.Parameters.Add("@IdDpto", SqlDbType.Int).Value = CInt(Departamento.SelectedValue)
                cmd.Parameters.Add("@IdDistN", SqlDbType.Int).Value = CInt(DistritoN.SelectedValue)
                cmd.Parameters.Add("@IdProvN", SqlDbType.Int).Value = CInt(ProvinciaN.SelectedValue)
                cmd.Parameters.Add("@IdDptoN", SqlDbType.Int).Value = CInt(DepartamentoN.SelectedValue)
                cmd.Parameters.Add("@DomPac", SqlDbType.VarChar, 100).Value = Domicilio.Text
                cmd.Parameters.Add("@IdRelg", SqlDbType.Int).Value = CInt(Religion.SelectedValue)
                cmd.Parameters.Add("@IdEciv", SqlDbType.Int).Value = CInt(ECivil.SelectedValue)
                cmd.Parameters.Add("@IdOcup", SqlDbType.Int).Value = CInt(Ocupacion.SelectedValue)
                cmd.Parameters.Add("@Centra", SqlDbType.VarChar, 100).Value = CTrabajo.Text
                If TDesocupacion.Text = "" Then
                    cmd.Parameters.Add("@TieDes", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@TieDes", SqlDbType.Int).Value = CInt(TDesocupacion.Text)
                End If
                If TResidencia.Text = "" Then
                    cmd.Parameters.Add("@TieRes", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@TieRes", SqlDbType.Int).Value = CInt(TResidencia.Text)
                End If
                cmd.Parameters.Add("@IdGins", SqlDbType.Int).Value = CInt(GInstruccion.SelectedValue)
                cmd.Parameters.Add("@IdDocu", SqlDbType.Int).Value = CInt(TDocumento.SelectedValue)
                If NDocumento.Text = "" Then
                    cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Value = CInt(NDocumento.Text)
                End If
                cmd.Parameters.Add("@IdIdma", SqlDbType.Int).Value = CInt(Idioma.SelectedValue)
                cmd.Parameters.Add("@RefPor", SqlDbType.VarChar, 100).Value = RefPor.Text
                cmd.Parameters.Add("@AppApo", SqlDbType.VarChar, 50).Value = AppApo.Text
                cmd.Parameters.Add("@ApmApo", SqlDbType.VarChar, 50).Value = ApmApo.Text
                cmd.Parameters.Add("@NomApo", SqlDbType.VarChar, 50).Value = NomApo.Text
                cmd.Parameters.Add("@DirApo", SqlDbType.VarChar, 100).Value = DirApo.Text
                If TelApo.Text = "" Then
                    cmd.Parameters.Add("@TelApo", SqlDbType.Int).Value = DBNull.Value
                Else
                    cmd.Parameters.Add("@TelApo", SqlDbType.Int).Value = CInt(TelApo.Text)
                End If
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                ApePat.Text = ""
                ApeMat.Text = ""
                NomPac.Text = ""
                Domicilio.Text = ""
                FecNac.Text = ""
                CTrabajo.Text = ""
                NDocumento.Text = ""
                RefPor.Text = ""
                AppApo.Text = ""
                ApmApo.Text = ""
                NomApo.Text = ""
                DirApo.Text = ""
                TelApo.Text = ""
                TResidencia.Text = ""
                TDesocupacion.Text = ""
                Departamento.SelectedIndex = -1
                Provincia.SelectedIndex = -1
                Distrito.SelectedIndex = -1
                DepartamentoN.SelectedIndex = -1
                ProvinciaN.SelectedIndex = -1
                DistritoN.SelectedIndex = -1
                Ocupacion.SelectedIndex = -1
                Religion.SelectedIndex = -1
                ECivil.SelectedIndex = -1
                GInstruccion.SelectedIndex = -1
                TDocumento.SelectedIndex = -1
                Idioma.SelectedIndex = -1
                ApePat.Focus()
            Catch ex As Exception
                MessageBox.Show("No se pudo guardar el registro. Porfavor Revise que los campos esten correctamente llenados " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub TabPac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Llenando el ComboBox con los datos actuales 
        Try
            Dim cmd1 As New SqlCommand("sp_ODpto", cn)
            cmd1.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd1)
            Dim ds As New DataSet
            da.Fill(ds, "TabDpto")
            Departamento.DataSource = ds.Tables("TabDpto")
            Departamento.DisplayMember = "DesDpto"
            Departamento.ValueMember = "IdDpto"
        Catch ex As Exception
            MessageBox.Show("Error en CbDpto: " & ex.Message)
        End Try

        'Llenando el ComboBox con los datos actuales 
        Try
            Dim cmd1 As New SqlCommand("sp_ODpto", cn)
            cmd1.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd1)
            Dim ds As New DataSet
            da.Fill(ds, "TabDpto")
            DepartamentoN.DataSource = ds.Tables("TabDpto")
            DepartamentoN.DisplayMember = "DesDpto"
            DepartamentoN.ValueMember = "IdDpto"
        Catch ex As Exception
            MessageBox.Show("Error en CbDpto: " & ex.Message)
        End Try

        Try
            Dim cmd2 As New SqlCommand("sp_MOcupaciones", cn)
            cmd2.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd2)
            Dim ds As New DataSet
            da.Fill(ds, "TabOcup")
            Ocupacion.DataSource = ds.Tables("TabOcup")
            Ocupacion.DisplayMember = "Descripción"
            Ocupacion.ValueMember = "Identificador"
        Catch ex As Exception
            MessageBox.Show("Error en CbOcup: " & ex.Message)
        End Try
        Try
            Dim cmd3 As New SqlCommand("sp_MReligiones", cn)
            cmd3.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd3)
            Dim ds As New DataSet
            da.Fill(ds, "TabRelg")
            Religion.DataSource = ds.Tables("TabRelg")
            Religion.DisplayMember = "Descripción"
            Religion.ValueMember = "Identificador"
        Catch ex As Exception
            MessageBox.Show("Error en CbRelg: " & ex.Message)
        End Try
        Try
            Dim cmd4 As New SqlCommand("sp_MEstCiv", cn)
            cmd4.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd4)
            Dim ds As New DataSet
            da.Fill(ds, "TabEciv")
            ECivil.DataSource = ds.Tables("TabEciv")
            ECivil.DisplayMember = "Descripción"
            ECivil.ValueMember = "Identificador"
        Catch ex As Exception
            MessageBox.Show("Error en CbEciv: " & ex.Message)
        End Try
        Try
            Dim cmd5 As New SqlCommand("sp_MGI", cn)
            cmd5.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd5)
            Dim ds As New DataSet
            da.Fill(ds, "TabGins")
            GInstruccion.DataSource = ds.Tables("TabGins")
            GInstruccion.DisplayMember = "Descripción"
            GInstruccion.ValueMember = "Identificador"
        Catch ex As Exception
            MessageBox.Show("Error en CbGins: " & ex.Message)
        End Try
        Try
            Dim cmd6 As New SqlCommand("sp_MDocu", cn)
            cmd6.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd6)
            Dim ds As New DataSet
            da.Fill(ds, "TabDocu")
            TDocumento.DataSource = ds.Tables("TabDocu")
            TDocumento.DisplayMember = "Descripción"
            TDocumento.ValueMember = "Identificador"
        Catch ex As Exception
            MessageBox.Show("Error en CbDocu: " & ex.Message)
        End Try
        Try
            Dim cmd7 As New SqlCommand("sp_MIdma", cn)
            cmd7.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd7)
            Dim ds As New DataSet
            da.Fill(ds, "TabIdma")
            Idioma.DataSource = ds.Tables("TabIdma")
            Idioma.DisplayMember = "Descripción"
            Idioma.ValueMember = "Identificador"
        Catch ex As Exception
            MessageBox.Show("Error en CbIdma: " & ex.Message)
        End Try

        'Editando un Registro
        Try
            If Editar_Registro = True Then
                'Obtención del Parámetro de Salida para colocarlo en el campo descripción
                Dim cmd As New SqlCommand("sp_RDPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cmd.Parameters.Add("@ApePat", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@ApeMat", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@NomPac", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@SexPac", SqlDbType.Char, 1).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@FecNac", SqlDbType.DateTime).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdDist", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdProv", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdDpto", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdDistN", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdProvN", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdDptoN", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@DomPac", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdRelg", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdEciv", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdOcup", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@Centra", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@TieDes", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@TieRes", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdGins", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdDocu", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@IdIdma", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@RefPor", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@AppApo", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@ApmApo", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@NomApo", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@DirApo", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
                cmd.Parameters.Add("@TelApo", SqlDbType.Int).Direction = ParameterDirection.Output
                cn.Open()
                cmd.ExecuteReader()
                cn.Close()
                'Llenando los campos con los resultados obtenidos del procedimiento
                ApePat.Text = cmd.Parameters("@ApePat").Value
                ApeMat.Text = cmd.Parameters("@ApeMat").Value
                NomPac.Text = cmd.Parameters("@NomPac").Value
                If cmd.Parameters("@SexPac").Value = "M" Then
                    RbVaron.Checked = True
                Else
                    RbMujer.Checked = True
                End If

                If IsDBNull(cmd.Parameters("@FecNac").Value) Then
                    FecNac.Text = ""
                Else
                    FecNac.Text = cmd.Parameters("@FecNac").Value
                End If

                Try
                    Dim cmdDpto As New SqlCommand("select DesDpto from TabDpto where IdDpto = " & cmd.Parameters("@IdDpto").Value, cn)
                    cn.Open()
                    Departamento.Text = cmdDpto.ExecuteScalar
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo el Departamento " & ex.Message)
                End Try
                Try
                    Dim cmdProv As New SqlCommand("select DesProv from TabProv where IdDpto = " & cmd.Parameters("@IdDpto").Value & " and IdProv = " & cmd.Parameters("@IdProv").Value, cn)
                    cn.Open()
                    Provincia.Text = cmdProv.ExecuteScalar
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo la Provincia " & ex.Message)
                End Try
                Try
                    Dim cmdDistrito As New SqlCommand("select DesDist from TabDist where IdDpto = " & cmd.Parameters("@IdDpto").Value & " and IdProv = " & cmd.Parameters("@IdProv").Value & " and IdDist = " & cmd.Parameters("@IdDist").Value, cn)
                    cn.Open()
                    Distrito.Text = cmdDistrito.ExecuteScalar
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo el Distrito " & ex.Message)
                End Try

                'lugar de nacimiento
                Try
                    Dim cmdDptoN As New SqlCommand("select DesDpto from TabDpto where IdDpto = " & cmd.Parameters("@IdDptoN").Value, cn)
                    cn.Open()
                    DepartamentoN.Text = cmdDptoN.ExecuteScalar
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo el Departamento Nacimiento " & ex.Message)
                End Try
                Try
                    Dim cmdProvN As New SqlCommand("select DesProv from TabProv where IdDpto = " & cmd.Parameters("@IdDptoN").Value & " and IdProv = " & cmd.Parameters("@IdProvN").Value, cn)
                    cn.Open()
                    ProvinciaN.Text = cmdProvN.ExecuteScalar
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo la Provincia Nacimiento" & ex.Message)
                End Try
                Try
                    Dim cmdDistritoN As New SqlCommand("select DesDist from TabDist where IdDpto = " & cmd.Parameters("@IdDptoN").Value & " and IdProv = " & cmd.Parameters("@IdProvN").Value & " and IdDist = " & cmd.Parameters("@IdDistN").Value, cn)
                    cn.Open()
                    DistritoN.Text = cmdDistritoN.ExecuteScalar
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo el Distrito Nacimiento" & ex.Message)
                End Try

                Domicilio.Text = cmd.Parameters("@DomPac").Value
                Try
                    Dim cmdReligion As New SqlCommand("select DesRelg from TabRelg where IdRelg = " & cmd.Parameters("@IdRelg").Value, cn)
                    cn.Open()
                    Religion.Text = cmdReligion.ExecuteScalar()
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo la Religion " & ex.Message)
                End Try
                Try
                    Dim cmdECivil As New SqlCommand("select DesEciv from TabEciv where IdEciv = " & cmd.Parameters("@IdEciv").Value, cn)
                    cn.Open()
                    ECivil.Text = cmdECivil.ExecuteScalar()
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo el E.Civil " & ex.Message)
                End Try
                Try
                    Dim cmdOcup As New SqlCommand("select DesOcup from TabOcup where IdOcup = " & cmd.Parameters("@IdOcup").Value, cn)
                    cn.Open()
                    Ocupacion.Text = cmdOcup.ExecuteScalar()
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo la Ocupación " & ex.Message)
                End Try
                CTrabajo.Text = cmd.Parameters("@Centra").Value

                If IsDBNull(cmd.Parameters("@Tiedes").Value) Then
                    TDesocupacion.Text = ""
                Else
                    TDesocupacion.Text = cmd.Parameters("@Tiedes").Value
                End If

                If IsDBNull(cmd.Parameters("@TieRes").Value) Then
                    TResidencia.Text = ""
                Else
                    TResidencia.Text = cmd.Parameters("@TieRes").Value
                End If

                Try
                    Dim cmdGI As New SqlCommand("select DesGins from TabGins where IdGins = " & cmd.Parameters("@IdGins").Value, cn)
                    cn.Open()
                    GInstruccion.Text = cmdGI.ExecuteScalar()
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo Grado de Instrucción " & ex.Message)
                End Try
                Try
                    Dim cmdDocu As New SqlCommand("select DesDocu from TabDocu where IdDocu = " & cmd.Parameters("@IdDocu").Value, cn)
                    cn.Open()
                    TDocumento.Text = cmdDocu.ExecuteScalar()
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo Documento " & ex.Message)
                End Try

                If IsDBNull(cmd.Parameters("@NumDoc").Value) Then
                    NDocumento.Text = ""
                Else
                    NDocumento.Text = cmd.Parameters("@NumDoc").Value
                End If

                Try
                    Dim cmdIdma As New SqlCommand("select DesIdma from TabIdma where IdIdma = " & cmd.Parameters("@IdIdma").Value, cn)
                    cn.Open()
                    Idioma.Text = cmdIdma.ExecuteScalar()
                    cn.Close()
                Catch ex As Exception
                    MessageBox.Show("Error obteniendo Idioma " & ex.Message)
                End Try

                RefPor.Text = cmd.Parameters("@RefPor").Value
                AppApo.Text = cmd.Parameters("@AppApo").Value
                ApmApo.Text = cmd.Parameters("@ApmApo").Value
                NomApo.Text = cmd.Parameters("@NomApo").Value
                DirApo.Text = cmd.Parameters("@DirApo").Value

                If IsDBNull(cmd.Parameters("@TelApo").Value) Then
                    TelApo.Text = ""
                Else
                    TelApo.Text = cmd.Parameters("@TelApo").Value
                End If

                ApePat.Focus()
            Else
                RbVaron.Checked = True
                Departamento.SelectedIndex = 21
                Provincia.SelectedIndex = 0
                Distrito.SelectedIndex = 0
                DepartamentoN.SelectedIndex = 21
                ProvinciaN.SelectedIndex = 0
                DistritoN.SelectedIndex = 0
                Ocupacion.SelectedIndex = 0
                Religion.SelectedIndex = 0
                ECivil.SelectedIndex = 0
                GInstruccion.SelectedIndex = 0
                TDocumento.SelectedIndex = 0
                Idioma.SelectedIndex = 0
                ApePat.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Departamento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Departamento.SelectedIndexChanged
        Try
            Dim cmdOProv As New SqlCommand("sp_OProv", cn)
            cmdOProv.CommandType = CommandType.StoredProcedure
            cmdOProv.Parameters.Add("@IdDpto", SqlDbType.Int).Value = Departamento.SelectedValue
            Dim da As New SqlDataAdapter(cmdOProv)
            Dim ds As New DataSet
            da.Fill(ds, "TabProv")
            Provincia.DataSource = ds.Tables("TabProv")
            Provincia.DisplayMember = "DesProv"
            Provincia.ValueMember = "IdProv"
            Provincia.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Provincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Provincia.SelectedIndexChanged
        Try
            Dim cmdODist As New SqlCommand("sp_ODist", cn)
            cmdODist.CommandType = CommandType.StoredProcedure
            cmdODist.Parameters.Add("@IdDpto", SqlDbType.Int).Value = Departamento.SelectedValue
            cmdODist.Parameters.Add("@IdProv", SqlDbType.Int).Value = Provincia.SelectedValue
            Dim da As New SqlDataAdapter(cmdODist)
            Dim ds As New DataSet
            da.Fill(ds, "TabDist")
            Distrito.DataSource = ds.Tables("TabDist")
            Distrito.DisplayMember = "DesDist"
            Distrito.ValueMember = "IdDist"
            Distrito.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DepartamentoN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentoN.SelectedIndexChanged
        Try
            Dim cmdOProv As New SqlCommand("sp_OProv", cn)
            cmdOProv.CommandType = CommandType.StoredProcedure
            cmdOProv.Parameters.Add("@IdDpto", SqlDbType.Int).Value = DepartamentoN.SelectedValue
            Dim da As New SqlDataAdapter(cmdOProv)
            Dim ds As New DataSet
            da.Fill(ds, "TabProv")
            ProvinciaN.DataSource = ds.Tables("TabProv")
            ProvinciaN.DisplayMember = "DesProv"
            ProvinciaN.ValueMember = "IdProv"
            ProvinciaN.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ProvinciaN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProvinciaN.SelectedIndexChanged
        Try
            Dim cmdODist As New SqlCommand("sp_ODist", cn)
            cmdODist.CommandType = CommandType.StoredProcedure
            cmdODist.Parameters.Add("@IdDpto", SqlDbType.Int).Value = DepartamentoN.SelectedValue
            cmdODist.Parameters.Add("@IdProv", SqlDbType.Int).Value = ProvinciaN.SelectedValue
            Dim da As New SqlDataAdapter(cmdODist)
            Dim ds As New DataSet
            da.Fill(ds, "TabDist")
            DistritoN.DataSource = ds.Tables("TabDist")
            DistritoN.DisplayMember = "DesDist"
            DistritoN.ValueMember = "IdDist"
            DistritoN.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub
End Class