Imports System.Data
Imports System.Data.SqlClient


Public Class LoginForm1
    Dim sql As New Sqlcontrol
    Dim cmd As New SqlCommand


    Dim rd As SqlDataReader



    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "Admin" And PasswordTextBox.Text = "Admin" Then
            Form3.Show()

            Me.Hide()

        Else
            cmd.Connection = sql.SQLCon


            Try
                sql.SQLCon.Open()

                'if connected


                Try
                    cmd.CommandText = "select Username,Password from [FEST].[dbo].[Student] where Username='" & UsernameTextBox.Text & "' and Password='" & PasswordTextBox.Text & "';"
                    rd = cmd.ExecuteReader()
                    If rd.HasRows Then
                        Form2.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Wong Username or Password")
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            Catch ex As Exception
                MessageBox.Show("connection Error")
            End Try
            sql.SQLCon.Close()


        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class
