Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = "당신의 성별은" & vbCrLf
        If RadioButton1.Checked = True Then
            str = str & RadioButton1.Text
        End If
        If RadioButton2.Checked = True Then
            str = str & RadioButton2.Text
        End If
        str = str & "이고," & vbCrLf

        str = str & "당신의 취미는" & vbCrLf
        If CheckBox1.Checked = True Then
            str = str & CheckBox1.Text & vbCrLf
        End If
        If CheckBox2.Checked = True Then
            str = str & CheckBox2.Text & vbCrLf
        End If
        If CheckBox3.Checked = True Then
            str = str & CheckBox3.Text & vbCrLf
        End If
        str = str & "입니다." & vbCrLf

        Label1.Text = str

    End Sub
End Class
