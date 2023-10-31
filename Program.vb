Imports System

Module costos
    Sub Main(args As String())
        Dim descripcion As String
        Dim unidadesProd As Integer
        Dim costoMateriales As Decimal
        Dim costosFijo As Double
        Dim costosTotal As Double

        Console.WriteLine("Ingrese la descripcion del articulo: ")
        descripcion = Console.ReadLine()

        Console.WriteLine("Ingrese el numero de unidades producidas: ")
        unidadesProd = Convert.ToInt32(Console.ReadLine)()

        costoMateriales = unidadesProd * 3.5

        costosFijo = 10700

        costosTotal = costoMateriales + costosFijo

        Console.WriteLine("descripcion: {0}", descripcion)
        Console.WriteLine("Unidades produccion: {0}", unidadesProd)
        Console.WriteLine("costo de los materiales: {0}", costoMateriales)
        Console.WriteLine("costo fijo: {0}", costosFijo)
        Console.WriteLine("costo total: {0}", costosTotal)









8
    End Sub
End Module
