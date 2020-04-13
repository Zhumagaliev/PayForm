using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           string number = Console.ReadLine();
            int number2 = Convert.ToInt32(Console.ReadLine());
           Listtt<string> p = new Listtt<string>();
           p.Add(number);
            
            
            Console.WriteLine(p[number2]);
            
            //p.RemoveLast();
            Console.WriteLine(p.Length);
            Console.ReadLine();
        }

        class Listtt<B>
        {

            private B[] _array = new B[10];
            private B[] _tarray = new B[10];
            private int count = 0;
            public int Length { get; private set; }
            public B this[int index]
            {

                get
                {
                    if (index < count)
                        return _array[index];
                    else return _array[0];

                }
                //set {
                // if (index < _array.Length)
                // _array[index] = value;
                // else {
                // newArray();
                // _array[index] = value;
                // }
                //}
            }

            //public void Add(B v) {
            // if(_array[_array.Length-1] != null)
            //}

            public void Add(B i)
            {
                count++;
                if (_array.Length == count) newArray();
                _array[count - 1] = i;
                Length = count;
            }

            public void RemoveLast()
            {
                if ((float)_array.Length * 0.75 >= count - 1)
                {
                    Array.Copy(_array, 0, _tarray, 0, count - 1);
                    _array = new B[(int)(_array.Length * 0.75)];
                    Array.Copy(_tarray, 0, _array, 0, count - 1);
                    count--;
                    //обнуление массива таррей
                }
            }

            public void error() { Console.WriteLine("Error"); }
            private void newArray()
            {
                Array.Copy(_array, 0, _tarray, 0, _array.Length);
                _array = new B[_array.Length * 2];
                Array.Copy(_tarray, 0, _array, 0, _tarray.Length);
                //обнуление массива таррей
            }

        }

        
    }
}