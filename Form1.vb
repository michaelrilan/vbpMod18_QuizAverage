Public Class Form1
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim qmarks(9) As Integer
        Dim summ As Integer = 0

        For i As Integer = 0 To 9
            qmarks(i) = CInt(InputBox("Enter quiz mark " & (i + 1) & ":", "Quiz marks"))
            ListBox1.Items.Add(qmarks(i))
            summ += qmarks(i)

        Next
        Dim average_grd As Double = summ / qmarks.Length
        outputt.Text = "The average of the quiz marks is " & average_grd
    End Sub
End Class
