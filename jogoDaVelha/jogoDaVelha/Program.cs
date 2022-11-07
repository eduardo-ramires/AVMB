using System.Diagnostics;

namespace jogoDaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] tabela = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            int op = 0, cont = 0, i = 0, j = 0;
            int final = 0;

            for (i = 0; i < 3; i++)
            {
                for ( j = 0; j < 3; j++)
                {
                    Console.Write(tabela[i, j] + " ");
                }
                Console.Write("\n");
            }

            while (final != 1)
            {

                Console.WriteLine("Digite o local desejado jopgador 01:");
                op = int.Parse(Console.ReadLine());

                switch (op) {
                    case 1:
                        if (tabela[0, 0] != "O") 
                        {
                            tabela[0, 0] = "X";
                        }
                         break;

                    case 2:
                        if (tabela[0, 1] != "O")
                        {
                            tabela[0, 1] = "X";
                        }
                        break;

                    case 3:
                        if (tabela[0, 2] != "O")
                        {
                            tabela[0, 2] = "X";
                        }
                        break;

                    case 4:
                        if (tabela[1, 0] != "O")
                        {
                            tabela[1, 0] = "X";
                        }
                        break;

                    case 5:
                        if (tabela[1, 1] != "O")
                        {
                            tabela[1, 1] = "X";
                        }
                        break;

                    case 6:
                        if (tabela[1, 2] != "O")
                        {
                            tabela[1, 2] = "X";
                        }
                        break;

                    case 7:
                        if (tabela[2, 0] != "O")
                        {
                            tabela[2, 0] = "X";
                        }
                        break;

                    case 8:
                        if (tabela[2, 1] != "O")
                        {
                            tabela[2, 1] = "X";
                        }
                        break;

                    case 9:
                        if (tabela[2, 2] != "O")
                        {
                            tabela[2, 2] = "X";
                        }
                        break;

                }

                for (j = 0; j<3; j++)
                {
                    for (i = 0; i < 3; i++)
                    {
                        if (tabela[i, j] == "X")
                        {
                            cont++;
                        }
                    }
                    if (cont == 3)
                    {
                        Console.WriteLine("Jogador 01 ganhou");
                        final = 1;
                    }
                    cont = 0;
                }
                cont = 0;

                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (tabela[i, j] == "X")
                        {
                            cont++;
                        }
                    }
                    if (cont == 3)
                    {
                        Console.WriteLine("Jogador 01 ganhou");
                        final = 1;
                    }
                    cont = 0;
                }

                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (tabela[i, j] == "X" || tabela[i, j] == "O")
                        {
                            cont++;
                        }
                    }
                }
                if (cont == 9)
                {
                    Console.WriteLine("Jogo empatado");
                    final = 1;
                }
                cont = 0;

                if (tabela[0, 0] == "X" && tabela[1, 1] == "X" && tabela[2, 2] == "X")
                {
                    Console.WriteLine("Jogador 01 ganhou");
                    final = 1;
                }

                if (tabela[0, 2] == "X" && tabela[1, 1] == "X" && tabela[2, 0] == "X")
                {
                    Console.WriteLine("Jogador 01 ganhou");
                    final = 1;
                }

                cont = 0;

                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.Write(tabela[i, j] + " ");
                    }
                    Console.Write("\n");
                }

                if (final == 0)
                {


                    Console.WriteLine("Digite o local desejado jogador 02:");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            if (tabela[0, 0] != "X")
                            {
                                tabela[0, 0] = "O";
                            }
                            break;

                        case 2:
                            if (tabela[0, 1] != "X")
                            {
                                tabela[0, 1] = "O";
                            }
                            break;

                        case 3:
                            if (tabela[0, 2] != "X")
                            {
                                tabela[0, 2] = "O";
                            }
                            break;

                        case 4:
                            if (tabela[1, 0] != "X")
                            {
                                tabela[1, 0] = "O";
                            }
                            break;

                        case 5:
                            if (tabela[1, 1] != "X")
                            {
                                tabela[1, 1] = "O";
                            }
                            break;

                        case 6:
                            if (tabela[1, 2] != "X")
                            {
                                tabela[1, 2] = "O";
                            }
                            break;

                        case 7:
                            if (tabela[2, 0] != "X")
                            {
                                tabela[2, 0] = "O";
                            }
                            break;

                        case 8:
                            if (tabela[2, 1] != "X")
                            {
                                tabela[2, 1] = "O";
                            }
                            break;

                        case 9:
                            if (tabela[2, 2] != "X")
                            {
                                tabela[2, 2] = "O";
                            }
                            break;

                    }

                    for (j = 0; j < 3; j++)
                    {
                        for (i = 0; i < 3; i++)
                        {
                            if (tabela[i, j] == "O")
                            {
                                cont++;
                            }
                        }
                        if (cont == 3)
                        {
                            Console.WriteLine("Jogador 02 ganhou");
                            final = 1;
                        }
                        cont = 0;
                    }
                    cont = 0;

                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (tabela[i, j] == "O")
                            {
                                cont++;
                            }
                        }
                        if (cont == 3)
                        {
                            Console.WriteLine("Jogador 02 ganhou");
                            final = 1;
                        }
                        cont = 0;
                    }
                    cont = 0;

                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (tabela[i, j] == "X" || tabela[i, j] == "O")
                            {
                                cont++;
                            }
                        }
                    }
                    if (cont == 9)
                    {
                        Console.WriteLine("Jogo empatado");
                        final = 1;
                    }
                    cont = 0;

                    if (tabela[0, 0] == "O" && tabela[1, 1] == "O" && tabela[2, 2] == "O")
                    {
                        Console.WriteLine("Jogador 02 ganhou");
                        final = 1;
                    }

                    if (tabela[0, 2] == "O" && tabela[1, 1] == "O" && tabela[2, 0] == "O")
                    {
                        Console.WriteLine("Jogador 02 ganhou");
                        final = 1;
                    }

                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            Console.Write(tabela[i, j] + " ");
                        }
                        Console.Write("\n");
                    }
                }
            }

        }
    }
}