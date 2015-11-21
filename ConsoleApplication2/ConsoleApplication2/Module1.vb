Module Module1

    Dim atrib As Integer

    Sub Main()
        Dim clase As New Class1
        Dim x As Integer = 0
        While x < 10


            Console.WriteLine(clase.atrib & "" & x)
            Console.WriteLine(Class1.a & "" & x)
            x += 1
        End While
        Console.ReadLine()


    End Sub

    
End Module
