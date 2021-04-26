Public Class Csort
    Function bubblesort(numlist As Cnode())
        Dim newarray As Cnode() = {}
        Dim Count As Integer = 0
        Dim Swapvalue As Cnode
        For ii = 0 To numlist.Length - 2
            For i = 0 To numlist.Length - 2
                Count += 1
                If numlist(i).weighting > numlist(i + 1).weighting Then
                    Swapvalue = numlist(i)
                    numlist(i) = numlist(i + 1)
                    numlist(i + 1) = Swapvalue
                End If
            Next
        Next
        For i = 0 To numlist.Length - 1
            newarray(i) = numlist(i)
        Next
        Return newarray
    End Function
End Class
