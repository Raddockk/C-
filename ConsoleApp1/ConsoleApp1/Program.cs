using System;
namespace TextAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты находишься в темной комнате. Перед тобой две двери.");
            Console.WriteLine(" Выбери дверь: 1 или 2?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                {
                        Console.WriteLine("Вы выбрали первую дверь, но она оказалась закрытой. Что будете делать?");
                        Console.WriteLine("1. Искать ключ или 2. Открыть дверь 2");

                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            Console.WriteLine("Спустя пол часа вам все таки удалось отыскать ключ.");
                            Console.WriteLine("Вы открываете дверь и оказываетесь у выхода");
                            Console.WriteLine("Игра окончена");
                        }
                            else if (input == "2")
                            {
                                Console.WriteLine("Вы решили, что поиск ключа - пустая трата времени и вошли во 2 дверь");
                                Console.WriteLine("Вы спускаетесь все глубже вниз, с каждым шагом все больше погружаясь во тьму");
                                Console.WriteLine("Дойдя до развилки, тускло освещенную еще чудом не погасшей лампой, вы задумались, куда бы пойти");
                                Console.WriteLine("Пойти 1. налево или 2. направо");

                                input = Console.ReadLine();

                                if (input == "1")
                                {
                                    Console.WriteLine("Вы повернули налево");
                                    Console.WriteLine("Из-за непроглядной тьмы вы не увидели обрыв и полетели вниз");
                                    Console.WriteLine("Игра окончена");

                                    input = Console.ReadLine();
                                }
                                else if (input == "2") {
                                    Console.WriteLine("Вы пошли направо и вскоре увидели вдали лучь света");
                                    Console.WriteLine("Подходя все ближе вы все отчетливее видите, что это выход");
                                    Console.WriteLine("Протиснувшись сквозь узкий проход, вы наконец вышли на свежий воздух");
                                    Console.WriteLine("Игра окончена");

                                    input = Console.ReadLine();
                                }
                             }

                                
                        break;
                }

                case "2":
                    {

                        Console.WriteLine("Вы выбрали 2 дверь");
                        Console.WriteLine("Вы спускаетесь все глубже вниз, с каждым шагом все больше погружаясь во тьму");
                        Console.WriteLine("Дойдя до развилки, тускло освещенную еще чудом не погасшей лампой, вы задумались, куда бы пойти");
                        Console.WriteLine("Пойти 1. налево или 2. направо");
                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            Console.WriteLine("Вы повернули налево");
                            Console.WriteLine("Из-за непроглядной тьмы вы не увидели обрыв и полетели вниз");
                            Console.WriteLine("Игра окончена");

                            input = Console.ReadLine();
                        }
                        else if (input == "2")
                        {
                            Console.WriteLine("Вы пошли направо и вскоре увидели вдали лучь света");
                            Console.WriteLine("Подходя все ближе вы все отчетливее видите, что это выход");
                            Console.WriteLine("Протиснувшись сквозь узкий проход, вы наконец вышли на свежий воздух");
                            Console.WriteLine("Игра окончена");

                            input = Console.ReadLine();
                        }
                    }
                    break;
            }

            
        }
    }
}