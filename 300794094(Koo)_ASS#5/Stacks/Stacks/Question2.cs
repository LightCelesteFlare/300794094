using System;

// using BinaryTreeLibrary; // Unnecessary using
namespace Stacks
{
    /* 
     * Write a program that implement the level order traversal of a binary tree,
     * in which the node values are displayed level by level, starting the root node
     * level. 
     * The nodes on each level are displayed from left to right.
     * The level order traversal uses a queue object to control the output of the nodes.
     * 
     */
    public class BinaryT { 
        static void Main()
        {
        
            Tree tree = new Tree();
            int insertValue;
            int order;
            Console.WriteLine("Inserting values: ");
            Random random = new Random();

            // insert 10 random integers from 0-99 in tree 
            for (var i = 1; i <= 10; i++)
            {
                insertValue = random.Next(100);
                order = i;
                Console.Write("[{0}]:", order);
                Console.Write($"{insertValue} ");

                tree.InsertNode(insertValue);
            }

            // perform preorder traversal of tree
            Console.WriteLine("\n\nPreorder traversal");
            tree.PreorderTraversal();

            // perform inorder traversal of tree
            Console.WriteLine("\n\nInorder traversal");
            tree.InorderTraversal();

            // perform postorder traversal of tree
            Console.WriteLine("\n\nPostorder traversal");
            tree.PostorderTraversal();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
