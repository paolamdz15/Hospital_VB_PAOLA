Imports System.Data.SqlClient

Public Class FrmDetalleFactura
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim ax As SqlCommand = New SqlCommand("Insert into Detalle_Factura(Cantidad,Precio_Unitario,TotalD,Medico_crea,Medico_actualiza ) values (@Cantidad,@Precio_Unitario,@TotalD,@Medico_crea,@Medico_actualiza)", conexionn)
        ax.Parameters.AddWithValue("@Cantidad", TxtCantidadDF.Text)
        ax.Parameters.AddWithValue("@Precio_Unitario", TxtPrecioUni.Text)
        ax.Parameters.AddWithValue("@TotalD", TxtTotalD.Text)
        ax.Parameters.AddWithValue("@Medico_crea", 1)
        ax.Parameters.AddWithValue("@Medico_actualiza", 1)
        ax.ExecuteNonQuery()
        conexionn.Close()
        Me.Detalle_FacturaTableAdapter.Fill(Me.Hospital1DataSet.Detalle_Factura)
    End Sub

    Private Sub FrmDetalleFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Detalle_FacturaTableAdapter.Fill(Me.Hospital1DataSet.Detalle_Factura)
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        conexionn.Open()
        Dim ax As SqlCommand = New SqlCommand("Update Detalle_Factura set Cantidad=@Cantidad,Precio_Unitario=@Precio_Unitario,TotalD=@TotalD,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_DFactura = @ID_DFactura", conexionn)

        ax.Parameters.AddWithValue("@ID_DFactura", DataGridViewDF.SelectedRows(0).Cells(0).Value)
        ax.Parameters.AddWithValue("@Cantidad", TxtCantidadDF.Text)
        ax.Parameters.AddWithValue("@Precio_Unitario", TxtPrecioUni.Text)
        ax.Parameters.AddWithValue("@TotalD", TxtTotalD.Text)
        ax.Parameters.AddWithValue("@Medico_crea", 1)
        ax.Parameters.AddWithValue("@Medico_actualiza", 1)
        ax.ExecuteNonQuery()
        conexionn.Close()
        Me.Detalle_FacturaTableAdapter.Fill(Me.Hospital1DataSet.Detalle_Factura)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        conexionn.Open()
        Dim ax As SqlCommand = New SqlCommand("Update Detalle_Factura set status=0 where ID_DFactura = @ID_DFactura", conexionn)

        ax.Parameters.AddWithValue("@ID_DFactura", DataGridViewDF.SelectedRows(0).Cells(0).Value)
        ax.ExecuteNonQuery()
        conexionn.Close()
        Me.Detalle_FacturaTableAdapter.Fill(Me.Hospital1DataSet.Detalle_Factura)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class