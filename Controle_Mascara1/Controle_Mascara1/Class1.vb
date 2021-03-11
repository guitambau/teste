Imports System.Data.SqlClient
Module Modulo
    Public registro As Integer
    Public conexaobd As New SqlConnection()
    Public objDataReader As SqlDataReader
    Public comandoSQL As SqlCommand = conexaobd.CreateCommand


    Public Sub SUB_CONECTAR()
        Try
            '  objDataReader.Close()
            conexaobd.Close()
            conexaobd.ConnectionString = "server=10.251.24.11;database=SGM_ONE;uid=sa;pwd=P@ssw0rd"
            conexaobd.Open()
        Catch ex As Exception
            conexaobd.ConnectionString = "server=10.251.24.11;database=SGM_ONE;uid=sa;pwd=P@ssw0rd"
            conexaobd.Open()
        End Try

    End Sub

    Public Sub SUB_DESCONECTAR()
        Try
            objDataReader.Close()
            conexaobd.Close()
        Catch ex As Exception

        End Try

    End Sub




End Module
