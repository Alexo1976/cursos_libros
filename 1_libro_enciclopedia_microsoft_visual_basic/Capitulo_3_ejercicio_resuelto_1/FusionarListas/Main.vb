Imports Microsoft.VisualBasic
Imports System

Module FusionarListas
    ' Fusionar dos listas ordenadas.
    Public Function Fusionar(ByVal listaA() As String, ByVal listaB() As String, ByVal listaC() As String) As Integer
        Dim ind, indA, indB, indC As Integer

        If (listaA.Length + listaB.Length = 0) Then
            Return 0
        End If

        ' Fusionar las listas A y B en la C.
        While (indA < listaA.Length And indB < listaB.Length)
            If (listaA(indA).CompareTo(listaB(indB)) < 0) Then
                listaC(indC) = listaA(indA)
                indC += 1 : indA += 1
            Else
                listaC(indC) = listaB(indB)
                indC += 1 : indB += 1
            End If
        End While

        ' Los dos bucles siguientes son para prever ek caso de que, logicamente una lista finalizara antes que la otra.
        For ind = indA To listaA.Length - 1
            listaC(indC) = listaA(ind)
            indC += 1
        Next

        For ind = indB To listaB.Length - 1
            listaC(indC) = listaB(ind)
            indC += 1
        Next

        Return 1
    End Function

    Public Sub Main()
        ' Iniciamos las listas a ordenar (puede sustituir este proceso, por otro de lectura con el fin de tomar los datos de la entrada estandar).
        Dim lista1() As String = {"Ana", "Carmen", "David", "Francisco", "Javier", "Jesus", "Jose", "Josefina", "Luis", "Maria", "Patricia", "Sonia"}

        Dim lista2() As String = {"Agustin", "Belen", "Daniel", "Fernando", "Manuel", "Pedro", "Rosa", "Susana"}

        ' Declara la matriz que va a almacenar el resultado de fusionar las dos anteriores.
        Dim lista3(lista1.Length + lista2.Length) As String

        ' Fusionar lista1 y lista2 y almacenar el resultado en lista3.
        Dim ind, r As Integer
        r = Fusionar(lista1, lista2, lista3)
        ' Escribir la matriz resultante
        If (r <> 0) Then
            For ind = 0 To lista3.Length - 1
                Console.WriteLine(lista3(ind))
            Next
            Console.ReadLine()
        Else
            Console.WriteLine("Error")
        End If
    End Sub
End Module
