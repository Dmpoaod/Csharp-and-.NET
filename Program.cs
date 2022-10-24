using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Zad1
{
    class Program
    {
        
        public static string patternText = @"^[a-zA-Z ]{2,}";
        public static Regex reg = new Regex(patternText);
        
        // static int removeWS(char[] str)
        // {
        //     int cnt = 0;
        //     for (int i = 0; i < str.Length; i++)
        //     {
        //         if (str[i] != ' ')
        //         {
        //             str[cnt++] = str[i]; 
        //         }
        //     }
        //     return cnt;
        // }
        //
        // static bool validateName(char[] str)
        // {
        //     bool res = true;
        //     int spcCount = 0;
        //     if (str.Length < 2)
        //     {
        //         res = false;
        //         return res;
        //     }
        //     else
        //     {
        //         for (int i = 0; i < str.Length; i++)
        //         {
        //             if (str[i].Equals(' '))
        //             {
        //                 spcCount++;
        //             }
        //             if (!Char.IsLetter(str[i]) || !str[i].Equals(' '))
        //             {
        //                 res = false;
        //                 return res;
        //             }
        //         }
        //
        //         if (str.Length - spcCount < 2)
        //         {
        //             res = false;
        //             return res;
        //         }
        //         
        //     }
        //     return res;
        // }

        static bool validate(string str)
        {
            bool res = false;

            if (reg.IsMatch(str))
            {
                res = true;
            }

            return res;
        }
        
        
        static void Main(string[] args)
        {
            string firstOption;
            string heroName;
            Console.WriteLine("Witaj w grze Pierwsza Przygoda\n");
            Console.WriteLine("[1] Zacznij nową grę\n");
            Console.WriteLine("[X] Zamknij program\n");
            firstOption = Console.ReadLine();
            if (String.Equals(firstOption, "X") || String.Equals(firstOption, "x"))
            {
                System.Environment.Exit(0); 
            } else if (String.Equals(firstOption, "1"))
            {
                Console.Clear();
                Console.WriteLine("Podaj imię bohatera");
                heroName = Console.ReadLine();
                heroName.Trim();
                while (validate(heroName) == false)
                {
                    Console.WriteLine("Imię niepoprwne, wpisz ponownie");
                    heroName = Console.ReadLine();
                }

            }
            
        }
    }
}

