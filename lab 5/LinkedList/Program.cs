using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>(); // создаём связный список

            list.Add(17);
            list.Add(9);
            list.Add(8);
            list.Add(-27);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.Delete(8); // удаляем один элемент

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPress ENTER to exit.");
            Console.ReadLine();
        }
    }
}
