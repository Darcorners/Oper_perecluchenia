using System;

namespace Oper_perecluchenia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод кириллического символа
            Console.Write("Введите кириллический символ: ");
            char symbol = Console.ReadKey().KeyChar;

            // Получение кода символа по таблице Unicode
            int code = (int)symbol;

            // Вычисление следующего символа
            char nextSymbol = (char)(code + 1);

            // Вычисление остатка от деления на 4
            int remainder = code % 4;

            // Определение скобок для ответа
            string brackets = "";
            switch (remainder)
            {
                case 0:
                    brackets = "()";
                    break;
                case 1:
                    brackets = "[]";
                    break;
                case 2:
                    brackets = "<>";
                    break;
                case 3:
                    brackets = "{}";
                    break;
            }

            // Вывод ответа 
            Console.WriteLine($"\nСледующий символ: {brackets[0]}{nextSymbol}{brackets[1]}");
        }
    }
}
