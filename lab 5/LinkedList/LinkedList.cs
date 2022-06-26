using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Item<T> head = null; // первый элемент связного списка (далее - список)
        private Item<T> tail = null; // крайний элемент списка
        private int count = 0; // количество элементов списка

        public int Count
        {
            get => count;
        }

        public void Add(T data) // добавить в список
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            var item = new Item<T>(data);

            if(head == null) // если список пуст, то добавляем новый элемент в начало
            {
                head = item;
            }
            else // иначе добавляем как следующий за крайним
            {
                tail.Next = item;
            }

            tail = item; // устанавливаем этот элемент как последний
            count++;
        }

        public void Delete(T data) // удалить из списка
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            var current = head; //текущий элемеент
            Item<T> previous = null; //предыдущий

            while(current != null) // цикл по всем элементам списка, пока он не закончится или не найдётся элемент, который надо удалить
            {
                if(current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if(current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;
                        if(head == null)
                        {
                            tail = null;
                        }
                    }
                    count--;
                    break;
                }
                previous = current; // переход к следующему элементу в списке
                current = current.Next;
            }
        }

        public void Clear() // очистить список
        {
            head = null;
            tail = null;
            count = 0;
        }

        public IEnumerator<T> GetEnumerator() // вернуть перечисление всех элементов в списке в виде коллекции элементов
        {
            var current = head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() // вернуть итерационное перечисление по списку, IEnumerator проходит по коллекции
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
