Imports System.Data
Imports System.Data.SqlClient
Public Class Login
    Dim cn As New SqlConnection(Conexion)
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Usuario.Text.Trim = "Admin" And Clave.Text.Trim = "sa" Then
            Admin = True
            Principal.ShowDialog()
            Me.Close()
        Else
            'Para Enfermeras
            Try
                Dim cmdE As New SqlCommand("sp_VUsersE", cn)
                cmdE.CommandType = CommandType.StoredProcedure
                cmdE.Parameters.Add("@NumDoc", SqlDbType.Int).Value = CInt(Usuario.Text)
                cmdE.Parameters.Add("@Clave", SqlDbType.VarChar, 20).Value = Clave.Text
                cmdE.Parameters.Add("@SN", SqlDbType.Int).Direction = ParameterDirection.Output
                cmdE.Parameters.Add("@SC", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output
                cn.Open()
                cmdE.ExecuteReader()
                cn.Close()
                If Not IsDBNull(cmdE.Parameters("@SN").Value) And Not IsDBNull(cmdE.Parameters("@SC").Value) Then
                    If Usuario.Text.Trim = cmdE.Parameters("@SN").Value And Clave.Text.Trim = cmdE.Parameters("@SC").Value Then
                        Validar = cmdE.Parameters("@SN").Value
                        Principal.ShowDialog()
                        Me.Close()
                        Exit Sub
                    Else
                        Exit Try
                    End If
                Else
                    Exit Try
                End If
            Catch ex As Exception
                MessageBox.Show("Ingrese correctamente los datos solicitados " & ex.Message, "Error", MessageBoxButtons.OK)
                Exit Sub
            Finally
                cn.Close()
            End Try
            'Para Doctores
            Try
                Dim cmdD As New SqlCommand("sp_VUsersD", cn)
                cmdD.CommandType = CommandType.StoredProcedure
                cmdD.Parameters.Add("@NumDoc", SqlDbType.Int).Value = CInt(Usuario.Text)
                cmdD.Parameters.Add("@Clave", SqlDbType.VarChar, 20).Value = Clave.Text
                cmdD.Parameters.Add("@SN", SqlDbType.Int).Direction = ParameterDirection.Output
                cmdD.Parameters.Add("@SC", SqlDbType.VarChar, 20).Direction = ParameterDirection.Output
                cn.Open()
                cmdD.ExecuteReader()
                cn.Close()
                If Not IsDBNull(cmdD.Parameters("@SN").Value) And Not IsDBNull(cmdD.Parameters("@SC").Value) Then
                    If Usuario.Text.Trim = cmdD.Parameters("@SN").Value And Clave.Text.Trim = cmdD.Parameters("@SC").Value Then
                        Validar = cmdD.Parameters("@SN").Value
                        Principal.ShowDialog()
                        Me.Close()
                        Exit Sub
                    Else
                        Exit Try
                    End If
                Else
                    Exit Try
                End If
            Catch ex As Exception
                MessageBox.Show("Ingrese correctamente los datos solicitados" & ex.Message, "Error", MessageBoxButtons.OK)
                Exit Sub
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Enf, Doc As Integer
            Dim Cenf As New SqlCommand("sp_ContarRegE", cn)
            Cenf.CommandType = CommandType.StoredProcedure
            Dim Cdoc As New SqlCommand("sp_ContarRegD", cn)
            Cdoc.CommandType = CommandType.StoredProcedure
            cn.Open()
            Enf = Cenf.ExecuteScalar
            Doc = Cdoc.ExecuteScalar
            cn.Close()
            If Enf = 0 Or Doc = 0 Then
                Admin = True
                Principal.ShowDialog()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            cn.Close()
        End Try
    End Sub

End Class
