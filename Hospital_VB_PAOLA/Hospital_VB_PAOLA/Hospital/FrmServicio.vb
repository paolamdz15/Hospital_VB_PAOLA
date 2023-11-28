Imports System.Data.SqlClient

Public Class FrmServicio
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Servicio(NombreS,Descripcion,Duracion,ID_Atencion,Medico_crea,Medico_actualiza)
        values(@NombreS,@Descripcion,@Duracion,@ID_Atencion,@Medico_crea,@Medico_actualiza)", conexionn)
        xd.Parameters.AddWithValue("@NombreS", TxtNombreS.Text)
        xd.Parameters.AddWithValue("@Descripcion", TxtDescripcionS.Text)
        xd.Parameters.AddWithValue("@Duracion", TxtDuracionS.Text)
        xd.Parameters.AddWithValue("@ID_Atencion", CBIdAtencionS.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ServicioTableAdapter.Fill(Me.Hospital1DataSet.Servicio)
    End Sub

    Private Sub FrmServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AtencionTableAdapter.Fill(Me.Hospital1DataSet.Atencion)
        Me.ServicioTableAdapter.Fill(Me.Hospital1DataSet.Servicio)
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Servicio set  NombreS=@NombreS,Descripcion=@Descripcion,Duracion=@Duracion,ID_Atencion=@ID_Atencion,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Servicio  = @ID_Servicio ", conexionn)
        xd.Parameters.AddWithValue("ID_Servicio ", DataGridViewS.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@NombreS", TxtNombreS.Text)
        xd.Parameters.AddWithValue("@Descripcion", TxtDescripcionS.Text)
        xd.Parameters.AddWithValue("@Duracion", TxtDuracionS.Text)
        xd.Parameters.AddWithValue("@ID_Atencion", CBIdAtencionS.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ServicioTableAdapter.Fill(Me.Hospital1DataSet.Servicio)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Servicio set status=0 where ID_Servicio = @ID_Servicio", conexionn)
        xd.Parameters.AddWithValue("ID_Servicio", DataGridViewS.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ServicioTableAdapter.Fill(Me.Hospital1DataSet.Servicio)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class