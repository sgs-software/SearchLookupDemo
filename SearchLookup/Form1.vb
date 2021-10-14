Public Class Form1


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Class1BindingSource.DataSource = New List(Of Class1)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Class1BindingSource.DataSource = New List(Of Class1) From {
            New Class1 With {.Id = 1, .Name = "Name1"},
            New Class1 With {.Id = 2, .Name = "Name2"}
        }

    End Sub
End Class
