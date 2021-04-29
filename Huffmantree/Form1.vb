Public Class Form1
    Private filePath As String
    Private array(128) As Cnode
    Private texts As String
    Private holderarray(128) As Cnode
    Private sort As New Csort
    Private operators As New Cnodeoperation

    Private Sub frequencyanalysis() 'counts how many characters in a string
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
    Private Sub addtogrid() 'loads the final array into the grid
        Dim dt As New DataTable

        dt.Columns.Add("Character", Type.GetType("System.String"))
        dt.Columns.Add("frequency", Type.GetType("System.Int64"))
        dt.Columns.Add("coding", Type.GetType("System.String"))

        operators.removethenothings(operators.displaynodes)
        ' MsgBox(operators.nodes.Length())
        For i = 0 To operators.displaynodes.Length - 1
            Dim dr As DataRow = dt.NewRow
            dr("frequency") = operators.displaynodes(i).weighting 'creates all the different collumns
            dr("Character") = operators.displaynodes(i).letterofnode
            dr("coding") = operators.displaynodes(i).pointer
            dt.Rows.Add(dr)
        Next
        dt.DefaultView.Sort = "frequency DESC" 'sorts the table by frequency
        dt = dt.DefaultView.ToTable
        DataGridView1.DataSource = dt

        DataGridView1.Refresh()
    End Sub
    Private Sub findbinarycodes(node As Cnode, binchar As String, startoftree As Boolean) 'this gets the binary codes of all the characters once the trees been created
        If startoftree = True Then 'checks to see if its the first character
            binchar = ""
        End If
        lefttraverse(node, binchar) 'traverses down the left hand side 
        righttraverse(node, binchar) 'traverses down right hand side
    End Sub
    Private Sub lefttraverse(node As Cnode, binchar As String)
        If Not (node.childnodes(0) Is Nothing) Then 'for when it traverses down the left
            If node.childnodes(0).letterofnode Is Nothing Then
                binchar += "0" 'adds zero for when it goes left
                node.childnodes(0).pointer = binchar
                findbinarycodes(node.childnodes(0), binchar, False)
            Else
                node.childnodes(0).pointer = binchar + "0"
                operators.addnode(node.childnodes(0))


            End If
        End If
    End Sub
    Private Sub righttraverse(node As Cnode, binchar As String) 'when it goes down the right
        If Not (node.childnodes(1) Is Nothing) Then
            If node.childnodes(1).letterofnode Is Nothing Then 'does exactly the same as above but adds a 1 since its going right
                binchar += "1"
                node.childnodes(1).pointer = binchar
                findbinarycodes(node.childnodes(1), binchar, False)
            Else
                node.childnodes(1).pointer = binchar + "1"

                operators.addnode(node.childnodes(1))


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
                MsgBox("you didn't open a file...closing program")
                Environment.Exit(0)
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
        determinesizes()
    End Sub
    Private Sub determinesizes()
        sizeone.Text = texts.Length * 7
        sizetwo.Text = 0
        For i = 0 To operators.displaynodes.Length - 1
            sizetwo.Text += operators.displaynodes(i).pointer.Length * operators.displaynodes(i).weighting
        Next
        Percentage.Text = sizetwo.Text / sizeone.Text * 100 & " %"

        sizeone.Text &= " bits"
        sizetwo.Text &= " bits"

    End Sub

    Private Sub append(ByRef arrayz As Cnode())
        'MsgBox("append")
        If array.Length > 1 Then
            'MsgBox("appending")
            Dim minimumone As Cnode = arrayz(0)
            Dim minimumtwo As Cnode = arrayz(1)
            Dim kids As Cnode() = {minimumone, minimumtwo}


            Dim oneplustwo As Integer = minimumone.weighting + minimumtwo.weighting
            Dim newNodeVal As New Cnode(oneplustwo, Nothing, kids)
            arrayz(1) = Nothing
            arrayz(0) = Nothing
            ReDim Preserve arrayz(arrayz.Length)



            arrayz(arrayz.Length - 1) = newNodeVal


            operators.removethenothings(arrayz)
            arrayz = sort.bubblesort(arrayz)
            'MsgBox(arrayz.Length)
            append(arrayz) 'recures back through to add everything back to the tree
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class