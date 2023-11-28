Imports System.Data.SqlClient

Public Class FrmMedicamentos
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim mc As SqlCommand = New SqlCommand("Insert into Medicamento (NombreM,Fecha_Caducidad,Medico_crea,Medico_actualiza) values (@NombreM,@Fecha_Caducidad,@Medico_crea,@Medico_actualiza)", conexionn)
        mc.Parameters.AddWithValue("@NombreM", TxtNombreM.Text)
        mc.Parameters.AddWithValue("@Fecha_Caducidad", TxtFCADM.Text)
        mc.Parameters.AddWithValue("@Medico_crea", 1)
        mc.Parameters.AddWithValue("@Medico_actualiza", 1)
        mc.ExecuteNonQuery()
        conexionn.Close()
        Me.MedicamentoTableAdapter.Fill(Me.Hospital1DataSet.Medicamento)
    End Sub

    Private Sub FrmMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MedicamentoTableAdapter.Fill(Me.Hospital1DataSet.Medicamento)
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        conexionn.Open()
        Dim mc As SqlCommand = New SqlCommand("Update Medicamento set NombreM=@NombreM, Fecha_Caducidad=@Fecha_Caducidad,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Medicamento = @ID_Medicamento", conexionn)
        mc.Parameters.AddWithValue("@ID_Medicamento", DataGridViewM.SelectedRows(0).Cells(0).Value)
        mc.Parameters.AddWithValue("@NombreM", TxtNombreM.Text)
        mc.Parameters.AddWithValue("@Fecha_Caducidad", TxtFCADM.Text)
        mc.Parameters.AddWithValue("@Medico_crea", 1)
        mc.Parameters.AddWithValue("@Medico_actualiza", 1)
        mc.ExecuteNonQuery()
        conexionn.Close()
        Me.MedicamentoTableAdapter.Fill(Me.Hospital1DataSet.Medicamento)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexionn.Open()
        Dim mc As SqlCommand = New SqlCommand("Update Medicamento set status=0 where ID_Medicamento = @ID_Medicamento", conexionn)
        mc.Parameters.AddWithValue("@ID_Medicamento", DataGridViewM.SelectedRows(0).Cells(0).Value)
        mc.ExecuteNonQuery()
        conexionn.Close()
        Me.MedicamentoTableAdapter.Fill(Me.Hospital1DataSet.Medicamento)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class