Public Class Form1
    Private filePath As String
    Private array(128) As Cnode
    Private texts As String
    Private holderarray(128) As Cnode
    Private sort As New Csort
    Private operators As New Cnodeoperation

    Private Sub frequencyanalysis()
        Dim chararray() As Char = texts.ToCharArray
        Dim distinctarray() As Char = chararray.Distinct.ToArray

        Dim counter As Integer = 0
        For i As Integer = 0 To distinctarray.Count - 1
            counter = 0
            For j As Integer = i To chararray.Count - 1
                If distinctarray(i) = chararray(j) Then
                    counter += 1
                End If
            Next
            array(i).weighting = counter
            array(i).letterofnode = distinctarray(i)
            'MsgBox(array(i).letterofnode & array(i).weighting)
            'MsgBox(distinctarray(i) + "   =   " + counter.ToString)
        Next
    End Sub
    Private Sub addtogrid()
        'For i = 0 To operators.nodes.Length - 1
        '    MsgBox(operators.nodes(i).pointer)

        'Next
    End Sub





    Private Sub findbinarycodes(node As Cnode, binchar As String, startoftree As Boolean)
        If startoftree = True Then
            binchar = ""
        End If
        lefttraverse(node, binchar)
        righttraverse(node, binchar)
    End Sub
    Private Sub lefttraverse(node As Cnode, binchar As String)
        If Not (node.childnodes(0) Is Nothing) Then 'for when it traverses down the left
            If node.childnodes(0).letterofnode Is Nothing Then
                binchar += "0"
                node.childnodes(0).pointer = binchar
                findbinarycodes(node.childnodes(0), binchar, False)
            Else
                node.childnodes(0).pointer = binchar + "0"
                operators.add(node.childnodes(0))


            End If
        End If
    End Sub
    Private Sub righttraverse(node As Cnode, binchar As String) 'when it goes down the right
        If Not (node.childnodes(1) Is Nothing) Then
            If node.childnodes(1).letterofnode Is Nothing Then
                binchar += "1"
                node.childnodes(1).pointer = binchar
                findbinarycodes(node.childnodes(1), binchar, False)
            Else
                node.childnodes(1).pointer = binchar + "1"

                operators.add(node.childnodes(1))


            End If
        End If
    End Sub














    Private Sub initialize()
        For i = 0 To array.Length - 1
            array(i) = New Cnode(Nothing, Nothing, Nothing)
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initialize()

        Select Case OpenFileDialog1.ShowDialog()
            Case DialogResult.OK
                filePath = OpenFileDialog1.FileName
                texts = My.Computer.FileSystem.ReadAllText(filePath)
            Case Else
        End Select

        For i = 0 To texts.Length - 1
            If Asc(texts(i)) > 128 Then
                texts = Replace(texts, texts(i), "")
            End If
        Next

        frequencyanalysis()

        array = sort.bubblesort(array)
        ' MsgBox("list has been sorted")
        Dim liststart As Integer = 0
        For i = 0 To array.Length - 1
            ' MsgBox(array(i).weighting)
            If array(i).weighting = 0 Then
                array(i) = Nothing
            End If
        Next

        operators.removethenothings(array)
        append(array)
        findbinarycodes(array(0), "", True)
        addtogrid()
    End Sub

    Private Sub append(ByRef arrayz As Cnode())
        'MsgBox("append")
        If array.Length > 1 Then
            'MsgBox("appending")
            Dim minimumone As Cnode = arrayz(0)
            Dim minimumtwo As Cnode = arrayz(1)
            Dim oneplustwo As Integer = minimumone.weighting + minimumtwo.weighting
            Dim kids As Cnode() = {minimumone, minimumtwo}
            Dim newNodeVal As New Cnode(oneplustwo, Nothing, kids)
            arrayz(1) = newNodeVal
            arrayz(0) = Nothing

            operators.removethenothings(arrayz)
            arrayz = sort.bubblesort(arrayz)
            'MsgBox(arrayz.Length)
            append(arrayz)
        End If
    End Sub


End Class