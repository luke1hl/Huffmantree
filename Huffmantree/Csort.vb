Public Class Csort
    Function bubblesort(numlist() As Cnode)

        Dim Count As Integer = 0
        Dim Swapvalue As Cnode
        For i = 0 To numlist.Length - 1
            '  MsgBox(newarray(i).weighting)
        Next
        For ii = 0 To numlist.Length - 2
            For i = 0 To numlist.Length - 2
                Count += 1
                '  MsgBox(newarray(i).weighting)
                If numlist(i).weighting > numlist(i + 1).weighting Then
                    Swapvalue = numlist(i)
                    numlist(i) = numlist(i + 1)
                    numlist(i + 1) = Swapvalue
                    'MsgBox(i)
                End If
            Next
        Next
        For i = 0 To numlist.Length - 1
            MsgBox(numlist(i).weighting)
        Next
        Return numlist
    End Function
End Class
