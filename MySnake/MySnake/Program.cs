﻿using System;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);


            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            Console.SetCursorPosition(x2, y2);
            Console.Write(sym2);
            Console.ReadLine();


        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym );
        }
    }
}
