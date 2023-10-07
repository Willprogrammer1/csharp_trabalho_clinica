using System;

namespace terminal_clinica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Médicos
            string nomeProfissional;
            string especialidadeProfissional;
            int tempoExperiencia;


            Console.WriteLine("Quantos médicos que trabalham na clınica");
            int numerosProfissionais = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numerosProfissionais; i++)
            {
                Console.WriteLine($"Qual o nome profissional {i}?");
                nomeProfissional = Console.ReadLine();

                Console.WriteLine($"Qual a especialidade de {nomeProfissional}?");
                especialidadeProfissional = Console.ReadLine();

                Console.WriteLine($"Qual o tempo de experiência de {nomeProfissional}?");
                tempoExperiencia = int.Parse(Console.ReadLine());

            }
        }
    }
}
