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
            //list.Pop();
            //Console.WriteLine("After pop head");
            //list.Show();
            //list.DeleteAt(2);
            //Console.WriteLine("After deleting last");
            //list.Show();
            list.Search(30);
            Console.WriteLine("after finding");
            list.Show();
            list.InsertAt(2, 40);
            Console.WriteLine("After adding");
            list.Show();
            list.DeleteAt(2);
            Console.WriteLine("After deleting");
            list.Show();
            
        }
    }
}
