Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'aとbの変数をint型で定義
        Dim a, b As Integer

        'Valメソッドで文字列を数字に変換する
        'Valメソッドを使用すると通常の文字を入力されたら0にすることができる
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        TextBox3.Text = a + b
        TextBox4.Text = a - b
        TextBox5.Text = a * b
        TextBox6.Text = a / b
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim tenn As Integer
        tenn = Val(TextBox7.Text)
        If tenn > 29 Then
            If tenn > 99 Then
                TextBox8.Text = "東大合格"
            ElseIf tenn > 29 Then
                TextBox8.Text = "合格"
            End If
        Else
            TextBox8.Text = "赤点"
        End If
    End Sub
End Class
