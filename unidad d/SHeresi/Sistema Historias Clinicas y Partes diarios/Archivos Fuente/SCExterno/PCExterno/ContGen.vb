Imports System.Data
Imports System.Data.SqlClient
Public Class ContGen
    Dim cn As New SqlConnection(Conexion)
    Dim Filtrador As New BindingSource

    Private Sub ContGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Grilla.AutoResizeColumns()
        If VTitulo = "Operaciones" Then
            CbTipos.Items.Clear()
            CbTipos.Items.Add("Historia Clínica")
            CbTipos.Items.Add("Parte Diario")
        End If
        If VTitulo = "Mantenimientos" Then
            CbTipos.Items.Clear()
            CbTipos.Items.Add("Doctores")
            CbTipos.Items.Add("Pacientes")
            CbTipos.Items.Add("Enfermeras")
            CbTipos.Items.Add("Religiones")
            CbTipos.Items.Add("Ocupaciones")
            CbTipos.Items.Add("Diagnósticos")
            CbTipos.Items.Add("Idiomas")
            CbTipos.Items.Add("Estados Económicos")
            CbTipos.Items.Add("Condiciones de Alta")
            CbTipos.Items.Add("Tipos de Estado Civil")
            CbTipos.Items.Add("Grados de Instrucción")
            CbTipos.Items.Add("Tipos Hospitalizaciones")
            CbTipos.Items.Add("Continuidad de los Pacientes")
            CbTipos.Items.Add("Tipos de Documentos")

        End If
        'Refrescar el combo y la grilla con los datos del formulario que se este trabajando
        '-----HISTORIAS CLINICAS-----
        If HC = True Then
            Try
                HC = False
                CbTipos.SelectedIndex = 0
                Dim cmd As New SqlCommand("sp_MHraCli", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "HraCli")
                Grilla.DataSource = ds.Tables("HraCli")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los datos de la historia clínica: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----PARTES DIARIOS-----
        If Parte = True Then
            Try
                Parte = False
                CbTipos.SelectedIndex = 1
                Dim cmd As New SqlCommand("sp_MCabPart", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "CabPartDia")
                Grilla.DataSource = ds.Tables("CabPartDia")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los datos principales del parte: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----DOCTORES-----
        If Doct = True Then
            Try
                Doct = False
                CbTipos.SelectedIndex = 0
                Dim cmd As New SqlCommand("sp_MDoct", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabDoct")
                Grilla.DataSource = ds.Tables("TabDoct")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los datos de los doctores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----PACIENTES-----
        If Pac = True Then
            Try
                Pac = False
                CbTipos.SelectedIndex = 1
                Dim cmd As New SqlCommand("sp_MPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabPac")
                Grilla.DataSource = ds.Tables("TabPac")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los datos de los pacientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----ENFERMERAS-----
        If Enfm = True Then
            Try
                Enfm = False
                CbTipos.SelectedIndex = 2
                Dim cmd As New SqlCommand("sp_MEnfm", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabEnfm")
                Grilla.DataSource = ds.Tables("TabEnfm")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los datos las enfermeras: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----RELIGIONES-----
        If Religiones = True Then
            Try
                Religiones = False
                CbTipos.SelectedIndex = 3
                Dim cmd As New SqlCommand("sp_MReligiones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabRelg")
                Grilla.DataSource = ds.Tables("TabRelg")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con las religiones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----OCUPACIONES-----
        If Ocupaciones = True Then
            Try
                Ocupaciones = False
                CbTipos.SelectedIndex = 4
                Dim cmd As New SqlCommand("sp_MOcupaciones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabOcup")
                Grilla.DataSource = ds.Tables("TabOcup")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con las ocupaciones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----DIAGNOSTICOS-----
        If Diag = True Then
            Try
                Diag = False
                CbTipos.SelectedIndex = 5
                Dim cmd As New SqlCommand("sp_MDiag", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabDiag")
                Grilla.DataSource = ds.Tables("TabDiag")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los diagnósticos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

        '-----IDIOMAS-----
        If Idiomas = True Then
            Try
                Idiomas = False
                CbTipos.SelectedIndex = 6
                Dim cmd As New SqlCommand("sp_MIdma", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabIdma")
                Grilla.DataSource = ds.Tables("TabIdma")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los idiomas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

        '-----SITUACION ECONOMICA-----
        If TipPac = True Then
            Try
                TipPac = False
                CbTipos.SelectedIndex = 7
                Dim cmd As New SqlCommand("sp_MTipPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipPac")
                Grilla.DataSource = ds.Tables("TipPac")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con las situaciones económicas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----CONDICIONES DE ALTA-----
        If Cond = True Then
            Try
                Cond = False
                CbTipos.SelectedIndex = 8
                Dim cmd As New SqlCommand("sp_MCond", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabCond")
                Grilla.DataSource = ds.Tables("TabCond")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con las condiciones de alta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----ESTADO CIVIL-----
        If EstCiv = True Then
            Try
                EstCiv = False
                CbTipos.SelectedIndex = 9
                Dim cmd As New SqlCommand("sp_MEstCiv", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabEciv")
                Grilla.DataSource = ds.Tables("TabEciv")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los estados civiles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----GRADOS DE INSTRUCCION-----
        If GI = True Then
            Try
                GI = False
                CbTipos.SelectedIndex = 10
                Dim cmd As New SqlCommand("sp_MGI", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabGins")
                Grilla.DataSource = ds.Tables("TabGins")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los grados de instrucción: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----TIPOS DE HOSPITALIZACION-----
        If Hosp = True Then
            Try
                Hosp = False
                CbTipos.SelectedIndex = 11
                Dim cmd As New SqlCommand("sp_MHosp", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipHosp")
                Grilla.DataSource = ds.Tables("TipHosp")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los tipos de hospitalización: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----CONTINUIDAD DE LOS PACIENTES-----
        If cPac = True Then
            Try
                cPac = False
                CbTipos.SelectedIndex = 12
                Dim cmd As New SqlCommand("sp_McPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "ContPac")
                Grilla.DataSource = ds.Tables("ContPac")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los tipos de continuidad: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----TIPOS DE DOCUMENTOS-----
        If Docu = True Then
            Try
                Docu = False
                CbTipos.SelectedIndex = 13
                Dim cmd As New SqlCommand("sp_MDocu", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabDocu")
                Grilla.DataSource = ds.Tables("TabDocu")
            Catch ex As Exception
                MessageBox.Show("Se generó un error al llenar la grilla con los tipos de documentos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub CbTipos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbTipos.SelectedIndexChanged
        Editar.Enabled = True
        Eliminar.Enabled = True
        '-----HISTORIAS CLINICAS-----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 0 Then
            Filtro.Text = ""
            Try
                Dim cmd As New SqlCommand("sp_MHraCli", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "HraCli")
                Grilla.DataSource = ds.Tables("HraCli")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con las historias clínicas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----PARTES DIARIOS-----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 1 Then
            Filtro.Text = ""
            Try
                Dim cmd As New SqlCommand("sp_MCabPart", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "CabPartDia")
                Grilla.DataSource = ds.Tables("CabPartDia")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los partes diarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----DOCTORES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 0 Then
            Try
                Dim cmd As New SqlCommand("sp_MDoct", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabDoct")
                Grilla.DataSource = ds.Tables("TabDoct")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los datos de los doctores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 1 Then
            Try
                Dim cmd As New SqlCommand("sp_MPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabPac")
                Grilla.DataSource = ds.Tables("TabPac")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los datos de los pacientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----ENFERMERAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 2 Then
            Try
                Dim cmd As New SqlCommand("sp_MEnfm", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabEnfm")
                Grilla.DataSource = ds.Tables("TabEnfm")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los datos de las enfermeras: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----RELIGIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 3 Then
            Try
                Dim cmd As New SqlCommand("sp_MReligiones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabRelg")
                Grilla.DataSource = ds.Tables("TabRelg")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con las religiones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----OCUPACIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 4 Then
            Try
                Dim cmd As New SqlCommand("sp_MOcupaciones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabOcup")
                Grilla.DataSource = ds.Tables("TabOcup")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con las ocupaciones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----DIAGNOSTICOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 5 Then
            Try
                Dim cmd As New SqlCommand("sp_MDiag", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabDiag")
                Grilla.DataSource = ds.Tables("TabDiag")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los diagnósticos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----IDIOMAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 6 Then
            Try
                Dim cmd As New SqlCommand("sp_MIdma", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabIdma")
                Grilla.DataSource = ds.Tables("TabIdma")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los idiomas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----SITUACION ECONOMICAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 7 Then
            Try
                Dim cmd As New SqlCommand("sp_MTipPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipPac")
                Grilla.DataSource = ds.Tables("TipPac")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los estados económicos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----CONDICIONES DE ALTA-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 8 Then
            Try
                Dim cmd As New SqlCommand("sp_MCond", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabCond")
                Grilla.DataSource = ds.Tables("TabCond")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con las condiciones de alta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----ESTADO CIVIL-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 9 Then
            Try
                Dim cmd As New SqlCommand("sp_MEstCiv", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabEciv")
                Grilla.DataSource = ds.Tables("TabEciv")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los estados civiles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----GRADOS DE INSTRUCCION-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 10 Then
            Try
                Dim cmd As New SqlCommand("sp_MGI", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabGins")
                Grilla.DataSource = ds.Tables("TabGins")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los grados de instrucción: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----TIPOS DE HOSPITALIZACION-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 11 Then
            Try
                Dim cmd As New SqlCommand("sp_MHosp", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipHosp")
                Grilla.DataSource = ds.Tables("TipHosp")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los tipos de hospitalización: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----CONTINUIDAD DE LOS PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 12 Then

            Try
                Dim cmd As New SqlCommand("sp_McPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "ContPac")
                Grilla.DataSource = ds.Tables("ContPac")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los tipos de continuidad: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        '-----TIPOS DE DOCUMENTOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 13 Then
            Try
                Dim cmd As New SqlCommand("sp_MDocu", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabDocu")
                Grilla.DataSource = ds.Tables("TabDocu")
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la grilla con los tipos de documentos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
        
        Filtro.Focus()
    End Sub

    Private Sub Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        '-----HISTORIAS CLINICAS-----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 0 Then
            Editar_Registro = False
            Dim hijo As New HraCli
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----PARTES DIARIOS-----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 1 Then
            Editar_Registro = False
            Dim hijo As New CabPartDia
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----DOCTORES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 0 Then
            Editar_Registro = False
            Dim hijo As New TabDoc
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 1 Then
            Editar_Registro = False
            Dim hijo As New TabPac
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----ENFERMERAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 2 Then
            Editar_Registro = False
            Dim hijo As New TabEnf
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----RELIGIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 3 Then
            Editar_Registro = False
            Dim hijo As New MTabRel
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----OCUPACIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 4 Then
            Editar_Registro = False
            Dim hijo As New MTabOcu
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----DIAGNOSTICOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 5 Then
            Editar_Registro = False
            Dim hijo As New MTabDiag
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----IDIOMAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 6 Then
            Editar_Registro = False
            Dim hijo As New MIdma
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----SITUACION ECONOMICA-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 7 Then
            Editar_Registro = False
            Dim hijo As New MTipPac
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----CONDICIONES DE ALTA-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 8 Then
            Editar_Registro = False
            Dim hijo As New MCondAlta
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----ESTADO CIVIL-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 9 Then
            Editar_Registro = False
            Dim hijo As New MEstCiv
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----GRADO DE INSTRUCCIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 10 Then
            Editar_Registro = False
            Dim hijo As New MGraIns
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----TIPOS DE HOSPITALIZACION-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 11 Then
            Editar_Registro = False
            Dim hijo As New MTipHosp
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----CONTINUIDAD DE LOS PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 12 Then
            Editar_Registro = False
            Dim hijo As New MContPac
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If
        '-----TIPOS DE DOCUMENTOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 13 Then
            Editar_Registro = False
            Dim hijo As New MDocs
            hijo.MdiParent = Principal
            hijo.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Grilla_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellClick
        Try
            Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
        Catch ex As Exception
            Editar.Enabled = False
            Eliminar.Enabled = False
            MessageBox.Show("No hay datos para seleccionar. Por favor ingrese nuevos registros", "Alerta", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub Editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar.Click
        '-----HISTORIAS CLINICAS-----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 0 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario 
                Editar_Registro = True
                Dim hijo As New HraCli
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----PARTES DIARIOS-----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 1 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value  'id parte
                Index2 = Grilla.Item(1, Grilla.CurrentRow.Index).Value 'id doctor
                Index3 = Grilla.Item(3, Grilla.CurrentRow.Index).Value 'fecha
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario 
                Editar_Registro = True
                Dim hijo As New PartDia
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----DOCTORES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 0 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Aplicando seguridad para editar enfermeras
                Try
                    Dim cmd As New SqlCommand("sp_PED", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                    cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Direction = ParameterDirection.Output
                    cn.Open()
                    cmd.ExecuteReader()
                    cn.Close()
                    If Admin = False Then
                        If Validar <> cmd.Parameters("@NumDoc").Value Then
                            MessageBox.Show("No tiene permiso para editar esta persona", "Acceso Denegado", MessageBoxButtons.OK)
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New TabDoc
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 1 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New TabPac
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----ENFERMERAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 2 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Aplicando seguridad para editar enfermeras
                Try
                    Dim cmd As New SqlCommand("sp_PEE", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                    cmd.Parameters.Add("@NumDoc", SqlDbType.Int).Direction = ParameterDirection.Output
                    cn.Open()
                    cmd.ExecuteReader()
                    cn.Close()
                    If Admin = False Then
                        If Validar <> cmd.Parameters("@NumDoc").Value Then
                            MessageBox.Show("No tiene permiso para editar esta persona", "Acceso Denegado", MessageBoxButtons.OK)
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New TabEnf
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----RELIGIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 3 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MTabRel
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----OCUPACIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 4 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MTabOcu
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----DIAGNOSTICOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 5 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MTabDiag
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----IDIOMAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 6 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MIdma
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----SITUACION ECONOMICA-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 7 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MTipPac
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----CONDICIONES DE ALTA-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 8 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MCondAlta
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----ESTADO CIVIL-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 9 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MEstCiv
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----GRADO DE INSTRUCCIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 10 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MGraIns
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----TIPOS DE HOSPITALIZACION----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 11 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MTipHosp
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----CONTINUIDAD DE LOS PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 12 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MContPac
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If
        '-----TIPOS DE DOCUMENTOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 13 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Enviando Parámetro para Proceder a actualizar e invocar el formulario Est. Civiles
                Editar_Registro = True
                Dim hijo As New MDocs
                hijo.MdiParent = Principal
                hijo.Show()
                Me.Close()
            Catch ex As Exception
                Editar_Registro = False
                Exit Sub
            End Try
        End If

    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        '-----HISTORIAS CLINICAS-----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 0 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EHraCli", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MHraCli", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "HraCli")
                Grilla.DataSource = ds.Tables("HraCli")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----PARTES DIARIOS-----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 1 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_ECabPart", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MCabPart", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "CabPartDia")
                Grilla.DataSource = ds.Tables("CabPartDia")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----DOCTORES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 0 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EDoct", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MDoct", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabDoct")
                Grilla.DataSource = ds.Tables("TabDoct")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 1 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabPac")
                Grilla.DataSource = ds.Tables("TabPac")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----ENFERMERAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 2 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EEnfm", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MEnfm", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabEnfm")
                Grilla.DataSource = ds.Tables("TabEnfm")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----RELIGIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 3 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EReligiones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MReligiones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabRelg")
                Grilla.DataSource = ds.Tables("TabRelg")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----OCUPACIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 4 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EOcupaciones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MOcupaciones", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabOcup")
                Grilla.DataSource = ds.Tables("TabOcup")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----DIAGNOSTICOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 5 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EDiag", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.VarChar, 15).Value = Index
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MDiag", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabDiag")
                Grilla.DataSource = ds.Tables("TabDiag")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----IDIOMAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 6 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EIdma", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MIdma", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabIdma")
                Grilla.DataSource = ds.Tables("TabIdma")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----SITUACION ECONOMICA-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 7 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_ETipPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MTipPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TipPac")
                Grilla.DataSource = ds.Tables("TipPac")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----CONDICIONES DE ALTA-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 8 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_ECond", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MCond", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabCond")
                Grilla.DataSource = ds.Tables("TabCond")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----ESTADO CIVIL-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 9 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EEstCiv", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MEstCiv", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabEciv")
                Grilla.DataSource = ds.Tables("TabEciv")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----GRADO DE INSTRUCCIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 10 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EGI", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MGI", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabGins")
                Grilla.DataSource = ds.Tables("TabGins")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----GRADO DE INSTRUCCIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 11 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EHosp", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MHosp", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TipHosp")
                Grilla.DataSource = ds.Tables("TipHosp")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----CONTINUIDAD DE LOS PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 12 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EcPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_McPac", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "ContPac")
                Grilla.DataSource = ds.Tables("ContPac")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        '-----TIPOS DE DOCUMENTOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 13 Then
            Try
                'Valor actual de Index en la grilla
                Index = Grilla.Item(0, Grilla.CurrentRow.Index).Value
                'Procedimiento para Eliminar el registro seleccionado en la grilla
                Dim cmd As New SqlCommand("sp_EDocu", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Index", SqlDbType.Int).Value = CInt(Index)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                'Refrescando la grilla
                Dim cmd2 As New SqlCommand("sp_MDocu", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd2)
                Dim ds As New DataSet
                da.Fill(ds, "TabDocu")
                Grilla.DataSource = ds.Tables("TabDocu")
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        
    End Sub

    Private Sub Filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtro.TextChanged
        '-----HISTORIAS CLINICAS-----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 0 Then
            Try
                'Asignando Parámetros
                Dim cmd As New SqlCommand("sp_MHraCli", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "HraCli")
                'Estableciendo parámetros al objeto Filtrador
                Filtrador.DataSource = ds
                Filtrador.DataMember = "HraCli"
                Filtrador.Filter = "Paciente like '%" & Filtro.Text & "%'"
                Grilla.DataSource = Filtrador
            Catch ex As Exception
                Filtrador.Filter = ""
                Grilla.DataSource = Filtrador
                Exit Sub
            End Try
        End If
        '-----PARTES DIARIOS----
        If VTitulo = "Operaciones" And CbTipos.SelectedIndex = 1 Then
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
        End If
        '-----DOCTORES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 0 Then
            Try
                'Asignando Parámetros
                Dim cmd As New SqlCommand("sp_MDoct", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabDoct")
                'Estableciendo parámetros al objeto Filtrador
                Filtrador.DataSource = ds
                Filtrador.DataMember = "TabDoct"
                Filtrador.Filter = "Ap_Paterno like '" & Filtro.Text & "%'"
                Grilla.DataSource = Filtrador
            Catch ex As Exception
                Filtrador.Filter = ""
                Grilla.DataSource = Filtrador
                Exit Sub
            End Try
        End If
        '-----PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 1 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MPac", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabPac")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabPac"
            Filtrador.Filter = "Ape_Paterno like '" & Filtro.Text & "%' or " & "Distrito like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----ENFERMERAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 2 Then
            Try
                'Asignando Parámetros
                Dim cmd As New SqlCommand("sp_MEnfm", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TabEnfm")
                'Estableciendo parámetros al objeto Filtrador
                Filtrador.DataSource = ds
                Filtrador.DataMember = "TabEnfm"
                Filtrador.Filter = "Ap_Paterno like '" & Filtro.Text & "%'"
                Grilla.DataSource = Filtrador
            Catch ex As Exception
                Filtrador.Filter = ""
                Grilla.DataSource = Filtrador
                Exit Sub
            End Try
        End If
        '-----RELIGIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 3 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MReligiones", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabRelg")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabRelg"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----OCUPACIONES-----

        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 4 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MOcupaciones", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabOcup")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabOcup"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----DIAGNOSTICOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 5 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MDiag", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabDiag")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabDiag"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----IDIOMAS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 6 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MIdma", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabIdma")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabIdma"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----SITUACION ECONOMICA-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 7 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MTipPac", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TipPac")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TipPac"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----CONDICIONES DE ALTA-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 8 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MCond", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabCond")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabCond"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----ESTADO CIVIL-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 9 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MEstCiv", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabEciv")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabEciv"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----GRADO DE INSTRUCCIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 10 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MGI", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabGins")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabGins"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----TIPOS DE HOSPITALIZACIONES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 11 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MHosp", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TipHosp")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TipHosp"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----CONTINUIDAD DE LOS PACIENTES-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 12 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_McPac", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "ContPac")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "ContPac"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
        '-----TIPOS DE DOCUMENTOS-----
        If VTitulo = "Mantenimientos" And CbTipos.SelectedIndex = 13 Then
            'Asignando Parámetros
            Dim cmd As New SqlCommand("sp_MDocu", cn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "TabDocu")
            'Estableciendo parámetros al objeto Filtrador
            Filtrador.DataSource = ds
            Filtrador.DataMember = "TabDocu"
            Filtrador.Filter = "Descripción like '%" & Filtro.Text & "%'"
            Grilla.DataSource = Filtrador
        End If
    End Sub

End Class