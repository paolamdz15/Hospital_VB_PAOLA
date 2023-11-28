Imports System.Data.SqlClient

Public Class FrmFactura
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Nota(Fecha_Emision,Total,ID_DFactura,Medico_crea,Medico_actualiza)
        values(@Fecha_Emision,@Total,@ID_DFactura,@Medico_crea,@Medico_actualiza)", conexionn)
        xd.Parameters.AddWithValue("@Fecha_Emision", TxtFechaEmision.Text)
        xd.Parameters.AddWithValue("@Total", TxtTotalF.Text)
        xd.Parameters.AddWithValue("@ID_DFactura", CBIdDFF.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.NotaTableAdapter1.Fill(Me.Hospital1DataSet1.Nota)
    End Sub

    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.NotaTableAdapter1.Fill(Me.Hospital1DataSet1.Nota)
        Me.Detalle_FacturaTableAdapter1.Fill(Me.Hospital1DataSet2.Detalle_Factura)


    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Nota set Fecha_Emision=@Fecha_Emision,Total=@Total,ID_DFactura=@ID_DFactura,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Factura = @ID_Factura", conexionn)
        xd.Parameters.AddWithValue("@ID_Factura", DGVFactura.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@Fecha_Emision", TxtFechaEmision.Text)
        xd.Parameters.AddWithValue("@Total", TxtTotalF.Text)
        xd.Parameters.AddWithValue("@ID_DFactura", CBIdDFF.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.NotaTableAdapter1.Fill(Me.Hospital1DataSet1.Nota)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Nota set status=0 where ID_Factura = @ID_Factura", conexionn)
        xd.Parameters.AddWithValue("@ID_Factura", DGVFactura.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.NotaTableAdapter1.Fill(Me.Hospital1DataSet1.Nota)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class