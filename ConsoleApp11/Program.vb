Imports System
Public Class Rectangle
    Private length As Integer 'variable declaration'
    Private width As Integer

    Public Sub New(ByVal length As Integer, ByVal width As Integer)
        Me.length = length
        Me.width = width
    End Sub

    Public Function CalculateArea() As Integer
        Return length * width
    End Function

    Public Function CalculatePerimeter() As Integer
        Return 2 * (length + width)
    End Function
End Class

Module Program
    Sub Main()

        Dim rectangle1 As New Rectangle(5, 3)

        Console.WriteLine("Rectangle 1:")
        Console.WriteLine("Area: " & rectangle1.CalculateArea())
        Console.WriteLine("Perimeter: " & rectangle1.CalculatePerimeter())

        Dim rectangle2 As New Rectangle(7, 4)

        Console.WriteLine(vbCrLf & "Rectangle 2:")
        Console.WriteLine("Area: " & rectangle2.CalculateArea())
        Console.WriteLine("Perimeter: " & rectangle2.CalculatePerimeter())

        Console.ReadLine()
    End Sub
End Module

