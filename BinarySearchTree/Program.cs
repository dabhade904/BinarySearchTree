namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string [] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(50);
            binaryTree.Add(17);
            binaryTree.Add(72);
            binaryTree.Add(23);
            binaryTree.Add(76); 
            binaryTree.Add(54);
            binaryTree.Add(12);
            binaryTree.Add(14);
            binaryTree.Add(9);
            binaryTree.Add(67);
            binaryTree.Add(19);
            binaryTree.TraversePreorder(binaryTree.Root);
        }
    }
}