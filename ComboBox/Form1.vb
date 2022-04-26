Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1
            .Items.Add("바나나")
            .Items.Add("사과")
            .Items.Add("오렌지")
            .Items.Add("수박")
            .Items.Add("파인애플")
            .Text = .Items(0)
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ComboBox1.Text & "을(를) 선택했습니다."
    End Sub
End Class
