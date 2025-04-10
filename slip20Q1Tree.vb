Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        

        ' Add root nodes
        TreeView1.Nodes.Add("BCA")
        TreeView1.Nodes.Add("BBA")

        ' Add child nodes for BCA
        TreeView1.Nodes(0).Nodes.Add("FY")
        TreeView1.Nodes(0).Nodes.Add("SY")
        TreeView1.Nodes(0).Nodes.Add("TY")

        ' Add child nodes for BBA
        TreeView1.Nodes(1).Nodes.Add("FY")
        TreeView1.Nodes(1).Nodes.Add("SY")
        TreeView1.Nodes(1).Nodes.Add("TY")

        ' Optional: Expand all nodes to show children immediately
        TreeView1.ExpandAll()




    End Sub
End Class
