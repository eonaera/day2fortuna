using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace day2fortuna
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChoosePerson(); //пример от Ленчика
            //Riddles(); //классическое задание
            //Fortuna(); //проверка на удачу через иф
            Fortunafor(); //версия проверки на удачу через цикл
        }
        static void ChoosePerson()
        {
            List<string> list = new List<string>() { "Леший", "Вера", "Шакира", "Конь" };
            var random = new Random();
            Console.WriteLine(list[random.Next(list.Count)]);
        }
        static void Riddles()
        {
            Console.WriteLine("Hi. Are you ready? yes/no");
            string answ0 = Console.ReadLine();
            bool rightansw0 = answ0 == "yes";
            if (rightansw0)
            {
                int rcount;
                string answ;
                bool rightansw;
                Console.WriteLine("Okay. \n 1. I make two people out of one. What am I? \t");
                answ = Console.ReadLine();
                rightansw = answ == "mirror";
                if (rightansw)
                {
                    rcount = 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    rcount = 0;
                    Console.WriteLine("Sorry. The right answer is a mirror");
                }
                Console.WriteLine($"- answers:" + rcount + ". Next riddle:");
                Console.WriteLine("2. David's father has three sons: Snap, Crackle, and _____?");
                answ = Console.ReadLine();
                rightansw = answ == "David";
                if (rightansw)
                {
                    rcount = rcount + 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    Console.WriteLine("Sorry. The right answer is David");
                }
                Console.WriteLine($"- answers:" + rcount + ". Next riddle:");
                Console.WriteLine("3. What runs without legs?");
                answ = Console.ReadLine();
                rightansw = answ == "water";
                if (rightansw)
                {
                    rcount = rcount + 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    Console.WriteLine("Sorry. The right answer is water");
                }
                Console.WriteLine($"- answers:" + rcount + ". Next riddle:");
                Console.WriteLine("4. What has six faces, but does not wear makeup, has twenty-one eyes, but cannot see? What is it?");
                answ = Console.ReadLine();
                rightansw = answ == "dice";
                if (rightansw)
                {
                    rcount = rcount + 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    Console.WriteLine("Sorry. The right answer is dice");
                }
                Console.WriteLine($"- answers:" + rcount + ". Next riddle:");
                Console.WriteLine("5. What 7 letter word is spelled the same way backwards and forwards?");
                answ = Console.ReadLine();
                rightansw = answ == "racecar";
                if (rightansw)
                {
                    rcount = rcount + 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    Console.WriteLine("Sorry. The right answer is racecar");
                }
                Console.WriteLine($"- answers:" + rcount + ". Next riddle:");
                Console.WriteLine("6. What is it that given one, you'll have either two or none?");
                answ = Console.ReadLine();
                rightansw = answ == "choice";
                if (rightansw)
                {
                    rcount = rcount + 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    Console.WriteLine("Sorry. The right answer is a choice");
                }
                Console.WriteLine($"- answers:" + rcount + ". Next riddle:");
                Console.WriteLine("7. You can see it everyday, But cannot touch it at will. What is it?");
                answ = Console.ReadLine();
                rightansw = answ == "sky";
                if (rightansw)
                {
                    rcount = rcount + 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    Console.WriteLine("Sorry. The right answer is sky");
                }
                Console.WriteLine($"- answers:" + rcount + ". Next riddle:");
                Console.WriteLine("8. I'm a god, a planet, and measurer of heat. Who I am?");
                answ = Console.ReadLine();
                rightansw = answ == "Mercury";
                if (rightansw)
                {
                    rcount = rcount + 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    Console.WriteLine("Sorry. The right answer is Mercury");
                }
                Console.WriteLine($"- answers:" + rcount + ". Next riddle:");
                Console.WriteLine("9. The more you take, the more you leave behind. What am I?");
                answ = Console.ReadLine();
                rightansw = answ == "footsteps";
                if (rightansw)
                {
                    rcount = rcount + 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    Console.WriteLine("Sorry. The right answer is footsteps");
                }
                Console.WriteLine($"- answers:" + rcount + ". Next riddle:");
                Console.WriteLine("10. What has a head, a tail, is brown, and has no legs?");
                answ = Console.ReadLine();
                rightansw = answ == "penny";
                if (rightansw)
                {
                    rcount = rcount + 1;
                    Console.WriteLine("Right!");
                }
                else
                {
                    Console.WriteLine("Sorry. The right answer is a penny");
                }
                Console.WriteLine($"Your results:" + rcount);
                Console.WriteLine("Do you like the riddle? I don't ask. You like them! Bye-bye!");
            }
            else
            {
                Console.WriteLine("Okay, guy. Go away!");
            }
        }
        static void Fortuna()
        {
            int fortunecount = 0;
            bool bansw;
            List<string> ransw = new List<string>() { "1", "2", "3", "4", "5"};
            var random = new Random();
            Console.WriteLine("Hey! I want to check your fortuna. Tell me a number from 1 to 5");
            string answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            answ = Console.ReadLine();
            if (bansw = answ == ransw[random.Next(ransw.Count)])
            {
                Console.WriteLine("Good! One more:");
                fortunecount = fortunecount+1;
            }
            else
            {
                Console.WriteLine("Looser! Try more:");
            }
            Console.Write($"End. Your fortune is "+fortunecount+" from 10. ");
            if (fortunecount < 4)
            {
                Console.Write("So so you good luck gentleman. ");
            }
            else if (fortunecount > 7)
            {
                Console.Write("Share me, please. ");
            }
            else
            {
                Console.Write("You can live with such luck. ");
            }
        }
        static void Fortunafor()
        {
            int fortunecount = 0;
            bool bansw;
            List<string> ransw = new List<string>() { "1", "2", "3", "4", "5" };
            var random = new Random();
            Console.WriteLine("Hey! I want to check your fortuna. Tell me a number from 1 to 5");
            for (int i = 0; i < 10; i++)
            {
                string answ = Console.ReadLine();
                if (bansw = answ == ransw[random.Next(ransw.Count)])
                {
                    Console.WriteLine("Good! One more:");
                    fortunecount = fortunecount + 1;
                }
                else
                {
                    Console.WriteLine("Looser! Try more:");
                }
            }
            Console.Write($"End. Your fortune is " + fortunecount + " from 10. ");
            if (fortunecount < 4)
            {
                Console.Write("bad luck gentleman =( ");
            }
            else if (fortunecount > 7)
            {
                Console.Write("Share me, please. ");
            }
            else
            {
                Console.Write("You can live with such luck. ");
            }
        }
    }
}
