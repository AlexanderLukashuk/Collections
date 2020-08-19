using System;

namespace MyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyElemCollection myCollection = new MyElemCollection(10);
            myCollection.Add(99);
            myCollection.Add(1);
            myCollection.Add(9);
            myCollection.Add(101);
            myCollection.Add(7);
            myCollection.Remove(1);
            myCollection.Add(88);
            myCollection.Add(11);
            myCollection.RemoveAt(3);
            Console.WriteLine($"Size: {myCollection.GetLenght()}");
            for (int i = 0; i < myCollection.Count; i++)
            {
                Console.WriteLine(myCollection[i]);
            }
        }
    }
}
