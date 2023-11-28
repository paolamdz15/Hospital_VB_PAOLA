Imports System.Data.SqlClient

Public Class FrmCliente
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Insert into Cliente(NombreC,ApPaternoC,ApMaternoC,DireccionC,TelefonoC,ID_Factura,Medico_crea,Medico_actualiza)
        values(@NombreC,@ApPaternoC,@ApMaternoC,@DireccionC,@TelefonoC,@ID_Factura,@Medico_crea,@Medico_actualiza)", conexionn)
        xd.Parameters.AddWithValue("@NombreC", TxtNombreC.Text)
        xd.Parameters.AddWithValue("@ApPaternoC", TxtApC.Text)
        xd.Parameters.AddWithValue("@ApMaternoC", TxtAmC.Text)
        xd.Parameters.AddWithValue("@DireccionC", TxtDireccionC.Text)
        xd.Parameters.AddWithValue("@TelefonoC", TxtTelC.Text)
        xd.Parameters.AddWithValue("@ID_Factura", CBN.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ClienteTableAdapter2.Fill(Me.Hospital1DataSet1.Cliente)
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.NotaTableAdapter2.Fill(Me.Hospital1DataSet3.Nota)
        Me.ClienteTableAdapter2.Fill(Me.Hospital1DataSet1.Cliente)


    End Sub

    Private Sub BtnActualizarC_Click(sender As Object, e As EventArgs) Handles BtnActualizarC.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Cliente set  NombreC=@NombreC,ApPaternoC=@ApPaternoC,ApMaternoC=@ApMaternoC,DireccionC=@DireccionC,TelefonoC=@TelefonoC,ID_Factura=@ID_Factura,Medico_crea=@Medico_crea,Medico_actualiza=@Medico_actualiza where ID_Cliente = @ID_Cliente", conexionn)
        xd.Parameters.AddWithValue("@ID_Cliente  ", DataGridViewCliente.SelectedRows(0).Cells(0).Value)
        xd.Parameters.AddWithValue("@NombreC", TxtNombreC.Text)
        xd.Parameters.AddWithValue("ApPaternoC", TxtApC.Text)
        xd.Parameters.AddWithValue("@ApMaternoC", TxtAmC.Text)
        xd.Parameters.AddWithValue("@DireccionC", TxtDireccionC.Text)
        xd.Parameters.AddWithValue("@TelefonoC", TxtTelC.Text)
        xd.Parameters.AddWithValue("@ID_Factura", CBN.SelectedValue)
        xd.Parameters.AddWithValue("@Medico_crea", 1)
        xd.Parameters.AddWithValue("@Medico_actualiza", 1)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ClienteTableAdapter2.Fill(Me.Hospital1DataSet1.Cliente)
    End Sub

    Private Sub BtnEliminarC_Click(sender As Object, e As EventArgs) Handles BtnEliminarC.Click
        conexionn.Open()
        Dim xd As SqlCommand = New SqlCommand("Update Cliente set status=0 where ID_Cliente = @ID_Cliente", conexionn)
        xd.Parameters.AddWithValue("@ID_Cliente", DataGridViewCliente.SelectedRows(0).Cells(0).Value)
        xd.ExecuteNonQuery()
        conexionn.Close()
        Me.ClienteTableAdapter2.Fill(Me.Hospital1DataSet1.Cliente)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim Menu As FrmInicio = New FrmInicio()
        Menu.Show()
        Me.Hide()
    End Sub
End Class