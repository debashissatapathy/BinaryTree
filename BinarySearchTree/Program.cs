using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinarySearchTree<int> BinarySearch = new BinarySearchTree<int>(70);
            BinarySearch.Insert(70);
            BinarySearch.Insert(32);
            BinarySearch.Insert(48);
            BinarySearch.Insert(43);
            BinarySearch.Insert(35);
            BinarySearch.Insert(26);
            BinarySearch.Insert(57);
            BinarySearch.Insert(5);
            BinarySearch.Insert(39); 
            BinarySearch.Insert(19);
            BinarySearch.Display();
            BinarySearch.GetSize();
            bool result = BinarySearch.IfExists(56, BinarySearch);
            Console.WriteLine(result);
        }
    }
}
