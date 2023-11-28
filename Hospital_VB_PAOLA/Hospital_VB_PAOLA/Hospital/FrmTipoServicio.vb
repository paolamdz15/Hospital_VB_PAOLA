Imports System.Data.SqlClient

Public Class FrmTipoServicio
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Tipo_Servicio (Costo,AreaRelacionada,ID_Atencion,ID_Servicio,ID_DFactura,Medico_crea,Medico_actualiza)
        values(@Costo,@AreaRelacionada,@ID_Atencion,@ID_Servicio,@ID_DFactura,@Medico_crea,@Medico_actualiza)", conexionn)
        xd.Parameters.AddWithValue("@Costo", TxtCostoS.Text)
        xd.Parameters.AddWithValue("@AreaRelacionada", TxtAreaRTS.Text)
        xd.Parameters.AddWithValue("@ID_Atencion", ComboBox1.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Servicio", ComboBox2.SelectedValue)
        xd.Parameters.AddWithValue("@ID_DFactura", ComboBox3.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_ServicioTableAdapter.Fill(Me.Hospital1DataSet.Tipo_Servicio)
    End Sub

    Private Sub FrmTipoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Detalle_FacturaTableAdapter.Fill(Me.Hospital1DataSet.Detalle_Factura)
        Me.ServicioTableAdapter.Fill(Me.Hospital1DataSet.Servicio)
        Me.AtencionTableAdapter.Fill(Me.Hospital1DataSet.Atencion)
        Me.Tipo_ServicioTableAdapter.Fill(Me.Hospital1DataSet.Tipo_Servicio)

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Tipo_Servicio set  Costo=@Costo,AreaRelacionada=@AreaRelacionada,ID_Atencion=@ID_Atencion,ID_Servicio=@ID_Servicio,ID_DFactura=@ID_DFactura,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_TServicio  = @ID_TServicio ", conexionn)
        xd.Parameters.AddWithValue("ID_TServicio ", DataGridViewTS.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@Costo", TxtCostoS.Text)
        xd.Parameters.AddWithValue("@AreaRelacionada", TxtAreaRTS.Text)
        xd.Parameters.AddWithValue("@ID_Atencion", ComboBox1.SelectedValue)
        xd.Parameters.AddWithValue("@ID_Servicio", ComboBox2.SelectedValue)
        xd.Parameters.AddWithValue("@ID_DFactura", ComboBox3.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_ServicioTableAdapter.Fill(Me.Hospital1DataSet.Tipo_Servicio)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Diagnostico set status=0 where ID_TServicio = @ID_TServicio", conexionn)
        xd.Parameters.AddWithValue("@ID_TServicio", DataGridViewTS.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.Tipo_ServicioTableAdapter.Fill(Me.Hospital1DataSet.Tipo_Servicio)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class