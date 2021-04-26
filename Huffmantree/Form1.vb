Public Class Form1
    Private filePath As String

    Private text As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case OpenFileDialog1.ShowDialog()
            Case DialogResult.OK
                filePath = OpenFileDialog1.FileName
                text = My.Computer.FileSystem.ReadAllText(filePath)
            Case Else
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class
