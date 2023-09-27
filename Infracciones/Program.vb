Module MainModule
    Sub Main()
        ' Solicitar al usuario que ingrese el número total de infracciones
        Console.Write("Ingrese el número total de infracciones: ")
        Dim totalInfracciones As Integer = Integer.Parse(Console.ReadLine())

        ' Calcular promedios
        Dim porcentajeMatutino As Double = 0.2
        Dim porcentajeTarde As Double = 0.35
        Dim porcentajeNoche As Double = 0.45

        Dim promedioMatutino As Double = totalInfracciones * porcentajeMatutino
        Dim promedioTarde As Double = totalInfracciones * porcentajeTarde
        Dim promedioNoche As Double = totalInfracciones * porcentajeNoche

        ' Mostrar resultados
        Console.WriteLine("Promedio diario matutino de infracciones: " & promedioMatutino)
        Console.WriteLine("Promedio diario en la tarde de infracciones: " & promedioTarde)
        Console.WriteLine("Promedio diario nocturno de infracciones: " & promedioNoche)

        ' Datos del desarrollador
        Console.WriteLine("Desarrollado por: Javier Alexander Naranjo Moz, NM0463012022")

        Console.ReadLine() ' Esperar a que el usuario presione Enter
    End Sub
End Module
