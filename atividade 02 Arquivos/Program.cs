
using System.Text;

namespace atividade02Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line, codigo, selecao, nome;
            int resp;
            Console.WriteLine("MENU:");
            Console.WriteLine("1- Cadastrar figurinhas repetidas");
            Console.WriteLine("2- Cadastrar figurinhas faltantes");
            Console.WriteLine("3- Listar figurinhas repetidas");
            Console.WriteLine("4- Listar figurinhas faltantes");
            Console.WriteLine("0- Para sair");
            resp = int.Parse(Console.ReadLine());


            while (resp != 0)
            {
                if (resp == 1)
                {
                    StreamWriter copa = new StreamWriter("C:\\copa\\repetida.csv", true, Encoding.UTF8);
                    Console.WriteLine("Digite o codigo da figurinha:");
                    codigo = Console.ReadLine();
                    Console.WriteLine("Digite a seleção da figurinha:");
                    selecao = Console.ReadLine();
                    Console.WriteLine("Digite o nome do jogador:");
                    nome = Console.ReadLine();
                    copa.WriteLine(codigo + ";" + selecao + ";" + nome + ";");
                    copa.Close();
                }

                if (resp == 2)
                {
                    StreamWriter copa = new StreamWriter("C:\\copa\\faltante.csv", true, Encoding.UTF8);
                    Console.WriteLine("Digite o codigo da figurinha:");
                    codigo = Console.ReadLine();
                    Console.WriteLine("Digite a seleção da figurinha:");
                    selecao = Console.ReadLine();
                    Console.WriteLine("Digite o nome do jogador:");
                    nome = Console.ReadLine();
                    copa.WriteLine(codigo + ";" + selecao + ";" + nome + ";");
                    copa.Close();
                }


                if (resp == 3)
                {
                    StreamReader copa = new StreamReader("C:\\copa\\repetida.csv");
                    line = copa.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = copa.ReadLine();
                    }

                }

                if (resp == 4)
                {
                    StreamReader copa = new StreamReader("C:\\copa\\faltante.csv");
                    line = copa.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = copa.ReadLine();
                    }

                }

                Console.WriteLine("MENU:");
                Console.WriteLine("1- Cadastrar figurinhas repetidas");
                Console.WriteLine("2- Cadastrar figurinhas faltantes");
                Console.WriteLine("3- Listar figurinhas repetidas");
                Console.WriteLine("4- Listar figurinhas faltantes");
                Console.WriteLine("0- Para sair");
                resp = int.Parse(Console.ReadLine());
            }

        }
    }
}