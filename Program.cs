using System;
using System.IO;
namespace aula1110
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;

            if (!File.Exists("./perguntas.txt"))
            {
                Console.WriteLine("Arquivo 'perguntas' não existe. Criar? 1 para sim, qualquer outro valor para não");
                if (Console.ReadLine() == "1")
                {
                    using(sw = new StreamWriter("./Perguntas.txt", true))
                    {
                        Console.WriteLine("Vai escrevendo. Não digitar nada sai");
                        string aux = Console.ReadLine();
                        if(aux != "")
                            do
                            {
                                aux = Console.ReadLine();
                                sw.WriteLine(aux);
                            } while(aux != "");
                    }
                }else{
                    return;
                }                
            }

            string[] perguntas = File.ReadAllLines("./perguntas.txt");
            sw = new  StreamWriter("./respostas.csv", true);

            for(int i = 0; i < perguntas.Length; i++)
            {
                Console.WriteLine("insira " + perguntas[i] + ":");
                sw.Write(Console.ReadLine() +";");
            }           

            sw.Close();
        }
    }
}
