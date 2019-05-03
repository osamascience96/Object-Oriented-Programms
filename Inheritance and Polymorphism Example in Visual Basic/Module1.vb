Module Module1

    Sub Main()

        Dim bookObj As New Book("ABC123", "Thomas")
        Console.WriteLine(bookObj.GetItemId())
        bookObj.SetBookName("Calculas")
        Console.WriteLine(bookObj.GetBookName())
        Console.WriteLine(bookObj.Get_Artist_Author_Name())
        bookObj.SetLoan(True)
        Console.WriteLine(bookObj.GetLoan())
        bookObj.SetItemTakenDate(#4/27/2019#)
        Console.WriteLine(bookObj.GetItemTakenDate())
        bookObj.SetIsRequested(True)
        Console.WriteLine(bookObj.GetIsRequested())
        bookObj.PrintDetails()

        Console.WriteLine("------------------------------------------------------------------")

        Dim cdObj As New CD("ABC132", "Arif Lohar")
        Console.WriteLine(cdObj.GetItemId())
        cdObj.SetCDName("Jugni Folks")
        Console.WriteLine(cdObj.GetCDName())
        Console.WriteLine(cdObj.Get_Artist_Author_Name())
        cdObj.SetLoan(True)
        Console.WriteLine(cdObj.GetLoan())
        cdObj.SetItemTakenDate(#2/27/2019#)
        Console.WriteLine(cdObj.GetItemTakenDate())
        cdObj.SetGenere("Classic")
        Console.WriteLine(cdObj.GetGenere())
        cdObj.PrintDetails()

        Console.ReadLine()
    End Sub

End Module
