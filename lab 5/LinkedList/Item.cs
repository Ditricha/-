using System;

namespace LinkedList
{
    public class Item<T> // класс для опичания элемента связного списка (далее - списка)
    {
        public T Data { get; set; } // хранимые данные

        public Item<T> Next { get; set; } // следующий элемент списка

        public Item(T data) // создание нового элемента
        {
            if(data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            Data = data;
        }

        public override string ToString() // привидение к строке
        {
            return Data.ToString();
        }
    }
}
