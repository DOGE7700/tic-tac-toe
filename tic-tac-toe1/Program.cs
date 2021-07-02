using System;
namespace tic_tac_toe
{
    class Program
    {
        public static int NoWin = 0;
        public static string x1, x2, x3, x4, x5, x6, x7, x8, x9, o1, o2, o3, o4, o5, o6, o7, o8, o9 = " ";
        static void Main(string[] args)
        {
            Console.WriteLine("1 |2 |3");
            Console.WriteLine("__|__|__");
            Console.WriteLine("4 |5 |6");
            Console.WriteLine("__|__|__");
            Console.WriteLine("7 |8 |9");
            Console.WriteLine("Крестики ходят первыми. Выберите номер клетки.");
            GameChooseX();
        }
        public static void DrawGame()
        {
            Console.WriteLine($"{x1}{o1} |{x2}{o2} |{x3}{o3}");
            Console.WriteLine("___|___|___");
            Console.WriteLine($"{x4}{o4} |{x5}{o5} |{x6}{o6}");
            Console.WriteLine("___|___|___");
            Console.WriteLine($"{x7}{o7} |{x8}{o8} |{x9}{o9}");
        }
        public static void GameChooseX()
        {
            string chooseX = Console.ReadLine();


            switch (chooseX)
            {
                case "1":
                    {
                        if (o1 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        if (x1 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        else
                        {
                            x1 = "X";
                            GameChooseX_Method();
                        }

                        break;
                    }

                case "2":
                    {
                        if (o2 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        if (x2 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        else
                        {
                            x2 = "X";
                            GameChooseX_Method();
                        }

                        break;
                    }

                case "3":
                    {
                        if (o3 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        if (x3 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        else
                        {
                            x3 = "X";
                            GameChooseX_Method();
                        }

                        break;
                    }

                case "4":
                    {
                        if (o4 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        if (x4 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        else
                        {
                            x4 = "X";
                            GameChooseX_Method();
                        }

                        break;
                    }

                case "5":
                    {
                        if (o5 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        if (x5 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        else
                        {
                            x5 = "X";
                            GameChooseX_Method();
                        }

                        break;
                    }

                case "6":
                    {
                        if (o6 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        if (x6 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        else
                        {
                            x6 = "X";
                            GameChooseX_Method();
                        }

                        break;
                    }

                case "7":
                    {
                        if (o7 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        if (x7 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        else
                        {
                            x7 = "X";
                            GameChooseX_Method();
                        }

                        break;
                    }

                case "8":
                    {
                        if (o8 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        if (x8 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        else
                        {
                            x8 = "X";
                            GameChooseX_Method();
                        }

                        break;
                    }

                case "9":
                    {
                        if (o9 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        if (x9 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseX();
                        }
                        else
                        {
                            x9 = "X";
                            GameChooseX_Method();
                        }

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Выберите число от 1 до 9");
                        GameChooseX();
                        break;
                    }

            }

        }
        public static void GameChooseO()
        {
            string chooseO = Console.ReadLine();


            switch (chooseO)
            {

                case "1":
                    {
                        if (x1 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        if (o1 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        else
                        {
                            o1 = "O";
                            GameChooseO_Method();
                        }

                        break;
                    }

                case "2":
                    {
                        if (x2 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        if (o2 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        else
                        {
                            o2 = "O";
                            GameChooseO_Method();
                        }

                        break;
                    }

                case "3":
                    {
                        if (x3 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        if (o3 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        else
                        {
                            o3 = "O";
                            GameChooseO_Method();
                        }

                        break;
                    }

                case "4":
                    {
                        if (x4 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        if (o4 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        else
                        {
                            o4 = "O";
                            GameChooseO_Method();
                        }

                        break;
                    }

                case "5":
                    {
                        if (x5 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        if (o5 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        else
                        {
                            o5 = "O";
                            GameChooseO_Method();
                        }

                        break;
                    }

                case "6":
                    {
                        if (x6 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        if (o6 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        else
                        {
                            o6 = "O";
                            GameChooseO_Method();
                        }

                        break;
                    }

                case "7":
                    {
                        if (x7 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        if (o7 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        else
                        {
                            o7 = "O";
                            GameChooseO_Method();
                        }

                        break;
                    }

                case "8":
                    {
                        if (x8 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        if (o8 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        else
                        {
                            o8 = "O";
                            GameChooseO_Method();
                        }

                        break;
                    }

                case "9":
                    {
                        if (x9 == "X")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        if (o9 == "O")
                        {
                            Console.WriteLine("Это место занято, выберите другое.");
                            GameChooseO();
                        }
                        else
                        {
                            o9 = "O";
                            GameChooseO_Method();
                        }

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Выберите число от 1 до 9");
                        GameChooseO();
                        break;
                    }
            }

        }
        public static void GameChooseX_Method()
        {
            WinX();
            ++NoWin;
            DrawGame();
            Draw();
            Console.WriteLine("Теперь ход ноликов. Выберите клетку.");
            GameChooseO();
        }
        public static void GameChooseO_Method()
        {
            WinO();
            ++NoWin;
            DrawGame();
            Draw();
            Console.WriteLine("Теперь ход крестиков. Выберите клетку.");
            GameChooseX();
        }
        static void WinX()
        {
            if (x1 == "X")
            {
                if (x2 == "X")
                {
                    if (x3 == "X")
                    {
                        Console.WriteLine("Крестики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (x4 == "X")
            {
                if (x5 == "X")
                {
                    if (x6 == "X")
                    {
                        Console.WriteLine("Крестики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (x7 == "X")
            {
                if (x8 == "X")
                {
                    if (x9 == "X")
                    {
                        Console.WriteLine("Крестики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (x1 == "X")
            {
                if (x4 == "X")
                {
                    if (x7 == "X")
                    {
                        Console.WriteLine("Крестики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (x2 == "X")
            {
                if (x5 == "X")
                {
                    if (x8 == "X")
                    {
                        Console.WriteLine("Крестики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (x3 == "X")
            {
                if (x6 == "X")
                {
                    if (x9 == "X")
                    {
                        Console.WriteLine("Крестики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (x1 == "X")
            {
                if (x5 == "X")
                {
                    if (x9 == "X")
                    {
                        Console.WriteLine("Крестики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (x3 == "X")
            {
                if (x5 == "X")
                {
                    if (x7 == "X")
                    {
                        Console.WriteLine("Крестики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
        }
        static void WinO()
        {
            if (o1 == "O")
            {
                if (o2 == "O")
                {
                    if (o3 == "O")
                    {
                        Console.WriteLine("Нолики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (o4 == "O")
            {
                if (o5 == "O")
                {
                    if (o6 == "O")
                    {
                        Console.WriteLine("Нолики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (o7 == "O")
            {
                if (o8 == "O")
                {
                    if (o9 == "O")
                    {
                        Console.WriteLine("Нолики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (o1 == "O")
            {
                if (o4 == "O")
                {
                    if (o7 == "O")
                    {
                        Console.WriteLine("Нолики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (o2 == "O")
            {
                if (o5 == "O")
                {
                    if (o8 == "O")
                    {
                        Console.WriteLine("Нолики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (o3 == "O")
            {
                if (o6 == "O")
                {
                    if (o9 == "O")
                    {
                        Console.WriteLine("Нолики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (o1 == "O")
            {
                if (o5 == "O")
                {
                    if (o9 == "O")
                    {
                        Console.WriteLine("Нолики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (o3 == "O")
            {
                if (o5 == "O")
                {
                    if (o7 == "O")
                    {
                        Console.WriteLine("Нолики победили! Нажмите любую клавишу чтобы выйти.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
        }
        public static void Draw()
        {
            if (NoWin == 9)
            {
                Console.WriteLine("Ничья! Нажмите любую клавишу чтобы выйти.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}

//что добавить:
//!ничью через добавление NoWin++ за каждый успешный ход!+
//!!!запрет ставить свой знак на уже поставленный свой знак!!!+