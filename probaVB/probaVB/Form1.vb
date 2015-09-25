Public Class Form1
   

    'handles especifica que é un proc de evento
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

        Mensaxe("XDDD")

    End Sub

    Private Sub Mensaxe(mensaxeAAmosar As String)
        MsgBox(mensaxeAAmosar)

    End Sub

    Private Function x() As Integer
        Return 1
    End Function

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        FrmEjerc1.ShowDialog()

    End Sub
End Class
