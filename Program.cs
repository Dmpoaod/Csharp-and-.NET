using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Zad1
{
    public enum EHeroClass
        {
            barbarzyńca, 
            paladyn, 
            amazonka,
        }
    public class Hero
    {
        public string name;
        public EHeroClass Class;

        public Hero(string Hname, EHeroClass HClass)
        {
            name = Hname;
            Class = HClass;
        }
        
    }

    public class NonPlayerCharacter
    {
        public string name;

        public NonPlayerCharacter(string NPCname)
        {
            name = NPCname;
        }
    }

    public class NpcDialogPart
    {
        
    }

    public class HeroDialogPart
    {
        
    }
    
    class Program
    {
        
        public static string patternText = @"^[a-zA-Z ]{2,}";
        public static Regex reg = new Regex(patternText);
        
       
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
            Console.WriteLine("Witaj w grze Pierwsza Przygoda");
            Console.WriteLine("[1] Zacznij nową grę");
            Console.WriteLine("[X] Zamknij program");
            firstOption = Console.ReadLine();
            if (String.Equals(firstOption, "X") || String.Equals(firstOption, "x"))
            {
                System.Environment.Exit(0); 
            } else if (String.Equals(firstOption, "1"))
            {
                Console.Clear();
                Console.WriteLine("Podaj imię bohatera");
                heroName = Console.ReadLine();
                heroName = heroName.Trim();
                while (validate(heroName) == false)
                {
                    Console.WriteLine("Imię niepoprwne, wpisz ponownie");
                    heroName = Console.ReadLine();
                }
                
                Console.WriteLine("Witaj "+ heroName +". Wybierz klasę postaci. Dostępne klasy: ");
                Console.WriteLine("[1] Barbarzyńca");
                Console.WriteLine("[2] Paladyn");
                Console.WriteLine("[3] Amazonka");
                string input = Console.ReadLine();
                EHeroClass HClass = EHeroClass.barbarzyńca;
                if (input.Equals("1"))
                {
                    HClass = EHeroClass.barbarzyńca;
                } else if (input.Equals("2"))
                {
                    HClass = EHeroClass.paladyn;
                } else if (input.Equals("3"))
                {
                    HClass = EHeroClass.amazonka;
                }
                
                Hero hero = new Hero(heroName, HClass);
                Console.Clear();
                Console.WriteLine(hero.Class + " " + hero.name + " wyrusza na przygodę");


            }
            
        }
    }
}

