Public Class Form1
    Private filePath As String
    Private array(128) As Cnode
    Private texts As String
    Private holderarray(128) As Cnode
    Private sort As New Csort
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
    Private Function initialize()
        For i = 0 To array.Length - 1
            array(i) = New Cnode(Nothing, Nothing, Nothing)
        Next
    End Function
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

        Dim liststart As Integer = 0
        For i = 0 To array.Length - 1
            ' MsgBox(array(i).weighting)
            If array(i).weighting = 0 Then
                array(i) = Nothing
            End If
        Next

        removethenothings()
        append()
    End Sub

    Private Sub append()
        MsgBox("append")
        If array.Length > 1 Then
            Dim minimumone As Cnode = array(0)
            Dim minimumtwo As Cnode = array(1)
            Dim oneplustwo As Integer = minimumone.weighting + minimumtwo.weighting
            Dim kids As Cnode() = {minimumone, minimumtwo}
            Dim newNodeVal As New Cnode(oneplustwo, Nothing, kids)
            array(array.Length - 1) = newNodeVal
            array(0) = Nothing
            array(1) = Nothing
            removethenothings()
            array = sort.bubblesort(array)
            append()
        End If
    End Sub

    Private Sub removethenothings()
        Dim nadacount As Integer = 0
        Dim counter As Integer = 0

        For i = 0 To array.Length - 1
            If array(i) Is Nothing Then
                nadacount += 1
            End If
        Next
        holderarray = array

        For i = nadacount + 1 To holderarray.Length - 1
            array(counter) = holderarray(i)
            counter += 1
        Next

        For i = 0 To array.Length - 1
            Try
                array(i).weighting += 0

            Catch
                ReDim Preserve array(i)
            End Try
        Next
    End Sub

End Class