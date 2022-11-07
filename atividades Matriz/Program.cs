namespace atividades_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividades 01 matriz:
            /*int[,] matriz = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite um numero:");
                matriz[i, 0] = int.Parse(Console.ReadLine());
                matriz[i, 1] = matriz[i, 0] + 10;
                matriz[i, 2] = matriz[i, 0] * 2;

                Console.WriteLine(matriz[i, 0] + "-" +  matriz[i, 1] + "-" + matriz[i, 2]);
            }*/







            //atividade 02 matriz:
            /*int somaColuna = 0, somaLinha1 = 0, somaLinha2 = 0, somaLinha3 = 0;

            int[,] matriz = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine("Digite um numero para: " + i + " , " + y);
                    matriz[i, y] = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        somaLinha1 = somaLinha1 + matriz[0, y];
                    }
                    if (i == 1)
                    {
                        somaLinha2 = somaLinha2 + matriz[1, y];
                    }
                    if (i == 2)
                    {
                        somaLinha3 = somaLinha3 + matriz[2, y];
                    }
                }
            }
            Console.WriteLine(somaLinha1 +"-"+ somaLinha2 +"-" + somaLinha3);*/






            //Atividade 03 matriz
            /*int[,] matriz = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.WriteLine("Digite um numero:");
                    matriz[i, a] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    if (i == a)
                    {
                        Console.WriteLine("Resultado:");
                        Console.WriteLine(matriz[i, a]);
                    }
                }
                
            }*/







            //Atividade 04 matriz
            /*int par = 0, impar = 0, neg = 0, positivo = 0, zero = 0;

            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.WriteLine("Digite um numero:");
                    matriz[i, a] = int.Parse(Console.ReadLine());
                    if (matriz[i, a] % 2 == 0)
                    {
                        par++;
                    }
                    if (matriz[i, a] % 2 == 1 || matriz[i, a] % 2 == -1)
                    {
                        impar++;
                    }
                    if (matriz[i, a] >  0)
                    {
                        positivo++;
                    }
                    if (matriz[i, a]  < 0)
                    {
                        neg++;
                    }
                    if (matriz[i, a] == 0)
                    {
                        zero++;
                    }
                }
            }
            Console.WriteLine(par + "Numeros são pares" );
            Console.WriteLine(impar + "Numeros são impares" );
            Console.WriteLine(positivo + "Numeros são positivos" );
            Console.WriteLine(neg + "Numeros são negativos" );
            Console.WriteLine(zero + "Numeros são zero" );*/







            //atividade 05 matriz:
            /*double soma=0 , somaA= 0, somaB = 0;

            double[,] matrizA = new double[2, 3];
            double[,] matrizB = new double[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine("Digite:");
                    matrizA[i, a] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    somaA =somaA + matrizA[i, a];

                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine("Digite:");
                    matrizB[i, a] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    somaA =somaA + matrizB[i, a];

                }
            }
            Console.WriteLine(somaA);*/







            //atividade 06 matriz:

            /*Random random = new Random();
            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    int randomNumber = random.Next(0, 9);
                    matriz[i, a] = randomNumber;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(matriz[i,a] + " ");
                }
                Console.WriteLine(" ");
            }

            int num = matriz[0, 0];

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    if (matriz[i, a] > num)
                    {
                        num = matriz[i, a];
                    }
                }
            }
            Console.WriteLine("O maior numero é o: " + num);*/







            //atividade 07 matriz:
            /*int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine("Digite um numero para variavel A:");
                    matrizA[i, a] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine("Digite um numero para variavel B:");
                    matrizB[i, a] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    matrizC[i, a] = (matrizA[i, a] - matrizB[i, a]);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.Write(matrizA[i, a] + " ");
                }
                Console.WriteLine(" ");
            }
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.Write(matrizB[i, a] + " ");
                }
                Console.WriteLine(" ");
            }
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.Write(matrizC[i, a] + " ");
                }
                Console.WriteLine(" ");
            }*/










            //atividade 08 matriz;

            /*int[,] matriz = new int[4, 4];


                for (int i = 0; i < 4; i++)
                {
                    for (int a = 0; a < 4; a++)
                    {
                        Console.WriteLine("Digite um numero:");
                        matriz[i, a] = int.Parse(Console.ReadLine());
                    }
                }

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(matriz[i, a] +"|");                
                }
                Console.WriteLine(" ");
                Console.WriteLine("--------------------");
            }
            for (int i = 3; i >= 0; i--)
            {
                for (int a = 3; a >= 0; a--)
                {
                    Console.Write(matriz[i, a] + "|");
                }
                Console.WriteLine(" ");
                Console.WriteLine("--------------------");
            }*/









            //atividade 09 matrizes:
            /*int num, cont = 0;
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine("Digite um numero:");
                    matriz[i, a] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.Write(matriz[i, a]+ "|");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("Digite um numero para pesquisa:");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    if (matriz[i, a] == num)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("O numero que voce digitou aparece " + cont + " vezes na matriz");*/







            //atividade 10 matrizes:
            /*double soma= 0, num = 0, cont = 0;
            double[,] matrizA = new double[2, 2];
            double[,] matrizB = new double[2, 2];
            
            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                    Console.WriteLine("Digite um numero para a matriz A");
                    matrizA[i, a] = int.Parse(Console.ReadLine());
                    soma = soma + matrizA[i, a];
                    cont++;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                    Console.WriteLine("Digite um numero para a matriz A");
                    matrizB[i, a] = int.Parse(Console.ReadLine());
                    soma = soma + matrizA[i, a];
                    cont++;
                }
            }
            soma = soma / cont;

            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                   if (matrizA[i, a] > soma)
                    {
                        Console.WriteLine(" o numero " + matrizA[i, a] + " é maior que a media, que é " + soma);
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                    if (matrizB[i, a] > soma)
                    {
                        Console.WriteLine(" o numero " + matrizB[i, a] + " é maior que a media, que é " + soma);
                    }
                }
            }*/







            //atividade 11 matrizes:
            /*float soma = 0;
            float[,] matrizA = new float[3, 3];
            float[,] matrizB = new float[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine("Digite um numero para matriz A");
                    matrizA[i, a] = float.Parse(Console.ReadLine()); 
                    if (i ==0 && a == 0)
                    {
                        matrizB[i, a] = matrizA[i, a];
                    }
                    else {
                        soma = i + a;
                        matrizB[i, a] = matrizA[i, a] / soma;
                    }
                    
                    soma = 0;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.Write(matrizB[i, a] + "|");
                }
                Console.WriteLine(" ");
            }*/








            //atividade 12 matrizes:
            /*int[,] matriz = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.WriteLine("Digite um valor:");
                    matriz[i, a] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    Console.Write(matriz[i, a] + "|");
                }
                Console.WriteLine(" ");
            }

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 3; a++)
                {
                    if ((i + a) % 2 == 0)
                    {
                        Console.WriteLine(matriz[i, a]);
                    }
                }
            }*/







            //atividade 13
            /*
            int i, j;
            int[,] A = new int[5, 5];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("Digite um numero para a matriz");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int diagonal_principal = A[0, 0] + A[1, 1] + A[2, 2] + A[3, 3] + A[4, 4];
            int diagonal_secundaria = A[0, 4] + A[1, 3] + A[2, 2] + A[3, 1] + A[4, 0];
            if (diagonal_principal == diagonal_secundaria)
            {
                Console.WriteLine("A soma dos elementos da diagonal principal É igual a soma dos elementos da diagonal secundária");
            }
            else
            {
                Console.WriteLine("A soma dos elementos da diagonal principal NÃO É igual a soma dos elementos da diagonal secundária");
            }*/







            //atividade 14
            /*
            int i, j, tam = 5;
            int[,] A = new int[5, 5];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++) {
                    Console.WriteLine("Digite um numero para a matriz");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int valor = 0;
            for (i = 0; i < 5; i++)
            {
                if (A[i, i] == A[i, tam - 1 - i])
                {
                    valor = 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
            if (valor == 1)
            {
                Console.WriteLine("Os elementos da diagonal principal são iguais aos elementos da diagonal secundária");
            }
            else
            {
                Console.WriteLine("Os elementos da diagonal principal NÃO são iguais aos elementos da diagonal secundária");
            }
            */







            //matrizes 15
            /*
            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int[,] matrizC = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.WriteLine("Digite um numero para variavel A:");
                    matrizA[i, a] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.WriteLine("Digite um numero para variavel B:");
                    matrizB[i, a] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    matrizC[i, a] = (matrizA[i, a] + matrizB[i, a]);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(matrizA[i, a] + " ");
                }
                Console.WriteLine(" ");
            }
            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(matrizB[i, a] + " ");
                }
                Console.WriteLine(" ");
            }
            for (int i = 0; i < 4; i++)
            {
                for (int a = 0; a < 4; a++)
                {
                    Console.Write(matrizC[i, a] + " ");
                }
                Console.WriteLine(" ");
            }*/




            //atividade  matrizes 16
            /*
            int i, j, num = 1;
            int[,] A = new int[3, 4];
            int[,] B = new int[4, 3];
            Console.WriteLine("Matriz A[3, 4]");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    A[i, j] = num++;
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
            Console.WriteLine("Matriz B[4, 3]");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    B[i, j] = A[j, i];
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine(" ");
            }*/
        }
    }
}