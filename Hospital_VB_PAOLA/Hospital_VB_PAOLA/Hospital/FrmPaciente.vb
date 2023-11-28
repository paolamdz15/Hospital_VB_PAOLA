Imports System.Data.SqlClient

Public Class Form1
    Private Sub BtnAgregarP_Click(sender As Object, e As EventArgs) Handles BtnAgregarP.Click
        conexionn.Open()
        Dim cm As SqlCommand = New SqlCommand("Insert into Paciente(NombreP,Ap_PaternoP,Ap_MaternoP,Edad,Peso,Medico_crea,Medico_actualiza)
        values(@NombreP,@Ap_PaternoP,@Ap_MaternoP,@Edad,@Peso,@Medico_crea,@Medico_actualiza)", conexionn)
        cm.Parameters.AddWithValue("@NombreP", TxtNombreP.Text)
        cm.Parameters.AddWithValue("@Ap_PaternoP", TxtAPP.Text)
        cm.Parameters.AddWithValue("@Ap_MaternoP", TxtAMP.Text)
        cm.Parameters.AddWithValue("@Edad", TxtEdad.Text)
        cm.Parameters.AddWithValue("@Peso", TxtPeso.Text)
        cm.Parameters.AddWithValue("@Medico_crea", 1)
        cm.Parameters.AddWithValue("@Medico_actualiza", 1)
        cm.ExecuteNonQuery()
        conexionn.Close()
        Me.PacienteTableAdapter.Fill(Me.Hospital1DataSet.Paciente)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PacienteTableAdapter.Fill(Me.Hospital1DataSet.Paciente)
    End Sub

    Private Sub BtnActualizarP_Click(sender As Object, e As EventArgs) Handles BtnActualizarP.Click
        conexionn.Open()
        Dim edad As Integer
        If Integer.TryParse(TxtEdad.Text, edad) Then
            Dim peso As Decimal
            If Decimal.TryParse(TxtPeso.Text, peso) Then
                Dim cm As SqlCommand = New SqlCommand("Update Paciente set NombreP=@NombreP,Ap_PaternoP=@Ap_PaternoP,Ap_MaternoP=@Ap_MaternoP,Edad=@Edad,Peso=@Peso,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Paciente = @ID_Paciente", conexionn)
                cm.Parameters.AddWithValue("@ID_Paciente", DataGridViewPacientes.SelectedRows(0).Cells(0).Value)
                cm.Parameters.AddWithValue("@NombreP", TxtNombreP.Text)
                cm.Parameters.AddWithValue("@Ap_PaternoP", TxtAPP.Text)
                cm.Parameters.AddWithValue("@Ap_MaternoP", TxtAMP.Text)
                cm.Parameters.AddWithValue("@Edad", TxtEdad.Text)
                cm.Parameters.AddWithValue("@Peso", TxtPeso.Text)
                cm.Parameters.AddWithValue("@Medico_crea", 1)
                cm.Parameters.AddWithValue("@Medico_actualiza", 1)
                cm.ExecuteNonQuery()
            End If
        End If
        conexionn.Close()
        Me.PacienteTableAdapter.Fill(Me.Hospital1DataSet.Paciente)
    End Sub

    Private Sub BtnEliminarP_Click(sender As Object, e As EventArgs) Handles BtnEliminarP.Click
        conexionn.Open()
        Dim cm As SqlCommand = New SqlCommand("Update Paciente set status=0 where ID_Paciente = @ID_Paciente", conexionn)
        cm.Parameters.AddWithValue("@ID_Paciente", DataGridViewPacientes.SelectedRows(0).Cells(0).Value)
        cm.ExecuteNonQuery()
        conexionn.Close()
        Me.PacienteTableAdapter.Fill(Me.Hospital1DataSet.Paciente)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class
