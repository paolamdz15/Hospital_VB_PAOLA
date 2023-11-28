Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        conexionn.Open()
        If existeUsuario(txtUsuario.Text) = True Then
            If txtContrasena.Text.Equals(Desencriptar(obtenerContrasena(txtUsuario.Text))) Then
                Dim frmInicio As FrmInicio = New FrmInicio()
                Me.Hide()
                frmInicio.Show()
            Else
                MsgBox("La contraseña es invalida")
            End If
        Else
            MsgBox("El usuario introducido no existe")
        End If

        conexionn.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class