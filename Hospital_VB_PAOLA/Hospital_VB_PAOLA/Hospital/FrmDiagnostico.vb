Imports System.Data.SqlClient

Public Class FrmDiagnostico
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Diagnostico(Fecha,Descripcion,Resultado,ID_Medico,ID_Paciente ,ID_Enfermedad ,Medico_crea,Medico_actualiza)
        values(@Fecha,@Descripcion,@Resultado,@ID_Medico,@ID_Paciente ,@ID_Enfermedad,@Medico_crea,@Medico_actualiza)", conexionn)
        xd.Parameters.AddWithValue("@Fecha", TxtFechaD.Text)
        xd.Parameters.AddWithValue("@Descripcion", TxtDescripcionD.Text)
        xd.Parameters.AddWithValue("@Resultado", TxtResultadoD.Text)
        xd.Parameters.AddWithValue("@ID_Medico", CBIdMedicoD.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Paciente", CBIdPacienteD.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Enfermedad", CBIdEnfermedadD.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.DiagnosticoTableAdapter.Fill(Me.Hospital1DataSet.Diagnostico)
    End Sub

    Private Sub FrmDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.EnfermedadesTableAdapter.Fill(Me.Hospital1DataSet.Enfermedades)
        Me.PacienteTableAdapter.Fill(Me.Hospital1DataSet.Paciente)
        Me.MedicoTableAdapter.Fill(Me.Hospital1DataSet.Medico)
        Me.DiagnosticoTableAdapter.Fill(Me.Hospital1DataSet.Diagnostico)

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Diagnostico set  Fecha=@Fecha,Descripcion=@Descripcion,Resultado=@Resultado,ID_Medico=@ID_Medico,ID_Paciente=@ID_Paciente,ID_Enfermedad=@ID_Enfermedad ,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Diagnostico = @ID_Diagnostico", conexionn)
        xd.Parameters.AddWithValue("@ID_Diagnostico", DataGridViewD.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@Fecha", TxtFechaD.Text)
        xd.Parameters.AddWithValue("@Descripcion", TxtDescripcionD.Text)
        xd.Parameters.AddWithValue("@Resultado", TxtResultadoD.Text)
        xd.Parameters.AddWithValue("@ID_Medico", CBIdMedicoD.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Paciente", CBIdPacienteD.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Enfermedad", CBIdEnfermedadD.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.DiagnosticoTableAdapter.Fill(Me.Hospital1DataSet.Diagnostico)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Diagnostico set status=0 where ID_Diagnostico = @ID_Diagnostico", conexionn)
        xd.Parameters.AddWithValue("@ID_Diagnostico", DataGridViewD.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.DiagnosticoTableAdapter.Fill(Me.Hospital1DataSet.Diagnostico)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class