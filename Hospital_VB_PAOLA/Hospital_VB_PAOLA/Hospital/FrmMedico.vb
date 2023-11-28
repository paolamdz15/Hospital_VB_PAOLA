Imports System.Data.SqlClient

Public Class FrmMedico

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Medico(Nombre,Ap_Paterno,Ap_Materno,Especialidad,Telefono,Usuario,Contrasena,Medico_crea,Medico_actualiza)
        values(@Nombre,@Ap_Paterno,@Ap_Materno,@Especialidad,@Telefono,@Usuario,@Contrasena,@Medico_crea,@Medico_actualiza)", conexionn)
        xd.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
        xd.Parameters.AddWithValue("@Ap_Paterno", TxtAp.Text)
        xd.Parameters.AddWithValue("@Ap_Materno", TxtAm.Text)
        xd.Parameters.AddWithValue("@Especialidad", TxtEsp.Text)
        xd.Parameters.AddWithValue("@Telefono", TxtTel.Text)
        xd.Parameters.AddWithValue("@Usuario", TxtUsuario.Text)
        xd.Parameters.AddWithValue("@Contrasena", Encriptar(TxtContra.Text))
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.MedicoTableAdapter.Fill(Me.Hospital1DataSet.Medico)
    End Sub

    Private Sub FrmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MedicoTableAdapter.Fill(Me.Hospital1DataSet.Medico)
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Medico set Nombre=@Nombre,Ap_Paterno=@Ap_Paterno,Ap_Materno=@Ap_Materno,Especialidad=@Especialidad,Telefono=@Telefono,Usuario=@Usuario,
        Contrasena=@Contrasena,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Medico = @ID_Medico", conexionn)
        xd.Parameters.AddWithValue("@ID_Medico", DataGridViewMedico.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
        xd.Parameters.AddWithValue("@Ap_Paterno", TxtAp.Text)
        xd.Parameters.AddWithValue("@Ap_Materno", TxtAm.Text)
        xd.Parameters.AddWithValue("@Especialidad", TxtEsp.Text)
        xd.Parameters.AddWithValue("@Telefono", TxtTel.Text)
        xd.Parameters.AddWithValue("@Usuario", TxtUsuario.Text)
        xd.Parameters.AddWithValue("@Contrasena", Encriptar(TxtContra.Text))
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.MedicoTableAdapter.Fill(Me.Hospital1DataSet.Medico)

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Medico set status=0 where ID_Medico = @ID_Medico", conexionn)
        xd.Parameters.AddWithValue("@ID_Medico", DataGridViewMedico.SelectedRows(0).Cells(0).Value)
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