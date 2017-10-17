Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Sqlcontrol
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server =LAPTOP-A33PLPM0; Integrated Security = true"}

    Public SQLCmd As New SqlCommand With {.Connection = SQLCon}


    Public Function HasConnection9() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
