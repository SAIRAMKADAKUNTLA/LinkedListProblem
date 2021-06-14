using System;

namespace Linked__list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked list problem");
            Linked list = new Linked();
            list.Insert(56);            
            list.Insert(70);
            Console.WriteLine("list of elements");
            list.Show();          
            Console.WriteLine("after adding");
            list.InsertAt(1, 30);
            list.Show();
            
        }
    }
}
