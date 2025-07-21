Option Strict On
Imports System.Data.SqlClient
Imports CSharpClassLibrary

Module Module1

    Sub Main()
        Dim nama As String = "John Doe"
        ' Display a greeting message to the user

        Console.WriteLine("Hello, " & nama & "! Welcome to the VB Console Application.")

        Dim a As Integer = 5
        Dim b As Integer = 10

        Dim hasil As Integer = MyFunction.Add(a, b)
        Console.WriteLine("The result of adding " & a & " and " & b & " is: " & hasil)

        hasil = MyFunction.Subtract(a, b)
        Console.WriteLine("The result of subtracting " & b & " from " & a & " is: " & hasil)


        Dim d = 12
        'd = "Erick"


        Dim e As Integer = 10
        Dim f As Double = e
        Dim g As Double = 14.5
        Dim h As Integer = Convert.ToInt32(g)
        Console.WriteLine("The value of h is: " & h)


        Console.WriteLine("The value of d is: " & d)

        Dim c = b
        Console.WriteLine("The value of c is: " & c)
        b = 15
        Console.WriteLine("The value of b is now: " & c)

        Dim person1 As New Person("Alice")
        Dim person2 As New Person()
        person2.Name = "Bob"

        Dim person3 = person2
        Console.WriteLine("Person 3's name is: " & person3.Name)
        person2.Name = "Charlie"
        Console.WriteLine("Person 3's name is now: " & person3.Name)

        Select Case person1.Name
            Case "Alice"
                Console.WriteLine("Person 1 is Alice.")
            Case "Bob"
                Console.WriteLine("Person 1 is Bob.")
            Case Else
                Console.WriteLine("Person 1 is someone else.")
        End Select

        Try

        Catch sqlEx As SqlException


        Catch ex As Exception

        End Try

    End Sub

    Public Class Person
        ' This class can be used for additional functionality in the future
        Private _name As String
        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value
            End Set
        End Property

        Sub New()
            ' Default constructor
        End Sub

        Sub New(name As String)
            _name = name
        End Sub

        Public Function GetGreeting() As String
            Return "Hello, " & _name & "! Welcome to the VB Console Application."
        End Function

        Sub DisplayGreeting()
            Console.WriteLine("Hello, " & _name & "! Welcome to the VB Console Application.")
        End Sub
    End Class

End Module
