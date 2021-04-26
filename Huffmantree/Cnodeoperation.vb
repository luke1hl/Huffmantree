Public Class Cnodeoperation
    Property nodes As Cnode()
    Private sorter As New Csort
    Function returnnode()
        Return nodes
    End Function
    Sub add(ByRef node As Cnode)
        MsgBox(node.letterofnode)
        ReDim Preserve nodes(nodes.Length)
        nodes(nodes.Length - 1) = node
        removethenothings(nodes)
        sorter.bubblesort(nodes)
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
