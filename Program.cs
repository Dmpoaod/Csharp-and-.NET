using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        void NpcDialogPartStartTalking()
                     {
                         
                     }
    }

    public class Location
    {
        public string locationName;
        public NonPlayerCharacter[] NPCList = new NonPlayerCharacter[10];

        public Location(string name, NonPlayerCharacter[] NpcList)
        {
            locationName = name;
            NPCList = NpcList;
        }
    }

    public class DialogParser
    {
        
    }

    public class NpcDialogPart
    {
         string[] NpcDiag = new string[]
        {
            "Witaj, czy możesz mi pomóc dostać się do innego miasta?", "Dziękuję! W nagrodę otrzymasz ode mnie 100 sztuk złota", "Niestety nie mam więcej. Jestem bardzo biedny", "Dziękuję",
            "Witaj, czy chcesz coś kupić?", "Oto one", "70 sztuk złota", "Nie zejdę niżej niż 50", "Do zobaczenia"
        };
        
         string[] HDiag = new string[]
         {
             "Tak, chętnie pomogę", "„Dam znać jak będę gotowy", "100 sztuk złota to za mało!", "OK, może być 100 sztuk złota", "W takim razie radź sobie sam.", "Nie, nie pomogę, żegnaj",
             "Chciałbym zobaczyć twoje towary", "Ile za to?", "To za drogo. Mogę dać 30.", "Uczciwa cena. Kupuję.", "Nie zapłacę tyle", "Żegnaj"
         };
         

    }

    public class HeroDialogPart
    {
        string[] HDiag = new string[]
        {
            "Tak, chętnie pomogę", "„Dam znać jak będę gotowy", "100 sztuk złota to za mało!", "OK, może być 100 sztuk złota", "W takim razie radź sobie sam.", "Nie, nie pomogę, żegnaj",
            "Chciałbym zobaczyć twoje towary", "Ile za to?", "To za drogo. Mogę dać 30.", "Uczciwa cena. Kupuję.", "Nie zapłacę tyle", "Żegnaj"
        };
    }
    
    class Program
    {
        void ShowLocation(Location location)
        {
        
        }

    
        
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

                NonPlayerCharacter[] npclist = new NonPlayerCharacter[]
                    { new NonPlayerCharacter("Akara"), new NonPlayerCharacter("Cain") };

                Location loc = new Location("Neverwinter", npclist);
                
                Console.WriteLine("Znajdujesz się w: " + loc.locationName + ". Co chcesz zrobić?");
                Console.WriteLine("[1] Porozmawiaj z " + npclist[0].name + ".");
                Console.WriteLine("[2] Porozmawiaj z " + npclist[1].name + ".");
                Console.WriteLine("[X] Zamknij program.");
                firstOption = Console.ReadLine();
                if (String.Equals(firstOption, "X") || String.Equals(firstOption, "x"))
                {
                    System.Environment.Exit(0); 
                } else if (String.Equals(firstOption, "1"))
                {
                    
                } else if (String.Equals(firstOption, "2"))
                {
                    
                }




            }
            
        }
    }
}

