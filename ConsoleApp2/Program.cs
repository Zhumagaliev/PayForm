using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // необобщенная коллекция ArrayList
            ArrayList objectList = new ArrayList() { 1, 2, "string", 'c', 2.0f };

            object obj = 45.8;
            objectList.Add(obj);
            
            objectList.Add("string2");//Метод добавления новых элементов.
            objectList.RemoveAt(0); // удаление первого элемента
            foreach (object o in objectList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Общее число элементов коллекции: {0}", objectList.Count);//Свойство только для чтения для получения общего количества элементов.
            
            
            // обобщенная коллекция List
            List<string> countries = new List<string>() { "Казахстан", "Россия", "Украина", "Азербайджан" };
            countries.Add("США");
            countries.RemoveAt(1); // удаление второго элемента
            foreach (string s in countries)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}