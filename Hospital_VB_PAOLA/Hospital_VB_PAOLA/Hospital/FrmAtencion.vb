Imports System.Data.SqlClient

Public Class FrmAtencion
    Private Sub BtnAgregarA_Click(sender As Object, e As EventArgs) Handles BtnAgregarA.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Atencion(FechaA,Hora_Inicio,Hora_Fin,ID_Medico,ID_Paciente,Medico_crea,Medico_actualiza)
        values(@FechaA,@Hora_Inicio,@Hora_Fin,@ID_Medico,@ID_Paciente,@Medico_crea,@Medico_actualiza)", conexionn)
        xd.Parameters.AddWithValue("@FechaA", SqlDbType.Date).Value = Convert.ToDateTime(TxtFechaA.Text)
        xd.Parameters.AddWithValue("@Hora_Inicio", SqlDbType.Time).Value = Convert.ToDateTime(TxtHoraIA.Text)
        xd.Parameters.AddWithValue("@Hora_Fin", SqlDbType.Time).Value = Convert.ToDateTime(TxtHoraFA.Text)
        xd.Parameters.AddWithValue("@ID_Medico", CBIdMedA.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Paciente", CBIdPacienteA.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.AtencionTableAdapter.Fill(Me.Hospital1DataSet.Atencion)
    End Sub

    Private Sub FrmAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PacienteTableAdapter.Fill(Me.Hospital1DataSet.Paciente)
        Me.MedicoTableAdapter.Fill(Me.Hospital1DataSet.Medico)
        Me.AtencionTableAdapter.Fill(Me.Hospital1DataSet.Atencion)
    End Sub

    Private Sub BtnActualizarA_Click(sender As Object, e As EventArgs) Handles BtnActualizarA.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Atencion set FechaA=@FechaA,Hora_Inicio=@Hora_Inicio,Hora_Fin=@Hora_Fin,ID_Medico=@ID_Medico,ID_Paciente=@ID_Paciente,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Medico = @ID_Medico", conexionn)
        xd.Parameters.AddWithValue("@ID_Atencion ", DataGridViewAtencion.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@FechaA", TxtFechaA.Text)
        xd.Parameters.AddWithValue("@Hora_Inicio", TxtHoraIA.Text)
        xd.Parameters.AddWithValue("@Hora_Fin", TxtHoraFA.Text)
        xd.Parameters.AddWithValue("@ID_Medico", CBIdMedA.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Paciente", CBIdPacienteA.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.AtencionTableAdapter.Fill(Me.Hospital1DataSet.Atencion)
    End Sub

    Private Sub BtnEliminarA_Click(sender As Object, e As EventArgs) Handles BtnEliminarA.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Atencion set status=0 where ID_Atencion = @ID_Atencion", conexionn)
        xd.Parameters.AddWithValue("@ID_Atencion", DataGridViewAtencion.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.MedicoTableAdapter.Fill(Me.Hospital1DataSet.Medico)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class