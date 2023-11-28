Public Class FrmInicio


    Private Sub btnMedicos_Click(sender As Object, e As EventArgs) Handles btnMedicos.Click
        Dim ListadoMedicos As FrmMedico = New FrmMedico()
        ListadoMedicos.Show()
        Me.Hide()
    End Sub

    Private Sub btnMedicamentos_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        Dim ListadoMedicamento As FrmMedicamentos = New FrmMedicamentos()
        ListadoMedicamento.Show()
        Me.Hide()
    End Sub

    Private Sub btnAtencion_Click(sender As Object, e As EventArgs) Handles btnAtencion.Click
        Dim Atenciones As FrmAtencion = New FrmAtencion()
        Atenciones.Show()
        Me.Hide()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        Dim Servicios As FrmServicio = New FrmServicio()
        Servicios.Show()
        Me.Hide()
    End Sub

    Private Sub btnTServicios_Click(sender As Object, e As EventArgs) Handles btnTServicios.Click
        Dim TServicios As FrmTipoServicio = New FrmTipoServicio()
        TServicios.Show()
        Me.Hide()
    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        Dim Pacientes As Form1 = New Form1()
        Pacientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim Clientes As FrmCliente = New FrmCliente()
        Clientes.Show()
        Me.Hide()
    End Sub

    Private Sub btnRecetas_Click(sender As Object, e As EventArgs) Handles btnRecetas.Click
        Dim Recetas As FrmReceta = New FrmReceta()
        Recetas.Show()
        Me.Hide()
    End Sub

    Private Sub btnDiagnostico_Click(sender As Object, e As EventArgs) Handles btnDiagnostico.Click
        Dim Diagnosticos As FrmDiagnostico = New FrmDiagnostico()
        Diagnosticos.Show()
        Me.Hide()
    End Sub

    Private Sub btnEnfermedad_Click(sender As Object, e As EventArgs) Handles btnEnfermedad.Click
        Dim Enfermedades As FrmEnfermedad = New FrmEnfermedad()
        Enfermedades.Show()
        Me.Hide()
    End Sub

    Private Sub btnDFactura_Click(sender As Object, e As EventArgs) Handles btnDFactura.Click
        Dim DFacturas As FrmDetalleFactura = New FrmDetalleFactura()
        DFacturas.Show()
        Me.Hide()
    End Sub

    Private Sub btnFactura_Click(sender As Object, e As EventArgs) Handles btnFactura.Click
        Dim Facturas As FrmFactura = New FrmFactura()
        Facturas.Show()
        Me.Hide()
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class