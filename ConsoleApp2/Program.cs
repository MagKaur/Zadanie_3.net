﻿using System;
using Akcesory;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hours godz = new Hours();
            godz.Hour = 14; //dostęp do zmiennej prywatnej poprzez właściwość
            //przypisanie możliwe dzięki sekcji set we własności Hour
            Console.WriteLine(godz);
            //sekcja set nie tylko umożliwia bezpośredni dostęp do zmiennej 
            //prywatnej hour, ale sprawuje kontrolę nad jej zakresem i 
            //pozwala ustalić wartości innych zmiennych prywatnych
            Console.ReadKey();
        }
    }
}
