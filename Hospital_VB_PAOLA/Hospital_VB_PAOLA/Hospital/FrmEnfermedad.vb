Imports System.Data.SqlClient

Public Class FrmEnfermedad
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim dx As SqlCommand = New SqlCommand("Insert into Enfermedades(NombreE,Tratamiento,Medico_crea,Medico_actualiza) values (@NombreE,@Tratamiento,@Medico_crea,@Medico_actualiza)", conexionn)

        dx.Parameters.AddWithValue("@NombreE", TxtNombreE.Text)
        dx.Parameters.AddWithValue("@Tratamiento", TxtTratamientoE.Text)
        dx.Parameters.AddWithValue("@Medico_crea", 1)
        dx.Parameters.AddWithValue("@Medico_actualiza", 1)
        dx.ExecuteNonQuery()
        conexionn.Close()
        Me.EnfermedadesTableAdapter.Fill(Me.Hospital1DataSet.Enfermedades)
    End Sub

    Private Sub FrmEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EnfermedadesTableAdapter.Fill(Me.Hospital1DataSet.Enfermedades)
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        conexionn.Open()
        Dim dx As SqlCommand = New SqlCommand("Update Enfermedades set NombreE=@NombreE, Tratamiento=@Tratamiento,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Enfermedad = @ID_Enfermedad", conexionn)
        dx.Parameters.AddWithValue("@ID_Enfermedad", DataGridViewE.SelectedRows(0).Cells(0).Value)
        dx.Parameters.AddWithValue("@NombreE", TxtNombreE.Text)
        dx.Parameters.AddWithValue("@Tratamiento", TxtTratamientoE.Text)
        dx.Parameters.AddWithValue("@Medico_crea", 1)
        dx.Parameters.AddWithValue("@Medico_actualiza", 1)
        dx.ExecuteNonQuery()
        conexionn.Close()
        Me.EnfermedadesTableAdapter.Fill(Me.Hospital1DataSet.Enfermedades)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexionn.Open()
        Dim dx As SqlCommand = New SqlCommand("Update Enfermedades set status=0 where ID_Enfermedad = @ID_Enfermedad", conexionn)
        dx.Parameters.AddWithValue("@ID_Enfermedad", DataGridViewE.SelectedRows(0).Cells(0).Value)
        dx.ExecuteNonQuery()
        conexionn.Close()
        Me.EnfermedadesTableAdapter.Fill(Me.Hospital1DataSet.Enfermedades)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class