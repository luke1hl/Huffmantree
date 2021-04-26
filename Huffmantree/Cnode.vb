Public Class Cnode
    Property childnodes As Cnode() = {Nothing, Nothing} 'holdes the two nodes that are children of this node
    Property weighting As Integer
    Property letterofnode As String
    Property pointer As String

    Sub New(weighting As Integer, letterofnode As String, childnodes() As Cnode)
        Me.weighting = weighting
        Me.letterofnode = letterofnode
        Me.childnodes = childnodes

    End Sub

End Class
