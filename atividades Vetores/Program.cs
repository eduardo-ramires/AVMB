using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace atividade01Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 01 vetores
            /*
            int imp = 0, par = 0;

            int[] vetor = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um valor para o vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            

            for (int i = 0; i < 3; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    imp++;
                }
            }

            Console.WriteLine(imp + " Eram impares");
            Console.WriteLine(par + " Eram pares");*/






            //Atividade 02 vetor
            /*
            int[] vetorA = new int[3];
            int[] vetorB = new int[3];
            int[] vetorC = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um valor para o vetor A");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um valor para o vetor B");
                vetorB[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                vetorC[i] = vetorA[i] + vetorB[i];
                Console.WriteLine(vetorC[i]);
            }*/











            //Atividade 03 vetores
            /*
            int cont = 0, num;
            int[] vetor = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um valor para o vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                for (int a = 1; a <= vetor[i]; a++)
                {
                    if (vetor[i] % a == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2)
                {
                    Console.WriteLine(vetor[i]);
                    Console.WriteLine(i);
                }
                cont = 0;
            }*/








            //atividade04 vetores
            /*
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            int[] vetorC = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero para op vetor A");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero para op vetor B");
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            { 
                vetorC[i] = vetorA[i] * vetorB[i];
                Console.WriteLine(vetorC[i]);
            }
            */





            //atividade 05 vetores
            /*
            int[] vetor = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero para o veotor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            int menor = vetor[0], posicao = 0;

            for (int i = 1; i < 5; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    posicao = i;
                }
            }
            Console.WriteLine("O menor numero é o: " + menor + " que esta na posição " + posicao);*/









            //Atividade 06 vetores
            /*
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero para o vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 9;  i >= 0; i--)
            {
                Console.Write(vetor[i]);
            }*/







            //atividade 07 vetores
            /*
            int[] vetor = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero para o vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numeros pares:");
            for (int i = 9; i >= 0; i--)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.Write(vetor[i]);
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Numeros impares");
            for (int i = 9; i >= 0; i--)
            {
                if (vetor[i] % 2 !=0)
                {
                    Console.Write(vetor[i]);
                }
            }*/







            //Atividade 08 vetores
            /*
            float[] vetor = new float[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite um numero para o vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if(vetor[i] < 0)
                {
                    Console.WriteLine("O numero "+ vetor[i] +" é menor que zero e esta na posição "+i);
                }
            }*/








            //atividade 09 vetores
            /*


            int i, j, aux = 0;
            int[] vetor = new int[10];


            //Preencher
            Console.WriteLine("Preencha o Vetor com valores aleatórios");
            for (i = 0; i < 10; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine();

            //Ordenar
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (vetor[i] < vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                Console.Write("[" + vetor[i] + "]");
            }*/






            //Atividade 10 vetor
            /*
            int[] vetorA = new int[10];
            int[] vetorB = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero para o vetor:");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (vetorA[i] == 0)
                    vetorB[i] = 2;
                else
                {
                    vetorB[i] = vetorA[i];
                }
            }
            Console.WriteLine("Vetor 01:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetorA[i] + "|");
            }
            Console.WriteLine("");
            Console.WriteLine("Vetor 02:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetorB[i] + "|");
            }*/




            //atividade 11 vetores
            /*
            int[] vetor = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero para o vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Normal:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(vetor[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Inverso:");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(vetor[i]);
            }*/






            //atividade 12 vetores
            /*
            int[] vetor = new int[10];
            int cont = 1;


            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o valor para o vetor:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Digite o valor que deseja pesquisar: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
               if (vetor[i] == num)
                {
                    Console.WriteLine("O numero " + num + " Foi encontrado na posição " + i);
                    cont = 0;
                }
            }   

            if ( cont != 0)
            {
                Console.WriteLine("Numero nao encontrado");
            }*/






            //atividade 13
            /*
            int cont = 1, cont2 = 0, cont4 = 0, cont8 = 0;
            int[] vetor = new int[100];

            while (cont < 100){
                Console.WriteLine("Digite o valor para a" + cont + "ª posição do vetor");
                vetor[cont] = int.Parse(Console.ReadLine());
                if (vetor[cont] == -1)
                {
                    Console.WriteLine("Programa encerrado");
                    
                        cont = 100;
                }
                else
                {
                    cont++;
                }
            }
            for (int i = 0; i < cont; i++)
            {
                if (vetor[i] == 2)
                {
                    cont2++;
                }
                if (vetor[i] == 4)
                {
                    cont4++;
                }
                if (vetor[i] == 8)
                {
                    cont8++;
                }
            }
            Console.WriteLine("O numero 2 foram digitadas " + cont2 + " vezes");
            Console.WriteLine("O numero 4 foram digitadas " + cont4 + " vezes");
            Console.WriteLine("O numero 8 foram digitadas " + cont8 + " vezes");
            */








            //atividade 15
            /*
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            int cont = 4;
           

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero para o vetor");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                vetorB[i] = vetorA[cont];
                cont--;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(vetorA[i]);
            }
            Console.WriteLine(" ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(vetorB[i]);
            }*/










            //atividade 16 vetores
            /*
            int[] vetorA = new int[5];
            int[] vetorB = new int[5];
            int[] uni = new int[5];
            int[] dif = new int[5];
            int[] inter = new int[5];
            int cont = 4;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero para o vetor");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero para o vetor");
                vetorB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                uni[i] = (vetorA[i] + vetorB[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                dif[i] = vetorA[i] - vetorB[i];
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"A diferença entre{vetorA[i]} e {vetorB[i]} é {dif[i]}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"A união do {vetorA[i]} e {vetorB[i]} é {uni[i]}");
            }
            */

        }
    }
}
