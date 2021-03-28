using System;
using Akcesory;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hours godz = new Hours();
            godz.Hour = 0; //dostęp do zmiennej prywatnej poprzez właściwość
            //przypisanie możliwe dzięki sekcji set we własności Hour
            Console.WriteLine(godz);
            //sekcja set nie tylko umożliwia bezpośredni dostęp do zmiennej 
            //prywatnej hour, ale sprawuje kontrolę nad jej zakresem i 
            //pozwala ustalić wartości innych zmiennych prywatnych
            godz.Hour = 3;
            Console.WriteLine(godz);
            godz.Hour = 12;
            Console.WriteLine(godz);
            godz.Hour = 19;
            Console.WriteLine(godz);
            godz.Hour = 24;
            Console.WriteLine(godz);
            godz.Hour = 36;
            Console.WriteLine(godz);
            godz.Hour = -80;
            Console.WriteLine(godz);
            Console.ReadKey();
        }
    }
}
