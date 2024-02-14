Imports System.IO

Module MainModule

    Sub Main()
        Dim choice As Integer = 0

        Console.WriteLine("Selamat datang di Kalkulator Sederhana")
        Console.WriteLine("-------------------------------------")

        Do
            DisplayMenu()
            choice = Integer.Parse(Console.ReadLine())

            Select Case choice
                Case 1
                    Add()
                Case 2
                    Subtract()
                Case 3
                    Multiply()
                Case 4
                    Divide()
                Case 5
                    ReadFromFile()
                Case 6
                    Exit Do
                Case Else
                    Console.WriteLine("Pilihan tidak valid.")
            End Select
        Loop
    End Sub

    Sub DisplayMenu()
        Console.WriteLine("Silakan pilih operasi:")
        Console.WriteLine("1. Penjumlahan")
        Console.WriteLine("2. Pengurangan")
        Console.WriteLine("3. Perkalian")
        Console.WriteLine("4. Pembagian")
        Console.WriteLine("5. Baca dari file")
        Console.WriteLine("6. Keluar")
        Console.Write("Pilihan Anda: ")
    End Sub

    Sub Add()
        Dim num1, num2 As Double

        Console.Write("Masukkan angka pertama: ")
        num1 = Double.Parse(Console.ReadLine())
        Console.Write("Masukkan angka kedua: ")
        num2 = Double.Parse(Console.ReadLine())

        Console.WriteLine("Hasil penjumlahan: " & (num1 + num2))
    End Sub

    Sub Subtract()
        Dim num1, num2 As Double

        Console.Write("Masukkan angka pertama: ")
        num1 = Double.Parse(Console.ReadLine())
        Console.Write("Masukkan angka kedua: ")
        num2 = Double.Parse(Console.ReadLine())

        Console.WriteLine("Hasil pengurangan: " & (num1 - num2))
    End Sub

    Sub Multiply()
        Dim num1, num2 As Double

        Console.Write("Masukkan angka pertama: ")
        num1 = Double.Parse(Console.ReadLine())
        Console.Write("Masukkan angka kedua: ")
        num2 = Double.Parse(Console.ReadLine())

        Console.WriteLine("Hasil perkalian: " & (num1 * num2))
    End Sub

    Sub Divide()
        Dim num1, num2 As Double

        Console.Write("Masukkan angka pertama: ")
        num1 = Double.Parse(Console.ReadLine())
        Console.Write("Masukkan angka kedua: ")
        num2 = Double.Parse(Console.ReadLine())

        If num2 <> 0 Then
            Console.WriteLine("Hasil pembagian: " & (num1 / num2))
        Else
            Console.WriteLine("Pembagian oleh nol tidak diizinkan.")
        End If
    End Sub

    Sub ReadFromFile()
        Dim fileName As String
        Console.Write("Masukkan nama file: ")
        fileName = Console.ReadLine()

        Try
            Using sr As New StreamReader(fileName)
                Dim line As String
                line = sr.ReadLine()
                While line IsNot Nothing
                    Console.WriteLine(line)
                    line = sr.ReadLine()
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("File tidak ditemukan atau terjadi kesalahan: " & ex.Message)
        End Try
    End Sub
End Module
