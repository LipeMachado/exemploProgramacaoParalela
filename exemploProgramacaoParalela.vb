Private Sub executaSequencialLinq(ByVal qtde As Integer)
        Dim sw As New Stopwatch()
        Dim valores = Enumerable.Range(1, qtde)

        sw.Start()
        Dim numeros = From n In valores
                      Where n &gt;= 1 And n &lt;= qtde
                      Select retornaNum(n)

        For Each num In numeros
            Console.WriteLine(num)
        Next

        sw.Stop()
        Console.WriteLine("Tempo execucao com for normal usando Linq: " &amp; sw.Elapsed.ToString)
    End Sub

    Private Sub executaParaleloLinq(ByVal qtde As Integer)
        Dim sw As New Stopwatch()
        Dim valores = Enumerable.Range(1, qtde)

        sw.Start()
        Dim numeros = From n In valores.AsParallel
                      Where n &gt;= 1 And n &lt;= qtde
                      Select retornaNum(n)

        For Each num In numeros
            Console.WriteLine(num)
        Next

        sw.Stop()
        Console.WriteLine("Tempo execucao com for paralelo usando Linq: " &amp; sw.Elapsed.ToString)
    End Sub

    Private Function retornaNum(ByVal numero As Integer) As Integer
        Thread.Sleep(500)
        Return numero
    End Function