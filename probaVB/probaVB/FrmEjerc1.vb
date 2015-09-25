Public Class FrmEjerc1
    Private Sub operacions(sender As Object, even As EventArgs) Handles btnDiv.Click, btnMul.Click, btnRestar.Click, btnSumar.Click
        Dim x As Button = CType(sender, Button)

        Select Case x.Text
            Case "+"
                If TextBox1.Text = "" Or TextBox2.Text = "" Then
                    MsgBox("Introduce valores")
                Else
                    lblResult.Text = CInt(TextBox1.Text) + CInt(TextBox2.Text)
                End If
            Case "-"
                If TextBox1.Text = "" Or TextBox2.Text = "" Then
                    MsgBox("Introduce valores")
                Else
                    lblResult.Text = CInt(TextBox1.Text) - CInt(TextBox2.Text)
                End If
            Case "*"
                If TextBox1.Text = "" Or TextBox2.Text = "" Then
                    MsgBox("Introduce valores")
                Else
                    lblResult.Text = CInt(TextBox1.Text) * CInt(TextBox2.Text)
                End If
            Case "/"
                If TextBox1.Text = "" Or TextBox2.Text = "" Then
                    MsgBox("Introduce valores")
                Else
                    lblResult.Text = CInt(TextBox1.Text) / CInt(TextBox2.Text)
                End If
        End Select

    End Sub

    Private Sub btnAxuda_Click(sender As Object, e As EventArgs) Handles btnAxuda.Click
        MsgBox("mete os valores e dalle o boton da operacion a querer realizar")
    End Sub

End Class