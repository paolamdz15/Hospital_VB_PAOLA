Imports System.Data.SqlClient

Public Class FrmReceta
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Receta(FechaR,Indicaciones,ID_Medico,ID_Paciente,ID_Medicamento ,Medico_crea,Medico_actualiza)
        values(@FechaR,@Indicaciones,@ID_Medico,@ID_Paciente,@ID_Medicamento,@Medico_crea,@Medico_actualiza)", conexionn)
        xd.Parameters.AddWithValue("@FechaR", TxtFechaR.Text)
        xd.Parameters.AddWithValue("@Indicaciones", TxtIndicacionesR.Text)
        xd.Parameters.AddWithValue("@ID_Medico", CBIdMedicoR.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Paciente", CBIdPacienteR.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Medicamento", CBIdMedicamentoR.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.RecetaTableAdapter.Fill(Me.Hospital1DataSet.Receta)
    End Sub

    Private Sub FrmReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MedicamentoTableAdapter.Fill(Me.Hospital1DataSet.Medicamento)
        Me.PacienteTableAdapter.Fill(Me.Hospital1DataSet.Paciente)
        Me.MedicoTableAdapter.Fill(Me.Hospital1DataSet.Medico)
        Me.RecetaTableAdapter.Fill(Me.Hospital1DataSet.Receta)
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Receta set FechaR=@FechaR,Indicaciones=@Indicaciones,ID_Medico=@ID_Medico,ID_Paciente=@ID_Paciente,ID_Medicamento=@ID_Medicamento ,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Receta = @ID_Receta", conexionn)
        xd.Parameters.AddWithValue("ID_Receta", DataGridViewR.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@FechaR", TxtFechaR.Text)
        xd.Parameters.AddWithValue("@Indicaciones", TxtIndicacionesR.Text)
        xd.Parameters.AddWithValue("@ID_Medico", CBIdMedicoR.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Paciente", CBIdPacienteR.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Medicamento", CBIdMedicamentoR.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.RecetaTableAdapter.Fill(Me.Hospital1DataSet.Receta)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Receta set status=0 where ID_Receta = @ID_Receta", conexionn)
        xd.Parameters.AddWithValue("ID_Receta", DataGridViewR.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.RecetaTableAdapter.Fill(Me.Hospital1DataSet.Receta)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class