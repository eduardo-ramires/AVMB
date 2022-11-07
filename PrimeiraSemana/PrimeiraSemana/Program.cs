namespace PrimeiraSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade 01
            /*int num1, num2, num3, num4, media, count;

            count = 0;


            Console.WriteLine("Digite o primeiro numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero:");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero:");
            num4 = int.Parse(Console.ReadLine());

            media =(num1 + num2 + num3 + num4) / 4;

            if (num1 > media){
                Console.WriteLine("o numero " + num1 +" é maior que a media " + media);
            }

            else
            {
                count++;
            }


            if (num2 > media)
            {
                Console.WriteLine("o numero " + num2 +" é maior que a media " + media);
            }
            else
            {
                count++;
            }

            if (num3 > media)
            {
                Console.WriteLine("o numero " + num3 +" é maior que a media " + media);
            }
            else
            {
                count++;
            }

            if (num4 > media)
            {
                Console.WriteLine("o numero " + num4 +" é maior que a media " + media);
            }
            else
            {
                count++;
            }

            if (count == 4)
            {
                Console.WriteLine("Sem valores maiores que a media");
            }*/







            //atividade 02
            /*int horaA, horaB, valorA, valorB, somaA, somaB;

            Console.WriteLine("Digite a quantidade de horas do professor A:");
            horaA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas do professor B:");
            horaB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor por hora que o professor A recebe:");
            valorA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor por hora que o professor B recebe:");
            valorB = int.Parse(Console.ReadLine());

            somaA = horaA / valorA;
            somaB = horaB / valorB;

            if (somaA > somaB)
            {
                Console.WriteLine("O professor A recebe mais que o professor B");
            }

            if (somaB > somaA)
            {
                Console.WriteLine("O professor B recebe mais que o professor A");
            }

            if (somaA == somaB)
            {
                Console.WriteLine("O professor A e B recebem " + somaB);
            }*/






            //atividade 03
            /* int numdigitado, count;
            count = 0;

            Console.WriteLine("Digite um numero de 1 a 12:");
            numdigitado = int.Parse(Console.ReadLine());

            if (numdigitado > 12 || numdigitado < 1)
            {
                Console.WriteLine("O numero digitado é invalido");
            }

            if (numdigitado == 1)
            {
                Console.WriteLine("o numero que voce digitou representa Janeiro");
            }
          

            if (numdigitado == 2)
            {
                Console.WriteLine("o numero que voce digitou representa fevereiro");
            }
          

            if (numdigitado == 3)
            {
                Console.WriteLine("o numero que voce digitou representa março");
            }
        

            if (numdigitado == 4)
            {
                Console.WriteLine("o numero que voce digitou representa abril");
            }
            

            if (numdigitado == 5)
            {
                Console.WriteLine("o numero que voce digitou representa maio");
            }
           

            if (numdigitado == 6)
            {
                Console.WriteLine("o numero que voce digitou representa Junho");
            }

            if (numdigitado == 7)
            {
                Console.WriteLine("o numero que voce digitou representa Julho");
            }


            if (numdigitado == 8)
            {
                Console.WriteLine("o numero que voce digitou representa agosto");
            }



            if (numdigitado == 9)
            {
                Console.WriteLine("o numero que voce digitou representa setembro");
            }


            if (numdigitado == 10)
            {
                Console.WriteLine("o numero que voce digitou representa outubro");
            }

            if (numdigitado == 11)
            {
                Console.WriteLine("o numero que voce digitou representa novembro");
            }

            if (numdigitado == 12)
            {
                Console.WriteLine("o numero que voce digitou representa dezembro");
            }*/






            //ATIVIDADE 04  










            //atividade 05
            /*string letra;

            Console.WriteLine("digite uma letra:");
            letra = (Console.ReadLine());

            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine(  "A letra "+letra+" é uma vogal");
            }

            else
            {
                Console.WriteLine("A letra " + letra + " é uma consoante");
            }*/




            //atividade 06
            /*int hora, min, cont, seg;
            cont = 0;

            Console.WriteLine("Digite as hora:" );
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os minuto:" );
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os segundos" );
            seg = int.Parse(Console.ReadLine());

            if (hora >= 24)
            {
                Console.WriteLine("Digite uma hora valida");
            }
            else
            {
                cont++;
            }

            if (min >= 60)
            {
                Console.WriteLine("Digite um minuto valido");
            }
            else
            {
                cont++;
            }

            if (seg >= 60)
            {
                Console.WriteLine("Segundos invalidos");
            }
            else
            {
                cont++;
            }

            if (cont == 3)
            {
                Console.WriteLine("horario validado!");
            }*/








            //atividade 07
            /*int n, cont, total, soma;
            Console.WriteLine("Digite quantos integrantes tem sua familia:");
            n = int.Parse(Console.ReadLine());
            cont = n;
            total = 0;

            for (n = 1; n <= cont; n++)
            {
                Console.WriteLine("Digite a renda do "+ n + "º integrante");
                soma = int.Parse(Console.ReadLine());

                total = total + soma;
            }
            Console.WriteLine("A renda per capita desta familia é de aproximadamente: R$" + (total/cont));*/






            //atividade 08
            /*int  compra, cont;
            cont = 0;

            Console.WriteLine("Valor da compra:");
            compra = int.Parse(Console.ReadLine());

            if (compra <= 10)
            {
                Console.WriteLine("Você tera o lucro de 70% que corrresponde a " + (compra * 0.7) + " reais de lucro e o total da venda é de: " + (compra + (compra * 0.7)) + " Reais");
            }
            else
            {
                cont++;
            }

            if (compra <= 30 && compra > 10)
            {
                Console.WriteLine("Você tera o lucro de 70% que corrresponde a " + (compra * 0.5) + " reais de lucro e o total da venda é de: " + (compra + (compra * 0.5)) + " Reais");
            }
            else
            {
                cont++;
            }

            if (compra <= 50 && compra > 30)
            {
                Console.WriteLine("Você tera o lucro de 70% que corrresponde a " + (compra * 0.4) + " reais de lucro e o total da venda é de: " + (compra + (compra * 0.4)) + "Reais");
            }
            else
            {
                cont++;
            }

            if (compra > 50 && compra > 30)
            {
                Console.WriteLine("Você tera o lucro de 70% que corrresponde a " + (compra * 0.3) + " reais de lucro e o total da venda é de: " + (compra + (compra * 0.3)) + "Reais");
            }
            else
            {
                cont++;
            }

            if (cont == 4)
            {
                Console.WriteLine("Valor invalido");
            }*/






            //atividade 09
            /*float a, b, c, count ;

            count = 0;

            Console.WriteLine("Digite o lado A do triangulo:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado B do triangulo:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado C do triangulo:");
            c = int.Parse(Console.ReadLine());

            if (c > (a+b) || b > (a + c) || a > (c + b))
            {
                Console.WriteLine("Os lados não podem formar um triangulo");

            }
            else
            {
                Console.WriteLine("Os lados podem formar um triangulo e pode formar um triangulo:");

                if (a == b && b == c)
                {
                    Console.WriteLine("EQUILATERO");
                }
                else
                {
                    count++;
                }

                if (a != b && b != c)
                {
                    Console.WriteLine("ESCALENO");
                }
                else
                {
                    count++;
                }

                if (count == 2)
                {
                    Console.WriteLine("ISOCELES");
                }*/



            //atvidade 10
            /*
            float num;
            Console.WriteLine("Digite um numero para ver a tabuada");
            num = float.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num * i));
            }*/





            //atividade 11
            /*
            for (int i = 1000; i < 2000; i++)
            {
                if (i % 11 == 5)
                {
                    Console.WriteLine(i);
                }
            }*/




            //atividade 12
            /*int a, b, i, total;

            total = 0;

            Console.WriteLine("Digite o valor A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor B:");
            b = int.Parse(Console.ReadLine());

            if ( a > b)
            {
                for (i = b; i <= a; i++)
                {
                    if (i % 2 == 0)
                    {
                        total = total + i;
                    }
                }
                Console.WriteLine("A soma de todos os pares da: "+ total);
            }

            if (b > a)
            {
                for (i = a; i <= b; i++)
                {
                    if (i % 2 == 0)
                    {
                        total = total + i;
                    }
                }
                Console.WriteLine("A soma de todos os pares da: " + total);
            }*/






            //atividade 13
            /*int a, i, f, cont;

            Console.WriteLine("digite o valor inicial da contagem:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor final da contagem:");
            f = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 caso queira pular os valores impares, 2 para pular os pares ou 0 se nao quiser pular os valor");
            a = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                for (cont = i; cont <= f; cont++)
                {
                    Console.WriteLine(cont);
                }
            }

            if (a == 1)
            {
                for (cont = i; cont <= f; cont++)
                {
                    if (cont % 2 == 1)
                    {

                        Console.WriteLine(cont);
                    }
                }
            }

            if (a == 2)
            {
                for (cont = i; cont <= f; cont++)
                {
                    if (cont % 2 == 0)
                    {

                        Console.WriteLine(cont);
                    }
                }
            }*/







            //atividade 14
            /*float i;

            for (i=20; i > 0; i--)
            {
                Console.WriteLine( "2,54 X" + i +" = " + i * 2.54);
            }*/







            //atividade 15 e 16
            /*int i, f, cont, pergunta;

            Console.WriteLine("Digite o valor inicial da contagem:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor final da contagem:");
            f = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 se quer a contagem em modo decrescente e 2 para ordem crescente:");
            pergunta = int.Parse(Console.ReadLine());

            if (pergunta == 1)
            {
                for (cont = f; cont > i; cont--)
                {
                    Console.WriteLine(cont);
                }
            }

            if (pergunta == 2)
            {
                for (cont = i; cont < f; cont++)
                {
                    Console.WriteLine(cont);
                }
            }*/






            //atividade 17:
            /* int a;

            for (a = 0; a < 10; a++)
            {
                
                if (a == 5)
                {
                    break
                }

            Console.WriteLine("Volta numero: " + a); */






            //atividade 18
            /* int a;

            for (a = 0; a < 10; a++)
            {
                
                if ( a == 5 || a == 7)
                {
                    Console.WriteLine("continue");
                    continue;

                }

            Console.WriteLine("Volta numero: " + a); */





            //atividade 19
            /*float i = 1, soma= 1000, a = 1000;

            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0 && i != 1)
                {
                    Console.WriteLine(a + "/" + i + "=" );
                    soma =soma -  (a / i);
                    Console.WriteLine(soma);
                }

                if (i % 2 == 1 && i != 1)
                {
                    Console.WriteLine(a + "/" + i + "=");
                    soma = soma +(a / i) ;
                    Console.WriteLine(soma);
                }
                a = a - 3;

            }
            Console.WriteLine(a);*/





            //atividade 20
            /*int n, cont, i;
            cont = 0;

            Console.WriteLine("Digite um numero:");
            n = int.Parse(Console.ReadLine());
            
            for (i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }            
            }

            if (cont == 1 && n != 1)
            {
                Console.WriteLine("O numero "+n+" é primo");
            }

            if (cont > 1 || n == 1)
            {
                Console.WriteLine("O numero " + n+ " não é primo");
            }*/
        }
    }
}