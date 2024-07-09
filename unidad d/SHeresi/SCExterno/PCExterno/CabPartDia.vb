Imports System.Data
Imports System.Data.SqlClient
Public Class CabPartDia
    Dim cn As New SqlConnection(Conexion)
    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Try
            NDoctor = Doctor.SelectedValue
            FParte = FecParte.Text
            Try
                Dim cmdIns As New SqlCommand("sp_ICabPart", cn)
                cmdIns.CommandType = CommandType.StoredProcedure
                cmdIns.Parameters.Add("@IdDoct", SqlDbType.Int).Value = NDoctor
                cmdIns.Parameters.Add("@Fecpar", SqlDbType.DateTime).Value = FParte
                cn.Open()
                cmdIns.ExecuteNonQuery()
                cn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Try
                Dim cmdmax As New SqlCommand("select max(IdPart) from CabPartDia", cn)
                cn.Open()
                NParte = cmdmax.ExecuteScalar
                cn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show("Seleccione un Doctor de la lista desplegable", "Error", MessageBoxButtons.OK)
            Exit Sub
        End Try
        'Llamar al formulario dentro de Principal
        Dim hijo As New PartDia
        hijo.MdiParent = Principal
        hijo.Show()
        Me.Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        'Llamar al formulario dentro de Principal
        Dim hijo As New ContGen
        hijo.MdiParent = Principal
        hijo.Show()
        Me.Close()
    End Sub

    Private Sub CabPartDia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdSNomDoc As New SqlCommand("sp_SNomDoc", cn)
        cmdSNomDoc.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmdSNomDoc)
        Dim ds As New DataSet
        da.Fill(ds, "TabDoct")
        Doctor.DataSource = ds.Tables("TabDoct")
        Doctor.DisplayMember = "Doctor"
        Doctor.ValueMember = "Identificador"
        FecParte.Text = Date.Today.ToShortDateString
    End Sub
End Class