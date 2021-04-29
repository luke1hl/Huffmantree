Public Class Cnodeoperation
    Property displaynodes As Cnode() = {Nothing} 'holds the final array for when your displayying
    Private sorter As New Csort
    Function returnnode()
        Return displaynodes
    End Function
    Sub addnode(ByRef node As Cnode)
        ReDim Preserve displaynodes(displaynodes.Length)
        displaynodes(displaynodes.Length - 1) = node
        '  MsgBox(nodes.Length)
        'removethenothings(nodes)
        'sorter.bubblesort(nodes)

    End Sub
    Sub removethenothings(ByRef arrayz As Cnode())
        Dim pointernode(0) As Cnode
        Dim counter As Integer = 0
        Dim flagger As Boolean = False



        Dim howmanynothings As Integer = 0
        For i = 0 To arrayz.Length - 1
            If arrayz(i) Is Nothing Then
                howmanynothings += 1

            End If
        Next
        ' MsgBox(howmanynothings)
        'MsgBox(nodes.Length)



        While Not flagger And howmanynothings > 0
            counter += 1
            If Not arrayz(counter) Is Nothing Then
                pointernode(pointernode.Length - 1) = arrayz(counter)
                ReDim Preserve pointernode(pointernode.Length)

            End If
            If pointernode.Length - 1 = arrayz.Length - howmanynothings Then
                flagger = True
            End If

        End While
        ReDim Preserve pointernode(pointernode.Length - 2)
        arrayz = pointernode
    End Sub
End Class
