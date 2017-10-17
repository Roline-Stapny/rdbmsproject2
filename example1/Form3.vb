Imports System.Text.RegularExpressions ' Regular Expressions Namespace

Imports System.Data
Imports System.Data.SqlClient


Public Class Form3

    'delclare the connection
    ' Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim sql As New Sqlcontrol




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label8.Show()
        Label9.Show()
        ListView1.Show()
        ListView2.Show()
        Button5.Show()

        'hide organize
        TextBox1.Hide()
        TextBox2.Show()
        TextBox3.Hide()
        DateTimePicker1.Hide()
        TextBox5.Hide()
        TextBox6.Hide()
        TextBox7.Hide()
        Label1.Hide()
        Label2.Show()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Button3.Hide()


    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'If Not A Matching Format Entered
        If Not Regex.Match(TextBox1.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox1.Focus() 'Return Focus
            TextBox1.Clear() 'Clear TextBox

        Else

            'Everything Fine can copy to dtabase

        End If

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        'If Not A Matching Format Entered
        If Not Regex.Match(TextBox6.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox6.Focus() 'Return Focus
            TextBox6.Clear() 'Clear TextBox


        Else

            'Everything Fine

        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        'If Not A Matching Format Entered
        If Not Regex.Match(TextBox3.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox3.Focus() 'Return Focus
            TextBox3.Clear() 'Clear TextBox

        Else

            'Everything Fine

        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        'If Not A Matching Format Entered
        If Not Regex.Match(TextBox5.Text, "^[a-z ]*$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox5.Focus() 'Return Focus
            TextBox5.Clear() 'Clear TextBox

        Else

            'Everything Fine

        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[0-9]+$", RegexOptions.IgnoreCase).Success Then 'Only numbers

            MessageBox.Show("Please  enter numbers Only!") 'Inform User

            TextBox2.Focus() 'Return Focus
            TextBox2.Clear() 'Clear TextBox


        Else

            'Everything Fine

        End If



    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[0-9]+$", RegexOptions.IgnoreCase).Success Then 'Only numbers

            MessageBox.Show("Please  enter numbers Only!") 'Inform User

            TextBox2.Focus() 'Return Focus
            TextBox2.Clear() 'Clear TextBox
        Else
            'Everything Fine

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        LoginForm1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Show()
        TextBox2.Show()
        TextBox3.Show()
        DateTimePicker1.Show()
        TextBox5.Show()
        TextBox6.Show()
        TextBox7.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        Label7.Show()
        Button3.Show()


        'of organize
        Label8.Hide()
        Label9.Hide()
        ListView1.Hide()
        ListView2.Hide()
        Button5.Hide()


    End Sub
    'add button code

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'chech for empty textboxes
        Dim emptyTextBoxes =
         From txt In Me.Controls.OfType(Of TextBox)()
         Where txt.Text.Length = 0
         Select txt.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                            String.Join(",", emptyTextBoxes)))
        Else



            Try
                'open the connection
                sql.SQLCon.Open()
                Try
                    sql.SQLCmd.CommandText = "Insert into [FEST].[dbo].[Event] ([Event_Name],[Event_id],[Department],[Date],[Place]) Values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + DateTimePicker1.Text + "','" + TextBox5.Text + "')"
                    sql.SQLCmd.ExecuteNonQuery()

                    MessageBox.Show("succesful")
                Catch ex As Exception

                    'insertion failed
                    MsgBox(ex.Message)
                End Try

            Catch ex As Exception
                'connection failed
                MsgBox(ex.Message)

            End Try
            sql.SQLCon.Close()
        End If


    End Sub



    'go button code


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' Integer Event_id As TextBox2.Text




    End Sub
End Class