Public Class Form1
    Private filePath As String
    Private array(128) As Cnode
    Private texts As String
    Private holderarray(128) As Array
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
            '  array(i).weighting = counter
            ' array(i).letterofnode = distinctarray(i)

            MsgBox(distinctarray(i) + "   =   " + counter.ToString)
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case OpenFileDialog1.ShowDialog()
            Case DialogResult.OK
                filePath = OpenFileDialog1.FileName
                texts = My.Computer.FileSystem.ReadAllText(filePath)
            Case Else
        End Select
        frequencyanalysis()
        array = sort.bubblesort(array)
        For i = 0 To array.Length - 1
            MsgBox(array(i).letterofnode & " " & array(i).weighting)
        Next
    End Sub


End Class