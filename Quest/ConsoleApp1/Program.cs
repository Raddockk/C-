﻿using System;
namespace TextAdventureGame
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вы просыпаетесь в темной комнате и не помните, как сюда попали.");
            Console.WriteLine(" Вы видите перед собой две двери: одна зеленая - 1, другая красная - 2. ");
            Console.WriteLine("Выберите, какую дверь открыть: 1 или 2 или остаться на месте (3)");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                {
                        Console.WriteLine("Вы зашли в комнату с зеленой дверью?");
                        Console.WriteLine("Вы видите перед собой сундук, который вы можете открыть");
                        Console.WriteLine("Попытаться разбить крышку сундука (закосить под Кратоса) - 1 или попытаться отодвинуть крышку сундука - 2");


                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            Console.WriteLine("Видимо сундук простоял здесь не один десяток лет и весь прогнил");
                            Console.WriteLine("Поэтому вы ловким ударом руки разбивыете крышку");
                            Console.WriteLine("Внутри лежат щит и меч");
                            Console.WriteLine("Однако и вы не Бог Войны, поэтому получаете сильный ушиб кисти, из-за чего не можете держать в ней предметы");
                            Console.WriteLine("Выберите, что вы хотите взять: щит - 1 или меч - 2");

                            input = Console.ReadLine();

                            if (input == "1")
                            {
                                Console.WriteLine("Вы взяли щит и решаете вернуться обратно");
                                Console.WriteLine("Вернувшись вы решаете открыть оставшуюся дверь");
                                Console.WriteLine("Зайдя в комнату вы слышите странное шипение в противоположном углу");
                                Console.WriteLine("Приглядевшись, вы обнаруживаете молодую особь виверны");
                                Console.WriteLine("Она набрасывается на вас, но вы успеваете защититься щитом");
                                Console.WriteLine("Вспомнив уроки фехтования, вы машинально пытаетесь нанести ей удар мечом, забыв, что у вас его нет");
                                Console.WriteLine("Виверна хватает лапами вашу руку и разрывает вас");
                                Console.WriteLine("Игра окончена, вы проиграли");

                                input = Console.ReadLine();                                
                            }

                            else if (input == "2")
                            {
                                Console.WriteLine("Вы взяли меч и решаете вернуться обратно");
                                Console.WriteLine("Вернувшись вы решаете открыть оставшуюся дверь");
                                Console.WriteLine("Зайдя в комнату вы слышите странное шипение в противоположном углу");
                                Console.WriteLine("Приглядевшись, вы обнаруживаете молодую особь виверны");
                                Console.WriteLine("Она набрасывается на вас, но вы успеваете парировать ее удар мечом");
                                Console.WriteLine("Спустя несколько минут ожесточенного боя, вы побеждаете в схватке");
                                Console.WriteLine("Еле стоя на ногах, вы выходите из незнакомого вам помещения и падаете на землю около выхода");
                                Console.WriteLine("Последнее, что вы помните, как группа людей подобрала вас");

                                input = Console.ReadLine();
                            }
                        }
                            else if (input == "2")
                            {
                                Console.WriteLine("С большим трудом, но вы все же смогли сдвинуть дубовую крышку сундука");
                                Console.WriteLine("С глухим звуком она падает на пол");
                                Console.WriteLine("Внутри лежат щит и меч");
                                Console.WriteLine("Выберите, что хотите взять: щит - 1, меч - 2 или щит и меч - 3");

                                input = Console.ReadLine();

                                    if (input == "1") 
                                    {
                                        Console.WriteLine("Вы взяли щит и решаете вернуться обратно");
                                        Console.WriteLine("Вернувшись вы решаете открыть оставшуюся дверь");
                                        Console.WriteLine("Зайдя в комнату вы слышите странное шипение в противоположном углу");
                                        Console.WriteLine("Приглядевшись, вы обнаруживаете молодую особь виверны");
                                        Console.WriteLine("Она набрасывается на вас, но вы успеваете защититься щитом");
                                        Console.WriteLine("Вспомнив уроки фехтования, вы машинально пытаетесь нанести ей удар мечом, забыв, что у вас его нет");
                                        Console.WriteLine("Виверна хватает лапами вашу руку и разрывает вас");
                                        Console.WriteLine("Игра окончена, вы проиграли");

                                        input = Console.ReadLine();
                                    }

                                    else if (input == "2")
                                    {
                                        Console.WriteLine("Вы взяли меч и решаете вернуться обратно");
                                        Console.WriteLine("Вернувшись вы решаете открыть оставшуюся дверь");
                                        Console.WriteLine("Зайдя в комнату вы слышите странное шипение в противоположном углу");
                                        Console.WriteLine("Приглядевшись, вы обнаруживаете молодую особь виверны");
                                        Console.WriteLine("Она набрасывается на вас, но вы успеваете парировать ее удар мечом");
                                        Console.WriteLine("Спустя несколько минут ожесточенного боя, вы побеждаете в схватке");
                                        Console.WriteLine("Еле стоя на ногах, вы выходите из незнакомого вам помещения и падаете на землю около выхода");
                                        Console.WriteLine("Последнее, что вы помните, как группа людей подобрала вас");

                                        input = Console.ReadLine();
                                    }

                                    else if (input == "3")
                                    {
                                        Console.WriteLine("Вы взяли щит с мечом и решаете вернуться обратно");
                                        Console.WriteLine("Вернувшись вы решаете открыть оставшуюся дверь");
                                        Console.WriteLine("Зайдя в комнату вы слышите странное шипение в противоположном углу");
                                        Console.WriteLine("Приглядевшись, вы обнаруживаете молодую особь виверны");
                                        Console.WriteLine("Она набрасывается на вас, но вы успеваете защититься щитом");
                                        Console.WriteLine("Вспомнив уроки фехтования, вы машинально наносите ей удар мечом в брюхо");
                                        Console.WriteLine("Спустя непродолжительное время, вы одерживаете победу, получив лишь пару царапин");
                                        Console.WriteLine("Вы выходите из незнакомого вам помещения, солнечный свет бьет вам в лицо");
                                        Console.WriteLine("Игра окончена, вы победили");

                                        input = Console.ReadLine();
                                    }
                            }

                                
                        break;
                }

                case "2":
                    {
                        Console.WriteLine("Вы заходите в комнату с красной дверью");
                        Console.WriteLine("Зайдя в комнату вы слышите странное шипение в противоположном углу");
                        Console.WriteLine("Приглядевшись, вы обнаруживаете молодую особь виверны");
                        Console.WriteLine("Она набрасывается на вас, и вы пытаетесь защититься от ее атаки, закрыв лицо руками");
                        Console.WriteLine("Удивительно, но это вам не помогает, и одним движением виверна разрывает вас");
                        Console.WriteLine("Игра окончена, вы проиграли");
                    }
                    break;

                    case "3":
                    {
                        Console.WriteLine("Вы слишком напуганы, поэтому просто забились в угол, свернувшись колачиком, и не стали никуда идти.");
                    }
                    break;
            }

            
        }
    }
}