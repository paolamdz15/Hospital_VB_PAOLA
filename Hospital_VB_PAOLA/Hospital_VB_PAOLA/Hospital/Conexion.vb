Imports System.Data.SqlClient

Module Conexion
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public conexionn As New SqlClient.SqlConnection("data source=DESKTOP-REBAD4R\SQLEXPRESS; initial catalog =Hospital1; integrated security=SSPI; persist security info = false; trusted_connection = yes; ")


    Function existeUsuario(ByVal Usuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            cmd = New SqlCommand("select * from Medico where Usuario = '" & Usuario & "'", conexionn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error en la funcion existeUsuario: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Function obtenerContrasena(ByVal Usuario As String) As String
        Dim contra As String = ""
        Try
            cmd = New SqlCommand("Select Contrasena from Medico where Usuario='" & Usuario & "'", conexionn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                contra = dr.Item("Contrasena").ToString
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error en la funcion obtenerContrasena debido a: " + ex.ToString)
        End Try
        Return contra
    End Function
End Module